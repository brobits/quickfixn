﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class MarketDefinition : Message
    {
        public const string MsgType = "BU";

        public MarketDefinition():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
