using System;
using System.Text;

namespace System.Collections.Specialized
{
	/// <summary>Provides a simple structure that stores Boolean values and small integers in 32 bits of memory.</summary>
	// Token: 0x020000B0 RID: 176
	public struct BitVector32
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.BitVector32" /> structure containing the data represented in an existing <see cref="T:System.Collections.Specialized.BitVector32" /> structure.</summary>
		/// <param name="value">A <see cref="T:System.Collections.Specialized.BitVector32" /> structure that contains the data to copy. </param>
		// Token: 0x06000774 RID: 1908 RVA: 0x000073F3 File Offset: 0x000055F3
		public BitVector32(BitVector32 source)
		{
			this.bits = source.bits;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Specialized.BitVector32" /> structure containing the data represented in an integer.</summary>
		/// <param name="data">An integer representing the data of the new <see cref="T:System.Collections.Specialized.BitVector32" />. </param>
		// Token: 0x06000775 RID: 1909 RVA: 0x00007402 File Offset: 0x00005602
		public BitVector32(int init)
		{
			this.bits = init;
		}

		/// <summary>Gets the value of the <see cref="T:System.Collections.Specialized.BitVector32" /> as an integer.</summary>
		/// <returns>The value of the <see cref="T:System.Collections.Specialized.BitVector32" /> as an integer.</returns>
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x0000740B File Offset: 0x0000560B
		public int Data
		{
			get
			{
				return this.bits;
			}
		}

		/// <summary>Gets or sets the value stored in the specified <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
		/// <returns>The value stored in the specified <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
		/// <param name="section">A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> that contains the value to get or set. </param>
		// Token: 0x1700018E RID: 398
		public int this[BitVector32.Section section]
		{
			get
			{
				return (this.bits >> (int)section.Offset) & (int)section.Mask;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Section can't hold negative values");
				}
				if (value > (int)section.Mask)
				{
					throw new ArgumentException("Value too large to fit in section");
				}
				this.bits &= ~((int)section.Mask << (int)section.Offset);
				this.bits |= value << (int)section.Offset;
			}
		}

		/// <summary>Gets or sets the state of the bit flag indicated by the specified mask.</summary>
		/// <returns>true if the specified bit flag is on (1); otherwise, false.</returns>
		/// <param name="bit">A mask that indicates the bit to get or set. </param>
		// Token: 0x1700018F RID: 399
		public bool this[int mask]
		{
			get
			{
				return (this.bits & mask) == mask;
			}
			set
			{
				if (value)
				{
					this.bits |= mask;
				}
				else
				{
					this.bits &= ~mask;
				}
			}
		}

		/// <summary>Creates the first mask in a series of masks that can be used to retrieve individual bits in a <see cref="T:System.Collections.Specialized.BitVector32" /> that is set up as bit flags.</summary>
		/// <returns>A mask that isolates the first bit flag in the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		// Token: 0x0600077B RID: 1915 RVA: 0x000025B7 File Offset: 0x000007B7
		public static int CreateMask()
		{
			return 1;
		}

		/// <summary>Creates an additional mask following the specified mask in a series of masks that can be used to retrieve individual bits in a <see cref="T:System.Collections.Specialized.BitVector32" /> that is set up as bit flags.</summary>
		/// <returns>A mask that isolates the bit flag following the one that <paramref name="previous" /> points to in <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <param name="previous">The mask that indicates the previous bit flag. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="previous" /> indicates the last bit flag in the <see cref="T:System.Collections.Specialized.BitVector32" />. </exception>
		// Token: 0x0600077C RID: 1916 RVA: 0x00007465 File Offset: 0x00005665
		public static int CreateMask(int prev)
		{
			if (prev == 0)
			{
				return 1;
			}
			if (prev == -2147483648)
			{
				throw new InvalidOperationException("all bits set");
			}
			return prev << 1;
		}

		/// <summary>Creates the first <see cref="T:System.Collections.Specialized.BitVector32.Section" /> in a series of sections that contain small integers.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> that can hold a number from zero to <paramref name="maxValue" />.</returns>
		/// <param name="maxValue">A 16-bit signed integer that specifies the maximum value for the new <see cref="T:System.Collections.Specialized.BitVector32.Section" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="maxValue" /> is less than 1. </exception>
		// Token: 0x0600077D RID: 1917 RVA: 0x00007488 File Offset: 0x00005688
		public static BitVector32.Section CreateSection(short maxValue)
		{
			return BitVector32.CreateSection(maxValue, new BitVector32.Section(0, 0));
		}

