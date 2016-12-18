module Fix44.Fields


open UTCDateTime
open MonthYear


type Account =
    |Account of string
     member x.Value = let (Account v) = x in v


type AdvId =
    |AdvId of string
     member x.Value = let (AdvId v) = x in v


type AdvRefID =
    |AdvRefID of string
     member x.Value = let (AdvRefID v) = x in v


type AdvSide =
    | Buy
    | Sell
    | Cross
    | Trade


type AdvTransType =
    | New
    | Cancel
    | Replace


type AvgPx =
    |AvgPx of decimal
     member x.Value = let (AvgPx v) = x in v


type BeginSeqNo =
    |BeginSeqNo of uint32
     member x.Value = let (BeginSeqNo v) = x in v


type BeginString =
    |BeginString of string
     member x.Value = let (BeginString v) = x in v


type BodyLength =
    |BodyLength of int
     member x.Value = let (BodyLength v) = x in v


type CheckSum =
    |CheckSum of string
     member x.Value = let (CheckSum v) = x in v


type ClOrdID =
    |ClOrdID of string
     member x.Value = let (ClOrdID v) = x in v


type Commission =
    |Commission of decimal
     member x.Value = let (Commission v) = x in v


type CommType =
    | PerUnit
    | Percentage
    | Absolute
    | PercentageWaivedCashDiscount
    | PercentageWaivedEnhancedUnits
    | PointsPerBondOrOrContract


type CumQty =
    |CumQty of decimal
     member x.Value = let (CumQty v) = x in v


type Currency =
    |Currency of string
     member x.Value = let (Currency v) = x in v


type EndSeqNo =
    |EndSeqNo of uint32
     member x.Value = let (EndSeqNo v) = x in v


type ExecID =
    |ExecID of string
     member x.Value = let (ExecID v) = x in v


type ExecInst =
    | NotHeld
    | Work
    | GoAlong
    | OverTheDay
    | Held
    | ParticipateDontInitiate
    | StrictScale
    | TryToScale
    | StayOnBidside
    | StayOnOfferside
    | NoCross
    | OkToCross
    | CallFirst
    | PercentOfVolume
    | DoNotIncrease
    | DoNotReduce
    | AllOrNone
    | ReinstateOnSystemFailure
    | InstitutionsOnly
    | ReinstateOnTradingHalt
    | CancelOnTradingHalt
    | LastPeg
    | MidPrice
    | NonNegotiable
    | OpeningPeg
    | MarketPeg
    | CancelOnSystemFailure
    | PrimaryPeg
    | Suspend
    | FixedPegToLocalBestBidOrOfferAtTimeOfOrder
    | CustomerDisplayInstruction
    | Netting
    | PegToVwap
    | TradeAlong
    | TryToStop
    | CancelIfNotBest
    | TrailingStopPeg
    | StrictLimit
    | IgnorePriceValidityChecks
    | PegToLimitPrice
    | WorkToTargetStrategy


type ExecRefID =
    |ExecRefID of string
     member x.Value = let (ExecRefID v) = x in v


type HandlInst =
    | AutomatedExecutionOrderPrivate
    | AutomatedExecutionOrderPublic
    | ManualOrder


type SecurityIDSource =
    | Cusip
    | Sedol
    | Quik
    | IsinNumber
    | RicCode
    | IsoCurrencyCode
    | IsoCountryCode
    | ExchangeSymbol
    | ConsolidatedTapeAssociation
    | BloombergSymbol
    | Wertpapier
    | Dutch
    | Valoren
    | Sicovam
    | Belgian
    | Common
    | ClearingHouseClearingOrganization
    | IsdaFpmlProductSpecification
    | OptionsPriceReportingAuthority


type IOIid =
    |IOIid of string
     member x.Value = let (IOIid v) = x in v


type IOIQltyInd =
    | Low
    | Medium
    | High


type IOIRefID =
    |IOIRefID of string
     member x.Value = let (IOIRefID v) = x in v


type IOIQty =
    |IOIQty of string
     member x.Value = let (IOIQty v) = x in v


type IOITransType =
    | New
    | Cancel
    | Replace


type LastCapacity =
    | Agent
    | CrossAsAgent
    | CrossAsPrincipal
    | Principal


type LastMkt =
    |LastMkt of string
     member x.Value = let (LastMkt v) = x in v


type LastPx =
    |LastPx of decimal
     member x.Value = let (LastPx v) = x in v


type LastQty =
    |LastQty of decimal
     member x.Value = let (LastQty v) = x in v


type LinesOfText =
    |LinesOfText of int
     member x.Value = let (LinesOfText v) = x in v


type MsgSeqNum =
    |MsgSeqNum of uint32
     member x.Value = let (MsgSeqNum v) = x in v


type MsgType =
    | Heartbeat
    | TestRequest
    | ResendRequest
    | Reject
    | SequenceReset
    | Logout
    | IndicationOfInterest
    | Advertisement
    | ExecutionReport
    | OrderCancelReject
    | Logon
    | News
    | Email
    | OrderSingle
    | OrderList
    | OrderCancelRequest
    | OrderCancelReplaceRequest
    | OrderStatusRequest
    | AllocationInstruction
    | ListCancelRequest
    | ListExecute
    | ListStatusRequest
    | ListStatus
    | AllocationInstructionAck
    | DontKnowTrade
    | QuoteRequest
    | Quote
    | SettlementInstructions
    | MarketDataRequest
    | MarketDataSnapshotFullRefresh
    | MarketDataIncrementalRefresh
    | MarketDataRequestReject
    | QuoteCancel
    | QuoteStatusRequest
    | MassQuoteAcknowledgement
    | SecurityDefinitionRequest
    | SecurityDefinition
    | SecurityStatusRequest
    | SecurityStatus
    | TradingSessionStatusRequest
    | TradingSessionStatus
    | MassQuote
    | BusinessMessageReject
    | BidRequest
    | BidResponse
    | ListStrikePrice
    | XmlMessage
    | RegistrationInstructions
    | RegistrationInstructionsResponse
    | OrderMassCancelRequest
    | OrderMassCancelReport
    | NewOrderCross
    | CrossOrderCancelReplaceRequest
    | CrossOrderCancelRequest
    | SecurityTypeRequest
    | SecurityTypes
    | SecurityListRequest
    | SecurityList
    | DerivativeSecurityListRequest
    | DerivativeSecurityList
    | NewOrderMultileg
    | MultilegOrderCancelReplace
    | TradeCaptureReportRequest
    | TradeCaptureReport
    | OrderMassStatusRequest
    | QuoteRequestReject
    | RfqRequest
    | QuoteStatusReport
    | QuoteResponse
    | Confirmation
    | PositionMaintenanceRequest
    | PositionMaintenanceReport
    | RequestForPositions
    | RequestForPositionsAck
    | PositionReport
    | TradeCaptureReportRequestAck
    | TradeCaptureReportAck
    | AllocationReport
    | AllocationReportAck
    | ConfirmationAck
    | SettlementInstructionRequest
    | AssignmentReport
    | CollateralRequest
    | CollateralAssignment
    | CollateralResponse
    | CollateralReport
    | CollateralInquiry
    | NetworkStatusRequest
    | NetworkStatusResponse
    | UserRequest
    | UserResponse
    | CollateralInquiryAck
    | ConfirmationRequest


type NewSeqNo =
    |NewSeqNo of uint32
     member x.Value = let (NewSeqNo v) = x in v


type OrderID =
    |OrderID of string
     member x.Value = let (OrderID v) = x in v


type OrderQty =
    |OrderQty of decimal
     member x.Value = let (OrderQty v) = x in v


type OrdStatus =
    | New
    | PartiallyFilled
    | Filled
    | DoneForDay
    | Canceled
    | Replaced
    | PendingCancel
    | Stopped
    | Rejected
    | Suspended
    | PendingNew
    | Calculated
    | Expired
    | AcceptedForBidding
    | PendingReplace


type OrdType =
    | Market
    | Limit
    | Stop
    | StopLimit
    | MarketOnClose
    | WithOrWithout
    | LimitOrBetter
    | LimitWithOrWithout
    | OnBasis
    | OnClose
    | LimitOnClose
    | ForexMarket
    | PreviouslyQuoted
    | PreviouslyIndicated
    | ForexLimit
    | ForexSwap
    | ForexPreviouslyQuoted
    | Funari
    | MarketIfTouched
    | MarketWithLeftoverAsLimit
    | PreviousFundValuationPoint
    | NextFundValuationPoint
    | Pegged


type OrigClOrdID =
    |OrigClOrdID of string
     member x.Value = let (OrigClOrdID v) = x in v


type OrigTime =
    |OrigTime of UTCTimestamp
     member x.Value = let (OrigTime v) = x in v


type PossDupFlag =
    |PossDupFlag of bool
     member x.Value = let (PossDupFlag v) = x in v


type Price =
    |Price of decimal
     member x.Value = let (Price v) = x in v


type RefSeqNum =
    |RefSeqNum of uint32
     member x.Value = let (RefSeqNum v) = x in v


type SecurityID =
    |SecurityID of string
     member x.Value = let (SecurityID v) = x in v


type SenderCompID =
    |SenderCompID of string
     member x.Value = let (SenderCompID v) = x in v


type SenderSubID =
    |SenderSubID of string
     member x.Value = let (SenderSubID v) = x in v


type SendingTime =
    |SendingTime of UTCTimestamp
     member x.Value = let (SendingTime v) = x in v


type Quantity =
    |Quantity of decimal
     member x.Value = let (Quantity v) = x in v


type Side =
    | Buy
    | Sell
    | BuyMinus
    | SellPlus
    | SellShort
    | SellShortExempt
    | Undisclosed
    | Cross
    | CrossShort
    | CrossShortExempt
    | AsDefined
    | Opposite
    | Subscribe
    | Redeem
    | Lend
    | Borrow


type Symbol =
    |Symbol of string
     member x.Value = let (Symbol v) = x in v


type TargetCompID =
    |TargetCompID of string
     member x.Value = let (TargetCompID v) = x in v


type TargetSubID =
    |TargetSubID of string
     member x.Value = let (TargetSubID v) = x in v


type Text =
    |Text of string
     member x.Value = let (Text v) = x in v


type TimeInForce =
    | Day
    | GoodTillCancel
    | AtTheOpening
    | ImmediateOrCancel
    | FillOrKill
    | GoodTillCrossing
    | GoodTillDate
    | AtTheClose


type TransactTime =
    |TransactTime of UTCTimestamp
     member x.Value = let (TransactTime v) = x in v


type Urgency =
    | Normal
    | Flash
    | Background


type ValidUntilTime =
    |ValidUntilTime of UTCTimestamp
     member x.Value = let (ValidUntilTime v) = x in v


type SettlType =
    | Regular
    | Cash
    | NextDay
    | TPlus2
    | TPlus3
    | TPlus4
    | Future
    | WhenAndIfIssued
    | SellersOption
    | TPlus5


type SettlDate =
    |SettlDate of string
     member x.Value = let (SettlDate v) = x in v


type SymbolSfx =
    | WhenIssued
    | AEucpWithLumpSumInterest


type ListID =
    |ListID of string
     member x.Value = let (ListID v) = x in v


type ListSeqNo =
    |ListSeqNo of int
     member x.Value = let (ListSeqNo v) = x in v


type TotNoOrders =
    |TotNoOrders of int
     member x.Value = let (TotNoOrders v) = x in v


type ListExecInst =
    |ListExecInst of string
     member x.Value = let (ListExecInst v) = x in v


type AllocID =
    |AllocID of string
     member x.Value = let (AllocID v) = x in v


type AllocTransType =
    | New
    | Replace
    | Cancel


type RefAllocID =
    |RefAllocID of string
     member x.Value = let (RefAllocID v) = x in v


type NoOrders =
    |NoOrders of int
     member x.Value = let (NoOrders v) = x in v


type AvgPxPrecision =
    |AvgPxPrecision of int
     member x.Value = let (AvgPxPrecision v) = x in v


type TradeDate =
    |TradeDate of string
     member x.Value = let (TradeDate v) = x in v


type PositionEffect =
    | Open
    | Close
    | Rolled
    | Fifo


type NoAllocs =
    |NoAllocs of int
     member x.Value = let (NoAllocs v) = x in v


type AllocAccount =
    |AllocAccount of string
     member x.Value = let (AllocAccount v) = x in v


type AllocQty =
    |AllocQty of decimal
     member x.Value = let (AllocQty v) = x in v


type ProcessCode =
    | Regular
    | SoftDollar
    | StepIn
    | StepOut
    | SoftDollarStepIn
    | SoftDollarStepOut
    | PlanSponsor


type NoRpts =
    |NoRpts of int
     member x.Value = let (NoRpts v) = x in v


type RptSeq =
    |RptSeq of int
     member x.Value = let (RptSeq v) = x in v


type CxlQty =
    |CxlQty of decimal
     member x.Value = let (CxlQty v) = x in v


type NoDlvyInst =
    |NoDlvyInst of int
     member x.Value = let (NoDlvyInst v) = x in v


type AllocStatus =
    | Accepted
    | BlockLevelReject
    | AccountLevelReject
    | Received
    | Incomplete
    | RejectedByIntermediary


type AllocRejCode =
    | UnknownAccount
    | IncorrectQuantity
    | IncorrectAveragePrice
    | UnknownExecutingBrokerMnemonic
    | CommissionDifference
    | UnknownOrderid
    | UnknownListid
    | Other
    | IncorrectAllocatedQuantity
    | CalculationDifference
    | UnknownOrStaleExecId
    | MismatchedDataValue
    | UnknownClordid
    | WarehouseRequestRejected


// compound len+str field
type Signature =
    |Signature of byte []
     member x.Value = let (Signature v) = x in v


// compound len+str field
type SecureData =
    |SecureData of byte []
     member x.Value = let (SecureData v) = x in v


type EmailType =
    | New
    | Reply
    | AdminReply


// compound len+str field
type RawData =
    |RawData of byte []
     member x.Value = let (RawData v) = x in v


type PossResend =
    |PossResend of bool
     member x.Value = let (PossResend v) = x in v


type EncryptMethod =
    | NoneOther
    | Pkcs
    | Des
    | PkcsDes
    | PgpDes
    | PgpDesMd5
    | PemDesMd5


type StopPx =
    |StopPx of decimal
     member x.Value = let (StopPx v) = x in v


type ExDestination =
    |ExDestination of string
     member x.Value = let (ExDestination v) = x in v


type CxlRejReason =
    | TooLateToCancel
    | UnknownOrder
    | BrokerExchangeOption
    | OrderAlreadyInPendingCancelOrPendingReplaceStatus
    | UnableToProcessOrderMassCancelRequest
    | OrigordmodtimeDidNotMatchLastTransacttimeOfOrder
    | DuplicateClordidReceived
    | Other


type OrdRejReason =
    | BrokerExchangeOption
    | UnknownSymbol
    | ExchangeClosed
    | OrderExceedsLimit
    | TooLateToEnter
    | UnknownOrder
    | DuplicateOrder
    | DuplicateOfAVerballyCommunicatedOrder
    | StaleOrder
    | TradeAlongRequired
    | InvalidInvestorId
    | UnsupportedOrderCharacteristic
    | SurveillenceOption
    | IncorrectQuantity
    | IncorrectAllocatedQuantity
    | UnknownAccount
    | Other


type IOIQualifier =
    | AllOrNone
    | MarketOnClose
    | AtTheClose
    | Vwap
    | InTouchWith
    | Limit
    | MoreBehind
    | AtTheOpen
    | TakingAPosition
    | AtTheMarket
    | ReadyToTrade
    | PortfolioShown
    | ThroughTheDay
    | Versus
    | IndicationWorkingAway
    | CrossingOpportunity
    | AtTheMidpoint
    | PreOpen


type WaveNo =
    |WaveNo of string
     member x.Value = let (WaveNo v) = x in v


type Issuer =
    |Issuer of string
     member x.Value = let (Issuer v) = x in v


type SecurityDesc =
    |SecurityDesc of string
     member x.Value = let (SecurityDesc v) = x in v


type HeartBtInt =
    |HeartBtInt of int
     member x.Value = let (HeartBtInt v) = x in v


type MinQty =
    |MinQty of decimal
     member x.Value = let (MinQty v) = x in v


type MaxFloor =
    |MaxFloor of decimal
     member x.Value = let (MaxFloor v) = x in v


type TestReqID =
    |TestReqID of string
     member x.Value = let (TestReqID v) = x in v


