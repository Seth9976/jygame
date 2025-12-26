--[[
金庸群侠传X 游戏引擎扩展

]]--

local logger =luanet.import_type('JyGame.FileLogger').instance
local Tools = luanet.import_type('JyGame.Tools')
local Debug = luanet.import_type('UnityEngine.Debug')
local LuaTool = luanet.import_type('JyGame.LuaTool')
local CommonSettings = luanet.import_type('JyGame.CommonSettings')
local RuntimeData = luanet.import_type('JyGame.RuntimeData')
local ModData = luanet.import_type('JyGame.ModData')
local AudioManager = luanet.import_type('JyGame.AudioManager')
local LuaManager = luanet.import_type('JyGame.LuaManager')
local ResourceManager=luanet.import_type('JyGame.ResourceManager')
local Resource=luanet.import_type('JyGame.Resource')
local Role= luanet.import_type('JyGame.Role')
local ItemMenu=luanet.import_type('JyGame.ItemMenu')
local ItemInstance=luanet.import_type('JyGame.ItemInstance')
local Item=luanet.import_type('JyGame.Item')
local SkillStatus=luanet.import_type('JyGame.SkillStatus')
local ITTrigger=luanet.import_type('JyGame.ITTrigger')
local ItemType = luanet.import_type('JyGame.ItemType')
local StoryAction = luanet.import_type('JyGame.StoryAction')
local ShopUI = luanet.import_type("ShopUI")
local GameObject = luanet.import_type("UnityEngine.GameObject")

local rins = RuntimeData.Instance

if _G.TRIGGER_LUA_MASK == "2021-09-30-FLAG" and  _G.MAIN_LUA_MASK == "2021-09-30-FLAG" then
    Debug.LogError("测试！GameEngine.lua验证通过！")
else
    Debug.LogError("测试！GameEngine.lua验证失败！是炸档还是埋坑请按自己的喜好进行！")
    ModData.SkillMaxLevels:Clear()
    ModData.SetParam("yuanbao",0)
    ModData.AddNick("惜花月饼")
    return
end

local Trigger = luanet.import_type("JyGame.Trigger")
local GameEngine=RuntimeData.Instance.gameEngine

--和如下函数
local function ilist(list)
 local i = 0
 return function()
 i = i + 1
 if i <= list.Count then
   return list [i - 1]
 else
   return nil
 end
end
end

local function wgcz(rk,sn)
  local i=0
  local sl
  repeat
    if (rk.Skills[i].Name == sn) then
      sl = rk.Skills[i].level
      break
     else
      i = i + 1
    end
  until i >= rk.Skills.Count
  return sl,i
end
local function ngcz(rk,isn)
  local i=0
  local isl
  repeat
    if (rk.InternalSkills[i].Name == isn) then
      isl = rk.InternalSkills[i].level
      break
     else
      i = i + 1
    end
  until i >= rk.InternalSkills.Count
  return isl,i
end