		/// <summary>Creates a new <see cref="T:System.Collections.Specialized.BitVector32.Section" /> following the specified <see cref="T:System.Collections.Specialized.BitVector32.Section" /> in a series of sections that contain small integers.</summary>
		/// <returns>A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> that can hold a number from zero to <paramref name="maxValue" />.</returns>
		/// <param name="maxValue">A 16-bit signed integer that specifies the maximum value for the new <see cref="T:System.Collections.Specialized.BitVector32.Section" />. </param>
		/// <param name="previous">The previous <see cref="T:System.Collections.Specialized.BitVector32.Section" /> in the <see cref="T:System.Collections.Specialized.BitVector32" />. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="maxValue" /> is less than 1. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="previous" /> includes the final bit in the <see cref="T:System.Collections.Specialized.BitVector32" />.-or- <paramref name="maxValue" /> is greater than the highest value that can be represented by the number of bits after <paramref name="previous" />. </exception>
		// Token: 0x0600077E RID: 1918 RVA: 0x0002CF14 File Offset: 0x0002B114
		public static BitVector32.Section CreateSection(short maxValue, BitVector32.Section previous)
		{
			if (maxValue < 1)
			{
				throw new ArgumentException("maxValue");
			}
			int num = BitVector32.HighestSetBit((int)maxValue);
			int num2 = (1 << num) - 1;
			int num3 = (int)previous.Offset + BitVector32.HighestSetBit((int)previous.Mask);
			if (num3 + num > 32)
			{
				throw new ArgumentException("Sections cannot exceed 32 bits in total");
			}
			return new BitVector32.Section((short)num2, (short)num3);
		}

		/// <summary>Determines whether the specified object is equal to the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>true if the specified object is equal to the <see cref="T:System.Collections.Specialized.BitVector32" />; otherwise, false.</returns>
		/// <param name="o">The object to compare with the current <see cref="T:System.Collections.Specialized.BitVector32" />. </param>
		// Token: 0x0600077F RID: 1919 RVA: 0x0002CF78 File Offset: 0x0002B178
		public override bool Equals(object o)
		{
			return o is BitVector32 && this.bits == ((BitVector32)o).bits;
		}

