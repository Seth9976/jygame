using System;
using System.ComponentModel.Design;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Provides properties and methods to add a license to a component and to manage a <see cref="T:System.ComponentModel.LicenseProvider" />. This class cannot be inherited.</summary>
	// Token: 0x0200017B RID: 379
	public sealed class LicenseManager
	{
		// Token: 0x06000D0A RID: 3338 RVA: 0x000021C3 File Offset: 0x000003C3
		private LicenseManager()
		{
		}

		/// <summary>Gets or sets the current <see cref="T:System.ComponentModel.LicenseContext" />, which specifies when you can use the licensed object.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.LicenseContext" /> that specifies when you can use the licensed object.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.ComponentModel.LicenseManager.CurrentContext" /> property is currently locked and cannot be changed.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00032160 File Offset: 0x00030360
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x000321B8 File Offset: 0x000303B8
		public static LicenseContext CurrentContext
		{
			get
			{
				object obj = LicenseManager.lockObject;
				LicenseContext licenseContext;
				lock (obj)
				{
					if (LicenseManager.mycontext == null)
					{
						LicenseManager.mycontext = new global::System.ComponentModel.Design.RuntimeLicenseContext();
					}
					licenseContext = LicenseManager.mycontext;
				}
				return licenseContext;
			}
			set
			{
				object obj = LicenseManager.lockObject;
				lock (obj)
				{
					if (LicenseManager.contextLockUser != null)
					{
						throw new InvalidOperationException("The CurrentContext property of the LicenseManager is currently locked and cannot be changed.");
					}
					LicenseManager.mycontext = value;
				}
			}
		}

		/// <summary>Gets the <see cref="T:System.ComponentModel.LicenseUsageMode" /> which specifies when you can use the licensed object for the <see cref="P:System.ComponentModel.LicenseManager.CurrentContext" />.</summary>
		/// <returns>One of the <see cref="T:System.ComponentModel.LicenseUsageMode" /> values, as specified in the <see cref="P:System.ComponentModel.LicenseManager.CurrentContext" /> property.</returns>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0000ADF2 File Offset: 0x00008FF2
		public static LicenseUsageMode UsageMode
		{
			get
			{
				return LicenseManager.CurrentContext.UsageMode;
			}
		}

		/// <summary>Creates an instance of the specified type, given a context in which you can use the licensed instance.</summary>
		/// <returns>An instance of the specified type.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		/// <param name="creationContext">A <see cref="T:System.ComponentModel.LicenseContext" /> that specifies when you can use the licensed instance. </param>
		// Token: 0x06000D0F RID: 3343 RVA: 0x0000ADFE File Offset: 0x00008FFE
		public static object CreateWithContext(Type type, LicenseContext creationContext)
		{
			return LicenseManager.CreateWithContext(type, creationContext, new object[0]);
		}

		/// <summary>Creates an instance of the specified type with the specified arguments, given a context in which you can use the licensed instance.</summary>
		/// <returns>An instance of the specified type with the given array of arguments.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type to create. </param>
		/// <param name="creationContext">A <see cref="T:System.ComponentModel.LicenseContext" /> that specifies when you can use the licensed instance. </param>
		/// <param name="args">An array of type <see cref="T:System.Object" /> that represents the arguments for the type. </param>
		// Token: 0x06000D10 RID: 3344 RVA: 0x00032210 File Offset: 0x00030410
		public static object CreateWithContext(Type type, LicenseContext creationContext, object[] args)
		{
			object obj = null;
			object obj2 = LicenseManager.lockObject;
			lock (obj2)
			{
				object obj3 = new object();
				LicenseContext currentContext = LicenseManager.CurrentContext;
				LicenseManager.CurrentContext = creationContext;
				LicenseManager.LockContext(obj3);
				try
				{
					obj = Activator.CreateInstance(type, args);
				}
				catch (TargetInvocationException ex)
				{
					throw ex.InnerException;
				}
				finally
				{
					LicenseManager.UnlockContext(obj3);
					LicenseManager.CurrentContext = currentContext;
				}
			}
			return obj;
		}

		/// <summary>Returns whether the given type has a valid license.</summary>
		/// <returns>true if the given type is licensed; otherwise, false.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> to find a valid license for. </param>
		// Token: 0x06000D11 RID: 3345 RVA: 0x000322A4 File Offset: 0x000304A4
		public static bool IsLicensed(Type type)
		{
			License license = null;
			if (!LicenseManager.privateGetLicense(type, null, false, out license))
			{
				return false;
			}
			if (license != null)
			{
				license.Dispose();
			}
			return true;
		}

		/// <summary>Determines whether a valid license can be granted for the specified type.</summary>
		/// <returns>true if a valid license can be granted; otherwise, false.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the <see cref="T:System.ComponentModel.License" />. </param>
		// Token: 0x06000D12 RID: 3346 RVA: 0x000322A4 File Offset: 0x000304A4
		public static bool IsValid(Type type)
		{
			License license = null;
			if (!LicenseManager.privateGetLicense(type, null, false, out license))
			{
				return false;
			}
			if (license != null)
			{
				license.Dispose();
			}
			return true;
		}

		/// <summary>Determines whether a valid license can be granted for the specified instance of the type. This method creates a valid <see cref="T:System.ComponentModel.License" />.</summary>
		/// <returns>true if a valid <see cref="T:System.ComponentModel.License" /> can be granted; otherwise, false.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the license. </param>
		/// <param name="instance">An object of the specified type or a type derived from the specified type. </param>
		/// <param name="license">A <see cref="T:System.ComponentModel.License" /> that is a valid license, or null if a valid license cannot be granted. </param>
		// Token: 0x06000D13 RID: 3347 RVA: 0x0000AE0D File Offset: 0x0000900D
		public static bool IsValid(Type type, object instance, out License license)
		{
			return LicenseManager.privateGetLicense(type, null, false, out license);
		}

		/// <summary>Prevents changes being made to the current <see cref="T:System.ComponentModel.LicenseContext" /> of the given object.</summary>
		/// <param name="contextUser">The object whose current context you want to lock. </param>
		/// <exception cref="T:System.InvalidOperationException">The context is already locked.</exception>
		// Token: 0x06000D14 RID: 3348 RVA: 0x000322D4 File Offset: 0x000304D4
		public static void LockContext(object contextUser)
		{
			object obj = LicenseManager.lockObject;
			lock (obj)
			{
				LicenseManager.contextLockUser = contextUser;
			}
		}

		/// <summary>Allows changes to be made to the current <see cref="T:System.ComponentModel.LicenseContext" /> of the given object.</summary>
		/// <param name="contextUser">The object whose current context you want to unlock. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="contextUser" /> represents a different user than the one specified in a previous call to <see cref="M:System.ComponentModel.LicenseManager.LockContext(System.Object)" />. </exception>
		// Token: 0x06000D15 RID: 3349 RVA: 0x00032310 File Offset: 0x00030510
		public static void UnlockContext(object contextUser)
		{
			object obj = LicenseManager.lockObject;
			lock (obj)
			{
				if (LicenseManager.contextLockUser != null)
				{
					if (LicenseManager.contextLockUser != contextUser)
					{
						throw new ArgumentException("The CurrentContext property of the LicenseManager can only be unlocked with the same contextUser.");
					}
					LicenseManager.contextLockUser = null;
				}
			}
		}

		/// <summary>Determines whether a license can be granted for the specified type.</summary>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the license. </param>
		/// <exception cref="T:System.ComponentModel.LicenseException">A <see cref="T:System.ComponentModel.License" /> cannot be granted. </exception>
		// Token: 0x06000D16 RID: 3350 RVA: 0x00032370 File Offset: 0x00030570
		public static void Validate(Type type)
		{
			License license = null;
			if (!LicenseManager.privateGetLicense(type, null, true, out license))
			{
				throw new LicenseException(type, null);
			}
			if (license != null)
			{
				license.Dispose();
			}
		}

		/// <summary>Determines whether a license can be granted for the instance of the specified type.</summary>
		/// <returns>A valid <see cref="T:System.ComponentModel.License" />.</returns>
		/// <param name="type">A <see cref="T:System.Type" /> that represents the type of object that requests the license. </param>
		/// <param name="instance">An <see cref="T:System.Object" /> of the specified type or a type derived from the specified type. </param>
		/// <exception cref="T:System.ComponentModel.LicenseException">The type is licensed, but a <see cref="T:System.ComponentModel.License" /> cannot be granted. </exception>
		// Token: 0x06000D17 RID: 3351 RVA: 0x000323A4 File Offset: 0x000305A4
		public static License Validate(Type type, object instance)
		{
			License license = null;
			if (!LicenseManager.privateGetLicense(type, instance, true, out license))
			{
				throw new LicenseException(type, instance);
			}
			return license;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000323CC File Offset: 0x000305CC
		private static bool privateGetLicense(Type type, object instance, bool allowExceptions, out License license)
		{
			bool flag = false;
			License license2 = null;
			LicenseProviderAttribute licenseProviderAttribute = (LicenseProviderAttribute)Attribute.GetCustomAttribute(type, typeof(LicenseProviderAttribute), true);
			if (licenseProviderAttribute != null)
			{
				Type licenseProvider = licenseProviderAttribute.LicenseProvider;
				if (licenseProvider != null)
				{
					LicenseProvider licenseProvider2 = (LicenseProvider)Activator.CreateInstance(licenseProvider);
					if (licenseProvider2 != null)
					{
						license2 = licenseProvider2.GetLicense(LicenseManager.CurrentContext, type, instance, allowExceptions);
						if (license2 != null)
						{
							flag = true;
						}
					}
				}
			}
			else
			{
				flag = true;
			}
			license = license2;
			return flag;
		}

		// Token: 0x04000395 RID: 917
		private static LicenseContext mycontext;

		// Token: 0x04000396 RID: 918
		private static object contextLockUser;

		// Token: 0x04000397 RID: 919
		private static object lockObject = new object();
	}
}
