using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the name of the category in which to group the property or event when displayed in a <see cref="T:System.Windows.Forms.PropertyGrid" /> control set to Categorized mode.</summary>
	// Token: 0x020000DB RID: 219
	[AttributeUsage(AttributeTargets.All)]
	public class CategoryAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CategoryAttribute" /> class using the category name Default.</summary>
		// Token: 0x06000953 RID: 2387 RVA: 0x00008CFE File Offset: 0x00006EFE
		public CategoryAttribute()
		{
			this.category = "Misc";
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CategoryAttribute" /> class using the specified category name.</summary>
		/// <param name="category">The name of the category. </param>
		// Token: 0x06000954 RID: 2388 RVA: 0x00008D11 File Offset: 0x00006F11
		public CategoryAttribute(string category)
		{
			this.category = category;
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Action category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the action category.</returns>
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002EFE4 File Offset: 0x0002D1E4
		public static CategoryAttribute Action
		{
			get
			{
				if (CategoryAttribute.action != null)
				{
					return CategoryAttribute.action;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.action == null)
					{
						CategoryAttribute.action = new CategoryAttribute("Action");
					}
				}
				return CategoryAttribute.action;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Appearance category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the appearance category.</returns>
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0002F054 File Offset: 0x0002D254
		public static CategoryAttribute Appearance
		{
			get
			{
				if (CategoryAttribute.appearance != null)
				{
					return CategoryAttribute.appearance;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.appearance == null)
					{
						CategoryAttribute.appearance = new CategoryAttribute("Appearance");
					}
				}
				return CategoryAttribute.appearance;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Asynchronous category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the asynchronous category.</returns>
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0002F0C4 File Offset: 0x0002D2C4
		public static CategoryAttribute Asynchronous
		{
			get
			{
				if (CategoryAttribute.behaviour != null)
				{
					return CategoryAttribute.behaviour;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.async == null)
					{
						CategoryAttribute.async = new CategoryAttribute("Asynchronous");
					}
				}
				return CategoryAttribute.async;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Behavior category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the behavior category.</returns>
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0002F134 File Offset: 0x0002D334
		public static CategoryAttribute Behavior
		{
			get
			{
				if (CategoryAttribute.behaviour != null)
				{
					return CategoryAttribute.behaviour;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.behaviour == null)
					{
						CategoryAttribute.behaviour = new CategoryAttribute("Behavior");
					}
				}
				return CategoryAttribute.behaviour;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Data category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the data category.</returns>
		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0002F1A4 File Offset: 0x0002D3A4
		public static CategoryAttribute Data
		{
			get
			{
				if (CategoryAttribute.data != null)
				{
					return CategoryAttribute.data;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.data == null)
					{
						CategoryAttribute.data = new CategoryAttribute("Data");
					}
				}
				return CategoryAttribute.data;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Default category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the default category.</returns>
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002F214 File Offset: 0x0002D414
		public static CategoryAttribute Default
		{
			get
			{
				if (CategoryAttribute.def != null)
				{
					return CategoryAttribute.def;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.def == null)
					{
						CategoryAttribute.def = new CategoryAttribute();
					}
				}
				return CategoryAttribute.def;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Design category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the design category.</returns>
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0002F27C File Offset: 0x0002D47C
		public static CategoryAttribute Design
		{
			get
			{
				if (CategoryAttribute.design != null)
				{
					return CategoryAttribute.design;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.design == null)
					{
						CategoryAttribute.design = new CategoryAttribute("Design");
					}
				}
				return CategoryAttribute.design;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the DragDrop category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the drag-and-drop category.</returns>
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		public static CategoryAttribute DragDrop
		{
			get
			{
				if (CategoryAttribute.drag_drop != null)
				{
					return CategoryAttribute.drag_drop;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.drag_drop == null)
					{
						CategoryAttribute.drag_drop = new CategoryAttribute("Drag Drop");
					}
				}
				return CategoryAttribute.drag_drop;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Focus category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the focus category.</returns>
		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x0002F35C File Offset: 0x0002D55C
		public static CategoryAttribute Focus
		{
			get
			{
				if (CategoryAttribute.focus != null)
				{
					return CategoryAttribute.focus;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.focus == null)
					{
						CategoryAttribute.focus = new CategoryAttribute("Focus");
					}
				}
				return CategoryAttribute.focus;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Format category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the format category.</returns>
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0002F3CC File Offset: 0x0002D5CC
		public static CategoryAttribute Format
		{
			get
			{
				if (CategoryAttribute.format != null)
				{
					return CategoryAttribute.format;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.format == null)
					{
						CategoryAttribute.format = new CategoryAttribute("Format");
					}
				}
				return CategoryAttribute.format;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Key category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the key category.</returns>
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x0002F43C File Offset: 0x0002D63C
		public static CategoryAttribute Key
		{
			get
			{
				if (CategoryAttribute.key != null)
				{
					return CategoryAttribute.key;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.key == null)
					{
						CategoryAttribute.key = new CategoryAttribute("Key");
					}
				}
				return CategoryAttribute.key;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Layout category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the layout category.</returns>
		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0002F4AC File Offset: 0x0002D6AC
		public static CategoryAttribute Layout
		{
			get
			{
				if (CategoryAttribute.layout != null)
				{
					return CategoryAttribute.layout;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.layout == null)
					{
						CategoryAttribute.layout = new CategoryAttribute("Layout");
					}
				}
				return CategoryAttribute.layout;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the Mouse category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the mouse category.</returns>
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x0002F51C File Offset: 0x0002D71C
		public static CategoryAttribute Mouse
		{
			get
			{
				if (CategoryAttribute.mouse != null)
				{
					return CategoryAttribute.mouse;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.mouse == null)
					{
						CategoryAttribute.mouse = new CategoryAttribute("Mouse");
					}
				}
				return CategoryAttribute.mouse;
			}
		}

		/// <summary>Gets a <see cref="T:System.ComponentModel.CategoryAttribute" /> representing the WindowStyle category.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.CategoryAttribute" /> for the window style category.</returns>
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0002F58C File Offset: 0x0002D78C
		public static CategoryAttribute WindowStyle
		{
			get
			{
				if (CategoryAttribute.window_style != null)
				{
					return CategoryAttribute.window_style;
				}
				object obj = CategoryAttribute.lockobj;
				lock (obj)
				{
					if (CategoryAttribute.window_style == null)
					{
						CategoryAttribute.window_style = new CategoryAttribute("Window Style");
					}
				}
				return CategoryAttribute.window_style;
			}
		}

		/// <summary>Looks up the localized name of the specified category.</summary>
		/// <returns>The localized name of the category, or null if a localized name does not exist.</returns>
		/// <param name="value">The identifer for the category to look up. </param>
		// Token: 0x06000964 RID: 2404 RVA: 0x00008D2C File Offset: 0x00006F2C
		protected virtual string GetLocalizedString(string value)
		{
			return global::Locale.GetText(value);
		}

		/// <summary>Gets the name of the category for the property or event that this attribute is applied to.</summary>
		/// <returns>The name of the category for the property or event that this attribute is applied to.</returns>
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		public string Category
		{
			get
			{
				if (!this.IsLocalized)
				{
					this.IsLocalized = true;
					string localizedString = this.GetLocalizedString(this.category);
					if (localizedString != null)
					{
						this.category = localizedString;
					}
				}
				return this.category;
			}
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.CategoryAttribute" />..</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		// Token: 0x06000966 RID: 2406 RVA: 0x00008D34 File Offset: 0x00006F34
		public override bool Equals(object obj)
		{
			return obj is CategoryAttribute && (obj == this || ((CategoryAttribute)obj).Category == this.category);
		}

		/// <summary>Returns the hash code for this attribute.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06000967 RID: 2407 RVA: 0x00008D62 File Offset: 0x00006F62
		public override int GetHashCode()
		{
			return this.category.GetHashCode();
		}

		/// <summary>Determines if this attribute is the default.</summary>
		/// <returns>true if the attribute is the default value for this attribute class; otherwise, false.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x06000968 RID: 2408 RVA: 0x00008D6F File Offset: 0x00006F6F
		public override bool IsDefaultAttribute()
		{
			return this.category == CategoryAttribute.Default.Category;
		}

		// Token: 0x0400027A RID: 634
		private string category;

		// Token: 0x0400027B RID: 635
		private bool IsLocalized;

		// Token: 0x0400027C RID: 636
		private static volatile CategoryAttribute action;

		// Token: 0x0400027D RID: 637
		private static volatile CategoryAttribute appearance;

		// Token: 0x0400027E RID: 638
		private static volatile CategoryAttribute behaviour;

		// Token: 0x0400027F RID: 639
		private static volatile CategoryAttribute data;

		// Token: 0x04000280 RID: 640
		private static volatile CategoryAttribute def;

		// Token: 0x04000281 RID: 641
		private static volatile CategoryAttribute design;

		// Token: 0x04000282 RID: 642
		private static volatile CategoryAttribute drag_drop;

		// Token: 0x04000283 RID: 643
		private static volatile CategoryAttribute focus;

		// Token: 0x04000284 RID: 644
		private static volatile CategoryAttribute format;

		// Token: 0x04000285 RID: 645
		private static volatile CategoryAttribute key;

		// Token: 0x04000286 RID: 646
		private static volatile CategoryAttribute layout;

		// Token: 0x04000287 RID: 647
		private static volatile CategoryAttribute mouse;

		// Token: 0x04000288 RID: 648
		private static volatile CategoryAttribute window_style;

		// Token: 0x04000289 RID: 649
		private static volatile CategoryAttribute async;

		// Token: 0x0400028A RID: 650
		private static object lockobj = new object();
	}
}
