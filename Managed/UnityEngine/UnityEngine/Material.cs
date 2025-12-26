using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>The material class.</para>
	/// </summary>
	// Token: 0x02000087 RID: 135
	public class Material : Object
	{
		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="contents"></param>
		// Token: 0x060007F1 RID: 2033 RVA: 0x00005212 File Offset: 0x00003412
		[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.")]
		public Material(string contents)
		{
			Material.Internal_CreateWithString(this, contents);
		}

		/// <summary>
		///   <para>Create a temporary Material.</para>
		/// </summary>
		/// <param name="shader">Create a material with a given Shader.</param>
		/// <param name="source">Create a material by copying all properties from another material.</param>
		// Token: 0x060007F2 RID: 2034 RVA: 0x00005221 File Offset: 0x00003421
		public Material(Shader shader)
		{
			Material.Internal_CreateWithShader(this, shader);
		}

		/// <summary>
		///   <para>Create a temporary Material.</para>
		/// </summary>
		/// <param name="shader">Create a material with a given Shader.</param>
		/// <param name="source">Create a material by copying all properties from another material.</param>
		// Token: 0x060007F3 RID: 2035 RVA: 0x00005230 File Offset: 0x00003430
		public Material(Material source)
		{
			Material.Internal_CreateWithMaterial(this, source);
		}

		/// <summary>
		///   <para>The shader used by the material.</para>
		/// </summary>
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007F4 RID: 2036
		// (set) Token: 0x060007F5 RID: 2037
		public extern Shader shader
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The main material's color.</para>
		/// </summary>
		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0000523F File Offset: 0x0000343F
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0000524C File Offset: 0x0000344C
		public Color color
		{
			get
			{
				return this.GetColor("_Color");
			}
			set
			{
				this.SetColor("_Color", value);
			}
		}

		/// <summary>
		///   <para>The material's texture.</para>
		/// </summary>
		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0000525A File Offset: 0x0000345A
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00005267 File Offset: 0x00003467
		public Texture mainTexture
		{
			get
			{
				return this.GetTexture("_MainTex");
			}
			set
			{
				this.SetTexture("_MainTex", value);
			}
		}

		/// <summary>
		///   <para>The texture offset of the main texture.</para>
		/// </summary>
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x00005275 File Offset: 0x00003475
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00005282 File Offset: 0x00003482
		public Vector2 mainTextureOffset
		{
			get
			{
				return this.GetTextureOffset("_MainTex");
			}
			set
			{
				this.SetTextureOffset("_MainTex", value);
			}
		}

		/// <summary>
		///   <para>The texture scale of the main texture.</para>
		/// </summary>
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00005290 File Offset: 0x00003490
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0000529D File Offset: 0x0000349D
		public Vector2 mainTextureScale
		{
			get
			{
				return this.GetTextureScale("_MainTex");
			}
			set
			{
				this.SetTextureScale("_MainTex", value);
			}
		}

		/// <summary>
		///   <para>Set a named color value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="color"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007FE RID: 2046 RVA: 0x000052AB File Offset: 0x000034AB
		public void SetColor(string propertyName, Color color)
		{
			this.SetColor(Shader.PropertyToID(propertyName), color);
		}

		/// <summary>
		///   <para>Set a named color value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="color"></param>
		/// <param name="nameID"></param>
		// Token: 0x060007FF RID: 2047 RVA: 0x000052BA File Offset: 0x000034BA
		public void SetColor(int nameID, Color color)
		{
			Material.INTERNAL_CALL_SetColor(this, nameID, ref color);
		}

		// Token: 0x06000800 RID: 2048
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetColor(Material self, int nameID, ref Color color);

		/// <summary>
		///   <para>Get a named color value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000801 RID: 2049 RVA: 0x000052C5 File Offset: 0x000034C5
		public Color GetColor(string propertyName)
		{
			return this.GetColor(Shader.PropertyToID(propertyName));
		}

		/// <summary>
		///   <para>Get a named color value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000802 RID: 2050
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Color GetColor(int nameID);

		/// <summary>
		///   <para>Set a named vector value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="vector"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000803 RID: 2051 RVA: 0x000052D3 File Offset: 0x000034D3
		public void SetVector(string propertyName, Vector4 vector)
		{
			this.SetColor(propertyName, new Color(vector.x, vector.y, vector.z, vector.w));
		}

		/// <summary>
		///   <para>Set a named vector value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="vector"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000804 RID: 2052 RVA: 0x000052FD File Offset: 0x000034FD
		public void SetVector(int nameID, Vector4 vector)
		{
			this.SetColor(nameID, new Color(vector.x, vector.y, vector.z, vector.w));
		}

		/// <summary>
		///   <para>Get a named vector value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000805 RID: 2053 RVA: 0x0001474C File Offset: 0x0001294C
		public Vector4 GetVector(string propertyName)
		{
			Color color = this.GetColor(propertyName);
			return new Vector4(color.r, color.g, color.b, color.a);
		}

		/// <summary>
		///   <para>Get a named vector value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000806 RID: 2054 RVA: 0x00014784 File Offset: 0x00012984
		public Vector4 GetVector(int nameID)
		{
			Color color = this.GetColor(nameID);
			return new Vector4(color.r, color.g, color.b, color.a);
		}

		/// <summary>
		///   <para>Set a named texture.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="texture"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000807 RID: 2055 RVA: 0x00005327 File Offset: 0x00003527
		public void SetTexture(string propertyName, Texture texture)
		{
			this.SetTexture(Shader.PropertyToID(propertyName), texture);
		}

		/// <summary>
		///   <para>Set a named texture.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="texture"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000808 RID: 2056
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetTexture(int nameID, Texture texture);

		/// <summary>
		///   <para>Get a named texture.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000809 RID: 2057 RVA: 0x00005336 File Offset: 0x00003536
		public Texture GetTexture(string propertyName)
		{
			return this.GetTexture(Shader.PropertyToID(propertyName));
		}

		/// <summary>
		///   <para>Get a named texture.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600080A RID: 2058
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Texture GetTexture(int nameID);

		// Token: 0x0600080B RID: 2059
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTextureOffset(Material mat, string name, out Vector2 output);

		// Token: 0x0600080C RID: 2060
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetTextureScale(Material mat, string name, out Vector2 output);

		/// <summary>
		///   <para>Sets the placement offset of texture propertyName.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="offset"></param>
		// Token: 0x0600080D RID: 2061 RVA: 0x00005344 File Offset: 0x00003544
		public void SetTextureOffset(string propertyName, Vector2 offset)
		{
			Material.INTERNAL_CALL_SetTextureOffset(this, propertyName, ref offset);
		}

		// Token: 0x0600080E RID: 2062
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTextureOffset(Material self, string propertyName, ref Vector2 offset);

		/// <summary>
		///   <para>Gets the placement offset of texture propertyName.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		// Token: 0x0600080F RID: 2063 RVA: 0x000147BC File Offset: 0x000129BC
		public Vector2 GetTextureOffset(string propertyName)
		{
			Vector2 vector;
			Material.Internal_GetTextureOffset(this, propertyName, out vector);
			return vector;
		}

		/// <summary>
		///   <para>Sets the placement scale of texture propertyName.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="scale"></param>
		// Token: 0x06000810 RID: 2064 RVA: 0x0000534F File Offset: 0x0000354F
		public void SetTextureScale(string propertyName, Vector2 scale)
		{
			Material.INTERNAL_CALL_SetTextureScale(this, propertyName, ref scale);
		}

		// Token: 0x06000811 RID: 2065
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetTextureScale(Material self, string propertyName, ref Vector2 scale);

		/// <summary>
		///   <para>Gets the placement scale of texture propertyName.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		// Token: 0x06000812 RID: 2066 RVA: 0x000147D4 File Offset: 0x000129D4
		public Vector2 GetTextureScale(string propertyName)
		{
			Vector2 vector;
			Material.Internal_GetTextureScale(this, propertyName, out vector);
			return vector;
		}

		/// <summary>
		///   <para>Set a named matrix for the shader.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="matrix"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000813 RID: 2067 RVA: 0x0000535A File Offset: 0x0000355A
		public void SetMatrix(string propertyName, Matrix4x4 matrix)
		{
			this.SetMatrix(Shader.PropertyToID(propertyName), matrix);
		}

		/// <summary>
		///   <para>Set a named matrix for the shader.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="matrix"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000814 RID: 2068 RVA: 0x00005369 File Offset: 0x00003569
		public void SetMatrix(int nameID, Matrix4x4 matrix)
		{
			Material.INTERNAL_CALL_SetMatrix(this, nameID, ref matrix);
		}

		// Token: 0x06000815 RID: 2069
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_SetMatrix(Material self, int nameID, ref Matrix4x4 matrix);

		/// <summary>
		///   <para>Get a named matrix value from the shader.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000816 RID: 2070 RVA: 0x00005374 File Offset: 0x00003574
		public Matrix4x4 GetMatrix(string propertyName)
		{
			return this.GetMatrix(Shader.PropertyToID(propertyName));
		}

		/// <summary>
		///   <para>Get a named matrix value from the shader.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000817 RID: 2071
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Matrix4x4 GetMatrix(int nameID);

		/// <summary>
		///   <para>Set a named float value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000818 RID: 2072 RVA: 0x00005382 File Offset: 0x00003582
		public void SetFloat(string propertyName, float value)
		{
			this.SetFloat(Shader.PropertyToID(propertyName), value);
		}

		/// <summary>
		///   <para>Set a named float value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000819 RID: 2073
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetFloat(int nameID, float value);

		/// <summary>
		///   <para>Get a named float value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600081A RID: 2074 RVA: 0x00005391 File Offset: 0x00003591
		public float GetFloat(string propertyName)
		{
			return this.GetFloat(Shader.PropertyToID(propertyName));
		}

		/// <summary>
		///   <para>Get a named float value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600081B RID: 2075
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetFloat(int nameID);

		/// <summary>
		///   <para>Set a named integer value.
		///
		/// When setting values on materials using the Standard Shader, you should be aware that you may need to use EnableKeyword to enable features of the shader that were not previously in use. For more detail, read wiki:
		/// MaterialsAccessingViaScript|Accessing Materials via Script.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600081C RID: 2076 RVA: 0x0000539F File Offset: 0x0000359F
		public void SetInt(string propertyName, int value)
		{
			this.SetFloat(propertyName, (float)value);
		}

		/// <summary>
		///   <para>Set a named integer value.
		///
		/// When setting values on materials using the Standard Shader, you should be aware that you may need to use EnableKeyword to enable features of the shader that were not previously in use. For more detail, read wiki:
		/// MaterialsAccessingViaScript|Accessing Materials via Script.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600081D RID: 2077 RVA: 0x000053AA File Offset: 0x000035AA
		public void SetInt(int nameID, int value)
		{
			this.SetFloat(nameID, (float)value);
		}

		/// <summary>
		///   <para>Get a named integer value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600081E RID: 2078 RVA: 0x000053B5 File Offset: 0x000035B5
		public int GetInt(string propertyName)
		{
			return (int)this.GetFloat(propertyName);
		}

		/// <summary>
		///   <para>Get a named integer value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x0600081F RID: 2079 RVA: 0x000053BF File Offset: 0x000035BF
		public int GetInt(int nameID)
		{
			return (int)this.GetFloat(nameID);
		}

		/// <summary>
		///   <para>Set a ComputeBuffer value.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="buffer"></param>
		// Token: 0x06000820 RID: 2080
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetBuffer(string propertyName, ComputeBuffer buffer);

		/// <summary>
		///   <para>Checks if material's shader has a property of a given name.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000821 RID: 2081 RVA: 0x000053C9 File Offset: 0x000035C9
		public bool HasProperty(string propertyName)
		{
			return this.HasProperty(Shader.PropertyToID(propertyName));
		}

		/// <summary>
		///   <para>Checks if material's shader has a property of a given name.</para>
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="nameID"></param>
		// Token: 0x06000822 RID: 2082
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool HasProperty(int nameID);

		/// <summary>
		///   <para>Get the value of material's shader tag.</para>
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="searchFallbacks"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000823 RID: 2083
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern string GetTag(string tag, bool searchFallbacks, [DefaultValue("\"\"")] string defaultValue);

		/// <summary>
		///   <para>Get the value of material's shader tag.</para>
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="searchFallbacks"></param>
		/// <param name="defaultValue"></param>
		// Token: 0x06000824 RID: 2084 RVA: 0x000147EC File Offset: 0x000129EC
		[ExcludeFromDocs]
		public string GetTag(string tag, bool searchFallbacks)
		{
			string empty = string.Empty;
			return this.GetTag(tag, searchFallbacks, empty);
		}

		/// <summary>
		///   <para>Sets an override tag/value on the material.</para>
		/// </summary>
		/// <param name="tag">Name of the tag to set.</param>
		/// <param name="val">Name of the value to set. Empty string to clear the override flag.</param>
		// Token: 0x06000825 RID: 2085
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetOverrideTag(string tag, string val);

		/// <summary>
		///   <para>Interpolate properties between two materials.</para>
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <param name="t"></param>
		// Token: 0x06000826 RID: 2086
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Lerp(Material start, Material end, float t);

		/// <summary>
		///   <para>How many passes are in this material (Read Only).</para>
		/// </summary>
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000827 RID: 2087
		public extern int passCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Activate the given pass for rendering.</para>
		/// </summary>
		/// <param name="pass">Shader pass number to setup.</param>
		/// <returns>
		///   <para>If false is returned, no rendering should be done.</para>
		/// </returns>
		// Token: 0x06000828 RID: 2088
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetPass(int pass);

		/// <summary>
		///   <para>Render queue of this material.</para>
		/// </summary>
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000829 RID: 2089
		// (set) Token: 0x0600082A RID: 2090
		public extern int renderQueue
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000053D7 File Offset: 0x000035D7
		[Obsolete("Creating materials from shader source string will be removed in the future. Use Shader assets instead.")]
		public static Material Create(string scriptContents)
		{
			return new Material(scriptContents);
		}

		// Token: 0x0600082C RID: 2092
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWithString([Writable] Material mono, string contents);

		// Token: 0x0600082D RID: 2093
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWithShader([Writable] Material mono, Shader shader);

		// Token: 0x0600082E RID: 2094
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateWithMaterial([Writable] Material mono, Material source);

		/// <summary>
		///   <para>Copy properties from other material into this material.</para>
		/// </summary>
		/// <param name="mat"></param>
		// Token: 0x0600082F RID: 2095
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CopyPropertiesFromMaterial(Material mat);

		/// <summary>
		///   <para>Set a shader keyword that is enabled by this material.</para>
		/// </summary>
		/// <param name="keyword"></param>
		// Token: 0x06000830 RID: 2096
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void EnableKeyword(string keyword);

		/// <summary>
		///   <para>Unset a shader keyword.</para>
		/// </summary>
		/// <param name="keyword"></param>
		// Token: 0x06000831 RID: 2097
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DisableKeyword(string keyword);

		/// <summary>
		///   <para>Is the shader keyword enabled on this material?</para>
		/// </summary>
		/// <param name="keyword"></param>
		// Token: 0x06000832 RID: 2098
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsKeywordEnabled(string keyword);

		/// <summary>
		///   <para>Additional shader keywords set by this material.</para>
		/// </summary>
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000833 RID: 2099
		// (set) Token: 0x06000834 RID: 2100
		public extern string[] shaderKeywords
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Defines how the material should interact with lightmaps and lightprobes.</para>
		/// </summary>
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000835 RID: 2101
		// (set) Token: 0x06000836 RID: 2102
		public extern MaterialGlobalIlluminationFlags globalIlluminationFlags
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}
	}
}
