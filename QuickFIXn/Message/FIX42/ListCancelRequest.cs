﻿using QuickFix.Fields;

namespace QuickFix
{
	namespace FIX42
	{
		public class ListCancelRequest : Message
		{
			public const string MsgType = "K";

			public ListCancelRequest() : base()
			{
				this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
			}

			public ListCancelRequest(QuickFix.Fields.ListID aListID,
				QuickFix.Fields.TransactTime aTransactTime)
				   : this()
			{
				this.ListID = aListID;
				this.TransactTime = aTransactTime;
			}

			public QuickFix.Fields.ListID ListID
			{
				get
				{
					var val = new QuickFix.Fields.ListID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

			public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

			public bool IsSetListID() { return IsSetField(Tags.ListID); }
			public QuickFix.Fields.TransactTime TransactTime
			{
				get
				{
					var val = new QuickFix.Fields.TransactTime();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

			public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

			public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }
			public QuickFix.Fields.Text Text
			{
				get
				{
					var val = new QuickFix.Fields.Text();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Text val) { this.Text = val; }

			public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

			public bool IsSetText() { return IsSetField(Tags.Text); }
			public QuickFix.Fields.EncodedTextLen EncodedTextLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedTextLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

			public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

			public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }
			public QuickFix.Fields.EncodedText EncodedText
			{
				get
				{
					var val = new QuickFix.Fields.EncodedText();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

			public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

			public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }

		}
	}
}