type ReportToExch =
    |ReportToExch of bool
     member x.Value = let (ReportToExch v) = x in v


type LocateReqd =
    |LocateReqd of bool
     member x.Value = let (LocateReqd v) = x in v


type OnBehalfOfCompID =
    |OnBehalfOfCompID of string
     member x.Value = let (OnBehalfOfCompID v) = x in v


type OnBehalfOfSubID =
    |OnBehalfOfSubID of string
     member x.Value = let (OnBehalfOfSubID v) = x in v


type QuoteID =
    |QuoteID of string
     member x.Value = let (QuoteID v) = x in v


type NetMoney =
    |NetMoney of decimal
     member x.Value = let (NetMoney v) = x in v


type SettlCurrAmt =
    |SettlCurrAmt of decimal
     member x.Value = let (SettlCurrAmt v) = x in v


type SettlCurrency =
    |SettlCurrency of string
     member x.Value = let (SettlCurrency v) = x in v


type ForexReq =
    |ForexReq of bool
     member x.Value = let (ForexReq v) = x in v


type OrigSendingTime =
    |OrigSendingTime of UTCTimestamp
     member x.Value = let (OrigSendingTime v) = x in v


type GapFillFlag =
    |GapFillFlag of bool
     member x.Value = let (GapFillFlag v) = x in v


type NoExecs =
    |NoExecs of int
     member x.Value = let (NoExecs v) = x in v


type ExpireTime =
    |ExpireTime of UTCTimestamp
     member x.Value = let (ExpireTime v) = x in v


type DKReason =
    | UnknownSymbol
    | WrongSide
    | QuantityExceedsOrder
    | NoMatchingOrder
    | PriceExceedsLimit
    | CalculationDifference
    | Other


type DeliverToCompID =
    |DeliverToCompID of string
     member x.Value = let (DeliverToCompID v) = x in v


type DeliverToSubID =
    |DeliverToSubID of string
     member x.Value = let (DeliverToSubID v) = x in v


type IOINaturalFlag =
    |IOINaturalFlag of bool
     member x.Value = let (IOINaturalFlag v) = x in v


type QuoteReqID =
    |QuoteReqID of string
     member x.Value = let (QuoteReqID v) = x in v


type BidPx =
    |BidPx of decimal
     member x.Value = let (BidPx v) = x in v


type OfferPx =
    |OfferPx of decimal
     member x.Value = let (OfferPx v) = x in v


type BidSize =
    |BidSize of decimal
     member x.Value = let (BidSize v) = x in v


type OfferSize =
    |OfferSize of decimal
     member x.Value = let (OfferSize v) = x in v


type NoMiscFees =
    |NoMiscFees of int
     member x.Value = let (NoMiscFees v) = x in v


type MiscFeeAmt =
    |MiscFeeAmt of decimal
     member x.Value = let (MiscFeeAmt v) = x in v


type MiscFeeCurr =
    |MiscFeeCurr of string
     member x.Value = let (MiscFeeCurr v) = x in v


type MiscFeeType =
    | Regulatory
    | Tax
    | LocalCommission
    | ExchangeFees
    | Stamp
    | Levy
    | Other
    | Markup
    | ConsumptionTax
    | PerTransaction
    | Conversion
    | Agent


type PrevClosePx =
    |PrevClosePx of decimal
     member x.Value = let (PrevClosePx v) = x in v


type ResetSeqNumFlag =
    |ResetSeqNumFlag of bool
     member x.Value = let (ResetSeqNumFlag v) = x in v


type SenderLocationID =
    |SenderLocationID of string
     member x.Value = let (SenderLocationID v) = x in v


type TargetLocationID =
    |TargetLocationID of string
     member x.Value = let (TargetLocationID v) = x in v


type OnBehalfOfLocationID =
    |OnBehalfOfLocationID of string
     member x.Value = let (OnBehalfOfLocationID v) = x in v


type DeliverToLocationID =
    |DeliverToLocationID of string
     member x.Value = let (DeliverToLocationID v) = x in v


type NoRelatedSym =
    |NoRelatedSym of int
     member x.Value = let (NoRelatedSym v) = x in v


type Subject =
    |Subject of string
     member x.Value = let (Subject v) = x in v


type Headline =
    |Headline of string
     member x.Value = let (Headline v) = x in v


type URLLink =
    |URLLink of string
     member x.Value = let (URLLink v) = x in v


type ExecType =
    | New
    | PartialFill
    | Fill
    | DoneForDay
    | Canceled
    | Replace
    | PendingCancel
    | Stopped
    | Rejected
    | Suspended
    | PendingNew
    | Calculated
    | Expired
    | Restated
    | PendingReplace
    | Trade
    | TradeCorrect
    | TradeCancel
    | OrderStatus


type LeavesQty =
    |LeavesQty of decimal
     member x.Value = let (LeavesQty v) = x in v


type CashOrderQty =
    |CashOrderQty of decimal
     member x.Value = let (CashOrderQty v) = x in v


type AllocAvgPx =
    |AllocAvgPx of decimal
     member x.Value = let (AllocAvgPx v) = x in v


type AllocNetMoney =
    |AllocNetMoney of decimal
     member x.Value = let (AllocNetMoney v) = x in v


type SettlCurrFxRate =
    |SettlCurrFxRate of decimal
     member x.Value = let (SettlCurrFxRate v) = x in v


type SettlCurrFxRateCalc =
    | Multiply
    | Divide


type NumDaysInterest =
    |NumDaysInterest of int
     member x.Value = let (NumDaysInterest v) = x in v


type AccruedInterestRate =
    |AccruedInterestRate of decimal
     member x.Value = let (AccruedInterestRate v) = x in v


type AccruedInterestAmt =
    |AccruedInterestAmt of decimal
     member x.Value = let (AccruedInterestAmt v) = x in v


type SettlInstMode =
    | Default
    | StandingInstructionsProvided
    | SpecificOrderForASingleAccount
    | RequestReject


type AllocText =
    |AllocText of string
     member x.Value = let (AllocText v) = x in v


type SettlInstID =
    |SettlInstID of string
     member x.Value = let (SettlInstID v) = x in v


type SettlInstTransType =
    | New
    | Cancel
    | Replace
    | Restate


type EmailThreadID =
    |EmailThreadID of string
     member x.Value = let (EmailThreadID v) = x in v


type SettlInstSource =
    | BrokersInstructions
    | InstitutionsInstructions
    | Investor


type SecurityType =
    | EuroSupranationalCoupons
    | FederalAgencyCoupon
    | FederalAgencyDiscountNote
    | PrivateExportFunding
    | UsdSupranationalCoupons
    | Future
    | Option
    | CorporateBond
    | CorporatePrivatePlacement
    | ConvertibleBond
    | DualCurrency
    | EuroCorporateBond
    | IndexedLinked
    | StructuredNotes
    | YankeeCorporateBond
    | ForeignExchangeContract
    | CommonStock
    | PreferredStock
    | BradyBond
    | EuroSovereigns
    | UsTreasuryBond
    | InterestStripFromAnyBondOrNote
    | TreasuryInflationProtectedSecurities
    | PrincipalStripOfACallableBondOrNote
    | PrincipalStripFromANonCallableBondOrNote
    | UsTreasuryNote
    | UsTreasuryBill
    | Repurchase
    | Forward
    | BuySellback
    | SecuritiesLoan
    | SecuritiesPledge
    | TermLoan
    | RevolverLoan
    | RevolverTermLoan
    | BridgeLoan
    | LetterOfCredit
    | SwingLineFacility
    | DebtorInPossession
    | Defaulted
    | Withdrawn
    | Replaced
    | Matured
    | AmendedAndRestated
    | Retired
    | BankersAcceptance
    | BankNotes
    | BillOfExchanges
    | CertificateOfDeposit
    | CallLoans
    | CommercialPaper
    | DepositNotes
    | EuroCertificateOfDeposit
    | EuroCommercialPaper
    | LiquidityNote
    | MediumTermNotes
    | Overnight
    | PromissoryNote
    | PlazosFijos
    | ShortTermLoanNote
    | TimeDeposit
    | ExtendedCommNote
    | YankeeCertificateOfDeposit
    | AssetBackedSecurities
    | CorpMortgageBackedSecurities
    | CollateralizedMortgageObligation
    | IoetteMortgage
    | MortgageBackedSecurities
    | MortgageInterestOnly
    | MortgagePrincipalOnly
    | MortgagePrivatePlacement
    | MiscellaneousPassThrough
    | Pfandbriefe
    | ToBeAnnounced
    | OtherAnticipationNotes
    | CertificateOfObligation
    | CertificateOfParticipation
    | GeneralObligationBonds
    | MandatoryTender
    | RevenueAnticipationNote
    | RevenueBonds
    | SpecialAssessment
    | SpecialObligation
    | SpecialTax
    | TaxAnticipationNote
    | TaxAllocation
    | TaxExemptCommercialPaper
    | TaxAndRevenueAnticipationNote
    | VariableRateDemandNote
    | Warrant
    | MutualFund
    | MultiLegInstrument
    | NoSecurityType
    | Wildcard


type EffectiveTime =
    |EffectiveTime of UTCTimestamp
     member x.Value = let (EffectiveTime v) = x in v


type StandInstDbType =
    | Other
    | DtcSid
    | ThomsonAlert
    | AGlobalCustodian
    | Accountnet


type StandInstDbName =
    |StandInstDbName of string
     member x.Value = let (StandInstDbName v) = x in v


type StandInstDbID =
    |StandInstDbID of string
     member x.Value = let (StandInstDbID v) = x in v


type SettlDeliveryType =
    | VersusPayment
    | Free
    | TriParty
    | HoldInCustody


type BidSpotRate =
    |BidSpotRate of decimal
     member x.Value = let (BidSpotRate v) = x in v


type BidForwardPoints =
    |BidForwardPoints of decimal
     member x.Value = let (BidForwardPoints v) = x in v


type OfferSpotRate =
    |OfferSpotRate of decimal
     member x.Value = let (OfferSpotRate v) = x in v


type OfferForwardPoints =
    |OfferForwardPoints of decimal
     member x.Value = let (OfferForwardPoints v) = x in v


type OrderQty2 =
    |OrderQty2 of decimal
     member x.Value = let (OrderQty2 v) = x in v


type SettlDate2 =
    |SettlDate2 of string
     member x.Value = let (SettlDate2 v) = x in v


type LastSpotRate =
    |LastSpotRate of decimal
     member x.Value = let (LastSpotRate v) = x in v


type LastForwardPoints =
    |LastForwardPoints of decimal
     member x.Value = let (LastForwardPoints v) = x in v


type AllocLinkID =
    |AllocLinkID of string
     member x.Value = let (AllocLinkID v) = x in v


type AllocLinkType =
    | FXNetting
    | FXSwap


type SecondaryOrderID =
    |SecondaryOrderID of string
     member x.Value = let (SecondaryOrderID v) = x in v


type NoIOIQualifiers =
    |NoIOIQualifiers of int
     member x.Value = let (NoIOIQualifiers v) = x in v


type MaturityMonthYear =
    |MaturityMonthYear of MonthYear
     member x.Value = let (MaturityMonthYear v) = x in v


type PutOrCall =
    | Put
    | Call


type StrikePrice =
    |StrikePrice of decimal
     member x.Value = let (StrikePrice v) = x in v


type CoveredOrUncovered =
    | Covered
    | Uncovered


type OptAttribute =
    |OptAttribute of char
     member x.Value = let (OptAttribute v) = x in v


type SecurityExchange =
    |SecurityExchange of string
     member x.Value = let (SecurityExchange v) = x in v


type NotifyBrokerOfCredit =
    |NotifyBrokerOfCredit of bool
     member x.Value = let (NotifyBrokerOfCredit v) = x in v


type AllocHandlInst =
    | Match
    | Forward
    | ForwardAndMatch


type MaxShow =
    |MaxShow of decimal
     member x.Value = let (MaxShow v) = x in v


type PegOffsetValue =
    |PegOffsetValue of decimal
     member x.Value = let (PegOffsetValue v) = x in v


// compound len+str field
type XmlData =
    |XmlData of byte []
     member x.Value = let (XmlData v) = x in v


type SettlInstRefID =
    |SettlInstRefID of string
     member x.Value = let (SettlInstRefID v) = x in v


type NoRoutingIDs =
    |NoRoutingIDs of int
     member x.Value = let (NoRoutingIDs v) = x in v


type RoutingType =
    | TargetFirm
    | TargetList
    | BlockFirm
    | BlockList


type RoutingID =
    |RoutingID of string
     member x.Value = let (RoutingID v) = x in v


type Spread =
    |Spread of decimal
     member x.Value = let (Spread v) = x in v


type BenchmarkCurveCurrency =
    |BenchmarkCurveCurrency of string
     member x.Value = let (BenchmarkCurveCurrency v) = x in v


type BenchmarkCurveName =
    | Muniaaa
    | Futureswap
    | Libid
    | Libor
    | Other
    | Swap
    | Treasury
    | Euribor
    | Pfandbriefe
    | Eonia
    | Sonia
    | Eurepo


type BenchmarkCurvePoint =
    |BenchmarkCurvePoint of string
     member x.Value = let (BenchmarkCurvePoint v) = x in v


type CouponRate =
    |CouponRate of decimal
     member x.Value = let (CouponRate v) = x in v


type CouponPaymentDate =
    |CouponPaymentDate of string
     member x.Value = let (CouponPaymentDate v) = x in v


type IssueDate =
    |IssueDate of string
     member x.Value = let (IssueDate v) = x in v


type RepurchaseTerm =
    |RepurchaseTerm of int
     member x.Value = let (RepurchaseTerm v) = x in v


type RepurchaseRate =
    |RepurchaseRate of decimal
     member x.Value = let (RepurchaseRate v) = x in v


type Factor =
    |Factor of decimal
     member x.Value = let (Factor v) = x in v


type TradeOriginationDate =
    |TradeOriginationDate of string
     member x.Value = let (TradeOriginationDate v) = x in v


type ExDate =
    |ExDate of string
     member x.Value = let (ExDate v) = x in v


type ContractMultiplier =
    |ContractMultiplier of decimal
     member x.Value = let (ContractMultiplier v) = x in v


type NoStipulations =
    |NoStipulations of int
     member x.Value = let (NoStipulations v) = x in v


type StipulationType =
    | Amt
    | AutoReinvestmentAtOrBetter
    | BankQualified
    | BargainConditions
    | CouponRange
    | IsoCurrencyCode
    | CustomStartEndDate
    | GeographicsAndPercentRange
    | ValuationDiscount
    | Insured
    | YearOrYearMonthOfIssue
    | IssuersTicker
    | IssueSizeRange
    | LookbackDays
    | ExplicitLotIdentifier
    | LotVariance
    | MaturityYearAndMonth
    | MaturityRange
    | MaximumSubstitutions
    | MinimumQuantity
    | MinimumIncrement
    | MinimumDenomination
    | PaymentFrequencyCalendar
    | NumberOfPieces
    | PoolsMaximum
    | PoolsPerMillion
    | PoolsPerLot
    | PoolsPerTrade
    | PriceRange
    | PricingFrequency
    | ProductionYear
    | CallProtection
    | Purpose
    | BenchmarkPriceSource
    | RatingSourceAndRange
    | Restricted
    | MarketSector
    | SecuritytypeIncludedOrExcluded
    | Structure
    | SubstitutionsFrequency
    | SubstitutionsLeft
    | FreeformText
    | TradeVariance
    | WeightedAverageCoupon
    | WeightedAverageLifeCoupon
    | WeightedAverageLoanAge
    | WeightedAverageMaturity
    | WholePool
    | YieldRange
    | SingleMonthlyMortality
    | ConstantPrepaymentRate
    | ConstantPrepaymentYield
    | ConstantPrepaymentPenalty
    | AbsolutePrepaymentSpeed
    | MonthlyPrepaymentRate
    | PercentOfBmaPrepaymentCurve
    | PercentOfProspectusPrepaymentCurve
    | PercentOfManufacturedHousingPrepaymentCurve
    | FinalCprOfHomeEquityPrepaymentCurve


type StipulationValue =
    | SpecialCumDividend
    | SpecialExDividend
    | SpecialCumCoupon
    | SpecialExCoupon
    | SpecialCumBonus
    | SpecialExBonus
    | SpecialCumRights
    | SpecialExRights
    | SpecialCumCapitalRepayments
    | SpecialExCapitalRepayments
    | CashSettlement
    | SpecialPrice
    | ReportForEuropeanEquityMarketSecurities
    | GuaranteedDelivery


