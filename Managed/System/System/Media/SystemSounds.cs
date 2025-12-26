using System;

namespace System.Media
{
	/// <summary>Retrieves sounds associated with a set of Windows operating system sound-event types. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x020002C3 RID: 707
	public sealed class SystemSounds
	{
		// Token: 0x06001853 RID: 6227 RVA: 0x000021C3 File Offset: 0x000003C3
		private SystemSounds()
		{
		}

		/// <summary>Gets the sound associated with the Asterisk program event in the current Windows sound scheme.</summary>
		/// <returns>A <see cref="T:System.Media.SystemSound" />.</returns>
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00012080 File Offset: 0x00010280
		public static SystemSound Asterisk
		{
			get
			{
				return new SystemSound("Asterisk");
			}
		}

		/// <summary>Gets the sound associated with the Beep program event in the current Windows sound scheme.</summary>
		/// <returns>A <see cref="T:System.Media.SystemSound" />.</returns>
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0001208C File Offset: 0x0001028C
		public static SystemSound Beep
		{
			get
			{
				return new SystemSound("Beep");
			}
		}

		/// <summary>Gets the sound associated with the Exclamation program event in the current Windows sound scheme.</summary>
		/// <returns>A <see cref="T:System.Media.SystemSound" />.</returns>
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00012098 File Offset: 0x00010298
		public static SystemSound Exclamation
		{
			get
			{
				return new SystemSound("Exclamation");
			}
		}

		/// <summary>Gets the sound associated with the Hand program event in the current Windows sound scheme.</summary>
		/// <returns>A <see cref="T:System.Media.SystemSound" />.</returns>
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x000120A4 File Offset: 0x000102A4
		public static SystemSound Hand
		{
			get
			{
				return new SystemSound("Hand");
			}
		}

		/// <summary>Gets the sound associated with the Question program event in the current Windows sound scheme.</summary>
		/// <returns>A <see cref="T:System.Media.SystemSound" />.</returns>
		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x000120B0 File Offset: 0x000102B0
		public static SystemSound Question
		{
			get
			{
				return new SystemSound("Question");
			}
		}
	}
}
