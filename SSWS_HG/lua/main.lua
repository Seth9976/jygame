--[[
 金庸群侠传X外接脚本公用配置文件
 汉家松鼠工作室(http://www.jy-x.com)
]]--

local Debug = luanet.import_type('UnityEngine.Debug')
local Color = luanet.import_type('UnityEngine.Color')
local Tools = luanet.import_type('JyGame.Tools')
local LuaTool = luanet.import_type('JyGame.LuaTool')
local AudioManager = luanet.import_type('JyGame.AudioManager')
local logger = luanet.import_type('JyGame.FileLogger').instance
local RuntimeData = luanet.import_type('JyGame.RuntimeData')

_G.MAIN_LUA_MASK = "2021-09-30-FLAG"

--载入的LUA文件列表
function ROOT_getLuaFiles()
	return {
		"rollrole.lua",
		"triggerlogic.lua",
		"battle.lua",
		"AttackLogic.lua",
		"GameEngine.lua",
		"AI.lua",
		"skill.lua",
		"buff.lua",
		"item.lua",
	}
end

--资源载入完成
--这里一般用于做数据调试和测试
function ROOT_onInitedResources()
	logger:Log("game started..")
end

--配置列表
function ROOT_getConfigList()
	return {
		--主菜单音乐（默认："音乐.武侠回忆" ）
		MAINMENU_MUSIC = "音乐.兰君",
		--默认：true，false
		CONSOLE = true,
		--主菜单背景图（默认："地图.绅士武侠"）
		--MAINMENU_BG = "地图.绅士武侠",
		MAINMENU_BG = LuaTool.MakeStringArray({
			--"地图.片头0",
			"地图.片头1",
			"地图.片头2",
			"地图.片头3",
			"地图.片头4",
			--"地图.片头5",
			--"地图.片头6",
			--"地图.片头7",
			--"地图.片头8",
			--"地图.片头0",
			--"地图.片头I",
			--"地图.片头J",
			--"地图.片头K",
			--"地图.片头2A",
			"地图.片头2B",
			"地图.片头2D",
			"地图.片头2E",
			"地图.片头2F",
			"地图.片头2G",
		}),

		--预加载图片：1开启，0关闭（默认：0）
        PRECACHE_TEXTURE = 0,

       --游戏帧率FPS：20--60之间（默认：60）
        FRAME_RATE = 40,

        --技能施放延时系数：-1.0--0.1之间（默认-1.0）
        SKILL_DELAY_COEFFICIENT = 0.01,

		--开场剧本（默认："新手村_出生"）
		gamestart_story = "新手村_出生",

		--开场地点（默认："南贤居"）
		gamestart_location = "南贤屋内",

		--每周目敌人增加攻击力比例（默认：0.1）
		ZHOUMU_ATTACK_ADD = 0.086,

		--每周目敌人增加的防御力比例（默认：0.08）
		ZHOUMU_DEFENCE_ADD = 0.06,

		--每周目敌人增加血量比例（默认：0.15）
		ZHOUMU_HP_ADD = 0.15,

		--每周目敌人增加内力比例（默认：0.15）
		ZHOUMU_MP_ADD = 0.15,

		--多少个周目提高一级武功等级上限（默认：2）
		PER_MAXLEVEL_ADD_BY_ZHOUMU = 99,

		--NPC多少个周目提高所有武功等级1级（默认：2）
		NPC_SKILL_LEVEL_ADD_BY_ZHOUMU = 1,

		--默认最大战斗时间（默认：3000）
		DEFAULT_MAX_GAME_SPTIME = 3000 + RuntimeData.Instance.Round * 200 ,

		--最大内功数量（默认：5）
		MAX_INTERNALSKILL_COUNT = 4 + ( RuntimeData.Instance.Round  / ( RuntimeData.Instance.Round + 10 ) ) * 6,

		--最大外功数量（默认：10）
		MAX_SKILL_COUNT = 9 + ( RuntimeData.Instance.Round / ( RuntimeData.Instance.Round + 8 ) ) * 6 ,

		--最大可分点属性值（默认：200）
		MAX_ATTRIBUTE = 250+RuntimeData.Instance.Round*3,

		--最大外功等级（默认：20）
		MAX_SKILL_LEVEL = 13 + ( ( RuntimeData.Instance.Round * 2-1 ) / ( RuntimeData.Instance.Round * 2 + 9 ) ) * 20,

		--最大内功等级（默认：20）
		MAX_INTERNALSKILL_LEVEL = 13 + ( ( RuntimeData.Instance.Round * 2 -1 ) / ( RuntimeData.Instance.Round * 2 + 9) ) * 20,

		--战斗元宝掉率(默认：0.5%)
		YUANBAO_DROP_RATE = 0.05,

		--最大血内上限（默认：10000）
		MAX_HPMP = 44000,

		--每周目增长血内上限（默认：1000）
		MAX_HPMP_PER_ROUND = 4000,

		--人物等级上限（默认：30）
		--MAX_LEVEL = 20 + ( ( RuntimeData.Instance.Round * 2 + 10 ) / ( RuntimeData.Instance.Round * 2 + 20 ) ) * 21,
		MAX_LEVEL = 30,

		--箱子物品上限（默认：8 + RuntimeData.Instance.Round * 6）
		MAX_XIANGZI_ITEM_COUNT = 100 + RuntimeData.Instance.Round * 10,

		--困难残章掉率(1.5%，默认：0.015)
		HARD_MODE_CANZHANG_DROPRATE = 0.05,

		--炼狱以上难度残章基础掉率(3%，默认：0.03)
		CRAZY_MODE_CANZHANG_DROPRATE = 0.25;

		--炼狱以上难度残章基础掉率每周目递增(0.5%，默认：0.005)
		CRAZY_MODE_CANZHANG_DROPRATE_PER_ROUND = 0,

		--外功最大掉落残章的武学难度值(不含，默认：8)
		CANZHANG_MAX_HARD_SKILL = 11,

		--内功最大掉落残章的武学难度值(不含，默认：8)
		CANZHANG_MAX_HARD_INTERNALSKILL = 11,

		--外功残章掉率是内功的多少倍（默认：2.0）
		CANZHANG_DROP_RATE_INTERNAL_RATE = 2,

		ENCRYPT_SAVE =0,
		--随机战斗音乐
		randomBattleMusics = LuaTool.MakeStringArray({
			"战斗音乐.云狐之战",
			"战斗音乐.暮云出击",
			"战斗音乐.山谷行进",
			"战斗音乐.山谷行进2",
			"战斗音乐.2",
			"战斗音乐.3",
			"战斗音乐.4",
			"战斗音乐.5",
			"战斗音乐01",
			"战斗音乐02",
			"战斗音乐03",
			"战斗音乐04",
			"战斗音乐05",
			"战斗音乐06",
			"战斗音乐07",
			"战斗音乐08",
			"战斗音乐09",
			"战斗音乐10",
		}),

		--困难难度 NPC随机天赋池
		EnemyRandomTalentsList = LuaTool.MakeStringArray({
			"飘然","斗魂","哀歌","奋战","百足之虫",
			"真气护体","暴躁","金钟罩","自我主义","大小姐",
			"破甲","好色","瘸子","白内障","左手剑",
			"右臂有伤",
			"拳掌增益",
			"剑法增益",
			"刀法增益",
			"奇门增益",
		}),

		--说明：炼狱、无悔难度是每次从以下3个天赋池中各取一个
		--炼狱、无悔难度下NPC随机天赋池1
		EnemyRandomTalentListCrazy1 = LuaTool.MakeStringArray({
			"金刚","清风","御风","俗家弟子","无相",
			"嗜血狂魔","阴毒","阴阳","剑心","心眼","洞察",
			"百足之虫","真气护体","金钟罩","灵心慧质",
			"乾坤大挪移","哀歌","心若冰清","百穴归一",
			"救死扶伤","油嘴滑舌","灵台清明","舍己为人",
		}),

		--炼狱、无悔难度下NPC随机天赋池2
		EnemyRandomTalentListCrazy2 = LuaTool.MakeStringArray({
			"刀封印","剑封印","奇门封印","拳掌封印",
			"琴胆剑心","阴谋家","追魂","破甲",
			"斗魂","奋战","素心神剑改","左右互搏术",
			"毒圣","狠毒","大力士","八百圣贤像",
			"幽谷情花","龙回首","蓄力","七伤神拳",
			"御气","意外之王","天道轮回","狂怒",
		}),

		--炼狱、无悔难度下NPC随机天赋池3
		EnemyRandomTalentListCrazy3 = LuaTool.MakeStringArray({
			"好色","鲁莽","轻功高超","百战无前",
			"铁口直断","锐眼","左手剑",
			"冰心","烈焰","诅咒","嗜酒如命",
			"钢铁意志","金丝宝甲","铁壁","铁布衫",

		}),

		--同福客栈小游戏最大提升到的属性值（默认：70）
		SMALLGAME_MAX_ATTRIBUTE = 100,

		--奥义呐喊（女声）
		AOYI_SOUND_FEMALE = LuaTool.MakeStringArray({
			"音效.女", "音效.女2", "音效.女3", "音效.女4","音效.女01", "音效.女02", "音效.女03",
		}),

		--奥义呐喊（男声）
		AOYI_SOUND_MALE = LuaTool.MakeStringArray({
			"音效.男", "音效.男2", "音效.男3", "音效.男4", "音效.男5", "音效.男-哼", "音效.男01", "音效.男02", "音效.男03",
		}),

		--奥义音效（随机选取）
		AOYI_EFFECT = LuaTool.MakeStringArray({
			"音效.内功攻击4", "音效.打雷", "音效.奥义1", "音效.奥义2", "音效.奥义3", "音效.奥义4", "音效.奥义5", "音效.奥义6"
		}),

		--珍珑棋局随机掉落武器
		ZHENLONG_WUQI = LuaTool.MakeStringArray({
			 "真.倚天剑","真.天龙宝剑","玄铁剑","鸣凤剑","真武剑",
			 "真.屠龙刀","鸳鸯宝刀","血刀","被诅咒的木刀","飞狐宝刀","霹雳狂刀",
			 "游龙鞭","霸王枪","孤鸿影","真.打狗棒",
			 "真.灭仙爪","真.月梦爪","定鼎山河","墨家机关拳",

		}),

		--珍珑棋局防具
		ZHENLONG_FANGJU = LuaTool.MakeStringArray({
			"黄金重甲","幽梦衣","霓裳羽衣","岳飞的重铠","千变魔女的披风","乌蚕衣","三清袍","姜子牙的道袍","蚩尤的护甲"
		}),

		--珍珑棋局饰品
		ZHENLONG_SHIPIN = LuaTool.MakeStringArray({
			"水晶护符","魔神信物","神奇戒指","孙悟空的紧箍咒","墨玉","莽毒蛛蛤",
			"渡元禅师的木鱼","达摩祖师的木鱼","独孤求败的草帽",
		}),

		--BUFF列表
		BUFF_LIST = LuaTool.MakeStringArray({
			"攻击强化","防御强化","恢复", "集气", "飘渺", "左右互搏术",
			"攻击增强","防御增强","溜须拍马", "易容", "沾衣十八跌",
			"狂战", "坚守", "圣战", "轻身", "魔神降临", "神行",
			"不动如山", "醉酒",
			"五岳剑气", "归元", "亢龙有悔", "续命", "天人合一",
			"专注", "御气", "猛攻", "王权护佑", "刺客无双",
			"蓄势", "千钧劲", "御剑", "佛法", "五毒引", "御百兵",
			"机巧","四圣附体","玉碎","笔力","涅槃",
			"摧破真气","固守","同心","战阵","弓势",
			"游龙","解体","寒气入体","拆招","轻灵",
			"舍命","万马奔腾","纯阳","太极","山河",
			-- "护盾","神速攻击",
		}),

		--DEBUFF列表
		DEBUFF_LIST = LuaTool.MakeStringArray({
			"中毒", "内伤", "致盲", "缓速", "晕眩", "攻击弱化", "防御弱化",
			"诸般封印", "剑封印", "刀封印","拳掌封印", "奇门封印",
			"伤害加深", "重伤", "定身", "诅咒", "麻痹", 
			"剧毒", "噬灵", "迷魂", "情花奇毒", "封穴",
			"烈焰", "寒冰", "断筋", "鬼话", "飘渺解除",
			"中毒加深","惊魂","真气紊乱","异种真气",
			"大斗小秤",
		}),

		--游戏战斗加速倍速（默认：1.5）
		BATTLE_SPEEDUP_RATE = 2,

		--战斗场景X坐标格数（默认：11）
		BATTLE_MOVEBLOCK_MAX_X = 14,

		--战斗场景Y坐标格数（默认：4）
		BATTLE_MOVEBLOCK_MAX_Y = 5,

		--战斗场景格子长度（默认：80）
		BATTLE_MOVEBLOCK_LENGTH = 72,

		--战斗场景格子宽度（默认：80）
		BATTLE_MOVEBLOCK_WIDTH = 72,

		--战斗场景右边距（默认：5，单位：格子数）
		BATTLE_MOVEBLOCK_MARGIN_RIGHT = 6.5,

		--战斗场景上边距（默认：2，单位：格子数）
		BATTLE_MOVEBLOCK_MARGIN_TOP = 2,

		--战斗场景格子大小修正（默认：1.25，单位：倍数）
		--注意：格子的实际大小为64*64，但金X默认值为1.25倍（即80*80）
		BATTLE_MOVEBLOCK_SCALE = 1.125,

		--战斗场景格子移除（10格以内）（默认为""）。设置格式：x1,y1,注释（可选）#x2,y2,注释（可选）#x3,y3,注释（可选），例如：0,4#11,4,右上角#11,0,右下角
		BATTLE_MOVEBLOCK_REMOVE = "",

		BUFF_SKILL_CD = 55,
		ITEM_TRIGGERS_XML=1,
		DIALOG_CURRENT_TIMER=0.02,
		DIALOG_TIMER=-1,
	}
end

	function DodgeAward(num)
  if (num >= 5 and num < 10) then
    return "特制鸡腿"
   elseif (num >= 10 and num < 14) then
    return "冬虫夏草#金丝道袍#阔剑#精钢拳套#金刚杵#柳叶刀"
   elseif (num >= 10 and num < 15) then
    return "生生造化丹#冬虫夏草#罗汉拳谱#天山掌法谱#松风剑法秘籍#华山剑法秘籍#三分剑术#雷震剑法秘籍#南山刀法谱#袖箭秘诀#拂尘秘诀#蛇鹤八打"
	elseif (num >= 15 and num < 20) then
		return "药品包裹#同福大礼包"
	elseif (num >= 20 and num < 25) then
		return "同福大礼包"
	elseif (num >= 25) then
		return "凌波微步图谱#天下轻功总决"
  end
  return ""
end

--同福客栈小游戏白展堂奖励物品定义, unique=true或false, 随机物品以#分隔
	function WhacAMoleAward(unique)
	if (unique == true) then
		return "柳叶刀#金丝道袍#黄金项链#乌蚕衣#花熏伞"
	end
	return "同福大礼包#生生造化丹#花熏伞#血刀#乌蚕衣"  --unique=false
	end