type YieldType =
    | AfterTaxYield
    | AnnualYield
    | YieldAtIssue
    | YieldToAverageMaturity
    | BookYield
    | YieldToNextCall
    | YieldChangeSinceClose
    | ClosingYield
    | CompoundYield
    | CurrentYield
    | TrueGrossYield
    | GovernmentEquivalentYield
    | YieldWithInflationAssumption
    | InverseFloaterBondYield
    | MostRecentClosingYield
    | ClosingYieldMostRecentMonth
    | ClosingYieldMostRecentQuarter
    | ClosingYieldMostRecentYear
    | YieldToLongestAverageLife
    | MarkToMarketYield
    | YieldToMaturity
    | YieldToNextRefund
    | OpenAverageYield
    | YieldToNextPut
    | PreviousCloseYield
    | ProceedsYield
    | SemiAnnualYield
    | YieldToShortestAverageLife
    | SimpleYield
    | TaxEquivalentYield
    | YieldToTenderDate
    | TrueYield
    | YieldValueOf132
    | YieldToWorst


type Yield =
    |Yield of decimal
     member x.Value = let (Yield v) = x in v


type TotalTakedown =
    |TotalTakedown of decimal
     member x.Value = let (TotalTakedown v) = x in v


type Concession =
    |Concession of decimal
     member x.Value = let (Concession v) = x in v


type RepoCollateralSecurityType =
    |RepoCollateralSecurityType of int
     member x.Value = let (RepoCollateralSecurityType v) = x in v


type RedemptionDate =
    |RedemptionDate of string
     member x.Value = let (RedemptionDate v) = x in v


type UnderlyingCouponPaymentDate =
    |UnderlyingCouponPaymentDate of string
     member x.Value = let (UnderlyingCouponPaymentDate v) = x in v


type UnderlyingIssueDate =
    |UnderlyingIssueDate of string
     member x.Value = let (UnderlyingIssueDate v) = x in v


type UnderlyingRepoCollateralSecurityType =
    |UnderlyingRepoCollateralSecurityType of int
     member x.Value = let (UnderlyingRepoCollateralSecurityType v) = x in v


type UnderlyingRepurchaseTerm =
    |UnderlyingRepurchaseTerm of int
     member x.Value = let (UnderlyingRepurchaseTerm v) = x in v


type UnderlyingRepurchaseRate =
    |UnderlyingRepurchaseRate of decimal
     member x.Value = let (UnderlyingRepurchaseRate v) = x in v


type UnderlyingFactor =
    |UnderlyingFactor of decimal
     member x.Value = let (UnderlyingFactor v) = x in v


type UnderlyingRedemptionDate =
    |UnderlyingRedemptionDate of string
     member x.Value = let (UnderlyingRedemptionDate v) = x in v


type LegCouponPaymentDate =
    |LegCouponPaymentDate of string
     member x.Value = let (LegCouponPaymentDate v) = x in v


type LegIssueDate =
    |LegIssueDate of string
     member x.Value = let (LegIssueDate v) = x in v


type LegRepoCollateralSecurityType =
    |LegRepoCollateralSecurityType of int
     member x.Value = let (LegRepoCollateralSecurityType v) = x in v


type LegRepurchaseTerm =
    |LegRepurchaseTerm of int
     member x.Value = let (LegRepurchaseTerm v) = x in v


type LegRepurchaseRate =
    |LegRepurchaseRate of decimal
     member x.Value = let (LegRepurchaseRate v) = x in v


type LegFactor =
    |LegFactor of decimal
     member x.Value = let (LegFactor v) = x in v


type LegRedemptionDate =
    |LegRedemptionDate of string
     member x.Value = let (LegRedemptionDate v) = x in v


type CreditRating =
    |CreditRating of string
     member x.Value = let (CreditRating v) = x in v


type UnderlyingCreditRating =
    |UnderlyingCreditRating of string
     member x.Value = let (UnderlyingCreditRating v) = x in v


type LegCreditRating =
    |LegCreditRating of string
     member x.Value = let (LegCreditRating v) = x in v


type TradedFlatSwitch =
    |TradedFlatSwitch of bool
     member x.Value = let (TradedFlatSwitch v) = x in v


type BasisFeatureDate =
    |BasisFeatureDate of string
     member x.Value = let (BasisFeatureDate v) = x in v


type BasisFeaturePrice =
    |BasisFeaturePrice of decimal
     member x.Value = let (BasisFeaturePrice v) = x in v


type MDReqID =
    |MDReqID of string
     member x.Value = let (MDReqID v) = x in v


type SubscriptionRequestType =
    | Snapshot
    | SnapshotPlusUpdates
    | DisablePreviousSnapshotPlusUpdateRequest


type MarketDepth =
    |MarketDepth of int
     member x.Value = let (MarketDepth v) = x in v


type MDUpdateType =
    | FullRefresh
    | IncrementalRefresh


type AggregatedBook =
    |AggregatedBook of bool
     member x.Value = let (AggregatedBook v) = x in v


type NoMDEntryTypes =
    |NoMDEntryTypes of int
     member x.Value = let (NoMDEntryTypes v) = x in v


type NoMDEntries =
    |NoMDEntries of int
     member x.Value = let (NoMDEntries v) = x in v


type MDEntryType =
    | Bid
    | Offer
    | Trade
    | IndexValue
    | OpeningPrice
    | ClosingPrice
    | SettlementPrice
    | TradingSessionHighPrice
    | TradingSessionLowPrice
    | TradingSessionVwapPrice
    | Imbalance
    | TradeVolume
    | OpenInterest


type MDEntryPx =
    |MDEntryPx of decimal
     member x.Value = let (MDEntryPx v) = x in v


type MDEntrySize =
    |MDEntrySize of decimal
     member x.Value = let (MDEntrySize v) = x in v


type MDEntryDate =
    |MDEntryDate of UTCDate
     member x.Value = let (MDEntryDate v) = x in v


type MDEntryTime =
    |MDEntryTime of UTCTimeOnly
     member x.Value = let (MDEntryTime v) = x in v


type TickDirection =
    | PlusTick
    | ZeroPlusTick
    | MinusTick
    | ZeroMinusTick


type MDMkt =
    |MDMkt of string
     member x.Value = let (MDMkt v) = x in v


type QuoteCondition =
    | OpenActive
    | ClosedInactive
    | ExchangeBest
    | ConsolidatedBest
    | Locked
    | Crossed
    | Depth
    | FastTrading
    | NonFirm


type TradeCondition =
    | CashMarket
    | AveragePriceTrade
    | CashTrade
    | NextDayMarket
    | OpeningReopeningTradeDetail
    | IntradayTradeDetail
    | Rule127
    | Rule155
    | SoldLast
    | NextDayTrade
    | Opened
    | Seller
    | Sold
    | StoppedStock
    | ImbalanceMoreBuyers
    | ImbalanceMoreSellers
    | OpeningPrice


type MDEntryID =
    |MDEntryID of string
     member x.Value = let (MDEntryID v) = x in v


type MDUpdateAction =
    | New
    | Change
    | Delete


type MDEntryRefID =
    |MDEntryRefID of string
     member x.Value = let (MDEntryRefID v) = x in v


type MDReqRejReason =
    | UnknownSymbol
    | DuplicateMdreqid
    | InsufficientBandwidth
    | InsufficientPermissions
    | UnsupportedSubscriptionrequesttype
    | UnsupportedMarketdepth
    | UnsupportedMdupdatetype
    | UnsupportedAggregatedbook
    | UnsupportedMdentrytype
    | UnsupportedTradingsessionid
    | UnsupportedScope
    | UnsupportedOpenclosesettleflag
    | UnsupportedMdimplicitdelete


type MDEntryOriginator =
    |MDEntryOriginator of string
     member x.Value = let (MDEntryOriginator v) = x in v


type LocationID =
    |LocationID of string
     member x.Value = let (LocationID v) = x in v


type DeskID =
    |DeskID of string
     member x.Value = let (DeskID v) = x in v


type DeleteReason =
    | CancelationTradeBust
    | Error


type OpenCloseSettlFlag =
    | DailyOpenCloseSettlementEntry
    | SessionOpenCloseSettlementEntry
    | DeliverySettlementEntry
    | ExpectedEntry
    | EntryFromPreviousBusinessDay
    | TheoreticalPriceValue


type SellerDays =
    |SellerDays of int
     member x.Value = let (SellerDays v) = x in v


type MDEntryBuyer =
    |MDEntryBuyer of string
     member x.Value = let (MDEntryBuyer v) = x in v


type MDEntrySeller =
    |MDEntrySeller of string
     member x.Value = let (MDEntrySeller v) = x in v


type MDEntryPositionNo =
    |MDEntryPositionNo of int
     member x.Value = let (MDEntryPositionNo v) = x in v


type FinancialStatus =
    | Bankrupt
    | PendingDelisting


type CorporateAction =
    | ExDividend
    | ExDistribution
    | ExRights
    | New
    | ExInterest


type DefBidSize =
    |DefBidSize of decimal
     member x.Value = let (DefBidSize v) = x in v


type DefOfferSize =
    |DefOfferSize of decimal
     member x.Value = let (DefOfferSize v) = x in v


type NoQuoteEntries =
    |NoQuoteEntries of int
     member x.Value = let (NoQuoteEntries v) = x in v


type NoQuoteSets =
    |NoQuoteSets of int
     member x.Value = let (NoQuoteSets v) = x in v


type QuoteStatus =
    | Accepted
    | CanceledForSymbol
    | CanceledForSecurityType
    | CanceledForUnderlying
    | CanceledAll
    | Rejected
    | RemovedFromMarket
    | Expired
    | Query
    | QuoteNotFound
    | Pending
    | Pass
    | LockedMarketWarning
    | CrossMarketWarning
    | CanceledDueToLockMarket
    | CanceledDueToCrossMarket


type QuoteCancelType =
    | CancelForSymbol
    | CancelForSecurityType
    | CancelForUnderlyingSymbol
    | CancelAllQuotes


type QuoteEntryID =
    |QuoteEntryID of string
     member x.Value = let (QuoteEntryID v) = x in v


type QuoteRejectReason =
    | UnknownSymbol
    | ExchangeClosed
    | QuoteRequestExceedsLimit
    | TooLateToEnter
    | UnknownQuote
    | DuplicateQuote
    | InvalidBidAskSpread
    | InvalidPrice
    | NotAuthorizedToQuoteSecurity
    | Other


type QuoteResponseLevel =
    | NoAcknowledgement
    | AcknowledgeOnlyNegativeOrErroneousQuotes
    | AcknowledgeEachQuoteMessages


type QuoteSetID =
    |QuoteSetID of string
     member x.Value = let (QuoteSetID v) = x in v


type QuoteRequestType =
    | Manual
    | Automatic


type TotNoQuoteEntries =
    |TotNoQuoteEntries of int
     member x.Value = let (TotNoQuoteEntries v) = x in v


type UnderlyingSecurityIDSource =
    |UnderlyingSecurityIDSource of string
     member x.Value = let (UnderlyingSecurityIDSource v) = x in v


type UnderlyingIssuer =
    |UnderlyingIssuer of string
     member x.Value = let (UnderlyingIssuer v) = x in v


type UnderlyingSecurityDesc =
    |UnderlyingSecurityDesc of string
     member x.Value = let (UnderlyingSecurityDesc v) = x in v


type UnderlyingSecurityExchange =
    |UnderlyingSecurityExchange of string
     member x.Value = let (UnderlyingSecurityExchange v) = x in v


type UnderlyingSecurityID =
    |UnderlyingSecurityID of string
     member x.Value = let (UnderlyingSecurityID v) = x in v


type UnderlyingSecurityType =
    |UnderlyingSecurityType of string
     member x.Value = let (UnderlyingSecurityType v) = x in v


type UnderlyingSymbol =
    |UnderlyingSymbol of string
     member x.Value = let (UnderlyingSymbol v) = x in v


type UnderlyingSymbolSfx =
    |UnderlyingSymbolSfx of string
     member x.Value = let (UnderlyingSymbolSfx v) = x in v


type UnderlyingMaturityMonthYear =
    |UnderlyingMaturityMonthYear of MonthYear
     member x.Value = let (UnderlyingMaturityMonthYear v) = x in v


type UnderlyingPutOrCall =
    | Put
    | Call


type UnderlyingStrikePrice =
    |UnderlyingStrikePrice of decimal
     member x.Value = let (UnderlyingStrikePrice v) = x in v


type UnderlyingOptAttribute =
    |UnderlyingOptAttribute of char
     member x.Value = let (UnderlyingOptAttribute v) = x in v


type UnderlyingCurrency =
    |UnderlyingCurrency of string
     member x.Value = let (UnderlyingCurrency v) = x in v


type SecurityReqID =
    |SecurityReqID of string
     member x.Value = let (SecurityReqID v) = x in v


type SecurityRequestType =
    | RequestSecurityIdentityAndSpecifications
    | RequestSecurityIdentityForTheSpecificationsProvided
    | RequestListSecurityTypes
    | RequestListSecurities


type SecurityResponseID =
    |SecurityResponseID of string
     member x.Value = let (SecurityResponseID v) = x in v


type SecurityResponseType =
    | AcceptSecurityProposalAsIs
    | AcceptSecurityProposalWithRevisionsAsIndicatedInTheMessage
    | ListOfSecurityTypesReturnedPerRequest
    | ListOfSecuritiesReturnedPerRequest
    | RejectSecurityProposal
    | CanNotMatchSelectionCriteria


type SecurityStatusReqID =
    |SecurityStatusReqID of string
     member x.Value = let (SecurityStatusReqID v) = x in v


type UnsolicitedIndicator =
    |UnsolicitedIndicator of bool
     member x.Value = let (UnsolicitedIndicator v) = x in v


type SecurityTradingStatus =
    | OpeningDelay
    | TradingHalt
    | Resume
    | NoOpenNoResume
    | PriceIndication
    | TradingRangeIndication
    | MarketImbalanceBuy
    | MarketImbalanceSell
    | MarketOnCloseImbalanceBuy
    | MarketOnCloseImbalanceSell
    | NotAssigned
    | NoMarketImbalance
    | NoMarketOnCloseImbalance
    | ItsPreOpening
    | NewPriceIndication
    | TradeDisseminationTime
    | ReadyToTradeStartOfSession
    | NotAvailableForTradingEndOfSession
    | NotTradedOnThisMarket
    | UnknownOrInvalid
    | PreOpen
    | OpeningRotation
    | FastMarket


type HaltReason =
    | OrderImbalance
    | EquipmentChangeover
    | NewsPending
    | NewsDissemination
    | OrderInflux
    | AdditionalInformation


type InViewOfCommon =
    |InViewOfCommon of bool
     member x.Value = let (InViewOfCommon v) = x in v


type DueToRelated =
    |DueToRelated of bool
     member x.Value = let (DueToRelated v) = x in v


type BuyVolume =
    |BuyVolume of decimal
     member x.Value = let (BuyVolume v) = x in v


type SellVolume =
    |SellVolume of decimal
     member x.Value = let (SellVolume v) = x in v


type HighPx =
    |HighPx of decimal
     member x.Value = let (HighPx v) = x in v


type LowPx =
    |LowPx of decimal
     member x.Value = let (LowPx v) = x in v


type Adjustment =
    | Cancel
    | Error
    | Correction


type TradSesReqID =
    |TradSesReqID of string
     member x.Value = let (TradSesReqID v) = x in v


type TradingSessionID =
    |TradingSessionID of string
     member x.Value = let (TradingSessionID v) = x in v


type ContraTrader =
    |ContraTrader of string
     member x.Value = let (ContraTrader v) = x in v


type TradSesMethod =
    | Electronic
    | OpenOutcry
    | TwoParty


type TradSesMode =
    | Testing
    | Simulated
    | Production


type TradSesStatus =
    | Unknown
    | Halted
    | Open
    | Closed
    | PreOpen
    | PreClose
    | RequestRejected


type TradSesStartTime =
    |TradSesStartTime of UTCTimestamp
     member x.Value = let (TradSesStartTime v) = x in v


type TradSesOpenTime =
    |TradSesOpenTime of UTCTimestamp
     member x.Value = let (TradSesOpenTime v) = x in v


type TradSesPreCloseTime =
    |TradSesPreCloseTime of UTCTimestamp
     member x.Value = let (TradSesPreCloseTime v) = x in v


