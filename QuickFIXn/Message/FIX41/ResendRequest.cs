﻿using QuickFix.Fields;
namespace QuickFix.FIX41
{
    public class ResendRequest : Message
    {
        public const string MsgType = "2";

        public ResendRequest():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
