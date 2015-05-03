﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class NewOrderCross : Message
    {
        public const string MsgType = "s";

        public NewOrderCross():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