		/// <summary>Serves as a hash function for the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A hash code for the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x06000780 RID: 1920 RVA: 0x00007497 File Offset: 0x00005697
		public override int GetHashCode()
		{
			return this.bits.GetHashCode();
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		// Token: 0x06000781 RID: 1921 RVA: 0x000074A4 File Offset: 0x000056A4
		public override string ToString()
		{
			return BitVector32.ToString(this);
		}

		/// <summary>Returns a string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <param name="value">The <see cref="T:System.Collections.Specialized.BitVector32" /> to represent. </param>
		// Token: 0x06000782 RID: 1922 RVA: 0x0002CFAC File Offset: 0x0002B1AC
		public static string ToString(BitVector32 value)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BitVector32{");
			for (long num = (long)((ulong)int.MinValue); num > 0L; num >>= 1)
			{
				stringBuilder.Append((((long)value.bits & num) != 0L) ? '1' : '0');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002D014 File Offset: 0x0002B214
		private static int HighestSetBit(int i)
		{
			int num = 0;
			while (i >> num != 0)
			{
				num++;
			}
			return num;
		}

		// Token: 0x04000212 RID: 530
		private int bits;

		/// <summary>Represents a section of the vector that can contain an integer number.</summary>
		// Token: 0x020000B1 RID: 177
		public struct Section
		{
			// Token: 0x06000784 RID: 1924 RVA: 0x000074B1 File Offset: 0x000056B1
			internal Section(short mask, short offset)
			{
				this.mask = mask;
				this.offset = offset;
			}

			/// <summary>Gets a mask that isolates this section within the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
			/// <returns>A mask that isolates this section within the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000785 RID: 1925 RVA: 0x000074C1 File Offset: 0x000056C1
			public short Mask
			{
				get
				{
					return this.mask;
				}
			}

			/// <summary>Gets the offset of this section from the start of the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
			/// <returns>The offset of this section from the start of the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000786 RID: 1926 RVA: 0x000074C9 File Offset: 0x000056C9
			public short Offset
			{
				get
				{
					return this.offset;
				}
			}

			/// <summary>Determines whether the specified <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object is the same as the current <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</summary>
			/// <returns>true if the <paramref name="obj" /> parameter is the same as the current <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object; otherwise false.</returns>
			/// <param name="obj">The <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object to compare with the current <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</param>
			// Token: 0x06000787 RID: 1927 RVA: 0x000074D1 File Offset: 0x000056D1
			public bool Equals(BitVector32.Section obj)
			{
				return this.mask == obj.mask && this.offset == obj.offset;
			}

			/// <summary>Determines whether the specified object is the same as the current <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</summary>
			/// <returns>true if the specified object is the same as the current <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object; otherwise, false.</returns>
			/// <param name="o">The object to compare with the current <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</param>
			// Token: 0x06000788 RID: 1928 RVA: 0x0002D038 File Offset: 0x0002B238
			public override bool Equals(object o)
			{
				if (!(o is BitVector32.Section))
				{
					return false;
				}
				BitVector32.Section section = (BitVector32.Section)o;
				return this.mask == section.mask && this.offset == section.offset;
			}

			/// <summary>Serves as a hash function for the current <see cref="T:System.Collections.Specialized.BitVector32.Section" />, suitable for hashing algorithms and data structures, such as a hash table.</summary>
			/// <returns>A hash code for the current <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
			// Token: 0x06000789 RID: 1929 RVA: 0x000074F7 File Offset: 0x000056F7
			public override int GetHashCode()
			{
				return (int)this.mask << (int)this.offset;
			}

			/// <summary>Returns a string that represents the current <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <returns>A string that represents the current <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
			// Token: 0x0600078A RID: 1930 RVA: 0x00007509 File Offset: 0x00005709
			public override string ToString()
			{
				return BitVector32.Section.ToString(this);
			}

			/// <summary>Returns a string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</summary>
			/// <returns>A string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32.Section" />.</returns>
			/// <param name="value">The <see cref="T:System.Collections.Specialized.BitVector32.Section" /> to represent.</param>
			// Token: 0x0600078B RID: 1931 RVA: 0x0002D080 File Offset: 0x0002B280
			public static string ToString(BitVector32.Section value)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Section{0x");
				stringBuilder.Append(Convert.ToString(value.Mask, 16));
				stringBuilder.Append(", 0x");
				stringBuilder.Append(Convert.ToString(value.Offset, 16));
				stringBuilder.Append("}");
				return stringBuilder.ToString();
			}

			/// <summary>Determines whether two specified <see cref="T:System.Collections.Specialized.BitVector32.Section" /> objects are equal.</summary>
			/// <returns>true if the <paramref name="a" /> and <paramref name="b" /> parameters represent the same <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object, otherwise, false.</returns>
			/// <param name="a">A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</param>
			/// <param name="b">A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</param>
			// Token: 0x0600078C RID: 1932 RVA: 0x00007516 File Offset: 0x00005716
			public static bool operator ==(BitVector32.Section v1, BitVector32.Section v2)
			{
				return v1.mask == v2.mask && v1.offset == v2.offset;
			}

			/// <summary>Determines whether two <see cref="T:System.Collections.Specialized.BitVector32.Section" /> objects have different values.</summary>
			/// <returns>true if the <paramref name="a" /> and <paramref name="b" /> parameters represent different <see cref="T:System.Collections.Specialized.BitVector32.Section" /> objects; otherwise, false.</returns>
			/// <param name="a">A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</param>
			/// <param name="b">A <see cref="T:System.Collections.Specialized.BitVector32.Section" /> object.</param>
			// Token: 0x0600078D RID: 1933 RVA: 0x0000753E File Offset: 0x0000573E
			public static bool operator !=(BitVector32.Section v1, BitVector32.Section v2)
			{
				return v1.mask != v2.mask || v1.offset != v2.offset;
			}

			// Token: 0x04000213 RID: 531
			private short mask;

			// Token: 0x04000214 RID: 532
			private short offset;
		}
	}
}