type TradSesCloseTime =
    |TradSesCloseTime of UTCTimestamp
     member x.Value = let (TradSesCloseTime v) = x in v


type TradSesEndTime =
    |TradSesEndTime of UTCTimestamp
     member x.Value = let (TradSesEndTime v) = x in v


type NumberOfOrders =
    |NumberOfOrders of int
     member x.Value = let (NumberOfOrders v) = x in v


type MessageEncoding =
    | Iso2022Jp
    | EucJp
    | ShiftJis
    | Utf8


// compound len+str field
type EncodedIssuer =
    |EncodedIssuer of byte []
     member x.Value = let (EncodedIssuer v) = x in v


// compound len+str field
type EncodedSecurityDesc =
    |EncodedSecurityDesc of byte []
     member x.Value = let (EncodedSecurityDesc v) = x in v


// compound len+str field
type EncodedListExecInst =
    |EncodedListExecInst of byte []
     member x.Value = let (EncodedListExecInst v) = x in v


// compound len+str field
type EncodedText =
    |EncodedText of byte []
     member x.Value = let (EncodedText v) = x in v


// compound len+str field
type EncodedSubject =
    |EncodedSubject of byte []
     member x.Value = let (EncodedSubject v) = x in v


// compound len+str field
type EncodedHeadline =
    |EncodedHeadline of byte []
     member x.Value = let (EncodedHeadline v) = x in v


// compound len+str field
type EncodedAllocText =
    |EncodedAllocText of byte []
     member x.Value = let (EncodedAllocText v) = x in v


// compound len+str field
type EncodedUnderlyingIssuer =
    |EncodedUnderlyingIssuer of byte []
     member x.Value = let (EncodedUnderlyingIssuer v) = x in v


// compound len+str field
type EncodedUnderlyingSecurityDesc =
    |EncodedUnderlyingSecurityDesc of byte []
     member x.Value = let (EncodedUnderlyingSecurityDesc v) = x in v


type AllocPrice =
    |AllocPrice of decimal
     member x.Value = let (AllocPrice v) = x in v


type QuoteSetValidUntilTime =
    |QuoteSetValidUntilTime of UTCTimestamp
     member x.Value = let (QuoteSetValidUntilTime v) = x in v


type QuoteEntryRejectReason =
    | UnknownSymbol
    | ExchangeClosed
    | QuoteExceedsLimit
    | TooLateToEnter
    | UnknownQuote
    | DuplicateQuote
    | InvalidBidAskSpread
    | InvalidPrice
    | NotAuthorizedToQuoteSecurity


type LastMsgSeqNumProcessed =
    |LastMsgSeqNumProcessed of uint32
     member x.Value = let (LastMsgSeqNumProcessed v) = x in v


type RefTagID =
    |RefTagID of int
     member x.Value = let (RefTagID v) = x in v


type RefMsgType =
    |RefMsgType of string
     member x.Value = let (RefMsgType v) = x in v


type SessionRejectReason =
    | InvalidTagNumber
    | RequiredTagMissing
    | TagNotDefinedForThisMessageType
    | UndefinedTag
    | TagSpecifiedWithoutAValue
    | ValueIsIncorrect
    | IncorrectDataFormatForValue
    | DecryptionProblem
    | SignatureProblem
    | CompidProblem
    | SendingtimeAccuracyProblem
    | InvalidMsgtype
    | XmlValidationError
    | TagAppearsMoreThanOnce
    | TagSpecifiedOutOfRequiredOrder
    | RepeatingGroupFieldsOutOfOrder
    | IncorrectNumingroupCountForRepeatingGroup
    | NonDataValueIncludesFieldDelimiter
    | Other


type BidRequestTransType =
    | New
    | Cancel


type ContraBroker =
    |ContraBroker of string
     member x.Value = let (ContraBroker v) = x in v


type ComplianceID =
    |ComplianceID of string
     member x.Value = let (ComplianceID v) = x in v


type SolicitedFlag =
    |SolicitedFlag of bool
     member x.Value = let (SolicitedFlag v) = x in v


type ExecRestatementReason =
    | GtCorporateAction
    | GtRenewalRestatement
    | VerbalChange
    | RepricingOfOrder
    | BrokerOption
    | PartialDeclineOfOrderqty
    | CancelOnTradingHalt
    | CancelOnSystemFailure
    | MarketOption
    | CanceledNotBest


type BusinessRejectRefID =
    |BusinessRejectRefID of string
     member x.Value = let (BusinessRejectRefID v) = x in v


type BusinessRejectReason =
    | Other
    | UnkownId
    | UnknownSecurity
    | UnsupportedMessageType
    | ApplicationNotAvailable
    | ConditionallyRequiredFieldMissing
    | NotAuthorized
    | DelivertoFirmNotAvailableAtThisTime


type GrossTradeAmt =
    |GrossTradeAmt of decimal
     member x.Value = let (GrossTradeAmt v) = x in v


type NoContraBrokers =
    |NoContraBrokers of int
     member x.Value = let (NoContraBrokers v) = x in v


type MaxMessageSize =
    |MaxMessageSize of int
     member x.Value = let (MaxMessageSize v) = x in v


type NoMsgTypes =
    |NoMsgTypes of int
     member x.Value = let (NoMsgTypes v) = x in v


type MsgDirection =
    | Send
    | Receive


type NoTradingSessions =
    |NoTradingSessions of int
     member x.Value = let (NoTradingSessions v) = x in v


type TotalVolumeTraded =
    |TotalVolumeTraded of decimal
     member x.Value = let (TotalVolumeTraded v) = x in v


type DiscretionInst =
    | RelatedToDisplayedPrice
    | RelatedToMarketPrice
    | RelatedToPrimaryPrice
    | RelatedToLocalPrimaryPrice
    | RelatedToMidpointPrice
    | RelatedToLastTradePrice
    | RelatedToVwap


type DiscretionOffsetValue =
    |DiscretionOffsetValue of decimal
     member x.Value = let (DiscretionOffsetValue v) = x in v


type BidID =
    |BidID of string
     member x.Value = let (BidID v) = x in v


type ClientBidID =
    |ClientBidID of string
     member x.Value = let (ClientBidID v) = x in v


type ListName =
    |ListName of string
     member x.Value = let (ListName v) = x in v


type TotNoRelatedSym =
    |TotNoRelatedSym of int
     member x.Value = let (TotNoRelatedSym v) = x in v


type BidType =
    | NonDisclosed
    | DisclosedStyle
    | NoBiddingProcess


type NumTickets =
    |NumTickets of int
     member x.Value = let (NumTickets v) = x in v


type SideValue1 =
    |SideValue1 of decimal
     member x.Value = let (SideValue1 v) = x in v


type SideValue2 =
    |SideValue2 of decimal
     member x.Value = let (SideValue2 v) = x in v


type NoBidDescriptors =
    |NoBidDescriptors of int
     member x.Value = let (NoBidDescriptors v) = x in v


type BidDescriptorType =
    | Sector
    | Country
    | Index


type BidDescriptor =
    |BidDescriptor of string
     member x.Value = let (BidDescriptor v) = x in v


type SideValueInd =
    | Sidevalue1
    | Sidevalue2


type LiquidityPctLow =
    |LiquidityPctLow of decimal
     member x.Value = let (LiquidityPctLow v) = x in v


type LiquidityPctHigh =
    |LiquidityPctHigh of decimal
     member x.Value = let (LiquidityPctHigh v) = x in v


type LiquidityValue =
    |LiquidityValue of decimal
     member x.Value = let (LiquidityValue v) = x in v


type EFPTrackingError =
    |EFPTrackingError of decimal
     member x.Value = let (EFPTrackingError v) = x in v


type FairValue =
    |FairValue of decimal
     member x.Value = let (FairValue v) = x in v


type OutsideIndexPct =
    |OutsideIndexPct of decimal
     member x.Value = let (OutsideIndexPct v) = x in v


type ValueOfFutures =
    |ValueOfFutures of decimal
     member x.Value = let (ValueOfFutures v) = x in v


type LiquidityIndType =
    | FivedayMovingAverage
    | TwentydayMovingAverage
    | NormalMarketSize
    | Other


type WtAverageLiquidity =
    |WtAverageLiquidity of decimal
     member x.Value = let (WtAverageLiquidity v) = x in v


type ExchangeForPhysical =
    |ExchangeForPhysical of bool
     member x.Value = let (ExchangeForPhysical v) = x in v


type OutMainCntryUIndex =
    |OutMainCntryUIndex of decimal
     member x.Value = let (OutMainCntryUIndex v) = x in v


type CrossPercent =
    |CrossPercent of decimal
     member x.Value = let (CrossPercent v) = x in v


type ProgRptReqs =
    | BuysideExplicitlyRequestsStatusUsingStatusrequest
    | SellsidePeriodicallySendsStatusUsingListstatus
    | RealTimeExecutionReports


type ProgPeriodInterval =
    |ProgPeriodInterval of int
     member x.Value = let (ProgPeriodInterval v) = x in v


type IncTaxInd =
    | Net
    | Gross


type NumBidders =
    |NumBidders of int
     member x.Value = let (NumBidders v) = x in v


type BidTradeType =
    | RiskTrade
    | VwapGuarantee
    | Agency
    | GuaranteedClose


type BasisPxType =
    | ClosingPriceAtMorningSession
    | ClosingPrice
    | CurrentPrice
    | Sq
    | VwapThroughADay
    | VwapThroughAMorningSession
    | VwapThroughAnAfternoonSession
    | VwapThroughADayExceptYori
    | VwapThroughAMorningSessionExceptYori
    | VwapThroughAnAfternoonSessionExceptYori
    | Strike
    | Open
    | Others


type NoBidComponents =
    |NoBidComponents of int
     member x.Value = let (NoBidComponents v) = x in v


type Country =
    |Country of string
     member x.Value = let (Country v) = x in v


type TotNoStrikes =
    |TotNoStrikes of int
     member x.Value = let (TotNoStrikes v) = x in v


type PriceType =
    | Percentage
    | PerUnit
    | FixedAmount
    | Discount
    | Premium
    | Spread
    | TedPrice
    | TedYield
    | Yield
    | FixedCabinetTradePrice
    | VariableCabinetTradePrice


type DayOrderQty =
    |DayOrderQty of decimal
     member x.Value = let (DayOrderQty v) = x in v


type DayCumQty =
    |DayCumQty of decimal
     member x.Value = let (DayCumQty v) = x in v


type DayAvgPx =
    |DayAvgPx of decimal
     member x.Value = let (DayAvgPx v) = x in v


type GTBookingInst =
    | BookOutAllTradesOnDayOfExecution
    | AccumulateExecutionsUntilOrderIsFilledOrExpires
    | AccumulateUntilVerballyNotifiedOtherwise


type NoStrikes =
    |NoStrikes of int
     member x.Value = let (NoStrikes v) = x in v


type ListStatusType =
    | Ack
    | Response
    | Timed
    | Execstarted
    | Alldone
    | Alert


type NetGrossInd =
    | Net
    | Gross


type ListOrderStatus =
    | Inbiddingprocess
    | Receivedforexecution
    | Executing
    | Canceling
    | Alert
    | AllDone
    | Reject


type ExpireDate =
    |ExpireDate of string
     member x.Value = let (ExpireDate v) = x in v


type ListExecInstType =
    | Immediate
    | WaitForExecuteInstruction
    | ExchangeSwitchCivOrderSellDriven
    | ExchangeSwitchCivOrderBuyDrivenCashTopUp
    | ExchangeSwitchCivOrderBuyDrivenCashWithdraw


type CxlRejResponseTo =
    | OrderCancelRequest
    | OrderCancelReplaceRequest


type UnderlyingCouponRate =
    |UnderlyingCouponRate of decimal
     member x.Value = let (UnderlyingCouponRate v) = x in v


type UnderlyingContractMultiplier =
    |UnderlyingContractMultiplier of decimal
     member x.Value = let (UnderlyingContractMultiplier v) = x in v


type ContraTradeQty =
    |ContraTradeQty of decimal
     member x.Value = let (ContraTradeQty v) = x in v


type ContraTradeTime =
    |ContraTradeTime of UTCTimestamp
     member x.Value = let (ContraTradeTime v) = x in v


type LiquidityNumSecurities =
    |LiquidityNumSecurities of int
     member x.Value = let (LiquidityNumSecurities v) = x in v


type MultiLegReportingType =
    | SingleSecurity
    | IndividualLegOfAMultiLegSecurity
    | MultiLegSecurity


type StrikeTime =
    |StrikeTime of UTCTimestamp
     member x.Value = let (StrikeTime v) = x in v


type ListStatusText =
    |ListStatusText of string
     member x.Value = let (ListStatusText v) = x in v


// compound len+str field
type EncodedListStatusText =
    |EncodedListStatusText of byte []
     member x.Value = let (EncodedListStatusText v) = x in v


type PartyIDSource =
    | Bic
    | GenerallyAcceptedMarketParticipantIdentifier
    | ProprietaryCustomCode
    | IsoCountryCode
    | SettlementEntityLocation
    | Mic
    | CsdParticipantMemberCode
    | KoreanInvestorId
    | TaiwaneseQualifiedForeignInvestorIdQfiiFid
    | TaiwaneseTradingAccount
    | MalaysianCentralDepositoryNumber
    | ChineseBShare
    | UkNationalInsuranceOrPensionNumber
    | UsSocialSecurityNumber
    | UsEmployerIdentificationNumber
    | AustralianBusinessNumber
    | AustralianTaxFileNumber
    | DirectedBroker


type PartyID =
    |PartyID of string
     member x.Value = let (PartyID v) = x in v


type NetChgPrevDay =
    |NetChgPrevDay of decimal
     member x.Value = let (NetChgPrevDay v) = x in v


type PartyRole =
    | ExecutingFirm
    | BrokerOfCredit
    | ClientId
    | ClearingFirm
    | InvestorId
    | IntroducingFirm
    | EnteringFirm
    | LocateLendingFirm
    | FundManagerClientId
    | SettlementLocation
    | OrderOriginationTrader
    | ExecutingTrader
    | OrderOriginationFirm
    | GiveupClearingFirm
    | CorrespondantClearingFirm
    | ExecutingSystem
    | ContraFirm
    | ContraClearingFirm
    | SponsoringFirm
    | UnderlyingContraFirm
    | ClearingOrganization
    | Exchange
    | CustomerAccount
    | CorrespondentClearingOrganization
    | CorrespondentBroker
    | BuyerSeller
    | Custodian
    | Intermediary
    | Agent
    | SubCustodian
    | Beneficiary
    | InterestedParty
    | RegulatoryBody
    | LiquidityProvider
    | EnteringTrader
    | ContraTrader
    | PositionAccount


type NoPartyIDs =
    |NoPartyIDs of int
     member x.Value = let (NoPartyIDs v) = x in v


type NoSecurityAltID =
    |NoSecurityAltID of int
     member x.Value = let (NoSecurityAltID v) = x in v


type SecurityAltID =
    |SecurityAltID of string
     member x.Value = let (SecurityAltID v) = x in v


type SecurityAltIDSource =
    |SecurityAltIDSource of string
     member x.Value = let (SecurityAltIDSource v) = x in v


type NoUnderlyingSecurityAltID =
    |NoUnderlyingSecurityAltID of int
     member x.Value = let (NoUnderlyingSecurityAltID v) = x in v


type UnderlyingSecurityAltID =
    |UnderlyingSecurityAltID of string
     member x.Value = let (UnderlyingSecurityAltID v) = x in v


type UnderlyingSecurityAltIDSource =
    |UnderlyingSecurityAltIDSource of string
     member x.Value = let (UnderlyingSecurityAltIDSource v) = x in v


type Product =
    | Agency
    | Commodity
    | Corporate
    | Currency
    | Equity
    | Government
    | Index
    | Loan
    | Moneymarket
    | Mortgage
    | Municipal
    | Other
    | Financing


type CFICode =
    |CFICode of string
     member x.Value = let (CFICode v) = x in v


type UnderlyingProduct =
    |UnderlyingProduct of int
     member x.Value = let (UnderlyingProduct v) = x in v


type UnderlyingCFICode =
    |UnderlyingCFICode of string
     member x.Value = let (UnderlyingCFICode v) = x in v


type TestMessageIndicator =
    |TestMessageIndicator of bool
     member x.Value = let (TestMessageIndicator v) = x in v