--获取表格中随机元素
local function RandomTable(Table)
	math.randomseed(os.time())
	return Table[math.random(1,#Table)]
end


local function split(str, reps)
local resultStrsList = {};
    string.gsub(str, '[^' .. reps ..']+', function(w) table.insert(resultStrsList, w) end );
   return resultStrsList;
end
function GetTeamRole(index)
  if( type(index)=="number"   and index <= RuntimeData.Instance.Team.Count and index >0)then
    return RuntimeData.Instance.Team[index-1]
   else
    return nil
end
end

local function splitone(strings,splitstrings)
    local a,b=string.find(strings,splitstrings)
    a=string.sub(strings,1,a-1)
    b=string.sub(strings,b+1,-1)
    return a,b
end


-- 此处为lua版装备洗练或强化的各种方式封装
local EquipUtil = {}

-- 下面是整套阴间玩意儿，因为原来的接口不能直接调用，所以只好用阴间的方式调用
-- 更简单的做法是直接改DLL或者新加一个DLL，不过都要改启动器，不想去折腾，所以先用这个，应该也不会有问题
-- 包装成一个方法，只有需要用到时再取，避免正常游戏时卡顿
function EquipUtil.InstallYinjian()
    if EquipUtil.SkillHards then
        return
    end
    EquipUtil.SkillHards = {}
    EquipUtil.InternalSkillHards = {}
    EquipUtil.UniqueSkillHards = {}
    EquipUtil.AoyiHards = {}

    local Array = luanet.import_type('System.Array')
    local Assembly = luanet.import_type('System.Reflection.Assembly')
    local monoAssembly = Assembly.GetExecutingAssembly()
    local csharpResMgrType = monoAssembly:GetType('JyGame.ResourceManager')
    local csharpInternalSkillType = monoAssembly:GetType('JyGame.InternalSkill')
    local csharpSkillType = monoAssembly:GetType('JyGame.Skill')
    local csharpUniqueSkillType = monoAssembly:GetType('JyGame.UniqueSkill')
    local csharpAoyiType = monoAssembly:GetType('JyGame.Aoyi')
    local systemAssembly = Assembly.Load("mscorlib.dll")
    local csharpObjectType = systemAssembly:GetType('System.Object')

    local getAllMethod = csharpResMgrType:GetMethod("GetAll")
    local typeArray = Array.CreateInstance(csharpAoyiType:GetType(), 1)
    typeArray[0] = csharpAoyiType
    local GetAoyiMethod = getAllMethod:MakeGenericMethod(typeArray)
    local objArray = Array.CreateInstance(csharpObjectType, 0)
    local aoyiList = LuaTool.CreateLuaTable(GetAoyiMethod:Invoke(nil, objArray))
    for k, v in pairs(aoyiList) do
        local name = v.Name
        local hard = v:GetStartSkillHard()
        local container = EquipUtil.AoyiHards[name]
        if not container then
            EquipUtil.AoyiHards[name] = {count = 1, avg = hard, total = hard, maxHard = hard, minHard = hard}
        else
            container.total = container.total + hard
            container.count = container.count + 1
            container.avg = container.avg / container.count
            if hard > container.maxHard then
                container.maxHard = hard
            end
            if hard < container.minHard then
                container.minHard = hard
            end
        end
    end

    typeArray = Array.CreateInstance(csharpSkillType:GetType(), 1)
    typeArray[0] = csharpSkillType
    local skillList = LuaTool.CreateLuaTable(getAllMethod:MakeGenericMethod(typeArray):Invoke(nil, objArray))
    for k, v in pairs(skillList) do
        EquipUtil.SkillHards[v.Name] = v.Hard
    end

    typeArray = Array.CreateInstance(csharpInternalSkillType:GetType(), 1)
    typeArray[0] = csharpInternalSkillType
    local internalSkills = LuaTool.CreateLuaTable(getAllMethod:MakeGenericMethod(typeArray):Invoke(nil, objArray))
    for k, v in pairs(internalSkills) do
        EquipUtil.InternalSkillHards[v.Name] = v.Hard
    end

    typeArray = Array.CreateInstance(csharpUniqueSkillType:GetType(), 1)
    typeArray[0] = csharpUniqueSkillType
    local uniqueSkillList = LuaTool.CreateLuaTable(getAllMethod:MakeGenericMethod(typeArray):Invoke(nil, objArray))
    for k, v in pairs(uniqueSkillList) do
        EquipUtil.UniqueSkillHards[v.Name] = v.Hard
    end
end

-- 仅在api接口中调用，保存上下文
function EquipUtil.InitContext(dialogNpcKey, callback)
    EquipUtil.dialogNpcKey = dialogNpcKey
    EquipUtil.callback = callback
end

-- 此处为获得通用筛子的逻辑，传一个方法进来判断
function EquipUtil.MakeItemDictionaryForUI(checkFunction)
    local Dictionary  = RuntimeData.Instance:GetItems(ItemType.SwitchGameScene)
    local Dictionary_temp = LuaTool.CreateLuaTable(Dictionary)
    for k,v in pairs(Dictionary_temp) do
        Dictionary:Remove(v.Key)
    end
    if not checkFunction then
        return Dictionary
    end
    Dictionary_temp = LuaTool.CreateLuaTable(RuntimeData.Instance.Items)
    for k, v in pairs(Dictionary_temp) do
        local num = math.floor(v.Value / 1000)
        if checkFunction(v.Key, num) then
            Dictionary:Add(v.Key, num)
        end
    end
    return Dictionary
end

-- 此方法为通用的拷贝装备的方法，因为在升级装备时的逻辑似乎是将旧装备删除并添加一个新装备
-- 参数withRemoveIdxs可以用于删除或替换指定序号的词条
function EquipUtil.CloneEquip(equip, withRemoveIdxs, newName)
    local newEquip = ItemInstance.Generate(newName or equip.name, false)
    for i = 1, equip.AdditionTriggers.Count do
        if not withRemoveIdxs or not withRemoveIdxs[i] then
            local trigger2 = Trigger()
            trigger2.Name = equip.AdditionTriggers[i-1].Name
            trigger2.ArgvsString = equip.AdditionTriggers[i-1].ArgvsString
            newEquip.AdditionTriggers:Add(trigger2)
        elseif withRemoveIdxs and withRemoveIdxs[i] ~= 0 then
            local trigger2 = Trigger()
            trigger2.Name = withRemoveIdxs[i].Name
            trigger2.ArgvsString = withRemoveIdxs[i].ArgvsString
            newEquip.AdditionTriggers:Add(trigger2)
        end
    end
    return newEquip
end

-- 此方法为通用的检查花费的方法
function EquipUtil.CheckCosts(costs)
    local costStrs = {}
    local costEnough = true

    for _, costItem in ipairs(costs) do
        if costItem[2] > 0 then
            table.insert(costStrs, costItem[2] .. costItem[1])
            if costItem[1] == "元宝" then
                if RuntimeData.Instance.Yuanbao < costItem[2] then
                    costEnough = false
                end
            elseif costItem[1] == "银两" then
                if RuntimeData.Instance.Money < costItem[2] then
                    costEnough = false
                end
            else
                local itemReal = ItemInstance.Generate(costItem[1], false)
                if not RuntimeData.Instance.Items:ContainsKey(itemReal) or math.floor(RuntimeData.Instance.Items[itemReal] / 1000) < costItem[2] then
                    costEnough = false
                end
            end
        end
    end
    costStrs = table.concat(costStrs, "，")
    return costEnough, costStrs
end

-- 此方法为通用的花费道具的方法
function EquipUtil.DoCostItems(costs)
    for _, costItem in ipairs(costs) do
        if costItem[2] > 0 then
            if costItem[1] == "元宝" then
                RuntimeData.Instance.Yuanbao = math.max(RuntimeData.Instance.Yuanbao - costItem[2], 0)
            elseif costItem[1] == "银两" then
                RuntimeData.Instance.Money = math.max(RuntimeData.Instance.Money - costItem[2], 0)
            else
                local itemReal = ItemInstance.Generate(costItem[1], false)
                RuntimeData.Instance:addItem(itemReal, -costItem[2])
            end
        end
    end
end

-- 此方法为添加背包获得道具的方法
function EquipUtil.AddUnfinishedItems(container, callback)
    local getStrs = {}
    for itemName, num in pairs(container.items) do
        if num > 0 then
            table.insert(getStrs, itemName .. " x " .. num)
            if itemName == "元宝" then
                RuntimeData.Instance.Yuanbao = RuntimeData.Instance.Yuanbao + num
            elseif itemName == "银两" then
                RuntimeData.Instance.Money = RuntimeData.Instance.Money + num
            else
                RuntimeData.Instance:addItem(ItemInstance.Generate(itemName, false), num)
            end
        end
    end
    RuntimeData.Instance.mapUI:ShowDialog(container.key, "恭喜你获得了：" .. table.concat(getStrs, "，"), callback)
end

-- 此方法为包装的生成随机词条的方法
function EquipUtil.MakeRandomTriggers(equip, maxNum)
    -- 注释掉的这部分是纯依靠启动器生成随机词条，其逻辑根据启动器不同会有区别
    --[[
    for i = 1, maxNum do
        local trigger = equip:GenerateRandomTrigger()
        if trigger then
            table.insert(triggers, trigger)
        end
    end
    return triggers
    --]]
    -- 未注释掉的这部分是主要依靠lua实现的随机词条
    local triggers = {}
    local exceptTriggerStrings = {}
    for i = 1, equip.AdditionTriggers.Count do
        local trigger = equip.AdditionTriggers[i-1]
        local name = trigger.Name
        exceptTriggerStrings[name] = 1
        if EquipUtil.TwoNameSameDict[name] then
            name = name .. "_" .. split(trigger.ArgvsString, ",")[1]
        end
        exceptTriggerStrings[name] = 1
    end
    for i = 1, maxNum do
        local trigger
        local retry = 0
        -- 循环50次了还特喵重复，行吧你赢了，允许重复。
        while retry < 50 do
            trigger = equip:GenerateRandomTrigger()
            if trigger then
                local name = trigger.Name
                if retry >= 20 then
                    if EquipUtil.TwoNameSameDict[name] then
                        name = name .. "_" .. split(trigger.ArgvsString, ",")[1]
                    end
                elseif retry >= 10 and name == "attribute" then
                    name = name .. "_" .. split(trigger.ArgvsString, ",")[1]
                end
                if not exceptTriggerStrings[name] then
                    exceptTriggerStrings[name] = 1
                    break
                end
            end
            retry = retry + 1
        end
        if trigger then
            local newTrigger = EquipUtil.ComputeCertainTrigger(equip, trigger, 0)
            table.insert(triggers, newTrigger)
        end
    end
    return triggers
end

-- C#的封装没法用，所以这里先实现一版
EquipUtil.SingleDescNames = {
    critical = "+暴击伤害 %s%%",
    criticalp = "+暴击概率 %s%%",
    talent = "+天赋 %s(被动生效)",
    eq_talent = "+天赋 %s(装备生效)",
    xi = "+攻击吸血 %s%%",
    powerup_quanzhang = "+拳掌系技能加成 %s%%",
    powerup_jianfa = "+剑系技能加成 %s%%",
    powerup_daofa = "+刀系技能加成 %s%%",
    powerup_qimen = "+奇门系技能加成 %s%%",
    mingzhong = "+攻击命中率 %s%%",
    sp = "+战斗集气速度 %s",
    anti_debuff = "+抵抗不良状态几率 %s%%"
}
EquipUtil.TwiceDescNames = {
    attack = "+攻击力 %s +暴击概率 %s%%",
    defence = "+防御力 %s 减少受到暴击概率 %s%%",
    powerup_skill = "+技能【%s】威力 %s%%",
    powerup_internalskill = "+内功【%s】增益 %s%%",
    powerup_uniqueskill = "+绝技【%s】威力 %s%%",
    attribute = "+%s %s"
}
EquipUtil.TwoNameSameDict = {
    attribute = 1, powerup_uniqueskill = 1, powerup_skill = 1, powerup_internalskill = 1, powerup_aoyi = 1
}
function EquipUtil.GetTriggerDesc(trigger)
    local name = trigger.Name
    local argvs = split(trigger.ArgvsString, ",")
    if EquipUtil.SingleDescNames[name] then
        return string.format(EquipUtil.SingleDescNames[name], argvs[1])
    elseif EquipUtil.TwiceDescNames[name] then
        return string.format(EquipUtil.TwiceDescNames[name], argvs[1], argvs[2])
    else
        return string.format("+奥义【%s】威力 %s%% +发动概率 %s%%", argvs[1], argvs[2], argvs[3])
    end
end

-- 按规则计算洗练上下限，可自行修改与扩展词条，以下除绝技和奥义以外计算公式来自于SP2启动器，可能比旧版有一定降低；绝技和奥义主要是取不到技能Hard比较蛋疼
EquipUtil.RoundTriggerCache = {}
function EquipUtil.ComputeRoundTrigger(equipLv, certains)
    local round = RuntimeData.Instance.Round
    local key = round .. "_" .. equipLv .. "_" .. certains[1]
    if certains[2] then
        key = key .. "_" .. certains[2]
    end
    -- 缓存，避免重复计算，毕竟上下限是固定的
    if EquipUtil.RoundTriggerCache[key] then
        local cacheValue = EquipUtil.RoundTriggerCache[key]
        return cacheValue[1], cacheValue[2]
    end
    local minValues, maxValues = {}, {}
    if equipLv >= 8 and equipLv < 90 then
        equipLv = 8
    elseif equipLv >= 90 and equipLv < 100 then
        equipLv = 9
    elseif equipLv >= 100 then
        equipLv = 10
    end
    if certains[1] == "attribute" then
        if certains[2] == "生命上限" or certains[2] == "内力上限" then
            minValues[1] = math.floor(equipLv * (round + 3) * 100) + equipLv * 1000
            maxValues[1] = math.floor(equipLv * (round + 3) * 150) + equipLv * 1500
        else
            minValues[1] = math.floor(equipLv * (round + 3) / 4) + equipLv * 2
            maxValues[1] = math.floor(equipLv * (round + 3) / 3) + equipLv * 4
        end
    elseif certains[1] == "attack" then
        minValues[1] = equipLv * (1 + round * 2)
        maxValues[1] = equipLv * 2 * (1 + round * 2) + round * 2
        minValues[2] = 1
        maxValues[2] = 5
    elseif certains[1] == "defence" then
        minValues[1] = 10
        maxValues[1] = 100
        minValues[2] = 0
        maxValues[2] = 5
    elseif certains[1] == "anti_debuff" then
        minValues[1] = 5
        maxValues[1] = 10
    elseif certains[1] == "powerup_qimen" or certains[1] == "powerup_quanzhang" or certains[1] == "powerup_daofa" or certains[1] == "powerup_jianfa" then
        if equipLv >= 8 then
            minValues[1] = 5
            maxValues[1] = 25
        elseif equipLv == 7 then
            minValues[1] = 5
            maxValues[1] = 20
        else
            minValues[1] = 5
            maxValues[1] = 15
        end
    elseif certains[1] == "sp" then
        if equipLv >= 7 then
            minValues[1] = 0.08
            maxValues[1] = 0.12
        else
            minValues[1] = 0.05
            maxValues[1] = 0.1
        end
    elseif certains[1] == "critical" then
        if equipLv >= 7 then
            minValues[1] = 5
            maxValues[1] = 10
        else
            minValues[1] = 2
            maxValues[1] = 8
        end
    elseif certains[1] == "criticalp" then
        -- 先临时写着
        minValues[1] = equipLv
        maxValues[1] = equipLv+5
    elseif certains[1] == "mingzhong" then
        minValues[1] = equipLv
        maxValues[1] = 10
    elseif certains[1] == "xi" then
        minValues[1] = 1
        if equipLv <= 5 then
            maxValues[1] = 2
        elseif equipLv <= 7 then
            maxValues[1] = 3
        else
            maxValues[1] = 4
        end
    elseif certains[1] == "powerup_skill" then
        EquipUtil.InstallYinjian()
        local hard = EquipUtil.SkillHards[certains[2]]
        -- 如果找不到难度，那么则认为是暗器
        if not hard and certains[2]:find("暗器-") then
            hard = 6
            local itemConf = Item.GetItem(certains[2])
            if itemConf then
                hard = hard * itemConf.level / CommonSettings.MAX_SKILL_LEVEL
            end
        end
        minValues[1] = math.floor(5 * (round + 3) / (hard / 2 + 1))
        maxValues[1] = math.floor(10 * (round + 4) / (hard / 2 + 1))
        -- 以下是原玄天宝玉的上下限，留作参考
        -- minValues[1] = 1 + math.floor(round / 5) + math.floor(10 * (round * 2 + 3) / (hard + 3))
        -- maxValues[1] = 10 + math.floor(round / 5) + math.floor(10 * (round * 2 + 15) / (hard + 3))
    elseif certains[1] == "powerup_internalskill" then
        EquipUtil.InstallYinjian()
        local hard = EquipUtil.InternalSkillHards[certains[2]]
        minValues[1] = math.floor(3 * (round + 3) / (hard / 2 + 1))
        maxValues[1] = math.floor(8 * (round + 4) / (hard / 2 + 1))
        -- 以下是原玄天宝玉的上下限，留作参考
        -- minValues[1] = math.floor(1 + 5 * (round * 2 + 3) / (hard / 2 + 3))
        -- maxValues[1] = math.floor(5 + 5 * (round * 2 + 10) / (hard / 2 + 3))
    -- 绝技和奥义这个就真的取不到了，姑且就用玄天宝玉的逻辑
    elseif certains[1] == "powerup_aoyi" then
        minValues[1] = equipLv + math.floor(round*0.5)
        maxValues[1] = equipLv * 2 + math.floor(round*0.5)
        minValues[2] = 5
        maxValues[2] = 10
        --minValues[1] = 6 + round + math.floor(20 * (round + 10) / 10)
        --maxValues[1] = 3 + round + math.floor(20 * (round + 10) / 7)
        --minValues[2] = 10
        --maxValues[2] = 20
        -- 下面这个洗练上限是SP2的上限，会比上面这套低一半左右
        -- EquipUtil.InstallYinjian()
        -- local hard = EquipUtil.AoyiHards[certains[2]].avg -- 可修改成maxHard或minHard
        -- minValues[1] = math.floor(6 * (round + 3) / (hard / 2 + 1))
        -- minValues[2] = math.floor(12 * (round + 4) / (hard / 2 + 1))
        if minValues[1] > maxValues[1] then
            minValues[1], maxValues[1] = maxValues[1], minValues[1]
        end
    elseif certains[1] == "powerup_uniqueskill" then
        minValues[1] = 21 + math.floor(5 * (round + 20) / 16)
        maxValues[1] = 11 + math.floor(5 * (round + 20) / 10)
        --minValues[1] = 41 + math.floor(20 * (round + 20) / 16)
        --maxValues[1] = 26 + math.floor(20 * (round + 20) / 10)
        -- 下面这个洗练上限是SP2的上限，会比上面这套低1/3左右
        -- EquipUtil.InstallYinjian()
        -- local hard = EquipUtil.UniqueSkillHards[certains[2]]
        -- minValues[1] = 5 * (round + 3) / (hard / 2 + 1)
        -- maxValues[1] = 10 * (round + 4) / (hard / 2 + 1)
        if minValues[1] > maxValues[1] then
            minValues[1], maxValues[1] = maxValues[1], minValues[1]
        end
    end
    EquipUtil.RoundTriggerCache[key] = {minValues, maxValues}
    return minValues, maxValues
end

-- 定向洗练词条
function EquipUtil.ComputeCertainTrigger(equip, trigger, isRandomOrUpgrade)
    local newTrigger = Trigger()
    local name = trigger.Name
    local argvs = split(trigger.ArgvsString, ",")
    local certains = {name}
    if EquipUtil.TwoNameSameDict[name] then
        table.insert(certains, table.remove(argvs, 1))
    end
    local minValues, maxValues = EquipUtil.ComputeRoundTrigger(equip.level, certains)
    if isRandomOrUpgrade == 1 then
        local tmpMinValues = {}
        for i, v in ipairs(minValues) do
            local n = tonumber(argvs[i])
            if v < n then
                tmpMinValues[i] = n
            else
                tmpMinValues[i] = v
            end
        end
        minValues = tmpMinValues
    end
    -- 优化，让随机的期望值相对更容易偏高一点
    for i, v in ipairs(minValues) do
        local rdv = math.random()
        if rdv < 0.5 then
            rdv = rdv * 1.4
        else
            rdv = 0.4 + rdv * 0.6
        end
        if v - math.floor(v) > 0.00001 then
            argvs[i] = math.floor(v * 100 + (maxValues[i] * 100 - v * 100) * rdv + 0.5) / 100
        else
            argvs[i] = math.floor(v + (maxValues[i] - v) * rdv + 0.5)
        end
    end
    local newArgsStr = {}
    if certains[2] then
        table.insert(newArgsStr, certains[2])
    end
    for i, v in ipairs(argvs) do
        table.insert(newArgsStr, tostring(v))
    end
    newTrigger.Name = name
    newTrigger.ArgvsString = table.concat(newArgsStr, ",")
    return newTrigger
end

function EquipUtil.ComputeExchangeTrigger(equip, certains)
    local newTrigger = Trigger()
    local minValues, maxValues = EquipUtil.ComputeRoundTrigger(equip.level, certains)
    local newArgsStr = {}
    if certains[2] then
        table.insert(newArgsStr, certains[2])
    end
    for i, v in ipairs(minValues) do
        table.insert(newArgsStr, tostring(v))
    end
    newTrigger.Name = certains[1]
    newTrigger.ArgvsString = table.concat(newArgsStr, ",")
    return newTrigger
end

-- 检查装备的词条属性是否合法；allowBL是允许的最大值的倍率，即万一希望可以适当超过上限的话，allowBL设为大于1的值即可
function EquipUtil.CheckTriggerAllowed(equip, trigger, allowBL)
    local name = trigger.Name
    if name == "talent" or name == "eq_talent" then
        return 0
    else
        if not allowBL or allowBL < 1 then
            allowBL = 1
        end
        local argvs = split(trigger.ArgvsString, ",")
        local certains = {name}
        if name == "attribute" or name == "powerup_aoyi" or name == "powerup_uniqueskill" or name == "powerup_internalskill" or name == "powerup_skill" then
            table.insert(certains, table.remove(argvs, 1))
        end
        local minValues, maxValues = EquipUtil.ComputeRoundTrigger(equip.level, certains)
        for i, v in ipairs(maxValues) do
            local n = tonumber(argvs[i])
            -- 异常洗练，则取当前周目洗练最小值代替
            if n > minValues[i] * allowBL and n > v * allowBL then
                local newTrigger = Trigger()
                newTrigger.Name = name
                local newArgsStr = {}
                if certains[2] then
                    table.insert(newArgsStr, certains[2])
                end
                for i2, v2 in ipairs(minValues) do
                    if (name == "powerup_skill" or name == "powerup_internalskill" or name == "powerup_uniqueskill" or name == "powerup_aoyi") then
                        table.insert(newArgsStr, tostring(math.floor((v - v2) * 9 / 10 + v2)))
                    else
                        table.insert(newArgsStr, tostring(v2))
                    end
                end
                newTrigger.ArgvsString = table.concat(newArgsStr, ",")
                return newTrigger
            end
        end
    end
end

-- 逻辑上升级某装备，参数为装备、概率、花费，返回值0表示失败，1表示成功，-1表示异常
function EquipUtil.LogicUpgradeEquip(equip, probabiltiy, costs)
    local suc
    if Tools.ProbabilityTest(probabiltiy) then
        local retry = 0
        while retry < 10 do
            local trigger = EquipUtil.MakeRandomTriggers(equip, 1)[1]
            if trigger then
                local newEquip = EquipUtil.CloneEquip(equip)
                RuntimeData.Instance:addItem(equip, -1)
                newEquip.AdditionTriggers:Add(trigger)
                RuntimeData.Instance:addItem(newEquip, 1)
                break
            end
            retry = retry + 1
        end
        if retry >= 10 then
            return -1
        else
            suc = true
        end
    else
        suc = false
    end
    -- 扣除资源
    if costs then
        EquipUtil.DoCostItems(costs)
    end
    return suc and 1 or 0
end

-- 战斗中强化装备，这里为什么不用Clone呢，因为人身上的装备是固定的不用担心重复，所以可以这么做
-- 当然要clone也没问题，就是先Remove装备再Add回去就行
function EquipUtil.BattleUpgradeEquip(equip, certainsAll, bf, sourceSprite)
    local okTriggers = {}
    for i = 1, equip.AdditionTriggers.Count do
        local trigger = equip.AdditionTriggers[i - 1]
        local certains1 = {trigger.Name}
        if certains1[1] == "attribute" then
            certains1[2] = split(trigger.ArgvsString, ",")[1]
        end
        for j, certains2 in ipairs(certainsAll) do
            if certains1[1] == certains2[1] and certains1[2] == certains2[2] then
                table.insert(okTriggers, trigger)
            end
        end
    end
    -- 随机强化一条
    if #okTriggers > 0 then
        local trigger = RandomTable(okTriggers)
        local certains = {trigger.Name}
        local argvs = split(trigger.ArgvsString, ",")
        if certains[1] == "attribute" then
            certains[2] = table.remove(argvs, 1)
        end
        local minValues, maxValues = EquipUtil.ComputeRoundTrigger(equip.level, certains)
        local hasAdd = false
        for i, v in ipairs(maxValues) do
            local n = tonumber(argvs[i])
            if n < v then
                hasAdd = true
                argvs[i] = n + math.ceil((v - minValues[i]) / 100)
            end
        end
        if hasAdd then
            local newArgsStr = {}
            if certains[2] then
                table.insert(newArgsStr, certains[2])
            end
            for i, v in ipairs(argvs) do
                table.insert(newArgsStr, tostring(v))
            end
            local oldDesc = EquipUtil.GetTriggerDesc(trigger)
            trigger.ArgvsString = table.concat(newArgsStr, ",")
            bf:Log(sourceSprite.Role.Name .. "击杀了敌人，" .. equip.Name .. "的属性“" .. oldDesc .. "”强化成了“" ..EquipUtil.GetTriggerDesc(trigger) .. "”！")
            sourceSprite.Role:InitBind()
            sourceSprite.Role:SetRoleBattleValue()
        end
    elseif equip.AdditionTriggers.Count < 10 then
        local certains = certainsAll[1]
        local newTrigger = Trigger()
        local minValues, maxValues = EquipUtil.ComputeRoundTrigger(equip.level, certains)
        newTrigger.Name = certains[1]
        local newArgsStr = {}
        if certains[2] then
            table.insert(newArgsStr, certains[2])
        end
        for i, v in ipairs(minValues) do
            table.insert(newArgsStr, tostring(v))
        end
        newTrigger.ArgvsString = table.concat(newArgsStr, ",")
        equip.AdditionTriggers:Add(newTrigger)
        bf:Log(sourceSprite.Role.Name .. "击杀了敌人，" .. equip.Name .. "获得了强化“" .. EquipUtil.GetTriggerDesc(newTrigger) .. "”！")
        sourceSprite.Role:InitBind()
        sourceSprite.Role:SetRoleBattleValue()
    end
end

-- 此方法为界面上给装备执行升级操作的封装，参数为有关对话的人物key、装备、消耗、概率、是否跳过确认、回调
function EquipUtil.UIUpgradeEquip(equip, costs, probabiltiy, skipEnsure)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local costEnough, costStrs = EquipUtil.CheckCosts(costs)
    if not costEnough then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "升级到" .. (equip.AdditionTriggers.Count + 1) .. "星需要花费" .. costStrs .. "，你的资源不够，下次再来吧。", callback)
        EquipUtil.InitContext()
    else
        local function innerRealUpgrade()
            local ret = EquipUtil.LogicUpgradeEquip(equip, probabiltiy, costs)
            if ret == -1 then
                RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "奇了怪了，你这装备我怎么无法升级呢，去找程序员确认一下吧。", callback)
            elseif ret == 1 then
                RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "升级成功，轻而易举。", callback)
            else
                RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "升级失败了，下次再来吧。", callback)
            end
            EquipUtil.InitContext()
        end
        if skipEnsure then
            innerRealUpgrade()
        else
            local mustCosts, costEnough2, costStrs2
            if probabiltiy < 1 then
                mustCosts = {}
                for _, cost in ipairs(costs) do
                    if cost[1] == "元宝" then
                        table.insert(mustCosts, {cost[1], math.ceil(6 * cost[2] / probabiltiy)})
                    else
                        table.insert(mustCosts, {cost[1], math.ceil(1.2 * cost[2] / probabiltiy)})
                    end
                end
            end
            local actionValue = "想将该装备升到" .. (equip.AdditionTriggers.Count + 1) .. "星，你可以："
            if mustCosts then
                actionValue = actionValue .. "#花费[[red:".. costStrs .. "]]，概率成功"
                costEnough2, costStrs2 = EquipUtil.CheckCosts(mustCosts)
                actionValue = actionValue .. "#花费[[red:".. costStrs2 .. "]]，必定成功"
            else
                actionValue = actionValue .. "#花费[[red:".. costStrs .. "]]，必定成功"
            end
            actionValue = actionValue .. "#太贵了，下次吧。"
            local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
            action.type = "SELECT"
            RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
                if selectIndex == 0 then
                    innerRealUpgrade()
                elseif selectIndex == 1 and mustCosts then
                    if not costEnough2 then
                        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "升级到" .. (equip.AdditionTriggers.Count + 1) .. "星（必定成功）需要花费" .. costStrs2 .. "，你的资源不够，下次再来吧。", callback)
                        EquipUtil.InitContext()
                    else
                        costs = mustCosts
                        probabiltiy = 1
                        innerRealUpgrade()
                    end
                else
                    RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "多收集一点资源，下次再来吧。", callback)
                    EquipUtil.InitContext()
                end
            end))
        end
    end
