﻿using QuickFix.Fields;

namespace QuickFix
{
	namespace FIX43
	{
		public class SecurityStatus : Message
		{
			public const string MsgType = "f";

			public SecurityStatus() : base()
			{
				this.Header.SetField(new QuickFix.Fields.MsgType(MsgType));
			}

			public SecurityStatus(QuickFix.Fields.Symbol aSymbol)
				   : this()
			{
				this.Symbol = aSymbol;
			}

			public QuickFix.Fields.SecurityStatusReqID SecurityStatusReqID
			{
				get
				{
					var val = new QuickFix.Fields.SecurityStatusReqID();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityStatusReqID val) { this.SecurityStatusReqID = val; }

			public QuickFix.Fields.SecurityStatusReqID Get(QuickFix.Fields.SecurityStatusReqID val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityStatusReqID val) { return IsSetSecurityStatusReqID(); }

			public bool IsSetSecurityStatusReqID() { return IsSetField(Tags.SecurityStatusReqID); }
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
			public QuickFix.Fields.UnsolicitedIndicator UnsolicitedIndicator
			{
				get
				{
					var val = new QuickFix.Fields.UnsolicitedIndicator();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.UnsolicitedIndicator val) { this.UnsolicitedIndicator = val; }

			public QuickFix.Fields.UnsolicitedIndicator Get(QuickFix.Fields.UnsolicitedIndicator val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.UnsolicitedIndicator val) { return IsSetUnsolicitedIndicator(); }

			public bool IsSetUnsolicitedIndicator() { return IsSetField(Tags.UnsolicitedIndicator); }
			public QuickFix.Fields.SecurityTradingStatus SecurityTradingStatus
			{
				get
				{
					var val = new QuickFix.Fields.SecurityTradingStatus();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SecurityTradingStatus val) { this.SecurityTradingStatus = val; }

			public QuickFix.Fields.SecurityTradingStatus Get(QuickFix.Fields.SecurityTradingStatus val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SecurityTradingStatus val) { return IsSetSecurityTradingStatus(); }

			public bool IsSetSecurityTradingStatus() { return IsSetField(Tags.SecurityTradingStatus); }
			public QuickFix.Fields.FinancialStatus FinancialStatus
			{
				get
				{
					var val = new QuickFix.Fields.FinancialStatus();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.FinancialStatus val) { this.FinancialStatus = val; }

			public QuickFix.Fields.FinancialStatus Get(QuickFix.Fields.FinancialStatus val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.FinancialStatus val) { return IsSetFinancialStatus(); }

			public bool IsSetFinancialStatus() { return IsSetField(Tags.FinancialStatus); }
			public QuickFix.Fields.CorporateAction CorporateAction
			{
				get
				{
					var val = new QuickFix.Fields.CorporateAction();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.CorporateAction val) { this.CorporateAction = val; }

			public QuickFix.Fields.CorporateAction Get(QuickFix.Fields.CorporateAction val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.CorporateAction val) { return IsSetCorporateAction(); }

			public bool IsSetCorporateAction() { return IsSetField(Tags.CorporateAction); }
			public QuickFix.Fields.HaltReason HaltReason
			{
				get
				{
					var val = new QuickFix.Fields.HaltReason();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.HaltReason val) { this.HaltReason = val; }

			public QuickFix.Fields.HaltReason Get(QuickFix.Fields.HaltReason val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.HaltReason val) { return IsSetHaltReason(); }

			public bool IsSetHaltReason() { return IsSetField(Tags.HaltReason); }
			public QuickFix.Fields.InViewOfCommon InViewOfCommon
			{
				get
				{
					var val = new QuickFix.Fields.InViewOfCommon();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.InViewOfCommon val) { this.InViewOfCommon = val; }

			public QuickFix.Fields.InViewOfCommon Get(QuickFix.Fields.InViewOfCommon val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.InViewOfCommon val) { return IsSetInViewOfCommon(); }

			public bool IsSetInViewOfCommon() { return IsSetField(Tags.InViewOfCommon); }
			public QuickFix.Fields.DueToRelated DueToRelated
			{
				get
				{
					var val = new QuickFix.Fields.DueToRelated();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.DueToRelated val) { this.DueToRelated = val; }

			public QuickFix.Fields.DueToRelated Get(QuickFix.Fields.DueToRelated val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.DueToRelated val) { return IsSetDueToRelated(); }

			public bool IsSetDueToRelated() { return IsSetField(Tags.DueToRelated); }
			public QuickFix.Fields.BuyVolume BuyVolume
			{
				get
				{
					var val = new QuickFix.Fields.BuyVolume();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.BuyVolume val) { this.BuyVolume = val; }

			public QuickFix.Fields.BuyVolume Get(QuickFix.Fields.BuyVolume val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.BuyVolume val) { return IsSetBuyVolume(); }

			public bool IsSetBuyVolume() { return IsSetField(Tags.BuyVolume); }
			public QuickFix.Fields.SellVolume SellVolume
			{
				get
				{
					var val = new QuickFix.Fields.SellVolume();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.SellVolume val) { this.SellVolume = val; }

			public QuickFix.Fields.SellVolume Get(QuickFix.Fields.SellVolume val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.SellVolume val) { return IsSetSellVolume(); }

			public bool IsSetSellVolume() { return IsSetField(Tags.SellVolume); }
			public QuickFix.Fields.HighPx HighPx
			{
				get
				{
					var val = new QuickFix.Fields.HighPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.HighPx val) { this.HighPx = val; }

			public QuickFix.Fields.HighPx Get(QuickFix.Fields.HighPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.HighPx val) { return IsSetHighPx(); }

			public bool IsSetHighPx() { return IsSetField(Tags.HighPx); }
			public QuickFix.Fields.LowPx LowPx
			{
				get
				{
					var val = new QuickFix.Fields.LowPx();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.LowPx val) { this.LowPx = val; }

			public QuickFix.Fields.LowPx Get(QuickFix.Fields.LowPx val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.LowPx val) { return IsSetLowPx(); }

			public bool IsSetLowPx() { return IsSetField(Tags.LowPx); }
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
			public QuickFix.Fields.Adjustment Adjustment
			{
				get
				{
					var val = new QuickFix.Fields.Adjustment();
					GetField(val);
					return val;
				}
				set { SetField(value); }
			}

			public void Set(QuickFix.Fields.Adjustment val) { this.Adjustment = val; }

			public QuickFix.Fields.Adjustment Get(QuickFix.Fields.Adjustment val)
			{
				GetField(val);
				return val;
			}

			public bool IsSet(QuickFix.Fields.Adjustment val) { return IsSetAdjustment(); }

			public bool IsSetAdjustment() { return IsSetField(Tags.Adjustment); }
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
		}
	}
}