type QuantityType =
    | Shares
    | Bonds
    | Currentface
    | Originalface
    | Currency
    | Contracts
    | Other
    | Par


type BookingRefID =
    |BookingRefID of string
     member x.Value = let (BookingRefID v) = x in v


type IndividualAllocID =
    |IndividualAllocID of string
     member x.Value = let (IndividualAllocID v) = x in v


type RoundingDirection =
    | RoundToNearest
    | RoundDown
    | RoundUp


type RoundingModulus =
    |RoundingModulus of decimal
     member x.Value = let (RoundingModulus v) = x in v


type CountryOfIssue =
    |CountryOfIssue of string
     member x.Value = let (CountryOfIssue v) = x in v


type StateOrProvinceOfIssue =
    |StateOrProvinceOfIssue of string
     member x.Value = let (StateOrProvinceOfIssue v) = x in v


type LocaleOfIssue =
    |LocaleOfIssue of string
     member x.Value = let (LocaleOfIssue v) = x in v


type NoRegistDtls =
    |NoRegistDtls of int
     member x.Value = let (NoRegistDtls v) = x in v


type MailingDtls =
    |MailingDtls of string
     member x.Value = let (MailingDtls v) = x in v


type InvestorCountryOfResidence =
    |InvestorCountryOfResidence of string
     member x.Value = let (InvestorCountryOfResidence v) = x in v


type PaymentRef =
    |PaymentRef of string
     member x.Value = let (PaymentRef v) = x in v


type DistribPaymentMethod =
    | Crest
    | Nscc
    | Euroclear
    | Clearstream
    | Cheque
    | TelegraphicTransfer
    | Fedwire
    | DirectCredit
    | AchCredit
    | Bpay
    | HighValueClearingSystem
    | ReinvestInFund


type CashDistribCurr =
    |CashDistribCurr of string
     member x.Value = let (CashDistribCurr v) = x in v


type CommCurrency =
    |CommCurrency of string
     member x.Value = let (CommCurrency v) = x in v


type CancellationRights =
    | Yes
    | NoExecutionOnly
    | NoWaiverAgreement
    | NoInstitutional


type MoneyLaunderingStatus =
    | Passed
    | NotChecked
    | ExemptBelowTheLimit
    | ExemptClientMoneyTypeExemption
    | ExemptAuthorisedCreditOrFinancialInstitution


type MailingInst =
    |MailingInst of string
     member x.Value = let (MailingInst v) = x in v


type TransBkdTime =
    |TransBkdTime of UTCTimestamp
     member x.Value = let (TransBkdTime v) = x in v


type ExecPriceType =
    | BidPrice
    | CreationPrice
    | CreationPricePlusAdjustmentPercent
    | CreationPricePlusAdjustmentAmount
    | OfferPrice
    | OfferPriceMinusAdjustmentPercent
    | OfferPriceMinusAdjustmentAmount
    | SinglePrice


type ExecPriceAdjustment =
    |ExecPriceAdjustment of decimal
     member x.Value = let (ExecPriceAdjustment v) = x in v


type DateOfBirth =
    |DateOfBirth of string
     member x.Value = let (DateOfBirth v) = x in v


type TradeReportTransType =
    | New
    | Cancel
    | Replace
    | Release
    | Reverse


type CardHolderName =
    |CardHolderName of string
     member x.Value = let (CardHolderName v) = x in v


type CardNumber =
    |CardNumber of string
     member x.Value = let (CardNumber v) = x in v


type CardExpDate =
    |CardExpDate of string
     member x.Value = let (CardExpDate v) = x in v


type CardIssNum =
    |CardIssNum of string
     member x.Value = let (CardIssNum v) = x in v


type PaymentMethod =
    | Crest
    | Nscc
    | Euroclear
    | Clearstream
    | Cheque
    | TelegraphicTransfer
    | Fedwire
    | DebitCard
    | DirectDebit
    | DirectCredit
    | CreditCard
    | AchDebit
    | AchCredit
    | Bpay
    | HighValueClearingSystem


type RegistAcctType =
    |RegistAcctType of string
     member x.Value = let (RegistAcctType v) = x in v


type Designation =
    |Designation of string
     member x.Value = let (Designation v) = x in v


type TaxAdvantageType =
    | NNone
    | MaxiIsa
    | Tessa
    | MiniCashIsa
    | MiniStocksAndSharesIsa
    | MiniInsuranceIsa
    | CurrentYearPayment
    | PriorYearPayment
    | AssetTransfer
    | EmployeePriorYear
    | Other


type RegistRejReasonText =
    |RegistRejReasonText of string
     member x.Value = let (RegistRejReasonText v) = x in v


type FundRenewWaiv =
    | Yes
    | No


type CashDistribAgentName =
    |CashDistribAgentName of string
     member x.Value = let (CashDistribAgentName v) = x in v


type CashDistribAgentCode =
    |CashDistribAgentCode of string
     member x.Value = let (CashDistribAgentCode v) = x in v


type CashDistribAgentAcctNumber =
    |CashDistribAgentAcctNumber of string
     member x.Value = let (CashDistribAgentAcctNumber v) = x in v


type CashDistribPayRef =
    |CashDistribPayRef of string
     member x.Value = let (CashDistribPayRef v) = x in v


type CashDistribAgentAcctName =
    |CashDistribAgentAcctName of string
     member x.Value = let (CashDistribAgentAcctName v) = x in v


type CardStartDate =
    |CardStartDate of string
     member x.Value = let (CardStartDate v) = x in v


type PaymentDate =
    |PaymentDate of string
     member x.Value = let (PaymentDate v) = x in v


type PaymentRemitterID =
    |PaymentRemitterID of string
     member x.Value = let (PaymentRemitterID v) = x in v


type RegistStatus =
    | Accepted
    | Rejected
    | Held
    | Reminder


type RegistRejReasonCode =
    | InvalidUnacceptableAccountType
    | InvalidUnacceptableTaxExemptType
    | InvalidUnacceptableOwnershipType
    | InvalidUnacceptableNoRegDetls
    | InvalidUnacceptableRegSeqNo
    | InvalidUnacceptableRegDtls
    | InvalidUnacceptableMailingDtls
    | InvalidUnacceptableMailingInst
    | InvalidUnacceptableInvestorId
    | InvalidUnacceptableInvestorIdSource
    | InvalidUnacceptableDateOfBirth
    | InvalidUnacceptableInvestorCountryOfResidence
    | InvalidUnacceptableNodistribinstns
    | InvalidUnacceptableDistribPercentage
    | InvalidUnacceptableDistribPaymentMethod
    | InvalidUnacceptableCashDistribAgentAcctName
    | InvalidUnacceptableCashDistribAgentCode
    | InvalidUnacceptableCashDistribAgentAcctNum
    | Other


type RegistRefID =
    |RegistRefID of string
     member x.Value = let (RegistRefID v) = x in v


type RegistDtls =
    |RegistDtls of string
     member x.Value = let (RegistDtls v) = x in v


type NoDistribInsts =
    |NoDistribInsts of int
     member x.Value = let (NoDistribInsts v) = x in v


type RegistEmail =
    |RegistEmail of string
     member x.Value = let (RegistEmail v) = x in v


type DistribPercentage =
    |DistribPercentage of decimal
     member x.Value = let (DistribPercentage v) = x in v


type RegistID =
    |RegistID of string
     member x.Value = let (RegistID v) = x in v


type RegistTransType =
    | New
    | Replace
    | Cancel


type ExecValuationPoint =
    |ExecValuationPoint of UTCTimestamp
     member x.Value = let (ExecValuationPoint v) = x in v


type OrderPercent =
    |OrderPercent of decimal
     member x.Value = let (OrderPercent v) = x in v


type OwnershipType =
    | JointInvestors
    | TenantsInCommon
    | JointTrustees


type NoContAmts =
    |NoContAmts of int
     member x.Value = let (NoContAmts v) = x in v


type ContAmtType =
    | CommissionAmount
    | CommissionPercent
    | InitialChargeAmount
    | InitialChargePercent
    | DiscountAmount
    | DiscountPercent
    | DilutionLevyAmount
    | DilutionLevyPercent
    | ExitChargeAmount


type ContAmtValue =
    |ContAmtValue of decimal
     member x.Value = let (ContAmtValue v) = x in v


type ContAmtCurr =
    |ContAmtCurr of string
     member x.Value = let (ContAmtCurr v) = x in v


type OwnerType =
    | IndividualInvestor
    | PublicCompany
    | PrivateCompany
    | IndividualTrustee
    | CompanyTrustee
    | PensionPlan
    | CustodianUnderGiftsToMinorsAct
    | Trusts
    | Fiduciaries
    | NetworkingSubAccount
    | NonProfitOrganization
    | CorporateBody
    | Nominee


type PartySubID =
    |PartySubID of string
     member x.Value = let (PartySubID v) = x in v


type NestedPartyID =
    |NestedPartyID of string
     member x.Value = let (NestedPartyID v) = x in v


type NestedPartyIDSource =
    |NestedPartyIDSource of char
     member x.Value = let (NestedPartyIDSource v) = x in v


type SecondaryClOrdID =
    |SecondaryClOrdID of string
     member x.Value = let (SecondaryClOrdID v) = x in v


type SecondaryExecID =
    |SecondaryExecID of string
     member x.Value = let (SecondaryExecID v) = x in v


type OrderCapacity =
    | Agency
    | Proprietary
    | Individual
    | Principal
    | RisklessPrincipal
    | AgentForOtherMember


type OrderRestrictions =
    | ProgramTrade
    | IndexArbitrage
    | NonIndexArbitrage
    | CompetingMarketMaker
    | ActingAsMarketMakerOrSpecialistInTheSecurity
    | ActingAsMarketMakerOrSpecialistInTheUnderlyingSecurityOfADerivativeSecurity
    | ForeignEntity
    | ExternalMarketParticipant
    | ExternalInterConnectedMarketLinkage
    | RisklessArbitrage


type MassCancelRequestType =
    | CancelOrdersForASecurity
    | CancelOrdersForAnUnderlyingSecurity
    | CancelOrdersForAProduct
    | CancelOrdersForACficode
    | CancelOrdersForASecuritytype
    | CancelOrdersForATradingSession
    | CancelAllOrders


type MassCancelResponse =
    | CancelRequestRejected
    | CancelOrdersForASecurity
    | CancelOrdersForAnUnderlyingSecurity
    | CancelOrdersForAProduct
    | CancelOrdersForACficode
    | CancelOrdersForASecuritytype
    | CancelOrdersForATradingSession
    | CancelAllOrders


type MassCancelRejectReason =
    | MassCancelNotSupported
    | InvalidOrUnknownSecurity
    | InvalidOrUnknownUnderlying
    | InvalidOrUnknownProduct
    | InvalidOrUnknownCficode
    | InvalidOrUnknownSecurityType
    | InvalidOrUnknownTradingSession
    | Other


type TotalAffectedOrders =
    |TotalAffectedOrders of int
     member x.Value = let (TotalAffectedOrders v) = x in v


type NoAffectedOrders =
    |NoAffectedOrders of int
     member x.Value = let (NoAffectedOrders v) = x in v


type AffectedOrderID =
    |AffectedOrderID of string
     member x.Value = let (AffectedOrderID v) = x in v


type AffectedSecondaryOrderID =
    |AffectedSecondaryOrderID of string
     member x.Value = let (AffectedSecondaryOrderID v) = x in v


type QuoteType =
    | Indicative
    | Tradeable
    | RestrictedTradeable
    | Counter


type NestedPartyRole =
    |NestedPartyRole of int
     member x.Value = let (NestedPartyRole v) = x in v


type NoNestedPartyIDs =
    |NoNestedPartyIDs of int
     member x.Value = let (NoNestedPartyIDs v) = x in v


type TotalAccruedInterestAmt =
    |TotalAccruedInterestAmt of decimal
     member x.Value = let (TotalAccruedInterestAmt v) = x in v


type MaturityDate =
    |MaturityDate of string
     member x.Value = let (MaturityDate v) = x in v


type UnderlyingMaturityDate =
    |UnderlyingMaturityDate of string
     member x.Value = let (UnderlyingMaturityDate v) = x in v


type InstrRegistry =
    |InstrRegistry of string
     member x.Value = let (InstrRegistry v) = x in v


type CashMargin =
    | Cash
    | MarginOpen
    | MarginClose


type NestedPartySubID =
    |NestedPartySubID of string
     member x.Value = let (NestedPartySubID v) = x in v


type Scope =
    | Local
    | National
    | Global


type MDImplicitDelete =
    |MDImplicitDelete of bool
     member x.Value = let (MDImplicitDelete v) = x in v


type CrossID =
    |CrossID of string
     member x.Value = let (CrossID v) = x in v


type CrossType =
    | CrossTradeWhichIsExecutedCompletelyOrNot
    | CrossTradeWhichIsExecutedPartiallyAndTheRestIsCancelled
    | CrossTradeWhichIsPartiallyExecutedWithTheUnfilledPortionsRemainingActive
    | CrossTradeIsExecutedWithExistingOrdersWithTheSamePrice


type CrossPrioritization =
    | NNone
    | BuySideIsPrioritized
    | SellSideIsPrioritized


type OrigCrossID =
    |OrigCrossID of string
     member x.Value = let (OrigCrossID v) = x in v


type NoSides =
    | OneSide
    | BothSides


type Username =
    |Username of string
     member x.Value = let (Username v) = x in v


type Password =
    |Password of string
     member x.Value = let (Password v) = x in v


type NoLegs =
    |NoLegs of int
     member x.Value = let (NoLegs v) = x in v


type LegCurrency =
    |LegCurrency of string
     member x.Value = let (LegCurrency v) = x in v


type TotNoSecurityTypes =
    |TotNoSecurityTypes of int
     member x.Value = let (TotNoSecurityTypes v) = x in v


type NoSecurityTypes =
    |NoSecurityTypes of int
     member x.Value = let (NoSecurityTypes v) = x in v


type SecurityListRequestType =
    | Symbol
    | SecuritytypeAndOrCficode
    | Product
    | Tradingsessionid
    | AllSecurities


type SecurityRequestResult =
    | ValidRequest
    | InvalidOrUnsupportedRequest
    | NoInstrumentsFoundThatMatchSelectionCriteria
    | NotAuthorizedToRetrieveInstrumentData
    | InstrumentDataTemporarilyUnavailable
    | RequestForInstrumentDataNotSupported


type RoundLot =
    |RoundLot of decimal
     member x.Value = let (RoundLot v) = x in v


type MinTradeVol =
    |MinTradeVol of decimal
     member x.Value = let (MinTradeVol v) = x in v


type MultiLegRptTypeReq =
    | ReportByMulitlegSecurityOnly
    | ReportByMultilegSecurityAndByInstrumentLegsBelongingToTheMultilegSecurity
    | ReportByInstrumentLegsBelongingToTheMultilegSecurityOnly


type LegPositionEffect =
    |LegPositionEffect of char
     member x.Value = let (LegPositionEffect v) = x in v


type LegCoveredOrUncovered =
    |LegCoveredOrUncovered of int
     member x.Value = let (LegCoveredOrUncovered v) = x in v


type LegPrice =
    |LegPrice of decimal
     member x.Value = let (LegPrice v) = x in v


type TradSesStatusRejReason =
    | UnknownOrInvalidTradingsessionid


type TradeRequestID =
    |TradeRequestID of string
     member x.Value = let (TradeRequestID v) = x in v


type TradeRequestType =
    | AllTrades
    | MatchedTradesMatchingCriteriaProvidedOnRequest
    | UnmatchedTradesThatMatchCriteria
    | UnreportedTradesThatMatchCriteria
    | AdvisoriesThatMatchCriteria


type PreviouslyReported =
    |PreviouslyReported of bool
     member x.Value = let (PreviouslyReported v) = x in v


type TradeReportID =
    |TradeReportID of string
     member x.Value = let (TradeReportID v) = x in v


type TradeReportRefID =
    |TradeReportRefID of string
     member x.Value = let (TradeReportRefID v) = x in v


type MatchStatus =
    | ComparedMatchedOrAffirmed
    | UncomparedUnmatchedOrUnaffirmed
    | AdvisoryOrAlert


type MatchType =
    |MatchType of string
     member x.Value = let (MatchType v) = x in v


type OddLot =
    |OddLot of bool
     member x.Value = let (OddLot v) = x in v


type NoClearingInstructions =
    |NoClearingInstructions of int
     member x.Value = let (NoClearingInstructions v) = x in v