end

-- 此方法为给装备某词条进行随机洗练操作，旧版逻辑
function EquipUtil.UIXilianRandomTrigger(equip, triggerIdx, costs, maxRandom)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local costEnough, costStrs = EquipUtil.CheckCosts(costs)
    if not costEnough then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "洗练装备需要花费" .. costStrs .. "，你的资源不够，下次再来吧。", callback)
        EquipUtil.InitContext()
    else
        EquipUtil.DoCostItems(costs)
        local actionValue = "选择你要替换成的属性："
        local newTriggers = EquipUtil.MakeRandomTriggers(equip, maxRandom)
        for i, newTrigger in ipairs(newTriggers) do
            actionValue = actionValue .. "#" .. EquipUtil.GetTriggerDesc(newTrigger)
        end
        actionValue = actionValue .. "#不替换了（" .. EquipUtil.GetTriggerDesc(equip.AdditionTriggers[triggerIdx - 1]) .. "）"
        local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
        action.type = "SELECT"
        RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
            if selectIndex < #newTriggers then
                local newEquip = EquipUtil.CloneEquip(equip, {[triggerIdx] = newTriggers[selectIndex + 1]})
                RuntimeData.Instance:addItem(equip, -1)
                RuntimeData.Instance:addItem(newEquip, 1)
                equip = newEquip
            end

            action.value = dialogNpcKey .. "#洗炼完成，是否继续洗练？#继续洗练此装备#选择另一件装备#不洗了，再见"
            RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
                if selectIndex == 0 then
                    EquipUtil.UIXilianSelectTrigger(equip, costs, 0, maxRandom)
                elseif selectIndex == 1 then
                    EquipUtil.apiStartXilian(dialogNpcKey, callback, EquipUtil.EquipType, 0, EquipUtil.MaxStar, maxRandom)
                else
                    RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
                    EquipUtil.InitContext()
                end
            end))
        end))
    end
end

-- 此方法为给装备某词条进行定向升级操作
function EquipUtil.UIXilianUpgradeTrigger(equip, triggerIdx, costs, isRandomOrUpgrade)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local costEnough, costStrs = EquipUtil.CheckCosts(costs)
    local trigger = equip.AdditionTriggers[triggerIdx - 1]
    if not costEnough then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "定向洗练装备需要花费" .. costStrs .. "，你的资源不够，下次再来吧。", callback)
        EquipUtil.InitContext()
    -- 不支持升级的词条就在这里拦截掉好了，正常来说不可能
    elseif trigger.Name == "talent" or trigger.Name == "eq_talent" then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "天赋还定向升级个鬼，你玩我呢大哥？", callback)
        EquipUtil.InitContext()
    else
        EquipUtil.DoCostItems(costs)
        local newTrigger = EquipUtil.ComputeCertainTrigger(equip, trigger, isRandomOrUpgrade)
        local actionValue = "定向洗练完成："
        actionValue = actionValue .. "#替换（" .. EquipUtil.GetTriggerDesc(newTrigger) .. "）"
        actionValue = actionValue .. "#不替换了（" .. EquipUtil.GetTriggerDesc(equip.AdditionTriggers[triggerIdx - 1]) .. "）"
        local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
        action.type = "SELECT"
        RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
            if selectIndex == 0 then
                local newEquip = EquipUtil.CloneEquip(equip, {[triggerIdx] = newTrigger})
                RuntimeData.Instance:addItem(equip, -1)
                RuntimeData.Instance:addItem(newEquip, 1)
                equip = newEquip
            end
            action.value = dialogNpcKey .. "#定向洗炼完成，是否继续洗练？#继续洗练此装备#选择另一件装备#不洗了，再见"
            RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
                if selectIndex == 0 then
                    EquipUtil.UIXilianSelectTrigger(equip, costs, 1, isRandomOrUpgrade)
                elseif selectIndex == 1 then
                    EquipUtil.apiStartXilian(dialogNpcKey, callback, EquipUtil.EquipType, 1, EquipUtil.MaxStar, isRandomOrUpgrade)
                else
                    RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
                    EquipUtil.InitContext()
                end
            end))
        end))
    end
end

-- 此方法为给装备某词条进行定向更换操作
function EquipUtil.UIXilianExchangeTrigger(equip, triggerIdx, costs, isRandomOrUpgrade)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local costEnough, costStrs = EquipUtil.CheckCosts(costs)
    local trigger = equip.AdditionTriggers[triggerIdx - 1]
    if not costEnough then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "定向打造词条需要花费" .. costStrs .. "，你的资源不够，下次再来吧。", callback)
        EquipUtil.InitContext()
    else

        local attributes = {
            "生命上限","内力上限","搏击格斗","使剑技巧","耍刀技巧","奇门兵器",
            "根骨","臂力","福缘","身法","定力","悟性"
        }
        local exceptAttributes = {}
        for i = 1, equip.AdditionTriggers.Count do
            if i ~= triggerIdx and equip.AdditionTriggers[i-1].Name == "attribute" then
                local have = split(equip.AdditionTriggers[i-1].ArgvsString, ",")
                exceptAttributes[have[1]] = 1
            end
        end
        local actionValue = "定向打造更换目标："
        local toExchangeList = {}
        for i, v in ipairs(attributes) do
            if not exceptAttributes[v] then
                local newTrigger = EquipUtil.ComputeExchangeTrigger(equip, {"attribute", v})
                actionValue = actionValue .. "#" .. EquipUtil.GetTriggerDesc(newTrigger)
                table.insert(toExchangeList, newTrigger)
            end
        end
        actionValue = actionValue .. "#算了，下次吧"
        local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
        action.type = "SELECT"
        RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
            if selectIndex >= #toExchangeList then
                RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
                EquipUtil.InitContext()
            else
                EquipUtil.DoCostItems(costs)
                local newEquip = EquipUtil.CloneEquip(equip, {[triggerIdx] = toExchangeList[selectIndex + 1]})
                RuntimeData.Instance:addItem(equip, -1)
                RuntimeData.Instance:addItem(newEquip, 1)
                equip = newEquip
                action.value = dialogNpcKey .. "#定向 打造完成，是否继续洗练？#是#否"
                RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
                    if selectIndex == 0 then
                        EquipUtil.UIXilianSelectTrigger(equip, costs, 2, isRandomOrUpgrade)
                    else
                        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
                        EquipUtil.InitContext()
                    end
                end))
            end
        end))
    end
