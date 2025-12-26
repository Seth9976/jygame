using System;
using System.Diagnostics;

namespace UnityEngine.Assertions.Must
{
	/// <summary>
	///   <para>An extension class that serves as a wrapper for the Assert class.</para>
	/// </summary>
	// Token: 0x020002FB RID: 763
	[DebuggerStepThrough]
	public static class MustExtensions
	{
		/// <summary>
		///   <para>An extension method for Assertions.Assert.IsTrue.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="message"></param>
		// Token: 0x06002334 RID: 9012 RVA: 0x0000E9BF File Offset: 0x0000CBBF
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeTrue(this bool value)
		{
			Assert.IsTrue(value);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.IsTrue.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="message"></param>
		// Token: 0x06002335 RID: 9013 RVA: 0x0000E9C7 File Offset: 0x0000CBC7
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeTrue(this bool value, string message)
		{
			Assert.IsTrue(value, message);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.IsFalse.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="message"></param>
		// Token: 0x06002336 RID: 9014 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeFalse(this bool value)
		{
			Assert.IsFalse(value);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.IsFalse.</para>
		/// </summary>
		/// <param name="value"></param>
		/// <param name="message"></param>
		// Token: 0x06002337 RID: 9015 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeFalse(this bool value, string message)
		{
			Assert.IsFalse(value, message);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x06002338 RID: 9016 RVA: 0x0000E9E1 File Offset: 0x0000CBE1
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeApproximatelyEqual(this float actual, float expected)
		{
			Assert.AreApproximatelyEqual(actual, expected);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x06002339 RID: 9017 RVA: 0x0000E9EA File Offset: 0x0000CBEA
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeApproximatelyEqual(this float actual, float expected, string message)
		{
			Assert.AreApproximatelyEqual(actual, expected, message);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x0600233A RID: 9018 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeApproximatelyEqual(this float actual, float expected, float tolerance)
		{
			Assert.AreApproximatelyEqual(actual, expected, tolerance);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x0600233B RID: 9019 RVA: 0x0000E9FE File Offset: 0x0000CBFE
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeApproximatelyEqual(this float actual, float expected, float tolerance, string message)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreNotApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x0600233C RID: 9020 RVA: 0x0000EA09 File Offset: 0x0000CC09
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected)
		{
			Assert.AreNotApproximatelyEqual(expected, actual);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreNotApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x0600233D RID: 9021 RVA: 0x0000EA12 File Offset: 0x0000CC12
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, message);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreNotApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x0600233E RID: 9022 RVA: 0x0000EA1C File Offset: 0x0000CC1C
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
		}

		/// <summary>
		///   <para>An extension method for Assertions.Assert.AreNotApproximatelyEqual.</para>
		/// </summary>
		/// <param name="actual"></param>
		/// <param name="expected"></param>
		/// <param name="message"></param>
		/// <param name="tolerance"></param>
		// Token: 0x0600233F RID: 9023 RVA: 0x0000EA26 File Offset: 0x0000CC26
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeApproximatelyEqual(this float actual, float expected, float tolerance, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0000EA31 File Offset: 0x0000CC31
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeEqual<T>(this T actual, T expected)
		{
			Assert.AreEqual<T>(actual, expected);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0000EA3A File Offset: 0x0000CC3A
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeEqual<T>(this T actual, T expected, string message)
		{
			Assert.AreEqual<T>(expected, actual, message);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0000EA44 File Offset: 0x0000CC44
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeEqual<T>(this T actual, T expected)
		{
			Assert.AreNotEqual<T>(actual, expected);
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0000EA4D File Offset: 0x0000CC4D
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeEqual<T>(this T actual, T expected, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0000EA57 File Offset: 0x0000CC57
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeNull<T>(this T expected) where T : class
		{
			Assert.IsNull<T>(expected);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000EA5F File Offset: 0x0000CC5F
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustBeNull<T>(this T expected, string message) where T : class
		{
			Assert.IsNull<T>(expected, message);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0000EA68 File Offset: 0x0000CC68
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeNull<T>(this T expected) where T : class
		{
			Assert.IsNotNull<T>(expected);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0000EA70 File Offset: 0x0000CC70
		[Conditional("UNITY_ASSERTIONS")]
		public static void MustNotBeNull<T>(this T expected, string message) where T : class
		{
			Assert.IsNotNull<T>(expected, message);
		}
	}
}