type ClearingInstruction =
    | ProcessNormally
    | ExcludeFromAllNetting
    | BilateralNettingOnly
    | ExClearing
    | SpecialTrade
    | MultilateralNetting
    | ClearAgainstCentralCounterparty
    | ExcludeFromCentralCounterparty
    | ManualMode
    | AutomaticPostingMode
    | AutomaticGiveUpMode
    | QualifiedServiceRepresentative
    | CustomerTrade
    | SelfClearing


type TradeInputSource =
    |TradeInputSource of string
     member x.Value = let (TradeInputSource v) = x in v


type TradeInputDevice =
    |TradeInputDevice of string
     member x.Value = let (TradeInputDevice v) = x in v


type NoDates =
    |NoDates of int
     member x.Value = let (NoDates v) = x in v


type AccountType =
    | AccountIsCarriedOnCustomerSideOfBooks
    | AccountIsCarriedOnNonCustomerSideOfBooks
    | HouseTrader
    | FloorTrader
    | AccountIsCarriedOnNonCustomerSideOfBooksAndIsCrossMargined
    | AccountIsHouseTraderAndIsCrossMargined
    | JointBackofficeAccount


type CustOrderCapacity =
    | MemberTradingForTheirOwnAccount
    | ClearingFirmTradingForItsProprietaryAccount
    | MemberTradingForAnotherMember
    | AllOther


type ClOrdLinkID =
    |ClOrdLinkID of string
     member x.Value = let (ClOrdLinkID v) = x in v


type MassStatusReqID =
    |MassStatusReqID of string
     member x.Value = let (MassStatusReqID v) = x in v


type MassStatusReqType =
    | StatusForOrdersForASecurity
    | StatusForOrdersForAnUnderlyingSecurity
    | StatusForOrdersForAProduct
    | StatusForOrdersForACficode
    | StatusForOrdersForASecuritytype
    | StatusForOrdersForATradingSession
    | StatusForAllOrders
    | StatusForOrdersForAPartyid


type OrigOrdModTime =
    |OrigOrdModTime of UTCTimestamp
     member x.Value = let (OrigOrdModTime v) = x in v


type LegSettlType =
    |LegSettlType of char
     member x.Value = let (LegSettlType v) = x in v


type LegSettlDate =
    |LegSettlDate of string
     member x.Value = let (LegSettlDate v) = x in v


type DayBookingInst =
    | CanTriggerBookingWithoutReferenceToTheOrderInitiator
    | SpeakWithOrderInitiatorBeforeBooking
    | Accumulate


type BookingUnit =
    | EachPartialExecutionIsABookableUnit
    | AggregatePartialExecutionsOnThisOrderAndBookOneTradePerOrder
    | AggregateExecutionsForThisSymbolSideAndSettlementDate


type PreallocMethod =
    | ProRata
    | DoNotProRata


type UnderlyingCountryOfIssue =
    |UnderlyingCountryOfIssue of string
     member x.Value = let (UnderlyingCountryOfIssue v) = x in v


type UnderlyingStateOrProvinceOfIssue =
    |UnderlyingStateOrProvinceOfIssue of string
     member x.Value = let (UnderlyingStateOrProvinceOfIssue v) = x in v


type UnderlyingLocaleOfIssue =
    |UnderlyingLocaleOfIssue of string
     member x.Value = let (UnderlyingLocaleOfIssue v) = x in v


type UnderlyingInstrRegistry =
    |UnderlyingInstrRegistry of string
     member x.Value = let (UnderlyingInstrRegistry v) = x in v


type LegCountryOfIssue =
    |LegCountryOfIssue of string
     member x.Value = let (LegCountryOfIssue v) = x in v


type LegStateOrProvinceOfIssue =
    |LegStateOrProvinceOfIssue of string
     member x.Value = let (LegStateOrProvinceOfIssue v) = x in v


type LegLocaleOfIssue =
    |LegLocaleOfIssue of string
     member x.Value = let (LegLocaleOfIssue v) = x in v


type LegInstrRegistry =
    |LegInstrRegistry of string
     member x.Value = let (LegInstrRegistry v) = x in v


type LegSymbol =
    |LegSymbol of string
     member x.Value = let (LegSymbol v) = x in v


type LegSymbolSfx =
    |LegSymbolSfx of string
     member x.Value = let (LegSymbolSfx v) = x in v


type LegSecurityID =
    |LegSecurityID of string
     member x.Value = let (LegSecurityID v) = x in v


type LegSecurityIDSource =
    |LegSecurityIDSource of string
     member x.Value = let (LegSecurityIDSource v) = x in v


type NoLegSecurityAltID =
    |NoLegSecurityAltID of int
     member x.Value = let (NoLegSecurityAltID v) = x in v


type LegSecurityAltID =
    |LegSecurityAltID of string
     member x.Value = let (LegSecurityAltID v) = x in v


type LegSecurityAltIDSource =
    |LegSecurityAltIDSource of string
     member x.Value = let (LegSecurityAltIDSource v) = x in v


type LegProduct =
    |LegProduct of int
     member x.Value = let (LegProduct v) = x in v


type LegCFICode =
    |LegCFICode of string
     member x.Value = let (LegCFICode v) = x in v


type LegSecurityType =
    |LegSecurityType of string
     member x.Value = let (LegSecurityType v) = x in v


type LegMaturityMonthYear =
    |LegMaturityMonthYear of MonthYear
     member x.Value = let (LegMaturityMonthYear v) = x in v


type LegMaturityDate =
    |LegMaturityDate of string
     member x.Value = let (LegMaturityDate v) = x in v


type LegStrikePrice =
    |LegStrikePrice of decimal
     member x.Value = let (LegStrikePrice v) = x in v


type LegOptAttribute =
    |LegOptAttribute of char
     member x.Value = let (LegOptAttribute v) = x in v


type LegContractMultiplier =
    |LegContractMultiplier of decimal
     member x.Value = let (LegContractMultiplier v) = x in v


type LegCouponRate =
    |LegCouponRate of decimal
     member x.Value = let (LegCouponRate v) = x in v


type LegSecurityExchange =
    |LegSecurityExchange of string
     member x.Value = let (LegSecurityExchange v) = x in v


type LegIssuer =
    |LegIssuer of string
     member x.Value = let (LegIssuer v) = x in v


// compound len+str field
type EncodedLegIssuer =
    |EncodedLegIssuer of byte []
     member x.Value = let (EncodedLegIssuer v) = x in v


type LegSecurityDesc =
    |LegSecurityDesc of string
     member x.Value = let (LegSecurityDesc v) = x in v


// compound len+str field
type EncodedLegSecurityDesc =
    |EncodedLegSecurityDesc of byte []
     member x.Value = let (EncodedLegSecurityDesc v) = x in v


type LegRatioQty =
    |LegRatioQty of decimal
     member x.Value = let (LegRatioQty v) = x in v


type LegSide =
    |LegSide of char
     member x.Value = let (LegSide v) = x in v


type TradingSessionSubID =
    |TradingSessionSubID of string
     member x.Value = let (TradingSessionSubID v) = x in v


type AllocType =
    | Calculated
    | Preliminary
    | ReadyToBookSingleOrder
    | WarehouseInstruction
    | RequestToIntermediary


type NoHops =
    |NoHops of int
     member x.Value = let (NoHops v) = x in v


type HopCompID =
    |HopCompID of string
     member x.Value = let (HopCompID v) = x in v


type HopSendingTime =
    |HopSendingTime of UTCTimestamp
     member x.Value = let (HopSendingTime v) = x in v


type HopRefID =
    |HopRefID of uint32
     member x.Value = let (HopRefID v) = x in v


type MidPx =
    |MidPx of decimal
     member x.Value = let (MidPx v) = x in v


type BidYield =
    |BidYield of decimal
     member x.Value = let (BidYield v) = x in v


type MidYield =
    |MidYield of decimal
     member x.Value = let (MidYield v) = x in v


type OfferYield =
    |OfferYield of decimal
     member x.Value = let (OfferYield v) = x in v


type ClearingFeeIndicator =
    | CboeMember
    | NonMemberAndCustomer
    | EquityMemberAndClearingMember
    | FullAndAssociateMemberTradingForOwnAccountAndAsFloorBrokers
    | Firms106hAnd106j
    | GimIdemAndComMembershipInterestHolders
    | LesseeAnd106fEmployees
    | AllOtherOwnershipTypes


type WorkingIndicator =
    |WorkingIndicator of bool
     member x.Value = let (WorkingIndicator v) = x in v


type LegLastPx =
    |LegLastPx of decimal
     member x.Value = let (LegLastPx v) = x in v


type PriorityIndicator =
    | PriorityUnchanged
    | LostPriorityAsResultOfOrderChange


type PriceImprovement =
    |PriceImprovement of decimal
     member x.Value = let (PriceImprovement v) = x in v


type Price2 =
    |Price2 of decimal
     member x.Value = let (Price2 v) = x in v


type LastForwardPoints2 =
    |LastForwardPoints2 of decimal
     member x.Value = let (LastForwardPoints2 v) = x in v


type BidForwardPoints2 =
    |BidForwardPoints2 of decimal
     member x.Value = let (BidForwardPoints2 v) = x in v


type OfferForwardPoints2 =
    |OfferForwardPoints2 of decimal
     member x.Value = let (OfferForwardPoints2 v) = x in v


type RFQReqID =
    |RFQReqID of string
     member x.Value = let (RFQReqID v) = x in v


type MktBidPx =
    |MktBidPx of decimal
     member x.Value = let (MktBidPx v) = x in v


type MktOfferPx =
    |MktOfferPx of decimal
     member x.Value = let (MktOfferPx v) = x in v


type MinBidSize =
    |MinBidSize of decimal
     member x.Value = let (MinBidSize v) = x in v


type MinOfferSize =
    |MinOfferSize of decimal
     member x.Value = let (MinOfferSize v) = x in v


type QuoteStatusReqID =
    |QuoteStatusReqID of string
     member x.Value = let (QuoteStatusReqID v) = x in v


type LegalConfirm =
    |LegalConfirm of bool
     member x.Value = let (LegalConfirm v) = x in v


type UnderlyingLastPx =
    |UnderlyingLastPx of decimal
     member x.Value = let (UnderlyingLastPx v) = x in v


type UnderlyingLastQty =
    |UnderlyingLastQty of decimal
     member x.Value = let (UnderlyingLastQty v) = x in v


type LegRefID =
    |LegRefID of string
     member x.Value = let (LegRefID v) = x in v


type ContraLegRefID =
    |ContraLegRefID of string
     member x.Value = let (ContraLegRefID v) = x in v


type SettlCurrBidFxRate =
    |SettlCurrBidFxRate of decimal
     member x.Value = let (SettlCurrBidFxRate v) = x in v


type SettlCurrOfferFxRate =
    |SettlCurrOfferFxRate of decimal
     member x.Value = let (SettlCurrOfferFxRate v) = x in v


type QuoteRequestRejectReason =
    | UnknownSymbol
    | ExchangeClosed
    | QuoteRequestExceedsLimit
    | TooLateToEnter
    | InvalidPrice
    | NotAuthorizedToRequestQuote
    | NoMatchForInquiry
    | NoMarketForInstrument
    | NoInventory
    | Pass
    | Other


type SideComplianceID =
    |SideComplianceID of string
     member x.Value = let (SideComplianceID v) = x in v


type AcctIDSource =
    | Bic
    | SidCode
    | Tfm
    | Omgeo
    | DtccCode
    | Other


type AllocAcctIDSource =
    |AllocAcctIDSource of int
     member x.Value = let (AllocAcctIDSource v) = x in v


type BenchmarkPrice =
    |BenchmarkPrice of decimal
     member x.Value = let (BenchmarkPrice v) = x in v


type BenchmarkPriceType =
    |BenchmarkPriceType of int
     member x.Value = let (BenchmarkPriceType v) = x in v


type ConfirmID =
    |ConfirmID of string
     member x.Value = let (ConfirmID v) = x in v


type ConfirmStatus =
    | Received
    | MismatchedAccount
    | MissingSettlementInstructions
    | Confirmed
    | RequestRejected


type ConfirmTransType =
    | New
    | Replace
    | Cancel


type ContractSettlMonth =
    |ContractSettlMonth of MonthYear
     member x.Value = let (ContractSettlMonth v) = x in v


type DeliveryForm =
    | Bookentry
    | Bearer


type LastParPx =
    |LastParPx of decimal
     member x.Value = let (LastParPx v) = x in v


type NoLegAllocs =
    |NoLegAllocs of int
     member x.Value = let (NoLegAllocs v) = x in v


type LegAllocAccount =
    |LegAllocAccount of string
     member x.Value = let (LegAllocAccount v) = x in v


type LegIndividualAllocID =
    |LegIndividualAllocID of string
     member x.Value = let (LegIndividualAllocID v) = x in v


type LegAllocQty =
    |LegAllocQty of decimal
     member x.Value = let (LegAllocQty v) = x in v


type LegAllocAcctIDSource =
    |LegAllocAcctIDSource of string
     member x.Value = let (LegAllocAcctIDSource v) = x in v


type LegSettlCurrency =
    |LegSettlCurrency of string
     member x.Value = let (LegSettlCurrency v) = x in v


type LegBenchmarkCurveCurrency =
    |LegBenchmarkCurveCurrency of string
     member x.Value = let (LegBenchmarkCurveCurrency v) = x in v


type LegBenchmarkCurveName =
    |LegBenchmarkCurveName of string
     member x.Value = let (LegBenchmarkCurveName v) = x in v


type LegBenchmarkCurvePoint =
    |LegBenchmarkCurvePoint of string
     member x.Value = let (LegBenchmarkCurvePoint v) = x in v


type LegBenchmarkPrice =
    |LegBenchmarkPrice of decimal
     member x.Value = let (LegBenchmarkPrice v) = x in v


type LegBenchmarkPriceType =
    |LegBenchmarkPriceType of int
     member x.Value = let (LegBenchmarkPriceType v) = x in v


type LegBidPx =
    |LegBidPx of decimal
     member x.Value = let (LegBidPx v) = x in v


type LegIOIQty =
    |LegIOIQty of string
     member x.Value = let (LegIOIQty v) = x in v


type NoLegStipulations =
    |NoLegStipulations of int
     member x.Value = let (NoLegStipulations v) = x in v


type LegOfferPx =
    |LegOfferPx of decimal
     member x.Value = let (LegOfferPx v) = x in v


type LegOrderQty =
    |LegOrderQty of decimal
     member x.Value = let (LegOrderQty v) = x in v


type LegPriceType =
    |LegPriceType of int
     member x.Value = let (LegPriceType v) = x in v


type LegQty =
    |LegQty of decimal
     member x.Value = let (LegQty v) = x in v


type LegStipulationType =
    |LegStipulationType of string
     member x.Value = let (LegStipulationType v) = x in v


type LegStipulationValue =
    |LegStipulationValue of string
     member x.Value = let (LegStipulationValue v) = x in v


type LegSwapType =
    | ParForPar
    | ModifiedDuration
    | Risk
    | Proceeds


type Pool =
    |Pool of string
     member x.Value = let (Pool v) = x in v


type QuotePriceType =
    | Percent
    | PerShare
    | FixedAmount
    | Discount
    | Premium
    | BasisPointsRelativeToBenchmark
    | TedPrice
    | TedYield
    | YieldSpread
    | Yield


type QuoteRespID =
    |QuoteRespID of string
     member x.Value = let (QuoteRespID v) = x in v


type QuoteRespType =
    | HitLift
    | Counter
    | Expired
    | Cover
    | DoneAway
    | Pass


type QuoteQualifier =
    |QuoteQualifier of char
     member x.Value = let (QuoteQualifier v) = x in v


type YieldRedemptionDate =
    |YieldRedemptionDate of string
     member x.Value = let (YieldRedemptionDate v) = x in v


type YieldRedemptionPrice =
    |YieldRedemptionPrice of decimal
     member x.Value = let (YieldRedemptionPrice v) = x in v


type YieldRedemptionPriceType =
    |YieldRedemptionPriceType of int
     member x.Value = let (YieldRedemptionPriceType v) = x in v


type BenchmarkSecurityID =
    |BenchmarkSecurityID of string
     member x.Value = let (BenchmarkSecurityID v) = x in v


type ReversalIndicator =
    |ReversalIndicator of bool
     member x.Value = let (ReversalIndicator v) = x in v


type YieldCalcDate =
    |YieldCalcDate of string
     member x.Value = let (YieldCalcDate v) = x in v


