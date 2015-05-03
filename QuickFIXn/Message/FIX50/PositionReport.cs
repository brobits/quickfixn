﻿using QuickFix.Fields;
namespace QuickFix.FIX50
{
    public class PositionReport : Message
    {
        public const string MsgType = "AP";

        public PositionReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
