﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class ListStrikePrice : Message
    {
        public const string MsgType = "m";

        public ListStrikePrice():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
