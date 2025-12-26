using System;
using System.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020002DB RID: 731
	public class TextEditor
	{
		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0000DAC2 File Offset: 0x0000BCC2
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x0000DACA File Offset: 0x0000BCCA
		public Rect position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				if (this.m_Position == value)
				{
					return;
				}
				this.m_Position = value;
				this.UpdateScrollOffset();
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x0000DAEB File Offset: 0x0000BCEB
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x0002A8F8 File Offset: 0x00028AF8
		public int cursorIndex
		{
			get
			{
				return this.m_CursorIndex;
			}
			set
			{
				int cursorIndex = this.m_CursorIndex;
				this.m_CursorIndex = Mathf.Clamp(value, 0, this.content.text.Length);
				if (this.m_CursorIndex != cursorIndex)
				{
					this.m_RevealCursor = true;
				}
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000DAFB File Offset: 0x0000BCFB
		public int selectIndex
		{
			get
			{
				return this.m_SelectIndex;
			}
			set
			{
				this.m_SelectIndex = Mathf.Clamp(value, 0, this.content.text.Length);
			}
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0000DB1A File Offset: 0x0000BD1A
		private void ClearCursorPos()
		{
			this.hasHorizontalCursorPos = false;
			this.m_iAltCursorPos = -1;
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0002A93C File Offset: 0x00028B3C
		public void OnFocus()
		{
			if (this.multiline)
			{
				int num = 0;
				this.selectIndex = num;
				this.cursorIndex = num;
			}
			else
			{
				this.SelectAll();
			}
			this.m_HasFocus = true;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0000DB2A File Offset: 0x0000BD2A
		public void OnLostFocus()
		{
			this.m_HasFocus = false;
			this.scrollOffset = Vector2.zero;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0002A978 File Offset: 0x00028B78
		private void GrabGraphicalCursorPos()
		{
			if (!this.hasHorizontalCursorPos)
			{
				this.graphicalCursorPos = this.style.GetCursorPixelPosition(this.position, this.content, this.cursorIndex);
				this.graphicalSelectCursorPos = this.style.GetCursorPixelPosition(this.position, this.content, this.selectIndex);
				this.hasHorizontalCursorPos = false;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0002A9E0 File Offset: 0x00028BE0
		public bool HandleKeyEvent(Event e)
		{
			this.InitKeyActions();
			EventModifiers modifiers = e.modifiers;
			e.modifiers &= ~EventModifiers.CapsLock;
			if (TextEditor.s_Keyactions.ContainsKey(e))
			{
				TextEditor.TextEditOp textEditOp = TextEditor.s_Keyactions[e];
				this.PerformOperation(textEditOp);
				e.modifiers = modifiers;
				return true;
			}
			e.modifiers = modifiers;
			return false;
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0002AA40 File Offset: 0x00028C40
		public bool DeleteLineBack()
		{
			if (this.hasSelection)
			{
				this.DeleteSelection();
				return true;
			}
			int num = this.cursorIndex;
			int num2 = num;
			while (num2-- != 0)
			{
				if (this.content.text[num2] == '\n')
				{
					num = num2 + 1;
					break;
				}
			}
			if (num2 == -1)
			{
				num = 0;
			}
			if (this.cursorIndex != num)
			{
				this.content.text = this.content.text.Remove(num, this.cursorIndex - num);
				int num3 = num;
				this.cursorIndex = num3;
				this.selectIndex = num3;
				return true;
			}
			return false;
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0002AAE8 File Offset: 0x00028CE8
		public bool DeleteWordBack()
		{
			if (this.hasSelection)
			{
				this.DeleteSelection();
				return true;
			}
			int num = this.FindEndOfPreviousWord(this.cursorIndex);
			if (this.cursorIndex != num)
			{
				this.content.text = this.content.text.Remove(num, this.cursorIndex - num);
				int num2 = num;
				this.cursorIndex = num2;
				this.selectIndex = num2;
				return true;
			}
			return false;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0002AB5C File Offset: 0x00028D5C
		public bool DeleteWordForward()
		{
			if (this.hasSelection)
			{
				this.DeleteSelection();
				return true;
			}
			int num = this.FindStartOfNextWord(this.cursorIndex);
			if (this.cursorIndex < this.content.text.Length)
			{
				this.content.text = this.content.text.Remove(this.cursorIndex, num - this.cursorIndex);
				return true;
			}
			return false;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0002ABD4 File Offset: 0x00028DD4
		public bool Delete()
		{
			if (this.hasSelection)
			{
				this.DeleteSelection();
				return true;
			}
			if (this.cursorIndex < this.content.text.Length)
			{
				this.content.text = this.content.text.Remove(this.cursorIndex, 1);
				return true;
			}
			return false;
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0000DB3E File Offset: 0x0000BD3E
		public bool CanPaste()
		{
			return GUIUtility.systemCopyBuffer.Length != 0;
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0002AC38 File Offset: 0x00028E38
		public bool Backspace()
		{
			if (this.hasSelection)
			{
				this.DeleteSelection();
				return true;
			}
			if (this.cursorIndex > 0)
			{
				this.content.text = this.content.text.Remove(this.cursorIndex - 1, 1);
				int num = this.cursorIndex - 1;
				this.cursorIndex = num;
				this.selectIndex = num;
				this.ClearCursorPos();
				return true;
			}
			return false;
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0000DB50 File Offset: 0x0000BD50
		public void SelectAll()
		{
			this.cursorIndex = 0;
			this.selectIndex = this.content.text.Length;
			this.ClearCursorPos();
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0000DB75 File Offset: 0x0000BD75
		public void SelectNone()
		{
			this.selectIndex = this.cursorIndex;
			this.ClearCursorPos();
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x0000DB89 File Offset: 0x0000BD89
		public bool hasSelection
		{
			get
			{
				return this.cursorIndex != this.selectIndex;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x0002ACAC File Offset: 0x00028EAC
		public string SelectedText
		{
			get
			{
				int length = this.content.text.Length;
				if (this.cursorIndex > length)
				{
					this.cursorIndex = length;
				}
				if (this.selectIndex > length)
				{
					this.selectIndex = length;
				}
				if (this.cursorIndex == this.selectIndex)
				{
					return string.Empty;
				}
				if (this.cursorIndex < this.selectIndex)
				{
					return this.content.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
				}
				return this.content.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0002AD60 File Offset: 0x00028F60
		public bool DeleteSelection()
		{
			int length = this.content.text.Length;
			if (this.cursorIndex > length)
			{
				this.cursorIndex = length;
			}
			if (this.selectIndex > length)
			{
				this.selectIndex = length;
			}
			if (this.cursorIndex == this.selectIndex)
			{
				return false;
			}
			if (this.cursorIndex < this.selectIndex)
			{
				this.content.text = this.content.text.Substring(0, this.cursorIndex) + this.content.text.Substring(this.selectIndex, this.content.text.Length - this.selectIndex);
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.content.text = this.content.text.Substring(0, this.selectIndex) + this.content.text.Substring(this.cursorIndex, this.content.text.Length - this.cursorIndex);
				this.cursorIndex = this.selectIndex;
			}
			this.ClearCursorPos();
			return true;
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0002AE94 File Offset: 0x00029094
		public void ReplaceSelection(string replace)
		{
			this.DeleteSelection();
			this.content.text = this.content.text.Insert(this.cursorIndex, replace);
			this.selectIndex = (this.cursorIndex += replace.Length);
			this.ClearCursorPos();
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0000DB9C File Offset: 0x0000BD9C
		public void Insert(char c)
		{
			this.ReplaceSelection(c.ToString());
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0002AEEC File Offset: 0x000290EC
		public void MoveSelectionToAltCursor()
		{
			if (this.m_iAltCursorPos == -1)
			{
				return;
			}
			int iAltCursorPos = this.m_iAltCursorPos;
			string selectedText = this.SelectedText;
			this.content.text = this.content.text.Insert(iAltCursorPos, selectedText);
			if (iAltCursorPos < this.cursorIndex)
			{
				this.cursorIndex += selectedText.Length;
				this.selectIndex += selectedText.Length;
			}
			this.DeleteSelection();
			int num = iAltCursorPos;
			this.cursorIndex = num;
			this.selectIndex = num;
			this.ClearCursorPos();
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0002AF80 File Offset: 0x00029180
		public void MoveRight()
		{
			this.ClearCursorPos();
			if (this.selectIndex == this.cursorIndex)
			{
				this.cursorIndex++;
				this.DetectFocusChange();
				this.selectIndex = this.cursorIndex;
			}
			else if (this.selectIndex > this.cursorIndex)
			{
				this.cursorIndex = this.selectIndex;
			}
			else
			{
				this.selectIndex = this.cursorIndex;
			}
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0002AFF8 File Offset: 0x000291F8
		public void MoveLeft()
		{
			if (this.selectIndex == this.cursorIndex)
			{
				this.cursorIndex--;
				this.selectIndex = this.cursorIndex;
			}
			else if (this.selectIndex > this.cursorIndex)
			{
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.cursorIndex = this.selectIndex;
			}
			this.ClearCursorPos();
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0002B06C File Offset: 0x0002926C
		public void MoveUp()
		{
			if (this.selectIndex < this.cursorIndex)
			{
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.cursorIndex = this.selectIndex;
			}
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y - 1f;
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.content, this.graphicalCursorPos);
			this.selectIndex = cursorStringIndex;
			this.cursorIndex = cursorStringIndex;
			if (this.cursorIndex <= 0)
			{
				this.ClearCursorPos();
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0002B104 File Offset: 0x00029304
		public void MoveDown()
		{
			if (this.selectIndex > this.cursorIndex)
			{
				this.selectIndex = this.cursorIndex;
			}
			else
			{
				this.cursorIndex = this.selectIndex;
			}
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y + (this.style.lineHeight + 5f);
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.content, this.graphicalCursorPos);
			this.selectIndex = cursorStringIndex;
			this.cursorIndex = cursorStringIndex;
			if (this.cursorIndex == this.content.text.Length)
			{
				this.ClearCursorPos();
			}
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0002B1B8 File Offset: 0x000293B8
		public void MoveLineStart()
		{
			int num = ((this.selectIndex >= this.cursorIndex) ? this.cursorIndex : this.selectIndex);
			int num2 = num;
			int num3;
			while (num2-- != 0)
			{
				if (this.content.text[num2] == '\n')
				{
					num3 = num2 + 1;
					this.cursorIndex = num3;
					this.selectIndex = num3;
					return;
				}
			}
			num3 = 0;
			this.cursorIndex = num3;
			this.selectIndex = num3;
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0002B234 File Offset: 0x00029434
		public void MoveLineEnd()
		{
			int num = ((this.selectIndex <= this.cursorIndex) ? this.cursorIndex : this.selectIndex);
			int i = num;
			int length = this.content.text.Length;
			int num2;
			while (i < length)
			{
				if (this.content.text[i] == '\n')
				{
					num2 = i;
					this.cursorIndex = num2;
					this.selectIndex = num2;
					return;
				}
				i++;
			}
			num2 = length;
			this.cursorIndex = num2;
			this.selectIndex = num2;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0002B2C0 File Offset: 0x000294C0
		public void MoveGraphicalLineStart()
		{
			int graphicalLineStart = this.GetGraphicalLineStart((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			this.selectIndex = graphicalLineStart;
			this.cursorIndex = graphicalLineStart;
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0002B304 File Offset: 0x00029504
		public void MoveGraphicalLineEnd()
		{
			int graphicalLineEnd = this.GetGraphicalLineEnd((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			this.selectIndex = graphicalLineEnd;
			this.cursorIndex = graphicalLineEnd;
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0002B348 File Offset: 0x00029548
		public void MoveTextStart()
		{
			int num = 0;
			this.cursorIndex = num;
			this.selectIndex = num;
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x0002B368 File Offset: 0x00029568
		public void MoveTextEnd()
		{
			int length = this.content.text.Length;
			this.cursorIndex = length;
			this.selectIndex = length;
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0002B394 File Offset: 0x00029594
		private int IndexOfEndOfLine(int startIndex)
		{
			int num = this.content.text.IndexOf('\n', startIndex);
			return (num == -1) ? this.content.text.Length : num;
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0002B3D4 File Offset: 0x000295D4
		public void MoveParagraphForward()
		{
			this.cursorIndex = ((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			if (this.cursorIndex < this.content.text.Length)
			{
				int num = this.IndexOfEndOfLine(this.cursorIndex + 1);
				this.cursorIndex = num;
				this.selectIndex = num;
			}
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0002B444 File Offset: 0x00029644
		public void MoveParagraphBackward()
		{
			this.cursorIndex = ((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			if (this.cursorIndex > 1)
			{
				int num = this.content.text.LastIndexOf('\n', this.cursorIndex - 2) + 1;
				this.cursorIndex = num;
				this.selectIndex = num;
			}
			else
			{
				int num = 0;
				this.cursorIndex = num;
				this.selectIndex = num;
			}
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0002B4C8 File Offset: 0x000296C8
		public void MoveCursorToPosition(Vector2 cursorPosition)
		{
			this.selectIndex = this.style.GetCursorStringIndex(this.position, this.content, cursorPosition + this.scrollOffset);
			if (!Event.current.shift)
			{
				this.cursorIndex = this.selectIndex;
			}
			this.DetectFocusChange();
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0002B520 File Offset: 0x00029720
		public void MoveAltCursorToPosition(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.content, cursorPosition + this.scrollOffset);
			this.m_iAltCursorPos = Mathf.Min(this.content.text.Length, cursorStringIndex);
			this.DetectFocusChange();
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0002B574 File Offset: 0x00029774
		public bool IsOverSelection(Vector2 cursorPosition)
		{
			int cursorStringIndex = this.style.GetCursorStringIndex(this.position, this.content, cursorPosition + this.scrollOffset);
			return cursorStringIndex < Mathf.Max(this.cursorIndex, this.selectIndex) && cursorStringIndex > Mathf.Min(this.cursorIndex, this.selectIndex);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x0002B5D4 File Offset: 0x000297D4
		public void SelectToPosition(Vector2 cursorPosition)
		{
			if (!this.m_MouseDragSelectsWholeWords)
			{
				this.cursorIndex = this.style.GetCursorStringIndex(this.position, this.content, cursorPosition + this.scrollOffset);
			}
			else
			{
				int num = this.style.GetCursorStringIndex(this.position, this.content, cursorPosition + this.scrollOffset);
				if (this.m_DblClickSnap == TextEditor.DblClickSnapping.WORDS)
				{
					if (num < this.m_DblClickInitPos)
					{
						this.cursorIndex = this.FindEndOfClassification(num, -1);
						this.selectIndex = this.FindEndOfClassification(this.m_DblClickInitPos, 1);
					}
					else
					{
						if (num >= this.content.text.Length)
						{
							num = this.content.text.Length - 1;
						}
						this.cursorIndex = this.FindEndOfClassification(num, 1);
						this.selectIndex = this.FindEndOfClassification(this.m_DblClickInitPos - 1, -1);
					}
				}
				else if (num < this.m_DblClickInitPos)
				{
					if (num > 0)
					{
						this.cursorIndex = this.content.text.LastIndexOf('\n', Mathf.Max(0, num - 2)) + 1;
					}
					else
					{
						this.cursorIndex = 0;
					}
					this.selectIndex = this.content.text.LastIndexOf('\n', this.m_DblClickInitPos);
				}
				else
				{
					if (num < this.content.text.Length)
					{
						this.cursorIndex = this.IndexOfEndOfLine(num);
					}
					else
					{
						this.cursorIndex = this.content.text.Length;
					}
					this.selectIndex = this.content.text.LastIndexOf('\n', Mathf.Max(0, this.m_DblClickInitPos - 2)) + 1;
				}
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0002B798 File Offset: 0x00029998
		public void SelectLeft()
		{
			if (this.m_bJustSelected && this.cursorIndex > this.selectIndex)
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.selectIndex;
				this.selectIndex = cursorIndex;
			}
			this.m_bJustSelected = false;
			this.cursorIndex--;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0002B7F0 File Offset: 0x000299F0
		public void SelectRight()
		{
			if (this.m_bJustSelected && this.cursorIndex < this.selectIndex)
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.selectIndex;
				this.selectIndex = cursorIndex;
			}
			this.m_bJustSelected = false;
			this.cursorIndex++;
			int length = this.content.text.Length;
			if (this.cursorIndex > length)
			{
				this.cursorIndex = length;
			}
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0002B86C File Offset: 0x00029A6C
		public void SelectUp()
		{
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y - 1f;
			this.cursorIndex = this.style.GetCursorStringIndex(this.position, this.content, this.graphicalCursorPos);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0002B8BC File Offset: 0x00029ABC
		public void SelectDown()
		{
			this.GrabGraphicalCursorPos();
			this.graphicalCursorPos.y = this.graphicalCursorPos.y + (this.style.lineHeight + 5f);
			this.cursorIndex = this.style.GetCursorStringIndex(this.position, this.content, this.graphicalCursorPos);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0000DBAB File Offset: 0x0000BDAB
		public void SelectTextEnd()
		{
			this.cursorIndex = this.content.text.Length;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0000DBC3 File Offset: 0x0000BDC3
		public void SelectTextStart()
		{
			this.cursorIndex = 0;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0000DBCC File Offset: 0x0000BDCC
		public void MouseDragSelectsWholeWords(bool on)
		{
			this.m_MouseDragSelectsWholeWords = on;
			this.m_DblClickInitPos = this.cursorIndex;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0000DBE1 File Offset: 0x0000BDE1
		public void DblClickSnap(TextEditor.DblClickSnapping snapping)
		{
			this.m_DblClickSnap = snapping;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0002B918 File Offset: 0x00029B18
		private int GetGraphicalLineStart(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.position, this.content, p);
			cursorPixelPosition.x = 0f;
			return this.style.GetCursorStringIndex(this.position, this.content, cursorPixelPosition);
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0002B964 File Offset: 0x00029B64
		private int GetGraphicalLineEnd(int p)
		{
			Vector2 cursorPixelPosition = this.style.GetCursorPixelPosition(this.position, this.content, p);
			cursorPixelPosition.x += 5000f;
			return this.style.GetCursorStringIndex(this.position, this.content, cursorPixelPosition);
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x0002B9B8 File Offset: 0x00029BB8
		private int FindNextSeperator(int startPos)
		{
			int length = this.content.text.Length;
			while (startPos < length && !TextEditor.isLetterLikeChar(this.content.text[startPos]))
			{
				startPos++;
			}
			while (startPos < length && TextEditor.isLetterLikeChar(this.content.text[startPos]))
			{
				startPos++;
			}
			return startPos;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x0000DBEA File Offset: 0x0000BDEA
		private static bool isLetterLikeChar(char c)
		{
			return char.IsLetterOrDigit(c) || c == '\'';
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x0002BA30 File Offset: 0x00029C30
		private int FindPrevSeperator(int startPos)
		{
			startPos--;
			while (startPos > 0 && !TextEditor.isLetterLikeChar(this.content.text[startPos]))
			{
				startPos--;
			}
			while (startPos >= 0 && TextEditor.isLetterLikeChar(this.content.text[startPos]))
			{
				startPos--;
			}
			return startPos + 1;
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		public void MoveWordRight()
		{
			this.cursorIndex = ((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			int num = this.FindNextSeperator(this.cursorIndex);
			this.selectIndex = num;
			this.cursorIndex = num;
			this.ClearCursorPos();
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0002BAF8 File Offset: 0x00029CF8
		public void MoveToStartOfNextWord()
		{
			this.ClearCursorPos();
			if (this.cursorIndex != this.selectIndex)
			{
				this.MoveRight();
				return;
			}
			int num = this.FindStartOfNextWord(this.cursorIndex);
			this.selectIndex = num;
			this.cursorIndex = num;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0002BB40 File Offset: 0x00029D40
		public void MoveToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			if (this.cursorIndex != this.selectIndex)
			{
				this.MoveLeft();
				return;
			}
			int num = this.FindEndOfPreviousWord(this.cursorIndex);
			this.selectIndex = num;
			this.cursorIndex = num;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0000DBFF File Offset: 0x0000BDFF
		public void SelectToStartOfNextWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindStartOfNextWord(this.cursorIndex);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0000DC19 File Offset: 0x0000BE19
		public void SelectToEndOfPreviousWord()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.FindEndOfPreviousWord(this.cursorIndex);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0000DC33 File Offset: 0x0000BE33
		private TextEditor.CharacterType ClassifyChar(char c)
		{
			if (char.IsWhiteSpace(c))
			{
				return TextEditor.CharacterType.WhiteSpace;
			}
			if (char.IsLetterOrDigit(c) || c == '\'')
			{
				return TextEditor.CharacterType.LetterLike;
			}
			return TextEditor.CharacterType.Symbol;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x0002BB88 File Offset: 0x00029D88
		public int FindStartOfNextWord(int p)
		{
			int length = this.content.text.Length;
			if (p == length)
			{
				return p;
			}
			char c = this.content.text[p];
			TextEditor.CharacterType characterType = this.ClassifyChar(c);
			if (characterType != TextEditor.CharacterType.WhiteSpace)
			{
				p++;
				while (p < length && this.ClassifyChar(this.content.text[p]) == characterType)
				{
					p++;
				}
			}
			else if (c == '\t' || c == '\n')
			{
				return p + 1;
			}
			if (p == length)
			{
				return p;
			}
			c = this.content.text[p];
			if (c == ' ')
			{
				while (p < length && char.IsWhiteSpace(this.content.text[p]))
				{
					p++;
				}
			}
			else if (c == '\t' || c == '\n')
			{
				return p;
			}
			return p;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0002BC84 File Offset: 0x00029E84
		private int FindEndOfPreviousWord(int p)
		{
			if (p == 0)
			{
				return p;
			}
			p--;
			while (p > 0 && this.content.text[p] == ' ')
			{
				p--;
			}
			TextEditor.CharacterType characterType = this.ClassifyChar(this.content.text[p]);
			if (characterType != TextEditor.CharacterType.WhiteSpace)
			{
				while (p > 0 && this.ClassifyChar(this.content.text[p - 1]) == characterType)
				{
					p--;
				}
			}
			return p;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0002BD18 File Offset: 0x00029F18
		public void MoveWordLeft()
		{
			this.cursorIndex = ((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
			this.cursorIndex = this.FindPrevSeperator(this.cursorIndex);
			this.selectIndex = this.cursorIndex;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x0002BD6C File Offset: 0x00029F6C
		public void SelectWordRight()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			if (this.cursorIndex < this.selectIndex)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordRight();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex >= this.selectIndex) ? this.selectIndex : this.cursorIndex);
				return;
			}
			this.selectIndex = this.cursorIndex;
			this.MoveWordRight();
			this.selectIndex = selectIndex;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x0002BDF4 File Offset: 0x00029FF4
		public void SelectWordLeft()
		{
			this.ClearCursorPos();
			int selectIndex = this.selectIndex;
			if (this.cursorIndex > this.selectIndex)
			{
				this.selectIndex = this.cursorIndex;
				this.MoveWordLeft();
				this.selectIndex = selectIndex;
				this.cursorIndex = ((this.cursorIndex <= this.selectIndex) ? this.selectIndex : this.cursorIndex);
				return;
			}
			this.selectIndex = this.cursorIndex;
			this.MoveWordLeft();
			this.selectIndex = selectIndex;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0002BE7C File Offset: 0x0002A07C
		public void ExpandSelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			if (this.cursorIndex < this.selectIndex)
			{
				this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineStart(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		public void ExpandSelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			if (this.cursorIndex > this.selectIndex)
			{
				this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
			}
			else
			{
				int cursorIndex = this.cursorIndex;
				this.cursorIndex = this.GetGraphicalLineEnd(this.selectIndex);
				this.selectIndex = cursorIndex;
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0000DC58 File Offset: 0x0000BE58
		public void SelectGraphicalLineStart()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineStart(this.cursorIndex);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0000DC72 File Offset: 0x0000BE72
		public void SelectGraphicalLineEnd()
		{
			this.ClearCursorPos();
			this.cursorIndex = this.GetGraphicalLineEnd(this.cursorIndex);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0002BF34 File Offset: 0x0002A134
		public void SelectParagraphForward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex < this.selectIndex;
			if (this.cursorIndex < this.content.text.Length)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex + 1);
				if (flag && this.cursorIndex > this.selectIndex)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0002BFA8 File Offset: 0x0002A1A8
		public void SelectParagraphBackward()
		{
			this.ClearCursorPos();
			bool flag = this.cursorIndex > this.selectIndex;
			if (this.cursorIndex > 1)
			{
				this.cursorIndex = this.content.text.LastIndexOf('\n', this.cursorIndex - 2) + 1;
				if (flag && this.cursorIndex < this.selectIndex)
				{
					this.cursorIndex = this.selectIndex;
				}
			}
			else
			{
				int num = 0;
				this.cursorIndex = num;
				this.selectIndex = num;
			}
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0002C030 File Offset: 0x0002A230
		public void SelectCurrentWord()
		{
			this.ClearCursorPos();
			int length = this.content.text.Length;
			this.selectIndex = this.cursorIndex;
			if (length == 0)
			{
				return;
			}
			if (this.cursorIndex >= length)
			{
				this.cursorIndex = length - 1;
			}
			if (this.selectIndex >= length)
			{
				this.selectIndex--;
			}
			if (this.cursorIndex < this.selectIndex)
			{
				this.cursorIndex = this.FindEndOfClassification(this.cursorIndex, -1);
				this.selectIndex = this.FindEndOfClassification(this.selectIndex, 1);
			}
			else
			{
				this.cursorIndex = this.FindEndOfClassification(this.cursorIndex, 1);
				this.selectIndex = this.FindEndOfClassification(this.selectIndex, -1);
			}
			this.m_bJustSelected = true;
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x0002C100 File Offset: 0x0002A300
		private int FindEndOfClassification(int p, int dir)
		{
			int length = this.content.text.Length;
			if (p >= length || p < 0)
			{
				return p;
			}
			TextEditor.CharacterType characterType = this.ClassifyChar(this.content.text[p]);
			for (;;)
			{
				p += dir;
				if (p < 0)
				{
					break;
				}
				if (p >= length)
				{
					return length;
				}
				if (this.ClassifyChar(this.content.text[p]) != characterType)
				{
					goto Block_4;
				}
			}
			return 0;
			Block_4:
			if (dir == 1)
			{
				return p;
			}
			return p + 1;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0002C188 File Offset: 0x0002A388
		public void SelectCurrentParagraph()
		{
			this.ClearCursorPos();
			int length = this.content.text.Length;
			if (this.cursorIndex < length)
			{
				this.cursorIndex = this.IndexOfEndOfLine(this.cursorIndex) + 1;
			}
			if (this.selectIndex != 0)
			{
				this.selectIndex = this.content.text.LastIndexOf('\n', this.selectIndex - 1) + 1;
			}
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		public void UpdateScrollOffsetIfNeeded()
		{
			if (Event.current.type != EventType.Repaint && Event.current.type != EventType.Layout)
			{
				this.UpdateScrollOffset();
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x0002C1FC File Offset: 0x0002A3FC
		private void UpdateScrollOffset()
		{
			int cursorIndex = this.cursorIndex;
			this.graphicalCursorPos = this.style.GetCursorPixelPosition(new Rect(0f, 0f, this.position.width, this.position.height), this.content, cursorIndex);
			Rect rect = this.style.padding.Remove(this.position);
			Vector2 vector = new Vector2(this.style.CalcSize(this.content).x, this.style.CalcHeight(this.content, this.position.width));
			if (vector.x < this.position.width)
			{
				this.scrollOffset.x = 0f;
			}
			else if (this.m_RevealCursor)
			{
				if (this.graphicalCursorPos.x + 1f > this.scrollOffset.x + rect.width)
				{
					this.scrollOffset.x = this.graphicalCursorPos.x - rect.width;
				}
				if (this.graphicalCursorPos.x < this.scrollOffset.x + (float)this.style.padding.left)
				{
					this.scrollOffset.x = this.graphicalCursorPos.x - (float)this.style.padding.left;
				}
			}
			if (vector.y < rect.height)
			{
				this.scrollOffset.y = 0f;
			}
			else if (this.m_RevealCursor)
			{
				if (this.graphicalCursorPos.y + this.style.lineHeight > this.scrollOffset.y + rect.height + (float)this.style.padding.top)
				{
					this.scrollOffset.y = this.graphicalCursorPos.y - rect.height - (float)this.style.padding.top + this.style.lineHeight;
				}
				if (this.graphicalCursorPos.y < this.scrollOffset.y + (float)this.style.padding.top)
				{
					this.scrollOffset.y = this.graphicalCursorPos.y - (float)this.style.padding.top;
				}
			}
			if (this.scrollOffset.y > 0f && vector.y - this.scrollOffset.y < rect.height)
			{
				this.scrollOffset.y = vector.y - rect.height - (float)this.style.padding.top - (float)this.style.padding.bottom;
			}
			this.scrollOffset.y = ((this.scrollOffset.y >= 0f) ? this.scrollOffset.y : 0f);
			this.m_RevealCursor = false;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x0002C538 File Offset: 0x0002A738
		public void DrawCursor(string text)
		{
			string text2 = this.content.text;
			int num = this.cursorIndex;
			if (Input.compositionString.Length > 0)
			{
				this.content.text = text.Substring(0, this.cursorIndex) + Input.compositionString + text.Substring(this.selectIndex);
				num += Input.compositionString.Length;
			}
			else
			{
				this.content.text = text;
			}
			this.graphicalCursorPos = this.style.GetCursorPixelPosition(new Rect(0f, 0f, this.position.width, this.position.height), this.content, num);
			Vector2 contentOffset = this.style.contentOffset;
			this.style.contentOffset -= this.scrollOffset;
			this.style.Internal_clipOffset = this.scrollOffset;
			Input.compositionCursorPos = this.graphicalCursorPos + new Vector2(this.position.x, this.position.y + this.style.lineHeight) - this.scrollOffset;
			if (Input.compositionString.Length > 0)
			{
				this.style.DrawWithTextSelection(this.position, this.content, this.controlID, this.cursorIndex, this.cursorIndex + Input.compositionString.Length, true);
			}
			else
			{
				this.style.DrawWithTextSelection(this.position, this.content, this.controlID, this.cursorIndex, this.selectIndex);
			}
			if (this.m_iAltCursorPos != -1)
			{
				this.style.DrawCursor(this.position, this.content, this.controlID, this.m_iAltCursorPos);
			}
			this.style.contentOffset = contentOffset;
			this.style.Internal_clipOffset = Vector2.zero;
			this.content.text = text2;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0002C748 File Offset: 0x0002A948
		private bool PerformOperation(TextEditor.TextEditOp operation)
		{
			this.m_RevealCursor = true;
			switch (operation)
			{
			case TextEditor.TextEditOp.MoveLeft:
				this.MoveLeft();
				return false;
			case TextEditor.TextEditOp.MoveRight:
				this.MoveRight();
				return false;
			case TextEditor.TextEditOp.MoveUp:
				this.MoveUp();
				return false;
			case TextEditor.TextEditOp.MoveDown:
				this.MoveDown();
				return false;
			case TextEditor.TextEditOp.MoveLineStart:
				this.MoveLineStart();
				return false;
			case TextEditor.TextEditOp.MoveLineEnd:
				this.MoveLineEnd();
				return false;
			case TextEditor.TextEditOp.MoveTextStart:
				this.MoveTextStart();
				return false;
			case TextEditor.TextEditOp.MoveTextEnd:
				this.MoveTextEnd();
				return false;
			case TextEditor.TextEditOp.MoveGraphicalLineStart:
				this.MoveGraphicalLineStart();
				return false;
			case TextEditor.TextEditOp.MoveGraphicalLineEnd:
				this.MoveGraphicalLineEnd();
				return false;
			case TextEditor.TextEditOp.MoveWordLeft:
				this.MoveWordLeft();
				return false;
			case TextEditor.TextEditOp.MoveWordRight:
				this.MoveWordRight();
				return false;
			case TextEditor.TextEditOp.MoveParagraphForward:
				this.MoveParagraphForward();
				return false;
			case TextEditor.TextEditOp.MoveParagraphBackward:
				this.MoveParagraphBackward();
				return false;
			case TextEditor.TextEditOp.MoveToStartOfNextWord:
				this.MoveToStartOfNextWord();
				return false;
			case TextEditor.TextEditOp.MoveToEndOfPreviousWord:
				this.MoveToEndOfPreviousWord();
				return false;
			case TextEditor.TextEditOp.SelectLeft:
				this.SelectLeft();
				return false;
			case TextEditor.TextEditOp.SelectRight:
				this.SelectRight();
				return false;
			case TextEditor.TextEditOp.SelectUp:
				this.SelectUp();
				return false;
			case TextEditor.TextEditOp.SelectDown:
				this.SelectDown();
				return false;
			case TextEditor.TextEditOp.SelectTextStart:
				this.SelectTextStart();
				return false;
			case TextEditor.TextEditOp.SelectTextEnd:
				this.SelectTextEnd();
				return false;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineStart:
				this.ExpandSelectGraphicalLineStart();
				return false;
			case TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd:
				this.ExpandSelectGraphicalLineEnd();
				return false;
			case TextEditor.TextEditOp.SelectGraphicalLineStart:
				this.SelectGraphicalLineStart();
				return false;
			case TextEditor.TextEditOp.SelectGraphicalLineEnd:
				this.SelectGraphicalLineEnd();
				return false;
			case TextEditor.TextEditOp.SelectWordLeft:
				this.SelectWordLeft();
				return false;
			case TextEditor.TextEditOp.SelectWordRight:
				this.SelectWordRight();
				return false;
			case TextEditor.TextEditOp.SelectToEndOfPreviousWord:
				this.SelectToEndOfPreviousWord();
				return false;
			case TextEditor.TextEditOp.SelectToStartOfNextWord:
				this.SelectToStartOfNextWord();
				return false;
			case TextEditor.TextEditOp.SelectParagraphBackward:
				this.SelectParagraphBackward();
				return false;
			case TextEditor.TextEditOp.SelectParagraphForward:
				this.SelectParagraphForward();
				return false;
			case TextEditor.TextEditOp.Delete:
				return this.Delete();
			case TextEditor.TextEditOp.Backspace:
				return this.Backspace();
			case TextEditor.TextEditOp.DeleteWordBack:
				return this.DeleteWordBack();
			case TextEditor.TextEditOp.DeleteWordForward:
				return this.DeleteWordForward();
			case TextEditor.TextEditOp.DeleteLineBack:
				return this.DeleteLineBack();
			case TextEditor.TextEditOp.Cut:
				return this.Cut();
			case TextEditor.TextEditOp.Copy:
				this.Copy();
				return false;
			case TextEditor.TextEditOp.Paste:
				return this.Paste();
			case TextEditor.TextEditOp.SelectAll:
				this.SelectAll();
				return false;
			case TextEditor.TextEditOp.SelectNone:
				this.SelectNone();
				return false;
			}
			Debug.Log("Unimplemented: " + operation);
			return false;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
		public void SaveBackup()
		{
			this.oldText = this.content.text;
			this.oldPos = this.cursorIndex;
			this.oldSelectPos = this.selectIndex;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0000DCDF File Offset: 0x0000BEDF
		public void Undo()
		{
			this.content.text = this.oldText;
			this.cursorIndex = this.oldPos;
			this.selectIndex = this.oldSelectPos;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0000DD0A File Offset: 0x0000BF0A
		public bool Cut()
		{
			if (this.isPasswordField)
			{
				return false;
			}
			this.Copy();
			return this.DeleteSelection();
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
		public void Copy()
		{
			if (this.selectIndex == this.cursorIndex)
			{
				return;
			}
			if (this.isPasswordField)
			{
				return;
			}
			string text;
			if (this.cursorIndex < this.selectIndex)
			{
				text = this.content.text.Substring(this.cursorIndex, this.selectIndex - this.cursorIndex);
			}
			else
			{
				text = this.content.text.Substring(this.selectIndex, this.cursorIndex - this.selectIndex);
			}
			GUIUtility.systemCopyBuffer = text;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0000DD25 File Offset: 0x0000BF25
		private static string ReplaceNewlinesWithSpaces(string value)
		{
			value = value.Replace("\r\n", " ");
			value = value.Replace('\n', ' ');
			value = value.Replace('\r', ' ');
			return value;
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0002CA80 File Offset: 0x0002AC80
		public bool Paste()
		{
			string text = GUIUtility.systemCopyBuffer;
			if (text != string.Empty)
			{
				if (!this.multiline)
				{
					text = TextEditor.ReplaceNewlinesWithSpaces(text);
				}
				this.ReplaceSelection(text);
				return true;
			}
			return false;
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0000DD52 File Offset: 0x0000BF52
		private static void MapKey(string key, TextEditor.TextEditOp action)
		{
			TextEditor.s_Keyactions[Event.KeyboardEvent(key)] = action;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		private void InitKeyActions()
		{
			if (TextEditor.s_Keyactions != null)
			{
				return;
			}
			TextEditor.s_Keyactions = new Dictionary<Event, TextEditor.TextEditOp>();
			TextEditor.MapKey("left", TextEditor.TextEditOp.MoveLeft);
			TextEditor.MapKey("right", TextEditor.TextEditOp.MoveRight);
			TextEditor.MapKey("up", TextEditor.TextEditOp.MoveUp);
			TextEditor.MapKey("down", TextEditor.TextEditOp.MoveDown);
			TextEditor.MapKey("#left", TextEditor.TextEditOp.SelectLeft);
			TextEditor.MapKey("#right", TextEditor.TextEditOp.SelectRight);
			TextEditor.MapKey("#up", TextEditor.TextEditOp.SelectUp);
			TextEditor.MapKey("#down", TextEditor.TextEditOp.SelectDown);
			TextEditor.MapKey("delete", TextEditor.TextEditOp.Delete);
			TextEditor.MapKey("backspace", TextEditor.TextEditOp.Backspace);
			TextEditor.MapKey("#backspace", TextEditor.TextEditOp.Backspace);
			if (Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXWebPlayer || Application.platform == RuntimePlatform.OSXDashboardPlayer || Application.platform == RuntimePlatform.OSXEditor || (Application.platform == RuntimePlatform.WebGLPlayer && SystemInfo.operatingSystem.StartsWith("Mac")))
			{
				TextEditor.MapKey("^left", TextEditor.TextEditOp.MoveGraphicalLineStart);
				TextEditor.MapKey("^right", TextEditor.TextEditOp.MoveGraphicalLineEnd);
				TextEditor.MapKey("&left", TextEditor.TextEditOp.MoveWordLeft);
				TextEditor.MapKey("&right", TextEditor.TextEditOp.MoveWordRight);
				TextEditor.MapKey("&up", TextEditor.TextEditOp.MoveParagraphBackward);
				TextEditor.MapKey("&down", TextEditor.TextEditOp.MoveParagraphForward);
				TextEditor.MapKey("%left", TextEditor.TextEditOp.MoveGraphicalLineStart);
				TextEditor.MapKey("%right", TextEditor.TextEditOp.MoveGraphicalLineEnd);
				TextEditor.MapKey("%up", TextEditor.TextEditOp.MoveTextStart);
				TextEditor.MapKey("%down", TextEditor.TextEditOp.MoveTextEnd);
				TextEditor.MapKey("#home", TextEditor.TextEditOp.SelectTextStart);
				TextEditor.MapKey("#end", TextEditor.TextEditOp.SelectTextEnd);
				TextEditor.MapKey("#^left", TextEditor.TextEditOp.ExpandSelectGraphicalLineStart);
				TextEditor.MapKey("#^right", TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd);
				TextEditor.MapKey("#^up", TextEditor.TextEditOp.SelectParagraphBackward);
				TextEditor.MapKey("#^down", TextEditor.TextEditOp.SelectParagraphForward);
				TextEditor.MapKey("#&left", TextEditor.TextEditOp.SelectWordLeft);
				TextEditor.MapKey("#&right", TextEditor.TextEditOp.SelectWordRight);
				TextEditor.MapKey("#&up", TextEditor.TextEditOp.SelectParagraphBackward);
				TextEditor.MapKey("#&down", TextEditor.TextEditOp.SelectParagraphForward);
				TextEditor.MapKey("#%left", TextEditor.TextEditOp.ExpandSelectGraphicalLineStart);
				TextEditor.MapKey("#%right", TextEditor.TextEditOp.ExpandSelectGraphicalLineEnd);
				TextEditor.MapKey("#%up", TextEditor.TextEditOp.SelectTextStart);
				TextEditor.MapKey("#%down", TextEditor.TextEditOp.SelectTextEnd);
				TextEditor.MapKey("%a", TextEditor.TextEditOp.SelectAll);
				TextEditor.MapKey("%x", TextEditor.TextEditOp.Cut);
				TextEditor.MapKey("%c", TextEditor.TextEditOp.Copy);
				TextEditor.MapKey("%v", TextEditor.TextEditOp.Paste);
				TextEditor.MapKey("^d", TextEditor.TextEditOp.Delete);
				TextEditor.MapKey("^h", TextEditor.TextEditOp.Backspace);
				TextEditor.MapKey("^b", TextEditor.TextEditOp.MoveLeft);
				TextEditor.MapKey("^f", TextEditor.TextEditOp.MoveRight);
				TextEditor.MapKey("^a", TextEditor.TextEditOp.MoveLineStart);
				TextEditor.MapKey("^e", TextEditor.TextEditOp.MoveLineEnd);
				TextEditor.MapKey("&delete", TextEditor.TextEditOp.DeleteWordForward);
				TextEditor.MapKey("&backspace", TextEditor.TextEditOp.DeleteWordBack);
				TextEditor.MapKey("%backspace", TextEditor.TextEditOp.DeleteLineBack);
			}
			else
			{
				TextEditor.MapKey("home", TextEditor.TextEditOp.MoveGraphicalLineStart);
				TextEditor.MapKey("end", TextEditor.TextEditOp.MoveGraphicalLineEnd);
				TextEditor.MapKey("%left", TextEditor.TextEditOp.MoveWordLeft);
				TextEditor.MapKey("%right", TextEditor.TextEditOp.MoveWordRight);
				TextEditor.MapKey("%up", TextEditor.TextEditOp.MoveParagraphBackward);
				TextEditor.MapKey("%down", TextEditor.TextEditOp.MoveParagraphForward);
				TextEditor.MapKey("^left", TextEditor.TextEditOp.MoveToEndOfPreviousWord);
				TextEditor.MapKey("^right", TextEditor.TextEditOp.MoveToStartOfNextWord);
				TextEditor.MapKey("^up", TextEditor.TextEditOp.MoveParagraphBackward);
				TextEditor.MapKey("^down", TextEditor.TextEditOp.MoveParagraphForward);
				TextEditor.MapKey("#^left", TextEditor.TextEditOp.SelectToEndOfPreviousWord);
				TextEditor.MapKey("#^right", TextEditor.TextEditOp.SelectToStartOfNextWord);
				TextEditor.MapKey("#^up", TextEditor.TextEditOp.SelectParagraphBackward);
				TextEditor.MapKey("#^down", TextEditor.TextEditOp.SelectParagraphForward);
				TextEditor.MapKey("#home", TextEditor.TextEditOp.SelectGraphicalLineStart);
				TextEditor.MapKey("#end", TextEditor.TextEditOp.SelectGraphicalLineEnd);
				TextEditor.MapKey("^delete", TextEditor.TextEditOp.DeleteWordForward);
				TextEditor.MapKey("^backspace", TextEditor.TextEditOp.DeleteWordBack);
				TextEditor.MapKey("%backspace", TextEditor.TextEditOp.DeleteLineBack);
				TextEditor.MapKey("^a", TextEditor.TextEditOp.SelectAll);
				TextEditor.MapKey("^x", TextEditor.TextEditOp.Cut);
				TextEditor.MapKey("^c", TextEditor.TextEditOp.Copy);
				TextEditor.MapKey("^v", TextEditor.TextEditOp.Paste);
				TextEditor.MapKey("#delete", TextEditor.TextEditOp.Cut);
				TextEditor.MapKey("^insert", TextEditor.TextEditOp.Copy);
				TextEditor.MapKey("#insert", TextEditor.TextEditOp.Paste);
			}
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0002CEA0 File Offset: 0x0002B0A0
		public void DetectFocusChange()
		{
			if (this.m_HasFocus && this.controlID != GUIUtility.keyboardControl)
			{
				this.OnLostFocus();
			}
			if (!this.m_HasFocus && this.controlID == GUIUtility.keyboardControl)
			{
				this.OnFocus();
			}
		}

		// Token: 0x04000B07 RID: 2823
		public TouchScreenKeyboard keyboardOnScreen;

		// Token: 0x04000B08 RID: 2824
		public int controlID;

		// Token: 0x04000B09 RID: 2825
		public GUIContent content = new GUIContent();

		// Token: 0x04000B0A RID: 2826
		public GUIStyle style = GUIStyle.none;

		// Token: 0x04000B0B RID: 2827
		public bool multiline;

		// Token: 0x04000B0C RID: 2828
		public bool hasHorizontalCursorPos;

		// Token: 0x04000B0D RID: 2829
		public bool isPasswordField;

		// Token: 0x04000B0E RID: 2830
		internal bool m_HasFocus;

		// Token: 0x04000B0F RID: 2831
		public Vector2 scrollOffset = Vector2.zero;

		// Token: 0x04000B10 RID: 2832
		private Rect m_Position;

		// Token: 0x04000B11 RID: 2833
		private int m_CursorIndex;

		// Token: 0x04000B12 RID: 2834
		private int m_SelectIndex;

		// Token: 0x04000B13 RID: 2835
		private bool m_RevealCursor;

		// Token: 0x04000B14 RID: 2836
		public Vector2 graphicalCursorPos;

		// Token: 0x04000B15 RID: 2837
		public Vector2 graphicalSelectCursorPos;

		// Token: 0x04000B16 RID: 2838
		private bool m_MouseDragSelectsWholeWords;

		// Token: 0x04000B17 RID: 2839
		private int m_DblClickInitPos;

		// Token: 0x04000B18 RID: 2840
		private TextEditor.DblClickSnapping m_DblClickSnap;

		// Token: 0x04000B19 RID: 2841
		private bool m_bJustSelected;

		// Token: 0x04000B1A RID: 2842
		private int m_iAltCursorPos = -1;

		// Token: 0x04000B1B RID: 2843
		private string oldText;

		// Token: 0x04000B1C RID: 2844
		private int oldPos;

		// Token: 0x04000B1D RID: 2845
		private int oldSelectPos;

		// Token: 0x04000B1E RID: 2846
		private static Dictionary<Event, TextEditor.TextEditOp> s_Keyactions;

		// Token: 0x020002DC RID: 732
		public enum DblClickSnapping : byte
		{
			// Token: 0x04000B20 RID: 2848
			WORDS,
			// Token: 0x04000B21 RID: 2849
			PARAGRAPHS
		}

		// Token: 0x020002DD RID: 733
		private enum CharacterType
		{
			// Token: 0x04000B23 RID: 2851
			LetterLike,
			// Token: 0x04000B24 RID: 2852
			Symbol,
			// Token: 0x04000B25 RID: 2853
			Symbol2,
			// Token: 0x04000B26 RID: 2854
			WhiteSpace
		}

		// Token: 0x020002DE RID: 734
		private enum TextEditOp
		{
			// Token: 0x04000B28 RID: 2856
			MoveLeft,
			// Token: 0x04000B29 RID: 2857
			MoveRight,
			// Token: 0x04000B2A RID: 2858
			MoveUp,
			// Token: 0x04000B2B RID: 2859
			MoveDown,
			// Token: 0x04000B2C RID: 2860
			MoveLineStart,
			// Token: 0x04000B2D RID: 2861
			MoveLineEnd,
			// Token: 0x04000B2E RID: 2862
			MoveTextStart,
			// Token: 0x04000B2F RID: 2863
			MoveTextEnd,
			// Token: 0x04000B30 RID: 2864
			MovePageUp,
			// Token: 0x04000B31 RID: 2865
			MovePageDown,
			// Token: 0x04000B32 RID: 2866
			MoveGraphicalLineStart,
			// Token: 0x04000B33 RID: 2867
			MoveGraphicalLineEnd,
			// Token: 0x04000B34 RID: 2868
			MoveWordLeft,
			// Token: 0x04000B35 RID: 2869
			MoveWordRight,
			// Token: 0x04000B36 RID: 2870
			MoveParagraphForward,
			// Token: 0x04000B37 RID: 2871
			MoveParagraphBackward,
			// Token: 0x04000B38 RID: 2872
			MoveToStartOfNextWord,
			// Token: 0x04000B39 RID: 2873
			MoveToEndOfPreviousWord,
			// Token: 0x04000B3A RID: 2874
			SelectLeft,
			// Token: 0x04000B3B RID: 2875
			SelectRight,
			// Token: 0x04000B3C RID: 2876
			SelectUp,
			// Token: 0x04000B3D RID: 2877
			SelectDown,
			// Token: 0x04000B3E RID: 2878
			SelectTextStart,
			// Token: 0x04000B3F RID: 2879
			SelectTextEnd,
			// Token: 0x04000B40 RID: 2880
			SelectPageUp,
			// Token: 0x04000B41 RID: 2881
			SelectPageDown,
			// Token: 0x04000B42 RID: 2882
			ExpandSelectGraphicalLineStart,
			// Token: 0x04000B43 RID: 2883
			ExpandSelectGraphicalLineEnd,
			// Token: 0x04000B44 RID: 2884
			SelectGraphicalLineStart,
			// Token: 0x04000B45 RID: 2885
			SelectGraphicalLineEnd,
			// Token: 0x04000B46 RID: 2886
			SelectWordLeft,
			// Token: 0x04000B47 RID: 2887
			SelectWordRight,
			// Token: 0x04000B48 RID: 2888
			SelectToEndOfPreviousWord,
			// Token: 0x04000B49 RID: 2889
			SelectToStartOfNextWord,
			// Token: 0x04000B4A RID: 2890
			SelectParagraphBackward,
			// Token: 0x04000B4B RID: 2891
			SelectParagraphForward,
			// Token: 0x04000B4C RID: 2892
			Delete,
			// Token: 0x04000B4D RID: 2893
			Backspace,
			// Token: 0x04000B4E RID: 2894
			DeleteWordBack,
			// Token: 0x04000B4F RID: 2895
			DeleteWordForward,
			// Token: 0x04000B50 RID: 2896
			DeleteLineBack,
			// Token: 0x04000B51 RID: 2897
			Cut,
			// Token: 0x04000B52 RID: 2898
			Copy,
			// Token: 0x04000B53 RID: 2899
			Paste,
			// Token: 0x04000B54 RID: 2900
			SelectAll,
			// Token: 0x04000B55 RID: 2901
			SelectNone,
			// Token: 0x04000B56 RID: 2902
			ScrollStart,
			// Token: 0x04000B57 RID: 2903
			ScrollEnd,
			// Token: 0x04000B58 RID: 2904
			ScrollPageUp,
			// Token: 0x04000B59 RID: 2905
			ScrollPageDown
		}
	}
}
