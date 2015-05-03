﻿using QuickFix.Fields;
namespace QuickFix.FIX42
{
    public class TradingSessionStatus : Message
    {
        public const string MsgType = "h";

        public TradingSessionStatus():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