type NoPositions =
    |NoPositions of int
     member x.Value = let (NoPositions v) = x in v


type PosType =
    | TransactionQuantity
    | IntraSpreadQty
    | InterSpreadQty
    | EndOfDayQty
    | StartOfDayQty
    | OptionExerciseQty
    | OptionAssignment
    | TransactionFromExercise
    | TransactionFromAssignment
    | PitTradeQty
    | TransferTradeQty
    | ElectronicTradeQty
    | AllocationTradeQty
    | AdjustmentQty
    | AsOfTradeQty
    | DeliveryQty
    | TotalTransactionQty
    | CrossMarginQty
    | IntegralSplit


type LongQty =
    |LongQty of decimal
     member x.Value = let (LongQty v) = x in v


type ShortQty =
    |ShortQty of decimal
     member x.Value = let (ShortQty v) = x in v


type PosQtyStatus =
    | Submitted
    | Accepted
    | Rejected


type PosAmtType =
    | FinalMarkToMarketAmount
    | IncrementalMarkToMarketAmount
    | TradeVariationAmount
    | StartOfDayMarkToMarketAmount
    | PremiumAmount
    | CashResidualAmount
    | CashAmount
    | ValueAdjustedAmount


type PosAmt =
    |PosAmt of decimal
     member x.Value = let (PosAmt v) = x in v


type PosTransType =
    | Exercise
    | DoNotExercise
    | PositionAdjustment
    | PositionChangeSubmissionMarginDisposition
    | Pledge


type PosReqID =
    |PosReqID of string
     member x.Value = let (PosReqID v) = x in v


type NoUnderlyings =
    |NoUnderlyings of int
     member x.Value = let (NoUnderlyings v) = x in v


type PosMaintAction =
    | New
    | Replace
    | Cancel


type OrigPosReqRefID =
    |OrigPosReqRefID of string
     member x.Value = let (OrigPosReqRefID v) = x in v


type PosMaintRptRefID =
    |PosMaintRptRefID of string
     member x.Value = let (PosMaintRptRefID v) = x in v


type ClearingBusinessDate =
    |ClearingBusinessDate of string
     member x.Value = let (ClearingBusinessDate v) = x in v


type SettlSessID =
    |SettlSessID of string
     member x.Value = let (SettlSessID v) = x in v


type SettlSessSubID =
    |SettlSessSubID of string
     member x.Value = let (SettlSessSubID v) = x in v


type AdjustmentType =
    | ProcessRequestAsMarginDisposition
    | DeltaPlus
    | DeltaMinus
    | Final


type ContraryInstructionIndicator =
    |ContraryInstructionIndicator of bool
     member x.Value = let (ContraryInstructionIndicator v) = x in v


type PriorSpreadIndicator =
    |PriorSpreadIndicator of bool
     member x.Value = let (PriorSpreadIndicator v) = x in v


type PosMaintRptID =
    |PosMaintRptID of string
     member x.Value = let (PosMaintRptID v) = x in v


type PosMaintStatus =
    | Accepted
    | AcceptedWithWarnings
    | Rejected
    | Completed
    | CompletedWithWarnings


type PosMaintResult =
    | SuccessfulCompletionNoWarningsOrErrors
    | Rejected
    | Other


type PosReqType =
    | Positions
    | Trades
    | Exercises
    | Assignments


type ResponseTransportType =
    | Inband
    | OutOfBand


type ResponseDestination =
    |ResponseDestination of string
     member x.Value = let (ResponseDestination v) = x in v


type TotalNumPosReports =
    |TotalNumPosReports of int
     member x.Value = let (TotalNumPosReports v) = x in v


type PosReqResult =
    | ValidRequest
    | InvalidOrUnsupportedRequest
    | NoPositionsFoundThatMatchCriteria
    | NotAuthorizedToRequestPositions
    | RequestForPositionNotSupported
    | Other


type PosReqStatus =
    | Completed
    | CompletedWithWarnings
    | Rejected


type SettlPrice =
    |SettlPrice of decimal
     member x.Value = let (SettlPrice v) = x in v


type SettlPriceType =
    | Final
    | Theoretical


type UnderlyingSettlPrice =
    |UnderlyingSettlPrice of decimal
     member x.Value = let (UnderlyingSettlPrice v) = x in v


type UnderlyingSettlPriceType =
    |UnderlyingSettlPriceType of int
     member x.Value = let (UnderlyingSettlPriceType v) = x in v


type PriorSettlPrice =
    |PriorSettlPrice of decimal
     member x.Value = let (PriorSettlPrice v) = x in v


type NoQuoteQualifiers =
    |NoQuoteQualifiers of int
     member x.Value = let (NoQuoteQualifiers v) = x in v


type AllocSettlCurrency =
    |AllocSettlCurrency of string
     member x.Value = let (AllocSettlCurrency v) = x in v


type AllocSettlCurrAmt =
    |AllocSettlCurrAmt of decimal
     member x.Value = let (AllocSettlCurrAmt v) = x in v


type InterestAtMaturity =
    |InterestAtMaturity of decimal
     member x.Value = let (InterestAtMaturity v) = x in v


type LegDatedDate =
    |LegDatedDate of string
     member x.Value = let (LegDatedDate v) = x in v


type LegPool =
    |LegPool of string
     member x.Value = let (LegPool v) = x in v


type AllocInterestAtMaturity =
    |AllocInterestAtMaturity of decimal
     member x.Value = let (AllocInterestAtMaturity v) = x in v


type AllocAccruedInterestAmt =
    |AllocAccruedInterestAmt of decimal
     member x.Value = let (AllocAccruedInterestAmt v) = x in v


type DeliveryDate =
    |DeliveryDate of string
     member x.Value = let (DeliveryDate v) = x in v


type AssignmentMethod =
    | Random
    | Prorata


type AssignmentUnit =
    |AssignmentUnit of decimal
     member x.Value = let (AssignmentUnit v) = x in v


type OpenInterest =
    |OpenInterest of decimal
     member x.Value = let (OpenInterest v) = x in v


type ExerciseMethod =
    | Automatic
    | Manual


type TotNumTradeReports =
    |TotNumTradeReports of int
     member x.Value = let (TotNumTradeReports v) = x in v


type TradeRequestResult =
    | Successful
    | InvalidOrUnknownInstrument
    | InvalidTypeOfTradeRequested
    | InvalidParties
    | InvalidTransportTypeRequested
    | InvalidDestinationRequested
    | TraderequesttypeNotSupported
    | UnauthorizedForTradeCaptureReportRequest
    | Yield


type TradeRequestStatus =
    | Accepted
    | Completed
    | Rejected


type TradeReportRejectReason =
    | Successful
    | InvalidPartyInformation
    | UnknownInstrument
    | UnauthorizedToReportTrades
    | InvalidTradeType
    | Yield


type SideMultiLegReportingType =
    | SingleSecurity
    | IndividualLegOfAMultiLegSecurity
    | MultiLegSecurity


type NoPosAmt =
    |NoPosAmt of int
     member x.Value = let (NoPosAmt v) = x in v


type AutoAcceptIndicator =
    |AutoAcceptIndicator of bool
     member x.Value = let (AutoAcceptIndicator v) = x in v


type AllocReportID =
    |AllocReportID of string
     member x.Value = let (AllocReportID v) = x in v


type NoNested2PartyIDs =
    |NoNested2PartyIDs of int
     member x.Value = let (NoNested2PartyIDs v) = x in v


type Nested2PartyID =
    |Nested2PartyID of string
     member x.Value = let (Nested2PartyID v) = x in v


type Nested2PartyIDSource =
    |Nested2PartyIDSource of char
     member x.Value = let (Nested2PartyIDSource v) = x in v


type Nested2PartyRole =
    |Nested2PartyRole of int
     member x.Value = let (Nested2PartyRole v) = x in v


type Nested2PartySubID =
    |Nested2PartySubID of string
     member x.Value = let (Nested2PartySubID v) = x in v


type BenchmarkSecurityIDSource =
    |BenchmarkSecurityIDSource of string
     member x.Value = let (BenchmarkSecurityIDSource v) = x in v


type SecuritySubType =
    |SecuritySubType of string
     member x.Value = let (SecuritySubType v) = x in v


type UnderlyingSecuritySubType =
    |UnderlyingSecuritySubType of string
     member x.Value = let (UnderlyingSecuritySubType v) = x in v


type LegSecuritySubType =
    |LegSecuritySubType of string
     member x.Value = let (LegSecuritySubType v) = x in v


type AllowableOneSidednessPct =
    |AllowableOneSidednessPct of decimal
     member x.Value = let (AllowableOneSidednessPct v) = x in v


type AllowableOneSidednessValue =
    |AllowableOneSidednessValue of decimal
     member x.Value = let (AllowableOneSidednessValue v) = x in v


type AllowableOneSidednessCurr =
    |AllowableOneSidednessCurr of string
     member x.Value = let (AllowableOneSidednessCurr v) = x in v


type NoTrdRegTimestamps =
    |NoTrdRegTimestamps of int
     member x.Value = let (NoTrdRegTimestamps v) = x in v


type TrdRegTimestamp =
    |TrdRegTimestamp of UTCTimestamp
     member x.Value = let (TrdRegTimestamp v) = x in v


type TrdRegTimestampType =
    | ExecutionTime
    | TimeIn
    | TimeOut
    | BrokerReceipt
    | BrokerExecution


type TrdRegTimestampOrigin =
    |TrdRegTimestampOrigin of string
     member x.Value = let (TrdRegTimestampOrigin v) = x in v


type ConfirmRefID =
    |ConfirmRefID of string
     member x.Value = let (ConfirmRefID v) = x in v


type ConfirmType =
    | Status
    | Confirmation
    | ConfirmationRequestRejected


type ConfirmRejReason =
    | MismatchedAccount
    | MissingSettlementInstructions
    | Other


type BookingType =
    | RegularBooking
    | Cfd
    | TotalReturnSwap


type IndividualAllocRejCode =
    |IndividualAllocRejCode of int
     member x.Value = let (IndividualAllocRejCode v) = x in v


type SettlInstMsgID =
    |SettlInstMsgID of string
     member x.Value = let (SettlInstMsgID v) = x in v


type NoSettlInst =
    |NoSettlInst of int
     member x.Value = let (NoSettlInst v) = x in v


type LastUpdateTime =
    |LastUpdateTime of UTCTimestamp
     member x.Value = let (LastUpdateTime v) = x in v


type AllocSettlInstType =
    | UseDefaultInstructions
    | DeriveFromParametersProvided
    | FullDetailsProvided
    | SsiDbIdsProvided
    | PhoneForInstructions


type NoSettlPartyIDs =
    |NoSettlPartyIDs of int
     member x.Value = let (NoSettlPartyIDs v) = x in v


type SettlPartyID =
    |SettlPartyID of string
     member x.Value = let (SettlPartyID v) = x in v


type SettlPartyIDSource =
    |SettlPartyIDSource of char
     member x.Value = let (SettlPartyIDSource v) = x in v


type SettlPartyRole =
    |SettlPartyRole of int
     member x.Value = let (SettlPartyRole v) = x in v


type SettlPartySubID =
    |SettlPartySubID of string
     member x.Value = let (SettlPartySubID v) = x in v


type SettlPartySubIDType =
    |SettlPartySubIDType of int
     member x.Value = let (SettlPartySubIDType v) = x in v


type DlvyInstType =
    | Securities
    | Cash


type TerminationType =
    | Overnight
    | Term
    | Flexible
    | Open


type NextExpectedMsgSeqNum =
    |NextExpectedMsgSeqNum of uint32
     member x.Value = let (NextExpectedMsgSeqNum v) = x in v


type OrdStatusReqID =
    |OrdStatusReqID of string
     member x.Value = let (OrdStatusReqID v) = x in v


type SettlInstReqID =
    |SettlInstReqID of string
     member x.Value = let (SettlInstReqID v) = x in v


type SettlInstReqRejCode =
    | UnableToProcessRequest
    | UnknownAccount
    | NoMatchingSettlementInstructionsFound
    | Other


type SecondaryAllocID =
    |SecondaryAllocID of string
     member x.Value = let (SecondaryAllocID v) = x in v


type AllocReportType =
    | SellsideCalculatedUsingPreliminary
    | SellsideCalculatedWithoutPreliminary
    | WarehouseRecap
    | RequestToIntermediary


type AllocReportRefID =
    |AllocReportRefID of string
     member x.Value = let (AllocReportRefID v) = x in v


type AllocCancReplaceReason =
    | OriginalDetailsIncompleteIncorrect
    | ChangeInUnderlyingOrderDetails


type CopyMsgIndicator =
    |CopyMsgIndicator of bool
     member x.Value = let (CopyMsgIndicator v) = x in v


type AllocAccountType =
    | AccountIsCarriedOnCustomerSideOfBooks
    | AccountIsCarriedOnNonCustomerSideOfBooks
    | HouseTrader
    | FloorTrader
    | AccountIsCarriedOnNonCustomerSideOfBooksAndIsCrossMargined
    | AccountIsHouseTraderAndIsCrossMargined
    | JointBackofficeAccount


type OrderAvgPx =
    |OrderAvgPx of decimal
     member x.Value = let (OrderAvgPx v) = x in v


type OrderBookingQty =
    |OrderBookingQty of decimal
     member x.Value = let (OrderBookingQty v) = x in v


type NoSettlPartySubIDs =
    |NoSettlPartySubIDs of int
     member x.Value = let (NoSettlPartySubIDs v) = x in v


type NoPartySubIDs =
    |NoPartySubIDs of int
     member x.Value = let (NoPartySubIDs v) = x in v


type PartySubIDType =
    |PartySubIDType of int
     member x.Value = let (PartySubIDType v) = x in v


type NoNestedPartySubIDs =
    |NoNestedPartySubIDs of int
     member x.Value = let (NoNestedPartySubIDs v) = x in v


type NestedPartySubIDType =
    |NestedPartySubIDType of int
     member x.Value = let (NestedPartySubIDType v) = x in v


type NoNested2PartySubIDs =
    |NoNested2PartySubIDs of int
     member x.Value = let (NoNested2PartySubIDs v) = x in v


type Nested2PartySubIDType =
    |Nested2PartySubIDType of int
     member x.Value = let (Nested2PartySubIDType v) = x in v


type AllocIntermedReqType =
    | PendingAccept
    | PendingRelease
    | PendingReversal
    | Accept
    | BlockLevelReject
    | AccountLevelReject


type UnderlyingPx =
    |UnderlyingPx of decimal
     member x.Value = let (UnderlyingPx v) = x in v


type PriceDelta =
    |PriceDelta of decimal
     member x.Value = let (PriceDelta v) = x in v


type ApplQueueMax =
    |ApplQueueMax of int
     member x.Value = let (ApplQueueMax v) = x in v


type ApplQueueDepth =
    |ApplQueueDepth of int
     member x.Value = let (ApplQueueDepth v) = x in v


type ApplQueueResolution =
    | NoActionTaken
    | QueueFlushed
    | OverlayLast
    | EndSession


type ApplQueueAction =
    | NoActionTaken
    | QueueFlushed
    | OverlayLast
    | EndSession


type NoAltMDSource =
    |NoAltMDSource of int
     member x.Value = let (NoAltMDSource v) = x in v


type AltMDSourceID =
    |AltMDSourceID of string
     member x.Value = let (AltMDSourceID v) = x in v


type SecondaryTradeReportID =
    |SecondaryTradeReportID of string
     member x.Value = let (SecondaryTradeReportID v) = x in v


type AvgPxIndicator =
    | NoAveragePricing
    | TradeIsPartOfAnAveragePriceGroupIdentifiedByTheTradelinkid
    | LastTradeInTheAveragePriceGroupIdentifiedByTheTradelinkid


type TradeLinkID =
    |TradeLinkID of string
     member x.Value = let (TradeLinkID v) = x in v


type OrderInputDevice =
    |OrderInputDevice of string
     member x.Value = let (OrderInputDevice v) = x in v


type UnderlyingTradingSessionID =
    |UnderlyingTradingSessionID of string
     member x.Value = let (UnderlyingTradingSessionID v) = x in v


type UnderlyingTradingSessionSubID =
    |UnderlyingTradingSessionSubID of string
     member x.Value = let (UnderlyingTradingSessionSubID v) = x in v


type TradeLegRefID =
    |TradeLegRefID of string
     member x.Value = let (TradeLegRefID v) = x in v