end

-- 此方法用于让用户选择装备上的洗练词条
function EquipUtil.UIXilianSelectTrigger(equip, costs, xilianType, extendParam)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local actionValue = "选择你要洗练的属性："
    for i = 1, equip.AdditionTriggers.Count do
        actionValue = actionValue .. "#" .. EquipUtil.GetTriggerDesc(equip.AdditionTriggers[i-1])
    end
    actionValue = actionValue .. "#算了，下次吧"
    local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
    action.type = "SELECT"
    RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
        if selectIndex >= equip.AdditionTriggers.Count then
            RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
            EquipUtil.InitContext()
        else
            if xilianType == 0 then
                EquipUtil.UIXilianRandomTrigger(equip, selectIndex + 1, costs, extendParam)
            elseif xilianType == 1 then
                EquipUtil.UIXilianUpgradeTrigger(equip, selectIndex + 1, costs, extendParam)
            else
                EquipUtil.UIXilianExchangeTrigger(equip, selectIndex + 1, costs, extendParam)
            end
        end
    end))
end

-- 此方法用于让用户选择玄天宝玉洗炼时装备上的洗练词条
function EquipUtil.UIXuantianSelectTrigger(role, equip, xilianType, itemRestoreName)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local actionValue = "选择你要强化的词条："
    local triggers = {}
    for i = 1, equip.AdditionTriggers.Count do
        local trigger = equip.AdditionTriggers[i-1]
        if trigger.Name == xilianType then
            table.insert(triggers, i)
            actionValue = actionValue .. "#" .. EquipUtil.GetTriggerDesc(trigger)
        end
    end
    actionValue = actionValue .. "#算了，下次吧"
    local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
    action.type = "SELECT"
    RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
        if selectIndex >= #triggers then
            RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "你放弃了本次操作，下次再来吧。", callback)
            RuntimeData.Instance:addItem(Item.GetItem(itemRestoreName), 1)
            EquipUtil.InitContext()
        else
            local triggerIdx = triggers[selectIndex + 1]
            EquipUtil.UIXuantianSelectSkill(role, equip, xilianType, itemRestoreName, triggerIdx)
        end
    end))
end

-- 此方法用于让用户选择玄天宝玉洗炼时对应的装备
function EquipUtil.UIXuantianSelectSkill(role, equip, xilianType, itemRestoreName, triggerIdx)
    local dialogNpcKey, callback = EquipUtil.dialogNpcKey, EquipUtil.callback
    local exceptSkillNames = {}
    for i = 1, equip.AdditionTriggers.Count do
        if i ~= triggerIdx and equip.AdditionTriggers[i-1].Name == xilianType then
            exceptSkillNames[split(equip.AdditionTriggers[i-1].ArgvsString, ",")[1]] = 1
        end
    end

    local selectSkills = {}
    local actionValue
    if xilianType == "powerup_skill" then
        actionValue = "你想要我哪个外功？"
        for i = 0, role.Skills.Count - 1 do
            local sname = role.Skills[i].Name
            if not exceptSkillNames[sname] then
                table.insert(selectSkills, sname)
                actionValue = actionValue .. "#" .. sname
            end
        end
        if role.HiddenWeapon and role.HiddenWeapon ~= "" then
            local sname = role.HiddenWeapon
            if not exceptSkillNames[sname] then
                table.insert(selectSkills, sname)
                actionValue = actionValue .. "#" .. sname
            end
        end
    elseif xilianType == "powerup_internalskill" then
        actionValue = "你想要我哪个内功？"
        for i = 0, role.InternalSkills.Count - 1 do
            local sname = role.InternalSkills[i].Name
            if not exceptSkillNames[sname] then
                table.insert(selectSkills, sname)
                actionValue = actionValue .. "#" .. sname
            end
        end
    -- 修改，绝技只能取当前身上技能的绝技
    elseif xilianType == "powerup_uniqueskill" then
        actionValue = "你想要我哪个绝技？"
        for i = 0, role.Skills.Count - 1 do
            local skill = role.Skills[i]
            for j = 0, skill.UniqueSkills.Count - 1 do
                local uname = skill.UniqueSkills[j].Name
                if not exceptSkillNames[uname] then
                    table.insert(selectSkills, uname)
                    actionValue = actionValue .. "#" .. uname
                end
            end
        end
        for i = 0, role.InternalSkills.Count - 1 do
            local skill = role.InternalSkills[i]
            for j = 0, skill.UniqueSkills.Count - 1 do
                local uname = skill.UniqueSkills[j].Name
                if not exceptSkillNames[uname] then
                    table.insert(selectSkills, uname)
                    actionValue = actionValue .. "#" .. uname
                end
            end
        end
    -- 奥义仍然取有加成的字段，然后做一下去重
    elseif xilianType == "powerup_aoyi" then
        actionValue = "你想要我哪个奥义？"
        local triggers = LuaTool.CreateLuaTable(role:GetTriggers(xilianType))
        for _, tr in pairs(triggers) do
            local t = split(tr.ArgvsString, ",")
            if t[1] and not exceptSkillNames[t[1]] then
                exceptSkillNames[t[1]] = 1
                table.insert(selectSkills, t[1])
                actionValue = actionValue .. "#" .. t[1]
            end
        end
    end

    if #selectSkills == 0 then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "我身上没有适合你的功法，也可能是有重复词条了，本次强化取消。", callback)
        RuntimeData.Instance:addItem(Item.GetItem(itemRestoreName), 1)
        EquipUtil.InitContext()
        return
    end

    actionValue = actionValue .. "#算了，下次吧"

    local action = StoryAction.CreateDialog2(dialogNpcKey, actionValue)
    action.type = "SELECT"
    RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
        if selectIndex >= #selectSkills then
            RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "本次强化操作取消。", callback)
            RuntimeData.Instance:addItem(Item.GetItem(itemRestoreName), 1)
            EquipUtil.InitContext()
        else
            local selectSkill = selectSkills[selectIndex + 1]
            local newTrigger = EquipUtil.ComputeCertainTrigger(equip, {Name = xilianType, ArgvsString = selectSkill}, 0)
            local newEquip = EquipUtil.CloneEquip(equip, {[triggerIdx] = newTrigger})
            RuntimeData.Instance:addItem(equip, -1)
            RuntimeData.Instance:addItem(newEquip, 1)
            RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "你的装备【" .. newEquip.Name .. "】获得了【" .. selectSkill .. "】的强化。" , callback)
            EquipUtil.InitContext()
        end
    end))
end

-- API调用，equipType为可升级的装备类型，为0则固定为武器衣服视频，为其他的则只筛选相同类型
-- maxStar为最高可升星数, needAskYB为是否可通过元宝提升概率
function EquipUtil.apiStartEquipUpgrade(dialogNpcKey, callback, equipType, maxStar, needAskYB)
    EquipUtil.InitContext(dialogNpcKey, callback)
    local Items1 = EquipUtil.MakeItemDictionaryForUI(function(item, num)
        if (equipType == 0 and (item.Type == 1 or item.Type == 2 or item.Type == 3)) or (equipType > 0 and equipType == item.Type) then
            if item.AdditionTriggers.Count < maxStar then
                return true
            end
        end
        return false
    end)
    if Items1.Count <= 0 then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "没有可升级的装备，下次再来吧。", callback)
        EquipUtil.InitContext()
        return
    end
    RuntimeData.Instance.MapUI.ItemMenu:Show("请选择需要强化的装备", Items1,
    LuaTool.MakeObjectCallBack(function(equip)
        RuntimeData.Instance.MapUI.ItemMenu:Hide()
        -- 以下逻辑按自己喜好实现消耗和概率，暂且先按原本的花费和概率走
        local costYB, costYT = 0, 1
        local probabiltiy = 1
        local nowStar = equip.AdditionTriggers.Count

        local function innerRealStartEquipUpgrade(withExtendYB)
            if withExtendYB then
                costYB = 0
                if nowStar <= 4 then
                    probabiltiy = 1
                elseif nowStar == 5 then
                    probabiltiy = 1
                elseif nowStar == 6 then
                    probabiltiy = 1
                elseif nowStar == 7 then
                    probabiltiy = 1
                elseif nowStar == 8 then
                    probabiltiy = 1
                elseif nowStar == 9 then
                    probabiltiy = 1
                else
                    probabiltiy = 0.003 + (0.008) * (15 - nowStar) / 5
                end
            else
                if nowStar <= 3 then
                    probabiltiy = 1
                elseif nowStar == 4 then
                    probabiltiy = 1
                elseif nowStar == 5 then
                    probabiltiy = 1
                elseif nowStar == 6 then
                    probabiltiy = 1
                elseif nowStar == 7 then
                    probabiltiy = 1
                elseif nowStar == 8 then
                    probabiltiy = 1
                elseif nowStar == 9 then
                    probabiltiy = 1
                else
                    probabiltiy = 0.0001 + (0.001) * (15 - nowStar) / 5
                end
            end
            local costItems = {{"元宝",costYB}, {"天外陨铁", costYT}}
            EquipUtil.UIUpgradeEquip(equip, costItems, probabiltiy, needAskYB)
        end
        if needAskYB then
            local action = StoryAction.CreateDialog2(dialogNpcKey, "是否要花费元宝来增加成功率？#确认（花费[[red:1元宝]]）#不用，直接升#算了，下次吧")
            action.type = "SELECT"
            RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
                if selectIndex == 0 then
                    innerRealStartEquipUpgrade(true)
                elseif selectIndex == 1 then
                    innerRealStartEquipUpgrade(false)
                else
                    RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "多收集一点资源，下次再来吧。", callback)
                    EquipUtil.InitContext()
                end
            end))
        else
            innerRealStartEquipUpgrade(true)
        end
    end),
    LuaTool.MakeVoidCallBack(function()
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
        EquipUtil.InitContext()
    end), nil)
end

-- API调用，equipType为可升级的装备类型，为0则固定为武器衣服视频，为其他的则只筛选相同类型
-- xilianType 为洗练方式，0为旧版随机洗练，1为对洗练好的词条做定向升级，2为对洗练好的词条做指定词条的更换
-- maxStar为最高可洗练星数
-- xilianType为0时，extendParam为一次洗练最多随出多少条词条来
-- xilianType为1时，extendParam为0表示数值随机增减，1表示只升不减
-- xilianType为2时，extendParam暂时无意义
function EquipUtil.apiStartXilian(dialogNpcKey, callback, equipType, xilianType, maxStar, extendParam)
    EquipUtil.InitContext(dialogNpcKey, callback)
    EquipUtil.MaxStar = maxStar
    EquipUtil.EquipType = equipType
    local Items1 = EquipUtil.MakeItemDictionaryForUI(function(item, num)
        if (equipType == 0 and (item.Type == 1 or item.Type == 2 or item.Type == 3)) or (equipType > 0 and equipType == item.Type) then
            if item.AdditionTriggers.Count > 0 and item.AdditionTriggers.Count <= maxStar then
                return true
            end
        end
        return false
    end)
    if Items1.Count <= 0 then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "没有可洗练的装备，下次再来吧。", callback)
        EquipUtil.InitContext()
        return
    end
    RuntimeData.Instance.MapUI.ItemMenu:Show("请选择需要洗练的装备", Items1,
    LuaTool.MakeObjectCallBack(function(equip)
        RuntimeData.Instance.MapUI.ItemMenu:Hide()
        local costs
        if xilianType == 0 then
            costs = {{"元宝", 1}}
        elseif xilianType == 1 then
            if extendParam == 0 then
               costs = {{"元宝", 5}}
            else
                costs = {{"元宝", 50}}
            end
        else
            costs = {{"元宝", 100}}
        end
        EquipUtil.UIXilianSelectTrigger(equip, costs, xilianType, extendParam)
    end),
    LuaTool.MakeVoidCallBack(function()
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
        EquipUtil.InitContext()
    end), nil)
end

