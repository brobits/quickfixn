﻿using QuickFix.Fields;
namespace QuickFix.FIX40
{
    public class OrderCancelReplaceRequest : Message
    {
        public const string MsgType = "G";

        public OrderCancelReplaceRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