type ExchangeRule =
    |ExchangeRule of string
     member x.Value = let (ExchangeRule v) = x in v


type TradeAllocIndicator =
    | AllocationNotRequired
    | AllocationRequired
    | UseAllocationProvidedWithTheTrade


type ExpirationCycle =
    | ExpireOnTradingSessionClose
    | ExpireOnTradingSessionOpen


type TrdType =
    | RegularTrade
    | BlockTrade
    | Efp
    | Transfer
    | LateTrade
    | TTrade
    | WeightedAveragePriceTrade
    | BunchedTrade
    | LateBunchedTrade
    | PriorReferencePriceTrade
    | AfterHoursTrade


type TrdSubType =
    |TrdSubType of int
     member x.Value = let (TrdSubType v) = x in v


type TransferReason =
    |TransferReason of string
     member x.Value = let (TransferReason v) = x in v


type AsgnReqID =
    |AsgnReqID of string
     member x.Value = let (AsgnReqID v) = x in v


type TotNumAssignmentReports =
    |TotNumAssignmentReports of int
     member x.Value = let (TotNumAssignmentReports v) = x in v


type AsgnRptID =
    |AsgnRptID of string
     member x.Value = let (AsgnRptID v) = x in v


type ThresholdAmount =
    |ThresholdAmount of decimal
     member x.Value = let (ThresholdAmount v) = x in v


type PegMoveType =
    | Floating
    | Fixed


type PegOffsetType =
    | Price
    | BasisPoints
    | Ticks
    | PriceTierLevel


type PegLimitType =
    | OrBetter
    | Strict
    | OrWorse


type PegRoundDirection =
    | MoreAggressive
    | MorePassive


type PeggedPrice =
    |PeggedPrice of decimal
     member x.Value = let (PeggedPrice v) = x in v


type PegScope =
    | Local
    | National
    | Global
    | NationalExcludingLocal


type DiscretionMoveType =
    | Floating
    | Fixed


type DiscretionOffsetType =
    | Price
    | BasisPoints
    | Ticks
    | PriceTierLevel


type DiscretionLimitType =
    | OrBetter
    | Strict
    | OrWorse


type DiscretionRoundDirection =
    | MoreAggressive
    | MorePassive


type DiscretionPrice =
    |DiscretionPrice of decimal
     member x.Value = let (DiscretionPrice v) = x in v


type DiscretionScope =
    | Local
    | National
    | Global
    | NationalExcludingLocal


type TargetStrategy =
    |TargetStrategy of int
     member x.Value = let (TargetStrategy v) = x in v


type TargetStrategyParameters =
    |TargetStrategyParameters of string
     member x.Value = let (TargetStrategyParameters v) = x in v


type ParticipationRate =
    |ParticipationRate of decimal
     member x.Value = let (ParticipationRate v) = x in v


type TargetStrategyPerformance =
    |TargetStrategyPerformance of decimal
     member x.Value = let (TargetStrategyPerformance v) = x in v


type LastLiquidityInd =
    | AddedLiquidity
    | RemovedLiquidity
    | LiquidityRoutedOut


type PublishTrdIndicator =
    |PublishTrdIndicator of bool
     member x.Value = let (PublishTrdIndicator v) = x in v


type ShortSaleReason =
    | DealerSoldShort
    | DealerSoldShortExempt
    | SellingCustomerSoldShort
    | SellingCustomerSoldShortExempt
    | QualifedServiceRepresentativeOrAutomaticGiveupContraSideSoldShort
    | QsrOrAguContraSideSoldShortExempt


type QtyType =
    | Units
    | Contracts


type SecondaryTrdType =
    |SecondaryTrdType of int
     member x.Value = let (SecondaryTrdType v) = x in v


type TradeReportType =
    | Submit
    | Alleged
    | Accept
    | Decline
    | Addendum
    | NoWas
    | TradeReportCancel
    | LockedInTradeBreak


type AllocNoOrdersType =
    | NotSpecified
    | ExplicitListProvided


type SharedCommission =
    |SharedCommission of decimal
     member x.Value = let (SharedCommission v) = x in v


type ConfirmReqID =
    |ConfirmReqID of string
     member x.Value = let (ConfirmReqID v) = x in v


type AvgParPx =
    |AvgParPx of decimal
     member x.Value = let (AvgParPx v) = x in v


type ReportedPx =
    |ReportedPx of decimal
     member x.Value = let (ReportedPx v) = x in v


type NoCapacities =
    |NoCapacities of int
     member x.Value = let (NoCapacities v) = x in v


type OrderCapacityQty =
    |OrderCapacityQty of decimal
     member x.Value = let (OrderCapacityQty v) = x in v


type NoEvents =
    |NoEvents of int
     member x.Value = let (NoEvents v) = x in v


type EventType =
    | Put
    | Call
    | Tender
    | SinkingFundCall
    | Other


type EventDate =
    |EventDate of string
     member x.Value = let (EventDate v) = x in v


type EventPx =
    |EventPx of decimal
     member x.Value = let (EventPx v) = x in v


type EventText =
    |EventText of string
     member x.Value = let (EventText v) = x in v


type PctAtRisk =
    |PctAtRisk of decimal
     member x.Value = let (PctAtRisk v) = x in v


type NoInstrAttrib =
    |NoInstrAttrib of int
     member x.Value = let (NoInstrAttrib v) = x in v


type InstrAttribType =
    | Flat
    | ZeroCoupon
    | InterestBearing
    | NoPeriodicPayments
    | VariableRate
    | LessFeeForPut
    | SteppedCoupon
    | CouponPeriod
    | WhenAndIfIssued
    | OriginalIssueDiscount
    | CallablePuttable
    | EscrowedToMaturity
    | EscrowedToRedemptionDate
    | PreRefunded
    | InDefault
    | Unrated
    | Taxable
    | Indexed
    | SubjectToAlternativeMinimumTax
    | OriginalIssueDiscountPrice
    | CallableBelowMaturityValue
    | CallableWithoutNoticeByMailToHolderUnlessRegistered
    | Text


type InstrAttribValue =
    |InstrAttribValue of string
     member x.Value = let (InstrAttribValue v) = x in v


type DatedDate =
    |DatedDate of string
     member x.Value = let (DatedDate v) = x in v


type InterestAccrualDate =
    |InterestAccrualDate of string
     member x.Value = let (InterestAccrualDate v) = x in v


type CPProgram =
    |CPProgram of int
     member x.Value = let (CPProgram v) = x in v


type CPRegType =
    |CPRegType of string
     member x.Value = let (CPRegType v) = x in v


type UnderlyingCPProgram =
    |UnderlyingCPProgram of string
     member x.Value = let (UnderlyingCPProgram v) = x in v


type UnderlyingCPRegType =
    |UnderlyingCPRegType of string
     member x.Value = let (UnderlyingCPRegType v) = x in v


type UnderlyingQty =
    |UnderlyingQty of decimal
     member x.Value = let (UnderlyingQty v) = x in v


type TrdMatchID =
    |TrdMatchID of string
     member x.Value = let (TrdMatchID v) = x in v


type SecondaryTradeReportRefID =
    |SecondaryTradeReportRefID of string
     member x.Value = let (SecondaryTradeReportRefID v) = x in v


type UnderlyingDirtyPrice =
    |UnderlyingDirtyPrice of decimal
     member x.Value = let (UnderlyingDirtyPrice v) = x in v


type UnderlyingEndPrice =
    |UnderlyingEndPrice of decimal
     member x.Value = let (UnderlyingEndPrice v) = x in v


type UnderlyingStartValue =
    |UnderlyingStartValue of decimal
     member x.Value = let (UnderlyingStartValue v) = x in v


type UnderlyingCurrentValue =
    |UnderlyingCurrentValue of decimal
     member x.Value = let (UnderlyingCurrentValue v) = x in v


type UnderlyingEndValue =
    |UnderlyingEndValue of decimal
     member x.Value = let (UnderlyingEndValue v) = x in v


type NoUnderlyingStips =
    |NoUnderlyingStips of int
     member x.Value = let (NoUnderlyingStips v) = x in v


type UnderlyingStipType =
    |UnderlyingStipType of string
     member x.Value = let (UnderlyingStipType v) = x in v


type UnderlyingStipValue =
    |UnderlyingStipValue of string
     member x.Value = let (UnderlyingStipValue v) = x in v


type MaturityNetMoney =
    |MaturityNetMoney of decimal
     member x.Value = let (MaturityNetMoney v) = x in v


type MiscFeeBasis =
    | Absolute
    | PerUnit
    | Percentage


type TotNoAllocs =
    |TotNoAllocs of int
     member x.Value = let (TotNoAllocs v) = x in v


type LastFragment =
    |LastFragment of bool
     member x.Value = let (LastFragment v) = x in v


type CollReqID =
    |CollReqID of string
     member x.Value = let (CollReqID v) = x in v


type CollAsgnReason =
    | Initial
    | Scheduled
    | TimeWarning
    | MarginDeficiency
    | MarginExcess
    | ForwardCollateralDemand
    | EventOfDefault
    | AdverseTaxEvent


type CollInquiryQualifier =
    | Tradedate
    | GcInstrument
    | Collateralinstrument
    | SubstitutionEligible
    | NotAssigned
    | PartiallyAssigned
    | FullyAssigned
    | OutstandingTrades


type NoTrades =
    |NoTrades of int
     member x.Value = let (NoTrades v) = x in v


type MarginRatio =
    |MarginRatio of decimal
     member x.Value = let (MarginRatio v) = x in v


type MarginExcess =
    |MarginExcess of decimal
     member x.Value = let (MarginExcess v) = x in v


type TotalNetValue =
    |TotalNetValue of decimal
     member x.Value = let (TotalNetValue v) = x in v


type CashOutstanding =
    |CashOutstanding of decimal
     member x.Value = let (CashOutstanding v) = x in v


type CollAsgnID =
    |CollAsgnID of string
     member x.Value = let (CollAsgnID v) = x in v


type CollAsgnTransType =
    | New
    | Replace
    | Cancel
    | Release
    | Reverse


type CollRespID =
    |CollRespID of string
     member x.Value = let (CollRespID v) = x in v


type CollAsgnRespType =
    | Received
    | Accepted
    | Declined
    | Rejected


type CollAsgnRejectReason =
    | UnknownDeal
    | UnknownOrInvalidInstrument
    | UnauthorizedTransaction
    | InsufficientCollateral
    | InvalidTypeOfCollateral
    | ExcessiveSubstitution
    | Other


type CollAsgnRefID =
    |CollAsgnRefID of string
     member x.Value = let (CollAsgnRefID v) = x in v


type CollRptID =
    |CollRptID of string
     member x.Value = let (CollRptID v) = x in v


type CollInquiryID =
    |CollInquiryID of string
     member x.Value = let (CollInquiryID v) = x in v


type CollStatus =
    | Unassigned
    | PartiallyAssigned
    | AssignmentProposed
    | Assigned
    | Challenged


type TotNumReports =
    |TotNumReports of int
     member x.Value = let (TotNumReports v) = x in v


type LastRptRequested =
    |LastRptRequested of bool
     member x.Value = let (LastRptRequested v) = x in v


type AgreementDesc =
    |AgreementDesc of string
     member x.Value = let (AgreementDesc v) = x in v


type AgreementID =
    |AgreementID of string
     member x.Value = let (AgreementID v) = x in v


type AgreementDate =
    |AgreementDate of string
     member x.Value = let (AgreementDate v) = x in v


type StartDate =
    |StartDate of string
     member x.Value = let (StartDate v) = x in v


type EndDate =
    |EndDate of string
     member x.Value = let (EndDate v) = x in v


type AgreementCurrency =
    |AgreementCurrency of string
     member x.Value = let (AgreementCurrency v) = x in v


type DeliveryType =
    | VersusPayment
    | Free
    | TriParty
    | HoldInCustody


type EndAccruedInterestAmt =
    |EndAccruedInterestAmt of decimal
     member x.Value = let (EndAccruedInterestAmt v) = x in v


type StartCash =
    |StartCash of decimal
     member x.Value = let (StartCash v) = x in v


type EndCash =
    |EndCash of decimal
     member x.Value = let (EndCash v) = x in v


type UserRequestID =
    |UserRequestID of string
     member x.Value = let (UserRequestID v) = x in v


type UserRequestType =
    | Logonuser
    | Logoffuser
    | Changepasswordforuser
    | RequestIndividualUserStatus


type NewPassword =
    |NewPassword of string
     member x.Value = let (NewPassword v) = x in v


type UserStatus =
    | LoggedIn
    | NotLoggedIn
    | UserNotRecognised
    | PasswordIncorrect
    | PasswordChanged
    | Other


type UserStatusText =
    |UserStatusText of string
     member x.Value = let (UserStatusText v) = x in v


type StatusValue =
    | Connected
    | NotConnectedDownExpectedUp
    | NotConnectedDownExpectedDown
    | InProcess


type StatusText =
    |StatusText of string
     member x.Value = let (StatusText v) = x in v


type RefCompID =
    |RefCompID of string
     member x.Value = let (RefCompID v) = x in v


type RefSubID =
    |RefSubID of string
     member x.Value = let (RefSubID v) = x in v


type NetworkResponseID =
    |NetworkResponseID of string
     member x.Value = let (NetworkResponseID v) = x in v


type NetworkRequestID =
    |NetworkRequestID of string
     member x.Value = let (NetworkRequestID v) = x in v


type LastNetworkResponseID =
    |LastNetworkResponseID of string
     member x.Value = let (LastNetworkResponseID v) = x in v


type NetworkRequestType =
    | Snapshot
    | Subscribe
    | StopSubscribing
    | LevelOfDetail


type NoCompIDs =
    |NoCompIDs of int
     member x.Value = let (NoCompIDs v) = x in v


type NetworkStatusResponseType =
    | Full
    | IncrementalUpdate


type NoCollInquiryQualifier =
    |NoCollInquiryQualifier of int
     member x.Value = let (NoCollInquiryQualifier v) = x in v


type TrdRptStatus =
    | Accepted
    | Rejected


type AffirmStatus =
    | Received
    | ConfirmRejected
    | Affirmed


type UnderlyingStrikeCurrency =
    |UnderlyingStrikeCurrency of string
     member x.Value = let (UnderlyingStrikeCurrency v) = x in v


type LegStrikeCurrency =
    |LegStrikeCurrency of string
     member x.Value = let (LegStrikeCurrency v) = x in v


type TimeBracket =
    |TimeBracket of string
     member x.Value = let (TimeBracket v) = x in v


type CollAction =
    | Retain
    | Add
    | Remove


type CollInquiryStatus =
    | Accepted
    | AcceptedWithWarnings
    | Completed
    | CompletedWithWarnings
    | Rejected


type CollInquiryResult =
    | Successful
    | InvalidOrUnknownInstrument
    | InvalidOrUnknownCollateralType
    | InvalidParties
    | InvalidTransportTypeRequested
    | InvalidDestinationRequested
    | NoCollateralFoundForTheTradeSpecified
    | NoCollateralFoundForTheOrderSpecified
    | CollateralInquiryTypeNotSupported
    | UnauthorizedForCollateralInquiry
    | Other


type StrikeCurrency =
    |StrikeCurrency of string
     member x.Value = let (StrikeCurrency v) = x in v


type NoNested3PartyIDs =
    |NoNested3PartyIDs of int
     member x.Value = let (NoNested3PartyIDs v) = x in v


type Nested3PartyID =
    |Nested3PartyID of string
     member x.Value = let (Nested3PartyID v) = x in v


type Nested3PartyIDSource =
    |Nested3PartyIDSource of char
     member x.Value = let (Nested3PartyIDSource v) = x in v


type Nested3PartyRole =
    |Nested3PartyRole of int
     member x.Value = let (Nested3PartyRole v) = x in v


type NoNested3PartySubIDs =
    |NoNested3PartySubIDs of int
     member x.Value = let (NoNested3PartySubIDs v) = x in v


type Nested3PartySubID =
    |Nested3PartySubID of string
     member x.Value = let (Nested3PartySubID v) = x in v


type Nested3PartySubIDType =
    |Nested3PartySubIDType of int
     member x.Value = let (Nested3PartySubIDType v) = x in v


type LegContractSettlMonth =
    |LegContractSettlMonth of MonthYear
     member x.Value = let (LegContractSettlMonth v) = x in v


type LegInterestAccrualDate =
    |LegInterestAccrualDate of string
     member x.Value = let (LegInterestAccrualDate v) = x in v