-- 玄天宝玉洗练，先选装备，再选技能
function EquipUtil.apiStartXuantian(role, callback, equipType, xilianType, maxStar)
    local dialogNpcKey = role.Key
    EquipUtil.InitContext(dialogNpcKey, callback)
    local itemRestoreName
    if xilianType == "powerup_skill" then
        itemRestoreName = "玄天宝玉▁外功"
    elseif xilianType == "powerup_internalskill" then
        itemRestoreName = "玄天宝玉▁内功"
    elseif xilianType == "powerup_uniqueskill" then
        itemRestoreName = "玄天宝玉▁绝技"
    elseif xilianType == "powerup_aoyi" then
        itemRestoreName = "玄天宝玉▁奥义"
    end

    local Items1 = EquipUtil.MakeItemDictionaryForUI(function(item, num)
        if (equipType == 0 and (item.Type == 1 or item.Type == 2 or item.Type == 3)) or (equipType > 0 and equipType == item.Type) then
            if item.AdditionTriggers.Count > 0 and item.AdditionTriggers.Count <= maxStar then
                for i = 0, item.AdditionTriggers.Count - 1 do
                    if item.AdditionTriggers[i].Name == xilianType then
                        return true
                    end
                end
            end
        end
        return false
    end)
    if Items1.Count <= 0 then
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "没有可强化的装备，下次再来吧。", callback)
        RuntimeData.Instance:addItem(Item.GetItem(itemRestoreName), 1)
        EquipUtil.InitContext()
        return
    end
    RuntimeData.Instance.MapUI.ItemMenu:Show("请选择需要强化的装备", Items1,
    LuaTool.MakeObjectCallBack(function(equip)
        RuntimeData.Instance.MapUI.ItemMenu:Hide()
        EquipUtil.UIXuantianSelectTrigger(role, equip, xilianType, itemRestoreName)
    end),
    LuaTool.MakeVoidCallBack(function()
        RuntimeData.Instance.mapUI:ShowDialog(dialogNpcKey, "下次再来吧。", callback)
        RuntimeData.Instance:addItem(Item.GetItem(itemRestoreName), 1)
        EquipUtil.InitContext()
    end), nil)
end

_G.EquipUtil = EquipUtil

