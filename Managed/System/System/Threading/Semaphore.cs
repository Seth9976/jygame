using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Threading
{
	/// <summary>Limits the number of threads that can access a resource or pool of resources concurrently. </summary>
	/// <filterpriority>1</filterpriority>
	// Token: 0x020004C8 RID: 1224
	[ComVisible(false)]
	public sealed class Semaphore : WaitHandle
	{
		// Token: 0x06002B63 RID: 11107 RVA: 0x0001E2FA File Offset: 0x0001C4FA
		private Semaphore(IntPtr handle)
		{
			this.Handle = handle;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Semaphore" /> class, specifying the maximum number of concurrent entries and optionally reserving some entries.</summary>
		/// <param name="initialCount">The initial number of requests for the semaphore that can be granted concurrently.</param>
		/// <param name="maximumCount">The maximum number of requests for the semaphore that can be granted concurrently.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="initialCount" /> is greater than <paramref name="maximumCount" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maximumCount" /> is less than 1.-or-<paramref name="initialCount" /> is less than 0.</exception>
		// Token: 0x06002B64 RID: 11108 RVA: 0x0001E309 File Offset: 0x0001C509
		public Semaphore(int initialCount, int maximumCount)
			: this(initialCount, maximumCount, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Semaphore" /> class, specifying the maximum number of concurrent entries, optionally reserving some entries for the calling thread, and optionally specifying the name of a system semaphore object.</summary>
		/// <param name="initialCount">The initial number of requests for the semaphore that can be granted concurrently. </param>
		/// <param name="maximumCount">The maximum number of requests for the semaphore that can be granted concurrently.</param>
		/// <param name="name">The name of a named system semaphore object.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="initialCount" /> is greater than <paramref name="maximumCount" />.-or-<paramref name="name" /> is longer than 260 characters.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maximumCount" /> is less than 1.-or-<paramref name="initialCount" /> is less than 0.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The named semaphore exists and has access control security, and the user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named semaphore cannot be created, perhaps because a wait handle of a different type has the same name.</exception>
		// Token: 0x06002B65 RID: 11109 RVA: 0x0008BCB8 File Offset: 0x00089EB8
		public Semaphore(int initialCount, int maximumCount, string name)
		{
			if (initialCount < 0)
			{
				throw new ArgumentOutOfRangeException("initialCount", "< 0");
			}
			if (maximumCount < 1)
			{
				throw new ArgumentOutOfRangeException("maximumCount", "< 1");
			}
			if (initialCount > maximumCount)
			{
				throw new ArgumentException("initialCount > maximumCount");
			}
			bool flag;
			this.Handle = Semaphore.CreateSemaphore_internal(initialCount, maximumCount, name, out flag);
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Semaphore" /> class, specifying the maximum number of concurrent entries, optionally reserving some entries for the calling thread, optionally specifying the name of a system semaphore object, and specifying a variable that receives a value indicating whether a new system semaphore was created.</summary>
		/// <param name="initialCount">The initial number of requests for the semaphore that can be satisfied concurrently. </param>
		/// <param name="maximumCount">The maximum number of requests for the semaphore that can be satisfied concurrently.</param>
		/// <param name="name">The name of a named system semaphore object.</param>
		/// <param name="createdNew">When this method returns, contains true if a local semaphore was created (that is, if <paramref name="name" /> is null or an empty string) or if the specified named system semaphore was created; false if the specified named system semaphore already existed. This parameter is passed uninitialized.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="initialCount" /> is greater than <paramref name="maximumCount" />. -or-<paramref name="name" /> is longer than 260 characters.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maximumCount" /> is less than 1.-or-<paramref name="initialCount" /> is less than 0.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The named semaphore exists and has access control security, and the user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.FullControl" />.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named semaphore cannot be created, perhaps because a wait handle of a different type has the same name.</exception>
		// Token: 0x06002B66 RID: 11110 RVA: 0x0001E314 File Offset: 0x0001C514
		public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew)
			: this(initialCount, maximumCount, name, out createdNew, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Semaphore" /> class, specifying the maximum number of concurrent entries, optionally reserving some entries for the calling thread, optionally specifying the name of a system semaphore object, specifying a variable that receives a value indicating whether a new system semaphore was created, and specifying security access control for the system semaphore.</summary>
		/// <param name="initialCount">The initial number of requests for the semaphore that can be satisfied concurrently. </param>
		/// <param name="maximumCount">The maximum number of requests for the semaphore that can be satisfied concurrently.</param>
		/// <param name="name">The name of a named system semaphore object.</param>
		/// <param name="createdNew">When this method returns, contains true if a local semaphore was created (that is, if <paramref name="name" /> is null or an empty string) or if the specified named system semaphore was created; false if the specified named system semaphore already existed. This parameter is passed uninitialized.</param>
		/// <param name="semaphoreSecurity">A <see cref="T:System.Security.AccessControl.SemaphoreSecurity" />  object that represents the access control security to be applied to the named system semaphore.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="initialCount" /> is greater than <paramref name="maximumCount" />.-or-<paramref name="name" /> is longer than 260 characters.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="maximumCount" /> is less than 1.-or-<paramref name="initialCount" /> is less than 0.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The named semaphore exists and has access control security, and the user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.FullControl" />.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named semaphore cannot be created, perhaps because a wait handle of a different type has the same name.</exception>
		// Token: 0x06002B67 RID: 11111 RVA: 0x0008BD1C File Offset: 0x00089F1C
		[global::System.MonoTODO("Does not support access control, semaphoreSecurity is ignored")]
		public Semaphore(int initialCount, int maximumCount, string name, out bool createdNew, global::System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity)
		{
			if (initialCount < 0)
			{
				throw new ArgumentOutOfRangeException("initialCount", "< 0");
			}
			if (maximumCount < 1)
			{
				throw new ArgumentOutOfRangeException("maximumCount", "< 1");
			}
			if (initialCount > maximumCount)
			{
				throw new ArgumentException("initialCount > maximumCount");
			}
			this.Handle = Semaphore.CreateSemaphore_internal(initialCount, maximumCount, name, out createdNew);
		}

		// Token: 0x06002B68 RID: 11112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr CreateSemaphore_internal(int initialCount, int maximumCount, string name, out bool createdNew);

		// Token: 0x06002B69 RID: 11113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int ReleaseSemaphore_internal(IntPtr handle, int releaseCount, out bool fail);

		// Token: 0x06002B6A RID: 11114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr OpenSemaphore_internal(string name, global::System.Security.AccessControl.SemaphoreRights rights, out global::System.IO.MonoIOError error);

		/// <summary>Gets the access control security for a named system semaphore.</summary>
		/// <returns>A <see cref="T:System.Security.AccessControl.SemaphoreSecurity" /> object that represents the access control security for the named system semaphore.</returns>
		/// <exception cref="T:System.UnauthorizedAccessException">The current <see cref="T:System.Threading.Semaphore" /> object represents a named system semaphore, and the user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.ReadPermissions" /> rights.-or-The current <see cref="T:System.Threading.Semaphore" /> object represents a named system semaphore and was not opened with <see cref="F:System.Security.AccessControl.SemaphoreRights.ReadPermissions" /> rights.</exception>
		/// <exception cref="T:System.NotSupportedException">Not supported for Windows 98 or Windows Millennium Edition.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002B6B RID: 11115 RVA: 0x00002664 File Offset: 0x00000864
		[global::System.MonoTODO]
		public global::System.Security.AccessControl.SemaphoreSecurity GetAccessControl()
		{
			throw new NotImplementedException();
		}

		/// <summary>Exits the semaphore and returns the previous count.</summary>
		/// <returns>The count on the semaphore before the <see cref="Overload:System.Threading.Semaphore.Release" /> method was called. </returns>
		/// <exception cref="T:System.Threading.SemaphoreFullException">The semaphore count is already at the maximum value.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred with a named semaphore.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The current semaphore represents a named system semaphore, but the user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" />.-or-The current semaphore represents a named system semaphore, but it was not opened with <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" />.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002B6C RID: 11116 RVA: 0x0001E322 File Offset: 0x0001C522
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[PrePrepareMethod]
		public int Release()
		{
			return this.Release(1);
		}

		/// <summary>Exits the semaphore a specified number of times and returns the previous count.</summary>
		/// <returns>The count on the semaphore before the <see cref="Overload:System.Threading.Semaphore.Release" /> method was called. </returns>
		/// <param name="releaseCount">The number of times to exit the semaphore.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="releaseCount" /> is less than 1.</exception>
		/// <exception cref="T:System.Threading.SemaphoreFullException">The semaphore count is already at the maximum value.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred with a named semaphore.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The current semaphore represents a named system semaphore, but the user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" /> rights.-or-The current semaphore represents a named system semaphore, but it was not opened with <see cref="F:System.Security.AccessControl.SemaphoreRights.Modify" /> rights.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002B6D RID: 11117 RVA: 0x0008BD80 File Offset: 0x00089F80
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public int Release(int releaseCount)
		{
			if (releaseCount < 1)
			{
				throw new ArgumentOutOfRangeException("releaseCount");
			}
			bool flag;
			int num = Semaphore.ReleaseSemaphore_internal(this.Handle, releaseCount, out flag);
			if (flag)
			{
				throw new SemaphoreFullException();
			}
			return num;
		}

		/// <summary>Sets the access control security for a named system semaphore.</summary>
		/// <param name="semaphoreSecurity">A <see cref="T:System.Security.AccessControl.SemaphoreSecurity" />  object that represents the access control security to be applied to the named system semaphore.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="semaphoreSecurity" /> is null.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The user does not have <see cref="F:System.Security.AccessControl.SemaphoreRights.ChangePermissions" /> rights.-or-The semaphore was not opened with <see cref="F:System.Security.AccessControl.SemaphoreRights.ChangePermissions" /> rights.</exception>
		/// <exception cref="T:System.NotSupportedException">The current <see cref="T:System.Threading.Semaphore" /> object does not represent a named system semaphore.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002B6E RID: 11118 RVA: 0x0001E32B File Offset: 0x0001C52B
		[global::System.MonoTODO]
		public void SetAccessControl(global::System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity)
		{
			if (semaphoreSecurity == null)
			{
				throw new ArgumentNullException("semaphoreSecurity");
			}
			throw new NotImplementedException();
		}

		/// <summary>Opens an existing named semaphore.</summary>
		/// <returns>A <see cref="T:System.Threading.Semaphore" /> object that represents a named system semaphore.</returns>
		/// <param name="name">The name of a named system semaphore.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is an empty string.-or-<paramref name="name" /> is longer than 260 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named semaphore does not exist.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The named semaphore exists, but the user does not have the security access required to use it.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x06002B6F RID: 11119 RVA: 0x0001E343 File Offset: 0x0001C543
		public static Semaphore OpenExisting(string name)
		{
			return Semaphore.OpenExisting(name, global::System.Security.AccessControl.SemaphoreRights.Modify | global::System.Security.AccessControl.SemaphoreRights.Synchronize);
		}

		/// <summary>Opens an existing named semaphore, specifying the desired security access rights.</summary>
		/// <returns>A <see cref="T:System.Threading.Semaphore" /> object that represents the named system semaphore.</returns>
		/// <param name="name">The name of a system semaphore.</param>
		/// <param name="rights">A bitwise combination of the <see cref="T:System.Security.AccessControl.SemaphoreRights" />  values that represent the desired security access rights.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is an empty string.-or-<paramref name="name" /> is longer than 260 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null.</exception>
		/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named semaphore does not exist.</exception>
		/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
		/// <exception cref="T:System.UnauthorizedAccessException">The named semaphore exists, but the user does not have the desired security access rights.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06002B70 RID: 11120 RVA: 0x0008BDBC File Offset: 0x00089FBC
		public static Semaphore OpenExisting(string name, global::System.Security.AccessControl.SemaphoreRights rights)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0 || name.Length > 260)
			{
				throw new ArgumentException("name", global::Locale.GetText("Invalid length [1-260]."));
			}
			global::System.IO.MonoIOError monoIOError;
			IntPtr intPtr = Semaphore.OpenSemaphore_internal(name, rights, out monoIOError);
			if (!(intPtr == (IntPtr)null))
			{
				return new Semaphore(intPtr);
			}
			if (monoIOError == global::System.IO.MonoIOError.ERROR_FILE_NOT_FOUND)
			{
				throw new WaitHandleCannotBeOpenedException(global::Locale.GetText("Named Semaphore handle does not exist: ") + name);
			}
			if (monoIOError == global::System.IO.MonoIOError.ERROR_ACCESS_DENIED)
			{
				throw new UnauthorizedAccessException();
			}
			throw new IOException(global::Locale.GetText("Win32 IO error: ") + monoIOError.ToString());
		}
	}
}
