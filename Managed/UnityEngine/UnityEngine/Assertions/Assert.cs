using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Assertions.Comparers;

namespace UnityEngine.Assertions
{
	/// <summary>
	///   <para>The Assert class contains assertion methods for setting invariants in the code.</para>
	/// </summary>
	// Token: 0x020002F7 RID: 759
	[DebuggerStepThrough]
	public static class Assert
	{
		// Token: 0x0600230B RID: 8971 RVA: 0x0002E2B0 File Offset: 0x0002C4B0
		private static void Fail(string message, string userMessage)
		{
			if (Debugger.IsAttached)
			{
				throw new AssertionException(message, userMessage);
			}
			if (Assert.raiseExceptions)
			{
				throw new AssertionException(message, userMessage);
			}
			if (message == null)
			{
				message = "Assertion has failed\n";
			}
			if (userMessage != null)
			{
				message = userMessage + '\n' + message;
			}
			Debug.LogAssertion(message);
		}

		/// <summary>
		///   <para>Asserts that the condition is true.</para>
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="message"></param>
		// Token: 0x0600230C RID: 8972 RVA: 0x0000E732 File Offset: 0x0000C932
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition)
		{
			Assert.IsTrue(condition, null);
		}

		/// <summary>
		///   <para>Asserts that the condition is true.</para>
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="message"></param>
		// Token: 0x0600230D RID: 8973 RVA: 0x0000E73B File Offset: 0x0000C93B
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsTrue(bool condition, string message)
		{
			if (!condition)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(true), message);
			}
		}

		/// <summary>
		///   <para>Asserts that the condition is false.</para>
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="message"></param>
		// Token: 0x0600230E RID: 8974 RVA: 0x0000E74F File Offset: 0x0000C94F
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsFalse(bool condition)
		{
			Assert.IsFalse(condition, null);
		}

		/// <summary>
		///   <para>Asserts that the condition is false.</para>
		/// </summary>
		/// <param name="condition"></param>
		/// <param name="message"></param>
		// Token: 0x0600230F RID: 8975 RVA: 0x0000E758 File Offset: 0x0000C958
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsFalse(bool condition, string message)
		{
			if (condition)
			{
				Assert.Fail(AssertionMessageUtil.BooleanFailureMessage(false), message);
			}
		}

		/// <summary>
		///   <para>Asserts that the values are approximately equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002310 RID: 8976 RVA: 0x0000E76C File Offset: 0x0000C96C
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual)
		{
			Assert.AreEqual<float>(expected, actual, null, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		/// <summary>
		///   <para>Asserts that the values are approximately equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002311 RID: 8977 RVA: 0x0000E77B File Offset: 0x0000C97B
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		/// <summary>
		///   <para>Asserts that the values are approximately equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002312 RID: 8978 RVA: 0x0000E78A File Offset: 0x0000C98A
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, null);
		}

		/// <summary>
		///   <para>Asserts that the values are approximately equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002313 RID: 8979 RVA: 0x0000E795 File Offset: 0x0000C995
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreEqual<float>(expected, actual, message, new FloatComparer(tolerance));
		}

		/// <summary>
		///   <para>Asserts that the values are approximately not equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002314 RID: 8980 RVA: 0x0000E7A5 File Offset: 0x0000C9A5
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual)
		{
			Assert.AreNotEqual<float>(expected, actual, null, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		/// <summary>
		///   <para>Asserts that the values are approximately not equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002315 RID: 8981 RVA: 0x0000E7B4 File Offset: 0x0000C9B4
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, FloatComparer.s_ComparerWithDefaultTolerance);
		}

		/// <summary>
		///   <para>Asserts that the values are approximately not equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002316 RID: 8982 RVA: 0x0000E7C3 File Offset: 0x0000C9C3
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, null);
		}

		/// <summary>
		///   <para>Asserts that the values are approximately not equal. An absolute error check is used for approximate equality check (|a-b| &lt; tolerance). Default tolerance is 0.00001f.</para>
		/// </summary>
		/// <param name="tolerance">Tolerance of approximation.</param>
		/// <param name="expected"></param>
		/// <param name="actual"></param>
		/// <param name="message"></param>
		// Token: 0x06002317 RID: 8983 RVA: 0x0000E7CE File Offset: 0x0000C9CE
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotApproximatelyEqual(float expected, float actual, float tolerance, string message)
		{
			Assert.AreNotEqual<float>(expected, actual, message, new FloatComparer(tolerance));
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0000E7DE File Offset: 0x0000C9DE
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual)
		{
			Assert.AreEqual<T>(expected, actual, null);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual, string message)
		{
			Assert.AreEqual<T>(expected, actual, message, Assert.GetEqualityComparer<T>(null));
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			if (!comparer.Equals(actual, expected))
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, true), message);
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0000E81F File Offset: 0x0000CA1F
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual<T>(expected, actual, null);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0000E829 File Offset: 0x0000CA29
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message, Assert.GetEqualityComparer<T>(null));
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0000E839 File Offset: 0x0000CA39
		[Conditional("UNITY_ASSERTIONS")]
		public static void AreNotEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer)
		{
			if (comparer.Equals(actual, expected))
			{
				Assert.Fail(AssertionMessageUtil.GetEqualityMessage(actual, expected, false), message);
			}
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0002E30C File Offset: 0x0002C50C
		private static IEqualityComparer<T> GetEqualityComparer<T>(params object[] args)
		{
			Type typeFromHandle = typeof(T);
			object @default;
			Assert.m_ComparersCache.TryGetValue(typeFromHandle, out @default);
			if (@default != null)
			{
				return (IEqualityComparer<T>)@default;
			}
			@default = EqualityComparer<T>.Default;
			Assert.m_ComparersCache.Add(typeFromHandle, @default);
			return (IEqualityComparer<T>)@default;
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0000E860 File Offset: 0x0000CA60
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull<T>(T value) where T : class
		{
			Assert.IsNull<T>(value, null);
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0000E869 File Offset: 0x0000CA69
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNull<T>(T value, string message) where T : class
		{
			if (value != null)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, true), message);
			}
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0000E888 File Offset: 0x0000CA88
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull<T>(T value) where T : class
		{
			Assert.IsNotNull<T>(value, null);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x0000E891 File Offset: 0x0000CA91
		[Conditional("UNITY_ASSERTIONS")]
		public static void IsNotNull<T>(T value, string message) where T : class
		{
			if (value == null)
			{
				Assert.Fail(AssertionMessageUtil.NullFailureMessage(value, false), message);
			}
		}

		// Token: 0x04000BA3 RID: 2979
		internal const string UNITY_ASSERTIONS = "UNITY_ASSERTIONS";

		/// <summary>
		///   <para>Should an exception be thrown on a failure.</para>
		/// </summary>
		// Token: 0x04000BA4 RID: 2980
		public static bool raiseExceptions;

		// Token: 0x04000BA5 RID: 2981
		private static readonly Dictionary<Type, object> m_ComparersCache = new Dictionary<Type, object>();
	}
}