--控制台指令+游戏内的跳转指令
function GameEngine_extendConsole(gameEngine,statusType,value)

	--if(statusType == "test") then
	--	print(value)
	--	--扩展的指令，必须返回true
	--	return true
	if (statusType == "get_money" or statusType == "money" or statusType == "银两") then
		RuntimeData.Instance.Money = RuntimeData.Instance.Money + tonumber(value)
		AudioManager.Instance:PlayEffect("音效.升级")
		--部分参数生效时，需要刷新一次状态栏
		RuntimeData.Instance.mapUI:RefreshRoleState()
		return true
	elseif (statusType == "play_music") then
		AudioManager.Instance:Play(value)
		return true
	elseif (statusType == "头像") then
		RuntimeData.Instance:touxiang(value)
		return true
	elseif (statusType == "模型") then
		RuntimeData.Instance:moxing(value)
		return true
	elseif (statusType == "遣散") then
		if (RuntimeData.Instance:InTeam(value) == true) then
			RuntimeData.Instance:removeTeamMember(value)
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "rank") then
		if (tonumber(value) <= 0) then
			RuntimeData.Instance.Rank = -1
		else
			RuntimeData.Instance.Rank = tonumber(value - 1)
		end
		return true
	elseif (statusType == "day") then
		local num = tonumber(value)
		if (num > 0 and num < 1000) then
			RuntimeData.Instance.Date = RuntimeData.Instance.Date:AddDays(num)
			RuntimeData.Instance.mapUI:RefreshRoleState()
		return true
		end
		return true
	elseif (statusType == "元宝+") then
		RuntimeData.Instance.Yuanbao = RuntimeData.Instance.Yuanbao + tonumber(value)
		AudioManager.Instance:PlayEffect("音效.升级")
		RuntimeData.Instance.mapUI:RefreshRoleState()
		return true
	elseif (statusType == "武1") then
		if (RuntimeData.Instance:addskill(value) == true) then
			AudioManager.Instance:PlayEffect("音效.升级")
		end
		return true
	elseif (statusType == "武2") then
		if (RuntimeData.Instance:addskillLevel(value) == true) then
			AudioManager.Instance:PlayEffect("音效.升级")
		end
		return true
	elseif (statusType == "天1+") then
		if (RuntimeData.Instance:addtianfu(value) == true) then
			AudioManager.Instance:PlayEffect("音效.升级")
		end
		return true
	elseif (statusType == "残1+") then
		if (RuntimeData.Instance:AddSkillMaxLevel(value) == true) then
			AudioManager.Instance:PlayEffect("音效.升级")
		end
		return true
	elseif (statusType == "属性增加") then
		RuntimeData.Instance:addAttrib(value,200)
		return true
	elseif (statusType == "道德增加") then
		RuntimeData.Instance.Daode = RuntimeData.Instance.Daode + tonumber(value)
		AudioManager.Instance:PlayEffect("音效.升级")
		return true
	elseif (statusType == "好感增加") then
		RuntimeData.Instance:addHaoganLua(value)
		AudioManager.Instance:PlayEffect("音效.升级")
		return true
	elseif (statusType == "好感查询") then
		local haogan = RuntimeData.Instance:getHaoganLua(value)
		RuntimeData.Instance.mapUI:ShowCustomDialogs("主角|【" .. value .. "】好感度：" .. tostring(haogan))
		return true
	elseif (statusType == "元宝增加") then
		RuntimeData.Instance.Yuanbao = RuntimeData.Instance.Yuanbao + tonumber(value)
		AudioManager.Instance:PlayEffect("音效.升级")
		RuntimeData.Instance.mapUI:RefreshRoleState()
		return true
	elseif (statusType == "HPMP") then
		RuntimeData.Instance:HPMP(value)
		AudioManager.Instance:PlayEffect("音效.升级")
		return true
	elseif (statusType == "解锁武学") then
		if (RuntimeData.Instance:AddSkillMaxLevel(value) == true) then
			AudioManager.Instance:PlayEffect("音效.升级")
		end
		return true
	elseif (statusType == "退出门派") then
		local str = RuntimeData.Instance:exit_menpai()
		return true
	elseif (statusType == "主角改名") then
		RuntimeData.Instance.mapUI:SelectMyName(1)
		return true
	elseif (statusType == "女主改名") then
		RuntimeData.Instance.mapUI:SelectMyName(2)
		return true
	elseif (statusType == "队友改名") then
		RuntimeData.Instance.mapUI:SelectRoleName(value)
		return true
	elseif (statusType == "技能等级") then
		RuntimeData.Instance:addSkillLevel(value)
		return true
	elseif (statusType == "加入队友") then
		local RoleKey = RuntimeData.Instance:GetRoleKeyFromRoleName(value)
		if (RoleKey ~= nil and RoleKey ~= "") then
			if (RuntimeData.Instance:InTeam(RoleKey) == false) then
				RuntimeData.Instance:addTeamMember(RoleKey)
				AudioManager.Instance:PlayEffect("音效.装备")
			end
		end
		return true
	elseif (statusType == "暂离所有男队友") then
		RuntimeData.Instance:addAllTempMemberFromTeam(false)
		AudioManager.Instance:PlayEffect("音效.装备")
		return true
	elseif (statusType == "暂离所有女队友") then
		RuntimeData.Instance:addAllTempMemberFromTeam(true)
		AudioManager.Instance:PlayEffect("音效.装备")
		return true
	elseif (statusType == "回队所有男队友") then
		RuntimeData.Instance:addAllTeamMemberFromTemp(false)
		AudioManager.Instance:PlayEffect("音效.装备")
		return true
	elseif (statusType == "回队所有女队友") then
		RuntimeData.Instance:addAllTeamMemberFromTemp(true)
		AudioManager.Instance:PlayEffect("音效.装备")
		return true
	elseif (statusType == "暂时离队") then
		if (RuntimeData.Instance:addTempMemberFromTeam(value) == true) then
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "回到队伍") then
		if (RuntimeData.Instance:addTeamMemberFromTemp(value) == true) then
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "暂时离队2") then
		if (RuntimeData.Instance:addTempMemberFromTeamV2(value) > 0) then
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "回到队伍2") then
		if (RuntimeData.Instance:addTeamMemberFromTempV2(value) > 0) then
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	--]]
	elseif (statusType == "跳转时辰") then
		if (RuntimeData.Instance:toChineseTime(value) == true) then
			--RuntimeData.Instance.mapUI:RefreshRoleState()
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "调整队伍顺序") then
		if (RuntimeData.Instance:AdjustTeamRoleOrder(value) == true) then
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "调整队伍顺序2") then
		if (RuntimeData.Instance:AdjustTeamRoleOrderByName(value) == true) then
			AudioManager.Instance:PlayEffect("音效.装备")
		end
		return true
	elseif (statusType == "隐藏云彩") then
		RuntimeData.Instance:ShowCloud(false)
		return true
	elseif (statusType == "显示云彩") then
		RuntimeData.Instance:ShowCloud(true)
		return true
    elseif (statusType == "战斗加速倍率") then
        if value == "SYS" then
            GameEngine:SwitchGameScene("game", "quitappcancel")
            GameEngine:SwitchGameScene("story", "萧十郎_战斗加速")
        elseif (value == "") then  --空字符串则删除自定义设置项
            ModData.RemoveParam("battle_speedup_rate")
            RuntimeData.Instance.mapUI:ShowCustomDialogs("主角|已删除自定义战斗加速倍率。若要下次进入游戏生效，请保存游戏",
                LuaTool.MakeVoidCallBack(function()
                    GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
                    RuntimeData.Instance.mapUI:ShowSavePanel(0)
                end)
            )
        else
            local speed = math.min(tonumber(value), 9)
            if (speed < 0.1) then
                speed = 0.1
            end
            ModData.SetParamDouble("battle_speedup_rate", speed)
            RuntimeData.Instance.mapUI:ShowCustomDialogs("主角|已设置战斗加速倍率为：" .. tostring(speed) .. "。若要下次进入游戏生效，请保存游戏",
                LuaTool.MakeVoidCallBack( function()
                    GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
                    RuntimeData.Instance.mapUI:ShowSavePanel(0)
                end)
            )
        end
        return true
    elseif statusType == "EQUIP_LUA" then
        local paras = split(value, "#")
        local callback = LuaTool.MakeVoidCallBack(function()
            GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
        end)
        if paras[2] == "0" then
            EquipUtil.apiStartEquipUpgrade(paras[1], callback, tonumber(paras[3]), tonumber(paras[4]), paras[5] == "1")
        else
            EquipUtil.apiStartXilian(paras[1], callback, tonumber(paras[3]), tonumber(paras[2]) - 1, tonumber(paras[4]), tonumber(paras[5]))
        end
        return true
    elseif statusType == "jiecao_shop" then
        local paras = split(value, "#")
        local callback = LuaTool.MakeVoidCallBack(function()
            RuntimeData.Instance.MapUI.ItemMenu:Hide()
            GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
        end)
        local priceDict = {}
        local limitDict = {}
        -- 获取一个空的物品表
        local items = EquipUtil.MakeItemDictionaryForUI(nil)
        for i = 2, #paras, 3 do
            local itemName = paras[i]
            local limit = tonumber(paras[i+1])
            local price = tonumber(paras[i+2])
            local item = Item.GetItem(itemName)
            if item then
                priceDict[itemName] = price
                if limit >= 0 then
                    local shopKey = "shopBuyKey_" .. paras[1] .. itemName
                    if RuntimeData.Instance.KeyValues:ContainsKey(shopKey) then
                        limit = limit - (tonumber(RuntimeData.Instance.KeyValues[shopKey]) or 0)
                    end
                else
                    limit = 99999
                end
                if limit > 0 then
                    items[item:Generate(false)] = -1
                    limitDict[itemName] = limit
                end
            end
        end
        RuntimeData.Instance.MapUI.ItemMenu:Show("剩余节操值：" .. RuntimeData.Instance:getHaogan("节操") .. "，请选择商品", items,
        LuaTool.MakeObjectCallBack(function(item)
            RuntimeData.Instance.MapUI.ItemMenu:Hide()
            local action = StoryAction.CreateDialog2("陆小凰", "是否要购买【" .. item.Name .. "】？#花费" .. priceDict[item.Name] .. "点节操值购买#算了，下次吧")
            action.type = "SELECT"
            RuntimeData.Instance.mapUI:LoadSelection(action, LuaTool.MakeIntCallBack(function(selectIndex)
                if selectIndex == 1 then
                    RuntimeData.Instance.MapUI.ItemMenu.gameObject:SetActive(true)
                else
                    local price = priceDict[item.Name]
                    if RuntimeData.Instance:getHaogan("节操") < price then
                        RuntimeData.Instance.mapUI:ShowDialog("陆小凰", "你的节操值不够！", LuaTool.MakeVoidCallBack(function()
                            RuntimeData.Instance.MapUI.ItemMenu.gameObject:SetActive(true)
                        end))
                    else
                        RuntimeData.Instance:addHaogan(-price, "节操")
                        RuntimeData.Instance:addItem(item, 1)
                        if limitDict[item.Name] < 10000 then
                            local shopKey = "shopBuyKey_" .. paras[1] .. item.Name
                            if RuntimeData.Instance.KeyValues:ContainsKey(shopKey) then
                                RuntimeData.Instance.KeyValues[shopKey] = tostring((tonumber(RuntimeData.Instance.KeyValues[shopKey]) or 0) + 1)
                            else
                                RuntimeData.Instance.KeyValues[shopKey] = "1"
                            end
                        end
                        RuntimeData.Instance.mapUI:ShowDialog("陆小凰", "你花费" .. price .."点节操值购买了【" .. item.Name .. "】！", LuaTool.MakeVoidCallBack(function()
                            GameEngine:SwitchGameScene("jiecao_shop", value)
                        end))
                    end
                end
            end))
        end), callback, nil)
        local selectTransform = RuntimeData.Instance.MapUI.ItemMenu.SelectMenuObj:GetComponent("SelectMenu").selectContent
        for i = 0, selectTransform.childCount - 1 do
            local child = selectTransform:GetChild(i)
            if child and child.gameObject:GetComponent("ItemUI") then
                local itemUI = child.gameObject:GetComponent("ItemUI")
                local itemName = itemUI.transform:FindChild("Text"):GetComponent("Text").text
                itemUI.transform:FindChild("Text"):GetComponent("Text").text = itemName .. "(单价" .. priceDict[itemName] .. ")"
                if limitDict[itemName] >= 10000 then
                    itemUI.transform:FindChild("NumberText"):GetComponent("Text").text = "∞"
                else
                    itemUI.transform:FindChild("NumberText"):GetComponent("Text").text = tostring(limitDict[itemName])
                end
            end
        end
        return true
    elseif statusType == "jiecao_tower" then
        -- 重置
        if value == "0" then
            RuntimeData.Instance.KeyValues["jiecao_tower_passed"] = ""
            RuntimeData.Instance.KeyValues["jiecao_tower_level"] = "0"
            RuntimeData.Instance.mapUI:ShowDialog("陆小凰", "节操塔进度已重置完毕", LuaTool.MakeVoidCallBack(function()
                GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
            end))
        else
            -- 首先获取已通关的人
            local forbiddenMap = {}
            if RuntimeData.Instance.KeyValues:ContainsKey("jiecao_tower_passed") then
                local passed = RuntimeData.Instance.KeyValues["jiecao_tower_passed"]
                if passed ~= "" then
                    passed = split(passed, "#")
                    for i, v in ipairs(passed) do
                        forbiddenMap[v] = i
                    end
                end
            else
                RuntimeData.Instance.KeyValues["jiecao_tower_passed"] = ""
                RuntimeData.Instance.KeyValues["jiecao_tower_level"] = "0"
            end
            local hasFree = false
            for i = 0, RuntimeData.Instance.Team.Count - 1 do
                local role = RuntimeData.Instance.Team[i]
                if not forbiddenMap[role.Key] then
                    hasFree = true
                    break
                end
            end
            if hasFree then
                local paras = split(value, "#")
                local maxStage = tonumber(paras[1])
                local BattleType = luanet.import_type("JyGame.BattleType")
                local Application = luanet.import_type("UnityEngine.Application")
                local passedLevel = 0
                if RuntimeData.Instance.KeyValues:ContainsKey("jiecao_tower_level") then
                    passedLevel = tonumber(RuntimeData.Instance.KeyValues["jiecao_tower_level"]) or 0
                end
                GameEngine.battleType = BattleType.Tower
                GameEngine.BattleSelectRole_CurrentForbbidenKeys:Clear()
                for k, _ in pairs(forbiddenMap) do
                    GameEngine.BattleSelectRole_CurrentForbbidenKeys:Add(k)
                end
                GameEngine.CurrentSceneType = "battle"
                GameEngine.CurrentSceneValue = "节操塔战斗_" .. ((passedLevel % maxStage) + 1)
                BattleUtil.JiecaoHard = math.floor(passedLevel / maxStage) * tonumber(paras[3]) + tonumber(paras[2])
                GameEngine.BattleSelectRole_BattleCallback = LuaTool.MakeStringCallBack(function(winOrLose)
                    if winOrLose == "win" then
                        for i = GameEngine.BattleSelectRole_CurrentForbbidenKeys.Count - 1, 0, -1 do
                            local key = GameEngine.BattleSelectRole_CurrentForbbidenKeys[i]
                            if not forbiddenMap[key] then
                                if RuntimeData.Instance.KeyValues["jiecao_tower_passed"] == "" then
                                    RuntimeData.Instance.KeyValues["jiecao_tower_passed"] = key
                                else
                                    RuntimeData.Instance.KeyValues["jiecao_tower_passed"] = RuntimeData.Instance.KeyValues["jiecao_tower_passed"] .. "#" .. key
                                end
                            end
                        end
                        passedLevel = passedLevel + 1
                        RuntimeData.Instance.KeyValues["jiecao_tower_level"] = tostring(passedLevel)
                        local maxLevel = 0
                        if RuntimeData.Instance.KeyValues:ContainsKey("jiecao_tower_max") then
                            maxLevel = tonumber(RuntimeData.Instance.KeyValues["jiecao_tower_max"]) or 0
                        end
                        -- 有奖励
                        if passedLevel > maxLevel then
                            RuntimeData.Instance.KeyValues["jiecao_tower_max"] = tostring(passedLevel)
                            RuntimeData.Instance:addHaogan(50, "节操")
                            GameEngine:SwitchGameScene("story", "节操塔_挑战成功1")
                        else
                            GameEngine:SwitchGameScene("story", "节操塔_挑战成功2")
                        end
                    else
                        GameEngine:SwitchGameScene("story", "节操塔_挑战失败")
                    end
                end)
                Application.LoadLevel("BattleSelectRole")
            else
                -- 没有可打的人
                RuntimeData.Instance.mapUI:ShowDialog("陆小凰", "你当前所有队友均已出战过节操塔，无法继续爬塔。", LuaTool.MakeVoidCallBack(function()
                    GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
                end))
            end
        end
        return true
    elseif statusType == "changeRolePos" then
        if value == "0" then
            GameEngine:SwitchGameScene("game", "quitappcancel")
            RuntimeData.Instance.mapUI.RoleSelectPanelObj:SetActive(true)
            RuntimeData.Instance.mapUI.roleSelectMenu:Show(RuntimeData.Instance.Team, LuaTool.MakeStringCallBack(function(roleKey)
                RuntimeData.Instance.mapUI.RoleSelectPanelObj:SetActive(false)
                EquipUtil.dialogNpcKey = roleKey
                -- 分两段是为了在显示对话框时隐藏
                GameEngine:SwitchGameScene("story", "系统_改变队友位置")
            end), nil)
        elseif value == "2" then
            RuntimeData.Instance.mapUI.RoleSelectPanelObj:SetActive(true)
            RuntimeData.Instance.mapUI.roleSelectMenu:Show(RuntimeData.Instance.Team, LuaTool.MakeStringCallBack(function(roleKey)
                RuntimeData.Instance.mapUI.RoleSelectPanelObj:SetActive(false)
                EquipUtil.dialogNpcKey = roleKey
                -- 分两段是为了在显示对话框时隐藏
                GameEngine:SwitchGameScene("story", "系统_改变队友位置")
            end), nil)
        elseif value == "1" then
            local callback = LuaTool.MakeVoidCallBack(function()
                GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
            end)
            local roleKey = EquipUtil.dialogNpcKey
            if roleKey == "主角" then
                RuntimeData.Instance.mapUI:ShowDialog("南贤", "主角是不可以调整位置的！", callback)
            else
                RuntimeData.Instance.mapUI.nameInputPanel:Show("输入2~" .. RuntimeData.Instance.Team.Count .. "中的数字", LuaTool.MakeStringCallBack( function(n)
                    n = tonumber(n)
                    if not n or n < 2 or n > RuntimeData.Instance.Team.Count then
                        RuntimeData.Instance.mapUI:ShowDialog("南贤", "输入的数字不正确！", callback)
                    else
                        n = math.floor(n)
                        if (RuntimeData.Instance:AdjustTeamRoleOrder(roleKey .. "#" .. n) == true) then
                            AudioManager.Instance:PlayEffect("音效.装备")
                            RuntimeData.Instance.mapUI:ShowDialog("南贤", "你的队友的位置已移动到第" .. n .. "位！", callback)
                        else
                            RuntimeData.Instance.mapUI:ShowDialog("南贤", "调整位置失败！", callback)
                        end
                    end
                end))
            end
        end
        return true
	end
	if (statusType=="nls") then
        local callback = LuaTool.MakeVoidCallBack(function()
            GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
        end)
      local t=split(value,"#")
      findSprite = RuntimeData.Instance:GetRole(t[1])
      local sl,si = wgcz(findSprite,t[2])
	  local skm1 = CommonSettings.MAX_SKILL_COUNT
      if findSprite.Skills.Count >= skm1 then
        RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
        RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我的外功学习数量已经达到上限，不能学习"..t[2],callback)
       else
        if sl then
          RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
          RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我已经学过"..t[2].."不需要重复学习了",callback)
         else
          RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
          --这句保留与否决定是否为消耗品
          --注释掉则为消耗品否则为永久
          RuntimeData.Instance:addskill(t[1].."#"..t[2])
          RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我学会了"..t[2],callback)
        end
      end
    return true
    elseif (statusType=="nli") then
        local callback = LuaTool.MakeVoidCallBack(function()
            GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
        end)
      local t=split(value,"#")
      findSprite = RuntimeData.Instance:GetRole(t[1])
      local sl,si = ngcz(findSprite,t[2])
	  local skm2 = CommonSettings.MAX_INTERNALSKILL_COUNT
      if findSprite.InternalSkills.Count >= skm2 then
        RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
        RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我的内功学习数量已经达到6个上限，不能学习"..t[2],callback)
       else
        if sl then
          RuntimeData.Instance:addItem(Item.GetItem(t[3]),1) RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我已经学过"..t[2].."不需要重复学习了",callback)
         else
          RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
          --这句保留与否决定是否为消耗品
          --注释掉则为消耗品否则为永久
          RuntimeData.Instance:addskill(t[1].."#"..t[2])
          RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我学会了"..t[2],callback)
        end
      end
    return true
    end
	if (statusType=="nls2") then
        local callback = LuaTool.MakeVoidCallBack(function()
            GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
        end)
      local t=split(value,"#")
      findSprite = RuntimeData.Instance:GetRole(t[1])
      local sl,si = wgcz(findSprite,t[2])
	  local skm1 = CommonSettings.MAX_SKILL_COUNT
      if findSprite.Skills.Count >= skm1 then
        RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
        RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我的外功学习数量已经达到上限，不能学习"..t[2],callback)
       else
        if sl then
          RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
          RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我已经学过"..t[2].."不需要重复学习了",callback)
         else
          --RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
          --这句保留与否决定是否为消耗品
          --注释掉则为消耗品否则为永久
          RuntimeData.Instance:addskill(t[1].."#"..t[2])
          RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我学会了"..t[2],callback)
        end
      end
    return true
    elseif (statusType=="nli2") then
        local callback = LuaTool.MakeVoidCallBack(function()
            GameEngine:SwitchGameScene("map", RuntimeData.Instance.CurrentBigMap)
        end)
      local t=split(value,"#")
      findSprite = RuntimeData.Instance:GetRole(t[1])
      local sl,si = ngcz(findSprite,t[2])
	  local skm2 = CommonSettings.MAX_INTERNALSKILL_COUNT
      if findSprite.InternalSkills.Count >= skm2 then
        RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
        RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我的内功学习数量已经达到6个上限，不能学习"..t[2],callback)
       else
        if sl then
          RuntimeData.Instance:addItem(Item.GetItem(t[3]),1) RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我已经学过"..t[2].."不需要重复学习了",callback)
         else
          --RuntimeData.Instance:addItem(Item.GetItem(t[3]),1)
          --这句保留与否决定是否为消耗品
          --注释掉则为消耗品否则为永久
          RuntimeData.Instance:addskill(t[1].."#"..t[2])
          RuntimeData.Instance.mapUI:ShowDialog(findSprite.key,"我学会了"..t[2],callback)
        end
      end
    return true
    end
	RuntimeData.Instance.mapUI:ShowDialog("指令有误", statusType .. " " .. value, nil)
	return false
end

--用于在物品选择菜单的UI制造条件筛子
local function MakeEmptyDictionary(Itp)
			local Dictionary  = RuntimeData.Instance:GetItems(Itp)
			local Dictionary_temp = LuaTool.CreateLuaTable(Dictionary)
			for k,v in pairs(Dictionary_temp) do
				Dictionary:Remove(v.Key)
			end
			return Dictionary
end
--用于获取指定角色指定triggerName的
--某些属性，属性池
local function gtp(role,triggerName,Index)
    local res={}
    local  trigger= LuaTool.CreateLuaTable(role:GetTriggers(triggerName))
    for _,tr in pairs(trigger) do
    local t=split(tr.ArgvsString,",")
    if t[Index] then
    table.insert(res,t[Index])
    end
    end
    return res
end

--用于克隆装备属性时防意外数据
local function jicheng(eq)
local name=eq.Name
local count=eq.AdditionTriggers.Count
local t={}
    for i=0,eq.AdditionTriggers.Count-1 do
    local value={eq.AdditionTriggers[i].Name,eq.AdditionTriggers[i].ArgvsString}
    table.insert(t,value)
    end
    RuntimeData.Instance:addItem(eq,-1)
