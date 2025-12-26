using System;

namespace System.ComponentModel
{
	/// <summary>Provides metadata for a property representing a data field. This class cannot be inherited.</summary>
	// Token: 0x020000ED RID: 237
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DataObjectFieldAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> class and indicates whether the field is the primary key for the data row.</summary>
		/// <param name="primaryKey">true to indicate that the field is in the primary key of the data row; otherwise, false.</param>
		// Token: 0x060009CE RID: 2510 RVA: 0x000092D3 File Offset: 0x000074D3
		public DataObjectFieldAttribute(bool primaryKey)
		{
			this.primary_key = primaryKey;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> class and indicates whether the field is the primary key for the data row, and whether the field is a database identity field.</summary>
		/// <param name="primaryKey">true to indicate that the field is in the primary key of the data row; otherwise, false.</param>
		/// <param name="isIdentity">true to indicate that the field is an identity field that uniquely identifies the data row; otherwise, false.</param>
		// Token: 0x060009CF RID: 2511 RVA: 0x000092E9 File Offset: 0x000074E9
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
		{
			this.primary_key = primaryKey;
			this.is_identity = isIdentity;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> class and indicates whether the field is the primary key for the data row, whether the field is a database identity field, and whether the field can be null.</summary>
		/// <param name="primaryKey">true to indicate that the field is in the primary key of the data row; otherwise, false.</param>
		/// <param name="isIdentity">true to indicate that the field is an identity field that uniquely identifies the data row; otherwise, false.</param>
		/// <param name="isNullable">true to indicate that the field can be null in the data store; otherwise, false.</param>
		// Token: 0x060009D0 RID: 2512 RVA: 0x00009306 File Offset: 0x00007506
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
		{
			this.primary_key = primaryKey;
			this.is_identity = isIdentity;
			this.is_nullable = isNullable;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DataObjectFieldAttribute" /> class and indicates whether the field is the primary key for the data row, whether it is a database identity field, and whether it can be null and sets the length of the field.</summary>
		/// <param name="primaryKey">true to indicate that the field is in the primary key of the data row; otherwise, false.</param>
		/// <param name="isIdentity">true to indicate that the field is an identity field that uniquely identifies the data row; otherwise, false.</param>
		/// <param name="isNullable">true to indicate that the field can be null in the data store; otherwise, false.</param>
		/// <param name="length">The length of the field in bytes.</param>
		// Token: 0x060009D1 RID: 2513 RVA: 0x0000932A File Offset: 0x0000752A
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
		{
			this.primary_key = primaryKey;
			this.is_identity = isIdentity;
			this.is_nullable = isNullable;
			this.length = length;
		}

		/// <summary>Gets a value indicating whether a property represents an identity field in the underlying data.</summary>
		/// <returns>true if the property represents an identity field in the underlying data; otherwise, false. The default value is false.</returns>
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00009356 File Offset: 0x00007556
		public bool IsIdentity
		{
			get
			{
				return this.is_identity;
			}
		}

		/// <summary>Gets a value indicating whether a property represents a field that can be null in the underlying data store.</summary>
		/// <returns>true if the property represents a field that can be null in the underlying data store; otherwise, false.</returns>
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0000935E File Offset: 0x0000755E
		public bool IsNullable
		{
			get
			{
				return this.is_nullable;
			}
		}

		/// <summary>Gets the length of the property in bytes.</summary>
		/// <returns>The length of the property in bytes, or -1 if not set.</returns>
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00009366 File Offset: 0x00007566
		public int Length
		{
			get
			{
				return this.length;
			}
		}

		/// <summary>Gets a value indicating whether a property is in the primary key in the underlying data.</summary>
		/// <returns>true if the property is in the primary key of the data store; otherwise, false.</returns>
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0000936E File Offset: 0x0000756E
		public bool PrimaryKey
		{
			get
			{
				return this.primary_key;
			}
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if this instance is the same as the instance specified by the <paramref name="obj" /> parameter; otherwise, false.</returns>
		/// <param name="obj">An object to compare with this instance of <see cref="T:System.ComponentModel.DataObjectFieldAttribute" />.</param>
		// Token: 0x060009D6 RID: 2518 RVA: 0x0002FE68 File Offset: 0x0002E068
		public override bool Equals(object obj)
		{
			DataObjectFieldAttribute dataObjectFieldAttribute = obj as DataObjectFieldAttribute;
			return dataObjectFieldAttribute != null && (dataObjectFieldAttribute.primary_key == this.primary_key && dataObjectFieldAttribute.is_identity == this.is_identity && dataObjectFieldAttribute.is_nullable == this.is_nullable) && dataObjectFieldAttribute.length == this.length;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		// Token: 0x060009D7 RID: 2519 RVA: 0x0002FEC8 File Offset: 0x0002E0C8
		public override int GetHashCode()
		{
			return (((!this.primary_key) ? 0 : 1) | ((!this.is_identity) ? 0 : 2) | ((!this.is_nullable) ? 0 : 4)) ^ this.length;
		}

		// Token: 0x040002A1 RID: 673
		private bool primary_key;

		// Token: 0x040002A2 RID: 674
		private bool is_identity;

		// Token: 0x040002A3 RID: 675
		private bool is_nullable;

		// Token: 0x040002A4 RID: 676
		private int length = -1;
	}
}
