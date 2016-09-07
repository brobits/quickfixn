﻿using QuickFix.Fields;

namespace QuickFix
{
	namespace FIX44
	{
		public class AllocationInstruction : Message
		{
			public const string MsgType = "J";

			public AllocationInstruction() : base()
			{
				this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
			}

			public AllocationInstruction(QuickFix.Fields.AllocID aAllocID,
				QuickFix.Fields.AllocTransType aAllocTransType,
				QuickFix.Fields.AllocType aAllocType,
				QuickFix.Fields.AllocNoOrdersType aAllocNoOrdersType,
				QuickFix.Fields.Side aSide,
				QuickFix.Fields.Symbol aSymbol,
				QuickFix.Fields.Quantity aQuantity,
				QuickFix.Fields.AvgPx aAvgPx,
				QuickFix.Fields.TradeDate aTradeDate)
				   : this()
			{
				this.AllocID = aAllocID;
				this.AllocTransType = aAllocTransType;
				this.AllocType = aAllocType;
				this.AllocNoOrdersType = aAllocNoOrdersType;
				this.Side = aSide;
				this.Symbol = aSymbol;
				this.Quantity = aQuantity;
				this.AvgPx = aAvgPx;
				this.TradeDate = aTradeDate;
			}

			public QuickFix.Fields.AllocID AllocID
			{
				get
				{
					var val = new QuickFix.Fields.AllocID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocID val) { this.AllocID = val; }

			public QuickFix.Fields.AllocID Get(QuickFix.Fields.AllocID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocID val) { return IsSetAllocID(); }

			public bool IsSetAllocID() { return IsSetField(Tags.AllocID); }
			public QuickFix.Fields.AllocTransType AllocTransType
			{
				get
				{
					var val = new QuickFix.Fields.AllocTransType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocTransType val) { this.AllocTransType = val; }

			public QuickFix.Fields.AllocTransType Get(QuickFix.Fields.AllocTransType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocTransType val) { return IsSetAllocTransType(); }

			public bool IsSetAllocTransType() { return IsSetField(Tags.AllocTransType); }
			public QuickFix.Fields.AllocType AllocType
			{
				get
				{
					var val = new QuickFix.Fields.AllocType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocType val) { this.AllocType = val; }

			public QuickFix.Fields.AllocType Get(QuickFix.Fields.AllocType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocType val) { return IsSetAllocType(); }

			public bool IsSetAllocType() { return IsSetField(Tags.AllocType); }
			public QuickFix.Fields.SecondaryAllocID SecondaryAllocID
			{
				get
				{
					var val = new QuickFix.Fields.SecondaryAllocID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecondaryAllocID val) { this.SecondaryAllocID = val; }

			public QuickFix.Fields.SecondaryAllocID Get(QuickFix.Fields.SecondaryAllocID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecondaryAllocID val) { return IsSetSecondaryAllocID(); }

			public bool IsSetSecondaryAllocID() { return IsSetField(Tags.SecondaryAllocID); }
			public QuickFix.Fields.RefAllocID RefAllocID
			{
				get
				{
					var val = new QuickFix.Fields.RefAllocID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.RefAllocID val) { this.RefAllocID = val; }

			public QuickFix.Fields.RefAllocID Get(QuickFix.Fields.RefAllocID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.RefAllocID val) { return IsSetRefAllocID(); }

			public bool IsSetRefAllocID() { return IsSetField(Tags.RefAllocID); }
			public QuickFix.Fields.AllocCancReplaceReason AllocCancReplaceReason
			{
				get
				{
					var val = new QuickFix.Fields.AllocCancReplaceReason();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocCancReplaceReason val) { this.AllocCancReplaceReason = val; }

			public QuickFix.Fields.AllocCancReplaceReason Get(QuickFix.Fields.AllocCancReplaceReason val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocCancReplaceReason val) { return IsSetAllocCancReplaceReason(); }

			public bool IsSetAllocCancReplaceReason() { return IsSetField(Tags.AllocCancReplaceReason); }
			public QuickFix.Fields.AllocIntermedReqType AllocIntermedReqType
			{
				get
				{
					var val = new QuickFix.Fields.AllocIntermedReqType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocIntermedReqType val) { this.AllocIntermedReqType = val; }

			public QuickFix.Fields.AllocIntermedReqType Get(QuickFix.Fields.AllocIntermedReqType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocIntermedReqType val) { return IsSetAllocIntermedReqType(); }

			public bool IsSetAllocIntermedReqType() { return IsSetField(Tags.AllocIntermedReqType); }
			public QuickFix.Fields.AllocLinkID AllocLinkID
			{
				get
				{
					var val = new QuickFix.Fields.AllocLinkID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocLinkID val) { this.AllocLinkID = val; }

			public QuickFix.Fields.AllocLinkID Get(QuickFix.Fields.AllocLinkID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocLinkID val) { return IsSetAllocLinkID(); }

			public bool IsSetAllocLinkID() { return IsSetField(Tags.AllocLinkID); }
			public QuickFix.Fields.AllocLinkType AllocLinkType
			{
				get
				{
					var val = new QuickFix.Fields.AllocLinkType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocLinkType val) { this.AllocLinkType = val; }

			public QuickFix.Fields.AllocLinkType Get(QuickFix.Fields.AllocLinkType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocLinkType val) { return IsSetAllocLinkType(); }

			public bool IsSetAllocLinkType() { return IsSetField(Tags.AllocLinkType); }
			public QuickFix.Fields.BookingRefID BookingRefID
			{
				get
				{
					var val = new QuickFix.Fields.BookingRefID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BookingRefID val) { this.BookingRefID = val; }

			public QuickFix.Fields.BookingRefID Get(QuickFix.Fields.BookingRefID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BookingRefID val) { return IsSetBookingRefID(); }

			public bool IsSetBookingRefID() { return IsSetField(Tags.BookingRefID); }
			public QuickFix.Fields.AllocNoOrdersType AllocNoOrdersType
			{
				get
				{
					var val = new QuickFix.Fields.AllocNoOrdersType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocNoOrdersType val) { this.AllocNoOrdersType = val; }

			public QuickFix.Fields.AllocNoOrdersType Get(QuickFix.Fields.AllocNoOrdersType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocNoOrdersType val) { return IsSetAllocNoOrdersType(); }

			public bool IsSetAllocNoOrdersType() { return IsSetField(Tags.AllocNoOrdersType); }
			public QuickFix.Fields.NoOrders NoOrders
			{
				get
				{
					var val = new QuickFix.Fields.NoOrders();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoOrders val) { this.NoOrders = val; }

			public QuickFix.Fields.NoOrders Get(QuickFix.Fields.NoOrders val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoOrders val) { return IsSetNoOrders(); }

			public bool IsSetNoOrders() { return IsSetField(Tags.NoOrders); }
			public QuickFix.Fields.NoExecs NoExecs
			{
				get
				{
					var val = new QuickFix.Fields.NoExecs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoExecs val) { this.NoExecs = val; }

			public QuickFix.Fields.NoExecs Get(QuickFix.Fields.NoExecs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoExecs val) { return IsSetNoExecs(); }

			public bool IsSetNoExecs() { return IsSetField(Tags.NoExecs); }
			public QuickFix.Fields.PreviouslyReported PreviouslyReported
			{
				get
				{
					var val = new QuickFix.Fields.PreviouslyReported();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PreviouslyReported val) { this.PreviouslyReported = val; }

			public QuickFix.Fields.PreviouslyReported Get(QuickFix.Fields.PreviouslyReported val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PreviouslyReported val) { return IsSetPreviouslyReported(); }

			public bool IsSetPreviouslyReported() { return IsSetField(Tags.PreviouslyReported); }
			public QuickFix.Fields.ReversalIndicator ReversalIndicator
			{
				get
				{
					var val = new QuickFix.Fields.ReversalIndicator();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ReversalIndicator val) { this.ReversalIndicator = val; }

			public QuickFix.Fields.ReversalIndicator Get(QuickFix.Fields.ReversalIndicator val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ReversalIndicator val) { return IsSetReversalIndicator(); }

			public bool IsSetReversalIndicator() { return IsSetField(Tags.ReversalIndicator); }
			public QuickFix.Fields.MatchType MatchType
			{
				get
				{
					var val = new QuickFix.Fields.MatchType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MatchType val) { this.MatchType = val; }

			public QuickFix.Fields.MatchType Get(QuickFix.Fields.MatchType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MatchType val) { return IsSetMatchType(); }

			public bool IsSetMatchType() { return IsSetField(Tags.MatchType); }
			public QuickFix.Fields.Side Side
			{
				get
				{
					var val = new QuickFix.Fields.Side();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Side val) { this.Side = val; }

			public QuickFix.Fields.Side Get(QuickFix.Fields.Side val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Side val) { return IsSetSide(); }

			public bool IsSetSide() { return IsSetField(Tags.Side); }
			public QuickFix.Fields.Symbol Symbol
			{
				get
				{
					var val = new QuickFix.Fields.Symbol();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Symbol val) { this.Symbol = val; }

			public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Symbol val) { return IsSetSymbol(); }

			public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }
			public QuickFix.Fields.SymbolSfx SymbolSfx
			{
				get
				{
					var val = new QuickFix.Fields.SymbolSfx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SymbolSfx val) { this.SymbolSfx = val; }

			public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SymbolSfx val) { return IsSetSymbolSfx(); }

			public bool IsSetSymbolSfx() { return IsSetField(Tags.SymbolSfx); }
			public QuickFix.Fields.SecurityID SecurityID
			{
				get
				{
					var val = new QuickFix.Fields.SecurityID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityID val) { this.SecurityID = val; }

			public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityID val) { return IsSetSecurityID(); }

			public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }
			public QuickFix.Fields.SecurityIDSource SecurityIDSource
			{
				get
				{
					var val = new QuickFix.Fields.SecurityIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityIDSource val) { this.SecurityIDSource = val; }

			public QuickFix.Fields.SecurityIDSource Get(QuickFix.Fields.SecurityIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityIDSource val) { return IsSetSecurityIDSource(); }

			public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }
			public QuickFix.Fields.NoSecurityAltID NoSecurityAltID
			{
				get
				{
					var val = new QuickFix.Fields.NoSecurityAltID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoSecurityAltID val) { this.NoSecurityAltID = val; }

			public QuickFix.Fields.NoSecurityAltID Get(QuickFix.Fields.NoSecurityAltID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoSecurityAltID val) { return IsSetNoSecurityAltID(); }

			public bool IsSetNoSecurityAltID() { return IsSetField(Tags.NoSecurityAltID); }
			public QuickFix.Fields.Product Product
			{
				get
				{
					var val = new QuickFix.Fields.Product();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Product val) { this.Product = val; }

			public QuickFix.Fields.Product Get(QuickFix.Fields.Product val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Product val) { return IsSetProduct(); }

			public bool IsSetProduct() { return IsSetField(Tags.Product); }
			public QuickFix.Fields.CFICode CFICode
			{
				get
				{
					var val = new QuickFix.Fields.CFICode();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CFICode val) { this.CFICode = val; }

			public QuickFix.Fields.CFICode Get(QuickFix.Fields.CFICode val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CFICode val) { return IsSetCFICode(); }

			public bool IsSetCFICode() { return IsSetField(Tags.CFICode); }
			public QuickFix.Fields.SecurityType SecurityType
			{
				get
				{
					var val = new QuickFix.Fields.SecurityType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityType val) { this.SecurityType = val; }

			public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityType val) { return IsSetSecurityType(); }

			public bool IsSetSecurityType() { return IsSetField(Tags.SecurityType); }
			public QuickFix.Fields.SecuritySubType SecuritySubType
			{
				get
				{
					var val = new QuickFix.Fields.SecuritySubType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecuritySubType val) { this.SecuritySubType = val; }

			public QuickFix.Fields.SecuritySubType Get(QuickFix.Fields.SecuritySubType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecuritySubType val) { return IsSetSecuritySubType(); }

			public bool IsSetSecuritySubType() { return IsSetField(Tags.SecuritySubType); }
			public QuickFix.Fields.MaturityMonthYear MaturityMonthYear
			{
				get
				{
					var val = new QuickFix.Fields.MaturityMonthYear();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MaturityMonthYear val) { this.MaturityMonthYear = val; }

			public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MaturityMonthYear val) { return IsSetMaturityMonthYear(); }

			public bool IsSetMaturityMonthYear() { return IsSetField(Tags.MaturityMonthYear); }
			public QuickFix.Fields.MaturityDate MaturityDate
			{
				get
				{
					var val = new QuickFix.Fields.MaturityDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MaturityDate val) { this.MaturityDate = val; }

			public QuickFix.Fields.MaturityDate Get(QuickFix.Fields.MaturityDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MaturityDate val) { return IsSetMaturityDate(); }

			public bool IsSetMaturityDate() { return IsSetField(Tags.MaturityDate); }
			public QuickFix.Fields.PutOrCall PutOrCall
			{
				get
				{
					var val = new QuickFix.Fields.PutOrCall();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PutOrCall val) { this.PutOrCall = val; }

			public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PutOrCall val) { return IsSetPutOrCall(); }

			public bool IsSetPutOrCall() { return IsSetField(Tags.PutOrCall); }
			public QuickFix.Fields.CouponPaymentDate CouponPaymentDate
			{
				get
				{
					var val = new QuickFix.Fields.CouponPaymentDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CouponPaymentDate val) { this.CouponPaymentDate = val; }

			public QuickFix.Fields.CouponPaymentDate Get(QuickFix.Fields.CouponPaymentDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CouponPaymentDate val) { return IsSetCouponPaymentDate(); }

			public bool IsSetCouponPaymentDate() { return IsSetField(Tags.CouponPaymentDate); }
			public QuickFix.Fields.IssueDate IssueDate
			{
				get
				{
					var val = new QuickFix.Fields.IssueDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.IssueDate val) { this.IssueDate = val; }

			public QuickFix.Fields.IssueDate Get(QuickFix.Fields.IssueDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.IssueDate val) { return IsSetIssueDate(); }

			public bool IsSetIssueDate() { return IsSetField(Tags.IssueDate); }
			public QuickFix.Fields.RepoCollateralSecurityType RepoCollateralSecurityType
			{
				get
				{
					var val = new QuickFix.Fields.RepoCollateralSecurityType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.RepoCollateralSecurityType val) { this.RepoCollateralSecurityType = val; }

			public QuickFix.Fields.RepoCollateralSecurityType Get(QuickFix.Fields.RepoCollateralSecurityType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.RepoCollateralSecurityType val) { return IsSetRepoCollateralSecurityType(); }

			public bool IsSetRepoCollateralSecurityType() { return IsSetField(Tags.RepoCollateralSecurityType); }
			public QuickFix.Fields.RepurchaseTerm RepurchaseTerm
			{
				get
				{
					var val = new QuickFix.Fields.RepurchaseTerm();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.RepurchaseTerm val) { this.RepurchaseTerm = val; }

			public QuickFix.Fields.RepurchaseTerm Get(QuickFix.Fields.RepurchaseTerm val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.RepurchaseTerm val) { return IsSetRepurchaseTerm(); }

			public bool IsSetRepurchaseTerm() { return IsSetField(Tags.RepurchaseTerm); }
			public QuickFix.Fields.RepurchaseRate RepurchaseRate
			{
				get
				{
					var val = new QuickFix.Fields.RepurchaseRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.RepurchaseRate val) { this.RepurchaseRate = val; }

			public QuickFix.Fields.RepurchaseRate Get(QuickFix.Fields.RepurchaseRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.RepurchaseRate val) { return IsSetRepurchaseRate(); }

			public bool IsSetRepurchaseRate() { return IsSetField(Tags.RepurchaseRate); }
			public QuickFix.Fields.Factor Factor
			{
				get
				{
					var val = new QuickFix.Fields.Factor();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Factor val) { this.Factor = val; }

			public QuickFix.Fields.Factor Get(QuickFix.Fields.Factor val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Factor val) { return IsSetFactor(); }

			public bool IsSetFactor() { return IsSetField(Tags.Factor); }
			public QuickFix.Fields.CreditRating CreditRating
			{
				get
				{
					var val = new QuickFix.Fields.CreditRating();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CreditRating val) { this.CreditRating = val; }

			public QuickFix.Fields.CreditRating Get(QuickFix.Fields.CreditRating val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CreditRating val) { return IsSetCreditRating(); }

			public bool IsSetCreditRating() { return IsSetField(Tags.CreditRating); }
			public QuickFix.Fields.InstrRegistry InstrRegistry
			{
				get
				{
					var val = new QuickFix.Fields.InstrRegistry();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.InstrRegistry val) { this.InstrRegistry = val; }

			public QuickFix.Fields.InstrRegistry Get(QuickFix.Fields.InstrRegistry val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.InstrRegistry val) { return IsSetInstrRegistry(); }

			public bool IsSetInstrRegistry() { return IsSetField(Tags.InstrRegistry); }
			public QuickFix.Fields.CountryOfIssue CountryOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.CountryOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CountryOfIssue val) { this.CountryOfIssue = val; }

			public QuickFix.Fields.CountryOfIssue Get(QuickFix.Fields.CountryOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CountryOfIssue val) { return IsSetCountryOfIssue(); }

			public bool IsSetCountryOfIssue() { return IsSetField(Tags.CountryOfIssue); }
			public QuickFix.Fields.StateOrProvinceOfIssue StateOrProvinceOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.StateOrProvinceOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StateOrProvinceOfIssue val) { this.StateOrProvinceOfIssue = val; }

			public QuickFix.Fields.StateOrProvinceOfIssue Get(QuickFix.Fields.StateOrProvinceOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StateOrProvinceOfIssue val) { return IsSetStateOrProvinceOfIssue(); }

			public bool IsSetStateOrProvinceOfIssue() { return IsSetField(Tags.StateOrProvinceOfIssue); }
			public QuickFix.Fields.LocaleOfIssue LocaleOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.LocaleOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LocaleOfIssue val) { this.LocaleOfIssue = val; }

			public QuickFix.Fields.LocaleOfIssue Get(QuickFix.Fields.LocaleOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LocaleOfIssue val) { return IsSetLocaleOfIssue(); }

			public bool IsSetLocaleOfIssue() { return IsSetField(Tags.LocaleOfIssue); }
			public QuickFix.Fields.RedemptionDate RedemptionDate
			{
				get
				{
					var val = new QuickFix.Fields.RedemptionDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.RedemptionDate val) { this.RedemptionDate = val; }

			public QuickFix.Fields.RedemptionDate Get(QuickFix.Fields.RedemptionDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.RedemptionDate val) { return IsSetRedemptionDate(); }

			public bool IsSetRedemptionDate() { return IsSetField(Tags.RedemptionDate); }
			public QuickFix.Fields.StrikePrice StrikePrice
			{
				get
				{
					var val = new QuickFix.Fields.StrikePrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StrikePrice val) { this.StrikePrice = val; }

			public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StrikePrice val) { return IsSetStrikePrice(); }

			public bool IsSetStrikePrice() { return IsSetField(Tags.StrikePrice); }
			public QuickFix.Fields.StrikeCurrency StrikeCurrency
			{
				get
				{
					var val = new QuickFix.Fields.StrikeCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StrikeCurrency val) { this.StrikeCurrency = val; }

			public QuickFix.Fields.StrikeCurrency Get(QuickFix.Fields.StrikeCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StrikeCurrency val) { return IsSetStrikeCurrency(); }

			public bool IsSetStrikeCurrency() { return IsSetField(Tags.StrikeCurrency); }
			public QuickFix.Fields.OptAttribute OptAttribute
			{
				get
				{
					var val = new QuickFix.Fields.OptAttribute();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.OptAttribute val) { this.OptAttribute = val; }

			public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.OptAttribute val) { return IsSetOptAttribute(); }

			public bool IsSetOptAttribute() { return IsSetField(Tags.OptAttribute); }
			public QuickFix.Fields.ContractMultiplier ContractMultiplier
			{
				get
				{
					var val = new QuickFix.Fields.ContractMultiplier();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ContractMultiplier val) { this.ContractMultiplier = val; }

			public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ContractMultiplier val) { return IsSetContractMultiplier(); }

			public bool IsSetContractMultiplier() { return IsSetField(Tags.ContractMultiplier); }
			public QuickFix.Fields.CouponRate CouponRate
			{
				get
				{
					var val = new QuickFix.Fields.CouponRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CouponRate val) { this.CouponRate = val; }

			public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CouponRate val) { return IsSetCouponRate(); }

			public bool IsSetCouponRate() { return IsSetField(Tags.CouponRate); }
			public QuickFix.Fields.SecurityExchange SecurityExchange
			{
				get
				{
					var val = new QuickFix.Fields.SecurityExchange();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityExchange val) { this.SecurityExchange = val; }

			public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityExchange val) { return IsSetSecurityExchange(); }

			public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }
			public QuickFix.Fields.Issuer Issuer
			{
				get
				{
					var val = new QuickFix.Fields.Issuer();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Issuer val) { this.Issuer = val; }

			public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Issuer val) { return IsSetIssuer(); }

			public bool IsSetIssuer() { return IsSetField(Tags.Issuer); }
			public QuickFix.Fields.EncodedIssuerLen EncodedIssuerLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedIssuerLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedIssuerLen val) { this.EncodedIssuerLen = val; }

			public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) { return IsSetEncodedIssuerLen(); }

			public bool IsSetEncodedIssuerLen() { return IsSetField(Tags.EncodedIssuerLen); }
			public QuickFix.Fields.EncodedIssuer EncodedIssuer
			{
				get
				{
					var val = new QuickFix.Fields.EncodedIssuer();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedIssuer val) { this.EncodedIssuer = val; }

			public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedIssuer val) { return IsSetEncodedIssuer(); }

			public bool IsSetEncodedIssuer() { return IsSetField(Tags.EncodedIssuer); }
			public QuickFix.Fields.SecurityDesc SecurityDesc
			{
				get
				{
					var val = new QuickFix.Fields.SecurityDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityDesc val) { this.SecurityDesc = val; }

			public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityDesc val) { return IsSetSecurityDesc(); }

			public bool IsSetSecurityDesc() { return IsSetField(Tags.SecurityDesc); }
			public QuickFix.Fields.EncodedSecurityDescLen EncodedSecurityDescLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedSecurityDescLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedSecurityDescLen val) { this.EncodedSecurityDescLen = val; }

			public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) { return IsSetEncodedSecurityDescLen(); }

			public bool IsSetEncodedSecurityDescLen() { return IsSetField(Tags.EncodedSecurityDescLen); }
			public QuickFix.Fields.EncodedSecurityDesc EncodedSecurityDesc
			{
				get
				{
					var val = new QuickFix.Fields.EncodedSecurityDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedSecurityDesc val) { this.EncodedSecurityDesc = val; }

			public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) { return IsSetEncodedSecurityDesc(); }

			public bool IsSetEncodedSecurityDesc() { return IsSetField(Tags.EncodedSecurityDesc); }
			public QuickFix.Fields.Pool Pool
			{
				get
				{
					var val = new QuickFix.Fields.Pool();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Pool val) { this.Pool = val; }

			public QuickFix.Fields.Pool Get(QuickFix.Fields.Pool val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Pool val) { return IsSetPool(); }

			public bool IsSetPool() { return IsSetField(Tags.Pool); }
			public QuickFix.Fields.ContractSettlMonth ContractSettlMonth
			{
				get
				{
					var val = new QuickFix.Fields.ContractSettlMonth();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ContractSettlMonth val) { this.ContractSettlMonth = val; }

			public QuickFix.Fields.ContractSettlMonth Get(QuickFix.Fields.ContractSettlMonth val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ContractSettlMonth val) { return IsSetContractSettlMonth(); }

			public bool IsSetContractSettlMonth() { return IsSetField(Tags.ContractSettlMonth); }
			public QuickFix.Fields.CPProgram CPProgram
			{
				get
				{
					var val = new QuickFix.Fields.CPProgram();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CPProgram val) { this.CPProgram = val; }

			public QuickFix.Fields.CPProgram Get(QuickFix.Fields.CPProgram val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CPProgram val) { return IsSetCPProgram(); }

			public bool IsSetCPProgram() { return IsSetField(Tags.CPProgram); }
			public QuickFix.Fields.CPRegType CPRegType
			{
				get
				{
					var val = new QuickFix.Fields.CPRegType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CPRegType val) { this.CPRegType = val; }

			public QuickFix.Fields.CPRegType Get(QuickFix.Fields.CPRegType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CPRegType val) { return IsSetCPRegType(); }

			public bool IsSetCPRegType() { return IsSetField(Tags.CPRegType); }
			public QuickFix.Fields.NoEvents NoEvents
			{
				get
				{
					var val = new QuickFix.Fields.NoEvents();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoEvents val) { this.NoEvents = val; }

			public QuickFix.Fields.NoEvents Get(QuickFix.Fields.NoEvents val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoEvents val) { return IsSetNoEvents(); }

			public bool IsSetNoEvents() { return IsSetField(Tags.NoEvents); }
			public QuickFix.Fields.DatedDate DatedDate
			{
				get
				{
					var val = new QuickFix.Fields.DatedDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.DatedDate val) { this.DatedDate = val; }

			public QuickFix.Fields.DatedDate Get(QuickFix.Fields.DatedDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.DatedDate val) { return IsSetDatedDate(); }

			public bool IsSetDatedDate() { return IsSetField(Tags.DatedDate); }
			public QuickFix.Fields.InterestAccrualDate InterestAccrualDate
			{
				get
				{
					var val = new QuickFix.Fields.InterestAccrualDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.InterestAccrualDate val) { this.InterestAccrualDate = val; }

			public QuickFix.Fields.InterestAccrualDate Get(QuickFix.Fields.InterestAccrualDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.InterestAccrualDate val) { return IsSetInterestAccrualDate(); }

			public bool IsSetInterestAccrualDate() { return IsSetField(Tags.InterestAccrualDate); }
			public QuickFix.Fields.DeliveryForm DeliveryForm
			{
				get
				{
					var val = new QuickFix.Fields.DeliveryForm();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.DeliveryForm val) { this.DeliveryForm = val; }

			public QuickFix.Fields.DeliveryForm Get(QuickFix.Fields.DeliveryForm val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.DeliveryForm val) { return IsSetDeliveryForm(); }

			public bool IsSetDeliveryForm() { return IsSetField(Tags.DeliveryForm); }
			public QuickFix.Fields.PctAtRisk PctAtRisk
			{
				get
				{
					var val = new QuickFix.Fields.PctAtRisk();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PctAtRisk val) { this.PctAtRisk = val; }

			public QuickFix.Fields.PctAtRisk Get(QuickFix.Fields.PctAtRisk val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PctAtRisk val) { return IsSetPctAtRisk(); }

			public bool IsSetPctAtRisk() { return IsSetField(Tags.PctAtRisk); }
			public QuickFix.Fields.NoInstrAttrib NoInstrAttrib
			{
				get
				{
					var val = new QuickFix.Fields.NoInstrAttrib();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoInstrAttrib val) { this.NoInstrAttrib = val; }

			public QuickFix.Fields.NoInstrAttrib Get(QuickFix.Fields.NoInstrAttrib val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoInstrAttrib val) { return IsSetNoInstrAttrib(); }

			public bool IsSetNoInstrAttrib() { return IsSetField(Tags.NoInstrAttrib); }
			public QuickFix.Fields.AgreementDesc AgreementDesc
			{
				get
				{
					var val = new QuickFix.Fields.AgreementDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AgreementDesc val) { this.AgreementDesc = val; }

			public QuickFix.Fields.AgreementDesc Get(QuickFix.Fields.AgreementDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AgreementDesc val) { return IsSetAgreementDesc(); }

			public bool IsSetAgreementDesc() { return IsSetField(Tags.AgreementDesc); }
			public QuickFix.Fields.AgreementID AgreementID
			{
				get
				{
					var val = new QuickFix.Fields.AgreementID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AgreementID val) { this.AgreementID = val; }

			public QuickFix.Fields.AgreementID Get(QuickFix.Fields.AgreementID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AgreementID val) { return IsSetAgreementID(); }

			public bool IsSetAgreementID() { return IsSetField(Tags.AgreementID); }
			public QuickFix.Fields.AgreementDate AgreementDate
			{
				get
				{
					var val = new QuickFix.Fields.AgreementDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AgreementDate val) { this.AgreementDate = val; }

			public QuickFix.Fields.AgreementDate Get(QuickFix.Fields.AgreementDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AgreementDate val) { return IsSetAgreementDate(); }

			public bool IsSetAgreementDate() { return IsSetField(Tags.AgreementDate); }
			public QuickFix.Fields.AgreementCurrency AgreementCurrency
			{
				get
				{
					var val = new QuickFix.Fields.AgreementCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AgreementCurrency val) { this.AgreementCurrency = val; }

			public QuickFix.Fields.AgreementCurrency Get(QuickFix.Fields.AgreementCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AgreementCurrency val) { return IsSetAgreementCurrency(); }

			public bool IsSetAgreementCurrency() { return IsSetField(Tags.AgreementCurrency); }
			public QuickFix.Fields.TerminationType TerminationType
			{
				get
				{
					var val = new QuickFix.Fields.TerminationType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TerminationType val) { this.TerminationType = val; }

			public QuickFix.Fields.TerminationType Get(QuickFix.Fields.TerminationType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TerminationType val) { return IsSetTerminationType(); }

			public bool IsSetTerminationType() { return IsSetField(Tags.TerminationType); }
			public QuickFix.Fields.StartDate StartDate
			{
				get
				{
					var val = new QuickFix.Fields.StartDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StartDate val) { this.StartDate = val; }

			public QuickFix.Fields.StartDate Get(QuickFix.Fields.StartDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StartDate val) { return IsSetStartDate(); }

			public bool IsSetStartDate() { return IsSetField(Tags.StartDate); }
			public QuickFix.Fields.EndDate EndDate
			{
				get
				{
					var val = new QuickFix.Fields.EndDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EndDate val) { this.EndDate = val; }

			public QuickFix.Fields.EndDate Get(QuickFix.Fields.EndDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EndDate val) { return IsSetEndDate(); }

			public bool IsSetEndDate() { return IsSetField(Tags.EndDate); }
			public QuickFix.Fields.DeliveryType DeliveryType
			{
				get
				{
					var val = new QuickFix.Fields.DeliveryType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.DeliveryType val) { this.DeliveryType = val; }

			public QuickFix.Fields.DeliveryType Get(QuickFix.Fields.DeliveryType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.DeliveryType val) { return IsSetDeliveryType(); }

			public bool IsSetDeliveryType() { return IsSetField(Tags.DeliveryType); }
			public QuickFix.Fields.MarginRatio MarginRatio
			{
				get
				{
					var val = new QuickFix.Fields.MarginRatio();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MarginRatio val) { this.MarginRatio = val; }

			public QuickFix.Fields.MarginRatio Get(QuickFix.Fields.MarginRatio val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MarginRatio val) { return IsSetMarginRatio(); }

			public bool IsSetMarginRatio() { return IsSetField(Tags.MarginRatio); }
			public QuickFix.Fields.NoUnderlyings NoUnderlyings
			{
				get
				{
					var val = new QuickFix.Fields.NoUnderlyings();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoUnderlyings val) { this.NoUnderlyings = val; }

			public QuickFix.Fields.NoUnderlyings Get(QuickFix.Fields.NoUnderlyings val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoUnderlyings val) { return IsSetNoUnderlyings(); }

			public bool IsSetNoUnderlyings() { return IsSetField(Tags.NoUnderlyings); }
			public QuickFix.Fields.NoLegs NoLegs
			{
				get
				{
					var val = new QuickFix.Fields.NoLegs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoLegs val) { this.NoLegs = val; }

			public QuickFix.Fields.NoLegs Get(QuickFix.Fields.NoLegs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoLegs val) { return IsSetNoLegs(); }

			public bool IsSetNoLegs() { return IsSetField(Tags.NoLegs); }
			public QuickFix.Fields.Quantity Quantity
			{
				get
				{
					var val = new QuickFix.Fields.Quantity();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Quantity val) { this.Quantity = val; }

			public QuickFix.Fields.Quantity Get(QuickFix.Fields.Quantity val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Quantity val) { return IsSetQuantity(); }

			public bool IsSetQuantity() { return IsSetField(Tags.Quantity); }
			public QuickFix.Fields.QtyType QtyType
			{
				get
				{
					var val = new QuickFix.Fields.QtyType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.QtyType val) { this.QtyType = val; }

			public QuickFix.Fields.QtyType Get(QuickFix.Fields.QtyType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.QtyType val) { return IsSetQtyType(); }

			public bool IsSetQtyType() { return IsSetField(Tags.QtyType); }
			public QuickFix.Fields.LastMkt LastMkt
			{
				get
				{
					var val = new QuickFix.Fields.LastMkt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LastMkt val) { this.LastMkt = val; }

			public QuickFix.Fields.LastMkt Get(QuickFix.Fields.LastMkt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LastMkt val) { return IsSetLastMkt(); }

			public bool IsSetLastMkt() { return IsSetField(Tags.LastMkt); }
			public QuickFix.Fields.TradeOriginationDate TradeOriginationDate
			{
				get
				{
					var val = new QuickFix.Fields.TradeOriginationDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TradeOriginationDate val) { this.TradeOriginationDate = val; }

			public QuickFix.Fields.TradeOriginationDate Get(QuickFix.Fields.TradeOriginationDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TradeOriginationDate val) { return IsSetTradeOriginationDate(); }

			public bool IsSetTradeOriginationDate() { return IsSetField(Tags.TradeOriginationDate); }
			public QuickFix.Fields.TradingSessionID TradingSessionID
			{
				get
				{
					var val = new QuickFix.Fields.TradingSessionID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TradingSessionID val) { this.TradingSessionID = val; }

			public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TradingSessionID val) { return IsSetTradingSessionID(); }

			public bool IsSetTradingSessionID() { return IsSetField(Tags.TradingSessionID); }
			public QuickFix.Fields.TradingSessionSubID TradingSessionSubID
			{
				get
				{
					var val = new QuickFix.Fields.TradingSessionSubID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TradingSessionSubID val) { this.TradingSessionSubID = val; }

			public QuickFix.Fields.TradingSessionSubID Get(QuickFix.Fields.TradingSessionSubID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TradingSessionSubID val) { return IsSetTradingSessionSubID(); }

			public bool IsSetTradingSessionSubID() { return IsSetField(Tags.TradingSessionSubID); }
			public QuickFix.Fields.PriceType PriceType
			{
				get
				{
					var val = new QuickFix.Fields.PriceType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PriceType val) { this.PriceType = val; }

			public QuickFix.Fields.PriceType Get(QuickFix.Fields.PriceType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PriceType val) { return IsSetPriceType(); }

			public bool IsSetPriceType() { return IsSetField(Tags.PriceType); }
			public QuickFix.Fields.AvgPx AvgPx
			{
				get
				{
					var val = new QuickFix.Fields.AvgPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AvgPx val) { this.AvgPx = val; }

			public QuickFix.Fields.AvgPx Get(QuickFix.Fields.AvgPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AvgPx val) { return IsSetAvgPx(); }

			public bool IsSetAvgPx() { return IsSetField(Tags.AvgPx); }
			public QuickFix.Fields.AvgParPx AvgParPx
			{
				get
				{
					var val = new QuickFix.Fields.AvgParPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AvgParPx val) { this.AvgParPx = val; }

			public QuickFix.Fields.AvgParPx Get(QuickFix.Fields.AvgParPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AvgParPx val) { return IsSetAvgParPx(); }

			public bool IsSetAvgParPx() { return IsSetField(Tags.AvgParPx); }
			public QuickFix.Fields.Spread Spread
			{
				get
				{
					var val = new QuickFix.Fields.Spread();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Spread val) { this.Spread = val; }

			public QuickFix.Fields.Spread Get(QuickFix.Fields.Spread val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Spread val) { return IsSetSpread(); }

			public bool IsSetSpread() { return IsSetField(Tags.Spread); }
			public QuickFix.Fields.BenchmarkCurveCurrency BenchmarkCurveCurrency
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkCurveCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkCurveCurrency val) { this.BenchmarkCurveCurrency = val; }

			public QuickFix.Fields.BenchmarkCurveCurrency Get(QuickFix.Fields.BenchmarkCurveCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkCurveCurrency val) { return IsSetBenchmarkCurveCurrency(); }

			public bool IsSetBenchmarkCurveCurrency() { return IsSetField(Tags.BenchmarkCurveCurrency); }
			public QuickFix.Fields.BenchmarkCurveName BenchmarkCurveName
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkCurveName();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkCurveName val) { this.BenchmarkCurveName = val; }

			public QuickFix.Fields.BenchmarkCurveName Get(QuickFix.Fields.BenchmarkCurveName val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkCurveName val) { return IsSetBenchmarkCurveName(); }

			public bool IsSetBenchmarkCurveName() { return IsSetField(Tags.BenchmarkCurveName); }
			public QuickFix.Fields.BenchmarkCurvePoint BenchmarkCurvePoint
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkCurvePoint();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkCurvePoint val) { this.BenchmarkCurvePoint = val; }

			public QuickFix.Fields.BenchmarkCurvePoint Get(QuickFix.Fields.BenchmarkCurvePoint val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkCurvePoint val) { return IsSetBenchmarkCurvePoint(); }

			public bool IsSetBenchmarkCurvePoint() { return IsSetField(Tags.BenchmarkCurvePoint); }
			public QuickFix.Fields.BenchmarkPrice BenchmarkPrice
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkPrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkPrice val) { this.BenchmarkPrice = val; }

			public QuickFix.Fields.BenchmarkPrice Get(QuickFix.Fields.BenchmarkPrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkPrice val) { return IsSetBenchmarkPrice(); }

			public bool IsSetBenchmarkPrice() { return IsSetField(Tags.BenchmarkPrice); }
			public QuickFix.Fields.BenchmarkPriceType BenchmarkPriceType
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkPriceType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkPriceType val) { this.BenchmarkPriceType = val; }

			public QuickFix.Fields.BenchmarkPriceType Get(QuickFix.Fields.BenchmarkPriceType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkPriceType val) { return IsSetBenchmarkPriceType(); }

			public bool IsSetBenchmarkPriceType() { return IsSetField(Tags.BenchmarkPriceType); }
			public QuickFix.Fields.BenchmarkSecurityID BenchmarkSecurityID
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkSecurityID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkSecurityID val) { this.BenchmarkSecurityID = val; }

			public QuickFix.Fields.BenchmarkSecurityID Get(QuickFix.Fields.BenchmarkSecurityID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkSecurityID val) { return IsSetBenchmarkSecurityID(); }

			public bool IsSetBenchmarkSecurityID() { return IsSetField(Tags.BenchmarkSecurityID); }
			public QuickFix.Fields.BenchmarkSecurityIDSource BenchmarkSecurityIDSource
			{
				get
				{
					var val = new QuickFix.Fields.BenchmarkSecurityIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BenchmarkSecurityIDSource val) { this.BenchmarkSecurityIDSource = val; }

			public QuickFix.Fields.BenchmarkSecurityIDSource Get(QuickFix.Fields.BenchmarkSecurityIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BenchmarkSecurityIDSource val) { return IsSetBenchmarkSecurityIDSource(); }

			public bool IsSetBenchmarkSecurityIDSource() { return IsSetField(Tags.BenchmarkSecurityIDSource); }
			public QuickFix.Fields.Currency Currency
			{
				get
				{
					var val = new QuickFix.Fields.Currency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Currency val) { this.Currency = val; }

			public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Currency val) { return IsSetCurrency(); }

			public bool IsSetCurrency() { return IsSetField(Tags.Currency); }
			public QuickFix.Fields.AvgPxPrecision AvgPxPrecision
			{
				get
				{
					var val = new QuickFix.Fields.AvgPxPrecision();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AvgPxPrecision val) { this.AvgPxPrecision = val; }

			public QuickFix.Fields.AvgPxPrecision Get(QuickFix.Fields.AvgPxPrecision val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AvgPxPrecision val) { return IsSetAvgPxPrecision(); }

			public bool IsSetAvgPxPrecision() { return IsSetField(Tags.AvgPxPrecision); }
			public QuickFix.Fields.NoPartyIDs NoPartyIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoPartyIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoPartyIDs val) { this.NoPartyIDs = val; }

			public QuickFix.Fields.NoPartyIDs Get(QuickFix.Fields.NoPartyIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoPartyIDs val) { return IsSetNoPartyIDs(); }

			public bool IsSetNoPartyIDs() { return IsSetField(Tags.NoPartyIDs); }
			public QuickFix.Fields.TradeDate TradeDate
			{
				get
				{
					var val = new QuickFix.Fields.TradeDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TradeDate val) { this.TradeDate = val; }

			public QuickFix.Fields.TradeDate Get(QuickFix.Fields.TradeDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TradeDate val) { return IsSetTradeDate(); }

			public bool IsSetTradeDate() { return IsSetField(Tags.TradeDate); }
			public QuickFix.Fields.TransactTime TransactTime
			{
				get
				{
					var val = new QuickFix.Fields.TransactTime();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TransactTime val) { this.TransactTime = val; }

			public QuickFix.Fields.TransactTime Get(QuickFix.Fields.TransactTime val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TransactTime val) { return IsSetTransactTime(); }

			public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }
			public QuickFix.Fields.SettlType SettlType
			{
				get
				{
					var val = new QuickFix.Fields.SettlType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlType val) { this.SettlType = val; }

			public QuickFix.Fields.SettlType Get(QuickFix.Fields.SettlType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlType val) { return IsSetSettlType(); }

			public bool IsSetSettlType() { return IsSetField(Tags.SettlType); }
			public QuickFix.Fields.SettlDate SettlDate
			{
				get
				{
					var val = new QuickFix.Fields.SettlDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlDate val) { this.SettlDate = val; }

			public QuickFix.Fields.SettlDate Get(QuickFix.Fields.SettlDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlDate val) { return IsSetSettlDate(); }

			public bool IsSetSettlDate() { return IsSetField(Tags.SettlDate); }
			public QuickFix.Fields.BookingType BookingType
			{
				get
				{
					var val = new QuickFix.Fields.BookingType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BookingType val) { this.BookingType = val; }

			public QuickFix.Fields.BookingType Get(QuickFix.Fields.BookingType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BookingType val) { return IsSetBookingType(); }

			public bool IsSetBookingType() { return IsSetField(Tags.BookingType); }
			public QuickFix.Fields.GrossTradeAmt GrossTradeAmt
			{
				get
				{
					var val = new QuickFix.Fields.GrossTradeAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.GrossTradeAmt val) { this.GrossTradeAmt = val; }

			public QuickFix.Fields.GrossTradeAmt Get(QuickFix.Fields.GrossTradeAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.GrossTradeAmt val) { return IsSetGrossTradeAmt(); }

			public bool IsSetGrossTradeAmt() { return IsSetField(Tags.GrossTradeAmt); }
			public QuickFix.Fields.Concession Concession
			{
				get
				{
					var val = new QuickFix.Fields.Concession();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Concession val) { this.Concession = val; }

			public QuickFix.Fields.Concession Get(QuickFix.Fields.Concession val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Concession val) { return IsSetConcession(); }

			public bool IsSetConcession() { return IsSetField(Tags.Concession); }
			public QuickFix.Fields.TotalTakedown TotalTakedown
			{
				get
				{
					var val = new QuickFix.Fields.TotalTakedown();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TotalTakedown val) { this.TotalTakedown = val; }

			public QuickFix.Fields.TotalTakedown Get(QuickFix.Fields.TotalTakedown val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TotalTakedown val) { return IsSetTotalTakedown(); }

			public bool IsSetTotalTakedown() { return IsSetField(Tags.TotalTakedown); }
			public QuickFix.Fields.NetMoney NetMoney
			{
				get
				{
					var val = new QuickFix.Fields.NetMoney();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NetMoney val) { this.NetMoney = val; }

			public QuickFix.Fields.NetMoney Get(QuickFix.Fields.NetMoney val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NetMoney val) { return IsSetNetMoney(); }

			public bool IsSetNetMoney() { return IsSetField(Tags.NetMoney); }
			public QuickFix.Fields.PositionEffect PositionEffect
			{
				get
				{
					var val = new QuickFix.Fields.PositionEffect();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PositionEffect val) { this.PositionEffect = val; }

			public QuickFix.Fields.PositionEffect Get(QuickFix.Fields.PositionEffect val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PositionEffect val) { return IsSetPositionEffect(); }

			public bool IsSetPositionEffect() { return IsSetField(Tags.PositionEffect); }
			public QuickFix.Fields.AutoAcceptIndicator AutoAcceptIndicator
			{
				get
				{
					var val = new QuickFix.Fields.AutoAcceptIndicator();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AutoAcceptIndicator val) { this.AutoAcceptIndicator = val; }

			public QuickFix.Fields.AutoAcceptIndicator Get(QuickFix.Fields.AutoAcceptIndicator val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AutoAcceptIndicator val) { return IsSetAutoAcceptIndicator(); }

			public bool IsSetAutoAcceptIndicator() { return IsSetField(Tags.AutoAcceptIndicator); }
			public QuickFix.Fields.Text Text
			{
				get
				{
					var val = new QuickFix.Fields.Text();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Text val) { this.Text = val; }

			public QuickFix.Fields.Text Get(QuickFix.Fields.Text val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Text val) { return IsSetText(); }

			public bool IsSetText() { return IsSetField(Tags.Text); }
			public QuickFix.Fields.EncodedTextLen EncodedTextLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedTextLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedTextLen val) { this.EncodedTextLen = val; }

			public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedTextLen val) { return IsSetEncodedTextLen(); }

			public bool IsSetEncodedTextLen() { return IsSetField(Tags.EncodedTextLen); }
			public QuickFix.Fields.EncodedText EncodedText
			{
				get
				{
					var val = new QuickFix.Fields.EncodedText();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedText val) { this.EncodedText = val; }

			public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedText val) { return IsSetEncodedText(); }

			public bool IsSetEncodedText() { return IsSetField(Tags.EncodedText); }
			public QuickFix.Fields.NumDaysInterest NumDaysInterest
			{
				get
				{
					var val = new QuickFix.Fields.NumDaysInterest();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NumDaysInterest val) { this.NumDaysInterest = val; }

			public QuickFix.Fields.NumDaysInterest Get(QuickFix.Fields.NumDaysInterest val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NumDaysInterest val) { return IsSetNumDaysInterest(); }

			public bool IsSetNumDaysInterest() { return IsSetField(Tags.NumDaysInterest); }
			public QuickFix.Fields.AccruedInterestRate AccruedInterestRate
			{
				get
				{
					var val = new QuickFix.Fields.AccruedInterestRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AccruedInterestRate val) { this.AccruedInterestRate = val; }

			public QuickFix.Fields.AccruedInterestRate Get(QuickFix.Fields.AccruedInterestRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AccruedInterestRate val) { return IsSetAccruedInterestRate(); }

			public bool IsSetAccruedInterestRate() { return IsSetField(Tags.AccruedInterestRate); }
			public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
			{
				get
				{
					var val = new QuickFix.Fields.AccruedInterestAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AccruedInterestAmt val) { this.AccruedInterestAmt = val; }

			public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AccruedInterestAmt val) { return IsSetAccruedInterestAmt(); }

			public bool IsSetAccruedInterestAmt() { return IsSetField(Tags.AccruedInterestAmt); }
			public QuickFix.Fields.TotalAccruedInterestAmt TotalAccruedInterestAmt
			{
				get
				{
					var val = new QuickFix.Fields.TotalAccruedInterestAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TotalAccruedInterestAmt val) { this.TotalAccruedInterestAmt = val; }

			public QuickFix.Fields.TotalAccruedInterestAmt Get(QuickFix.Fields.TotalAccruedInterestAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TotalAccruedInterestAmt val) { return IsSetTotalAccruedInterestAmt(); }

			public bool IsSetTotalAccruedInterestAmt() { return IsSetField(Tags.TotalAccruedInterestAmt); }
			public QuickFix.Fields.InterestAtMaturity InterestAtMaturity
			{
				get
				{
					var val = new QuickFix.Fields.InterestAtMaturity();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.InterestAtMaturity val) { this.InterestAtMaturity = val; }

			public QuickFix.Fields.InterestAtMaturity Get(QuickFix.Fields.InterestAtMaturity val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.InterestAtMaturity val) { return IsSetInterestAtMaturity(); }

			public bool IsSetInterestAtMaturity() { return IsSetField(Tags.InterestAtMaturity); }
			public QuickFix.Fields.EndAccruedInterestAmt EndAccruedInterestAmt
			{
				get
				{
					var val = new QuickFix.Fields.EndAccruedInterestAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EndAccruedInterestAmt val) { this.EndAccruedInterestAmt = val; }

			public QuickFix.Fields.EndAccruedInterestAmt Get(QuickFix.Fields.EndAccruedInterestAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EndAccruedInterestAmt val) { return IsSetEndAccruedInterestAmt(); }

			public bool IsSetEndAccruedInterestAmt() { return IsSetField(Tags.EndAccruedInterestAmt); }
			public QuickFix.Fields.StartCash StartCash
			{
				get
				{
					var val = new QuickFix.Fields.StartCash();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StartCash val) { this.StartCash = val; }

			public QuickFix.Fields.StartCash Get(QuickFix.Fields.StartCash val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StartCash val) { return IsSetStartCash(); }

			public bool IsSetStartCash() { return IsSetField(Tags.StartCash); }
			public QuickFix.Fields.EndCash EndCash
			{
				get
				{
					var val = new QuickFix.Fields.EndCash();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EndCash val) { this.EndCash = val; }

			public QuickFix.Fields.EndCash Get(QuickFix.Fields.EndCash val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EndCash val) { return IsSetEndCash(); }

			public bool IsSetEndCash() { return IsSetField(Tags.EndCash); }
			public QuickFix.Fields.LegalConfirm LegalConfirm
			{
				get
				{
					var val = new QuickFix.Fields.LegalConfirm();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegalConfirm val) { this.LegalConfirm = val; }

			public QuickFix.Fields.LegalConfirm Get(QuickFix.Fields.LegalConfirm val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegalConfirm val) { return IsSetLegalConfirm(); }

			public bool IsSetLegalConfirm() { return IsSetField(Tags.LegalConfirm); }
			public QuickFix.Fields.NoStipulations NoStipulations
			{
				get
				{
					var val = new QuickFix.Fields.NoStipulations();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoStipulations val) { this.NoStipulations = val; }

			public QuickFix.Fields.NoStipulations Get(QuickFix.Fields.NoStipulations val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoStipulations val) { return IsSetNoStipulations(); }

			public bool IsSetNoStipulations() { return IsSetField(Tags.NoStipulations); }
			public QuickFix.Fields.YieldType YieldType
			{
				get
				{
					var val = new QuickFix.Fields.YieldType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.YieldType val) { this.YieldType = val; }

			public QuickFix.Fields.YieldType Get(QuickFix.Fields.YieldType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.YieldType val) { return IsSetYieldType(); }

			public bool IsSetYieldType() { return IsSetField(Tags.YieldType); }
			public QuickFix.Fields.Yield Yield
			{
				get
				{
					var val = new QuickFix.Fields.Yield();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Yield val) { this.Yield = val; }

			public QuickFix.Fields.Yield Get(QuickFix.Fields.Yield val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Yield val) { return IsSetYield(); }

			public bool IsSetYield() { return IsSetField(Tags.Yield); }
			public QuickFix.Fields.YieldCalcDate YieldCalcDate
			{
				get
				{
					var val = new QuickFix.Fields.YieldCalcDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.YieldCalcDate val) { this.YieldCalcDate = val; }

			public QuickFix.Fields.YieldCalcDate Get(QuickFix.Fields.YieldCalcDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.YieldCalcDate val) { return IsSetYieldCalcDate(); }

			public bool IsSetYieldCalcDate() { return IsSetField(Tags.YieldCalcDate); }
			public QuickFix.Fields.YieldRedemptionDate YieldRedemptionDate
			{
				get
				{
					var val = new QuickFix.Fields.YieldRedemptionDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.YieldRedemptionDate val) { this.YieldRedemptionDate = val; }

			public QuickFix.Fields.YieldRedemptionDate Get(QuickFix.Fields.YieldRedemptionDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.YieldRedemptionDate val) { return IsSetYieldRedemptionDate(); }

			public bool IsSetYieldRedemptionDate() { return IsSetField(Tags.YieldRedemptionDate); }
			public QuickFix.Fields.YieldRedemptionPrice YieldRedemptionPrice
			{
				get
				{
					var val = new QuickFix.Fields.YieldRedemptionPrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.YieldRedemptionPrice val) { this.YieldRedemptionPrice = val; }

			public QuickFix.Fields.YieldRedemptionPrice Get(QuickFix.Fields.YieldRedemptionPrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.YieldRedemptionPrice val) { return IsSetYieldRedemptionPrice(); }

			public bool IsSetYieldRedemptionPrice() { return IsSetField(Tags.YieldRedemptionPrice); }
			public QuickFix.Fields.YieldRedemptionPriceType YieldRedemptionPriceType
			{
				get
				{
					var val = new QuickFix.Fields.YieldRedemptionPriceType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.YieldRedemptionPriceType val) { this.YieldRedemptionPriceType = val; }

			public QuickFix.Fields.YieldRedemptionPriceType Get(QuickFix.Fields.YieldRedemptionPriceType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.YieldRedemptionPriceType val) { return IsSetYieldRedemptionPriceType(); }

			public bool IsSetYieldRedemptionPriceType() { return IsSetField(Tags.YieldRedemptionPriceType); }
			public QuickFix.Fields.TotNoAllocs TotNoAllocs
			{
				get
				{
					var val = new QuickFix.Fields.TotNoAllocs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.TotNoAllocs val) { this.TotNoAllocs = val; }

			public QuickFix.Fields.TotNoAllocs Get(QuickFix.Fields.TotNoAllocs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.TotNoAllocs val) { return IsSetTotNoAllocs(); }

			public bool IsSetTotNoAllocs() { return IsSetField(Tags.TotNoAllocs); }
			public QuickFix.Fields.LastFragment LastFragment
			{
				get
				{
					var val = new QuickFix.Fields.LastFragment();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LastFragment val) { this.LastFragment = val; }

			public QuickFix.Fields.LastFragment Get(QuickFix.Fields.LastFragment val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LastFragment val) { return IsSetLastFragment(); }

			public bool IsSetLastFragment() { return IsSetField(Tags.LastFragment); }
			public QuickFix.Fields.NoAllocs NoAllocs
			{
				get
				{
					var val = new QuickFix.Fields.NoAllocs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoAllocs val) { this.NoAllocs = val; }

			public QuickFix.Fields.NoAllocs Get(QuickFix.Fields.NoAllocs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoAllocs val) { return IsSetNoAllocs(); }

			public bool IsSetNoAllocs() { return IsSetField(Tags.NoAllocs); }

			public class NoOrdersGroup : Group
			{
				public static int[] fieldOrder = {Tags.ClOrdID, Tags.OrderID, Tags.SecondaryOrderID, Tags.SecondaryClOrdID, Tags.ListID, Tags.NoNested2PartyIDs, Tags.OrderQty, Tags.OrderAvgPx, Tags.OrderBookingQty, 0};

				public NoOrdersGroup() : base(Tags.NoOrders, Tags.ClOrdID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoOrdersGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.ClOrdID ClOrdID
			{
				get
				{
					var val = new QuickFix.Fields.ClOrdID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ClOrdID val) { this.ClOrdID = val; }

			public QuickFix.Fields.ClOrdID Get(QuickFix.Fields.ClOrdID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ClOrdID val) { return IsSetClOrdID(); }

			public bool IsSetClOrdID() { return IsSetField(Tags.ClOrdID); }
			public QuickFix.Fields.OrderID OrderID
			{
				get
				{
					var val = new QuickFix.Fields.OrderID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.OrderID val) { this.OrderID = val; }

			public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.OrderID val) { return IsSetOrderID(); }

			public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }
			public QuickFix.Fields.SecondaryOrderID SecondaryOrderID
			{
				get
				{
					var val = new QuickFix.Fields.SecondaryOrderID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecondaryOrderID val) { this.SecondaryOrderID = val; }

			public QuickFix.Fields.SecondaryOrderID Get(QuickFix.Fields.SecondaryOrderID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecondaryOrderID val) { return IsSetSecondaryOrderID(); }

			public bool IsSetSecondaryOrderID() { return IsSetField(Tags.SecondaryOrderID); }
			public QuickFix.Fields.SecondaryClOrdID SecondaryClOrdID
			{
				get
				{
					var val = new QuickFix.Fields.SecondaryClOrdID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecondaryClOrdID val) { this.SecondaryClOrdID = val; }

			public QuickFix.Fields.SecondaryClOrdID Get(QuickFix.Fields.SecondaryClOrdID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecondaryClOrdID val) { return IsSetSecondaryClOrdID(); }

			public bool IsSetSecondaryClOrdID() { return IsSetField(Tags.SecondaryClOrdID); }
			public QuickFix.Fields.ListID ListID
			{
				get
				{
					var val = new QuickFix.Fields.ListID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ListID val) { this.ListID = val; }

			public QuickFix.Fields.ListID Get(QuickFix.Fields.ListID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ListID val) { return IsSetListID(); }

			public bool IsSetListID() { return IsSetField(Tags.ListID); }
			public QuickFix.Fields.NoNested2PartyIDs NoNested2PartyIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoNested2PartyIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoNested2PartyIDs val) { this.NoNested2PartyIDs = val; }

			public QuickFix.Fields.NoNested2PartyIDs Get(QuickFix.Fields.NoNested2PartyIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoNested2PartyIDs val) { return IsSetNoNested2PartyIDs(); }

			public bool IsSetNoNested2PartyIDs() { return IsSetField(Tags.NoNested2PartyIDs); }
			public QuickFix.Fields.OrderQty OrderQty
			{
				get
				{
					var val = new QuickFix.Fields.OrderQty();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.OrderQty val) { this.OrderQty = val; }

			public QuickFix.Fields.OrderQty Get(QuickFix.Fields.OrderQty val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.OrderQty val) { return IsSetOrderQty(); }

			public bool IsSetOrderQty() { return IsSetField(Tags.OrderQty); }
			public QuickFix.Fields.OrderAvgPx OrderAvgPx
			{
				get
				{
					var val = new QuickFix.Fields.OrderAvgPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.OrderAvgPx val) { this.OrderAvgPx = val; }

			public QuickFix.Fields.OrderAvgPx Get(QuickFix.Fields.OrderAvgPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.OrderAvgPx val) { return IsSetOrderAvgPx(); }

			public bool IsSetOrderAvgPx() { return IsSetField(Tags.OrderAvgPx); }
			public QuickFix.Fields.OrderBookingQty OrderBookingQty
			{
				get
				{
					var val = new QuickFix.Fields.OrderBookingQty();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.OrderBookingQty val) { this.OrderBookingQty = val; }

			public QuickFix.Fields.OrderBookingQty Get(QuickFix.Fields.OrderBookingQty val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.OrderBookingQty val) { return IsSetOrderBookingQty(); }

			public bool IsSetOrderBookingQty() { return IsSetField(Tags.OrderBookingQty); }

			public class NoNested2PartyIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.Nested2PartyID, Tags.Nested2PartyIDSource, Tags.Nested2PartyRole, Tags.NoNested2PartySubIDs, 0};

				public NoNested2PartyIDsGroup() : base(Tags.NoNested2PartyIDs, Tags.Nested2PartyID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoNested2PartyIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.Nested2PartyID Nested2PartyID
			{
				get
				{
					var val = new QuickFix.Fields.Nested2PartyID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Nested2PartyID val) { this.Nested2PartyID = val; }

			public QuickFix.Fields.Nested2PartyID Get(QuickFix.Fields.Nested2PartyID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Nested2PartyID val) { return IsSetNested2PartyID(); }

			public bool IsSetNested2PartyID() { return IsSetField(Tags.Nested2PartyID); }
			public QuickFix.Fields.Nested2PartyIDSource Nested2PartyIDSource
			{
				get
				{
					var val = new QuickFix.Fields.Nested2PartyIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Nested2PartyIDSource val) { this.Nested2PartyIDSource = val; }

			public QuickFix.Fields.Nested2PartyIDSource Get(QuickFix.Fields.Nested2PartyIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Nested2PartyIDSource val) { return IsSetNested2PartyIDSource(); }

			public bool IsSetNested2PartyIDSource() { return IsSetField(Tags.Nested2PartyIDSource); }
			public QuickFix.Fields.Nested2PartyRole Nested2PartyRole
			{
				get
				{
					var val = new QuickFix.Fields.Nested2PartyRole();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Nested2PartyRole val) { this.Nested2PartyRole = val; }

			public QuickFix.Fields.Nested2PartyRole Get(QuickFix.Fields.Nested2PartyRole val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Nested2PartyRole val) { return IsSetNested2PartyRole(); }

			public bool IsSetNested2PartyRole() { return IsSetField(Tags.Nested2PartyRole); }
			public QuickFix.Fields.NoNested2PartySubIDs NoNested2PartySubIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoNested2PartySubIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoNested2PartySubIDs val) { this.NoNested2PartySubIDs = val; }

			public QuickFix.Fields.NoNested2PartySubIDs Get(QuickFix.Fields.NoNested2PartySubIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoNested2PartySubIDs val) { return IsSetNoNested2PartySubIDs(); }

			public bool IsSetNoNested2PartySubIDs() { return IsSetField(Tags.NoNested2PartySubIDs); }

			public class NoNested2PartySubIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.Nested2PartySubID, Tags.Nested2PartySubIDType, 0};

				public NoNested2PartySubIDsGroup() : base(Tags.NoNested2PartySubIDs, Tags.Nested2PartySubID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoNested2PartySubIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.Nested2PartySubID Nested2PartySubID
			{
				get
				{
					var val = new QuickFix.Fields.Nested2PartySubID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Nested2PartySubID val) { this.Nested2PartySubID = val; }

			public QuickFix.Fields.Nested2PartySubID Get(QuickFix.Fields.Nested2PartySubID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Nested2PartySubID val) { return IsSetNested2PartySubID(); }

			public bool IsSetNested2PartySubID() { return IsSetField(Tags.Nested2PartySubID); }
			public QuickFix.Fields.Nested2PartySubIDType Nested2PartySubIDType
			{
				get
				{
					var val = new QuickFix.Fields.Nested2PartySubIDType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Nested2PartySubIDType val) { this.Nested2PartySubIDType = val; }

			public QuickFix.Fields.Nested2PartySubIDType Get(QuickFix.Fields.Nested2PartySubIDType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Nested2PartySubIDType val) { return IsSetNested2PartySubIDType(); }

			public bool IsSetNested2PartySubIDType() { return IsSetField(Tags.Nested2PartySubIDType); }

			}
			}
			}
			public class NoExecsGroup : Group
			{
				public static int[] fieldOrder = {Tags.LastQty, Tags.ExecID, Tags.SecondaryExecID, Tags.LastPx, Tags.LastParPx, Tags.LastCapacity, 0};

				public NoExecsGroup() : base(Tags.NoExecs, Tags.LastQty, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoExecsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.LastQty LastQty
			{
				get
				{
					var val = new QuickFix.Fields.LastQty();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LastQty val) { this.LastQty = val; }

			public QuickFix.Fields.LastQty Get(QuickFix.Fields.LastQty val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LastQty val) { return IsSetLastQty(); }

			public bool IsSetLastQty() { return IsSetField(Tags.LastQty); }
			public QuickFix.Fields.ExecID ExecID
			{
				get
				{
					var val = new QuickFix.Fields.ExecID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ExecID val) { this.ExecID = val; }

			public QuickFix.Fields.ExecID Get(QuickFix.Fields.ExecID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ExecID val) { return IsSetExecID(); }

			public bool IsSetExecID() { return IsSetField(Tags.ExecID); }
			public QuickFix.Fields.SecondaryExecID SecondaryExecID
			{
				get
				{
					var val = new QuickFix.Fields.SecondaryExecID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecondaryExecID val) { this.SecondaryExecID = val; }

			public QuickFix.Fields.SecondaryExecID Get(QuickFix.Fields.SecondaryExecID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecondaryExecID val) { return IsSetSecondaryExecID(); }

			public bool IsSetSecondaryExecID() { return IsSetField(Tags.SecondaryExecID); }
			public QuickFix.Fields.LastPx LastPx
			{
				get
				{
					var val = new QuickFix.Fields.LastPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LastPx val) { this.LastPx = val; }

			public QuickFix.Fields.LastPx Get(QuickFix.Fields.LastPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LastPx val) { return IsSetLastPx(); }

			public bool IsSetLastPx() { return IsSetField(Tags.LastPx); }
			public QuickFix.Fields.LastParPx LastParPx
			{
				get
				{
					var val = new QuickFix.Fields.LastParPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LastParPx val) { this.LastParPx = val; }

			public QuickFix.Fields.LastParPx Get(QuickFix.Fields.LastParPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LastParPx val) { return IsSetLastParPx(); }

			public bool IsSetLastParPx() { return IsSetField(Tags.LastParPx); }
			public QuickFix.Fields.LastCapacity LastCapacity
			{
				get
				{
					var val = new QuickFix.Fields.LastCapacity();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LastCapacity val) { this.LastCapacity = val; }

			public QuickFix.Fields.LastCapacity Get(QuickFix.Fields.LastCapacity val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LastCapacity val) { return IsSetLastCapacity(); }

			public bool IsSetLastCapacity() { return IsSetField(Tags.LastCapacity); }

			}
			public class NoSecurityAltIDGroup : Group
			{
				public static int[] fieldOrder = {Tags.SecurityAltID, Tags.SecurityAltIDSource, 0};

				public NoSecurityAltIDGroup() : base(Tags.NoSecurityAltID, Tags.SecurityAltID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoSecurityAltIDGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.SecurityAltID SecurityAltID
			{
				get
				{
					var val = new QuickFix.Fields.SecurityAltID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityAltID val) { this.SecurityAltID = val; }

			public QuickFix.Fields.SecurityAltID Get(QuickFix.Fields.SecurityAltID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityAltID val) { return IsSetSecurityAltID(); }

			public bool IsSetSecurityAltID() { return IsSetField(Tags.SecurityAltID); }
			public QuickFix.Fields.SecurityAltIDSource SecurityAltIDSource
			{
				get
				{
					var val = new QuickFix.Fields.SecurityAltIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityAltIDSource val) { this.SecurityAltIDSource = val; }

			public QuickFix.Fields.SecurityAltIDSource Get(QuickFix.Fields.SecurityAltIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityAltIDSource val) { return IsSetSecurityAltIDSource(); }

			public bool IsSetSecurityAltIDSource() { return IsSetField(Tags.SecurityAltIDSource); }

			}
			public class NoEventsGroup : Group
			{
				public static int[] fieldOrder = {Tags.EventType, Tags.EventDate, Tags.EventPx, Tags.EventText, 0};

				public NoEventsGroup() : base(Tags.NoEvents, Tags.EventType, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoEventsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.EventType EventType
			{
				get
				{
					var val = new QuickFix.Fields.EventType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EventType val) { this.EventType = val; }

			public QuickFix.Fields.EventType Get(QuickFix.Fields.EventType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EventType val) { return IsSetEventType(); }

			public bool IsSetEventType() { return IsSetField(Tags.EventType); }
			public QuickFix.Fields.EventDate EventDate
			{
				get
				{
					var val = new QuickFix.Fields.EventDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EventDate val) { this.EventDate = val; }

			public QuickFix.Fields.EventDate Get(QuickFix.Fields.EventDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EventDate val) { return IsSetEventDate(); }

			public bool IsSetEventDate() { return IsSetField(Tags.EventDate); }
			public QuickFix.Fields.EventPx EventPx
			{
				get
				{
					var val = new QuickFix.Fields.EventPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EventPx val) { this.EventPx = val; }

			public QuickFix.Fields.EventPx Get(QuickFix.Fields.EventPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EventPx val) { return IsSetEventPx(); }

			public bool IsSetEventPx() { return IsSetField(Tags.EventPx); }
			public QuickFix.Fields.EventText EventText
			{
				get
				{
					var val = new QuickFix.Fields.EventText();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EventText val) { this.EventText = val; }

			public QuickFix.Fields.EventText Get(QuickFix.Fields.EventText val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EventText val) { return IsSetEventText(); }

			public bool IsSetEventText() { return IsSetField(Tags.EventText); }

			}
			public class NoInstrAttribGroup : Group
			{
				public static int[] fieldOrder = {Tags.InstrAttribType, Tags.InstrAttribValue, 0};

				public NoInstrAttribGroup() : base(Tags.NoInstrAttrib, Tags.InstrAttribType, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoInstrAttribGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.InstrAttribType InstrAttribType
			{
				get
				{
					var val = new QuickFix.Fields.InstrAttribType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.InstrAttribType val) { this.InstrAttribType = val; }

			public QuickFix.Fields.InstrAttribType Get(QuickFix.Fields.InstrAttribType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.InstrAttribType val) { return IsSetInstrAttribType(); }

			public bool IsSetInstrAttribType() { return IsSetField(Tags.InstrAttribType); }
			public QuickFix.Fields.InstrAttribValue InstrAttribValue
			{
				get
				{
					var val = new QuickFix.Fields.InstrAttribValue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.InstrAttribValue val) { this.InstrAttribValue = val; }

			public QuickFix.Fields.InstrAttribValue Get(QuickFix.Fields.InstrAttribValue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.InstrAttribValue val) { return IsSetInstrAttribValue(); }

			public bool IsSetInstrAttribValue() { return IsSetField(Tags.InstrAttribValue); }

			}
			public class NoUnderlyingsGroup : Group
			{
				public static int[] fieldOrder = {Tags.UnderlyingSymbol, Tags.UnderlyingSymbolSfx, Tags.UnderlyingSecurityID, Tags.UnderlyingSecurityIDSource, Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingProduct, Tags.UnderlyingCFICode, Tags.UnderlyingSecurityType, Tags.UnderlyingSecuritySubType, Tags.UnderlyingMaturityMonthYear, Tags.UnderlyingMaturityDate, Tags.UnderlyingPutOrCall, Tags.UnderlyingCouponPaymentDate, Tags.UnderlyingIssueDate, Tags.UnderlyingRepoCollateralSecurityType, Tags.UnderlyingRepurchaseTerm, Tags.UnderlyingRepurchaseRate, Tags.UnderlyingFactor, Tags.UnderlyingCreditRating, Tags.UnderlyingInstrRegistry, Tags.UnderlyingCountryOfIssue, Tags.UnderlyingStateOrProvinceOfIssue, Tags.UnderlyingLocaleOfIssue, Tags.UnderlyingRedemptionDate, Tags.UnderlyingStrikePrice, Tags.UnderlyingStrikeCurrency, Tags.UnderlyingOptAttribute, Tags.UnderlyingContractMultiplier, Tags.UnderlyingCouponRate, Tags.UnderlyingSecurityExchange, Tags.UnderlyingIssuer, Tags.EncodedUnderlyingIssuerLen, Tags.EncodedUnderlyingIssuer, Tags.UnderlyingSecurityDesc, Tags.EncodedUnderlyingSecurityDescLen, Tags.EncodedUnderlyingSecurityDesc, Tags.UnderlyingCPProgram, Tags.UnderlyingCPRegType, Tags.UnderlyingCurrency, Tags.UnderlyingQty, Tags.UnderlyingPx, Tags.UnderlyingDirtyPrice, Tags.UnderlyingEndPrice, Tags.UnderlyingStartValue, Tags.UnderlyingCurrentValue, Tags.UnderlyingEndValue, Tags.NoUnderlyingStips, 0};

				public NoUnderlyingsGroup() : base(Tags.NoUnderlyings, Tags.UnderlyingSymbol, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoUnderlyingsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.UnderlyingSymbol UnderlyingSymbol
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSymbol();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSymbol val) { this.UnderlyingSymbol = val; }

			public QuickFix.Fields.UnderlyingSymbol Get(QuickFix.Fields.UnderlyingSymbol val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSymbol val) { return IsSetUnderlyingSymbol(); }

			public bool IsSetUnderlyingSymbol() { return IsSetField(Tags.UnderlyingSymbol); }
			public QuickFix.Fields.UnderlyingSymbolSfx UnderlyingSymbolSfx
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSymbolSfx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSymbolSfx val) { this.UnderlyingSymbolSfx = val; }

			public QuickFix.Fields.UnderlyingSymbolSfx Get(QuickFix.Fields.UnderlyingSymbolSfx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSymbolSfx val) { return IsSetUnderlyingSymbolSfx(); }

			public bool IsSetUnderlyingSymbolSfx() { return IsSetField(Tags.UnderlyingSymbolSfx); }
			public QuickFix.Fields.UnderlyingSecurityID UnderlyingSecurityID
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityID val) { this.UnderlyingSecurityID = val; }

			public QuickFix.Fields.UnderlyingSecurityID Get(QuickFix.Fields.UnderlyingSecurityID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityID val) { return IsSetUnderlyingSecurityID(); }

			public bool IsSetUnderlyingSecurityID() { return IsSetField(Tags.UnderlyingSecurityID); }
			public QuickFix.Fields.UnderlyingSecurityIDSource UnderlyingSecurityIDSource
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityIDSource val) { this.UnderlyingSecurityIDSource = val; }

			public QuickFix.Fields.UnderlyingSecurityIDSource Get(QuickFix.Fields.UnderlyingSecurityIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityIDSource val) { return IsSetUnderlyingSecurityIDSource(); }

			public bool IsSetUnderlyingSecurityIDSource() { return IsSetField(Tags.UnderlyingSecurityIDSource); }
			public QuickFix.Fields.NoUnderlyingSecurityAltID NoUnderlyingSecurityAltID
			{
				get
				{
					var val = new QuickFix.Fields.NoUnderlyingSecurityAltID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoUnderlyingSecurityAltID val) { this.NoUnderlyingSecurityAltID = val; }

			public QuickFix.Fields.NoUnderlyingSecurityAltID Get(QuickFix.Fields.NoUnderlyingSecurityAltID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoUnderlyingSecurityAltID val) { return IsSetNoUnderlyingSecurityAltID(); }

			public bool IsSetNoUnderlyingSecurityAltID() { return IsSetField(Tags.NoUnderlyingSecurityAltID); }
			public QuickFix.Fields.UnderlyingProduct UnderlyingProduct
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingProduct();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingProduct val) { this.UnderlyingProduct = val; }

			public QuickFix.Fields.UnderlyingProduct Get(QuickFix.Fields.UnderlyingProduct val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingProduct val) { return IsSetUnderlyingProduct(); }

			public bool IsSetUnderlyingProduct() { return IsSetField(Tags.UnderlyingProduct); }
			public QuickFix.Fields.UnderlyingCFICode UnderlyingCFICode
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCFICode();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCFICode val) { this.UnderlyingCFICode = val; }

			public QuickFix.Fields.UnderlyingCFICode Get(QuickFix.Fields.UnderlyingCFICode val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCFICode val) { return IsSetUnderlyingCFICode(); }

			public bool IsSetUnderlyingCFICode() { return IsSetField(Tags.UnderlyingCFICode); }
			public QuickFix.Fields.UnderlyingSecurityType UnderlyingSecurityType
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityType val) { this.UnderlyingSecurityType = val; }

			public QuickFix.Fields.UnderlyingSecurityType Get(QuickFix.Fields.UnderlyingSecurityType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityType val) { return IsSetUnderlyingSecurityType(); }

			public bool IsSetUnderlyingSecurityType() { return IsSetField(Tags.UnderlyingSecurityType); }
			public QuickFix.Fields.UnderlyingSecuritySubType UnderlyingSecuritySubType
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecuritySubType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecuritySubType val) { this.UnderlyingSecuritySubType = val; }

			public QuickFix.Fields.UnderlyingSecuritySubType Get(QuickFix.Fields.UnderlyingSecuritySubType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecuritySubType val) { return IsSetUnderlyingSecuritySubType(); }

			public bool IsSetUnderlyingSecuritySubType() { return IsSetField(Tags.UnderlyingSecuritySubType); }
			public QuickFix.Fields.UnderlyingMaturityMonthYear UnderlyingMaturityMonthYear
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingMaturityMonthYear();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingMaturityMonthYear val) { this.UnderlyingMaturityMonthYear = val; }

			public QuickFix.Fields.UnderlyingMaturityMonthYear Get(QuickFix.Fields.UnderlyingMaturityMonthYear val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingMaturityMonthYear val) { return IsSetUnderlyingMaturityMonthYear(); }

			public bool IsSetUnderlyingMaturityMonthYear() { return IsSetField(Tags.UnderlyingMaturityMonthYear); }
			public QuickFix.Fields.UnderlyingMaturityDate UnderlyingMaturityDate
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingMaturityDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingMaturityDate val) { this.UnderlyingMaturityDate = val; }

			public QuickFix.Fields.UnderlyingMaturityDate Get(QuickFix.Fields.UnderlyingMaturityDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingMaturityDate val) { return IsSetUnderlyingMaturityDate(); }

			public bool IsSetUnderlyingMaturityDate() { return IsSetField(Tags.UnderlyingMaturityDate); }
			public QuickFix.Fields.UnderlyingPutOrCall UnderlyingPutOrCall
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingPutOrCall();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingPutOrCall val) { this.UnderlyingPutOrCall = val; }

			public QuickFix.Fields.UnderlyingPutOrCall Get(QuickFix.Fields.UnderlyingPutOrCall val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingPutOrCall val) { return IsSetUnderlyingPutOrCall(); }

			public bool IsSetUnderlyingPutOrCall() { return IsSetField(Tags.UnderlyingPutOrCall); }
			public QuickFix.Fields.UnderlyingCouponPaymentDate UnderlyingCouponPaymentDate
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCouponPaymentDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCouponPaymentDate val) { this.UnderlyingCouponPaymentDate = val; }

			public QuickFix.Fields.UnderlyingCouponPaymentDate Get(QuickFix.Fields.UnderlyingCouponPaymentDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCouponPaymentDate val) { return IsSetUnderlyingCouponPaymentDate(); }

			public bool IsSetUnderlyingCouponPaymentDate() { return IsSetField(Tags.UnderlyingCouponPaymentDate); }
			public QuickFix.Fields.UnderlyingIssueDate UnderlyingIssueDate
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingIssueDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingIssueDate val) { this.UnderlyingIssueDate = val; }

			public QuickFix.Fields.UnderlyingIssueDate Get(QuickFix.Fields.UnderlyingIssueDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingIssueDate val) { return IsSetUnderlyingIssueDate(); }

			public bool IsSetUnderlyingIssueDate() { return IsSetField(Tags.UnderlyingIssueDate); }
			public QuickFix.Fields.UnderlyingRepoCollateralSecurityType UnderlyingRepoCollateralSecurityType
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingRepoCollateralSecurityType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) { this.UnderlyingRepoCollateralSecurityType = val; }

			public QuickFix.Fields.UnderlyingRepoCollateralSecurityType Get(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingRepoCollateralSecurityType val) { return IsSetUnderlyingRepoCollateralSecurityType(); }

			public bool IsSetUnderlyingRepoCollateralSecurityType() { return IsSetField(Tags.UnderlyingRepoCollateralSecurityType); }
			public QuickFix.Fields.UnderlyingRepurchaseTerm UnderlyingRepurchaseTerm
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingRepurchaseTerm();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingRepurchaseTerm val) { this.UnderlyingRepurchaseTerm = val; }

			public QuickFix.Fields.UnderlyingRepurchaseTerm Get(QuickFix.Fields.UnderlyingRepurchaseTerm val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseTerm val) { return IsSetUnderlyingRepurchaseTerm(); }

			public bool IsSetUnderlyingRepurchaseTerm() { return IsSetField(Tags.UnderlyingRepurchaseTerm); }
			public QuickFix.Fields.UnderlyingRepurchaseRate UnderlyingRepurchaseRate
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingRepurchaseRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingRepurchaseRate val) { this.UnderlyingRepurchaseRate = val; }

			public QuickFix.Fields.UnderlyingRepurchaseRate Get(QuickFix.Fields.UnderlyingRepurchaseRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingRepurchaseRate val) { return IsSetUnderlyingRepurchaseRate(); }

			public bool IsSetUnderlyingRepurchaseRate() { return IsSetField(Tags.UnderlyingRepurchaseRate); }
			public QuickFix.Fields.UnderlyingFactor UnderlyingFactor
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingFactor();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingFactor val) { this.UnderlyingFactor = val; }

			public QuickFix.Fields.UnderlyingFactor Get(QuickFix.Fields.UnderlyingFactor val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingFactor val) { return IsSetUnderlyingFactor(); }

			public bool IsSetUnderlyingFactor() { return IsSetField(Tags.UnderlyingFactor); }
			public QuickFix.Fields.UnderlyingCreditRating UnderlyingCreditRating
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCreditRating();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCreditRating val) { this.UnderlyingCreditRating = val; }

			public QuickFix.Fields.UnderlyingCreditRating Get(QuickFix.Fields.UnderlyingCreditRating val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCreditRating val) { return IsSetUnderlyingCreditRating(); }

			public bool IsSetUnderlyingCreditRating() { return IsSetField(Tags.UnderlyingCreditRating); }
			public QuickFix.Fields.UnderlyingInstrRegistry UnderlyingInstrRegistry
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingInstrRegistry();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingInstrRegistry val) { this.UnderlyingInstrRegistry = val; }

			public QuickFix.Fields.UnderlyingInstrRegistry Get(QuickFix.Fields.UnderlyingInstrRegistry val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingInstrRegistry val) { return IsSetUnderlyingInstrRegistry(); }

			public bool IsSetUnderlyingInstrRegistry() { return IsSetField(Tags.UnderlyingInstrRegistry); }
			public QuickFix.Fields.UnderlyingCountryOfIssue UnderlyingCountryOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCountryOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCountryOfIssue val) { this.UnderlyingCountryOfIssue = val; }

			public QuickFix.Fields.UnderlyingCountryOfIssue Get(QuickFix.Fields.UnderlyingCountryOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCountryOfIssue val) { return IsSetUnderlyingCountryOfIssue(); }

			public bool IsSetUnderlyingCountryOfIssue() { return IsSetField(Tags.UnderlyingCountryOfIssue); }
			public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue UnderlyingStateOrProvinceOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingStateOrProvinceOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) { this.UnderlyingStateOrProvinceOfIssue = val; }

			public QuickFix.Fields.UnderlyingStateOrProvinceOfIssue Get(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingStateOrProvinceOfIssue val) { return IsSetUnderlyingStateOrProvinceOfIssue(); }

			public bool IsSetUnderlyingStateOrProvinceOfIssue() { return IsSetField(Tags.UnderlyingStateOrProvinceOfIssue); }
			public QuickFix.Fields.UnderlyingLocaleOfIssue UnderlyingLocaleOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingLocaleOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingLocaleOfIssue val) { this.UnderlyingLocaleOfIssue = val; }

			public QuickFix.Fields.UnderlyingLocaleOfIssue Get(QuickFix.Fields.UnderlyingLocaleOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingLocaleOfIssue val) { return IsSetUnderlyingLocaleOfIssue(); }

			public bool IsSetUnderlyingLocaleOfIssue() { return IsSetField(Tags.UnderlyingLocaleOfIssue); }
			public QuickFix.Fields.UnderlyingRedemptionDate UnderlyingRedemptionDate
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingRedemptionDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingRedemptionDate val) { this.UnderlyingRedemptionDate = val; }

			public QuickFix.Fields.UnderlyingRedemptionDate Get(QuickFix.Fields.UnderlyingRedemptionDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingRedemptionDate val) { return IsSetUnderlyingRedemptionDate(); }

			public bool IsSetUnderlyingRedemptionDate() { return IsSetField(Tags.UnderlyingRedemptionDate); }
			public QuickFix.Fields.UnderlyingStrikePrice UnderlyingStrikePrice
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingStrikePrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingStrikePrice val) { this.UnderlyingStrikePrice = val; }

			public QuickFix.Fields.UnderlyingStrikePrice Get(QuickFix.Fields.UnderlyingStrikePrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingStrikePrice val) { return IsSetUnderlyingStrikePrice(); }

			public bool IsSetUnderlyingStrikePrice() { return IsSetField(Tags.UnderlyingStrikePrice); }
			public QuickFix.Fields.UnderlyingStrikeCurrency UnderlyingStrikeCurrency
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingStrikeCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingStrikeCurrency val) { this.UnderlyingStrikeCurrency = val; }

			public QuickFix.Fields.UnderlyingStrikeCurrency Get(QuickFix.Fields.UnderlyingStrikeCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingStrikeCurrency val) { return IsSetUnderlyingStrikeCurrency(); }

			public bool IsSetUnderlyingStrikeCurrency() { return IsSetField(Tags.UnderlyingStrikeCurrency); }
			public QuickFix.Fields.UnderlyingOptAttribute UnderlyingOptAttribute
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingOptAttribute();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingOptAttribute val) { this.UnderlyingOptAttribute = val; }

			public QuickFix.Fields.UnderlyingOptAttribute Get(QuickFix.Fields.UnderlyingOptAttribute val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingOptAttribute val) { return IsSetUnderlyingOptAttribute(); }

			public bool IsSetUnderlyingOptAttribute() { return IsSetField(Tags.UnderlyingOptAttribute); }
			public QuickFix.Fields.UnderlyingContractMultiplier UnderlyingContractMultiplier
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingContractMultiplier();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingContractMultiplier val) { this.UnderlyingContractMultiplier = val; }

			public QuickFix.Fields.UnderlyingContractMultiplier Get(QuickFix.Fields.UnderlyingContractMultiplier val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingContractMultiplier val) { return IsSetUnderlyingContractMultiplier(); }

			public bool IsSetUnderlyingContractMultiplier() { return IsSetField(Tags.UnderlyingContractMultiplier); }
			public QuickFix.Fields.UnderlyingCouponRate UnderlyingCouponRate
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCouponRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCouponRate val) { this.UnderlyingCouponRate = val; }

			public QuickFix.Fields.UnderlyingCouponRate Get(QuickFix.Fields.UnderlyingCouponRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCouponRate val) { return IsSetUnderlyingCouponRate(); }

			public bool IsSetUnderlyingCouponRate() { return IsSetField(Tags.UnderlyingCouponRate); }
			public QuickFix.Fields.UnderlyingSecurityExchange UnderlyingSecurityExchange
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityExchange();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityExchange val) { this.UnderlyingSecurityExchange = val; }

			public QuickFix.Fields.UnderlyingSecurityExchange Get(QuickFix.Fields.UnderlyingSecurityExchange val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityExchange val) { return IsSetUnderlyingSecurityExchange(); }

			public bool IsSetUnderlyingSecurityExchange() { return IsSetField(Tags.UnderlyingSecurityExchange); }
			public QuickFix.Fields.UnderlyingIssuer UnderlyingIssuer
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingIssuer();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingIssuer val) { this.UnderlyingIssuer = val; }

			public QuickFix.Fields.UnderlyingIssuer Get(QuickFix.Fields.UnderlyingIssuer val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingIssuer val) { return IsSetUnderlyingIssuer(); }

			public bool IsSetUnderlyingIssuer() { return IsSetField(Tags.UnderlyingIssuer); }
			public QuickFix.Fields.EncodedUnderlyingIssuerLen EncodedUnderlyingIssuerLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedUnderlyingIssuerLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedUnderlyingIssuerLen val) { this.EncodedUnderlyingIssuerLen = val; }

			public QuickFix.Fields.EncodedUnderlyingIssuerLen Get(QuickFix.Fields.EncodedUnderlyingIssuerLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuerLen val) { return IsSetEncodedUnderlyingIssuerLen(); }

			public bool IsSetEncodedUnderlyingIssuerLen() { return IsSetField(Tags.EncodedUnderlyingIssuerLen); }
			public QuickFix.Fields.EncodedUnderlyingIssuer EncodedUnderlyingIssuer
			{
				get
				{
					var val = new QuickFix.Fields.EncodedUnderlyingIssuer();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedUnderlyingIssuer val) { this.EncodedUnderlyingIssuer = val; }

			public QuickFix.Fields.EncodedUnderlyingIssuer Get(QuickFix.Fields.EncodedUnderlyingIssuer val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedUnderlyingIssuer val) { return IsSetEncodedUnderlyingIssuer(); }

			public bool IsSetEncodedUnderlyingIssuer() { return IsSetField(Tags.EncodedUnderlyingIssuer); }
			public QuickFix.Fields.UnderlyingSecurityDesc UnderlyingSecurityDesc
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityDesc val) { this.UnderlyingSecurityDesc = val; }

			public QuickFix.Fields.UnderlyingSecurityDesc Get(QuickFix.Fields.UnderlyingSecurityDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityDesc val) { return IsSetUnderlyingSecurityDesc(); }

			public bool IsSetUnderlyingSecurityDesc() { return IsSetField(Tags.UnderlyingSecurityDesc); }
			public QuickFix.Fields.EncodedUnderlyingSecurityDescLen EncodedUnderlyingSecurityDescLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedUnderlyingSecurityDescLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) { this.EncodedUnderlyingSecurityDescLen = val; }

			public QuickFix.Fields.EncodedUnderlyingSecurityDescLen Get(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDescLen val) { return IsSetEncodedUnderlyingSecurityDescLen(); }

			public bool IsSetEncodedUnderlyingSecurityDescLen() { return IsSetField(Tags.EncodedUnderlyingSecurityDescLen); }
			public QuickFix.Fields.EncodedUnderlyingSecurityDesc EncodedUnderlyingSecurityDesc
			{
				get
				{
					var val = new QuickFix.Fields.EncodedUnderlyingSecurityDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) { this.EncodedUnderlyingSecurityDesc = val; }

			public QuickFix.Fields.EncodedUnderlyingSecurityDesc Get(QuickFix.Fields.EncodedUnderlyingSecurityDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedUnderlyingSecurityDesc val) { return IsSetEncodedUnderlyingSecurityDesc(); }

			public bool IsSetEncodedUnderlyingSecurityDesc() { return IsSetField(Tags.EncodedUnderlyingSecurityDesc); }
			public QuickFix.Fields.UnderlyingCPProgram UnderlyingCPProgram
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCPProgram();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCPProgram val) { this.UnderlyingCPProgram = val; }

			public QuickFix.Fields.UnderlyingCPProgram Get(QuickFix.Fields.UnderlyingCPProgram val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCPProgram val) { return IsSetUnderlyingCPProgram(); }

			public bool IsSetUnderlyingCPProgram() { return IsSetField(Tags.UnderlyingCPProgram); }
			public QuickFix.Fields.UnderlyingCPRegType UnderlyingCPRegType
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCPRegType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCPRegType val) { this.UnderlyingCPRegType = val; }

			public QuickFix.Fields.UnderlyingCPRegType Get(QuickFix.Fields.UnderlyingCPRegType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCPRegType val) { return IsSetUnderlyingCPRegType(); }

			public bool IsSetUnderlyingCPRegType() { return IsSetField(Tags.UnderlyingCPRegType); }
			public QuickFix.Fields.UnderlyingCurrency UnderlyingCurrency
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCurrency val) { this.UnderlyingCurrency = val; }

			public QuickFix.Fields.UnderlyingCurrency Get(QuickFix.Fields.UnderlyingCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCurrency val) { return IsSetUnderlyingCurrency(); }

			public bool IsSetUnderlyingCurrency() { return IsSetField(Tags.UnderlyingCurrency); }
			public QuickFix.Fields.UnderlyingQty UnderlyingQty
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingQty();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingQty val) { this.UnderlyingQty = val; }

			public QuickFix.Fields.UnderlyingQty Get(QuickFix.Fields.UnderlyingQty val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingQty val) { return IsSetUnderlyingQty(); }

			public bool IsSetUnderlyingQty() { return IsSetField(Tags.UnderlyingQty); }
			public QuickFix.Fields.UnderlyingPx UnderlyingPx
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingPx val) { this.UnderlyingPx = val; }

			public QuickFix.Fields.UnderlyingPx Get(QuickFix.Fields.UnderlyingPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingPx val) { return IsSetUnderlyingPx(); }

			public bool IsSetUnderlyingPx() { return IsSetField(Tags.UnderlyingPx); }
			public QuickFix.Fields.UnderlyingDirtyPrice UnderlyingDirtyPrice
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingDirtyPrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingDirtyPrice val) { this.UnderlyingDirtyPrice = val; }

			public QuickFix.Fields.UnderlyingDirtyPrice Get(QuickFix.Fields.UnderlyingDirtyPrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingDirtyPrice val) { return IsSetUnderlyingDirtyPrice(); }

			public bool IsSetUnderlyingDirtyPrice() { return IsSetField(Tags.UnderlyingDirtyPrice); }
			public QuickFix.Fields.UnderlyingEndPrice UnderlyingEndPrice
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingEndPrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingEndPrice val) { this.UnderlyingEndPrice = val; }

			public QuickFix.Fields.UnderlyingEndPrice Get(QuickFix.Fields.UnderlyingEndPrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingEndPrice val) { return IsSetUnderlyingEndPrice(); }

			public bool IsSetUnderlyingEndPrice() { return IsSetField(Tags.UnderlyingEndPrice); }
			public QuickFix.Fields.UnderlyingStartValue UnderlyingStartValue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingStartValue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingStartValue val) { this.UnderlyingStartValue = val; }

			public QuickFix.Fields.UnderlyingStartValue Get(QuickFix.Fields.UnderlyingStartValue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingStartValue val) { return IsSetUnderlyingStartValue(); }

			public bool IsSetUnderlyingStartValue() { return IsSetField(Tags.UnderlyingStartValue); }
			public QuickFix.Fields.UnderlyingCurrentValue UnderlyingCurrentValue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingCurrentValue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingCurrentValue val) { this.UnderlyingCurrentValue = val; }

			public QuickFix.Fields.UnderlyingCurrentValue Get(QuickFix.Fields.UnderlyingCurrentValue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingCurrentValue val) { return IsSetUnderlyingCurrentValue(); }

			public bool IsSetUnderlyingCurrentValue() { return IsSetField(Tags.UnderlyingCurrentValue); }
			public QuickFix.Fields.UnderlyingEndValue UnderlyingEndValue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingEndValue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingEndValue val) { this.UnderlyingEndValue = val; }

			public QuickFix.Fields.UnderlyingEndValue Get(QuickFix.Fields.UnderlyingEndValue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingEndValue val) { return IsSetUnderlyingEndValue(); }

			public bool IsSetUnderlyingEndValue() { return IsSetField(Tags.UnderlyingEndValue); }
			public QuickFix.Fields.NoUnderlyingStips NoUnderlyingStips
			{
				get
				{
					var val = new QuickFix.Fields.NoUnderlyingStips();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoUnderlyingStips val) { this.NoUnderlyingStips = val; }

			public QuickFix.Fields.NoUnderlyingStips Get(QuickFix.Fields.NoUnderlyingStips val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoUnderlyingStips val) { return IsSetNoUnderlyingStips(); }

			public bool IsSetNoUnderlyingStips() { return IsSetField(Tags.NoUnderlyingStips); }

			public class NoUnderlyingSecurityAltIDGroup : Group
			{
				public static int[] fieldOrder = {Tags.UnderlyingSecurityAltID, Tags.UnderlyingSecurityAltIDSource, 0};

				public NoUnderlyingSecurityAltIDGroup() : base(Tags.NoUnderlyingSecurityAltID, Tags.UnderlyingSecurityAltID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoUnderlyingSecurityAltIDGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.UnderlyingSecurityAltID UnderlyingSecurityAltID
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityAltID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityAltID val) { this.UnderlyingSecurityAltID = val; }

			public QuickFix.Fields.UnderlyingSecurityAltID Get(QuickFix.Fields.UnderlyingSecurityAltID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltID val) { return IsSetUnderlyingSecurityAltID(); }

			public bool IsSetUnderlyingSecurityAltID() { return IsSetField(Tags.UnderlyingSecurityAltID); }
			public QuickFix.Fields.UnderlyingSecurityAltIDSource UnderlyingSecurityAltIDSource
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingSecurityAltIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingSecurityAltIDSource val) { this.UnderlyingSecurityAltIDSource = val; }

			public QuickFix.Fields.UnderlyingSecurityAltIDSource Get(QuickFix.Fields.UnderlyingSecurityAltIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingSecurityAltIDSource val) { return IsSetUnderlyingSecurityAltIDSource(); }

			public bool IsSetUnderlyingSecurityAltIDSource() { return IsSetField(Tags.UnderlyingSecurityAltIDSource); }

			}
			public class NoUnderlyingStipsGroup : Group
			{
				public static int[] fieldOrder = {Tags.UnderlyingStipType, Tags.UnderlyingStipValue, 0};

				public NoUnderlyingStipsGroup() : base(Tags.NoUnderlyingStips, Tags.UnderlyingStipType, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoUnderlyingStipsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.UnderlyingStipType UnderlyingStipType
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingStipType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingStipType val) { this.UnderlyingStipType = val; }

			public QuickFix.Fields.UnderlyingStipType Get(QuickFix.Fields.UnderlyingStipType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingStipType val) { return IsSetUnderlyingStipType(); }

			public bool IsSetUnderlyingStipType() { return IsSetField(Tags.UnderlyingStipType); }
			public QuickFix.Fields.UnderlyingStipValue UnderlyingStipValue
			{
				get
				{
					var val = new QuickFix.Fields.UnderlyingStipValue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnderlyingStipValue val) { this.UnderlyingStipValue = val; }

			public QuickFix.Fields.UnderlyingStipValue Get(QuickFix.Fields.UnderlyingStipValue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnderlyingStipValue val) { return IsSetUnderlyingStipValue(); }

			public bool IsSetUnderlyingStipValue() { return IsSetField(Tags.UnderlyingStipValue); }

			}
			}
			public class NoLegsGroup : Group
			{
				public static int[] fieldOrder = {Tags.LegSymbol, Tags.LegSymbolSfx, Tags.LegSecurityID, Tags.LegSecurityIDSource, Tags.NoLegSecurityAltID, Tags.LegProduct, Tags.LegCFICode, Tags.LegSecurityType, Tags.LegSecuritySubType, Tags.LegMaturityMonthYear, Tags.LegMaturityDate, Tags.LegCouponPaymentDate, Tags.LegIssueDate, Tags.LegRepoCollateralSecurityType, Tags.LegRepurchaseTerm, Tags.LegRepurchaseRate, Tags.LegFactor, Tags.LegCreditRating, Tags.LegInstrRegistry, Tags.LegCountryOfIssue, Tags.LegStateOrProvinceOfIssue, Tags.LegLocaleOfIssue, Tags.LegRedemptionDate, Tags.LegStrikePrice, Tags.LegStrikeCurrency, Tags.LegOptAttribute, Tags.LegContractMultiplier, Tags.LegCouponRate, Tags.LegSecurityExchange, Tags.LegIssuer, Tags.EncodedLegIssuerLen, Tags.EncodedLegIssuer, Tags.LegSecurityDesc, Tags.EncodedLegSecurityDescLen, Tags.EncodedLegSecurityDesc, Tags.LegRatioQty, Tags.LegSide, Tags.LegCurrency, Tags.LegPool, Tags.LegDatedDate, Tags.LegContractSettlMonth, Tags.LegInterestAccrualDate, 0};

				public NoLegsGroup() : base(Tags.NoLegs, Tags.LegSymbol, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoLegsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.LegSymbol LegSymbol
			{
				get
				{
					var val = new QuickFix.Fields.LegSymbol();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSymbol val) { this.LegSymbol = val; }

			public QuickFix.Fields.LegSymbol Get(QuickFix.Fields.LegSymbol val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSymbol val) { return IsSetLegSymbol(); }

			public bool IsSetLegSymbol() { return IsSetField(Tags.LegSymbol); }
			public QuickFix.Fields.LegSymbolSfx LegSymbolSfx
			{
				get
				{
					var val = new QuickFix.Fields.LegSymbolSfx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSymbolSfx val) { this.LegSymbolSfx = val; }

			public QuickFix.Fields.LegSymbolSfx Get(QuickFix.Fields.LegSymbolSfx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSymbolSfx val) { return IsSetLegSymbolSfx(); }

			public bool IsSetLegSymbolSfx() { return IsSetField(Tags.LegSymbolSfx); }
			public QuickFix.Fields.LegSecurityID LegSecurityID
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityID val) { this.LegSecurityID = val; }

			public QuickFix.Fields.LegSecurityID Get(QuickFix.Fields.LegSecurityID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityID val) { return IsSetLegSecurityID(); }

			public bool IsSetLegSecurityID() { return IsSetField(Tags.LegSecurityID); }
			public QuickFix.Fields.LegSecurityIDSource LegSecurityIDSource
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityIDSource val) { this.LegSecurityIDSource = val; }

			public QuickFix.Fields.LegSecurityIDSource Get(QuickFix.Fields.LegSecurityIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityIDSource val) { return IsSetLegSecurityIDSource(); }

			public bool IsSetLegSecurityIDSource() { return IsSetField(Tags.LegSecurityIDSource); }
			public QuickFix.Fields.NoLegSecurityAltID NoLegSecurityAltID
			{
				get
				{
					var val = new QuickFix.Fields.NoLegSecurityAltID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoLegSecurityAltID val) { this.NoLegSecurityAltID = val; }

			public QuickFix.Fields.NoLegSecurityAltID Get(QuickFix.Fields.NoLegSecurityAltID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoLegSecurityAltID val) { return IsSetNoLegSecurityAltID(); }

			public bool IsSetNoLegSecurityAltID() { return IsSetField(Tags.NoLegSecurityAltID); }
			public QuickFix.Fields.LegProduct LegProduct
			{
				get
				{
					var val = new QuickFix.Fields.LegProduct();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegProduct val) { this.LegProduct = val; }

			public QuickFix.Fields.LegProduct Get(QuickFix.Fields.LegProduct val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegProduct val) { return IsSetLegProduct(); }

			public bool IsSetLegProduct() { return IsSetField(Tags.LegProduct); }
			public QuickFix.Fields.LegCFICode LegCFICode
			{
				get
				{
					var val = new QuickFix.Fields.LegCFICode();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegCFICode val) { this.LegCFICode = val; }

			public QuickFix.Fields.LegCFICode Get(QuickFix.Fields.LegCFICode val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegCFICode val) { return IsSetLegCFICode(); }

			public bool IsSetLegCFICode() { return IsSetField(Tags.LegCFICode); }
			public QuickFix.Fields.LegSecurityType LegSecurityType
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityType val) { this.LegSecurityType = val; }

			public QuickFix.Fields.LegSecurityType Get(QuickFix.Fields.LegSecurityType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityType val) { return IsSetLegSecurityType(); }

			public bool IsSetLegSecurityType() { return IsSetField(Tags.LegSecurityType); }
			public QuickFix.Fields.LegSecuritySubType LegSecuritySubType
			{
				get
				{
					var val = new QuickFix.Fields.LegSecuritySubType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecuritySubType val) { this.LegSecuritySubType = val; }

			public QuickFix.Fields.LegSecuritySubType Get(QuickFix.Fields.LegSecuritySubType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecuritySubType val) { return IsSetLegSecuritySubType(); }

			public bool IsSetLegSecuritySubType() { return IsSetField(Tags.LegSecuritySubType); }
			public QuickFix.Fields.LegMaturityMonthYear LegMaturityMonthYear
			{
				get
				{
					var val = new QuickFix.Fields.LegMaturityMonthYear();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegMaturityMonthYear val) { this.LegMaturityMonthYear = val; }

			public QuickFix.Fields.LegMaturityMonthYear Get(QuickFix.Fields.LegMaturityMonthYear val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegMaturityMonthYear val) { return IsSetLegMaturityMonthYear(); }

			public bool IsSetLegMaturityMonthYear() { return IsSetField(Tags.LegMaturityMonthYear); }
			public QuickFix.Fields.LegMaturityDate LegMaturityDate
			{
				get
				{
					var val = new QuickFix.Fields.LegMaturityDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegMaturityDate val) { this.LegMaturityDate = val; }

			public QuickFix.Fields.LegMaturityDate Get(QuickFix.Fields.LegMaturityDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegMaturityDate val) { return IsSetLegMaturityDate(); }

			public bool IsSetLegMaturityDate() { return IsSetField(Tags.LegMaturityDate); }
			public QuickFix.Fields.LegCouponPaymentDate LegCouponPaymentDate
			{
				get
				{
					var val = new QuickFix.Fields.LegCouponPaymentDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegCouponPaymentDate val) { this.LegCouponPaymentDate = val; }

			public QuickFix.Fields.LegCouponPaymentDate Get(QuickFix.Fields.LegCouponPaymentDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegCouponPaymentDate val) { return IsSetLegCouponPaymentDate(); }

			public bool IsSetLegCouponPaymentDate() { return IsSetField(Tags.LegCouponPaymentDate); }
			public QuickFix.Fields.LegIssueDate LegIssueDate
			{
				get
				{
					var val = new QuickFix.Fields.LegIssueDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegIssueDate val) { this.LegIssueDate = val; }

			public QuickFix.Fields.LegIssueDate Get(QuickFix.Fields.LegIssueDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegIssueDate val) { return IsSetLegIssueDate(); }

			public bool IsSetLegIssueDate() { return IsSetField(Tags.LegIssueDate); }
			public QuickFix.Fields.LegRepoCollateralSecurityType LegRepoCollateralSecurityType
			{
				get
				{
					var val = new QuickFix.Fields.LegRepoCollateralSecurityType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegRepoCollateralSecurityType val) { this.LegRepoCollateralSecurityType = val; }

			public QuickFix.Fields.LegRepoCollateralSecurityType Get(QuickFix.Fields.LegRepoCollateralSecurityType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegRepoCollateralSecurityType val) { return IsSetLegRepoCollateralSecurityType(); }

			public bool IsSetLegRepoCollateralSecurityType() { return IsSetField(Tags.LegRepoCollateralSecurityType); }
			public QuickFix.Fields.LegRepurchaseTerm LegRepurchaseTerm
			{
				get
				{
					var val = new QuickFix.Fields.LegRepurchaseTerm();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegRepurchaseTerm val) { this.LegRepurchaseTerm = val; }

			public QuickFix.Fields.LegRepurchaseTerm Get(QuickFix.Fields.LegRepurchaseTerm val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegRepurchaseTerm val) { return IsSetLegRepurchaseTerm(); }

			public bool IsSetLegRepurchaseTerm() { return IsSetField(Tags.LegRepurchaseTerm); }
			public QuickFix.Fields.LegRepurchaseRate LegRepurchaseRate
			{
				get
				{
					var val = new QuickFix.Fields.LegRepurchaseRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegRepurchaseRate val) { this.LegRepurchaseRate = val; }

			public QuickFix.Fields.LegRepurchaseRate Get(QuickFix.Fields.LegRepurchaseRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegRepurchaseRate val) { return IsSetLegRepurchaseRate(); }

			public bool IsSetLegRepurchaseRate() { return IsSetField(Tags.LegRepurchaseRate); }
			public QuickFix.Fields.LegFactor LegFactor
			{
				get
				{
					var val = new QuickFix.Fields.LegFactor();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegFactor val) { this.LegFactor = val; }

			public QuickFix.Fields.LegFactor Get(QuickFix.Fields.LegFactor val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegFactor val) { return IsSetLegFactor(); }

			public bool IsSetLegFactor() { return IsSetField(Tags.LegFactor); }
			public QuickFix.Fields.LegCreditRating LegCreditRating
			{
				get
				{
					var val = new QuickFix.Fields.LegCreditRating();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegCreditRating val) { this.LegCreditRating = val; }

			public QuickFix.Fields.LegCreditRating Get(QuickFix.Fields.LegCreditRating val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegCreditRating val) { return IsSetLegCreditRating(); }

			public bool IsSetLegCreditRating() { return IsSetField(Tags.LegCreditRating); }
			public QuickFix.Fields.LegInstrRegistry LegInstrRegistry
			{
				get
				{
					var val = new QuickFix.Fields.LegInstrRegistry();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegInstrRegistry val) { this.LegInstrRegistry = val; }

			public QuickFix.Fields.LegInstrRegistry Get(QuickFix.Fields.LegInstrRegistry val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegInstrRegistry val) { return IsSetLegInstrRegistry(); }

			public bool IsSetLegInstrRegistry() { return IsSetField(Tags.LegInstrRegistry); }
			public QuickFix.Fields.LegCountryOfIssue LegCountryOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.LegCountryOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegCountryOfIssue val) { this.LegCountryOfIssue = val; }

			public QuickFix.Fields.LegCountryOfIssue Get(QuickFix.Fields.LegCountryOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegCountryOfIssue val) { return IsSetLegCountryOfIssue(); }

			public bool IsSetLegCountryOfIssue() { return IsSetField(Tags.LegCountryOfIssue); }
			public QuickFix.Fields.LegStateOrProvinceOfIssue LegStateOrProvinceOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.LegStateOrProvinceOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegStateOrProvinceOfIssue val) { this.LegStateOrProvinceOfIssue = val; }

			public QuickFix.Fields.LegStateOrProvinceOfIssue Get(QuickFix.Fields.LegStateOrProvinceOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegStateOrProvinceOfIssue val) { return IsSetLegStateOrProvinceOfIssue(); }

			public bool IsSetLegStateOrProvinceOfIssue() { return IsSetField(Tags.LegStateOrProvinceOfIssue); }
			public QuickFix.Fields.LegLocaleOfIssue LegLocaleOfIssue
			{
				get
				{
					var val = new QuickFix.Fields.LegLocaleOfIssue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegLocaleOfIssue val) { this.LegLocaleOfIssue = val; }

			public QuickFix.Fields.LegLocaleOfIssue Get(QuickFix.Fields.LegLocaleOfIssue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegLocaleOfIssue val) { return IsSetLegLocaleOfIssue(); }

			public bool IsSetLegLocaleOfIssue() { return IsSetField(Tags.LegLocaleOfIssue); }
			public QuickFix.Fields.LegRedemptionDate LegRedemptionDate
			{
				get
				{
					var val = new QuickFix.Fields.LegRedemptionDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegRedemptionDate val) { this.LegRedemptionDate = val; }

			public QuickFix.Fields.LegRedemptionDate Get(QuickFix.Fields.LegRedemptionDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegRedemptionDate val) { return IsSetLegRedemptionDate(); }

			public bool IsSetLegRedemptionDate() { return IsSetField(Tags.LegRedemptionDate); }
			public QuickFix.Fields.LegStrikePrice LegStrikePrice
			{
				get
				{
					var val = new QuickFix.Fields.LegStrikePrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegStrikePrice val) { this.LegStrikePrice = val; }

			public QuickFix.Fields.LegStrikePrice Get(QuickFix.Fields.LegStrikePrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegStrikePrice val) { return IsSetLegStrikePrice(); }

			public bool IsSetLegStrikePrice() { return IsSetField(Tags.LegStrikePrice); }
			public QuickFix.Fields.LegStrikeCurrency LegStrikeCurrency
			{
				get
				{
					var val = new QuickFix.Fields.LegStrikeCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegStrikeCurrency val) { this.LegStrikeCurrency = val; }

			public QuickFix.Fields.LegStrikeCurrency Get(QuickFix.Fields.LegStrikeCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegStrikeCurrency val) { return IsSetLegStrikeCurrency(); }

			public bool IsSetLegStrikeCurrency() { return IsSetField(Tags.LegStrikeCurrency); }
			public QuickFix.Fields.LegOptAttribute LegOptAttribute
			{
				get
				{
					var val = new QuickFix.Fields.LegOptAttribute();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegOptAttribute val) { this.LegOptAttribute = val; }

			public QuickFix.Fields.LegOptAttribute Get(QuickFix.Fields.LegOptAttribute val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegOptAttribute val) { return IsSetLegOptAttribute(); }

			public bool IsSetLegOptAttribute() { return IsSetField(Tags.LegOptAttribute); }
			public QuickFix.Fields.LegContractMultiplier LegContractMultiplier
			{
				get
				{
					var val = new QuickFix.Fields.LegContractMultiplier();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegContractMultiplier val) { this.LegContractMultiplier = val; }

			public QuickFix.Fields.LegContractMultiplier Get(QuickFix.Fields.LegContractMultiplier val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegContractMultiplier val) { return IsSetLegContractMultiplier(); }

			public bool IsSetLegContractMultiplier() { return IsSetField(Tags.LegContractMultiplier); }
			public QuickFix.Fields.LegCouponRate LegCouponRate
			{
				get
				{
					var val = new QuickFix.Fields.LegCouponRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegCouponRate val) { this.LegCouponRate = val; }

			public QuickFix.Fields.LegCouponRate Get(QuickFix.Fields.LegCouponRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegCouponRate val) { return IsSetLegCouponRate(); }

			public bool IsSetLegCouponRate() { return IsSetField(Tags.LegCouponRate); }
			public QuickFix.Fields.LegSecurityExchange LegSecurityExchange
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityExchange();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityExchange val) { this.LegSecurityExchange = val; }

			public QuickFix.Fields.LegSecurityExchange Get(QuickFix.Fields.LegSecurityExchange val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityExchange val) { return IsSetLegSecurityExchange(); }

			public bool IsSetLegSecurityExchange() { return IsSetField(Tags.LegSecurityExchange); }
			public QuickFix.Fields.LegIssuer LegIssuer
			{
				get
				{
					var val = new QuickFix.Fields.LegIssuer();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegIssuer val) { this.LegIssuer = val; }

			public QuickFix.Fields.LegIssuer Get(QuickFix.Fields.LegIssuer val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegIssuer val) { return IsSetLegIssuer(); }

			public bool IsSetLegIssuer() { return IsSetField(Tags.LegIssuer); }
			public QuickFix.Fields.EncodedLegIssuerLen EncodedLegIssuerLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedLegIssuerLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedLegIssuerLen val) { this.EncodedLegIssuerLen = val; }

			public QuickFix.Fields.EncodedLegIssuerLen Get(QuickFix.Fields.EncodedLegIssuerLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedLegIssuerLen val) { return IsSetEncodedLegIssuerLen(); }

			public bool IsSetEncodedLegIssuerLen() { return IsSetField(Tags.EncodedLegIssuerLen); }
			public QuickFix.Fields.EncodedLegIssuer EncodedLegIssuer
			{
				get
				{
					var val = new QuickFix.Fields.EncodedLegIssuer();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedLegIssuer val) { this.EncodedLegIssuer = val; }

			public QuickFix.Fields.EncodedLegIssuer Get(QuickFix.Fields.EncodedLegIssuer val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedLegIssuer val) { return IsSetEncodedLegIssuer(); }

			public bool IsSetEncodedLegIssuer() { return IsSetField(Tags.EncodedLegIssuer); }
			public QuickFix.Fields.LegSecurityDesc LegSecurityDesc
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityDesc val) { this.LegSecurityDesc = val; }

			public QuickFix.Fields.LegSecurityDesc Get(QuickFix.Fields.LegSecurityDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityDesc val) { return IsSetLegSecurityDesc(); }

			public bool IsSetLegSecurityDesc() { return IsSetField(Tags.LegSecurityDesc); }
			public QuickFix.Fields.EncodedLegSecurityDescLen EncodedLegSecurityDescLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedLegSecurityDescLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedLegSecurityDescLen val) { this.EncodedLegSecurityDescLen = val; }

			public QuickFix.Fields.EncodedLegSecurityDescLen Get(QuickFix.Fields.EncodedLegSecurityDescLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedLegSecurityDescLen val) { return IsSetEncodedLegSecurityDescLen(); }

			public bool IsSetEncodedLegSecurityDescLen() { return IsSetField(Tags.EncodedLegSecurityDescLen); }
			public QuickFix.Fields.EncodedLegSecurityDesc EncodedLegSecurityDesc
			{
				get
				{
					var val = new QuickFix.Fields.EncodedLegSecurityDesc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedLegSecurityDesc val) { this.EncodedLegSecurityDesc = val; }

			public QuickFix.Fields.EncodedLegSecurityDesc Get(QuickFix.Fields.EncodedLegSecurityDesc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedLegSecurityDesc val) { return IsSetEncodedLegSecurityDesc(); }

			public bool IsSetEncodedLegSecurityDesc() { return IsSetField(Tags.EncodedLegSecurityDesc); }
			public QuickFix.Fields.LegRatioQty LegRatioQty
			{
				get
				{
					var val = new QuickFix.Fields.LegRatioQty();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegRatioQty val) { this.LegRatioQty = val; }

			public QuickFix.Fields.LegRatioQty Get(QuickFix.Fields.LegRatioQty val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegRatioQty val) { return IsSetLegRatioQty(); }

			public bool IsSetLegRatioQty() { return IsSetField(Tags.LegRatioQty); }
			public QuickFix.Fields.LegSide LegSide
			{
				get
				{
					var val = new QuickFix.Fields.LegSide();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSide val) { this.LegSide = val; }

			public QuickFix.Fields.LegSide Get(QuickFix.Fields.LegSide val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSide val) { return IsSetLegSide(); }

			public bool IsSetLegSide() { return IsSetField(Tags.LegSide); }
			public QuickFix.Fields.LegCurrency LegCurrency
			{
				get
				{
					var val = new QuickFix.Fields.LegCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegCurrency val) { this.LegCurrency = val; }

			public QuickFix.Fields.LegCurrency Get(QuickFix.Fields.LegCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegCurrency val) { return IsSetLegCurrency(); }

			public bool IsSetLegCurrency() { return IsSetField(Tags.LegCurrency); }
			public QuickFix.Fields.LegPool LegPool
			{
				get
				{
					var val = new QuickFix.Fields.LegPool();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegPool val) { this.LegPool = val; }

			public QuickFix.Fields.LegPool Get(QuickFix.Fields.LegPool val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegPool val) { return IsSetLegPool(); }

			public bool IsSetLegPool() { return IsSetField(Tags.LegPool); }
			public QuickFix.Fields.LegDatedDate LegDatedDate
			{
				get
				{
					var val = new QuickFix.Fields.LegDatedDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegDatedDate val) { this.LegDatedDate = val; }

			public QuickFix.Fields.LegDatedDate Get(QuickFix.Fields.LegDatedDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegDatedDate val) { return IsSetLegDatedDate(); }

			public bool IsSetLegDatedDate() { return IsSetField(Tags.LegDatedDate); }
			public QuickFix.Fields.LegContractSettlMonth LegContractSettlMonth
			{
				get
				{
					var val = new QuickFix.Fields.LegContractSettlMonth();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegContractSettlMonth val) { this.LegContractSettlMonth = val; }

			public QuickFix.Fields.LegContractSettlMonth Get(QuickFix.Fields.LegContractSettlMonth val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegContractSettlMonth val) { return IsSetLegContractSettlMonth(); }

			public bool IsSetLegContractSettlMonth() { return IsSetField(Tags.LegContractSettlMonth); }
			public QuickFix.Fields.LegInterestAccrualDate LegInterestAccrualDate
			{
				get
				{
					var val = new QuickFix.Fields.LegInterestAccrualDate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegInterestAccrualDate val) { this.LegInterestAccrualDate = val; }

			public QuickFix.Fields.LegInterestAccrualDate Get(QuickFix.Fields.LegInterestAccrualDate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegInterestAccrualDate val) { return IsSetLegInterestAccrualDate(); }

			public bool IsSetLegInterestAccrualDate() { return IsSetField(Tags.LegInterestAccrualDate); }

			public class NoLegSecurityAltIDGroup : Group
			{
				public static int[] fieldOrder = {Tags.LegSecurityAltID, Tags.LegSecurityAltIDSource, 0};

				public NoLegSecurityAltIDGroup() : base(Tags.NoLegSecurityAltID, Tags.LegSecurityAltID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoLegSecurityAltIDGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.LegSecurityAltID LegSecurityAltID
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityAltID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityAltID val) { this.LegSecurityAltID = val; }

			public QuickFix.Fields.LegSecurityAltID Get(QuickFix.Fields.LegSecurityAltID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityAltID val) { return IsSetLegSecurityAltID(); }

			public bool IsSetLegSecurityAltID() { return IsSetField(Tags.LegSecurityAltID); }
			public QuickFix.Fields.LegSecurityAltIDSource LegSecurityAltIDSource
			{
				get
				{
					var val = new QuickFix.Fields.LegSecurityAltIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LegSecurityAltIDSource val) { this.LegSecurityAltIDSource = val; }

			public QuickFix.Fields.LegSecurityAltIDSource Get(QuickFix.Fields.LegSecurityAltIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LegSecurityAltIDSource val) { return IsSetLegSecurityAltIDSource(); }

			public bool IsSetLegSecurityAltIDSource() { return IsSetField(Tags.LegSecurityAltIDSource); }

			}
			}
			public class NoPartyIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.PartyID, Tags.PartyIDSource, Tags.PartyRole, Tags.NoPartySubIDs, 0};

				public NoPartyIDsGroup() : base(Tags.NoPartyIDs, Tags.PartyID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoPartyIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.PartyID PartyID
			{
				get
				{
					var val = new QuickFix.Fields.PartyID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PartyID val) { this.PartyID = val; }

			public QuickFix.Fields.PartyID Get(QuickFix.Fields.PartyID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PartyID val) { return IsSetPartyID(); }

			public bool IsSetPartyID() { return IsSetField(Tags.PartyID); }
			public QuickFix.Fields.PartyIDSource PartyIDSource
			{
				get
				{
					var val = new QuickFix.Fields.PartyIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PartyIDSource val) { this.PartyIDSource = val; }

			public QuickFix.Fields.PartyIDSource Get(QuickFix.Fields.PartyIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PartyIDSource val) { return IsSetPartyIDSource(); }

			public bool IsSetPartyIDSource() { return IsSetField(Tags.PartyIDSource); }
			public QuickFix.Fields.PartyRole PartyRole
			{
				get
				{
					var val = new QuickFix.Fields.PartyRole();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PartyRole val) { this.PartyRole = val; }

			public QuickFix.Fields.PartyRole Get(QuickFix.Fields.PartyRole val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PartyRole val) { return IsSetPartyRole(); }

			public bool IsSetPartyRole() { return IsSetField(Tags.PartyRole); }
			public QuickFix.Fields.NoPartySubIDs NoPartySubIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoPartySubIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoPartySubIDs val) { this.NoPartySubIDs = val; }

			public QuickFix.Fields.NoPartySubIDs Get(QuickFix.Fields.NoPartySubIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoPartySubIDs val) { return IsSetNoPartySubIDs(); }

			public bool IsSetNoPartySubIDs() { return IsSetField(Tags.NoPartySubIDs); }

			public class NoPartySubIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.PartySubID, Tags.PartySubIDType, 0};

				public NoPartySubIDsGroup() : base(Tags.NoPartySubIDs, Tags.PartySubID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoPartySubIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.PartySubID PartySubID
			{
				get
				{
					var val = new QuickFix.Fields.PartySubID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PartySubID val) { this.PartySubID = val; }

			public QuickFix.Fields.PartySubID Get(QuickFix.Fields.PartySubID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PartySubID val) { return IsSetPartySubID(); }

			public bool IsSetPartySubID() { return IsSetField(Tags.PartySubID); }
			public QuickFix.Fields.PartySubIDType PartySubIDType
			{
				get
				{
					var val = new QuickFix.Fields.PartySubIDType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.PartySubIDType val) { this.PartySubIDType = val; }

			public QuickFix.Fields.PartySubIDType Get(QuickFix.Fields.PartySubIDType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.PartySubIDType val) { return IsSetPartySubIDType(); }

			public bool IsSetPartySubIDType() { return IsSetField(Tags.PartySubIDType); }

			}
			}
			public class NoStipulationsGroup : Group
			{
				public static int[] fieldOrder = {Tags.StipulationType, Tags.StipulationValue, 0};

				public NoStipulationsGroup() : base(Tags.NoStipulations, Tags.StipulationType, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoStipulationsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.StipulationType StipulationType
			{
				get
				{
					var val = new QuickFix.Fields.StipulationType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StipulationType val) { this.StipulationType = val; }

			public QuickFix.Fields.StipulationType Get(QuickFix.Fields.StipulationType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StipulationType val) { return IsSetStipulationType(); }

			public bool IsSetStipulationType() { return IsSetField(Tags.StipulationType); }
			public QuickFix.Fields.StipulationValue StipulationValue
			{
				get
				{
					var val = new QuickFix.Fields.StipulationValue();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StipulationValue val) { this.StipulationValue = val; }

			public QuickFix.Fields.StipulationValue Get(QuickFix.Fields.StipulationValue val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StipulationValue val) { return IsSetStipulationValue(); }

			public bool IsSetStipulationValue() { return IsSetField(Tags.StipulationValue); }

			}
			public class NoAllocsGroup : Group
			{
				public static int[] fieldOrder = {Tags.AllocAccount, Tags.AllocAcctIDSource, Tags.MatchStatus, Tags.AllocPrice, Tags.AllocQty, Tags.IndividualAllocID, Tags.ProcessCode, Tags.NoNestedPartyIDs, Tags.NotifyBrokerOfCredit, Tags.AllocHandlInst, Tags.AllocText, Tags.EncodedAllocTextLen, Tags.EncodedAllocText, Tags.Commission, Tags.CommType, Tags.CommCurrency, Tags.FundRenewWaiv, Tags.AllocAvgPx, Tags.AllocNetMoney, Tags.SettlCurrAmt, Tags.AllocSettlCurrAmt, Tags.SettlCurrency, Tags.AllocSettlCurrency, Tags.SettlCurrFxRate, Tags.SettlCurrFxRateCalc, Tags.AccruedInterestAmt, Tags.AllocAccruedInterestAmt, Tags.AllocInterestAtMaturity, Tags.SettlInstMode, Tags.NoMiscFees, Tags.NoClearingInstructions, Tags.ClearingInstruction, Tags.ClearingFeeIndicator, Tags.AllocSettlInstType, Tags.SettlDeliveryType, Tags.StandInstDbType, Tags.StandInstDbName, Tags.StandInstDbID, Tags.NoDlvyInst, 0};

				public NoAllocsGroup() : base(Tags.NoAllocs, Tags.AllocAccount, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoAllocsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.AllocAccount AllocAccount
			{
				get
				{
					var val = new QuickFix.Fields.AllocAccount();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocAccount val) { this.AllocAccount = val; }

			public QuickFix.Fields.AllocAccount Get(QuickFix.Fields.AllocAccount val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocAccount val) { return IsSetAllocAccount(); }

			public bool IsSetAllocAccount() { return IsSetField(Tags.AllocAccount); }
			public QuickFix.Fields.AllocAcctIDSource AllocAcctIDSource
			{
				get
				{
					var val = new QuickFix.Fields.AllocAcctIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocAcctIDSource val) { this.AllocAcctIDSource = val; }

			public QuickFix.Fields.AllocAcctIDSource Get(QuickFix.Fields.AllocAcctIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocAcctIDSource val) { return IsSetAllocAcctIDSource(); }

			public bool IsSetAllocAcctIDSource() { return IsSetField(Tags.AllocAcctIDSource); }
			public QuickFix.Fields.MatchStatus MatchStatus
			{
				get
				{
					var val = new QuickFix.Fields.MatchStatus();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MatchStatus val) { this.MatchStatus = val; }

			public QuickFix.Fields.MatchStatus Get(QuickFix.Fields.MatchStatus val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MatchStatus val) { return IsSetMatchStatus(); }

			public bool IsSetMatchStatus() { return IsSetField(Tags.MatchStatus); }
			public QuickFix.Fields.AllocPrice AllocPrice
			{
				get
				{
					var val = new QuickFix.Fields.AllocPrice();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocPrice val) { this.AllocPrice = val; }

			public QuickFix.Fields.AllocPrice Get(QuickFix.Fields.AllocPrice val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocPrice val) { return IsSetAllocPrice(); }

			public bool IsSetAllocPrice() { return IsSetField(Tags.AllocPrice); }
			public QuickFix.Fields.AllocQty AllocQty
			{
				get
				{
					var val = new QuickFix.Fields.AllocQty();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocQty val) { this.AllocQty = val; }

			public QuickFix.Fields.AllocQty Get(QuickFix.Fields.AllocQty val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocQty val) { return IsSetAllocQty(); }

			public bool IsSetAllocQty() { return IsSetField(Tags.AllocQty); }
			public QuickFix.Fields.IndividualAllocID IndividualAllocID
			{
				get
				{
					var val = new QuickFix.Fields.IndividualAllocID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.IndividualAllocID val) { this.IndividualAllocID = val; }

			public QuickFix.Fields.IndividualAllocID Get(QuickFix.Fields.IndividualAllocID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.IndividualAllocID val) { return IsSetIndividualAllocID(); }

			public bool IsSetIndividualAllocID() { return IsSetField(Tags.IndividualAllocID); }
			public QuickFix.Fields.ProcessCode ProcessCode
			{
				get
				{
					var val = new QuickFix.Fields.ProcessCode();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ProcessCode val) { this.ProcessCode = val; }

			public QuickFix.Fields.ProcessCode Get(QuickFix.Fields.ProcessCode val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ProcessCode val) { return IsSetProcessCode(); }

			public bool IsSetProcessCode() { return IsSetField(Tags.ProcessCode); }
			public QuickFix.Fields.NoNestedPartyIDs NoNestedPartyIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoNestedPartyIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoNestedPartyIDs val) { this.NoNestedPartyIDs = val; }

			public QuickFix.Fields.NoNestedPartyIDs Get(QuickFix.Fields.NoNestedPartyIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoNestedPartyIDs val) { return IsSetNoNestedPartyIDs(); }

			public bool IsSetNoNestedPartyIDs() { return IsSetField(Tags.NoNestedPartyIDs); }
			public QuickFix.Fields.NotifyBrokerOfCredit NotifyBrokerOfCredit
			{
				get
				{
					var val = new QuickFix.Fields.NotifyBrokerOfCredit();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NotifyBrokerOfCredit val) { this.NotifyBrokerOfCredit = val; }

			public QuickFix.Fields.NotifyBrokerOfCredit Get(QuickFix.Fields.NotifyBrokerOfCredit val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NotifyBrokerOfCredit val) { return IsSetNotifyBrokerOfCredit(); }

			public bool IsSetNotifyBrokerOfCredit() { return IsSetField(Tags.NotifyBrokerOfCredit); }
			public QuickFix.Fields.AllocHandlInst AllocHandlInst
			{
				get
				{
					var val = new QuickFix.Fields.AllocHandlInst();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocHandlInst val) { this.AllocHandlInst = val; }

			public QuickFix.Fields.AllocHandlInst Get(QuickFix.Fields.AllocHandlInst val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocHandlInst val) { return IsSetAllocHandlInst(); }

			public bool IsSetAllocHandlInst() { return IsSetField(Tags.AllocHandlInst); }
			public QuickFix.Fields.AllocText AllocText
			{
				get
				{
					var val = new QuickFix.Fields.AllocText();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocText val) { this.AllocText = val; }

			public QuickFix.Fields.AllocText Get(QuickFix.Fields.AllocText val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocText val) { return IsSetAllocText(); }

			public bool IsSetAllocText() { return IsSetField(Tags.AllocText); }
			public QuickFix.Fields.EncodedAllocTextLen EncodedAllocTextLen
			{
				get
				{
					var val = new QuickFix.Fields.EncodedAllocTextLen();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedAllocTextLen val) { this.EncodedAllocTextLen = val; }

			public QuickFix.Fields.EncodedAllocTextLen Get(QuickFix.Fields.EncodedAllocTextLen val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedAllocTextLen val) { return IsSetEncodedAllocTextLen(); }

			public bool IsSetEncodedAllocTextLen() { return IsSetField(Tags.EncodedAllocTextLen); }
			public QuickFix.Fields.EncodedAllocText EncodedAllocText
			{
				get
				{
					var val = new QuickFix.Fields.EncodedAllocText();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.EncodedAllocText val) { this.EncodedAllocText = val; }

			public QuickFix.Fields.EncodedAllocText Get(QuickFix.Fields.EncodedAllocText val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.EncodedAllocText val) { return IsSetEncodedAllocText(); }

			public bool IsSetEncodedAllocText() { return IsSetField(Tags.EncodedAllocText); }
			public QuickFix.Fields.Commission Commission
			{
				get
				{
					var val = new QuickFix.Fields.Commission();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Commission val) { this.Commission = val; }

			public QuickFix.Fields.Commission Get(QuickFix.Fields.Commission val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Commission val) { return IsSetCommission(); }

			public bool IsSetCommission() { return IsSetField(Tags.Commission); }
			public QuickFix.Fields.CommType CommType
			{
				get
				{
					var val = new QuickFix.Fields.CommType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CommType val) { this.CommType = val; }

			public QuickFix.Fields.CommType Get(QuickFix.Fields.CommType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CommType val) { return IsSetCommType(); }

			public bool IsSetCommType() { return IsSetField(Tags.CommType); }
			public QuickFix.Fields.CommCurrency CommCurrency
			{
				get
				{
					var val = new QuickFix.Fields.CommCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CommCurrency val) { this.CommCurrency = val; }

			public QuickFix.Fields.CommCurrency Get(QuickFix.Fields.CommCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CommCurrency val) { return IsSetCommCurrency(); }

			public bool IsSetCommCurrency() { return IsSetField(Tags.CommCurrency); }
			public QuickFix.Fields.FundRenewWaiv FundRenewWaiv
			{
				get
				{
					var val = new QuickFix.Fields.FundRenewWaiv();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.FundRenewWaiv val) { this.FundRenewWaiv = val; }

			public QuickFix.Fields.FundRenewWaiv Get(QuickFix.Fields.FundRenewWaiv val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.FundRenewWaiv val) { return IsSetFundRenewWaiv(); }

			public bool IsSetFundRenewWaiv() { return IsSetField(Tags.FundRenewWaiv); }
			public QuickFix.Fields.AllocAvgPx AllocAvgPx
			{
				get
				{
					var val = new QuickFix.Fields.AllocAvgPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocAvgPx val) { this.AllocAvgPx = val; }

			public QuickFix.Fields.AllocAvgPx Get(QuickFix.Fields.AllocAvgPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocAvgPx val) { return IsSetAllocAvgPx(); }

			public bool IsSetAllocAvgPx() { return IsSetField(Tags.AllocAvgPx); }
			public QuickFix.Fields.AllocNetMoney AllocNetMoney
			{
				get
				{
					var val = new QuickFix.Fields.AllocNetMoney();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocNetMoney val) { this.AllocNetMoney = val; }

			public QuickFix.Fields.AllocNetMoney Get(QuickFix.Fields.AllocNetMoney val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocNetMoney val) { return IsSetAllocNetMoney(); }

			public bool IsSetAllocNetMoney() { return IsSetField(Tags.AllocNetMoney); }
			public QuickFix.Fields.SettlCurrAmt SettlCurrAmt
			{
				get
				{
					var val = new QuickFix.Fields.SettlCurrAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlCurrAmt val) { this.SettlCurrAmt = val; }

			public QuickFix.Fields.SettlCurrAmt Get(QuickFix.Fields.SettlCurrAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlCurrAmt val) { return IsSetSettlCurrAmt(); }

			public bool IsSetSettlCurrAmt() { return IsSetField(Tags.SettlCurrAmt); }
			public QuickFix.Fields.AllocSettlCurrAmt AllocSettlCurrAmt
			{
				get
				{
					var val = new QuickFix.Fields.AllocSettlCurrAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocSettlCurrAmt val) { this.AllocSettlCurrAmt = val; }

			public QuickFix.Fields.AllocSettlCurrAmt Get(QuickFix.Fields.AllocSettlCurrAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocSettlCurrAmt val) { return IsSetAllocSettlCurrAmt(); }

			public bool IsSetAllocSettlCurrAmt() { return IsSetField(Tags.AllocSettlCurrAmt); }
			public QuickFix.Fields.SettlCurrency SettlCurrency
			{
				get
				{
					var val = new QuickFix.Fields.SettlCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlCurrency val) { this.SettlCurrency = val; }

			public QuickFix.Fields.SettlCurrency Get(QuickFix.Fields.SettlCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlCurrency val) { return IsSetSettlCurrency(); }

			public bool IsSetSettlCurrency() { return IsSetField(Tags.SettlCurrency); }
			public QuickFix.Fields.AllocSettlCurrency AllocSettlCurrency
			{
				get
				{
					var val = new QuickFix.Fields.AllocSettlCurrency();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocSettlCurrency val) { this.AllocSettlCurrency = val; }

			public QuickFix.Fields.AllocSettlCurrency Get(QuickFix.Fields.AllocSettlCurrency val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocSettlCurrency val) { return IsSetAllocSettlCurrency(); }

			public bool IsSetAllocSettlCurrency() { return IsSetField(Tags.AllocSettlCurrency); }
			public QuickFix.Fields.SettlCurrFxRate SettlCurrFxRate
			{
				get
				{
					var val = new QuickFix.Fields.SettlCurrFxRate();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlCurrFxRate val) { this.SettlCurrFxRate = val; }

			public QuickFix.Fields.SettlCurrFxRate Get(QuickFix.Fields.SettlCurrFxRate val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlCurrFxRate val) { return IsSetSettlCurrFxRate(); }

			public bool IsSetSettlCurrFxRate() { return IsSetField(Tags.SettlCurrFxRate); }
			public QuickFix.Fields.SettlCurrFxRateCalc SettlCurrFxRateCalc
			{
				get
				{
					var val = new QuickFix.Fields.SettlCurrFxRateCalc();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlCurrFxRateCalc val) { this.SettlCurrFxRateCalc = val; }

			public QuickFix.Fields.SettlCurrFxRateCalc Get(QuickFix.Fields.SettlCurrFxRateCalc val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlCurrFxRateCalc val) { return IsSetSettlCurrFxRateCalc(); }

			public bool IsSetSettlCurrFxRateCalc() { return IsSetField(Tags.SettlCurrFxRateCalc); }
			public QuickFix.Fields.AccruedInterestAmt AccruedInterestAmt
			{
				get
				{
					var val = new QuickFix.Fields.AccruedInterestAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AccruedInterestAmt val) { this.AccruedInterestAmt = val; }

			public QuickFix.Fields.AccruedInterestAmt Get(QuickFix.Fields.AccruedInterestAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AccruedInterestAmt val) { return IsSetAccruedInterestAmt(); }

			public bool IsSetAccruedInterestAmt() { return IsSetField(Tags.AccruedInterestAmt); }
			public QuickFix.Fields.AllocAccruedInterestAmt AllocAccruedInterestAmt
			{
				get
				{
					var val = new QuickFix.Fields.AllocAccruedInterestAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocAccruedInterestAmt val) { this.AllocAccruedInterestAmt = val; }

			public QuickFix.Fields.AllocAccruedInterestAmt Get(QuickFix.Fields.AllocAccruedInterestAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocAccruedInterestAmt val) { return IsSetAllocAccruedInterestAmt(); }

			public bool IsSetAllocAccruedInterestAmt() { return IsSetField(Tags.AllocAccruedInterestAmt); }
			public QuickFix.Fields.AllocInterestAtMaturity AllocInterestAtMaturity
			{
				get
				{
					var val = new QuickFix.Fields.AllocInterestAtMaturity();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocInterestAtMaturity val) { this.AllocInterestAtMaturity = val; }

			public QuickFix.Fields.AllocInterestAtMaturity Get(QuickFix.Fields.AllocInterestAtMaturity val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocInterestAtMaturity val) { return IsSetAllocInterestAtMaturity(); }

			public bool IsSetAllocInterestAtMaturity() { return IsSetField(Tags.AllocInterestAtMaturity); }
			public QuickFix.Fields.SettlInstMode SettlInstMode
			{
				get
				{
					var val = new QuickFix.Fields.SettlInstMode();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlInstMode val) { this.SettlInstMode = val; }

			public QuickFix.Fields.SettlInstMode Get(QuickFix.Fields.SettlInstMode val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlInstMode val) { return IsSetSettlInstMode(); }

			public bool IsSetSettlInstMode() { return IsSetField(Tags.SettlInstMode); }
			public QuickFix.Fields.NoMiscFees NoMiscFees
			{
				get
				{
					var val = new QuickFix.Fields.NoMiscFees();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoMiscFees val) { this.NoMiscFees = val; }

			public QuickFix.Fields.NoMiscFees Get(QuickFix.Fields.NoMiscFees val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoMiscFees val) { return IsSetNoMiscFees(); }

			public bool IsSetNoMiscFees() { return IsSetField(Tags.NoMiscFees); }
			public QuickFix.Fields.NoClearingInstructions NoClearingInstructions
			{
				get
				{
					var val = new QuickFix.Fields.NoClearingInstructions();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoClearingInstructions val) { this.NoClearingInstructions = val; }

			public QuickFix.Fields.NoClearingInstructions Get(QuickFix.Fields.NoClearingInstructions val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoClearingInstructions val) { return IsSetNoClearingInstructions(); }

			public bool IsSetNoClearingInstructions() { return IsSetField(Tags.NoClearingInstructions); }
			public QuickFix.Fields.ClearingInstruction ClearingInstruction
			{
				get
				{
					var val = new QuickFix.Fields.ClearingInstruction();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ClearingInstruction val) { this.ClearingInstruction = val; }

			public QuickFix.Fields.ClearingInstruction Get(QuickFix.Fields.ClearingInstruction val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ClearingInstruction val) { return IsSetClearingInstruction(); }

			public bool IsSetClearingInstruction() { return IsSetField(Tags.ClearingInstruction); }
			public QuickFix.Fields.ClearingFeeIndicator ClearingFeeIndicator
			{
				get
				{
					var val = new QuickFix.Fields.ClearingFeeIndicator();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.ClearingFeeIndicator val) { this.ClearingFeeIndicator = val; }

			public QuickFix.Fields.ClearingFeeIndicator Get(QuickFix.Fields.ClearingFeeIndicator val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.ClearingFeeIndicator val) { return IsSetClearingFeeIndicator(); }

			public bool IsSetClearingFeeIndicator() { return IsSetField(Tags.ClearingFeeIndicator); }
			public QuickFix.Fields.AllocSettlInstType AllocSettlInstType
			{
				get
				{
					var val = new QuickFix.Fields.AllocSettlInstType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.AllocSettlInstType val) { this.AllocSettlInstType = val; }

			public QuickFix.Fields.AllocSettlInstType Get(QuickFix.Fields.AllocSettlInstType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.AllocSettlInstType val) { return IsSetAllocSettlInstType(); }

			public bool IsSetAllocSettlInstType() { return IsSetField(Tags.AllocSettlInstType); }
			public QuickFix.Fields.SettlDeliveryType SettlDeliveryType
			{
				get
				{
					var val = new QuickFix.Fields.SettlDeliveryType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlDeliveryType val) { this.SettlDeliveryType = val; }

			public QuickFix.Fields.SettlDeliveryType Get(QuickFix.Fields.SettlDeliveryType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlDeliveryType val) { return IsSetSettlDeliveryType(); }

			public bool IsSetSettlDeliveryType() { return IsSetField(Tags.SettlDeliveryType); }
			public QuickFix.Fields.StandInstDbType StandInstDbType
			{
				get
				{
					var val = new QuickFix.Fields.StandInstDbType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StandInstDbType val) { this.StandInstDbType = val; }

			public QuickFix.Fields.StandInstDbType Get(QuickFix.Fields.StandInstDbType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StandInstDbType val) { return IsSetStandInstDbType(); }

			public bool IsSetStandInstDbType() { return IsSetField(Tags.StandInstDbType); }
			public QuickFix.Fields.StandInstDbName StandInstDbName
			{
				get
				{
					var val = new QuickFix.Fields.StandInstDbName();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StandInstDbName val) { this.StandInstDbName = val; }

			public QuickFix.Fields.StandInstDbName Get(QuickFix.Fields.StandInstDbName val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StandInstDbName val) { return IsSetStandInstDbName(); }

			public bool IsSetStandInstDbName() { return IsSetField(Tags.StandInstDbName); }
			public QuickFix.Fields.StandInstDbID StandInstDbID
			{
				get
				{
					var val = new QuickFix.Fields.StandInstDbID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.StandInstDbID val) { this.StandInstDbID = val; }

			public QuickFix.Fields.StandInstDbID Get(QuickFix.Fields.StandInstDbID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.StandInstDbID val) { return IsSetStandInstDbID(); }

			public bool IsSetStandInstDbID() { return IsSetField(Tags.StandInstDbID); }
			public QuickFix.Fields.NoDlvyInst NoDlvyInst
			{
				get
				{
					var val = new QuickFix.Fields.NoDlvyInst();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoDlvyInst val) { this.NoDlvyInst = val; }

			public QuickFix.Fields.NoDlvyInst Get(QuickFix.Fields.NoDlvyInst val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoDlvyInst val) { return IsSetNoDlvyInst(); }

			public bool IsSetNoDlvyInst() { return IsSetField(Tags.NoDlvyInst); }

			public class NoNestedPartyIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.NestedPartyID, Tags.NestedPartyIDSource, Tags.NestedPartyRole, Tags.NoNestedPartySubIDs, 0};

				public NoNestedPartyIDsGroup() : base(Tags.NoNestedPartyIDs, Tags.NestedPartyID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoNestedPartyIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.NestedPartyID NestedPartyID
			{
				get
				{
					var val = new QuickFix.Fields.NestedPartyID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NestedPartyID val) { this.NestedPartyID = val; }

			public QuickFix.Fields.NestedPartyID Get(QuickFix.Fields.NestedPartyID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NestedPartyID val) { return IsSetNestedPartyID(); }

			public bool IsSetNestedPartyID() { return IsSetField(Tags.NestedPartyID); }
			public QuickFix.Fields.NestedPartyIDSource NestedPartyIDSource
			{
				get
				{
					var val = new QuickFix.Fields.NestedPartyIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NestedPartyIDSource val) { this.NestedPartyIDSource = val; }

			public QuickFix.Fields.NestedPartyIDSource Get(QuickFix.Fields.NestedPartyIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NestedPartyIDSource val) { return IsSetNestedPartyIDSource(); }

			public bool IsSetNestedPartyIDSource() { return IsSetField(Tags.NestedPartyIDSource); }
			public QuickFix.Fields.NestedPartyRole NestedPartyRole
			{
				get
				{
					var val = new QuickFix.Fields.NestedPartyRole();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NestedPartyRole val) { this.NestedPartyRole = val; }

			public QuickFix.Fields.NestedPartyRole Get(QuickFix.Fields.NestedPartyRole val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NestedPartyRole val) { return IsSetNestedPartyRole(); }

			public bool IsSetNestedPartyRole() { return IsSetField(Tags.NestedPartyRole); }
			public QuickFix.Fields.NoNestedPartySubIDs NoNestedPartySubIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoNestedPartySubIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoNestedPartySubIDs val) { this.NoNestedPartySubIDs = val; }

			public QuickFix.Fields.NoNestedPartySubIDs Get(QuickFix.Fields.NoNestedPartySubIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoNestedPartySubIDs val) { return IsSetNoNestedPartySubIDs(); }

			public bool IsSetNoNestedPartySubIDs() { return IsSetField(Tags.NoNestedPartySubIDs); }

			public class NoNestedPartySubIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.NestedPartySubID, Tags.NestedPartySubIDType, 0};

				public NoNestedPartySubIDsGroup() : base(Tags.NoNestedPartySubIDs, Tags.NestedPartySubID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoNestedPartySubIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.NestedPartySubID NestedPartySubID
			{
				get
				{
					var val = new QuickFix.Fields.NestedPartySubID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NestedPartySubID val) { this.NestedPartySubID = val; }

			public QuickFix.Fields.NestedPartySubID Get(QuickFix.Fields.NestedPartySubID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NestedPartySubID val) { return IsSetNestedPartySubID(); }

			public bool IsSetNestedPartySubID() { return IsSetField(Tags.NestedPartySubID); }
			public QuickFix.Fields.NestedPartySubIDType NestedPartySubIDType
			{
				get
				{
					var val = new QuickFix.Fields.NestedPartySubIDType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NestedPartySubIDType val) { this.NestedPartySubIDType = val; }

			public QuickFix.Fields.NestedPartySubIDType Get(QuickFix.Fields.NestedPartySubIDType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NestedPartySubIDType val) { return IsSetNestedPartySubIDType(); }

			public bool IsSetNestedPartySubIDType() { return IsSetField(Tags.NestedPartySubIDType); }

			}
			}
			public class NoMiscFeesGroup : Group
			{
				public static int[] fieldOrder = {Tags.MiscFeeAmt, Tags.MiscFeeCurr, Tags.MiscFeeType, Tags.MiscFeeBasis, 0};

				public NoMiscFeesGroup() : base(Tags.NoMiscFees, Tags.MiscFeeAmt, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoMiscFeesGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.MiscFeeAmt MiscFeeAmt
			{
				get
				{
					var val = new QuickFix.Fields.MiscFeeAmt();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MiscFeeAmt val) { this.MiscFeeAmt = val; }

			public QuickFix.Fields.MiscFeeAmt Get(QuickFix.Fields.MiscFeeAmt val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MiscFeeAmt val) { return IsSetMiscFeeAmt(); }

			public bool IsSetMiscFeeAmt() { return IsSetField(Tags.MiscFeeAmt); }
			public QuickFix.Fields.MiscFeeCurr MiscFeeCurr
			{
				get
				{
					var val = new QuickFix.Fields.MiscFeeCurr();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MiscFeeCurr val) { this.MiscFeeCurr = val; }

			public QuickFix.Fields.MiscFeeCurr Get(QuickFix.Fields.MiscFeeCurr val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MiscFeeCurr val) { return IsSetMiscFeeCurr(); }

			public bool IsSetMiscFeeCurr() { return IsSetField(Tags.MiscFeeCurr); }
			public QuickFix.Fields.MiscFeeType MiscFeeType
			{
				get
				{
					var val = new QuickFix.Fields.MiscFeeType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MiscFeeType val) { this.MiscFeeType = val; }

			public QuickFix.Fields.MiscFeeType Get(QuickFix.Fields.MiscFeeType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MiscFeeType val) { return IsSetMiscFeeType(); }

			public bool IsSetMiscFeeType() { return IsSetField(Tags.MiscFeeType); }
			public QuickFix.Fields.MiscFeeBasis MiscFeeBasis
			{
				get
				{
					var val = new QuickFix.Fields.MiscFeeBasis();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.MiscFeeBasis val) { this.MiscFeeBasis = val; }

			public QuickFix.Fields.MiscFeeBasis Get(QuickFix.Fields.MiscFeeBasis val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.MiscFeeBasis val) { return IsSetMiscFeeBasis(); }

			public bool IsSetMiscFeeBasis() { return IsSetField(Tags.MiscFeeBasis); }

			}
			public class NoDlvyInstGroup : Group
			{
				public static int[] fieldOrder = {Tags.SettlInstSource, Tags.DlvyInstType, Tags.NoSettlPartyIDs, 0};

				public NoDlvyInstGroup() : base(Tags.NoDlvyInst, Tags.SettlInstSource, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoDlvyInstGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.SettlInstSource SettlInstSource
			{
				get
				{
					var val = new QuickFix.Fields.SettlInstSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlInstSource val) { this.SettlInstSource = val; }

			public QuickFix.Fields.SettlInstSource Get(QuickFix.Fields.SettlInstSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlInstSource val) { return IsSetSettlInstSource(); }

			public bool IsSetSettlInstSource() { return IsSetField(Tags.SettlInstSource); }
			public QuickFix.Fields.DlvyInstType DlvyInstType
			{
				get
				{
					var val = new QuickFix.Fields.DlvyInstType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.DlvyInstType val) { this.DlvyInstType = val; }

			public QuickFix.Fields.DlvyInstType Get(QuickFix.Fields.DlvyInstType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.DlvyInstType val) { return IsSetDlvyInstType(); }

			public bool IsSetDlvyInstType() { return IsSetField(Tags.DlvyInstType); }
			public QuickFix.Fields.NoSettlPartyIDs NoSettlPartyIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoSettlPartyIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoSettlPartyIDs val) { this.NoSettlPartyIDs = val; }

			public QuickFix.Fields.NoSettlPartyIDs Get(QuickFix.Fields.NoSettlPartyIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoSettlPartyIDs val) { return IsSetNoSettlPartyIDs(); }

			public bool IsSetNoSettlPartyIDs() { return IsSetField(Tags.NoSettlPartyIDs); }

			public class NoSettlPartyIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.SettlPartyID, Tags.SettlPartyIDSource, Tags.SettlPartyRole, Tags.NoSettlPartySubIDs, 0};

				public NoSettlPartyIDsGroup() : base(Tags.NoSettlPartyIDs, Tags.SettlPartyID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoSettlPartyIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.SettlPartyID SettlPartyID
			{
				get
				{
					var val = new QuickFix.Fields.SettlPartyID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlPartyID val) { this.SettlPartyID = val; }

			public QuickFix.Fields.SettlPartyID Get(QuickFix.Fields.SettlPartyID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlPartyID val) { return IsSetSettlPartyID(); }

			public bool IsSetSettlPartyID() { return IsSetField(Tags.SettlPartyID); }
			public QuickFix.Fields.SettlPartyIDSource SettlPartyIDSource
			{
				get
				{
					var val = new QuickFix.Fields.SettlPartyIDSource();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlPartyIDSource val) { this.SettlPartyIDSource = val; }

			public QuickFix.Fields.SettlPartyIDSource Get(QuickFix.Fields.SettlPartyIDSource val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlPartyIDSource val) { return IsSetSettlPartyIDSource(); }

			public bool IsSetSettlPartyIDSource() { return IsSetField(Tags.SettlPartyIDSource); }
			public QuickFix.Fields.SettlPartyRole SettlPartyRole
			{
				get
				{
					var val = new QuickFix.Fields.SettlPartyRole();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlPartyRole val) { this.SettlPartyRole = val; }

			public QuickFix.Fields.SettlPartyRole Get(QuickFix.Fields.SettlPartyRole val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlPartyRole val) { return IsSetSettlPartyRole(); }

			public bool IsSetSettlPartyRole() { return IsSetField(Tags.SettlPartyRole); }
			public QuickFix.Fields.NoSettlPartySubIDs NoSettlPartySubIDs
			{
				get
				{
					var val = new QuickFix.Fields.NoSettlPartySubIDs();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.NoSettlPartySubIDs val) { this.NoSettlPartySubIDs = val; }

			public QuickFix.Fields.NoSettlPartySubIDs Get(QuickFix.Fields.NoSettlPartySubIDs val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.NoSettlPartySubIDs val) { return IsSetNoSettlPartySubIDs(); }

			public bool IsSetNoSettlPartySubIDs() { return IsSetField(Tags.NoSettlPartySubIDs); }

			public class NoSettlPartySubIDsGroup : Group
			{
				public static int[] fieldOrder = {Tags.SettlPartySubID, Tags.SettlPartySubIDType, 0};

				public NoSettlPartySubIDsGroup() : base(Tags.NoSettlPartySubIDs, Tags.SettlPartySubID, fieldOrder)
				{
				}

				public override Group Clone()
				{
					var clone = new NoSettlPartySubIDsGroup();
					clone.CopyStateFrom(this);
					return clone;
				}
			public QuickFix.Fields.SettlPartySubID SettlPartySubID
			{
				get
				{
					var val = new QuickFix.Fields.SettlPartySubID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlPartySubID val) { this.SettlPartySubID = val; }

			public QuickFix.Fields.SettlPartySubID Get(QuickFix.Fields.SettlPartySubID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlPartySubID val) { return IsSetSettlPartySubID(); }

			public bool IsSetSettlPartySubID() { return IsSetField(Tags.SettlPartySubID); }
			public QuickFix.Fields.SettlPartySubIDType SettlPartySubIDType
			{
				get
				{
					var val = new QuickFix.Fields.SettlPartySubIDType();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SettlPartySubIDType val) { this.SettlPartySubIDType = val; }

			public QuickFix.Fields.SettlPartySubIDType Get(QuickFix.Fields.SettlPartySubIDType val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SettlPartySubIDType val) { return IsSetSettlPartySubIDType(); }

			public bool IsSetSettlPartySubIDType() { return IsSetField(Tags.SettlPartySubIDType); }

			}
			}
			}
			}
		}
	}
}