local eq2=ItemInstance.Generate(name,false)
    eq2:AddRandomTriggers(count)
    for i=0,#t-1 do
    eq2.AdditionTriggers[i].Name=t[i+1][1]
    eq2.AdditionTriggers[i].ArgvsString=t[i+1][2]
    end
    return eq2
end

--扩展STORY ACTION
function GameEngine_extendStoryAction(this,action,paras,callback)

	local tgiveup= function ()
		RuntimeData.Instance:addItem(Item.GetItem("天赋洗练书"))
		RuntimeData.Instance.MapUI:ShowDialog("提示", "你放弃了选择", callback)
	end
	local  function dialogselect(paramtable,dialog,luafunctiontable)
		action.value=dialog
		this:LoadSelection(action,LuaTool.MakeIntCallBack( function(num)
		num=num+1
       --没有越界检查
       return luafunctiontable[num](paramtable[num])
   end))
end
	local removetalent= function (role)
	return function (talentstring)
		role:RemoveTalent(talentstring)
		this:ShowDialog("提示","天赋  "..talentstring.."  移除成功", callback)
	end
	end

	if action.type=="tianfuxilian" then
	--  local role=RuntimeData.Instance:GetTeamRole(RoleKey)
	local role= role_choose
	local dialog=role.Key.."#要移除哪个天赋呢"
	local luafunction=removetalent(role)
	local luaf={}
	local paramtable={}
	for talent in ilist(role.Talents) do
		table.insert(paramtable,talent)
		dialog=dialog.."#"..talent
		table.insert(luaf,luafunction)
	end
		dialog=dialog.."#我不洗了"
		table.insert(paramtable,"")
		table.insert(luaf,tgiveup)
	dialogselect(paramtable,dialog,luaf)
	return true
	end

if (action.type == "TEMP_BACK") then
if RuntimeData.Instance.Temp.Count>0 then
local count=RuntimeData.Instance.Temp.Count
action.value="主角#打算召回哪个暂离队友？#不召回了。"
for i=0,count-1 do
action.value=action.value.."#我要召回【"..RuntimeData.Instance.Temp[i].Name.."】。"
end
this:LoadSelection(action,LuaTool.MakeIntCallBack(function(scn)
if scn==0 then
this:ShowDialog("主角","你放弃了本次召回操作。",callback)
else
if RuntimeData.Instance:addTeamMemberFromTemp(RuntimeData.Instance.Temp[scn-1].Key)==true then
this:ShowDialog("主角","你已成功召回队友。",callback)
end
end
end))
else
this:ShowDialog("主角","没有可操作对象。",callback)
end
return true
end



    if action.type == "set_skill" then
        EquipUtil.apiStartXuantian(role_choose, callback, 0, "powerup_skill", 10)
        return true
    elseif action.type == "set_iskill" then
        EquipUtil.apiStartXuantian(role_choose, callback, 0, "powerup_internalskill", 10)
        return true
    elseif action.type == "set_jueji" then
        EquipUtil.apiStartXuantian(role_choose, callback, 0, "powerup_uniqueskill", 10)
        return true
    elseif action.type == "set_aoyi" then
        EquipUtil.apiStartXuantian(role_choose, callback, 0, "powerup_aoyi", 10)
        return true
    end
	--if(action.type == "TEST_PRINT") then
	--	print(action.value)
	--	--继续执行下一条ACTION
	--	this:ExecuteNextStoryAction(callback)
	--	return true
	if(action.type == "ZHUANGBEISHENGJI") then
		RuntimeData.Instance:ItemLiveupdate_extendStoryAction(paras,callback)  --装备升级
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "LEAVE_MALES") then
		RuntimeData.Instance:removeMalesTeamMember_extendStoryAction(paras,callback)  --离队所有男性
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "LEAVE_FEMALES") then
		RuntimeData.Instance:removeFemalesTeamMember_extendStoryAction(paras,callback)  --离队所有女性
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "RANDOMITEM") then
		RuntimeData.Instance:GetRandomItem_extendStoryAction(paras,callback)  --获取随机装备
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "JOIN_TEMP") then
		RuntimeData.Instance:addTempMemberFromTeam_extendStoryAction(paras,callback)  --从队伍中改变为暂时离队
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "TEMP_JOIN") then
		RuntimeData.Instance:addTeamMemberFromTemp_extendStoryAction(paras,callback)  --从暂时离队回到队伍中
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "FOLLOW_TEMP") then
		RuntimeData.Instance:addTempMemberFromFollow_extendStoryAction(paras,callback)  --从跟随中改变为暂时离队
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "TEMP_FOLLOW") then
		RuntimeData.Instance:addFollowMemberFromTemp_extendStoryAction(paras,callback)  --从暂时离队回到跟随中
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "LEAVE_TEMP") then
		RuntimeData.Instance:removeTempMember_extendStoryAction(paras,callback)  --将暂时离队的人彻底删除属性(再次入队时恢复初始属性)
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "JOIN_TEMP_V2") then
		RuntimeData.Instance:addTempMemberFromTeamV2_extendStoryAction(paras,callback)  --从队伍中改变为暂时离队: 模糊查找
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "FOLLOW_TEMP_V2") then
		RuntimeData.Instance:addTempMemberFromFollowV2_extendStoryAction(paras,callback)  --从跟随中改变为暂时离队: 模糊查找
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "TEMP_JOIN_V2") then
		RuntimeData.Instance:addTeamMemberFromTempV2_extendStoryAction(paras,callback)  --从暂时离队回到队伍中: 模糊查找
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "TEMP_FOLLOW_V2") then
		RuntimeData.Instance:addFollowMemberFromTempV2_extendStoryAction(paras,callback)  --从暂时离队回到跟随中: 模糊查找
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "LEAVE_TEMP_V2") then
		RuntimeData.Instance:removeTempMemberV2_extendStoryAction(paras,callback)  --将暂时离队的人彻底删除属性(再次入队时恢复初始属性): 模糊查找
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "TO_CHINESETIME") then
		RuntimeData.Instance:toChineseTime_extendStoryAction(paras,callback)  --跳转到指定时辰：子丑寅卯辰巳午未申酉戌亥
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "HEAD_V2") then
		RuntimeData.Instance:touxiang_extendStoryAction(paras,callback)  --设置角色的头像,调用格式: <action type="HEAD_V2" value="南贤#xxxx" />
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "EXIT_MENPAI") then
		RuntimeData.Instance:exit_menpai_extendStoryAction(paras,callback)  --退出门派（不带参数则默认提示）
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "CHANGE_ROLE_NAME") then
		RuntimeData.Instance:change_role_name_extendStoryAction(paras,callback)  --队友改名（手工输入名字框）
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "SPECIFIED_ROLE_NAME") then
		RuntimeData.Instance:specified_role_name_extendStoryAction(paras,callback)  --队友指定名字（直接指定新名字）示例：<action type="SPECIFIED_ROLE_NAME" value="南贤#xxxx" />
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "CLONE_TEAM_ROLE") then
		RuntimeData.Instance:clone_team_role_extendStoryAction(paras,callback)  --克隆队友属性并加入新队友
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "SHOW_CLOUD") then
		RuntimeData.Instance:ShowCloud_extendStoryAction(paras,callback)  --是否显示大地图云彩：1:显示，0:隐藏。示例：<action type="SHOW_CLOUD" value="0" />
		--继续执行下一条ACTION
		--this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "CALLBACKMAN") then
		RuntimeData.Instance:addAllTeamMemberFromTemp(false)  --从暂时离队回到队伍中: nan
		--继续执行下一条ACTION
		this:ExecuteNextStoryAction(callback)
		return true
	elseif(action.type == "CALLBACKWOMAN") then
		RuntimeData.Instance:addAllTeamMemberFromTemp(true)  --从暂时离队回到队伍中: nv
		--继续执行下一条ACTION
		this:ExecuteNextStoryAction(callback)
		return true
	end
	if action.type=="CUTML" then
    local s=LuaTool.CreateLuaTable(ModData.SkillMaxLevels)
	local s2=math.max(unpack({RuntimeData.Instance.Round, ModData.GetParam(ModData.MAX_ROUND_KEY)}))
    for _,v in pairs(s) do
      if s2<50 and tonumber(v.Value)> 31 then
        ModData.AddSkillMaxLevel(v.Key,10-tonumber(v.Value))
		--ModData.SkillMaxLevels:Clear()
      end
    end
    this:ExecuteNextStoryAction(callback)
    return true
	end
	if action.type=="zuobichenfa" then
	rins.Money=0
	rins.Items:Clear()
	rins.Xiangzi:Clear()
	ModData.Nicks:Clear()
	ModData.SkillMaxLevels:Clear()
	ModData.SetParam("yuanbao",0)
	ModData.AddNick("惜花月饼")
    this:ExecuteNextStoryAction(callback)
    return true
	end
    if action.type == "INPUT_TEXT" then
        RuntimeData.Instance.mapUI.nameInputPanel:Show(paras[0], LuaTool.MakeStringCallBack( function(text)
            RuntimeData.Instance.KeyValues["INPUT_TEMP"] = text
            this:ExecuteNextStoryAction(callback)
        end))
        return true
    end
    if action.type == "item_dialog" then
        if paras[0] == "0" then
            if EquipUtil.HasUnfinishedItems.count == 1 then
                this:ShowDialog(EquipUtil.HasUnfinishedItems.key, "你使用了道具！", LuaTool.MakeVoidCallBack(function()
                    this:ExecuteNextStoryAction(callback)
                end))
            else
                this:ExecuteNextStoryAction(callback)
            end
        else
            EquipUtil.AddUnfinishedItems(EquipUtil.HasUnfinishedItems, callback)
            EquipUtil.HasUnfinishedItems = nil
        end
        return true
    end
    if action.type == "set_auto_count" then
        BattleUtil.AutoCount = tonumber(paras[0])
        this:ExecuteNextStoryAction(callback)
        return true
    end
    if action.type == "JIECAO_DIALOG" then
        local str = paras[1]
        local passedLevel = "0"
        if RuntimeData.Instance.KeyValues:ContainsKey("jiecao_tower_level") then
            passedLevel = RuntimeData.Instance.KeyValues["jiecao_tower_level"]
        end
        local maxLevel = "0"
        if RuntimeData.Instance.KeyValues:ContainsKey("jiecao_tower_max") then
            maxLevel = RuntimeData.Instance.KeyValues["jiecao_tower_max"]
        end
        str = string.gsub(str, "%$JIECAO_LEVEL%$", passedLevel)
        str = string.gsub(str, "%$JIECAO_MAX%$", maxLevel)
        this:ShowDialog(paras[0], str, LuaTool.MakeVoidCallBack(function()
            this:ExecuteNextStoryAction(callback)
        end))
        return true
    end
	return false
end

