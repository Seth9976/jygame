using System;
using LuaInterface;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSourceWrap
{
	private static Type classType = _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioSource).TypeHandle);

	public static void Register(IntPtr L)
	{
		LuaMethod[] regs = new LuaMethod[19]
		{
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(777870313u), Play),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(60830286u), PlayDelayed),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(457836672u), PlayScheduled),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(53424267u), SetScheduledStartTime),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2412467529u), SetScheduledEndTime),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3288983909u), Stop),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2973309182u), Pause),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2615689225u), UnPause),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4262152152u), PlayOneShot),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1256025337u), PlayClipAtPoint),
			new LuaMethod(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(230956812u), SetCustomCurve),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3219659045u), GetCustomCurve),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3158547335u), GetOutputData),
			new LuaMethod(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1789784058u), GetSpectrumData),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3293011356u), SetSpatializerFloat),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1730148422u), GetSpatializerFloat),
			new LuaMethod(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1657282774u), _202C_200D_202B_202A_206C_206A_200C_202E_206E_202E_206B_202D_202B_202B_200B_202D_202C_200E_200C_200E_206D_206B_200D_206B_202C_200E_206E_206E_206F_206C_200E_206A_202A_200D_200E_206E_200F_206E_206C_200D_202E),
			new LuaMethod(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3661446913u), GetClassType),
			new LuaMethod(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(396454614u), Lua_Eq)
		};
		LuaField[] fields = new LuaField[26]
		{
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(167285488u), get_volume, set_volume),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1022877494u), get_pitch, set_pitch),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1226741781u), get_time, set_time),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2881752943u), get_timeSamples, set_timeSamples),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(449323053u), get_clip, set_clip),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2129403495u), get_outputAudioMixerGroup, set_outputAudioMixerGroup),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(264665756u), get_isPlaying, null),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(634819684u), get_loop, set_loop),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3875521702u), get_ignoreListenerVolume, set_ignoreListenerVolume),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3377555740u), get_playOnAwake, set_playOnAwake),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2949495981u), get_ignoreListenerPause, set_ignoreListenerPause),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(4076059798u), get_velocityUpdateMode, set_velocityUpdateMode),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4118737409u), get_panStereo, set_panStereo),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3843225112u), get_spatialBlend, set_spatialBlend),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3688001988u), get_spatialize, set_spatialize),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2138003211u), get_reverbZoneMix, set_reverbZoneMix),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2733171383u), get_bypassEffects, set_bypassEffects),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1364408106u), get_bypassListenerEffects, set_bypassListenerEffects),
			new LuaField(global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2086400666u), get_bypassReverbZones, set_bypassReverbZones),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(414202372u), get_dopplerLevel, set_dopplerLevel),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(146586801u), get_spread, set_spread),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2440425352u), get_priority, set_priority),
			new LuaField(global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1233528582u), get_mute, set_mute),
			new LuaField(global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2679332917u), get_minDistance, set_minDistance),
			new LuaField(global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3388065382u), get_maxDistance, set_maxDistance),
			new LuaField(global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1384979164u), get_rolloffMode, set_rolloffMode)
		};
		LuaScriptMgr.RegisterLib(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(361203246u), _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioSource).TypeHandle), regs, fields, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(Behaviour).TypeHandle));
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int _202C_200D_202B_202A_206C_206A_200C_202E_206E_202E_206B_202D_202B_202B_200B_202D_202C_200E_200C_200E_206D_206B_200D_206B_202C_200E_206E_206E_206F_206C_200E_206A_202A_200D_200E_206E_200F_206E_206C_200D_202E(IntPtr P_0)
	{
		int num = LuaDLL.lua_gettop(P_0);
		while (true)
		{
			int num2 = -1967009927;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ -1679906343)) % 6)
				{
				case 2u:
					break;
				case 5u:
					LuaDLL.luaL_error(P_0, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3885487383u));
					num2 = -2084412594;
					continue;
				case 0u:
				{
					AudioSource obj = _200F_202B_202D_206F_206A_206D_202B_202B_200C_200F_206C_202C_200C_202E_202D_202C_206E_200B_202B_202A_202C_200F_206B_200E_206F_200E_206E_202B_206D_206F_206F_202E_200F_206F_202A_206D_202B_202C_206E_200E_202E();
					LuaScriptMgr.Push(P_0, (Object)(object)obj);
					num2 = ((int)num3 * -343774873) ^ 0x7CF6885C;
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (num == 0)
					{
						num4 = 1054127175;
						num5 = num4;
					}
					else
					{
						num4 = 896413244;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1357498317);
					continue;
				}
				case 1u:
					return 1;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetClassType(IntPtr L)
	{
		LuaScriptMgr.Push(L, classType);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_volume(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 31565777;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2F203DB9)) % 7)
				{
				case 6u:
					break;
				case 4u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1931867265;
						num6 = num5;
					}
					else
					{
						num5 = -2031661756;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 354304081);
					continue;
				}
				case 5u:
					num = (int)(num2 * 1290266813) ^ -554744907;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(47980600u));
					num = ((int)num2 * -439052820) ^ 0x5AC1D598;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1867586771u));
					num = 1424791468;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 517539218;
						num4 = num3;
					}
					else
					{
						num3 = 878503388;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -365259541);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _200C_206D_200F_206C_202E_200C_206E_200E_200C_202A_200D_206F_200C_202C_206D_200C_200E_200C_202C_206C_206C_202D_200E_200E_202D_206E_200F_206C_200C_206A_202B_200C_206F_200D_206B_200D_200B_206F_206F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_pitch(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1179273138;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1603666279)) % 8)
				{
				case 6u:
					break;
				case 7u:
				{
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 612581028;
						num6 = num5;
					}
					else
					{
						num5 = 1652049359;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 2093633308);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2140698032u));
					num = -216455648;
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1487521454;
						num4 = num3;
					}
					else
					{
						num3 = -342033127;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 708300378);
					continue;
				}
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -426671905) ^ -390396045;
					continue;
				case 5u:
					num = ((int)num2 * -831776123) ^ 0x344A3FD1;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(457412962u));
					num = ((int)num2 * -198772229) ^ -408941259;
					continue;
				default:
					LuaScriptMgr.Push(L, _200F_200C_206C_200D_206C_202E_206E_200C_202D_206E_200C_200C_202E_202C_202D_206C_206B_200B_206D_202B_202A_200F_202C_200D_202D_206D_202C_202D_200E_200B_200B_202E_202A_206A_200D_200E_202B_202C_200C_202A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_time(IntPtr L)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -678583195;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -8336159)) % 9)
				{
				case 8u:
					break;
				case 5u:
					num = ((int)num2 * -753579402) ^ 0x8FC63A3;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _206D_202D_206B_202E_202E_206C_202E_206C_206F_202E_206A_206E_202E_206E_202C_202E_202D_206E_200D_200D_202D_202B_200E_206E_202E_206D_200E_202A_206F_200F_200D_200C_202D_200C_202A_206D_200C_200E_206A_202A_202E(val));
					num = -1099392749;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2856532071u));
					num = (int)(num2 * 491258498) ^ -1214092393;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(81270024u));
					num = -2090298145;
					continue;
				case 4u:
					val = (AudioSource)luaObject;
					num = (int)((num2 * 2127424428) ^ 0x1EDCF5F7);
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1150557773;
						num6 = num5;
					}
					else
					{
						num5 = -1333150225;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 898983148);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -103424769;
						num4 = num3;
					}
					else
					{
						num3 = -2054915565;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1662378416);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_timeSamples(IntPtr L)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 1734178341;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x25DDD593)) % 9)
				{
				case 0u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 393517287;
						num6 = num5;
					}
					else
					{
						num5 = 1068404553;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1200062332);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 837280172) ^ 0x44734C6E);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 968776605;
						num4 = num3;
					}
					else
					{
						num3 = 1154521407;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1592187330);
					continue;
				}
				case 5u:
					val = (AudioSource)luaObject;
					num = (int)(num2 * 469459081) ^ -1897322173;
					continue;
				case 8u:
					num = (int)(num2 * 1595200599) ^ -1458439283;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1668845697u));
					num = 2023331539;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3051183235u));
					num = ((int)num2 * -1734958012) ^ -571673095;
					continue;
				default:
					LuaScriptMgr.Push(L, _200F_200E_206F_202A_200F_202A_206B_206B_206F_200B_206D_206D_202A_206D_202E_200E_200E_206A_202B_202E_202E_202B_206F_206D_206C_202E_200F_200F_206F_200F_206A_206B_200C_206A_200C_202E_202A_206B_206B_206A_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_clip(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 550760139;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6E7BB520)) % 8)
				{
				case 7u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(864889178u));
					num = (int)((num2 * 1852670760) ^ 0x4DDFEFCD);
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -2056708308;
						num6 = num5;
					}
					else
					{
						num5 = -1034860522;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -357920943);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3020016298u));
					num = 1545415261;
					continue;
				case 5u:
					LuaScriptMgr.Push(L, (Object)(object)_202A_206A_200D_206F_206A_200D_202C_206E_206F_202C_202B_200B_206B_202D_206C_200F_206A_200B_200C_206E_202C_206D_200C_206B_206B_200D_200B_202C_200F_200D_200F_202E_202B_206D_200E_200E_200D_202C_206E_202E(val));
					num = 1971701982;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -663816395) ^ 0x6194FA21;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1332929700;
						num4 = num3;
					}
					else
					{
						num3 = -312941880;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1585690685);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_outputAudioMixerGroup(IntPtr L)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1713421817;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x33C69867)) % 8)
				{
				case 7u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1492694654u));
					num = 894752725;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, (Object)(object)_206C_202D_206E_206E_202A_200C_206C_202E_202E_202D_206E_200F_200E_200B_206F_202B_206E_200C_206A_202B_202A_202A_202B_200F_200D_200D_202A_200D_202A_200B_200E_200C_200F_202D_202A_202B_206B_200C_202D_200F_202E(val));
					num = 684985399;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1941672878;
						num6 = num5;
					}
					else
					{
						num5 = 341149375;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1537251148);
					continue;
				}
				case 6u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -306687369;
						num4 = num3;
					}
					else
					{
						num3 = -858682706;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1161086881);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3200149018u));
					num = (int)(num2 * 1364424254) ^ -635859309;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -271891190) ^ 0x691544A8;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_isPlaying(IntPtr L)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1960558900;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xEC2465D)) % 9)
				{
				case 7u:
					break;
				case 6u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1994302508;
						num6 = num5;
					}
					else
					{
						num5 = -1504860437;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1388831057);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1045121914u));
					num = ((int)num2 * -1048027943) ^ 0x22A6C7DE;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1003016425;
						num4 = num3;
					}
					else
					{
						num3 = -1893414787;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1429654309);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1023387311) ^ -1556107356;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(373065419u));
					num = 2140633837;
					continue;
				case 8u:
					LuaScriptMgr.Push(L, _202C_202C_202E_202A_200D_206F_202A_206E_206F_200D_206F_202A_202C_200E_202E_202E_206B_206F_206A_200B_200B_202B_202E_202A_202D_206E_202E_202A_200D_202B_200F_200F_202C_206F_202A_206B_200B_206D_200F_202C_202E(val));
					num = 1621194333;
					continue;
				case 2u:
					num = ((int)num2 * -1041209508) ^ -1312081511;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_loop(IntPtr L)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 1839898327;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0xB9FBB21)) % 8)
				{
				case 5u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4187691175u));
					num = (int)((num2 * 2005505613) ^ 0x161CB997);
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1854530387;
						num6 = num5;
					}
					else
					{
						num5 = -1207868841;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1363098748);
					continue;
				}
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 375270834) ^ 0x1E265C36);
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _200C_200D_202D_200B_206A_200C_202E_200E_200D_206A_200D_200B_206D_200C_202D_202B_200E_200B_202B_200B_200B_206C_202A_200C_206F_206A_200B_206B_200B_206E_206E_202B_206C_200C_202B_200D_206F_206F_206F_206C_202E(val));
					num = 1082163022;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(4230572761u));
					num = 242921941;
					continue;
				case 6u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1439455327;
						num4 = num3;
					}
					else
					{
						num3 = -2074781170;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1243991182);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_ignoreListenerVolume(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0064;
		IL_0018:
		int num = -1907685940;
		goto IL_001d;
		IL_001d:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ -1852317976)) % 7)
			{
			case 0u:
				break;
			case 5u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(4068483578u));
				num = -1253220416;
				continue;
			case 6u:
				goto IL_0064;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4227732156u));
				num = ((int)num2 * -1101332303) ^ 0x63E53A29;
				continue;
			case 4u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = (int)(num2 * 1247060659) ^ -52369241;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -228463758;
					num4 = num3;
				}
				else
				{
					num3 = -86216999;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -225730088);
				continue;
			}
			default:
				return 1;
			}
			break;
		}
		goto IL_0018;
		IL_0064:
		LuaScriptMgr.Push(L, _202D_202C_206E_200F_202C_200D_200B_206E_206A_200B_200D_206C_202E_200E_200B_206F_200E_202B_200C_206A_200E_200D_200F_206B_202E_206F_206C_202A_202B_206A_206B_206E_206D_202A_206F_200E_202D_206A_202C_206D_202E(val));
		num = -78075308;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_playOnAwake(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = 1348928234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x6F74BBF5)) % 7)
				{
				case 0u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -593805826;
						num6 = num5;
					}
					else
					{
						num5 = -1970465424;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1003272338);
					continue;
				}
				case 6u:
					LuaScriptMgr.Push(L, _200E_206E_206E_206E_200C_202A_206A_202B_206A_202D_206A_206A_200B_200F_202B_200C_202D_200E_206E_202C_202C_202D_202D_202B_206A_202C_206A_206A_206D_200B_200D_200D_202D_200E_200C_200B_200F_200F_200B_200F_202E(val));
					num = 1464720464;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2850205691u));
					num = (int)((num2 * 1845501222) ^ 0x6D349330);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(431081576u));
					num = 211478096;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1270127305;
						num4 = num3;
					}
					else
					{
						num3 = -2134643249;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -832836866);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_ignoreListenerPause(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1698409559;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x44808C51)) % 8)
				{
				case 7u:
					break;
				case 5u:
					LuaScriptMgr.Push(L, _206E_202E_202D_206D_206C_206B_200C_206E_202B_202E_200E_200E_200C_202E_202A_200E_202D_200C_200F_206B_202C_200F_200B_200C_206A_200B_200E_200C_206D_202D_202C_206A_202A_206F_202C_200D_202C_202D_202A_202E(val));
					num = 1833137394;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1961297088u));
					num = ((int)num2 * -973146627) ^ 0x21541D44;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2030063512u));
					num = 1726557692;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1880995151) ^ 0x4EC57E04;
					continue;
				case 4u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1057493953;
						num6 = num5;
					}
					else
					{
						num5 = 514800179;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -666100278);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1481194738;
						num4 = num3;
					}
					else
					{
						num3 = -2065852590;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 280369107);
					continue;
				}
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_velocityUpdateMode(IntPtr L)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 1219345574;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x184CC2DC)) % 8)
				{
				case 0u:
					break;
				case 1u:
					LuaScriptMgr.Push(L, (Enum)(object)_200D_202E_202E_206F_206F_200B_206F_206B_200C_202B_202E_206F_200C_200E_206D_206F_202A_202E_200D_202E_200E_202D_206C_202B_206D_202E_206F_200C_202E_202D_200C_200E_206A_206C_200C_206B_206F_202C_200D_202C_202E(val));
					num = 730625034;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1394381379u));
					num = 1299258973;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2356681131u));
					num = (int)(num2 * 2031286947) ^ -1467189044;
					continue;
				case 2u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 797859818;
						num6 = num5;
					}
					else
					{
						num5 = 1407464159;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -840375467);
					continue;
				}
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 127412591;
						num4 = num3;
					}
					else
					{
						num3 = 1586185913;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1621183562);
					continue;
				}
				case 7u:
					num = (int)((num2 * 792592125) ^ 0x222A24C6);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_panStereo(IntPtr L)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1187588851;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1154712324)) % 8)
				{
				case 0u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2164867326u));
					num = ((int)num2 * -1181654970) ^ -133749276;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -598994593;
						num6 = num5;
					}
					else
					{
						num5 = -688780804;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -992935060);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -534240380) ^ -1822486982;
					continue;
				case 1u:
					val = (AudioSource)luaObject;
					num = (int)((num2 * 1632261772) ^ 0x20E06FFD);
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3890850009u));
					num = -490238848;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -323684480;
						num4 = num3;
					}
					else
					{
						num3 = -139523475;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1737903471);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _202B_206E_202A_202B_200D_206E_202A_202D_206E_200E_200B_200D_200F_206D_202B_200F_202D_202D_202C_200B_202A_206F_202B_202D_206A_200F_202A_206C_202E_206F_206E_206F_200B_202E_200C_206B_200B_202E_200F_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_spatialBlend(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -123324319;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2010086897)) % 8)
				{
				case 4u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2379564343u));
					num = -1357047912;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 539872958) ^ -1748803607;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(521858831u));
					num = (int)(num2 * 2065990116) ^ -611825804;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1314499006;
						num6 = num5;
					}
					else
					{
						num5 = 684518528;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 917592837);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 199256812;
						num4 = num3;
					}
					else
					{
						num3 = 2115970805;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -479345194);
					continue;
				}
				case 7u:
					LuaScriptMgr.Push(L, _206E_200C_202E_202C_200C_206D_206B_200C_202C_206D_200F_206A_206F_206C_200F_206B_206B_206F_202A_206B_202E_202B_200C_200D_202D_206E_202C_200E_202B_202E_206D_206C_202E_202B_200D_206B_200C_200B_202A_206C_202E(val));
					num = -57057638;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_spatialize(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 124038022;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5604BF88)) % 9)
				{
				case 7u:
					break;
				case 1u:
				{
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 828858214;
						num6 = num5;
					}
					else
					{
						num5 = 1164162924;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1937127761);
					continue;
				}
				case 6u:
					LuaScriptMgr.Push(L, _200C_200C_202C_202B_200C_202E_202D_206B_202C_200B_202A_200F_200E_206A_200D_200C_206B_200E_206D_200E_206C_200D_206F_206B_206A_200D_202E_206B_206C_202B_202B_206C_202D_206B_202E_206B_206C_202C_200D_202E(val));
					num = 470967670;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -200498847;
						num4 = num3;
					}
					else
					{
						num3 = -390603223;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1082281703);
					continue;
				}
				case 3u:
					num = ((int)num2 * -902445502) ^ 0x3291CEAC;
					continue;
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1377245838) ^ -1532145961;
					continue;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2963643931u));
					num = (int)(num2 * 95572700) ^ -91922820;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(4111910295u));
					num = 1657394932;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_reverbZoneMix(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = -666197568;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ -552581803)) % 6)
					{
					case 2u:
						break;
					case 0u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(749708428u));
						num = -1945637562;
						continue;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3134320553u));
						num = ((int)num2 * -1391187877) ^ 0x79BA6A95;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 1426381477;
							num4 = num3;
						}
						else
						{
							num3 = 1933655402;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1340758675);
						continue;
					}
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 764985064) ^ -1593540813;
						continue;
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		LuaScriptMgr.Push(L, _206F_206C_206E_206B_200C_206D_200E_202A_200D_200F_202B_206E_200D_200B_202B_200D_200E_202A_200B_200F_206B_206C_202E_206D_202A_202D_202E_202B_200B_200B_202D_200D_206E_206C_206C_206F_206D_202A_200E_206A_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bypassEffects(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 2053347161;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x295938C5)) % 9)
				{
				case 0u:
					break;
				case 4u:
				{
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1359267220;
						num6 = num5;
					}
					else
					{
						num5 = 1414315325;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -2075194098);
					continue;
				}
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -57208839;
						num4 = num3;
					}
					else
					{
						num3 = -502593996;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -990730922);
					continue;
				}
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(748166012u));
					num = 2017477404;
					continue;
				case 2u:
					LuaScriptMgr.Push(L, _206D_206B_200C_206D_202A_202A_202A_200F_202B_206C_202A_202C_200D_202A_200C_202C_202E_202B_200F_200F_206B_200E_200B_206D_206E_206E_202E_206E_206B_200F_206D_202D_206C_200B_202B_206F_206F_206D_202D_200F_202E(val));
					num = 1288048983;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1102694939) ^ 0x334B807C;
					continue;
				case 7u:
					num = ((int)num2 * -1141837681) ^ 0x32AF40A3;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(31529007u));
					num = (int)(num2 * 810474884) ^ -749150468;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bypassListenerEffects(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1860146532;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1245779529)) % 8)
				{
				case 2u:
					break;
				case 3u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1147549409;
						num6 = num5;
					}
					else
					{
						num5 = -1467771080;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 872786165);
					continue;
				}
				case 7u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1778507127) ^ 0x71C2169;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1797078007;
						num4 = num3;
					}
					else
					{
						num3 = 1503370156;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -927130898);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3335108168u));
					num = ((int)num2 * -1725711181) ^ -356290351;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1038808379u));
					num = -182626529;
					continue;
				case 4u:
					num = ((int)num2 * -1665944925) ^ 0xE33156B;
					continue;
				default:
					LuaScriptMgr.Push(L, _200C_206B_202E_200E_202D_206F_200D_206E_206D_202D_206F_206A_200F_200D_206C_206A_202C_200D_202D_206D_200B_202D_200D_200F_202E_200B_206B_200B_200D_206A_206C_202A_206C_206C_200C_206A_200C_200B_202B_202C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_bypassReverbZones(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -213117228;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -397978718)) % 8)
				{
				case 7u:
					break;
				case 6u:
					val = (AudioSource)luaObject;
					num = (int)((num2 * 438163612) ^ 0x2FC3BEC9);
					continue;
				case 2u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 261554897) ^ -366212135;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(1017909763u));
					num = -1589996446;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3650928609u));
					num = (int)(num2 * 846915908) ^ -1718775598;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -733083208;
						num6 = num5;
					}
					else
					{
						num5 = -1955608343;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1464099606);
					continue;
				}
				case 3u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1823609707;
						num4 = num3;
					}
					else
					{
						num3 = -2912609;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1354998141);
					continue;
				}
				default:
					LuaScriptMgr.Push(L, _206F_206B_206A_200B_200E_202E_202E_206C_200D_200C_200F_202E_202C_206E_206D_202B_200E_200F_200E_206F_202B_206B_200F_206E_200F_206B_202E_200B_200C_206D_200C_200F_202C_202A_206B_200E_202D_202C_200B_202E_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_dopplerLevel(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -1802195878;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -945389914)) % 7)
				{
				case 5u:
					break;
				case 1u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 379540483;
						num6 = num5;
					}
					else
					{
						num5 = 1656907453;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -892753736);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1052906997;
						num4 = num3;
					}
					else
					{
						num3 = -2117992509;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1333500884);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1028428955u));
					num = -1337568989;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 859392453) ^ -94310081;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3700536389u));
					num = ((int)num2 * -523817292) ^ -101042745;
					continue;
				default:
					LuaScriptMgr.Push(L, _202D_200B_206B_206F_206A_200D_200E_200D_206A_206C_200D_206E_206E_202B_200D_202C_200D_206F_200C_206A_206B_206A_200F_200D_200F_202D_200E_202D_200D_202A_206A_202B_206A_200D_200D_200E_200C_200D_200B_200F_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_spread(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1393520514;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7F4918C2)) % 7)
					{
					case 6u:
						break;
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = ((int)num2 * -1252476074) ^ -1588336633;
						continue;
					case 0u:
						num = (int)(num2 * 2060675996) ^ -1676655978;
						continue;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3482881284u));
						num = ((int)num2 * -1207074052) ^ 0x42B8E32E;
						continue;
					case 2u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -768848543;
							num4 = num3;
						}
						else
						{
							num3 = -1638206323;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -538391208);
						continue;
					}
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1930650044u));
						num = 1736928118;
						continue;
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		LuaScriptMgr.Push(L, _202E_206D_202B_206E_206A_206F_200C_206E_206F_200C_202C_202C_206B_206F_200B_200E_200B_200B_200D_202B_202C_200D_202C_206A_206C_202E_200F_200E_206B_202D_206D_202C_206E_206E_200F_202D_206E_200B_202E_202A_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_priority(IntPtr L)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1126018846;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5A00007C)) % 8)
				{
				case 0u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(228936693u));
					num = ((int)num2 * -674276193) ^ -690894805;
					continue;
				case 4u:
					LuaScriptMgr.Push(L, _200B_202C_202C_200B_202A_206C_200E_206E_202C_206B_202A_206C_202B_206E_202C_202D_200B_206D_206E_206B_206B_202C_200F_200F_202B_206F_202E_200F_206C_200C_206E_202E_202B_202B_202A_206F_202D_206B_206E_206F_202E(val));
					num = 1969721767;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -1030452293;
						num6 = num5;
					}
					else
					{
						num5 = -1318323215;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 621066347);
					continue;
				}
				case 2u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1458236562;
						num4 = num3;
					}
					else
					{
						num3 = 425777175;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1440497979);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3609666780u));
					num = 1015176952;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 2043540461) ^ 0x3FAA638F);
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_mute(IntPtr L)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -976826277;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1885518243)) % 9)
				{
				case 7u:
					break;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3611043048u));
					num = ((int)num2 * -1619559895) ^ 0x2ECCAC2B;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -1514856036;
						num6 = num5;
					}
					else
					{
						num5 = -9430;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -472496024);
					continue;
				}
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1399445056) ^ 0x3A895E6B;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1198930058;
						num4 = num3;
					}
					else
					{
						num3 = -1472988533;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1793114061);
					continue;
				}
				case 8u:
					num = ((int)num2 * -24354187) ^ -1991295652;
					continue;
				case 3u:
					val = (AudioSource)luaObject;
					num = ((int)num2 * -900962337) ^ 0x2904FCDF;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2318707854u));
					num = -430335510;
					continue;
				default:
					LuaScriptMgr.Push(L, _200C_206D_206C_202C_202D_206E_206A_206A_206A_206C_206D_202A_202C_202B_202D_202A_202C_202E_200F_206D_206F_206F_200F_200E_206D_206E_202B_206B_202B_200C_206E_200F_202C_200F_206B_206A_200D_200E_200F_206C_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_minDistance(IntPtr L)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -851820485;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -444062092)) % 8)
				{
				case 0u:
					break;
				case 7u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1843521923;
						num6 = num5;
					}
					else
					{
						num5 = 1189138606;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 943266855);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1013595449;
						num4 = num3;
					}
					else
					{
						num3 = 1178603805;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1144214112);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1231919106u));
					num = -1475030134;
					continue;
				case 6u:
					LuaScriptMgr.Push(L, _200E_200C_200F_200D_200B_202C_206B_200F_200C_200F_206A_206E_206E_202A_202C_206D_202A_200B_202C_200C_202B_200C_202B_202C_200F_206A_206F_206E_200D_202C_206A_206C_206F_202D_202C_202D_206B_202C_206A_206A_202E(val));
					num = -774672072;
					continue;
				case 3u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 1270237391) ^ 0x7FBE408B);
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(844088176u));
					num = ((int)num2 * -27754727) ^ 0x1ACE5D0B;
					continue;
				default:
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_maxDistance(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1300166548;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x5AC48F9E)) % 7)
					{
					case 0u:
						break;
					case 3u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 1443104659) ^ -86524871;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3367327572u));
						num = 6905230;
						continue;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2401160534u));
						num = (int)(num2 * 1987847046) ^ -772982351;
						continue;
					case 2u:
						num = (int)((num2 * 1175898985) ^ 0x708A037F);
						continue;
					case 6u:
					{
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 1132889509;
							num4 = num3;
						}
						else
						{
							num3 = 1380405158;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1146141359);
						continue;
					}
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		LuaScriptMgr.Push(L, _202A_200D_202B_200B_200D_206F_200E_202A_206F_202B_202E_206F_206A_200B_200F_202C_200F_206F_206B_206C_206B_202D_200D_206C_206B_206E_202A_206E_200F_200E_200B_202D_200B_202E_202D_206E_200D_206F_206A_202E_202E(val));
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int get_rolloffMode(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 144001903;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5BD3130B)) % 7)
				{
				case 5u:
					break;
				case 3u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 754680697;
						num6 = num5;
					}
					else
					{
						num5 = 1795303877;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1955157792);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(742247653u));
					num = ((int)num2 * -1445788673) ^ 0x37FD8389;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1114453528;
						num4 = num3;
					}
					else
					{
						num3 = -705522772;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1075123123);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -2005425134) ^ 0x3BE00E50;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(690645108u));
					num = 2057625157;
					continue;
				default:
					LuaScriptMgr.Push(L, (Enum)(object)_206D_202A_200D_202D_200F_206E_206F_200B_202E_206F_200E_206D_200B_202D_206B_200B_206A_202C_202A_206E_202B_202A_206C_206D_200D_200D_206A_202A_202D_206C_200F_200B_206F_206C_202C_202E_206C_206C_200E_202D_202E(val));
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_volume(IntPtr L)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 639069691;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x61755D8E)) % 9)
				{
				case 5u:
					break;
				case 7u:
					_206D_206A_206D_202E_206F_200D_206A_202A_202E_202A_202B_200D_200D_200E_206C_202D_206A_200E_206E_206F_200B_202D_206C_206F_206B_206E_200B_202C_206E_200D_202B_202A_200B_202D_206E_206A_206E_206D_200B_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 554158577;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 301533606;
						num6 = num5;
					}
					else
					{
						num5 = 477814396;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 400713298);
					continue;
				}
				case 8u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1999474264) ^ 0x3D2795F;
					continue;
				case 4u:
					val = (AudioSource)luaObject;
					num = (int)((num2 * 886228476) ^ 0x5013AFEF);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = 1564003391;
						num4 = num3;
					}
					else
					{
						num3 = 416450135;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 182256871);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2178033019u));
					num = ((int)num2 * -517129261) ^ 0x2478344C;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(3953561504u));
					num = 756358358;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_pitch(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1717223727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x2959CC91)) % 8)
				{
				case 2u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1950451169;
						num6 = num5;
					}
					else
					{
						num5 = 769172444;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1054019986);
					continue;
				}
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 854043595) ^ 0x524727E5);
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(872592872u));
					num = ((int)num2 * -1661313559) ^ 0x6C2B6475;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -169962106;
						num4 = num3;
					}
					else
					{
						num3 = -1720462532;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1635776423);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(582248282u));
					num = 1231431800;
					continue;
				case 1u:
					_202E_206B_200C_200B_206E_206E_200C_206F_206A_202C_206F_200B_206F_206E_206B_202A_200C_202A_206F_202E_206C_202B_206C_206F_206D_206B_206A_200B_202C_206A_202E_202C_200F_202A_200F_202C_206E_200E_202C_200C_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 525622426;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_time(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			LuaTypes luaTypes = default(LuaTypes);
			while (true)
			{
				int num = 1224476501;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x7381DF8A)) % 6)
					{
					case 0u:
						break;
					case 5u:
						luaTypes = LuaDLL.lua_type(L, 1);
						num = (int)(num2 * 1771940553) ^ -673396369;
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2297246585u));
						num = ((int)num2 * -218499765) ^ 0x3FE65C41;
						continue;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(110957156u));
						num = 490891696;
						continue;
					case 4u:
					{
						int num3;
						int num4;
						if (luaTypes == LuaTypes.LUA_TTABLE)
						{
							num3 = -2134456687;
							num4 = num3;
						}
						else
						{
							num3 = -1794843959;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 489939508);
						continue;
					}
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		_202E_206A_206E_206D_202E_202A_206F_200C_202E_202C_206A_202E_200F_202D_202A_206C_202B_202C_200D_202B_206B_206E_202B_202B_206B_202C_206C_206B_202E_206E_206B_206D_200E_202B_202B_200D_202D_200E_206F_200F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_timeSamples(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = -979151155;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -627624422)) % 8)
				{
				case 3u:
					break;
				case 4u:
					num = ((int)num2 * -272450658) ^ -1481440086;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3051183235u));
					num = ((int)num2 * -2116633218) ^ -2131559726;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -473415019;
						num6 = num5;
					}
					else
					{
						num5 = -1769056158;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1172433771);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1463008345;
						num4 = num3;
					}
					else
					{
						num3 = 422456260;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 418714493);
					continue;
				}
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3665818390u));
					num = -1565163102;
					continue;
				case 0u:
					_202A_200B_206D_206B_206A_202D_200D_202D_206A_206E_206A_206C_200E_202A_200B_202C_206D_206A_206A_206D_206C_200F_202E_206E_202B_202D_206E_200D_200E_206B_202E_202E_200E_206B_206B_206D_206C_200C_202B_206C_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					num = -1255394632;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_clip(IntPtr L)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1105848869;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x678DF1A)) % 10)
				{
				case 9u:
					break;
				case 0u:
					_206A_202D_202C_206C_200C_202D_202B_206B_202D_200C_206B_206B_202E_206F_202B_200E_200D_200F_200B_202D_202B_202B_206C_202E_202D_202B_202E_202B_202C_206E_206E_202A_202B_200D_202D_206C_206C_206E_206E_200C_202E(val, (AudioClip)LuaScriptMgr.GetUnityObject(L, 3, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioClip).TypeHandle)));
					num = 199336998;
					continue;
				case 1u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1421335805u));
					num = 911405380;
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 2139790367;
						num6 = num5;
					}
					else
					{
						num5 = 1538524685;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -86061651);
					continue;
				}
				case 7u:
					val = (AudioSource)luaObject;
					num = ((int)num2 * -1919917853) ^ -1103674806;
					continue;
				case 8u:
					num = (int)((num2 * 1619804116) ^ 0x2928A284);
					continue;
				case 6u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -921691587) ^ -1525331548;
					continue;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2700189840u));
					num = (int)(num2 * 2101651967) ^ -1650054075;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 916192339;
						num4 = num3;
					}
					else
					{
						num3 = 459816561;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2073660332);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_outputAudioMixerGroup(IntPtr L)
	{
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -1566152246;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1287989182)) % 10)
				{
				case 5u:
					break;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2058232089u));
					num = -134884038;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2918151376u));
					num = ((int)num2 * -1945409356) ^ -373472195;
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 1260683855) ^ -1808495947;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1682942233;
						num6 = num5;
					}
					else
					{
						num5 = 523239815;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1908150905);
					continue;
				}
				case 9u:
				{
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -815683056;
						num4 = num3;
					}
					else
					{
						num3 = -1105238371;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 680673674);
					continue;
				}
				case 1u:
					num = ((int)num2 * -1673677288) ^ 0x2F5749B2;
					continue;
				case 6u:
					val = (AudioSource)luaObject;
					num = ((int)num2 * -248041268) ^ 0x12F7FCB9;
					continue;
				case 8u:
					_202B_202C_206A_202D_206F_200D_200E_202D_202C_202C_202D_200C_200E_200B_206B_200B_202B_206A_206C_200D_202D_206B_206A_200F_206F_200B_200F_202E_200F_202E_202E_206B_200D_200B_200B_200B_206F_202A_206B_202A_202E(val, (AudioMixerGroup)LuaScriptMgr.GetUnityObject(L, 3, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioMixerGroup).TypeHandle)));
					num = -666834718;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_loop(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_001b;
		}
		goto IL_00d3;
		IL_001b:
		int num = 1013841553;
		goto IL_0020;
		IL_0020:
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x39942FAE)) % 8)
			{
			case 5u:
				break;
			case 2u:
				num = ((int)num2 * -2144001298) ^ -1390235613;
				continue;
			case 6u:
			{
				int num3;
				int num4;
				if (luaTypes != LuaTypes.LUA_TTABLE)
				{
					num3 = -2109398878;
					num4 = num3;
				}
				else
				{
					num3 = -1511515266;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1131764022);
				continue;
			}
			case 4u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1292426259u));
				num = (int)(num2 * 831609375) ^ -598428408;
				continue;
			case 7u:
				luaTypes = LuaDLL.lua_type(L, 1);
				num = ((int)num2 * -1512990050) ^ 0x734062FA;
				continue;
			case 0u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(786867823u));
				num = 1984962463;
				continue;
			case 1u:
				goto IL_00d3;
			default:
				return 0;
			}
			break;
		}
		goto IL_001b;
		IL_00d3:
		_202A_202C_200F_200F_202A_206A_202C_206F_202C_200B_202E_200D_200E_206C_206A_202C_202C_206E_206C_202D_206D_206E_200C_206A_200D_202C_206A_206A_206F_200E_206B_206F_200E_202C_200F_202D_206B_202B_202D_202C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
		num = 360908005;
		goto IL_0020;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_ignoreListenerVolume(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = 1237062315;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x4330F442)) % 8)
				{
				case 3u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(2952705435u));
					num = 515552322;
					continue;
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3566788191u));
					num = ((int)num2 * -1099730705) ^ 0x284CB5F6;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -239136306;
						num6 = num5;
					}
					else
					{
						num5 = -472540513;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1095463249);
					continue;
				}
				case 5u:
					num = (int)((num2 * 275789576) ^ 0x3945A36A);
					continue;
				case 4u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 559091418) ^ 0x4564CF48);
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 264733797;
						num4 = num3;
					}
					else
					{
						num3 = 2016705633;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -99740529);
					continue;
				}
				default:
					_202C_202A_200E_202C_202C_202C_200D_206C_202D_200F_206D_200E_206F_202D_202C_202B_200F_200D_200E_200D_200B_200C_202C_202C_202A_202B_206F_206B_200D_206E_206E_202A_206C_200E_206D_206D_206C_200C_206A_200E_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_playOnAwake(IntPtr L)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		LuaTypes luaTypes = default(LuaTypes);
		while (true)
		{
			int num = -2051392606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -212940222)) % 10)
				{
				case 0u:
					break;
				case 2u:
					val = (AudioSource)luaObject;
					num = (int)((num2 * 1152524399) ^ 0x12C8288B);
					continue;
				case 3u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1160315936;
						num6 = num5;
					}
					else
					{
						num5 = 169257713;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1411503381);
					continue;
				}
				case 4u:
					_206B_206E_206E_206C_200E_206A_200E_202B_206B_200E_202E_202B_206E_206B_200E_200F_200B_202B_200C_206F_202C_202B_200C_202E_200E_200E_206B_206C_206E_206D_206D_206F_200C_200C_206C_202D_206F_206C_206A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1788289651;
					continue;
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -726827164) ^ -1031732848;
					continue;
				case 9u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2850205691u));
					num = ((int)num2 * -1494969193) ^ -1561628172;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = 1674225785;
						num4 = num3;
					}
					else
					{
						num3 = 340726302;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1992805231);
					continue;
				}
				case 7u:
					num = (int)((num2 * 859614127) ^ 0x519C8CAD);
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2791168269u));
					num = -1651880174;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_ignoreListenerPause(IntPtr L)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -1533305344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1840078266)) % 7)
				{
				case 4u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3960409697u));
					num = (int)(num2 * 376170140) ^ -2120801082;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = 1807485900;
						num6 = num5;
					}
					else
					{
						num5 = 968114587;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 498384589);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2030063512u));
					num = -929148414;
					continue;
				case 3u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1590543194;
						num4 = num3;
					}
					else
					{
						num3 = 2060946838;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 276341092);
					continue;
				}
				case 1u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -1015697536) ^ 0x48021367;
					continue;
				default:
					_206F_202A_202E_206F_202B_202C_206D_200B_202B_200B_200F_200B_206A_202E_202E_200C_206B_206F_200B_206F_200F_200E_200D_202E_202B_202C_202C_200C_202C_200D_202A_202A_206B_206F_206D_206B_200C_206E_200B_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_velocityUpdateMode(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -1342504828;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1046187762)) % 7)
				{
				case 5u:
					break;
				case 1u:
				{
					val = (AudioSource)luaObject;
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -985648999;
						num6 = num5;
					}
					else
					{
						num5 = -1595471242;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 747039826);
					continue;
				}
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1394381379u));
					num = -1204181331;
					continue;
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(758699246u));
					num = ((int)num2 * -1002541219) ^ 0x5DDB585D;
					continue;
				case 2u:
					_200B_206D_206E_206C_200B_202A_202B_200C_206A_202D_206A_202E_202E_206C_206E_200E_200D_206A_200D_202A_202A_200F_202C_202A_202B_206F_206F_200C_200E_202A_206A_202C_202E_200F_206F_200B_200F_202E_200D_202B_202E(val, (AudioVelocityUpdateMode)(int)LuaScriptMgr.GetNetObject(L, 3, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioVelocityUpdateMode).TypeHandle)));
					num = -2014585103;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -1967768284;
						num4 = num3;
					}
					else
					{
						num3 = -1139434390;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -861277737);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_panStereo(IntPtr L)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 1612129159;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x7ED51D6)) % 8)
				{
				case 7u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -296785977;
						num6 = num5;
					}
					else
					{
						num5 = -745428594;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -399056086);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(987528203u));
					num = 2031636632;
					continue;
				case 1u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -76881664;
						num4 = num3;
					}
					else
					{
						num3 = -65979386;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2064655848);
					continue;
				}
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = ((int)num2 * -534797302) ^ -1479797476;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(2265124892u));
					num = (int)((num2 * 856041625) ^ 0x12261624);
					continue;
				case 6u:
					_200B_200F_202A_206B_200F_206D_206E_206E_202D_206C_206D_200C_200B_206A_206B_206F_206D_202D_206D_206B_202D_202E_200E_206E_200C_200B_200E_200C_202C_202A_200E_206B_200C_200E_206F_202A_202A_206C_200E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 1728890061;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_spatialBlend(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 1936372578;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x77E92526)) % 6)
					{
					case 3u:
						break;
					case 1u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(811437649u));
						num = 726281674;
						continue;
					case 0u:
						num = ((int)num2 * -1869749763) ^ -847700686;
						continue;
					case 5u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3645524101u));
						num = ((int)num2 * -1678966485) ^ 0x23A75C61;
						continue;
					case 2u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = 1172215469;
							num4 = num3;
						}
						else
						{
							num3 = 753822443;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -785232700);
						continue;
					}
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		_202C_200E_200E_200B_202E_200B_200E_200D_206C_200B_206B_200E_200F_202B_202D_202A_206C_206F_200B_200C_202B_202C_206C_202D_206D_202C_206B_200B_206D_206A_202A_206E_202B_202C_200B_200F_200B_202E_200F_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_spatialize(IntPtr L)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 830956902;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x503F5B58)) % 9)
				{
				case 4u:
					break;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(4105341283u));
					num = 1100214476;
					continue;
				case 0u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)((num2 * 715659295) ^ 0x116B50BB);
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 997204698;
						num6 = num5;
					}
					else
					{
						num5 = 1113678440;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1864172166);
					continue;
				}
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1980679077u));
					num = ((int)num2 * -1414213911) ^ 0x665A538;
					continue;
				case 3u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -2086477778;
						num4 = num3;
					}
					else
					{
						num3 = -226288616;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 647607919);
					continue;
				}
				case 2u:
					num = (int)((num2 * 694962076) ^ 0x65C54834);
					continue;
				case 1u:
					_202D_206E_202D_206C_202E_202D_200E_206B_206F_200F_202A_202B_206A_202D_202A_200B_206A_202D_206C_200D_206E_206B_200D_202C_202C_206A_206E_206E_206E_202C_202C_200F_200C_200B_206C_200C_200C_200D_200C_206A_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = 1288244722;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_reverbZoneMix(IntPtr L)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -2097909508;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1917844466)) % 7)
				{
				case 0u:
					break;
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1596437785u));
					num = -1405552975;
					continue;
				case 4u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -665289029;
						num6 = num5;
					}
					else
					{
						num5 = -1613395482;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1105430860);
					continue;
				}
				case 3u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1042832169;
						num4 = num3;
					}
					else
					{
						num3 = 832873859;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1524736033);
					continue;
				}
				case 2u:
					num = ((int)num2 * -2090909197) ^ -54704855;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(491168454u));
					num = (int)((num2 * 561734444) ^ 0xDD5466A);
					continue;
				default:
					_200F_206D_206D_206E_202B_206F_202B_200F_200B_200E_206E_200E_202C_200E_206F_200E_202D_202E_202A_202B_206F_200B_200F_202E_206D_202D_206F_202D_200C_206A_200D_200B_202C_202D_202E_200D_206B_206B_206F_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_bypassEffects(IntPtr L)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -1354811534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1709427917)) % 7)
				{
				case 6u:
					break;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(972754110u));
					num = ((int)num2 * -614579887) ^ 0xBD9BD1C;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num5 = -485247174;
						num6 = num5;
					}
					else
					{
						num5 = -1554628969;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1998037091);
					continue;
				}
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(925223865u));
					num = -1697599770;
					continue;
				case 1u:
				{
					val = (AudioSource)luaObject;
					int num3;
					int num4;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -1370322378;
						num4 = num3;
					}
					else
					{
						num3 = -1096748084;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2009402026);
					continue;
				}
				case 3u:
					_202C_202B_206E_206D_206C_200C_206D_202B_200D_206E_206D_206F_200D_206D_206B_206B_202C_202E_200B_200B_202E_200E_206B_200B_206C_206F_200F_202D_206E_206F_206C_200F_206D_200F_206B_202A_202E_206D_202D_202C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -779424740;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_bypassListenerEffects(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 1585874361;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)(num ^ 0x263F01DA)) % 5)
					{
					case 0u:
						break;
					case 1u:
					{
						LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
						int num3;
						int num4;
						if (luaTypes != LuaTypes.LUA_TTABLE)
						{
							num3 = -383868211;
							num4 = num3;
						}
						else
						{
							num3 = -1216765867;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -628671626);
						continue;
					}
					case 4u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1131706844u));
						num = 243687630;
						continue;
					case 3u:
						LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(1068314516u));
						num = ((int)num2 * -221110812) ^ -1413325350;
						continue;
					default:
						goto end_IL_001b;
					}
					break;
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		_202D_202C_206D_206F_206A_202E_202C_206E_206C_200B_202B_206F_202C_202C_202D_200F_206A_206D_202A_206B_206A_206E_200C_202D_200B_200C_200E_200B_202B_200F_200D_200B_202C_206F_206C_200B_206F_202C_202A_200F_202E(val, LuaScriptMgr.GetBoolean(L, 3));
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_bypassReverbZones(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = -1720932641;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -110509484)) % 8)
				{
				case 0u:
					break;
				case 6u:
					_200F_206D_206A_206F_206D_202B_202B_200C_200B_200F_206E_200F_202B_206D_206D_200E_200F_206E_202B_202A_202D_206E_202C_206F_202B_202A_206F_206C_200E_202A_206F_206E_206D_206B_206C_202D_200C_202C_206E_206D_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -285325170;
					continue;
				case 5u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1397461318;
						num6 = num5;
					}
					else
					{
						num5 = -409677599;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -307417230);
					continue;
				}
				case 7u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2756298999u));
					num = (int)(num2 * 1122443379) ^ -657780856;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(1116419941u));
					num = -2142191966;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -18544256;
						num4 = num3;
					}
					else
					{
						num3 = -1019755197;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1805439066);
					continue;
				}
				case 1u:
					num = (int)((num2 * 813369670) ^ 0xF193364);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_dopplerLevel(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = -2135830660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -817836182)) % 8)
				{
				case 7u:
					break;
				case 6u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -61402461;
						num6 = num5;
					}
					else
					{
						num5 = -935833691;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1941625495);
					continue;
				}
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(3700536389u));
					num = (int)((num2 * 952089228) ^ 0x4D5D4E23);
					continue;
				case 5u:
					_206E_206C_200E_206D_200F_200D_206D_200B_202C_200D_202B_202C_200F_206B_200B_206E_202E_206A_202A_206B_200B_206B_206A_202D_200D_206B_202E_200E_206C_202D_206F_202C_202D_206A_200D_202E_202C_200B_200B_202E_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -1431857312;
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(3948550656u));
					num = -1693612193;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -903739673;
						num4 = num3;
					}
					else
					{
						num3 = -31531573;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 294144951);
					continue;
				}
				case 1u:
					num = ((int)num2 * -240238398) ^ 0x1B46F3CD;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_spread(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = 1877137408;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1D9A30)) % 7)
				{
				case 5u:
					break;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1305271417u));
					num = (int)((num2 * 1690945812) ^ 0x2B6EE94B);
					continue;
				case 4u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(1575434481u));
					num = 330680815;
					continue;
				case 0u:
					_206D_206E_200D_200B_200D_202A_206A_206A_206B_206F_200F_206F_200C_206B_200F_202E_202B_202C_200E_200C_206D_202A_206E_206C_206D_206F_206D_202D_202E_206B_206E_200C_206B_206F_200C_200C_206A_200B_206F_200F_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = 1193957875;
					continue;
				case 3u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -1870188691;
						num6 = num5;
					}
					else
					{
						num5 = -1329206492;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1318187997);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -733409989;
						num4 = num3;
					}
					else
					{
						num3 = -837590801;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1927738320);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_priority(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = -756705442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -427264960)) % 7)
				{
				case 0u:
					break;
				case 2u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2383153723u));
					num = -607269241;
					continue;
				case 6u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = -632754060;
						num6 = num5;
					}
					else
					{
						num5 = -2032507559;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 94221136);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1717336833u));
					num = (int)((num2 * 1937797173) ^ 0x193E738);
					continue;
				case 4u:
				{
					int num3;
					int num4;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = 1278860017;
						num4 = num3;
					}
					else
					{
						num3 = 1669153949;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1071474269);
					continue;
				}
				case 3u:
					num = ((int)num2 * -1672138174) ^ -415568819;
					continue;
				default:
					_200C_200B_206F_202A_200C_206E_202C_206B_200E_200C_206A_200D_202A_202C_206F_200E_202D_200D_200D_200B_200E_206B_202B_206A_206D_200B_200C_200D_206C_200F_200D_200E_200F_206C_200D_202D_200F_200B_202B_206B_202E(val, (int)LuaScriptMgr.GetNumber(L, 3));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_mute(IntPtr L)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		LuaTypes luaTypes = default(LuaTypes);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -2081430829;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1145742459)) % 10)
				{
				case 3u:
					break;
				case 5u:
				{
					int num5;
					int num6;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num5 = 1901573661;
						num6 = num5;
					}
					else
					{
						num5 = 1394177711;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1972287106);
					continue;
				}
				case 4u:
				{
					int num3;
					int num4;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num3 = -919420173;
						num4 = num3;
					}
					else
					{
						num3 = -1732222556;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1833335804);
					continue;
				}
				case 2u:
					val = (AudioSource)luaObject;
					num = (int)(num2 * 493085897) ^ -346396747;
					continue;
				case 1u:
					num = ((int)num2 * -268119253) ^ -1608000826;
					continue;
				case 8u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(411283865u));
					num = (int)(num2 * 604552220) ^ -2026988270;
					continue;
				case 9u:
					luaTypes = LuaDLL.lua_type(L, 1);
					num = (int)(num2 * 908153777) ^ -1762049263;
					continue;
				case 6u:
					_200B_202E_206E_202C_206F_206F_206F_200E_206B_200B_202E_200C_200B_200C_202E_200E_206E_200F_206C_206C_206C_202E_202B_200B_206F_202E_200C_206E_202C_202C_200E_206B_206C_202A_200C_202E_206D_206E_206F_202C_202E(val, LuaScriptMgr.GetBoolean(L, 3));
					num = -1034290294;
					continue;
				case 0u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(544315724u));
					num = -723871701;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_minDistance(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
		{
			goto IL_0018;
		}
		goto IL_0046;
		IL_0018:
		int num = 2039652015;
		goto IL_001d;
		IL_001d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)(num ^ 0x3D3ADA2B)) % 6)
			{
			case 0u:
				break;
			case 5u:
				goto IL_0046;
			case 2u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(844088176u));
				num = ((int)num2 * -1654926246) ^ -102088226;
				continue;
			case 4u:
			{
				LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
				int num3;
				int num4;
				if (luaTypes == LuaTypes.LUA_TTABLE)
				{
					num3 = 84499995;
					num4 = num3;
				}
				else
				{
					num3 = 1246864354;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1113424218);
				continue;
			}
			case 1u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(2409485109u));
				num = 1031288014;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_0018;
		IL_0046:
		_206F_200E_200B_200F_206F_202B_206E_200E_202A_206E_200E_200E_202D_200D_200D_202A_206C_200D_206A_200E_202E_202C_202B_200C_200C_202E_206C_202A_200F_200C_206F_206C_200C_206A_202A_202B_206D_206B_200D_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
		num = 174611870;
		goto IL_001d;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_maxDistance(IntPtr L)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = (AudioSource)luaObject;
		while (true)
		{
			int num = -164672278;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1168883379)) % 7)
				{
				case 4u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (!_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = -23533815;
						num6 = num5;
					}
					else
					{
						num5 = -1117745919;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1371722692);
					continue;
				}
				case 5u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(2401160534u));
					num = (int)((num2 * 84732862) ^ 0x2E71FDB5);
					continue;
				case 3u:
					_206C_202E_206A_202C_200C_202B_206D_200B_206F_206C_202D_200C_206B_206A_206C_200D_202B_206D_200B_202C_200D_206C_206F_200B_200B_202B_206D_206B_202E_200D_200C_202D_200D_206D_200C_202E_206D_200D_206E_202B_202E(val, (float)LuaScriptMgr.GetNumber(L, 3));
					num = -2121322193;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3367327572u));
					num = -727842859;
					continue;
				case 1u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes != LuaTypes.LUA_TTABLE)
					{
						num3 = -2084999018;
						num4 = num3;
					}
					else
					{
						num3 = -1432100787;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 736898165);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int set_rolloffMode(IntPtr L)
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = 2019626573;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x63F82159)) % 8)
				{
				case 2u:
					break;
				case 1u:
					_202D_206C_206F_200D_202A_202A_200B_200D_200F_200C_200B_206F_206E_200B_206E_206E_200F_200F_206F_200D_202A_200B_200D_202A_202D_206B_202A_200F_200F_206F_206D_202C_200B_202A_202D_200C_206C_206E_206A_202B_202E(val, (AudioRolloffMode)(int)LuaScriptMgr.GetNetObject(L, 3, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioRolloffMode).TypeHandle)));
					num = 700430868;
					continue;
				case 6u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(3122001664u));
					num = ((int)num2 * -399087881) ^ -876524806;
					continue;
				case 7u:
				{
					int num5;
					int num6;
					if (_200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E((Object)(object)val, (Object)null))
					{
						num5 = 1067277285;
						num6 = num5;
					}
					else
					{
						num5 = 837411772;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 181072740);
					continue;
				}
				case 3u:
					LuaDLL.luaL_error(L, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(690645108u));
					num = 462833792;
					continue;
				case 0u:
				{
					LuaTypes luaTypes = LuaDLL.lua_type(L, 1);
					int num3;
					int num4;
					if (luaTypes == LuaTypes.LUA_TTABLE)
					{
						num3 = -1576652401;
						num4 = num3;
					}
					else
					{
						num3 = -759013494;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1889487616);
					continue;
				}
				case 4u:
					val = (AudioSource)luaObject;
					num = (int)(num2 * 836078926) ^ -1079261530;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Play(IntPtr L)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 1)
		{
			goto IL_000b;
		}
		goto IL_0052;
		IL_000b:
		int num2 = -207965200;
		goto IL_0010;
		IL_0010:
		AudioSource val2 = default(AudioSource);
		ulong num4 = default(ulong);
		AudioSource val = default(AudioSource);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -571013778)) % 11)
			{
			case 8u:
				break;
			case 6u:
				goto IL_0052;
			case 0u:
				val2 = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(539238537u));
				num2 = (int)(num3 * 666042572) ^ -306244913;
				continue;
			case 4u:
				num4 = (ulong)LuaScriptMgr.GetNumber(L, 2);
				num2 = ((int)num3 * -1549068233) ^ 0x5B232567;
				continue;
			case 2u:
				return 0;
			case 5u:
				_200D_200E_200E_200F_206D_206B_202D_202D_206A_206A_202E_202C_206A_202A_206E_206F_206C_206F_206A_200B_206C_202C_202E_202E_200E_202D_200B_202E_200C_206A_206B_206B_200E_200C_206B_206B_202D_200E_206C_202D_202E(val2, num4);
				num2 = (int)((num3 * 222143491) ^ 0xBB51467);
				continue;
			case 10u:
				return 0;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(771686168u));
				num2 = -1382830640;
				continue;
			case 1u:
				val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(731127323u));
				num2 = (int)((num3 * 410438978) ^ 0x63E206ED);
				continue;
			case 7u:
				_206E_202A_206F_206E_200F_200D_202E_200F_206D_200D_206E_202C_200F_206B_206E_200C_202D_200B_200E_200C_202C_200C_206E_200E_202A_202C_202D_200B_200F_202B_200B_206E_200D_202E_206A_200D_202A_200B_202A_200F_202E(val);
				num2 = ((int)num3 * -868879677) ^ -822344978;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000b;
		IL_0052:
		int num5;
		if (num == 2)
		{
			num2 = -1713458230;
			num5 = num2;
		}
		else
		{
			num2 = -2060199026;
			num5 = num2;
		}
		goto IL_0010;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int PlayDelayed(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AudioSource val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(731127323u));
		float num3 = default(float);
		while (true)
		{
			int num = -2061642258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -724504151)) % 4)
				{
				case 0u:
					break;
				case 3u:
					num3 = (float)LuaScriptMgr.GetNumber(L, 2);
					num = (int)(num2 * 1363310074) ^ -1895729815;
					continue;
				case 2u:
					_202D_200F_200F_202C_202D_200B_202A_206B_206A_202C_206A_200B_202A_206D_206D_200D_206F_200F_206D_200D_200E_206B_206D_202A_200B_200F_200F_206E_206B_202D_200C_202E_206D_200C_206F_202B_206F_206C_200D_206F_202E(val, num3);
					num = (int)((num2 * 1563576783) ^ 0x64C919A);
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int PlayScheduled(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AudioSource val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2035515352u));
		double num = LuaScriptMgr.GetNumber(L, 2);
		_202E_206F_200C_202A_200B_202B_202E_206A_200D_206A_200D_202A_202C_202A_200D_206E_206E_206E_200B_206A_206C_200E_200C_206A_206B_206F_200F_200B_200B_200B_200C_206C_202B_206F_206C_206B_200D_206E_200B_200F_202E(val, num);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetScheduledStartTime(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AudioSource val = default(AudioSource);
		double num3 = default(double);
		while (true)
		{
			int num = 2115869884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x1F727B39)) % 4)
				{
				case 3u:
					break;
				case 1u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3245250556u));
					num = (int)((num2 * 650006524) ^ 0x79522019);
					continue;
				case 0u:
					num3 = LuaScriptMgr.GetNumber(L, 2);
					num = ((int)num2 * -822368042) ^ 0x354A6093;
					continue;
				default:
					_202A_206E_202C_200C_200E_202A_202D_200B_206F_206F_206B_202D_202B_202A_202D_202B_202A_202D_206C_200D_202A_206C_200B_206D_206F_202E_206F_202B_202D_206C_202B_206F_200E_202B_206D_206D_206B_200B_202E_200F_202E(val, num3);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetScheduledEndTime(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 2);
		AudioSource val = default(AudioSource);
		double num3 = default(double);
		while (true)
		{
			int num = 1281121242;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x5FC168D5)) % 4)
				{
				case 0u:
					break;
				case 3u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2035515352u));
					num = ((int)num2 * -1878727675) ^ -493809249;
					continue;
				case 1u:
					num3 = LuaScriptMgr.GetNumber(L, 2);
					num = (int)((num2 * 1615129677) ^ 0x7A93035E);
					continue;
				default:
					_202C_200F_202A_202D_200D_200B_202C_206E_200B_206C_200E_200E_200F_200B_206A_200C_200D_206F_200F_200F_200E_206B_200C_206C_200B_206F_202E_202D_206C_200F_206F_202A_206D_200C_206B_206B_202E_202C_206C_206A_202E(val, num3);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Stop(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		AudioSource val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(777542013u));
		_200E_202A_200F_202A_200F_202A_200F_202B_200C_202A_206C_206F_200D_206B_206E_206B_206B_200D_206A_206A_200E_206B_206E_206D_200D_206B_206E_206E_206C_202B_202D_206B_206F_202A_200D_202A_202E_206A_202B_206B_202E(val);
		return 0;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Pause(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num = -1116076466;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1332984407)) % 4)
				{
				case 2u:
					break;
				case 3u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(777542013u));
					num = (int)((num2 * 243219909) ^ 0x2E72E596);
					continue;
				case 0u:
					_202A_206B_200B_200F_202C_202A_206F_200F_200F_200D_206A_206D_200B_202A_202E_200D_202A_200B_206C_200F_202E_206A_200F_200B_202E_206A_200D_206A_202B_202B_200F_206F_200D_200E_200E_202E_206B_206D_206B_202B_202E(val);
					num = ((int)num2 * -1119393029) ^ 0x416F694;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int UnPause(IntPtr L)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 1);
		while (true)
		{
			int num = -1456755340;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1590016276)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					return 0;
				}
				break;
				IL_0029:
				AudioSource val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3245250556u));
				_202E_200D_200F_202A_200C_200B_200C_202B_206A_202B_206E_206C_206B_202B_206A_206B_206C_206F_206D_206B_202D_202B_202E_202A_200B_202B_202B_206C_200D_202E_200E_202E_202E_202E_200E_202A_206C_206A_206E_200F_202E(val);
				num = (int)(num2 * 1777366179) ^ -1127787875;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int PlayOneShot(IntPtr L)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		AudioSource val = default(AudioSource);
		while (true)
		{
			int num2 = 677939572;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)(num2 ^ 0x287AF059)) % 8)
				{
				case 3u:
					break;
				case 1u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2035515352u));
					num2 = (int)((num3 * 2122674829) ^ 0x1D7EAC5A);
					continue;
				case 0u:
				{
					AudioSource val3 = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(3245250556u));
					AudioClip val4 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 2, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioClip).TypeHandle));
					_202C_206A_200D_206B_206B_206B_200E_206A_200E_200F_200F_206A_206C_206B_200E_202A_206D_206B_206F_202B_206B_202D_202C_200B_200E_200B_200D_200C_200F_200F_202B_206B_200C_202A_200D_200B_202D_206A_200B_206F_202E(val3, val4);
					return 0;
				}
				case 6u:
				{
					AudioClip val2 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 2, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioClip).TypeHandle));
					float num6 = (float)LuaScriptMgr.GetNumber(L, 3);
					_206C_200B_206F_200C_206D_200C_206A_200C_206C_202A_200F_206C_206B_202D_202B_206E_202D_206F_202D_206D_202C_200E_200E_206F_200C_206F_206B_200B_206A_206F_200F_200D_202C_202A_202D_200C_200C_206D_200F_206A_202E(val, val2, num6);
					num2 = (int)(num3 * 593168563) ^ -336745140;
					continue;
				}
				case 2u:
				{
					int num7;
					if (num == 3)
					{
						num2 = 2022347664;
						num7 = num2;
					}
					else
					{
						num2 = 905802685;
						num7 = num2;
					}
					continue;
				}
				case 7u:
					return 0;
				case 5u:
				{
					int num4;
					int num5;
					if (num != 2)
					{
						num4 = 394191481;
						num5 = num4;
					}
					else
					{
						num4 = 418773011;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 1042104434);
					continue;
				}
				default:
					LuaDLL.luaL_error(L, global::_003CModule_003E._202E_200D_200D_200B_202E_206D_202C_200E_206B_200C_202C_206E_206A_200C_202C_202E_202C_200E_200E_206C_200D_200B_206B_200C_202E_202A_200B_206C_200F_206E_206E_202E_200F_206B_202C_206D_200F_202D_200E_202D_202E<string>(1919637746u));
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int PlayClipAtPoint(IntPtr L)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		int num = LuaDLL.lua_gettop(L);
		if (num == 2)
		{
			goto IL_000e;
		}
		goto IL_00b4;
		IL_000e:
		int num2 = -92985236;
		goto IL_0013;
		IL_0013:
		AudioClip val2 = default(AudioClip);
		Vector3 vector = default(Vector3);
		float num4 = default(float);
		Vector3 vector2 = default(Vector3);
		AudioClip val = default(AudioClip);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)(num2 ^ -1204854275)) % 10)
			{
			case 5u:
				break;
			case 7u:
				_206F_206C_202D_200F_202A_206A_206B_206B_202B_200C_206E_200B_202A_206D_206F_202A_200B_202C_202A_206C_200D_206D_202C_202D_206D_200C_202D_206A_200E_206E_206A_206C_200B_206E_206A_202D_200C_206E_202E_200E_202E(val2, vector, num4);
				return 0;
			case 1u:
				vector2 = LuaScriptMgr.GetVector3(L, 2);
				num2 = (int)(num3 * 1682930522) ^ -1207120821;
				continue;
			case 6u:
				_202B_202B_202D_206B_206D_202A_202A_202C_200C_206A_202E_202E_200B_200F_200E_202C_202A_202C_206C_202E_206E_200C_200E_200D_200D_202C_202D_206F_200D_206E_206B_206C_202A_202C_200F_202D_200F_206E_200F_206F_202E(val, vector2);
				num2 = (int)((num3 * 1344763791) ^ 0x452F92B1);
				continue;
			case 8u:
				return 0;
			case 0u:
				goto IL_00b4;
			case 4u:
				val2 = (AudioClip)LuaScriptMgr.GetUnityObject(L, 1, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioClip).TypeHandle));
				vector = LuaScriptMgr.GetVector3(L, 2);
				num4 = (float)LuaScriptMgr.GetNumber(L, 3);
				num2 = ((int)num3 * -2070855975) ^ 0xFD51C98;
				continue;
			case 9u:
				val = (AudioClip)LuaScriptMgr.GetUnityObject(L, 1, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioClip).TypeHandle));
				num2 = ((int)num3 * -631636543) ^ -1963297023;
				continue;
			case 3u:
				LuaDLL.luaL_error(L, global::_003CModule_003E._200B_202D_202D_202E_206D_202E_206C_200C_202B_200B_206E_202A_206C_206F_202B_206E_200E_206B_200E_206F_202E_202C_200B_200B_200C_206B_200C_200C_200C_202E_200C_200F_206F_202E_202D_206C_200D_200C_202E_206B_202E<string>(192876999u));
				num2 = -638564869;
				continue;
			default:
				return 0;
			}
			break;
		}
		goto IL_000e;
		IL_00b4:
		int num5;
		if (num == 3)
		{
			num2 = -1314888463;
			num5 = num2;
		}
		else
		{
			num2 = -757742606;
			num5 = num2;
		}
		goto IL_0013;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetCustomCurve(IntPtr L)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioSource val3 = default(AudioSource);
		while (true)
		{
			int num = 1708786274;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x3BBD73B7)) % 4)
				{
				case 3u:
					break;
				case 1u:
					val3 = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202E_200E_202B_202E_206D_200E_206E_206C_206D_206D_206A_200C_202D_202D_202D_206C_202D_200D_206F_206F_206B_202C_206D_202C_206D_200F_206F_206A_200C_202A_202B_200D_202A_202D_206B_200F_206F_200C_206D_202E<string>(2035515352u));
					num = ((int)num2 * -960566984) ^ 0x4BF1E17;
					continue;
				case 0u:
				{
					AudioSourceCurveType val = (AudioSourceCurveType)(int)LuaScriptMgr.GetNetObject(L, 2, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioSourceCurveType).TypeHandle));
					AnimationCurve val2 = (AnimationCurve)LuaScriptMgr.GetNetObject(L, 3, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AnimationCurve).TypeHandle));
					_200E_206A_200E_202E_206D_206D_202D_202E_200C_202C_200B_202D_202E_202A_200C_202B_202B_206E_200F_206F_206F_200B_206C_200F_200E_206C_206C_206A_202C_200D_202D_200E_202D_206B_202B_202D_206C_206D_206E_206D_202E(val3, val, val2);
					num = (int)((num2 * 1790385295) ^ 0x43BCAE21);
					continue;
				}
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetCustomCurve(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		LuaScriptMgr.CheckArgsCount(L, 2);
		AudioSource val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(777542013u));
		AudioSourceCurveType val2 = default(AudioSourceCurveType);
		AnimationCurve o = default(AnimationCurve);
		while (true)
		{
			int num = -694216438;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -2027296468)) % 4)
				{
				case 0u:
					break;
				case 2u:
					val2 = (AudioSourceCurveType)(int)LuaScriptMgr.GetNetObject(L, 2, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(AudioSourceCurveType).TypeHandle));
					num = ((int)num2 * -485097740) ^ 0x81ADCBF;
					continue;
				case 3u:
					o = _206F_206A_206E_206C_202B_206C_202E_200F_202E_206B_202E_206D_206A_200E_200C_200E_202C_200E_202C_200C_200B_206B_202E_200E_206E_200D_202D_200C_200C_200B_206B_200E_200F_206B_202B_202B_206C_206D_202C_206F_202E(val, val2);
					num = ((int)num2 * -1374565309) ^ 0xA827364;
					continue;
				default:
					LuaScriptMgr.PushObject(L, o);
					return 1;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetOutputData(IntPtr L)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioSource val = default(AudioSource);
		float[] arrayNumber = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = 898352209;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ 0x14EA9597)) % 4)
				{
				case 3u:
					break;
				case 2u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(731127323u));
					arrayNumber = LuaScriptMgr.GetArrayNumber<float>(L, 2);
					num = (int)((num2 * 2037511235) ^ 0x7ADA5254);
					continue;
				case 1u:
					num3 = (int)LuaScriptMgr.GetNumber(L, 3);
					num = ((int)num2 * -2045819045) ^ 0x13C74FE0;
					continue;
				default:
					_200E_206D_202C_206B_200E_200C_200C_202C_206D_200D_200D_206A_202C_200D_202A_202B_202D_206E_206A_202B_206B_206B_206A_200F_206E_202E_200D_206E_206D_200D_202E_202D_202E_206F_200C_202A_206E_200D_200D_206D_202E(val, arrayNumber, num3);
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetSpectrumData(IntPtr L)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 4);
		AudioSource val = default(AudioSource);
		float[] arrayNumber = default(float[]);
		int num3 = default(int);
		while (true)
		{
			int num = -159066098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -1318223598)) % 5)
				{
				case 4u:
					break;
				case 0u:
				{
					FFTWindow val2 = (FFTWindow)(int)LuaScriptMgr.GetNetObject(L, 4, _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(typeof(FFTWindow).TypeHandle));
					_202A_206D_202D_206D_206A_200E_202C_206C_206F_200B_202B_200E_202E_206F_202D_206F_202C_202B_206C_206D_202B_206F_202D_206D_206D_200D_200F_200F_202B_202B_206D_200E_202B_202C_200B_206C_200F_206A_202C_202B_202E(val, arrayNumber, num3, val2);
					num = ((int)num2 * -1809238387) ^ 0x2F10F491;
					continue;
				}
				case 3u:
					arrayNumber = LuaScriptMgr.GetArrayNumber<float>(L, 2);
					num3 = (int)LuaScriptMgr.GetNumber(L, 3);
					num = ((int)num2 * -1121523133) ^ 0x38D4170B;
					continue;
				case 1u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206D_206A_202B_200C_202A_200E_206D_202A_200B_206A_200F_200F_206C_206E_206A_200D_200E_202D_202C_202B_202B_206B_206A_202D_206D_200E_206F_206F_200C_206B_200F_202E_200E_200D_206E_202C_206C_206D_206C_206B_202E<string>(777542013u));
					num = ((int)num2 * -1419186930) ^ 0x75A999BE;
					continue;
				default:
					return 0;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int SetSpatializerFloat(IntPtr L)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioSource val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(731127323u));
		int num = (int)LuaScriptMgr.GetNumber(L, 2);
		float num2 = (float)LuaScriptMgr.GetNumber(L, 3);
		bool b = _202C_200D_206C_200C_206B_206B_206E_200B_206F_200E_202E_206A_202A_200B_200B_202E_202E_206B_206F_202C_202E_206B_206E_202B_206F_206E_200F_200B_206C_200B_206D_200B_206B_206C_202B_202B_200B_206F_200E_202D_202E(val, num, num2);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int GetSpatializerFloat(IntPtr L)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		LuaScriptMgr.CheckArgsCount(L, 3);
		AudioSource val = default(AudioSource);
		float d = default(float);
		while (true)
		{
			int num = -1071106643;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(num ^ -939637864)) % 4)
				{
				case 2u:
					break;
				case 1u:
					val = (AudioSource)LuaScriptMgr.GetUnityObjectSelf(L, 1, global::_003CModule_003E._206E_202A_206F_206F_202C_206D_206F_206C_200F_206D_200D_200C_206A_206D_206C_206C_206F_202C_202C_200E_200C_206C_200D_206A_202E_202A_200C_202A_206B_200D_202E_200C_202E_200D_200B_200B_206E_200D_202C_206F_202E<string>(731127323u));
					num = ((int)num2 * -1384993147) ^ -496606239;
					continue;
				case 0u:
				{
					int num3 = (int)LuaScriptMgr.GetNumber(L, 2);
					bool b = _206A_206E_200D_200C_200F_206D_206B_200F_200D_200B_202D_200C_200E_206C_206B_206E_200B_200B_206A_206F_206F_206B_202B_200B_202E_202C_200B_202E_202C_206E_206E_202C_206C_202C_206A_202E_202A_206A_200D_206F_202E(val, num3, ref d);
					LuaScriptMgr.Push(L, b);
					LuaScriptMgr.Push(L, d);
					num = ((int)num2 * -384000691) ^ 0x463D4A77;
					continue;
				}
				default:
					return 2;
				}
				break;
			}
		}
	}

	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	private static int Lua_Eq(IntPtr L)
	{
		LuaScriptMgr.CheckArgsCount(L, 2);
		object luaObject = LuaScriptMgr.GetLuaObject(L, 1);
		Object val = (Object)((luaObject is Object) ? luaObject : null);
		object luaObject2 = LuaScriptMgr.GetLuaObject(L, 2);
		Object val2 = (Object)((luaObject2 is Object) ? luaObject2 : null);
		bool b = _200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E(val, val2);
		LuaScriptMgr.Push(L, b);
		return 1;
	}

	static Type _202A_200B_202A_200F_206F_202D_202A_200B_200E_206C_206B_200C_202B_202D_202B_200E_202D_202B_200C_202B_202E_200F_206D_200F_202A_206C_206E_200E_206D_202B_200E_202A_200E_200B_202D_206E_202E_202B_202E_202B_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static AudioSource _200F_202B_202D_206F_206A_206D_202B_202B_200C_200F_206C_202C_200C_202E_202D_202C_206E_200B_202B_202A_202C_200F_206B_200E_206F_200E_206E_202B_206D_206F_206F_202E_200F_206F_202A_206D_202B_202C_206E_200E_202E()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new AudioSource();
	}

	static bool _200C_206B_202E_202C_200F_202D_200D_202C_206D_200D_206B_206C_206E_200B_200D_202A_206F_206E_206D_206F_206D_202E_206D_206F_206C_202B_206A_206E_202D_200E_202C_206C_206A_206E_206D_206A_206E_202C_202C_206D_202E(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static float _200C_206D_200F_206C_202E_200C_206E_200E_200C_202A_200D_206F_200C_202C_206D_200C_200E_200C_202C_206C_206C_202D_200E_200E_202D_206E_200F_206C_200C_206A_202B_200C_206F_200D_206B_200D_200B_206F_206F_202E(AudioSource P_0)
	{
		return P_0.volume;
	}

	static float _200F_200C_206C_200D_206C_202E_206E_200C_202D_206E_200C_200C_202E_202C_202D_206C_206B_200B_206D_202B_202A_200F_202C_200D_202D_206D_202C_202D_200E_200B_200B_202E_202A_206A_200D_200E_202B_202C_200C_202A_202E(AudioSource P_0)
	{
		return P_0.pitch;
	}

	static float _206D_202D_206B_202E_202E_206C_202E_206C_206F_202E_206A_206E_202E_206E_202C_202E_202D_206E_200D_200D_202D_202B_200E_206E_202E_206D_200E_202A_206F_200F_200D_200C_202D_200C_202A_206D_200C_200E_206A_202A_202E(AudioSource P_0)
	{
		return P_0.time;
	}

	static int _200F_200E_206F_202A_200F_202A_206B_206B_206F_200B_206D_206D_202A_206D_202E_200E_200E_206A_202B_202E_202E_202B_206F_206D_206C_202E_200F_200F_206F_200F_206A_206B_200C_206A_200C_202E_202A_206B_206B_206A_202E(AudioSource P_0)
	{
		return P_0.timeSamples;
	}

	static AudioClip _202A_206A_200D_206F_206A_200D_202C_206E_206F_202C_202B_200B_206B_202D_206C_200F_206A_200B_200C_206E_202C_206D_200C_206B_206B_200D_200B_202C_200F_200D_200F_202E_202B_206D_200E_200E_200D_202C_206E_202E(AudioSource P_0)
	{
		return P_0.clip;
	}

	static AudioMixerGroup _206C_202D_206E_206E_202A_200C_206C_202E_202E_202D_206E_200F_200E_200B_206F_202B_206E_200C_206A_202B_202A_202A_202B_200F_200D_200D_202A_200D_202A_200B_200E_200C_200F_202D_202A_202B_206B_200C_202D_200F_202E(AudioSource P_0)
	{
		return P_0.outputAudioMixerGroup;
	}

	static bool _202C_202C_202E_202A_200D_206F_202A_206E_206F_200D_206F_202A_202C_200E_202E_202E_206B_206F_206A_200B_200B_202B_202E_202A_202D_206E_202E_202A_200D_202B_200F_200F_202C_206F_202A_206B_200B_206D_200F_202C_202E(AudioSource P_0)
	{
		return P_0.isPlaying;
	}

	static bool _200C_200D_202D_200B_206A_200C_202E_200E_200D_206A_200D_200B_206D_200C_202D_202B_200E_200B_202B_200B_200B_206C_202A_200C_206F_206A_200B_206B_200B_206E_206E_202B_206C_200C_202B_200D_206F_206F_206F_206C_202E(AudioSource P_0)
	{
		return P_0.loop;
	}

	static bool _202D_202C_206E_200F_202C_200D_200B_206E_206A_200B_200D_206C_202E_200E_200B_206F_200E_202B_200C_206A_200E_200D_200F_206B_202E_206F_206C_202A_202B_206A_206B_206E_206D_202A_206F_200E_202D_206A_202C_206D_202E(AudioSource P_0)
	{
		return P_0.ignoreListenerVolume;
	}

	static bool _200E_206E_206E_206E_200C_202A_206A_202B_206A_202D_206A_206A_200B_200F_202B_200C_202D_200E_206E_202C_202C_202D_202D_202B_206A_202C_206A_206A_206D_200B_200D_200D_202D_200E_200C_200B_200F_200F_200B_200F_202E(AudioSource P_0)
	{
		return P_0.playOnAwake;
	}

	static bool _206E_202E_202D_206D_206C_206B_200C_206E_202B_202E_200E_200E_200C_202E_202A_200E_202D_200C_200F_206B_202C_200F_200B_200C_206A_200B_200E_200C_206D_202D_202C_206A_202A_206F_202C_200D_202C_202D_202A_202E(AudioSource P_0)
	{
		return P_0.ignoreListenerPause;
	}

	static AudioVelocityUpdateMode _200D_202E_202E_206F_206F_200B_206F_206B_200C_202B_202E_206F_200C_200E_206D_206F_202A_202E_200D_202E_200E_202D_206C_202B_206D_202E_206F_200C_202E_202D_200C_200E_206A_206C_200C_206B_206F_202C_200D_202C_202E(AudioSource P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.velocityUpdateMode;
	}

	static float _202B_206E_202A_202B_200D_206E_202A_202D_206E_200E_200B_200D_200F_206D_202B_200F_202D_202D_202C_200B_202A_206F_202B_202D_206A_200F_202A_206C_202E_206F_206E_206F_200B_202E_200C_206B_200B_202E_200F_202C_202E(AudioSource P_0)
	{
		return P_0.panStereo;
	}

	static float _206E_200C_202E_202C_200C_206D_206B_200C_202C_206D_200F_206A_206F_206C_200F_206B_206B_206F_202A_206B_202E_202B_200C_200D_202D_206E_202C_200E_202B_202E_206D_206C_202E_202B_200D_206B_200C_200B_202A_206C_202E(AudioSource P_0)
	{
		return P_0.spatialBlend;
	}

	static bool _200C_200C_202C_202B_200C_202E_202D_206B_202C_200B_202A_200F_200E_206A_200D_200C_206B_200E_206D_200E_206C_200D_206F_206B_206A_200D_202E_206B_206C_202B_202B_206C_202D_206B_202E_206B_206C_202C_200D_202E(AudioSource P_0)
	{
		return P_0.spatialize;
	}

	static float _206F_206C_206E_206B_200C_206D_200E_202A_200D_200F_202B_206E_200D_200B_202B_200D_200E_202A_200B_200F_206B_206C_202E_206D_202A_202D_202E_202B_200B_200B_202D_200D_206E_206C_206C_206F_206D_202A_200E_206A_202E(AudioSource P_0)
	{
		return P_0.reverbZoneMix;
	}

	static bool _206D_206B_200C_206D_202A_202A_202A_200F_202B_206C_202A_202C_200D_202A_200C_202C_202E_202B_200F_200F_206B_200E_200B_206D_206E_206E_202E_206E_206B_200F_206D_202D_206C_200B_202B_206F_206F_206D_202D_200F_202E(AudioSource P_0)
	{
		return P_0.bypassEffects;
	}

	static bool _200C_206B_202E_200E_202D_206F_200D_206E_206D_202D_206F_206A_200F_200D_206C_206A_202C_200D_202D_206D_200B_202D_200D_200F_202E_200B_206B_200B_200D_206A_206C_202A_206C_206C_200C_206A_200C_200B_202B_202C_202E(AudioSource P_0)
	{
		return P_0.bypassListenerEffects;
	}

	static bool _206F_206B_206A_200B_200E_202E_202E_206C_200D_200C_200F_202E_202C_206E_206D_202B_200E_200F_200E_206F_202B_206B_200F_206E_200F_206B_202E_200B_200C_206D_200C_200F_202C_202A_206B_200E_202D_202C_200B_202E_202E(AudioSource P_0)
	{
		return P_0.bypassReverbZones;
	}

	static float _202D_200B_206B_206F_206A_200D_200E_200D_206A_206C_200D_206E_206E_202B_200D_202C_200D_206F_200C_206A_206B_206A_200F_200D_200F_202D_200E_202D_200D_202A_206A_202B_206A_200D_200D_200E_200C_200D_200B_200F_202E(AudioSource P_0)
	{
		return P_0.dopplerLevel;
	}

	static float _202E_206D_202B_206E_206A_206F_200C_206E_206F_200C_202C_202C_206B_206F_200B_200E_200B_200B_200D_202B_202C_200D_202C_206A_206C_202E_200F_200E_206B_202D_206D_202C_206E_206E_200F_202D_206E_200B_202E_202A_202E(AudioSource P_0)
	{
		return P_0.spread;
	}

	static int _200B_202C_202C_200B_202A_206C_200E_206E_202C_206B_202A_206C_202B_206E_202C_202D_200B_206D_206E_206B_206B_202C_200F_200F_202B_206F_202E_200F_206C_200C_206E_202E_202B_202B_202A_206F_202D_206B_206E_206F_202E(AudioSource P_0)
	{
		return P_0.priority;
	}

	static bool _200C_206D_206C_202C_202D_206E_206A_206A_206A_206C_206D_202A_202C_202B_202D_202A_202C_202E_200F_206D_206F_206F_200F_200E_206D_206E_202B_206B_202B_200C_206E_200F_202C_200F_206B_206A_200D_200E_200F_206C_202E(AudioSource P_0)
	{
		return P_0.mute;
	}

	static float _200E_200C_200F_200D_200B_202C_206B_200F_200C_200F_206A_206E_206E_202A_202C_206D_202A_200B_202C_200C_202B_200C_202B_202C_200F_206A_206F_206E_200D_202C_206A_206C_206F_202D_202C_202D_206B_202C_206A_206A_202E(AudioSource P_0)
	{
		return P_0.minDistance;
	}

	static float _202A_200D_202B_200B_200D_206F_200E_202A_206F_202B_202E_206F_206A_200B_200F_202C_200F_206F_206B_206C_206B_202D_200D_206C_206B_206E_202A_206E_200F_200E_200B_202D_200B_202E_202D_206E_200D_206F_206A_202E_202E(AudioSource P_0)
	{
		return P_0.maxDistance;
	}

	static AudioRolloffMode _206D_202A_200D_202D_200F_206E_206F_200B_202E_206F_200E_206D_200B_202D_206B_200B_206A_202C_202A_206E_202B_202A_206C_206D_200D_200D_206A_202A_202D_206C_200F_200B_206F_206C_202C_202E_206C_206C_200E_202D_202E(AudioSource P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.rolloffMode;
	}

	static void _206D_206A_206D_202E_206F_200D_206A_202A_202E_202A_202B_200D_200D_200E_206C_202D_206A_200E_206E_206F_200B_202D_206C_206F_206B_206E_200B_202C_206E_200D_202B_202A_200B_202D_206E_206A_206E_206D_200B_202B_202E(AudioSource P_0, float P_1)
	{
		P_0.volume = P_1;
	}

	static void _202E_206B_200C_200B_206E_206E_200C_206F_206A_202C_206F_200B_206F_206E_206B_202A_200C_202A_206F_202E_206C_202B_206C_206F_206D_206B_206A_200B_202C_206A_202E_202C_200F_202A_200F_202C_206E_200E_202C_200C_202E(AudioSource P_0, float P_1)
	{
		P_0.pitch = P_1;
	}

	static void _202E_206A_206E_206D_202E_202A_206F_200C_202E_202C_206A_202E_200F_202D_202A_206C_202B_202C_200D_202B_206B_206E_202B_202B_206B_202C_206C_206B_202E_206E_206B_206D_200E_202B_202B_200D_202D_200E_206F_200F_202E(AudioSource P_0, float P_1)
	{
		P_0.time = P_1;
	}

	static void _202A_200B_206D_206B_206A_202D_200D_202D_206A_206E_206A_206C_200E_202A_200B_202C_206D_206A_206A_206D_206C_200F_202E_206E_202B_202D_206E_200D_200E_206B_202E_202E_200E_206B_206B_206D_206C_200C_202B_206C_202E(AudioSource P_0, int P_1)
	{
		P_0.timeSamples = P_1;
	}

	static void _206A_202D_202C_206C_200C_202D_202B_206B_202D_200C_206B_206B_202E_206F_202B_200E_200D_200F_200B_202D_202B_202B_206C_202E_202D_202B_202E_202B_202C_206E_206E_202A_202B_200D_202D_206C_206C_206E_206E_200C_202E(AudioSource P_0, AudioClip P_1)
	{
		P_0.clip = P_1;
	}

	static void _202B_202C_206A_202D_206F_200D_200E_202D_202C_202C_202D_200C_200E_200B_206B_200B_202B_206A_206C_200D_202D_206B_206A_200F_206F_200B_200F_202E_200F_202E_202E_206B_200D_200B_200B_200B_206F_202A_206B_202A_202E(AudioSource P_0, AudioMixerGroup P_1)
	{
		P_0.outputAudioMixerGroup = P_1;
	}

	static void _202A_202C_200F_200F_202A_206A_202C_206F_202C_200B_202E_200D_200E_206C_206A_202C_202C_206E_206C_202D_206D_206E_200C_206A_200D_202C_206A_206A_206F_200E_206B_206F_200E_202C_200F_202D_206B_202B_202D_202C_202E(AudioSource P_0, bool P_1)
	{
		P_0.loop = P_1;
	}

	static void _202C_202A_200E_202C_202C_202C_200D_206C_202D_200F_206D_200E_206F_202D_202C_202B_200F_200D_200E_200D_200B_200C_202C_202C_202A_202B_206F_206B_200D_206E_206E_202A_206C_200E_206D_206D_206C_200C_206A_200E_202E(AudioSource P_0, bool P_1)
	{
		P_0.ignoreListenerVolume = P_1;
	}

	static void _206B_206E_206E_206C_200E_206A_200E_202B_206B_200E_202E_202B_206E_206B_200E_200F_200B_202B_200C_206F_202C_202B_200C_202E_200E_200E_206B_206C_206E_206D_206D_206F_200C_200C_206C_202D_206F_206C_206A_202E(AudioSource P_0, bool P_1)
	{
		P_0.playOnAwake = P_1;
	}

	static void _206F_202A_202E_206F_202B_202C_206D_200B_202B_200B_200F_200B_206A_202E_202E_200C_206B_206F_200B_206F_200F_200E_200D_202E_202B_202C_202C_200C_202C_200D_202A_202A_206B_206F_206D_206B_200C_206E_200B_206D_202E(AudioSource P_0, bool P_1)
	{
		P_0.ignoreListenerPause = P_1;
	}

	static void _200B_206D_206E_206C_200B_202A_202B_200C_206A_202D_206A_202E_202E_206C_206E_200E_200D_206A_200D_202A_202A_200F_202C_202A_202B_206F_206F_200C_200E_202A_206A_202C_202E_200F_206F_200B_200F_202E_200D_202B_202E(AudioSource P_0, AudioVelocityUpdateMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.velocityUpdateMode = P_1;
	}

	static void _200B_200F_202A_206B_200F_206D_206E_206E_202D_206C_206D_200C_200B_206A_206B_206F_206D_202D_206D_206B_202D_202E_200E_206E_200C_200B_200E_200C_202C_202A_200E_206B_200C_200E_206F_202A_202A_206C_200E_202E(AudioSource P_0, float P_1)
	{
		P_0.panStereo = P_1;
	}

	static void _202C_200E_200E_200B_202E_200B_200E_200D_206C_200B_206B_200E_200F_202B_202D_202A_206C_206F_200B_200C_202B_202C_206C_202D_206D_202C_206B_200B_206D_206A_202A_206E_202B_202C_200B_200F_200B_202E_200F_202E_202E(AudioSource P_0, float P_1)
	{
		P_0.spatialBlend = P_1;
	}

	static void _202D_206E_202D_206C_202E_202D_200E_206B_206F_200F_202A_202B_206A_202D_202A_200B_206A_202D_206C_200D_206E_206B_200D_202C_202C_206A_206E_206E_206E_202C_202C_200F_200C_200B_206C_200C_200C_200D_200C_206A_202E(AudioSource P_0, bool P_1)
	{
		P_0.spatialize = P_1;
	}

	static void _200F_206D_206D_206E_202B_206F_202B_200F_200B_200E_206E_200E_202C_200E_206F_200E_202D_202E_202A_202B_206F_200B_200F_202E_206D_202D_206F_202D_200C_206A_200D_200B_202C_202D_202E_200D_206B_206B_206F_202B_202E(AudioSource P_0, float P_1)
	{
		P_0.reverbZoneMix = P_1;
	}

	static void _202C_202B_206E_206D_206C_200C_206D_202B_200D_206E_206D_206F_200D_206D_206B_206B_202C_202E_200B_200B_202E_200E_206B_200B_206C_206F_200F_202D_206E_206F_206C_200F_206D_200F_206B_202A_202E_206D_202D_202C_202E(AudioSource P_0, bool P_1)
	{
		P_0.bypassEffects = P_1;
	}

	static void _202D_202C_206D_206F_206A_202E_202C_206E_206C_200B_202B_206F_202C_202C_202D_200F_206A_206D_202A_206B_206A_206E_200C_202D_200B_200C_200E_200B_202B_200F_200D_200B_202C_206F_206C_200B_206F_202C_202A_200F_202E(AudioSource P_0, bool P_1)
	{
		P_0.bypassListenerEffects = P_1;
	}

	static void _200F_206D_206A_206F_206D_202B_202B_200C_200B_200F_206E_200F_202B_206D_206D_200E_200F_206E_202B_202A_202D_206E_202C_206F_202B_202A_206F_206C_200E_202A_206F_206E_206D_206B_206C_202D_200C_202C_206E_206D_202E(AudioSource P_0, bool P_1)
	{
		P_0.bypassReverbZones = P_1;
	}

	static void _206E_206C_200E_206D_200F_200D_206D_200B_202C_200D_202B_202C_200F_206B_200B_206E_202E_206A_202A_206B_200B_206B_206A_202D_200D_206B_202E_200E_206C_202D_206F_202C_202D_206A_200D_202E_202C_200B_200B_202E_202E(AudioSource P_0, float P_1)
	{
		P_0.dopplerLevel = P_1;
	}

	static void _206D_206E_200D_200B_200D_202A_206A_206A_206B_206F_200F_206F_200C_206B_200F_202E_202B_202C_200E_200C_206D_202A_206E_206C_206D_206F_206D_202D_202E_206B_206E_200C_206B_206F_200C_200C_206A_200B_206F_200F_202E(AudioSource P_0, float P_1)
	{
		P_0.spread = P_1;
	}

	static void _200C_200B_206F_202A_200C_206E_202C_206B_200E_200C_206A_200D_202A_202C_206F_200E_202D_200D_200D_200B_200E_206B_202B_206A_206D_200B_200C_200D_206C_200F_200D_200E_200F_206C_200D_202D_200F_200B_202B_206B_202E(AudioSource P_0, int P_1)
	{
		P_0.priority = P_1;
	}

	static void _200B_202E_206E_202C_206F_206F_206F_200E_206B_200B_202E_200C_200B_200C_202E_200E_206E_200F_206C_206C_206C_202E_202B_200B_206F_202E_200C_206E_202C_202C_200E_206B_206C_202A_200C_202E_206D_206E_206F_202C_202E(AudioSource P_0, bool P_1)
	{
		P_0.mute = P_1;
	}

	static void _206F_200E_200B_200F_206F_202B_206E_200E_202A_206E_200E_200E_202D_200D_200D_202A_206C_200D_206A_200E_202E_202C_202B_200C_200C_202E_206C_202A_200F_200C_206F_206C_200C_206A_202A_202B_206D_206B_200D_202E(AudioSource P_0, float P_1)
	{
		P_0.minDistance = P_1;
	}

	static void _206C_202E_206A_202C_200C_202B_206D_200B_206F_206C_202D_200C_206B_206A_206C_200D_202B_206D_200B_202C_200D_206C_206F_200B_200B_202B_206D_206B_202E_200D_200C_202D_200D_206D_200C_202E_206D_200D_206E_202B_202E(AudioSource P_0, float P_1)
	{
		P_0.maxDistance = P_1;
	}

	static void _202D_206C_206F_200D_202A_202A_200B_200D_200F_200C_200B_206F_206E_200B_206E_206E_200F_200F_206F_200D_202A_200B_200D_202A_202D_206B_202A_200F_200F_206F_206D_202C_200B_202A_202D_200C_206C_206E_206A_202B_202E(AudioSource P_0, AudioRolloffMode P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.rolloffMode = P_1;
	}

	static void _206E_202A_206F_206E_200F_200D_202E_200F_206D_200D_206E_202C_200F_206B_206E_200C_202D_200B_200E_200C_202C_200C_206E_200E_202A_202C_202D_200B_200F_202B_200B_206E_200D_202E_206A_200D_202A_200B_202A_200F_202E(AudioSource P_0)
	{
		P_0.Play();
	}

	static void _200D_200E_200E_200F_206D_206B_202D_202D_206A_206A_202E_202C_206A_202A_206E_206F_206C_206F_206A_200B_206C_202C_202E_202E_200E_202D_200B_202E_200C_206A_206B_206B_200E_200C_206B_206B_202D_200E_206C_202D_202E(AudioSource P_0, ulong P_1)
	{
		P_0.Play(P_1);
	}

	static void _202D_200F_200F_202C_202D_200B_202A_206B_206A_202C_206A_200B_202A_206D_206D_200D_206F_200F_206D_200D_200E_206B_206D_202A_200B_200F_200F_206E_206B_202D_200C_202E_206D_200C_206F_202B_206F_206C_200D_206F_202E(AudioSource P_0, float P_1)
	{
		P_0.PlayDelayed(P_1);
	}

	static void _202E_206F_200C_202A_200B_202B_202E_206A_200D_206A_200D_202A_202C_202A_200D_206E_206E_206E_200B_206A_206C_200E_200C_206A_206B_206F_200F_200B_200B_200B_200C_206C_202B_206F_206C_206B_200D_206E_200B_200F_202E(AudioSource P_0, double P_1)
	{
		P_0.PlayScheduled(P_1);
	}

	static void _202A_206E_202C_200C_200E_202A_202D_200B_206F_206F_206B_202D_202B_202A_202D_202B_202A_202D_206C_200D_202A_206C_200B_206D_206F_202E_206F_202B_202D_206C_202B_206F_200E_202B_206D_206D_206B_200B_202E_200F_202E(AudioSource P_0, double P_1)
	{
		P_0.SetScheduledStartTime(P_1);
	}

	static void _202C_200F_202A_202D_200D_200B_202C_206E_200B_206C_200E_200E_200F_200B_206A_200C_200D_206F_200F_200F_200E_206B_200C_206C_200B_206F_202E_202D_206C_200F_206F_202A_206D_200C_206B_206B_202E_202C_206C_206A_202E(AudioSource P_0, double P_1)
	{
		P_0.SetScheduledEndTime(P_1);
	}

	static void _200E_202A_200F_202A_200F_202A_200F_202B_200C_202A_206C_206F_200D_206B_206E_206B_206B_200D_206A_206A_200E_206B_206E_206D_200D_206B_206E_206E_206C_202B_202D_206B_206F_202A_200D_202A_202E_206A_202B_206B_202E(AudioSource P_0)
	{
		P_0.Stop();
	}

	static void _202A_206B_200B_200F_202C_202A_206F_200F_200F_200D_206A_206D_200B_202A_202E_200D_202A_200B_206C_200F_202E_206A_200F_200B_202E_206A_200D_206A_202B_202B_200F_206F_200D_200E_200E_202E_206B_206D_206B_202B_202E(AudioSource P_0)
	{
		P_0.Pause();
	}

	static void _202E_200D_200F_202A_200C_200B_200C_202B_206A_202B_206E_206C_206B_202B_206A_206B_206C_206F_206D_206B_202D_202B_202E_202A_200B_202B_202B_206C_200D_202E_200E_202E_202E_202E_200E_202A_206C_206A_206E_200F_202E(AudioSource P_0)
	{
		P_0.UnPause();
	}

	static void _202C_206A_200D_206B_206B_206B_200E_206A_200E_200F_200F_206A_206C_206B_200E_202A_206D_206B_206F_202B_206B_202D_202C_200B_200E_200B_200D_200C_200F_200F_202B_206B_200C_202A_200D_200B_202D_206A_200B_206F_202E(AudioSource P_0, AudioClip P_1)
	{
		P_0.PlayOneShot(P_1);
	}

	static void _206C_200B_206F_200C_206D_200C_206A_200C_206C_202A_200F_206C_206B_202D_202B_206E_202D_206F_202D_206D_202C_200E_200E_206F_200C_206F_206B_200B_206A_206F_200F_200D_202C_202A_202D_200C_200C_206D_200F_206A_202E(AudioSource P_0, AudioClip P_1, float P_2)
	{
		P_0.PlayOneShot(P_1, P_2);
	}

	static void _202B_202B_202D_206B_206D_202A_202A_202C_200C_206A_202E_202E_200B_200F_200E_202C_202A_202C_206C_202E_206E_200C_200E_200D_200D_202C_202D_206F_200D_206E_206B_206C_202A_202C_200F_202D_200F_206E_200F_206F_202E(AudioClip P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(P_0, P_1);
	}

	static void _206F_206C_202D_200F_202A_206A_206B_206B_202B_200C_206E_200B_202A_206D_206F_202A_200B_202C_202A_206C_200D_206D_202C_202D_206D_200C_202D_206A_200E_206E_206A_206C_200B_206E_206A_202D_200C_206E_202E_200E_202E(AudioClip P_0, Vector3 P_1, float P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		AudioSource.PlayClipAtPoint(P_0, P_1, P_2);
	}

	static void _200E_206A_200E_202E_206D_206D_202D_202E_200C_202C_200B_202D_202E_202A_200C_202B_202B_206E_200F_206F_206F_200B_206C_200F_200E_206C_206C_206A_202C_200D_202D_200E_202D_206B_202B_202D_206C_206D_206E_206D_202E(AudioSource P_0, AudioSourceCurveType P_1, AnimationCurve P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		P_0.SetCustomCurve(P_1, P_2);
	}

	static AnimationCurve _206F_206A_206E_206C_202B_206C_202E_200F_202E_206B_202E_206D_206A_200E_200C_200E_202C_200E_202C_200C_200B_206B_202E_200E_206E_200D_202D_200C_200C_200B_206B_200E_200F_206B_202B_202B_206C_206D_202C_206F_202E(AudioSource P_0, AudioSourceCurveType P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return P_0.GetCustomCurve(P_1);
	}

	static void _200E_206D_202C_206B_200E_200C_200C_202C_206D_200D_200D_206A_202C_200D_202A_202B_202D_206E_206A_202B_206B_206B_206A_200F_206E_202E_200D_206E_206D_200D_202E_202D_202E_206F_200C_202A_206E_200D_200D_206D_202E(AudioSource P_0, float[] P_1, int P_2)
	{
		P_0.GetOutputData(P_1, P_2);
	}

	static void _202A_206D_202D_206D_206A_200E_202C_206C_206F_200B_202B_200E_202E_206F_202D_206F_202C_202B_206C_206D_202B_206F_202D_206D_206D_200D_200F_200F_202B_202B_206D_200E_202B_202C_200B_206C_200F_206A_202C_202B_202E(AudioSource P_0, float[] P_1, int P_2, FFTWindow P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		P_0.GetSpectrumData(P_1, P_2, P_3);
	}

	static bool _202C_200D_206C_200C_206B_206B_206E_200B_206F_200E_202E_206A_202A_200B_200B_202E_202E_206B_206F_202C_202E_206B_206E_202B_206F_206E_200F_200B_206C_200B_206D_200B_206B_206C_202B_202B_200B_206F_200E_202D_202E(AudioSource P_0, int P_1, float P_2)
	{
		return P_0.SetSpatializerFloat(P_1, P_2);
	}

	static bool _206A_206E_200D_200C_200F_206D_206B_200F_200D_200B_202D_200C_200E_206C_206B_206E_200B_200B_206A_206F_206F_206B_202B_200B_202E_202C_200B_202E_202C_206E_206E_202C_206C_202C_206A_202E_202A_206A_200D_206F_202E(AudioSource P_0, int P_1, ref float P_2)
	{
		return P_0.GetSpatializerFloat(P_1, ref P_2);
	}
}
