﻿using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class News : Message
    {
        public const string MsgType = "B";

        public News():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }

        public QuickFix.Fields.OrigTime OrigTime
        {
            get
            {
                var val = new QuickFix.Fields.OrigTime();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.OrigTime val) { this.OrigTime = val; }

        public QuickFix.Fields.OrigTime Get(QuickFix.Fields.OrigTime val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.OrigTime val) { return IsSetOrigTime(); }

        public bool IsSetOrigTime() { return IsSetField(Tags.OrigTime); }

        public QuickFix.Fields.Urgency Urgency
        {
            get
            {
                var val = new QuickFix.Fields.Urgency();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.Urgency val) { this.Urgency = val; }

        public QuickFix.Fields.Urgency Get(QuickFix.Fields.Urgency val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.Urgency val) { return IsSetUrgency(); }

        public bool IsSetUrgency() { return IsSetField(Tags.Urgency); }

        public QuickFix.Fields.RelatdSym RelatdSym
        {
            get
            {
                var val = new QuickFix.Fields.RelatdSym();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RelatdSym val) { this.RelatdSym = val; }

        public QuickFix.Fields.RelatdSym Get(QuickFix.Fields.RelatdSym val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RelatdSym val) { return IsSetRelatdSym(); }

        public bool IsSetRelatdSym() { return IsSetField(Tags.RelatdSym); }

        public QuickFix.Fields.LinesOfText LinesOfText
        {
            get
            {
                var val = new QuickFix.Fields.LinesOfText();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.LinesOfText val) { this.LinesOfText = val; }

        public QuickFix.Fields.LinesOfText Get(QuickFix.Fields.LinesOfText val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.LinesOfText val) { return IsSetLinesOfText(); }

        public bool IsSetLinesOfText() { return IsSetField(Tags.LinesOfText); }

        public QuickFix.Fields.RawDataLength RawDataLength
        {
            get
            {
                var val = new QuickFix.Fields.RawDataLength();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RawDataLength val) { this.RawDataLength = val; }

        public QuickFix.Fields.RawDataLength Get(QuickFix.Fields.RawDataLength val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RawDataLength val) { return IsSetRawDataLength(); }

        public bool IsSetRawDataLength() { return IsSetField(Tags.RawDataLength); }

        public QuickFix.Fields.RawData RawData
        {
            get
            {
                var val = new QuickFix.Fields.RawData();
                GetField(val);
                return val;
            }
            set { SetField(value); }
        }

        public void Set(QuickFix.Fields.RawData val) { this.RawData = val; }

        public QuickFix.Fields.RawData Get(QuickFix.Fields.RawData val)
        {
            GetField(val);
            return val;
        }

        public bool IsSet(QuickFix.Fields.RawData val) { return IsSetRawData(); }

        public bool IsSetRawData() { return IsSetField(Tags.RawData); }


        public class LinesOfTextGroup : Group
        {
            public static int[] fieldOrder = {Tags.Text, 0};

            public LinesOfTextGroup() : base(Tags.LinesOfText, Tags.Text, fieldOrder)
            {
            }

            public override Group Clone()
            {
                var clone = new LinesOfTextGroup();
                clone.CopyStateFrom(this);
                return clone;
            }
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


        }


    }
}
