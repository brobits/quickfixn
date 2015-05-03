﻿using QuickFix.Fields;
namespace QuickFix.FIX50SP1
{
    public class AllocationInstructionAlert : Message
    {
        public const string MsgType = "BM";

        public AllocationInstructionAlert():base()
        {
            this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
        }
    }
}
