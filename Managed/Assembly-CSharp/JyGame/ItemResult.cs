using System.Collections.Generic;
using LuaInterface;

namespace JyGame;

public class ItemResult
{
	public int Hp;

	public int Mp;

	public int DescPoisonLevel;

	public int DescPoisonDuration;

	public int Balls;

	public int MaxHp;

	public int MaxMp;

	public string UpgradeSkill = string.Empty;

	public string UpgradeInternalSkill = string.Empty;

	public List<Buff> Buffs;

	public LuaTable data = LuaTool.CreateLuaTable();

	public int MaxGengu;

	public int MaxBili;

	public int MaxFuyuan;

	public int MaxShenfa;

	public int MaxDingli;

	public int MaxWuxing;

	public int MaxQuanzhang;

	public int MaxJianfa;

	public int MaxDaofa;

	public int MaxQimen;

	public int Female;

	public string SwitchGameScene = string.Empty;
}
