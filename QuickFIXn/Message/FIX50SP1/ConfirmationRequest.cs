﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class ConfirmationRequest : Message
    {
        public const string MsgType = "BH";

        public ConfirmationRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
