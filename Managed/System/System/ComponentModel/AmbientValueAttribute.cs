using System;

namespace System.ComponentModel
{
	/// <summary>Specifies the value to pass to a property to cause the property to get its value from another source. This is known as ambience. This class cannot be inherited.</summary>
	// Token: 0x020000C8 RID: 200
	[AttributeUsage(AttributeTargets.All)]
	public sealed class AmbientValueAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a Boolean value for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x06000898 RID: 2200 RVA: 0x0000826C File Offset: 0x0000646C
		public AmbientValueAttribute(bool value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given an 8-bit unsigned integer for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x06000899 RID: 2201 RVA: 0x00008280 File Offset: 0x00006480
		public AmbientValueAttribute(byte value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a Unicode character for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x0600089A RID: 2202 RVA: 0x00008294 File Offset: 0x00006494
		public AmbientValueAttribute(char value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a double-precision floating-point number for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x0600089B RID: 2203 RVA: 0x000082A8 File Offset: 0x000064A8
		public AmbientValueAttribute(double value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a 16-bit signed integer for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x0600089C RID: 2204 RVA: 0x000082BC File Offset: 0x000064BC
		public AmbientValueAttribute(short value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a 32-bit signed integer for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x0600089D RID: 2205 RVA: 0x000082D0 File Offset: 0x000064D0
		public AmbientValueAttribute(int value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a 64-bit signed integer for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x0600089E RID: 2206 RVA: 0x000082E4 File Offset: 0x000064E4
		public AmbientValueAttribute(long value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given an object for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x0600089F RID: 2207 RVA: 0x000082F8 File Offset: 0x000064F8
		public AmbientValueAttribute(object value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a single-precision floating point number for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x060008A0 RID: 2208 RVA: 0x00008307 File Offset: 0x00006507
		public AmbientValueAttribute(float value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given a string for its value.</summary>
		/// <param name="value">The value of this attribute. </param>
		// Token: 0x060008A1 RID: 2209 RVA: 0x000082F8 File Offset: 0x000064F8
		public AmbientValueAttribute(string value)
		{
			this.AmbientValue = value;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AmbientValueAttribute" /> class, given the value and its type.</summary>
		/// <param name="type">The <see cref="T:System.Type" /> of the <paramref name="value" /> parameter. </param>
		/// <param name="value">The value for this attribute. </param>
		// Token: 0x060008A2 RID: 2210 RVA: 0x0002E7B4 File Offset: 0x0002C9B4
		public AmbientValueAttribute(Type type, string value)
		{
			try
			{
				this.AmbientValue = Convert.ChangeType(value, type);
			}
			catch
			{
				this.AmbientValue = null;
			}
		}

		/// <summary>Gets the object that is the value of this <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</summary>
		/// <returns>The object that is the value of this <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</returns>
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0000831B File Offset: 0x0000651B
		public object Value
		{
			get
			{
				return this.AmbientValue;
			}
		}

		/// <summary>Determines whether the specified <see cref="T:System.ComponentModel.AmbientValueAttribute" /> is equal to the current <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</summary>
		/// <returns>true if the specified <see cref="T:System.ComponentModel.AmbientValueAttribute" /> is equal to the current <see cref="T:System.ComponentModel.AmbientValueAttribute" />; otherwise, false.</returns>
		/// <param name="obj">The <see cref="T:System.ComponentModel.AmbientValueAttribute" /> to compare with the current <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</param>
		// Token: 0x060008A4 RID: 2212 RVA: 0x00008323 File Offset: 0x00006523
		public override bool Equals(object obj)
		{
			return obj is AmbientValueAttribute && (obj == this || ((AmbientValueAttribute)obj).Value == this.AmbientValue);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.AmbientValueAttribute" />.</returns>
		// Token: 0x060008A5 RID: 2213 RVA: 0x0000834E File Offset: 0x0000654E
		public override int GetHashCode()
		{
			return this.AmbientValue.GetHashCode();
		}

		// Token: 0x04000249 RID: 585
		private object AmbientValue;
	}
}
