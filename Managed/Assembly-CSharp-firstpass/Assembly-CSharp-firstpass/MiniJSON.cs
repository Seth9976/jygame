using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// Token: 0x02000002 RID: 2
public class MiniJSON
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002108 File Offset: 0x00000308
	public static object jsonDecode(string json)
	{
		MiniJSON.lastDecode = json;
		if (json != null)
		{
			char[] array = json.ToCharArray();
			int num = 0;
			bool flag = true;
			object obj = MiniJSON.parseValue(array, ref num, ref flag);
			if (flag)
			{
				MiniJSON.lastErrorIndex = -1;
			}
			else
			{
				MiniJSON.lastErrorIndex = num;
			}
			return obj;
		}
		return null;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002154 File Offset: 0x00000354
	public static string jsonEncode(object json)
	{
		StringBuilder stringBuilder = new StringBuilder(2000);
		bool flag = MiniJSON.serializeValue(json, stringBuilder);
		return (!flag) ? null : stringBuilder.ToString();
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002188 File Offset: 0x00000388
	public static bool lastDecodeSuccessful()
	{
		return MiniJSON.lastErrorIndex == -1;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002194 File Offset: 0x00000394
	public static int getLastErrorIndex()
	{
		return MiniJSON.lastErrorIndex;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000219C File Offset: 0x0000039C
	public static string getLastErrorSnippet()
	{
		if (MiniJSON.lastErrorIndex == -1)
		{
			return string.Empty;
		}
		int num = MiniJSON.lastErrorIndex - 5;
		int num2 = MiniJSON.lastErrorIndex + 15;
		if (num < 0)
		{
			num = 0;
		}
		if (num2 >= MiniJSON.lastDecode.Length)
		{
			num2 = MiniJSON.lastDecode.Length - 1;
		}
		return MiniJSON.lastDecode.Substring(num, num2 - num + 1);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002204 File Offset: 0x00000404
	protected static Hashtable parseObject(char[] json, ref int index)
	{
		Hashtable hashtable = new Hashtable();
		MiniJSON.nextToken(json, ref index);
		bool flag = false;
		while (!flag)
		{
			int num = MiniJSON.lookAhead(json, index);
			if (num == 0)
			{
				return null;
			}
			if (num == 6)
			{
				MiniJSON.nextToken(json, ref index);
			}
			else
			{
				if (num == 2)
				{
					MiniJSON.nextToken(json, ref index);
					return hashtable;
				}
				string text = MiniJSON.parseString(json, ref index);
				if (text == null)
				{
					return null;
				}
				num = MiniJSON.nextToken(json, ref index);
				if (num != 5)
				{
					return null;
				}
				bool flag2 = true;
				object obj = MiniJSON.parseValue(json, ref index, ref flag2);
				if (!flag2)
				{
					return null;
				}
				hashtable[text] = obj;
			}
		}
		return hashtable;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000022A4 File Offset: 0x000004A4
	protected static ArrayList parseArray(char[] json, ref int index)
	{
		ArrayList arrayList = new ArrayList();
		MiniJSON.nextToken(json, ref index);
		bool flag = false;
		while (!flag)
		{
			int num = MiniJSON.lookAhead(json, index);
			if (num == 0)
			{
				return null;
			}
			if (num == 6)
			{
				MiniJSON.nextToken(json, ref index);
			}
			else
			{
				if (num == 4)
				{
					MiniJSON.nextToken(json, ref index);
					break;
				}
				bool flag2 = true;
				object obj = MiniJSON.parseValue(json, ref index, ref flag2);
				if (!flag2)
				{
					return null;
				}
				arrayList.Add(obj);
			}
		}
		return arrayList;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002324 File Offset: 0x00000524
	protected static object parseValue(char[] json, ref int index, ref bool success)
	{
		switch (MiniJSON.lookAhead(json, index))
		{
		case 1:
			return MiniJSON.parseObject(json, ref index);
		case 3:
			return MiniJSON.parseArray(json, ref index);
		case 7:
			return MiniJSON.parseString(json, ref index);
		case 8:
			return MiniJSON.parseNumber(json, ref index);
		case 9:
			MiniJSON.nextToken(json, ref index);
			return bool.Parse("TRUE");
		case 10:
			MiniJSON.nextToken(json, ref index);
			return bool.Parse("FALSE");
		case 11:
			MiniJSON.nextToken(json, ref index);
			return null;
		}
		success = false;
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000023E0 File Offset: 0x000005E0
	protected static string parseString(char[] json, ref int index)
	{
		string text = string.Empty;
		MiniJSON.eatWhitespace(json, ref index);
		char c = json[index++];
		bool flag = false;
		while (!flag)
		{
			if (index == json.Length)
			{
				break;
			}
			c = json[index++];
			if (c == '"')
			{
				flag = true;
				break;
			}
			if (c == '\\')
			{
				if (index == json.Length)
				{
					break;
				}
				c = json[index++];
				if (c == '"')
				{
					text += '"';
				}
				else if (c == '\\')
				{
					text += '\\';
				}
				else if (c == '/')
				{
					text += '/';
				}
				else if (c == 'b')
				{
					text += '\b';
				}
				else if (c == 'f')
				{
					text += '\f';
				}
				else if (c == 'n')
				{
					text += '\n';
				}
				else if (c == 'r')
				{
					text += '\r';
				}
				else if (c == 't')
				{
					text += '\t';
				}
				else if (c == 'u')
				{
					int num = json.Length - index;
					if (num < 4)
					{
						break;
					}
					char[] array = new char[4];
					Array.Copy(json, index, array, 0, 4);
					uint num2 = uint.Parse(new string(array), NumberStyles.HexNumber);
					text += char.ConvertFromUtf32((int)num2);
					index += 4;
				}
			}
			else
			{
				text += c;
			}
		}
		if (!flag)
		{
			return null;
		}
		return text;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000025B4 File Offset: 0x000007B4
	protected static double parseNumber(char[] json, ref int index)
	{
		MiniJSON.eatWhitespace(json, ref index);
		int lastIndexOfNumber = MiniJSON.getLastIndexOfNumber(json, index);
		int num = lastIndexOfNumber - index + 1;
		char[] array = new char[num];
		Array.Copy(json, index, array, 0, num);
		index = lastIndexOfNumber + 1;
		return double.Parse(new string(array));
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000025FC File Offset: 0x000007FC
	protected static int getLastIndexOfNumber(char[] json, int index)
	{
		int i;
		for (i = index; i < json.Length; i++)
		{
			if ("0123456789+-.eE".IndexOf(json[i]) == -1)
			{
				break;
			}
		}
		return i - 1;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002638 File Offset: 0x00000838
	protected static void eatWhitespace(char[] json, ref int index)
	{
		while (index < json.Length)
		{
			if (" \t\n\r".IndexOf(json[index]) == -1)
			{
				break;
			}
			index++;
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002674 File Offset: 0x00000874
	protected static int lookAhead(char[] json, int index)
	{
		int num = index;
		return MiniJSON.nextToken(json, ref num);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000268C File Offset: 0x0000088C
	protected static int nextToken(char[] json, ref int index)
	{
		MiniJSON.eatWhitespace(json, ref index);
		if (index == json.Length)
		{
			return 0;
		}
		char c = json[index];
		index++;
		char c2 = c;
		switch (c2)
		{
		case '"':
			return 7;
		default:
			switch (c2)
			{
			case '[':
				return 3;
			default:
			{
				switch (c2)
				{
				case '{':
					return 1;
				case '}':
					return 2;
				}
				index--;
				int num = json.Length - index;
				if (num >= 5 && json[index] == 'f' && json[index + 1] == 'a' && json[index + 2] == 'l' && json[index + 3] == 's' && json[index + 4] == 'e')
				{
					index += 5;
					return 10;
				}
				if (num >= 4 && json[index] == 't' && json[index + 1] == 'r' && json[index + 2] == 'u' && json[index + 3] == 'e')
				{
					index += 4;
					return 9;
				}
				if (num >= 4 && json[index] == 'n' && json[index + 1] == 'u' && json[index + 2] == 'l' && json[index + 3] == 'l')
				{
					index += 4;
					return 11;
				}
				return 0;
			}
			case ']':
				return 4;
			}
			break;
		case ',':
			return 6;
		case '-':
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
			return 8;
		case ':':
			return 5;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002848 File Offset: 0x00000A48
	protected static bool serializeObjectOrArray(object objectOrArray, StringBuilder builder)
	{
		if (objectOrArray is Hashtable)
		{
			return MiniJSON.serializeObject((Hashtable)objectOrArray, builder);
		}
		return objectOrArray is ArrayList && MiniJSON.serializeArray((ArrayList)objectOrArray, builder);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000287C File Offset: 0x00000A7C
	protected static bool serializeObject(Hashtable anObject, StringBuilder builder)
	{
		builder.Append("{");
		IDictionaryEnumerator enumerator = anObject.GetEnumerator();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			string text = enumerator.Key.ToString();
			object value = enumerator.Value;
			if (!flag)
			{
				builder.Append(", ");
			}
			MiniJSON.serializeString(text, builder);
			builder.Append(":");
			if (!MiniJSON.serializeValue(value, builder))
			{
				return false;
			}
			flag = false;
		}
		builder.Append("}");
		return true;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002904 File Offset: 0x00000B04
	protected static bool serializeDictionary(Dictionary<string, string> dict, StringBuilder builder)
	{
		builder.Append("{");
		bool flag = true;
		foreach (KeyValuePair<string, string> keyValuePair in dict)
		{
			if (!flag)
			{
				builder.Append(", ");
			}
			MiniJSON.serializeString(keyValuePair.Key, builder);
			builder.Append(":");
			MiniJSON.serializeString(keyValuePair.Value, builder);
			flag = false;
		}
		builder.Append("}");
		return true;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000029B4 File Offset: 0x00000BB4
	protected static bool serializeArray(ArrayList anArray, StringBuilder builder)
	{
		builder.Append("[");
		bool flag = true;
		for (int i = 0; i < anArray.Count; i++)
		{
			object obj = anArray[i];
			if (!flag)
			{
				builder.Append(", ");
			}
			if (!MiniJSON.serializeValue(obj, builder))
			{
				return false;
			}
			flag = false;
		}
		builder.Append("]");
		return true;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002A20 File Offset: 0x00000C20
	protected static bool serializeValue(object value, StringBuilder builder)
	{
		if (value == null)
		{
			builder.Append("null");
		}
		else if (value.GetType().IsArray)
		{
			MiniJSON.serializeArray(new ArrayList((ICollection)value), builder);
		}
		else if (value is string)
		{
			MiniJSON.serializeString((string)value, builder);
		}
		else if (value is char)
		{
			MiniJSON.serializeString(Convert.ToString((char)value), builder);
		}
		else if (value is decimal)
		{
			MiniJSON.serializeString(Convert.ToString((decimal)value), builder);
		}
		else if (value is Hashtable)
		{
			MiniJSON.serializeObject((Hashtable)value, builder);
		}
		else if (value is Dictionary<string, string>)
		{
			MiniJSON.serializeDictionary((Dictionary<string, string>)value, builder);
		}
		else if (value is ArrayList)
		{
			MiniJSON.serializeArray((ArrayList)value, builder);
		}
		else if (value is bool && (bool)value)
		{
			builder.Append("true");
		}
		else if (value is bool && !(bool)value)
		{
			builder.Append("false");
		}
		else
		{
			if (!value.GetType().IsPrimitive)
			{
				return false;
			}
			MiniJSON.serializeNumber(Convert.ToDouble(value), builder);
		}
		return true;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002B94 File Offset: 0x00000D94
	protected static void serializeString(string aString, StringBuilder builder)
	{
		builder.Append("\"");
		foreach (char c in aString.ToCharArray())
		{
			if (c == '"')
			{
				builder.Append("\\\"");
			}
			else if (c == '\\')
			{
				builder.Append("\\\\");
			}
			else if (c == '\b')
			{
				builder.Append("\\b");
			}
			else if (c == '\f')
			{
				builder.Append("\\f");
			}
			else if (c == '\n')
			{
				builder.Append("\\n");
			}
			else if (c == '\r')
			{
				builder.Append("\\r");
			}
			else if (c == '\t')
			{
				builder.Append("\\t");
			}
			else
			{
				int num = Convert.ToInt32(c);
				if (num >= 32 && num <= 126)
				{
					builder.Append(c);
				}
				else
				{
					builder.Append("\\u" + Convert.ToString(num, 16).PadLeft(4, '0'));
				}
			}
		}
		builder.Append("\"");
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002CCC File Offset: 0x00000ECC
	protected static void serializeNumber(double number, StringBuilder builder)
	{
		builder.Append(Convert.ToString(number));
	}

	// Token: 0x04000001 RID: 1
	private const int TOKEN_NONE = 0;

	// Token: 0x04000002 RID: 2
	private const int TOKEN_CURLY_OPEN = 1;

	// Token: 0x04000003 RID: 3
	private const int TOKEN_CURLY_CLOSE = 2;

	// Token: 0x04000004 RID: 4
	private const int TOKEN_SQUARED_OPEN = 3;

	// Token: 0x04000005 RID: 5
	private const int TOKEN_SQUARED_CLOSE = 4;

	// Token: 0x04000006 RID: 6
	private const int TOKEN_COLON = 5;

	// Token: 0x04000007 RID: 7
	private const int TOKEN_COMMA = 6;

	// Token: 0x04000008 RID: 8
	private const int TOKEN_STRING = 7;

	// Token: 0x04000009 RID: 9
	private const int TOKEN_NUMBER = 8;

	// Token: 0x0400000A RID: 10
	private const int TOKEN_TRUE = 9;

	// Token: 0x0400000B RID: 11
	private const int TOKEN_FALSE = 10;

	// Token: 0x0400000C RID: 12
	private const int TOKEN_NULL = 11;

	// Token: 0x0400000D RID: 13
	private const int BUILDER_CAPACITY = 2000;

	// Token: 0x0400000E RID: 14
	protected static int lastErrorIndex = -1;

	// Token: 0x0400000F RID: 15
	protected static string lastDecode = string.Empty;
}