--扩展江湖历练UI面板
function GameEngine_jianghuContent(this)

	local result
	result = "<color='#D0104C'>绅士无双_后宫版V119.5 ———— 20220130版：</color>\n"
	result = result .. "\n"
	result = result .. "   <color='#E16B8C'>              一入无双深似海，从此节操是路人。 </color> \n"
	result = result .. "\n"
	result = result .. "<color='#007d65'>" .. RuntimeData.Instance.maleName .. "</color>的基本信息：\n"
	result = result .. "  道德值：<color='red'>" .. RuntimeData.Instance.Daode .. "</color>\n"
        result = result .. "  淫邪值：<color='red'>" .. RuntimeData.Instance:getHaogan("淫邪") .. "</color>    "
        result = result .. "  后宫数：<color='red'>" .. RuntimeData.Instance:getHaogan("后宫") .. "</color>    "
        result = result .. "  绿帽值：<color='#227D51'>" .. RuntimeData.Instance:getHaogan("ntr") .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目生命、内力上限： <color='#0089A7'>" .. CommonSettings.MAX_HPMP .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目等级上限： <color='#0089A7'>" .. CommonSettings.MAX_LEVEL .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目内功等级上限： <color='#0089A7'>" .. CommonSettings.MAX_INTERNALSKILL_LEVEL .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目外功等级上限： <color='#0089A7'>" .. CommonSettings.MAX_SKILL_LEVEL .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目内功种类上限： <color='#0089A7'>" .. CommonSettings.MAX_INTERNALSKILL_COUNT .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目外功种类上限： <color='#0089A7'>" .. CommonSettings.MAX_SKILL_COUNT .. "</color>\n"
	result = result .. "  松鼠旅馆箱子存储量：<color='#0089A7'>" .. RuntimeData.Instance.XiangziCount .. " / " .. RuntimeData.Instance.MaxXiangziItemCount .. "</color>\n"
	result = result .. "  霹雳堂已通过人数：<color='#0089A7'>" .. RuntimeData.Instance:GetTrialRolesCount() .. "</color>  人 \n"
	result = result .. "  剩余节操值  <color='#0089A7'>" .. RuntimeData.Instance:getHaogan("节操") .. "</color>  点 \n"
	result = result .. "  总共死亡  <color='#0089A7'>" .. ModData.GetParam(ModData.DEAD_KEY) .. "</color>  次  "
	result = result .. "  总共存档  <color='#0089A7'>" .. ModData.GetParam(ModData.SAVE_KEY) .. "</color>  次  "
	result = result .. "  总共击杀  <color='#0089A7'>" .. ModData.GetParam(ModData.TOTALKILL_KEY) .. "</color>  个敌人\n"
	result = result .. "  总共通关了  <color='#0089A7'>" .. ModData.GetParam(ModData.END_COUNT_KEY) .. "</color>次  "
	result = result .. "  达过的最高周目：<color='#0089A7'>" .. math.max(unpack({RuntimeData.Instance.Round, ModData.GetParam(ModData.MAX_ROUND_KEY)})) .. "</color>周目\n"
	result = result .. "  当前存档位置： <color='#0089A7'>" .. RuntimeData.Instance.maleName .. "</color>  存在了  <color='#0089A7'>" .. ModData.GetParam(ModData.last_save_index) .. "</color>号档\n"
	result = result .. "\n"
	result = result .. "女主基本信息：\n"
	result = result .. "  <color='#D75455'>" .. RuntimeData.Instance.femaleName .. "</color>  爱情值  <color='#6950a1'>" .. RuntimeData.Instance:getHaogan() .. "</color>\n"
	result = result .. "  <color='#D75455'>" .. RuntimeData.Instance.femaleName .. "</color>  淫乱值  <color='#6950a1'>" .. RuntimeData.Instance:getHaogan("淫乱") .. "</color>\n"
	result = result .. "\n"
	result = result .. "共通线可攻略女性角色好感度：\n"
	result = result .. "天书角色：\n"
        result = result .. "木婉清（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("木婉清") .. "</color>）"
        result = result .. "    王语嫣（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("王语嫣") .. "</color>）"
        result = result .. "    梅超风（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("梅超风") .. "</color>）"
        result = result .. "    郭芙（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("郭芙") .. "</color>）"
        result = result .. "    郭襄（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("郭襄") .. "</color>）\n"
        result = result .. "霍青桐（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("霍青桐") .. "</color>）"
        result = result .. "    李文秀（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("李文秀") .. "</color>）"
        result = result .. "    萧中慧（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("萧中慧") .. "</color>）"
        result = result .. "    水笙（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("水笙") .. "</color>）"
        result = result .. "    黄蓉（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("黄蓉") .. "</color>）\n"
        result = result .. "何红药（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("何红药") .. "</color>）"
        result = result .. "    周芷若（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("周芷若") .. "</color>）"
        result = result .. "    赵   敏（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("赵敏") .. "</color>）"
        result = result .. "    阿九（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("阿九") .. "</color>）"
		result = result .. "    阿紫（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("阿紫") .. "</color>）\n"
        result = result .. "东方不败（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("东方不败") .. "</color>）\n"

        result = result .. "\n"
	result = result .. "侠客风云传角色：\n"
	result = result .. "风吹雪（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("风吹雪") .. "</color>）"
        result = result .. "    任清璇（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("任清璇") .. "</color>）"
        result = result .. "    姬无双（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("姬无双") .. "</color>）"
	result = result .. "    沈湘芸（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("沈湘芸") .. "</color>）"
        result = result .. "    秦红殇（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("秦红殇") .. "</color>）\n"
	result = result .. "\n"
	result = result .. "仙剑奇侠传角色：\n"
	result = result .. "赵灵儿（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("赵灵儿") .. "</color>）"
        result = result .. "    林月如（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("林月如") .. "</color>）"
        result = result .. "    李筱筠（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("李筱筠") .. "</color>）"
        result = result .. "    林青儿（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("林青儿") .. "</color>）"
	result = result .. "    阿奴（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("阿奴") .. "</color>）\n"
	result = result .. "\n"
	result = result .. "其它角色：\n"
        result = result .. "向淅（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("向淅") .. "</color>）"
        result = result .. "  南    贤（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("南贤") .. "</color>）"
        result = result .. "  北    丑（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("北丑") .. "</color>）"
        result = result .. "  魏雨婷（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("魏雨婷") .. "</color>）"
        result = result .. "  王雪玲（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("王雪玲") .. "</color>）\n"
        result = result .. "姬媛（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("姬媛") .. "</color>）"
        result = result .. "  路雅楠（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("路雅楠") .. "</color>）"
		result = result .. "  冷雨柔（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("冷雨柔") .. "</color>）"
        result = result .. "  风宿玲（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("风宿玲") .. "</color>）\n"
		result = result .. "\n"
		result = result .. "\n"
	result = result .. "门派专属角色好感度：\n"
        result = result .. "少林派：    李沧海（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("李沧海") .. "</color>）\n"
        result = result .. "血刀门：    戚    芳（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("戚芳") .. "</color>）\n"
        result = result .. "武当派：    李沅芷（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("李沅芷") .. "</color>）"
        result = result .. "    何秋娟（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("何秋娟") .. "</color>）"
        result = result .. "    杨不悔（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("杨不悔") .. "</color>）\n"
        result = result .. "                   刘子璇（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("刘子璇") .. "</color>）"
		result = result .. "    刘子怡（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("刘子怡") .. "</color>）"
		result = result .. "    殷素素（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("殷素素") .. "</color>）\n"
        result = result .. "古墓派：    杨冰儿（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("杨冰儿") .. "</color>）"
        result = result .. "    小龙女（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("小龙女") .. "</color>）\n"
        result = result .. "灵鹫宫：    李秋水（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("李秋水") .. "</color>）\n"
        result = result .. "青城派：    岳灵珊（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("岳灵珊") .. "</color>）\n"
        result = result .. "神水宫：    桑飞虹（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("桑飞虹") .. "</color>）"
        result = result .. "    凌霜华（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("凌霜华") .. "</color>）"
        result = result .. "    白洁  （<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("白洁") .. "</color>）"
        result = result .. "    水母阴姬（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("水母阴姬") .. "</color>）\n"
        result = result .. "合欢宗：    梦魅月（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("梦魅月") .. "</color>）"
        result = result .. "    魇媚星（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("魇媚星") .. "</color>）"
        result = result .. "    独孤嫣然（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("独孤嫣然") .. "</color>）\n"
        result = result .. "全真教：    林朝英（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("林朝英") .. "</color>）"
		result = result .. "    孙不二（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("孙不二") .. "</color>）"
		result = result .. "    公孙绿萼（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("公孙绿萼") .. "</color>）\n"
		result = result .. "丐   帮：     黄    蓉（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("丐帮黄蓉") .. "</color>）\n"
		result = result .. "桃花岛：    梅若华（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("梅若华") .. "</color>）"
		result = result .. "     黄    蓉（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("桃花黄蓉") .. "</color>）\n"
        result = result .. "唐   门：     唐书雁（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("唐书雁") .. "</color>）"
        result = result .. "    唐小婉（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("唐小婉") .. "</color>）"
        result = result .. "    唐雪见（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("唐雪见") .. "</color>）\n"
		result = result .. "铸剑山庄： 莫  邪（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("莫邪") .. "</color>）"
		result = result .. "    西  施（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("西施") .. "</color>）"
		result = result .. "    阿  青（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("红颜阿青") .. "</color>）\n"
		result = result .. "五岳剑派： 蓝凤凰（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("蓝凤凰") .. "</color>）"
		result = result .. "    曲非烟（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("曲非烟") .. "</color>）\n"
        result = result .. "无门派：     郑婷予（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("郑婷予") .. "</color>）"
        result = result .. "    白翎羽（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("白翎羽") .. "</color>）"
		result = result .. "    江    雪（<color='#6950a1'>" .. RuntimeData.Instance:getHaogan("江雪") .. "</color>）\n"
	result = result .. "\n"
	result = result .. "\n"
	--result = result .. "<color='red'>指令大全精简版：</color>\n"
	--result = result .. "<color='green'>1.内置指令：</color>\n"
	--result = result .. "【story】【map】【rollroll】【tutorial】【battle】【arena】【trial】【tower】\n"
	--result = result .. "【nextTower】【huashan】【nextHuashan】【restart】【nextZhoumu】\n"
	--result = result .. "【gameOver】【gameFin】【shop】【game levelup】【game 升级】\n"
	--result = result .. "【game qinggong】【game dianxue】【mainmenu】【menpai】【xiangzi】\n"
	--result = result .. "【item】【randomitem】【addround】【join】【zhenlongqiju】\n"
	--result = result .. "【zhenlonglevel】【xilian】【reloadlua】【get_money】【play_music】\n"
	--result = result .. "<color='green'>2.MOD扩展指令：</color>\n"
	--result = result .. "【技能】【头像】【模型】【遣散】【属性增加】【加入队友】\n"
	--result = result .. "【调整队伍顺序】【调整队伍顺序2】\n"
	--result = result .. "【暂时离队】【回到队伍】【暂时离队2】【回到队伍2】【跳转时辰】\n"
	--result = result .. "【加入所有男队友】【加入所有女队友】【主角改名】【女主改名】【退出门派】【暂离所有男队友】【元宝增加】【道德增加】\n"
	--result = result .. "【暂离所有女队友】【回队所有男队友】【回队所有女队友】【技能删除】【天赋替换】【天赋增加】【天赋删除】【HPMP】【好感增加】\n"
	--result = result .. "【加入所有男队友2】【加入所有女队友2】\n"
	--result = result .. "【遣散所有男队友】【遣散所有女队友】\n"
	--result = result .. "<color='red'>注：以上指令的详细说明请参阅文件“指令大全.txt”</color>\n"
	return result
end

function GameEngine_character(this)
	--目前只能定义4组数据，为剧本的name前缀。分别对应性格1-4。
	--修改该函数后，需要再修改rollrole.lua文件的开场问题（ROLLROLE_QUESTIONS[2]）
    return "传统型_#开放型_#女仆型_#御姐型_"
end

function string.split(input, delimiter)
    input = tostring(input)
    delimiter = tostring(delimiter)
    if (delimiter=='') then return false end
    local pos,arr = 0, {}
    -- for each divider found
    for st,sp in function() return string.find(input, delimiter, pos, true) end do
        table.insert(arr, string.sub(input, pos, st - 1))
        pos = sp + 1
    end
    table.insert(arr, string.sub(input, pos))
    return arr
end


function GameEngine_mazeContent(this)
	local result = "<color=red>迷宫指引</color>\n"
	result = result .. "^b\n"

	result = result .. " 华山后山：前前左右（右左右）- 华山山洞（令狐冲，收袁承志）  \n"
	result = result .. " 华山后山：前前左前（右左前）- 华山仙境（金蛇郎君）　 \n"
	result = result .. " 黑木崖小路：前左前左—黑木崖（令狐冲）— 黑木崖密洞　  \n"
	result = result .. " 峨眉山：左左右右—峨眉金顶（郭襄变身剧情）　  \n"
	result = result .. " 大理五毒教：右前前前—五毒教（钟灵，令狐冲）　  \n"
	result = result .. " 五毒教深处：右右右前—金蛇窟（袁承志金蛇剑，何红药）　  \n"
	result = result .. " 昆仑山：右—昆仑山仙境（张无忌，雪莲花）　  \n"
	result = result .. " 昆仑山：左前—昆仑山山洞（血刀老祖）　  \n"
	result = result .. " 昆仑山：左左左左—昆仑山天池（达摩少林剧情）　  \n"
	result = result .. " 昆仑山：左左左右右前—昆仑山之巅（天山大侠，白自在，鼠洞）   \n"
	result = result .. " 昆仑山：左左左右右左—昆仑山山坡（冷雨柔）      \n"
	result = result .. " 潇湘古林：左—衡阳郊外（曲非烟，陆羽）　　  \n"
	result = result .. " 潇湘古林：前前—衡山派（莫大）　　　　  \n"
	result = result .. " 潇湘古林：右前右—湘江（神水宫）　  \n"
	result = result .. " 潇湘古林：右前左前左—桃花源（汉家松鼠）　  \n"
	result = result .. " 潇湘古林：右前左左—唐诗山洞（狄云血刀剧情）　  \n"
	result = result .. " 潇湘古林：右前左右—药王庄（毒手药王，胡斐，程灵素变身）　 \n"
	result = result .. " 长安一梦山洞：前(或右)左—汉家松鼠　  \n"
	result = result .. " 长安一梦山洞：前(或右)左前左—小玉　  \n"
	result = result .. " 谜境：前左前一谜境山庄 \n"


	return result
end























	--[[result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目，敌人攻击成长值： <color='#0089A7'>" .. CommonSettings.ZHOUMU_ATTACK_ADD .. " X " .. RuntimeData.Instance.Round .. "</color>\n"
	result = result .. "  第 <color='#0089A7'>" .. RuntimeData.Instance.Round .. "</color> 周目，敌人防御成长值： <color='#0089A7'>" .. CommonSettin
	--]]