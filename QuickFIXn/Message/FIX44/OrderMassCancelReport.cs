﻿using QuickFix.Fields;
namespace QuickFix.FIX44
{
    public class OrderMassCancelReport : Message
    {
        public const string MsgType = "r";

        public OrderMassCancelReport():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
