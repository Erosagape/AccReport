USE [acc_3x]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTotalDebitCredit]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[UpdateTotalDebitCredit]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePR_STATUS]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[UpdatePR_STATUS]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePO_STATUS]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[UpdatePO_STATUS]
GO
/****** Object:  StoredProcedure [dbo].[TestHR]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[TestHR]
GO
/****** Object:  StoredProcedure [dbo].[TestCall_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[TestCall_MNL]
GO
/****** Object:  StoredProcedure [dbo].[TestCall]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[TestCall]
GO
/****** Object:  StoredProcedure [dbo].[SetTWTLog]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetTWTLog]
GO
/****** Object:  StoredProcedure [dbo].[SetTransactionStock]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetTransactionStock]
GO
/****** Object:  StoredProcedure [dbo].[SetTransactionHeader]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetTransactionHeader]
GO
/****** Object:  StoredProcedure [dbo].[SetTransactionDetail]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetTransactionDetail]
GO
/****** Object:  StoredProcedure [dbo].[SetJournalHeader]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetJournalHeader]
GO
/****** Object:  StoredProcedure [dbo].[SetJournalDetail]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetJournalDetail]
GO
/****** Object:  StoredProcedure [dbo].[SetDataSale]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetDataSale]
GO
/****** Object:  StoredProcedure [dbo].[SetDataPurchase]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[SetDataPurchase]
GO
/****** Object:  StoredProcedure [dbo].[Process_RVFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_RVFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Process_ReceiptToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_ReceiptToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Process_PVFromBillPay]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_PVFromBillPay]
GO
/****** Object:  StoredProcedure [dbo].[Process_InvoiceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_InvoiceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Process_CustAdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_CustAdvanceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Process_CNDNToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_CNDNToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Process_ClearMoneyFromNoAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_ClearMoneyFromNoAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Process_ClearMoneyFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_ClearMoneyFromAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Process_ClearExpenseFromManualEntry]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_ClearExpenseFromManualEntry]
GO
/****** Object:  StoredProcedure [dbo].[Process_ClearExpenseFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_ClearExpenseFromAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Process_BillPayToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_BillPayToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Process_AdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Process_AdvanceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_WHTaxFromTransaction]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_WHTaxFromTransaction]
GO
/****** Object:  StoredProcedure [dbo].[Insert_WHTaxFromPC]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_WHTaxFromPC]
GO
/****** Object:  StoredProcedure [dbo].[Insert_WHTaxFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_WHTaxFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Transaction]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_Transaction]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromVender]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromVender]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromUser]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromUser]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromTCharge]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromTCharge]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromService]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromService]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromSCharge]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromSCharge]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromOCharge]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromOCharge]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromCustomer]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SubAccCodeFromCustomer]
GO
/****** Object:  StoredProcedure [dbo].[Insert_StockFromTransaction]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_StockFromTransaction]
GO
/****** Object:  StoredProcedure [dbo].[Insert_StockFromDO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_StockFromDO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SOFromSR]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SOFromSR]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SIToJournal_ByDate]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SIToJournal_ByDate]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SIToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SIToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SIFromSO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SIFromSO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SIFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SIFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_SalaryToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_SalaryToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromSO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RVFromSO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromSI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RVFromSI]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromRC]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RVFromRC]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromJob_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RVFromJob_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RVFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RVfromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RVfromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RefundFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RefundFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptToJournal_V4]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptToJournal_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptToJournal_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptToJournal_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ReceiptFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RCFromSO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RCFromSO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_RCFromSI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_RCFromSI]
GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickSellProduct]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_QuickSellProduct]
GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickReceive]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_QuickReceive]
GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickPayment]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_QuickPayment]
GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_QuickJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickCashSaleProduct]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_QuickCashSaleProduct]
GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickBuyAsset]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_QuickBuyAsset]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromTransaction]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromTransaction]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromPO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromPO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromPI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromPI]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromPC]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromPC]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromBillPay_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromBillPay_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromBillPay_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromBillPay_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromBillPay]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PVFromBillPay]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ProductsCodeFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromjob_demoacc]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ProductsCodeFromjob_demoacc]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromjob_3xacc]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ProductsCodeFromjob_3xacc]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromjob_3x]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ProductsCodeFromjob_3x]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ProductsCodeFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PostReceiptToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PostReceiptToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PostInvoiceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PostInvoiceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PostCNDNToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PostCNDNToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PostClearToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PostClearToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_POFromPR]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_POFromPR]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PIToJournal_ByDate]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PIToJournal_ByDate]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PIToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PIToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PIFromPO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PIFromPO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PIFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PIFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PCFromPO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PCFromPO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PCFromPI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PCFromPI]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PayrollToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PayrollToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_PayrollByStaff]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_PayrollByStaff]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Journal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_Journal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceToJournal_V4]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceToJournal_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceToJournal_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceToJournal_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_InvoiceFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DPToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DPToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DOFromSO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DOFromSO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DOFromSI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DOFromSI]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DOFromRC]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DOFromRC]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DIFromPO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DIFromPO]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DIFromPI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DIFromPI]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DIFromPC]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DIFromPC]
GO
/****** Object:  StoredProcedure [dbo].[Insert_DepreByDate]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_DepreByDate]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CustAdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CustAdvanceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CostToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CostToJournal_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CostToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CostToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CostFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CostFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CostFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CostFromAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CNDNToJournal_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CNDNToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CNDNFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_CNDNFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromNoAdvance_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearMoneyFromNoAdvance_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromNoAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearMoneyFromNoAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromAdvance_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearMoneyFromAdvance_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearMoneyFromAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromManualEntry_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromManualEntry_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromManualEntry_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromManualEntry]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromBillPay_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromBillPay_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromBillPay]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromBillPay]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromAdvance_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromAdvance_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromAdvance_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromAdvance_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ClearExpenseFromAdvance]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayToJournal_V4]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayToJournal_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayToJournal_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayToJournal_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BillPayFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_BD]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_BD]
GO
/****** Object:  StoredProcedure [dbo].[Insert_ARFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_ARFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceToJournal_V4]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceToJournal_V3]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceToJournal_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceToJournal_MNL]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceToJournal]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceFromJob_V2]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdvanceFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdjustSIJournalFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AdjustSIJournalFromJob]
GO
/****** Object:  StoredProcedure [dbo].[Insert_AddDeductPayroll]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Insert_AddDeductPayroll]
GO
/****** Object:  StoredProcedure [dbo].[GetWorkSheet_ByHeader_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetWorkSheet_ByHeader_V2]
GO
/****** Object:  StoredProcedure [dbo].[GetWorkSheet_ByHeader]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetWorkSheet_ByHeader]
GO
/****** Object:  StoredProcedure [dbo].[GetStockCard]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetStockCard]
GO
/****** Object:  StoredProcedure [dbo].[GetRefundFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetRefundFromJob]
GO
/****** Object:  StoredProcedure [dbo].[GetReceiptAPFromJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetReceiptAPFromJob]
GO
/****** Object:  StoredProcedure [dbo].[GetGLTemplate]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetGLTemplate]
GO
/****** Object:  StoredProcedure [dbo].[GetCashFlow_ByDate]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetCashFlow_ByDate]
GO
/****** Object:  StoredProcedure [dbo].[GetCashFlow]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetCashFlow]
GO
/****** Object:  StoredProcedure [dbo].[GetBalanceSheetCompare_V2]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetBalanceSheetCompare_V2]
GO
/****** Object:  StoredProcedure [dbo].[GetBalanceSheetCompare]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetBalanceSheetCompare]
GO
/****** Object:  StoredProcedure [dbo].[GetBalance_YearCompare]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetBalance_YearCompare]
GO
/****** Object:  StoredProcedure [dbo].[GetBalance_QuarterCompare]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetBalance_QuarterCompare]
GO
/****** Object:  StoredProcedure [dbo].[GetBalance_JournalByJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetBalance_JournalByJob]
GO
/****** Object:  StoredProcedure [dbo].[GetBalance_DateCompare]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[GetBalance_DateCompare]
GO
/****** Object:  StoredProcedure [dbo].[Generate_ReportGL_ByJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Generate_ReportGL_ByJob]
GO
/****** Object:  StoredProcedure [dbo].[Generate_ReportGL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Generate_ReportGL]
GO
/****** Object:  StoredProcedure [dbo].[Generate_GLClosingWHT]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Generate_GLClosingWHT]
GO
/****** Object:  StoredProcedure [dbo].[Generate_GLClosingVAT]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Generate_GLClosingVAT]
GO
/****** Object:  StoredProcedure [dbo].[Generate_GLClosingProfit]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Generate_GLClosingProfit]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_JOB_JOURNAL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[DELETE_JOB_JOURNAL]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ALL_TRANSCTION]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[DELETE_ALL_TRANSCTION]
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ALL_JOURNAL]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[DELETE_ALL_JOURNAL]
GO
/****** Object:  StoredProcedure [dbo].[CopyTransaction]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CopyTransaction]
GO
/****** Object:  StoredProcedure [dbo].[ClosePR]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[ClosePR]
GO
/****** Object:  StoredProcedure [dbo].[ClosePO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[ClosePO]
GO
/****** Object:  StoredProcedure [dbo].[CloseDI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CloseDI]
GO
/****** Object:  StoredProcedure [dbo].[CancelPR]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelPR]
GO
/****** Object:  StoredProcedure [dbo].[CancelPO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelPO]
GO
/****** Object:  StoredProcedure [dbo].[CancelPI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelPI]
GO
/****** Object:  StoredProcedure [dbo].[CancelPC]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelPC]
GO
/****** Object:  StoredProcedure [dbo].[CancelJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelJournal]
GO
/****** Object:  StoredProcedure [dbo].[CancelDO]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelDO]
GO
/****** Object:  StoredProcedure [dbo].[CancelDI]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[CancelDI]
GO
/****** Object:  StoredProcedure [dbo].[Calculate_Depre]    Script Date: 26/10/2026 12:29:15 ******/
DROP PROCEDURE IF EXISTS [dbo].[Calculate_Depre]
GO
/****** Object:  View [dbo].[vSum_TransactionByType]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_TransactionByType]
GO
/****** Object:  View [dbo].[vSum_TransactionByDocType]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_TransactionByDocType]
GO
/****** Object:  View [dbo].[vSum_StockByType]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_StockByType]
GO
/****** Object:  View [dbo].[vStock_Document]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vStock_Document]
GO
/****** Object:  View [dbo].[vRV_LinkJob]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vRV_LinkJob]
GO
/****** Object:  View [dbo].[vRC_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vRC_All]
GO
/****** Object:  View [dbo].[vProfileConfig]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vProfileConfig]
GO
/****** Object:  View [dbo].[vPC_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_All]
GO
/****** Object:  View [dbo].[vMas_User]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_User]
GO
/****** Object:  View [dbo].[vMas_HROrgChart]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_HROrgChart]
GO
/****** Object:  View [dbo].[vMas_DocConfigSchema]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_DocConfigSchema]
GO
/****** Object:  View [dbo].[vMas_AccConfigCode]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_AccConfigCode]
GO
/****** Object:  View [dbo].[vJournal_ByPeriod]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vJournal_ByPeriod]
GO
/****** Object:  View [dbo].[vHR_WorkTimeSummary]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_WorkTimeSummary]
GO
/****** Object:  View [dbo].[vHR_WorkTimeDetail]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_WorkTimeDetail]
GO
/****** Object:  View [dbo].[vHR_PayrollSlip]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_PayrollSlip]
GO
/****** Object:  View [dbo].[vDI_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vDI_All]
GO
/****** Object:  View [dbo].[vAcc_CodeConfig]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAcc_CodeConfig]
GO
/****** Object:  View [dbo].[vPC_CheckPO]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_CheckPO]
GO
/****** Object:  View [dbo].[vBalanceSheet]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vBalanceSheet]
GO
/****** Object:  View [dbo].[vOrder_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vOrder_Balance]
GO
/****** Object:  View [dbo].[vStock_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vStock_Balance]
GO
/****** Object:  View [dbo].[vSO_Delivery]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSO_Delivery]
GO
/****** Object:  View [dbo].[vSO_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSO_Balance]
GO
/****** Object:  View [dbo].[vDO_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vDO_All]
GO
/****** Object:  View [dbo].[vTransaction_LinkBack]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTransaction_LinkBack]
GO
/****** Object:  View [dbo].[vSum_AllType]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_AllType]
GO
/****** Object:  View [dbo].[vTransaction_Link]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTransaction_Link]
GO
/****** Object:  View [dbo].[vPO_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPO_Balance]
GO
/****** Object:  View [dbo].[vPO_Delivery]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPO_Delivery]
GO
/****** Object:  View [dbo].[vSum_Stock]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_Stock]
GO
/****** Object:  View [dbo].[vSum_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_Balance]
GO
/****** Object:  View [dbo].[vProfitLoss]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vProfitLoss]
GO
/****** Object:  View [dbo].[vTrialBalance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTrialBalance]
GO
/****** Object:  View [dbo].[vStock_Card]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vStock_Card]
GO
/****** Object:  View [dbo].[vStock_Onhand]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vStock_Onhand]
GO
/****** Object:  View [dbo].[vSum_JournalByPrefix]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_JournalByPrefix]
GO
/****** Object:  View [dbo].[vPR_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPR_Balance]
GO
/****** Object:  View [dbo].[vPR_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPR_All]
GO
/****** Object:  View [dbo].[vPO_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPO_All]
GO
/****** Object:  View [dbo].[vCalculate_Depre_Double]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vCalculate_Depre_Double]
GO
/****** Object:  View [dbo].[vCalculate_Depre_Straight]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vCalculate_Depre_Straight]
GO
/****** Object:  View [dbo].[vSR_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSR_Balance]
GO
/****** Object:  View [dbo].[vSR_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSR_All]
GO
/****** Object:  View [dbo].[vSO_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSO_All]
GO
/****** Object:  View [dbo].[vSum_BalanceMonthlyCompare]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_BalanceMonthlyCompare]
GO
/****** Object:  View [dbo].[vSum_BalanceMonthlyAccumulate]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_BalanceMonthlyAccumulate]
GO
/****** Object:  View [dbo].[vSum_BalanceMonthlyCalculate]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_BalanceMonthlyCalculate]
GO
/****** Object:  View [dbo].[vSum_BalanceMonthly]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_BalanceMonthly]
GO
/****** Object:  View [dbo].[vTrial_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTrial_Balance]
GO
/****** Object:  View [dbo].[vMas_AccountSheet]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_AccountSheet]
GO
/****** Object:  View [dbo].[vRV_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vRV_All]
GO
/****** Object:  View [dbo].[vPV_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPV_All]
GO
/****** Object:  View [dbo].[vMas_DocConfigStandard]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_DocConfigStandard]
GO
/****** Object:  View [dbo].[vDI_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vDI_H]
GO
/****** Object:  View [dbo].[vDI_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vDI_D]
GO
/****** Object:  View [dbo].[vDO_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vDO_H]
GO
/****** Object:  View [dbo].[vDO_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vDO_D]
GO
/****** Object:  View [dbo].[vSR_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSR_H]
GO
/****** Object:  View [dbo].[vSR_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSR_D]
GO
/****** Object:  View [dbo].[vSO_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSO_H]
GO
/****** Object:  View [dbo].[vSO_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSO_D]
GO
/****** Object:  View [dbo].[vPR_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPR_H]
GO
/****** Object:  View [dbo].[vPR_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPR_D]
GO
/****** Object:  View [dbo].[vPC_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_H]
GO
/****** Object:  View [dbo].[vPC_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_D]
GO
/****** Object:  View [dbo].[vRC_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vRC_H]
GO
/****** Object:  View [dbo].[vRC_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vRC_D]
GO
/****** Object:  View [dbo].[vPC_BalanceBySource]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_BalanceBySource]
GO
/****** Object:  View [dbo].[vPC_BalanceByDoc]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_BalanceByDoc]
GO
/****** Object:  View [dbo].[vPC_BalanceByParty]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_BalanceByParty]
GO
/****** Object:  View [dbo].[vPC_BalanceByProduct]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_BalanceByProduct]
GO
/****** Object:  View [dbo].[vPC_BalanceBySaleDesc]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_BalanceBySaleDesc]
GO
/****** Object:  View [dbo].[vPC_Collect]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPC_Collect]
GO
/****** Object:  View [dbo].[vSI_BalanceBySaleDesc]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSI_BalanceBySaleDesc]
GO
/****** Object:  View [dbo].[vSI_BalanceByProduct]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSI_BalanceByProduct]
GO
/****** Object:  View [dbo].[vSI_BalanceByParty]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSI_BalanceByParty]
GO
/****** Object:  View [dbo].[vSI_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSI_Balance]
GO
/****** Object:  View [dbo].[vSI_Receive]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSI_Receive]
GO
/****** Object:  View [dbo].[vSum_JournalByType]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vSum_JournalByType]
GO
/****** Object:  View [dbo].[vAV_Payment]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAV_Payment]
GO
/****** Object:  View [dbo].[vAV_BalanceByEmp]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAV_BalanceByEmp]
GO
/****** Object:  View [dbo].[vAV_BalanceByParty]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAV_BalanceByParty]
GO
/****** Object:  View [dbo].[vHR_Salary]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_Salary]
GO
/****** Object:  View [dbo].[vHR_SalaryConfig]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_SalaryConfig]
GO
/****** Object:  View [dbo].[vHR_PayrollConfig]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_PayrollConfig]
GO
/****** Object:  View [dbo].[vHR_CalTaxEmp]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_CalTaxEmp]
GO
/****** Object:  View [dbo].[vHR_PayRoll]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vHR_PayRoll]
GO
/****** Object:  View [dbo].[vAV_BalanceByDoc]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAV_BalanceByDoc]
GO
/****** Object:  View [dbo].[vAV_Balance]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAV_Balance]
GO
/****** Object:  View [dbo].[vAV_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAV_All]
GO
/****** Object:  View [dbo].[vAR_Payment]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAR_Payment]
GO
/****** Object:  View [dbo].[vAR_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAR_H]
GO
/****** Object:  View [dbo].[vAR_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAR_D]
GO
/****** Object:  View [dbo].[vAP_Payment]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAP_Payment]
GO
/****** Object:  View [dbo].[vAP_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAP_H]
GO
/****** Object:  View [dbo].[vAP_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vAP_D]
GO
/****** Object:  View [dbo].[vPO_Payment]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPO_Payment]
GO
/****** Object:  View [dbo].[vJournal_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vJournal_All]
GO
/****** Object:  View [dbo].[vJournal_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vJournal_H]
GO
/****** Object:  View [dbo].[vJournal_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vJournal_D]
GO
/****** Object:  View [dbo].[vTransaction_All]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTransaction_All]
GO
/****** Object:  View [dbo].[vTransaction_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTransaction_H]
GO
/****** Object:  View [dbo].[vTransaction_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vTransaction_D]
GO
/****** Object:  View [dbo].[vPO_H]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPO_H]
GO
/****** Object:  View [dbo].[vPO_D]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vPO_D]
GO
/****** Object:  View [dbo].[vMas_Product]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_Product]
GO
/****** Object:  View [dbo].[vMas_ProductType]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_ProductType]
GO
/****** Object:  View [dbo].[vMas_Warehouse]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_Warehouse]
GO
/****** Object:  View [dbo].[vMas_AccCode]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_AccCode]
GO
/****** Object:  View [dbo].[vMas_ModuleMenu]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_ModuleMenu]
GO
/****** Object:  View [dbo].[vMas_UserRoleAll]    Script Date: 26/10/2026 12:29:15 ******/
DROP VIEW IF EXISTS [dbo].[vMas_UserRoleAll]
GO
/****** Object:  UserDefinedFunction [dbo].[ProcessAddressSingle]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[ProcessAddressSingle]
GO
/****** Object:  UserDefinedFunction [dbo].[GetRunning]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetRunning]
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewTransaction]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetNewTransaction]
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewStaffCode]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetNewStaffCode]
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewRunning]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetNewRunning]
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewProduct]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetNewProduct]
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewJournal]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetNewJournal]
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewEntry]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetNewEntry]
GO
/****** Object:  UserDefinedFunction [dbo].[GetMaxRunning]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetMaxRunning]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAuthorize]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetAuthorize]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAccConfig]    Script Date: 26/10/2026 12:29:15 ******/
DROP FUNCTION IF EXISTS [dbo].[GetAccConfig]
GO
/****** Object:  UserDefinedFunction [dbo].[GetAccConfig]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetAccConfig]
(
	@code nvarchar(50),
	@key nvarchar(50)
)
returns nvarchar(50)
as
begin
	declare @val nvarchar(50);
	SELECT @val=ConfigValue FROM dbo.Mas_AccConfig WHERE ConfigCode=@code AND ConfigKey=@key;
	return @val;
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetAuthorize]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetAuthorize]
(
@userid varchar(50),
@module varchar(20),
@menu varchar(20)
)
returns varchar(20)
as 
begin
declare @author varchar(20)=''

select @author=isnull(b.Author,'') 
from Mas_UserRoleAssign a
inner join Mas_UserRoleAuthor b
on a.RoleID=b.RoleID
where a.UserID=@userid
and b.ModuleID=@module
and b.MenuID=@menu

return @author
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetMaxRunning]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetMaxRunning]
(
	@running varchar(50),
	@mask varchar(50)
)
returns varchar(50)
as
begin
	declare @countnum int=len(@mask)-len(REPLACE(@mask,'_',''))
	declare @format varchar(50)=REPLACE(SUBSTRING(@mask,len(@mask)-@countnum+1,@countnum),'_','0')
	declare @icount int=len(@running)-@countnum
	declare @val varchar(50)=''
	declare @header varchar(50)=substring(@running,1,len(@running)-@countnum)
	
	declare @c int=@countnum;

	while @c>0
	begin
		set @c=@c-1
		set @val=concat(@val,SUBSTRING(@running,(LEN(@running)-@c),1))
	end
	
	set @running=UPPER(concat(@header,FORMAT(CONVERT(int,@val)+1,@format)))
	
	return @running
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewEntry]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[GetNewEntry]
(  
 @header varchar(10),
 @format varchar(10)
)
returns int
as 
begin
/**
รูปแบบข้อมูล BL24060001
ต้องการหา running จาก 
format=0000
header=BL2406
startpos=LEN(header)+1=6+1=7
countchr=LEN(format)=4
**/
declare @countchr int=LEN(@format);
declare @startpos int=LEN(@header)+1;
declare @running varchar(10);
set @running=(SELECT convert(int,isnull(MAX(SUBSTRING(JournalNo,@startpos,@countchr)),0)+1) as run FROM Acc_JournalHD WHERE JournalNo like @header+'%')

return @running;
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetNewJournal]
(  
 @header varchar(10),
 @format varchar(10)
)
returns varchar(50)
as 
begin
/**
รูปแบบข้อมูล BL24060001
ต้องการหา running จาก 
format=0000
header=BL2406
startpos=LEN(header)+1=6+1=7
countchr=LEN(format)=4
**/
declare @countchr int=LEN(@format);
declare @startpos int=LEN(@header)+1;
declare @running varchar(10);
set @running=(SELECT CONCAT(@header,ISNULL(FORMAT(convert(int,MAX(SUBSTRING(JournalNo,@startpos,@countchr)))+1,@format),FORMAT(1,@format))) as run FROM Acc_JournalHD WHERE JournalNo like @header+'%')

return @running;
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewProduct]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetNewProduct]
(
	@fmt varchar(50),
	@docdate date,
	@whc varchar(10)='',
	@typ varchar(10)=''
)
returns varchar(50)
as
begin
	declare @tmp varchar(50)=LOWER(@fmt)
	declare @countnum int=len(@fmt)-len(REPLACE(@fmt,'#',''))
	
	set @tmp=REPLACE(@tmp,'[wh]',@whc)
	set @tmp=REPLACE(@tmp,'[ty]',@typ)
	set @tmp=REPLACE(@tmp,'[yyyy]',FORMAT(@docdate,'yyyy'))
	set @tmp=REPLACE(@tmp,'[yy]',FORMAT(@docdate,'yy'))
	set @tmp=REPLACE(@tmp,'[mm]',FORMAT(@docdate,'MM'))
	set @tmp=REPLACE(@tmp,'[dd]',FORMAT(@docdate,'dd'))
	set @tmp=REPLACE(@tmp,'#','_')

	declare @running varchar(50)=(select isnull(max(ProductCode),REPLACE(@tmp,'_','0')) from vMas_Product 
	where WarehouseCode like @whc+'%' and ProductTypeCode like @typ+'%' and ProductCode like @tmp)

	declare @icount int=len(@running)-@countnum
	declare @val varchar(50)=''
	declare @header varchar(50)=substring(@running,1,len(@running)-@countnum)
	declare @format varchar(50)=replace(substring(@fmt,len(@fmt)-@countnum+1,@countnum),'#','0')
	
	declare @c int=@countnum;

	while @c>0
	begin
		set @c=@c-1
		set @val=concat(@val,SUBSTRING(@running,(LEN(@running)-@c),1))
	end
	
	set @running=UPPER(concat(@header,FORMAT(CONVERT(int,@val)+1,@format)))
	
	return @running
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewRunning]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE function [dbo].[GetNewRunning]
(  
 @doctype varchar(10),
 @tb varchar(2), --T=Transaction,J=Journal
 @docdate date
)
returns varchar(50)
as 
begin
declare @prefix varchar(20)=''
if @prefix=''
begin
	set @prefix=@doctype;
end

declare @fmt  varchar(10)='0000';

declare @header varchar(10);
set @header=CONCAT(@prefix,FORMAT(@docdate,'yyMM'));

declare @running varchar(20)='';
if(@tb='T')
begin
	set @running=dbo.GetNewTransaction(@header,@fmt);
end 
else
begin
	set @running=dbo.GetNewJournal(@header,@fmt);
end 
return @running;
end

GO
/****** Object:  UserDefinedFunction [dbo].[GetNewStaffCode]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[GetNewStaffCode]
(
	@fmt varchar(50),
	@department varchar(10)='',
	@division varchar(10)=''
)
returns varchar(50)
as
begin
	declare @tmp varchar(50)=LOWER(@fmt)
	declare @countnum int=len(@fmt)-len(REPLACE(@fmt,'#',''))
	
	set @tmp=REPLACE(@tmp,'[dp]',@department)
	set @tmp=REPLACE(@tmp,'[dv]',@division)
	set @tmp=REPLACE(@tmp,'#','_')

	declare @running varchar(50)=(select isnull(max(StaffCode),REPLACE(@tmp,'_','0')) from Mas_HRStaff 
	where StaffCode like @tmp)

	return dbo.GetMaxRunning(@running,@tmp)
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetNewTransaction]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[GetNewTransaction]
(  
 @header varchar(10),
 @format varchar(10)
)
returns varchar(50)
as 
begin
/**
รูปแบบข้อมูล BL24060001
ต้องการหา running จาก 
format=0000
header=BL2406
startpos=LEN(header)+1=6+1=7
countchr=LEN(format)=4
**/
declare @countchr int=LEN(@format);
declare @startpos int=LEN(@header)+1;
declare @running varchar(10);
set @running=(SELECT CONCAT(@header,ISNULL(FORMAT(convert(int,MAX(SUBSTRING(AccDocNo,@startpos,@countchr)))+1,@format),FORMAT(1,@format))) as run FROM Acc_TransactionHD WHERE AccDocNo like @header+'%')

return @running;
end
GO
/****** Object:  UserDefinedFunction [dbo].[GetRunning]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






create function [dbo].[GetRunning]
(  
 @doctype varchar(10),
 @tb varchar(2), --T=Transaction,J=Journal
 @docdate date,
 @prefix nvarchar(10)
)
returns varchar(50)
as 
begin
if @prefix=''
begin
	set @prefix=@doctype;
end

declare @fmt  varchar(10)='0000';

declare @header varchar(10);
set @header=CONCAT(@prefix,FORMAT(@docdate,'yyMM'));

declare @running varchar(20)='';
if(@tb='T')
begin
	set @running=dbo.GetNewTransaction(@header,@fmt);
end 
else
begin
	set @running=dbo.GetNewJournal(@header,@fmt);
end 
return @running;
end

GO
/****** Object:  UserDefinedFunction [dbo].[ProcessAddressSingle]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE function [dbo].[ProcessAddressSingle]
(
@textaddress nvarchar(max)
)
returns nvarchar(max)
as
begin
declare @postcode varchar(5)='';
declare @processtext nvarchar(MAX)=RTRIM(LTRIM(@textaddress));
declare @lengthtext int=LEN(@processtext);

set @postcode=substring(@processtext,@lengthtext-4,5);
IF ISNUMERIC(@postcode)=0
BEGIN
	SET @postcode='';
END
set @processtext= REPLACE(@processtext,@postcode,'');

set @processtext= REPLACE(@processtext,'จ.','จังหวัด');
declare @searchtext nvarchar(50)='จังหวัด';

declare @indexprov int=CHARINDEX(@searchtext,@processtext);
declare @provtext varchar(500)='';
if @indexprov>0 
begin
	set @provtext=replace(substring(@processtext,@indexprov,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexprov,255),'');
end
set @provtext=LTRIM(RTRIM(@provtext));

set @processtext= REPLACE(@processtext,'ต.','ตำบล');
set @processtext= REPLACE(@processtext,'อ.','อำเภอ');
set @processtext= REPLACE(@processtext,'แขวง','ตำบล');
set @processtext= REPLACE(@processtext,'เขต','อำเภอ');

set @searchtext='อำเภอ';

declare @indexamp int=CHARINDEX(@searchtext,@processtext);
declare @amptext varchar(500)='';
if @indexamp>0 
begin
	set @amptext=replace(substring(@processtext,@indexamp,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexamp,255),'');
	if @provtext='' and CHARINDEX(' ',@amptext)>0
	begin 
		set @provtext=LTRIM(RTRIM(substring(@amptext,CHARINDEX(' ',@amptext),255)));
		set @amptext=REPLACE(@amptext,@provtext,'');
	end
end
set @amptext=LTRIM(RTRIM(@amptext));

set @searchtext='ตำบล';

declare @indextum int=CHARINDEX(@searchtext,@processtext);
declare @tumtext varchar(500)='';
if @indextum>0 
begin
	set @tumtext=replace(substring(@processtext,@indextum,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indextum,255),'');
end
set @tumtext=LTRIM(RTRIM(@tumtext));

set @processtext= REPLACE(@processtext,'ถ.','ถนน');

set @searchtext='ถนน';

declare @indexroad int=CHARINDEX(@searchtext,@processtext);
declare @roadtext varchar(500)='';
if @indexroad>0 
begin
	set @roadtext=replace(substring(@processtext,@indexroad,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexroad,255),'');
end
set @roadtext=LTRIM(RTRIM(@roadtext));

set @processtext= REPLACE(@processtext,'ครอก','ซอย');
set @processtext= REPLACE(@processtext,'ซ.','ซอย');

set @searchtext='ซอย';

declare @indexsoi int=CHARINDEX(@searchtext,@processtext);
declare @soitext varchar(500)='';
if @indexsoi>0 
begin
	set @soitext=replace(substring(@processtext,@indexsoi,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexsoi,255),'');
end
set @soitext=LTRIM(RTRIM(@soitext));

set @processtext= REPLACE(@processtext,'ชั้นที่','ชั้น');
set @processtext= REPLACE(@processtext,'หมู่ที่','หมู่');
set @processtext= REPLACE(@processtext,'ม.','หมู่');
set @processtext= REPLACE(@processtext,'ห้องที่','ห้อง');
set @processtext= REPLACE(@processtext,'ห้องเลขที่','ห้อง');

declare @housenametext varchar(500)='';
declare @indexhousename int = CHARINDEX('หมู่บ้าน', @processtext);
    declare @indexpier int = CHARINDEX('ท่า', @processtext);
    declare @indexindustrial int = CHARINDEX('นิคม', @processtext);

    if @indexhousename > 0
    begin
        set @housenametext = LTRIM(RTRIM(SUBSTRING(@processtext, @indexhousename + LEN('หมู่บ้าน') -1 , 255)));
        set @processtext = LTRIM(RTRIM(REPLACE(@processtext, SUBSTRING(@processtext, @indexhousename, 255), '')));
    end
    else if @indexpier > 0
    begin
        set @housenametext = LTRIM(RTRIM(SUBSTRING(@processtext, @indexpier, 255)));
        set @processtext = LTRIM(RTRIM(REPLACE(@processtext, SUBSTRING(@processtext, @indexpier, 255), '')));
    end
    else if @indexindustrial > 0
    begin
        set @housenametext = LTRIM(RTRIM(SUBSTRING(@processtext, @indexindustrial, 255)));
        set @processtext = LTRIM(RTRIM(REPLACE(@processtext, SUBSTRING(@processtext, @indexindustrial, 255), '')));
    end
set @searchtext='ห้อง';

declare @indexroom int=CHARINDEX(@searchtext,@processtext);
declare @roomtext varchar(500)='';
if @indexroom>0 
begin
	set @roomtext=replace(substring(@processtext,@indexroom,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexroom,255),'');
end
set @roomtext=LTRIM(RTRIM(@roomtext));

set @searchtext='ชั้น';

declare @indexfloor int=CHARINDEX(@searchtext,@processtext);
declare @floortext varchar(500)='';
if @indexfloor>0 
begin
	set @floortext=replace(substring(@processtext,@indexfloor,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexfloor,255),'');
end
set @floortext=LTRIM(RTRIM(@floortext));

set @searchtext='อาคาร';

declare @indexbldg int=CHARINDEX(@searchtext,@processtext);
declare @bldgtext varchar(500)='';
if @indexbldg>0 
begin
	set @bldgtext=replace(substring(@processtext,@indexbldg,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexbldg,255),'');
end
set @bldgtext=LTRIM(RTRIM(@bldgtext));

set @searchtext='หมู่';

declare @indexmoo int=CHARINDEX(@searchtext,@processtext);
declare @mootext varchar(500)='';
if @indexmoo>0 
begin
	set @mootext=replace(substring(@processtext,@indexmoo,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexmoo,255),'');
end
set @mootext=LTRIM(RTRIM(@mootext));

set @searchtext='เลขที่';

declare @indexhouseno int=CHARINDEX(@searchtext,@processtext);
declare @housenotext varchar(500)='';
if @indexhouseno>0 
begin
	set @housenotext=replace(substring(@processtext,@indexhouseno,255),@searchtext,'');
	set @processtext= REPLACE(@processtext,substring(@processtext,@indexhouseno,255),'');
end
set @housenotext=LTRIM(RTRIM(@housenotext));

if @housenotext='' and @processtext<>''
begin
	set @housenotext=@processtext;
end

return concat(@bldgtext,'|',
@roomtext,'|',
@floortext,'|',
@housenametext,'|',
@housenotext,'|',
@mootext,'|',
@soitext,'|',
@roadtext,'|',
@tumtext,'|',
@amptext,'|',
@provtext,'|',
@postcode);
end

GO
/****** Object:  View [dbo].[vMas_UserRoleAll]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vMas_UserRoleAll]
as
select a.UserID,a.Active,a.LastUpdate,c.RoleName,b.*,d.MenuName,e.ModuleName
from Mas_UserRoleAssign a
inner join Mas_UserRoleAuthor b
on a.RoleID=b.RoleID
inner join Mas_UserRole c
on a.RoleID=c.RoleID
left join Mas_Menu d
on b.MenuID=d.MenuID
left join Mas_UserRoleModule e 
on b.ModuleID=e.ModuleID 
GO
/****** Object:  View [dbo].[vMas_ModuleMenu]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vMas_ModuleMenu]
as
select distinct a.ModuleID,a.ModuleName,a.MenuID,a.MenuName,b.WebAddress 
from vMas_UserRoleAll a
left join Mas_ModuleMenu b on a.MenuID=b.MenuID

GO
/****** Object:  View [dbo].[vMas_AccCode]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vMas_AccCode]
AS
SELECT        dbo.Mas_AccCode.AccCode, dbo.Mas_AccCode.AccName, dbo.Mas_AccCode.AccNameEN, dbo.Mas_AccCode.AccTypeID, dbo.Mas_AccType.AccType, dbo.Mas_AccType.AccTypeName, dbo.Mas_AccType.AccTypeNameEN, 
                         dbo.Mas_AccType.AccSide, dbo.Mas_AccCode.AccMainCode, Mas_AccCode_1.AccName AS AccMainName, Mas_AccCode_1.AccNameEN AS AccMainNameEN
FROM            dbo.Mas_AccType INNER JOIN
                         dbo.Mas_AccCode ON dbo.Mas_AccType.AccTypeID = dbo.Mas_AccCode.AccTypeID LEFT OUTER JOIN
                         dbo.Mas_AccCode AS Mas_AccCode_1 ON dbo.Mas_AccCode.AccMainCode = Mas_AccCode_1.AccCode
GO
/****** Object:  View [dbo].[vMas_Warehouse]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/**update view v1.18**/
/*--NOTE--
เนื่องจากมีการเพิ่ม field
1. Mas_ProductType เพิ่ม AccCode (Asset/Income/Expense) 
2. Mas_Products เพิ่ม AccCode (Asset/Income/Expense) และ WarehouseCode
จึงต้องปรับ View ดัวย (โครงสร้างเหมือนเดิม)
1.ถ้าไม่ระบุ WarehouseCode ใน Mas_Product ให้ดึง Code จาก Mas_ProductType
2.ถ้าไม่ระบุ AccCode ใน Mas_Product ให้ดึง AccCode จาก Mas_ProductType
ใน Mas_ProductType ถ้าไม่ระบุ AccCode ให้ดึง AccCode จาก Mas_Warehouse ตามปกติ
 
view ที่ปรับแก้
1.vMas_Warehouse
2.vMas_ProductType
3.vMas_Product
*/
CREATE VIEW [dbo].[vMas_Warehouse]
AS
SELECT        w.WarehouseID, w.WarehouseCode, w.Name, w.Location, w.Address, w.AssetAccCode, c1.AccName AS AssetAccName, c1.AccNameEN AS AssetAccNameEN, c1.AccType AS AssetAccType, 
                         c1.AccTypeName AS AssetAccTypeName, c1.AccTypeNameEN AS AssetAccTypeNameEN, c1.AccSide AS AssetAccSide, c1.AccMainCode AS AssetAccMainCode, c1.AccMainName AS AssetAccMainName, 
                         c1.AccMainNameEN AS AssetAccMainNameEN, w.IncomeAccCode, c2.AccName AS IncomeAccName, c2.AccNameEN AS IncomeAccNameEN, c2.AccType AS IncomeAccType, c2.AccTypeName AS IncomeAccTypeName, 
                         c2.AccTypeNameEN AS IncomeAccTypeNameEN, c2.AccSide AS IncomeAccSide, c2.AccMainCode AS IncomeAccMainCode, c2.AccMainName AS IncomeAccMainName, c2.AccMainNameEN AS IncomeAccMainNameEN, 
                         w.ExpenseAccCode, c3.AccName AS ExpenseAccName, c3.AccNameEN AS ExpenseAccNameEN, c3.AccType AS ExpenseAccType, c3.AccTypeName AS ExpenseAccTypeName, c3.AccTypeNameEN AS ExpenseAccTypeNameEN, 
                         c3.AccSide AS ExpenseAccSide, c3.AccMainCode AS ExpenseAccMainCode, c3.AccMainName AS ExpenseAccMainName, c3.AccMainNameEN AS ExpenseAccMainNameEN
FROM            dbo.Mas_Warehouse AS w LEFT OUTER JOIN
                         dbo.vMas_AccCode AS c3 ON w.ExpenseAccCode = c3.AccCode LEFT OUTER JOIN
                         dbo.vMas_AccCode AS c2 ON w.IncomeAccCode = c2.AccCode LEFT OUTER JOIN
                         dbo.vMas_AccCode AS c1 ON w.AssetAccCode = c1.AccCode
GO
/****** Object:  View [dbo].[vMas_ProductType]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [dbo].[vMas_ProductType]
AS
SELECT        pt.ProductTypeID, pt.ProductTypeCode, pt.ProductTypeName, w.WarehouseID, w.WarehouseCode, w.Name AS WarehouseName, w.Location AS WarehouseLocation, w.Address AS WarehouseAddress, 
isnull(c1.AccCode,w.AssetAccCode) as AssetAccCode, 
isnull(c1.AccName,w.AssetAccName) as AssetAccName, 
isnull(c1.AccNameEN,w.AssetAccNameEN) as AssetAccNameEN, 
isnull(c1.AccType, w.AssetAccType) as AssetAccType, 
isnull(c1.AccTypeName,w.AssetAccTypeName) as AssetAccTypeName, 
isnull(c1.AccTypeNameEN ,w.AssetAccTypeNameEN) as AssetAccTypeNameEN, 
isnull(c1.AccSide,w.AssetAccSide) as AssetAccSide, 
isnull(c1.AccMainCode,w.AssetAccMainCode) as AssetAccMainCode, 
isnull(c1.AccMainName,w.AssetAccMainName) as AssetAccMainName, 
isnull(c1.AccMainNameEN,w.AssetAccMainNameEN) as AssetAccMainNameEN, 
isnull(c2.AccCode,w.IncomeAccCode) as IncomeAccCode, 
isnull(c2.AccName,w.IncomeAccName) as IncomeAccName, 
isnull(c2.AccNameEN,w.IncomeAccNameEN) as IncomeAccNameEN, 
isnull(c2.AccType, w.IncomeAccType) as IncomeAccType, 
isnull(c2.AccTypeName,w.IncomeAccTypeName) as IncomeAccTypeName, 
isnull(c2.AccTypeNameEN ,w.IncomeAccTypeNameEN) as IncomeAccTypeNameEN, 
isnull(c2.AccSide,w.IncomeAccSide) as IncomeAccSide, 
isnull(c2.AccMainCode,w.IncomeAccMainCode) as IncomeAccMainCode, 
isnull(c2.AccMainName,w.IncomeAccMainName) as IncomeAccMainName, 
isnull(c2.AccMainNameEN,w.IncomeAccMainNameEN) as IncomeAccMainNameEN, 
isnull(c3.AccCode,w.ExpenseAccCode) as ExpenseAccCode, 
isnull(c3.AccName,w.ExpenseAccName) as ExpenseAccName, 
isnull(c3.AccNameEN,w.ExpenseAccNameEN) as ExpenseAccNameEN, 
isnull(c3.AccType, w.ExpenseAccType) as ExpenseAccType, 
isnull(c3.AccTypeName,w.ExpenseAccTypeName) as ExpenseAccTypeName, 
isnull(c3.AccTypeNameEN ,w.ExpenseAccTypeNameEN) as ExpenseAccTypeNameEN, 
isnull(c3.AccSide,w.ExpenseAccSide) as ExpenseAccSide, 
isnull(c3.AccMainCode,w.ExpenseAccMainCode) as ExpenseAccMainCode, 
isnull(c3.AccMainName,w.ExpenseAccMainName) as ExpenseAccMainName, 
isnull(c3.AccMainNameEN,w.ExpenseAccMainNameEN) as ExpenseAccMainNameEN, 
pt.IsMaterial, pt.IsService, pt.RateVat, pt.RateWht, pt.VatType
FROM            dbo.vMas_Warehouse AS w INNER JOIN
                         dbo.Mas_ProductType AS pt ON w.WarehouseCode = pt.WarehouseCode
						 LEFT JOIN vMas_AccCode c1
						 on pt.AssetAccCode=c1.AccCode 
						 LEFT JOIN vMas_AccCode c2
						 on pt.IncomeAccCode=c2.AccCode 
						 LEFT JOIN vMas_AccCode c3
						 on pt.ExpenseAccCode=c3.AccCode 


GO
/****** Object:  View [dbo].[vMas_Product]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [dbo].[vMas_Product]
AS
SELECT        p.ProductID, p.ProductCode, p.ProductName, p.Brand AS ProductBrand, p.Color AS ProductColor, p.Size AS ProductSize, p.SizeUnit AS ProductSizeUnit, p.Volume AS ProductVolume, p.VolumeUnit AS ProductVolumeUnit, 
                         p.UnitStock, p.ProductTypeCode, pt.ProductTypeID, pt.ProductTypeName, 
						 pt.WarehouseID, 
isnull(w.WarehouseCode,pt.WarehouseCode) as WarehouseCode, 
isnull(w.[Name],pt.WarehouseName) as WarehouseName, 
isnull(w.[Location], pt.WarehouseLocation) as WarehouseLocation, 
isnull(w.Address,pt.WarehouseAddress) as WarehouseAddress, 
isnull(c1.AccCode,pt.AssetAccCode) as AssetAccCode, 
isnull(c1.AccName,pt.AssetAccName) as AssetAccName, 
isnull(c1.AccNameEN,pt.AssetAccNameEN) as AssetAccNameEN, 
isnull(c1.AccType, pt.AssetAccType) as AssetAccType, 
isnull(c1.AccTypeName,pt.AssetAccTypeName) as AssetAccTypeName, 
isnull(c1.AccTypeNameEN ,pt.AssetAccTypeNameEN) as AssetAccTypeNameEN, 
isnull(c1.AccSide,pt.AssetAccSide) as AssetAccSide, 
isnull(c1.AccMainCode,pt.AssetAccMainCode) as AssetAccMainCode, 
isnull(c1.AccMainName,pt.AssetAccMainName) as AssetAccMainName, 
isnull(c1.AccMainNameEN,pt.AssetAccMainNameEN) as AssetAccMainNameEN, 
isnull(c2.AccCode,pt.IncomeAccCode) as IncomeAccCode, 
isnull(c2.AccName,pt.IncomeAccName) as IncomeAccName, 
isnull(c2.AccNameEN,pt.IncomeAccNameEN) as IncomeAccNameEN, 
isnull(c2.AccType, pt.IncomeAccType) as IncomeAccType, 
isnull(c2.AccTypeName,pt.IncomeAccTypeName) as IncomeAccTypeName, 
isnull(c2.AccTypeNameEN ,pt.IncomeAccTypeNameEN) as IncomeAccTypeNameEN, 
isnull(c2.AccSide,pt.IncomeAccSide) as IncomeAccSide, 
isnull(c2.AccMainCode,pt.IncomeAccMainCode) as IncomeAccMainCode, 
isnull(c2.AccMainName,pt.IncomeAccMainName) as IncomeAccMainName, 
isnull(c2.AccMainNameEN,pt.IncomeAccMainNameEN) as IncomeAccMainNameEN, 
isnull(c3.AccCode,pt.ExpenseAccCode) as ExpenseAccCode, 
isnull(c3.AccName,pt.ExpenseAccName) as ExpenseAccName, 
isnull(c3.AccNameEN,pt.ExpenseAccNameEN) as ExpenseAccNameEN, 
isnull(c3.AccType, pt.ExpenseAccType) as ExpenseAccType, 
isnull(c3.AccTypeName,pt.ExpenseAccTypeName) as ExpenseAccTypeName, 
isnull(c3.AccTypeNameEN ,pt.ExpenseAccTypeNameEN) as ExpenseAccTypeNameEN, 
isnull(c3.AccSide,pt.ExpenseAccSide) as ExpenseAccSide, 
isnull(c3.AccMainCode,pt.ExpenseAccMainCode) as ExpenseAccMainCode, 
isnull(c3.AccMainName,pt.ExpenseAccMainName) as ExpenseAccMainName, 
isnull(c3.AccMainNameEN,pt.ExpenseAccMainNameEN) as ExpenseAccMainNameEN, 					 
                         pt.IsMaterial, pt.IsService, pt.RateVat, pt.RateWht, pt.VatType
FROM            dbo.Mas_Products AS p INNER JOIN
                         dbo.vMas_ProductType AS pt ON p.ProductTypeCode = pt.ProductTypeCode
						 LEFT JOIN vMas_AccCode c1
						 on p.AssetAccCode=c1.AccCode 
						 LEFT JOIN vMas_AccCode c2
						 on p.IncomeAccCode=c2.AccCode 
						 LEFT JOIN vMas_AccCode c3
						 on p.ExpenseAccCode=c3.AccCode 
						 LEFT JOIN vMas_Warehouse w 
						 on p.WarehouseCode=w.WarehouseCode


GO
/****** Object:  View [dbo].[vPO_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vPO_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='PO'
GO
/****** Object:  View [dbo].[vPO_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vPO_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet
,c.StatusName,d.*
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vPO_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='PO_STATUS'
) c on a.DocStatus=c.StatusCode
left join (
  select DocNo,Text1 as ContactName,Text2 as ContactTel,
  Text3 as BillingCondition,Text4 as PORemark,Text5 as ApproveBy,Date1 as ApproveDate,
  Text6 as CancelBy,Date2 as CancelDate,Text7 as CancelReason
  from Acc_AdditionData 
  where Seq=0
) d on a.AccDocNo=d.DocNo
where a.AccDocType='PO'
GO
/****** Object:  View [dbo].[vTransaction_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vTransaction_D]
AS
SELECT        a.AccDocNo AS DocNo, a.AccItemNo, a.AccSourceDocNo, a.AccSourceDocItem, a.StockTransNo, a.Qty, a.Price, a.UnitMea, a.Currency, a.ExchangeRate, a.Amount, a.SaleProductCode, a.SalesDescription, b.Text1 AS DText1, 
                         b.Date1 AS DDate1, b.Num1 AS DNum1, b.Text2 AS DText2, b.Date2 AS DDate2, b.Num2 AS DNum2, b.Text3 AS DText3, b.Date3 AS DDate3, b.Num3 AS DNum3, b.Text4 AS DText4, b.Date4 AS DDate4, b.Num4 AS DNum4, 
                         b.Text5 AS DText5, b.Date5 AS DDate5, b.Num5 AS DNum5, b.Text6 AS DText6, b.Date6 AS DDate6, b.Num6 AS DNum6, b.Text7 AS DText7, b.Date7 AS DDate7, b.Num7 AS DNum7, b.Text8 AS DText8, b.Date8 AS DDate8, 
                         b.Num8 AS DNum8, b.Text9 AS DText9, b.Date9 AS DDate9, b.Num9 AS DNum9, b.Text10 AS DText10, b.Date10 AS DDate10, b.Num10 AS DNum10, a.RateVat AS DRateVat, a.RateWht AS DRateWht, a.VatType AS DVatType,
(case when a.VatType>=1 then (case when a.VatType=1 then a.Amount else a.Amount*100/(100+a.RateVat) end) else a.Amount end) as TotalAmount
,(case when a.VatType>=1 then (case when a.VatType=1 then a.Amount*a.RateVat*0.01 else a.Amount-(a.Amount*100/(100+a.RateVat)) end) else 0 end) as VatAmount
,(case when a.VatType=1 then a.Amount*a.RateWht*0.01 else (a.Amount*100/(100+a.RateVat))*a.RateWht*0.01 end) as WhtAmount
,(case when a.RateVat>0 then (case when a.VatType=1 then a.Amount else a.Amount*100/(100+a.RateVat) end) else 0 end) as CalVatAmount
,(case when a.RateWht>0 then (case when a.VatType=1 then a.Amount else a.Amount*100/(100+a.RateVat) end) else 0 end) as CalWhtAmount
,(case when a.RateVat=0 and a.RateWht=0 then a.Amount else 0 end) as CalNonVatAmount
FROM            dbo.Acc_TransactionDT AS a LEFT OUTER JOIN
                         dbo.Acc_AdditionData AS b ON a.AccDocNo = b.DocNo AND a.AccItemNo = b.Seq
GO
/****** Object:  View [dbo].[vTransaction_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vTransaction_H]
AS
SELECT        a.AccDocNo, a.AccBatchDate, a.AccEffectiveDate, a.PartyCode, a.PartyTaxCode, a.PartyName, a.PartyAddress, a.IssueBy, a.AccDocType, 
d.TName as AccDocTypeName,
a.AccPostDate, a.FiscalYear, 0 as DocStatus, a.DocRefNo, b.Text1, b.Date1, b.Num1, 
                         b.Text2, b.Date2, b.Num2, b.Text3, b.Date3, b.Num3, b.Text4, b.Date4, b.Num4, b.Text5, b.Date5, b.Num5, b.Text6, b.Date6, b.Num6, b.Text7, b.Date7, b.Num7, b.Text8, b.Date8, b.Num8, b.Text9, b.Date9, b.Num9, b.Text10, 
                         b.Date10, b.Num10,c.TotalBaseAmount,c.TotalNonVat as TotalNonVatAmount,c.TotalTaxAmount,c.TotalAmount,c.TotalVat,c.TotalWht,c.TotalNet
FROM            dbo.Acc_TransactionHD AS a 
LEFT OUTER JOIN
(SELECT        DocNo, Seq, Text1, Date1, Num1, Text2, Date2, Num2, Text3, Date3, Num3, Text4, Date4, Num4, Text5, Date5, Num5, Text6, Date6, Num6, Text7, Date7, Num7, Text8, Date8, Num8, Text9, Date9, Num9, Text10, 
                            Date10, Num10
FROM            dbo.Acc_AdditionData
WHERE        (Seq = 0)
) AS b ON a.AccDocNo = b.DocNo
LEFT OUTER JOIN
(
select dt.docNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.CalVatAmount) as TotalBaseAmount,
sum(dt.CalWhtAmount) as TotalTaxAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.CalNonVatAmount) as TotalNonVat,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vTransaction_D d
) dt 
group by dt.DocNo
) as c on a.AccDocNo=c.DocNo 
left outer join Mas_DocConfig d on a.AccDocType=d.Category
GO
/****** Object:  View [dbo].[vTransaction_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vTransaction_All]
AS
SELECT        a.AccDocNo, a.AccBatchDate, a.AccEffectiveDate, a.PartyCode, a.PartyTaxCode, a.PartyName, a.PartyAddress, a.IssueBy, a.AccDocType, 
a.AccDocTypeName,
    a.AccPostDate, a.FiscalYear, a.DocStatus, a.DocRefNo, a.Text1, a.Date1, a.Num1, 
                         a.Text2, a.Date2, a.Num2, a.Text3, a.Date3, a.Num3, a.Text4, a.Date4, a.Num4, a.Text5, a.Date5, a.Num5, a.Text6, a.Date6, a.Num6, a.Text7, a.Date7, a.Num7, a.Text8, a.Date8, a.Num8, a.Text9, a.Date9, a.Num9, a.Text10, 
                         a.Date10, a.Num10, b.DocNo, b.AccItemNo, b.AccSourceDocNo, b.AccSourceDocItem, b.StockTransNo, b.Qty, b.Price, b.UnitMea, b.Currency, b.ExchangeRate, b.Amount, b.SaleProductCode, b.SalesDescription, b.DText1, 
                         b.DDate1, b.DNum1, b.DText2, b.DDate2, b.DNum2, b.DText3, b.DDate3, b.DNum3, b.DText4, b.DDate4, b.DNum4, b.DText5, b.DDate5, b.DNum5, b.DText6, b.DDate6, b.DNum6, b.DText7, b.DDate7, b.DNum7, b.DText8, 
                         b.DDate8, b.DNum8, b.DText9, b.DDate9, b.DNum9, b.DText10, b.DDate10, b.DNum10, b.DRateVat, b.DRateWht, b.DVatType, c.ProductID, c.ProductCode, c.ProductName, c.ProductBrand, c.ProductColor, c.ProductSize, 
                         c.ProductSizeUnit, c.ProductVolume, c.ProductVolumeUnit, c.UnitStock, c.ProductTypeCode, c.ProductTypeID, c.ProductTypeName, c.WarehouseID, c.WarehouseCode, c.WarehouseName, c.WarehouseLocation, 
                         c.WarehouseAddress, c.AssetAccCode, c.AssetAccName, c.AssetAccNameEN, c.AssetAccType, c.AssetAccTypeName, c.AssetAccTypeNameEN, c.AssetAccSide, c.AssetAccMainCode, c.AssetAccMainName, 
                         c.AssetAccMainNameEN, c.IncomeAccCode, c.IncomeAccName, c.IncomeAccNameEN, c.IncomeAccType, c.IncomeAccTypeName, c.IncomeAccTypeNameEN, c.IncomeAccSide, c.IncomeAccMainCode, c.IncomeAccMainName, 
                         c.IncomeAccMainNameEN, c.ExpenseAccCode, c.ExpenseAccName, c.ExpenseAccNameEN, c.ExpenseAccType, c.ExpenseAccTypeName, c.ExpenseAccTypeNameEN, c.ExpenseAccSide, c.ExpenseAccMainCode, 
                         c.ExpenseAccMainName, c.ExpenseAccMainNameEN, c.IsMaterial, c.IsService, b.DRateVat as RateVat, b.DRateWht as RateWht, b.DVatType as VatType,
						 b.VatAmount as DVatAmt,b.WhtAmount as DWhtAmt,b.TotalAmount+b.VatAmount-b.WhtAmount as DNetAmt,
						 a.TotalAmount,a.TotalVat,a.TotalWht,a.TotalNet,b.TotalAmount as DAmt
FROM            dbo.vTransaction_H AS a LEFT JOIN
                         dbo.vTransaction_D AS b ON a.AccDocNo = b.DocNo LEFT OUTER JOIN
                         dbo.vMas_Product AS c ON b.SaleProductCode = c.ProductCode
GO
/****** Object:  View [dbo].[vJournal_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vJournal_D]
AS
SELECT        dbo.Acc_JournalDT.EntryId, dbo.Acc_JournalDT.Seq, dbo.Acc_JournalDT.AccCode,dbo.Mas_AccCode.AccName as GLName,dbo.Mas_AccCode.AccMainCode,
dbo.Acc_JournalDT.AccName as GLDesc, dbo.Acc_JournalDT.AccDesc as AccDesc, dbo.Acc_JournalDT.Debit, dbo.Acc_JournalDT.Credit, 
                         dbo.Acc_AdditionData.Text1 AS DText1, dbo.Acc_AdditionData.Date1 AS DDate1, dbo.Acc_AdditionData.Num1 AS DNum1, dbo.Acc_AdditionData.Text2 AS DText2, dbo.Acc_AdditionData.Date2 AS DDate2, 
                         dbo.Acc_AdditionData.Num2 AS DNum2, dbo.Acc_AdditionData.Text3 AS DText3, dbo.Acc_AdditionData.Date3 AS DDate3, dbo.Acc_AdditionData.Num3 AS DNum3, dbo.Acc_AdditionData.Text4 AS DText4, 
                         dbo.Acc_AdditionData.Date4 AS DDate4, dbo.Acc_AdditionData.Num4 AS DNum4, dbo.Acc_AdditionData.Text5 AS DText5, dbo.Acc_AdditionData.Date5 AS DDate5, dbo.Acc_AdditionData.Num5 AS DNum5, 
                         dbo.Acc_AdditionData.Text6 AS DText6, dbo.Acc_AdditionData.Date6 AS DDate6, dbo.Acc_AdditionData.Num6 AS DNum6, dbo.Acc_AdditionData.Text7 AS DText7, dbo.Acc_AdditionData.Date7 AS DDate7, 
                         dbo.Acc_AdditionData.Num7 AS DNum7, dbo.Acc_AdditionData.Text8 AS DText8, dbo.Acc_AdditionData.Date8 AS DDate8, dbo.Acc_AdditionData.Num8 AS DNum8, dbo.Acc_AdditionData.Text9 AS DText9, 
                         dbo.Acc_AdditionData.Date9 AS DDate9, dbo.Acc_AdditionData.Num9 AS DNum9, dbo.Acc_AdditionData.Text10 AS DText10, dbo.Acc_AdditionData.Date10 AS DDate10, dbo.Acc_AdditionData.Num10 AS DNum10
FROM            dbo.Acc_JournalDT INNER JOIN
                         dbo.Acc_JournalHD ON dbo.Acc_JournalDT.EntryId = dbo.Acc_JournalHD.EntryId LEFT OUTER JOIN
                         dbo.Acc_AdditionData ON dbo.Acc_JournalHD.JournalNo = dbo.Acc_AdditionData.DocNo AND dbo.Acc_JournalDT.Seq = dbo.Acc_AdditionData.Seq
						 LEFT JOIN dbo.Mas_AccCode on dbo.Acc_JournalDT.AccCode=dbo.Mas_AccCode.AccCode 
GO
/****** Object:  View [dbo].[vJournal_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vJournal_H]
as
select a.*,b.*
from Acc_JournalHD a
left join (
  select * from Acc_AdditionData 
  where Seq=0
) b
on a.JournalNo=b.DocNo
GO
/****** Object:  View [dbo].[vJournal_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE view [dbo].[vJournal_All] 
as 
select a.*,b.Seq as ItemNo,b.AccCode,b.GLName as AccName,b.AccMainCode,c.AccName as AccMainCodeName,b.GLDesc as AccRemark,b.AccDesc,b.Debit,b.Credit,c.AccTypeID,
b.DText1,b.DDate1,b.DNum1,
b.DText2,b.DDate2,b.DNum2,
b.DText3,b.DDate3,b.DNum3,
b.DText4,b.DDate4,b.DNum4,
b.DText5,b.DDate5,b.DNum5,
b.DText6,b.DDate6,b.DNum6,
b.DText7,b.DDate7,b.DNum7,
b.DText8,b.DDate8,b.DNum8,
b.DText9,b.DDate9,b.DNum9,
b.DText10,b.DDate10,b.DNum10
from vJournal_H a left join vJournal_D b on a.EntryId=b.EntryId
left join Mas_AccCode c on b.AccMainCode=c.AccCode

GO
/****** Object:  View [dbo].[vPO_Payment]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE view [dbo].[vPO_Payment]
as
select a.*,
isnull(b.AccDesc,c.AccDesc) as AccDesc,
isnull(b.TotalPay,0)+isnull(c.TotalPay,0)+isnull(d.TotalPay,0) as TotalPayment,
isnull(e.PVNo,d.PVNo) as PVNo
from vPO_H a
left join
(
	SELECT DocReFNo as AccRefNo,
	max(DocNo) as AccDesc,
	sum(DNetAmt) as TotalPay
	from vTransaction_All
	where DocStatus<>99 and AccSourceDocNo='' and AccDocType ='PC'
	group by DocRefNo
) b
on a.AccdocNo=b.AccRefNo
left join
(
	SELECT d.AccDocNo as AccRefNo,
	max(e.DocNo) as AccDesc,
	sum(e.DNetAmt) as TotalPay
	from vTransaction_All d left join 
	vTransaction_All e on d.AccDocNo=e.AccSourceDocNo 
	and d.AccItemNo=e.AccSourceDocItem
	where d.DocStatus<>99
	AND d.AccSourceDocNo<>'' 
	and e.AccDocType='PC'
	group by d.AccDocNo
) c
on a.AccdocNo=c.AccRefNo
left join (
	select AccDesc,sum(Credit) as TotalPay,MAX(JournalNo) as PVNo
	from vJournal_All t
	where JournalNo like 'PV%' and Credit>0 	
	and not exists(select 1 from vTransaction_All where AccSourceDocNo=t.AccDesc and AccDocType='PC')
	group by AccDesc 
) d
on a.AccDocNo=d.AccDesc 
left join (
	select AccDesc,sum(Credit) as TotalPay,MAX(JournalNo) as PVNo
	from vJournal_All t
	where JournalNo like 'PV%' and Credit>0 		
	group by AccDesc 
) e
on isnull(b.AccDesc,c.AccDesc)=e.AccDesc 
where a.DocStatus<>99
GO
/****** Object:  View [dbo].[vAP_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vAP_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, 
						 dbo.Acc_TransactionDT.Price  as UnitPrice,
						 dbo.Acc_TransactionDT.Price*dbo.Acc_TransactionDT.ExchangeRate as Price
						 , dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType, 
                         (CASE WHEN dbo.Acc_TransactionDT.VatType >= 1 THEN (CASE WHEN dbo.Acc_TransactionDT.VatType = 1 THEN dbo.Acc_TransactionDT.Amount ELSE dbo.Acc_TransactionDT.Amount * 100 / (100 + dbo.Acc_TransactionDT.RateVat)
                          END) ELSE dbo.Acc_TransactionDT.Amount END) AS TotalAmount, 
                         (CASE WHEN dbo.Acc_TransactionDT.VatType >= 1 THEN (CASE WHEN dbo.Acc_TransactionDT.VatType = 1 THEN dbo.Acc_TransactionDT.Amount * dbo.Acc_TransactionDT.RateVat * 0.01 ELSE dbo.Acc_TransactionDT.Amount - (dbo.Acc_TransactionDT.Amount
                          * 100 / (100 + dbo.Acc_TransactionDT.RateVat)) END) ELSE 0 END) AS VatAmount, 
                         (CASE WHEN dbo.Acc_TransactionDT.VatType = 1 THEN dbo.Acc_TransactionDT.Amount * dbo.Acc_TransactionDT.RateWht * 0.01 ELSE dbo.Acc_TransactionDT.Amount * 100 / (100 + dbo.Acc_TransactionDT.RateVat) 
                         * dbo.Acc_TransactionDT.RateWht * 0.01 END) AS WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
WHERE        (dbo.Acc_TransactionHD.AccDocType ='PI')
GO
/****** Object:  View [dbo].[vAP_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vAP_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet 
,c.StatusName,d.*
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vAP_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='PI_STATUS'
) c on a.DocStatus=c.StatusCode
left join (
   select DocNo,Text6 as CancelBy,Text7 as CancelReason,Date1 as CancelDate
   from Acc_AdditionData 
   where Seq=0
) d on a.AccDocNo=d.DocNo
where a.AccDocType='PI'
GO
/****** Object:  View [dbo].[vAP_Payment]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vAP_Payment]
as
select a.*,b.AccDesc,isnull(b.TotalPay,0) as TotalPayment
from vAP_H a
left join
(
	SELECT AccSourceDocNo as AccRefNo,
	max(DocNo) as AccDesc,
	sum(DNetAmt) as TotalPay
	from vTransaction_All
	where DocStatus<>99
	AND AccSourceDocNo<>'' and AccDocType IN('PC','PV')
	group by AccSourceDocNo
) b
on a.AccdocNo=b.AccRefNo
where a.DocStatus<>99
GO
/****** Object:  View [dbo].[vAR_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vAR_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, 
						 dbo.Acc_TransactionDT.Price  as UnitPrice,
						 dbo.Acc_TransactionDT.Price*dbo.Acc_TransactionDT.ExchangeRate as Price,
						 dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='SI'
GO
/****** Object:  View [dbo].[vAR_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vAR_H]
as
select a.*,b.TotalAmount,b.TotalNonVat,
b.TotalVatBase,b.TotalVat,
b.TotalTaxBase1,b.TotalTaxBase2,b.TotalTaxBase3,b.TotalTaxBase5,b.TotalTaxBase10
,b.TotalWht,b.TotalNet 
,c.StatusName
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.TotalNonVat) as TotalNonVat,
sum(dt.TotalVatBase) as TotalVatBase,
sum(dt.VatAmount) as TotalVat,
sum(dt.TotalTaxBase1) as TotalTaxBase1,
sum(dt.TotalTaxBase2) as TotalTaxBase2,
sum(dt.TotalTaxBase3) as TotalTaxBase3,
sum(dt.TotalTaxBase5) as TotalTaxBase5,
sum(dt.TotalTaxBase10) as TotalTaxBase10,
sum(dt.WhtAmount) as TotalWht,
sum(TotalAmount+VatAmount-WhtAmount) as TotalNet 
from 
(
	select d.*,
	(case when RateWht=1 then Amount else 0 end) as TotalTaxBase1,
	(case when RateWht=2 then Amount else 0 end) as TotalTaxBase2,
	(case when RateWht=3 then Amount else 0 end) as TotalTaxBase3,
	(case when RateWht=5 then Amount else 0 end) as TotalTaxBase5,
	(case when RateWht=10 then Amount else 0 end) as TotalTaxBase10,
	(case when RateVat>0 then Amount else 0 end) as TotalVatBase,
	(case when RateVat=0 and RateWht=0 then Amount else 0 end) as TotalNonVat
	from vAR_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='SI_STATUS'
) c on a.DocStatus=c.StatusCode
where a.AccDocType='SI'
GO
/****** Object:  View [dbo].[vAR_Payment]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vAR_Payment]
as
select a.*,b.AccDesc,isnull(b.TotalPay,0) as TotalPayment
from vAR_H a
left join
(
	SELECT AccSourceDocNo as AccRefNo,
	max(DocNo) as AccDesc,
	sum(DNetAmt) as TotalPay
	from vTransaction_All
	where DocStatus<>99
	AND AccSourceDocNo<>'' and AccDocType IN('RC','RV')
	group by AccSourceDocNo
) b
on a.AccdocNo=b.AccRefNo
where a.DocStatus<>99
GO
/****** Object:  View [dbo].[vAV_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vAV_All]
as
select a.AccDocNo,a.AccBatchDate,a.PartyName,a.IssueBy,a.ProductCode,a.ProductName,a.SalesDescription,
a.DNetAmt as AmountNet,
c.AccDocNo as PaymentDocNo,c.AccItemNo as PaymentItemNo,c.DNetAmt as PaymentNet,
b.AccDocNo as LinkDocNo,b.AccItemNo as LinkItemNo,b.DNetAmt as UsedNet
from vTransaction_All a left join vTransaction_All b 
on a.AccDocNo=b.AccSourceDocNo 
and a.AccItemNo=b.AccSourceDocItem
and b.AccDocType='PC'
left join vTransaction_All c 
on a.AccDocNo=c.AccSourceDocNo 
and a.AccItemNo=c.AccSourceDocItem
and c.AccDocType='DP'
where exists(select 1 from Acc_TransactionHD where AccDocNo=a.AccDocNo and AccDocType='AV')

GO
/****** Object:  View [dbo].[vAV_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vAV_Balance]
as
select *,AmountNet-isnull(Usednet,0) as Balance
from (
select AccDocNo,AccBatchDate,IssueBy,PartyName,ProductCode,ProductName,SalesDescription,AmountNet,sum(UsedNet) as UsedNet 
from vAV_All
group by AccDocNo,AccBatchDate,IssueBy,PartyName,ProductCode,ProductName,SalesDescription,AmountNet
) t

GO
/****** Object:  View [dbo].[vAV_BalanceByDoc]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vAV_BalanceByDoc]
as
select AccDocNo,AccBatchDate,sum(AmountNet) as AmountNet,sum(UsedNet) as UsedNet,sum(Balance) as Balance 
from vAV_Balance
group by AccDocNo,AccBatchDate
GO
/****** Object:  View [dbo].[vHR_PayRoll]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE view [dbo].[vHR_PayRoll]
as
select s.StaffName,ct.contractType,
pc.SalaryPerDay,pc.SalaryPerHour,pc.SalaryPerMonth,
pc.OtPerDay,pc.OtPerHour,pc.LatePerDay,pc.LatePerHour,
e.PositionId,p.PositionName,p.LevelId,l.LevelName,
dp.DepartmentId,dp.DepartmentName,
dv.DivisionId,dv.DivisionName,dv.CompanyId,
c.*
from Acc_HRContract c 
left join Mas_HRContractType ct on c.ContractTypeId=ct.ContractTypeId
inner join Mas_HRStaff s on c.StaffId=s.StaffId
inner join Mas_HREmployment e on c.StaffId=e.StaffId
and c.ContractNo=e.ContractNo
inner join Mas_HRPayRollConfig pc on e.ContractType=pc.ContractTypeId
and e.Positionid=pc.PositionId
inner join Mas_HRPosition p on e.PositionId=p.PositionId
inner join Mas_HRLevel l on p.LevelId=l.LevelId
inner join Mas_HRDepartment dp on p.DepartmentId=dp.DepartmentId
inner join Mas_HRDivision dv on dp.DivisionId=dv.DivisionId
where c.ContractStatus=1
GO
/****** Object:  View [dbo].[vHR_CalTaxEmp]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vHR_CalTaxEmp]
as
with tbl as 
(
	select a.*,(a.SalaryPerMonth*12) as SalaryPerYear,
	(case when ((a.SalaryPerMonth*12)*isnull(cf2.DeductPersonal,0.5))>100000 then 100000 else ((a.SalaryPerMonth*12)*0.5) end) as DefaultDeduct,
	(case when isnull(d1.DeductTotal,0)>0 then 
	(case when ((a.SalaryPerMonth*12)*isnull(cf1.SocialRate,0.03))
	>isnull(d1.DeductTotal,99999) then isnull(d1.DeductTotal,99999)
	else ((a.SalaryPerMonth*12)*isnull(cf1.SocialRate,0.03)) end)
	else 0 end)
	as SocialDeduct,
	isnull(d2.TotalDeduct,0) as TotalDeduct
	from vHR_Payroll a
	left join  (
		select ConfigKey,cast(ConfigValue as float) as SocialRate from Mas_HRConfig
		where ConfigCode='RATES'
	) cf1
	on 'SocialRate'=cf1.ConfigKey
	left join  (
		select ConfigKey,cast(ConfigValue as float) as DeductPersonal from Mas_HRConfig
		where ConfigCode='RATES'
	) cf2
	on 'DeductPersonal'=cf1.ConfigKey
	left join 
	(
		select 6 as DeductSeq,StaffId,
		sum(ABS(AmountPayment)) as SocialPaid 
		from Acc_HRPayRoll 
		where AccCodeDebit<>'' 
		and AccCodeDebit=dbo.GetAccConfig('GL_CONFIG','SocialFund')
		group by StaffId
	) c 
	on a.StaffId=c.StaffId 
	left join 
	(
		select * from Acc_HRTaxDeduct 
		where DeductSeq=6
	) d1 on 
	a.StaffId=d1.StaffId 	
	left join 
	(
		select TaxYear,StaffId,SUM(DeductAmount) as TotalDeduct 
		from Acc_HRTaxDeduct 
		group by TaxYear,StaffId 
	) d2 on 
	a.StaffId=d2.StaffId 
	where a.ContractStatus=1
)
select PositionId,PositionName,StaffId,StaffName,SalaryPerMonth,SalaryPerYear,DefaultDeduct,TotalDeduct,SocialDeduct,
TotalYearly,
sum(TaxCal) as TotalTaxYear,
cast(sum(TaxCal)/12 as decimal(18,2)) as TotalTaxMonth
from 
(
select tbl.*,
(tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct)) as TotalYearly,
(case when (tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct))>=SalaryTo 
then SalaryTo-SalaryFrom 
else 
case when (tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct))>SalaryFrom then 
(tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct))-SalaryFrom else 0 end end
) as TaxBase,
(case when (tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct))>=SalaryTo 
then SalaryTo-SalaryFrom 
else 
case when (tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct))>SalaryFrom then 
(tbl.SalaryPerYear-tbl.DefaultDeduct-(tbl.TotalDeduct+tbl.SocialDeduct))-SalaryFrom else 0 end end
)*tx.TaxRate*0.01 as TaxCal
from 
tbl,(
	SELECT ConfigKey as Condition,CAST(substring(ConfigKey,1,CHARINDEX('-',ConfigKey,0)-1) as float) as SalaryFrom,
	CAST(substring(ConfigKey,CHARINDEX('-',ConfigKey,0)+1,len(ConfigKey)) as float) as SalaryTo
	,ConfigValue as TaxRate
	from Mas_HRConfig 
	where ConfigCode like 'SALARY_TAXRATE%'
) tx 
) t 
group by PositionId,PositionName,StaffId,StaffName,SalaryPerMonth,SalaryPerYear,DefaultDeduct,TotalDeduct,SocialDeduct,TotalYearly
GO
/****** Object:  View [dbo].[vHR_PayrollConfig]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vHR_PayrollConfig]
as
select ct.ContractType,p.PositionName,pc.*,pc.SalaryPerMonth*12 as SalaryYearly 
from Mas_HRPayRollConfig pc
inner join Mas_HRContractType ct on pc.ContractTypeId=ct.ContractTypeId
inner join Mas_HRPosition p on pc.PositionId=p.PositionId
GO
/****** Object:  View [dbo].[vHR_SalaryConfig]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vHR_SalaryConfig]
as
select ct.ContractType,st.SalaryType,sl.*,a.AccName
from Mas_HRSalary sl
inner join Mas_HRContractType ct
on sl.ContractTypeId=ct.ContractTypeId
inner join Mas_HRSalaryType st on sl.SalaryTypeId=st.SalaryTypeId
left join Mas_AccCode a on sl.AccCode=a.AccCode
GO
/****** Object:  View [dbo].[vHR_Salary]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE view [dbo].[vHR_Salary]
as
with tb as
(
	select b.*, a.StaffId,a.StaffName,c.PositionId,c.PositionName,
	(case when b.SalaryBase=0 and b.SalaryEnd=0 then 
	a.SalaryPerMonth *b.SalaryRate
	else 
	(case when a.SalaryPerMonth>b.SalaryBase and 
	a.SalaryPerMonth<=b.SalaryEnd 
	then a.SalaryPerMonth*b.SalaryRate
	else 
	(case when a.SalaryPerMonth>b.SalaryBase and (b.SalaryEnd+b.SalaryFix)=0 then
	a.SalaryPerMonth*b.SalaryRate
	else (case when a.SalaryPerMonth>b.SalaryBase and (b.SalaryEnd+b.SalaryFix)>0 
	then b.SalaryFix*b.SalaryRate else 0 end) end)
	end)
	end) as TotalAmount,
	d.BookCode,d.BankCode,d.BookName  
	from vHR_Payroll a
	inner join vHR_SalaryConfig b
	on a.ContracttypeId=b.ContractTypeId 		
	inner join vHR_PayrollConfig c on a.ContractTypeId=c.ContractTypeId	
	and a.PositionId=c.PositionId
	left join Mas_HRBookAccount d on
	a.ContractId=d.ContractId and a.StaffId=d.StaffId
	where a.ContractStatus=1
)
select * from (
	select t.PayrollType, t.ItemNo as Seq, t.SalaryName,t.BookCode,t.BookName,t.PositionId,t.PositionName, t.StaffId,t.StaffName,t.AccCode,t.AccName,
	(case when substring(t.AccCode,1,1) in('1','5') then ABS(TotalAmount) else 0 end) as Debit,
	(case when substring(t.AccCode,1,1) not in('1','5') then ABS(TotalAmount) else 0 end) as Credit,
	TotalAmount as TotalPayment
	from 
	tb t 
	where t.TotalAmount<>0 
	union all
	select 1 as PayrollType, 0 as Seq,'เงินเดือนและค่าจ้าง' as SalaryName,t.BookCode,t.BookName,t.PositionId,t.PositionName,t.StaffId,t.StaffName,p.AccCode,p.AccName,0 as Debit,
	sum(TotalAmount)*
	(case when b.TotalTaxYear>0 then
	(1-(cast(isnull(dbo.GetAccConfig('WHT_CONFIG','RateEmp'),0) as decimal(10,2))*0.01)) 
	else 1 end
	) as Credit,
	0 as TotalPayment
	from tb t inner join vHR_CalTaxEmp b
	on t.StaffId=b.StaffId 
	,Mas_AccCode p 
	where p.AccCode=ISNULL(dbo.GetAccConfig('GL_CONFIG','AccrueSalary'),dbo.GetAccConfig('AP_CONFIG','CashOut'))
	and ItemNo>0
	group by t.BookCode,t.BookName,t.PositionId,t.PositionName,t.StaffId,t.StaffName,p.AccCode,p.AccName,b.TotalTaxYear
	union all
	select 2 as PayrollType, max(t.ItemNo)+1 as Seq,'ภาษี หัก ณ ที่จ่าย' as SalaryName,t.BookCode,t.BookName,t.PositionId,t.PositionName,t.StaffId,t.StaffName,p.AccCode,p.AccName,0 as Debit,
	b.TotalTaxMonth as Credit,
	-1*b.TotalTaxMonth as TotalPayment
	from tb t inner join vHR_CalTaxEmp b
	on t.StaffId=b.StaffId 
	,Mas_AccCode p 
	where p.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxEmployee')
	and ItemNo>0 and b.TotalTaxYear>0
	group by t.BookCode,t.BookName,t.PositionId,t.PositionName,t.StaffId,t.StaffName,p.AccCode,p.AccName,b.TotalTaxMonth
) a

GO
/****** Object:  View [dbo].[vAV_BalanceByParty]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vAV_BalanceByParty]
as
select PartyName,sum(AmountNet) as AmountNet,sum(UsedNet) as UsedNet,sum(Balance) as Balance 
from vAV_Balance
group by PartyName

GO
/****** Object:  View [dbo].[vAV_BalanceByEmp]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vAV_BalanceByEmp]
as
select IssueBy,sum(AmountNet) as AmountNet,sum(UsedNet) as UsedNet,sum(Balance) as Balance 
from vAV_Balance
group by IssueBy

GO
/****** Object:  View [dbo].[vAV_Payment]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vAV_Payment]
as
select *,AmountNet-isnull(PaymentNet,0) as Balance
from vAV_All

GO
/****** Object:  View [dbo].[vSum_JournalByType]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vSum_JournalByType]
as
select 
SUBSTRING(JournalNo,1,4) as Header,AccCode,AccName,
count(*) as CountDoc,
sum(Debit) as TotalDebit,
sum(Credit) as TotalCredit
from vJournal_All
group by SUBSTRING(JournalNo,1,4),AccCode,AccName
GO
/****** Object:  View [dbo].[vSI_Receive]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vSI_Receive]
as
select a.AccDocNo,a.AccBatchDate,a.PartyName,a.IssueBy,a.ProductCode,a.ProductName,a.SalesDescription,
a.Amount as Amount,
a.DRateVat,
a.DVatAmt as AmountVat,
a.DRateWht,
a.DWhtAmt as AmountWhd,
a.DNetAmt as AmountNet,
b.AccDocNo as LinkDocNo,b.AccItemNo as LinkItemNo,
a.DNetAmt as ReceiveNet
from vTransaction_All a left join vTransaction_All b 
on a.AccDocNo=b.AccSourceDocNo 
and a.AccItemNo=b.AccSourceDocItem
and b.AccDocType='RC'
where exists(select 1 from Acc_TransactionHD where AccDocNo=a.AccDocNo and AccDocType='SI')

GO
/****** Object:  View [dbo].[vSI_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vSI_Balance]
as
select *,AmountNet-isnull(ReceiveNet,0) as Balance
from (
select AccDocNo,AccBatchDate,IssueBy,PartyName,ProductCode,ProductName,SalesDescription,AmountNet,sum(ReceiveNet) as ReceiveNet 
from vSI_Receive
group by AccDocNo,AccBatchDate,IssueBy,PartyName,ProductCode,ProductName,SalesDescription,AmountNet
) t
GO
/****** Object:  View [dbo].[vSI_BalanceByParty]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vSI_BalanceByParty]
as
select PartyName,sum(AmountNet) as AmountNet,sum(ReceiveNet) as UsedNet,sum(Balance) as Balance 
from vSI_Balance
group by PartyName

GO
/****** Object:  View [dbo].[vSI_BalanceByProduct]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vSI_BalanceByProduct]
as
select ProductName,sum(AmountNet) as AmountNet,sum(ReceiveNet) as UsedNet,sum(Balance) as Balance 
from vSI_Balance
group by ProductName

GO
/****** Object:  View [dbo].[vSI_BalanceBySaleDesc]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vSI_BalanceBySaleDesc]
as
select SalesDescription,sum(AmountNet) as AmountNet,sum(ReceiveNet) as UsedNet,sum(Balance) as Balance 
from vSI_Balance
group by SalesDescription

GO
/****** Object:  View [dbo].[vPC_Collect]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vPC_Collect]
as
select a.AccDocNo,a.AccBatchDate,a.PartyName,a.IssueBy,a.ProductCode,a.ProductName,a.SalesDescription,
a.AccSourceDocNo,a.AccSourceDocItem,
a.Amount as Amount,
a.DRateVat,
a.DVatAmt as AmountVat,
a.DRateWht,
a.DWhtAmt as AmountWhd,
a.DNetAmt as AmountNet,
b.AccDocNo as LinkDocNo,b.AccItemNo as LinkItemNo,
b.DNetAmt as BillNet,
a.DNetAmt-isnull(b.DNetAmt,0) as Balance,
c.AccDocNo as RcvDocNo,c.AccItemNo as RcvItemNo,
c.DNetAmt as RcvNet,
isnull(b.DNetAmt,0)-isnull(c.DNetAmt,0) as RcvBalance
from vTransaction_All a left join vTransaction_All b 
on a.AccDocNo=b.AccSourceDocNo 
and a.AccItemNo=b.AccSourceDocItem
and b.AccDocType='SI' left join vTransaction_All c 
on b.AccDocNo=c.AccSourceDocNo 
and b.AccItemNo=c.AccSourceDocItem
and c.AccDocType='RC'
where exists(select 1 from Acc_TransactionHD where AccDocNo=a.AccDocNo and AccDocType='PC')

GO
/****** Object:  View [dbo].[vPC_BalanceBySaleDesc]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vPC_BalanceBySaleDesc]
as
select SalesDescription,sum(AmountNet) as AmountNet,sum(BillNet) as UsedNet,sum(Balance) as Balance 
from vPC_Collect
group by SalesDescription

GO
/****** Object:  View [dbo].[vPC_BalanceByProduct]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vPC_BalanceByProduct]
as
select ProductName,sum(AmountNet) as AmountNet,sum(BillNet) as UsedNet,sum(Balance) as Balance 
from vPC_Collect
group by ProductName

GO
/****** Object:  View [dbo].[vPC_BalanceByParty]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vPC_BalanceByParty]
as
select PartyName,sum(AmountNet) as AmountNet,sum(BillNet) as UsedNet,sum(Balance) as Balance 
from vPC_Collect
group by PartyName

GO
/****** Object:  View [dbo].[vPC_BalanceByDoc]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vPC_BalanceByDoc]
as
select AccDocNo,AccBatchDate,IssueBy,PartyName,sum(AmountNet) as AmountNet,sum(BillNet) as UsedNet,sum(Balance) as Balance 
from vPC_Collect
group by AccDocNo,AccBatchDate,IssueBy,PartyName

GO
/****** Object:  View [dbo].[vPC_BalanceBySource]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vPC_BalanceBySource]
as
select AccSourceDocNo,sum(AmountNet) as AmountNet,sum(BillNet) as UsedNet,sum(Balance) as Balance 
from vPC_Collect
group by AccSourceDocNo

GO
/****** Object:  View [dbo].[vRC_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vRC_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='RC'
GO
/****** Object:  View [dbo].[vRC_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vRC_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet
,c.StatusName
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vRC_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='PC_STATUS'
) c on a.DocStatus=c.StatusCode
where a.AccDocType='RC'
GO
/****** Object:  View [dbo].[vPC_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vPC_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='PC'
GO
/****** Object:  View [dbo].[vPC_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE view [dbo].[vPC_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet
,c.StatusName,d.*
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vPC_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='PC_STATUS'
) c on a.DocStatus=c.StatusCode
left join (
select DocNo,Text1 as SupRcpNo,
Text2 as TransType,Text3 as BookDetail,Text4 as TransDetail,
Date1 as VoucherDate,Text5 as Voucher,Text6 as CancelBy,Date2 as CancelDate,Text7 as CancelReason
from Acc_AdditionData where Seq=0
) d on a.AccDocNo=d.DocNo
where a.AccDocType='PC'
GO
/****** Object:  View [dbo].[vPR_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vPR_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='PR'
GO
/****** Object:  View [dbo].[vPR_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vPR_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet,
c.StatusName,d.*
from (
	select dt.AccdocNo,
	sum(dt.TotalAmount) as TotalAmount,
	sum(dt.VatAmount) as TotalVat,
	sum(dt.WhtAmount) as TotalWht,
	sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
	from 
	(
		select d.*
		from vPR_D d
	) dt 
	group by dt.AccDocNo
) b right join 
(
	select AccDocNo,AccBatchDate,AccEffectiveDate,
	PartyCode,PartyTaxCode,PartYName,PartyAddress,
	IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo
	from Acc_TransactionHD
)
a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='PR_STATUS'
) c on a.DocStatus=c.StatusCode
left join (
	select DocNo,Text1 as CheckBy,Date1 as CheckDate,Num1 as CreditDays,Date2 as TargetDeliveryDate,
Text2 as PRRemark,Text3 as ApproveBy,Date3 as ApproveDAte,Text4 as CancelBy,Date4 as CancelDate,Text5 as CancelReason
from Acc_AdditionData 
where Seq=0
) d on a.AccDocNo=d.DocNo 
where a.AccDocType='PR'
GO
/****** Object:  View [dbo].[vSO_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vSO_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='SO'
GO
/****** Object:  View [dbo].[vSO_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vSO_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet 
,c.StatusName
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vSO_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='SO_STATUS'
) c on a.DocStatus=c.StatusCode
where a.AccDocType='SO'
GO
/****** Object:  View [dbo].[vSR_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vSR_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='SR'
GO
/****** Object:  View [dbo].[vSR_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vSR_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet 
,c.StatusName
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vSR_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='SR_STATUS'
) c on a.DocStatus=c.StatusCode
where a.AccDocType='SR'
GO
/****** Object:  View [dbo].[vDO_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE VIEW [dbo].[vDO_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='DO'
GO
/****** Object:  View [dbo].[vDO_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE view [dbo].[vDO_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet
,c.StatusName,d.*
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vDO_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='DO_STATUS'
) c on a.DocStatus=c.StatusCode
left join (
  select DocNo,Date1 as CancelDate,Text1 as CancelBy,Text2 as CancelReason
  from Acc_AdditionData
  where Seq=0
) d on a.AccDocNo=d.DocNo 
where a.AccDocType='DO'
GO
/****** Object:  View [dbo].[vDI_D]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE VIEW [dbo].[vDI_D]
AS
SELECT        dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.FiscalYear, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.IssueBy, 
                         dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyTaxCode, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.AccEffectiveDate, 
                         dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription, dbo.vMas_Product.ProductID, dbo.vMas_Product.ProductCode, dbo.vMas_Product.ProductName, 
                         dbo.vMas_Product.ProductBrand, dbo.vMas_Product.ProductColor, dbo.vMas_Product.ProductSize, dbo.vMas_Product.ProductSizeUnit, dbo.vMas_Product.ProductVolume, dbo.vMas_Product.ProductVolumeUnit, 
                         dbo.vMas_Product.UnitStock, dbo.vMas_Product.ProductTypeCode, dbo.vMas_Product.ProductTypeID, dbo.vMas_Product.ProductTypeName, dbo.vMas_Product.WarehouseID, dbo.vMas_Product.WarehouseCode, 
                         dbo.vMas_Product.WarehouseName, dbo.vMas_Product.WarehouseLocation, dbo.vMas_Product.WarehouseAddress, dbo.vMas_Product.AssetAccCode, dbo.vMas_Product.AssetAccName, dbo.vMas_Product.AssetAccNameEN, 
                         dbo.vMas_Product.AssetAccType, dbo.vMas_Product.AssetAccTypeName, dbo.vMas_Product.AssetAccTypeNameEN, dbo.vMas_Product.AssetAccSide, dbo.vMas_Product.AssetAccMainCode, 
                         dbo.vMas_Product.AssetAccMainName, dbo.vMas_Product.AssetAccMainNameEN, dbo.vMas_Product.IncomeAccCode, dbo.vMas_Product.IncomeAccName, dbo.vMas_Product.IncomeAccNameEN, 
                         dbo.vMas_Product.IncomeAccType, dbo.vMas_Product.IncomeAccTypeName, dbo.vMas_Product.IncomeAccTypeNameEN, dbo.vMas_Product.IncomeAccSide, dbo.vMas_Product.IncomeAccMainCode, 
                         dbo.vMas_Product.IncomeAccMainName, dbo.vMas_Product.IncomeAccMainNameEN, dbo.vMas_Product.ExpenseAccCode, dbo.vMas_Product.ExpenseAccName, dbo.vMas_Product.ExpenseAccNameEN, 
                         dbo.vMas_Product.ExpenseAccType, dbo.vMas_Product.ExpenseAccTypeName, dbo.vMas_Product.ExpenseAccTypeNameEN, dbo.vMas_Product.ExpenseAccSide, dbo.vMas_Product.ExpenseAccMainCode, 
                         dbo.vMas_Product.ExpenseAccMainName, dbo.vMas_Product.ExpenseAccMainNameEN, dbo.vMas_Product.IsMaterial, dbo.vMas_Product.IsService, dbo.Acc_TransactionDT.RateVat, dbo.Acc_TransactionDT.RateWht, 
                         dbo.Acc_TransactionDT.VatType,
(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat) end) else dbo.Acc_TransactionDT.Amount end) as TotalAmount
,(case when dbo.Acc_TransactionDT.VatType>=1 then (case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateVat*0.01 else dbo.Acc_TransactionDT.Amount-(dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)) end) else 0 end) as VatAmount
,(case when dbo.Acc_TransactionDT.VatType=1 then dbo.Acc_TransactionDT.Amount*dbo.Acc_TransactionDT.RateWht*0.01 else dbo.Acc_TransactionDT.Amount*100/(100+dbo.Acc_TransactionDT.RateVat)*dbo.Acc_TransactionDT.RateWht*0.01 end) as WhtAmount
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo INNER JOIN
                         dbo.vMas_Product ON dbo.Acc_TransactionDT.SaleProductCode = dbo.vMas_Product.ProductCode
wHERE dbo.Acc_TransactionHD.AccDocType='DI'
GO
/****** Object:  View [dbo].[vDI_H]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE view [dbo].[vDI_H]
as
select a.*,b.TotalAmount,b.TotalVat,b.TotalWht,b.TotalNet
,c.StatusName,d.*
from (
select dt.AccdocNo,
sum(dt.TotalAmount) as TotalAmount,
sum(dt.VatAmount) as TotalVat,
sum(dt.WhtAmount) as TotalWht,
sum(dt.TotalAmount+dt.VatAmount-dt.WhtAmount) as TotalNet 
from 
(
	select d.*
	from vDI_D d
) dt 
group by dt.AccDocNo
) b right join Acc_TransactionHD a on b.AccDocNo=a.AccDocNo 
left join (
	select ConfigKey as StatusCode,ConfigValue as StatusName from Mas_AccConfig where ConfigCode='DI_STATUS'
) c on a.DocStatus=c.StatusCode
left join (
  select DocNo,Date1 as CancelDate,Text1 as CancelBy,Text2 as CancelReason
  from Acc_AdditionData
  where Seq=0
) d on a.AccDocNo=d.DocNo 
where a.AccDocType='DI'
GO
/****** Object:  View [dbo].[vMas_DocConfigStandard]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vMas_DocConfigStandard]
as
select b.Category,b.TName as DocTypeName,a.* 
from Mas_DocConfigStandard a
left join Mas_DocConfig b 
on a.DocConfigId=b.DocConfigID
GO
/****** Object:  View [dbo].[vPV_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vPV_All]
AS
SELECT        dbo.Acc_JournalHD.EntryId, dbo.Acc_JournalHD.JournalNo, dbo.Acc_JournalHD.EntryDate, dbo.Acc_JournalHD.EffectiveDate, dbo.Acc_JournalHD.EntryBy, dbo.Acc_JournalHD.Description, dbo.Acc_JournalHD.TotalDebit, 
                         dbo.Acc_JournalHD.TotalCredit, dbo.Acc_JournalDT.Seq, dbo.Acc_JournalDT.AccCode, dbo.Acc_JournalDT.AccName, dbo.Acc_JournalDT.AccDesc, dbo.Acc_JournalDT.Debit, dbo.Acc_JournalDT.Credit, 
                         dbo.Acc_AdditionData.Text5 AS AdjustNo, dbo.Acc_AdditionData.Text6 AS CancelBy, dbo.Acc_AdditionData.Text7 AS CancelReason, dbo.Acc_AdditionData.Date1 AS CancelDate, dbo.Acc_AdditionData.Text8 AS TransType, 
                         dbo.Acc_AdditionData.Text9 AS TransNo, dbo.Acc_AdditionData.Text10 AS TransReceipt, dbo.Acc_AdditionData.Text3 AS TransDetail
FROM            dbo.Acc_JournalHD LEFT JOIN
                         dbo.Acc_JournalDT ON dbo.Acc_JournalHD.EntryId = dbo.Acc_JournalDT.EntryId LEFT OUTER JOIN
                         dbo.Acc_AdditionData ON dbo.Acc_JournalHD.JournalNo = dbo.Acc_AdditionData.DocNo
WHERE   SUBSTRING(dbo.Acc_JournalHD.JournalNo,1,2)  in (select distinct substring(Category,1,2) as Category from vMas_DocConfigStandard where AccBook ='PV')
GO
/****** Object:  View [dbo].[vRV_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vRV_All]
AS
SELECT        dbo.Acc_JournalHD.EntryId, dbo.Acc_JournalHD.JournalNo, dbo.Acc_JournalHD.EntryDate, dbo.Acc_JournalHD.EffectiveDate, dbo.Acc_JournalHD.EntryBy, dbo.Acc_JournalHD.Description, dbo.Acc_JournalHD.TotalDebit, 
                         dbo.Acc_JournalHD.TotalCredit, dbo.Acc_JournalDT.Seq, dbo.Acc_JournalDT.AccCode, dbo.Acc_JournalDT.AccName, dbo.Acc_JournalDT.AccDesc, dbo.Acc_JournalDT.Debit, dbo.Acc_JournalDT.Credit,
						 dbo.Acc_AdditionData.Text5 AS AdjustNo, dbo.Acc_AdditionData.Text6 AS CancelBy, dbo.Acc_AdditionData.Text7 AS CancelReason, dbo.Acc_AdditionData.Date1 AS CancelDate, dbo.Acc_AdditionData.Text8 AS TransType, 
                         dbo.Acc_AdditionData.Text9 AS TransNo, dbo.Acc_AdditionData.Text10 AS TransReceipt, dbo.Acc_AdditionData.Text3 AS TransDetail
FROM            dbo.Acc_JournalHD LEFT JOIN
                         dbo.Acc_JournalDT ON dbo.Acc_JournalHD.EntryId = dbo.Acc_JournalDT.EntryId
						 LEFT OUTER JOIN
                         dbo.Acc_AdditionData ON dbo.Acc_JournalHD.JournalNo = dbo.Acc_AdditionData.DocNo
WHERE   SUBSTRING(dbo.Acc_JournalHD.JournalNo,1,2)  in (select distinct substring(Category,1,2) as Category from vMas_DocConfigStandard where AccBook ='RV')
GO
/****** Object:  View [dbo].[vMas_AccountSheet]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vMas_AccountSheet]
as
select Year(EntryDate) as FiscalYear,
AccCode,AccName
from Acc_JournalHD,Mas_AccCode  
group by Year(EntryDate),AccCode,AccName
GO
/****** Object:  View [dbo].[vTrial_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE view [dbo].[vTrial_Balance] 
as 
select 
Period,AccMainCode,AccMainName,AccCode,AccName,
case when Dr>Cr then Dr-Cr else 0 end as Dr,
case when Dr<Cr then Cr-Dr else 0 end as Cr
from (
select year(a.EntryDate) as Period,c.AccCode,c.AccName,c.AccMainCode,d.AccName as AccMainName,
sum(b.Debit) as Dr,sum(b.Credit) as Cr 
from Acc_JournalHD a inner join Acc_JournalDT b on a.EntryId=b.EntryId
left join Mas_AccCode c on b.AccCode=c.AccCode
left join Mas_AccCode d on c.AccMainCode=d.AccCode
group by year(a.EntryDate),c.AccCode,c.AccName,c.AccMainCode,d.AccName
) t
GO
/****** Object:  View [dbo].[vSum_BalanceMonthly]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vSum_BalanceMonthly]
as 
select s.FiscalYear as Period,s.AccCode,s.AccName,
isnull((select sum(Dr) from vTrial_Balance where AccCode=s.AccCode and Period<s.FisCalYear),0) as BalDr,
isnull((select sum(Cr) from vTrial_Balance where AccCode=s.AccCode and Period<s.FisCalYear),0) as BalCr,
isnull(t.Dr_Jan,0) as Dr_Jan,isnull(t.Cr_Jan,0) as Cr_Jan,
isnull(t.Dr_Feb,0) as Dr_Feb,isnull(t.Cr_Feb,0) as Cr_Feb,
isnull(t.Dr_Mar,0) as Dr_Mar,isnull(t.Cr_Mar,0) as Cr_Mar,
isnull(t.Dr_Apr,0) as Dr_Apr,isnull(t.Cr_Apr,0) as Cr_Apr,
isnull(t.Dr_May,0) as Dr_May,isnull(t.Cr_May,0) as Cr_May,
isnull(t.Dr_Jun,0) as Dr_Jun,isnull(t.Cr_Jun,0) as Cr_Jun,
isnull(t.Dr_Jul,0) as Dr_Jul,isnull(t.Cr_Jul,0) as Cr_Jul,
isnull(t.Dr_Aug,0) as Dr_Aug,isnull(t.Cr_Aug,0) as Cr_Aug,
isnull(t.Dr_Sep,0) as Dr_Sep,isnull(t.Cr_Sep,0) as Cr_Sep,
isnull(t.Dr_Oct,0) as Dr_Oct,isnull(t.Cr_Oct,0) as Cr_Oct,
isnull(t.Dr_Nov,0) as Dr_Nov,isnull(t.Cr_Nov,0) as Cr_Nov,
isnull(t.Dr_Dec,0) as Dr_Dec,isnull(t.Cr_Dec,0) as Cr_Dec,
isnull(t.TotalDr,0) as TotalDr,isnull(t.TotalCr,0) as TotalCr
from vMas_AccountSheet s
left join
(
	select year(a.EntryDate) as Period,c.AccCode,c.AccName,
	sum(case when Month(a.EntryDate)=1 then b.Debit else 0 end) as Dr_Jan,sum(case when Month(a.EntryDate)=1 then b.Credit else 0 end) as Cr_Jan,
	sum(case when Month(a.EntryDate)=2 then b.Debit else 0 end) as Dr_Feb,sum(case when Month(a.EntryDate)=2 then b.Credit else 0 end) as Cr_Feb,
	sum(case when Month(a.EntryDate)=3 then b.Debit else 0 end) as Dr_Mar,sum(case when Month(a.EntryDate)=3 then b.Credit else 0 end) as Cr_Mar,
	sum(case when Month(a.EntryDate)=4 then b.Debit else 0 end) as Dr_Apr,sum(case when Month(a.EntryDate)=4 then b.Credit else 0 end) as Cr_Apr,
	sum(case when Month(a.EntryDate)=5 then b.Debit else 0 end) as Dr_May,sum(case when Month(a.EntryDate)=5 then b.Credit else 0 end) as Cr_May,
	sum(case when Month(a.EntryDate)=6 then b.Debit else 0 end) as Dr_Jun,sum(case when Month(a.EntryDate)=6 then b.Credit else 0 end) as Cr_Jun,
	sum(case when Month(a.EntryDate)=7 then b.Debit else 0 end) as Dr_Jul,sum(case when Month(a.EntryDate)=7 then b.Credit else 0 end) as Cr_Jul,
	sum(case when Month(a.EntryDate)=8 then b.Debit else 0 end) as Dr_Aug,sum(case when Month(a.EntryDate)=8 then b.Credit else 0 end) as Cr_Aug,
	sum(case when Month(a.EntryDate)=9 then b.Debit else 0 end) as Dr_Sep,sum(case when Month(a.EntryDate)=9 then b.Credit else 0 end) as Cr_Sep,
	sum(case when Month(a.EntryDate)=10 then b.Debit else 0 end) as Dr_Oct,sum(case when Month(a.EntryDate)=10 then b.Credit else 0 end) as Cr_Oct,
	sum(case when Month(a.EntryDate)=11 then b.Debit else 0 end) as Dr_Nov,sum(case when Month(a.EntryDate)=11 then b.Credit else 0 end) as Cr_Nov,
	sum(case when Month(a.EntryDate)=12 then b.Debit else 0 end) as Dr_Dec,sum(case when Month(a.EntryDate)=12 then b.Credit else 0 end) as Cr_Dec,
	sum(b.Debit) as TotalDr,sum(b.Credit) as TotalCr 
	from Acc_JournalHD a inner join Acc_JournalDT b on a.EntryId=b.EntryId
	left join Mas_AccCode c on b.AccCode=c.AccCode
	left join Mas_AccCode d on c.AccMainCode=d.AccCode
	group by year(a.EntryDate),c.AccCode,c.AccName
) t on
s.FiscalYear=t.Period and s.AccCode=t.AccCode 
GO
/****** Object:  View [dbo].[vSum_BalanceMonthlyCalculate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vSum_BalanceMonthlyCalculate]
as 
select t.Period,t.AccCode,t.AccName,
isnull((case when t.BalDr>=t.BalCr then t.BalDr-t.BalCr else 0 END),0) as BalDr,
isnull((case when t.BalDr<t.BalCr then t.BalCr-t.BalDr else 0 END),0) as BalCr,
isnull((case when t.Dr_Jan>=t.Cr_Jan then t.Dr_Jan-t.Cr_Jan else 0 END),0) as Dr_Jan,
isnull((case when t.Dr_Jan<t.Cr_Jan then t.Cr_Jan-t.Dr_Jan else 0 END),0) as Cr_Jan,
isnull((case when t.Dr_Feb>=t.Cr_Feb then t.Dr_Feb-t.Cr_Feb else 0 END),0) as Dr_Feb,
isnull((case when t.Dr_Feb<t.Cr_Feb then t.Cr_Feb-t.Dr_Feb else 0 END),0) as Cr_Feb,
isnull((case when t.Dr_Mar>=t.Cr_Mar then t.Dr_Mar-t.Cr_Mar else 0 END),0) as Dr_Mar,
isnull((case when t.Dr_Mar<t.Cr_Mar then t.Cr_Mar-t.Dr_Mar else 0 END),0) as Cr_Mar,
isnull((case when t.Dr_Apr>=t.Cr_Apr then t.Dr_Apr-t.Cr_Apr else 0 END),0) as Dr_Apr,
isnull((case when t.Dr_Apr<t.Cr_Apr then t.Cr_Apr-t.Dr_Apr else 0 END),0) as Cr_Apr,
isnull((case when t.Dr_May>=t.Cr_May then t.Dr_May-t.Cr_May else 0 END),0) as Dr_May,
isnull((case when t.Dr_May<t.Cr_May then t.Cr_May-t.Dr_May else 0 END),0) as Cr_May,
isnull((case when t.Dr_Jun>=t.Cr_Jun then t.Dr_Jun-t.Cr_Jun else 0 END),0) as Dr_Jun,
isnull((case when t.Dr_Jun<t.Cr_Jun then t.Cr_Jun-t.Dr_Jun else 0 END),0) as Cr_Jun,
isnull((case when t.Dr_Jul>=t.Cr_Jul then t.Dr_Jul-t.Cr_Jul else 0 END),0) as Dr_Jul,
isnull((case when t.Dr_Jul<t.Cr_Jul then t.Cr_Jul-t.Dr_Jul else 0 END),0) as Cr_Jul,
isnull((case when t.Dr_Aug>=t.Cr_Aug then t.Dr_Aug-t.Cr_Aug else 0 END),0) as Dr_Aug,
isnull((case when t.Dr_Aug<t.Cr_Aug then t.Cr_Aug-t.Dr_Aug else 0 END),0) as Cr_Aug,
isnull((case when t.Dr_Sep>=t.Cr_Sep then t.Dr_Sep-t.Cr_Sep else 0 END),0) as Dr_Sep,
isnull((case when t.Dr_Sep<t.Cr_Sep then t.Cr_Sep-t.Dr_Sep else 0 END),0) as Cr_Sep,
isnull((case when t.Dr_Oct>=t.Cr_Oct then t.Dr_Oct-t.Cr_Oct else 0 END),0) as Dr_Oct,
isnull((case when t.Dr_Oct<t.Cr_Oct then t.Cr_Oct-t.Dr_Oct else 0 END),0) as Cr_Oct,
isnull((case when t.Dr_Nov>=t.Cr_Nov then t.Dr_Nov-t.Cr_Nov else 0 END),0) as Dr_Nov,
isnull((case when t.Dr_Nov<t.Cr_Nov then t.Cr_Nov-t.Dr_Nov else 0 END),0) as Cr_Nov,
isnull((case when t.Dr_Dec>=t.Cr_Dec then t.Dr_Dec-t.Cr_Dec else 0 END),0) as Dr_Dec,
isnull((case when t.Dr_Dec<t.Cr_Dec then t.Cr_Dec-t.Dr_Dec else 0 END),0) as Cr_Dec,
isnull((case when t.TotalDr>=t.TotalCr then t.TotalDr-t.TotalCr else 0 END),0) as TotalDr,
isnull((case when t.totalDr<t.TotalCr then t.TotalCr-t.TotalDr else 0 END),0) as TotalCr
from 
vSum_BalanceMonthly t
GO
/****** Object:  View [dbo].[vSum_BalanceMonthlyAccumulate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vSum_BalanceMonthlyAccumulate]
as 
select Period,AccCode,AccName,
BalDr,BalCr,
(case when Dr_Jan>=Cr_Jan then Dr_Jan-Cr_Jan else 0 end) as Dr_Jan,
(case when Dr_Jan<Cr_Jan then Cr_Jan-Dr_Jan else 0 end) as Cr_Jan,
(case when Dr_Feb>=Cr_Feb then Dr_Feb-Cr_Feb else 0 end) as Dr_Feb,
(case when Dr_Feb<Cr_Feb then Cr_Feb-Dr_Feb else 0 end) as Cr_Feb,
(case when Dr_Mar>=Cr_Mar then Dr_Mar-Cr_Mar else 0 end) as Dr_Mar,
(case when Dr_Mar<Cr_Mar then Cr_Mar-Dr_Mar else 0 end) as Cr_Mar,
(case when Dr_Apr>=Cr_Apr then Dr_Apr-Cr_Apr else 0 end) as Dr_Apr,
(case when Dr_Apr<Cr_Apr then Cr_Apr-Dr_Apr else 0 end) as Cr_Apr,
(case when Dr_May>=Cr_May then Dr_May-Cr_May else 0 end) as Dr_May,
(case when Dr_May<Cr_May then Cr_May-Dr_May else 0 end) as Cr_May,
(case when Dr_Jun>=Cr_Jun then Dr_Jun-Cr_Jun else 0 end) as Dr_Jun,
(case when Dr_Jun<Cr_Jun then Cr_Jun-Dr_Jun else 0 end) as Cr_Jun,
(case when Dr_Jul>=Cr_Jul then Dr_Jul-Cr_Jul else 0 end) as Dr_Jul,
(case when Dr_Jul<Cr_Jul then Cr_Jul-Dr_Jul else 0 end) as Cr_Jul,
(case when Dr_Aug>=Cr_Aug then Dr_Aug-Cr_Aug else 0 end) as Dr_Aug,
(case when Dr_Aug<Cr_Aug then Cr_Aug-Dr_Aug else 0 end) as Cr_Aug,
(case when Dr_Sep>=Cr_Sep then Dr_Sep-Cr_Sep else 0 end) as Dr_Sep,
(case when Dr_Sep<Cr_Sep then Cr_Sep-Dr_Sep else 0 end) as Cr_Sep,
(case when Dr_Oct>=Cr_Oct then Dr_Oct-Cr_Oct else 0 end) as Dr_Oct,
(case when Dr_Oct<Cr_Oct then Cr_Oct-Dr_Oct else 0 end) as Cr_Oct,
(case when Dr_Nov>=Cr_Nov then Dr_Nov-Cr_Nov else 0 end) as Dr_Nov,
(case when Dr_Nov<Cr_Nov then Cr_Nov-Dr_Nov else 0 end) as Cr_Nov,
(case when Dr_Dec>=Cr_Dec then Dr_Dec-Cr_Dec else 0 end) as Dr_Dec,
(case when Dr_Dec<Cr_Dec then Cr_Dec-Dr_Dec else 0 end) as Cr_Dec
from (
	select 
	Period,AccCode,AccName,
	BalDr,BalCr,
	BalDr+Dr_Jan as Dr_Jan,
	BalDr+Dr_Jan+Dr_Feb as Dr_Feb,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar as Dr_Mar,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr as Dr_Apr,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May as Dr_May,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun as Dr_Jun,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul as Dr_Jul,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug as Dr_Aug,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep as Dr_Sep,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct as Dr_Oct,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct+Dr_Nov as Dr_Nov,
	BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct+Dr_Nov+Dr_Dec as Dr_Dec,
	BalCr+Cr_Jan as Cr_Jan,
	BalCr+Cr_Jan+Cr_Feb as Cr_Feb,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar as Cr_Mar,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr as Cr_Apr,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May as Cr_May,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun as Cr_Jun,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul as Cr_Jul,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug as Cr_Aug,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep as Cr_Sep,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct as Cr_Oct,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct+Cr_Nov as Cr_Nov,
	BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct+Cr_Nov+Cr_Dec as Cr_Dec
	from vSum_BalanceMonthlyCalculate	
) t
GO
/****** Object:  View [dbo].[vSum_BalanceMonthlyCompare]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vSum_BalanceMonthlyCompare]
as
select 
Period,AccCode,AccName,
BalDr,BalCr,Dr1,Cr1,Dr_Jan,Cr_Jan,
Dr2,Cr2,Dr_Feb,Cr_Feb,
Dr3,Cr3,Dr_Mar,Cr_Mar,
Dr4,Cr4,Dr_Apr,Cr_Apr,
Dr5,Cr5,Dr_May,Cr_May,
Dr6,Cr6,Dr_Jun,Cr_Jun,
Dr7,Cr7,Dr_Jul,Cr_Jul,
Dr8,Cr8,Dr_Aug,Cr_Aug,
Dr9,Cr9,Dr_Sep,Cr_Sep,
Dr10,Cr10,Dr_Oct,Cr_Oct,
Dr11,Cr11,Dr_Nov,Cr_Nov,
Dr12,Cr12,Dr_Dec,Cr_Dec
from (
	select a.*,
	b.Dr_Jan as Dr1, 
	b.Cr_Jan as Cr1, 
	b.Dr_Feb as Dr2, 
	b.Cr_Feb as Cr2, 
	b.Dr_Mar as Dr3, 
	b.Cr_Mar as Cr3, 
	b.Dr_Apr as Dr4, 
	b.Cr_Apr as Cr4, 
	b.Dr_May as Dr5, 
	b.Cr_May as Cr5, 
	b.Dr_Jun as Dr6, 
	b.Cr_Jun as Cr6, 
	b.Dr_Jul as Dr7, 
	b.Cr_Jul as Cr7, 
	b.Dr_Aug as Dr8, 
	b.Cr_Aug as Cr8, 
	b.Dr_Sep as Dr9, 
	b.Cr_Sep as Cr9, 
	b.Dr_Oct as Dr10, 
	b.Cr_Oct as Cr10, 
	b.Dr_Nov as Dr11, 
	b.Cr_Nov as Cr11, 
	b.Dr_Dec as Dr12, 
	b.Cr_Dec as Cr12
	from vSum_BalanceMonthlyAccumulate a
	inner join vSum_BalanceMonthlyCalculate b
	on a.Period=b.Period and a.AccCode=b.AccCode
) t
GO
/****** Object:  View [dbo].[vSO_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vSO_All]
AS
SELECT        dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccEffectiveDate, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.PartyTaxCode, 
                         dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.IssueBy, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.FiscalYear, 
                         dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'SO')
GO
/****** Object:  View [dbo].[vSR_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vSR_All]
AS
SELECT        dbo.Acc_TransactionHD.*, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, 
                         dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, 
                         dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'SR')
GO
/****** Object:  View [dbo].[vSR_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vSR_Balance]
as
select a.*,b.IssQty ,a.Qty-isnull(b.IssQty,0) as Balance
from
vSR_All a left join
(
select AccSourceDocNo as SoNo,AccSourceDocItem as SoItemNo
,sum(Qty) as IssQty
from vSO_All
group by AccSourceDocNo,AccSourceDocItem
) b
on a.AccDocNo=b.SoNo and a.AccItemNo=b.SoItemNo
GO
/****** Object:  View [dbo].[vCalculate_Depre_Straight]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE view [dbo].[vCalculate_Depre_Straight]
as
select *,
DepreYearly-DepreYearlyMax as DepreAddBack,
cast((DepreYearly*TotalYears)/DaysTotal as decimal(10,4)) as DeprePerDay,
cast((DepreYearlyMax*TotalYears)/DaysTotal as decimal(10,4)) as DepreMaxPerDay,
cast((DepreYearly*TotalYears)/DaysTotal as decimal(10,4))-
cast((DepreYearlyMax*TotalYears)/DaysTotal as decimal(10,4)) as DepreAddBackPerDay,
round(DayFirstYear*	cast((DepreYearly*TotalYears)/DaysTotal as decimal(10,4)),1) as DepreFirstYear,
round(cast((DepreYearly*TotalYears)/DaysTotal as decimal(10,4))*DaysFullYear,1) as DepreFullYear,
round(DayLastYear	*cast((DepreYearly*TotalYears)/DaysTotal as decimal(10,4)),1) as DepreLastYear
from (
	select a.AccDocNo,d.StockTransNo,d.AccDocNo as DeliveryNo,a.AccBatchDate,a.ProductCode,a.ProductName,a.ProductTypecode,a.ProductTypeName,a.WarehouseCode,a.WarehouseName,
	a.AccEffectiveDate,a.AssetAccCode,a.AssetAccName,isnull(b.TotalYears,5) as TotalYears,
	DATEADD(year,isnull(b.TotalYears,5),a.AccEffectiveDate) as ExpirationDate,
	DATEDIFF(day,a.AccEffectiveDate,DATEADD(year,isnull(b.TotalYears,5),a.AccEffectiveDate)) as DaysTotal,
	DATEDIFF(day,a.AccEffectiveDate,DATEFROMPARTS(YEAR(a.AccEffectiveDate)+1,1,1)) as DayFirstYear,
	(CASE WHEN DAY(EOMONTH(DATEFROMPARTS(year(a.AccEffectiveDate), 2, 1))) = 29 THEN 366 ELSE 365 END) as DaysFirstYear,	
	DATEDIFF(day,DATEFROMPARTS(YEAR(a.AccEffectiveDate)+1,1,1),DATEFROMPARTS(YEAR(a.AccEffectiveDate)+isnull(b.TotalYears,5),1,1)) as DaysFullYear,
	DATEDIFF(day,DATEFROMPARTS(YEAR(DATEADD(year,isnull(b.TotalYears,5),a.AccEffectiveDate)),1,1),DATEADD(year,isnull(b.TotalYears,5),a.AccEffectiveDate)) as DayLastYear,
	(CASE WHEN DAY(EOMONTH(DATEFROMPARTS(year(DATEADD(year,isnull(b.TotalYears,5),a.AccEffectiveDate)), 2, 1))) = 29 THEN 366 ELSE 365 END) as DaysLastYear,	
	a.Amount as BuyPrice,isnull(b.ScrapValue,0) as ScrapPrice,
	(case when b.MaximumValue>0 and b.MaximumValue<a.Amount then b.MaximumValue else a.Amount end) as BaseDepre,
	cast((((case when b.MaximumValue>0 and b.MaximumValue<a.Amount then b.MaximumValue else a.Amount end)-isnull(b.ScrapValue,0))/isnull(b.TotalYears,5)) as decimal(10,4)) as DepreYearlyMax,
	cast(((a.Amount-isnull(b.ScrapValue,0))/isnull(b.TotalYears,5)) as decimal(10,4)) as DepreYearly
	from vTransaction_All a left join
	(
		select p.ProductTypeCode,
		cast (isnull(dbo.GetAccConfig('DEPRE_RATE',p.ProductTypeCode),5) as decimal(10,2)) as TotalYears,
		cast(isnull(dbo.GetAccConfig('DEPRE_BASECAP',p.ProductTypeCode),0) as decimal(10,2)) as MaximumValue,
		cast(isnull(dbo.GetAccConfig('DEPRE_SCRAPVALUE',p.ProductTypeCode),1) as decimal(10,2)) as ScrapValue
		from vMas_ProductType p
	) b on a.ProductTypeCode=b.ProductTypeCode and TotalYears>0
	inner join 
	(
		select b.*,c.AccSourceDocNo,c.AccSourceDocItem,c.AccDocNo,c.StockTransNo
		from Acc_StockTransaction b
		inner join vTransaction_All c
		on b.TransID=c.StockTransNo 
		where b.TransType='IN'
	) d on a.StockTransNo=d.StockTransNo
	where IsService=0 and isMaterial=0 and b.TotalYears>0
) t 
GO
/****** Object:  View [dbo].[vCalculate_Depre_Double]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vCalculate_Depre_Double]
as
select 
a.*,
isnull(so.QtyOut,0) as SoldQty,isnull(so.AmountOut ,0) as SoldAmount,
a.TransQty-isnull(so.QtyOut,0) as BalQty,
(a.TransQty*a.TransPrice*a.TransRate)-isnull(so.AmountOut ,0) as BalAmount,
c.TotalYears,c.MaximumValue,(a.TransQty*c.ScrapValue) as ScrapAmount,
(((a.TransQty*a.TransPrice*a.TransRate)-isnull(so.AmountOut ,0))/c.TotalYears)*2 as DepreDoubleAmt
from 
Acc_StockTransaction a
inner join vTransaction_All di
on a.TransID =di.StockTransNo
inner join vTransaction_All pc
on di.AccSourceDocNo=pc.AccSourceDocNo
and di.AccSourceDocItem=pc.AccSourceDocItem
left join (
	select di.AccDocNo,di.AccItemNo,sum(b.TransQty) as QtyOut,
	sum(do.Amount) as AmountOut
	from Acc_StockTransaction b
	inner join vTransaction_All do
	on b.TransID=do.StockTransNo
	inner join vTransaction_All di
	on do.AccSourceDocNo=di.AccDocNo
	and do.AccItemNo=di.AccItemNo
	where do.AccDocType='DO'
	and di.AccDocType='DI'
	group by di.AccDocNo,di.AccItemNo
) so
on di.AccDocNo=so.AccDocNo and di.AccItemNo=so.AccItemNo
left join
(
	select p.ProductTypeCode,
	cast (isnull(dbo.GetAccConfig('DEPRE_RATE',p.ProductTypeCode),5) as decimal(10,2)) as TotalYears,
	cast(isnull(dbo.GetAccConfig('DEPRE_BASECAP',p.ProductTypeCode),0) as decimal(10,2)) as MaximumValue,
	cast(isnull(dbo.GetAccConfig('DEPRE_SCRAPVALUE',p.ProductTypeCode),1) as decimal(10,2)) as ScrapValue
	from vMas_ProductType p
) c on di.ProductTypeCode=c.ProductTypeCode
where pc.AccDocType='PC' and c.TotalYears>0
and di.AccDocType='DI'

GO
/****** Object:  View [dbo].[vPO_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vPO_All]
AS
SELECT        dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccEffectiveDate, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.PartyTaxCode, 
                         dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.IssueBy, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.FiscalYear, 
                         dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'PO')
GO
/****** Object:  View [dbo].[vPR_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vPR_All]
AS
SELECT        dbo.Acc_TransactionHD.*, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, 
                         dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, 
                         dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'PR')
GO
/****** Object:  View [dbo].[vPR_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vPR_Balance]
as
select a.*,b.IssQty ,a.Qty-isnull(b.IssQty,0) as Balance
from
vPR_All a left join
(
select AccSourceDocNo as PoNo,AccSourceDocItem as PoItemNo
,sum(Qty) as IssQty
from vPO_All
where DocStatus<>99
group by AccSourceDocNo,AccSourceDocItem
) b
on a.AccDocNo=b.PoNo and a.AccItemNo=b.PoItemNo
where a.AccEffectiveDate<=GETDATE() and a.DocStatus<99
GO
/****** Object:  View [dbo].[vSum_JournalByPrefix]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vSum_JournalByPrefix]
as
select 
SUBSTRING(JournalNo,1,3) as Header,
AccCode,AccName,sum(Debit) as Dr,sum(Credit) as Cr
from vJournal_All 
group by SUBSTRING(JournalNo,1,3),AccCode,AccName
GO
/****** Object:  View [dbo].[vStock_Onhand]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vStock_Onhand]
AS
SELECT        a.WarehouseCode, a.StockProductCode, b.UnitStock, b.ProductName, b.ProductColor, b.ProductBrand, a.AssetAccCode, c.AccName as AssetAccName, b.AssetAccMainCode, b.AssetAccMainName, SUM(a.TransQty) AS SumQty, 
                         SUM(a.TransQty * a.TransPrice * a.TransRate) AS SumAmount, 
						 CASE WHEN SUM(a.TransQty) > 0 THEN SUM(a.TransQty * a.TransPrice * a.TransRate) / SUM(a.TransQty) ELSE 0 END AS AvgPrice, 
                         SUM(CASE WHEN a.TransQty>0 THEN a.TransQty ELSE 0 END) AS QtyIN, 
						 SUM(CASE WHEN a.TransQty<0 THEN Abs(a.TransQty) ELSE 0 END) AS QtyOUT,
						 MAX(CASE WHEN a.TransQty>0 THEN a.TransPrice*a.TransRate ELSE 0 END) AS MaxPriceIN, 
						 MAX(CASE WHEN a.TransQty<0 THEN a.TransPrice*a.TransRate ELSE 0 END) AS MaxPriceOUT
FROM            dbo.Acc_StockTransaction AS a INNER JOIN
                         dbo.vMas_Product AS b ON a.StockProductCode = b.ProductCode INNER JOIN
                         dbo.vMas_AccCode AS c ON a.AssetAccCode = c.AccCode 
WHERE a.TransQty<>0
GROUP BY a.WarehouseCode, a.StockProductCode, b.UnitStock, b.ProductName, b.ProductColor, b.ProductBrand, a.AssetAccCode, c.AccName, b.AssetAccMainCode, b.AssetAccMainName
GO
/****** Object:  View [dbo].[vStock_Card]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE VIEW [dbo].[vStock_Card]
as
SELECT        a.TransNum as TransNo,a.TransID, d.AccDocNo, d.AccBatchDate, d.AccEffectiveDate, d.PartyCode, d.PartyTaxCode, d.PartyName, d.PartyAddress, 
d.IssueBy, d.AccDocType, d.AccPostDate, d.FiscalYear, d.DocStatus, a.WarehouseCode, e.[Name] as WarehouseName,
						 a.StockProductCode, b.UnitStock, b.ProductName, b.ProductColor, b.ProductBrand, a.TransQty,round( a.TransPrice,4) as TransPrice, a.TransCurrency, a.TransRate, 
						 a.TransQty * a.TransPrice * a.TransRate AS TransAmount, 						 
                         CASE WHEN a.TransType IN ('IN', 'TI') THEN a.TransQty ELSE 0 END AS QtyIN, 
						 CASE WHEN a.TransType IN ('OUT', 'TO') THEN Abs(a.TransQty) ELSE 0 END AS QtyOUT, 
						                          CASE WHEN a.TransType IN ('IN', 'TI') THEN a.TransQty * a.TransPrice * a.TransRate ELSE 0 END AS AmountIN, 
						 CASE WHEN a.TransType IN ('OUT', 'TO') THEN Abs(a.TransQty * a.TransPrice * a.TransRate) ELSE 0 END AS AmountOUT, 
						 c.AccSourceDocNo, c.AccSourceDocItem, 
                         c.SaleProductCode, c.SalesDescription, a.AssetAccCode, f.AccName as AssetAccName, b.AssetAccMainCode, b.AssetAccMainName
FROM            dbo.Acc_StockTransaction AS a INNER JOIN
                         dbo.vMas_Product AS b ON a.StockProductCode = b.ProductCode INNER JOIN
                         dbo.vTransaction_D AS c ON a.TransID = c.StockTransNo INNER JOIN
                         dbo.vTransaction_H AS d ON c.DocNo = d.AccDocNo INNER JOIN
                         dbo.vMas_Warehouse AS e ON a.WarehouseCode = e.WarehouseCode
						 inner join dbo.vMas_AccCode f on a.AssetAccCode=f.AccCode 
where d.DocStatus<>99

GO
/****** Object:  View [dbo].[vTrialBalance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vTrialBalance] 
as 
select 
Period,AccMonth,AccMainCode,AccMainName,AccCode,AccName,
case when Dr>Cr then Dr-Cr else 0 end as Dr,
case when Dr<Cr then Cr-Dr else 0 end as Cr
from (
select year(a.EntryDate) as Period,Month(a.EntryDate) as AccMonth,c.AccCode,c.AccName,c.AccMainCode,d.AccName as AccMainName,
sum(b.Debit) as Dr,sum(b.Credit) as Cr 
from Acc_JournalHD a inner join Acc_JournalDT b on a.EntryId=b.EntryId
left join Mas_AccCode c on b.AccCode=c.AccCode
left join Mas_AccCode d on c.AccMainCode=d.AccCode
where a.JournalNo not like 'BL%'
group by year(a.EntryDate),Month(a.EntryDate),c.AccCode,c.AccName,c.AccMainCode,d.AccName
) t
GO
/****** Object:  View [dbo].[vProfitLoss]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vProfitLoss]
as
select h.*,d.AccMainCode,d.AccMainName 
from (
	select Period,AccMonth,AccCode,AccName,Dr as Debit,Cr as Credit 
	from vTrialBalance where (Dr+cr)>0 and AccMainCode>'400000'
	union all
	select a.Period,a.AccMonth,b.AccCode,b.AccName,a.Debit,a.Credit
	from (
		select Period,AccMonth,0 as Debit,sum(Dr)-Sum(Cr) as Credit
		from vTrialBalance where AccMainCode>='400000'
		group by Period,AccMonth
		having sum(Dr)>Sum(Cr) 
		union all
		select Period,AccMonth,sum(Cr)-Sum(Dr) as Debit,0 as Credit
		from vTrialBalance where AccMainCode>='400000'
		group by Period,AccMonth
		having sum(Cr)>Sum(Dr)
	) a,Mas_AccCode b 
	where b.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
) h left join vMas_AccCode d on
h.AccCode=d.AccCode
GO
/****** Object:  View [dbo].[vSum_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vSum_Balance]
AS
SELECT 
AccType,AccTypeName,AccCode,AccName,
case when Debit>Credit then Debit-Credit else 0 end as Debit,
case when Debit<Credit then Credit-Debit else 0 end as Credit
FROM (
	SELECT   dbo.vTrial_Balance.AccCode, dbo.vTrial_Balance.AccName, SUM(dbo.vTrial_Balance.Dr) AS Debit, SUM(dbo.vTrial_Balance.Cr) AS Credit, dbo.vMas_AccCode.AccType, 
							 dbo.vMas_AccCode.AccTypeName
	FROM            dbo.vTrial_Balance INNER JOIN
							 dbo.vMas_AccCode ON dbo.vTrial_Balance.AccCode = dbo.vMas_AccCode.AccCode
	GROUP BY dbo.vTrial_Balance.AccCode, dbo.vTrial_Balance.AccName, dbo.vMas_AccCode.AccType, dbo.vMas_AccCode.AccTypeName
) t
GO
/****** Object:  View [dbo].[vSum_Stock]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vSum_Stock]
AS
SELECT        AssetAccCode, AssetAccName, SUM(SumAmount) AS TotalAmount, SUM(SumQty) AS TotalQty,
case when SUM(SumQty)>0 then SUM(SumAmount)/SUM(SumQty) else 0 end as AvgPrice
FROM            dbo.vStock_Onhand
GROUP BY AssetAccCode, AssetAccName
GO
/****** Object:  View [dbo].[vPO_Delivery]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vPO_Delivery]
AS
SELECT        dbo.Acc_TransactionHD.*, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, 
                         dbo.Acc_TransactionDT.Price*dbo.Acc_TransactionDT.ExchangeRate as Price , dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, 
                         dbo.Acc_TransactionDT.SalesDescription
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
INNER JOIN dbo.Acc_StockTransaction ON dbo.Acc_TransactionDT.StockTransNo=dbo.Acc_StockTransaction.TransID 
WHERE dbo.Acc_StockTransaction.TransQty>0
AND dbo.Acc_TransactionHD.DocStatus<>99
GO
/****** Object:  View [dbo].[vPO_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vPO_Balance]
as
select a.*,b.RcvQty ,a.Qty-isnull(b.RcvQty,0) as Balance
from
vPO_All a left join
(
select AccSourceDocNo as PoNo,AccSourceDocItem as PoItemNo
,sum(Qty) as RcvQty
from vPO_Delivery
group by AccSourceDocNo,AccSourceDocItem
) b
on a.AccDocNo=b.PoNo and a.AccItemNo=b.PoItemNo
where a.DocStatus<>99
GO
/****** Object:  View [dbo].[vTransaction_Link]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vTransaction_Link]
as
select tr.AccDocType,tr.AccDocTypeName,tr.AccDocNo,tr.AccBatchDate,
tr.PartyCode,tr.PartyTaxCode,tr.PartyName,
tr.SalesDescription,tr.ProductCode,tr.ProductName,tr.ProductTypeCode,tr.WarehouseCode,
tr.Qty,tr.Price,tr.Currency,tr.ExchangeRate,tr.Amount,
tr.DVatType,tr.TotalAmount,tr.RateVat,tr.DVatAmt,tr.DWhtAmt,tr.DNetAmt,
pr.AccDocNo as PRNo,pr.AccBatchDate as PRDate,
sr.AccDocNo as SRNo,sr.AccBatchDate as SRDate,
po.AccDocNo as PONo,po.AccBatchDate as PODate,
ap.AccDocNo as APNo,ap.AccBatchDate as APDate,
pc.AccDocNo as PCNo,pc.AccBatchDate as PCDate,
di.AccDocNo as DINo,di.AccBatchDate as DIDate,
so.AccDocNo as SONo,so.AccBatchDate as SODate,
ar.AccDocNo as ARNo,ar.AccBatchDate as ARDate,
rc.AccDocNo as RCNo,rc.AccBatchDate as RCDate,
do.AccDocNo as DONo,do.AccBatchDate as DODate
from vTransaction_All tr
left join vPR_D pr
on tr.AccSourceDocNo=pr.AccDocNo 
and tr.AccSourceDocItem=pr.AccItemNo
left join vSR_D sr
on tr.AccSourceDocNo=sr.AccDocNo 
and tr.AccSourceDocItem=sr.AccItemNo
left join vPO_D po
on tr.AccSourceDocNo=po.AccDocNo 
and tr.AccSourceDocItem=po.AccItemNo
left join vAP_D ap
on tr.AccSourceDocNo=ap.AccDocNo 
and tr.AccSourceDocItem=ap.AccItemNo
left join vPC_D pc
on tr.AccSourceDocNo=pc.AccDocNo 
and tr.AccSourceDocItem=pc.AccItemNo
left join vDI_D di
on tr.AccSourceDocNo=di.AccDocNo 
and tr.AccSourceDocItem=di.AccItemNo
left join vSO_D so
on tr.AccSourceDocNo=so.AccDocNo 
and tr.AccSourceDocItem=so.AccItemNo
left join vAR_D ar
on tr.AccSourceDocNo=ar.AccDocNo 
and tr.AccSourceDocItem=ar.AccItemNo
left join vRC_D rc
on tr.AccSourceDocNo=rc.AccDocNo 
and tr.AccSourceDocItem=rc.AccItemNo
left join vDO_D do
on tr.AccSourceDocNo=do.AccDocNo 
and tr.AccSourceDocItem=do.AccItemNo
GO
/****** Object:  View [dbo].[vSum_AllType]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vSum_AllType]
as
select AccTypeID,AccTypeName,
sum(Dr) as Debit,sum(Cr) as Credit
from vTrial_balance 
inner join Mas_AccType 
on substring(AccCode,1,1)=Mas_AccType.AccTypeID
group by AccTypeID,AccTypeName
GO
/****** Object:  View [dbo].[vTransaction_LinkBack]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE view [dbo].[vTransaction_LinkBack]
as
select tr.AccDocType,tr.AccDocTypeName,tr.AccDocNo,tr.AccBatchDate,
tr.PartyCode,tr.PartyTaxCode,tr.PartyName,
tr.SalesDescription,tr.ProductCode,tr.ProductName,tr.ProductTypeCode,tr.WarehouseCode,
tr.Qty,tr.Price,tr.Currency,tr.ExchangeRate,tr.Amount,
tr.DVatType,tr.TotalAmount,tr.RateVat,tr.DVatAmt,tr.DWhtAmt,tr.DNetAmt,
pr.AccDocNo as PRNo,pr.AccBatchDate as PRDate,
sr.AccDocNo as SRNo,sr.AccBatchDate as SRDate,
po.AccDocNo as PONo,po.AccBatchDate as PODate,
ap.AccDocNo as APNo,ap.AccBatchDate as APDate,
pc.AccDocNo as PCNo,pc.AccBatchDate as PCDate,
di.AccDocNo as DINo,di.AccBatchDate as DIDate,
so.AccDocNo as SONo,so.AccBatchDate as SODate,
ar.AccDocNo as ARNo,ar.AccBatchDate as ARDate,
rc.AccDocNo as RCNo,rc.AccBatchDate as RCDate,
do.AccDocNo as DONo,do.AccBatchDate as DODate
from vTransaction_All tr
left join vPR_D pr
on tr.AccSourceDocNo=pr.AccSourceDocNo 
and tr.AccSourceDocItem=pr.AccSourceDocItem
and tr.AccdocNo<>pr.AccdocNo
left join vSR_D sr
on tr.AccSourceDocNo=sr.AccSourceDocNo 
and tr.AccSourceDocItem=sr.AccSourceDocItem
and tr.AccdocNo<>sr.AccdocNo
left join vPO_D po
on tr.AccSourceDocNo=po.AccDocNo 
and tr.AccSourceDocItem=po.AccItemNo
and tr.AccdocNo<>po.AccdocNo
left join vSO_D so
on tr.AccSourceDocNo=so.AccSourceDocNo 
and tr.AccSourceDocItem=so.AccSourceDocItem
and tr.AccdocNo<>so.AccdocNo
left join (select * from vAP_D where AccSourceDocNo<>'') ap
on tr.AccSourceDocNo=ap.AccSourceDocNo 
and tr.AccSourceDocItem=ap.AccSourceDocItem
and tr.AccdocNo<>ap.AccdocNo
left join (select * from vPC_D where AccSourceDocNo<>'') pc
on tr.AccSourceDocNo=pc.AccSourceDocNo 
and tr.AccSourceDocItem=pc.AccSourceDocItem
and tr.AccdocNo<>pc.AccdocNo
left join (select * from vDI_D where AccSourceDocNo<>'') di
on tr.AccDocNo=di.AccSourceDocNo 
and tr.AccItemNo=di.AccSourceDocItem
and tr.AccdocNo<>di.AccdocNo
left join (select * from vAR_D where AccSourceDocNo<>'') ar
on tr.AccSourceDocNo=ar.AccSourceDocNo 
and tr.AccSourceDocItem=ar.AccSourceDocItem
and tr.AccdocNo<>ar.AccdocNo
left join (select * from vRC_D where AccSourceDocNo<>'') rc
on tr.AccDocNo=rc.AccSourceDocNo 
and tr.AccItemNo=rc.AccSourceDocItem
and tr.AccdocNo<>rc.AccdocNo
left join (select * from vDO_D where AccSourceDocNo<>'') do
on tr.AccSourceDocNo=do.AccSourceDocNo 
and tr.AccSourceDocItem=do.AccSourceDocItem
and tr.AccdocNo<>do.AccdocNo

GO
/****** Object:  View [dbo].[vDO_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vDO_All]
AS
SELECT        dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccEffectiveDate, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.PartyTaxCode, 
                         dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.IssueBy, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.FiscalYear, 
                         dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'DO')
GO
/****** Object:  View [dbo].[vSO_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vSO_Balance]
as
select a.*,b.IssQty ,a.Qty-isnull(b.IssQty,0) as Balance
from
vSO_All a left join
(
select AccSourceDocNo as SoNo,AccSourceDocItem as SoItemNo
,sum(Qty) as IssQty
from vDO_All
group by AccSourceDocNo,AccSourceDocItem
) b
on a.AccDocNo=b.SoNo and a.AccItemNo=b.SoItemNo
GO
/****** Object:  View [dbo].[vSO_Delivery]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vSO_Delivery]
AS
SELECT        dbo.Acc_TransactionHD.*, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, 
                         dbo.Acc_TransactionDT.Price*dbo.Acc_TransactionDT.ExchangeRate as Price, 
						 dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, 
                         dbo.Acc_TransactionDT.SalesDescription
FROM            dbo.Acc_TransactionHD INNER JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
INNER JOIN dbo.Acc_StockTransaction ON dbo.Acc_TransactionDT.StockTransNo=dbo.Acc_StockTransaction.TransID 
WHERE dbo.Acc_StockTransaction.TransQty<0
GO
/****** Object:  View [dbo].[vStock_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vStock_Balance]
as
select t.*,QTYIN-isnull(QTYOUT,0) as BalQty,
(QTYIN-isnull(QTYOUT,0))*Price as BalAmount
,sum(QTYIN-isnull(QTYOUT,0)) OVER (PARTITION BY SaleProductCode ORDER BY AccEffectiveDate,StockTransNo) as SumQty
from (
	select a.AccDocNo,a.AccItemNo,a.AccEffectiveDate,a.StockTransNo,a.SaleProductCode,
	a.Price as Price,
	a.Qty as QTYIN,isnull(sum(b.Qty),0) as QTYOUT,c.WarehouseCode	
	from vPO_Delivery a
	inner join vMas_Product p on a.SaleProductCode=p.ProductCode
	left join vSO_Delivery b
	on a.AccDocNo=b.AccSourceDocNo and a.AccItemNo=b.AccSourceDocItem
	and a.SaleProductCode=b.SaleProductCode
	inner join Acc_StockTransaction c on a.StockTransNo=c.TransID
	where a.DocStatus<>99
	group by a.AccDocNo,a.AccItemNo,a.AccEffectiveDate,a.StockTransNo,a.SaleProductCode,c.WarehouseCode,
	a.Price,a.Qty
) t

GO
/****** Object:  View [dbo].[vOrder_Balance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE view [dbo].[vOrder_Balance]
as
select t.*,QTYIN-isnull(QTYOUT,0) as BalQty,
round((QTYIN-isnull(QTYOUT,0))*Price,2) as BalAmount
from (
	select a.AccDocNo,a.AccEffectiveDate,a.StockTransNo,a.SaleProductCode,
	a.Price,
	a.Qty as QTYIN,isnull(sum(b.Qty),0) as QTYOUT
	from vPO_All a
	inner join vMas_Product p on a.SaleProductCode=p.ProductCode
	left join vSO_All b
	on a.AccDocNo=b.AccSourceDocNo and a.AccItemNo=b.AccSourceDocItem
	and a.SaleProductCode=b.SaleProductCode
	group by a.AccDocNo,a.AccEffectiveDate,a.StockTransNo,a.SaleProductCode,
	a.Price,a.Qty
) t
GO
/****** Object:  View [dbo].[vBalanceSheet]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vBalanceSheet]
as
SELECT        Period, AccCode, AccName, Dr AS Debit, Cr AS Credit
FROM            vTrial_Balance
WHERE        (Dr + cr) > 0 AND AccMainCode < '400000'
UNION ALL
SELECT        a.Period, b.AccCode, b.AccName, a.Debit, a.Credit
FROM            (SELECT        Period, sum(Dr) - Sum(Cr) AS Debit, 0 AS Credit
                          FROM            vTrial_Balance
                          WHERE        AccMainCode >= '400000'
                          GROUP BY Period
                          HAVING         sum(Dr) > Sum(Cr)
                          UNION ALL
                          SELECT        Period, 0 AS Debit, sum(Cr) - Sum(Dr) AS Credit
                          FROM            vTrial_Balance
                          WHERE        AccMainCode >= '400000'
                          GROUP BY Period
                          HAVING        sum(Cr) > Sum(Dr)) a, Mas_AccCode b
WHERE        b.AccCode = dbo.GetAccConfig('GL_CONFIG', 'ProfitLoss')
GO
/****** Object:  View [dbo].[vPC_CheckPO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vPC_CheckPO]
as
select 
b.AccDocNo,b.AccItemNo,b.VatType,b.RateVat,b.RateWht,
(b.TotalAmount+b.VatAmount-b.WhtAmount) as TotalNet,
sum(a.TotalAmount+a.VatAmount-a.WhtAmount) as TotalPayment,
case when b.VatType=2 then
(b.TotalAmount+b.VatAmount-b.WhtAmount)-sum(a.TotalAmount+a.VatAmount-a.WhtAmount) 
else
b.TotalAmount-sum(a.TotalAmount)
end 
as TotalAmount
from vPC_D a
inner join vPO_D b
on a.AccSourceDocNo=b.AccDocNo 
and a.AccSourceDocItem=b.AccItemNo 
group by b.AccDocNo,b.AccItemNo,
b.TotalAmount,b.VatAmount,b.WhtAmount,b.VatType,b.RateVat,b.RateWht

GO
/****** Object:  View [dbo].[vAcc_CodeConfig]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vAcc_CodeConfig]
as
select a.*,b.AccName from Mas_AccConfig a inner join Mas_AccCode b
on a.ConfigValue=b.AccCode 
GO
/****** Object:  View [dbo].[vDI_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vDI_All]
AS
SELECT        dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccEffectiveDate, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.PartyTaxCode, 
                         dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.IssueBy, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.FiscalYear, 
                         dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'DI')
GO
/****** Object:  View [dbo].[vHR_PayrollSlip]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vHR_PayrollSlip]
AS
SELECT [SlipNo]
      ,[PaymentType]
      ,[StaffId]
      ,[PaymentToAcc]
      ,[PaymentFromAcc]
      ,[PaymentDate]
      ,[SalaryStatus]
      ,[ApproveDate]
      ,[ApproveBy]
      ,[Canceldate]
      ,[Cancelby]
      ,MAX([Createdate]) as CreateDate
      ,[Createby]
      ,SUM([AmountPayment]) as TotalPayment
      ,SUM([AmountAdd]) as TotalRevenue
      ,SUM([AmountDeduct]) as TotalExpense      
  FROM [dbo].[Acc_HRPayRoll]
GROUP BY [SlipNo]
      ,[PaymentType]
      ,[StaffId]
      ,[PaymentToAcc]
      ,[PaymentFromAcc]
      ,[PaymentDate]
      ,[SalaryStatus]
      ,[ApproveDate]
      ,[ApproveBy]
      ,[Canceldate]
      ,[Cancelby]
      ,[Createby]
GO
/****** Object:  View [dbo].[vHR_WorkTimeDetail]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vHR_WorkTimeDetail]
as
	select g.StaffId,g.StaffName,e.PositionName,
	h.DepartmentName,i.DivisionName,a.CheckInType,k.ConfigValue as CheckInTypeName,
	f.TimeStart,f.TimeEnd,a.CheckIndate,a.CheckOutDate,
	f.LateStart,j.LatePerHour/60 as LatePerMin,j.LatePerHour,j.LatePerDay,
	case when a.CheckInType=6 then j.OtPerDay else 0 end as HolidayPay,
	case when CAST(a.CheckInDate as time(7))>=f.LateStart then DATEDIFF(MINUTE,CAST(a.CheckInDate as time(7)),f.LateStart) else 0 end as LateCheckIn,
	case when CAST(a.CheckInDate as time(7))>=f.LateStart then round(DATEDIFF(MINUTE,CAST(a.CheckInDate as time(7)),f.LateStart)*(j.LatePerHour/60),0) else 0 end as LateCheckInPay,
	case when CAST(a.CheckOutDate as time(7))>=f.OTStart then DATEDIFF(MINUTE,f.OTStart,CAST(a.CheckOutDate as time(7))) else 0 end as LateCheckOut,
	case when CAST(a.CheckOutDate as time(7))>=f.OTStart then round(DATEDIFF(MINUTE,f.OTStart,CAST(a.CheckOutDate as time(7)))*(j.OtPerHour/60),0) else 0 end as LateCheckOutPay,
	f.OTStart,j.OTPerHour/60 as OTPerMin,j.OTPerHour,j.OTPerDay,
	DATEDIFF(MINUTE,CAST(a.CheckInDate as time(7)),f.TimeStart)+
	DATEDIFF(MINUTE,f.OTStart,CAST(a.CheckOutDate as time(7))) as OverMin,
	DATEDIFF(MINUTE,a.CheckInDate,a.CheckOutDate) as MinWorks,
	(DATEDIFF(MINUTE,a.CheckInDate,a.CheckOutDate)/60)-1 as HourWorks,
	c.MinuteCheck,c.IsCheckTime,c.DayCheck,c.PaymentDays,
	j.SalaryPerDay,j.SalaryPerHour,j.SalaryPerMonth
	from Acc_HRTimeAttendance a
	inner join Acc_HRContract b on a.StaffId=b.StaffId
	inner join Mas_HRContractType c on b.ContractTypeId=c.ContractTypeId
	inner join Mas_HREmployment d on b.ContractNo=d.ContractNo 
	inner join Mas_HRPosition e on d.PositionId=e.PositionId
	inner join Mas_HRTimeShift f on e.LevelId=f.LevelId
	inner join Mas_HRStaff g on a.StaffId=g.StaffId
	inner join Mas_HRDepartment h on e.DepartmentId=h.DepartmentId
	inner join Mas_HRDivision i on h.DivisionId=i.DivisionId
	inner join Mas_HRPayRollConfig j on e.PositionId=j.PositionId 
	and c.ContractTypeId=j.ContractTypeId
	inner join Mas_HRConfig k on a.CheckInType=k.ConfigKey 
	and k.ConfigCode='CHECKIN_TYPE'
	where a.CheckInDate between f.StartDate and f.EndDate
	and a.CheckInDate between d.BeginDate and d.EndDate
GO
/****** Object:  View [dbo].[vHR_WorkTimeSummary]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vHR_WorkTimeSummary]
as
select Year(CheckIndate) as WorkYear,Month(CheckInDate) as WorkMonth,
StaffId,StaffName,DayCheck,
count(*) as TotalWorkDays,
sum(case when LateCheckIn<0 then 1 else 0 end) as TotalLateIn,
sum(case when LateCheckOut>0 then 1 else 0 end) as TotalLateOut,
sum(case when LateCheckIn<0 then LateCheckIn else 0 end) as TotalLateInMin,
sum(case when LateCheckOut>0 then LateCheckOut else 0 end) as TotalLateOutMin,
sum(case when LateCheckIn<0 then round(cast(LateCheckIn*LatePerMin as decimal(10,2)),0) else 0 end) as TotalLatePay,
sum(case when LateCheckOut>0 then 
round(cast(LateCheckOut*OTPerMin as decimal(10,2)),0) 
else 0 end) as TotalOTPay,
sum(case when CheckInType=6 then OTPerDay else 0 end)
as TotalHolidayPay,
sum(case when CheckInType=4 then 1 else 0 end) as TotalSick,
sum(case when CheckInType=5 then 1 else 0 end) as TotalLeave,
sum(case when CheckInType=6 then 1 else 0 end) as TotalHoliday,
SalaryPerDay,SalaryPerHour,SalaryPerMonth
from 
(
	select g.StaffId,g.StaffName,e.PositionName,
	h.DepartmentName,i.DivisionName,a.CheckInType,
	f.TimeStart,f.TimeEnd,a.CheckIndate,a.CheckOutDate,
	j.OTPerHour/60 as OTPerMin,j.LatePerHour/60 as LatePerMin,
	j.OTPerHour,j.LatePerHour,j.OTPerDay,j.LatePerDay,
	case when CAST(a.CheckInDate as time(7))>=f.LateStart then DATEDIFF(MINUTE,CAST(a.CheckInDate as time(7)),f.LateStart) else 0 end as LateCheckIn,
	case when CAST(a.CheckOutDate as time(7))>=f.OTStart then DATEDIFF(MINUTE,f.OTStart,CAST(a.CheckOutDate as time(7))) else 0 end as LateCheckOut,
	DATEDIFF(MINUTE,CAST(a.CheckInDate as time(7)),f.TimeStart)+
	DATEDIFF(MINUTE,f.TimeEnd,CAST(a.CheckOutDate as time(7))) as OverMin,
	DATEDIFF(MINUTE,a.CheckInDate,a.CheckOutDate) as MinWorks,
	(DATEDIFF(MINUTE,a.CheckInDate,a.CheckOutDate)/60)-1 as HourWorks,
	c.MinuteCheck,c.IsCheckTime,c.DayCheck,c.PaymentDays,
	j.SalaryPerDay,j.SalaryPerHour,j.SalaryPerMonth
	from Acc_HRTimeAttendance a
	inner join Acc_HRContract b on a.StaffId=b.StaffId
	inner join Mas_HRContractType c on b.ContractTypeId=c.ContractTypeId
	inner join Mas_HREmployment d on b.ContractNo=d.ContractNo 
	inner join Mas_HRPosition e on d.PositionId=e.PositionId
	inner join Mas_HRTimeShift f on e.LevelId=f.LevelId
	inner join Mas_HRStaff g on a.StaffId=g.StaffId
	inner join Mas_HRDepartment h on e.DepartmentId=h.DepartmentId
	inner join Mas_HRDivision i on h.DivisionId=i.DivisionId
	inner join Mas_HRPayRollConfig j on e.PositionId=j.PositionId 
	and c.ContractTypeId=j.ContractTypeId
	where a.CheckInDate between f.StartDate and f.EndDate
	and a.CheckInDate between d.BeginDate and d.EndDate
) t
group by Year(CheckIndate),Month(CheckInDate),
StaffId,StaffName,DayCheck,SalaryPerDay,SalaryPerHour,SalaryPerMonth
GO
/****** Object:  View [dbo].[vJournal_ByPeriod]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vJournal_ByPeriod]
as
select c.PeriodYear,c.PeriodName,b.PeriodSeqName,a.*
from Acc_JournalHD a,
Mas_AccPeriodDT b,
Mas_AccPeriodHD c
where b.PeriodId=c.PeriodId
and b.FromDate<=a.EntryDate and b.ToDate>=a.EntryDate

GO
/****** Object:  View [dbo].[vMas_AccConfigCode]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vMas_AccConfigCode]
as
select a.*,b.AccNAme 
from Mas_AccConfig a inner join Mas_AccCode b
on a.ConfigValue=b.AccCode
GO
/****** Object:  View [dbo].[vMas_DocConfigSchema]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vMas_DocConfigSchema]
as
select a.TName,a.EName,b.*
from Mas_DocConfig a inner join Mas_DocConfigSchema b
on a.DocConfigID=b.DocConfigID
GO
/****** Object:  View [dbo].[vMas_HROrgChart]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vMas_HROrgChart]
as
select a.*,
b.DivisionId,b.DivisionName,b.DivisionNameEN,
c.DepartmentId,c.DepartmentName,c.DepartmentNameEN
from Mas_Company a
inner join Mas_HRDivision b
on a.CompanyId=b.CompanyId
inner join Mas_HRDepartment c
on b.DivisionId=c.DivisionId
where c.HeadDepartmentId=0
GO
/****** Object:  View [dbo].[vMas_User]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vMas_User]
as
select * from Mas_User a
inner join Mas_HRStaff b 
on a.Username=b.UserID
where b.StaffType<>99
GO
/****** Object:  View [dbo].[vPC_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vPC_All]
AS
SELECT        dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccEffectiveDate, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.PartyTaxCode, 
                         dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.IssueBy, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.FiscalYear, 
                         dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'PC')
GO
/****** Object:  View [dbo].[vProfileConfig]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vProfileConfig]
as
select 
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_NAME') as CompanyName,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_NAME_EN') as CompanyNameEN,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_TAXNUMBER') as CompanyTaxNo,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_TAXBRANCH') as CompanyTaxBranch,
concat(
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_ADDRESS1'),' ',
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_ADDRESS2')) as CompanyAddress,
concat(
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_ADDRESS1_EN'),' ',
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_ADDRESS2_EN')) as CompanyAddressEN,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_FAX') as CompanyFax,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_TEL') as CompanyTel,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_LOGO') as CompanyLogo,
dbo.GetAccConfig('PROFILE_CONFIG','COMPANY_EMAIL') as CompanyEMail
GO
/****** Object:  View [dbo].[vRC_All]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vRC_All]
AS
SELECT        dbo.Acc_TransactionHD.AccDocNo, dbo.Acc_TransactionHD.AccBatchDate, dbo.Acc_TransactionHD.AccEffectiveDate, dbo.Acc_TransactionHD.PartyCode, dbo.Acc_TransactionHD.PartyTaxCode, 
                         dbo.Acc_TransactionHD.PartyName, dbo.Acc_TransactionHD.PartyAddress, dbo.Acc_TransactionHD.IssueBy, dbo.Acc_TransactionHD.AccDocType, dbo.Acc_TransactionHD.AccPostDate, dbo.Acc_TransactionHD.FiscalYear, 
                         dbo.Acc_TransactionHD.DocStatus, dbo.Acc_TransactionHD.DocRefNo, dbo.Acc_TransactionDT.AccItemNo, dbo.Acc_TransactionDT.AccSourceDocNo, dbo.Acc_TransactionDT.AccSourceDocItem, 
                         dbo.Acc_TransactionDT.StockTransNo, dbo.Acc_TransactionDT.Qty, dbo.Acc_TransactionDT.Price, dbo.Acc_TransactionDT.UnitMea, dbo.Acc_TransactionDT.Currency, dbo.Acc_TransactionDT.ExchangeRate, 
                         dbo.Acc_TransactionDT.Amount, dbo.Acc_TransactionDT.SaleProductCode, dbo.Acc_TransactionDT.SalesDescription,
						 dbo.Acc_TransactionDT.VatType,dbo.Acc_TransactionDT.RateVat,dbo.Acc_TransactionDT.RateWht
FROM            dbo.Acc_TransactionHD LEFT JOIN
                         dbo.Acc_TransactionDT ON dbo.Acc_TransactionHD.AccDocNo = dbo.Acc_TransactionDT.AccDocNo
WHERE        (dbo.Acc_TransactionHD.AccDocType = N'RC')
GO
/****** Object:  View [dbo].[vRV_LinkJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vRV_LinkJob] 
as 
select BranchCode,DocNo,ItemNo,CustTaxID,CustBranch,custName,SICode,AmtCharge,AmtAdvance,ReceiptNet,ReceiptWht,ReceiptNo,ReceiptDAte,ReceiptItemNo,
case when CountAdvPay>0 then 1 else 0 end as IsFromAdv,
case when CountAdvPay=0 and CountBillPay>0 then 1 else 0 end as IsFromAP,
case when CountAdvPay=0 and CountBillPay=0 then 1 else 0 end as IsAccrue
from (
select BranchCode,custTaxID,CustBranch,CustName,DocNo,ItemNo,SICode,AmtCharge,AmtAdvance,ReceiptNo,ReceiptDate,ReceiptItemNo,Net-Amt50Tavi as ReceiptNet,Amt50Tavi as ReceiptWht,
count(*) as countRec,
sum(case when isnull(AdvNO,'')<>'' then 1 else 0 end) as CountAdvPay,
sum(case when not isnull(AdvNO,'')<>'' and isnull(VenderBillingNo,'')<>'' then 1 else 0 end) as CountBillPay,
sum(case when not isnull(AdvNO,'')<>'' and not isnull(VenderBillingNo,'')<>'' then 1 else 0 end) as CountAP
from (
	select rh.BillToCustCode,rh.BillToCustBranch,isnull(cu.NameThai,'-') as CustName,
	isnull(cu.TaxNumber,'-') as CustTaxID,isnull(cu.Branch,'-') as CustBranch,
	rd.InvoiceNo as DocNo,rd.InvoiceItemNo as ItemNo,id.AmtCharge,id.AmtAdvance,rd.SICode,cd.AdvNO,cd.VenderBillingNo,rd.ReceiptNo,rh.ReceiptDate,rd.ItemNo as ReceiptItemNo,rd.Net,rd.Amt50Tavi,
	cd.ClrNo,cd.JobNo,rh.BranchCode 
	from [job_3x].dbo.Job_ReceiptDetail rd
	inner join [job_3x].dbo.Job_ReceiptHeader rh
	on rd.BranchCode=rh.BranchCode and rd.ReceiptNo=rh.ReceiptNo
	left join [job_3x].dbo.Job_InvoiceDetail id 
	on rd.BranchCode=id.BranchCode and rd.InvoiceNo=id.DocNo and rd.InvoiceItemNo=id.ItemNo 	
	left join [job_3x].dbo.Mas_Company cu
	on rh.BillToCustCode=cu.CustCode and rh.BillToCustBranch=cu.Branch
	left join 
	(
		select a.* from [job_3x].dbo.Job_ClearDetail a
		inner join [job_3x].dbo.Job_ClearHeader b
		on a.ClrNo=b.ClrNO and a.BranchCode=b.BranchCode
		where b.DocStatus<>99
	) cd 
	on rd.BranchCode=cd.BranchCode and rd.InvoiceNo=cd.LinkBillNo and rd.InvoiceItemNo=cd.LinkItem 	
	and rd.SICode=cd.SICode 
	where not rh.CancelProve<>''
) r
group by BranchCode,CustTaxID,CustBranch,CustName,DocNo,ItemNo,SICode,AmtCharge,AmtAdvance,ReceiptNo,ReceiptDate,ReceiptItemNo,Net ,Amt50Tavi
) t
GO
/****** Object:  View [dbo].[vStock_Document]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vStock_Document]
as
select * from (
select a.*,c.*,d.AccBatchDate as PaymentDate,a.TransQty*a.TransPrice*a.TransRate as StockAmount
from Acc_StockTransaction a
inner join Acc_TransactionDT b
on a.TransID=b.StockTransNo
inner join Acc_TransactionDT c
on b.AccSourceDocNo=c.AccSourceDocNo
and b.AccSourceDocItem=c.AccSourceDocItem
and b.AccDocNo<>c.AccDocNo
inner join Acc_TransactionHD d
on c.AccDocNo=d.AccDocNo 
where d.AccDocType like 'PC%'
) t
GO
/****** Object:  View [dbo].[vSum_StockByType]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
select * from vSum_TransactionByType
select * from vSum_JournalByType
*/
CREATE view [dbo].[vSum_StockByType]
as
select substring(RefDocNo,1,6) as Header,
count(*) as CountDoc,
sum(TransQty*TransPrice*TransRate) as TotalValue
from Acc_StockTransaction
group by substring(RefDocNo,1,6)
GO
/****** Object:  View [dbo].[vSum_TransactionByDocType]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[vSum_TransactionByDocType]
as 
select concat(year(h.AccBatchDate),FORMAT(Month(h.AccBatchDate),'00'))  as Period,
h.AccDocType as Header,
count(*) as CountDoc,sum(d.TotalAmount) as TotalAmount
from Acc_TransactionHD h
inner join (
 select AccDocNo,sum(Amount) as TotalAmount
 from Acc_TransactionDT 
 group by AccDocNo 
) d on h.AccDocNo=d.AccDocNo
group by h.AccDocType,concat(year(h.AccBatchDate),FORMAT(Month(h.AccBatchDate),'00'))
GO
/****** Object:  View [dbo].[vSum_TransactionByType]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE view [dbo].[vSum_TransactionByType]
as 
select 
SUBSTRING(h.AccDocNo,1,3) as Header,
count(*) as CountDoc,sum(d.TotalAmount) as TotalAmount
from Acc_TransactionHD h
inner join (
 select AccDocNo,sum(Amount) as TotalAmount
 from Acc_TransactionDT 
 group by AccDocNo 
) d on h.AccDocNo=d.AccDocNo
group by SUBSTRING(h.AccDocNo,1,3)
GO
/****** Object:  StoredProcedure [dbo].[Calculate_Depre]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--declare @totalyear int=5;
--declare @soldprice decimal(10,4)=1.0;
--declare @productcode varchar(20)='';
CREATE procedure [dbo].[Calculate_Depre]
(
	@productcode varchar(20),
	@totalyear decimal(10,2),
	@soldprice decimal(10,2)
)
as
begin
with tb
as
(
	select *,@totalyear as TotalYears,@soldprice as ScrapPrice,	
	cast((DepreYearly*@totalyear)/DaysTotal as decimal(10,4)) as DeprePerDay,
	round(DayFirstYear*	cast((DepreYearly*@totalyear)/DaysTotal as decimal(10,4)),1) as DepreFirstYear,
	round(cast((DepreYearly*@totalyear)/DaysTotal as decimal(10,4))*DaysFullYear,1) as DepreFullYear,
	round(DayLastYear	*cast((DepreYearly*@totalyear)/DaysTotal as decimal(10,4)),1) as DepreLastYear
	from (
		select a.AccDocNo,a.AccBatchDate,a.ProductCode,a.ProductName,a.ProductTypecode,a.ProductTypeName,a.WarehouseCode,a.WarehouseName,
		a.AccEffectiveDate,a.AssetAccCode,a.AssetAccName,
		DATEADD(year,@totalyear,a.AccEffectiveDate) as ExpirationDate,
		DATEDIFF(day,a.AccEffectiveDate,DATEADD(year,@totalyear,a.AccEffectiveDate)) as DaysTotal,
		DATEDIFF(day,a.AccEffectiveDate,DATEFROMPARTS(YEAR(a.AccEffectiveDate)+1,1,1)) as DayFirstYear,
		(CASE WHEN DAY(EOMONTH(DATEFROMPARTS(year(a.AccEffectiveDate), 2, 1))) = 29 THEN 366 ELSE 365 END) as DaysFirstYear,	
		DATEDIFF(day,DATEFROMPARTS(YEAR(a.AccEffectiveDate)+1,1,1),DATEFROMPARTS(YEAR(a.AccEffectiveDate)+@totalyear,1,1)) as DaysFullYear,
		DATEDIFF(day,DATEFROMPARTS(YEAR(DATEADD(year,@totalyear,a.AccEffectiveDate)),1,1),DATEADD(year,@totalyear,a.AccEffectiveDate)) as DayLastYear,
		(CASE WHEN DAY(EOMONTH(DATEFROMPARTS(year(DATEADD(year,@totalyear,a.AccEffectiveDate)), 2, 1))) = 29 THEN 366 ELSE 365 END) as DaysLastYear,	
		a.Amount as BuyPrice,
		cast(((a.Amount-@soldprice)/@totalyear) as decimal(10,4)) as DepreYearly
		from vTransaction_All a 
		where exists(
			select 1 from Acc_StockTransaction b
			inner join vTransaction_All c
			on b.TransID=c.StockTransNo 
			where c.AccSourceDocNo=a.AccSourceDocNo and c.AccSourceDocItem=a.AccSourceDocItem
			and b.TransType='IN'
		) and AccDocType='PC' and IsService=0 and isMaterial=0
		and a.ProductCode like @productcode+'%'
	) t 
)
select * from tb order by AssetAccCode,AccEffectiveDate
end

GO
/****** Object:  StoredProcedure [dbo].[CancelDI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CancelDI]
(
    @dino varchar(30),
    @cancelby varchar(20),
    @cancelreason varchar(255)
)
as 
BEGIN
   UPDATE Acc_TransactionHD
   SET DocStatus=99 
   WHERE AccDocNo=@dino;

   UPDATE a
   SET a.TransQty=0
   FROM Acc_StockTransaction a 
   INNER JOIN Acc_TransactionDT b
   on a.TransID =b.StockTransNo
   WHERE b.AccDocNo=@dino;

   Insert Into Acc_AdditionData
   (DocNo,Seq,Text1,Date1,Text2)
   select @dino,0,@cancelby,GETDATE(),@cancelreason
   where Not exists(select 1 from Acc_AdditionData where DocNo=@dino and Seq=0);

   update Acc_AdditionData
   set Date1=GETDATE(),Text1=@cancelby,Text2=@cancelreason
   where DocNo=@dino and Seq=0;

   select DocNo,Date1 as CancelDate,Text1 as CancelBy,Text2 as cancelreason
   from Acc_AdditionData 
   WHERE DocNo=@dino AND Seq=0;

   update a 
   set a.DocStatus=1  
   from Acc_TransactionHD a inner join 
   (select AccDocNo,sum(RcvQty) as RcvQty from vPO_Balance group by AccDocNo) 
   b on a.AccDocNo=b.AccDocNo 
   where b.RcvQty is null and a.DocStatus=2;
END

GO
/****** Object:  StoredProcedure [dbo].[CancelDO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC dbo.Insert_RVFromRC 'RC26010001','Boat','2026-01-03','1112-01'
--EXEC dbo.Insert_DOFromRC 'RC26010001','2026-01-03','2026-01-03','20260103-16.12','ADMIN'
--EXEC dbo.Insert_StockFromDO 'DO26010001','2026-01-03',0,'Boat'

CREATE procedure [dbo].[CancelDO]
(
@dono varchar(50),
@cancelby varchar(50),
@cancelreason varchar(max)
)
as
begin
--select b.* 
update b set b.TransQty=0,b.RefDocNo=concat('*',a.AccDocNo,'#',a.AccItemNo)
from Acc_TransactionDT a
inner join Acc_StockTransaction b 
on concat(a.AccDocNo,'#',a.AccItemNo)=b.RefDocNo
where a.AccDocNo=@dono

update Acc_TransactionHD set DocStatus=99,AccPostDate=GETDATE()
where AccDocNo=@dono

--select a.*
update c set c.DocRefNo=99
from Acc_TransactionDT a
inner join Acc_StockTransaction b 
on a.StockTransNo=b.TransID
inner join Acc_TransactionHD c on
a.AccDocNo=c.AccDocNo 
where b.TransQty=0

Insert Into Acc_AdditionData
(DocNo,Seq,Text1,Date1,Text2)
select @dono,0,@cancelby,GETDATE(),@cancelreason
where Not exists(select 1 from Acc_AdditionData where DocNo=@dono and Seq=0)

update Acc_AdditionData
set Date1=GETDATE(),Text1=@cancelby,Text2=@cancelreason
where DocNo=@dono and Seq=0

select DocNo,Date1 as CancelDate,Text1 as CancelBy,Text2 as cancelreason
from Acc_AdditionData 
WHERE DocNo=@dono AND Seq=0
end

GO
/****** Object:  StoredProcedure [dbo].[CancelJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CancelJournal]
(
	@journalno varchar(20),
	@cancelby varchar(20),
	@canceldate date,
	@cancelreason varchar(255)
)
as
begin
	declare @running varchar(20)=dbo.GetNewRunning('AJ','J',@canceldate);

	declare @id int=(SELECT isnull(MAX(EntryID),0)+1 from Acc_JournalHD);

	INSERT INTO Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
	SELECT @id,@running,@canceldate,@canceldate,@cancelby,[Description],TotalCredit,TotalDebit
	FROM Acc_JournalHD where JournalNo=@journalno;	

	INSERT INTO Acc_JournalDT(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,ItemNo,AccCode,AccName,AccDesc,Credit,Debit 
	from vJournal_All where JournalNo=@journalno;

	iNSERT INTO Acc_AdditionData
	(DocNO,Seq,Text5,Text6,Text7,Date1)
	SELECT @journalno,0,@running,@cancelby,@cancelreason,GETDATE()
	WHERE NOT EXISTS(SELECT 1 FROM Acc_AdditionData where DocNo=@journalno and Seq=0);

	UPDATE Acc_AdditionData
	SET Text5=@running,
	Text6=@cancelby,Text7=@cancelreason,Date1=GETDATE()
	WHERE DocNo=@journalno AND Seq=0;

	select * from Acc_JournalDT where EntryId=@id;
end

GO
/****** Object:  StoredProcedure [dbo].[CancelPC]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CancelPC]
(
	@pcno varchar(20),
	@cancelby varchar(20),
	@cancelreason varchar(255)
)
as
begin
IF not exists(select 1 from vPV_All where [AccDesc]=@pcno AND CancelBy='')
begin
	update Acc_TransactionHD set DocStatus=99 WHERE AccDocNo=@pcno;

	insert into Acc_AdditionData
	(DocNo,Seq,Text6,Text7,Date2)
	select @pcno,0,@cancelby,@cancelreason,GETDATE()
	where not exists(select 1 from Acc_AdditionData where DocNo=@pcno and Seq=0);

	update Acc_AdditionData
	set Date2=GETDATE(),Text6=@cancelby,Text7=@cancelreason
	where DocNo=@pcno and Seq=0;
end
select DocNo,Text6 as CancelBy,Text7 as CancelReason,Date2 as CancelDate from Acc_AdditionData where DocNo=@pcno and Seq=0;
end

GO
/****** Object:  StoredProcedure [dbo].[CancelPI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[CancelPI]
(
    @pino varchar(30),
    @cancelby varchar(20),
    @cancelreason varchar(255)
)
as 
BEGIN
   if not exists(select 1 from vTransaction_All where DocStatus<>99 and AccSourceDocNo=@pino)
   and not exists(select 1 from vJournal_H where isnull(Text6,'')='' and Journalno=@pino)
   begin
	update Acc_TransactionHD set DocStatus=99
	where AccDocNo=@pino;

	Insert into Acc_AdditionData(DocNo,Seq,Text6,Text7,Date1)
	select @pino,0,@cancelby,@cancelreason,GETDATE() 
	where not exists(select 1 from Acc_AdditionData where DocNo=@pino AND Seq=0);

	update Acc_AdditionData
	set Text6=@cancelby,Text7=@cancelreason,Date1=GETDATE()
	where DocNo=@pino and Seq=0;

	update a
	set a.DocStatus=0
	from Acc_TransactionHD a 
	where not exists(
		select 1 from vAP_D where DocStatus<>99
		and AccSourceDocNo=a.AccDocNo 
	) and a.DocStatus=1;
   end
   select DocNo,Text6 as CancelBy,Text7 as CancelReason,Date1 as CancelDate
   from Acc_AdditionData where DocNo=@pino And Seq=0;
END

GO
/****** Object:  StoredProcedure [dbo].[CancelPO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CancelPO]
(
@pono varchar(20),
@cancelby varchar(20),
@cancelreason varchar(255)
)
as
begin
if not exists(select 1 from Acc_TransactionDT a inner join Acc_TransactionHD b on a.AccDocNo=b.AccDocNo
where b.AccDocType<>'PO' and b.DocStatus<>99 and a.AccSourceDocNo=@pono )
BEGIN
    INSERT INTO Acc_AdditionData
    (DocNo,Seq,Text6,Text7,Date2)
    SELECT @pono,0,@cancelby,@cancelreason,GETDATE()
    WHERE NOT Exists(select 1 from Acc_AdditionData WHERE DocNo=@pono AND Seq=0);

    UPDATE Acc_AdditionData
    SET Text6=@cancelby,Text7=@cancelreason,Date2=GETDATE()
    WHERE DocNo=@pono AND Seq=0;

    UPDATE Acc_TransactionHD SET DocStatus=99
    WHERE AccDocNo=@pono;
END
select DocNo,Text6 as CancelBy,Text7 as CancelReason,Date2 as CancelDate FROM Acc_AdditionData WHERE DocNo=@pono;
End 

GO
/****** Object:  StoredProcedure [dbo].[CancelPR]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CancelPR]
(
@prno varchar(20),
@cancelby varchar(20),
@cancelreason varchar(255)
)
as
begin
if not exists(select 1 from Acc_TransactionDT a inner join Acc_TransactionHD b on a.AccDocNo=b.AccDocNo
where b.AccDocType<>'PR' and b.DocStatus<>99 and a.AccSourceDocNo=@prno )
BEGIN
    INSERT INTO Acc_AdditionData
    (DocNo,Seq,Text4,Text5,Date4)
    SELECT @prno,0,@cancelby,@cancelreason,GETDATE()
    WHERE NOT Exists(select 1 from Acc_AdditionData WHERE DocNo=@prno AND Seq=0);

    UPDATE Acc_AdditionData
    SET Text4=@cancelby,Text5=@cancelreason,Date4=GETDATE()
    WHERE DocNo=@prno AND Seq=0;

    UPDATE Acc_TransactionHD SET DocStatus=99
    WHERE AccDocNo=@prno;
END
select DocNo,Text4 as CancelBy,Text5 as CancelReason,Date4 as CancelDate FROM Acc_AdditionData WHERE DocNo=@prno;
End 

GO
/****** Object:  StoredProcedure [dbo].[CloseDI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CloseDI]
(
@dino varchar(20),
@closeby varchar(20)
)
as
begin
    UPDATE Acc_TransactionHD SET DocStatus=2
    WHERE AccDocNo=@dino and AccDocType='DI';

	select AccDocNo,DocStatus,StatusName from vDI_H where AccDocNo=@dino;
End 

GO
/****** Object:  StoredProcedure [dbo].[ClosePO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ClosePO]
(
@pono varchar(20),
@closeby varchar(20)
)
as
begin
    UPDATE Acc_TransactionHD SET DocStatus=3
    WHERE AccDocNo=@pono and AccDocType='PO';

	select AccDocNo,DocStatus,StatusName from vPO_H where AccDocNo=@pono;
End 

GO
/****** Object:  StoredProcedure [dbo].[ClosePR]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ClosePR]
(
@prno varchar(20),
@closeby varchar(20)
)
as
begin
    UPDATE Acc_TransactionHD SET DocStatus=2
    WHERE AccDocNo=@prno and AccDocType='PR';

	select AccDocNo,DocStatus,StatusName from vPR_H where AccDocNo=@prno;
End 

GO
/****** Object:  StoredProcedure [dbo].[CopyTransaction]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[CopyTransaction]
(
@fromdoc varchar(50),
@refno varchar(50),
@doctype varchar(10),
@userid varchar(20),
@docno varchar(50)='',
@docdate date=GetDate
)
as
begin
if (@docno='')
begin
	set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
end

insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
select @docno,@docdate,@docdate,PartyCode,PartyTaxCode,PartyName,PartyAddress,@userid,@doctype,'1900-01-01',@docdate,0,@refno from Acc_TransactionHD 
where AccDocNo=@fromdoc
and not exists(select 1 from Acc_TransactionHD where AccDocNo=@docno);

insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select 
@docno,AccItemNo,AccDocNo,AccItemNo,0,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType
from Acc_TransactionDT d where AccDocNo=@fromdoc
and not exists(select 1 from Acc_TransactionDT where AccDocNo=@docno and AccItemNo=d.AccItemNo);
end

GO
/****** Object:  StoredProcedure [dbo].[DELETE_ALL_JOURNAL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DELETE_ALL_JOURNAL]
as
begin
delete from Acc_JournalDT
delete from Acc_JournalHD 
end

GO
/****** Object:  StoredProcedure [dbo].[DELETE_ALL_TRANSCTION]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[DELETE_ALL_TRANSCTION]
as
begin
delete from Acc_TransactionDT
delete from Acc_TransactionHD
delete from Acc_StockTransaction
delete from Acc_AdditionData
delete from Acc_WHTax
delete from Acc_WHTaxDetail
delete from Mas_Projects
end

GO
/****** Object:  StoredProcedure [dbo].[DELETE_JOB_JOURNAL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DELETE_JOB_JOURNAL]
(
	@datefrom date,
	@dateto date
)
as
begin
DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'PV-A%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'PI-%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'AJ-A%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'AJ-P%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'AJ-C%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'AJ-R%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'RV-A%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'PV-A%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'RV-C%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'PV-C%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'SI-%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'RC-%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'PV-P%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'RV-R%'

DELETE FROM Acc_JournalHD
WHERE EntryDate>=@datefrom and EntryDate<=@dateto 
and JournalNo like 'PV-R%'

DELETE a FROM Acc_JournalDT a
where not exists(select 1 from Acc_JournalHD where EntryId=a.EntryId)
end

GO
/****** Object:  StoredProcedure [dbo].[Generate_GLClosingProfit]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Generate_GLClosingProfit]
(
	@profitcode varchar(20),
	@fiscalyear date,
	@userid varchar(20),
	@note nvarchar(255)
)
as 
begin
declare @running varchar(20)=dbo.GetNewRunning('BL','J',@fiscalyear);

insert into Acc_JournalHD (EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select MAX(EntryID)+1 as id,@running as jno,@fiscalyear as edate,@fiscalyear as pdate,@userid as uid,@note as descr,0 as dr,0 as cr 
from Acc_JournalHD
where not exists(select 1 from Acc_JournalHD where JournalNo=@running);

declare @id int=(select EntryID from Acc_JournalHD where JournalNo=@running);

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id as id,ROW_NUMBER() OVER(ORDER BY AccCode DESC) as seq,AccCode,AccName,AccDesc,Debit,Credit
from
(
	select AccCode,AccName,@note as AccDesc,Credit as Debit,Debit as Credit
	from vProfitLoss
	where AccCode<>dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
	and Period=Year(@fiscalyear)
	union all
	select b.AccCode,b.AccName,a.AccName as AccDesc,Debit,Credit
	from vProfitLoss a,vMas_AccCode b 
	where b.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')	
	and a.Period=Year(@fiscalyear)
	union all
	select b.AccCode,b.AccName,a.AccName as AccDesc,Credit,Debit
	from vProfitLoss a,vMas_AccCode b 
	where a.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
	and a.Period=Year(@fiscalyear)
	and b.AccCode=@profitcode
) tb

update h
set h.TotalDebit=d.Dr,
h.TotalCredit=d.Cr
from 
(
select EntryId,sum(Debit) as Dr,sum(Credit) as Cr 
from Acc_JournalDT group by EntryId
)
d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.EntryId=@id;

select * from vJournal_D where EntryId=@id;
end

GO
/****** Object:  StoredProcedure [dbo].[Generate_GLClosingVAT]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Generate_GLClosingVAT]
(
 @docdate date
)
as
begin
declare @vatbuy float;
select @vatbuy=Debit  from vSum_Balance where AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')

declare @vatsales float;
select @vatsales=Credit  from vSum_Balance where AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')

declare @vatdiff float;

declare @maxid int=(select MAX(EntryID) from Acc_JournalHD);
declare @newjournal varchar(20)=dbo.GetNewJournal(CONCAT('JV',FORMAT(@docdate,'yyMM')),'0000');

if @vatbuy<@vatsales 
begin   
   set @vatdiff=@vatsales-@vatbuy;

   insert into Acc_JournalHD select @maxid+1,@newjournal,@docdate,@docdate,'ADMIN','Close VAT Balance',@vatdiff,@vatdiff

   insert into Acc_JournalDT select @maxid+1,1,AccCode,AccName,'ปิดบัญชีภาษีขาย',@vatsales,0
   from Mas_AccCode where AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')

   insert into Acc_JournalDT select @maxid+1,2,AccCode,AccName,'ปิดบัญชีภาษีซื้อ',0,@vatbuy
   from Mas_AccCode where AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')

   insert into Acc_JournalDT select @maxid+1,3,AccCode,AccName,'เจ้าหนี้-กรมสรรพากร',0,@vatdiff
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','InputTax')
end
else
begin	
	set @vatdiff=@vatbuy-@vatsales;
	insert into Acc_JournalHD select @maxid+1,@newjournal,@docdate,@docdate,'ADMIN','Close VAT Balance',@vatdiff,@vatdiff

   insert into Acc_JournalDT select @maxid+1,1,AccCode,AccName,'ปิดบัญชีภาษีขาย',@vatsales,0
   from Mas_AccCode where AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')
   
   insert into Acc_JournalDT select @maxid+1,2,AccCode,AccName,'ลูกหนี้-กรมสรรพากร',@vatdiff,0
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','OutputTax')
   
   insert into Acc_JournalDT select @maxid+1,3,AccCode,AccName,'ปิดบัญชีภาษีซื้อ',0,@vatbuy
   from Mas_AccCode where AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')
end
--select * from vJournal_All where JournalNo=@newjournal
end

GO
/****** Object:  StoredProcedure [dbo].[Generate_GLClosingWHT]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Generate_GLClosingWHT]
(
 @docdate date
)
as
begin
declare @taxcustomer float=(select isnull(sum(Credit),0) from vSum_Balance where AccCode =dbo.GetAccConfig('ADV_CONFIG','TaxCustomer'));
declare @taxcompany float=(select isnull(sum(Credit),0) from vSum_Balance where AccCode =dbo.GetAccConfig('ADV_CONFIG','TaxCompany'));
declare @taxperson float=(select isnull(sum(Credit),0) from vSum_Balance where AccCode =dbo.GetAccConfig('ADV_CONFIG','TaxPerson'));
declare @taxstaff float=(select isnull(sum(Credit),0) from vSum_Balance where AccCode =dbo.GetAccConfig('ADV_CONFIG','TaxStaff'));

declare @taxnet float=@taxcustomer+@taxcompany+@taxperson+@taxstaff;

declare @maxid int=(select MAX(EntryID) from Acc_JournalHD);
declare @newjournal varchar(20)=dbo.GetNewJournal(CONCAT('JV',FORMAT(@docdate,'yyMM')),'0000');

insert into Acc_JournalHD select @maxid+1,@newjournal,@docdate,@docdate,'ADMIN','Closing WHT Non-Paid',@taxnet,@taxnet
insert into Acc_JournalDT select @maxid+1,1,b.AccCode,b.AccName,'ปิดบัญชีภาษีกระทำการแทน',@taxcustomer,0 from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='ADV_CONFIG' and a.ConfigKey='TaxCustomer'
insert into Acc_JournalDT select @maxid+1,2,b.AccCode,b.AccName,'ปิดบัญชีภาษี ภงด 1',@taxstaff,0 from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='ADV_CONFIG' and a.ConfigKey='TaxStaff'
insert into Acc_JournalDT select @maxid+1,3,b.AccCode,b.AccName,'ปิดบัญชีภาษี ภงด 3',@taxperson,0 from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='ADV_CONFIG' and a.ConfigKey='TaxPerson'
insert into Acc_JournalDT select @maxid+1,4,b.AccCode,b.AccName,'ปิดบัญชีภาษี ภงด 53',@taxcompany,0 from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='ADV_CONFIG' and a.ConfigKey='TaxCompany'
insert into Acc_JournalDT select @maxid+1,5,b.AccCode,b.AccName,'เจ้าหนี้-กรมสรรพากร',0,@taxnet from Mas_AccConfig a inner join Mas_AccCode b on a.ConfigValue=b.AccCode where a.ConfigCode='WHT_CONFIG' and a.ConfigKey='InputTax'

declare @outputtax float;
select @outputtax=Debit  from vSum_Balance where AccCode=dbo.GetAccConfig('WHT_CONFIG','OutputTax')

declare @inputtax float;
select @inputtax=Credit  from vSum_Balance where AccCode=dbo.GetAccConfig('WHT_CONFIG','InputTax')

declare @taxdiff float;

set @maxid=(select MAX(EntryID) from Acc_JournalHD);
set @newjournal=dbo.GetNewJournal(CONCAT('JV',FORMAT(@docdate,'yyMM')),'0000');

if @inputtax>@outputtax
begin   
   set @taxdiff=@outputtax-@inputtax;

   insert into Acc_JournalHD select @maxid+1,@newjournal,@docdate,@docdate,'ADMIN','Close WHT Balance',@taxdiff,@taxdiff

   insert into Acc_JournalDT select @maxid+1,1,AccCode,AccName,'ปิดบัญชีภาษีหัก ณ ที่จ่าย',0,@outputtax
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','OutputTax')

   insert into Acc_JournalDT select @maxid+1,2,AccCode,AccName,'ปิดบัญชีภาษีถูกหัก ณ ที่จ่าย',@inputtax,0
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','InputTax')

   insert into Acc_JournalDT select @maxid+1,3,AccCode,AccName,'ลูกหนี้-กรมสรรพากร',@taxdiff,0
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','InputTax')
end
else
begin	
	set @taxdiff=@inputtax-@outputtax;
	insert into Acc_JournalHD select @maxid+1,@newjournal,@docdate,@docdate,'ADMIN','Close WHT Balance',@taxdiff,@taxdiff

   insert into Acc_JournalDT select @maxid+1,1,AccCode,AccName,'ปิดบัญชีภาษีหัก ณ ที่จ่าย',0,@outputtax
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','OutputTax')

   insert into Acc_JournalDT select @maxid+1,2,AccCode,AccName,'ปิดบัญชีภาษีถูกหัก ณ ที่จ่าย',@inputtax,0
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','InputTax')

   insert into Acc_JournalDT select @maxid+1,3,AccCode,AccName,'เจ้าหนี้-กรมสรรพากร',0,@taxdiff
   from Mas_AccCode where AccCode=dbo.GetAccConfig('WHT_CONFIG','OutputTax')
end
--select * from vJournal_All where JournalNo=@newjournal
end

GO
/****** Object:  StoredProcedure [dbo].[Generate_ReportGL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

















CREATE procedure [dbo].[Generate_ReportGL]
(
@acccode varchar(20),
@datefrom date,
@dateto date,
@group int=0,
@filter varchar(20)=''
)
as
begin
declare @prevSum float=(select sum(
(case when EntryDate<@datefrom then (case when AccTypeID in(1,5) then Debit-Credit ELSE Credit-Debit end) else 0 end)
) as Prevsum from vJournal_All where JournalNo like @filter+'%' and EntryDate<@datefrom and AccCode=@acccode)

declare @nextSum float=(select sum(
(case when EntryDate<=@dateto then (case when AccTypeID in(1,5) then Debit-Credit ELSE Credit-Debit end) else 0 end)
) as Nextsum from vJournal_All where JournalNo like @filter+'%' and EntryDate<=@dateto and AccCode=@acccode)

DROP TABLE Acc_TempGL

select ROW_NUMBER() OVER(ORDER BY Lvl,AccRemark,EffectiveDate) as ItemNo,ac.AccName,tb.* into Acc_TempGL from
(
	select 0 as Lvl,@acccode as AccCode,DATEADD(day,-1,@datefrom) as EffectiveDate,
	 '' as JournalNo,'Previous Balance' as AccDesc,'' as AccRemark,'' as AccDetail,
	(case when SUBSTRING(@acccode,1,1) in('1','5') AND @prevSum>0 then @prevSum else (case when SUBSTRING(@acccode,1,1) not in('1','5') AND @prevSum<0 then ABS(@prevSum) else 0 end) end) as Debit,
	(case when SUBSTRING(@acccode,1,1) not in('1','5') AND @prevSum>0 then @prevSum else (case when SUBSTRING(@acccode,1,1) in('1','5') AND @prevSum<0 then ABS(@prevSum) else 0 end) end) as Credit
	union all
	select 1 as Lvl,AccCode,EntryDate,JournalNo,AccDesc,
	(case when @group=0 then AccRemark else [Description] end) as AccRemark,
	(case when @group=0 then AccDesc else AccRemark end) as AccDetail, 
	sum(Debit) as Debit,sum(Credit) as Credit
	from vJournal_All where AccCode=@acccode
	and JournalNo like @filter+'%' and EntryDate>=@datefrom and EntryDate<=@dateto
	group by AccCode,EntryDate,JournalNo,AccDesc,AccRemark,[Description]
	union all
	select 2 as Lvl,@acccode as AccCode,DATEADD(day,1,@dateto) as EntryDate,
	 '-' as JournalNo,'Forward Balance' as AccDesc,'' as AccRemark,'' as AccDetail,
	(case when SUBSTRING(@acccode,1,1) in('1','5') AND @nextSum>0 then @nextSum else (case when SUBSTRING(@acccode,1,1) not in('1','5') AND @nextSum<0 then ABS(@nextSum) else 0 end) end) as Debit,
	(case when SUBSTRING(@acccode,1,1) not in('1','5') AND @nextSum>0 then @nextSum else (case when SUBSTRING(@acccode,1,1) in('1','5') AND @nextSum<0 then ABS(@nextSum) else 0 end) end) as Credit
) tb left join vMas_AccCode ac on tb.AccCode=ac.AccCode
order by Lvl,AccRemark,EffectiveDate,JournalNo

select *,ABS(SUM(CASE WHEN JournalNo<>'-' THEN Debit-Credit ELSE 0 END) OVER(PARTITION BY AccName ORDER BY ItemNo)) as Balance from Acc_TempGL

end

GO
/****** Object:  StoredProcedure [dbo].[Generate_ReportGL_ByJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE procedure [dbo].[Generate_ReportGL_ByJob]
(
	@jobno varchar(20)
)
as
begin
select AccDocType,AccDocNo,AssetAccName,ProductName,
sum(Amount) as AMT,sum(DVatAmt) as VAT,sum(DWhtAmt) as WHT,sum(DNetAmt) as NET
from vTransaction_All where SalesDescription=@jobno
group by AccDocType,AccDocNo,AssetAccName,ProductName order by 1

select JournalNo,AccCode,AccName,AccDesc,
sum(Debit) as Dr,sum(Credit) as Cr
from vJournal_All where AccRemark=@jobno
group by JournalNo,AccCode,AccName,AccDesc
order by JournalNo

select AccCode,AccName,
sum(Debit) as Dr,sum(Credit) as Cr
from vJournal_All where AccRemark=@jobno
group by AccCode,AccName
end

GO
/****** Object:  StoredProcedure [dbo].[GetBalance_DateCompare]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetBalance_DateCompare]
(	
	@datebegin date,
	@datefrom date,
	@dateto date
)
as
begin
with tbl 
as
(
	select 
	AccCode,AccName,
	Dr_LastYear as Dr_Before,Cr_LastYear as Cr_Before,
	Dr_Current,Cr_Current,
	Dr_Balance,Cr_Balance,
	(case when Dr_Forward>0 then Dr_Forward else (case when Cr_Forward<0 then ABS(Cr_Forward) else 0 end) end) as Dr_Forward,
	(case when Cr_Forward>0 then Cr_Forward else (case when Dr_Forward<0 then ABS(Dr_Forward) else 0 end) end) as Cr_Forward
	from (
		select *,
		case when Dr_LastYear>0 then Dr_LastYear+Dr_Current-Cr_Current else 0 end as Dr_Forward,
		case when Cr_LastYear>0 then Cr_LastYear+Cr_Current-Dr_Current else 0 end as Cr_Forward
		from (
			select AccCode,AccName,
			case when Dr_Previous>Cr_Previous then Dr_Previous-Cr_Previous else 0 end as Dr_LastYear,
			case when Dr_Previous<Cr_Previous then Cr_Previous-Dr_Previous else 0 end as Cr_LastYear,
			Dr_Current,Cr_Current,
			case when Dr_Current>Cr_Current then Dr_Current-Cr_Current else 0 end as Dr_Balance,
			case when Dr_Current<Cr_Current then Cr_Current-Dr_Current else 0 end as Cr_Balance
			from (
				select AccCode,AccName,
				sum(case when Entrydate<@datefrom then Debit else 0 end) as Dr_Previous,
				sum(case when Entrydate<@datefrom then Credit else 0 end) as Cr_Previous,
				sum(case when EntryDate>=@datefrom then Debit else 0 end) as Dr_Current,
				sum(case when EntryDate>=@datefrom then Credit else 0 end) as Cr_Current
				from vJournal_All
				where EntryDate>=@datebegin and EntryDate<=@dateto
				group by AccCode,AccName
			) src
		) t0
	) t1
)
select * from (
	select a.* 
	from tbl a
	union all
	select
	c.AccCode,c.AccName,
	case when sum(Dr_Before)>sum(Cr_Before) then sum(Dr_Before)-sum(Cr_Before) else 0 end as Dr_Before,
	case when sum(Dr_Before)<sum(Cr_Before) then sum(Cr_Before)-sum(Dr_Before) else 0 end as Cr_Before,
	case when sum(Dr_Current)>sum(Cr_Current) then sum(Dr_Current)-sum(Cr_Current) else 0 end as Dr_Current,
	case when sum(Dr_Current)<sum(Cr_Current) then sum(Cr_Current)-sum(Dr_Current) else 0 end as Cr_Current,
	case when sum(Dr_Balance)>sum(Cr_Balance) then sum(Dr_Balance)-sum(Cr_Balance) else 0 end as Dr_Balance,
	case when sum(Dr_Balance)<sum(Cr_Balance) then sum(Cr_Balance)-sum(Dr_Balance) else 0 end as Cr_Balance,
	case when sum(Dr_Forward)>sum(Cr_Forward) then sum(Dr_Forward)-sum(Cr_Forward) else 0 end as Dr_Forward,
	case when sum(Dr_Forward)<sum(Cr_Forward) then sum(Cr_Forward)-sum(Dr_Forward) else 0 end as Cr_Forward
	from tbl b,Mas_AccCode c
	where substring(b.AccCode,1,1) in('4','5')
	and c.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
	group by c.AccCode,c.AccName
) s
order by AccCode
end

GO
/****** Object:  StoredProcedure [dbo].[GetBalance_JournalByJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetBalance_JournalByJob]
(
	@jobno varchar(20)='%',
	@acccode varchar(20)='%'
)
as
begin
select * into #tmpbal from (
	select AccCode,AccDesc,
	sum(Debit) a,sum(Credit) b,sum(Debit)-sum(Credit) c
	from Acc_JournalDT
	where AccCode like @acccode
	and AccDesc like @jobno
	group by AccCode,AccDesc
	having sum(Debit)<>sum(Credit)
) t

select b.AccName,a.* from #tmpbal a inner join Mas_AccCode b on a.AccCode=b.AccCode;
select b.AccCode,b.AccName,sum(c) as bal from #tmpbal a inner join Mas_AccCode b on a.AccCode=b.AccCode group by b.AccCode,b.AccName;

drop table #tmpbal;
end

GO
/****** Object:  StoredProcedure [dbo].[GetBalance_QuarterCompare]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GetBalance_QuarterCompare]
(
	@yy int
)
as
begin
with tbl
as
(
	select 
	AccCode,AccName,
	Dr_LQ1,Cr_LQ1,Dr_Q1,Cr_Q1,
	Dr_LQ2,Cr_LQ2,Dr_Q2,Cr_Q2,
	Dr_LQ3,Cr_LQ3,Dr_Q3,Cr_Q3,
	Dr_LQ4,Cr_LQ4,Dr_Q4,Cr_Q4
	from 
	(
		select AccCode,AccName,
		(case when Dr_PQ1>Cr_PQ1 then Dr_PQ1-Cr_PQ1 else 0 end) as Dr_LQ1,
		(case when Cr_PQ1>Dr_PQ1 then Cr_PQ1-Dr_PQ1 else 0 end) as Cr_LQ1,
		(case when Dr_PQ2>Cr_PQ2 then Dr_PQ2-Cr_PQ2 else 0 end) as Dr_LQ2,
		(case when Cr_PQ2>Dr_PQ2 then Cr_PQ2-Dr_PQ2 else 0 end) as Cr_LQ2,
		(case when Dr_PQ3>Cr_PQ3 then Dr_PQ3-Cr_PQ3 else 0 end) as Dr_LQ3,
		(case when Cr_PQ3>Dr_PQ3 then Cr_PQ3-Dr_PQ3 else 0 end) as Cr_LQ3,
		(case when Dr_PQ4>Cr_PQ4 then Dr_PQ4-Cr_PQ4 else 0 end) as Dr_LQ4,
		(case when Cr_PQ4>Dr_PQ4 then Cr_PQ4-Dr_PQ4 else 0 end) as Cr_LQ4,
		(case when Dr_Q1>Cr_Q1 then Dr_Q1-Cr_Q1 else 0 end) as Dr_Q1,
		(case when Cr_Q1>Dr_Q1 then Cr_Q1-Dr_Q1 else 0 end) as Cr_Q1,
		(case when Dr_Q2>Cr_Q2 then Dr_Q2-Cr_Q2 else 0 end) as Dr_Q2,
		(case when Cr_Q2>Dr_Q2 then Cr_Q2-Dr_Q2 else 0 end) as Cr_Q2,
		(case when Dr_Q3>Cr_Q3 then Dr_Q3-Cr_Q3 else 0 end) as Dr_Q3,
		(case when Cr_Q3>Dr_Q3 then Cr_Q3-Dr_Q3 else 0 end) as Cr_Q3,
		(case when Dr_Q4>Cr_Q4 then Dr_Q4-Cr_Q4 else 0 end) as Dr_Q4,
		(case when Cr_Q4>Dr_Q4 then Cr_Q4-Dr_Q4 else 0 end) as Cr_Q4
		from (
			select AccCode,AccName,
			sum(case when (Year(EntryDate)=@yy-1 AND month(EntryDate)<4) or Year(EntryDate)<@yy-1 then Debit else 0 end) as Dr_PQ1,
			sum(case when (Year(EntryDate)=@yy-1 AND month(EntryDate)<4) or Year(EntryDate)<@yy-1 then Credit else 0 end) as Cr_PQ1,
			sum(case when (Year(EntryDate)=@yy-1 AND month(EntryDate)<7) or Year(EntryDate)<@yy-1 then Debit else 0 end) as Dr_PQ2,
			sum(case when (Year(EntryDate)=@yy-1 AND month(EntryDate)<7) or Year(EntryDate)<@yy-1 then Credit else 0 end) as Cr_PQ2,
			sum(case when (Year(EntryDate)=@yy-1 AND month(EntryDate)<10) or Year(EntryDate)<@yy-1 then Debit else 0 end) as Dr_PQ3,
			sum(case when (Year(EntryDate)=@yy-1 AND month(EntryDate)<10) or Year(EntryDate)<@yy-1 then Credit else 0 end) as Cr_PQ3,
			sum(case when Year(EntryDate)<@yy then Debit else 0 end) as Dr_PQ4,
			sum(case when Year(EntryDate)<@yy then Credit else 0 end) as Cr_PQ4,
			sum(case when (Year(Entrydate)=@yy and month(Entrydate)<4) or Year(EntryDate)<@yy then Debit else 0 end) as Dr_Q1,
			sum(case when (Year(Entrydate)=@yy and month(Entrydate)<4) or Year(EntryDate)<@yy then Credit else 0 end) as Cr_Q1,
			sum(case when (Year(Entrydate)=@yy and month(Entrydate)<7) or Year(EntryDate)<@yy then Debit else 0 end) as Dr_Q2,
			sum(case when (Year(Entrydate)=@yy and month(Entrydate)<7) or Year(EntryDate)<@yy then Credit else 0 end) as Cr_Q2,
			sum(case when (Year(Entrydate)=@yy and month(Entrydate)<10) or Year(EntryDate)<@yy then Debit else 0 end) as Dr_Q3,
			sum(case when (Year(Entrydate)=@yy and month(Entrydate)<10) or Year(EntryDate)<@yy then Credit else 0 end) as Cr_Q3,
			sum(case when (Year(Entrydate)=@yy) or Year(EntryDate)<@yy then Debit else 0 end) as Dr_Q4,
			sum(case when (Year(Entrydate)=@yy) or Year(EntryDate)<@yy then Credit else 0 end) as Cr_Q4
			from vJournal_All
			group by AccCode,AccName
		) src
	) t
)
select *,
(case when substring(AccCode,1,1) in('1','5') then ((Dr_Q1-Cr_Q1)-(Dr_LQ1-Cr_LQ1)) else ((Cr_Q1-Dr_Q1)-(Cr_LQ1-Dr_LQ1)) end) as Change_Q1,
(case when substring(AccCode,1,1) in('1','5') then ((Dr_Q2-Cr_Q2)-(Dr_LQ2-Cr_LQ2)) else ((Cr_Q2-Dr_Q2)-(Cr_LQ2-Dr_LQ2)) end) as Change_Q2,
(case when substring(AccCode,1,1) in('1','5') then ((Dr_Q3-Cr_Q3)-(Dr_LQ3-Cr_LQ3)) else ((Cr_Q3-Dr_Q3)-(Cr_LQ3-Dr_LQ3)) end) as Change_Q3,
(case when substring(AccCode,1,1) in('1','5') then ((Dr_Q4-Cr_Q4)-(Dr_LQ4-Cr_LQ4)) else ((Cr_Q4-Dr_Q4)-(Cr_LQ4-Dr_LQ4)) end) as Change_Q4,
(case when substring(AccCode,1,1) in('1','5') then (case when (Dr_LQ1-Cr_LQ1)<>0 then (((Dr_Q1-Cr_Q1)-(Dr_LQ1-Cr_LQ1))/(Dr_LQ1-Cr_LQ1)) else 0 end) 
 else (case when (Cr_LQ1-Dr_LQ1)<>0 then (((Cr_Q1-Dr_Q1)-(Cr_LQ1-Dr_LQ1))/(Cr_LQ1-Dr_LQ1)) else 0 end) end)*100 as Ratio_Q1,
(case when substring(AccCode,1,1) in('1','5') then (case when (Dr_LQ2-Cr_LQ2)<>0 then (((Dr_Q2-Cr_Q2)-(Dr_LQ2-Cr_LQ2))/(Dr_LQ2-Cr_LQ2)) else 0 end) 
 else (case when (Cr_LQ2-Dr_LQ2)<>0 then (((Cr_Q2-Dr_Q2)-(Cr_LQ2-Dr_LQ2))/(Cr_LQ2-Dr_LQ2))else 0 end) end)*100 as Ratio_Q2,
(case when substring(AccCode,1,1) in('1','5') then (case when (Dr_LQ3-Cr_LQ3)<>0 then (((Dr_Q3-Cr_Q3)-(Dr_LQ3-Cr_LQ3))/(Dr_LQ3-Cr_LQ3)) else 0 end) 
else (case when (Cr_LQ3-Dr_LQ3)<>0 then (((Cr_Q3-Dr_Q3)-(Cr_LQ3-Dr_LQ3))/(Cr_LQ3-Dr_LQ3)) else 0 end) end)*100 as Ratio_Q3,
(case when substring(AccCode,1,1) in('1','5') then (case when (Dr_LQ4-Cr_LQ4)<>0 then (((Dr_Q4-Cr_Q4)-(Dr_LQ4-Cr_LQ4))/(Dr_LQ4-Cr_LQ4)) else 0 end) 
else (case when (Cr_LQ4-Dr_LQ4)<>0 then (((Cr_Q4-Dr_Q4)-(Cr_LQ4-Dr_LQ4))/(Cr_LQ4-Dr_LQ4)) else 0 end) end)*100 as Ratio_Q4
from (
	select a.* 
	from tbl a
	union all
	select
	c.AccCode,c.AccName,
	case when sum(Dr_LQ1)>sum(Cr_LQ1) then sum(Dr_LQ1)-sum(Cr_LQ1) else 0 end as Dr_LQ1,
	case when sum(Dr_LQ1)<sum(Cr_LQ1) then sum(Cr_LQ1)-sum(Dr_LQ1) else 0 end as Cr_LQ1,
	case when sum(Dr_Q1)>sum(Cr_Q1) then sum(Dr_Q1)-sum(Cr_Q1) else 0 end as Dr_Q1,
	case when sum(Dr_Q1)<sum(Cr_Q1) then sum(Cr_Q1)-sum(Dr_Q1) else 0 end as Cr_Q1,
	case when sum(Dr_LQ2)>sum(Cr_LQ2) then sum(Dr_LQ2)-sum(Cr_LQ2) else 0 end as Dr_LQ2,
	case when sum(Dr_LQ2)<sum(Cr_LQ2) then sum(Cr_LQ2)-sum(Dr_LQ2) else 0 end as Cr_LQ2,
	case when sum(Dr_Q2)>sum(Cr_Q2) then sum(Dr_Q2)-sum(Cr_Q2) else 0 end as Dr_Q2,
	case when sum(Dr_Q2)<sum(Cr_Q2) then sum(Cr_Q2)-sum(Dr_Q2) else 0 end as Cr_Q2,
	case when sum(Dr_LQ3)>sum(Cr_LQ3) then sum(Dr_LQ3)-sum(Cr_LQ3) else 0 end as Dr_LQ3,
	case when sum(Dr_LQ3)<sum(Cr_LQ3) then sum(Cr_LQ3)-sum(Dr_LQ3) else 0 end as Cr_LQ3,
	case when sum(Dr_Q3)>sum(Cr_Q3) then sum(Dr_Q3)-sum(Cr_Q3) else 0 end as Dr_Q3,
	case when sum(Dr_Q3)<sum(Cr_Q3) then sum(Cr_Q3)-sum(Dr_Q3) else 0 end as Cr_Q3,
	case when sum(Dr_LQ4)>sum(Cr_LQ4) then sum(Dr_LQ4)-sum(Cr_LQ4) else 0 end as Dr_LQ4,
	case when sum(Dr_LQ4)<sum(Cr_LQ4) then sum(Cr_LQ4)-sum(Dr_LQ4) else 0 end as Cr_LQ4,
	case when sum(Dr_Q4)>sum(Cr_Q4) then sum(Dr_Q4)-sum(Cr_Q4) else 0 end as Dr_Q4,
	case when sum(Dr_Q4)<sum(Cr_Q4) then sum(Cr_Q4)-sum(Dr_Q4) else 0 end as Cr_Q4
	from tbl b,Mas_AccCode c
	where substring(b.AccCode,1,1) in('4','5')
	and c.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
	group by c.AccCode,c.AccName
) s
where AccCode is not null
order by AccCode
end

GO
/****** Object:  StoredProcedure [dbo].[GetBalance_YearCompare]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GetBalance_YearCompare]
(
	@yy int
)
as
begin
with tbl 
as
(
	select 
	AccCode,AccName,
	Dr_LastYear,Cr_LastYear,
	Dr_Current,Cr_Current,
	Dr_Balance,Cr_Balance,
	(case when Dr_Forward>0 then Dr_Forward else (case when Cr_Forward<0 then ABS(Cr_Forward) else 0 end) end) as Dr_Forward,
	(case when Cr_Forward>0 then Cr_Forward else (case when Dr_Forward<0 then ABS(Dr_Forward) else 0 end) end) as Cr_Forward
	from (
		select *,
		case when Dr_LastYear>0 then Dr_LastYear+Dr_Current-Cr_Current else 0 end as Dr_Forward,
		case when Cr_LastYear>0 then Cr_LastYear+Cr_Current-Dr_Current else 0 end as Cr_Forward
		from (
			select AccCode,AccName,
			case when Dr_Previous>Cr_Previous then Dr_Previous-Cr_Previous else 0 end as Dr_LastYear,
			case when Dr_Previous<Cr_Previous then Cr_Previous-Dr_Previous else 0 end as Cr_LastYear,
			Dr_Current,Cr_Current,
			case when Dr_Current>Cr_Current then Dr_Current-Cr_Current else 0 end as Dr_Balance,
			case when Dr_Current<Cr_Current then Cr_Current-Dr_Current else 0 end as Cr_Balance
			from (
				select AccCode,AccName,
				sum(case when Year(Entrydate)<@yy then Debit else 0 end) as Dr_Previous,
				sum(case when Year(Entrydate)<@yy then Credit else 0 end) as Cr_Previous,
				sum(case when Year(Entrydate)=@yy then Debit else 0 end) as Dr_Current,
				sum(case when Year(Entrydate)=@yy then Credit else 0 end) as Cr_Current
				from vJournal_All
				group by AccCode,AccName
			) src
		) t0
	) t1
)
select *,
(case when SUBSTRING(AccCode,1,1) in('1','5') then (Dr_Forward-Cr_Forward)-(Dr_LastYear-Cr_LastYear) else ((Cr_Forward-Dr_Forward)-(Cr_LastYear-Dr_LastYear)) end) as ChangeAmt,
(case when SUBSTRING(AccCode,1,1) in('1','5') then (case when (Dr_LastYear-Cr_LastYear)<>0 then ((Dr_Forward-Cr_Forward)-(Dr_LastYear-Cr_LastYear))/(Dr_LastYear-Cr_LastYear) 
else 0 end) else (case when (Cr_LastYear-Dr_LastYear)<>0 then ((Cr_Forward-Dr_Forward)-(Cr_LastYear-Dr_LastYear))/(Cr_LastYear-Dr_LastYear) 
else 0 end) end)*100 as ChangeRatio
from (
	select a.* 
	from tbl a
	union all
	select
	c.AccCode,c.AccName,
	case when sum(Dr_LastYear)>sum(Cr_LastYear) then sum(Dr_LastYear)-sum(Cr_LastYear) else 0 end as Dr_LastYear,
	case when sum(Dr_LastYear)<sum(Cr_LastYear) then sum(Cr_LastYear)-sum(Dr_LastYear) else 0 end as Cr_LastYear,
	case when sum(Dr_Current)>sum(Cr_Current) then sum(Dr_Current)-sum(Cr_Current) else 0 end as Dr_Current,
	case when sum(Dr_Current)<sum(Cr_Current) then sum(Cr_Current)-sum(Dr_Current) else 0 end as Cr_Current,
	case when sum(Dr_Balance)>sum(Cr_Balance) then sum(Dr_Balance)-sum(Cr_Balance) else 0 end as Dr_Balance,
	case when sum(Dr_Balance)<sum(Cr_Balance) then sum(Cr_Balance)-sum(Dr_Balance) else 0 end as Cr_Balance,
	case when sum(Dr_Forward)>sum(Cr_Forward) then sum(Dr_Forward)-sum(Cr_Forward) else 0 end as Dr_Forward,
	case when sum(Dr_Forward)<sum(Cr_Forward) then sum(Cr_Forward)-sum(Dr_Forward) else 0 end as Cr_Forward
	from tbl b,Mas_AccCode c
	where substring(b.AccCode,1,1) in('4','5')
	and c.AccCode=dbo.GetAccConfig('GL_CONFIG','ProfitLoss')
	group by c.AccCode,c.AccName
) s
where AccCode is not null
order by AccCode
end

GO
/****** Object:  StoredProcedure [dbo].[GetBalanceSheetCompare]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GetBalanceSheetCompare]
(
@currentyear int,
@usemaincode int=0
)
as
begin
declare @firstday date=DATEFROMPARTS(@currentyear, 1, 1);
declare @lastyear date=DATEADD(day,-1,@firstday); 

if @usemaincode=0
begin
    select * from (
        select c.AccCode,c.AccName,
        isnull(a.Debit,0) as CurrentDR,isnull(a.Credit,0) as CurrentCR,
        isnull(a.Debit,0)-isnull(b.Debit,0) as ChangeDR,isnull(a.Credit,0)-isnull(b.Credit,0) as ChangeCR,
        isnull(b.Debit,0) as LastDR,isnull(b.Credit,0) as LastCr
        from vMas_AccCode c left join
        (
            select AccCode,AccName,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=@currentyear
            group by AccCode,AccName    
        ) a
        on c.AccCode=a.AccCode 
        left join
        (
            select AccCode,AccName,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=YEAR(@lastyear) 
            group by AccCode,AccName    
        ) b
        on c.AccCode=b.AccCode 
    ) t 
    where not (CurrentDR+CurrentCR+LastDR+LastCR+ChangeDR+ChangeCR)=0
end
else
begin
    declare @pos int=2;
    declare @fmt varchar(10)='00-00';
    if @usemaincode=2
    begin
        set @pos=3;
        set @fmt='0-00';
    end
        
    if @usemaincode=3
    begin
        set @pos=4;
        set @fmt='-00';
    end

    select * from (
        select c.AccCode,c.AccName,
        isnull(a.Debit,0) as CurrentDR,isnull(a.Credit,0) as CurrentCR,
        isnull(a.Debit,0)-isnull(b.Debit,0) as ChangeDR,isnull(a.Credit,0)-isnull(b.Credit,0) as ChangeCR,
        isnull(b.Debit,0) as LastDR,isnull(b.Credit,0) as LastCr
        from vMas_AccCode c left join
        (
            select concat(substring(AccCode,1,@pos),@fmt) as AccCode,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=@currentyear
            group by concat(substring(AccCode,1,@pos),@fmt)
        ) a
        on c.AccCode=a.AccCode 
        left join
        (
            select concat(substring(AccCode,1,@pos),@fmt) as AccCode,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=YEAR(@lastyear) 
            group by concat(substring(AccCode,1,@pos),@fmt)    
        ) b
        on c.AccCode=b.AccCode 
    ) t 
    where not (CurrentDR+CurrentCR+LastDR+LastCR+ChangeDR+ChangeCR)=0
end
end

GO
/****** Object:  StoredProcedure [dbo].[GetBalanceSheetCompare_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[GetBalanceSheetCompare_V2]
(
@currentyear int,
@usemaincode int=0
)
as
begin
declare @firstday date=DATEFROMPARTS(@currentyear, 1, 1);
declare @lastyear date=DATEADD(day,-1,@firstday); 

if @usemaincode=0
begin
    select * from (
        select c.AccCode,c.AccName,
        isnull(a.Debit,0) as CurrentDR,isnull(a.Credit,0) as CurrentCR,
        isnull(a.Debit,0)-isnull(b.Debit,0) as ChangeDR,isnull(a.Credit,0)-isnull(b.Credit,0) as ChangeCR,
        isnull(b.Debit,0) as LastDR,isnull(b.Credit,0) as LastCr
        from vMas_AccCode c left join
        (
            select AccCode,AccName,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=@currentyear
            group by AccCode,AccName    
        ) a
        on c.AccCode=a.AccCode 
        left join
        (
            select AccCode,AccName,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=YEAR(@lastyear) 
            group by AccCode,AccName    
        ) b
        on c.AccCode=b.AccCode 
    ) t 
    where not (CurrentDR+CurrentCR+LastDR+LastCR+ChangeDR+ChangeCR)=0
end
else
begin
    declare @pos int=2;
    declare @fmt varchar(10)='00-00';
    if @usemaincode=2
    begin
        set @pos=3;
        set @fmt='0-00';
    end
        
    if @usemaincode=3
    begin
        set @pos=4;
        set @fmt='-00';
    end

    select * from (
        select c.AccCode,c.AccName,
        isnull(a.Debit,0) as CurrentDR,isnull(a.Credit,0) as CurrentCR,
        isnull(a.Debit,0)-isnull(b.Debit,0) as ChangeDR,isnull(a.Credit,0)-isnull(b.Credit,0) as ChangeCR,
        isnull(b.Debit,0) as LastDR,isnull(b.Credit,0) as LastCr
        from vMas_AccCode c left join
        (
            select concat(substring(AccCode,1,@pos),@fmt) as AccCode,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=@currentyear
            group by concat(substring(AccCode,1,@pos),@fmt)
        ) a
        on c.AccCode=a.AccCode 
        left join
        (
            select concat(substring(AccCode,1,@pos),@fmt) as AccCode,
            case when sum(Debit)>=sum(Credit) then sum(Debit)-sum(Credit) else 0 end as Debit,
            case when sum(Debit)<sum(Credit) then sum(Credit)-sum(Debit) else 0 end as Credit 
            from vBalanceSheet where Period<=YEAR(@lastyear) 
            group by concat(substring(AccCode,1,@pos),@fmt)    
        ) b
        on c.AccCode=b.AccCode 
    ) t 
    where not (CurrentDR+CurrentCR+LastDR+LastCR+ChangeDR+ChangeCR)=0
end
end

GO
/****** Object:  StoredProcedure [dbo].[GetCashFlow]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[GetCashFlow]
(
@currentyear int,
@cashacccode varchar(20)='1112-01'
)
as
begin
with tb
as (
	select AccCode,AccName,Year(EntryDate) as period,CashType,AccDesc,sum(CashAmount) as TotalCash from (
	select EntryDate,[Description] as AccDesc,
	AccCode,AccName,AccMainCodename,
	(case when Credit>0 then 'OUT' else 'IN' END) as CashType,
	(case when Credit>0 then Credit*-1 else Debit end) as CashAmount 
	from vJournal_All where AccCode=@cashacccode
	) t 
	group by AccCode,AccName,Year(EntryDate),AccDesc,CashType
)
select 0 as lvl,AccCode,AccName,
'+' as CashType,'Begining Balance' as AccDesc,
sum(TotalCash) as CashIn,0 as CashOut
from tb
where Period<@currentyear
group by AccCode,AccName
union all
select 1 as lvl,AccCode,AccName,
'+' as CashType,AccDesc,
sum(TotalCash) as CashIn,0 as CashOut
from tb
where Period=@currentyear and TotalCash>0
group by AccCode,AccName,AccDesc
union all
select 1 as lvl,AccCode,AccName,
'-' as CashType,AccDesc,0 as CashIn,
sum(TotalCash*-1) as CashOut
from tb
where Period=@currentyear and TotalCash<0
group by AccCode,AccName,AccDesc
union all
select 2 as lvl,AccCode,AccName,
'+' as CashType,'Total',
sum(case when TotalCash>0 then TotalCash else 0 end) as CashIn,
sum(case when TotalCash<0 then TotalCash*-1 else 0 end) as CashOut
from tb
where Period=@currentyear
group by AccCode,AccName
union all
select 3 as lvl,AccCode,AccName,
'+' as CashType,'Cash Balance',
case when sum(TotalCash)>0 then sum(TotalCash) else 0 end as CashIn,
case when sum(TotalCash)<0 then sum(TotalCash*-1) else 0 end as CashOut
from tb
where Period=@currentyear
group by AccCode,AccName
union all
select 4 as lvl,AccCode,AccName,
'+' as CashType,'Forward Balance',
case when sum(TotalCash)>0 then sum(TotalCash) else 0 end as CashIn,
case when sum(TotalCash)<0 then sum(TotalCash*-1) else 0 end as CashOut
from tb
where Period<=@currentyear
group by AccCode,AccName
end


GO
/****** Object:  StoredProcedure [dbo].[GetCashFlow_ByDate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[GetCashFlow_ByDate]
(
@datefrom date,
@dateto date,
@cashacccode varchar(20)='1112-01'
)
as
begin
with tb
as (
	select AccCode,AccName,Year(EntryDate) as period,EntryDate,CashType,AccDesc,
	sum(CASE WHEN EntryDate<@datefrom then CashAmount else 0 end) as TotalBefore, 
	sum(CASE WHEN EntryDate>=@datefrom then CashAmount else 0 end) as TotalCash, 
	sum(CashAmount) as TotalForward
	from (
		select EntryDate,Concat(FORMAT(EntryDate,'dd/MM/yyyy'),' #',JournalNo,' - ',[Description]) as AccDesc,
		AccCode,AccName,AccMainCodename,
		(case when Credit>0 then 'OUT' else 'IN' END) as CashType,
		convert(decimal(10,2),case when Credit>0 then Credit*-1 else Debit end) as CashAmount 
		from vJournal_All where AccCode=@cashacccode	
		and EntryDate<=@dateto
	) t 
	group by AccCode,AccName,Year(EntryDate),EntryDate,AccDesc,CashType
)
select 0 as lvl,AccCode,AccName,
'+' as CashType,'Begining Balance' as AccDesc,
sum(TotalBefore) as CashIn,0 as CashOut
from tb
group by AccCode,AccName
union all
select 1 as lvl,AccCode,AccName,
(case when TotalCash<0 then '-' else '+' end) as CashType,AccDesc,
case when TotalCash<0 then 0 else TotalCash end as CashIn,
case when TotalCash<0 then TotalCash*-1 else 0 end as CashOut
from tb
where TotalBefore=0
union all
select 2 as lvl,AccCode,AccName,
'+' as CashType,'Total',
sum(case when TotalCash>0 then TotalCash else 0 end) as CashIn,
sum(case when TotalCash<0 then TotalCash*-1 else 0 end) as CashOut
from tb
group by AccCode,AccName
union all
select 3 as lvl,AccCode,AccName,
'+' as CashType,'Cash Balance',
case when sum(TotalCash)>0 then sum(TotalCash) else 0 end as CashIn,
case when sum(TotalCash)<0 then sum(TotalCash*-1) else 0 end as CashOut
from tb
group by AccCode,AccName
union all
select 4 as lvl,
'+' as CashType,'Forward Balance',AccCode,AccName,
case when sum(TotalCash+TotalBefore)>0 then sum(TotalCash+TotalBefore) else 0 end as CashIn,
case when sum(TotalCash+TotalBefore)<0 then sum(TotalCash+TotalBefore)*-1 else 0 end as CashOut
from tb
group by AccCode,AccName
end


GO
/****** Object:  StoredProcedure [dbo].[GetGLTemplate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GetGLTemplate]
(
	@configid int,
	@accdocno varchar(20)
)
as
begin
select t.AccDocNo as JournalNo,t.AccBatchDate as JournalDate, 
t.PartyTaxCode,t.PartyName,t.AccCode,t.AccName,
round(t.Debit,2) as Dr,
round(t.Credit,2) as Cr
from (
	select b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,
	a.AccFilter as AccCode,a.AccDesc as AccName,
	sum(case when a.AccSide='D' then b.DNetAmt+b.DWhtAmt else 0 end) as Debit, 
	sum(case when a.AccSide='C' then b.DNetAmt+b.DWhtAmt else 0 end) as Credit
	from vMas_DocConfigStandard a,
	vTransaction_All b
	where a.Category=b.AccDocType and a.AccFormula='Amount'
	and b.AccDocNo=@accdocno
	group by b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter,a.AccDesc
	union all
	select b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,c.ConfigValue,c.AccNAme,
	sum(case when a.AccSide='D' then b.DVatAmt else 0 end) as Debit, 
	sum(case when a.AccSide='C' then b.DVatAmt else 0 end) as Credit
	from vMas_DocConfigStandard a,
	vTransaction_All b,vMas_AccConfigCode c 
	where a.Category=b.AccDocType and a.AccFormula='VatAmount'
	and c.ConfigKey=a.AccConfigCode
	and b.AccDocNo=@accdocno and b.DVatAmt>0
	group by b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,c.ConfigValue,c.AccNAme
	union all
	select b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter as AccCode,a.AccDesc as AccName,
	sum(case when a.AccSide='D' then b.Amount+b.DVatAmt else 0 end) as Debit, 
	sum(case when a.AccSide='C' then b.Amount+b.DVatAmt else 0 end) as Credit
	from vMas_DocConfigStandard a,
	vTransaction_All b
	where a.Category=b.AccDocType and a.AccFormula='Amount+VatAmount'
	and b.AccDocNo=@accdocno
	group by b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter,a.AccDesc
	union all
	select b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter as AccCode,a.AccDesc as AccName,
	sum(case when a.AccSide='D' then b.DNetAmt else 0 end) as Debit, 
	sum(case when a.AccSide='C' then b.DNetAmt else 0 end) as Credit
	from vMas_DocConfigStandard a,
	vTransaction_All b
	where a.Category=b.AccDocType and a.AccFormula='NetAmount'
	and b.AccDocNo=@accdocno 
	group by b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter,a.AccDesc
	union all
	select b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter as AccCode,a.AccDesc as AccName,
	sum(case when a.AccSide='D' then b.DWhtAmt else 0 end) as Debit, 
	sum(case when a.AccSide='C' then b.DWhtAmt else 0 end) as Credit
	from vMas_DocConfigStandard a,
	vTransaction_All b
	where a.Category=b.AccDocType and a.AccFormula='WhtAmount'
	and b.AccDocNo=@accdocno and b.DWhtAmt>0
	group by b.AccDocNo,b.AccBatchDate,b.PartyTaxCode,b.PartyName,a.AccFilter,a.AccDesc
) t
end

GO
/****** Object:  StoredProcedure [dbo].[GetReceiptAPFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetReceiptAPFromJob]
as
begin
with src as (
SELECT 
rd.ReceiptNo,rh.ReceiptDate,
cd.LinkBillNo,
cd.AdvNO,isnull(pm.DocNo,'') as PayNO,
sum(case when id.AmtCharge>0 then rd.Amt else 0 end) as AmtCharge,
sum(case when id.AmtCharge>0 then rd.AmtVat else 0 end) as AmtChargeVAT,
sum(case when id.AmtCharge>0 and rd.Rate50Tavi=1 then rd.Amt50Tavi else 0 end) as AmtChargeWHT1,
sum(case when id.AmtCharge>0 and rd.Rate50Tavi<>1 then rd.Amt50Tavi else 0 end) as AmtChargeWHT3,
sum(case when id.AmtAdvance>0 then rd.Amt else 0 end) as AmtAdvance,
sum(case when id.AmtAdvance>0 then rd.AmtVat else 0 end) as AmtAdvaceVAT,
sum(case when id.AmtAdvance>0 and rd.Rate50Tavi=1 then rd.Amt50Tavi else 0 end) as AmtAdvanceWHT1,
sum(case when id.AmtAdvance>0 and rd.Rate50Tavi<>1 then rd.Amt50Tavi else 0 end) as AmtAdvanceWHT3
FROM [job_3x].dbo.Job_ReceiptDetail rd
inner join [job_3x].dbo.Job_ReceiptHeader rh
on rd.ReceiptNo=rh.ReceiptNo
inner join [job_3x].dbo.Job_ClearDetail cd
on rd.BranchCode=cd.BranchCode
and rd.InvoiceNo=cd.Linkbillno 
and rd.InvoiceItemNo=cd.LinkItem 
left join [job_3x].dbo.Job_PaymentDetail pm 
on cd.VenderBillingNo=concat(pm.DocNo,'#',pm.ItemNo)
inner join [job_3x].dbo.Job_InvoiceDetail id 
on rd.BranchCode=id.BranchCode 
and rd.InvoiceNo=id.DocNo
and rd.InvoiceItemNo =id.ItemNo 
inner join [job_3x].dbo.Job_InvoiceHeader ih 
on rd.BranchCode=ih.BranchCode 
and rd.InvoiceNo=ih.DocNo
inner join vMas_Product p on cd.SICode=p.ProductCode 
where not isnull(rh.CancelProve,'')<>''
group by rd.ReceiptNo,rh.ReceiptDate,cd.AdvNO,cd.LinkBillNo,pm.DocNo
)
select * from src where AmtAdvance >0 and ((AdvNO ='' and PayNO='')  or PayNO<>'')
end

GO
/****** Object:  StoredProcedure [dbo].[GetRefundFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetRefundFromJob]
AS
BEGIN
select a.AccCode,a.AccName,sum(d.UsedAmount+d.ChargeVAT) as Dr,0 as Cr 
from [job_3x].dbo.Job_ClearDetail d 
inner join [job_3x].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo 
inner join dbo.vMas_Product p 
on d.SICode=p.ProductCode,
dbo.vMas_AccCode a
where h.DocStatus<>99 and d.BNet=0 
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
group by a.AccCode,a.AccName
union all
select a.AccCode,a.AccName,0 as Dr,sum(d.UsedAmount+d.ChargeVAT) as Cr 
from [job_3x].dbo.Job_ClearDetail d 
inner join [job_3x].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo 
inner join dbo.vMas_Product p 
on d.SICode=p.ProductCode,
dbo.vMas_AccCode a
where h.DocStatus<>99 and d.BNet=0 
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
group by a.AccCode,a.AccName
end

GO
/****** Object:  StoredProcedure [dbo].[GetStockCard]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GetStockCard]
(
@datefrom date,
@dateto date,
@prodcode varchar(20),
@acccode varchar(20)=''
)
as
begin
with src
as (
	select TransID,AssetAccCode,AssetAccName,ProductName,StockProductCode,AccDocNo,AccBatchDate,
	PartyTaxCode,PartyName,UnitStock,TransQty,TransPrice,TransAmount,
	(case when QtyIN>0 then QTYIn else 0 end) as QtyIN,
	(case when QtyIN>0 then TransPrice else 0 end) as PriceIN,
	(case when QtyIN>0 then TransAmount else 0 end) as AmountIN,
	(case when QtyOUT>0 then QTYOUT else 0 end) as QtyOUT,
	(case when QtyOUT>0 then TransPrice else 0 end) as PriceOUT,
	(case when QtyOUT>0 then TransAmount else 0 end) as AmountOUT,
	SUM(TransQty) OVER(PARTITION BY StockProductCode ORDER BY StockProductCode,AccBatchDate,TransID) as QTYBal,
	AVG(TransPrice) OVER(PARTITION BY StockProductCode ORDER BY StockProductCode,AccBatchDate,TransID) as AVGPrice,
	SUM(TransAmount) OVER(PARTITION BY StockProductCode ORDER BY StockProductCode,AccBatchDate,TransID) as TotalBal
	from vStock_Card
	where StockProductCode like @prodcode+'%'
	and AccBatchDate<=@dateto
)
select * into #tmpstock 
from src where AssetAccCode like @acccode+'%'
order by StockProductCode,AccBatchDate,TransID;

declare @lastid int=-1;

select top 1 @lastid=TransId
from #tmpstock where AccBatchDate<@datefrom order by AccBatchDate DESC

select 0 as TransID,AssetAccCode,AssetAccName,ProductName,StockProductCode,
'Balance' as AccDocNo,AccBatchDate,'' as PartyTaxCode,'' as PartyName,
UnitStock,0 as TransQty,0 as TransPrice,0 as TransAmount,
0 as QtyIN,0 as PriceIn,0 as AmountIn,
0 as QtyOut,0 as PriceOut,0 as QtyOut,QtyBal,AVGPrice,TotalBal
from #tmpstock where TransID=@lastid 
union all
select * from #tmpstock
where AccBatchDate>=@datefrom;

drop table #tmpstock;
end

GO
/****** Object:  StoredProcedure [dbo].[GetWorkSheet_ByHeader]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetWorkSheet_ByHeader]
(
	@datefrom date,
	@dateto date,
	@header varchar(10),
	@reporttype int=2 --0=compare,1=balance,2=accumulate
)
as
begin
with tb as (
	select s.FiscalYear as Period,s.AccCode,s.AccName,
	isnull((select sum(Dr) from vTrial_Balance where AccCode=s.AccCode and Period<s.FisCalYear),0) as BalDr,
	isnull((select sum(Cr) from vTrial_Balance where AccCode=s.AccCode and Period<s.FisCalYear),0) as BalCr,
	isnull(t.Dr_Jan,0) as Dr_Jan,isnull(t.Cr_Jan,0) as Cr_Jan,
	isnull(t.Dr_Feb,0) as Dr_Feb,isnull(t.Cr_Feb,0) as Cr_Feb,
	isnull(t.Dr_Mar,0) as Dr_Mar,isnull(t.Cr_Mar,0) as Cr_Mar,
	isnull(t.Dr_Apr,0) as Dr_Apr,isnull(t.Cr_Apr,0) as Cr_Apr,
	isnull(t.Dr_May,0) as Dr_May,isnull(t.Cr_May,0) as Cr_May,
	isnull(t.Dr_Jun,0) as Dr_Jun,isnull(t.Cr_Jun,0) as Cr_Jun,
	isnull(t.Dr_Jul,0) as Dr_Jul,isnull(t.Cr_Jul,0) as Cr_Jul,
	isnull(t.Dr_Aug,0) as Dr_Aug,isnull(t.Cr_Aug,0) as Cr_Aug,
	isnull(t.Dr_Sep,0) as Dr_Sep,isnull(t.Cr_Sep,0) as Cr_Sep,
	isnull(t.Dr_Oct,0) as Dr_Oct,isnull(t.Cr_Oct,0) as Cr_Oct,
	isnull(t.Dr_Nov,0) as Dr_Nov,isnull(t.Cr_Nov,0) as Cr_Nov,
	isnull(t.Dr_Dec,0) as Dr_Dec,isnull(t.Cr_Dec,0) as Cr_Dec,
	isnull(t.TotalDr,0) as TotalDr,isnull(t.TotalCr,0) as TotalCr
	from vMas_AccountSheet s
	inner join
	(
		select year(a.EntryDate) as Period,c.AccCode,c.AccName,
		sum(case when Month(a.EntryDate)=1 then b.Debit else 0 end) as Dr_Jan,sum(case when Month(a.EntryDate)=1 then b.Credit else 0 end) as Cr_Jan,
		sum(case when Month(a.EntryDate)=2 then b.Debit else 0 end) as Dr_Feb,sum(case when Month(a.EntryDate)=2 then b.Credit else 0 end) as Cr_Feb,
		sum(case when Month(a.EntryDate)=3 then b.Debit else 0 end) as Dr_Mar,sum(case when Month(a.EntryDate)=3 then b.Credit else 0 end) as Cr_Mar,
		sum(case when Month(a.EntryDate)=4 then b.Debit else 0 end) as Dr_Apr,sum(case when Month(a.EntryDate)=4 then b.Credit else 0 end) as Cr_Apr,
		sum(case when Month(a.EntryDate)=5 then b.Debit else 0 end) as Dr_May,sum(case when Month(a.EntryDate)=5 then b.Credit else 0 end) as Cr_May,
		sum(case when Month(a.EntryDate)=6 then b.Debit else 0 end) as Dr_Jun,sum(case when Month(a.EntryDate)=6 then b.Credit else 0 end) as Cr_Jun,
		sum(case when Month(a.EntryDate)=7 then b.Debit else 0 end) as Dr_Jul,sum(case when Month(a.EntryDate)=7 then b.Credit else 0 end) as Cr_Jul,
		sum(case when Month(a.EntryDate)=8 then b.Debit else 0 end) as Dr_Aug,sum(case when Month(a.EntryDate)=8 then b.Credit else 0 end) as Cr_Aug,
		sum(case when Month(a.EntryDate)=9 then b.Debit else 0 end) as Dr_Sep,sum(case when Month(a.EntryDate)=9 then b.Credit else 0 end) as Cr_Sep,
		sum(case when Month(a.EntryDate)=10 then b.Debit else 0 end) as Dr_Oct,sum(case when Month(a.EntryDate)=10 then b.Credit else 0 end) as Cr_Oct,
		sum(case when Month(a.EntryDate)=11 then b.Debit else 0 end) as Dr_Nov,sum(case when Month(a.EntryDate)=11 then b.Credit else 0 end) as Cr_Nov,
		sum(case when Month(a.EntryDate)=12 then b.Debit else 0 end) as Dr_Dec,sum(case when Month(a.EntryDate)=12 then b.Credit else 0 end) as Cr_Dec,
		sum(b.Debit) as TotalDr,sum(b.Credit) as TotalCr 
		from Acc_JournalHD a inner join Acc_JournalDT b on a.EntryId=b.EntryId
		left join Mas_AccCode c on b.AccCode=c.AccCode
		left join Mas_AccCode d on c.AccMainCode=d.AccCode
		where a.JournalNo like @header+'%'
		and a.EntryDate>=@datefrom and a.EntryDate<=@dateto
		group by year(a.EntryDate),c.AccCode,c.AccName
	) t on
	s.FiscalYear=t.Period and s.AccCode=t.AccCode 
)
select * into #tmptb from tb

select * into #tmptb2 
from (
	select t.Period,t.AccCode,t.AccName,
	isnull((case when t.BalDr>=t.BalCr then t.BalDr-t.BalCr else 0 END),0) as BalDr,
	isnull((case when t.BalDr<t.BalCr then t.BalCr-t.BalDr else 0 END),0) as BalCr,
	isnull((case when t.Dr_Jan>=t.Cr_Jan then t.Dr_Jan-t.Cr_Jan else 0 END),0) as Dr_Jan,
	isnull((case when t.Dr_Jan<t.Cr_Jan then t.Cr_Jan-t.Dr_Jan else 0 END),0) as Cr_Jan,
	isnull((case when t.Dr_Feb>=t.Cr_Feb then t.Dr_Feb-t.Cr_Feb else 0 END),0) as Dr_Feb,
	isnull((case when t.Dr_Feb<t.Cr_Feb then t.Cr_Feb-t.Dr_Feb else 0 END),0) as Cr_Feb,
	isnull((case when t.Dr_Mar>=t.Cr_Mar then t.Dr_Mar-t.Cr_Mar else 0 END),0) as Dr_Mar,
	isnull((case when t.Dr_Mar<t.Cr_Mar then t.Cr_Mar-t.Dr_Mar else 0 END),0) as Cr_Mar,
	isnull((case when t.Dr_Apr>=t.Cr_Apr then t.Dr_Apr-t.Cr_Apr else 0 END),0) as Dr_Apr,
	isnull((case when t.Dr_Apr<t.Cr_Apr then t.Cr_Apr-t.Dr_Apr else 0 END),0) as Cr_Apr,
	isnull((case when t.Dr_May>=t.Cr_May then t.Dr_May-t.Cr_May else 0 END),0) as Dr_May,
	isnull((case when t.Dr_May<t.Cr_May then t.Cr_May-t.Dr_May else 0 END),0) as Cr_May,
	isnull((case when t.Dr_Jun>=t.Cr_Jun then t.Dr_Jun-t.Cr_Jun else 0 END),0) as Dr_Jun,
	isnull((case when t.Dr_Jun<t.Cr_Jun then t.Cr_Jun-t.Dr_Jun else 0 END),0) as Cr_Jun,
	isnull((case when t.Dr_Jul>=t.Cr_Jul then t.Dr_Jul-t.Cr_Jul else 0 END),0) as Dr_Jul,
	isnull((case when t.Dr_Jul<t.Cr_Jul then t.Cr_Jul-t.Dr_Jul else 0 END),0) as Cr_Jul,
	isnull((case when t.Dr_Aug>=t.Cr_Aug then t.Dr_Aug-t.Cr_Aug else 0 END),0) as Dr_Aug,
	isnull((case when t.Dr_Aug<t.Cr_Aug then t.Cr_Aug-t.Dr_Aug else 0 END),0) as Cr_Aug,
	isnull((case when t.Dr_Sep>=t.Cr_Sep then t.Dr_Sep-t.Cr_Sep else 0 END),0) as Dr_Sep,
	isnull((case when t.Dr_Sep<t.Cr_Sep then t.Cr_Sep-t.Dr_Sep else 0 END),0) as Cr_Sep,
	isnull((case when t.Dr_Oct>=t.Cr_Oct then t.Dr_Oct-t.Cr_Oct else 0 END),0) as Dr_Oct,
	isnull((case when t.Dr_Oct<t.Cr_Oct then t.Cr_Oct-t.Dr_Oct else 0 END),0) as Cr_Oct,
	isnull((case when t.Dr_Nov>=t.Cr_Nov then t.Dr_Nov-t.Cr_Nov else 0 END),0) as Dr_Nov,
	isnull((case when t.Dr_Nov<t.Cr_Nov then t.Cr_Nov-t.Dr_Nov else 0 END),0) as Cr_Nov,
	isnull((case when t.Dr_Dec>=t.Cr_Dec then t.Dr_Dec-t.Cr_Dec else 0 END),0) as Dr_Dec,
	isnull((case when t.Dr_Dec<t.Cr_Dec then t.Cr_Dec-t.Dr_Dec else 0 END),0) as Cr_Dec,
	isnull((case when t.TotalDr>=t.TotalCr then t.TotalDr-t.TotalCr else 0 END),0) as TotalDr,
	isnull((case when t.totalDr<t.TotalCr then t.TotalCr-t.TotalDr else 0 END),0) as TotalCr
	from #tmptb t
) t1 

select * into #tmptb3 from (
	select Period,AccCode,AccName,
	BalDr,BalCr,
	(case when Dr_Jan>=Cr_Jan then Dr_Jan-Cr_Jan else 0 end) as Dr_Jan,
	(case when Dr_Jan<Cr_Jan then Cr_Jan-Dr_Jan else 0 end) as Cr_Jan,
	(case when Dr_Feb>=Cr_Feb then Dr_Feb-Cr_Feb else 0 end) as Dr_Feb,
	(case when Dr_Feb<Cr_Feb then Cr_Feb-Dr_Feb else 0 end) as Cr_Feb,
	(case when Dr_Mar>=Cr_Mar then Dr_Mar-Cr_Mar else 0 end) as Dr_Mar,
	(case when Dr_Mar<Cr_Mar then Cr_Mar-Dr_Mar else 0 end) as Cr_Mar,
	(case when Dr_Apr>=Cr_Apr then Dr_Apr-Cr_Apr else 0 end) as Dr_Apr,
	(case when Dr_Apr<Cr_Apr then Cr_Apr-Dr_Apr else 0 end) as Cr_Apr,
	(case when Dr_May>=Cr_May then Dr_May-Cr_May else 0 end) as Dr_May,
	(case when Dr_May<Cr_May then Cr_May-Dr_May else 0 end) as Cr_May,
	(case when Dr_Jun>=Cr_Jun then Dr_Jun-Cr_Jun else 0 end) as Dr_Jun,
	(case when Dr_Jun<Cr_Jun then Cr_Jun-Dr_Jun else 0 end) as Cr_Jun,
	(case when Dr_Jul>=Cr_Jul then Dr_Jul-Cr_Jul else 0 end) as Dr_Jul,
	(case when Dr_Jul<Cr_Jul then Cr_Jul-Dr_Jul else 0 end) as Cr_Jul,
	(case when Dr_Aug>=Cr_Aug then Dr_Aug-Cr_Aug else 0 end) as Dr_Aug,
	(case when Dr_Aug<Cr_Aug then Cr_Aug-Dr_Aug else 0 end) as Cr_Aug,
	(case when Dr_Sep>=Cr_Sep then Dr_Sep-Cr_Sep else 0 end) as Dr_Sep,
	(case when Dr_Sep<Cr_Sep then Cr_Sep-Dr_Sep else 0 end) as Cr_Sep,
	(case when Dr_Oct>=Cr_Oct then Dr_Oct-Cr_Oct else 0 end) as Dr_Oct,
	(case when Dr_Oct<Cr_Oct then Cr_Oct-Dr_Oct else 0 end) as Cr_Oct,
	(case when Dr_Nov>=Cr_Nov then Dr_Nov-Cr_Nov else 0 end) as Dr_Nov,
	(case when Dr_Nov<Cr_Nov then Cr_Nov-Dr_Nov else 0 end) as Cr_Nov,
	(case when Dr_Dec>=Cr_Dec then Dr_Dec-Cr_Dec else 0 end) as Dr_Dec,
	(case when Dr_Dec<Cr_Dec then Cr_Dec-Dr_Dec else 0 end) as Cr_Dec
	from (
		select 
		Period,AccCode,AccName,
		BalDr,BalCr,
		BalDr+Dr_Jan as Dr_Jan,
		BalDr+Dr_Jan+Dr_Feb as Dr_Feb,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar as Dr_Mar,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr as Dr_Apr,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May as Dr_May,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun as Dr_Jun,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul as Dr_Jul,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug as Dr_Aug,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep as Dr_Sep,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct as Dr_Oct,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct+Dr_Nov as Dr_Nov,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct+Dr_Nov+Dr_Dec as Dr_Dec,
		BalCr+Cr_Jan as Cr_Jan,
		BalCr+Cr_Jan+Cr_Feb as Cr_Feb,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar as Cr_Mar,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr as Cr_Apr,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May as Cr_May,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun as Cr_Jun,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul as Cr_Jul,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug as Cr_Aug,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep as Cr_Sep,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct as Cr_Oct,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct+Cr_Nov as Cr_Nov,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct+Cr_Nov+Cr_Dec as Cr_Dec
		from #tmptb2
	) t
) t2

if @reporttype=2
begin
	select 
	Period,AccCode,AccName,
	BalDr,BalCr,Dr1,Cr1,Dr_Jan,Cr_Jan,
	Dr2,Cr2,Dr_Feb,Cr_Feb,
	Dr3,Cr3,Dr_Mar,Cr_Mar,
	Dr4,Cr4,Dr_Apr,Cr_Apr,
	Dr5,Cr5,Dr_May,Cr_May,
	Dr6,Cr6,Dr_Jun,Cr_Jun,
	Dr7,Cr7,Dr_Jul,Cr_Jul,
	Dr8,Cr8,Dr_Aug,Cr_Aug,
	Dr9,Cr9,Dr_Sep,Cr_Sep,
	Dr10,Cr10,Dr_Oct,Cr_Oct,
	Dr11,Cr11,Dr_Nov,Cr_Nov,
	Dr12,Cr12,Dr_Dec,Cr_Dec
	from (
		select a.*,
		b.Dr_Jan as Dr1, 
		b.Cr_Jan as Cr1, 
		b.Dr_Feb as Dr2, 
		b.Cr_Feb as Cr2, 
		b.Dr_Mar as Dr3, 
		b.Cr_Mar as Cr3, 
		b.Dr_Apr as Dr4, 
		b.Cr_Apr as Cr4, 
		b.Dr_May as Dr5, 
		b.Cr_May as Cr5, 
		b.Dr_Jun as Dr6, 
		b.Cr_Jun as Cr6, 
		b.Dr_Jul as Dr7, 
		b.Cr_Jul as Cr7, 
		b.Dr_Aug as Dr8, 
		b.Cr_Aug as Cr8, 
		b.Dr_Sep as Dr9, 
		b.Cr_Sep as Cr9, 
		b.Dr_Oct as Dr10, 
		b.Cr_Oct as Cr10, 
		b.Dr_Nov as Dr11, 
		b.Cr_Nov as Cr11, 
		b.Dr_Dec as Dr12, 
		b.Cr_Dec as Cr12
		from #tmptb3 a
		inner join #tmptb2 b
		on a.Period=b.Period and a.AccCode=b.AccCode
	) t
end 

if @reporttype=1
begin
	select * from #tmptb2
end

if @reporttype=0
begin
	select * from #tmptb
end

drop table #tmptb3
drop table #tmptb2
drop table #tmptb 
end

GO
/****** Object:  StoredProcedure [dbo].[GetWorkSheet_ByHeader_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GetWorkSheet_ByHeader_V2]
(
	@period int,
	@header varchar(10),
	@reporttype int=2 --0=compare,1=balance,2=accumulate
)
as
begin
with tb as (
	select s.FiscalYear as Period,s.AccCode,s.AccName,
	isnull((select sum(Dr) from vTrial_Balance where AccCode=s.AccCode and Period<s.FisCalYear),0) as BalDr,
	isnull((select sum(Cr) from vTrial_Balance where AccCode=s.AccCode and Period<s.FisCalYear),0) as BalCr,
	isnull(t.Dr_Jan,0) as Dr_Jan,isnull(t.Cr_Jan,0) as Cr_Jan,
	isnull(t.Dr_Feb,0) as Dr_Feb,isnull(t.Cr_Feb,0) as Cr_Feb,
	isnull(t.Dr_Mar,0) as Dr_Mar,isnull(t.Cr_Mar,0) as Cr_Mar,
	isnull(t.Dr_Apr,0) as Dr_Apr,isnull(t.Cr_Apr,0) as Cr_Apr,
	isnull(t.Dr_May,0) as Dr_May,isnull(t.Cr_May,0) as Cr_May,
	isnull(t.Dr_Jun,0) as Dr_Jun,isnull(t.Cr_Jun,0) as Cr_Jun,
	isnull(t.Dr_Jul,0) as Dr_Jul,isnull(t.Cr_Jul,0) as Cr_Jul,
	isnull(t.Dr_Aug,0) as Dr_Aug,isnull(t.Cr_Aug,0) as Cr_Aug,
	isnull(t.Dr_Sep,0) as Dr_Sep,isnull(t.Cr_Sep,0) as Cr_Sep,
	isnull(t.Dr_Oct,0) as Dr_Oct,isnull(t.Cr_Oct,0) as Cr_Oct,
	isnull(t.Dr_Nov,0) as Dr_Nov,isnull(t.Cr_Nov,0) as Cr_Nov,
	isnull(t.Dr_Dec,0) as Dr_Dec,isnull(t.Cr_Dec,0) as Cr_Dec,
	isnull(t.TotalDr,0) as TotalDr,isnull(t.TotalCr,0) as TotalCr
	from vMas_AccountSheet s
	left join
	(
		select year(a.EntryDate) as Period,c.AccCode,c.AccName,
		sum(case when Month(a.EntryDate)=1 then b.Debit else 0 end) as Dr_Jan,sum(case when Month(a.EntryDate)=1 then b.Credit else 0 end) as Cr_Jan,
		sum(case when Month(a.EntryDate)=2 then b.Debit else 0 end) as Dr_Feb,sum(case when Month(a.EntryDate)=2 then b.Credit else 0 end) as Cr_Feb,
		sum(case when Month(a.EntryDate)=3 then b.Debit else 0 end) as Dr_Mar,sum(case when Month(a.EntryDate)=3 then b.Credit else 0 end) as Cr_Mar,
		sum(case when Month(a.EntryDate)=4 then b.Debit else 0 end) as Dr_Apr,sum(case when Month(a.EntryDate)=4 then b.Credit else 0 end) as Cr_Apr,
		sum(case when Month(a.EntryDate)=5 then b.Debit else 0 end) as Dr_May,sum(case when Month(a.EntryDate)=5 then b.Credit else 0 end) as Cr_May,
		sum(case when Month(a.EntryDate)=6 then b.Debit else 0 end) as Dr_Jun,sum(case when Month(a.EntryDate)=6 then b.Credit else 0 end) as Cr_Jun,
		sum(case when Month(a.EntryDate)=7 then b.Debit else 0 end) as Dr_Jul,sum(case when Month(a.EntryDate)=7 then b.Credit else 0 end) as Cr_Jul,
		sum(case when Month(a.EntryDate)=8 then b.Debit else 0 end) as Dr_Aug,sum(case when Month(a.EntryDate)=8 then b.Credit else 0 end) as Cr_Aug,
		sum(case when Month(a.EntryDate)=9 then b.Debit else 0 end) as Dr_Sep,sum(case when Month(a.EntryDate)=9 then b.Credit else 0 end) as Cr_Sep,
		sum(case when Month(a.EntryDate)=10 then b.Debit else 0 end) as Dr_Oct,sum(case when Month(a.EntryDate)=10 then b.Credit else 0 end) as Cr_Oct,
		sum(case when Month(a.EntryDate)=11 then b.Debit else 0 end) as Dr_Nov,sum(case when Month(a.EntryDate)=11 then b.Credit else 0 end) as Cr_Nov,
		sum(case when Month(a.EntryDate)=12 then b.Debit else 0 end) as Dr_Dec,sum(case when Month(a.EntryDate)=12 then b.Credit else 0 end) as Cr_Dec,
		sum(b.Debit) as TotalDr,sum(b.Credit) as TotalCr 
		from Acc_JournalHD a inner join Acc_JournalDT b on a.EntryId=b.EntryId
		left join Mas_AccCode c on b.AccCode=c.AccCode
		left join Mas_AccCode d on c.AccMainCode=d.AccCode
		where a.JournalNo like @header+'%'
		and Year(EntryDate)=@period
		group by year(a.EntryDate),c.AccCode,c.AccName
	) t on
	s.FiscalYear=t.Period and s.AccCode=t.AccCode 
)
select * into #tmptb from tb

select * into #tmptb2 
from (
	select t.Period,t.AccCode,t.AccName,
	isnull((case when t.BalDr>=t.BalCr then t.BalDr-t.BalCr else 0 END),0) as BalDr,
	isnull((case when t.BalDr<t.BalCr then t.BalCr-t.BalDr else 0 END),0) as BalCr,
	isnull((case when t.Dr_Jan>=t.Cr_Jan then t.Dr_Jan-t.Cr_Jan else 0 END),0) as Dr_Jan,
	isnull((case when t.Dr_Jan<t.Cr_Jan then t.Cr_Jan-t.Dr_Jan else 0 END),0) as Cr_Jan,
	isnull((case when t.Dr_Feb>=t.Cr_Feb then t.Dr_Feb-t.Cr_Feb else 0 END),0) as Dr_Feb,
	isnull((case when t.Dr_Feb<t.Cr_Feb then t.Cr_Feb-t.Dr_Feb else 0 END),0) as Cr_Feb,
	isnull((case when t.Dr_Mar>=t.Cr_Mar then t.Dr_Mar-t.Cr_Mar else 0 END),0) as Dr_Mar,
	isnull((case when t.Dr_Mar<t.Cr_Mar then t.Cr_Mar-t.Dr_Mar else 0 END),0) as Cr_Mar,
	isnull((case when t.Dr_Apr>=t.Cr_Apr then t.Dr_Apr-t.Cr_Apr else 0 END),0) as Dr_Apr,
	isnull((case when t.Dr_Apr<t.Cr_Apr then t.Cr_Apr-t.Dr_Apr else 0 END),0) as Cr_Apr,
	isnull((case when t.Dr_May>=t.Cr_May then t.Dr_May-t.Cr_May else 0 END),0) as Dr_May,
	isnull((case when t.Dr_May<t.Cr_May then t.Cr_May-t.Dr_May else 0 END),0) as Cr_May,
	isnull((case when t.Dr_Jun>=t.Cr_Jun then t.Dr_Jun-t.Cr_Jun else 0 END),0) as Dr_Jun,
	isnull((case when t.Dr_Jun<t.Cr_Jun then t.Cr_Jun-t.Dr_Jun else 0 END),0) as Cr_Jun,
	isnull((case when t.Dr_Jul>=t.Cr_Jul then t.Dr_Jul-t.Cr_Jul else 0 END),0) as Dr_Jul,
	isnull((case when t.Dr_Jul<t.Cr_Jul then t.Cr_Jul-t.Dr_Jul else 0 END),0) as Cr_Jul,
	isnull((case when t.Dr_Aug>=t.Cr_Aug then t.Dr_Aug-t.Cr_Aug else 0 END),0) as Dr_Aug,
	isnull((case when t.Dr_Aug<t.Cr_Aug then t.Cr_Aug-t.Dr_Aug else 0 END),0) as Cr_Aug,
	isnull((case when t.Dr_Sep>=t.Cr_Sep then t.Dr_Sep-t.Cr_Sep else 0 END),0) as Dr_Sep,
	isnull((case when t.Dr_Sep<t.Cr_Sep then t.Cr_Sep-t.Dr_Sep else 0 END),0) as Cr_Sep,
	isnull((case when t.Dr_Oct>=t.Cr_Oct then t.Dr_Oct-t.Cr_Oct else 0 END),0) as Dr_Oct,
	isnull((case when t.Dr_Oct<t.Cr_Oct then t.Cr_Oct-t.Dr_Oct else 0 END),0) as Cr_Oct,
	isnull((case when t.Dr_Nov>=t.Cr_Nov then t.Dr_Nov-t.Cr_Nov else 0 END),0) as Dr_Nov,
	isnull((case when t.Dr_Nov<t.Cr_Nov then t.Cr_Nov-t.Dr_Nov else 0 END),0) as Cr_Nov,
	isnull((case when t.Dr_Dec>=t.Cr_Dec then t.Dr_Dec-t.Cr_Dec else 0 END),0) as Dr_Dec,
	isnull((case when t.Dr_Dec<t.Cr_Dec then t.Cr_Dec-t.Dr_Dec else 0 END),0) as Cr_Dec,
	isnull((case when t.TotalDr>=t.TotalCr then t.TotalDr-t.TotalCr else 0 END),0) as TotalDr,
	isnull((case when t.totalDr<t.TotalCr then t.TotalCr-t.TotalDr else 0 END),0) as TotalCr
	from #tmptb t
) t1 

select * into #tmptb3 from (
	select Period,AccCode,AccName,
	BalDr,BalCr,
	(case when Dr_Jan>=Cr_Jan then Dr_Jan-Cr_Jan else 0 end) as Dr_Jan,
	(case when Dr_Jan<Cr_Jan then Cr_Jan-Dr_Jan else 0 end) as Cr_Jan,
	(case when Dr_Feb>=Cr_Feb then Dr_Feb-Cr_Feb else 0 end) as Dr_Feb,
	(case when Dr_Feb<Cr_Feb then Cr_Feb-Dr_Feb else 0 end) as Cr_Feb,
	(case when Dr_Mar>=Cr_Mar then Dr_Mar-Cr_Mar else 0 end) as Dr_Mar,
	(case when Dr_Mar<Cr_Mar then Cr_Mar-Dr_Mar else 0 end) as Cr_Mar,
	(case when Dr_Apr>=Cr_Apr then Dr_Apr-Cr_Apr else 0 end) as Dr_Apr,
	(case when Dr_Apr<Cr_Apr then Cr_Apr-Dr_Apr else 0 end) as Cr_Apr,
	(case when Dr_May>=Cr_May then Dr_May-Cr_May else 0 end) as Dr_May,
	(case when Dr_May<Cr_May then Cr_May-Dr_May else 0 end) as Cr_May,
	(case when Dr_Jun>=Cr_Jun then Dr_Jun-Cr_Jun else 0 end) as Dr_Jun,
	(case when Dr_Jun<Cr_Jun then Cr_Jun-Dr_Jun else 0 end) as Cr_Jun,
	(case when Dr_Jul>=Cr_Jul then Dr_Jul-Cr_Jul else 0 end) as Dr_Jul,
	(case when Dr_Jul<Cr_Jul then Cr_Jul-Dr_Jul else 0 end) as Cr_Jul,
	(case when Dr_Aug>=Cr_Aug then Dr_Aug-Cr_Aug else 0 end) as Dr_Aug,
	(case when Dr_Aug<Cr_Aug then Cr_Aug-Dr_Aug else 0 end) as Cr_Aug,
	(case when Dr_Sep>=Cr_Sep then Dr_Sep-Cr_Sep else 0 end) as Dr_Sep,
	(case when Dr_Sep<Cr_Sep then Cr_Sep-Dr_Sep else 0 end) as Cr_Sep,
	(case when Dr_Oct>=Cr_Oct then Dr_Oct-Cr_Oct else 0 end) as Dr_Oct,
	(case when Dr_Oct<Cr_Oct then Cr_Oct-Dr_Oct else 0 end) as Cr_Oct,
	(case when Dr_Nov>=Cr_Nov then Dr_Nov-Cr_Nov else 0 end) as Dr_Nov,
	(case when Dr_Nov<Cr_Nov then Cr_Nov-Dr_Nov else 0 end) as Cr_Nov,
	(case when Dr_Dec>=Cr_Dec then Dr_Dec-Cr_Dec else 0 end) as Dr_Dec,
	(case when Dr_Dec<Cr_Dec then Cr_Dec-Dr_Dec else 0 end) as Cr_Dec
	from (
		select 
		Period,AccCode,AccName,
		BalDr,BalCr,
		BalDr+Dr_Jan as Dr_Jan,
		BalDr+Dr_Jan+Dr_Feb as Dr_Feb,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar as Dr_Mar,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr as Dr_Apr,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May as Dr_May,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun as Dr_Jun,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul as Dr_Jul,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug as Dr_Aug,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep as Dr_Sep,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct as Dr_Oct,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct+Dr_Nov as Dr_Nov,
		BalDr+Dr_Jan+Dr_Feb+Dr_Mar+Dr_Apr+Dr_May+Dr_Jun+Dr_Jul+Dr_Aug+Dr_Sep+Dr_Oct+Dr_Nov+Dr_Dec as Dr_Dec,
		BalCr+Cr_Jan as Cr_Jan,
		BalCr+Cr_Jan+Cr_Feb as Cr_Feb,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar as Cr_Mar,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr as Cr_Apr,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May as Cr_May,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun as Cr_Jun,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul as Cr_Jul,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug as Cr_Aug,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep as Cr_Sep,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct as Cr_Oct,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct+Cr_Nov as Cr_Nov,
		BalCr+Cr_Jan+Cr_Feb+Cr_Mar+Cr_Apr+Cr_May+Cr_Jun+Cr_Jul+Cr_Aug+Cr_Sep+Cr_Oct+Cr_Nov+Cr_Dec as Cr_Dec
		from #tmptb2
	) t
) t2

if @reporttype=2
begin
	select 
	Period,AccCode,AccName,
	BalDr,BalCr,Dr1,Cr1,Dr_Jan,Cr_Jan,
	Dr2,Cr2,Dr_Feb,Cr_Feb,
	Dr3,Cr3,Dr_Mar,Cr_Mar,
	Dr4,Cr4,Dr_Apr,Cr_Apr,
	Dr5,Cr5,Dr_May,Cr_May,
	Dr6,Cr6,Dr_Jun,Cr_Jun,
	Dr7,Cr7,Dr_Jul,Cr_Jul,
	Dr8,Cr8,Dr_Aug,Cr_Aug,
	Dr9,Cr9,Dr_Sep,Cr_Sep,
	Dr10,Cr10,Dr_Oct,Cr_Oct,
	Dr11,Cr11,Dr_Nov,Cr_Nov,
	Dr12,Cr12,Dr_Dec,Cr_Dec
	from (
		select a.*,
		b.Dr_Jan as Dr1, 
		b.Cr_Jan as Cr1, 
		b.Dr_Feb as Dr2, 
		b.Cr_Feb as Cr2, 
		b.Dr_Mar as Dr3, 
		b.Cr_Mar as Cr3, 
		b.Dr_Apr as Dr4, 
		b.Cr_Apr as Cr4, 
		b.Dr_May as Dr5, 
		b.Cr_May as Cr5, 
		b.Dr_Jun as Dr6, 
		b.Cr_Jun as Cr6, 
		b.Dr_Jul as Dr7, 
		b.Cr_Jul as Cr7, 
		b.Dr_Aug as Dr8, 
		b.Cr_Aug as Cr8, 
		b.Dr_Sep as Dr9, 
		b.Cr_Sep as Cr9, 
		b.Dr_Oct as Dr10, 
		b.Cr_Oct as Cr10, 
		b.Dr_Nov as Dr11, 
		b.Cr_Nov as Cr11, 
		b.Dr_Dec as Dr12, 
		b.Cr_Dec as Cr12
		from #tmptb3 a
		inner join #tmptb2 b
		on a.Period=b.Period and a.AccCode=b.AccCode
	) t
	where (BalDr+BalCr+Dr1+Cr1+Dr_Jan+Cr_Jan+
	Dr2+Cr2+Dr_Feb+Cr_Feb+
	Dr3+Cr3+Dr_Mar+Cr_Mar+
	Dr4+Cr4+Dr_Apr+Cr_Apr+
	Dr5+Cr5+Dr_May+Cr_May+
	Dr6+Cr6+Dr_Jun+Cr_Jun+
	Dr7+Cr7+Dr_Jul+Cr_Jul+
	Dr8+Cr8+Dr_Aug+Cr_Aug+
	Dr9+Cr9+Dr_Sep+Cr_Sep+
	Dr10+Cr10+Dr_Oct+Cr_Oct+
	Dr11+Cr11+Dr_Nov+Cr_Nov+
	Dr12+Cr12+Dr_Dec+Cr_Dec)>0
end 

if @reporttype=1
begin
	select * from #tmptb2 where (BalDr+BalCr+Dr_Jan+Cr_Jan+
	Dr_Feb+Cr_Feb+
	Dr_Mar+Cr_Mar+
	Dr_Apr+Cr_Apr+
	Dr_May+Cr_May+
	Dr_Jun+Cr_Jun+
	Dr_Jul+Cr_Jul+
	Dr_Aug+Cr_Aug+
	Dr_Sep+Cr_Sep+
	Dr_Oct+Cr_Oct+
	Dr_Nov+Cr_Nov+
	Dr_Dec+Cr_Dec+TotalDr+TotalCr)>0
end

if @reporttype=0
begin
	select * from #tmptb where (BalDr+BalCr+Dr_Jan+Cr_Jan+
	Dr_Feb+Cr_Feb+
	Dr_Mar+Cr_Mar+
	Dr_Apr+Cr_Apr+
	Dr_May+Cr_May+
	Dr_Jun+Cr_Jun+
	Dr_Jul+Cr_Jul+
	Dr_Aug+Cr_Aug+
	Dr_Sep+Cr_Sep+
	Dr_Oct+Cr_Oct+
	Dr_Nov+Cr_Nov+
	Dr_Dec+Cr_Dec+TotalDr+TotalCr)>0
end

drop table #tmptb3
drop table #tmptb2
drop table #tmptb 
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_AddDeductPayroll]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[Insert_AddDeductPayroll]
(
@datefrom date,
@dateto date,
@userid varchar(20),
@staffid int,
@paydate date
)
as
begin
declare @holidayPay decimal(10,2)=0
declare @otPay decimal(10,2)=0
declare @latePay decimal(10,2)=0

select @latePay=sum(LateCheckInPay),
@otPay=sum(LateCheckOutPay),
@holidayPay=sum(HolidayPay)
from vHR_WorkTimeDetail 
where CheckInDate>=@datefrom 
and CheckInDate<=@dateto 
and StaffId=@staffid

declare @slipNo varchar(20)=''
declare @sid int=0
declare @item int=0
declare @id int=0

select @sid=Max(SalaryId) from Acc_HRPayRoll where StaffId=@staffid
and PaymentDate=@paydate

if @sid>0
begin
	SET @slipNo=(select SlipNo FROM Acc_HRPayRoll where SalaryId=@sid)
	SET @item=(select MAX(ItemNo)+1 FROM Acc_HRPayRoll where SlipNo=@slipNo)

	if @latePay<0
	begin
		set @id=(SELECT MAX(SalaryId)+1 from Acc_HRPayRoll)

		Insert into Acc_HRPayRoll
		select @id,@slipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,PaymentDate,
		@item,'หัก-ขาดลามาสาย',@latepay,0,ABS(@latePay),'',dbo.GetAccConfig('GL_CONFIG','MiscReceive'),
		0,NULL,'',NULL,'',GETDATE(),@userid
		from Acc_HRPayRoll where SalaryId=@sid
		and not exists(select 1 from Acc_HRPayRoll where SlipNo=@slipNo and AmountPayment=@latePay and AccCodeCredit=dbo.GetAccConfig('GL_CONFIG','MiscReceive'))
	end
	if @otPay>0
	begin
		set @id=(SELECT MAX(SalaryId)+1 from Acc_HRPayRoll)
		SET @item=(select MAX(ItemNo)+1 FROM Acc_HRPayRoll where SlipNo=@slipNo)

		Insert into Acc_HRPayRoll
		select @id,@slipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,PaymentDate,
		@item,'บวก-ค่าล่วงเวลา',@otPay,@otPay,0,dbo.GetAccConfig('GL_CONFIG','OverTime'),'',
		0,NULL,'',NULL,'',GETDATE(),@userid
		from Acc_HRPayRoll where SalaryId=@sid
		and not exists(select 1 from Acc_HRPayRoll where SlipNo=@slipNo and AmountPayment=@otPay and AccCodeDebit=dbo.GetAccConfig('GL_CONFIG','OverTime'))
	end
		
	if @holidayPay>0
	begin
		set @id=(SELECT MAX(SalaryId)+1 from Acc_HRPayRoll)
		SET @item=(select MAX(ItemNo)+1 FROM Acc_HRPayRoll where SlipNo=@slipNo)

		Insert into Acc_HRPayRoll
		select @id,@slipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,PaymentDate,
		@item,'บวก-ค่าแรงวันหยุด',@holidayPay,@holidayPay,0,dbo.GetAccConfig('GL_CONFIG','OverTime'),'',
		0,NULL,'',NULL,'',GETDATE(),@userid
		from Acc_HRPayRoll where SalaryId=@sid
		and not exists(select 1 from Acc_HRPayRoll where SlipNo=@slipNo and AmountPayment=@holidayPay and AccCodeDebit=dbo.GetAccConfig('GL_CONFIG','OverTime'))
	end

	declare @whtamt float=(@holidayPay+@otPay+@latePay)*(cast(isnull(dbo.GetAccConfig('WHT_CONFIG','RateEmp'),0) as decimal(10,2))*0.01)

	if @whtamt>0
	begin
		set @id=(SELECT MAX(SalaryId)+1 from Acc_HRPayRoll)
		SET @item=(select MAX(ItemNo)+1 FROM Acc_HRPayRoll where SlipNo=@slipNo)

		Insert into Acc_HRPayRoll
		select @id,@slipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,PaymentDate,
		@item,'หัก-ภาษีหัก ณ ที่จ่าย',@whtamt*-1,0,@whtamt,'',dbo.GetAccConfig('ADV_CONFIG','TaxEmployee'),
		0,NULL,'',NULL,'',GETDATE(),@userid
		from Acc_HRPayRoll where SalaryId=@sid
		and not exists(select 1 from Acc_HRPayRoll where SlipNo=@slipNo and AmountDeduct=@whtamt and AccCodeCredit=dbo.GetAccConfig('ADV_CONFIG','TaxEmployee'))		
		and exists(select 1 from vHR_CalTaxEmp where StaffId= @staffid and TotalTaxYear>0)
	end
	if @whtamt<0
	begin
		set @id=(SELECT MAX(SalaryId)+1 from Acc_HRPayRoll)
		SET @item=(select MAX(ItemNo)+1 FROM Acc_HRPayRoll where SlipNo=@slipNo)

		Insert into Acc_HRPayRoll
		select @id,@slipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,PaymentDate,
		@item,'บวก-ภาษีหัก ณ ที่จ่าย',@whtamt,@whtamt*-1,0,dbo.GetAccConfig('ADV_CONFIG','TaxEmployee'),'',
		0,NULL,'',NULL,'',GETDATE(),@userid
		from Acc_HRPayRoll where SalaryId=@sid
		and not exists(select 1 from Acc_HRPayRoll where SlipNo=@slipNo and AmountPayment=@whtamt and AccCodeDebit=dbo.GetAccConfig('ADV_CONFIG','TaxEmployee'))		
		and exists(select 1 from vHR_CalTaxEmp where StaffId= @staffid and TotalTaxYear>0)
	end
end

select a.*,b.EntryId 
from Acc_HRPayRoll a left join vJournal_All b
on a.SlipNo=b.JournalNo 
and b.AccCode=CONCAT(AccCodeDebit,AccCodeCredit)
where SlipNo=@slipNo
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_AdjustSIJournalFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_AdjustSIJournalFromJob]
(
@datefrom date,
@dateto date
)
as
begin
insert into Acc_JournalDT 
select jh.EntryID,
jd.Seq+ROW_NUMBER() OVER(PARTITION BY ih.DocNo ORDER BY ih.DocNo) as Seq,
p.IncomeAccCode as AccCode,id.SDescription as AccName,'ปรับปรุงยอดที่ไม่ได้ทำเบิกจ่าย' as AccDesc,id.AmtAdvance as Debit,0 as Credit
from 
[job_3x].dbo.Job_InvoiceDetail id inner join 
[job_3x].dbo.Job_InvoiceHeader ih on
id.BranchCode=ih.BranchCode and id.DocNo=ih.DocNo
inner join Acc_JournalHD jh on 
ih.DocNo=jh.JournalNo
inner join (
select EntryID,MAX(Seq) as Seq from Acc_JournalDT 
group by EntryID
) jd on jh.EntryID=jd.EntryId
inner join vMas_Product p on id.SICode=p.ProductCode 
where not ih.CancelProve<>''
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto
and exists(select LinkBillNo,LinkItem 
			from [job_3x].dbo.Job_ClearDetail cd inner join [job_3x].dbo.Job_ClearHeader ch
			on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
			where cd.LinkBillNo=id.DocNo and cd.LinkItem=id.ItemNo and ch.DocStatus<>99 
			and cd.SICode=id.SICode and not isnull(cd.AdvNO,'')<>'')
and id.AmtAdvance>0

insert into Acc_JournalDT 
select jh.EntryID,
jd.Seq+ROW_NUMBER() OVER(PARTITION BY ih.DocNo ORDER BY ih.DocNo) as Seq,
dbo.GetAccConfig('AP_CONFIG','Purchase'),id.SDescription,'ปรับปรุงยอดที่ไม่ได้ทำเบิกจ่าย',0 as Debit,id.AmtAdvance as Credit
from 
[job_3x].dbo.Job_InvoiceDetail id inner join 
[job_3x].dbo.Job_InvoiceHeader ih on
id.BranchCode=ih.BranchCode and id.DocNo=ih.DocNo
inner join Acc_JournalHD jh on 
ih.DocNo=jh.JournalNo
inner join (
select EntryID,MAX(Seq) as Seq from Acc_JournalDT 
group by EntryID
) jd on jh.EntryID=jd.EntryId
inner join vMas_Product p on id.SICode=p.ProductCode 
where not ih.CancelProve<>''
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto
and exists(select LinkBillNo,LinkItem 
			from [job_3x].dbo.Job_ClearDetail cd inner join [job_3x].dbo.Job_ClearHeader ch
			on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
			where cd.LinkBillNo=id.DocNo and cd.LinkItem=id.ItemNo and ch.DocStatus<>99 
			and cd.SICode=id.SICode and not isnull(cd.AdvNO,'')<>'')
and not exists(select LinkBillNo,LinkItem 
			from [job_3x].dbo.Job_ClearDetail cd inner join [job_3x].dbo.Job_ClearHeader ch
			on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
			where cd.LinkBillNo=id.DocNo and cd.LinkItem=id.ItemNo and ch.DocStatus<>99 
			and cd.SICode=id.SICode and not isnull(cd.AdvNO,'')<>'' AND isnull(cd.VenderBillingNo,'')<>'')
and id.AmtAdvance>0

insert into Acc_JournalDT 
select jh.EntryID,
jd.Seq+ROW_NUMBER() OVER(PARTITION BY ih.DocNo ORDER BY ih.DocNo) as Seq,
p.AssetAccCode,id.SDescription,'ปรับปรุงยอดที่ไม่ได้ทำเบิกจ่าย',0 as Debit,id.AmtAdvance as Credit
from 
[job_3x].dbo.Job_InvoiceDetail id inner join 
[job_3x].dbo.Job_InvoiceHeader ih on
id.BranchCode=ih.BranchCode and id.DocNo=ih.DocNo
inner join Acc_JournalHD jh on 
ih.DocNo=jh.JournalNo
inner join (
select EntryID,MAX(Seq) as Seq from Acc_JournalDT 
group by EntryID
) jd on jh.EntryID=jd.EntryId
inner join vMas_Product p on id.SICode=p.ProductCode 
where not ih.CancelProve<>''
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto
and exists(select LinkBillNo,LinkItem 
			from [job_3x].dbo.Job_ClearDetail cd inner join [job_3x].dbo.Job_ClearHeader ch
			on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
			where cd.LinkBillNo=id.DocNo and cd.LinkItem=id.ItemNo and ch.DocStatus<>99 
			and cd.SICode=id.SICode and not isnull(cd.AdvNO,'')<>'')
and exists(select LinkBillNo,LinkItem 
			from [job_3x].dbo.Job_ClearDetail cd inner join [job_3x].dbo.Job_ClearHeader ch
			on cd.BranchCode=ch.BranchCode and cd.ClrNo=ch.ClrNo
			where cd.LinkBillNo=id.DocNo and cd.LinkItem=id.ItemNo and ch.DocStatus<>99 
			and cd.SICode=id.SICode and not isnull(cd.AdvNO,'')<>'' AND isnull(cd.VenderBillingNo,'')<>'')
and id.AmtAdvance>0

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





---Delete First
/*
delete b
from Acc_TransactionHD b
inner join [job_3x].dbo.Job_AdvHeader a
on b.AccDocNo=a.AdvNo 

delete b
from Acc_TransactionDT b
left join Acc_TransactionHD a 
on b.AccDocNo=a.AccDocNo 
where a.AccDocNo is null
*/
CREATE procedure [dbo].[Insert_AdvanceFromJob]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
BEGIN
--delete existing
delete b
from Acc_TransactionHD b
inner join [job_3x].dbo.Job_AdvHeader a
on b.AccDocNo=a.AdvNo 
and a.AdvDate>=@datefrom and a.AdvDate<=@dateto and a.CustCode like @custcode+'%'

delete b
from Acc_TransactionDT b
left join Acc_TransactionHD a 
on b.AccDocNo=a.AccDocNo 
where a.AccDocNo is null

--Transaction Header 
insert into Acc_TransactionHD
select
a.AdvNo,a.AdvDate,
(case when a.PayChqDate is null then '1900-01-01' else a.PayChqDate end),
a.CustCode,isnull(c.TaxNumber,''),isnull(c.NameThai,''),isnull(c.TAddress,'')
,a.EmpCode,
'AV',
(case when a.PaymentDate is null then '1900-01-01' else a.PaymentDAte end),
a.AdvDate,
(case when isnull(a.paymentRef,'')='' then 1 else 2 end)
,a.InvNo
from [job_3x].dbo.Job_AdvHeader a 
left join [job_3x].dbo.Mas_Company c 
on a.CustCode=c.CustCode and a.CustBranch=c.Branch
where isnull(a.CancelProve,'')='' and a.DocStatus>1
and exists(select 1 from [job_3x].dbo.Job_AdvDetail where BranchCode=a.BranchCode and Advno=a.AdvNo)
and not exists(select 1 from Acc_TransactionHD where AccDocno=a.AdvNo)
and a.AdvDate>=@datefrom and a.AdvDate<=@dateto and a.CustCode like @custcode+'%'

--Transaction Detail
insert into Acc_TransactionDT
select t.* from (
select b.AdvNo,b.ItemNo,'' as AccSourceDocNo,0 as SourceDocItem,0 as StockNo,
AdvQty as Qty,
UnitPrice as Price
,'SHP' as Unit,
b.CurrencyCode,
(case when b.ExchangeRate>1 then b.ExchangeRate else 1 end) as ExcRAte
,b.AdvAmount,
(case when isnull(b.SICode,'')='' then dbo.GetAccConfig('ADV_CONFIG','DefaultCost') else b.SICode end) as pdCode,
b.ForJNo,
(case when b.ChargeVAT>0 then b.VATRate else 0 end) as RateVat,
(case when b.Charge50Tavi>0 then b.Rate50Tavi else 0 end) as RateWht,
1 as VatType
from [job_3x].dbo.Job_AdvDetail b 
inner join [job_3x].dbo.Job_AdvHeader a 
on b.AdvNo=a.AdvNo and b.BranchCode=a.BranchCode 
where isnull(a.CancelProve,'')='' 
and a.AdvDate>=@datefrom and a.AdvDate<=@dateto and a.CustCode like @custcode+'%'
) t inner join Acc_TransactionHD s on t.AdvNo=s.AccDocNo
where not exists(select 1 from Acc_TransactionDT where AccDocNo=t.AdvNo and AccItemNo=t.ItemNo)

/**ADVANCE PAYMENT**/
--Delete First

delete a
from Acc_TransactionHD a inner join [job_3x].dbo.Job_AdvHeader b
on a.AccDocNo=b.PaymentRef 
where b.PaymentRef<>''
and b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto and b.CustCode like @custcode+'%'

delete b
from Acc_TransactionDT b
left join Acc_TransactionHD a 
on b.AccDocNo=a.AccDocNo 
where a.AccDocNo is null

---Transaction Header
insert into Acc_TransactionHD
select distinct 
b.ControlNo,b.VoucherDate,b.VoucherDate,b.RecUser,'',u.TName,u.TPosition,b.RecUser,'DP',b.VoucherDate,
b.VoucherDate,
(case when b.CancelProve<>'' then 99 else 1 end),b.TRemark
from 
[job_3x].dbo.Job_AdvHeader a
inner join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo and a.BranchCode=b.BranchCode 
left join [job_3x].dbo.Mas_User u on b.RecUser=u.UserID
where isnull(a.CancelProve,'')=''
and exists(select 1 from [job_3x].dbo.Job_AdvDetail where BranchCode=a.BranchCode and Advno=a.AdvNo)
and a.PaymentRef<>''
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto and a.CustCode like @custcode+'%'
and not exists(select 1 from Acc_TransactionHD where AccDocNo=b.ControlNo)

insert into Acc_TransactionDT
select av.* from (
select t.ControlNo, 
ROW_NUMBER() OVER(PARTITION BY ControlNo ORDER BY ControlNo) as Seq,
t.Advno,t.ItemNo,0 as stockNo,t.AdvQty,
t.UnitPrice
,'SHP' as UnitMea,t.CurrencyCode,
(case when t.ExchangeRate>1 then t.ExchangeRate else 1 end) as CurRate
,t.AdvAmount,
(case when isnull(t.SICode,'')='' then dbo.GetAccConfig('ADV_CONFIG','DefaultCost') else t.SICode end) as pdCode,
t.ForJNo,
(case when t.ChargeVAT>0 then t.VATRate else 0 end) as RateVat,
(case when t.Charge50Tavi>0 then t.Rate50Tavi else 0 end) as RateWht,
1 as VatType
from (
	select b.ControlNo,d.*
	from 
	[job_3x].dbo.Job_AdvHeader a
	inner join [job_3x].dbo.Job_CashControl b
	on a.PaymentRef=b.ControlNo and a.BranchCode=b.BranchCode 
	left join [job_3x].dbo.Mas_User u on b.RecUser=u.UserID
	inner join [job_3x].dbo.Job_AdvDetail d
	on a.BranchCode=d.BranchCode and a.Advno=d.AdvNo
	where isnull(a.CancelProve,'')=''
	and exists(select 1 from [job_3x].dbo.Job_AdvDetail where BranchCode=a.BranchCode and Advno=a.AdvNo)
	and a.PaymentRef<>''
	and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto and a.CustCode like @custcode+'%'
) t inner join Acc_TransactionHD h on t.ControlNo=h.AccDocNo
) av where not exists(select 1 from Acc_TransactionDT where AccDocNo=av.ControlNo and AccItemNo=av.Seq)
end
/*
--date lost in process (no detail)
select a.AdvNo,a.DocStatus,a.CustCode,d.AdvAmount from
[job_3x].dbo.Job_AdvHeader a left join Acc_TransactionHD b
on a.Advno=b.AccDocNo 
left join [job_3x].dbo.Job_AdvDetail d
on a.BranchCode=d.BranchCode and a.AdvNo=d.AdvNo
where b.AccDocNo is null and isnull(a.CancelProve,'')='' and d.AdvAmount is not null
and a.DocStatus>1

---data lost in process (payment ref not fund0
select a.* from 
[job_3x].dbo.Job_AdvHeader a
left join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo 
where isnull(a.CancelProve,'')=''
and exists(select 1 from [job_3x].dbo.Job_AdvDetail where BranchCode=a.BranchCode and Advno=a.AdvNo)
and a.PaymentRef<>'' and b.ControlNo is null 

---summary doc status--
select AccDocType,DocStatus,dbo.GetAccConfig(concat(AccDocType,'_STATUS'),DocStatus) as StatusName,
sum(TotalAmount) as TptalAmt,sum(VatAmount) as TotalVat,sum(WhtAmount) as TotalWht,
sum(TotalAmount+VatAmount-WhtAmount)as TotalNet
from vTransaction_D d inner join Acc_TransactionHD h on d.DocNo=h.AccDocNo
group by AccDocType,DocStatus

--insert into Mas_AccConfig select 'ADV_CONFIG','DefaultCost','CST-197'
--insert into Mas_AccConfig select 'AV_STATUS',0,'OPEN'
--insert into Mas_AccConfig select 'AV_STATUS',1,'APPROVE'
--insert into Mas_AccConfig select 'AV_STATUS',2,'PAID'
--insert into Mas_AccConfig select 'DP_STATUS',0,'OPEN'
--insert into Mas_AccConfig select 'DP_STATUS',1,'PAID'
--insert into Mas_AccConfig select 'DP_STATUS',2,'POST'
--insert into Mas_AccConfig select 'DP_STATUS',99,'CANCEL'

--select * from MAs_AccConfig where ConfigCode='ADV_CONFIG'

select AccDocType,SalesDescription,sum(TotalAmount) from vTransaction_All group by AccDocType,SalesDescription order by 1,2
select * from Mas_DocConfig where TName like '%ทดรอง%'
select * from vMas_Product where PRoductname like '%Cost%'

*/

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








---Delete First
/*
delete b
from Acc_TransactionHD b
inner join [job_3x].dbo.Job_AdvHeader a
on b.AccDocNo=a.AdvNo 

delete b
from Acc_TransactionDT b
left join Acc_TransactionHD a 
on b.AccDocNo=a.AccDocNo 
where a.AccDocNo is null
*/
CREATE procedure [dbo].[Insert_AdvanceFromJob_V2]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
BEGIN
--delete existing
delete b
from Acc_TransactionHD b
inner join [job_3x].dbo.Job_AdvHeader a
on b.AccDocNo=concat('PO-',a.AdvNo)
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto and a.CustCode like @custcode+'%'
and a.ApproveBy<>''

delete b
from Acc_TransactionDT b
left join Acc_TransactionHD a 
on b.AccDocNo=a.AccDocNo 
where a.AccDocNo is null

--Transaction Header 
insert into Acc_TransactionHD
select
concat('PO-',a.AdvNo) as AccDocNo,a.PaymentDate,
a.AdvDate,
'','',a.PayChqTo,a.TRemark
,a.EmpCode,
'PO',
a.PaymentDate,
a.AdvDate,
(case when isnull(a.paymentRef,'')='' then 0 else 1 end)
,a.PaymentRef
from [job_3x].dbo.Job_AdvHeader a 
inner join [job_3x].dbo.Job_CashControl b on a.PaymentRef=b.ControlNo
left join [job_3x].dbo.Mas_Company c 
on a.CustCode=c.CustCode and a.CustBranch=c.Branch
where isnull(a.CancelProve,'')='' and a.DocStatus>1
and exists(select 1 from [job_3x].dbo.Job_AdvDetail where BranchCode=a.BranchCode and Advno=a.AdvNo)
and not exists(select 1 from Acc_TransactionHD where AccDocNo=concat('PO-',a.AdvNo))
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto and a.CustCode like @custcode+'%'

--Transaction Detail
insert into Acc_TransactionDT
select t.* from (
select concat('PO-',a.AdvNo) as AccDocNo,b.ItemNo,'' as AccSourceDocNo,0 as SourceDocItem,0 as StockNo,
AdvQty as Qty,
UnitPrice as Price
,'SHP' as Unit,
b.CurrencyCode,
(case when b.ExchangeRate>1 then b.ExchangeRate else 1 end) as ExcRAte
,b.AdvAmount,
(case when isnull(b.SICode,'')='' then dbo.GetAccConfig('ADV_CONFIG','DefaultCost') else b.SICode end) as pdCode,
b.ForJNo,
(case when b.ChargeVAT>0 then b.VATRate else 0 end) as RateVat,
(case when b.Charge50Tavi>0 then b.Rate50Tavi else 0 end) as RateWht,
1 as VatType
from [job_3x].dbo.Job_AdvDetail b 
inner join [job_3x].dbo.Job_AdvHeader a 
on b.AdvNo=a.AdvNo and b.BranchCode=a.BranchCode 
inner join [job_3x].dbo.Job_CashControl c on a.PaymentRef=c.ControlNo
where isnull(a.CancelProve,'')='' 
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto and a.CustCode like @custcode+'%'
) t inner join Acc_TransactionHD s on t.AccDocNo=s.AccDocNo
where not exists(select 1 from Acc_TransactionDT where AccDocNo=t.AccDocNo and AccItemNo=t.ItemNo)

end
/*
--date lost in process (no detail)
select a.AdvNo,a.DocStatus,a.CustCode,d.AdvAmount from
[job_3x].dbo.Job_AdvHeader a left join Acc_TransactionHD b
on a.Advno=b.AccDocNo 
left join [job_3x].dbo.Job_AdvDetail d
on a.BranchCode=d.BranchCode and a.AdvNo=d.AdvNo
where b.AccDocNo is null and isnull(a.CancelProve,'')='' and d.AdvAmount is not null
and a.DocStatus>1

---data lost in process (payment ref not fund0
select a.* from 
[job_3x].dbo.Job_AdvHeader a
left join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo 
where isnull(a.CancelProve,'')=''
and exists(select 1 from [job_3x].dbo.Job_AdvDetail where BranchCode=a.BranchCode and Advno=a.AdvNo)
and a.PaymentRef<>'' and b.ControlNo is null 

---summary doc status--
select AccDocType,DocStatus,dbo.GetAccConfig(concat(AccDocType,'_STATUS'),DocStatus) as StatusName,
sum(TotalAmount) as TptalAmt,sum(VatAmount) as TotalVat,sum(WhtAmount) as TotalWht,
sum(TotalAmount+VatAmount-WhtAmount)as TotalNet
from vTransaction_D d inner join Acc_TransactionHD h on d.DocNo=h.AccDocNo
group by AccDocType,DocStatus

--insert into Mas_AccConfig select 'ADV_CONFIG','DefaultCost','CST-197'
--insert into Mas_AccConfig select 'AV_STATUS',0,'OPEN'
--insert into Mas_AccConfig select 'AV_STATUS',1,'APPROVE'
--insert into Mas_AccConfig select 'AV_STATUS',2,'PAID'
--insert into Mas_AccConfig select 'DP_STATUS',0,'OPEN'
--insert into Mas_AccConfig select 'DP_STATUS',1,'PAID'
--insert into Mas_AccConfig select 'DP_STATUS',2,'POST'
--insert into Mas_AccConfig select 'DP_STATUS',99,'CANCEL'

--select * from MAs_AccConfig where ConfigCode='ADV_CONFIG'

select AccDocType,SalesDescription,sum(TotalAmount) from vTransaction_All group by AccDocType,SalesDescription order by 1,2
select * from Mas_DocConfig where TName like '%ทดรอง%'
select * from vMas_Product where PRoductname like '%Cost%'

*/

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE procedure [dbo].[Insert_AdvanceToJournal]
(
@datefrom date,
@dateto date,
@userid varchar(20)
)
as
begin
declare @maxid int=(SELECT isnull(MAX(EntryId),0) from Acc_JournalHD);
/*1.1 Delete Existing Data*/
delete c
from [job_3x].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo 
inner join Acc_JournalDT c on b.EntryID=c.EntryID 
where a.DocStatus<>99 
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto

delete b
from [job_3x].dbo.Job_AdvHeader a inner join Acc_JournalHD b
on a.AdvNo=b.JournalNo 
where a.DocStatus<>99 
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto

/*1.2 Insert Advance Details*/
insert into Acc_JournalDT
select 
DENSE_RANK() OVER(ORDER BY AdvNo)+@maxid as EntryID,
ROW_NUMBER() OVER(PARTITION BY AdvNo ORDER BY AdvNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
	--Dr. เงินทดรองจ่ายพนักงาน (ยอด Net+Wht)
	select b.AdvNo,b.PaymentDate,a.AccCode,b.PayChqTo as AccName,b.TRemark as AccDesc,(b.TotalAdvance+b.Total50Tavi) as Debit,0 as Credit
	from [job_3x].dbo.Job_AdvHeader b,Mas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG','Cashin')
	and b.DocStatus<>99
	union all
	--Cr.เงินสดย่อย (ยอด net)
	select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,c.ForJNo as AccDesc,0 as Debit,c.AdvNet as Credit
	from [job_3x].dbo.Job_AdvHeader b inner join [job_3x].dbo.Job_AdvDetail c
	on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo 
	,Mas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
	and b.DocStatus<>99
	union all
	--Cr. หัก ณ ที่จ่ายในนามลูกค้า
	select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,concat(isnull(e.NameThai,b.CustCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
	from [job_3x].dbo.Job_AdvHeader b inner join [job_3x].dbo.Job_AdvDetail c
	on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo 
	left join [job_3x].dbo.Mas_Company e on b.CustCode=e.CustCode and b.CustBranch=e.Branch
	inner join [job_3x].dbo.Job_SrvSingle d on c.SICode=d.SICode
	,Mas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCustomer')
	and b.DocStatus<>99
	and c.Charge50Tavi>0 and d.IsCredit=1
	union all
	--Cr. หัก ณ ที่จ่าย
	select b.AdvNo,b.PaymentDate,a.AccCode,c.SDescription,concat(isnull(e.TName,c.VenCode),' #',b.Doc50Tavi) as AccDesc,0 as Debit,c.Charge50Tavi as Credit
	from [job_3x].dbo.Job_AdvHeader b inner join [job_3x].dbo.Job_AdvDetail c
	on b.BranchCode=c.BranchCode and b.AdvNo=c.AdvNo 
	left join [job_3x].dbo.Job_SrvSingle d on c.SICode=d.SICode
	left join [job_3x].dbo.Mas_Vender e on c.VenCode=e.VenCode
	,Mas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
	and b.DocStatus<>99
	and c.Charge50Tavi>0 and isnull(d.IsCredit,0)=0
) t
where t.AdvNo not in(select JournalNo FROM Acc_JournalHD)
and t.PaymentDate>=@datefrom and t.PaymentDate<=@dateto
order by AdvNo,AccCode

/*1.3 Insert Advance Header*/
insert into Acc_JournalHD
select 
ROW_NUMBER() OVER(ORDER BY a.AdvNo)+@maxid as EntryID,
a.AdvNO as JournalNo,
a.PaymentDate as EntryDate,
DATEADD(d,7,a.PaymentDate) as EffectiveDate,
@userid,a.PaymentRef,(a.TotalAdvance+a.Total50Tavi),(a.TotalAdvance+a.Total50Tavi)
from [job_3x].dbo.Job_AdvHeader a
where a.DocStatus<>99 
and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto
and a.AdvNo not in(select JournalNo FROM Acc_JournalHD)
order by a.AdvNo

end

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_AdvanceToJournal_MNL]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin

update a set a.PaymentDate=b.VoucherDate
from [job_3x].dbo.Job_AdvHeader a
inner join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo 
where a.PaymentDate<>b.VoucherDate

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_AdvHeader b	
on a.JournalNo=concat('PV-A',b.PaymentRef)
where b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto
and b.CustCode like @custcode+'%'
and a.EntryId=c.EntryId 
)

delete a 
from Acc_JournalHD a inner join [job_3x].dbo.Job_AdvHeader b	
on a.JournalNo=concat('PV-A',b.PaymentRef)
where b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto
and b.CustCode like @custcode+'%';


select * into #tmp1 from (
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCode,
	h.PaymentRef as RefNo,
	d.ForJno as SubAccname,
	sum(case when isnull(s.IsCredit,1)=0 then d.AdvAmount else d.AdvAmount+d.ChargeVAT-d.Charge50Tavi end) as Debit,0 as Credit,
	isnull(s.NameThai,d.SDescription) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a on 
	concat(a.AccMainName,'-',u.TName)=a.AccName	
	where h.DocStatus<>99 
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by a.AccCode,h.PaymentRef,d.ForJNo,isnull(s.NameThai,d.SDescription)
	union all
	select dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	h.PaymentRef as RefNo,
	d.AdvNo as SubAccname,
	sum(d.ChargeVAT) as Debit,0 as Credit,
	(case when u.VenCode is null then h.PayChqTo else u.TName end) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_Vender u on d.VenCode=u.VenCode
	where h.DocStatus<>99 and isnull(s.IsCredit,1)=0 and d.ChargeVAT>0
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by h.PaymentRef,d.AdvNo,(case when u.VenCode is null then h.PayChqTo else u.TName end)
	union all
	select dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,
	h.PaymentRef as RefNo,
	d.AdvNo as SubAccname,
	0 as Debit,sum(d.Charge50Tavi) as Credit,
	case when u.VenCode is null then h.PayChqTo else u.TName end as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_Vender u on d.VenCode=u.VenCode
	where h.DocStatus<>99 and d.Charge50Tavi>0 and isnull(s.IsCredit,1)=0
	and (case when u.VenCode is null then h.PayChqTo else u.TName end) like '%จำกัด%'
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto	
	group by h.PaymentRef,d.AdvNo,u.VenCode,u.TName,h.PayChqTo
	union all
	select dbo.GetAccConfig('ADV_CONFIG','TaxPerson') as AccCode,
	h.PaymentRef as RefNo,
	d.AdvNo as SubAccname,
	0 as Debit,sum(d.Charge50Tavi) as Credit,
	case when u.VenCode is null then h.PayChqTo else u.TName end as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_Vender u on d.VenCode=u.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a on 
	concat(a.AccMainName,'-',u.TName)=a.AccName	
	where h.DocStatus<>99 and d.Charge50Tavi>0 and isnull(s.IsCredit,1)=0
	and (case when u.VenCode is null then h.PayChqTo else u.TName end) not like '%จำกัด%'
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto	
	group by h.PaymentRef,d.AdvNo,u.VenCode,u.TName,h.PayChqTo
	union all
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCode
	,h.PaymentRef as RefNo,d.ForJno as SubAccname,
	0 as Debit,sum(d.AdvAmount+d.ChargeVAT-d.Charge50Tavi) as Credit,
	h.AdvNo as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on v.RecUser=u.UserID
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join (
		select s.ControlNo,MAX(c.AccCode) as AccCode,MAX(b.BookName) as BookBranch
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		left join Mas_AccCode c on b.GLAccountCode=c.AccCode
		on s.BookCode=b.BookCode
		group by s.ControlNo
	) a on v.ControlNo=a.ControlNo
	where h.DocStatus<>99 
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')),d.ForJNo,h.AdvNo,h.PaymentRef
) t 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('PV-A',RefNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY b.ControlNo),
concat('PV-A',b.Controlno) as DocNo,b.VoucherDate,b.VoucherDate,b.RecUser,c.PRVoucher,sum(a.Debit),sum(a.Credit)
from #tmp1 a inner join [job_3x].dbo.Job_CashControl b
on a.RefNo=b.ControlNo 
inner join [job_3x].dbo.Job_CashControlSub c on b.ControlNo=c.ControlNo
group by b.Controlno,b.VoucherDate,c.PRVoucher,b.RecUser;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY RefNo) as EntryId,
ROW_NUMBER() OVER(PARTITION BY RefNo ORDER BY RefNo,AccCode) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
	select RefNo,AccCode,CustName as AccName,SubAccname as AccDesc,
	sum(Debit) as Debit,sum(Credit) as Credit
	from #tmp1
	group by RefNo,AccCode,CustName,SubAccName
) t

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-A',RefNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[Insert_AdvanceToJournal_V2]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin
update a set a.PaymentDate=b.VoucherDate
from [job_3x].dbo.Job_AdvHeader a
inner join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo 
where a.PaymentDate<>b.VoucherDate

if @custcode=''
begin
	delete a 
	from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b	
	on a.JournalNo=concat('PV-A',b.ControlNo)
	where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto;

	delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);
end

select * into #tmp1 from (
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','DefaultCost')) as AccCode,h.PaymentRef as RefNo,d.ForJno as SubAccname,
	sum(d.AdvNet) as Debit,0 as Credit,c.NameEng as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on h.PaymentBy=u.UserID
	left join Mas_AccCode a on u.GLAccountCode=a.AccCode
	where h.DocStatus<>99 and h.PaymentRef<>'' and isnull(s.IsCredit,1)=1 and isnull(s.IsExpense,0)=0
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by a.AccCode,h.PaymentRef,d.ForJNo,c.NameEng
	union all
	select isnull(a.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCode,
	h.PaymentRef as RefNo,d.ForJNo as SubAccname,
	sum(d.AdvAmount) as Debit,0 as Credit,h.PayChqTo as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on h.PaymentBy=u.UserID
	left join Mas_AccCode a on s.GLAccountCodeSales=a.AccCode
	where h.DocStatus<>99 and h.PaymentRef<>'' and not isnull(s.IsCredit,1)=1
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by a.AccCode,h.PaymentRef,d.ForJNo,h.PayChqTo
	union all
    select a.AccCode as AccCode,h.PaymentRef as RefNo,d.ForJNo as SubAccname,
	sum(d.ChargeVAT) as Debit,0 as Credit,concat(h.PayChqTo,' / ',d.SDescription,'=',d.AdvAmount,d.CurrencyCode) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on h.PaymentBy=u.UserID
	,Mas_AccCode a
	where h.DocStatus<>99 and h.PaymentRef<>'' and s.IsCredit=0 and s.IsExpense=1
	and d.ChargeVAT>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by a.AccCode,h.PaymentRef,d.ForJNo,h.PayChqTo,d.SDescription,d.AdvAmount,d.CurrencyCode
	union all
	select a.AccCode as AccCode,h.PaymentRef as RefNo,d.ForJNo as SubAccname,
	0 as Debit,sum(d.Charge50Tavi) as Credit,concat(u.TaxNumber,'-',u.TName) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	inner join [job_3x].dbo.Mas_Vender u 
	on d.VenCode=u.VenCode
	,Mas_AccCode a
	where h.DocStatus<>99 and h.PaymentRef<>'' and s.IsCredit=0 and s.IsExpense=1
	and d.Charge50Tavi>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
	and u.TaxNumber like '0%'
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by a.AccCode,h.PaymentRef,d.ForJNo,u.TaxNumber,u.TName
	union all
	select a.AccCode as AccCode,h.PaymentRef as RefNo,d.ForJNo as SubAccname,
	0 as Debit,sum(d.Charge50Tavi) as Credit,concat(u.TaxNumber,'-',u.TName) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_Vender u 
	on d.VenCode=u.VenCode
	,Mas_AccCode a
	where h.DocStatus<>99 and h.PaymentRef<>'' and s.IsCredit=0 and s.IsExpense=1
	and d.Charge50Tavi>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
	and isnull(u.TaxNumber,'') not like '0%'
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by a.AccCode,h.PaymentRef,d.ForJNo,u.TaxNumber,u.TName
	union all
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCode
	,h.PaymentRef as RefNo,d.ForJno as SubAccname,
	0 as Debit,sum(d.AdvNet) as Credit,c.NameEng as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on h.EmpCode=u.UserID
	left join (
		select s.ControlNo,MAX(b.GLAccountCode) as AccCode
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		on s.BookCode=b.BookCode
		group by s.ControlNo
	) a on v.ControlNo=a.ControlNo
	where h.DocStatus<>99 and h.PaymentRef<>''
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')),d.ForJNo,c.NameEng,h.AdvNo,h.PaymentRef
) t 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('PV-A',RefNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY b.ControlNo),
concat('PV-A',b.Controlno) as DocNo,b.VoucherDate,b.VoucherDate,b.RecUser,b.TRemark,sum(a.Debit),sum(a.Credit)
from #tmp1 a inner join [job_3x].dbo.Job_CashControl b
on a.RefNo=b.ControlNo
group by b.Controlno,b.VoucherDate,b.TRemark,b.RecUser;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY RefNo),
ROW_NUMBER() OVER(PARTITION BY RefNo ORDER BY RefNo,AccCode),
AccCode,SubAccname,CustName,Debit,Credit
from #tmp1;

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-A',RefNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE procedure [dbo].[Insert_AdvanceToJournal_V3]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin
update a set a.PaymentDate=b.VoucherDate
from [job_3x].dbo.Job_AdvHeader a
inner join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo 
where a.PaymentDate<>b.VoucherDate

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_AdvHeader b	
on a.JournalNo=concat('PV-A',b.PaymentRef)
where b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto
and b.CustCode like @custcode+'%'
and a.EntryId=c.EntryId 
)

delete a 
from Acc_JournalHD a inner join [job_3x].dbo.Job_AdvHeader b	
on a.JournalNo=concat('PV-A',b.PaymentRef)
where b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto
and b.CustCode like @custcode+'%';


select * into #tmp1 from (
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCode,
	h.PaymentRef as RefNo,
	d.ForJno as SubAccname,
	sum(d.AdvNet+d.Charge50Tavi) as Debit,0 as Credit,
	isnull(u.TName,h.EmpCode) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join Mas_AccCode a on u.GLAccountCode=a.AccCode
	where h.DocStatus<>99 
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by a.AccCode,h.PaymentRef,d.ForJNo,isnull(u.TName,h.EmpCode)	
	union all
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCode
	,h.PaymentRef as RefNo,d.ForJno as SubAccname,
	0 as Debit,sum(d.AdvNet+d.Charge50Tavi) as Credit,
	h.AdvNo as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on v.RecUser=u.UserID
	left join (
		select s.ControlNo,MAX(c.AccCode) as AccCode,MAX(b.BookName) as BookBranch
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		left join Mas_AccCode c on b.GLAccountCode=c.AccCode
		on s.BookCode=b.BookCode
		group by s.ControlNo
	) a on v.ControlNo=a.ControlNo
	where h.DocStatus<>99 
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and h.CustCode like @custcode+'%'
	group by isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')),d.ForJNo,h.AdvNo,h.PaymentRef
) t 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('PV-A',RefNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY b.ControlNo),
concat('PV-A',b.Controlno) as DocNo,b.VoucherDate,b.VoucherDate,b.RecUser,c.PRVoucher,sum(a.Debit),sum(a.Credit)
from #tmp1 a inner join [job_3x].dbo.Job_CashControl b
on a.RefNo=b.ControlNo 
inner join [job_3x].dbo.Job_CashControlSub c on b.ControlNo=c.ControlNo
group by b.Controlno,b.VoucherDate,c.PRVoucher,b.RecUser;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY RefNo) as EntryId,
ROW_NUMBER() OVER(PARTITION BY RefNo ORDER BY RefNo,AccCode) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
	select RefNo,AccCode,CustName as AccName,SubAccname as AccDesc,
	sum(Debit) as Debit,sum(Credit) as Credit
	from #tmp1
	group by RefNo,AccCode,CustName,SubAccName
) t

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-A',RefNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_AdvanceToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_AdvanceToJournal_V4]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin

update a set a.PaymentDate=b.VoucherDate
from [job_3x].dbo.Job_AdvHeader a
inner join [job_3x].dbo.Job_CashControl b
on a.PaymentRef=b.ControlNo 
where a.PaymentDate<>b.VoucherDate

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_AdvHeader b	
on a.JournalNo=concat('PV-A',b.PaymentRef)
where b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto
and b.CustCode like @custcode+'%'
and a.EntryId=c.EntryId 
)

delete a 
from Acc_JournalHD a inner join [job_3x].dbo.Job_AdvHeader b	
on a.JournalNo=concat('PV-A',b.PaymentRef)
where b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto
and b.CustCode like @custcode+'%';


select * into #tmp1 from (
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCode,
	h.PaymentRef as RefNo,
	d.ForJno as SubAccname,
	sum(d.AdvNet+d.Charge50Tavi) as Debit,0 as Credit,
	isnull(u.TName,h.EmpCode) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a on 
	concat(a.AccMainName,'-',u.TName)=a.AccName	
	where h.DocStatus<>99 	
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by a.AccCode,h.PaymentRef,d.ForJNo,isnull(u.TName,h.EmpCode)	
	union all
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCode
	,h.PaymentRef as RefNo,d.ForJno as SubAccname,
	0 as Debit,sum(d.AdvNet+d.Charge50Tavi) as Credit,
	h.AdvNo as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on v.RecUser=u.UserID
	left join (
		select s.ControlNo,MAX(c.AccCode) as AccCode,MAX(b.BookName) as BookBranch
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		left join Mas_AccCode c on b.GLAccountCode=c.AccCode
		on s.BookCode=b.BookCode
		group by s.ControlNo
	) a on v.ControlNo=a.ControlNo
	where h.DocStatus<>99 
	and h.CustCode like @custcode+'%' and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')),d.ForJNo,h.AdvNo,h.PaymentRef
) t 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('PV-A',RefNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY b.ControlNo),
concat('PV-A',b.Controlno) as DocNo,b.VoucherDate,b.VoucherDate,b.RecUser,c.PRVoucher,sum(a.Debit),sum(a.Credit)
from #tmp1 a inner join [job_3x].dbo.Job_CashControl b
on a.RefNo=b.ControlNo 
inner join [job_3x].dbo.Job_CashControlSub c on b.ControlNo=c.ControlNo
group by b.Controlno,b.VoucherDate,c.PRVoucher,b.RecUser;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY RefNo) as EntryId,
ROW_NUMBER() OVER(PARTITION BY RefNo ORDER BY RefNo,AccCode) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
	select RefNo,AccCode,CustName as AccName,SubAccname as AccDesc,
	sum(Debit) as Debit,sum(Credit) as Credit
	from #tmp1
	group by RefNo,AccCode,CustName,SubAccName
) t

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-A',RefNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ARFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/**set a/r and set costing of sales**/
CREATE procedure [dbo].[Insert_ARFromJob]
(
	@datefrom date,
	@dateto date,
	@billingcode varchar(20)='%'
)
as
begin
--delete existsing data
delete a from Acc_TransactionHD a inner join [job_3x].dbo.Job_InvoiceHeader b on a.AccDocNo=b.DocNo
where b.DocDate>=@datefrom and b.DocDate<=@dateto and b.BillToCustCode like @billingcode
--delete related detals
delete a from Acc_TransactionDT a where AccDocNo not in(select AccDocNo from Acc_TransactionHD b where AccDocNo=b.AccDocNo)
--insert new data detail first
insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,
StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,
SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select 
id.DocNO,ROW_NUMBER() OVER(PARTITION BY id.DocNo ORDER BY id.DocNo) as ItemNo
,isnull(cd.ClrNo,'') as LinKNo,
isnull(cd.ItemNo,0) as LinkItem,
0 as StockNo,isnull(cd.Qty,id.Qty) as Qty,
(case when cd.SICode not like 'ADV%' then 
isnull(cd.UnitPrice,id.UnitPrice) 
else isnull((cd.UsedAmount+cd.ChargeVAT)/cd.Qty,id.TotalAmt/id.Qty) end)/isnull(cd.CurRate,id.ExchangeRate)
as Price
,id.QtyUnit,isnull(cd.CurrencyCode,id.CurrencyCode) as Curr,
isnull(cd.CurRate,id.ExchangeRate) as Rate,
(case when cd.SICode not like 'ADV%' then 
isnull(cd.UsedAmount,id.Amt) 
else isnull((cd.UsedAmount+cd.ChargeVAT),id.Amt) end) as Amount,
id.SICode,cd.Jobno,
(case when cd.SICode not like 'ADV%' then id.VATRate else 0 end) as VATRate,
(case when cd.SICode not like 'ADV%' then id.Rate50Tavi else 0 end) as TaxRate,
(case when cd.SICode not like 'ADV%' then id.IsTaxCharge else 0 end) as VatType
from 
[job_3x].dbo.Job_ClearDetail cd right join 
[job_3x].dbo.Job_InvoiceDetail id 
on cd.BranchCode=id.BranchCode and cd.LinkBillNo=id.DocNo and cd.LinkItem=id.Itemno 
inner join [job_3x].dbo.Job_InvoiceHeader ih 
on id.BranchCode=ih.BranchCode and id.DocNo=ih.DocNo 
where isnull(ih.CancelProve,'')=''
and not exists(select 1 from Acc_TransactionDT where AccDocNo=id.DocNo)
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto and ih.BillToCustCode like @billingcode

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,
PartyName,PartyAddress,IssueBy,AccDocType,
AccPostDate,FiscalYear,DocStatus,DocRefNo)
select ih.DocNo,ih.DocDate,isnull(ih.DueDate,ih.DocDate),ih.CustCode,concat(c.TaxNumber,'/',c.Branch),
c.NameThai,c.TAddress,ih.EmpCode,'SI',
ih.DocDate,ih.DocDate,2,ih.RefNo
from [job_3x].dbo.Job_InvoiceHeader ih 
left join [job_3x].dbo.Mas_Company c on ih.CustCode=c.CustCode
and ih.CustBranch=c.Branch
where isnull(ih.CancelProve,'')='' 
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto and ih.BillToCustCode like @billingcode
and exists(select 1 from Acc_TransactionDT where AccDocNo=ih.DocNo)
and not exists(select 1 from Acc_TransactionHD where AccDocNo=ih.DocNo)

select a.* from Acc_TransactionHD a inner join [job_3x].dbo.Job_InvoiceHeader b on a.AccDocNo=b.DocNo
where b.DocDate>=@datefrom and b.DocDate<=@dateto and b.BillToCustCode like @billingcode
end
/*
---Data Lost---
select h.* from Acc_TransactionHD h where not exists(select 1 from Acc_TransactionDT where AccDocNo=h.AccDocNo)
select h.* from Acc_TransactionDT h where not exists(select 1 from Acc_TransactionHD where AccDocNo=h.AccDocNo)

select ih.RefNo,id.* 
from [job_3x].dbo.Job_InvoiceHeader ih 
inner join [job_3x].dbo.Job_InvoiceDetail id 
on ih.DocNo=id.DocNo 
left join [job_3x].dbo.Job_ClearDetail cd on id.DocNo=cd.LinkBillNo and id.ItemNo=cd.LinkItem
where isnull(ih.CancelProve,'')='' 
and not exists(select 1 from Acc_TransactionHD where AccDocNo=ih.DocNo)
*/


GO
/****** Object:  StoredProcedure [dbo].[Insert_BD]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Insert_BD]
(
    @ip varchar(20),
    @dbname varchar(20),
    @docno varchar(20),
    @doctype varchar(10),
    @slipno varchar(20),
    @depdatetime datetime,
    @userid varchar(20),
    @depby varchar(20),
    @bookno varchar(20),
    @bookname varchar(20),
    @bookbank varchar(20),
    @bookbranch varchar(50),
    @depqty int,
    @depprice decimal(10,4),
    @depcurr varchar(10),
    @deprate decimal(10,4),
    @depnote nvarchar(255),
    @accdebit varchar(10),
    @acccredit varchar(10)
)
AS
BEGIN
    declare @bookdesc varchar(255)=concat(@bookbank,' ',@bookbranch);
    declare @drname varchar(255)=(select AccName from Mas_AccCode where AccCode=@accdebit);
    declare @crname varchar(255)=(select AccName from Mas_AccCode where AccCode=@acccredit);
    declare @depamt decimal(10,4)=(@depqty*@depprice*@deprate);
    EXEC dbo.SetTransactionHeader @ip,@dbname,@docno,@depdatetime,@depdatetime,@bookno,'',@depby,@bookdesc,@userid,@doctype,@depdatetime,@depdatetime,2,@slipno;
    EXEC dbo.SetTransactionDetail @ip,@dbname,@doctype,@docno,0,'',0,0,@depqty,@depprice,'',@depcurr,@deprate,@depamt,'',@depnote,0,0,0,@userid;
    EXEC dbo.SetJournalHeader @ip,@dbname,@doctype,@docno,@depdatetime,@depdatetime,@userid,@depnote,0,0;
    EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accdebit,@drname,@depnote,@userid,@depamt,0;
    EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@acccredit,@crname,@depnote,@userid,0,@depamt;
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*
select * from [job_3x].dbo.Job_PaymentHeader where DocNo='PAY-2510-1988'
select * from [job_3x].dbo.Job_CashControl where ControlNo='2510-621'
select * from [job_3x].dbo.Job_CashControlDoc where ControlNo='2510-621'
select * from [job_3x].dbo.Job_CashControlSub where ControlNo='2510-621'
go
*/
CREATE procedure [dbo].[Insert_BillPayFromJob]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20),
	@vencode varchar(20)=''
)
as
begin
--delete first
delete h from Acc_TransactionHD h
inner join [job_3x].dbo.Job_PaymentHeader d 
on h.AccDocNo=d.DocNo
where h.AccBatchDate>=@datefrom and h.AccBatchDate<=@dateto
and d.VenCode like @vencode+'%'

delete d from Acc_TransactionDT d 
left join Acc_TransactionHD h 
on d.AccDocNo=h.AccDocNo 
where h.AccDocNo is null
--insert detail

Insert into Acc_TransactionDT
(AccDocNo,AccItemno,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMEa,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
RateVat,RateWht,VatType)
select d.DocNo,d.ItemNo,d.ClrRefNo,d.ClrItemNo,0,
d.Qty,d.UnitPrice,d.QtyUnit,h.CurrencyCode,h.ExchangeRate,d.Amt,d.SICode,d.ForJNo,
round((d.amtvat*100/d.amt),0),
round((d.amtWht*100/d.amt),0),1
from [job_3x].dbo.Job_PaymentDetail d 
inner join [job_3x].dbo.Job_PaymentHeader h on d.BranchCode=h.BranchCode and d.DocNo=h.DocNo 
where isnull(h.CancelProve,'')='' and d.Amt>0
and h.DocDate>=@datefrom and h.DocDate<=@dateto and h.VenCode like @vencode+'%'

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyNAme,PartyAddress,
IssueBy,AccPostDate,FiscalYear,DocStatus,DocRefNo,AccDocType)
select DocNo,DocDate,DocDate,h.VenCode,concat(v.TaxNumber,'/',v.BranchCode),v.TName,concat(v.TAddress1,' ',v.TAddress2),
h.EmpCode,h.DocDate,h.DocDate,0,h.PoNo,'PI'
from [job_3x].dbo.Job_PaymentHeader h
left join [job_3x].dbo.Mas_Vender v on h.VenCode =v.VenCode
where isnull(CancelProve,'')=''  and h.TotalExpense>0
and exists(select 1 from [job_3x].dbo.Job_PaymentDetail where DocNo=h.DocNo)
and h.DocDate>=@datefrom and h.DocDate<=@dateto and h.VenCode like @vencode+'%'

--delete first
delete h from Acc_TransactionHD h
inner join [job_3x].dbo.Job_PaymentHeader d 
on h.AccDocNo=d.PaymentRef
where d.PaymentDate>=@datefrom and d.PaymentDate<=@dateto
and d.VenCode like @vencode+'%' and d.PaymentRef<>''

delete d from Acc_TransactionDT d 
left join Acc_TransactionHD h 
on d.AccDocNo=h.AccDocNo 
where h.AccDocNo is null

Insert into Acc_TransactionDT
(AccDocNo,AccItemno,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMEa,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
RateVat,RateWht,VatType)
select h.PaymentRef,ROW_NUMBER() OVER(PARTITION BY h.PaymentRef ORDER BY d.DocNo,d.ItemNo),d.DocNo,d.ItemNo,0,
d.Qty,d.UnitPrice,d.QtyUnit,h.CurrencyCode,h.ExchangeRate,d.Amt,d.SICode,d.ForJNo,
round((d.amtvat*100/d.amt),0),
round((d.amtWht*100/d.amt),0),1
from [job_3x].dbo.Job_CashControlDoc c 
inner join [job_3x].dbo.Job_PaymentHeader h on c.BranchCode=h.BranchCode and c.ControlNo=h.PaymentRef
and c.DocNo=h.DocNo
inner join [job_3x].dbo.Job_PaymentDetail d on h.BranchCode=d.BranchCode and h.DocNo=d.DocNo 
where isnull(h.CancelProve,'')='' and h.PaymentRef<>'' and d.Amt>0
and h.PaymentDate>=@datefrom and h.PaymentDate<=@dateto and h.VenCode like @vencode+'%'

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyNAme,PartyAddress,
IssueBy,AccPostDate,FiscalYear,DocStatus,DocRefNo,AccDocType)
select distinct c.ControlNo,c.VoucherDate,c.VoucherDate,
c.CustCode,concat(u.TaxNumber,'/',u.BranchCode),isnull(u.TName,''),concat(u.TAddress1,' ',u.TAddress2),
c.RecUser,c.RecDate,c.RecDate,0,c.ControlNo,'PS1'
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_CashControl c on h.PaymentRef=c.ControlNo 
left join [job_3x].dbo.Mas_Vender u on h.VenCode =u.VenCode
where isnull(h.CancelProve,'')=''  and h.TotalExpense>0 and h.PaymentRef<>''
and exists(select 1 from [job_3x].dbo.Job_PaymentDetail where DocNo=h.DocNo)
and h.PaymentDate>=@datefrom and h.PaymentDate<=@dateto and h.VenCode like @vencode+'%'

end
/**patch data**/
--update [job_3x].dbo.Job_PaymentDetail set Amt=Qty*UnitPrice where Amt=0
--update [job_3x].dbo.Job_PaymentHeader set ExchangeRate=1 where ExchangeRate=0
--update h set h.VenCode='V0012' from [job_3x].dbo.Job_PaymentHeader h where not exists(select 1 from [job_3x].dbo.Mas_Vender where VenCode=h.VenCode)
--select amt,amtwht,(amtWht*100/amt) as ratecak from [job_3x].dbo.Job_PaymentDetail d  where AmtWHT>0 order by 2 desc
--select amt,amtvat,round((amtvat*100/amt),0) as ratecak from [job_3x].dbo.Job_PaymentDetail d  where AmtVAT>0 order by 2 desc

/**data lost**/
/*
select d2.* 
from [job_3x].dbo.Job_ClearDetail d1
right join [job_3x].dbo.Job_PaymentDetail d2 on
d2.ClrRefNo=d1.ClrNo and d2.ClrItemNo=d1.ItemNo 
where d1.VenderBillingNo=concat(d2.DocNo,'#',d2.ItemNo)

select d1.* 
from [job_3x].dbo.Job_ClearDetail d1
left join [job_3x].dbo.Job_PaymentDetail d2 on
d1.VenderBillingNo= concat(d2.DocNo,'#',d2.ItemNo)
where d2.DocNo is null and d1.VenderBillingNo<>''
*/

GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





/*
select * from [job_3x].dbo.Job_PaymentHeader where DocNo='PAY-2510-1988'
select * from [job_3x].dbo.Job_CashControl where ControlNo='2510-621'
select * from [job_3x].dbo.Job_CashControlDoc where ControlNo='2510-621'
select * from [job_3x].dbo.Job_CashControlSub where ControlNo='2510-621'
go
*/
CREATE procedure [dbo].[Insert_BillPayFromJob_V2]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20),
	@vencode varchar(20)=''
)
as
begin
--delete first
delete h from Acc_TransactionHD h
inner join [job_3x].dbo.Job_PaymentHeader d 
on h.AccDocNo=d.DocNo
where h.AccBatchDate>=@datefrom and h.AccBatchDate<=@dateto
and d.VenCode like @vencode+'%'

delete d from Acc_TransactionDT d 
left join Acc_TransactionHD h 
on d.AccDocNo=h.AccDocNo 
where h.AccDocNo is null
--**ACCOUNT PAYABLES ENTRY***
--insert detail
Insert into Acc_TransactionDT
(AccDocNo,AccItemno,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMEa,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
RateVat,RateWht,VatType)
select d.DocNo,d.ItemNo,d.ClrRefNo,d.ClrItemNo,0,
(case when isnull(s.IsCredit,1)=1 then 1 else d.Qty end) as Qty,
(case when isnull(s.IsCredit,1)=1 then d.FTotal else d.UnitPrice end) as UnitPrice,
d.QtyUnit,h.CurrencyCode,h.ExchangeRate,
(case when isnull(s.IsCredit,1)=1 then d.Total+d.AmtWHT else d.Amt end) as Amt,
d.SICode,d.ForJNo,
(case when isnull(s.IsCredit,1)=1 then 0 else round((d.amtvat*100/d.amt),0) end) as VatRate,
(case when isnull(s.IsCredit,1)=1 then 0 else round((d.amtWht*100/d.amt),0) end) as TaxRate
,1 as VatType
from [job_3x].dbo.Job_PaymentDetail d 
inner join [job_3x].dbo.Job_PaymentHeader h on d.BranchCode=h.BranchCode and d.DocNo=h.DocNo 
left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode
where isnull(h.CancelProve,'')='' and d.Amt>0
and h.DocDate>=@datefrom and h.DocDate<=@dateto and h.VenCode like @vencode+'%'

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyNAme,PartyAddress,
IssueBy,AccPostDate,FiscalYear,DocStatus,DocRefNo,AccDocType)
select DocNo,DocDate,DocDate,h.VenCode,concat(v.TaxNumber,'/',v.BranchCode),v.TName,concat(v.TAddress1,' ',v.TAddress2),
h.EmpCode,h.DocDate,h.DocDate,0,h.PoNo,'PI'
from [job_3x].dbo.Job_PaymentHeader h
left join [job_3x].dbo.Mas_Vender v on h.VenCode =v.VenCode
where isnull(CancelProve,'')=''  and h.TotalExpense>0
and exists(select 1 from [job_3x].dbo.Job_PaymentDetail where DocNo=h.DocNo)
and h.DocDate>=@datefrom and h.DocDate<=@dateto and h.VenCode like @vencode+'%'

end
/**patch data**/
--update [job_3x].dbo.Job_PaymentDetail set Amt=Qty*UnitPrice where Amt=0
--update [job_3x].dbo.Job_PaymentHeader set ExchangeRate=1 where ExchangeRate=0
--update h set h.VenCode='V0012' from [job_3x].dbo.Job_PaymentHeader h where not exists(select 1 from [job_3x].dbo.Mas_Vender where VenCode=h.VenCode)
--select amt,amtwht,(amtWht*100/amt) as ratecak from [job_3x].dbo.Job_PaymentDetail d  where AmtWHT>0 order by 2 desc
--select amt,amtvat,round((amtvat*100/amt),0) as ratecak from [job_3x].dbo.Job_PaymentDetail d  where AmtVAT>0 order by 2 desc

/**data lost**/
/*
select d2.* 
from [job_3x].dbo.Job_ClearDetail d1
right join [job_3x].dbo.Job_PaymentDetail d2 on
d2.ClrRefNo=d1.ClrNo and d2.ClrItemNo=d1.ItemNo 
where d1.VenderBillingNo=concat(d2.DocNo,'#',d2.ItemNo)

select d1.* 
from [job_3x].dbo.Job_ClearDetail d1
left join [job_3x].dbo.Job_PaymentDetail d2 on
d1.VenderBillingNo= concat(d2.DocNo,'#',d2.ItemNo)
where d2.DocNo is null and d1.VenderBillingNo<>''
*/

GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_BillPayToJournal]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20),
	@accdebit varchar(20)='',
	@acccredit varchar(20)=''
)
as
begin
--delete first
delete h from Acc_JournalHD h
inner join Acc_TransactionHD d 
on h.JournalNo=CONCAT('RR-',d.AccDocNo)
where d.AccDocType='PS1' 
and d.AccBatchDate>=@datefrom and d.AccBatchDate<=@dateto 

delete d from Acc_JournalDT d left join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.EntryId is null
--new data
declare @id int=(select isnull(Max(EntryId),0) from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,Entrydate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo),
CONCAT('RR-',AccDocNo),AccBatchDate,AccEffectiveDate,@userid,DocRefNo,0,0
from (
select distinct AccDocNo,AccBatchDate,AccEffectiveDate,IssueBy,DocRefNo from 
vTransaction_All a
where a.AccDocType='PS1' 
and not exists(select 1 from vTransaction_All where AccDocNo=a.AccSourceDocNo and AccItemno=a.AccSourceDocItem and AccDocType='PC')
and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto 
) t

insert into Acc_JournalDT (EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(Order By AccDocNo),
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo,AccItemNo) as Seq,
AccCode,AccDesc,AccDocNo,Debit,Credit 
from (
	select AccDocNo,AccItemNo,ExpenseAccCode as AccCode,a.ProductName as AccName,SalesDescription as AccDesc,Amount as Debit,0 as Credit
	from vTransaction_All a
	where a.AccDocType='PS1' 
	and not exists(select 1 from vTransaction_All where AccDocNo=a.AccSourceDocNo and AccItemno=a.AccSourceDocItem and AccDocType='PC')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and @accdebit='' 
	union all
	select AccDocNo,AccItemNo,p.AccCode as AccCode,a.ProductName as AccName,SalesDescription as AccDesc,DVatAmt as Debit,0 as Credit
	from vTransaction_All a,vMas_AccCode p 
	where a.AccDocType='PS1' and a.DVatAmt>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
	and not exists(select 1 from vTransaction_All where AccDocNo=a.AccSourceDocNo and AccItemno=a.AccSourceDocItem and AccDocType='PC')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto 
	union all
	select AccDocNo,AccItemNo,p.AccCode as AccCode,a.ProductName as AccName,SalesDescription as AccDesc,0 as Debit,Amount+DVatAmt as Credit
	from vTransaction_All a,vMas_AccCode p 
	where a.AccDocType='PS1' and p.AccCode=dbo.GetAccConfig('AP_CONFIG','Purchase')
	and not exists(select 1 from vTransaction_All where AccDocNo=a.AccSourceDocNo and AccItemno=a.AccSourceDocItem and AccDocType='PC')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and @acccredit=''
	union all
	select AccDocNo,AccItemNo,p.AccCode as AccCode,a.ProductName as AccName,SalesDescription as AccDesc,Amount as Debit,0 as Credit
	from vTransaction_All a,vMas_AccCode p 
	where a.AccDocType='PS1' 
	and not exists(select 1 from vTransaction_All where AccDocNo=a.AccSourceDocNo and AccItemno=a.AccSourceDocItem and AccDocType='PC')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and p.AccCode=@accdebit
	union all
	select AccDocNo,AccItemNo,p.AccCode as AccCode,a.ProductName as AccName,SalesDescription as AccDesc,0 as Debit,Amount+DVatAmt as Credit
	from vTransaction_All a,vMas_AccCode p 
	where a.AccDocType='PS1' and p.AccCode=@acccredit
	and not exists(select 1 from vTransaction_All where AccDocNo=a.AccSourceDocNo and AccItemno=a.AccSourceDocItem and AccDocType='PC')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto 
) t

delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)

update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr

end

GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_BillPayToJournal_MNL]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId 
)

delete a from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto;

select * into #tmp2 from (
select CONCAT('PI-',h.DocNo) as DocNo,
h.DocDate,concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')) as VenderName,h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo as JNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeC,
(case when s.IsCredit=1 then
isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
else 
isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
end) as AccCodeD,
sum(case when isnull(s.IsCredit,1)=1 then d.Total+d.AmtWHT else d.Amt end) as Amt,
sum(case when isnull(s.IsCredit,1)=1 then 0 else d.AmtVAT end) as AmtVAT
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_PaymentDetail d
on h.DocNo=d.DocNo 
left join [job_3x].dbo.Job_Order j on d.ForJNo=j.JNo 
left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle s on d.SIcode=s.SICode
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
left join [job_3x].dbo.Mas_Vender v
on h.VenCode=v.VenCode 
left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') b 
on concat(b.AccMainName,'-',v.TName)=b.AccName
left join [job_3x].dbo.Job_SrvGroup g on s.GroupCode=g.GroupCode
where isnull(h.CancelProve,'')='' --and h.ApproveBy<>''
and h.DocDate>=@datefrom and h.DocDate<=@dateto
group by  h.DocNo,h.DocDate,isnull(v.TName,''),isnull(v.TaxNumber,''),h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')),s.IsCredit
,isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
,isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
) t

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(Order By DocNo),DocNo,DocDate,DocDate,EmpCode,Descr,Total,Total 
from (
select Docno,DocDate,EmpCode,concat(vendername,'@',pono,' #',refno) as Descr,
sum(Amt+AmtVat) as Total
from #tmp2
group by Docno,DocDate,Vendername,EmpCode,pono,refno
) t;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,ItemNo),
AccCode,AccName,AccDesc,Debit,Credit from 
(
select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,SDescription as AccName,
Sum(Amt+AmtVat) as Debit,0 as Credit
from #tmp2
group by DocNo,AccCodeD,SDescription,JNo
union all
select DocNo,2 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,VenderName as AccName,
0 as Debit,sum(Amt+AmtVAT) as Credit
from #tmp2
group by DocNo,AccCodeC,VenderName,JNo
) t;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp2 where DocNo=h.JournalNo)

drop table #tmp2;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[Insert_BillPayToJournal_V2]
(
	@datefrom date,
	@dateto date
)
as
begin
delete a from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=b.DocNo 
where b.DocDate>=@datefrom and b.DocDate<=@dateto;

delete b from Acc_JournalDT b
where not exists(select 1 from Acc_JournalHD where EntryId=b.EntryId)

select * into #tmp2 from (
select h.DocNo,h.DocDate,isnull(v.TName,'') as VenderName,h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo as JNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeC
,isnull(isnull(a.AccCode,g.GLAccountCode),dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeD,
sum(case when isnull(s.IsCredit,1)=1 then d.Total+d.AmtWHT else d.Amt end) as Amt,
sum(case when isnull(s.IsCredit,1)=1 then 0 else d.AmtVAT end) as AmtVAT
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_PaymentDetail d
on h.DocNo=d.DocNo 
left join [job_3x].dbo.Job_Order j on d.ForJNo=j.JNo 
left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle s on d.SIcode=s.SICode
left join Mas_AccCode a on s.GLAccountCodeCost=a.AccCode
left join [job_3x].dbo.Mas_Vender v
on h.VenCode=v.VenCode 
left join Mas_AccCode b on v.GLAccountCode=b.AccCode
left join [job_3x].dbo.Job_SrvGroup g on s.GroupCode=g.GroupCode
where isnull(h.CancelProve,'')='' --and h.ApproveBy<>''
and h.DocDate>=@datefrom and h.DocDate<=@dateto
group by  h.DocNo,h.DocDate,isnull(v.TName,''),h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase'))
,isnull(isnull(a.AccCode,g.GLAccountCode),dbo.GetAccConfig('GL_CONFIG','DefaultCost'))
) t

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(Order By DocNo),DocNo,DocDate,DocDate,EmpCode,Descr,Total,Total 
from (
select Docno,DocDate,EmpCode,concat(vendername,'@',pono,' #',refno) as Descr,
sum(Amt+AmtVat) as Total
from #tmp2
group by Docno,DocDate,Vendername,EmpCode,pono,refno
) t;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,ItemNo),
AccCode,AccName,AccDesc,Debit,Credit from 
(
select DocNo,0 as ItemNo,AccCodeD as AccCode,SDescription as AccDesc,JNo as AccName,
Sum(Amt) as Debit,0 as Credit
from #tmp2
group by DocNo,AccCodeD,SDescription,JNo
union all
select DocNo,1 as ItemNo,dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,SDescription as AccDesc,JNo as AccName,
Sum(AmtVAT) as Debit,0 as Credit
from #tmp2 where AmtVAT>0
group by DocNo,SDescription,JNo
union all
select DocNo,2 as ItemNo,AccCodeC as AccCode,VenderName as AccDesc,JNo as AccName,
0 as Debit,sum(Amt+AmtVAT) as Credit
from #tmp2
group by DocNo,AccCodeC,VenderName,JNo
) t;


select * from Acc_JournalHD h 
where exists(select 1 from #tmp2 where DocNo=h.JournalNo)

drop table #tmp2;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE procedure [dbo].[Insert_BillPayToJournal_V3]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId 
)

delete a from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto;

select * into #tmp2 from (
select CONCAT('PI-',h.DocNo) as DocNo,
h.DocDate,concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')) as VenderName,h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo as JNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeC
,isnull(a.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense')) as AccCodeD,
sum(case when isnull(s.IsCredit,1)=1 then d.Total+d.AmtWHT else d.Amt end) as Amt,
sum(case when isnull(s.IsCredit,1)=1 then 0 else d.AmtVAT end) as AmtVAT
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_PaymentDetail d
on h.DocNo=d.DocNo 
left join [job_3x].dbo.Job_Order j on d.ForJNo=j.JNo 
left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle s on d.SIcode=s.SICode
left join Mas_AccCode a on s.GLAccountCodeCost=a.AccCode
left join [job_3x].dbo.Mas_Vender v
on h.VenCode=v.VenCode 
left join Mas_AccCode b on v.GLAccountCode=b.AccCode
left join [job_3x].dbo.Job_SrvGroup g on s.GroupCode=g.GroupCode
where isnull(h.CancelProve,'')='' --and h.ApproveBy<>''
and h.DocDate>=@datefrom and h.DocDate<=@dateto
group by  h.DocNo,h.DocDate,isnull(v.TName,''),isnull(v.TaxNumber,''),h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase'))
,isnull(a.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
) t

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(Order By DocNo),DocNo,DocDate,DocDate,EmpCode,Descr,Total,Total 
from (
select Docno,DocDate,EmpCode,concat(vendername,'@',pono,' #',refno) as Descr,
sum(Amt+AmtVat) as Total
from #tmp2
group by Docno,DocDate,Vendername,EmpCode,pono,refno
) t;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,ItemNo),
AccCode,AccName,AccDesc,Debit,Credit from 
(
select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,SDescription as AccName,
Sum(Amt+AmtVat) as Debit,0 as Credit
from #tmp2
group by DocNo,AccCodeD,SDescription,JNo
union all
select DocNo,2 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,VenderName as AccName,
0 as Debit,sum(Amt+AmtVAT) as Credit
from #tmp2
group by DocNo,AccCodeC,VenderName,JNo
) t;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp2 where DocNo=h.JournalNo)

drop table #tmp2;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_BillPayToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE procedure [dbo].[Insert_BillPayToJournal_V4]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId 
)

delete a from Acc_JournalHD a 
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto;

select * into #tmp2 from (
select CONCAT('PI-',h.DocNo) as DocNo,
h.DocDate,concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')) as VenderName,h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo as JNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeC,
(case when s.IsCredit=1 then
isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
else 
isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
end) as AccCodeD,
sum(case when isnull(s.IsCredit,1)=1 then d.Total+d.AmtWHT else d.Amt end) as Amt,
sum(case when isnull(s.IsCredit,1)=1 then 0 else d.AmtVAT end) as AmtVAT
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_PaymentDetail d
on h.DocNo=d.DocNo 
left join [job_3x].dbo.Job_Order j on d.ForJNo=j.JNo 
left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle s on d.SIcode=s.SICode
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
left join [job_3x].dbo.Mas_Vender v
on h.VenCode=v.VenCode 
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueExpense')+'-____') a2 
on concat(a2.AccMainName,'-',v.TName)=a2.AccName
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') b 
on concat(b.AccMainName,'-',v.TName)=b.AccName
left join [job_3x].dbo.Job_SrvGroup g on s.GroupCode=g.GroupCode
where isnull(h.CancelProve,'')='' --and h.ApproveBy<>''
and h.DocDate>=@datefrom and h.DocDate<=@dateto
group by  h.DocNo,h.DocDate,isnull(v.TName,''),isnull(v.TaxNumber,''),h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')),s.IsCredit
,isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
,isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
) t

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(Order By DocNo),DocNo,DocDate,DocDate,EmpCode,Descr,Total,Total 
from (
select Docno,DocDate,EmpCode,concat(vendername,'@',pono,' #',refno) as Descr,
sum(Amt+AmtVat) as Total
from #tmp2
group by Docno,DocDate,Vendername,EmpCode,pono,refno
) t;

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,ItemNo),
AccCode,AccName,AccDesc,Debit,Credit from 
(
select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,SDescription as AccName,
Sum(Amt+AmtVat) as Debit,0 as Credit
from #tmp2
group by DocNo,AccCodeD,SDescription,JNo
union all
select DocNo,2 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,VenderName as AccName,
0 as Debit,sum(Amt+AmtVAT) as Credit
from #tmp2
group by DocNo,AccCodeC,VenderName,JNo
) t;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp2 where DocNo=h.JournalNo)

drop table #tmp2;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




















CREATE procedure [dbo].[Insert_ClearExpenseFromAdvance]
(
@datefrom date,
@dateto date
)
as
Begin
delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-A',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-A',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select v.TaxNumber,v.TName,t.* into #tmp1 
from ( 
	select ad.AdvNo,ad.ItemNo,d.JobNo,h.ClrNo,h.ClrDate,ah.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,ad.ForJNo,
	(case when s.IsCredit=1 then isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkinProcess')) else isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) end) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeCredit,
	convert(decimal(18,2),(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else (case when s.IsExpense=1 then d.UsedAmount else d.UsedAmount+d.ChargeVAT-d.Tax50Tavi end) end)) as Amount,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end)) as AmountVat,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end)) as AmountWht,
	convert(decimal(18,2),(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount+d.ChargeVAT-d.Tax50Tavi end)) as AmountNet,
	(case when d.VenderCode='' and ad.VenCode<>'' then ad.VenCode else d.VenderCode end) as VenCode,
	isnull(u.TName,ah.EmpCode) as UserName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_AdvDetail ad
	on d.AdvNO=ad.AdvNo and d.AdvItemNo=ad.ItemNo 
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Job_AdvHeader ah
	on ad.AdvNo=ah.AdvNO 
	left join [job_3x].dbo.Mas_User u 
	on ah.EmpCode=u.UserID 
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	left join Mas_AccCode a1 on s.GLAccountCodeCost=a1.AccCode
	left join Mas_AccCode a2 on s.GLAccountCodeSales=a2.AccCode
	left join Mas_AccCode a3 on u.GLAccountCode=a3.AccCode
	where h.DocStatus<>99
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
) t left join [job_3x].dbo.Mas_Vender v on t.VenCode=v.VenCode

delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-A',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-A',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-A',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-A',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-A',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-A',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,a.UserName as AccName,a.ForJNo as AccDesc,
		0 as Debit,sum(AmountNet+AmountWht) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.UserName,a.ForJNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromAdvance_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_ClearExpenseFromAdvance_MNL]
(
@datefrom date,
@dateto date
)
as
Begin
delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-A',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-A',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select t.* into #tmp1 
from ( 
	select ad.AdvNo,ad.ItemNo,d.JobNo,h.ClrNo,h.ClrDate,ah.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,ad.ForJNo,
	(case when s.IsCredit=1 then 
	 isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkinProcess')) 
	 else 
	 isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) 
	 end) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeCredit,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.UsedAmount else (d.UsedAmount+d.ChargeVAT-d.Tax50Tavi) end)) as Amount,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end)) as AmountVat,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end)) as AmountWht,
	convert(decimal(18,2),(d.UsedAmount+d.ChargeVAT-d.Tax50Tavi)) as AmountNet,
	(case when d.VenderCode='' and ad.VenCode<>'' then ad.VenCode else d.VenderCode end) as VenCode,
	v.TaxNumber,v.TName,
	isnull(u.TName,ah.EmpCode) as UserName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_AdvDetail ad
	on d.AdvNO=ad.AdvNo and d.AdvItemNo=ad.ItemNo 
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Job_AdvHeader ah
	on ad.AdvNo=ah.AdvNO 
	left join [job_3x].dbo.Mas_Company c
	on ah.CustCode=c.CustCode and ah.CustBranch=c.Branch
	left join [job_3x].dbo.Job_Order j
	on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company b
	on j.CustCode=b.CustCode and j.CustBranch=b.Branch
	left join [job_3x].dbo.Mas_User u 
	on ah.EmpCode=u.UserID 
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',b.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
	on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a3 
	on concat(a3.AccMainName,'-',u.TName)=a3.AccName	
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where h.DocStatus<>99
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
) t 

delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-A',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-A',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-A',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-A',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		/*
		select concat('AJ-A',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-A',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		0 as Debit,sum(AmountVat) as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		*/
		select concat('AJ-A',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,a.UserName as AccName,a.ForJNo as AccDesc,
		0 as Debit,sum(Amount) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.UserName,a.ForJNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromAdvance_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


























CREATE procedure [dbo].[Insert_ClearExpenseFromAdvance_V2]
(
@datefrom date,
@dateto date
)
as
Begin
delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-A',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-A',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select t.* into #tmp1 
from ( 
	select ad.AdvNo,ad.ItemNo,d.JobNo,h.ClrNo,h.ClrDate,ah.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,ad.ForJNo,
	(case when s.IsCredit=1 then 
	 isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkinProcess')) 
	 else 
	 isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) 
	 end) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeCredit,
	convert(decimal(18,2),(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else (case when s.IsExpense=1 then d.UsedAmount else d.UsedAmount+d.ChargeVAT-d.Tax50Tavi end) end)) as Amount,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end)) as AmountVat,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end)) as AmountWht,
	convert(decimal(18,2),(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount+d.ChargeVAT-d.Tax50Tavi end)) as AmountNet,
	(case when d.VenderCode='' and ad.VenCode<>'' then ad.VenCode else d.VenderCode end) as VenCode,
	v.TaxNumber,v.TName,
	isnull(u.TName,ah.EmpCode) as UserName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_AdvDetail ad
	on d.AdvNO=ad.AdvNo and d.AdvItemNo=ad.ItemNo 
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Job_AdvHeader ah
	on ad.AdvNo=ah.AdvNO 
	left join [job_3x].dbo.Mas_Company c
	on ah.CustCode=c.CustCode and ah.CustBranch=c.Branch
	left join [job_3x].dbo.Job_Order j
	on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company b
	on j.CustCode=b.CustCode and j.CustBranch=b.Branch
	left join [job_3x].dbo.Mas_User u 
	on ah.EmpCode=u.UserID 
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',b.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
	on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a3 
	on concat(a3.AccMainName,'-',u.TName)=a3.AccName	
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where h.DocStatus<>99
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
) t 

delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-A',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-A',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-A',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-A',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-A',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-A',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,a.UserName as AccName,a.ForJNo as AccDesc,
		0 as Debit,sum(AmountNet+AmountWht) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.UserName,a.ForJNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromBillPay]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

















CREATE procedure [dbo].[Insert_ClearExpenseFromBillPay]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-P',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-P',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select v.TaxNumber,v.TName,t.* into #tmp1 
from ( 
	select ad.DocNo,ad.ItemNo,d.JobNo,h.ClrNo,h.ClrDate,ah.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeDebit ,
	isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense')) as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	(case when d.VenderCode='' and ah.VenCode<>'' then ah.VenCode else d.VenderCode end) as VenCode
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_PaymentDetail ad
	on d.ClrNo=ad.ClrRefNo and d.ItemNo=ad.ClrItemNo 
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Job_PaymentHeader ah
	on ad.DocNo=ah.DocNo 
	inner join [job_3x].dbo.Mas_User u 
	on ah.EmpCode=u.UserID 
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	left join Mas_Acccode a1 on s.GLAccountCodeSales=a1.AccCode 
	left join Mas_Acccode a2 on s.GLAccountCodeCost=a2.AccCode 
	where h.DocStatus<>99 and s.IsCredit=0 
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
) t left join [job_3x].dbo.Mas_Vender v on t.VenCode=v.VenCode

delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-P',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-P',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-P',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-P',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-P',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-P',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,0 as Debit,sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.SDescription,a.JobNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromBillPay_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_ClearExpenseFromBillPay_V2]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-P',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-P',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select t.* into #tmp1 
from ( 
	select ad.DocNo,ad.ItemNo,d.JobNo,h.ClrNo,h.ClrDate,ah.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeDebit ,
	(case when s.IsCredit=1 then
	isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
	else 
	isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
	end) as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	(case when d.VenderCode='' and ah.VenCode<>'' then ah.VenCode else d.VenderCode end) as VenCode,
	v.TaxNumber,v.TName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_PaymentDetail ad
	on d.ClrNo=ad.ClrRefNo and d.ItemNo=ad.ClrItemNo 
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Job_PaymentHeader ah
	on ad.DocNo=ah.DocNo 
	inner join [job_3x].dbo.Mas_User u 
	on ah.EmpCode=u.UserID 
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	inner join [job_3x].dbo.Job_Order j on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_Vender v on ah.VenCode=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueExpense')+'-____') a2 
	on concat(a2.AccMainName,'-',v.TName)=a2.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a3 
	on concat(a3.AccMainName,'-',s.NameThai)=a3.AccName	
	where h.DocStatus<>99 and s.IsCredit=0 
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
) t 

delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-P',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-P',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-P',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-P',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-P',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-P',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,0 as Debit,sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.SDescription,a.JobNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_ClearExpenseFromManualEntry]
(
	@datefrom date,
	@dateto date
)
as
begin
select isnull(v.TaxNumber,'') as TaxNumnber,isnull(v.TName,'') as TName,t.* into #tmp1 
from ( 
	select d.ClrNo,d.ItemNo,d.JobNo,h.ClrDate,h.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	isnull(s.GLAccountCodeSales,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeDebit ,
	isnull(u.GLAccountCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	j.forwarderCode as VenCode
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	inner join [job_3x].dbo.Job_Order j on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Vender v on j.forwarderCode=v.VenCode
	where h.DocStatus<>99 and d.AdvNO='' and d.VenderBillingNo=''
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
	and not (s.IsCredit=0 and s.IsExpense=0)
	and d.BNet>0
	and not h.CancelProve<>''
) t left join [job_3x].dbo.Mas_Vender v on t.VenCode=v.VenCode


delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-C',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-C',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-C',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,concat(a.TName,'-',a.SDescription) as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.TName,a.SDescription,a.JobNo 
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,0 as Debit,
		sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.SDescription,a.JobNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_ClearExpenseFromManualEntry_MNL]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-C',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-C',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select t.* into #tmp1 
from ( 
	select isnull(v.TaxNumber,'') as TaxNumnber,isnull(v.TName,d.Pay50TaviTo) as TName,
	d.ClrNo,d.ItemNo,d.JobNo,h.ClrDate,h.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	isnull((case when s.IsCredit=1 then isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) 
	else isnull(a2.AccCode,s.GLAccountCodeSales) end),
	dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	isnull(d.VenderCode,j.ForwarderCode) as VenCode,d.Pay50TaviTo as VenderName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	inner join [job_3x].dbo.Job_Order j on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
	on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
	left join [job_3x].dbo.Mas_Vender v on isnull(d.VenderCode,j.ForwarderCode)=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') a3 
	on concat(a3.AccMainName,'-',v.TName)=a3.AccName	
	where h.DocStatus<>99 and d.AdvNO='' and d.VenderBillingNo=''
	and not (s.IsCredit=0 and s.IsExpense=0) and d.BNet>0
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 		
) t 


delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-C',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-C',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-C',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,concat(TName,'-',SDescription) as AccName,a.JobNo as AccDesc,0 as Debit,
		sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.TName,a.SDescription,a.JobNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
















CREATE procedure [dbo].[Insert_ClearExpenseFromManualEntry_V2]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-C',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-C',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select isnull(v.TaxNumber,'') as TaxNumnber,isnull(v.TName,t.VenderName) as TName,t.* into #tmp1 
from ( 
	select d.ClrNo,d.ItemNo,d.JobNo,h.ClrDate,h.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	isnull((case when s.IsCredit=1 then a1.AccCode else a2.AccCode end),dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeDebit ,
	dbo.GetAccConfig('GL_CONFIG','AccrueExpense') as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	isnull(d.VenderCode,j.ForwarderCode) as VenCode,d.Pay50TaviTo as VenderName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	inner join [job_3x].dbo.Job_Order j on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Vender v on j.forwarderCode=v.VenCode
	left join Mas_AccCode a1 on s.GLAccountCodeCost=a1.AccCode
	left join Mas_AccCode a2 on s.GLAccountCodeSales=a2.AccCode
	where h.DocStatus<>99 and d.AdvNO='' and d.VenderBillingNo=''
	and not (s.IsCredit=0 and s.IsExpense=0) and d.BNet>0
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 		
) t left join [job_3x].dbo.Mas_Vender v on t.VenCode=v.VenCode


delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-C',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-C',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-C',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,TName as AccName,a.JobNo as AccDesc,0 as Debit,
		sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.TName,a.JobNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearExpenseFromManualEntry_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_ClearExpenseFromManualEntry_V3]
(
	@datefrom date,
	@dateto date
)
as
begin

delete c from Acc_JournalDT c
where exists(
select 1 from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-C',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
and a.EntryID=c.EntryId
)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ClearHeader b 
on a.JournalNo=concat('AJ-C',b.ClrNo)
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

select t.* into #tmp1 
from ( 
	select isnull(v.TaxNumber,'') as TaxNumnber,isnull(v.TName,d.Pay50TaviTo) as TName,
	d.ClrNo,d.ItemNo,d.JobNo,h.ClrDate,h.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	(case when s.IsCredit=1 then 
	 isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkinProcess')) 
	 else 
	 isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) 
	 end) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense')) as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	isnull(d.VenderCode,j.ForwarderCode) as VenCode,d.Pay50TaviTo as VenderName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	inner join [job_3x].dbo.Job_Order j on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
	on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
	left join [job_3x].dbo.Mas_Vender v on isnull(d.VenderCode,j.ForwarderCode)=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueExpense')+'-____') a3 
	on concat(a3.AccMainName,'-',v.TName)=a3.AccName	
	where h.DocStatus<>99 and d.AdvNO='' and d.VenderBillingNo=''
	and not (s.IsCredit=0 and s.IsExpense=0) and d.BNet>0
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 		
) t 


delete d from Acc_JournalDT d where exists(
select 1 from Acc_JournalHD a inner join #tmp1 b 
on a.JournalNo=CONCAT('AJ-C',b.ClrNo) and a.EntryId=d.EntryId
)

delete h from Acc_JournalHD h
inner join #tmp1 b 
on h.JournalNo=CONCAT('AJ-C',b.ClrNo)

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.ClrNo),
concat('AJ-C',a.ClrNo) as JournalNo,
a.ClrDate,a.ClrDate,a.Clrby,a.TRemark,sum(a.AmountNet+a.AmountWht),sum(a.AmountNet+a.AmountWht)
from #tmp1 a
group by a.ClrNo,a.ClrDate,a.ClrBy,a.TRemark

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY JVNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY JVNo ORDER BY JVNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,concat(TName,'-',SDescription) as AccName,a.JobNo as AccDesc,0 as Debit,
		sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.TName,a.SDescription,a.JobNo
	) t
) dt 

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





--update [job_3x].dbo.Job_ClearDetail set SIcode='CSS-061' where SICode='CSS-061S'
--update [job_3x].dbo.Job_ClearDetail set SIcode='EX-P-013' where SICode='EX-P-0130'
--update [job_3x].dbo.Job_ClearDetail set SIcode='CST-066' where SICode='CST-066CCC'
--update [job_3x].dbo.Job_ClearDetail set SIcode='CST-066' where SICode='CST-066CAI'
--/*
CREATE procedure [dbo].[Insert_ClearFromJob]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20)
)
as
begin
--delete first
delete a from Acc_TransactionHD a
where exists(select 1 from [job_3x].dbo.Job_ClearDetail h
             where h.ClrNo=a.AccDocNo 
			 and h.Date50Tavi>=@datefrom and h.Date50Tavi<=@dateto
			 and exists(select 1 from [job_3x].dbo.Job_ClearHeader hd where hd.ClrNo=h.ClrNo and isnull(hd.CancelProve,'')='' and hd.DocStatus>0 and hd.ClearType<3)
			 )

delete from Acc_TransactionDT 
where AccDocNo not in(select AccDocNo from Acc_TransactionHD)

Insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
select * from (
select concat(ClrNo,'-',ROW_NUMBER() over(PARTITION BY ClrNo ORDER BY ClrNo)) as DocNo,
EntryDate,EffectiveDate,PArtyCode,PartyTax,PArtyName,PartyAddress,UserID,DocType,PostDate,FiscalYear,DocStatus,ClrNo as DocRefNo
from (
	select distinct h.ClrNo,isnull(d.Date50Tavi,h.ClrDate) as EntryDate,
	h.ClrDate as EffectiveDate,isnull(v.VenCode,'') as PArtyCode
	,isnull(v.TaxNumber,'') as PartyTax
	,isnull(v.TName,'') as PArtyName,
	isnull(v.TAddress1,'') as PartyAddress,
	@userid as UserID,'PC' as DocType,
	h.ClrDate as FiscalYear,h.ClrDate as PostDate,
	1 as DocStatus,h.CTN_NO
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h
	on d.BranchCode=h.BranchCode and d.Clrno=h.Clrno
	left join vMas_Product p on d.SICode=p.ProductCode
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where isnull(h.CancelProve,'')='' and h.DocStatus>0 and h.ClearType<3	
	and d.VenderBillingNo=''
	and isnull(d.Date50Tavi,h.ClrDate)>=@datefrom and isnull(d.Date50Tavi,h.ClrDate)<=@dateto
) th
) t 
where not exists(select 1 from Acc_TransactionDT where AccDocNo=t.DocNo)

INSERT INTO Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,
UnitMea,Currency,ExchangeRate,Amount,SalePRoductCode,SalesDescription,RateVAt,RateWht,VatType)
select * from (
select concat(ClrNo,'-',DENSE_RANK() over(PARTITION BY ClrNo ORDER BY ClrNo,EntryDate,PArtyCode)) as DocNo,
ROW_NUMBER() over(PARTITION BY ClrNo,EntryDate,PartyCode ORDER BY ClrNo) as Seq,
AdvNo,AdvItemNo,0 as StockNo,Qty,UnitPrice,UnitCode,CurrencyCode,CurRate,Amount,SICode,JobNo,VATRate,Tax50TaviRate,1 as VatType
from (
	select h.ClrNo as ClrDocNo,isnull(d.Date50Tavi,h.ClrDate) as EntryDate,
	h.ClrDate as EffectiveDate,isnull(v.VenCode,'') as PArtyCode
	,isnull(v.TaxNumber,'') as PartyTax
	,isnull(v.TName,'') as PArtyName,
	isnull(v.TAddress1,'') as PartyAddress,
	@userid as UserID,'PC' as DocType,
	h.ClrDate as FiscalYear,h.ClrDate as PostDate,
	1 as DocStatus,h.CTN_NO,d.AdvNO,d.AdvItemno,UnitCode,d.CurrencyCode,CurRate,
	d.SICode,d.Jobno,d.ClrNo,
	(case when s.IsCredit=1 then 1 else Qty end) as Qty,
	(case when s.IsCredit=1 then UsedAmount+ChargeVAT-Tax50Tavi else UnitPrice end) as UnitPrice,
	(case when s.IsCredit=1 then UsedAmount+ChargeVAT-Tax50Tavi else UsedAmount end) as Amount,
	(case when s.IsCredit=1 then 0 else VATRate end) as VATRate,
	(case when s.IsCredit=1 then 0 else Tax50TaviRate end) as Tax50TaviRate
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h
	on d.BranchCode=h.BranchCode and d.Clrno=h.Clrno
	left join vMas_Product p on d.SICode=p.ProductCode
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where isnull(h.CancelProve,'')='' and h.DocStatus>0 and h.ClearType<3	
	and d.VenderBillingNo=''
	and isnull(d.Date50Tavi,h.ClrDate)>=@datefrom and isnull(d.Date50Tavi,h.ClrDate)<=@dateto
) td 
) t
where not exists(select 1 from Acc_TransactionDT where AccDocNo=t.DocNo and AccItemNo=t.Seq)

end
/*
--Advance Balance
select t.*,round(NetPayment-isnull(NetTotal,0),2) as Balance,DATEDIFF(DAY,AccBatchDate,@docdate) as Aging
from (
select a.DocNo,a.AccBatchDate,a.PartyName,a.AccSourceDocNo,a.AccSourceDocItem,round(a.DNetAmt,2) as NetPayment,
round(sum(b.Amount),2) as NetUsed,round(sum(b.DVatAmt),2) as NetVat,round(sum(b.DWhtAmt),2) as NetWht,round(sum(b.DNetAmt),2) as NetTotal
from 
(select * from vTransaction_All where AccDocType='DP') a inner join 
(select * from vTransaction_All where AccDocType='PC') b
on a.AccSourceDocNo=b.AccSourceDocNo and a.AccSourceDocItem=b.AccSourceDocItem
group by a.DocNo,a.AccBatchDate,a.PartyName,a.AccSourceDocNo,a.AccSourceDocItem,a.DNetAmt
) t 
order by Balance 
*/



GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







--update [job_3x].dbo.Job_ClearDetail set SIcode='CSS-061' where SICode='CSS-061S'
--update [job_3x].dbo.Job_ClearDetail set SIcode='EX-P-013' where SICode='EX-P-0130'
--update [job_3x].dbo.Job_ClearDetail set SIcode='CST-066' where SICode='CST-066CCC'
--update [job_3x].dbo.Job_ClearDetail set SIcode='CST-066' where SICode='CST-066CAI'
--/*
CREATE procedure [dbo].[Insert_ClearFromJob_V2]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20)
)
as
begin
--delete first
delete a from Acc_TransactionHD a
where exists(select 1 from [job_3x].dbo.Job_ClearHeader h
             where h.ClrNo=a.DocRefNo
			 and h.ClrDate>=@datefrom and h.ClrDate<=@dateto
			 and h.DocStatus<>99
			 )

delete from Acc_TransactionDT 
where AccDocNo not in(select AccDocNo from Acc_TransactionHD)

Insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
select * from (
select concat(ClrNo,'-',ROW_NUMBER() over(PARTITION BY ClrNo ORDER BY ClrNo)) as DocNo,
EntryDate,EffectiveDate,PArtyCode,PartyTax,PArtyName,PartyAddress,UserID,DocType,PostDate,FiscalYear,DocStatus,ClrNo as DocRefNo
from (
	select distinct h.ClrNo,h.ClrDate as EntryDate,
	isnull(d.Date50Tavi,h.ClrDate) as EffectiveDate,isnull(v.VenCode,'') as PArtyCode
	,isnull(v.TaxNumber,'') as PartyTax
	,isnull(v.TName,'') as PArtyName,
	isnull(v.TAddress1,'') as PartyAddress,
	@userid as UserID,'PC' as DocType,
	h.ClrDate as FiscalYear,h.ClrDate as PostDate,
	1 as DocStatus,h.CTN_NO
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h
	on d.BranchCode=h.BranchCode and d.Clrno=h.Clrno
	left join vMas_Product p on d.SICode=p.ProductCode
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where isnull(h.CancelProve,'')='' and h.DocStatus>0 and h.ClearType<3	
	and d.VenderBillingNo=''
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto
) th
) t 
where not exists(select 1 from Acc_TransactionDT where AccDocNo=t.DocNo)

INSERT INTO Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,
UnitMea,Currency,ExchangeRate,Amount,SalePRoductCode,SalesDescription,RateVAt,RateWht,VatType)
select * from (
select concat(ClrNo,'-',DENSE_RANK() over(PARTITION BY ClrNo ORDER BY ClrNo,EntryDate,PArtyCode)) as DocNo,
ROW_NUMBER() over(PARTITION BY ClrNo,EntryDate,PartyCode ORDER BY ClrNo) as Seq,
AdvNo,AdvItemNo,0 as StockNo,Qty,UnitPrice,UnitCode,CurrencyCode,CurRate,Amount,SICode,JobNo,VATRate,Tax50TaviRate,1 as VatType
from (
	select h.ClrNo as ClrDocNo,h.ClrDate as EntryDate,
	isnull(d.Date50Tavi,h.ClrDate) as EffectiveDate,isnull(v.VenCode,'') as PArtyCode
	,isnull(v.TaxNumber,'') as PartyTax
	,isnull(v.TName,'') as PArtyName,
	isnull(v.TAddress1,'') as PartyAddress,
	@userid as UserID,'PC' as DocType,
	h.ClrDate as FiscalYear,h.ClrDate as PostDate,
	1 as DocStatus,h.CTN_NO,d.AdvNO,d.AdvItemno,UnitCode,d.CurrencyCode,CurRate,
	d.SICode,d.Jobno,d.ClrNo,
	(case when s.IsCredit=1 then 1 else Qty end) as Qty,
	(case when s.IsCredit=1 then UsedAmount+ChargeVAT-Tax50Tavi else UnitPrice end) as UnitPrice,
	(case when s.IsCredit=1 then UsedAmount+ChargeVAT-Tax50Tavi else UsedAmount end) as Amount,
	(case when s.IsCredit=1 then 0 else VATRate end) as VATRate,
	(case when s.IsCredit=1 then 0 else Tax50TaviRate end) as Tax50TaviRate
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h
	on d.BranchCode=h.BranchCode and d.Clrno=h.Clrno
	left join vMas_Product p on d.SICode=p.ProductCode
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where isnull(h.CancelProve,'')='' and h.DocStatus>0 and h.ClearType<3	
	and d.VenderBillingNo=''
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto
) td 
) t
where not exists(select 1 from Acc_TransactionDT where AccDocNo=t.DocNo and AccItemNo=t.Seq)

end
/*
--Advance Balance
select t.*,round(NetPayment-isnull(NetTotal,0),2) as Balance,DATEDIFF(DAY,AccBatchDate,@docdate) as Aging
from (
select a.DocNo,a.AccBatchDate,a.PartyName,a.AccSourceDocNo,a.AccSourceDocItem,round(a.DNetAmt,2) as NetPayment,
round(sum(b.Amount),2) as NetUsed,round(sum(b.DVatAmt),2) as NetVat,round(sum(b.DWhtAmt),2) as NetWht,round(sum(b.DNetAmt),2) as NetTotal
from 
(select * from vTransaction_All where AccDocType='DP') a inner join 
(select * from vTransaction_All where AccDocType='PC') b
on a.AccSourceDocNo=b.AccSourceDocNo and a.AccSourceDocItem=b.AccSourceDocItem
group by a.DocNo,a.AccBatchDate,a.PartyName,a.AccSourceDocNo,a.AccSourceDocItem,a.DNetAmt
) t 
order by Balance 
*/



GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
















CREATE procedure [dbo].[Insert_ClearMoneyFromAdvance]
(
@datefrom date,
@dateto date
)
as
begin

delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('RV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('RV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto

delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and not exists(select 1 from [job_3x].dbo.Job_CashControlDoc where ControlNo=b.ControlNo and DocType='ADV')
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and not exists(select 1 from [job_3x].dbo.Job_CashControlDoc where ControlNo=b.ControlNo and DocType='ADV')

select * into #tmp1
from ( 
	select v.ControlNo,v.VoucherDate,v.RecUser,u.UserID,v.TRemark,a.AdvNo,a.ItemNo,s.PRVoucher,
	isnull(a1.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCodeBook,b.BookName,a.AdvNet,c.ClrNet,
	round(cast(a.AdvNet-isnull(c.ClrNet,0) as decimal(10,4)),2) as TotalUsed,
	isnull(a2.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeUser,u.TName as UserName,a.ForJno as JNo
	from 
	[job_3x].dbo.Job_CashControl v inner join 
	(
		select ControlNo,DocNo,acType,sum(PaidAmount) as PaidAmount 
		from [job_3x].dbo.Job_CashControlDoc 
		where DocType='CLR' and PaidAmount<>0
		group by ControlNo,DocNo,acType
	) d on v.ControlNo=d.ControlNo
	inner join [job_3x].dbo.Job_CashControlSub s on
	d.ControlNo=s.ControlNo and d.acType=s.acType
	inner join [job_3x].dbo.Job_AdvDetail a
	on d.DocNo=concat(a.AdvNo,'#',a.ItemNo)
	left join 
	(select cd.AdvNo,ah.EmpCode as AdvBy,cd.AdvItemNo,sum(cd.BNet) as ClrNet
	 from [job_3x].dbo.Job_ClearDetail cd
	 inner join [job_3x].dbo.Job_ClearHeader ch  
	 on cd.ClrNo=ch.ClrNo  
	 inner join [job_3x].dbo.Job_AdvHeader ah 
	 on cd.AdvNo=ah.AdvNo
	 where ch.DocStatus<>99 
	 and cd.AdvNO<>''
	 group by cd.AdvNo,ah.EmpCode,cd.AdvItemNo 
	) c on a.AdvNo=c.AdvNO and a.ItemNo=c.AdvItemNo
	inner join [job_3x].dbo.Mas_BookAccount b on s.BookCode=b.BookCode
	left join [job_3x].dbo.Mas_User u on c.AdvBy=u.UserID 
	left join Mas_AccCode a1 on b.GLAccountCode=a1.AccCode
	left join Mas_AccCode a2 on u.GLAccountCode=a2.AccCode
	where v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	and isnull(v.CancelProve,'')=''
) t

delete h from Acc_JournalHD h
inner join (
	select 
	concat((case when sum(TotalUsed)>0 then 'RV-A' else 'PV-A' end),ControlNo) as ControlNo,
	VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,
	PRVoucher,ABS(sum(TotalUsed)) as Debit,ABS(sum(TotalUsed)) as Credit
	from #tmp1	
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t on h.JournalNo=t.ControlNo
delete d from Acc_JournalDT d where not exists(select 1 from Acc_JournalHD where EntryId=d.EntryId)


declare @id int=(select isnull(max(EntryId),0) as q from Acc_JournalHD)

Insert into Acc_JournalHD
select @id+ROW_NUMBER() OVER(ORDER BY ControlNo) as EntryId,
t.* from (
	select 
	concat((case when sum(TotalUsed)>0 then 'RV-A' else 'PV-A' end),ControlNo) as ControlNo,
	VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,PRVoucher,
	ABS(sum(TotalUsed)) as Debit,ABS(sum(TotalUsed)) as Credit
	from #tmp1
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t
where not exists(select 1 from Acc_JournalHD where JournalNo=t.ControlNo)

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY ControlNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY ControlNo ORDER BY ControlNo,Debit,Credit) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select ControlNo,AccCode,AccName,AccDesc,
		(case when sum(Debit)>sum(Credit) then sum(Debit)-sum(Credit) else 0 end) as Debit,
		(case when sum(Debit)>sum(Credit) then 0 else sum(Credit)-sum(Debit) end) as Credit 
		from (
			select ControlNo,JNo as AccDesc,
			AccCodeBook as AccCode,AdvNo as AccName,TotalUsed as Debit,0 as Credit
			from #tmp1
			where TotalUsed>0
			union all
			select ControlNo,JNo as AccDesc,
			AccCodeUser as AccCode,UserName as AccName,0 as Debit,TotalUsed as Credit
			from #tmp1
			where TotalUsed>0
			union all
			select ControlNo,JNo as AccDesc,
			AccCodeBook as AccCode,AdvNo as AccName,0 as Debit,ABS(TotalUsed) as Credit
			from #tmp1
			where TotalUsed<0
			union all
			select ControlNo,JNo as AccDesc,
			AccCodeUser as AccCode,UserName as AccName,ABS(TotalUsed) as Debit,0 as Credit
			from #tmp1
			where TotalUsed<0
		) tbl
		group by ControlNo,AccCode,AccName,AccDesc
	) t 
) dt
inner join Acc_JournalHD hd on dt.EntryId =hd.EntryId

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromAdvance_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_ClearMoneyFromAdvance_V2]
(
@datefrom date,
@dateto date
)
as
begin

delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('RV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('RV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto

delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and not exists(select 1 from [job_3x].dbo.Job_CashControlDoc where ControlNo=b.ControlNo and DocType='ADV')
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-A',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and not exists(select 1 from [job_3x].dbo.Job_CashControlDoc where ControlNo=b.ControlNo and DocType='ADV')

select * into #tmp1
from ( 
	select v.ControlNo,v.VoucherDate,v.RecUser,u.UserID,v.TRemark,a.AdvNo,a.ItemNo,s.PRVoucher,
	isnull(a1.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCodeBook,b.BookName,a.AdvNet,c.ClrNet,
	round(cast(a.AdvNet-isnull(c.ClrNet,0) as decimal(10,4)),2) as TotalUsed,
	isnull(a2.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeUser,u.TName as UserName,a.ForJno as JNo
	from 
	[job_3x].dbo.Job_CashControl v inner join 
	(
		select ControlNo,DocNo,acType,sum(PaidAmount) as PaidAmount 
		from [job_3x].dbo.Job_CashControlDoc 
		where DocType='CLR' and PaidAmount<>0
		group by ControlNo,DocNo,acType
	) d on v.ControlNo=d.ControlNo
	inner join [job_3x].dbo.Job_CashControlSub s on
	d.ControlNo=s.ControlNo and d.acType=s.acType
	inner join [job_3x].dbo.Job_AdvDetail a
	on d.DocNo=concat(a.AdvNo,'#',a.ItemNo)
	left join 
	(select cd.AdvNo,ah.CustCode,ah.CustBranch,ah.EmpCode as AdvBy,cd.AdvItemNo,sum(cd.BNet) as ClrNet
	 from [job_3x].dbo.Job_ClearDetail cd
	 inner join [job_3x].dbo.Job_ClearHeader ch  
	 on cd.ClrNo=ch.ClrNo  
	 inner join [job_3x].dbo.Job_AdvHeader ah 
	 on cd.AdvNo=ah.AdvNo	 
	 where ch.DocStatus<>99 
	 and cd.AdvNO<>''
	 group by cd.AdvNo,ah.CustCode,ah.CustBranch,ah.EmpCode,cd.AdvItemNo 
	) c on a.AdvNo=c.AdvNO and a.ItemNo=c.AdvItemNo
	inner join [job_3x].dbo.Mas_BookAccount b on s.BookCode=b.BookCode
	left join [job_3x].dbo.Mas_User u on c.AdvBy=u.UserID 
	left join [job_3x].dbo.Mas_Company cu on c.Custcode=cu.custcode and c.CustBranch=cu.Branch
	left join Mas_AccCode a1 on b.GLAccountCode=a1.AccCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a2 
	on concat(a2.AccMainName,'-',u.TName)=a2.AccName	
	where isnull(v.CancelProve,'')='' 
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto

) t

delete h from Acc_JournalHD h
inner join (
	select 
	concat((case when sum(TotalUsed)>0 then 'RV-A' else 'PV-A' end),ControlNo) as ControlNo,
	VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,
	PRVoucher,ABS(sum(TotalUsed)) as Debit,ABS(sum(TotalUsed)) as Credit
	from #tmp1	
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t on h.JournalNo=t.ControlNo
delete d from Acc_JournalDT d where not exists(select 1 from Acc_JournalHD where EntryId=d.EntryId)


declare @id int=(select isnull(max(EntryId),0) as q from Acc_JournalHD)

Insert into Acc_JournalHD
select @id+ROW_NUMBER() OVER(ORDER BY ControlNo) as EntryId,
t.* from (
	select 
	concat((case when sum(TotalUsed)>0 then 'RV-A' else 'PV-A' end),ControlNo) as ControlNo,
	VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,PRVoucher,
	ABS(sum(TotalUsed)) as Debit,ABS(sum(TotalUsed)) as Credit
	from #tmp1
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t
where not exists(select 1 from Acc_JournalHD where JournalNo=t.ControlNo)

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY ControlNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY ControlNo ORDER BY ControlNo,Debit,Credit) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select ControlNo,AccCode,AccName,AccDesc,
		(case when sum(Debit)>sum(Credit) then sum(Debit)-sum(Credit) else 0 end) as Debit,
		(case when sum(Debit)>sum(Credit) then 0 else sum(Credit)-sum(Debit) end) as Credit 
		from (
			select ControlNo,JNo as AccDesc,
			AccCodeBook as AccCode,AdvNo as AccName,TotalUsed as Debit,0 as Credit
			from #tmp1
			where TotalUsed>0
			union all
			select ControlNo,JNo as AccDesc,
			AccCodeUser as AccCode,UserName as AccName,0 as Debit,TotalUsed as Credit
			from #tmp1
			where TotalUsed>0
			union all
			select ControlNo,JNo as AccDesc,
			AccCodeBook as AccCode,AdvNo as AccName,0 as Debit,ABS(TotalUsed) as Credit
			from #tmp1
			where TotalUsed<0
			union all
			select ControlNo,JNo as AccDesc,
			AccCodeUser as AccCode,UserName as AccName,ABS(TotalUsed) as Debit,0 as Credit
			from #tmp1
			where TotalUsed<0
		) tbl
		group by ControlNo,AccCode,AccName,AccDesc
	) t 
) dt
inner join Acc_JournalHD hd on dt.EntryId =hd.EntryId

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromNoAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






















CREATE procedure [dbo].[Insert_ClearMoneyFromNoAdvance]
(
@datefrom date,
@dateto date
)
as
begin

delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-C',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-C',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto

select t.* into #tmp1
from ( 
	select h.ControlNo,h.VoucherDate,h.RecUser,h.TRemark,
	isnull(ac.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')) as AccCodeBook,b.BookName,
	a.VenderCode,c.EmpCode,c.ClrNo,a.Pay50TaviTo,s.PRVoucher,a.SlipNO,
	isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense')) as AccCodeUser,u.TName as UserName,
	a.SICode,a.SDescription,i.IsCredit,
	(case when i.IsCredit=1 then a.UsedAmount+a.ChargeVAT else a.UsedAmount end) as UsedAmount,
	(case when i.IsCredit=1 then 0 else a.ChargeVAT end) as ChargeVAT,
	(case when i.IsCredit=1 then 0 else a.Tax50Tavi end) as Tax50Tavi,
	(case when i.IsCredit=1 then a.UsedAmount+a.ChargeVAT else a.BNet end) as TotalUsed,
	d.PaidAmount*-1 as PaidAmount,
	a.JobNo as JNo,s.PRType	
	from 
	[job_3x].dbo.Job_CashControl h inner join 
		(
		select ControlNo,DocNo,acType,sum(PaidAmount) as PaidAmount 
		from [job_3x].dbo.Job_CashControlDoc 
		where DocType='CLR' and PaidAmount<>0
		group by ControlNo,DocNo,acType
	) d on h.ControlNo=d.ControlNo
	inner join [job_3x].dbo.Job_CashControlSub s on
	d.ControlNo=s.ControlNo and d.acType=s.acType
	inner join [job_3x].dbo.Job_ClearDetail a
	on d.DocNo=concat(a.ClrNo,'#',a.ItemNo)
	inner join [job_3x].dbo.Job_Order j on a.JobNo=j.JNo 
	inner join [job_3x].dbo.Job_ClearHeader c 
	on a.ClrNo=c.ClrNo 
	left join [job_3x].dbo.Mas_User u on c.EmpCode=u.UserID
	left join [job_3x].dbo.Job_SrvSingle i on a.SIcode=i.SICode 
	left join [job_3x].dbo.Mas_BookAccount b on s.BookCode=b.BookCode
	left join dbo.Mas_AccCode ad on u.GLAccountCode=ad.AccCode
	left join dbo.Mas_AccCode ac on b.GLAccountCode=ac.AccCode
	left join [job_3x].dbo.Mas_Vender v on isnull(a.VenderCode,j.ForwarderCode)=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueExpense')+'-____') a3 
	on concat(a3.AccMainName,'-',v.TName)=a3.AccName	
	where isnull(h.CancelProve,'')='' and isnull(a.VenderBillingNo,'')=''
	and isnull(a.AdvNO,'')=''
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto	
) t 

delete h from Acc_JournalHD h
inner join (
	select 
	concat('PV-C',ControlNo) as ControlNo,VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,
	PRVoucher,sum(TotalUsed) as Debit,sum(TotalUsed) as Credit
	from #tmp1
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t on h.JournalNo=t.ControlNo
delete d from Acc_JournalDT d where not exists(select 1 from Acc_JournalHD where EntryId=d.EntryId)

declare @id int=(select isnull(max(EntryId),0) as q from Acc_JournalHD)

Insert into Acc_JournalHD
select @id+ROW_NUMBER() OVER(ORDER BY ControlNo) as EntryId,
t.* from (
	select 
	concat('PV-C',ControlNo) as ControlNo,VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,
	PRVoucher,sum(TotalUsed) as Debit,sum(TotalUsed) as Credit
	from #tmp1
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t
where not exists(select 1 from Acc_JournalHD where JournalNo=t.ControlNo)

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY ControlNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY ControlNo ORDER BY ControlNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,
		SDescription as AccName,
		sum(TotalUsed+Tax50Tavi) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
		) db
		group by ControlNo,JNo,AccCodeUser,SDescription
		union all
		select ControlNo,JNo,
		AccCodeBook as AccCode,
		UserName as AccName,
		0 as Debit,
		sum(TotalUsed) as Credit
		from (
			select *
			from #tmp1
		) cd
		group by ControlNo,JNo,AccCodeBook,UserName
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('WHT_CONFIG','TaxCompany') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(Tax50Tavi) as Credit
		from (
			select *
			from #tmp1
			where Tax50Tavi>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(ChargeVAT) as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	    Pay50TaviTo as AccName,
		sum(ChargeVAT) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
	) t 
) dt
inner join Acc_JournalHD hd on dt.EntryId =hd.EntryId

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ClearMoneyFromNoAdvance_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO























CREATE procedure [dbo].[Insert_ClearMoneyFromNoAdvance_MNL]
(
@datefrom date,
@dateto date
)
as
begin

delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-C',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b 
on a.JournalNo=concat('PV-C',b.ControlNo)
where b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto

select t.* into #tmp1
from ( 
	select h.ControlNo,h.VoucherDate,h.RecUser,h.TRemark,
	isnull(ac.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')) as AccCodeBook,b.BookName,
	a.VenderCode,c.EmpCode,c.ClrNo,a.Pay50TaviTo,s.PRVoucher,a.SlipNO,
	isnull(a3.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeUser,u.TName as UserName,
	a.SICode,a.SDescription,i.IsCredit,
	(case when i.IsCredit=1 then a.UsedAmount+a.ChargeVAT else a.UsedAmount end) as UsedAmount,
	(case when i.IsCredit=1 then 0 else a.ChargeVAT end) as ChargeVAT,
	(case when i.IsCredit=1 then 0 else a.Tax50Tavi end) as Tax50Tavi,
	(case when i.IsCredit=1 then a.UsedAmount+a.ChargeVAT else a.BNet end) as TotalUsed,
	d.PaidAmount*-1 as PaidAmount,
	a.JobNo as JNo,s.PRType	
	from 
	[job_3x].dbo.Job_CashControl h inner join 
		(
		select ControlNo,DocNo,acType,sum(PaidAmount) as PaidAmount 
		from [job_3x].dbo.Job_CashControlDoc 
		where DocType='CLR' and PaidAmount<>0
		group by ControlNo,DocNo,acType
	) d on h.ControlNo=d.ControlNo
	inner join [job_3x].dbo.Job_CashControlSub s on
	d.ControlNo=s.ControlNo and d.acType=s.acType
	inner join [job_3x].dbo.Job_ClearDetail a
	on d.DocNo=concat(a.ClrNo,'#',a.ItemNo)
	inner join [job_3x].dbo.Job_Order j on a.JobNo=j.JNo 
	inner join [job_3x].dbo.Job_ClearHeader c 
	on a.ClrNo=c.ClrNo 
	left join [job_3x].dbo.Mas_User u on c.EmpCode=u.UserID
	left join [job_3x].dbo.Job_SrvSingle i on a.SIcode=i.SICode 
	left join [job_3x].dbo.Mas_BookAccount b on s.BookCode=b.BookCode
	left join dbo.Mas_AccCode ad on u.GLAccountCode=ad.AccCode
	left join dbo.Mas_AccCode ac on b.GLAccountCode=ac.AccCode
	left join [job_3x].dbo.Mas_Vender v on isnull(a.VenderCode,j.ForwarderCode)=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') a3 
	on concat(a3.AccMainName,'-',v.TName)=a3.AccName	
	where isnull(h.CancelProve,'')='' and isnull(a.VenderBillingNo,'')=''
	and isnull(a.AdvNO,'')=''
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto	
) t 

delete h from Acc_JournalHD h
inner join (
	select 
	concat('PV-C',ControlNo) as ControlNo,VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,
	PRVoucher,sum(TotalUsed) as Debit,sum(TotalUsed) as Credit
	from #tmp1
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t on h.JournalNo=t.ControlNo
delete d from Acc_JournalDT d where not exists(select 1 from Acc_JournalHD where EntryId=d.EntryId)

declare @id int=(select isnull(max(EntryId),0) as q from Acc_JournalHD)

Insert into Acc_JournalHD
select @id+ROW_NUMBER() OVER(ORDER BY ControlNo) as EntryId,
t.* from (
	select 
	concat('PV-C',ControlNo) as ControlNo,VoucherDate as EntryDate,VoucherDate as EffectiveDate,RecUser,
	PRVoucher,sum(TotalUsed) as Debit,sum(TotalUsed) as Credit
	from #tmp1
	group by ControlNo,VoucherDate,VoucherDate,RecUser,PRVoucher
) t
where not exists(select 1 from Acc_JournalHD where JournalNo=t.ControlNo)

Insert into Acc_JournalDT
select dt.* from (
	select @id+DENSE_RANK() OVER(ORDER BY ControlNo) as EntryId,
	ROW_NUMBER() OVER(PARTITION BY ControlNo ORDER BY ControlNo,AccDesc) as Seq
	,AccCode,AccName,AccDesc,Debit,Credit from
	(
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,
		SDescription as AccName,
		sum(TotalUsed+Tax50Tavi) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
		) db
		group by ControlNo,JNo,AccCodeUser,SDescription
		union all
		select ControlNo,JNo,
		AccCodeBook as AccCode,
		UserName as AccName,
		0 as Debit,
		sum(TotalUsed) as Credit
		from (
			select *
			from #tmp1
		) cd
		group by ControlNo,JNo,AccCodeBook,UserName
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('WHT_CONFIG','TaxCompany') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(Tax50Tavi) as Credit
		from (
			select *
			from #tmp1
			where Tax50Tavi>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(ChargeVAT) as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	    Pay50TaviTo as AccName,
		sum(ChargeVAT) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
	) t 
) dt
inner join Acc_JournalHD hd on dt.EntryId =hd.EntryId

EXEC dbo.UpdateTotalDebitCredit

drop table #tmp1
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_CNDNFromJob]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin
delete a from Acc_TransactionHD a
inner join [job_3x].dbo.Job_CNDNHeader b 
on a.AccDocNo=b.DocNo
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and b.CustCode like @custcode+'%'; 

delete a from Acc_TransactionDT a 
inner join [job_3x].dbo.Job_CNDNHeader b 
on a.AccDocNo=b.DocNo
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and b.CustCode like @custcode+'%'; 

insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select 
d.DocNo,d.ItemNo,d.BillingNo as SourceDocNo,d.BillItemNo as SourceDocItem,0 as StockNo,
(case when d.DiffAmt>0 then -1 else 1 end),
(case when d.SICode not like 'ADV%' then d.DiffAmt else d.DiffAmt+d.VATAmt end)*-1 
,'SET','THB',1,
(case when d.SICode not like 'ADV%' then d.DiffAmt else d.DiffAmt+d.VATAmt end)*-1 
,d.SICode,i.RefNo,
(case when d.SICode not like 'ADV%' then d.VATRate else 0 end),
(case when d.SICode not like 'ADV%' then d.WHTRate else 0 end)
,1
from [job_3x].dbo.Job_CNDNDetail d
inner join [job_3x].dbo.Job_CNDNHeader h
on d.BranchCode=h.BranchCode 
and d.DocNo=h.DocNo
inner join [job_3x].dbo.Job_InvoiceHeader i 
on d.BranchCode=i.BranchCode and d.BillingNo=i.DocNo
inner join [job_3x].dbo.Job_InvoiceDetail s on d.BillingNo=s.DocNo and d.BillItemNo=s.ItemNo
inner join [job_3x].dbo.Job_SrvSingle c on s.SICode=c.SICode
where h.CancelDate is null and d.CorrectAmt<>0 and c.IsExpense=0 and c.IsCredit=0
and h.DocDate>=@datefrom and h.DocDate<=@dateto
and h.CustCode like @custcode+'%'; 

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,
IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
select h.DocNo,h.DocDate,h.DocDate,h.CustCode,concat(c.TaxNumber,'/',c.Branch),c.NameThai,c.TAddress,
h.EmpCode,'CN3',h.DocDate,h.DocDate,1,h.Remark
from
[job_3x].dbo.Job_CNDNHeader h 
left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
where h.CancelDate is null 
and exists(select 1 from Acc_TransactionDT where AccDocNo=h.DocNo)
and h.DocDate>=@datefrom and h.DocDate<=@dateto
and h.CustCode like @custcode+'%'; 
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE procedure [dbo].[Insert_CNDNFromJob_V2]
(
	@datefrom date,
	@dateto date
)
as 
begin
select * into #tmp1 from (
	select a.DocNo,a.DocDate,a.ApproveDate,a.Remark,c.NameThai as CustName,a.EmpCode,
	d.RefNo as ReFNo,
	d.DocDate as BillDate,
	a1.AccCode as AccCode1,
	(case when e.IsCredit=1 then dbo.GetAccConfig('AR_CONFIG','Advance') else a2.AccCode end) as AccCode2,
	b.OriginalAmt,b.CorrectAmt,
	b.CorrectAmt-b.OriginalAmt as Amt,b.VATAmt as AmtVat,ABS(b.DiffAmt)+ABS(b.VATAmt) as AmtTotal,f.ReceiptNo,
	f.Amt as ReceiveAmt,f.AmtVAT as ReceiveVat,b.BillingNo,
	b.SDescription
	from 
	[job_3x].dbo.Job_CNDNHeader a
	inner join [job_3x].dbo.Job_CNDNDetail b 
	on a.DocNo=b.DocNo 
	inner join [job_3x].dbo.Job_InvoiceHeader d 
	on b.BillingNo=d.DocNo 
	inner join [job_3x].dbo.Mas_Company c 
	on d.BillToCustCode=c.CustCode and d.BillToCustBranch=c.Branch
	inner join [job_3x].dbo.Job_SrvSingle e on b.SIcode=e.SICode 
	inner join Mas_AccCode a1 on e.GLAccountCodeCost=a1.AccCode 
	inner join Mas_AccCode a2 on c.GLAccountCode=a2.AccCode 
	left join [job_3x].dbo.Job_ReceiptDetail f on 
	b.BillingNo=f.InvoiceNo and b.BillItemNo=f.InvoiceItemNo
	where a.DocStatus<>99 
and a.DocDate>=@datefrom and a.DocDate<=@dateto 
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('AJ-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('AJ-',a.DocNo) as DocNo,a.DocDate,a.ApproveDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.ApproveDate,a.EmpCode,a.CustName 

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCode1 as AccCode,BillingNo as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit	
	from #tmp1 where Amt>0
	group by DocNo,AccCode1,BillingNo,RefNo
	union all
	select DocNo,AccCode1 as AccCode,BillingNo,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode1,BillingNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0 And Amt>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,CustName,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0 And Amt<0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCode2 as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1 where Amt>0
	group by DocNo,AccCode2,SDescription,RefNo
	union all
	select DocNo,AccCode2 as AccCode,SDescription,RefNo as SubAccName,
	sum(ABS(Amt)) as Debit,0 as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode2,SDescription,RefNo 
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('AJ-',DocNo)=h.JournalNo)

drop table #tmp1 
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE procedure [dbo].[Insert_CNDNToJournal]
(
	@datefrom date,
	@dateto date
)
as 
begin
delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CNDNHeader b 
on a.JournalNo=concat('AJ-R',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_CNDNHeader b 
on a.JournalNo=concat('AJ-R',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto

select * into #tmp1 from (
select a.DocNo,a.DocDate,a.ApproveDate,a.Remark,c.NameThai as CustName,a.EmpCode,
d.RefNo as ReFNo,
d.DocDate as BillDate,
a1.AccCode as AccCode1,
(case when e.IsCredit=1 then dbo.GetAccConfig('AR_CONFIG','Advance') else a2.AccCode end) as AccCode2,
b.OriginalAmt,b.CorrectAmt,
b.CorrectAmt-b.OriginalAmt as Amt,b.VATAmt as AmtVat,ABS(b.DiffAmt)+ABS(b.VATAmt) as AmtTotal,f.ReceiptNo,
f.Amt as ReceiveAmt,f.AmtVAT as ReceiveVat,b.BillingNo,
b.SDescription
from 
[job_3x].dbo.Job_CNDNHeader a
inner join [job_3x].dbo.Job_CNDNDetail b 
on a.DocNo=b.DocNo 
inner join [job_3x].dbo.Job_InvoiceHeader d 
on b.BillingNo=d.DocNo 
inner join [job_3x].dbo.Mas_Company c 
on d.BillToCustCode=c.CustCode and d.BillToCustBranch=c.Branch
inner join [job_3x].dbo.Job_SrvSingle e on b.SIcode=e.SICode 
inner join Mas_AccCode a1 on e.GLAccountCodeCost=a1.AccCode 
inner join Mas_AccCode a2 on c.GLAccountCode=a2.AccCode 
left join [job_3x].dbo.Job_ReceiptDetail f on 
b.BillingNo=f.InvoiceNo and b.BillItemNo=f.InvoiceItemNo
where a.DocStatus<>99 
and a.DocDate>=@datefrom and a.DocDate<=@dateto 
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('AJ-R',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('AJ-R',a.DocNo) as DocNo,a.DocDate,isnull(a.ApproveDate,a.DocDate),a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.ApproveDate,a.EmpCode,a.CustName 

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCode1 as AccCode,SDescription as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit	
	from #tmp1 where Amt>0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,AccCode1 as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0 And Amt>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0 And Amt<0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1 where Amt>0
	group by DocNo,AccCode2,BillingNo,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	sum(ABS(Amt)) as Debit,0 as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode2,BillingNo,RefNo 
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('AJ-R',DocNo)=h.JournalNo)

drop table #tmp1 
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CNDNToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
















CREATE procedure [dbo].[Insert_CNDNToJournal_V2]
(
	@datefrom date,
	@dateto date
)
as 
begin
delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_CNDNHeader b 
on a.JournalNo=concat('AJ-R',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_CNDNHeader b 
on a.JournalNo=concat('AJ-R',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto

select * into #tmp1 from (
select a.DocNo,a.DocDate,a.ApproveDate,a.Remark,c.NameThai as CustName,a.EmpCode,
d.RefNo as ReFNo,
d.DocDate as BillDate,
(case when e.IsCredit=1 then isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) 
else 
isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) end) as AccCode1,
(case when e.IsCredit=1 then 
isnull(av.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) else 
isnull(ar.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) end) as AccCode2,
b.OriginalAmt,b.CorrectAmt,
b.CorrectAmt-b.OriginalAmt as Amt,b.VATAmt as AmtVat,ABS(b.DiffAmt)+ABS(b.VATAmt) as AmtTotal,f.ReceiptNo,
f.Amt as ReceiveAmt,f.AmtVAT as ReceiveVat,b.BillingNo,
b.SDescription
from 
[job_3x].dbo.Job_CNDNHeader a
inner join [job_3x].dbo.Job_CNDNDetail b 
on a.DocNo=b.DocNo 
inner join [job_3x].dbo.Job_InvoiceHeader d 
on b.BillingNo=d.DocNo 
left join [job_3x].dbo.Mas_Company c 
on concat(isnull(d.BillToCustCode,d.CustCode),isnull(d.BillToCustBranch,d.CustBranch))=concat(c.CustCode,c.Branch)
inner join [job_3x].dbo.Job_SrvSingle e on b.SIcode=e.SICode 
left join (select * from vMas_AccCode where AccCode like 
dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
left join (select * from vMas_AccCode where AccCode like 
'4___-__-____') a3 
on concat(a3.AccMainName,'-',e.NameThai)=a3.AccName	
left join (select * from vMas_AccCode where AccCode like 
dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ar 
on concat(ar.AccMainName,'-',c.NameThai)=ar.AccName	
left join (select * from vMas_AccCode where AccCode like 
dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') av 
on concat(av.AccMainName,'-',c.NameThai)=av.AccName	
left join [job_3x].dbo.Job_ReceiptDetail f on 
b.BillingNo=f.InvoiceNo and b.BillItemNo=f.InvoiceItemNo
where a.DocStatus<>99 
and a.DocDate>=@datefrom and a.DocDate<=@dateto 
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('AJ-R',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('AJ-R',a.DocNo) as DocNo,a.DocDate,isnull(a.ApproveDate,a.DocDate),a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.ApproveDate,a.EmpCode,a.CustName 

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCode1 as AccCode,SDescription as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit	
	from #tmp1 where Amt>0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,AccCode1 as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,sum(ABS(AmtVat)) as Credit
	from #tmp1 where AmtVat<0 And Amt>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0 And Amt<0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1 where Amt>0
	group by DocNo,AccCode2,BillingNo,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	sum(ABS(Amt)) as Debit,0 as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode2,BillingNo,RefNo 
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('AJ-R',DocNo)=h.JournalNo)

drop table #tmp1 
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CostFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










CREATE procedure [dbo].[Insert_CostFromAdvance]
(
	@datefrom date,
	@dateto date
)
as
begin
select * into #tmp1 from (
	select concat(a.ClrNo,'-',a.ItemNo) as DocNo,a.Date50Tavi as DocDate,a.JobNo as RefNo,c.PaymentDate as PaymentDate,
	isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeD,
	isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCodeC,
	a.UsedAmount as Amt,a.ChargeVAT as AmtVat,a.Tax50Tavi as Amt50Tavi,(a.UsedAmount+a.ChargeVAT-a.Tax50Tavi) as AmtTotal,
	a.SIcode,a.SDescription,a.JobNo ,b.EmpCode,e.TaxNumber,e.TName as VenderName
	from [job_3x].dbo.Job_ClearDetail a
	inner join [job_3x].dbo.Job_ClearHeader b 
	on a.ClrNo=b.ClrNo 
	inner join [job_3x].dbo.Job_AdvHeader c
	on a.AdvNo=c.AdvNo 
	inner join [job_3x].dbo.Job_SrvSingle d
	on a.SICode=d.SICode 
	left join Mas_AccCode a1 on d.GLAccountCodeSales=a1.AccCode
	left join Mas_AccCode a2 on d.GLAccountCodeCost=a2.AccCode
	left join [job_3x].dbo.Mas_Vender e on a.VenderCode=e.VenCode
	where b.DocStatus<>99 and d.IsExpense=1
	and a.Date50Tavi>=@datefrom and a.Date50Tavi<=@dateto 
) tb


delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('PV-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
concat('PV-',a.DocNo) as DocNo,a.DocDate,a.PaymentDate,a.EmpCode,a.RefNo,sum(a.AmtTotal+a.Amt50Tavi),sum(a.AmtTotal+a.Amt50Tavi)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.PaymentDate,a.EmpCode,a.RefNo 

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,AccName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,SDescription as AccName,RefNo as SubAccName,
	sum(Amt) as Debit,0 as Credit
	from #tmp1 
	group by DocNo,AccCodeD,SDescription,RefNo
	union all 
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,VenderName as AccName,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,VenderName,RefNo
	union all
	select DocNo,dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,VenderName as AccName,RefNo as SubAccName,
	0 as Debit,sum(Amt50Tavi) as Credit
	from #tmp1 where Amt50Tavi>0
	group by DocNo,VenderName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription as AccName,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 
	group by DocNo,AccCodeC,SDescription,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-',DocNo)=h.JournalNo)

drop table #tmp1
end 

GO
/****** Object:  StoredProcedure [dbo].[Insert_CostFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_CostFromJob]
(
@datefrom date,
@dateto date
)
as
begin
--cost with invoice
insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select h.EntryId as Id,
(select MAX(ItemNo) from vJournal_All where JournalNo=c.AccDocNo)+ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo) 
as Seq,
AccCode,AccDesc,AccDocNo,Debit,Credit
from 
(
	--Dr. Expense Account Code from Mas_Products
	select b.AccDocNo,a.AccDocNo as DocRefno,
	a.ExpenseAccCode as AccCode,a.ProductName as AccName,a.SalesDescription as AccDesc,sum(a.Amount) as Debit,0 as Credit
	from vPC_D a 
	inner join (
		select DocRefNo,MAX(AccDocNo) as AccDocNo
		from Acc_TransactionHD
		where AccDocType='SI'
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by DocRefNo
	) b on a.SalesDescription=b.DocRefno
	where not exists(select 1 from vTransaction_All where AccDocType='SI' and DocRefNo=a.SalesDescription and AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	and a.AccDocType='PC' and a.ProductCode not like 'A%' and a.ProductCode not like 'S%'				
	group by b.AccDocNo,a.AccDocNo,a.ExpenseAccCode,a.ProductName,a.SalesDescription
	union all
	--Dr. Input VAT
	select b.AccDocNo as InvNo,a.AccDocNo,
	p.AccCode,a.ProductName,a.SalesDescription,sum(a.VatAmount) as Debit,0 as Credit
	from vPC_D a 
	inner join (
		select DocRefNo,MAX(AccDocNo) as AccDocNo
		from Acc_TransactionHD
		where AccDocType='SI'
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by DocRefNo
	) b on a.SalesDescription=b.DocRefno,vMas_AccCode p
	where a.VatAmount>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')			
	and not exists(select 1 from vTransaction_All where AccDocType='SI' and DocRefNo=a.SalesDescription and AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	and a.AccDocType='PC' and a.ProductCode not like 'A%' and a.ProductCode not like 'S%'	
	group by b.AccDocNo,a.AccDocNo,p.AccCode,a.ProductName,a.SalesDescription
	UNION ALL
	--Cr. With-holding Tax
	select b.AccDocNo as InvNo,a.AccDocNo,
	p.AccCode,a.ProductName,a.SalesDescription,0 as Debit,sum(a.WhtAmount) as Credit
	from vPC_D a 
	inner join (
		select DocRefNo,MAX(AccDocNo) as AccDocNo
		from Acc_TransactionHD
		where AccDocType='SI'
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by DocRefNo
	) b on a.SalesDescription=b.DocRefno,vMas_AccCode p
	where a.WhtAmount>0 and p.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')			
	and not exists(select 1 from vTransaction_All where AccDocType='SI' and DocRefNo=a.SalesDescription and AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	and a.AccDocType='PC' and a.ProductCode not like 'A%' and a.ProductCode not like 'S%'	
	group by b.AccDocNo,a.AccDocNo,p.AccCode,a.ProductName,a.SalesDescription
	union all
	--Cr Work In process
	select b.AccDocNo as InvNo,a.AccDocNo,
	p.AccCode,a.ProductName,a.SalesDescription,0 as Debit,sum(a.Amount+a.VatAmount-a.WhtAmount) as Credit
	from vPC_D a 
	inner join (
		select DocRefNo,MAX(AccDocNo) as AccDocNo
		from Acc_TransactionHD
		where AccDocType='SI'
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by DocRefNo
	) b on a.SalesDescription=b.DocRefno,vMas_AccCode p
	where p.AccCode=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')			
	and not exists(select 1 from vTransaction_All where AccDocType='SI' and DocRefNo=a.SalesDescription and AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	and a.AccDocType='PC' and a.ProductCode not like 'A%' and a.ProductCode not like 'S%'
	--and a.AccSourceDocItem>0
	group by b.AccDocNo,a.AccDocNo,p.AccCode,a.ProductName,a.SalesDescription
	/*
	union all
	select b.AccDocNo as InvNo,
	p.AccCode,a.ProductName,a.SalesDescription,0 as Debit,sum(a.Amount+a.VatAmount-a.WhtAmount) as Credit
	from vPC_D a 
	inner join (
		select DocRefNo,MAX(AccDocNo) as AccDocNo
		from Acc_TransactionHD
		where AccDocType='SI'
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by DocRefNo
	) b on a.SalesDescription=b.DocRefno,vMas_AccCode p
	where p.AccCode=dbo.GetAccConfig('AP_CONFIG','CashOut')			
	and not exists(select 1 from vTransaction_All where AccDocType='SI' and DocRefNo=a.SalesDescription and AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	and a.AccDocType='PC' and a.ProductCode not like 'A%' and a.ProductCode not like 'S%'
	and a.AccSourceDocItem=0
	group by b.AccDocNo,p.AccCode,a.ProductName,a.SalesDescription
	*/
) c inner join Acc_JournalHD h on c.AccDocNo=h.JournalNo


delete a from Acc_JournalDT a where not exists(select 1 from Acc_JournalHD where EntryID=a.EntryID)
--*/
--without invoice
declare @id int =(select isnull(MAX(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
select EntryId,CONCAT('PV-',h.AccDocNo) as JVNo,AccBatchDate,AccEffectiveDate,IssueBy,SalesDescription,0,0
from (
    select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo,SalesDescription) as EntryId,* from
    (
        select distinct  
        a.AccDocNo,a.AccBatchDate,a.AccEffectiveDate,a.IssueBy,a.SalesDescription,b.TotalExpense as Dr,b.TotalExpense as Cr
        from vPC_D a inner join [job_3x].dbo.Job_ClearHeader b on a.DocRefNo=b.ClrNo 
		left join (
			select DocRefNo,MAX(AccDocNo) as AccDocNo
			from Acc_TransactionHD
			where AccDocType='SI'
			and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
			group by DocRefNo
		) c on a.SalesDescription=c.DocRefno
		where b.ClrDate>=@datefrom and b.ClrDate<=@dateto 
		and c.AccDocNo is null
    ) t
) h 
where not exists(select 1 from Acc_JournalHD where JournalNo=CONCAT('PV-',h.AccDocNo))

insert into Acc_JournalDT (EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select EntryId,Seq,AccCode,AccDesc,d.AccDocNo,Dr,Cr from (
    select @id+DENSE_RANK() OVER (ORDER BY d.AccDocNo,d.SalesDescription) as EntryId,
    ROW_NUMBER() OVER (PARTITION BY d.AccDocNo,d.SalesDescription ORDER BY d.AccDocNo,d.SalesDescription) as Seq,
    d.AccDocNo,d.SalesDescription,t.AccCode,t.AccName,t.AccDesc,sum(t.Debit) as Dr,sum(t.Credit) as Cr 
    from (
		--Cr. Work In Process
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccName,a.SalesDescription as AccDesc,
        0 as Debit,a.Amount+a.VatAmount-a.WhtAmount as Credit
        from vPC_D a,vMas_AccCode b
        where b.AccCode=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
		and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        UNION ALL
		--Dr. Expense Account Code
        select a.AccDocNo,a.AccItemNo,a.ExpenseAccCode,a.ProductName as AccDesc,a.SalesDescription as AccDesc,
        a.Amount as Debit,0 as Credit 
        from vPC_D a
		where a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        UNION ALL
		--Dr. Input VAT
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccDesc,a.SalesDescription as AccDesc,
        a.VatAmount as Debit,0 as Credit
		from vPC_D a,vMas_AccCode b
		where a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        and a.VatAmount>0 AND b.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')
		UNION ALL
		--Cr. With-holding Tax (Company)
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccDesc,a.SalesDescription as AccDesc,
        0 as Debit,a.WhtAmount as Credit
		from vPC_D a,vMas_AccCode b
		where a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        and a.WhtAmount>0 AND b.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
		and a.PartyTaxCode like '0%'
		UNION ALL
		--Cr. With-holding Tax (Person)
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccDesc,a.SalesDescription as AccDesc,
        0 as Debit,a.WhtAmount as Credit
		from vPC_D a,vMas_AccCode b
		where a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        and a.WhtAmount>0 AND b.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
		and a.PartyTaxCode not like '0%'
    ) t inner join vPC_D d on t.AccDocNo=d.AccDocNo and t.AccItemNo=d.AccItemNo
    inner join [job_3x].dbo.Job_ClearHeader b on d.DocRefNo=b.ClrNo 
    group by d.AccDocNo,d.SalesDescription,t.AccCode,t.AccName,t.AccDesc
) d 
left join (
	select DocRefNo,MAX(AccDocNo) as AccDocNo
	from Acc_TransactionHD
	where AccDocType='SI'
	and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
	group by DocRefNo
) b on d.AccDesc=b.DocRefno
where not exists(select 1 from Acc_JournalDT where EntryId=d.EntryId and seq=d.Seq)
and b.AccDocNo is null

--clear error
delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)
--update total
update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CostToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_CostToJournal]
(
@datefrom date,
@dateto date,
@userid varchar(20)
)
as
begin
declare @maxid int=(select isnull(max(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalDT
select 
@maxid+DENSE_RANK() OVER(ORDER BY ClrNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ClrNo ORDER BY ClrNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
--Cr.ภาษีซื้อ
select c.AccCode,cd.SDescription as AccName,cd.ChargeVAT as Debit,0 as Credit 
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join [job_3x].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')=''
and cd.ChargeVAT>0
and c.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
union all
--Cr.เงินทดรองจ่ายพนักงาน
select c.AccCode,cd.SDescription,
0 as Debit,cd.UsedAmount+cd.ChargeVAT-cd.Tax50Tavi as Credit	
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join [job_3x].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')=''
and c.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
union all
--Cr.หัก ณ ที่จ่าย
select c.AccCode,cd.SDescription,0 as Debit,cd.Tax50Tavi as Credit 
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join [job_3x].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')=''
and cd.Tax50Tavi>0
and c.AccCode=dbo.GetAccConfig('WHT_CONFIG','InputTax')
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
union all
--Dr.ค่าใช้จ่าย
select p.ExpenseAccCode as AccCode,cd.SDescription as AccName,
cd.UsedAmount as Debit,0 as Credit
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
left join [job_3x].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo 
inner join vMas_Product p
on cd.SICode=p.ProductCode 
where ch.DocStatus<>99 and s.IsExpense=1
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
union all
--Dr.ภาษีซื้อยังไม่ถึงกำหนด
select c.AccCode,cd.SDescription as AccName,cd.ChargeVAT as Debit,0 as Credit 
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
left join [job_3x].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')='' and a.AdvNo is null
and cd.ChargeVAT>0
and c.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
union all
--Cr.เจ้าหนี้การค้า
select c.AccCode as AccCode,cd.SDescription as AccName,
0 as Debit,cd.UsedAmount+cd.ChargeVAT as Credit
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
left join [job_3x].dbo.Job_AdvDetail a
on cd.AdvNO=a.AdvNo and cd.AdvItemNo=a.ItemNo 
inner join vMas_Product p
on cd.SICode=p.ProductCode ,
vMas_AccCode c 
where ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')='' and a.AdvNO is null
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
and c.AccCode=dbo.GetAccConfig('AP_CONFIG','Purchase')
) t
where t.ClrNo not in(select JournalNo from Acc_JournalHD)

insert into Acc_JournalHD
select @maxid+ROW_NUMBER() OVER(ORDER BY ClrNo) as EntryID,
ClrNo,ClrDate,ClrDate,@userid,'-',TotalClr,TotalClr
from (
select ch.ClrNo,ch.ClrDate,sum(cd.UsedAmount+cd.ChargeVAT) as totalClr
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join vMas_Product p
on cd.SICode=p.ProductCode
where ch.DocStatus<>99 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')=''
and ch.ClrDate>=@datefrom and ch.ClrDate<=@dateto
group by ch.ClrNo,ch.ClrDate
) t
where t.ClrNo not in(select JournalNo from Acc_JournalHD)

EXEC dbo.Insert_RefundFromJob @datefrom,@dateto,@userid
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CostToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_CostToJournal_V2]
(
@datefrom date,
@dateto date,
@userid varchar(20)
)
as
begin
declare @maxid int=(select isnull(max(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalDT
select 
@maxid+DENSE_RANK() OVER(ORDER BY ClrNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ClrNo ORDER BY ClrNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
--Dr.ภาษีซื้อ
select c.AccCode,concat(isnull(v.TaxNumber,''),' - ',isnull(v.TName,'')) as AccDesc,cd.ChargeVAT as Debit,0 as Credit 
,cd.JobNo as AccName,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_Order j on cd.JobNo=j.JNo 
left join [job_3x].dbo.Mas_Vender v on cd.VenderCode=v.VenCode
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and s.IsExpense=1 and not s.IsCredit=1
and isnull(cd.VenderbillingNo,'')='' and isnull(cd.AdvNO,'')=''
and cd.ChargeVAT>0
and c.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')
and isnull(cd.Date50Tavi,ch.ClrDate)>=@datefrom and isnull(cd.Date50Tavi,ch.ClrDate)<=@dateto
union all
--Cr.เงินสดย่อย
select c.AccCode,concat(ch.ClrNo,(case when ch.ReceiveRef<>'' then ' PV#' else '' end),ch.ReceiveRef) as AccDesc,
0 as Debit,
(case when s.IsCredit=0 then cd.UsedAmount+cd.ChargeVAT-cd.Tax50Tavi else cd.UsedAmount+cd.ChargeVAT end) as Credit	
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and not (s.IsExpense=0 and s.IsCredit=0)
and isnull(cd.VenderbillingNo,'')='' and isnull(cd.AdvNO,'')=''
and c.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
and isnull(cd.Date50Tavi,ch.ClrDate)>=@datefrom and isnull(cd.Date50Tavi,ch.ClrDate)<=@dateto
union all
--Cr.หัก ณ ที่จ่าย
select c.AccCode,cd.SDescription,0 as Debit,
cd.Tax50Tavi as Credit 
,cd.JobNo,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join vMas_Product p
on cd.SICode=p.ProductCode,
vMas_AccCode c
where ch.DocStatus<>99 and s.IsExpense=1 and not s.IsCredit=1
and isnull(cd.VenderbillingNo,'')='' and isnull(cd.AdvNo,'')=''
and cd.Tax50Tavi>0
and c.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
and isnull(cd.Date50Tavi,ch.ClrDate)>=@datefrom and isnull(cd.Date50Tavi,ch.ClrDate)<=@dateto
union all
--Dr.ลูกหนี้เงินทดรองจ่าย
select u.GLAccountCode as AccCode,cd.SDescription as AccName,
cd.UsedAmount+cd.ChargeVAT as Debit,0 as Credit
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Mas_User u
on ch.EmpCode=u.UserID
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
where ch.DocStatus<>99 and s.IsCredit=1
and isnull(cd.VenderbillingNo,'')='' and isnull(cd.AdvNo,'')=''
and isnull(cd.Date50Tavi,ch.ClrDate)>=@datefrom and isnull(cd.Date50Tavi,ch.ClrDate)<=@dateto
union all
--Dr.ค่าใช้จ่าย
select s.GLAccountCodeCost as AccCode,cd.SDescription as AccName,
cd.UsedAmount as Debit,0 as Credit
,cd.JobNo as AccDesc,cd.ClrNo,ch.ClrDate
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
where ch.DocStatus<>99 and not s.IsCredit=1 and s.IsExpense=1
and isnull(cd.VenderbillingNo,'')='' and isnull(cd.AdvNo,'')=''
and isnull(cd.Date50Tavi,ch.ClrDate)>=@datefrom and isnull(cd.Date50Tavi,ch.ClrDate)<=@dateto
) t
where t.ClrNo not in(select JournalNo from Acc_JournalHD)

insert into Acc_JournalHD
select @maxid+ROW_NUMBER() OVER(ORDER BY ClrNo) as EntryID,
ClrNo,ClrDate,ClrDate,@userid,'-',TotalClr,TotalClr
from (
select ch.ClrNo,ch.ClrDate,sum(cd.UsedAmount+cd.ChargeVAT) as totalClr
from [job_3x].dbo.Job_ClearDetail cd
inner join [job_3x].dbo.Job_ClearHeader ch
on cd.ClrNo=ch.ClrNo 
inner join [job_3x].dbo.Job_SrvSingle s
on cd.SICode=s.SICode 
inner join vMas_Product p
on cd.SICode=p.ProductCode
where ch.DocStatus<>99 and not (s.IsExpense=0 and s.IsCredit=0) 
and isnull(cd.VenderbillingNo,'')='' and isnull(cd.AdvNo,'')=''
and isnull(cd.Date50Tavi,ch.ClrDate)>=@datefrom and isnull(cd.Date50Tavi,ch.ClrDate)<=@dateto
group by ch.ClrNo,ch.ClrDate
) t
where t.ClrNo not in(select JournalNo from Acc_JournalHD)

--EXEC dbo.Insert_RefundFromJob @datefrom,@dateto,@userid
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_CustAdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_CustAdvanceToJournal]
(
	@datefrom date,
	@dateto date
)
as
begin
delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('PV-R',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('PV-R',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto

select * into #tmp1 from (
select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','ChequeIn')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.CustCode,a.CustBranch)=concat(cb.CustCode,cb.Branch)
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product p on b.SICode=p.ProductCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','ChequeIn')+'-____') ac 
	on concat(ac.AccMainName,'-',cb.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ab 
	on concat(ab.AccMainName,'-',c.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 and b.AmtCredit>0
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','ChequeIn')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.CustCode,a.CustBranch)=concat(cb.CustCode,cb.Branch)
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','ChequeIn')+'-____') ac 
	on concat(ac.AccMainName,'-',cb.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',c.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 and b.AmtCredit>0
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('PV-R',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
concat('PV-R',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,CustName,AccCodeD as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(TotalCustAdv) as Credit
	from #tmp1 where TotalCustAdv>0
	group by AccCodeD,DocNo,SDescription,RefNo,CustName
	union all
	select DocNo,CustName,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	sum(TotalCustAdv) as Debit,0 as Credit
	from #tmp1 where TotalCustAdv>0
	group by AccCodeC,DocNo,SDescription,RefNo,CustName
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-R',DocNo)=h.JournalNo)

drop table #tmp1;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_DepreByDate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
declare @warehousecode varchar(20)='EQ'
declare @assetcode varchar(100)='EQ-2023010040'
declare @deliveryno varchar(50)='DI26070012'
declare @remark nvarchar(max)='ค่าเสื่อมราคางวด 2569/07'
declare @firstdate date='2026-07-21'
declare @lastdate date='2026-07-31'
DECLARE @userid varchar(10)='ADMIN'
DECLARE @doctype varchar(5)='JV'
*/
CREATE procedure [dbo].[Insert_DepreByDate]
(
	@warehousecode varchar(20),
	@assetcode varchar(20),
	@deliveryno varchar(50),
	@firstdate date,
	@lastdate date,
	@remark nvarchar(max),
	@userid varchar(20),
	@doctype varchar(5)='JV'
)
as
begin
declare @acccode varchar(20)=(select AssetAccCode from vStock_Onhand where StockProductCode=@assetcode and WarehouseCode=@warehousecode)
declare @startdate date=(select AccBatchDate from vCalculate_Depre_Straight where ProductCode=@assetcode and DeliveryNo=@deliveryno)

declare @depreyearly decimal(10,2)=(select DepreYearly from vCalculate_Depre_Straight where ProductCode=@assetcode and DeliveryNo=@deliveryno)

DECLARE @RC int
DECLARE @docno varchar(20)=''
DECLARE @description nvarchar(max)= @remark +' ของ '+@assetcode

DECLARE @docdate date=@lastdate
DECLARE @effectivedate date=@lastdate
DECLARE @amount decimal(10,2)=(datediff(day,@firstdate,@lastdate)+1)*(@depreyearly/datediff(day,@firstdate,DATEADD(year,1,@firstdate)))
DECLARE @accdebit varchar(10)=(select DebitAccCode from Mas_AccCodeConfig where AccCode=@acccode)
DECLARE @debitremark varchar(max)=@remark
DECLARE @acccredit varchar(10)=(select CreditAccCode from Mas_AccCodeConfig where AccCode=@acccode)
DECLARE @creditremark varchar(max)=@assetcode

-- TODO: Set parameter values here.

EXECUTE @RC = [dbo].[Insert_QuickJournal] 
   @doctype
  ,@docno
  ,@description
  ,@userid
  ,@docdate
  ,@effectivedate
  ,@amount
  ,@accdebit
  ,@debitremark
  ,@acccredit
  ,@creditremark

END



GO
/****** Object:  StoredProcedure [dbo].[Insert_DIFromPC]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE procedure [dbo].[Insert_DIFromPC]
(
@pcno nvarchar(20),
@docdate date,
@duedate date,
@refno nvarchar(50),
@userid nvarchar(50),
@itemno int=0,
@qty float=0,
@dno nvarchar(20)='',
@whcode nvarchar(20)=''
)
as 
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DI')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @doctype nvarchar(5);
set @doctype='DI';

declare @docno nvarchar(20);
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @dno<>''
begin
 set @docno=@dno;
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@duedate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,@docdate as PostDate,@docdate as SaveDate,1 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@pcno
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@docno);
if @ino is null
begin
 set @ino=0;
end

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY a.AccItemNo)+@ino as AccItemNo,a.AccSourceDocNo,a.AccSourceDocItem,0,a.Qty,
	((TotalAmount/ExchangeRate)/Qty),a.UnitMea,a.Currency,a.ExchangeRate,(TotalAmount/ExchangeRate),a.SaleProductCode,a.SalesDescription,
	a.RateVat,a.RateWht,1
	from vPC_D a
	where a.AccDocNo=@pcno
	and not exists(select 1 from vDI_D where AccSourceDocNo=a.AccSourceDocNo and AccSourceDocItem=a.AccSourceDocItem
	and DocStatus<>99)
end
else
begin
	if @qty=0
	begin
	   set @qty=(select Qty from vPC_D where AccDocNo=@pcno And AccItemNo=@itemno);
	end
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,a.AccSourceDocNo,a.AccSourceDocItem,0,@qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,(@qty*(TotalAmount/Qty)),SaleProductCode,SalesDescription,RateVat,RateWht,1
	from vPC_D a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	where a.AccDocNo=@pcno and a.AccItemNo=@itemno
	and not exists(select 1 from vDI_D where AccSourceDocNo=a.AccSourceDocNo and AccSourceDocItem=a.AccSourceDocItem
	and DocStatus<>99)
end 

insert into Acc_StockTransaction (TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select 
CONCAT(a.AccDocNo,'#',a.AccItemNo),'IN' as TransType,
a.SaleProductCode,a.Qty,a.Price,a.Currency,a.ExchangeRate, 
c.AssetAccCode,(case when not @whcode='' then @whcode else c.WarehouseCode end),CONCAT(a.AccSourceDocNo,'#',a.AccSourceDocItem)
from vDI_All a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
where a.AccDocNo=@docno and c.IsService=0 and a.StockTransNo=0
--and not exists(select 1 from Acc_StockTransaction where RefDocNo=CONCAT(a.AccSourceDocNo,'#',a.AccSourceDocItem))

delete from Acc_TransactionHD where AccDocNo=@docno
and not exists(select 1 from Acc_TransactionDT where AccDocNo=@docno)

update a
set a.StockTransNo=d.TransID
from Acc_TransactionDT a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
inner join Acc_StockTransaction d
on CONCAT(a.AccDocNo,'#',a.AccItemNo)=d.TransNum
where a.AccDocNo=@docno AND a.StockTransNo=0
and b.DocStatus<>99

--update Acc_TransactionHD set DocStatus=1,AccPostDate=@docdate where AccDocNo=@pcno;
delete a from Acc_TransactionHD a where not exists(select AccDocNo from Acc_TransactionDT where AccDocNo=a.AccdocNo)

select * from vTransaction_H where AccDocNo=@docno;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_DIFromPI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE procedure [dbo].[Insert_DIFromPI]
(
@pino nvarchar(20),
@docdate date,
@refno nvarchar(50),
@userid nvarchar(50),
@costtype int=0,--0=FIFO
@itemno int=0,
@qty float=0,
@dno nvarchar(20)='',
@whcode nvarchar(20)=''
)
as 
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DI')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @doctype nvarchar(5);
set @doctype='DI';

declare @docno nvarchar(20);
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @dno<>''
begin
 set @docno=@dno;
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@docdate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,'1900-01-01' as PostDate,
	@docdate as SaveDate,1 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@pino
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)
and not exists(select 1 from Acc_StockTransaction where RefDocNo like concat(@pino,'#',@itemno))

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@docno);

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,a.AccSourceDocNo,a.AccSourceDocItem,0,Qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,TotalAmount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType
	from vAP_D a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	where b.AccDocNo=@pino
	and not exists(select 1 from vDI_D where AccSourceDocNo=a.AccSourceDocNo and AccSourceDocItem=a.AccSourceDocItem
	and AccSourceDocNo<>'')
	and not exists(select 1 from Acc_StockTransaction where RefDocNo like concat(@pino,'#',@itemno))
end
else
begin
	if @qty=0
	begin
		set @qty=(select Qty from Acc_TransactionDT where AccDocNo=@docno and AccItemNO=@itemno);
	end

	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,a.AccSourceDocNo,a.AccSourceDocItem,0,@qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,(@qty*(TotalAmount/Qty)),SaleProductCode,SalesDescription,RateVat,RateWht,VatType
	from vAP_D a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	where a.AccDocNo=@pino and a.AccItemNo=@itemno
	and not exists(select 1 from vDI_D where AccSourceDocNo=a.AccSourceDocNo and AccSourceDocItem=a.AccSourceDocItem
	and AccSourceDocNo<>'')
	and not exists(select 1 from Acc_StockTransaction where RefDocNo like concat(@pino,'#',@itemno))
end


insert into Acc_StockTransaction (TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select 
CONCAT(a.AccDocNo,'#',a.AccItemNo),'IN' as TransType,
a.SaleProductCode,a.Qty,a.Price,a.Currency,a.ExchangeRate, 
c.AssetAccCode,(case when not @whcode='' then @whcode else c.WarehouseCode end),
concat(@pino,'#',@itemno)
from vDI_All a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
where a.AccDocNo=@docno and c.IsService=0 and a.StockTransNo=0
and not exists(select 1 from Acc_StockTransaction where RefDocNo like concat(@pino,'#',@itemno))

update a
set a.StockTransNo=d.TransID
from Acc_TransactionDT a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
inner join Acc_StockTransaction d
on CONCAT(a.AccDocNo,'#',a.AccItemNo)=d.TransNum
where a.AccDocNo=@docno AND a.StockTransNo=0
and b.DocStatus<>99
and not exists(select 1 from Acc_TransactionDT where StockTransNo=d.TransID)


delete from Acc_TransactionHD where AccDocNo=@docno
and not exists(select 1 from Acc_TransactionDT where AccDocNo=@docno)

select * from vTransaction_H where AccDocNo=@docno;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_DIFromPO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO













CREATE procedure [dbo].[Insert_DIFromPO]
(
@pono nvarchar(20),
@docdate date,
@duedate date,
@refno nvarchar(50),
@userid nvarchar(50),
@itemno int=0,
@qty float=0,
@dno nvarchar(20)='',
@whcode nvarchar(20)=''
)
as 
begin

/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DI')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @doctype nvarchar(5);
set @doctype='DI';

declare @docno nvarchar(20);
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @dno<>''
begin
 set @docno=@dno;
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@duedate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,@docdate as PostDate,@docdate as SaveDate,1 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@pono
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@docno);
if @ino is null
begin
 set @ino=0;
end

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY a.AccItemNo)+@ino as AccItemNo,a.AccDocNo,a.AccItemNo,0,b.Balance,
	(TotalAmount/a.ExchangeRate)/a.Qty,a.UnitMea,a.Currency,a.ExchangeRate,((TotalAmount/a.Qty)*Balance),a.SaleProductCode,a.SalesDescription,
	a.RateVat,a.RateWht,1
	from vPO_D a inner join vPO_Balance b
	on a.AccDocNo=b.AccDocNo and a.AccItemNo=b.AccItemNo
	where a.AccDocNo=@pono
	and b.Balance>0
end
else
begin
	if @qty=0
	begin
	   set @qty=(select Balance from vPO_Balance where AccDocNo=@pono And AccItemNo=@itemno);
	end
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,a.AccDocNo,a.AccItemNo,0,@qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,(@qty*(TotalAmount/Qty)),SaleProductCode,SalesDescription,RateVat,RateWht,1
	from vPO_D a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	where a.AccDocNo=@pono and a.AccItemNo=@itemno
end 

insert into Acc_StockTransaction (TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select 
CONCAT(a.AccDocNo,'#',a.AccItemNo),'IN' as TransType,
a.SaleProductCode,a.Qty,a.Price,a.Currency,a.ExchangeRate, 
c.AssetAccCode,(case when not @whcode='' then @whcode else c.WarehouseCode end),CONCAT(a.AccSourceDocNo,'#',a.AccSourceDocItem)
from vDI_All a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
where a.AccDocNo=@docno AND a.AccSourceDocNo=@pono and c.IsService=0 and a.StockTransNo=0

update a
set a.StockTransNo=d.TransID
from Acc_TransactionDT a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
inner join Acc_StockTransaction d
on CONCAT(a.AccDocNo,'#',a.AccItemNo)=d.TransNum
where a.AccDocNo=@docno AND a.AccSourceDocNo=@pono AND a.StockTransNo=0
and b.DocStatus<>99

delete from Acc_TransactionHD where AccDocNo=@docno
and not exists(select 1 from Acc_TransactionDT where AccDocNo=@docno)

--if @itemno=0
--begin
	--update Acc_TransactionHD set DocStatus=2,AccPostDate=@docdate where AccDocNo=@pono and DocStatus<>99
--end

select * from vTransaction_H where AccDocNo=@docno;
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_DOFromRC]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE procedure [dbo].[Insert_DOFromRC]
(
@rcno nvarchar(20),
@docdate date,
@duedate date,
@refno nvarchar(50),
@userid nvarchar(50),
@itemno int=0,
@qty float=0,
@dno nvarchar(20)='',
@whcode nvarchar(20)=''
)
as 
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DO')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @doctype nvarchar(5);
set @doctype='DO';

declare @docno nvarchar(20);
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @dno<>''
begin
 set @docno=@dno;
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@duedate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,@docdate as PostDate,@docdate as SaveDate,0 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@rcno
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@docno);
if @ino is null
begin
 set @ino=0;
end

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY a.AccItemNo)+@ino as AccItemNo,
	case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
	case when AccSourceDocNo<>'' then AccSourceDocItem else AccItemNo end
	,0,a.Qty,
	((TotalAmount/ExchangeRate)/Qty),a.UnitMea,a.Currency,a.ExchangeRate,(TotalAmount/ExchangeRate),a.SaleProductCode,a.SalesDescription,
	a.RateVat,a.RateWht,1
	from vRC_D a
	where a.AccDocNo=@rcno
	and not exists(select 1 from vDO_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end) and 
	AccSourceDocItem=(case when a.AccSourceDocNo<>'' then a.AccSourceDocItem else a.AccItemNo end))
end
else
begin
	if @qty=0
	begin
	   set @qty=(select Qty from vRC_D where AccDocNo=@rcno And AccItemNo=@itemno);
	end
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,
	case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
	case when AccSourceDocNo<>'' then AccSourceDocItem else AccItemNo end
	,0,@qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,(@qty*(TotalAmount/Qty)),SaleProductCode,SalesDescription,RateVat,RateWht,1
	from vRC_D a 
	where a.AccDocNo=@rcno and a.AccItemNo=@itemno
	and not exists(select 1 from vDO_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end) and 
	AccSourceDocItem=(case when a.AccSourceDocNo<>'' then a.AccSourceDocItem else a.AccItemNo end))
end 

--EXEC dbo.Insert_StockFromDO @docno,@docdate,0,@userid;
delete a from Acc_TransactionHD a where not exists(select 1 from Acc_TransactionDT where AccDocNo=a.AccDocNo)	

select * from vTransaction_H where AccDocNo=@docno;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_DOFromSI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE procedure [dbo].[Insert_DOFromSI]
(
@sino nvarchar(20),
@docdate date,
@refno nvarchar(50),
@userid nvarchar(50),
@costtype int=0,--0=FIFO
@itemno int=0,
@qty float=0,
@dno nvarchar(20)=''
)
as 
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DO')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @doctype nvarchar(5);
set @doctype='DO';

declare @docno nvarchar(20);
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @dno<>''
begin
 set @docno=@dno;
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@docdate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,'1900-01-01' as PostDate,@docdate as SaveDate,0 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@sino
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@docno);

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,
	case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
	case when AccSourceDocNo<>'' then AccSourceDocItem else AccItemNo end
	,0,Qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,TotalAmount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType
	from vAR_D a 
	where a.AccDocNo=@sino 
	and not exists(select 1 from vDO_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end) and 
	AccSourceDocItem=(case when a.AccSourceDocNo<>'' then a.AccSourceDocItem else a.AccItemNo end))
end
else
begin
	if @qty=0
	begin
		set @qty=(select Qty from Acc_TransactionDT where AccDocNo=@docno and AccItemNO=@itemno);
	end

	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,
	case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
	case when AccSourceDocNo<>'' then AccSourceDocItem else AccItemNo end
	,0,@qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,(@qty*(TotalAmount/Qty)),SaleProductCode,SalesDescription,RateVat,RateWht,VatType
	from vAR_D a 
	where AccDocNo=@sino and AccItemNo=@itemno
	and not exists(select 1 from vDO_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end) and 
	AccSourceDocItem=(case when a.AccSourceDocNo<>'' then a.AccSourceDocItem else a.AccItemNo end))
end

--EXEC dbo.Insert_StockFromDO @docno,@docdate,@costtype,@userid;

delete a from Acc_TransactionHD a where not exists(select 1 from Acc_TransactionDT where AccDocNo=a.AccDocNo)	

--update Acc_TransactionHD set DocStatus=2,AccPostDate=@docdate where AccDocNo=@sino;

select * from vTransaction_H where AccDocNo=@docno;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_DOFromSO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE procedure [dbo].[Insert_DOFromSO]
(
@sono nvarchar(20),
@docdate date,
@refno nvarchar(50),
@userid nvarchar(50),
@costtype int=0,--0=FIFO
@itemno int=0,
@qty float=0,
@dno nvarchar(20)=''
)
as 
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DO')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @doctype nvarchar(5);
set @doctype='DO';

declare @docno nvarchar(20);
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @dno<>''
begin
 set @docno=@dno;
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@docdate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,'1900-01-01' as PostDate,@docdate as SaveDate,0 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@sono
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@docno);

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY a.AccItemNo)+@ino as AccItemNo,a.AccDocNo,a.AccItemNo,0,b.Balance,
	((TotalAmount/a.ExchangeRate)/a.Qty),a.UnitMea,a.Currency,a.ExchangeRate,((TotalAmount/a.ExchangeRate)/a.Qty)*b.Balance,a.SaleProductCode,a.SalesDescription,a.RateVat,a.RateWht,a.VatType
	from vSO_D a inner join vSO_Balance b on a.AccDocNo=b.AccDocNo and a.AccItemNo=b.AccItemNo
	where a.AccDocNo=@sono and b.Balance>0
	--and not exists(select 1 from vDO_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
end
else
begin
	if @qty=0
	begin
		set @qty=(select Balance from vSO_Balance where AccDocNo=@sono and AccItemNO=@itemno);
	end

	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,a.AccDocNo,a.AccItemNo,0,@qty,
	((TotalAmount/ExchangeRate)/Qty),UnitMea,Currency,ExchangeRate,(@qty*(TotalAmount/Qty)),SaleProductCode,SalesDescription,RateVat,RateWht,VatType
	from vSO_D a 
	where a.AccDocNo=@sono and a.AccItemNo=@itemno;
end

delete a from Acc_TransactionHD a where not exists(select AccDocNo from Acc_TransactionDT where AccDocNo=a.AccdocNo)
--update Acc_TransactionHD set DocStatus=2,AccPostDate=@docdate where AccDocNo=@sono;

select * from vTransaction_H where AccDocNo=@docno;
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_DPToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*
update Acc_TransactionDT set SaleProductCode='CSS-061' where SaleProductCode='CSS-061S'
update Acc_TransactionDT set SaleProductCode='CST-103' where SaleProductCode='CST-103ไทย'
update Acc_TransactionDT set SaleProductCode='CSS-061' where SaleProductCode='CSS-061S'
update Acc_TransactionDT set SaleProductCode='CST-103' where SaleProductCode='CST-103ไทย'
*/
---Insert Advance Payment
CREATE procedure [dbo].[Insert_DPToJournal]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20),
	@accdebit varchar(20)='',
	@acccredit varchar(20)=''
)
as
begin
---delete first
delete h from Acc_JournalHD h
inner join [job_3x].dbo.Job_CashControl d on h.JournalNo=concat('PV-',d.ControlNo) 
where EntryDate>=@datefrom and EntryDate<=@dateto

delete d from Acc_JournalDT d left join Acc_JournalHD h 
on d.EntryId=h.EntryID 
where h.EntryId is null
--new data
declare @id int=(select isnull(max(EntryId),0) from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo),concat('PV-',AccDocNo),AccBatchDate,AccEffectiveDate,@userid,DocRefNo,0,0 
from vTransaction_H h inner join [job_3x].dbo.Job_CashControl d on h.AccDocNo=d.ControlNo 
where AccDocType='DP'
and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
and not exists(select 1 from Acc_JournalHD where JournalNo=concat('PV-',h.AccDocNo));

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select * from ( 
	select EntryId,ROW_NUMBER() OVER(PARTITION BY EntryID ORDER BY EntryId,AccDesc) as Seq,
	AccCode,AccDesc,AccName,Debit,Credit
	from 
	(
		select h.EntryId,a.AccCode,d.AccSourceDocNo as AccName,d.SalesDescription as AccDesc,sum(d.DNetAmt) as Debit,0 as Credit
		from vTransaction_All d inner join Acc_JournalHD h ON
		Concat('PV-',d.AccDocNo)=h.JournalNo,
		vMas_AccCode a 
		where d.AccDocType='DP' and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto and @accdebit=''
		group by h.EntryId,a.AccCode,d.SalesDescription,d.AccSourceDocNo
		union all
		select h.EntryId,a.AccCode,d.PartyName as AccName,d.SalesDescription as AccDesc,0 as Debit,sum(d.DNetAmt) as Credit
		from vTransaction_All d inner join Acc_JournalHD h ON
		Concat('PV-',d.AccDocNo)=h.JournalNo,
		vMas_AccCode a 
		where d.AccDocType='DP' and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto and @acccredit=''
		group by h.EntryId,a.AccCode,d.SalesDescription,d.PartyName
		union all
		select h.EntryId,a.AccCode,d.AccSourceDocNo as AccName,d.SalesDescription as AccDesc,sum(d.DNetAmt) as Debit,0 as Credit
		from vTransaction_All d inner join Acc_JournalHD h ON
		Concat('PV-',d.AccDocNo)=h.JournalNo,
		vMas_AccCode a 
		where d.AccDocType='DP' and a.AccCode=@accdebit
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by h.EntryId,a.AccCode,d.SalesDescription,d.AccSourceDocNo
		union all
		select h.EntryId,a.AccCode,d.PartyName as AccName,d.SalesDescription as AccDesc,0 as Debit,sum(d.DNetAmt) as Credit
		from vTransaction_All d inner join Acc_JournalHD h ON
		Concat('PV-',d.AccDocNo)=h.JournalNo,
		vMas_AccCode a 
		where d.AccDocType='DP' and a.AccCode=@acccredit
		and AccBatchDate>=@datefrom and AccBatchDate<=@dateto
		group by h.EntryId,a.AccCode,d.SalesDescription,d.PartyName
	) t
) pv
where not exists(select 1 from Acc_JournalDT where EntryId=pv.EntryId and Seq=pv.Seq)

delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)

update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr

end
/*
select AccDesc,sum(Debit) from vJournal_D where Debit>0 group by AccDesc
select AccDesc,sum(Credit) from vJournal_D where Credit>0 group by AccDesc
select sum(DNetAmt) from vTransaction_All where AccDocType='DP'
select * from vTrialBalance
*/

GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/**
delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_InvoiceHeader b on a.JournalNo=b.DocNo

delete b from Acc_JournalDT b
where EntryID not in(select EntryId from Acc_JournalHD)
**/
CREATE procedure [dbo].[Insert_InvoiceFromJob]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20)
)
as
begin

/**set a/r and set costing of sales**/
delete a from Acc_TransactionHD a inner join [job_3x].dbo.Job_InvoiceHeader b on a.AccDocNo=b.DocNo
where b.DocDate>=@datefrom and b.DocDate<=@dateto

delete a from Acc_TransactionDT a where not exists(select 1 from Acc_TransactionHD b where AccDocNo=b.AccDocNo)

insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,
StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,
SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select 
id.DocNO,ROW_NUMBER() OVER(PARTITION BY id.DocNo ORDER BY id.DocNo) as ItemNo
,'' as LinKNo,0 as LinkItem,
0 as StockNo,
(case when id.AmtAdvance>0 then 1 else id.Qty end) as Qty,
(case when id.AmtAdvance>0 then id.Amt+id.AmtVat else id.UnitPrice end) as Price
,id.QtyUnit,id.CurrencyCode as Curr,
id.ExchangeRate as Rate,
(case when id.AmtAdvance>0 then id.Amt+id.AmtVat else id.Amt end) as Amount,
id.SICode,ih.RefNo,
(case when id.AmtAdvance>0 then 0 else id.VATRate end),
(case when id.AmtAdvance>0 then 0 else id.Rate50Tavi end),
(case when id.AmtCharge>0 then 1 else 0 end)
from 
[job_3x].dbo.Job_InvoiceDetail id 
inner join [job_3x].dbo.Job_InvoiceHeader ih 
on id.BranchCode=ih.BranchCode and id.DocNo=ih.DocNo 
where isnull(ih.CancelProve,'')=''
and not exists(select 1 from Acc_TransactionDT where AccDocNo=id.DocNo)
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,
PartyName,PartyAddress,IssueBy,AccDocType,
AccPostDate,FiscalYear,DocStatus,DocRefNo)
select ih.DocNo,ih.DocDate,isnull(ih.DueDate,ih.DocDate),ih.CustCode,concat(c.TaxNumber,'/',c.Branch),
c.NameThai,c.TAddress,ih.EmpCode,'SI',
ih.DocDate,ih.DocDate,2,ih.RefNo
from [job_3x].dbo.Job_InvoiceHeader ih 
left join [job_3x].dbo.Mas_Company c on ih.CustCode=c.CustCode
and ih.CustBranch=c.Branch
where isnull(ih.CancelProve,'')='' 
and exists(select 1 from Acc_TransactionDT where AccDocNo=ih.DocNo)
and not exists(select 1 from Acc_TransactionHD where AccDocNo=ih.DocNo)
and ih.DocDate>=@datefrom and ih.DocDate<=@dateto

end
/*
---Data Lost---
select h.* from Acc_TransactionHD h where not exists(select 1 from Acc_TransactionDT where AccDocNo=h.AccDocNo)
select h.* from Acc_TransactionDT h where not exists(select 1 from Acc_TransactionHD where AccDocNo=h.AccDocNo)

select ih.RefNo,id.* 
from [job_3x].dbo.Job_InvoiceHeader ih 
inner join [job_3x].dbo.Job_InvoiceDetail id 
on ih.DocNo=id.DocNo 
left join [job_3x].dbo.Job_ClearDetail cd on id.DocNo=cd.LinkBillNo and id.ItemNo=cd.LinkItem
where isnull(ih.CancelProve,'')='' 
and not exists(select 1 from Acc_TransactionHD where AccDocNo=ih.DocNo)
*/


GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








--declare @datefrom date='2026-02-01'
---declare @dateto date='2026-03-31'

CREATE procedure [dbo].[Insert_InvoiceFromJob_V2]
(
	@datefrom date,
	@dateto date
)
as
begin
select * into #tmp1 from (
--select AccCodeD,AccCodeC,a1.AccName AccNameD,a2.AccName AccNameC,sum(Amt) as Amount,sum(AmtVat) as VatAmount,sum(AmtTotal) as TotalAmount from (
select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
c.TaxNumber,c.NameThai as CustName,c.CustCode,
a.EmpCode,b.SIcode,b.SDescription,
isnull(ad.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
ac.AccCode as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal
from [job_3x].dbo.Job_InvoiceHeader a 
inner join [job_3x].dbo.Job_InvoiceDetail b 
on a.DocNo=b.DocNo 
left join [job_3x].dbo.Mas_Company c
on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
left join [job_3x].dbo.Job_SrvSingle d 
on b.SICode=d.SICode 
left join dbo.Mas_AccCode ac on d.GLAccountCodeCost=ac.AccCode
where not isnull(a.CancelProve,'')<>'' 
and b.AmtCharge>0 
and a.DocDate>=@datefrom and a.DocDate<=@dateto
union all
select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,c.NameThai as CustName,c.CustCode,
a.EmpCode,b.SIcode,b.SDescription,
dbo.GetAccConfig('AR_CONFIG','Advance') as AccCodeD,
ac.AccCode as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet
from [job_3x].dbo.Job_InvoiceHeader a 
inner join [job_3x].dbo.Job_InvoiceDetail b 
on a.DocNo=b.DocNo 
left join [job_3x].dbo.Mas_Company c
on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle d 
on b.SICode=d.SICode 
left join dbo.Mas_AccCode ac on d.GLAccountCodeCost=ac.AccCode
where not isnull(a.CancelProve,'')<>'' 
and b.AmtAdvance>0 
and a.DocDate>=@datefrom and a.DocDate<=@dateto
--) t 
--inner join dbo.Mas_AccCode a1 on t.AccCodeD=a1.AccCode
--inner join dbo.Mas_AccCode a2 on t.AccCodeC=a2.AccCode
--group by AccCodeD,AccCodeC,a1.AccName,a2.AccName
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('SI-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
concat('SI-',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,SDescription as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,SDescription,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('SI-',DocNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










--declare @datefrom date='2026-02-01'
---declare @dateto date='2026-03-31'

CREATE procedure [dbo].[Insert_InvoiceToJournal]
(
	@datefrom date,
	@dateto date
)
as
begin
select * into #tmp1 from (
--select AccCodeD,AccCodeC,a1.AccName AccNameD,a2.AccName AccNameC,sum(Amt) as Amount,sum(AmtVat) as VatAmount,sum(AmtTotal) as TotalAmount from (
select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
c.TaxNumber,c.NameThai as CustName,c.CustCode,
a.EmpCode,b.SIcode,b.SDescription,
isnull(ad.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
ac.AccCode as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal
from [job_3x].dbo.Job_InvoiceHeader a 
inner join [job_3x].dbo.Job_InvoiceDetail b 
on a.DocNo=b.DocNo 
left join [job_3x].dbo.Mas_Company c
on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
left join [job_3x].dbo.Job_SrvSingle d 
on b.SICode=d.SICode 
left join dbo.Mas_AccCode ac on d.GLAccountCodeCost=ac.AccCode
--left join dbo.Mas_Products ac on b.SICode=ac.ProductCode
where not isnull(a.CancelProve,'')<>'' 
and b.AmtCharge>0 
and a.DocDate>=@datefrom and a.DocDate<=@dateto
union all
select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,c.NameThai as CustName,c.CustCode,
a.EmpCode,b.SIcode,b.SDescription,
dbo.GetAccConfig('AR_CONFIG','Advance') as AccCodeD,
ac.AccCode as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet
from [job_3x].dbo.Job_InvoiceHeader a 
inner join [job_3x].dbo.Job_InvoiceDetail b 
on a.DocNo=b.DocNo 
left join [job_3x].dbo.Mas_Company c
on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle d 
on b.SICode=d.SICode 
left join dbo.Mas_AccCode ac on d.GLAccountCodeCost=ac.AccCode
--left join dbo.Mas_Products ac on b.SICode=ac.ProductCode
where not isnull(a.CancelProve,'')<>'' 
and b.AmtAdvance>0 
and a.DocDate>=@datefrom and a.DocDate<=@dateto
--) t 
--inner join dbo.Mas_AccCode a1 on t.AccCodeD=a1.AccCode
--inner join dbo.Mas_AccCode a2 on t.AccCodeC=a2.AccCode
--group by AccCodeD,AccCodeC,a1.AccName,a2.AccName
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('SI-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
concat('SI-',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,SDescription as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,SDescription,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('SI-',DocNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_InvoiceToJournal_MNL]
(
	@datefrom date,
	@dateto date,
	@delmode int=0
)
as
begin
delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('SI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('SI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto

select * into #tmp1 from (
	select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.CustCode,a.CustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(cb.CustCode,cb.Branch)
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product p on b.SICode=p.ProductCode
	left join (select * from vMas_AccCode where AccCode like '4___-__-____') ac 
	on concat(ac.AccMainName,'-',d.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ab 
	on concat(ab.AccMainName,'-',cb.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.CustCode,a.CustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(cb.CustCode,cb.Branch)
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') ac 
	on concat(ac.AccMainName,'-',c.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',cb.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('SI-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

if @delmode=0
	begin
	declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

	insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
	select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
	concat('SI-',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
	from #tmp1 a 
	group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

	insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id+DENSE_RANK() OVER(ORDER BY DocNo),
	ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
	AccCode,CustName,SubAccname,Debit,Credit
	from (
		select DocNo,AccCodeD as AccCode,DocNo as CustName,RefNo as SubAccName,
		sum(AmtTotal) as Debit,0 as Credit
		from #tmp1
		group by DocNo,AccCodeD,DocNo,RefNo
		union all
		select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
		CustName,RefNo as SubAccName,
		0 as Debit,sum(AmtVat) as Credit
		from #tmp1 where AmtVat>0
		group by DocNo,CustName,RefNo
		union all
		select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(Amt) as Credit
		from #tmp1
		group by DocNo,AccCodeC,SDescription,RefNo
		/*
		union all
		select DocNo,dbo.GetAccConfig('AR_CONFIG','Advance') as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(TotalCustAdv) as Credit
		from #tmp1 where TotalCustAdv>0
		group by DocNo,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('AP_CONFIG','ChequeOut') as AccCode,SDescription,RefNo as SubAccName,
		sum(TotalCustAdv) as Debit,0 as Credit
		from #tmp1 where TotalCustAdv>0
		group by DocNo,SDescription,RefNo
		*/
	) tb;

	EXEC dbo.UpdateTotalDebitCredit
end
select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('SI-',DocNo)=h.JournalNo)

drop table #tmp1;
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












--declare @datefrom date='2026-02-01'
---declare @dateto date='2026-03-31'

CREATE procedure [dbo].[Insert_InvoiceToJournal_V2]
(
	@datefrom date,
	@dateto date,
	@delmode int=0
)
as
begin
select * into #tmp1 from (
	select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,c.NameThai as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ad.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
	isnull(ac.IncomeAccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product ac on b.SICode=ac.ProductCode
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,c.NameThai as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	dbo.GetAccConfig('AR_CONFIG','Advance') as AccCodeD,
	isnull(d.GLAccountCodeCost,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product ac on b.SICode=ac.ProductCode
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('SI-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

if @delmode=0
	begin
	declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

	insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
	select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
	concat('SI-',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
	from #tmp1 a 
	group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

	insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id+DENSE_RANK() OVER(ORDER BY DocNo),
	ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
	AccCode,CustName,SubAccname,Debit,Credit
	from (
		select DocNo,AccCodeD as AccCode,SDescription as CustName,RefNo as SubAccName,
		sum(AmtTotal) as Debit,0 as Credit
		from #tmp1
		group by DocNo,AccCodeD,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
		CustName,RefNo as SubAccName,
		0 as Debit,sum(AmtVat) as Credit
		from #tmp1 where AmtVat>0
		group by DocNo,CustName,RefNo
		union all
		select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(Amt) as Credit
		from #tmp1
		group by DocNo,AccCodeC,SDescription,RefNo
	) tb;

	EXEC dbo.UpdateTotalDebitCredit
end
select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('SI-',DocNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
















--declare @datefrom date='2026-02-01'
---declare @dateto date='2026-03-31'

CREATE procedure [dbo].[Insert_InvoiceToJournal_V3]
(
	@datefrom date,
	@dateto date,
	@delmode int=0
)
as
begin
delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('SI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('SI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto

select * into #tmp1 from (
		select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,c.NameThai as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	dbo.GetAccConfig('GL_CONFIG','AccrueIncome') as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product p on b.SICode=p.ProductCode
	left join dbo.Mas_AccCode ac on p.IncomeAccCode=ac.AccCode
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,c.NameThai as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	dbo.GetAccConfig('GL_CONFIG','AccrueIncome') as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on a.BillToCustCode=c.CustCode and a.BillToCustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.Mas_AccCode ac on d.GLAccountCodeCost=ac.AccCode
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('SI-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

if @delmode=0
	begin
	declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

	insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
	select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
	concat('SI-',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
	from #tmp1 a 
	group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

	insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id+DENSE_RANK() OVER(ORDER BY DocNo),
	ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
	AccCode,CustName,SubAccname,Debit,Credit
	from (
		select DocNo,AccCodeD as AccCode,SDescription as CustName,RefNo as SubAccName,
		sum(AmtTotal) as Debit,0 as Credit
		from #tmp1
		group by DocNo,AccCodeD,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
		CustName,RefNo as SubAccName,
		0 as Debit,sum(AmtVat) as Credit
		from #tmp1 where AmtVat>0
		group by DocNo,CustName,RefNo
		union all
		select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(Amt) as Credit
		from #tmp1
		group by DocNo,AccCodeC,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('AR_CONFIG','Advance') as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(TotalCustAdv) as Credit
		from #tmp1 where TotalCustAdv>0
		group by DocNo,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('ADV_CONFIG','CashOut') as AccCode,SDescription,RefNo as SubAccName,
		sum(TotalCustAdv) as Debit,0 as Credit
		from #tmp1 where TotalCustAdv>0
		group by DocNo,SDescription,RefNo
	) tb;

	EXEC dbo.UpdateTotalDebitCredit
end
select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('SI-',DocNo)=h.JournalNo)

drop table #tmp1;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_InvoiceToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_InvoiceToJournal_V4]
(
	@datefrom date,
	@dateto date,
	@delmode int=0
)
as
begin
delete c from Acc_JournalDT c 
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('SI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_InvoiceHeader b 
on a.JournalNo=concat('SI-',b.DocNo)
where b.DocDate>=@datefrom and b.DocDate<=@dateto

select * into #tmp1 from (
	select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.CustCode,a.CustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(cb.CustCode,cb.Branch)
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product p on b.SICode=p.ProductCode
	left join (select * from vMas_AccCode where AccCode like '4___-__-____') ac 
	on concat(ac.AccMainName,'-',d.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ab 
	on concat(ab.AccMainName,'-',cb.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.CustCode,a.CustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(cb.CustCode,cb.Branch)
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') ac 
	on concat(ac.AccMainName,'-',c.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',cb.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('SI-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

if @delmode=0
	begin
	declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

	insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
	select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo),
	concat('SI-',a.DocNo) as DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
	from #tmp1 a 
	group by a.DocNo,a.DocDate,a.DueDate,a.EmpCode,a.CustName

	insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id+DENSE_RANK() OVER(ORDER BY DocNo),
	ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
	AccCode,CustName,SubAccname,Debit,Credit
	from (
		select DocNo,AccCodeD as AccCode,SDescription as CustName,RefNo as SubAccName,
		sum(AmtTotal) as Debit,0 as Credit
		from #tmp1
		group by DocNo,AccCodeD,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
		CustName,RefNo as SubAccName,
		0 as Debit,sum(AmtVat) as Credit
		from #tmp1 where AmtVat>0
		group by DocNo,CustName,RefNo
		union all
		select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(Amt) as Credit
		from #tmp1
		group by DocNo,AccCodeC,SDescription,RefNo
		/*
		union all
		select DocNo,dbo.GetAccConfig('AR_CONFIG','Advance') as AccCode,SDescription,RefNo as SubAccName,
		0 as Debit,sum(TotalCustAdv) as Credit
		from #tmp1 where TotalCustAdv>0
		group by DocNo,SDescription,RefNo
		union all
		select DocNo,dbo.GetAccConfig('AP_CONFIG','ChequeOut') as AccCode,SDescription,RefNo as SubAccName,
		sum(TotalCustAdv) as Debit,0 as Credit
		from #tmp1 where TotalCustAdv>0
		group by DocNo,SDescription,RefNo
		*/
	) tb;

	EXEC dbo.UpdateTotalDebitCredit
end
select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('SI-',DocNo)=h.JournalNo)

drop table #tmp1;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_Journal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Journal]
(
@fiscalyear date,
@entrydate date,
@doctype varchar(10),
@journalno varchar(20),
@note nvarchar(255),
@accdebit varchar(20),
@descdebit nvarchar(255),
@acccredit varchar(20),
@desccredit nvarchar(255),
@amount float,
@userid varchar(20)
)
as
BEGIN
	if @journalno=''
	begin
		set @journalno=dbo.GetNewRunning(@doctype,'J',@entrydate);
	end
	if not exists(select 1 from Acc_JournalHD WHERE JournalNo=@journalno)
	begin
		declare @id int=(select isnull(MAX(EntryID),0)+1 from Acc_JournalHD);
		INSERT INTO Acc_JournalHD
		(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
		SELECT @id,@journalno,@entrydate,@fiscalyear,@userid,@note,0,0;
	end
	declare @seq int=(select isnull(MAX(Seq),0) from vJournal_All where JournalNo=@journalno);
	if @accdebit<>''
	begin		
		INSERT INTO Acc_JournalDT
		(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
		select a.EntryId,@seq+1,b.AccCode,b.AccName,@descdebit,@amount,0
		from Acc_JournalHD a,Mas_AccCode b
		where a.JournalNo=@journalno AND b.AccCode=@accdebit;
		SET @seq=@seq+1;
	end		
	if @acccredit<>''
	begin		
		INSERT INTO Acc_JournalDT
		(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
		select a.EntryId,@seq+1,b.AccCode,b.AccName,@desccredit,0,@amount
		from Acc_JournalHD a,Mas_AccCode b
		where a.JournalNo=@journalno AND b.AccCode=@acccredit;
	end

	update a
	set a.TotalDebit=b.SumDebit,a.TotalCredit=b.SumCredit
	from Acc_JournalHD a
	inner join 
		(select EntryID,sum(Debit) as SumDebit,sum(Credit) as SumCredit
		from Acc_JournalDT 
		group by EntryID
	) b
	on a.EntryId=b.EntryId
	where a.JournalNo=@journalno;
	
	select * from vJournal_All where JournalNo=@journalno;
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_PayrollByStaff]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_PayrollByStaff]
(
@paydate date,
@paytype int,
@userid varchar(20),
@staffid int
)
as
begin
declare @id int=(SELECT ISNULL(MAX(SalaryID),0) from Acc_HRPayRoll)
declare @cid int=(SELECT isnull(COUNT(DISTINCT SlipNo),0) FROM Acc_HRPayRoll where SlipNo like ''+FORMAT(@paydate,'yyMM')+'%')

insert into Acc_HRPayRoll
(SalaryId,SlipNo,PaymentType,StaffId,PaymentToAcc,PaymentFromAcc,
PaymentDate,ItemNo,SalaryName,AmountPayment,AmountAdd,AmountDeduct,
AccCodeDebit,AccCodeCredit,SalaryStatus,ApproveDate,ApproveBy,
CancelDate,CancelBy,CreateDate,CreateBy)
select @id+ROW_NUMBER() OVER(ORDER BY StaffId,Seq) as sid,
CONCAT(FORMAT(@paydate,'yyMM'),FORMAT(DENSE_RANK() OVER(ORDER BY StaffID)+@cid,'0000')) as SlipNo,
@paytype as PayType,
a.StaffId,a.BookCode,isnull(dbo.GetAccConfig('GL_CONFIG','BookAccount'),'N/A') as BookPay,
@paydate,Seq as ItemNo,SalaryName,
TotalPayment,
(case when PayrollType=1 then TotalPayment else 0 end) as AddAmt,
(case when PayrollType=2 then ABS(TotalPayment) else 0 end) as DeductAmt,
(case when Debit>0 then AccCode else '' end) as AccDebit,
(case when Credit>0 then AccCode else '' end) as AccCredit,
0 as SalaryStatus,
NULL as ApprDate,'' as ApprBy,
NULL as CancelDate,'' as CancelBy,
GETDATE() as CreateDate,@userid as createby
from vHR_Salary a 
where a.StaffId=@staffid and a.Seq>0
and not exists(select 1 from Acc_HRPayRoll where StaffId=@staffid and PaymentDate=@paydate)

select * from Acc_HRPayRoll where PaymentDate=@paydate and StaffId=@staffid
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_PayrollToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_PayrollToJournal]
(
@paydate date,
@userid varchar(20),
@accdesc varchar(200)
)
as
begin
declare @id int=(select max(EntryId)+1 from Acc_JournalHD)
declare @running varchar(20)=CONCAT('PV-SAL',FORMAT(@paydate,'yyMM'))

delete d from Acc_JournalDT d
where exists(select 1 from Acc_JournalHD where JournalNo=@running and EntryId= d.EntryId)

delete from Acc_JournalHD where JournalNo=@running

insert into Acc_JournalHD
select @id,@running,@paydate,@paydate,@userid,@accdesc,
sum(AmountAdd) as Dr,sum(AmountAdd) as Cr
from Acc_HRPayRoll
where PaymentDate=@paydate
and SalaryStatus=0
and not exists(select 1 from Acc_JournalHD where journalNo=CONCAT('PV-SAL',FORMAT(@paydate,'yyMM')))
having sum(AmountAdd)>0

insert into Acc_JournalDT
select @id,ROW_NUMBER() OVER(ORDER BY StaffId),
AccCode,AccName,AccDesc,Debit,Credit
from (
	select a.StaffId,
	CONCAT(a.AccCodeDebit,a.AccCodeCredit) as AccCode,
	concat(a.SalaryName,'-',b.StaffName) as AccName,
	a.SlipNo as AccDesc,a.AmountAdd as Debit,a.AmountDeduct as Credit
	from Acc_HRPayRoll a inner join Mas_HRStaff b on
	a.StaffId=b.StaffId 
	where CONCAT(a.AccCodeDebit,a.AccCodeCredit)<>dbo.GetAccConfig('GL_CONFIG','SocialFund')
	and a.SalaryStatus=0
	and a.PaymentDate=@paydate
	union all
	select a.StaffId,
	dbo.GetAccConfig('GL_CONFIG','AccrueSalary'),
	concat('เงินเดือนค้างจ่าย-',b.StaffName),a.SlipNo,0,sum(a.AmountPayment)
	from Acc_HRPayRoll a inner join Mas_HRStaff b on
	a.StaffId=b.StaffId 
	where a.SalaryStatus=0
	and a.PaymentDate=@paydate
	group by a.StaffId,b.StaffName,a.SlipNo	
	union all
	select a.StaffId,
	dbo.GetAccConfig('GL_CONFIG','AccrueSocial') as AccCode,
	concat(a.SalaryName,'-',b.StaffName) as AccName,
	a.SlipNo as AccDesc,0 as Debit,a.AmountDeduct*2 as Credit
	from Acc_HRPayRoll a inner join Mas_HRStaff b on
	a.StaffId=b.StaffId 
	where CONCAT(a.AccCodeDebit,a.AccCodeCredit)=dbo.GetAccConfig('GL_CONFIG','SocialFund')
	and a.SalaryStatus=0
	and a.PaymentDate=@paydate
	union all
	select a.StaffId,
	dbo.GetAccConfig('GL_CONFIG','SocialFund') as AccCode,
	concat(a.SalaryName,'-',b.StaffName) as AccName,
	a.SlipNo as AccDesc,a.AmountDeduct as Debit,0 as Credit
	from Acc_HRPayRoll a inner join Mas_HRStaff b on
	a.StaffId=b.StaffId 
	where CONCAT(a.AccCodeDebit,a.AccCodeCredit)=dbo.GetAccConfig('GL_CONFIG','SocialFund')
	and a.SalaryStatus=0
	and a.PaymentDate=@paydate
) t

update a 
set a.SalaryStatus=2
from Acc_HRPayRoll a
where exists(select AccDesc from vJournal_All where EntryId=@id and AccDesc=a.SlipNo)

EXEC dbo.UpdateTotalDebitCredit

select * from vJournal_All where EntryId=@id 

end
GO
/****** Object:  StoredProcedure [dbo].[Insert_PCFromPI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










CREATE procedure [dbo].[Insert_PCFromPI]
(
@userid varchar(20),
@docno varchar(20),
@transtype varchar(3),
@bankacc varchar(50),
@bankname varchar(50),
@rcpno varchar(50),
@docdate date,
@duedate date,
@pino varchar(20),
@itemno int=0,
@transno varchar(20)='',
@qty float=0
)
as
begin

/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','PC')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @header varchar(20);
set @header=CONCAT('PC',FORMAT(@docdate,'yyMM'));

declare @running varchar(20);
--set @running =dbo.GetNewTransaction(@header,'0000');
set @running=dbo.GetNewRunning('PC','T',@docdate);
if @docno<>'' 
begin
 set @running=@docno;
end


insert into Acc_TransactionHD
select distinct
@running as AccDocNo,
@docdate as AccBatchDate,
@duedate as AccEffectiveDate,
PartyCode,
PartyTaxCode,
PartyName,
PartyAddress,
@userid as IssueBy,
'PC' as AccDocType,
'1900-01-01' as AccPostDate,
@docdate as FiscalYear,
0 as DocStatus,
@rcpno
from vAP_D where AccDocNo=@pino
and not exists(select AccDocNo from Acc_TransactionHD where AccDocNo=@running)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@running);
if @ino is null
begin
 set @ino=0;
end


if @itemno=0
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	case when AccSourceDocNo<>'' then AccSourceDocNo else a.AccDocNo end,
	case when AccSourceDocNo<>'' then AccSourceDocItem else a.AccItemNo end,
	0 as StockTransNo,
	(case when b.TotalAmount is not null then 1 else Qty end),
	(case when b.TotalAmount is not null then b.TotalAmount/ExchangeRate else (a.TotalAmount/ExchangeRate)/Qty end),
	UnitMea,
	Currency,
	ExchangeRate,
	isnull(b.TotalAmount,a.TotalAmount),
	SaleProductCode,
	SalesDescription,
	isnull(b.RateVat,a.RateVat),
	isnull(b.RateWht,a.RateWht),
	(case when b.TotalAmount is not null then 2 else 1 end)
	from vAP_D a left join vPC_CheckPO b on
	a.AccSourceDocNo=b.AccDocNo and 
	a.AccSourceDocItem=b.AccItemNo
	where a.AccDocNo=@pino
	and isnull(b.TotalAmount,a.TotalAmount)>0
	and not exists(select 1 from vPC_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)

	--update Acc_TransactionHD set DocStatus=2 where AccdocNo=@pino and DocStatus<2
end
else
begin
	if @qty=0 
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
		case when AccSourceDocNo<>'' then AccSourceDocItem else AccItemNo end,
		0 as StockTransNo,
		Qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		TotalAmount,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vAP_D a where AccDocNo=@pino and AccItemNo=@itemno
		and not exists(select 1 from vPC_D where AccSourceDocNo=a.AccSourceDocNo and AccSourceDocItem=a.AccSourceDocItem and AccSourceDocNo<>'')
		and not exists(select 1 from vPC_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	end
	else
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
		case when AccSourceDocNo<>'' then AccSourceDocItem else AccItemNo end,
		0 as StockTransNo,
		@qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		(TotalAmount/Qty)*@qty,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vAP_D a where AccDocNo=@pino and AccItemNo=@itemno
		and not exists(select 1 from vPC_D where AccSourceDocNo=a.AccSourceDocNo and AccSourceDocItem=a.AccSourceDocItem and AccSourceDocNo<>'')
		and not exists(select 1 from vPC_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
	end
end

DELETE a FROM Acc_TransactionHD a where not exists(select 1 from Acc_TransactionDT where AccDocNO=a.AccDocNo)

insert into Acc_AdditionData(DocNo,Seq,Text1,Text2,Text3,Text4)
select @running,0,@transno,@transtype,@bankacc,@bankname
where not exists(select 1 from Acc_AdditionData where DocNo=@running and Seq=0)
and exists(select 1 from Acc_TransactionDT where AccDocNo=@running);

select AccDocNo as PCNo,AccBatchDate as PCDate,AccEffectiveDate as DueDate, 
PartyCode as CustCode,PartyName as CustName,TotalAmount,TotalVat,TotalWht,TotalNet
from vTransaction_H
where AccDocNo=@running;
end 







GO
/****** Object:  StoredProcedure [dbo].[Insert_PCFromPO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE procedure [dbo].[Insert_PCFromPO]
(
@userid varchar(20),
@docno varchar(20),
@transtype varchar(3),
@bankacc varchar(50),
@bankname varchar(50),
@rcpno varchar(50),
@docdate date,
@duedate date,
@pono varchar(20),
@itemno int=0,
@transno varchar(20)='',
@qty float=0
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','PC')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @header varchar(20);
set @header=CONCAT('PC',FORMAT(@docdate,'yyMM'));

declare @running varchar(20);
--set @running =dbo.GetNewTransaction(@header,'0000');
set @running=dbo.GetNewRunning('PC','T',@docdate);
if @docno<>'' 
begin
 set @running=@docno;
end


insert into Acc_TransactionHD
select distinct
@running as AccDocNo,
@docdate as AccBatchDate,
@duedate as AccEffectiveDate,
PartyCode,
PartyTaxCode,
PartyName,
PartyAddress,
@userid as IssueBy,
'PC' as AccDocType,
'1900-01-01' as AccPostDate,
@docdate as FiscalYear,
0 as DocStatus,
@rcpno
from vPO_D where AccDocNo=@pono
and not exists(select AccDocNo from Acc_TransactionHD where AccDocNo=@running)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@running);
if @ino is null
begin
 set @ino=0;
end


if @itemno=0
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	a.AccDocNo as AccSourceDocNo,
	a.AccItemNo as AccSourceDocItem,
	0 as StockTransNo,
	(case when b.TotalAmount is not null then 1 else Qty end),
	(case when b.TotalAmount is not null then b.TotalAmount/ExchangeRate else (a.TotalAmount/ExchangeRate)/Qty end),
	UnitMea,
	Currency,
	ExchangeRate,
	isnull(b.TotalAmount,a.TotalAmount),
	SaleProductCode,
	SalesDescription,
	isnull(b.RateVat,a.RateVat),
	isnull(b.RateWht,a.RateWht),
	(case when b.TotalAmount is not null then 2 else 1 end)
	from vPO_D a left join vPC_CheckPO b on
	a.AccDocNo=b.AccDocNo and 
	a.AccItemNo=b.AccItemNo
	where a.AccDocNo=@pono
	and isnull(b.TotalAmount,a.TotalAmount)>0

end
else
begin
	if @qty=0 
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		AccDocNo as AccSourceDocNo,
		AccItemNo as AccSourceDocItem,
		0 as StockTransNo,
		Qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		TotalAmount,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vPO_D where AccDocNo=@pono and AccItemNo=@itemno;
	end
	else
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		AccDocNo as AccSourceDocNo,
		AccItemNo as AccSourceDocItem,
		0 as StockTransNo,
		@qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		(TotalAmount/Qty)*@qty,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vPO_D where AccDocNo=@pono and AccItemNo=@itemno;
	end
end

--update Acc_TransactionHD set DocStatus=1 where AccDocNo=@pono;

insert into Acc_AdditionData(DocNo,Seq,Text1,Text2,Text3,Text4)
select @running,0,@transno,@transtype,@bankacc,@bankname
where not exists(select 1 from Acc_AdditionData where DocNo=@running and seq=0);

select AccDocNo as PCNo,AccBatchDate as PCDate,AccEffectiveDate as DueDate, 
PartyCode as CustCode,PartyName as CustName,TotalAmount,TotalVat,TotalWht,TotalNet
from vTransaction_H
where AccDocNo=@running;
end 




GO
/****** Object:  StoredProcedure [dbo].[Insert_PIFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_PIFromJob]
(
@datefrom date,
@dateto date,
@docdate date,
@userid varchar(20)
)
as
begin
insert into Acc_TransactionHD 
select h.DocNo,@docdate,h.DocDate,
isnull(c.VenCode,'-'),isnull(c.TaxNumber,'-'),isnull(c.TName,'-'),CONCAT(isnull(c.TAddress1,''),' ',isnull(c.TAddress2,'')),@userid,
'PI','1900-01-01',@docdate,1,concat(h.RefNo,' #',h.PoNo)
from [job_3x].dbo.Job_PaymentHeader h
left join [job_3x].dbo.Mas_Vender c
on h.VenCode=c.VenCode
where not h.CancelProve<>'' 
and h.DocDate>=@datefrom and h.DocDate<=@dateto 
and h.DocNo not in (select AccDocNo from Acc_TransactionHD)
and exists(
select d.DocNo from [job_3x].dbo.Job_PaymentDetail d
inner join [job_3x].dbo.Job_SrvSingle s
on d.SICode=s.SICode 
and s.IsExpense=1
and d.BranchCode=h.BranchCode and d.DocNo=h.DocNo 
)

insert into Acc_TransactionDT 
select d.DocNo,
ROW_NUMBER() OVER(PARTITION BY d.DocNo ORDER BY d.ItemNo),'',0,0,d.Qty,
((d.Amt-d.AmtDisc)/h.ExchangeRate)/d.Qty
,d.QtyUnit,h.CurrencyCode,h.ExchangeRate,
(d.Amt-d.AmtDisc)
,p.ProductCode,d.SDescription,
(case when d.AmtVAT>0 then h.VATRate else 0 end) as VatRate,
(case when d.AmtWHT>0 then h.TaxRate else 0 end) as TaxRate,
1 as VatRate
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_PaymentDetail d
on h.DocNo=d.DocNo 
inner join [job_3x].dbo.Job_SrvSingle s
on d.SICode=s.SICode 
inner join vMas_Product p on d.SICode=p.ProductCode
where not h.CancelProve<>'' and s.IsExpense=1
and h.DocDate>=@datefrom and h.DocDate<=@dateto
and h.DocNo not in (select AccDocNo from Acc_TransactionDT)
end 

GO
/****** Object:  StoredProcedure [dbo].[Insert_PIFromPO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE procedure [dbo].[Insert_PIFromPO]
(
@userid varchar(20),
@docdate date,
@pono varchar(20),
@invno varchar(50),
@itemno int=0,
@qty float=0,
@docno varchar(20)=''
)
as
begin

/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','PI')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @header varchar(20);
set @header=CONCAT('PI',FORMAT(@docdate,'yyMM'));

declare @running varchar(20);
--set @running =dbo.GetNewTransaction(@header,'0000');
set @running=dbo.GetNewRunning('PI','T',@docdate);
if @docno<>''
begin
 set @running=@docno;
end

insert into Acc_TransactionHD
select distinct
@running as AccDocNo,
@docdate as AccBatchDate,
'1900-01-01' as AccEffectiveDate,
PartyCode,
PartyTaxCode,
PartyName,
PartyAddress,
@userid as IssueBy,
'PI' as AccDocType,
'1900-01-01' as AccPostDate,
@docdate as FiscalYear,
0 as DocStatus,
@invno
from vPO_All where --DocStatus=0 and 
AccDocNo=@pono
and not exists(select AccDocNo from Acc_TransactionHD where AccDocNo=@running)

declare @ino int=(select Max(AccItemNo) from Acc_TransactionDT where AccDocNo=@running);
if @ino is null
begin
 set @ino=0;
end

if @itemno=0 
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	AccDocNo as AccSourceDocNo,
	AccItemNo as AccSourceDocItem,
	0 as StockTransNo,
	Qty,
	(TotalAmount/ExchangeRate)/Qty,
	UnitMea,
	Currency,
	ExchangeRate,
	TotalAmount,
	SaleProductCode,
	SalesDescription,RateVat,RateWht,1
	from vPO_D a where --docStatus=0 and 
	AccDocNo=@pono
	and not exists(select 1 from vAP_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
end
else
begin
    if @qty>0
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		AccDocNo as AccSourceDocNo,
		AccItemNo as AccSourceDocItem,
		0 as StockTransNo,
		@qty,
		((TotalAmount/ExchangeRate)/Qty),
		UnitMea,
		Currency,
		ExchangeRate,
		(TotalAmount/Qty)*@qty,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vPO_D where --docStatus=0 and 
		AccDocNo=@pono and AccItemNo=@itemno;
	end
	else
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		AccDocNo as AccSourceDocNo,
		AccItemNo as AccSourceDocItem,
		0 as StockTransNo,
		Qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		TotalAmount,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vPO_D a where --docStatus=0 and 
		AccDocNo=@pono and AccItemNo=@itemno
		and not exists(select 1 from vAP_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo);
	end
end

delete from Acc_TransactionHD where AccDocNo=@running 
and not exists(select 1 from Acc_TransactionDT where AccDocNo=@running)

--set due from supplier addition data (Num1=Due Payment Days from Invoice date)
update a 
set a.AccEffectiveDate=DATEADD(d,b.Num1,a.AccBatchDate)
from Acc_TransactionHD a inner join Acc_AdditionData b
on a.PartyCode=b.DocNo and b.Seq=0
and a.AccDocNo=@running

if @itemno=0
begin
	update Acc_TransactionHD set DocStatus=1 where DocStatus=0 And AccDocType='PO' and AccDocNo=@pono
end 

select AccDocNo as PINo,AccBatchDate as PIDate,AccEffectiveDate as DueDate, 
PartyCode as VenderCode,PartyName as VenderName,TotalAmount,TotalVat,TotalWht,TotalNet
from vAP_H
where AccDocNo=@running;
end 


GO
/****** Object:  StoredProcedure [dbo].[Insert_PIToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[Insert_PIToJournal]
(
@pino nvarchar(50),
@duedate date,
@userid nvarchar(50)
)
as
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','PI')
if NOT CHARINDEX('P',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT isnull(MAX(EntryId),0) as t from Acc_JournalHD)

insert into Acc_JournalHD
select @maxid+1 as EntryID,
h.AccDocNo,h.AccBatchDate  as EntryDate,
@duedate,@userid as UserID,
h.DocRefNo,0,0
from vAP_H h
where h.AccDocNo=@pino
and not exists(select JournalNo from Acc_JournalHD where JournalNo=@pino)

declare @eid int=(select EntryId from Acc_JournalHD where JournalNo=@pino);

insert into Acc_JournalDT
select * from (
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo) as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
	select 
	dbo.GetAccConfig('AP_CONFIG','Purchase') as AccCode,
	h.AccDocNo,0 as Debit,h.Amount+h.VatAmount as Credit,
	concat(h.SaleProductCode,' / ',h.SalesDescription) as AccDesc,h.AccSourceDocNo as RefNo
	from vAP_D h
	where h.AccDocNo=@pino
	union
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	h.AccDocNo,h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@pino and h.TotalVat>0
	union
	select 
	(case when d.IsService=0 then d.AssetAccCode else d.ExpenseAccCode end) as AccCode,
	d.AccDocNo,d.Amount as Debit,0 as Credit,
	concat(d.SaleProductCode,' / ',d.SalesDescription) as AccDesc,AccSourceDocNo as RefNo
	from vAP_D d	
	where d.AccDocNo=@pino 
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where Not Exists(select EntryId from Acc_JournalDT where EntryID=tb.EntryId and Seq=tb.Seq)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.JournalNo=@pino

update a set a.AccPostDate=b.EntryDate,
a.AccEffectiveDate=@duedate,a.DocStatus=1
from Acc_TransactionHD a
inner join Acc_JournalHD b
on a.AccDocNo=b.JournalNo 
where a.DocStatus=0 and b.JournalNo=@pino;

select * from vJournal_All where EntryId=@eid;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_PIToJournal_ByDate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_PIToJournal_ByDate]
(
@@datefrom date,
@@dateto date,
@@userid nvarchar(50)
)
as
begin
declare @@maxid int;
set @@maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)



insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NuMBER() OVER(ORDER BY h.AccDocNo) as EntryID,
h.AccDocNo,h.AccBatchDate  as EntryDate,
h.AccEffectiveDate,@@userid as UserID,
h.DocRefNo,0,0
from vAP_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
and h.AccDocNo not in(select JournalNo from Acc_JournalHD)



insert into Acc_JournalDT
select * from (
select @@maxid+DENSE_RANK() OVER(ORDER BY AccDocNo)  as EntryId,
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY RefNo) as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
    select
    dbo.GetAccConfig('AP_CONFIG','Purchase') as AccCode,
    h.AccDocNo,0 as Debit,h.TotalAmount+h.TotalVat as Credit,
    h.PartyName as AccDesc,h.DocRefNo as RefNo
    from vAP_H h
    where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
        union all
        select
        dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
        h.AccDocNo,h.TotalVat as Debit,0 as Credit,
        h.PartyName as AccDesc,h.DocRefNo as RefNo
        from vAP_H h
        where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
            and h.TotalVat>0
            union all
            select
            d.AssetAccCode as AccCode,
            d.AccDocNo,d.TotalAmount as Debit,0 as Credit,
            d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
            from vAP_D d
            where d.AccBatchDate>=@@datefrom and d.AccBatchDate<=@@dateto
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where tb.EntryId not in(select EntryID from Acc_JournalDT)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b
on a.EntryID=b.EntryID
where a.EffectiveDate>=@@datefrom and a.EffectiveDate<=@@dateto

update a set a.AccPostDate=b.EntryDate,a.DocStatus=2
from Acc_TransactionHD a
inner join Acc_JournalHD b
on a.AccDocNo=b.JournalNo
where a.DocStatus=1

end

GO
/****** Object:  StoredProcedure [dbo].[Insert_POFromPR]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_POFromPR]
(
@prno nvarchar(20),
@docdate date,
@duedate date,
@refno nvarchar(50),
@userid nvarchar(50),
@itemno int=0,
@pono varchar(20)='',
@closedoc int=0
)
as 
begin

declare @author varchar(20)= dbo.GetAuthorize(@userid,'PO','PO')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @docno nvarchar(50);
declare @doctype nvarchar(5);

set @doctype='PO';
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @pono<>''
begin
  set @docno=@pono;
end

declare @ino int=(select isnull(MAX(AccItemNo),0) FROM Acc_TransactionDT where AccDocNo=@docno);
if @ino is null
begin
	set @ino=0;
end

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	@ino+ROW_NUMBER() OVER(ORDER BY a.AccDocNo) as AccItemNo,a.AccDocNo,a.AccItemNo,0,c.Balance,
	a.Price,a.UnitMea,a.Currency,a.ExchangeRate,(a.Price*c.Balance*a.ExchangeRate),a.SaleProductCode,a.SalesDescription,
	a.RateVat,a.RateWht,a.VatType
	from Acc_TransactionDT a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	inner join vPR_Balance c on a.AccDocNo=c.AccDocNo and a.AccItemNo=c.AccItemNo
	where b.AccDocNo=@prno and c.Balance<>0
	and c.DocStatus<2
end
else
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY a.AccItemNo)+@ino as AccItemNo,a.AccDocNo,a.AccItemNo,0,c.Balance,
	c.Price,c.UnitMea,c.Currency,c.ExchangeRate,(c.Balance*c.Price*c.ExchangeRate),c.SaleProductCode,c.SalesDescription,
	c.RateVat,c.RateWht,c.VatType
	from Acc_TransactionDT a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo inner join vPR_Balance c 
	on a.AccDocNo=c.AccDocNo and a.AccItemNo=c.AccItemNo
	where a.AccDocNo=@prno and a.AccItemNo=@itemno
	and c.Balance>0 and c.DocStatus<2
end

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@duedate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,'1900-01-01' as PostDate,@docdate as SaveDate,0 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@prno
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

if @itemno=0
begin
	UPDATE Acc_TransactionHD SET DocStatus=1,AccPostDate=@docdate where AccDocNo=@prno AND DocStatus=0;

	INSERT INTO Acc_AdditionData(DocNo,Seq,Date3,Text3)
	SELECT @prno,0,@docdate,@userid WHERE NOT EXISTS(select 1 from Acc_AdditionData WHERE DocNo=@prno And Seq=0);

	UPDATE Acc_AdditionData 
	SET Date3=@docdate,Text3=@userid 
	WHERE DocNo=@prno AND Seq=0;
end

if @closedoc=1 
BEGIN
	UPDATE Acc_TransactionHD SET DocStatus=2,AccPostDate=@docdate where AccDocNo=@prno AND DocStatus<>99;	
END 

select AccDocNo as PONo,AccBatchDate as PODate,AccEffectiveDate as DueDate, 
PartyCode as VenderCode,PartyName as VenderName,TotalAmount,TotalVat,TotalWht,TotalNet
from vPO_H
where AccDocNo=@docno;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_PostClearToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--insert into Mas_AccConfig select 'GL_CONFIG','WorkInProcess','1140-03';
/**insert clearing data**/
--/*
CREATE procedure [dbo].[Insert_PostClearToJournal]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20)
)
as
begin
--delete first
delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_ClearHeader b on a.JournalNo=b.ClrNo
where b.ClrDate>=@datefrom and b.ClrDate<=@dateto

delete a from Acc_JournalDT a where not exists(select 1 from Acc_JournalHD where EntryID=a.EntryID)
--*/
declare @id int =(select isnull(MAX(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
select EntryId,AccDocNo,AccBatchDate,AccEffectiveDate,@userid,SalesDescription,0,0
from (
    select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo,SalesDescription) as EntryId,* from
    (
        select distinct  
        a.AccDocNo,a.AccBatchDate,a.AccEffectiveDate,a.IssueBy,a.SalesDescription,b.TotalExpense as Dr,b.TotalExpense as Cr
        from vPC_D a inner join [job_3x].dbo.Job_ClearHeader b on a.DocRefNo=b.ClrNo 
		where b.ClrDate>=@datefrom and b.ClrDate<=@dateto
    ) t
) h where not exists(select 1 from Acc_JournalHD where JournalNo=h.AccDocNo)

insert into Acc_JournalDT (EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select EntryId,Seq,AccCode,AccDesc,AccDocNo,Dr,Cr from (
    select @id+DENSE_RANK() OVER (ORDER BY d.AccDocNo,d.SalesDescription) as EntryId,
    ROW_NUMBER() OVER (PARTITION BY d.AccDocNo,d.SalesDescription ORDER BY d.AccDocNo,d.SalesDescription) as Seq,
    d.AccDocNo,d.SalesDescription,t.AccCode,t.AccName,t.AccDesc,sum(t.Debit) as Dr,sum(t.Credit) as Cr 
    from (
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccName,a.SalesDescription as AccDesc,
        a.Amount+a.VatAmount-a.WhtAmount as Debit,0 as Credit
        from vPC_D a,vMas_AccCode b
        where b.AccCode=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
		and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        UNION ALL
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccDesc,a.SalesDescription as AccDesc,
        0 as Debit,a.Amount+a.VatAmount-a.WhtAmount as Credit
        from vPC_D a,vMas_AccCode b
        where b.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
        and a.AccSourceDocItem>0
		and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
        union all
        select a.AccDocNo,a.AccItemNo,b.AccCode,a.ProductName as AccDesc,a.SalesDescription as AccDesc,
        0 as Debit,a.Amount+a.VatAmount-a.WhtAmount as Credit
        from vPC_D a,vMas_AccCode b
        where b.AccCode=dbo.GetAccConfig('AP_CONFIG','Purchase')
        and a.AccSourceDocItem=0
		and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto
    ) t inner join vPC_D d on t.AccDocNo=d.AccDocNo and t.AccItemNo=d.AccItemNo
    inner join [job_3x].dbo.Job_ClearHeader b on d.DocRefNo=b.ClrNo 
    group by d.AccDocNo,d.SalesDescription,t.AccCode,t.AccName,t.AccDesc
) d 
--select * from vMas_AccConfigCode 
--select * from vMas_DocConfigStandard where Category='DP'

update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr

end

GO
/****** Object:  StoredProcedure [dbo].[Insert_PostCNDNToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_PostCNDNToJournal]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin
delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CNDNHeader b on
a.JournalNo=b.DocNo
where b.DocDate>=@datefrom and b.DocDate<=@dateto and b.CustCode like @custcode+'%';

delete b from Acc_JournalDT b 
where not exists(select 1 from Acc_JournalHD where EntryID=b.EntryId)


declare @id int=(select isnull(MAX(EntryId),0) as id from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo) as EntryID,
a.AccDocNo as JournalNo,a.AccBatchDate,a.AccEffectiveDate,IssueBy,AccDocNo,0,0
from vTransaction_H a 
inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo
where a.AccDocType='CN3'
and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
order by a.AccDocNo

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY AccDocNo),
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo,AccCode) as Seq,
AccCode,AccName,AccDesc,Debit,Credit from (
	select AccDocNo,AccCode,AccName,AccDesc,sum(Debit) as Debit,Sum(Credit) as Credit from (
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode as AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,0 as Debit,
	sum(ABS(a.Amount+a.DVatAmt-a.DWhtAmt)) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo,
	vMas_AccCode p 
	where a.AccDocType='CN3'  and a.Qty<0 and p.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemno,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode as AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(ABS(a.Amount+a.DVatAmt-a.DWhtAmt)) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo,
	vMas_AccCode p 
	where a.AccDocType='CN3'  and a.Qty>0  and p.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemno,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode as AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,0 as Debit,
	sum(ABS(a.DWhtAmt)) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo,
	vMas_AccCode p 
	where a.AccDocType='CN3'  and a.Qty<0 and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemno,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode as AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(ABS(a.DWhtAmt)) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo,
	vMas_AccCode p 
	where a.AccDocType='CN3'  and a.Qty>0 and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemno,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,a.IncomeAccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(ABS(case when a.ProductCode like 'A%' then a.Amount+a.DVatAmt else a.Amount end)) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo
	where a.AccDocType='CN3' and a.Qty<0
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemNo,a.IncomeAccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,a.IncomeAccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	0 as Debit,sum(ABS(case when a.ProductCode like 'A%' then a.Amount+a.DVatAmt else a.Amount end)) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo
	where a.AccDocType='CN3' and a.Qty>0
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemNo,a.IncomeAccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(ABS(a.DVatAmt)) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo,vMas_AccCode p
	where a.AccDocType='CN3' AND a.ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	and ABS(a.DVatAmt)>0 and a.Qty<0
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	0 as Debit,sum(a.DVatAmt) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_CNDNHeader b on a.AccDocNo=b.DocNo,vMas_AccCode p
	where a.AccDocType='CN3' AND a.ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')
	and a.AccBatchDate>=@datefrom and a.AccBatchDate<=@dateto and b.CustCode like @custcode+'%'
	and ABS(a.DVatAmt)>0 and a.Qty>0
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	) dt
	group by AccDocNo,AccCode,AccName,AccDesc
) t

delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)

update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_PostInvoiceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*
select SaleProductCode,SalesDescription,count(*) from vTransaction_All d where AccDocType='SI'
and AccSourceDocItem>0 and exists(select 1 from Acc_TransactionDT where AccDocNo=d.AccSourceDocNo and AccItemNo=d.AccSourceDocItem)
group by SaleProductCode,SalesDescription
*/
CREATE procedure [dbo].[Insert_PostInvoiceToJournal]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20)
)
as
begin

delete a from Acc_JournalHD a
where exists(select 1 from vAR_H where AccBatchDate>=@datefrom and AccBatchDate<=@dateto and AccDocNo=a.JournalNo);

delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD);

declare @id int=(select isnull(MAX(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalDT (EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select EntryId,Seq,AccCode,AccDesc,AccDocNo,Debit,Credit 
from (
	select @id+DENSE_RANK() OVER(ORDER BY AccDocNo) as EntryID,
	ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo,AccDesc) as Seq,
	AccDocNo,AccCode,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit
	from (		
		select AccDocNo,AccItemNo,
		AssetAccCode as AccCode,ProductName as AccName,SalesDescription as AccDesc
		,sum(Amount+VatAmount) as Debit,0 as Credit
		from vAR_D d where d.AccBatchDate>=@datefrom and d.AccBatchDate<=@dateto 
		group by AccDocNo,AccItemNo,AssetAccCode,ProductName,SalesDescription
		UNION ALL
		select AccDocNo,AccItemNo,
		IncomeAccCode as AccCode,ProductName as AccName,SalesDescription as AccDesc
		,0 as Debit,sum(Amount) as Credit
		from vAR_D d where ProductCode like 'S%'
		and d.AccBatchDate>=@datefrom and d.AccBatchDate<=@dateto 
		group by AccDocNo,AccItemno,IncomeAccCode,ProductNAme,SalesDescription
		union all
		select AccDocNo,AccItemNo,
		p.AccCode as AccCode,ProductName as AccName,SalesDescription as AccDesc
		,0 as Debit,sum(VatAmount) as Credit
		from vAR_D d,vMas_AccCode p 
		where ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat')
		and VatAmount>0
		and d.AccBatchDate>=@datefrom and d.AccBatchDate<=@dateto 
		group by AccDocNo,AccItemNo,p.AccCode,ProductName,SalesDescription
		union all
		select AccDocNo,AccItemNo,
		p.AccCode as AccCode,ProductName as AccName,SalesDescription as AccDesc
		,0 as Debit,sum(Amount+VatAmount) as Credit
		from vAR_D d,vMas_AccCode p 
		where ProductCode like 'A%' and p.AccCode=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
		and d.AccBatchDate>=@datefrom and d.AccBatchDate<=@dateto 
		group by AccDocNo,AccItemNo,p.AccCode,ProductName,SalesDescription
	) t 
	group by AccDocno,AccCode,AccDesc
) tb 
where not exists(select 1 from Acc_JournalDT where EntryId=tb.EntryID and Seq=tb.Seq)
order by AccDocNo

insert into Acc_JournalHD (EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
select d.EntryId,h.AccDocNo,AccBatchDate,AccEffectiveDate,IssueBy,DocRefNo,0,0
from vAR_H h inner join 
(
	select distinct EntryID,AccDesc as DocNo from Acc_JournalDT
	where EntryId not in(select EntryId from Acc_JournalHD)
) d on h.AccDocNo=d.DocNo
where AccDocType='SI' 
and h.AccBatchDate>=@datefrom and h.AccBatchDate<=@dateto 
and not exists(select 1 from Acc_JournalHD where EntryId=d.EntryID)
order by AccDocNo

--clear error
delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)
--update total
update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr

end


GO
/****** Object:  StoredProcedure [dbo].[Insert_PostReceiptToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_PostReceiptToJournal]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin
delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ReceiptHeader b on
replace(a.JournalNo,'RV-','')=b.ReceiptNo
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%';

delete b from Acc_JournalDT b 
where not exists(select 1 from Acc_JournalHD where EntryID=b.EntryId)


declare @id int=(select isnull(MAX(EntryId),0) as id from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo) as EntryID,
concat('RV-',a.AccDocNo) as JournalNo,a.AccBatchDate,a.AccEffectiveDate,IssueBy,AccDocNo,0,0
from vTransaction_H a 
inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo
where a.AccDocType='RC '
and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%'
order by a.AccDocNo

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY AccDocNo),
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo,AccCode) as Seq,
AccCode,AccName,AccDesc,Debit,Credit from (
	select AccDocNo,AccCode,AccName,AccDesc,sum(Debit) as Debit,Sum(Credit) as Credit from (
	select 
	a.AccDocNo,a.AccItemNo,a.AssetAccCode as AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,0 as Debit,
	sum(a.Amount+a.DVatAmt) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo
	where a.AccDocType='RC' 
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemno,a.AssetAccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(case when a.ProductCode like 'A%' then a.Amount+a.DVatAmt else a.DNetAmt end) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo,vMas_AccCode p
	where a.AccDocType='RC' and p.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%'
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(a.DWhtAmt) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo,vMas_AccCode p
	where a.AccDocType='RC' AND a.ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%'
	and a.DWhtAmt>0
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(a.DVatAmt) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo,vMas_AccCode p
	where a.AccDocType='RC' AND a.ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat')
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%'
	and a.DVatAmt>0
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	0 as Debit,sum(a.DVatAmt) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo,vMas_AccCode p
	where a.AccDocType='RC' AND a.ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @custcode+'%'
	and a.DVatAmt>0
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	) dt
	group by AccDocNo,AccCode,AccName,AccDesc
) t

delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)

update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_ProductsCodeFromJob]
as
begin
--ลบก่อน
delete a
from dbo.Mas_Products a inner join [job_3x].dbo.Job_SrvSingle s 
on a.ProductCode=s.SICode 
--รหัสค่าบริการที่คิด VAT หัก 3 เข้ากลุ่มสินค้า SV1
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV1'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT หัก 1 เข้ากลุ่มสินค้า SV2 (ค่าขนส่งต่างๆ)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV2'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ หัก 1 เข้ากลุ่ม SV3 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV3'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ ไม่มีหัก  เข้ากลุ่ม SV4 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV4'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=0
--รหัสค่าบริการที่ไม่คิด VAT และ หัก 3 เข้ากลุ่ม SV5 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV5'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT และ ไม่หักเลยเข้ากลุ่ม SV6 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV6'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=0
--รหัสค่าใช้จ่ายต้นทุนที่คิด VAT หัก 3 เข้ากลุ่ม CSV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSV'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT หัก 1 เข้ากลุ่ม CTR
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CTR'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT ไม่ได้หัก 1 เข้ากลุ่ม CSN
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSN'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND NOT s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่มีใบเสร็จเข้ากลุ่ม CEX
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CEX'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=0 and s.IsExpense=1
--รหัสเงินค่าใช้จ่ายของลูกค้าเข้า ADV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','ADV'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsCredit=1 and s.IsExpense=0
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromjob_3x]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_ProductsCodeFromjob_3x]
as
begin
--ลบก่อน
delete a
from dbo.Mas_Products a inner join [job_3x].dbo.Job_SrvSingle s 
on a.ProductCode=s.SICode 
--รหัสค่าบริการที่คิด VAT หัก 3 เข้ากลุ่มสินค้า SV1
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV1'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT หัก 1 เข้ากลุ่มสินค้า SV2 (ค่าขนส่งต่างๆ)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV2'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ หัก 1 เข้ากลุ่ม SV3 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV3'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ ไม่มีหัก  เข้ากลุ่ม SV4 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV4'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=0
--รหัสค่าบริการที่ไม่คิด VAT และ หัก 3 เข้ากลุ่ม SV5 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV5'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT และ ไม่หักเลยเข้ากลุ่ม SV6 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV6'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=0
--รหัสค่าใช้จ่ายต้นทุนที่คิด VAT หัก 3 เข้ากลุ่ม CSV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSV'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT หัก 1 เข้ากลุ่ม CTR
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CTR'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT ไม่ได้หัก 1 เข้ากลุ่ม CSN
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSN'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND NOT s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่มีใบเสร็จเข้ากลุ่ม CEX
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CEX'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=0 and s.IsExpense=1
--รหัสเงินค่าใช้จ่ายของลูกค้าเข้า ADV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','ADV'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsCredit=1 and s.IsExpense=0


--Create SubAccounts
declare @codeca nvarchar(20)=dbo.GetAccConfig('ADV_CONFIG','CashIn')
declare @codear nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Sales')
declare @codeap nvarchar(20)=dbo.GetAccConfig('AP_CONFIG','Purchase')
declare @codead nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Advance')
declare @codeci nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','ChequeIn')
declare @codewp nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
declare @codeai nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueIncome')
declare @codeae nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueExpense')

EXEC dbo.Insert_SubAccCodefromUser @codeca,0

EXEC dbo.Insert_SubAccCodefromCustomer @codear,0
EXEC dbo.Insert_SubAccCodefromCustomer @codead,0
EXEC dbo.Insert_SubAccCodefromCustomer @codewp,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeai,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeci,0

EXEC dbo.Insert_SubAccCodefromVender @codeap,0
EXEC dbo.Insert_SubAccCodefromVender @codeae,0

--EXEC dbo.Insert_SubAccCodeFromService 'S','4100-00',0
EXEC dbo.Insert_SubAccCodeFromSCharge 'S','4100-01',0
EXEC dbo.Insert_SubAccCodeFromTCharge 'S','4100-02',0
EXEC dbo.Insert_SubAccCodeFromOCharge 'S','4100-05',0
EXEC dbo.Insert_SubAccCodeFromService 'A','5200-00',0
EXEC dbo.Insert_SubAccCodeFromService 'ERN','5100-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CSS','5130-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CST','5110-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EXC','5390-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EX-','5300-00',0
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromjob_3xacc]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_ProductsCodeFromjob_3xacc]
as
begin
--ลบก่อน
delete a
from dbo.Mas_Products a inner join [job_3xacc].dbo.Job_SrvSingle s 
on a.ProductCode=s.SICode 
--รหัสค่าบริการที่คิด VAT หัก 3 เข้ากลุ่มสินค้า SV1
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV1'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT หัก 1 เข้ากลุ่มสินค้า SV2 (ค่าขนส่งต่างๆ)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV2'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ หัก 1 เข้ากลุ่ม SV3 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV3'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ ไม่มีหัก  เข้ากลุ่ม SV4 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV4'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=0
--รหัสค่าบริการที่ไม่คิด VAT และ หัก 3 เข้ากลุ่ม SV5 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV5'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT และ ไม่หักเลยเข้ากลุ่ม SV6 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV6'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=0
--รหัสค่าใช้จ่ายต้นทุนที่คิด VAT หัก 3 เข้ากลุ่ม CSV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSV'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT หัก 1 เข้ากลุ่ม CTR
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CTR'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT ไม่ได้หัก 1 เข้ากลุ่ม CSN
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSN'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND NOT s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่มีใบเสร็จเข้ากลุ่ม CEX
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CEX'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=0 and s.IsExpense=1
--รหัสเงินค่าใช้จ่ายของลูกค้าเข้า ADV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','ADV'
from [job_3xacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsCredit=1 and s.IsExpense=0


--Create SubAccounts
declare @codeca nvarchar(20)=dbo.GetAccConfig('ADV_CONFIG','CashIn')
declare @codear nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Sales')
declare @codeap nvarchar(20)=dbo.GetAccConfig('AP_CONFIG','Purchase')
declare @codead nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Advance')
declare @codeci nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','ChequeIn')
declare @codewp nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
declare @codeai nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueIncome')
declare @codeae nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueExpense')

EXEC dbo.Insert_SubAccCodefromUser @codeca,0

EXEC dbo.Insert_SubAccCodefromCustomer @codear,0
EXEC dbo.Insert_SubAccCodefromCustomer @codead,0
EXEC dbo.Insert_SubAccCodefromCustomer @codewp,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeai,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeci,0

EXEC dbo.Insert_SubAccCodefromVender @codeap,0
EXEC dbo.Insert_SubAccCodefromVender @codeae,0

--EXEC dbo.Insert_SubAccCodeFromService 'S','4100-00',0
EXEC dbo.Insert_SubAccCodeFromSCharge 'S','4100-01',0
EXEC dbo.Insert_SubAccCodeFromTCharge 'S','4100-02',0
EXEC dbo.Insert_SubAccCodeFromOCharge 'S','4100-05',0
EXEC dbo.Insert_SubAccCodeFromService 'A','5200-00',0
EXEC dbo.Insert_SubAccCodeFromService 'ERN','5100-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CSS','5130-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CST','5110-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EXC','5390-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EX-','5300-00',0
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromjob_demoacc]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_ProductsCodeFromjob_demoacc]
as
begin
--ลบก่อน
delete a
from dbo.Mas_Products a inner join [job_demoacc].dbo.Job_SrvSingle s 
on a.ProductCode=s.SICode 
--รหัสค่าบริการที่คิด VAT หัก 3 เข้ากลุ่มสินค้า SV1
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV1'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT หัก 1 เข้ากลุ่มสินค้า SV2 (ค่าขนส่งต่างๆ)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV2'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ หัก 1 เข้ากลุ่ม SV3 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV3'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ ไม่มีหัก  เข้ากลุ่ม SV4 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV4'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=0
--รหัสค่าบริการที่ไม่คิด VAT และ หัก 3 เข้ากลุ่ม SV5 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV5'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT และ ไม่หักเลยเข้ากลุ่ม SV6 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV6'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=0
--รหัสค่าใช้จ่ายต้นทุนที่คิด VAT หัก 3 เข้ากลุ่ม CSV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSV'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT หัก 1 เข้ากลุ่ม CTR
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CTR'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT ไม่ได้หัก 1 เข้ากลุ่ม CSN
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSN'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND NOT s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่มีใบเสร็จเข้ากลุ่ม CEX
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CEX'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=0 and s.IsExpense=1
--รหัสเงินค่าใช้จ่ายของลูกค้าเข้า ADV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','ADV'
from [job_demoacc].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsCredit=1 and s.IsExpense=0


--Create SubAccounts
declare @codeca nvarchar(20)=dbo.GetAccConfig('ADV_CONFIG','CashIn')
declare @codear nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Sales')
declare @codeap nvarchar(20)=dbo.GetAccConfig('AP_CONFIG','Purchase')
declare @codead nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Advance')
declare @codeci nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','ChequeIn')
declare @codewp nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
declare @codeai nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueIncome')
declare @codeae nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueExpense')

EXEC dbo.Insert_SubAccCodefromUser @codeca,0

EXEC dbo.Insert_SubAccCodefromCustomer @codear,0
EXEC dbo.Insert_SubAccCodefromCustomer @codead,0
EXEC dbo.Insert_SubAccCodefromCustomer @codewp,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeai,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeci,0

EXEC dbo.Insert_SubAccCodefromVender @codeap,0
EXEC dbo.Insert_SubAccCodefromVender @codeae,0

--EXEC dbo.Insert_SubAccCodeFromService 'S','4100-00',0
EXEC dbo.Insert_SubAccCodeFromSCharge 'S','4100-01',0
EXEC dbo.Insert_SubAccCodeFromTCharge 'S','4100-02',0
EXEC dbo.Insert_SubAccCodeFromOCharge 'S','4100-05',0
EXEC dbo.Insert_SubAccCodeFromService 'A','5200-00',0
EXEC dbo.Insert_SubAccCodeFromService 'ERN','5100-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CSS','5130-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CST','5110-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EXC','5390-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EX-','5300-00',0
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_ProductsCodeFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_ProductsCodeFromJob_V2]
as
begin
--ลบก่อน
delete a
from dbo.Mas_Products a inner join [job_3x].dbo.Job_SrvSingle s 
on a.ProductCode=s.SICode 
--รหัสค่าบริการที่คิด VAT หัก 3 เข้ากลุ่มสินค้า SV1
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV1'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT หัก 1 เข้ากลุ่มสินค้า SV2 (ค่าขนส่งต่างๆ)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV2'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ หัก 1 เข้ากลุ่ม SV3 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV3'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=1
--รหัสค่าบริการที่คิด VAT และ ไม่มีหัก  เข้ากลุ่ม SV4 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV4'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=1 and s.Rate50Tavi=0
--รหัสค่าบริการที่ไม่คิด VAT และ หัก 3 เข้ากลุ่ม SV5 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV5'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=3
--รหัสค่าบริการที่ไม่คิด VAT และ ไม่หักเลยเข้ากลุ่ม SV6 (ถ้ามี)
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','SV6'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null AND s.IsCredit=0 AND s.IsExpense=0 AND s.IsTaxCharge=0 and s.Rate50Tavi=0
--รหัสค่าใช้จ่ายต้นทุนที่คิด VAT หัก 3 เข้ากลุ่ม CSV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSV'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT หัก 1 เข้ากลุ่ม CTR
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CTR'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่คิด VAT ไม่ได้หัก 1 เข้ากลุ่ม CSN
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CSN'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=1 and s.IsExpense=1 and s.IsTaxCharge=0 AND NOT s.Rate50Tavi=1
--รหัสค่าใช้จ่ายต้นทุนที่ไม่มีใบเสร็จเข้ากลุ่ม CEX
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','CEX'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsHaveSlip=0 and s.IsExpense=1
--รหัสเงินค่าใช้จ่ายของลูกค้าเข้า ADV
insert into dbo.Mas_Products 
(ProductCode,ProductName,
Brand,Color,Size,SizeUnit,Volume,VolumeUnit,UnitStock,ProductTypeCode)
select s.SICode,s.NameThai,
'','',0,'SHP',0,'SHP','SHP','ADV'
from [job_3x].dbo.Job_SrvSingle s
left join Mas_Products a
on s.SICode=a.ProductCode
where a.ProductCode is null and s.IsCredit=1 and s.IsExpense=0

/*
--Create SubAccounts
declare @codeca nvarchar(20)=dbo.GetAccConfig('ADV_CONFIG','CashIn')
declare @codear nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Sales')
declare @codeap nvarchar(20)=dbo.GetAccConfig('AP_CONFIG','Purchase')
declare @codead nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','Advance')
declare @codeci nvarchar(20)=dbo.GetAccConfig('AR_CONFIG','ChequeIn')
declare @codewp nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','WorkInProcess')
declare @codeai nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueIncome')
declare @codeae nvarchar(20)=dbo.GetAccConfig('GL_CONFIG','AccrueExpense')

EXEC dbo.Insert_SubAccCodefromUser @codeca,0

EXEC dbo.Insert_SubAccCodefromCustomer @codear,0
EXEC dbo.Insert_SubAccCodefromCustomer @codead,0
EXEC dbo.Insert_SubAccCodefromCustomer @codewp,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeai,0
EXEC dbo.Insert_SubAccCodefromCustomer @codeci,0

EXEC dbo.Insert_SubAccCodefromVender @codeap,0
EXEC dbo.Insert_SubAccCodefromVender @codeae,0

EXEC dbo.Insert_SubAccCodeFromService 'S','4100-00',0
EXEC dbo.Insert_SubAccCodeFromService 'A','5200-00',0
EXEC dbo.Insert_SubAccCodeFromService 'ERN','5100-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CSS','5130-00',0
EXEC dbo.Insert_SubAccCodeFromService 'CST','5110-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EXC','5390-00',0
EXEC dbo.Insert_SubAccCodeFromService 'EX-','5300-00',0
*/
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromBillPay]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_PVFromBillPay]
(
	@datefrom date,
	@dateto date,
	@userid varchar(20),
	@vencode varchar(20)=''
)
as
begin
--delete first
delete h from Acc_TransactionHD h
inner join [job_3x].dbo.Job_PaymentHeader d 
on h.AccDocNo=d.PaymentRef
where d.PaymentDate>=@datefrom and d.PaymentDate<=@dateto
and d.VenCode like @vencode+'%' and d.PaymentRef<>''

delete d from Acc_TransactionDT d 
left join Acc_TransactionHD h 
on d.AccDocNo=h.AccDocNo 
where h.AccDocNo is null

Insert into Acc_TransactionDT
(AccDocNo,AccItemno,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMEa,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
RateVat,RateWht,VatType)
select h.PaymentRef,ROW_NUMBER() OVER(PARTITION BY h.PaymentRef ORDER BY d.DocNo,d.ItemNo),d.DocNo,d.ItemNo,0,
d.Qty,d.UnitPrice,d.QtyUnit,h.CurrencyCode,h.ExchangeRate,d.Amt,d.SICode,d.ForJNo,
round((d.amtvat*100/d.amt),0),
round((d.amtWht*100/d.amt),0),1
from [job_3x].dbo.Job_CashControlDoc c 
inner join [job_3x].dbo.Job_PaymentHeader h on c.BranchCode=h.BranchCode and c.ControlNo=h.PaymentRef
and c.DocNo=h.DocNo
inner join [job_3x].dbo.Job_PaymentDetail d on h.BranchCode=d.BranchCode and h.DocNo=d.DocNo 
where isnull(h.CancelProve,'')='' and h.PaymentRef<>'' and d.Amt>0
and h.PaymentDate>=@datefrom and h.PaymentDate<=@dateto and h.VenCode like @vencode+'%'

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyNAme,PartyAddress,
IssueBy,AccPostDate,FiscalYear,DocStatus,DocRefNo,AccDocType)
select distinct c.ControlNo,c.VoucherDate,c.VoucherDate,
c.CustCode,concat(u.TaxNumber,'/',u.BranchCode),isnull(u.TName,''),concat(u.TAddress1,' ',u.TAddress2),
c.RecUser,c.RecDate,c.RecDate,0,c.ControlNo,'PC'
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_CashControl c on h.PaymentRef=c.ControlNo 
left join [job_3x].dbo.Mas_Vender u on h.VenCode =u.VenCode
where isnull(h.CancelProve,'')=''  and h.TotalExpense>0 and h.PaymentRef<>''
and exists(select 1 from [job_3x].dbo.Job_PaymentDetail where DocNo=h.DocNo)
and h.PaymentDate>=@datefrom and h.PaymentDate<=@dateto and h.VenCode like @vencode+'%'

end
/**patch data**/
--update [job_3x].dbo.Job_PaymentDetail set Amt=Qty*UnitPrice where Amt=0
--update [job_3x].dbo.Job_PaymentHeader set ExchangeRate=1 where ExchangeRate=0
--update h set h.VenCode='V0012' from [job_3x].dbo.Job_PaymentHeader h where not exists(select 1 from [job_3x].dbo.Mas_Vender where VenCode=h.VenCode)
--select amt,amtwht,(amtWht*100/amt) as ratecak from [job_3x].dbo.Job_PaymentDetail d  where AmtWHT>0 order by 2 desc
--select amt,amtvat,round((amtvat*100/amt),0) as ratecak from [job_3x].dbo.Job_PaymentDetail d  where AmtVAT>0 order by 2 desc

/**data lost**/
/*
select d2.* 
from [job_3x].dbo.Job_ClearDetail d1
right join [job_3x].dbo.Job_PaymentDetail d2 on
d2.ClrRefNo=d1.ClrNo and d2.ClrItemNo=d1.ItemNo 
where d1.VenderBillingNo=concat(d2.DocNo,'#',d2.ItemNo)

select d1.* 
from [job_3x].dbo.Job_ClearDetail d1
left join [job_3x].dbo.Job_PaymentDetail d2 on
d1.VenderBillingNo= concat(d2.DocNo,'#',d2.ItemNo)
where d2.DocNo is null and d1.VenderBillingNo<>''
*/

GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromBillPay_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_PVFromBillPay_V2]
(
	@datefrom date,
	@dateto date
)
as
begin
--**PV from AP**--
--delete first
delete h from Acc_TransactionHD h
inner join [job_3x].dbo.Job_PaymentHeader d 
on h.AccDocNo=d.PaymentRef
inner join [job_3x].dbo.Job_CashControl v on d.PaymentRef=v.ControlNo
where v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
and d.PaymentRef<>''

delete d from Acc_TransactionDT d 
left join Acc_TransactionHD h 
on d.AccDocNo=h.AccDocNo 
where h.AccDocNo is null

Insert into Acc_TransactionDT
(AccDocNo,AccItemno,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMEa,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
RateVat,RateWht,VatType)
select h.PaymentRef,ROW_NUMBER() OVER(PARTITION BY h.PaymentRef ORDER BY d.DocNo,d.ItemNo),d.DocNo,d.ItemNo,0,
(case when isnull(s.IsCredit,1)=1 then 1 else d.Qty end) as Qty,
(case when isnull(s.IsCredit,1)=1 then d.FTotal else d.UnitPrice end) as UnitPrice,
d.QtyUnit,h.CurrencyCode,h.ExchangeRate,
(case when isnull(s.IsCredit,1)=1 then d.Total else d.Amt end) as Amt,
d.SICode,d.ForJNo,
(case when isnull(s.IsCredit,1)=1 then 0 else round((d.amtvat*100/d.amt),0) end) as VatRate,
(case when isnull(s.IsCredit,1)=1 then 0 else round((d.amtWht*100/d.amt),0) end) as TaxRate
,1 as VatType
from [job_3x].dbo.Job_CashControlDoc c 
inner join [job_3x].dbo.Job_CashControl v on c.ControlNo=v.ControlNo
inner join [job_3x].dbo.Job_PaymentHeader h on c.BranchCode=h.BranchCode and c.ControlNo=h.PaymentRef
and c.DocNo=h.DocNo
inner join [job_3x].dbo.Job_PaymentDetail d on h.BranchCode=d.BranchCode and h.DocNo=d.DocNo 
left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode
where isnull(h.CancelProve,'')='' and h.PaymentRef<>'' and d.Amt>0
and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto 

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyNAme,PartyAddress,
IssueBy,AccPostDate,FiscalYear,DocStatus,DocRefNo,AccDocType)
select distinct c.ControlNo,c.VoucherDate,c.VoucherDate,
c.CustCode,concat(u.TaxNumber,'/',u.BranchCode),isnull(u.TName,''),concat(u.TAddress1,' ',u.TAddress2),
c.RecUser,c.RecDate,c.RecDate,0,c.ControlNo,'PC'
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_CashControl c on h.PaymentRef=c.ControlNo 
inner join [job_3x].dbo.Job_CashControl v on c.ControlNo=v.ControlNo
left join [job_3x].dbo.Mas_Vender u on h.VenCode =u.VenCode
where isnull(h.CancelProve,'')=''  and h.TotalExpense>0 and h.PaymentRef<>''
and exists(select 1 from [job_3x].dbo.Job_PaymentDetail where DocNo=h.DocNo)
and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto 


delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PV-B',b.PaymentRef)
and b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto;

delete b from Acc_JournalDT b
where not exists(select 1 from Acc_JournalHD where EntryId=b.EntryId)

update a set a.PaymentDate=c.VoucherDate
from [job_3x].dbo.Job_PaymentHeader a
left join [job_3x].dbo.Job_CashControlDoc d on a.DocNo=d.DocNo and a.PaymentRef=d.ControlNo 
left join [job_3x].dbo.Job_CashControl c on d.ControlNo=c.ControlNo and isnull(c.CancelProve,'')=''
where a.PaymentRef<>'' 
and c.VoucherDate<>a.PaymentDate

select * into #tmp3 from (
	select a.DocNo as RefNo,h.ControlNo as DocNo,h.VoucherDate as DocDate,
	concat(isnull(v.TaxNumber,''),' - ',isnull(v.TName,'')) as VenderName,h.RecUser as EmpCode,h.TRemark,b.ForJNo as JNo,
	isnull(c.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')) as AccCodeC,
	isnull(av.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeD,
	sum(b.Amt+b.AmtVAT) as Totalpay,sum(case when s.IsCredit=1 then 0 else b.AmtWHT end) as WhdAmt,
	sum(case when s.IsCredit=1 then 0 else b.AmtVAT end) as TotalVat,
	sum(case when s.IsCredit=1 then b.Total+b.AmtWHT else b.Total end) as TotalNet
	from [job_3x].dbo.Job_PaymentHeader a
	inner join [job_3x].dbo.Job_PaymentDetail b
	on a.DocNo=b.DocNo 	
	left join [job_3x].dbo.Job_SrvSingle s on b.SICode=s.SICode
	left join (
		select s.ControlNo,MAX(b.GLAccountCode) as AccCode
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		on s.BookCode=b.BookCode
		group by s.ControlNo
	) c on a.PaymentRef=c.ControlNo
	left join [job_3x].dbo.Mas_Vender v on a.VenCode=v.VenCode
	left join dbo.Mas_AccCode av on v.GLAccountCode=av.AccCode
	left join [job_3x].dbo.Job_CashControlDoc d on a.DocNo=d.DocNo and a.PaymentRef=d.ControlNo 
	left join [job_3x].dbo.Job_CashControl h on d.ControlNo=h.ControlNo and isnull(h.CancelProve,'')=''
	where a.PaymentRef<>''
	and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto
	group by isnull(c.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')),
	isnull(av.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')),
	a.DocNo,h.ControlNo,h.VoucherDate,concat(isnull(v.TaxNumber,''),' - ',isnull(v.TName,'')),h.RecUser,h.TRemark,b.ForJNo
) t

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(Order By DocNo),DocNo,DocDate,DocDate,EmpCode,TRemark,Total,Total
from (
	select CONCAT('PV-B',DocNo) as DocNo,DocDate,EmpCode,TRemark,sum(TotalPay) as Total
	from #tmp3
	group by DocNo,DocDate,EmpCode,TRemark
) t

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,ItemNo),
AccCode,AccName,AccDesc,Debit,Credit
from (
	select DocNo,0 as ItemNo,AccCodeD as AccCode,VenderName as AccDesc,JNo as AccName,
	sum(Totalpay) as Debit,0 as Credit
	from #tmp3
	group by DocNo,AccCodeD,VenderName,JNo
	union all 
	select DocNo,1 as ItemNo,AccCodeC as AccCode,RefNo as AccDesc,JNo as AccName,
	0 as Debit,sum(TotalNet) as Credit
	from #tmp3
	group by DocNo,AccCodeC,RefNo,JNo
    union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,VenderName as AccDesc,JNo as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp3,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
	and VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,VenderName as AccDesc,JNo as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp3,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
	and NOT VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,3 as ItemNo,AccCode as AccCode,VenderName as AccDesc,JNo as AccName,
	0 as Debit,sum(TotalVat) as Credit
	from #tmp3,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')	
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,4 as ItemNo,AccCode as AccCode,VenderName as AccDesc,JNo as AccName,
	sum(TotalVat) as Debit,0 as Credit
	from #tmp3,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')	
	group by DocNo,AccCode,VenderName,JNo
) t

select * from Acc_JournalHD h 
where exists(select 1 from #tmp3 where concat('PV-B',DocNo)=h.JournalNo)

drop table #tmp3;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromBillPay_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO














CREATE procedure [dbo].[Insert_PVFromBillPay_V3]
(
	@datefrom date,
	@dateto date
)
as
begin

update p 
set p.PaymentRef=a.ControlNo,p.PaymentDate=a.VoucherDate
from [job_3x].dbo.Job_PaymentHeader p
inner join [job_3x].dbo.Job_CashControlDoc c
on p.DocNo=c.DocNo
inner join [job_3x].dbo.Job_CashControl a
on c.ControlNo=a.ControlNo
where isnull(a.CancelProve,'')=''
and a.VoucherDate>=@datefrom and a.VoucherDate<=@dateto

delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_PaymentHeader b
on a.JournalNo=concat('PV-P',b.PaymentRef)
and b.PaymentDate>=@datefrom and b.PaymentDate<=@dateto;

delete b from Acc_JournalDT b
where not exists(select 1 from Acc_JournalHD where EntryId=b.EntryId)

select * into #tmp1 from (
	select a.DocNo as RefNo,h.ControlNo as DocNo,h.VoucherDate as DocDate,
	concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')) as VenderName,h.RecUser as EmpCode,h.TRemark,b.ForJNo as JNo,
	isnull(c.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')) as AccCodeC,
	isnull(av.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeD,
	sum(b.Total) as Totalpay,
	sum(case when s.IsCredit=1 then 0 else b.AmtWHT end) as WhdAmt,
	sum(case when s.IsCredit=1 then 0 else b.AmtVAT end) as TotalVat,
	sum(b.Total) as TotalNet
	from [job_3x].dbo.Job_PaymentHeader a
	inner join [job_3x].dbo.Job_PaymentDetail b
	on a.DocNo=b.DocNo 	
	left join [job_3x].dbo.Job_SrvSingle s on b.SICode=s.SICode
	left join (
		select s.ControlNo,MAX(c.AccCode) as AccCode
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		on s.BookCode=b.BookCode
		left join Mas_AccCode c on b.GLAccountCode=c.AccCode
		group by s.ControlNo
	) c on a.PaymentRef=c.ControlNo
	left join [job_3x].dbo.Mas_Vender v on a.VenCode=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') av 
	on concat(av.AccMainName,'-',v.TName)=av.AccName
	left join [job_3x].dbo.Job_CashControlDoc d on a.DocNo=d.DocNo and a.PaymentRef=d.ControlNo 
	left join [job_3x].dbo.Job_CashControl h on d.ControlNo=h.ControlNo and isnull(h.CancelProve,'')=''
	where a.PaymentRef<>''
	and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto
	group by isnull(c.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')),
	isnull(av.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')),
	a.DocNo,h.ControlNo,h.VoucherDate,concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')),h.RecUser,h.TRemark,b.ForJNo
) t

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(Order By DocNo),DocNo,DocDate,DocDate,EmpCode,TRemark,Total,Total
from (
	select CONCAT('PV-P',DocNo) as DocNo,DocDate,EmpCode,TRemark,sum(TotalPay) as Total
	from #tmp1
	group by DocNo,DocDate,EmpCode,TRemark
) t

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,ItemNo),
AccCode,AccName,AccDesc,Debit,Credit
from (
	select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,VenderName as AccName,
	sum(TotalNet+WhdAmt) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,VenderName,JNo
	union all 
	select DocNo,1 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,DocNo as AccName,
	0 as Debit,sum(TotalNet) as Credit
	from #tmp1
	group by DocNo,AccCodeC,DocNo,JNo
    union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp1,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
	and VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp1,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
	and NOT VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,3 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(TotalVat) as Credit
	from #tmp1,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')	
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,4 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	sum(TotalVat) as Debit,0 as Credit
	from #tmp1,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')	
	group by DocNo,AccCode,VenderName,JNo
) t

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('PV-P',DocNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromPC]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

















CREATE procedure [dbo].[Insert_PVFromPC]
(
@transno nvarchar(50),
@userid nvarchar(50),
@docdate date,
@acccode nvarchar(20),
@bankchg float=0,
@pvno nvarchar(20)='',
@accdebit nvarchar(20)=''
)
as
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'ACC','PV')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT isnull(MAX(EntryId),0) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT('PV',FORMAT(@docdate,'yyMM')),'0000');
if @pvno<>''
begin
 set @running=@pvno;
end

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
select @maxid+1 as EntryID,
@running,@docdate  as EntryDate,
@docdate,@userid as UserID,
@transno,0,0
from vTransaction_H h
where h.AccDocNo=@transno
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)
and not exists(select EntryId from Acc_JournalHD where [Description]=@transno)

declare @eid int=(select isnull(EntryID,0) from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(Max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY a.AccCode)+@seq as Seq,
b.AccCode,a.AccName,a.AccDesc,a.Debit,a.Credit from
(
	select 
	(case when @accdebit='' then (case when h.IsService=0 then h.AssetAccCode else h.ExpenseAccCode end) else @accdebit end) as AccCode,
	h.AccDocNo,h.TotalAmount as Debit,0 as Credit,
	h.SalesDescription  as AccName,(case when h.AccSourceDocNo='' then h.AccDocNo else h.AccSourceDocNo end) as AccDesc
	from vPC_D h
	where h.AccDocNo=@transno
	and not (exists(select 1 from vAP_D where AccSourceDocNo=h.AccSourceDocNo and AccSourceDocItem=h.AccSourceDocItem
	and AccSourceDocNo<>'')
	or exists(select 1 from vAP_D where AccDocNo=h.AccSourceDocNo and AccItemNo=h.AccSourceDocItem))
	union all
	select 
	(case when @accdebit='' then dbo.GetAccConfig('AP_CONFIG','Purchase') else @accdebit end) as AccCode,
	h.AccDocNo,h.TotalAmount+h.VatAmount as Debit,0 as Credit,
	h.SalesDescription as AccName,h.AccSourceDocNo as AccDesc
	from vPC_D h
	where h.AccDocNo=@transno
	and (exists(select 1 from vAP_D where AccSourceDocNo=h.AccSourceDocNo and AccSourceDocItem=h.AccSourceDocItem
	and AccSourceDocNo<>'')
	or exists(select 1 from vAP_D where AccDocNo=h.AccSourceDocNo and AccItemNo=h.AccSourceDocItem))
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.VatAmount as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vPC_D h
	where h.AccDocNo=@transno and h.VatAmount>0	
	and (exists(select 1 from vAP_D where AccSourceDocNo=h.AccSourceDocNo and AccSourceDocItem=h.AccSourceDocItem and AccSourceDocNo<>'')
	or exists(select 1 from vAP_D where AccDocNo=h.AccSourceDocNo and AccItemNo=h.AccSourceDocItem))
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	h.AccDocNo,h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno and h.TotalVat>0
	union all
	select 
	@acccode as AccCode,
	h.AccDocNo,0 as Debit,h.TotalNet+@bankchg as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno	
	union all
	select 
	dbo.GetAccConfig('GL_CONFIG','BankCharge') as AccCode,
	h.AccDocNo,@bankchg as Debit,0 as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno and @bankchg>0
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno	
	and h.PartyTaxCode like '0%' and h.TotalWht>0
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxPerson') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno	
	and h.PartyTaxCode not like '0%' and h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
and exists(select 1 from Acc_JournalHD where EntryId=@eid)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid;

update Acc_TransactionHD set DocStatus=2 where AccDocNo=@transno and DocStatus=0;

select * from Acc_JournalHD where EntryId=@eid;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromPI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










/**
เพิ่ม @accdebit สำหรับกำหนด code เองด้าน Debit
เพิ่ม @acccredit สำหรับกำหนด code เองด้าน Credit
**/

CREATE procedure [dbo].[Insert_PVFromPI]
(
@invno nvarchar(50),
@userid nvarchar(50),
@taxno nvarchar(50),
@docdate date,
@pvno nvarchar(20)='',
@accdebit nvarchar(20)='',
@acccredit nvarchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'ACC','PV')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT isnull(MAX(EntryId),0) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT('PV',FORMAT(@docdate,'yyMM')),'0000');
if @pvno<>''
begin
 set @running=@pvno;
end

insert into Acc_JournalHD
select @maxid+1 as EntryID,
@running,@docdate  as EntryDate,
@docdate,@userid as UserID,
@taxno,0,0
from vAP_H h
where h.AccDocNo=@invno
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)

declare @eid int=(select EntryID from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(Max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo)+@seq as Seq,
b.AccCode,b.AccName,RefNo,a.Debit,a.Credit from
(
	select 
	dbo.GetAccConfig('AP_CONFIG','Purchase') as AccCode,
	h.AccDocNo,h.TotalAmount+h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno and @accdebit=''
	union all
	select 
	@accdebit as AccCode,
	h.AccDocNo,h.TotalAmount+h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno and @accdebit<>''
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalVat as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno and h.TotalVat>0
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	h.AccDocNo,h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno and h.TotalVat>0
	union all
	select 
	dbo.GetAccConfig('AP_CONFIG','Cashout') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalNet as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno	and @acccredit=''
	union all
	select 
	@acccredit as AccCode,
	h.AccDocNo,0 as Debit,h.TotalNet as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno	and @acccredit<>''
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno	
	and h.PartyTaxCode like '0%' and h.TotalWht>0
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxPerson') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAP_H h
	where h.AccDocNo=@invno	
	and h.PartyTaxCode not like '0%' and h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode


update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid;

select * from Acc_JournalHD where EntryId=@eid;
--update Acc_TransactionHD set DocStatus=2 where AccDocNo=@invno and DocStatus<2
end




GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromPO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












/**
เพิ่ม isExpense=0 ดึฃด้าน DEbit จาก AssetAccCode 
เพิ่ม isExpense=1 ดึฃด้าน DEbit จาก ExpenseAccCode
เพิ่ม accdebit สำหรับกำหนด acccode เอง
**/

CREATE procedure [dbo].[Insert_PVFromPO]
(
@pono nvarchar(50),
@userid nvarchar(50),
@taxno nvarchar(50),
@docdate date,
@trantype varchar(20),
@tranno varchar(50),
@trandatail varchar(255)='',
@pvno nvarchar(20)='',
@acccode nvarchar(20)='',
@doctype nvarchar(5)='PV',
@isexpense int=0,
@accdebit nvarchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'ACC','PV')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT isnull(MAX(EntryId),0) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
if @pvno<>''
begin
 set @running=@pvno;
end

insert into Acc_JournalHD
(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @maxid+1 as EntryID,
@running,@docdate  as EntryDate,
@docdate,@userid as UserID,
@taxno,0,0
from vPO_H h
where h.AccDocNo=@pono
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)
and not exists(select 1 from Acc_JournalDT where AccDesc=h.AccDocNo)

declare @eid int=(select isnull(EntryID,0) from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(Max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

if @acccode=''
begin
 set @acccode=dbo.GetAccConfig('AP_CONFIG','Cashout');
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY a.AccCode)+@seq as Seq,
b.AccCode,a.AccName,AccDesc,a.Debit,a.Credit from
(
	select 
	h.AssetAccCode as AccCode,
	h.AccDocNo,h.TotalAmount as Debit,0 as Credit,
	concat(h.SaleProductCode,' / ',h.SalesDescription) as AccName,h.AccDocNo as AccDesc
	from vPO_D h
	where h.AccDocNo=@pono and @isexpense=0 and @accdebit=''
	union all
	select 
	h.ExpenseAccCode as AccCode,
	h.AccDocNo,h.TotalAmount as Debit,0 as Credit,
	concat(h.SaleProductCode,' / ',h.SalesDescription) as AccName,h.AccDocNo as AccDesc
	from vPO_D h
	where h.AccDocNo=@pono and @isexpense=1 and @accdebit=''
	union all
	select 
	@accdebit as AccCode,
	h.AccDocNo,h.TotalAmount as Debit,0 as Credit,
	concat(h.SaleProductCode,' / ',h.SalesDescription) as AccName,h.AccDocNo as AccDesc
	from vPO_D h
	where h.AccDocNo=@pono and @accdebit<>''
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	h.AccDocNo,h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vPO_H h
	where h.AccDocNo=@pono and h.TotalVat>0
	union all
	select 
	@acccode as AccCode,
	h.AccDocNo,0 as Debit,h.TotalNet as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vPO_H h
	where h.AccDocNo=@pono	
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vPO_H h
	where h.AccDocNo=@pono	
	and h.PartyTaxCode like '0%' and h.TotalWht>0
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxPerson') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vPO_H h
	where h.AccDocNo=@pono	
	and h.PartyTaxCode not like '0%' and h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
where exists(select 1 from Acc_JournalHD where EntryId=@eid)

Insert Into Acc_AdditionData
(DocNo,Seq,Text8,Text9,Text10,Text3)
select @running,0,@trantype,@tranno,@taxno,@trandatail
where not exists(select 1 from Acc_AdditionData where DocNo=@running And Seq=0)
and exists(select 1 from Acc_JournalHD where EntryId=@eid)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid

delete from acc_journaldt where Entryid not in(select entryid from acc_journalhd)

--update Acc_TransactionHD set DocStatus=3 where AccDocNo=@pono and DocStatus=2

select * from Acc_JournalHD where EntryId=@eid;
end




GO
/****** Object:  StoredProcedure [dbo].[Insert_PVFromTransaction]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/**
เพิ่ม @accdebit สำหรับกำหนด code เองด้าน Debit
เพิ่ม @acccredit สำหรับกำหนด code เองด้าน Credit
**/

CREATE procedure [dbo].[Insert_PVFromTransaction]
(
@docno nvarchar(50),
@userid nvarchar(50),
@taxno nvarchar(50),
@docdate date,
@pvno nvarchar(20)='',
@accdebit nvarchar(20)='',
@acccredit nvarchar(20)=''
)
as
begin

declare @maxid int;
set @maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT('PV',FORMAT(@docdate,'yyMM')),'0000');
if @pvno<>''
begin
 set @running=@pvno;
end

insert into Acc_JournalHD
select @maxid+1 as EntryID,
@running, @docdate as EntryDate,
@docdate,@userid as UserID,
@taxno,0,0
from vTransaction_H h
where h.AccDocNo=@docno
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)

declare @eid int=(select EntryID from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(Max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo)+@seq as Seq,
b.AccCode,b.AccName,RefNo,a.Debit,a.Credit from
(
	select 
	dbo.GetAccConfig('AP_CONFIG','Purchase') as AccCode,
	h.AccDocNo,h.TotalAmount+h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno and @accdebit=''
	union all
	select 
	@accdebit as AccCode,
	h.AccDocNo,
	(case when h.AccDocType='PI' THEN h.TotalAmount+h.TotalVat else h.TotalAmount end) as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno and @accdebit<>''
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalVat as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno and @accdebit='' and h.TotalVat>0
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	h.AccDocNo,h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno and h.TotalVat>0
	union all
	select 
	dbo.GetAccConfig('AP_CONFIG','Cashout') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalNet as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno	and @acccredit=''
	union all
	select 
	@acccredit as AccCode,
	h.AccDocNo,0 as Debit,h.TotalNet as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno	and @acccredit<>''
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno	
	and h.PartyTaxCode like '0%' and h.TotalWht>0
	union all
	select 
	dbo.GetAccConfig('ADV_CONFIG','TaxPerson') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalWht as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@docno	
	and h.PartyTaxCode not like '0%' and h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode


update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid;

update Acc_TransactionHD 
set DocStatus=2
where AccDocNo=@docno and DocStatus<2
end

select * from vJournal_All where EntryId=@eid;

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickBuyAsset]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_QuickBuyAsset]
(
 @productcode varchar(20),
 @curr varchar(20),
 @rate float,
 @qty float,
 @price float,
 @ref varchar(50),
 @docdate date,
 @partycode varchar(20),
 @partytaxcode varchar(20),
 @partyname varchar(50),
 @partyaddr varchar(MAX),
 @userid varchar(20),
 @note varchar(max),
 @vatrate int,
 @whtrate int,
 @vattype int,--1 exc 2 inc
 @doctype varchar(5), --PC
 @acctype int,--0 สด 1 เชื่อ
 @acccode varchar(20), --บัญชีเงินสด/เงินฝาก
 @rcpno varchar(20), --เลขใบเสร็จ/ใบกำกับที่ได้มา 
 @trantype varchar(20),--TR/CQ
 @bankcode varchar(20), --ชื่อธนาคาร(กรณีเงินโอน)
 @bankname varchar(255) --ชื่อสาขา/สมุดบัญชี/เลข Ref (กรณีเงินโอน)
)
as
begin
declare @journalno varchar(20)=dbo.GetNewJournal(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
declare @amount float=@price*@qty*@rate;
declare @vatbuy float=0;
--ถ้าเป็น include vat ให้ถอดยอดก่อนภาษีออกมาพร้อมทั้งหาราคาต่อหน่วย
if (@vatrate>0 AND @vattype=2)
begin 
	set @price=((((@amount*100)/(100+@vatrate))/@qty)/@rate);
	set @amount=@price*@qty*@rate;
end
--คิดภาษีซื้อ
set @vatbuy=((@amount*@vatrate)/100);

--select @price as price,@vatbuy as vat,@amount as amt;

declare @id int=(select isnull(MAX(EntryID),0)+1  from Acc_JournalHD);
--เพิ่มสมุดรายวันก่อน
insert into Acc_JournalHD
(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id,@journalno,@docdate,@docdate,@userid,@note,0,0
--เพิ่มรายการเอกสารต้นทาง
insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
values(@journalno,@docdate,@docdate,@partycode,@partytaxcode,@partyname,@partyaddr,@userid,@doctype,@docdate,@docdate,2,@ref)

declare @transno int=(select isnull(MAX(TransID),0)+1 from Acc_StockTransaction);
--เพิ่มสต๊อกบัญชีทรัพย์สิน
SET IDENTITY_INSERT Acc_StockTransaction ON
insert into Acc_StockTransaction
(TransID,TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select @transno,@ref,'IN',p.ProductCode,@qty,(round(@amount,2)/@qty)/@rate,@curr,@rate,p.AssetAccCode,p.WarehouseCode,@journalno
from vMas_Product p where p.ProductCode=@productcode;

declare @seq int=1;
--เพิ่มรายการ detail
insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select @journalno,1,'',0,@transno,@qty,@price,p.UnitStock,@curr,@rate,round(@amount,2),p.ProductCode,@note,@vatrate,@whtrate,1
from vMas_Product p where p.ProductCode=@productcode;
--ถ้าไม่ได้ระบุว่าจะลงบัญชีด้านเครดิตด้วยรหัสอะไร ให้เช็คว่าเป็นเงินสดหรือเจ้าหนี้
if(@acccode='') 
begin
 SET @acccode =IIF(@acctype=1,dbo.GetAccConfig('AP_CONFIG','Purchase'),dbo.GetAccConfig('AP_CONFIG','CashOut'));
end
--ลงสมุดรายวัน
--Cr. เงินสด/ลูกหนี้
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq,a.AccCode,a.AccName,@ref,0,round(@amount,2)+round(@vatbuy,2)
from vMas_AccCode a
where a.AccCode=@acccode;
--Dr.บัญชีสินทรัพย์
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+1,p.AssetAccCode,p.AssetAccName,@note,round(@amount,2),0
from vMas_Product p where p.ProductCode=@productcode;
--Dr.ภาษีซื้อ(ถ้ามี)
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+2,a.AccCode,a.AccName,@ref,round(@vatbuy,2),0
from vMas_AccCode a
where a.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat') and @vatbuy>0;

insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3,Text4)
select @journalno,0,@rcpno,@trantype,@bankcode,@bankname;

--รวมยอด
update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.JournalNo=@journalno

select JournalNo,AccRemark,AccCode,AccName,AccDesc,Debit,Credit from vJournal_All where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickCashSaleProduct]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE procedure [dbo].[Insert_QuickCashSaleProduct]
(
@userid varchar(20),
@note varchar(50),
@cashbook varchar(50),
@product varchar(50),
@qty float,
@price float,
@curr varchar(20),
@excrate float,
@docdate date,
@costprice float,
@profitrate float
)
as
begin
declare @total float=round(@qty*@price*@excrate,2);
declare @costfix float=round(@qty*@costprice,2);
declare @journalno varchar(20)=dbo.GetNewJournal(concat('RV',FORMAT(@docdate,'yyMM')),'0000');

declare @maxid int=(select isnull(MAX(EntryID),0)+1 from Acc_JournalHD);

insert into Acc_JournalHD (EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
values(@maxid,@journalno,@docdate,@docdate,@userid,@note,0,0)

declare @id int=(select EntryID FROM Acc_JournalHD where JournalNo=@journalno);
declare @seq int=(select isnull(MAX(Seq),0)+1 FROM Acc_JournalDT where EntryID=@id);
--Dr.เงินสด
insert into Acc_JournalDT 
select @id,@seq,a.AccCode,a.AccName,@cashbook,@total,0
from vMas_AccCode a,vMas_Product p
where a.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
and p.ProductCode='DEF'
--Cr.ขาย
insert into Acc_JournalDT 
select @id,@seq+1,p.IncomeAccCode,p.IncomeAccName,p.ProductName,0,round(@total*(100/(100+p.RateVat)),2)
from vMas_Product p,vMas_AccCode a
where p.ProductCode='DEF' and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')
--Cr.ภาษีขาย
insert into Acc_JournalDT 
select @id,@seq+2,a.AccCode,a.AccName,p.ProductName,0,@total-round(@total*(100/(100+p.RateVat)),2)
from vMas_Product p,vMas_AccCode a
where p.ProductCode='DEF' and p.RateVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat')
--ถ้าใส่อัตรากำไร ให้นำอัตรามาหาราคาต้นทุนก่อนคิดกำไร
if (@costfix=0)
begin
	select @costfix=round((round(@total*(100/(100+p.RateVat)),2)*100)/(100+@profitrate),2)
	from vMas_Product p
	where p.ProductCode='DEF'
end

--ถ้าได้ราคาต้นทุนส่งมาด้วย
if (@costfix>0) 
begin
--Cr.ต้นทุนขาย
insert into Acc_JournalDT 
select @id,@seq+3,p.ExpenseAccCode,p.ExpenseAccName,@product,
@costfix
,0
from vMas_Product p
where p.ProductCode='DEF'
--Cr.สินค้าคงเหลือ
insert into Acc_JournalDT 
select @id,@seq+4,p.AssetAccCode,p.AssetAccName,@product,0,
@costfix
from vMas_Product p
where p.ProductCode='DEF'

--Stock Card
set @id=(select isnull(MAX(TransID),0)+1 from Acc_StockTransaction);
--ลงยอดด้วยราคาสินค้าทุน
set IDENTITY_INSERT Acc_StockTransaction ON
insert into Acc_StockTransaction
(TransID,TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select @id,CONCAT('DI-',@journalno),'IN',ProductCode,@qty,
@costfix/@qty
,'THB',1,AssetAccCode,WarehouseCode,@journalno
from vMas_Product p where p.ProductCode='DEF'

insert into Acc_StockTransaction
(TransID,TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select @id+1,CONCAT('DO-',@journalno),'OUT',ProductCode,@qty*-1,
@costfix/@qty
,'THB',1,AssetAccCode,WarehouseCode,@journalno
from vMas_Product p where p.ProductCode='DEF'

--Acc Transaction
--เอกสารใบรับสินค้าเข้าคลังด้วยราคาต้นทุน
declare @docno varchar(20)=dbo.GetNewTransaction(concat('DI',FORMAT(@docdate,'yyMM')),'0000');

insert into Acc_TransactionDT
select @docno,1,'',0,
@id,@qty,
round(@costfix/@qty,2)
,p.UnitStock,
'THB',1,
@costfix
,ProductCode,@product,
RateVat,RateWht,VatType
from vMas_Product p where p.ProductCode='DEF'

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,
PartyCode,PartyTaxCode,
PartyName,PartyAddress,
IssueBy,AccDocType,AccPostDate,
FiscalYear,DocStatus,DocRefNo)
values(@docno,@docdate,@docdate,
'-','-',
@note,'-',
@userid,'DI',@docdate,
@docdate,2,@journalno)
--เอกสารใบสงสินค้า
SET @docno =dbo.GetNewTransaction(concat('DO',FORMAT(@docdate,'yyMM')),'0000');

insert into Acc_TransactionDT
select @docno,1,'',0,
@id+1,@qty,
@price
,p.UnitStock,
@curr,@excrate,
@total
,ProductCode,@product,
RateVat,RateWht,VatType
from vMas_Product p where p.ProductCode='DEF'

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,
PartyCode,PartyTaxCode,
PartyName,PartyAddress,
IssueBy,AccDocType,AccPostDate,
FiscalYear,DocStatus,DocRefNo)
values(@docno,@docdate,@docdate,
'-','-',
@note,'-',
@userid,'DO',@docdate,
@docdate,2,@journalno)

end

--รวม total
update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.JournalNo=@journalno

--RESULT
SELECT JournalNo,EffectiveDate,Description,AccCode,AccName,AccDesc,Debit,Credit
from vJournal_All
where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_QuickJournal]
(
	@doctype varchar(5),
	@docno varchar(20),
	@description nvarchar(max),
	@userid varchar(20),
	@docdate date,
	@effectivedate date,
	@amount decimal(10,2),
	@accdebit varchar(20),
	@debitremark varchar(max),
	@acccredit varchar(20),
	@creditremark varchar(max)
)
as
begin
	if @docno=''
	begin
		declare @fmt varchar(20)=concat(@doctype,FORMAT(@docdate,'yyMM'))
		set @docno=dbo.GetNewJournal(@fmt,'0000')
	end
	if not exists(select 1 from Acc_JournalHD where JournalNo=@docno)
	begin
		insert into Acc_JournalHD 
		select MAX(EntryID)+1 as EntryId,
		@docno,@docdate,@effectivedate,@userid,@description,0,0
		from Acc_JournalHD
	end
	declare @id int=(select isnull(EntryId,0) from Acc_JournalHD where JournalNo=@docno)
	if @id>0
	begin
		declare @seq int=0
		set @seq=(select isnull(max(Seq),0)+1 from Acc_JournalDT where EntryID=@id)

		if @accdebit<>'' 
		begin		
			insert into Acc_JournalDT 
			select @id,@seq,@accdebit,@creditremark,@debitremark,@amount,0
			from vMas_AccCode b 
			where AccCode=@accdebit 
		end				
		set @seq=(select isnull(max(Seq),0)+1 from Acc_JournalDT where EntryID=@id)
		if @acccredit<>'' 
		begin
			insert into Acc_JournalDT 
			select @id,@seq,@acccredit,@debitremark,@creditremark,0,@amount
			from vMas_AccCode b 
			where AccCode=@acccredit 
		end
		EXEC dbo.UpdateTotalDebitCredit
	end	
	select * from vJournal_All where JournalNo=@docno
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickPayment]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_QuickPayment]
(
 @expcode varchar(20),
 @curr varchar(20),
 @rate float,
 @price float,
 @ref varchar(50),
 @docdate date,
 @partycode varchar(20),
 @partytaxcode varchar(20),
 @partyname varchar(50),
 @partyaddr varchar(MAX),
 @userid varchar(20),
 @note varchar(max),
 @vatrate int,
 @whtrate int,
 @vattype int,--1-exclude 2=include
 @doctype varchar(5),--PC
 @acctype int,--1=เชื่อ 0=สด
 @acccode varchar(20),
 @rcpno varchar(20),
 @trantype varchar(20),--TRF/CASH/CHQ/CRCARD/DRCARD
 @bankacc varchar(20),
 @bankname varchar(255)
)
as
begin
declare @journalno varchar(20)=dbo.GetNewJournal(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
declare @amount float=@price*@rate;
declare @vatbuy float=0;
declare @whtamt float=0;
--ถ้าเป็น include vat ให้ถอดยอดก่อนภาษีออกมาพร้อมทั้งหาราคาต่อหน่วย
if (@vatrate>0 AND @vattype=2)
begin 
	set @price=(((@amount*100)/(100+@vatrate))/@rate);
	set @amount=@price*@rate;
end
--คิดภาษีซื้อ
set @vatbuy=((@amount*@vatrate)/100);
if (@acctype=0)
begin
 set @whtamt=((@amount*@whtrate)/100);
end
--select @price as price,@vatbuy as vat,@amount as amt;

declare @id int=(select isnull(MAX(EntryID),0)+1  from Acc_JournalHD);
--เพิ่มสมุดรายวันก่อน
insert into Acc_JournalHD
(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id,@journalno,@docdate,@docdate,@userid,@note,0,0
--เพิ่มรายการเอกสารต้นทาง
insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
values(@journalno,@docdate,@docdate,@partycode,@partytaxcode,@partyname,@partyaddr,@userid,@doctype,@docdate,@docdate,2,@ref)

declare @seq int=1;
--เพิ่มรายการ detail
insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select @journalno,1,'',0,0,1,@price,'SET',@curr,@rate,round(@amount,2),'',@note,@vatrate,@whtrate,1;
--ถ้าไม่ได้ระบุว่าจะลงบัญชีด้านเครดิตด้วยรหัสอะไร ให้เช็คว่าเป็นเงินสดหรือเจ้าหนี้
if(@acccode='') 
begin
 SET @acccode =IIF(@acctype=1,dbo.GetAccConfig('AP_CONFIG','Purchase'),dbo.GetAccConfig('AP_CONFIG','CashOut'));
end
if(@expcode='') 
begin
 SET @expcode =dbo.GetAccConfig('GL_CONFIG','MiscPayment');
end
--ลงสมุดรายวัน
--Cr. เงินสด/ลูกหนี้
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq,a.AccCode,a.AccName,@ref,0,
(case when @acctype=1 then round(@amount,2)+round(@vatbuy,2) else round(@amount,2)+round(@vatbuy,2)-round(@whtamt,2) end)
from vMas_AccCode a
where a.AccCode=@acccode;
if (@acctype=0 AND @whtamt>0)
begin
   SET @seq=@seq+1;
	--Cr. หัก ณ ที่จ่าย
	Insert into Acc_JournalDT
	(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,@seq,a.AccCode,a.AccName,@ref,0,
	round(@whtamt,2)
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG',(case when SUBSTRING(@partytaxcode,1,1)='0' then 'TaxCompany' else 'TaxPerson' end));
end
--Dr.บัญชีค่าใช้จ่าย
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+1,a.AccCode,a.AccName,@note,round(@amount,2),0
from vMas_AccCode a where a.AccCode=@expcode;
--Dr.ภาษีซื้อ(ถ้ามี)
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+2,a.AccCode,a.AccName,@ref,round(@vatbuy,2),0
from vMas_AccCode a
where a.AccCode=dbo.GetAccConfig('VAT_CONFIG',(case when @acctype=1 then 'UndueInputVat' else 'InputVat' end)) and @vatbuy>0;

Insert into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3,Text4)
values(@journalno,0,@rcpno,@trantype,@bankacc,@bankname)

--รวมยอด
update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.JournalNo=@journalno

select JournalNo,AccRemark,AccCode,AccName,AccDesc,Debit,Credit from vJournal_All where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickReceive]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










CREATE procedure [dbo].[Insert_QuickReceive]
(
 @inccode varchar(20),
 @curr varchar(20),
 @rate float,
 @price float,
 @ref varchar(50),
 @docdate date,
 @partycode varchar(20),
 @partytaxcode varchar(20),
 @partyname varchar(50),
 @partyaddr varchar(MAX),
 @userid varchar(20),
 @note varchar(max),
 @vatrate int,
 @whtrate int,
 @vattype int,
 @doctype varchar(5),
 @acctype int,--0=เงินสด 1=เงินเชื่อ
 @acccode varchar(20),
 @rcpno varchar(20),
 @trantype varchar(20),
 @bankcode varchar(20),
 @bankname varchar(255)
)
as
begin
declare @journalno varchar(20)=dbo.GetNewJournal(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
declare @amount float=@price*@rate;
declare @vatsale float=0;
declare @whtamt float=0;
--ถ้าเป็น include vat ให้ถอดยอดก่อนภาษีออกมาพร้อมทั้งหาราคาต่อหน่วย
if (@vatrate>0 AND @vattype=2)
begin 
	set @price=(((@amount*100)/(100+@vatrate))/@rate);
	set @amount=@price*@rate;
end
--คิดภาษีขาย
set @vatsale=((@amount*@vatrate)/100);
set @whtamt=((@amount*@whtrate)/100);

--select @price as price,@vatbuy as vat,@amount as amt;

declare @id int=(select isnull(MAX(EntryID),0)+1  from Acc_JournalHD);
--เพิ่มสมุดรายวันก่อน
insert into Acc_JournalHD
(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id,@journalno,@docdate,@docdate,@userid,@note,0,0
--เพิ่มรายการเอกสารต้นทาง
insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
values(@journalno,@docdate,@docdate,@partycode,@partytaxcode,@partyname,@partyaddr,@userid,@doctype,@docdate,@docdate,2,@ref)

declare @seq int=1;
--เพิ่มรายการ detail
insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select @journalno,1,'',0,0,1,@price,'SET',@curr,@rate,round(@amount,2),'DEF',@note,@vatrate,@whtrate,1;
--ถ้าไม่ได้ระบุว่าจะลงบัญชีด้านเครดิตด้วยรหัสอะไร ให้เช็คว่าเป็นเงินสดหรือเจ้าหนี้
if(@acccode='') 
begin
 SET @acccode =IIF(@acctype=1,dbo.GetAccConfig('AR_CONFIG','Sales'),dbo.GetAccConfig('AR_CONFIG','CashIn'));
end
if(@inccode='') 
begin
 SET @inccode =dbo.GetAccConfig('GL_CONFIG','MiscReceive');
end
--ลงสมุดรายวัน
--Dr. เงินสด/ลูกหนี้
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq,a.AccCode,a.AccName,@ref,
(CASE WHEN @acctype=1 then round(@amount,2)+round(@vatsale,2) else round(@amount,2)+round(@vatsale,2)-round(@whtamt,2) end)
,0
from vMas_AccCode a
where a.AccCode=@acccode;

--Cr.บัญชีรายได้
SET @seq=@seq+1;
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq,a.AccCode,a.AccName,@note,0,round(@amount,2)
from vMas_AccCode a where a.AccCode=@inccode;
--Cr.ภาษีขาย(ถ้ามี)
if @vatsale>0 
begin
	SET @seq=@seq+1;

	Insert into Acc_JournalDT
	(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,@seq,a.AccCode,a.AccName,@ref,0,round(@vatsale,2)
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('VAT_CONFIG',(case when @acctype=1 then 'UndueOutputVat' else 'OutputVat' end)) and @vatsale>0;
end
--Dr. ภาษีถูกหัก ณ ที่จ่าย(ถ้ามี)
if (@whtamt>0 AND @acctype=0)
begin
	SET @seq=@seq+1;

	Insert into Acc_JournalDT
	(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,@seq,a.AccCode,a.AccName,@ref,round(@whtamt,2),0
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax') and @whtamt>0;
end

Insert Into Acc_AdditionData
(DocNo,Seq,Text1,Text2,Text3,Text4)
select @journalno,0,@rcpno,@trantype,@bankcode,@bankname;

--รวมยอด
update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.JournalNo=@journalno

select JournalNo,AccRemark,AccCode,AccName,AccDesc,Debit,Credit from vJournal_All where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_QuickSellProduct]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_QuickSellProduct]
(
 @productcode varchar(20),
 @curr varchar(20),
 @rate float,
 @qty float,
 @price float,
 @ref varchar(50),
 @docdate date,
 @partycode varchar(20),
 @partytaxcode varchar(20),
 @partyname varchar(50),
 @partyaddr varchar(MAX),
 @userid varchar(20),
 @note varchar(max),
 @vatrate int,
 @whtrate int,
 @vattype int,
 @doctype varchar(5),
 @acctype int,
 @acccode varchar(20),
 @lotnumber int,
 @rcpno varchar(20),
 @transtype varchar(20),
 @bankcode varchar(20),
 @bankname varchar(255)
)
as
begin
declare @journalno varchar(20)=dbo.GetNewJournal(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
declare @amount float=@price*@qty*@rate;
declare @vatsale float=0;
--ถ้าเป็น include vat ให้ถอดยอดก่อนภาษีออกมาพร้อมทั้งหาราคาต่อหน่วย
if (@vatrate>0 AND @vattype=2)
begin 
	set @price=((((@amount*100)/(100+@vatrate))/@qty)/@rate);
	set @amount=@price*@qty*@rate;
end
--คิดภาษีขาย
set @vatsale=((@amount*@vatrate)/100);

declare @id int=(select isnull(MAX(EntryID),0)+1  from Acc_JournalHD);
--เพิ่มสมุดรายวันก่อน
insert into Acc_JournalHD
(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id,@journalno,@docdate,@docdate,@userid,@note,0,0
--เพิ่มรายการเอกสารต้นทาง
insert into Acc_TransactionHD 
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
values(@journalno,@docdate,@docdate,@partycode,@partytaxcode,@partyname,@partyaddr,@userid,@doctype,@docdate,@docdate,2,@ref)

declare @transno int=0;
if @lotnumber>0 
begin
set @transno=(select isnull(MAX(TransID),0)+1 from Acc_StockTransaction)
--ลดสต๊อกบัญชีทรัพย์สิน
SET IDENTITY_INSERT Acc_StockTransaction ON
insert into Acc_StockTransaction
(TransID,TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select @transno,@ref,'OUT',p.ProductCode,@qty*-1,s.TransPrice,s.TransCurrency,s.TransRate,p.AssetAccCode,p.WarehouseCode,@journalno
from vMas_Product p inner join Acc_StockTransaction s on 
p.ProductCode=s.StockProductCode
where p.ProductCode=@productcode and s.TransID=@lotnumber;
end
declare @seq int=1;
--เพิ่มรายการ detail
insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select @journalno,1,d.AccDocNo,d.AccItemNo,@transno,@qty,@price,p.UnitStock,@curr,@rate,round(@amount,2),p.ProductCode,@note,@vatrate,@whtrate,1
from vMas_Product p inner join 
Acc_TransactionDT d on p.ProductCode=d.SaleProductCode
where p.ProductCode=@productcode and d.StockTransNo=@lotnumber;
--ถ้าไม่ได้ระบุว่าจะลงบัญชีด้านเครดิตด้วยรหัสอะไร ให้เช็คว่าเป็นเงินสดหรือเจ้าหนี้
if(@acccode='') 
begin
 SET @acccode =IIF(@acctype=1,dbo.GetAccConfig('AR_CONFIG','Sales'),dbo.GetAccConfig('AR_CONFIG','CashIn'));
end
--ลงสมุดรายวัน
--Dr. เงินสด/ลูกหนี้
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq,a.AccCode,a.AccName,@ref,round(@amount,2)+round(@vatsale,2),0
from vMas_AccCode a
where a.AccCode=@acccode;
--Cr.บัญชีสินทรัพย์
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+1,p.IncomeAccCode,p.IncomeAccName,@note,0,round(@amount,2)
from vMas_Product p where p.ProductCode=@productcode;
--Cr.ภาษีขาย(ถ้ามี)
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+2,a.AccCode,a.AccName,@ref,0,round(@vatsale,2)
from vMas_AccCode a
where a.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat') and @vatsale>0;
--Cr.สินค้าที่ขาย
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+3,a.AccCode,a.AccName,d.AccDocNo,0,round(d.Price*@qty,2)
from vMas_AccCode a,Acc_TransactionDT d 
inner join vMas_Product p on d.SaleProductCode=p.ProductCode 
where d.StockTransNo=@lotnumber and a.AccCode=p.AssetAccCode
--Dr.ต้นทุนสินค้าที่ขาย
Insert into Acc_JournalDT
(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id,@seq+4,a.AccCode,a.AccName,d.AccDocNo,round(d.Price*@qty,2),0
from vMas_AccCode a,Acc_TransactionDT d 
inner join vMas_Product p on d.SaleProductCode=p.ProductCode 
where d.StockTransNo=@lotnumber and a.AccCode=dbo.GetAccConfig('GL_CONFIG','DefaultCost')

Insert into Acc_AdditionData
(DocNo,Text1,Text2,Text3,Text4)
select @journalno,@rcpno,@transtype,@bankcode,@bankname;

--รวมยอด
update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.JournalNo=@journalno

select JournalNo,AccRemark,AccCode,AccName,AccDesc,Debit,Credit from vJournal_All where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_RCFromSI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE procedure [dbo].[Insert_RCFromSI]
(
@userid varchar(20),
@docno varchar(20),
@transtype varchar(3),
@bankacc varchar(50),
@bankname varchar(50),
@rcpno varchar(50),
@docdate date,
@duedate date,
@sino varchar(20),
@itemno int=0,
@transno varchar(20)='',
@qty float=0
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','RC')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @header varchar(20);
set @header=CONCAT('RC',FORMAT(@docdate,'yyMM'));

declare @running varchar(20);
--set @running =dbo.GetNewTransaction(@header,'0000');
set @running=dbo.GetNewRunning('RC','T',@docdate);
if @docno<>'' 
begin
 set @running=@docno;
end


insert into Acc_TransactionHD
select 
@running as AccDocNo,
@docdate as AccBatchDate,
@duedate as AccEffectiveDate,
PartyCode,
PartyTaxCode,
PartyName,
PartyAddress,
@userid as IssueBy,
'RC' as AccDocType,
'1900-01-01' as AccPostDate,
@docdate as FiscalYear,
0 as DocStatus,
@rcpno
from vAR_H where AccDocNo=@sino
and not exists(select AccDocNo from Acc_TransactionHD where AccDocNo=@running)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@running);
if @ino is null
begin
 set @ino=0;
end


if @itemno=0
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
	case when AccSourceDocItem<>'' then AccSourceDocItem else AccItemNo end,
	0 as StockTransNo,
	Qty,
	(TotalAmount/ExchangeRate)/Qty,
	UnitMea,
	Currency,
	ExchangeRate,
	TotalAmount,
	SaleProductCode,
	SalesDescription,RateVat,RateWht,1
	from vAR_D a where AccDocNo=@sino
	and not exists(select 1 from vTransaction_D where AccDocNo=@running)	
	and not exists(select 1 from vRC_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end)
	and AccSourceDocItem=(case when a.AccSourceDocItem<>'' then a.AccSourceDocItem else a.AccItemNo end))
end
else
begin
	if @qty=0 
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
		case when AccSourceDocItem<>'' then AccSourceDocItem else AccItemNo end,
		0 as StockTransNo,
		Qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		TotalAmount,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vAR_D a where AccDocNo=@sino and AccItemNo=@itemno
		and not exists(select 1 from vRC_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end)
		and AccSourceDocItem=(case when a.AccSourceDocItem<>'' then a.AccSourceDocItem else a.AccItemNo end))
	end
	else
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		case when AccSourceDocNo<>'' then AccSourceDocNo else AccDocNo end,
		case when AccSourceDocItem<>'' then AccSourceDocItem else AccItemNo end,
		0 as StockTransNo,
		@qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		(TotalAmount/Qty)*@qty,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vAR_D a where AccDocNo=@sino and AccItemNo=@itemno
		and not exists(select 1 from vRC_D where AccSourceDocNo=(case when a.AccSourceDocNo<>'' then a.AccSourceDocNo else a.AccDocNo end)
		and AccSourceDocItem=(case when a.AccSourceDocItem<>'' then a.AccSourceDocItem else a.AccItemNo end))
	end
end

delete a from Acc_TransactionHD a where not exists(select 1 from Acc_TransactionDT where AccDocNo=a.AccDocNo)	

insert into Acc_AdditionData(DocNo,Seq,Text1,Text2,Text3,Text4)
select @running,0,@transno,@transtype,@bankacc,@bankname
where not exists(select 1 from Acc_AdditionData where DocNo=@running and seq=0)
and exists(select 1 from Acc_TransactionHD where AccdocNo=@running)

select AccDocNo as RCNo,AccBatchDate as RCDate,AccEffectiveDate as DueDate, 
PartyCode as CustCode,PartyName as CustName,TotalAmount,TotalVat,TotalWht,TotalNet
from vTransaction_H
where AccDocNo=@running;
end 


GO
/****** Object:  StoredProcedure [dbo].[Insert_RCFromSO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_RCFromSO]
(
@userid varchar(20),
@docno varchar(20),
@transtype varchar(3),
@bankacc varchar(50),
@bankname varchar(50),
@rcpno varchar(50),
@docdate date,
@duedate date,
@sono varchar(20),
@itemno int=0,
@transno varchar(20)='',
@qty float=0
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','RC')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @header varchar(20);
set @header=CONCAT('RC',FORMAT(@docdate,'yyMM'));

declare @running varchar(20);
--set @running =dbo.GetNewTransaction(@header,'0000');
set @running=dbo.GetNewRunning('RC','T',@docdate);
if @docno<>'' 
begin
 set @running=@docno;
end


insert into Acc_TransactionHD
select distinct
@running as AccDocNo,
@docdate as AccBatchDate,
@duedate as AccEffectiveDate,
PartyCode,
PartyTaxCode,
PartyName,
PartyAddress,
@userid as IssueBy,
'RC' as AccDocType,
'1900-01-01' as AccPostDate,
@docdate as FiscalYear,
0 as DocStatus,
@rcpno
from vSO_D where AccDocNo=@sono
and not exists(select AccDocNo from Acc_TransactionHD where AccDocNo=@running)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@running);
if @ino is null
begin
 set @ino=0;
end


if @itemno=0
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	AccDocNo as AccSourceDocNo,
	AccItemNo as AccSourceDocItem,
	0 as StockTransNo,
	Qty,
	(TotalAmount/ExchangeRate)/Qty,
	UnitMea,
	Currency,
	ExchangeRate,
	TotalAmount,
	SaleProductCode,
	SalesDescription,RateVat,RateWht,1
	from vSO_D a where AccDocNo=@sono
	and not exists(select 1 from vTransaction_D where AccDocNo=@running)
end
else
begin
	if @qty=0 
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		AccDocNo as AccSourceDocNo,
		AccItemNo as AccSourceDocItem,
		0 as StockTransNo,
		Qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		TotalAmount,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vSO_D where AccDocNo=@sono and AccItemNo=@itemno;
	end
	else
	begin
		insert into Acc_TransactionDT
		select 
		@running as AccDocNo,
		(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
		AccDocNo as AccSourceDocNo,
		AccItemNo as AccSourceDocItem,
		0 as StockTransNo,
		@qty,
		(TotalAmount/ExchangeRate)/Qty,
		UnitMea,
		Currency,
		ExchangeRate,
		(TotalAmount/Qty)*@qty,
		SaleProductCode,
		SalesDescription,RateVat,RateWht,1
		from vSO_D where AccDocNo=@sono and AccItemNo=@itemno;
	end
end

insert into Acc_AdditionData(DocNo,Seq,Text1,Text2,Text3,Text4)
select @running,0,@transno,@transtype,@bankacc,@bankname
where not exists(select 1 from Acc_AdditionData where DocNo=@running and seq=0);

select AccDocNo as RCNo,AccBatchDate as RCDate,AccEffectiveDate as DueDate, 
PartyCode as CustCode,PartyName as CustName,TotalAmount,TotalVat,TotalWht,TotalNet
from vTransaction_H
where AccDocNo=@running;
end 


GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_ReceiptFromJob]
(
	@datefrom date,
	@dateto date,
	@custcode varchar(20)=''
)
as
begin
delete a from Acc_TransactionHD a
inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.AccDocNo=b.ReceiptNo
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
and b.BillToCustCode like @custcode+'%'; 

delete a from Acc_TransactionDT a 
inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.AccDocNo=b.ReceiptNo
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
and b.BillToCustCode like @custcode+'%'; 

insert into Acc_TransactionDT
(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,
Qty,Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
select 
d.ReceiptNo,d.ItemNo,d.InvoiceNo as SourceDocNo,d.InvoiceItemNo as SourceDocItem,0 as StockNo,
1,
(case when d.SICode not like 'ADV%' then s.Amt else s.Amt+s.AmtVat end) 
,'SET','THB',1,
(case when d.SICode not like 'ADV%' then s.Amt else s.Amt+s.AmtVat end) 
,d.SICode,i.RefNo,
(case when d.SICode not like 'ADV%' then d.VatRate else 0 end),
(case when d.SICode not like 'ADV%' then d.Rate50Tavi else 0 end)
,1
from [job_3x].dbo.Job_ReceiptDetail d
inner join [job_3x].dbo.Job_ReceiptHeader h
on d.BranchCode=h.BranchCode 
and d.ReceiptNo=h.ReceiptNo
inner join [job_3x].dbo.Job_InvoiceHeader i 
on d.BranchCode=i.BranchCode and d.InvoiceNo=i.DocNo
inner join [job_3x].dbo.Job_InvoiceDetail s on d.InvoiceNo=s.DocNo and d.InvoiceItemNo=s.ItemNo
where isnull(h.CancelProve,'')=''
and h.ReceiptDate>=@datefrom and h.ReceiptDate<=@dateto
and h.BillToCustCode like @custcode+'%'; 

insert into Acc_TransactionHD
(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress,
IssueBy,AccDocType,AccPostDate,FiscalYear,DocStatus,DocRefNo)
select h.ReceiptNo,h.ReceiptDate,h.ReceiptDate,h.BillToCustCode,concat(c.TaxNumber,'/',c.Branch),c.NameThai,c.TAddress,
h.EmpCode,'RC',h.ReceiptDate,h.ReceiptDate,1,h.TRemark
from
[job_3x].dbo.Job_ReceiptHeader h 
left join [job_3x].dbo.Mas_Company c on h.BillToCustCode=c.CustCode and h.BillToCustBranch=c.Branch
where isnull(h.CancelProve,'')='' 
and h.ReceiptDate>=@datefrom and h.ReceiptDate<=@dateto
and h.BillToCustCode like @custcode+'%'; 
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










CREATE procedure [dbo].[Insert_ReceiptFromJob_V2]
(
	@datefrom date,
	@dateto date
)
as
begin
select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,c.PRVoucher as VoucherNo,
	isnull(h.VoucherDate,isnull(i.DueDate,i.DocDate)) as VoucherDate,
	a.Amt,a.AmtVAT,a.Amt50Tavi,a.Amt+a.AmtVAT as AmtTotal,
	a1.AccCode as AccCodeD,a2.AccCode as AccCodeC,a.InvoiceNo,
	a3.AccCode as AccCodeAR,a4.AccCode as AccCodeJV,f.NameThai as CustName,b.EmpCode ,d.SDescription
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	left join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i 
	on d.DocNo=i.DocNo 
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join dbo.Mas_AccCode a1 
	on e.GLAccountCodeCost=a1.AccCode
	left join dbo.Mas_AccCode a2
	on e.GLAccountCodeSales=a2.AccCode
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join dbo.Mas_AccCode a3
	on f.GLAccountCode=a3.AccCode
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	left join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and d.AmtCharge>0
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RC-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('RC-',a.DocNo) as DocNo,a.DocDate,a.DocDate,a.EmpCode,a.CustName,0,0
from #tmp1 a 
group by a.DocNo,a.DocDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	sum(Amt) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
	/*
	union all
	select DocNo,AccCodeAR as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,AmtTotal as Credit
	from #tmp1 where AccCodeAR is not null
	union all
	select DocNo,p.AccCode as AccCode,CustName,RefNo as SubAccName,
	Amt50Tavi as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where AccCodeAR is not null and Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	union all
	select DocNo,AccCodeJV as AccCode,CustName,RefNo as SubAccName,
	AmtTotal-Amt50Tavi as Debit,0 as Credit
	from #tmp1 where AccCodeJV is not null 
	*/
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RC-',DocNo)=h.JournalNo)

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_ReceiptToJournal]
(
@datefrom date,
@dateto date,
@userid varchar(20)
)
as
begin
declare @maxid int=(select isnull(max(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalDT
select 
@maxid+DENSE_RANK() OVER(ORDER BY ReceiptNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ReceiptNo ORDER BY ReceiptNo) as Seq,
AccCode,AccName,AccDesc,Debit,Credit
from (
    ---Dr.เงินรับ ทั้งหมด
	select r.ReceiptNo,
	a.AccCode,a.AccName,r.DocNo as AccDesc,
	sum(case when r.AmtAdvance>0 then r.ReceiptNet+r.ReceiptWht else r.ReceiptNet end) as Debit,0 as Credit
	from vRV_LinkJob r,
	vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
	and r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
	group by r.ReceiptNo,a.AccCode,a.AccName,r.DocNo
	union all
	--Cr.ลูกหนี้ ADV
	select r.ReceiptNo,
	p.AssetAccCode,p.AssetAccName,p.ProductName,0,r.ReceiptNet
	from vRV_LinkJob r
	inner join vMas_Product p
	on r.SICode=p.ProductCode 
	where r.IsFromAdv=1 and r.AmtAdvance>0
	and r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
	union all
	--Cr.ลูกหนี้ Charge
	select r.ReceiptNo,
	p.AssetAccCode,p.AssetAccName,p.ProductName,0,r.ReceiptNet+r.ReceiptWht
	from vRV_LinkJob r
	inner join vMas_Product p
	on r.SICode=p.ProductCode 
	where r.AmtCharge>0
	and r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
	union all
	--Cr. เจ้าหนี้ (ตั้งเพิ่ม กรณี ไม่มีใบเปย์)
	select r.ReceiptNo,
	a.AccCode,a.AccName,p.ProductName,0,r.ReceiptNet
	from vRV_LinkJob r
	inner join vMas_Product p
	on r.SICode=p.ProductCode, 
	vMas_AccCode a
	where r.IsFromAdv=0 and a.AccCode=dbo.GetAccConfig('AP_CONFIG','Purchase')
	and r.AmtAdvance>0
	and r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
	union all
	--Cr.หัก ณ ที่จ่าย
	select r.ReceiptNo,
	a.AccCode,a.AccName,'ถูกหัก ณ ที่จ่าย' as AccDesc,sum(r.ReceiptWht) as Debit,0 as Credit
	from vRV_LinkJob r,
	vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('WHT_CONFIG','OutputTax')
	and r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
	and r.Amtcharge>0
	group by r.ReceiptNo,a.AccCode,a.AccName,r.DocNo
	--Cr.หัก ณ ที่จ่าย customer
	union all
	select r.ReceiptNo,
	a.AccCode,a.AccName,'หัก ณ ที่จ่าย' as AccDesc,0 as Debit,sum(r.ReceiptWht) as Credit
	from vRV_LinkJob r,
	vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCustomer')
	and r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
	and r.AmtAdvance>0
	group by r.ReceiptNo,a.AccCode,a.AccName,r.DocNo	
) t
where t.ReceiptNo not in(select JournalNo from Acc_JournalHD)

insert into Acc_JournalHD
select @maxid+ROW_NUMBER() OVER(ORDER BY r.ReceiptNo) as EntryID,
r.ReceiptNo,r.ReceiptDate,r.ReceiptDAte,@userid,concat(r.CustTaxID,' / ',r.custName),sum(r.ReceiptNet+r.ReceiptWht),sum(r.ReceiptNet+r.ReceiptWht)
from vRV_LinkJob r
inner join vMas_Product p
on r.SICode=p.ProductCode 
where r.ReceiptDAte>=@datefrom and r.ReceiptDAte<=@dateto
and r.ReceiptNo not in(select JournalNo from Acc_JournalHD)
group by r.ReceiptNo,r.ReceiptDAte,r.CustTaxID,r.custName

end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_ReceiptToJournal_MNL]
(
	@datefrom date,
	@dateto date
)
as
begin
delete c from Acc_JournalDT c
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.JournalNo=concat('RC-',b.ReceiptNo)
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.JournalNo=concat('RC-',b.ReceiptNo)
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto

select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,c.PRVoucher as VoucherNo,
	isnull(h.VoucherDate,isnull(i.DueDate,i.DocDate)) as VoucherDate,
	a.Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVat,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi, 
	a.Amt+a.AmtVAT as AmtTotal,
	(case when d.AmtAdvance>0 then 
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) else 
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) end) as AccCodeC,
	isnull(ad.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueIncome')) as AccCodeD,a.InvoiceNo,
	f.NameThai as CustName,b.EmpCode ,d.SDescription
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	left join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i 
	on d.DocNo=i.DocNo 
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',f.NameThai)=ab.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ac 
	on concat(ac.AccMainName,'-',f.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueIncome')+'-____') ad 
	on concat(ad.AccMainName,'-',f.NameThai)=ad.AccName	
	left join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RC-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('RC-',a.DocNo) as DocNo,a.DocDate,a.DocDate,a.EmpCode,a.CustName,0,0
from #tmp1 a 
group by a.DocNo,a.DocDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,CustName,DocNo as SubAccName,
	sum(AmtTotal-Amt50Tavi) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,CustName
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,DocNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName
	union all
	select DocNo,AccCodeC as AccCode,InvoiceNo,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1
	group by DocNo,AccCodeC,InvoiceNo,RefNo
	union all
	select DocNo,p.AccCode as AccCode,CustName,DocNo as SubAccName,
	sum(Amt50Tavi) as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	group by DocNo,p.AccCode,CustName
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RC-',DocNo)=h.JournalNo)

drop table #tmp1
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE procedure [dbo].[Insert_ReceiptToJournal_V2]
(
	@datefrom date,
	@dateto date
)
as
begin
select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,c.PRVoucher as VoucherNo,
	isnull(h.VoucherDate,isnull(i.DueDate,i.DocDate)) as VoucherDate,
	a.Amt,a.AmtVAT,a.Amt50Tavi,a.Amt+a.AmtVAT as AmtTotal,
	a1.AccCode as AccCodeD,a2.AccCode as AccCodeC,a.InvoiceNo,
	a3.AccCode as AccCodeAR,a4.AccCode as AccCodeJV,f.NameThai as CustName,b.EmpCode ,d.SDescription
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	left join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i 
	on d.DocNo=i.DocNo 
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join dbo.Mas_AccCode a1 
	on e.GLAccountCodeCost=a1.AccCode
	left join dbo.Mas_AccCode a2
	on e.GLAccountCodeSales=a2.AccCode
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join dbo.Mas_AccCode a3
	on f.GLAccountCode=a3.AccCode
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	left join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and d.AmtCharge>0
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RC-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('RC-',a.DocNo) as DocNo,a.DocDate,a.DocDate,a.EmpCode,a.CustName,0,0
from #tmp1 a 
group by a.DocNo,a.DocDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	sum(Amt) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
	/*
	union all
	select DocNo,AccCodeAR as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,AmtTotal as Credit
	from #tmp1 where AccCodeAR is not null
	union all
	select DocNo,p.AccCode as AccCode,CustName,RefNo as SubAccName,
	Amt50Tavi as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where AccCodeAR is not null and Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	union all
	select DocNo,AccCodeJV as AccCode,CustName,RefNo as SubAccName,
	AmtTotal-Amt50Tavi as Debit,0 as Credit
	from #tmp1 where AccCodeJV is not null 
	*/
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RC-',DocNo)=h.JournalNo)

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
















CREATE procedure [dbo].[Insert_ReceiptToJournal_V3]
(
	@datefrom date,
	@dateto date
)
as
begin
delete c from Acc_JournalDT c
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.JournalNo=concat('RC-',b.ReceiptNo)
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.JournalNo=concat('RC-',b.ReceiptNo)
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto

select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,c.PRVoucher as VoucherNo,
	isnull(h.VoucherDate,isnull(i.DueDate,i.DocDate)) as VoucherDate,
	a.Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVat,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi, 
	a.Amt+a.AmtVAT as AmtTotal,
	(case when d.AmtAdvance>0 then dbo.GetAccConfig('AR_CONFIG','Advance') else dbo.GetAccConfig('AR_CONFIG','Sales') end) as AccCodeD,
	dbo.GetAccConfig('GL_CONFIG','AccrueIncome') as AccCodeC,a.InvoiceNo,
	f.NameThai as CustName,b.EmpCode ,d.SDescription
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	left join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i 
	on d.DocNo=i.DocNo 
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RC-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('RC-',a.DocNo) as DocNo,a.DocDate,a.DocDate,a.EmpCode,a.CustName,0,0
from #tmp1 a 
group by a.DocNo,a.DocDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	sum(AmtTotal-Amt50Tavi) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
	union all
	select DocNo,p.AccCode as AccCode,CustName,RefNo as SubAccName,
	sum(Amt50Tavi) as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	group by DocNo,p.AccCode,CustName,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RC-',DocNo)=h.JournalNo)

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_ReceiptToJournal_V4]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_ReceiptToJournal_V4]
(
	@datefrom date,
	@dateto date
)
as
begin
delete c from Acc_JournalDT c
where exists(select 1 from Acc_JournalHD a inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.JournalNo=concat('RC-',b.ReceiptNo)
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
and a.EntryId=c.EntryId)

delete a from Acc_JournalHD a inner join [job_3x].dbo.Job_ReceiptHeader b 
on a.JournalNo=concat('RC-',b.ReceiptNo)
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto

select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,c.PRVoucher as VoucherNo,
	isnull(h.VoucherDate,isnull(i.DueDate,i.DocDate)) as VoucherDate,
	a.Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVat,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi, 
	a.Amt+a.AmtVAT as AmtTotal,
	(case when d.AmtAdvance>0 then 
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) else 
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) end) as AccCodeC,
	isnull(ad.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueIncome')) as AccCodeD,a.InvoiceNo,
	f.NameThai as CustName,b.EmpCode ,d.SDescription
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	left join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i 
	on d.DocNo=i.DocNo 
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',f.NameThai)=ab.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ac 
	on concat(ac.AccMainName,'-',f.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueIncome')+'-____') ad 
	on concat(ad.AccMainName,'-',f.NameThai)=ad.AccName	
	left join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
) tb

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RC-',DocNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.DocNo,a.CustName),
concat('RC-',a.DocNo) as DocNo,a.DocDate,a.DocDate,a.EmpCode,a.CustName,0,0
from #tmp1 a 
group by a.DocNo,a.DocDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select DocNo,AccCodeD as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	sum(AmtTotal-Amt50Tavi) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
	union all
	select DocNo,p.AccCode as AccCode,CustName,RefNo as SubAccName,
	sum(Amt50Tavi) as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	group by DocNo,p.AccCode,CustName,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RC-',DocNo)=h.JournalNo)

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_RefundFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[Insert_RefundFromJob]
(
@datefrom date,
@dateto date,
@userid nvarchar(20)
)
AS
BEGIN
declare @maxid int=(select ISNULL(MAX(EntryID),0) from Acc_JournalHD);

insert into Acc_JournalDT
select 
@maxid+DENSE_RANK() OVER(ORDER BY ClrNo) as EntryID,
ROW_NUMBER() OVER(PARTITION BY ClrNo ORDER BY ClrNo) as Seq,
AccCode,AccName,AccDesc,Dr,Cr
from (
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription as AccDesc,sum(d.UsedAmount+d.ChargeVAT) as Dr,0 as Cr 
from [job_3x].dbo.Job_ClearDetail d 
inner join [job_3x].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo 
inner join dbo.vMas_Product p 
on d.SICode=p.ProductCode,
dbo.vMas_AccCode a
where h.DocStatus<>99 and d.BNet=0 
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
union all
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription,0 as Dr,sum(d.UsedAmount+d.ChargeVAT) as Cr 
from [job_3x].dbo.Job_ClearDetail d 
inner join [job_3x].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo 
inner join dbo.vMas_Product p 
on d.SICode=p.ProductCode,
dbo.vMas_AccCode a
where h.DocStatus<>99 and d.BNet=0 
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
) t
where ClrDate>=@datefrom and ClrDate<=@dateto

insert into Acc_JournalHD
select @maxid+ROW_NUMBER() OVER(ORDER BY ClrNo) as EntryID,
ClrNo,ClrDate,ClrDate,@userid,'-',sum(Dr),sum(Cr)
from (
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription as AccDesc,sum(d.UsedAmount+d.ChargeVAT) as Dr,0 as Cr 
from [job_3x].dbo.Job_ClearDetail d 
inner join [job_3x].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo 
inner join dbo.vMas_Product p 
on d.SICode=p.ProductCode,
dbo.vMas_AccCode a
where h.DocStatus<>99 and d.BNet=0 
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashOut')
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
union all
select h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription,0 as Dr,sum(d.UsedAmount+d.ChargeVAT) as Cr 
from [job_3x].dbo.Job_ClearDetail d 
inner join [job_3x].dbo.Job_ClearHeader h on d.ClrNo=h.ClrNo 
inner join dbo.vMas_Product p 
on d.SICode=p.ProductCode,
dbo.vMas_AccCode a
where h.DocStatus<>99 and d.BNet=0 
and isnull(d.LinkBillNo,'')<>''
and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','CashIn')
group by h.ClrNo,h.ClrDate,a.AccCode,a.AccName,d.SDescription
) t
where ClrDate>=@datefrom and ClrDate<=@dateto
group by ClrNo,ClrDAte
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_RVfromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_RVfromJob]
(
	@datefrom date,
	@dateto date,
	@billingcode varchar(20)='%'
)
as
begin
delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_ReceiptHeader b on
replace(a.JournalNo,'RV-','')=b.ReceiptNo
where b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @billingcode

delete b from Acc_JournalDT b 
where EntryId not in(SELECT EntryId from Acc_JournalHD)


declare @id int=(select isnull(MAX(EntryId),0) as id from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY AccDocNo) as EntryID,
concat('RV-',a.AccDocNo) as JournalNo,a.AccBatchDate,a.AccEffectiveDate,IssueBy,DocRefNo,0,0
from vTransaction_H a 
inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo
where a.AccDocType='RC '
and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @billingcode
order by a.AccDocNo

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY AccDocNo),
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo,AccCode) as Seq,
AccCode,AccName,AccDesc,sum(Debit) as Dr,sum(Credit) as Cr from (
	select 
	a.AccDocNo,a.AccItemNo,a.AssetAccCode as AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,0 as Debit,
	sum(a.Amount+a.DVatAmt) as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo
	where a.AccDocType='RC' 
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @billingcode
	group by a.AccDocNo,a.AccItemno,a.AssetAccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(a.DNetAmt) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo,vMas_AccCode p
	where a.AccDocType='RC' and p.AccCode=dbo.GetAccConfig('AR_CONFIG','CashIn')
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @billingcode
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
	union all
	select 
	a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription as AccName,a.AccSourceDocNo as AccDesc,
	sum(a.DWhtAmt) as Debit,0 as Credit
	from vTransaction_All a
	inner join [job_3x].dbo.Job_ReceiptHeader b on a.AccDocNo=b.ReceiptNo,vMas_AccCode p
	where a.AccDocType='RC' AND a.ProductCode like 'S%' and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto and b.BillToCustCode like @billingcode
	and a.DWhtAmt>0
	group by a.AccDocNo,a.AccItemNo,p.AccCode,a.SalesDescription,a.AccSourceDocNo
) t
group by AccDocNo,AccCode,AccName,AccDesc

delete from Acc_JournalDT where EntryID not in(select EntryId from Acc_JournalHD)
delete from Acc_JournalHD where EntryID not in(select EntryId from Acc_JournalDT)

update 
h set h.TotalDebit=d.Dr,h.TotalCredit=d.Cr
from Acc_JournalHD h inner join 
(select EntryID,sum(Debit) dr,sum(Credit) cr from Acc_JournalDT group by EntryID) d on h.EntryId=d.EntryID
where h.TotalDebit<>d.Dr or h.TotalCredit<>d.Cr
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromJob_V2]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

















--declare @datefrom date='2026-02-01'
---declare @dateto date='2026-03-31'

CREATE procedure [dbo].[Insert_RVFromJob_V2]
(
	@datefrom date,
	@dateto date
)
as
begin
delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b
on a.JournalNo=concat('RV-R',b.ControlNo)
and b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto;

delete b from Acc_JournalDT b
where not exists(select 1 from Acc_JournalHD where EntryId=b.EntryId)

select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,h.ControlNo as VoucherNo,h.VoucherDate,
	(case when d.AmtAdvance>0 then a.Amt+a.AmtVAT else a.Amt end) as Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVAT,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi,
	(a.Net) as AmtTotal,
	(case when d.AmtAdvance>0 then dbo.GetAccConfig('AR_CONFIG','Advance') else 
	isnull(a3.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) end) 
	as AccCodeC,
	a4.AccCode as AccCodeD,f.NameThai as CustName,h.RecUser as EmpCode,i.DocNo as InvoiceNo
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	inner join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i on d.DocNo=i.DocNo
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join dbo.Mas_AccCode a3
	on f.GLAccountCode=a3.AccCode
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	inner join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RV-R',VoucherNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.VoucherNo,a.CustName),
concat('RV-R',a.VoucherNo) as DocNo,a.VoucherDate,a.VoucherDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.VoucherNo,a.VoucherDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select VoucherNo as DocNo,AccCodeC as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 
	group by VoucherNo,AccCodeC,InvoiceNo,RefNo
	union all
	select VoucherNo,AccCodeD as AccCode,DocNo,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by VoucherNo,AccCodeD,DocNo,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RV-R',VoucherNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromJob_V3]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[Insert_RVFromJob_V3]
(
	@datefrom date,
	@dateto date
)
as
begin
delete a from Acc_JournalHD a
inner join [job_3x].dbo.Job_CashControl b
on a.JournalNo=concat('RV-R',b.ControlNo)
and b.VoucherDate>=@datefrom and b.VoucherDate<=@dateto;

delete b from Acc_JournalDT b
where not exists(select 1 from Acc_JournalHD where EntryId=b.EntryId)

select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,
	b.ReceiptDate as DocDate,h.ControlNo as VoucherNo,h.VoucherDate,
	(case when d.AmtAdvance>0 then a.Amt+a.AmtVAT else a.Amt end) as Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVAT,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi,
	(a.Net) as AmtTotal,
	isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueIncome')) as AccCodeC,
	isnull(a4.AccCode,dbo.GetAccConfig('AR_CONFIG','CashIn')) as AccCodeD,
	f.NameThai as CustName,h.RecUser as EmpCode,i.DocNo as InvoiceNo
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	inner join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i on d.DocNo=i.DocNo
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueIncome')+'-____') a3
	on concat(a3.AccMainName,'-',f.NameThai)=a3.AccName
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	inner join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto
	union all
	select c.ChqNo,j.JNo,
	c.ChqDate,h.ControlNo,h.VoucherDate,
	c.ChqAmount as Amt,0 as AmtVat,0 as AmtWht,c.ChqAmount,
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','ChequeIn')) as AccCodeC,
	isnull(a4.AccCode,dbo.GetAccConfig('AR_CONFIG','CashIn')) as AccCodeD,
	f.NameThai as CustName,h.RecUser as EmpCode,c.PRVoucher as InvoiceNo
	from [job_3x].dbo.Job_CashControlSub c 
	inner join [job_3x].dbo.Job_CashControl h on 
	c.ControlNo=h.ControlNo
	inner join [job_3x].dbo.Job_Order j on c.ForJNo=j.JNo 
	left join [job_3x].dbo.Mas_Company f on j.CustCode=f.CustCode and j.CustBranch=f.Branch
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','ChequeIn')+'-____') ac 
	on concat(ac.AccMainName,'-',f.NameThai)=ac.AccName
	where isnull(h.CancelProve,'')=''
	and c.acType='CU' and c.PRType='P'
	and c.ChqAmount>0 
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto
) tb 

delete a from Acc_JournalHD a where exists(select 1 from #tmp1 where a.JournalNo=concat('RV-R',VoucherNo));
delete b from Acc_JournalDT b where not exists(select EntryId from Acc_JournalHD where EntryId=b.EntryId);

declare @id int=(select isnull(MAX(EntryID),0)  from Acc_JournalHD);

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @id+ROW_NUMBER() OVER(ORDER BY a.VoucherNo,a.CustName),
concat('RV-R',a.VoucherNo) as DocNo,a.VoucherDate,a.VoucherDate,a.EmpCode,a.CustName,sum(a.AmtTotal),sum(a.AmtTotal)
from #tmp1 a 
group by a.VoucherNo,a.VoucherDate,a.EmpCode,a.CustName

insert into Acc_JournalDT(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
select @id+DENSE_RANK() OVER(ORDER BY DocNo),
ROW_NUMBER() OVER(PARTITION BY DocNo ORDER BY DocNo,AccCode),
AccCode,CustName,SubAccname,Debit,Credit
from (
	select VoucherNo as DocNo,AccCodeC as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 
	group by VoucherNo,AccCodeC,InvoiceNo,RefNo
	union all
	select VoucherNo,AccCodeD as AccCode,DocNo,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by VoucherNo,AccCodeD,DocNo,RefNo
) tb;

EXEC dbo.UpdateTotalDebitCredit

select * from Acc_JournalHD h 
where exists(select 1 from #tmp1 where concat('RV-R',VoucherNo)=h.JournalNo)

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromRC]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO























CREATE procedure [dbo].[Insert_RVFromRC]
(
@transno nvarchar(50),
@userid nvarchar(50),
@docdate date,
@acccode nvarchar(20),
@bankchg float=0,
@rvno nvarchar(20)='',
@acccredit nvarchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'ACC','RV')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end
declare @maxid int;
set @maxid=(SELECT isnull(MAX(EntryId),0) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT('RV',FORMAT(@docdate,'yyMM')),'0000');

if @rvno<>''
begin
 set @running=@rvno;
end

insert into Acc_JournalHD(EntryId,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
select @maxid+1 as EntryID,
@running,@docdate as EntryDate,
@docdate,@userid as UserID,
@transno,0,0
from vTransaction_H h
where h.AccDocNo=@transno
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)
and not exists(select 1 from Acc_JournalHD where [Description]=@transno)

declare @eid int=(select isnull(EntryID,0) from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo)+@seq as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
	select 
	(case when @acccredit='' then h.IncomeAccCode else @acccredit end) as AccCode,
	h.AccDocNo,0 as Debit,h.TotalAmount as Credit,
	h.SalesDescription as AccDesc,(case when h.AccSourceDocNo='' then h.AccDocNo else h.AccSourceDocNo end) as RefNo
	from vRC_D h	
	where h.AccDocNo=@transno
	and not (exists(select 1 from vAR_D where AccSourceDocNo=h.AccSourceDocNo and AccSourceDocItem=h.AccSourceDocItem
	and AccSourceDocNo<>'')
	or exists(select 1 from vAR_D where AccDocNo=h.AccSourceDocNo and AccItemNo=h.AccSourceDocItem))
	union all
	select 
	(case when @acccredit='' then dbo.GetAccConfig('AR_CONFIG','Sales') else @acccredit end) as AccCode,
	h.AccDocNo,0 as Debit,h.TotalAmount+h.VatAmount as Credit,
	h.SalesDescription as AccDesc,h.AccSourceDocNo as RefNo
	from vRC_D h	
	where h.AccDocNo=@transno
	and (exists(select 1 from vAR_D where AccSourceDocNo=h.AccSourceDocNo and AccSourceDocItem=h.AccSourceDocItem
	and AccSourceDocNo<>'')
	or exists(select 1 from vAR_D where AccDocNo=h.AccSourceDocNo and AccItemNo=h.AccSourceDocItem))
    union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalVat as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno and h.TotalVat>0
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	h.AccDocNo,h.VatAmount as Debit,0 as Credit,
	h.PartyName as AccDesc,h.AccSourceDocNo as RefNo
	from vRC_D h	
	where h.AccDocNo=@transno and h.VatAmount>0
	and (exists(select 1 from vAR_D where AccSourceDocNo=h.AccSourceDocNo and AccSourceDocItem=h.AccSourceDocItem
	and AccSourceDocNo<>'')
	or exists(select 1 from vAR_D where AccDocNo=h.AccSourceDocNo and AccItemNo=h.AccSourceDocItem))
	union all
	select 
	@acccode as AccCode,
	h.AccDocNo,h.TotalNet-@bankchg as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno	
    union all
	select 
	dbo.GetAccConfig('GL_CONFIG','BankCharge') as AccCode,
	h.AccDocNo,@bankchg as Debit,0 as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno and @bankchg>0
	union all
	select 
	dbo.GetAccConfig('WHT_CONFIG','OutputTax') as AccCode,
	h.AccDocNo,h.TotalWht as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vTransaction_H h
	where h.AccDocNo=@transno	And h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
where exists(select 1 from Acc_JournalHD where EntryId=@eid)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid;

--update Acc_TransactionHD set DocStatus=1 where AccDocNo=@transno and DocStatus<0

select * from Acc_JournalHD where EntryId=@eid;
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromSI]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE procedure [dbo].[Insert_RVFromSI]
(
@invno nvarchar(50),
@userid nvarchar(50),
@taxno nvarchar(50),
@docdate date,
@rvno nvarchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'ACC','RV')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT('RV',FORMAT(@docdate,'yyMM')),'0000');

if @rvno<>''
begin
 set @running=@rvno;
end

insert into Acc_JournalHD
select @maxid+1 as EntryID,
@running,@docdate  as EntryDate,
@docdate,@userid as UserID,
@taxno,0,0
from vAR_H h
where h.AccDocNo=@invno
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)

declare @eid int=(select EntryID from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo)+@seq as Seq,
b.AccCode,b.AccName,RefNo,a.Debit,a.Credit from
(
	select 
	dbo.GetAccConfig('AR_CONFIG','Sales') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalAmount+h.TotalVat as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAR_H h
	where h.AccDocNo=@invno
	union
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	h.AccDocNo,h.TotalVat as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAR_H h
	where h.AccDocNo=@invno and h.TotalVat>0
	union
	select 
	dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalVat as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAR_H h
	where h.AccDocNo=@invno and h.TotalVat>0
	union
	select 
	dbo.GetAccConfig('AR_CONFIG','CashIn') as AccCode,
	h.AccDocNo,h.TotalNet as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAR_H h
	where h.AccDocNo=@invno	
	union
	select 
	dbo.GetAccConfig('WHT_CONFIG','OutputTax') as AccCode,
	h.AccDocNo,h.TotalWht as Debit,0 as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAR_H h
	where h.AccDocNo=@invno	And h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode


update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid;

--update Acc_TransactionHD set DocStatus=2 where AccDocNo=@invno and DocStatus<2

select * from Acc_JournalHD where EntryId=@eid;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_RVFromSO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO














CREATE procedure [dbo].[Insert_RVFromSO]
(
@sono nvarchar(50),
@userid nvarchar(50),
@taxno nvarchar(50),
@docdate date,
@rvno nvarchar(20)='',
@acccode nvarchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'ACC','RV')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)

declare @running nvarchar(20);
set @running=dbo.GetNewJournal(CONCAT('RV',FORMAT(@docdate,'yyMM')),'0000');

if @rvno<>''
begin
 set @running=@rvno;
end

insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,[Description],TotalDebit,TotalCredit)
select @maxid+1 as EntryID,
@running,@docdate  as EntryDate,
@docdate,@userid as UserID,
@taxno,0,0
from vSO_H h
where h.AccDocNo=@sono
and not exists(select EntryID from Acc_JournalHD where JournalNo=@running)
and not exists(select 1 from Acc_JournalDT where AccDesc=h.AccDocNo and AccName=h.DocRefNo)

declare @eid int=(select isnull(EntryID,0) from Acc_JournalHD where JournalNo=@running);
declare @seq int=(select isnull(max(Seq),0) From Acc_JournalDT where EntryId=@eid);
if @seq is null 
begin
 set @seq=0;
end

insert into Acc_JournalDT
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo)+@seq as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
	select 
	h.IncomeAccCode as AccCode,
	h.AccDocNo,0 as Debit,h.TotalAmount as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vSO_D h
	where h.AccDocNo=@sono
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalVat as Credit,
	h.DocRefNo as AccDesc,h.AccDocNo as RefNo
	from vSO_H h
	where h.AccDocNo=@sono and h.TotalVat>0
	union all
	select 
	dbo.GetAccConfig('AR_CONFIG','CashIn') as AccCode,
	h.AccDocNo,h.TotalNet as Debit,0 as Credit,
	h.DocRefNo as AccDesc,h.AccDocNo as RefNo
	from vSO_H h
	where h.AccDocNo=@sono and @acccode=''
	union all
	select 
	@acccode as AccCode,
	h.AccDocNo,h.TotalNet as Debit,0 as Credit,
	h.DocRefNo as AccDesc,h.AccDocNo as RefNo
	from vSO_H h
	where h.AccDocNo=@sono and @acccode<>''
	union all
	select 
	dbo.GetAccConfig('WHT_CONFIG','IncomeTax') as AccCode,
	h.AccDocNo,h.TotalWht as Debit,0 as Credit,
	h.PartyName as AccDesc,h.AccDocNo as RefNo
	from vSO_H h
	where h.AccDocNo=@sono	And h.TotalWht>0
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
where exists(select 1 from Acc_JournalHD where EntryId=@eid)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.EntryId=@eid;

--update Acc_TransactionHD set DocStatus=2 where AccDocNo=@sono and DocStatus<2

select * from Acc_JournalHD where EntryId=@eid;
end



GO
/****** Object:  StoredProcedure [dbo].[Insert_SalaryToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_SalaryToJournal]
(
	@paydate date,
	@userid varchar(20),
	@paydesc varchar(200)
)
as
begin
declare @id int=(SELECT isnull(MAX(EntryID),0) from Acc_JournalHD);

with tbl as
(
select @id+DENSE_RANK() OVER(ORDER BY StaffID) as eid,
CONCAT('SAL',FORMAT(@paydate,'yyMM'),FORMAT(DENSE_RANK() OVER(ORDER BY StaffID),'0000')) as JournalNo,
ROW_NUMBER() OVER(PARTITION BY StaffId ORDER BY StaffId,Seq) as ItemNo,
AccCode,AccName,StaffName as AccDesc,sum(Debit) Dr,sum(Credit) as Cr 
from (
	select StaffId,Seq,
	AccCode,AccName,StaffName,0 as Debit,Credit
	from vHR_Salary a WHERE Seq=0 and PayrollType=2
	and AccCode=dbo.GetAccConfig('GL_CONFIG','AccrueSocial')
	union all
	select StaffId,Seq,
	b.AccCode,SalaryName,StaffName,Credit,0
	from vHR_Salary a,Mas_AccCode b 
	WHERE Seq>0 and PayrollType=2
	and a.AccCode=dbo.GetAccConfig('GL_CONFIG','AccrueSocial')
	and b.AccCode=dbo.GetAccConfig('GL_CONFIG','SocialFund')
	union all
	select StaffId,Seq,
	AccCode,AccName,StaffName,Debit,Credit
	from vHR_Salary a 
) t
group by StaffId,Seq,AccCode,AccName,StaffName
)
select * into #tmpsal from tbl

delete from Acc_JournalHD where JournalNo in(select distinct JournalNo from #tmpsal)
delete from Acc_JournalDT where EntryId not in(select EntryId from Acc_JournalHD)

insert into Acc_JournalHD
select eid,journalno,@paydate,@paydate,@userid,@paydesc,sum(Dr),sum(Cr)
from #tmpsal 
group by eid,journalno

insert into Acc_JournalDT
select eid,itemno,acccode,accname,accdesc,dr,cr from #tmpsal

select a.* from vJournal_All a
inner join #tmpsal b 
on a.EntryId=b.eid and a.ItemNo=b.itemno

drop table #tmpsal
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_SIFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


















CREATE procedure [dbo].[Insert_SIFromJob]
(
@datefrom date,
@dateto date,
@docdate date,
@userid varchar(20)
)
as
begin
insert into Acc_TransactionDT 
select d.DocNo,
ROW_NUMBER() OVER(ORDER BY d.ItemNo),'',0,0,
(case when d.AmtAdvance>0 then 1 else d.Qty end),
(case when d.AmtAdvance>0 then d.AmtAdvance else d.UnitPrice end)
,d.QtyUnit,d.CurrencyCode,d.ExchangeRate,
(case when d.AmtAdvance>0 then d.AmtAdvance else d.Amt end)
,p.ProductCode,d.SDescription,
(case when d.AmtCharge>0 AND d.AmtVat>0 then d.VATRate else 0 end),
(case when d.AmtCharge>0 AND d.Amt50Tavi>0 then d.Rate50Tavi else 0 end),
1
from [job_3x].dbo.Job_InvoiceHeader h
inner join [job_3x].dbo.Job_InvoiceDetail d
on h.DocNo=d.DocNo 
inner join vMas_Product p on d.SICode=p.ProductCode
where h.DocDate>=@datefrom and h.DocDate<=@dateto
and not isnull(h.CancelProve,'')<>''
and d.DocNo not in (select AccDocNo from Acc_TransactionHD)

insert into Acc_TransactionHD 
select h.DocNo,@docdate,h.DocDate,
isnull(c.CustCode,'-'),isnull(c.TaxNumber,'-'),
isnull(c.NameThai,'-'),CONCAT(isnull(c.TAddress1,''),' ',isnull(c.TAddress2,'')),@userid,
'SI','1900-01-01',@docdate,1,h.RefNo
from [job_3x].dbo.Job_InvoiceHeader h
left join [job_3x].dbo.Mas_Company c
on h.BillToCustCode=c.CustCode and h.BillToCustBranch=c.Branch
where h.DocDate>=@datefrom and h.DocDate<=@dateto
and not isnull(h.CancelProve,'')<>''
and h.DocNo not in (select AccDocNo from Acc_TransactionHD)

end 

GO
/****** Object:  StoredProcedure [dbo].[Insert_SIFromSO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE procedure [dbo].[Insert_SIFromSO]
(
@userid varchar(20),
@docdate date,
@duedate date,
@pono varchar(20),
@itemno int=0,
@docno varchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','SI')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @header varchar(20);
set @header=CONCAT('SI',FORMAT(@docdate,'yyMM'));

declare @running varchar(20);
--set @running =dbo.GetNewTransaction(@header,'0000');
set @running=dbo.GetNewRunning('SI','T',@docdate);
if @docno<>'' 
begin
 set @running=@docno;
end


insert into Acc_TransactionHD
select 
@running as AccDocNo,
@docdate as AccBatchDate,
@duedate as AccEffectiveDate,
PartyCode,
PartyTaxCode,
PartyName,
PartyAddress,
@userid as IssueBy,
'SI' as AccDocType,
'1900-01-01' as AccPostDate,
@docdate as FiscalYear,
0 as DocStatus,
DocRefNo
from vSO_H where AccDocNo=@pono
and not exists(select AccDocNo from Acc_TransactionHD where AccDocNo=@running)

declare @ino int=(select isnull(MAX(AccItemNo),0) from Acc_TransactionDT where AccDocNo=@running);
if @ino is null
begin
 set @ino=0;
end

if @itemno=0
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	AccDocNo as AccSourceDocNo,
	AccItemNo as AccSourceDocItem,
	0 as StockTransNo,
	Qty,
	(TotalAmount/ExchangeRate)/Qty,
	UnitMea,
	Currency,
	ExchangeRate,
	TotalAmount,
	SaleProductCode,
	SalesDescription,RateVat,RateWht,1
	from vSO_D a where AccDocNo=@pono
	and not exists(select 1 from vAR_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
end
else
begin
	insert into Acc_TransactionDT
	select 
	@running as AccDocNo,
	(ROW_NUMBER() OVER (PARTITION BY AccEffectiveDate ORDER BY AccBatchDate))+@ino as AccItemNo,
	AccDocNo as AccSourceDocNo,
	AccItemNo as AccSourceDocItem,
	0 as StockTransNo,
	Qty,
	(TotalAmount/ExchangeRate)/Qty,
	UnitMea,
	Currency,
	ExchangeRate,
	TotalAmount,
	SaleProductCode,
	SalesDescription,RateVat,RateWht,1
	from vSO_D a where AccDocNo=@pono and AccItemNo=@itemno
	and not exists(select 1 from vAR_D where AccSourceDocNo=a.AccDocNo and AccSourceDocItem=a.AccItemNo)
end

--update Acc_TransactionHD set DocStatus=1,AccPostDate=@docdate where DocStatus=0 And AccDocType='SO' and AccDocNo=@pono
delete from Acc_TransactionHD where AccDocNo=@running 
and not exists(select 1 from Acc_TransactionDT where AccDocNo=@running)

select AccDocNo as IVNo,AccBatchDate as PVDate,AccEffectiveDate as DueDate, 
PartyCode as CustCode,PartyName as CustName,TotalAmount,TotalVat,TotalWht,TotalNet
from vAR_H
where AccDocNo=@running;
end 



GO
/****** Object:  StoredProcedure [dbo].[Insert_SIToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE procedure [dbo].[Insert_SIToJournal]
(
@invno nvarchar(50),
@userid nvarchar(50),
@invdate nvarchar(20)=''
)
as
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'FIN','SI')
if NOT CHARINDEX('P',@author,1)>0
begin
	return
end

declare @maxid int;
set @maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)

insert into Acc_JournalHD
select @maxid+1 as EntryID,
h.AccDocNo,h.AccBatchDate  as EntryDate,
h.AccEffectiveDate,@userid as UserID,
h.DocRefNo,0,0
from vAR_H h
where h.AccDocNo=@invno
and not exists(select JournalNo from Acc_JournalHD where JournalNo=@invno)

declare @eid int=(select EntryId from Acc_JournalHD where JournalNo=@invno);

insert into Acc_JournalDT
select * from (
select @eid as EntryId,
ROW_NUMBER() OVER(ORDER BY RefNo) as Seq,
b.AccCode,a.AccDesc,a.RefNo,a.Debit,a.Credit from
(	
	select 
	dbo.GetAccConfig('AR_CONFIG','Sales') as AccCode,
	d.AccDocNo,d.TotalAmount+d.VatAmount as Debit,0 as Credit,
	concat(d.SaleProductCode,' / ', d.SalesDescription) as AccDesc,
	d.AccSourceDocNo as RefNo
	from vAR_D d	
	where d.AccDocNo=@invno
	union all
	select 
	dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	h.AccDocNo,0 as Debit,h.TotalVat as Credit,
	h.PartyName as AccDesc,h.DocRefNo as RefNo
	from vAR_H h
	where h.AccDocNo=@invno
	and h.TotalVat>0
	union all
	select 
	d.IncomeAccCode as AccCode,
	d.AccDocNo,0 as Debit,d.TotalAmount as Credit,
	concat(d.SaleProductCode,' / ', d.SalesDescription) as AccDesc,
	d.AccSourceDocNo as RefNo
	from vAR_D d	
	where d.AccDocNo=@invno
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where Not Exists(select EntryId from Acc_JournalDT where EntryID=tb.EntryId and Seq=tb.Seq)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where a.JournalNo=@invno

update a set a.AccPostDate=b.EntryDate
from Acc_TransactionHD a
inner join Acc_JournalHD b
on a.AccDocNo=b.JournalNo 
where a.DocStatus=0 and b.JournalNo=@invno;

select * from Acc_JournalHD where EntryId=@eid;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_SIToJournal_ByDate]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_SIToJournal_ByDate]
(
@@datefrom date,
@@dateto date,
@@userid nvarchar(50)
)
as
begin
declare @@maxid int;
set @@maxid=(SELECT MAX(EntryId) as t from Acc_JournalHD)



insert into Acc_JournalHD(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
select @@maxid+ROW_NuMBER() OVER(ORDER BY h.AccDocNo) as EntryID,
h.AccDocNo,h.AccBatchDate  as EntryDate,
h.AccEffectiveDate,@@userid as UserID,
h.DocRefNo,0,0
from vAR_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
and h.AccDocNo not in(select JournalNo from Acc_JournalHD)



insert into Acc_JournalDT
select * from (
select @@maxid+DENSE_RANK() OVER(ORDER BY AccDocNo)  as EntryId,
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY RefNo) as Seq,
b.AccCode,a.AccDesc,RefNo,a.Debit,a.Credit from
(
select
dbo.GetAccConfig('AR_CONFIG','Sales') as AccCode,
h.AccDocNo,h.TotalAmount+h.TotalVat as Debit,0 as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAR_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
union all
select
dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
h.AccDocNo,0 as Debit,h.TotalVat as Credit,
h.PartyName as AccDesc,h.DocRefNo as RefNo
from vAR_H h
where h.AccBatchDate>=@@datefrom and h.AccBatchDate<=@@dateto
and h.TotalVat>0
union all
select
d.IncomeAccCode as AccCode,
d.AccDocNo,0 as Debit,d.TotalAmount as Credit,
d.SalesDescription as AccDesc,CONCAT(d.AccSourceDocNo,'#',d.AccSourceDocItem) as RefNo
from vAR_D d
where d.AccBatchDate>=@@datefrom and d.AccBatchDate<=@@dateto
) a inner join vMas_AccCode b on a.AccCode=b.AccCode
) tb
where tb.EntryId not in(select EntryID from Acc_JournalDT)

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join
(select EntryId,sum(Debit) sumA,sum(Credit) sumb from Acc_JournalDT  group by EntryID) b
on a.EntryID=b.EntryID
where a.EffectiveDate>=@@datefrom and a.EffectiveDate<=@@dateto

update a set a.AccPostDate=b.EntryDate,a.DocStatus=2
from Acc_TransactionHD a
inner join Acc_JournalHD b
on a.AccDocNo=b.JournalNo
where a.DocStatus=1
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_SOFromSR]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_SOFromSR]
(
@srno nvarchar(20),
@docdate date,
@duedate date,
@refno nvarchar(50),
@userid nvarchar(50),
@itemno int=0,
@sono varchar(20)=''
)
as 
begin
declare @author varchar(20)= dbo.GetAuthorize(@userid,'SO','SO')
if NOT CHARINDEX('I',@author,1)>0
begin
	return
end

declare @docno nvarchar(50);
declare @doctype nvarchar(5);

set @doctype='SO';
--set @docno=dbo.GetNewTransaction(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
set @docno=dbo.GetNewRunning(@doctype,'T',@docdate);
if @sono<>''
begin
   set @docno=@sono;
end

if @itemno=0
begin
	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo) as AccItemNo,a.AccDocNo,a.AccItemNo,0,Qty,
	Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
	RateVat,RateWht,VatType
	from Acc_TransactionDT a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	where b.AccDocNo=@srno 
	and exists(select 1 from vSR_Balance where AccDocNo=@srno and AccItemNo=a.AccItemNo and Balance>0)
end
else
begin 
    declare @ino int=(select isnull(MAX(AccItemNo),0) FROM Acc_TransactionDT where AccDocNo=@docno);
	if @ino is null
	begin
		set @ino=0;
	end

	INSERT INTO Acc_TransactionDT
	select @docno as AccDocNo,
	ROW_NUMBER() OVER(ORDER BY AccItemNo)+@ino as AccItemNo,a.AccDocNo,a.AccItemNo,0,Qty,
	Price,UnitMea,Currency,ExchangeRate,Amount,SaleProductCode,SalesDescription,
	RateVat,RateWht,VatType
	from Acc_TransactionDT a inner join Acc_TransactionHD b
	on a.AccDocNo=b.AccDocNo
	where a.AccDocNo=@srno and a.AccItemNo=@itemno
end 

INSERT INTO Acc_TransactionHD
select * from 
(
	select @docno as AccDocNo,
	@docdate as AccBatchDate,@duedate as AccEffectiveDate,
	PartyCode as Partycode,PartyTaxCode as PartyTaxCode,
	PartyName,PartyAddress,@userid as EmpCode,@doctype as DocType,'1900-01-01' as PostDate,@docdate as SaveDate,0 as DocStatus,@refno as RefNo
	from Acc_TransactionHD where AccDocNo=@srno 
) a where AccDocNo not in(select AccDocNo from Acc_TransactionHD where AccDocNo=@docno)

update Acc_TransactionHD set DocStatus=1,AccPostDate=@docdate where DocStatus=0 and AccDocNo=@srno;

select AccDocNo as SONo,AccBatchDate as SODate,AccEffectiveDate as DueDate, 
PartyCode as CustCode,PartyName as CustName,TotalAmount,TotalVat,TotalWht,TotalNet
from vSO_H
where AccDocNo=@docno;

end


GO
/****** Object:  StoredProcedure [dbo].[Insert_StockFromDO]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE procedure [dbo].[Insert_StockFromDO]
(
@dono varchar(20),
@docdate date,
@caltype int, --0=FIFO,1=AVG
@userid varchar(20)
)
as
begin
/**check authorize**/
declare @author varchar(20)= dbo.GetAuthorize(@userid,'IC','DO')
if NOT CHARINDEX('P',@author,1)>0
begin
	return
end

declare @running varchar(20)=dbo.GetNewTransaction(CONCAT('TF',FORMAT(@docdate,'yyMM')),'0000');
if(@caltype=0)
begin
    
	--insert header
    insert into Acc_TransactionHD
	select @running,@docdate,@docdate,PartyCode,PartyTaxCode,PartyName,PartyAddress,@userid,'TF',@docdate,@docdate,0,AccDocNo from vDO_H where AccDocNo=@dono
	and not exists(select 1 from Acc_TransactionHD where DocRefNo=@dono);
	--insert stock card
    insert into Acc_StockTransaction(TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
	select concat(@running,'#',ROW_NUMBER() OVER(ORDER BY SaleProductCode,AccDocNo)) as LotNo,
	'OUT' as TransType,t.SaleProductCode,t.UsedQty*-1 as Qty,t.Price as Price,'THB' as Curr,1 as Rate,p.AssetAccCode,
	t.WarehouseCode,
	concat(t.AccRefNo,'#',t.RefItem)
	from (
		select b.*,b.SumQty-b.BalQty as PrevQty,a.Qty as SalesQty,
		(case when a.Qty>b.SumQty then b.BalQty else a.Qty-(b.SumQty-b.BalQty) end)
		as UsedQty,
		a.AccDocNo as AccRefNo,a.AccItemNo as RefItem
		from vStock_Balance  b 
		inner join vDO_All a
		on b.SaleProductCode=a.SaleProductCode	
		where b.SumQty>0 and a.StockTransNo=0
		and a.AccDocNo=@dono		
		and (b.SumQty-b.BalQty)<=a.Qty		
	) t inner join vMas_Product p on t.SaleProductCode=p.ProductCode
	where t.UsedQty>0
	and not exists(select 1 from Acc_StockTransaction where AccRefNo=concat(t.AccRefNo,'#',t.RefItem))
	and exists(select 1 from Acc_TransactionHD where AccDocNo=@running)
	order by SaleProductCode,StockTransNo
	--Insert detail 
	insert into Acc_TransactionDT
	select @running as DocNo,ROW_NUMBER() OVER(ORDER BY SaleProductCode,AccDocNo) as ItemNo,
	AccDocNo as SourceNo,AccItemNo as SourceItem,0,UsedQty,Price,UnitStock,'THB',1,UsedQty*Price,SaleProductCode,ProductName,0,0,0
	from (
		select b.*,b.SumQty-b.BalQty as PrevQty,a.Qty as SalesQty,
		(case when a.Qty>b.SumQty then b.BalQty else a.Qty-(b.SumQty-b.BalQty) end)
		as UsedQty,
		a.AccSourceDocNo as AccRefNo,a.AccSourceDocItem as RefItem
		from vStock_Balance  b 
		inner join vDO_All a
		on b.SaleProductCode=a.SaleProductCode	
		where b.SumQty>0 and a.StockTransNo=0
		and a.AccDocNo=@dono		
		and (b.SumQty-b.BalQty)<=a.Qty		
	) t inner join vMas_Product p on t.SaleProductCode=p.ProductCode
	where t.UsedQty>0
	and exists(select 1 from Acc_TransactionHD where AccDocNo=@running)
	order by SaleProductCode,StockTransNo
    --update foreign key from stock card to transaction    
	update a
	set a.StockTransNo=b.TransID
	from Acc_TransactionDT a inner join Acc_StockTransaction b
	on concat(a.AccDocNo,'#',a.AccItemNo)=b.TransNum
	where a.AccDocNo=@running and a.StockTransNo=0
	--journal entry
	declare @journalno varchar(20)=dbo.GetNewJournal(CONCAT('JV',FORMAT(@docdate,'yyMM')),'0000');
	declare @jv int=(select isnull(MAX(EntryID),0)+1 from Acc_JournalHD);

	insert into Acc_JournalHD (EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
	select @jv,@journalno,@docdate,@docdate,@userid,@dono,sum(Amount),sum(Amount) 
	from Acc_TransactionDT a 
	inner join vMas_Product b on a.SaleProductCode=b.ProductCode 
	where a.AccDocNo=@running
	group by a.AccDocNo;

	declare @id int=(SELECT EntryID from Acc_JournalHD where JournalNo=@journalno);
	declare @seq int=(select isnull(MAX(Seq),0) from Acc_JournalDT where EntryID=@id);
	--Cr. สินค้าคงเหลือ
	insert into Acc_JournalDT (EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,@seq+ROW_NUMBER() OVER (ORDER BY AccDocNo,AccItemNo)
	,b.AssetAccCode,a.AccDocNo,a.AccSourceDocNo,0,sum(a.Amount)
	from Acc_TransactionDT a 
	inner join vMas_Product b on a.SaleProductCode=b.ProductCode 
	where a.AccDocNo=@running
	group by AccDocNo,AccItemNo,AssetAccCode,AssetAccName,a.AccSourceDocNo;

	set @seq =(select isnull(MAX(Seq),0) from Acc_JournalDT where EntryID=@id);
	--Dr.ต้นทุน
	insert into Acc_JournalDT(EntryID,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,@seq+ROW_NUMBER() OVER (ORDER BY a.AccDocNo,AccItemNo)
	,b.ExpenseAccCode,a.AccDocNo,c.DocRefNo,sum(a.Amount),0
	from Acc_TransactionDT a inner join Acc_TransactionHD c on a.AccDocNo=c.AccDocNo 
	inner join vMas_Product b on a.SaleProductCode=b.ProductCode 
	where a.AccDocNo=@running
	group by a.AccDocNo,AccItemNo,ExpenseAccCode,ExpenseAccName,c.DocRefNo;
end

update Acc_TransactionHD set DocStatus=1 where AccDocNo=@dono
and exists(select 1 from Acc_JournalHD where [Description]=@dono) and DocStatus=0

select * from Acc_JournalHD where JournalNo=@journalno;
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_StockFromTransaction]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_StockFromTransaction]
(
    @docno varchar(20),
    @docdate date,
    @userid varchar(50),    
    @whcode varchar(20),
    @transtype varchar(20), --IN/OUT
    @qty float=0,
    @acccode varchar(20)=''
)
AS
BEGIN

insert into Acc_StockTransaction (TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
select 
CONCAT(a.AccDocNo,'#',a.AccItemNo),@transtype as TransType,
a.SaleProductCode,
(case when @qty<>0 then @qty else a.Qty end)
,a.Price,a.Currency,a.ExchangeRate, 
(case when not @acccode='' then @acccode else c.AssetAccCode end),
(case when not @whcode='' then @whcode else c.WarehouseCode end),
CONCAT(a.AccSourceDocNo,'#',a.AccSourceDocItem)
from vTransaction_All a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
where a.AccDocNo=@docno and c.IsService=0 and a.StockTransNo=0

update a
set a.StockTransNo=d.TransID
from Acc_TransactionDT a inner join Acc_TransactionHD b
on a.AccDocNo=b.AccDocNo
inner join vMas_Product c on a.SaleProductCode=c.ProductCode
inner join Acc_StockTransaction d
on CONCAT(a.AccDocNo,'#',a.AccItemNo)=d.TransNum
where a.AccDocNo=@docno AND a.StockTransNo=0
and b.DocStatus<>99

update Acc_TransactionHD set DocStatus=1,AccPostDate=@docdate where AccDocNo=@docno;

select * from vStock_Card where AccDocNo=@docno;
END

GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromCustomer]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_SubAccCodeFromCustomer]
(
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'

	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	update c set c.GLAccountCode=''
	from [job_3x].dbo.Mas_Company c 
	where not exists(select 1 from Mas_AccCode where AccCode=c.GLAccountCode)

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY CustCode),'0000')) as AccCode,
	concat(b.AccName,'-',a.NameThai) as AccName,concat(b.AccNameEN,'-',a.NameEng) as AccNameEN,
	b.AccTypeID,@mainacc
	from [job_3x].dbo.Mas_Company a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	--and isnull(a.GLAccountCode,'')=''
	and not exists(select 1 from Mas_AccCode where AccName=concat(b.AccName,'-',a.NameThai))
		
	update c set c.GLAccountCode=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Mas_Company c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and concat(b.AccName,'-',c.NameThai)=a.AccName
	and @update=1

	select c.GLAccountCode,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Mas_Company c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and concat(b.AccName,'-',c.NameThai)=a.AccName
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromOCharge]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_SubAccCodeFromOCharge]
(
	@prefix varchar(10),
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'
	
	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY SICode),'0000')) as AccCode,
	concat(b.AccName,'-',a.NameThai) as AccName,concat(b.AccNameEN,'-',a.NameEng) as AccNameEN,
	b.AccTypeID,@mainacc
	from [job_3x].dbo.Job_SrvSingle a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	and a.SICode like @prefix+'%'
	and not a.IsExpense=0
	--and isnull(a.GLAccountCodeCost,'')=''
	and not exists(select 1 from Mas_AccCode where AccName like '%-'+a.NameThai)
		
	update c set c.GLAccountCodeCost=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
	and @update=1

	select c.GLAccountCodeCost,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromSCharge]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_SubAccCodeFromSCharge]
(
	@prefix varchar(10),
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'
	
	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY SICode),'0000')) as AccCode,
	concat(b.AccName,'-',a.NameThai) as AccName,concat(b.AccNameEN,'-',a.NameEng) as AccNameEN,
	b.AccTypeID,@mainacc
	from [job_3x].dbo.Job_SrvSingle a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	and a.SICode like @prefix+'%'
	and not a.Rate50Tavi=1 and a.IsExpense=0
	--and isnull(a.GLAccountCodeCost,'')=''
	and not exists(select 1 from Mas_AccCode where AccName like '%-'+a.NameThai)
		
	update c set c.GLAccountCodeCost=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
	and @update=1

	select c.GLAccountCodeCost,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromService]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[Insert_SubAccCodeFromService]
(
	@prefix varchar(10),
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'
	
	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY SICode),'0000')) as AccCode,
	concat(b.AccName,'-',a.NameThai) as AccName,concat(b.AccNameEN,'-',a.NameEng) as AccNameEN,
	b.AccTypeID,@mainacc
	from [job_3x].dbo.Job_SrvSingle a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	and a.SICode like @prefix+'%'
	--and isnull(a.GLAccountCodeCost,'')=''
	and not exists(select 1 from Mas_AccCode where AccName like '%-'+a.NameThai)
		
	update c set c.GLAccountCodeCost=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
	and @update=1

	select c.GLAccountCodeCost,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromTCharge]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_SubAccCodeFromTCharge]
(
	@prefix varchar(10),
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'
	
	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY SICode),'0000')) as AccCode,
	concat(b.AccName,'-',a.NameThai) as AccName,concat(b.AccNameEN,'-',a.NameEng) as AccNameEN,
	b.AccTypeID,@mainacc
	from [job_3x].dbo.Job_SrvSingle a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	and a.SICode like @prefix+'%'
	and a.Rate50Tavi=1 and a.IsExpense=0
	--and isnull(a.GLAccountCodeCost,'')=''
	and not exists(select 1 from Mas_AccCode where AccName like '%-'+a.NameThai)
		
	update c set c.GLAccountCodeCost=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
	and @update=1

	select c.GLAccountCodeCost,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Job_SrvSingle c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and c.SICode like @prefix+'%'
	and concat(b.AccName,'-',c.NameThai)=a.AccName
end


GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromUser]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_SubAccCodeFromUser]
(
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'
	
	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	update c set c.GLAccountCode=''
	from [job_3x].dbo.Mas_User c 
	where not exists(select 1 from Mas_AccCode where AccCode=c.GLAccountCode)

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY a.TName),'0000')) as AccCode,
	concat(b.AccName,'-',a.TName) as AccName,concat(b.AccName,'-',a.TName) as AccNameEN,
	b.AccTypeID,@mainacc
	from (select distinct TName from [job_3x].dbo.Mas_User where lower(UserID) Not in('admin','boat','test','tawan','pasit')) a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	--and isnull(a.GLAccountCode,'')=''
	and not exists(select 1 from Mas_AccCode where AccName=concat(b.AccName,'-',a.TName))
	group by b.AccName,a.TName,b.AccTypeID
	
	update c set c.GLAccountCode=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Mas_User c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and concat(b.AccName,'-',c.TName)=a.AccName
	and @update=1

	select c.GLAccountCode,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Mas_User c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and concat(b.AccName,'-',c.TName)=a.AccName
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_SubAccCodeFromVender]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Insert_SubAccCodeFromVender]
(
	@mainacc varchar(20),
	@update int=0
)
as 
begin	
	delete from Mas_AccCode where AccCode like @mainacc+'-____'

	declare @maxcode varchar(20)=(select isnull(MAX(AccCode),concat(@mainacc,'-','0000')) from Mas_AccCode where AccCode like @mainacc+'-____')	
	declare @maxid int=(SELECT CAST(substring(@maxcode,len(@maxcode)-3,4) as int))

	update c set c.GLAccountCode=''
	from [job_3x].dbo.Mas_Vender c 
	where not exists(select 1 from Mas_AccCode where AccCode=c.GLAccountCode)

	insert into Mas_AccCode 
	select concat(@mainacc,'-',FORMAT(@maxid+ROW_NUMBER() OVER(ORDER BY VenCode),'0000')) as AccCode,
	concat(b.AccName,'-',a.TName) as AccName,concat(b.AccNameEN,'-',a.TName) as AccNameEN,
	b.AccTypeID,@mainacc
	from [job_3x].dbo.Mas_Vender a
	,Mas_AccCode b 
	where b.AccCode=@mainacc
	--and isnull(a.GLAccountCode,'')=''
	and not exists(select 1 from Mas_AccCode where AccName=concat(b.AccName,'-',a.TName))
	
	update c set c.GLAccountCode=a.AccCode
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Mas_Vender c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and concat(b.AccName,'-',c.TName)=a.AccName
	and @update=1

	select c.GLAccountCode,a.* 
	from Mas_AccCode a,Mas_AccCode b,
	[job_3x].dbo.Mas_Vender c 	
	where a.AccMainCode=@mainacc
	and b.AccCode=@mainacc 
	and concat(b.AccName,'-',c.TName)=a.AccName
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_Transaction]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insert_Transaction]
(
@fiscalyear date,
@entrydate date,
@effectdate date,
@doctype varchar(20),
@docno varchar(20),
@partycode varchar(50),
@partytype varchar(20),--C=Customer S=Supplier
@partytaxcode varchar(20),
@partyname varchar(255),
@partyaddress varchar(1000),
@userid varchar(20),
@refno varchar(255),
@stocktype int, --0=No stock,1=StockIn,-1=Stock out,
@productcode varchar(20),
@productdesc nvarchar(255),
@itemtype int, --1=Common -1=Discount
@qty float,
@unit varchar(20),
@price float,
@curr varchar(20),
@rate float,
@vattype int, --1=Exclude 2=include
@vatrate float,
@taxrate float,
@linkdoc varchar(20)='',
@linkitem int=0
)
as
begin
	/*create new running if not seen*/
	if @docno=''
	begin
		set @docno=dbo.GetNewRunning(@doctype,'T',@entrydate);
	end
	
	/*load data from master files customer*/
	if @partytype='C'
	begin
		select @partytaxcode=CONCAT(TaxNumber,'/',TaxBranch),
		@partyname=CustomerName,
		@partyaddress=CONCAT(Address1,' ',Address2)
		from Mas_Customer 
		where CustomerCode=@partycode;
	end
	
	/*load data from master files supplier*/	
	if @partytype='S'
	begin
		select @partytaxcode=CONCAT(TaxNumber,'/',TaxBranch),
		@partyname=SupplierName,
		@partyaddress=CONCAT(Address1,' ',Address2)
		from Mas_Supplier 
		where SupplierCode=@partycode;
	end
	
	/*insert header if not exists*/	
	if not exists(select 1 from Acc_TransactionHD where AccDocNo=@docno)
	begin
		INSERT INTO Acc_TransactionHD
		(AccDocNo,AccBatchDate,AccEffectiveDate,PartyCode,PartyTaxCode,PartyName,PartyAddress
		,IssueBy,AccDocType,AccpostDate,FiscalYear,DocStatus,DocRefNo)
		select
		@docno,@entrydate,@effectdate,@partycode,@partytaxcode,@partyname,@partyaddress,
		@userid,@doctype,@entrydate,@fiscalyear,0,@refno;
	end
	
	/*find new item number*/	
	declare @itemno int=(select isnull(MAX(AccItemNo),0)+1 from Acc_TransactionDT where AccDocNo=@docno);
	
	/*insert detail*/	
	declare @amount float=(@qty*@price*@rate)*@itemtype;
	
	INSERT INTO Acc_TransactionDT
	(AccDocNo,AccItemNo,AccSourceDocNo,AccSourceDocItem,StockTransNo,Qty,Price,UnitMea,Currency,ExchangeRate
	,Amount,SaleProductCode,SalesDescription,RateVat,RateWht,VatType)
	select @docno,@itemno,@linkdoc,@linkitem,0,@qty,@price*@itemtype,@unit,@curr,@rate,@amount,@productcode,@productdesc,@vatrate,@taxrate,@vattype;
	
	/*process stock card as requested*/	
	if @productcode<>'' AND @stocktype<>0 AND @itemtype=1
	begin
		/*new lot no*/			
		declare @stockprice float=@price;
		if @vattype=2
		begin
			SELECT @stockprice=TotalAmount/Qty from vTransaction_D where DocNo=@docno and AccItemNo=@itemno;
		end

		INSERT INTO Acc_StockTransaction
		(TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
		select CONCAT(@docno,'#',@itemno),(CASE WHEN @stocktype>0 THEN 'IN' ELSE 'OUT' END),
		p.ProductCode,@qty*@stocktype,@stockprice,@curr,@rate,p.AssetAccCode,p.WarehouseCode,@refno
		from vMas_Product p 
		where p.ProductCode=@productcode

		declare @lotno int=(select isnull(MAX(TransID),0) from Acc_StockTransaction where TransNum=CONCAT(@docno,'#',@itemno));
		/*update related data*/	
		if exists(select 1 from Acc_StockTransaction where TransID=@lotno)
		begin
			UPDATE Acc_TransactionDT
			set StockTransNo=@lotno
			where AccDocNo=@docno AND AccItemno=@itemno;
		end
	end	
end

GO
/****** Object:  StoredProcedure [dbo].[Insert_WHTaxFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Insert_WHTaxFromJob]
(
    @datefrom date,
    @dateto date
)
as

DELETE FROM Acc_WHTaxDetail
WHERE [PayDate]>=@datefrom and [PayDate]<=@dateto
AND exists(
   select 1 from [job_3x].dbo.Job_WHTaxDetail where [DocNo]=Acc_WHTaxDetail.DocNo 
   and [PayDate]>=@datefrom and [PayDate]<=@dateto
  )

DELETE FROM Acc_WHTax
WHERE exists(
   select 1 from [job_3x].dbo.Job_WHTaxDetail where [DocNo]=Acc_WHTax.DocNo 
   and [PayDate]>=@datefrom and [PayDate]<=@dateto
  )

INSERT INTO Acc_WHTaxDetail
SELECT [DocNo]
      ,[ItemNo]
      ,[IncType]
      ,[PayDate]
      ,[PayAmount]
      ,[PayTax]
      ,[PayTaxDesc]
      ,[JNo]
      ,[DocRefType]
      ,[DocRefNo]
      ,[PayRate]
  FROM [job_3x].[dbo].[Job_WHTaxDetail]
  where [PayDate]>=@datefrom and [PayDate]<=@dateto

INSERT INTO Acc_WHTax
SELECT 
      [DocNo]
      ,[DocDate]
      ,[TaxNumber1]
      ,[TName1]
      ,[TAddress1]
      ,[TaxNumber2]
      ,[TName2]
      ,[TAddress2]
      ,[TaxNumber3]
      ,[TName3]
      ,[TAddress3]
      ,[IDCard1]
      ,[IDCard2]
      ,[IDCard3]
      ,[SeqInForm]
      ,[FormType]
      ,[TaxLawNo]
      ,[IncRate]
      ,[IncOther]
      ,[UpdateBy]
      ,[TotalPayAmount]
      ,[TotalPayTax]
      ,[SoLicenseNo]
      ,[SoLicenseAmount]
      ,[SoAccAmount]
      ,[PayeeAccNo]
      ,[SoTaxNo]
      ,[PayTaxType]
      ,[PayTaxOther]
      ,[CancelProve]
      ,[CancelReason]
      ,[CancelDate]
      ,[LastUpdate]
      ,[TeacherAmt]
      ,[Branch1]
      ,[Branch2]
      ,[Branch3]
      ,[IsCSV]
  FROM [job_3x].[dbo].[Job_WHTax] h
  where exists(
   select 1 from [job_3x].dbo.Job_WHTaxDetail where [BranchCode]=h.BranchCode and [DocNo]=h.DocNo 
   and [PayDate]>=@datefrom and [PayDate]<=@dateto
  )

GO
/****** Object:  StoredProcedure [dbo].[Insert_WHTaxFromPC]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Insert_WHTaxFromPC] 
(
@docno varchar(20),
@formtype int,
@taxlawno varchar(2),
@userid varchar(20),
@inctype int,
@taxtype int=0
)
as 
begin
insert into Acc_WhTax
select AccDocNo,AccBatchDate,
b.CompanyTaxNo,b.CompanyName,b.CompanyAddress,
'' as TaxNo2,'' as TName2,'' as TAddress2,
substring(PartyTaxCode,1,13) as TaxNo3,
PartyName as TName3,PartyAddress as TAddress3,
'' as ID1,'' as ID2,'' as ID3,0 as SeqInForm,
@formtype as ftype,@taxlawno as tlawno,
0 as IncRate,'' as IncOther,
@userid as userid,a.TotalAmount,
a.TotalWht,
'' as SoLicNo,0 as SoLicAmt,0 as SoAccAmt,
'' as PayTaxNo,'' as SoTaxNo,
@taxtype as PType,'' as PTOther,
'' as CancelProve,'' as CancelReason,
NULL as CancelDate,GETDATE() as LastUpdate,
0 as TCAmt,
b.CompanyTaxBranch as Branch1,
'' as Branch2,
case when substring(PartyTaxCode,15,5)='' then '00000' else substring(PartyTaxCode,15,5) end as Branch3,
0 as IsCSV
from
vPC_H a,vProfileConfig b
where a.TotalWht>0 and a.AccDocNo=@docno 
and not exists(select 1 from Acc_WhTax where DocNo=a.AccDocNo)

insert into Acc_WHTaxDetail 
select * from (
select AccDocNo,
ROW_NUMBER() OVER(PARTITION BY AccDocNo ORDER BY AccDocNo,RateWht) as Itemno,
@inctype as inctype,AccBatchDate,amt,Wht,paytaxdesc,AccSourceDocNo,docreftype,docrefno,ratewht
from 
(
	select AccDocNo,	
	AccBatchDate,sum(TotalAmount) as Amt ,sum(WhtAmount) as Wht,
	(case when RateWht=1 then 'ค่าขนส่ง' else 'ค่าบริการ' end) as PayTaxDesc,
	AccSourceDocNo,0 as DocRefType,'' as DocRefNo,RateWht
	from vPC_D
	where RateWht>0 and AccDocNo=@docno 
	group by AccDocNo,RateWht,AccBatchDate,AccSourceDocNo
) d
) t
where not exists(select 1 from Acc_WHTaxDetail where DocNo=t.AccDocNo and Itemno=t.Itemno)

select * from Acc_WhTax where DocNo=@docno 
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_WHTaxFromTransaction]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[Insert_WHTaxFromTransaction]
(
@userid varchar(20),
@formtype int,
@taxlawno int,
@incometype int,
@incometext varchar(20),
@docno varchar(50),
@doctype int,
@taxtype int
)
as
begin
delete from Acc_WhTax where DocNo=@docno
delete from Acc_WhTaxDetail where DocNo=@docno

insert into Acc_WhTax
(
DocNo,
DocDate,
TaxNumber1,
TName1,
TAddress1,
TaxNumber2,
TName2,
TAddress2,
TaxNumber3,
TName3,
TAddress3,
IDCard1,
IDCard2,
IDCard3,
SeqInForm,
FormType,
TaxLawNo,
IncRate,
IncOther,
UpdateBy,
TotalPayAmount,
TotalPayTax,
SoLicenseNo,
SoLicenseAmount,
SoAccAmount,
PayeeAccNo,
SoTaxNo,
PayTaxType,
PayTaxOther,
CancelProve,
CancelReason,
CancelDate,
LastUpdate,
TeacherAmt,
Branch1,
Branch2,
Branch3,
IsCSV
)
select AccDocNo as DocNo,
AccBatchDate as DocDate,
(case when @doctype=3 then substring(PartyTaxCode,1,13) else CompanyTaxNo end) as TaxNumber1,
(case when @doctype=3 then PartyName  else CompanyName end) as TName1,
(case when @doctype=3 then PartyAddress  else CompanyAddress end) as TAddress1,
'' as TaxNumber2,
'' as TName2, 
'' as TAddress2,
(case when @doctype=3 then CompanyTaxNo else substring(PartyTaxCode,1,13) end) as TaxNumber3,
(case when @doctype=3 then CompanyName else PartyName end) as TName3,
(case when @doctype=3 then CompanyAddress else PartyAddress end) as TAddress3,
'' as IDCard1,
'' as IDCard2,
'' as IDCard3,
0 as SeqInForm,
@formtype as FormType,
@taxlawno as TaxLawNo,
0 as IncRate,
'' as IncOther,
'' as UpdateBy,
TotalTaxAmount as TotalPayAmount,
TotalWht as TotalPayTax,
'' as SoLicenseNo,
0 as SoLicenseAmount,
0 as SoAccAmount,
'' as PayeeAccNo,
'' as SoTaxNo,
@taxtype as PayTaxType,
'' as PayTaxOther,
'' as CancelProve,
'' as CancelReason,
'1900-01-01' as CancelDate,
GETDATE() as LastUpdate,
0 as TeacherAmt,
(case when @doctype=3 then substring(PartyTaxCode,15,10) else CompanyTaxBranch end) as Branch1,
'' as Branch2,
(case when @doctype=3 then CompanyTaxBranch else substring(PartyTaxCode,15,10) end) as Branch3,
0 as IsCSV
from vTransaction_H a,
vProfileconfig b
where AccDocNo=@docno

insert into Acc_WHTaxDetail(
DocNo,
ItemNo,
IncType,
PayDate,
PayAmount,
PayTax,
PayTaxDesc,
JNo,
DocRefType,
DocRefNo,
PayRate)
select 
DocNo as DocNo,
ROW_NUMBER() OVER(ORDER BY AccItemNo) as ItemNo,
@incometype as IncType,
h.AccBatchDate as PayDate,
d.TotalAmount as PayAmount,
d.WhtAmount as PayTax,
(case when @incometext='' then (case when d.DRateWht=1 then 'ค่าขนส่ง' else 'ค่าบริการ' end) else @incometext end) as PayTaxDesc,
'' as JNo,
'' as DocRefType,
d.AccSourceDocNo as DocRefNo,
d.DRateWht as PayRate
from vTransaction_D d inner join vTransaction_H h on d.DocNo=h.AccDocNo where h.AccDocNo=@docno

select a.* from Acc_WHTax a
inner join Acc_WHTaxDetail b on
a.DocNo=b.DocNo where a.DocNo=@docno
end

GO
/****** Object:  StoredProcedure [dbo].[Process_AdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Process_AdvanceToJournal]
(
	@datefrom date,
	@dateto date,
	@dtl as int=0
)
as
begin
select * into #tmp1 
from (
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCode,
	h.PaymentRef as RefNo,
	d.ForJno as SubAccname,
	sum(case when isnull(s.IsCredit,1)=0 then d.AdvAmount else d.AdvAmount+d.ChargeVAT-d.Charge50Tavi end) as Debit,0 as Credit,
	isnull(s.NameThai,d.SDescription) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a on 
	concat(a.AccMainName,'-',u.TName)=a.AccName	
	where h.DocStatus<>99 
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by a.AccCode,h.PaymentRef,d.ForJNo,isnull(s.NameThai,d.SDescription)
	union all
	select dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	h.PaymentRef as RefNo,
	d.AdvNo as SubAccname,
	sum(d.ChargeVAT) as Debit,0 as Credit,
	(case when u.VenCode is null then h.PayChqTo else u.TName end) as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_Vender u on d.VenCode=u.VenCode
	where h.DocStatus<>99 and isnull(s.IsCredit,1)=0 and d.ChargeVAT>0
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by h.PaymentRef,d.AdvNo,(case when u.VenCode is null then h.PayChqTo else u.TName end)
	union all
	select dbo.GetAccConfig('ADV_CONFIG','TaxCompany') as AccCode,
	h.PaymentRef as RefNo,
	d.AdvNo as SubAccname,
	0 as Debit,sum(d.Charge50Tavi) as Credit,
	case when u.VenCode is null then h.PayChqTo else u.TName end as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_Vender u on d.VenCode=u.VenCode
	where h.DocStatus<>99 and d.Charge50Tavi>0 and isnull(s.IsCredit,1)=0
	and (case when u.VenCode is null then h.PayChqTo else u.TName end) like '%จำกัด%'
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto	
	group by h.PaymentRef,d.AdvNo,u.VenCode,u.TName,h.PayChqTo
	union all
	select dbo.GetAccConfig('ADV_CONFIG','TaxPerson') as AccCode,
	h.PaymentRef as RefNo,
	d.AdvNo as SubAccname,
	0 as Debit,sum(d.Charge50Tavi) as Credit,
	case when u.VenCode is null then h.PayChqTo else u.TName end as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join [job_3x].dbo.Mas_Vender u on d.VenCode=u.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a on 
	concat(a.AccMainName,'-',u.TName)=a.AccName	
	where h.DocStatus<>99 and d.Charge50Tavi>0 and isnull(s.IsCredit,1)=0
	and (case when u.VenCode is null then h.PayChqTo else u.TName end) not like '%จำกัด%'
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto	
	group by h.PaymentRef,d.AdvNo,u.VenCode,u.TName,h.PayChqTo
	union all
	select isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCode
	,h.PaymentRef as RefNo,d.ForJno as SubAccname,
	0 as Debit,sum(d.AdvAmount+d.ChargeVAT-d.Charge50Tavi) as Credit,
	h.AdvNo as CustName
	from [job_3x].dbo.Job_AdvHeader h
	inner join [job_3x].dbo.Job_AdvDetail d on h.AdvNo=d.AdvNo 
	inner join [job_3x].dbo.Job_CashControl v on h.PaymentRef=v.ControlNo
	left join [job_3x].dbo.Mas_Company c on h.CustCode=c.CustCode and h.CustBranch=c.Branch
	left join [job_3x].dbo.Mas_User u 
	on v.RecUser=u.UserID
	left join [job_3x].dbo.Job_SrvSingle s on d.SICode=s.SICode 
	left join (
		select s.ControlNo,MAX(c.AccCode) as AccCode,MAX(b.BookName) as BookBranch
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		left join Mas_AccCode c on b.GLAccountCode=c.AccCode
		on s.BookCode=b.BookCode
		group by s.ControlNo
	) a on v.ControlNo=a.ControlNo
	where h.DocStatus<>99 
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
	group by isnull(a.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')),d.ForJNo,h.AdvNo,h.PaymentRef
) t 

if @dtl=0
begin
	select AccCode,AccName,sum(Debit) as Debit,sum(Credit) as Credit
	from (
		select RefNo,a.AccCode,b.AccName as AccName,SubAccname as AccDesc,
		sum(Debit) as Debit,sum(Credit) as Credit
		from #tmp1 a left join Mas_AccCode b on a.AccCode=b.AccCode
		group by RefNo,a.AccCode,SubAccName,b.AccName
	) t
	group by AccCode,AccName
end
else
begin
	select AccCode,AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit
	from (
		select RefNo,a.AccCode,b.AccName as AccName,SubAccname as AccDesc,
		sum(Debit) as Debit,sum(Credit) as Credit
		from #tmp1 a left join Mas_AccCode b on a.AccCode=b.AccCode
		group by RefNo,a.AccCode,SubAccName,b.AccName
	) t
	group by AccCode,AccName,AccDesc
end
drop table #tmp1 
end
GO
/****** Object:  StoredProcedure [dbo].[Process_BillPayToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Process_BillPayToJournal]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin

select * into #tmp2 from (
select CONCAT('PI-',h.DocNo) as DocNo,
h.DocDate,concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')) as VenderName,h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo as JNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeC,
(case when s.IsCredit=1 then
isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
else 
isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
end) as AccCodeD,
sum(case when isnull(s.IsCredit,1)=1 then d.Total+d.AmtWHT else d.Amt end) as Amt,
sum(case when isnull(s.IsCredit,1)=1 then 0 else d.AmtVAT end) as AmtVAT
from [job_3x].dbo.Job_PaymentHeader h
inner join [job_3x].dbo.Job_PaymentDetail d
on h.DocNo=d.DocNo 
left join [job_3x].dbo.Job_Order j on d.ForJNo=j.JNo 
left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
left join [job_3x].dbo.Job_SrvSingle s on d.SIcode=s.SICode
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
left join [job_3x].dbo.Mas_Vender v
on h.VenCode=v.VenCode 
left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') b 
on concat(b.AccMainName,'-',v.TName)=b.AccName
left join [job_3x].dbo.Job_SrvGroup g on s.GroupCode=g.GroupCode
where isnull(h.CancelProve,'')='' --and h.ApproveBy<>''
and h.DocDate>=@datefrom and h.DocDate<=@dateto
group by  h.DocNo,h.DocDate,isnull(v.TName,''),isnull(v.TaxNumber,''),h.EmpCode,h.PoNo,h.ReFNo,d.SDescription,d.ForJNo,
isnull(b.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')),s.IsCredit
,isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueExpense'))
,isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess'))
) t

if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from 
(
select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,SDescription as AccName,
Sum(Amt+AmtVat) as Debit,0 as Credit
from #tmp2
group by DocNo,AccCodeD,SDescription,JNo
union all
select DocNo,2 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,VenderName as AccName,
0 as Debit,sum(Amt+AmtVAT) as Credit
from #tmp2
group by DocNo,AccCodeC,VenderName,JNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
end
else
begin
select AccCode,GLName as AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from 
(
select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,SDescription as AccName,
Sum(Amt+AmtVat) as Debit,0 as Credit
from #tmp2
group by DocNo,AccCodeD,SDescription,JNo
union all
select DocNo,2 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,VenderName as AccName,
0 as Debit,sum(Amt+AmtVAT) as Credit
from #tmp2
group by DocNo,AccCodeC,VenderName,JNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,AccDesc
end

drop table #tmp2;
end


GO
/****** Object:  StoredProcedure [dbo].[Process_ClearExpenseFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Process_ClearExpenseFromAdvance]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin
select t.* into #tmp1 
from ( 
	select ad.AdvNo,ad.ItemNo,d.JobNo,h.ClrNo,h.ClrDate,ah.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,ad.ForJNo,
	(case when s.IsCredit=1 then 
	 isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkinProcess')) 
	 else 
	 isnull(a2.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultCost')) 
	 end) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeCredit,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.UsedAmount else (d.UsedAmount+d.ChargeVAT-d.Tax50Tavi) end)) as Amount,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end)) as AmountVat,
	convert(decimal(18,2),(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end)) as AmountWht,
	convert(decimal(18,2),(d.UsedAmount+d.ChargeVAT-d.Tax50Tavi)) as AmountNet,
	(case when d.VenderCode='' and ad.VenCode<>'' then ad.VenCode else d.VenderCode end) as VenCode,
	v.TaxNumber,v.TName,
	isnull(u.TName,ah.EmpCode) as UserName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_AdvDetail ad
	on d.AdvNO=ad.AdvNo and d.AdvItemNo=ad.ItemNo 
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	inner join [job_3x].dbo.Job_AdvHeader ah
	on ad.AdvNo=ah.AdvNO 
	left join [job_3x].dbo.Mas_Company c
	on ah.CustCode=c.CustCode and ah.CustBranch=c.Branch
	left join [job_3x].dbo.Job_Order j
	on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company b
	on j.CustCode=b.CustCode and j.CustBranch=b.Branch
	left join [job_3x].dbo.Mas_User u 
	on ah.EmpCode=u.UserID 
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',b.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
	on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a3 
	on concat(a3.AccMainName,'-',u.TName)=a3.AccName	
	left join [job_3x].dbo.Mas_Vender v on d.VenderCode=v.VenCode
	where h.DocStatus<>99
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 	
) t 

if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from 
(
	select concat('AJ-A',a.ClrNo) as JVNo,
	a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
	sum(Amount) as Debit,0 as Credit
	from #tmp1 a 
	group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
	union all
	select concat('AJ-A',a.ClrNo) as JVNo,
	a.AccCodeCredit as AccCode,a.UserName as AccName,a.ForJNo as AccDesc,
	0 as Debit,sum(Amount) as Credit
	from #tmp1 a
	group by a.ClrNo,a.AccCodeCredit,a.UserName,a.ForJNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
end
else
begin
select AccCode,GLName as AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from 
(
	select concat('AJ-A',a.ClrNo) as JVNo,
	a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
	sum(Amount) as Debit,0 as Credit
	from #tmp1 a 
	group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
	union all
	select concat('AJ-A',a.ClrNo) as JVNo,
	a.AccCodeCredit as AccCode,a.UserName as AccName,a.ForJNo as AccDesc,
	0 as Debit,sum(Amount) as Credit
	from #tmp1 a
	group by a.ClrNo,a.AccCodeCredit,a.UserName,a.ForJNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,AccDesc
end
drop table #tmp1 
end
GO
/****** Object:  StoredProcedure [dbo].[Process_ClearExpenseFromManualEntry]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[Process_ClearExpenseFromManualEntry]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin
select t.* into #tmp1 
from ( 
	select isnull(v.TaxNumber,'') as TaxNumnber,isnull(v.TName,d.Pay50TaviTo) as TName,
	d.ClrNo,d.ItemNo,d.JobNo,h.ClrDate,h.EmpCode as AdvBy,
	h.TRemark,h.CTN_NO,h.EmpCode as ClrBy,d.SIcode,d.SDescription,
	isnull((case when s.IsCredit=1 then isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) 
	else isnull(a2.AccCode,s.GLAccountCodeSales) end),
	dbo.GetAccConfig('GL_CONFIG','DefaultCost')) as AccCodeDebit ,
	isnull(a3.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeCredit,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.UsedAmount end) as Amount,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.ChargeVAT else 0 end) as AmountVat,
	(case when s.IsCredit=0 and s.IsExpense=1 then d.Tax50Tavi else 0 end) as AmountWht,
	(case when s.IsCredit=1 then d.UsedAmount+d.ChargeVAT else d.BNet end) as AmountNet,
	isnull(d.VenderCode,j.ForwarderCode) as VenCode,d.Pay50TaviTo as VenderName
	from [job_3x].dbo.Job_ClearDetail d
	inner join [job_3x].dbo.Job_ClearHeader h 
	on d.ClrNo=h.ClrNo 
	left join [job_3x].dbo.Mas_User u on h.EmpCode=u.UserID
	inner join [job_3x].dbo.Job_SrvSingle s on 
	d.SICode=s.SIcode 
	inner join [job_3x].dbo.Job_Order j on d.JobNo=j.JNo 
	left join [job_3x].dbo.Mas_Company c on j.Custcode=c.CustCode and j.CustBranch=c.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
	on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
	left join (select * from vMas_AccCode where AccCode like '5___-__-____') a2 
	on concat(a2.AccMainName,'-',s.NameThai)=a2.AccName	
	left join [job_3x].dbo.Mas_Vender v on isnull(d.VenderCode,j.ForwarderCode)=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') a3 
	on concat(a3.AccMainName,'-',v.TName)=a3.AccName	
	where h.DocStatus<>99 and d.AdvNO='' and d.VenderBillingNo=''
	and not (s.IsCredit=0 and s.IsExpense=0) and d.BNet>0
	and h.ClrDate>=@datefrom and h.ClrDate<=@dateto 		
) t 
if @dtl=0
begin
select dt.* from (
	select t.AccCode,ac.AccName,sum(Debit) as Debit,sum(Credit) as Credit from
	(
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,concat(TName,'-',SDescription) as AccName,a.JobNo as AccDesc,0 as Debit,
		sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.TName,a.SDescription,a.JobNo
	) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
	group by t.AccCode,ac.AccName
) dt 
end
else
begin
select dt.* from (
	select t.AccCode,ac.AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit from
	(
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeDebit as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(Amount) as Debit,0 as Credit
		from #tmp1 a 
		group by a.ClrNo,a.AccCodeDebit,a.SDescription,a.JobNo 
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		p.AccCode as AccCode,a.SDescription as AccName,a.JobNo as AccDesc,
		sum(AmountVat) as Debit,0 as Credit
		from #tmp1 a,Mas_AccCode p 
		where a.AmountVat>0 and p.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')
		group by a.ClrNo,p.AccCode,a.SDescription,a.JobNo
		union all
		select concat('AJ-C',a.ClrNo) as JVNo,
		a.AccCodeCredit as AccCode,concat(TName,'-',SDescription) as AccName,a.JobNo as AccDesc,0 as Debit,
		sum(Amount+AmountVat) as Credit
		from #tmp1 a
		group by a.ClrNo,a.AccCodeCredit,a.TName,a.SDescription,a.JobNo
	) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
	group by t.AccCode,ac.AccName,t.AccDesc
) dt 
end
drop table #tmp1;
end


GO
/****** Object:  StoredProcedure [dbo].[Process_ClearMoneyFromAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[Process_ClearMoneyFromAdvance]
(
@datefrom date,
@dateto date,
@dtl int=0
)
as
begin
select * into #tmp1
from ( 
	select v.ControlNo,v.VoucherDate,v.RecUser,u.UserID,v.TRemark,a.AdvNo,a.ItemNo,s.PRVoucher,
	isnull(a1.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashOut')) as AccCodeBook,b.BookName,a.AdvNet,c.ClrNet,
	round(cast(a.AdvNet-isnull(c.ClrNet,0) as decimal(10,4)),2) as TotalUsed,
	isnull(a2.AccCode,dbo.GetAccConfig('ADV_CONFIG','CashIn')) as AccCodeUser,u.TName as UserName,a.ForJno as JNo
	from 
	[job_3x].dbo.Job_CashControl v inner join 
	(
		select ControlNo,DocNo,acType,sum(PaidAmount) as PaidAmount 
		from [job_3x].dbo.Job_CashControlDoc 
		where DocType='CLR' and PaidAmount<>0
		group by ControlNo,DocNo,acType
	) d on v.ControlNo=d.ControlNo
	inner join [job_3x].dbo.Job_CashControlSub s on
	d.ControlNo=s.ControlNo and d.acType=s.acType
	inner join [job_3x].dbo.Job_AdvDetail a
	on d.DocNo=concat(a.AdvNo,'#',a.ItemNo)
	left join 
	(select cd.AdvNo,ah.CustCode,ah.CustBranch,ah.EmpCode as AdvBy,cd.AdvItemNo,sum(cd.BNet) as ClrNet
	 from [job_3x].dbo.Job_ClearDetail cd
	 inner join [job_3x].dbo.Job_ClearHeader ch  
	 on cd.ClrNo=ch.ClrNo  
	 inner join [job_3x].dbo.Job_AdvHeader ah 
	 on cd.AdvNo=ah.AdvNo	 
	 where ch.DocStatus<>99 
	 and cd.AdvNO<>''
	 group by cd.AdvNo,ah.CustCode,ah.CustBranch,ah.EmpCode,cd.AdvItemNo 
	) c on a.AdvNo=c.AdvNO and a.ItemNo=c.AdvItemNo
	inner join [job_3x].dbo.Mas_BookAccount b on s.BookCode=b.BookCode
	left join [job_3x].dbo.Mas_User u on c.AdvBy=u.UserID 
	left join [job_3x].dbo.Mas_Company cu on c.Custcode=cu.custcode and c.CustBranch=cu.Branch
	left join Mas_AccCode a1 on b.GLAccountCode=a1.AccCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('ADV_CONFIG','CashIn')+'-____') a2 
	on concat(a2.AccMainName,'-',u.TName)=a2.AccName	
	where isnull(v.CancelProve,'')='' 
	and v.VoucherDate>=@datefrom and v.VoucherDate<=@dateto
) tb


if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select ControlNo,AccCode,AccName,AccDesc,
	(case when sum(Debit)>sum(Credit) then sum(Debit)-sum(Credit) else 0 end) as Debit,
	(case when sum(Debit)>sum(Credit) then 0 else sum(Credit)-sum(Debit) end) as Credit 
	from (
		select ControlNo,JNo as AccDesc,
		AccCodeBook as AccCode,AdvNo as AccName,TotalUsed as Debit,0 as Credit
		from #tmp1
		where TotalUsed>0
		union all
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,UserName as AccName,0 as Debit,TotalUsed as Credit
		from #tmp1
		where TotalUsed>0
		union all
		select ControlNo,JNo as AccDesc,
		AccCodeBook as AccCode,AdvNo as AccName,0 as Debit,ABS(TotalUsed) as Credit
		from #tmp1
		where TotalUsed<0
		union all
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,UserName as AccName,ABS(TotalUsed) as Debit,0 as Credit
		from #tmp1
		where TotalUsed<0
	) tbl
	group by ControlNo,AccCode,AccName,AccDesc
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
order by AccCode
end
else
begin
select AccCode,GLName as AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select ControlNo,AccCode,AccName,AccDesc,
	(case when sum(Debit)>sum(Credit) then sum(Debit)-sum(Credit) else 0 end) as Debit,
	(case when sum(Debit)>sum(Credit) then 0 else sum(Credit)-sum(Debit) end) as Credit 
	from (
		select ControlNo,JNo as AccDesc,
		AccCodeBook as AccCode,AdvNo as AccName,TotalUsed as Debit,0 as Credit
		from #tmp1
		where TotalUsed>0
		union all
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,UserName as AccName,0 as Debit,TotalUsed as Credit
		from #tmp1
		where TotalUsed>0
		union all
		select ControlNo,JNo as AccDesc,
		AccCodeBook as AccCode,AdvNo as AccName,0 as Debit,ABS(TotalUsed) as Credit
		from #tmp1
		where TotalUsed<0
		union all
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,UserName as AccName,ABS(TotalUsed) as Debit,0 as Credit
		from #tmp1
		where TotalUsed<0
	) tbl
	group by ControlNo,AccCode,AccName,AccDesc
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,AccDesc
order by AccCode
end

drop table #tmp1
end

GO
/****** Object:  StoredProcedure [dbo].[Process_ClearMoneyFromNoAdvance]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
























CREATE procedure [dbo].[Process_ClearMoneyFromNoAdvance]
(
@datefrom date,
@dateto date,
@dtl int=0
)
as
begin

select tb.* into #tmp1
from ( 
	select h.ControlNo,h.VoucherDate,h.RecUser,h.TRemark,
	isnull(ac.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')) as AccCodeBook,b.BookName,
	a.VenderCode,c.EmpCode,c.ClrNo,a.Pay50TaviTo,s.PRVoucher,a.SlipNO,
	isnull(a3.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeUser,u.TName as UserName,
	a.SICode,a.SDescription,i.IsCredit,
	(case when i.IsCredit=1 then a.UsedAmount+a.ChargeVAT else a.UsedAmount end) as UsedAmount,
	(case when i.IsCredit=1 then 0 else a.ChargeVAT end) as ChargeVAT,
	(case when i.IsCredit=1 then 0 else a.Tax50Tavi end) as Tax50Tavi,
	(case when i.IsCredit=1 then a.UsedAmount+a.ChargeVAT else a.BNet end) as TotalUsed,
	d.PaidAmount*-1 as PaidAmount,
	a.JobNo as JNo,s.PRType	
	from 
	[job_3x].dbo.Job_CashControl h inner join 
		(
		select ControlNo,DocNo,acType,sum(PaidAmount) as PaidAmount 
		from [job_3x].dbo.Job_CashControlDoc 
		where DocType='CLR' and PaidAmount<>0
		group by ControlNo,DocNo,acType
	) d on h.ControlNo=d.ControlNo
	inner join [job_3x].dbo.Job_CashControlSub s on
	d.ControlNo=s.ControlNo and d.acType=s.acType
	inner join [job_3x].dbo.Job_ClearDetail a
	on d.DocNo=concat(a.ClrNo,'#',a.ItemNo)
	inner join [job_3x].dbo.Job_Order j on a.JobNo=j.JNo 
	inner join [job_3x].dbo.Job_ClearHeader c 
	on a.ClrNo=c.ClrNo 
	left join [job_3x].dbo.Mas_User u on c.EmpCode=u.UserID
	left join [job_3x].dbo.Job_SrvSingle i on a.SIcode=i.SICode 
	left join [job_3x].dbo.Mas_BookAccount b on s.BookCode=b.BookCode
	left join dbo.Mas_AccCode ad on u.GLAccountCode=ad.AccCode
	left join dbo.Mas_AccCode ac on b.GLAccountCode=ac.AccCode
	left join [job_3x].dbo.Mas_Vender v on isnull(a.VenderCode,j.ForwarderCode)=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') a3 
	on concat(a3.AccMainName,'-',v.TName)=a3.AccName	
	where isnull(h.CancelProve,'')='' and isnull(a.VenderBillingNo,'')=''
	and isnull(a.AdvNO,'')=''
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto	
) tb 


if @dtl=0
begin
select AccCode,AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
	select ControlNo,t.AccCode,ac.AccName,AccDesc,
	(case when sum(Debit)>sum(Credit) then sum(Debit)-sum(Credit) else 0 end) as Debit,
	(case when sum(Debit)>sum(Credit) then 0 else sum(Credit)-sum(Debit) end) as Credit 
	from (
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,
		SDescription as AccName,
		sum(TotalUsed+Tax50Tavi) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
		) db
		group by ControlNo,JNo,AccCodeUser,SDescription
		union all
		select ControlNo,JNo,
		AccCodeBook as AccCode,
		UserName as AccName,
		0 as Debit,
		sum(TotalUsed) as Credit
		from (
			select *
			from #tmp1
		) cd
		group by ControlNo,JNo,AccCodeBook,UserName
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('WHT_CONFIG','TaxCompany') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(Tax50Tavi) as Credit
		from (
			select *
			from #tmp1
			where Tax50Tavi>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(ChargeVAT) as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	    Pay50TaviTo as AccName,
		sum(ChargeVAT) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
	) t  left join Mas_AccCode ac on t.AccCode=ac.AccCode
	group by ControlNo,t.AccCode,ac.AccName,AccDesc
) dt
group by AccCode,AccName
order by AccCode
end 
else
begin
select AccCode,AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
	select ControlNo,t.AccCode,ac.AccName,AccDesc,
	(case when sum(Debit)>sum(Credit) then sum(Debit)-sum(Credit) else 0 end) as Debit,
	(case when sum(Debit)>sum(Credit) then 0 else sum(Credit)-sum(Debit) end) as Credit 
	from (
		select ControlNo,JNo as AccDesc,
		AccCodeUser as AccCode,
		SDescription as AccName,
		sum(TotalUsed+Tax50Tavi) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
		) db
		group by ControlNo,JNo,AccCodeUser,SDescription
		union all
		select ControlNo,JNo,
		AccCodeBook as AccCode,
		UserName as AccName,
		0 as Debit,
		sum(TotalUsed) as Credit
		from (
			select *
			from #tmp1
		) cd
		group by ControlNo,JNo,AccCodeBook,UserName
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('WHT_CONFIG','TaxCompany') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(Tax50Tavi) as Credit
		from (
			select *
			from #tmp1
			where Tax50Tavi>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','UndueInputVat') as AccCode,
	    Pay50TaviTo as AccName,
		0 as Debit,
		sum(ChargeVAT) as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
		union all
		select ControlNo,JNo,
		dbo.GetAccConfig('VAT_CONFIG','InputVat') as AccCode,
	    Pay50TaviTo as AccName,
		sum(ChargeVAT) as Debit,
		0 as Credit
		from (
			select *
			from #tmp1
			where ChargeVAT>0
		) cd
		group by ControlNo,JNo,Pay50TaviTo
	) t  left join Mas_AccCode ac on t.AccCode=ac.AccCode
	group by ControlNo,t.AccCode,ac.AccName,AccDesc
) dt
group by AccCode,AccName,AccDesc
order by AccCode
end 

drop table #tmp1
end


GO
/****** Object:  StoredProcedure [dbo].[Process_CNDNToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




















CREATE procedure [dbo].[Process_CNDNToJournal]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as 
begin
select * into #tmp1 from (
select a.DocNo,a.DocDate,a.ApproveDate,a.Remark,c.NameThai as CustName,a.EmpCode,
d.RefNo as ReFNo,
d.DocDate as BillDate,
(case when e.IsCredit=1 then isnull(a1.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) 
else 
isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) end) as AccCode1,
(case when e.IsCredit=1 then 
isnull(av.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) else 
isnull(ar.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) end) as AccCode2,
b.OriginalAmt,b.CorrectAmt,
b.CorrectAmt-b.OriginalAmt as Amt,b.VATAmt as AmtVat,ABS(b.DiffAmt)+ABS(b.VATAmt) as AmtTotal,f.ReceiptNo,
f.Amt as ReceiveAmt,f.AmtVAT as ReceiveVat,b.BillingNo,
b.SDescription
from 
[job_3x].dbo.Job_CNDNHeader a
inner join [job_3x].dbo.Job_CNDNDetail b 
on a.DocNo=b.DocNo 
inner join [job_3x].dbo.Job_InvoiceHeader d 
on b.BillingNo=d.DocNo 
left join [job_3x].dbo.Mas_Company c 
on concat(isnull(d.BillToCustCode,d.CustCode),isnull(d.BillToCustBranch,d.CustBranch))=concat(c.CustCode,c.Branch)
inner join [job_3x].dbo.Job_SrvSingle e on b.SIcode=e.SICode 
left join (select * from vMas_AccCode where AccCode like 
dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') a1 
on concat(a1.AccMainName,'-',c.NameThai)=a1.AccName	
left join (select * from vMas_AccCode where AccCode like 
'4___-__-____') a3 
on concat(a3.AccMainName,'-',e.NameThai)=a3.AccName	
left join (select * from vMas_AccCode where AccCode like 
dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ar 
on concat(ar.AccMainName,'-',c.NameThai)=ar.AccName	
left join (select * from vMas_AccCode where AccCode like 
dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') av 
on concat(av.AccMainName,'-',c.NameThai)=av.AccName	
left join [job_3x].dbo.Job_ReceiptDetail f on 
b.BillingNo=f.InvoiceNo and b.BillItemNo=f.InvoiceItemNo
where a.DocStatus<>99 
and a.DocDate>=@datefrom and a.DocDate<=@dateto 
) tb

if @dtl=0 
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,AccCode1 as AccCode,SDescription as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit	
	from #tmp1 where Amt>0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,AccCode1 as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,sum(ABS(AmtVat)) as Credit
	from #tmp1 where AmtVat<0 And Amt>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0 And Amt<0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1 where Amt>0
	group by DocNo,AccCode2,BillingNo,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	sum(ABS(Amt)) as Debit,0 as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode2,BillingNo,RefNo 
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
order by AccCode
end
else
begin
select AccCode,GLName as AccName,SubAccName as AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,AccCode1 as AccCode,SDescription as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit	
	from #tmp1 where Amt>0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,AccCode1 as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode1,SDescription,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	0 as Debit,sum(ABS(AmtVat)) as Credit
	from #tmp1 where AmtVat<0 And Amt>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,CustName,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0 And Amt<0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1 where Amt>0
	group by DocNo,AccCode2,BillingNo,RefNo
	union all
	select DocNo,AccCode2 as AccCode,BillingNo,RefNo as SubAccName,
	sum(ABS(Amt)) as Debit,0 as Credit
	from #tmp1 where Amt<0
	group by DocNo,AccCode2,BillingNo,RefNo 
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,SubAccName
order by AccCode
end

drop table #tmp1 
end

GO
/****** Object:  StoredProcedure [dbo].[Process_CustAdvanceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Process_CustAdvanceToJournal]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin
select * into #tmp1 from (
select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','ChequeIn')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.CustCode,a.CustBranch)=concat(cb.CustCode,cb.Branch)
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product p on b.SICode=p.ProductCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','ChequeIn')+'-____') ac 
	on concat(ac.AccMainName,'-',cb.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ab 
	on concat(ab.AccMainName,'-',c.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 and b.AmtCredit>0
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','ChequeIn')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.CustCode,a.CustBranch)=concat(cb.CustCode,cb.Branch)
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','ChequeIn')+'-____') ac 
	on concat(ac.AccMainName,'-',cb.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',c.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 and b.AmtCredit>0
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,CustName,AccCodeD as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(TotalCustAdv) as Credit
	from #tmp1 where TotalCustAdv>0
	group by AccCodeD,DocNo,SDescription,RefNo,CustName
	union all
	select DocNo,CustName,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	sum(TotalCustAdv) as Debit,0 as Credit
	from #tmp1 where TotalCustAdv>0
	group by AccCodeC,DocNo,SDescription,RefNo,CustName
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
order by AccCode
end
else
begin
select AccCode,GLName as AccName,SubAccName as AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,CustName,AccCodeD as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(TotalCustAdv) as Credit
	from #tmp1 where TotalCustAdv>0
	group by AccCodeD,DocNo,SDescription,RefNo,CustName
	union all
	select DocNo,CustName,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	sum(TotalCustAdv) as Debit,0 as Credit
	from #tmp1 where TotalCustAdv>0
	group by AccCodeC,DocNo,SDescription,RefNo,CustName
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,SubAccName
order by AccCode
end
drop table #tmp1;
end


GO
/****** Object:  StoredProcedure [dbo].[Process_InvoiceToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[Process_InvoiceToJournal]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin
select * into #tmp1 from (
	select 0 as RowType,a.DocNo,a.ReFNo,a.Docdate,isnull(a.DueDate,a.DocDate) as DueDate,
	c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','DefaultSale')) as AccCodeC,b.Amt,b.AmtVat,b.Amt+b.AmtVat as AmtTotal,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.CustCode,a.CustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(cb.CustCode,cb.Branch)
	left join dbo.Mas_AccCode ad on c.GLAccountCode=ad.AccCode
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join dbo.vMas_Product p on b.SICode=p.ProductCode
	left join (select * from vMas_AccCode where AccCode like '4___-__-____') ac 
	on concat(ac.AccMainName,'-',d.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ab 
	on concat(ab.AccMainName,'-',cb.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtCharge>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
	union all
	select 1 as RowType,a.DocNo,a.RefNo,a.Docdate,isnull(a.DueDate,a.DocDate),c.TaxNumber,isnull(c.NameThai,a.BillToCustCode) as CustName,c.CustCode,
	a.EmpCode,b.SIcode,b.SDescription,
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) as AccCodeD,
	isnull(ac.AccCode,dbo.GetAccConfig('GL_CONFIG','WorkInProcess')) as AccCodeC,b.Amt+b.AmtVat as Amt,0 as AmtVat,b.Amt+b.AmtVat as AmtNet,
	b.AmtCredit as TotalCustAdv
	from [job_3x].dbo.Job_InvoiceHeader a 
	inner join [job_3x].dbo.Job_InvoiceDetail b 
	on a.DocNo=b.DocNo 
	left join [job_3x].dbo.Mas_Company c
	on concat(a.CustCode,a.CustBranch)=concat(c.CustCode,c.Branch)
	left join [job_3x].dbo.Mas_Company cb
	on concat(a.BillToCustCode,a.BillToCustBranch)=concat(cb.CustCode,cb.Branch)
	left join [job_3x].dbo.Job_SrvSingle d 
	on b.SICode=d.SICode 
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','WorkInProcess')+'-____') ac 
	on concat(ac.AccMainName,'-',c.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',cb.NameThai)=ab.AccName	
	where not isnull(a.CancelProve,'')<>'' 
	and b.AmtAdvance>0 
	and a.DocDate>=@datefrom and a.DocDate<=@dateto
) tb 

if @dtl=0 
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,AccCodeD as AccCode,DocNo as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,DocNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
end
else
begin
select AccCode,GLName as AccName,SubAccName as AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,AccCodeD as AccCode,DocNo as CustName,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,DocNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName,RefNo
	union all
	select DocNo,AccCodeC as AccCode,SDescription,RefNo as SubAccName,
	0 as Debit,sum(Amt) as Credit
	from #tmp1
	group by DocNo,AccCodeC,SDescription,RefNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,SubAccName
end

drop table #tmp1;
end



GO
/****** Object:  StoredProcedure [dbo].[Process_PVFromBillPay]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO















create procedure [dbo].[Process_PVFromBillPay]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin

select * into #tmp1 from (
	select a.DocNo as RefNo,h.ControlNo as DocNo,h.VoucherDate as DocDate,
	concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')) as VenderName,h.RecUser as EmpCode,h.TRemark,b.ForJNo as JNo,
	isnull(c.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')) as AccCodeC,
	isnull(av.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')) as AccCodeD,
	sum(b.Total) as Totalpay,
	sum(case when s.IsCredit=1 then 0 else b.AmtWHT end) as WhdAmt,
	sum(case when s.IsCredit=1 then 0 else b.AmtVAT end) as TotalVat,
	sum(b.Total) as TotalNet
	from [job_3x].dbo.Job_PaymentHeader a
	inner join [job_3x].dbo.Job_PaymentDetail b
	on a.DocNo=b.DocNo 	
	left join [job_3x].dbo.Job_SrvSingle s on b.SICode=s.SICode
	left join (
		select s.ControlNo,MAX(c.AccCode) as AccCode
		from [job_3x].dbo.Job_CashControlSub s
		inner join [job_3x].dbo.Mas_BookAccount b
		on s.BookCode=b.BookCode
		left join Mas_AccCode c on b.GLAccountCode=c.AccCode
		group by s.ControlNo
	) c on a.PaymentRef=c.ControlNo
	left join [job_3x].dbo.Mas_Vender v on a.VenCode=v.VenCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AP_CONFIG','Purchase')+'-____') av 
	on concat(av.AccMainName,'-',v.TName)=av.AccName
	left join [job_3x].dbo.Job_CashControlDoc d on a.DocNo=d.DocNo and a.PaymentRef=d.ControlNo 
	left join [job_3x].dbo.Job_CashControl h on d.ControlNo=h.ControlNo and isnull(h.CancelProve,'')=''
	where a.PaymentRef<>''
	and a.PaymentDate>=@datefrom and a.PaymentDate<=@dateto
	group by isnull(c.AccCode,dbo.GetAccConfig('AP_CONFIG','CashOut')),
	isnull(av.AccCode,dbo.GetAccConfig('AP_CONFIG','Purchase')),
	a.DocNo,h.ControlNo,h.VoucherDate,concat(isnull(v.TaxNumber,''),'-',isnull(v.TName,'')),h.RecUser,h.TRemark,b.ForJNo
) t

if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from 
(
	select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,VenderName as AccName,
	sum(TotalNet+WhdAmt) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,VenderName,JNo
	union all 
	select DocNo,1 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,DocNo as AccName,
	0 as Debit,sum(TotalNet) as Credit
	from #tmp1
	group by DocNo,AccCodeC,DocNo,JNo
    union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp1,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
	and VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp1,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
	and NOT VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,3 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(TotalVat) as Credit
	from #tmp1,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')	
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,4 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	sum(TotalVat) as Debit,0 as Credit
	from #tmp1,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')	
	group by DocNo,AccCode,VenderName,JNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
end
else
begin
select AccCode,GLName as AccName,AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from 
(
	select DocNo,0 as ItemNo,AccCodeD as AccCode,JNo as AccDesc,VenderName as AccName,
	sum(TotalNet+WhdAmt) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,VenderName,JNo
	union all 
	select DocNo,1 as ItemNo,AccCodeC as AccCode,JNo as AccDesc,DocNo as AccName,
	0 as Debit,sum(TotalNet) as Credit
	from #tmp1
	group by DocNo,AccCodeC,DocNo,JNo
    union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp1,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany')
	and VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,2 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(WhdAmt) as Credit
	from #tmp1,Mas_AccCode a
	where WhdAmt>0 and a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxPerson')
	and NOT VenderName like '0%'
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,3 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	0 as Debit,sum(TotalVat) as Credit
	from #tmp1,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','UndueInputVat')	
	group by DocNo,AccCode,VenderName,JNo
	union all 
	select DocNo,4 as ItemNo,AccCode as AccCode,JNo as AccDesc,VenderName as AccName,
	sum(TotalVat) as Debit,0 as Credit
	from #tmp1,Mas_AccCode a
	where TotalVat>0 and a.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat')	
	group by DocNo,AccCode,VenderName,JNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,AccDesc
end 
drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[Process_ReceiptToJournal]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Process_ReceiptToJournal]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin
select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,b.ReceiptDate as DocDate,c.PRVoucher as VoucherNo,
	isnull(h.VoucherDate,isnull(i.DueDate,i.DocDate)) as VoucherDate,
	a.Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVat,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi, 
	a.Amt+a.AmtVAT as AmtTotal,
	(case when d.AmtAdvance>0 then 
	isnull(ab.AccCode,dbo.GetAccConfig('AR_CONFIG','Advance')) else 
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','Sales')) end) as AccCodeC,
	isnull(ad.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueIncome')) as AccCodeD,a.InvoiceNo,
	f.NameThai as CustName,b.EmpCode ,d.SDescription
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	left join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i 
	on d.DocNo=i.DocNo 
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Advance')+'-____') ab 
	on concat(ab.AccMainName,'-',f.NameThai)=ab.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','Sales')+'-____') ac 
	on concat(ac.AccMainName,'-',f.NameThai)=ac.AccName	
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueIncome')+'-____') ad 
	on concat(ad.AccMainName,'-',f.NameThai)=ad.AccName	
	left join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and b.ReceiptDate>=@datefrom and b.ReceiptDate<=@dateto
) tb

if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,AccCodeD as AccCode,CustName,DocNo as SubAccName,
	sum(AmtTotal-Amt50Tavi) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,CustName
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,DocNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName
	union all
	select DocNo,AccCodeC as AccCode,InvoiceNo,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1
	group by DocNo,AccCodeC,InvoiceNo,RefNo
	union all
	select DocNo,p.AccCode as AccCode,CustName,DocNo as SubAccName,
	sum(Amt50Tavi) as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	group by DocNo,p.AccCode,CustName
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
order by AccCode 
end
else
begin
select AccCode,GLName as AccName,SubAccName as AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select DocNo,AccCodeD as AccCode,CustName,DocNo as SubAccName,
	sum(AmtTotal-Amt50Tavi) as Debit,0 as Credit
	from #tmp1
	group by DocNo,AccCodeD,CustName
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','UndueOutputVat') as AccCode,
	InvoiceNo,RefNo as SubAccName,
	sum(AmtVat) as Debit,0 as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,InvoiceNo,RefNo
	union all
	select DocNo,dbo.GetAccConfig('VAT_CONFIG','OutputVat') as AccCode,
	CustName,DocNo as SubAccName,
	0 as Debit,sum(AmtVat) as Credit
	from #tmp1 where AmtVat>0
	group by DocNo,CustName
	union all
	select DocNo,AccCodeC as AccCode,InvoiceNo,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1
	group by DocNo,AccCodeC,InvoiceNo,RefNo
	union all
	select DocNo,p.AccCode as AccCode,CustName,DocNo as SubAccName,
	sum(Amt50Tavi) as Debit,0 as Credit
	from #tmp1,vMas_AccCode p  
	where Amt50Tavi>0
	and p.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax')
	group by DocNo,p.AccCode,CustName
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,SubAccName
order by AccCode
end

drop table #tmp1
end


GO
/****** Object:  StoredProcedure [dbo].[Process_RVFromJob]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






create procedure [dbo].[Process_RVFromJob]
(
	@datefrom date,
	@dateto date,
	@dtl int=0
)
as
begin
select * into #tmp1 from (
	select b.ReceiptNo as DocNo,i.RefNo as RefNo,
	b.ReceiptDate as DocDate,h.ControlNo as VoucherNo,h.VoucherDate,
	(case when d.AmtAdvance>0 then a.Amt+a.AmtVAT else a.Amt end) as Amt,
	(case when d.AmtAdvance>0 then 0 else a.AmtVAT end) as AmtVAT,
	(case when d.AmtAdvance>0 then 0 else a.Amt50Tavi end) as Amt50Tavi,
	(a.Net) as AmtTotal,
	isnull(a3.AccCode,dbo.GetAccConfig('GL_CONFIG','AccrueIncome')) as AccCodeC,
	isnull(a4.AccCode,dbo.GetAccConfig('AR_CONFIG','CashIn')) as AccCodeD,
	f.NameThai as CustName,h.RecUser as EmpCode,i.DocNo as InvoiceNo
	from [job_3x].dbo.Job_ReceiptDetail a
	inner join [job_3x].dbo.Job_ReceiptHeader b 
	on a.ReceiptNo=b.ReceiptNo 
	inner join [job_3x].dbo.Job_CashControlSub c 
	on a.ControlNo=c.ControlNo 
	inner join [job_3x].dbo.Job_InvoiceDetail d
	on a.InvoiceNo=d.DocNo and a.InvoiceItemNo=d.ItemNo 
	inner join [job_3x].dbo.Job_InvoiceHeader i on d.DocNo=i.DocNo
	inner join [job_3x].dbo.Job_SrvSingle e 
	on d.SICode=e.SICode 
	left join [job_3x].dbo.Mas_Company f on
	b.BillToCustCode=f.CustCode and b.BillToCustBranch=f.Branch
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('GL_CONFIG','AccrueIncome')+'-____') a3
	on concat(a3.AccMainName,'-',f.NameThai)=a3.AccName
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	inner join [job_3x].dbo.Job_CashControl h on c.ControlNo=h.ControlNo
	where not isnull(b.CancelProve,'')<>''
	and c.PRType='R'
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto
	union all
	select c.ChqNo,j.JNo,
	c.ChqDate,h.ControlNo,h.VoucherDate,
	c.ChqAmount as Amt,0 as AmtVat,0 as AmtWht,c.ChqAmount,
	isnull(ac.AccCode,dbo.GetAccConfig('AR_CONFIG','ChequeIn')) as AccCodeC,
	isnull(a4.AccCode,dbo.GetAccConfig('AR_CONFIG','CashIn')) as AccCodeD,
	f.NameThai as CustName,h.RecUser as EmpCode,c.PRVoucher as InvoiceNo
	from [job_3x].dbo.Job_CashControlSub c 
	inner join [job_3x].dbo.Job_CashControl h on 
	c.ControlNo=h.ControlNo
	inner join [job_3x].dbo.Job_Order j on c.ForJNo=j.JNo 
	left join [job_3x].dbo.Mas_Company f on j.CustCode=f.CustCode and j.CustBranch=f.Branch
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	left join (select * from vMas_AccCode where AccCode like dbo.GetAccConfig('AR_CONFIG','ChequeIn')+'-____') ac 
	on concat(ac.AccMainName,'-',f.NameThai)=ac.AccName
	where isnull(h.CancelProve,'')=''
	and c.acType='CU' and c.PRType='P'
	and c.ChqAmount>0 
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto
	union all 
	select c.DocNo,c.PRVoucher,
	h.VoucherDate,h.ControlNo,h.RecDate,
	c.cashAmount as Amt,0 as AmtVat,0 as AmtWht,c.CashAmount,
	dbo.GetAccConfig('AR_CONFIG','CashIn') as AccCodeC,
	dbo.GetAccConfig('GL_CONFIG','BankCharge') as AccCodeD,
	c.PayChqTo as CustName,h.RecUser as EmpCode,c.PRVoucher as InvoiceNo
	from [job_3x].dbo.Job_CashControlSub c 
	inner join [job_3x].dbo.Job_CashControl h on 
	c.ControlNo=h.ControlNo
	left join [job_3x].dbo.Mas_BookAccount g
	on c.BookCode=g.BookCode
	left join dbo.Mas_AccCode a4
	on g.GLAccountCode=a4.AccCode
	where isnull(h.CancelProve,'')=''
	and c.PRType='P'
	and c.ItemNo<>1 and c.CashAmount>0
	and h.VoucherDate>=@datefrom and h.VoucherDate<=@dateto
) tb 

if @dtl=0
begin
select AccCode,GLName as AccName,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select VoucherNo as DocNo,AccCodeC as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 
	group by VoucherNo,AccCodeC,InvoiceNo,RefNo
	union all
	select VoucherNo,AccCodeD as AccCode,DocNo,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by VoucherNo,AccCodeD,DocNo,RefNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName
order by AccCode
end
else
begin
select AccCode,GLName as AccName,SubAccName as AccDesc,sum(Debit) as Debit,sum(Credit) as Credit 
from (
select t.*,ac.AccName as GLName from (
	select VoucherNo as DocNo,AccCodeC as AccCode,InvoiceNo as CustName,RefNo as SubAccName,
	0 as Debit,sum(AmtTotal) as Credit
	from #tmp1 
	group by VoucherNo,AccCodeC,InvoiceNo,RefNo
	union all
	select VoucherNo,AccCodeD as AccCode,DocNo,RefNo as SubAccName,
	sum(AmtTotal) as Debit,0 as Credit
	from #tmp1
	group by VoucherNo,AccCodeD,DocNo,RefNo
) t left join Mas_AccCode ac on t.AccCode=ac.AccCode
) dt
group by AccCode,GLName,SubAccName
order by AccCode
end

drop table #tmp1;
end

GO
/****** Object:  StoredProcedure [dbo].[SetDataPurchase]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO















CREATE procedure [dbo].[SetDataPurchase]
(
 @ip varchar(50),
 @dbname varchar(50),
 @docno varchar(50), --เลขที่ใบบันทึกบัญชี
 @ref varchar(50), --เลขเอกสารอ้างอิง
 @docdate date,--วันที่ซื้อ
 @partycode varchar(20),--โค้ดผู้จำหน่าย
 @partytaxcode varchar(20),--รหัสประตำตัวผู้เสียภาษี
 @partyname varchar(50),--ชื่อผู้จำหน่าย
 @partyaddr varchar(MAX),--ที่อยู่ผู้จำหน่าย
 @userid varchar(20),--ชื่อพนักงาน
 @note varchar(max),--หมายเหตุ
 @productcode varchar(20), --รหัสบัญชีสินค้า/บริการ
 @curr varchar(20),--สกุลเงิน
 @rate float,--อัตราแลกเปลี่ยน
 @qty float,--จำนวน
 @price float,--ราคา
 @discamt float,--มูลค่าส่วนลด
 @discrate float,--อัตราส่วนลด
 @vatrate int,--อัตราแวต
 @whtrate int,--อัตราหัก
 @vattype int,--ประเภทการคิด 1=exc 2=inc
 @doctype varchar(5),--ประเภทเอกสารบันทึกบัญชี
 @acctype int,--ประเภทการทำรายการ 1=เชื่อ 2=สด
 @acccode varchar(20) --รหัสบัญชีเจ้าหนี้/เงินสดที่จ่าย
)
as
begin
--หายอดราคาเงินบาท
declare @amount float=@price*@qty*@rate;
declare @vatbuy float=0;

--ถ้าเป็น include vat ให้ถอดยอดก่อนภาษีออกมาพร้อมทั้งหาราคาต่อหน่วย
if (@vatrate>0 AND @vattype=2)
begin 
	set @price=((((@amount*100)/(100+@vatrate))/@qty)/@rate);
	set @amount=round(@price*@qty*@rate,2);
end

--ประมวลผลส่วนลด
declare @vatbase float=@amount-@discamt;
declare @disctotal float=@discamt;
if @discrate>0
begin
	--ถ้ามีใส่ยอดเงินสดมา ลดเงินสดก่อน ค่อยคิด ส่วนลด% เอามาเป็นฐานภาษี
	set @disctotal=@discamt+((@vatbase*@discrate)/100);
	set @vatbase=@vatbase-((@vatbase*@discrate)/100);
end

--คิดภาษีซื้อ
set @vatbuy=((@vatbase*@vatrate)/100);

--คิดภาษีหัก ณ ที่จ่าย
declare @whtamt float=0;
if(@whtrate>0)
begin
	set @whtamt=((@vatbase*@whtrate)/100);
end
if @docno=''
begin
  set @docno=dbo.GetNewTransaction(concat(@doctype,FORMAT(@docdate,'yyMM')),'0000');
end
--เพิ่มสต๊อกบัญชีทรัพย์สิน
if @productcode=''
begin
  set @productcode='DEF';
end
declare @transtype varchar(5)=(CASE WHEN @acctype='1' THEN 'PI' ELSE 'DI' END);
declare @warehousecode varchar(20)='';
declare @assetcode varchar(20)='';
declare @unitstock varchar(20)='';
declare @unitprice float=round(@vatbase/@qty,2);

select @warehousecode=WarehouseCode,@assetcode=AssetAccCode,@unitstock=UnitStock 
from vMas_Product where ProductCode=@productcode and IsService=0;

EXEC dbo.SetTransactionHeader @ip,@dbname,@docno,@docdate,@docdate,@partycode,@partytaxcode,@partyname,@partyaddr,@userid,@transtype,@docdate,@docdate,2,@ref;

declare @transno int=0;
if @warehousecode<>''
begin
	EXEC dbo.SetTransactionStock @ip,@dbname,@userid,@doctype,@ref,'IN',@productcode,@qty,@unitprice,@curr,@rate,@assetcode,@warehousecode,@docno;	
	--เช็คว่ามีข้อมูลสต๊อกลงมั๊ย
	select @transno=isnull(TransID,0) from Acc_StockTransaction where TransNum=@ref;
end
--เพิ่มรายการ detail transaction
EXEC dbo.SetTransactionDetail @ip,@dbname,@doctype,@docno,0,'',0,@transno,@qty,@price,@unitstock,@curr,@rate,@amount,@productcode,@note,@vatrate,@whtrate,1,@userid;
--ถ้ามีส่วนลด บันทึกส่วนลดอ้างอิงด้วย
if @disctotal>0
begin
    declare @discprice float=(@disctotal/@rate)*-1;
	declare @discamount float=round(@disctotal,2)*-1;
	declare @discnote nvarchar(500)=concat('Rate=',@discrate,'=',@disctotal-@discamt,',Cash=',@discamt);
    declare @item int=(select isnull(Max(AccItemNo),0) from Acc_TransactionDT WHERE AccDocNo=@docno);
	EXEC dbo.SetTransactionDetail @ip,@dbname,@doctype,@docno,0,@docno,@item,0,1,@discprice,'DISC',@curr,@rate,@discamount,'',@discnote,0,0,0,@userid;
end

--ถ้าไม่ได้ระบุว่าจะลงบัญชีด้านเครดิตด้วยรหัสอะไร ให้เช็คว่าเป็นเงินสดหรือเจ้าหนี้
if(@acccode='') 
begin
 SET @acccode =IIF(@acctype=1,dbo.GetAccConfig('AP_CONFIG','Purchase'),dbo.GetAccConfig('AP_CONFIG','CashOut'));
end
--ลงสมุดรายวัน
EXEC dbo.SetJournalHeader @ip,@dbname,@doctype,@docno,@docdate,@docdate,@userid,@note,0,0;

declare @id int=(select EntryID from Acc_JournalHD WHERE JournalNo=@docno);
declare @accode varchar(20)='';
declare @acname varchar(max)='';
--Cr. เงินสด/ลูกหนี้
declare @creditout float=round(@vatbase,2)+round(@vatbuy,2)-round(@whtamt,2);

select @accode=a.AccCode,@acname=a.AccName
from vMas_AccCode a
where a.AccCode=@acccode;

EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@ref,@userid,0,@creditout;

--Cr. หัก ณ ที่จ่าย(ถ้ามี)
if @whtamt>0
begin
	declare @creditwht float=round(@whtamt,2);

	select @accode=a.AccCode,@acname=a.AccName
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('ADV_CONFIG','TaxCompany') and @whtamt>0;

	EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@ref,@userid,0,@creditwht;
end
--Dr.บัญชีสินทรัพย์/ค่าใช้จ่าย
declare @debitin float=round(@vatbase,2);

select @accode=p.AssetAccCode,@acname=p.AssetAccName
from vMas_Product p where p.ProductCode=@productcode;

EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@note,@userid,@debitin,0;

--Dr.ภาษีซื้อ(ถ้ามี)
if @vatbuy>0
begin
	declare @debitvat float=round(@vatbuy,2);

	select @accode=a.AccCode,@acname=a.AccName
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('VAT_CONFIG','InputVat');

	EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@ref,@userid,@debitvat,0;
end

end

GO
/****** Object:  StoredProcedure [dbo].[SetDataSale]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

















CREATE procedure [dbo].[SetDataSale]
(
 @ip varchar(20),--ip addr
 @dbname varchar(50), --ชื่อ db 
 @docno varchar(50), --เลขที่ใบบันทึกบัญชี
 @ref varchar(50), --เลขเอกสารอ้างอิง
 @docdate date,--วันที่ขาย
 @partycode varchar(20),--โค้ดผู้ขาย
 @partytaxcode varchar(20),--รหัสประตำตัวผู้เสียภาษี
 @partyname varchar(50),--ชื่อผู้ซื้อ
 @partyaddr varchar(MAX),--ที่อยู่ผู้ซื้อ
 @userid varchar(20),--ชื่อพนักงาน
 @note varchar(max),--หมายเหตุ
 @productcode varchar(20), --รหัสบัญชีสินค้า/บริการ
 @curr varchar(20),--สกุลเงิน
 @rate float,--อัตราแลกเปลี่ยน
 @qty float,--จำนวน
 @price float,--ราคา
 @discamt float,--ราคาลดสด
 @discrate float,--อัตราส่วนลด
 @vatrate int,--อัตราแวต
 @whtrate int,--อัตราหัก
 @vattype int,--ประเภทการคิด 1=exc 2=inc
 @doctype varchar(5),--ประเภทเอกสารบันทึกบัญชี
 @acctype int,--ประเภทการทำรายการ 1=เชื่อ 2=สด
 @acccode varchar(20), --รหัสบัญชีเจ้าหนี้/เงินสดที่รับ
 @lotnumber int --เลขlot รายการต้นทุนขาย
)
as
begin
--หายอดราคาเงินบาท
declare @amount float=@price*@qty*@rate;
declare @vatsale float=0;
--ถ้าเป็น include vat ให้ถอดยอดก่อนภาษีออกมาพร้อมทั้งหาราคาต่อหน่วย
if (@vatrate>0 AND @vattype=2)
begin 
	set @price=((((@amount*100)/(100+@vatrate))/@qty)/@rate);
	set @amount=@price*@qty*@rate;
end
--ประมวลผลส่วนลดการค้า
declare @vatbase float=@amount-@discamt;
declare @disctotal float=@discamt;
if @discrate>0
begin
	--ถ้ามีใส่ยอดเงินสดมา ลดเงินสดก่อน ค่อยคิด ส่วนลด% เอามาเป็นฐานภาษี
	set @disctotal=@discamt+((@vatbase*@discrate)/100);
	set @vatbase=@vatbase-((@vatbase*@discrate)/100);
end

--คิดภาษีขาย
set @vatsale=((@vatbase*@vatrate)/100);

--คิดภาษีหัก ณ ที่จ่าย
declare @whtamt float=0;
if(@whtrate>0)
begin
	set @whtamt=((@vatbase*@whtrate)/100);
end

if @docno=''
begin
  set @docno=dbo.GetNewTransaction(concat(@doctype,FORMAT(@docdate,'yyMM')),'0000');
end
--เพิ่มสต๊อกบัญชีทรัพย์สิน
if @productcode=''
begin
  set @productcode='DEF';
end
declare @transtype varchar(5)=(CASE WHEN @acctype='1' THEN 'SI' ELSE 'DO' END);
declare @warehousecode varchar(20)='';
declare @assetcode varchar(20)='';
declare @unitprice float=((round(@vatbase,2)/@qty)/@rate);
declare @unitstock varchar(20)='';
declare @unitamount float=round(@amount,2);

select @warehousecode=WarehouseCode,@assetcode=AssetAccCode,@unitstock=UnitStock 
from vMas_Product where ProductCode=@productcode and IsService=0;

EXEC dbo.SetTransactionHeader @ip,@dbname,@docno,@docdate,@docdate,@partycode,@partytaxcode,@partyname,@partyaddr,@userid,@transtype,@docdate,@docdate,2,@ref;


declare @transno int=0;
declare @sourceno varchar(50);
declare @sourceitem int;
declare @transprice float;
declare @transrate float;
declare @transcurr varchar(20);
declare @transqty float=@qty*-1;

if @lotnumber>0 
begin
	set @transno=(select isnull(MAX(TransID),0)+1 from Acc_StockTransaction);

	select @transprice=TransPrice,@transcurr=TransCurrency,@transrate=TransRate
	from Acc_StockTransaction s  
	where s.TransID=@lotnumber;
	
	EXEC dbo.SetTransactionStock @ip,@dbname,@userid,@doctype,@ref,'OUT',@productcode,@transqty,@transprice,@transcurr,@transrate,@assetcode,@warehousecode,@docno;	
	--เช็คว่ามีข้อมูลสต๊อกลงมั๊ย
	select @transno=isnull(TransID,0) from Acc_StockTransaction where TransNum=@ref;

	select @sourceno=isnull(AccDocNo,''),@sourceitem=isnull(AccItemNo,0)
	from vTransaction_All 
	where StockTransNo=@lotnumber and AccDocType IN('DI','PI');
end
--เพิ่มรายการ detail transaction
EXEC dbo.SetTransactionDetail @ip,@dbname,@doctype,@docno,0,@sourceno,@sourceitem,@transno,@qty,@price,@unitstock,@curr,@rate,@unitamount,@productcode,@note,@vatrate,@whtrate,1,@userid;
--ถ้ามีส่วนลด บันทึกส่วนลดอ้างอิงด้วย
if @disctotal>0
begin
    declare @discprice float=(@disctotal/@rate)*-1;
	declare @discamount float=round(@disctotal,2)*-1;
	declare @discnote nvarchar(500)=concat('Rate=',@discrate,'=',@disctotal-@discamt,',Cash=',@discamt);
    declare @item int=(select isnull(Max(AccItemNo),0) from Acc_TransactionDT WHERE AccDocNo=@docno);
	EXEC dbo.SetTransactionDetail @ip,@dbname,@doctype,@docno,0,@docno,@item,0,1,@discprice,'DISC',@curr,@rate,@discamount,'',@discnote,0,0,0,@userid;
end

--ถ้าไม่ได้ระบุว่าจะลงบัญชีด้านเดบิตด้วยรหัสอะไร ให้เช็คว่าเป็นเงินสดหรือลูกหนี้
if(@acccode='') 
begin
 SET @acccode =IIF(@acctype=1,dbo.GetAccConfig('AR_CONFIG','Sales'),dbo.GetAccConfig('AR_CONFIG','CashIn'));
end
--ลงสมุดรายวัน
EXEC dbo.SetJournalHeader @ip,@dbname,@doctype,@docno,@docdate,@docdate,@userid,@note,0,0;

declare @id int=(select EntryID from Acc_JournalHD WHERE JournalNo=@docno);
declare @accode varchar(20)='';
declare @acname varchar(max)='';
--Dr. เงินสด/ลูกหนี้
declare @debitin float=round(@vatbase,2)+round(@vatsale,2)-round(@whtamt,2);

select @accode=a.AccCode,@acname=a.AccName
from vMas_AccCode a
where a.AccCode=@acccode;

EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@ref,@userid,@debitin,0;

--Dr. หัก ณ ที่จ่าย(ถ้ามี)
if @whtamt>0
begin
	declare @debitwht float=round(@whtamt,2);

	select @accode=a.AccCode,@acname=a.AccName
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('WHT_CONFIG','IncomeTax') and @whtamt>0;

	EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@ref,@userid,@debitwht,0;
end
--Cr.บัญชีรายได้
declare @creditout float=round(@vatbase,2);

select @accode=p.IncomeAccCode,@acname=p.IncomeAccName
from vMas_Product p where p.ProductCode=@productcode;

EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@note,@userid,0,@creditout;
--Cr.ภาษีขาย(ถ้ามี)
if @vatsale>0
begin
	declare @creditvat float=round(@vatsale,2);

	select @accode=a.AccCode,@acname=a.AccName
	from vMas_AccCode a
	where a.AccCode=dbo.GetAccConfig('VAT_CONFIG','OutputVat');

	EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@ref,@userid,0,@creditvat;
end

--ต้นทุนสินค้า
if @transprice>0
begin
	declare @costamt float=round(@qty*@transprice*@transrate,2);
	--Dr.ต้นทุนสินค้า
	select @accode=p.ExpenseAccCode,@acname=p.ExpenseAccName
	from vMas_Product p where p.ProductCode=@productcode;

	EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@note,@userid,@costamt,0;	
	
	--Cr.สินค้าคงเหลือ
	select @accode=p.AssetAccCode,@acname=p.AssetAccName
	from vStock_Card p where p.TransID=@transno;

	EXEC dbo.SetJournalDetail @ip,@dbname,@doctype,@docno,0,@accode,@acname,@note,@userid,0,@costamt;	
end

--select JournalNo,AccRemark,AccCode,AccName,AccDesc,Debit,Credit from vJournal_All where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[SetJournalDetail]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[SetJournalDetail]
(
@ip varchar(50),
@dbname varchar(50),
@doctype varchar(20),
@journalno varchar(50),
@item int,
@acccode varchar(50),
@accname varchar(max),
@accdesc varchar(max),
@userid varchar(50),
@debit float,
@credit float
)
as
begin
declare @id int=(select isnull(EntryID,0) from Acc_JournalHD where JournalNo=@journalno);
declare @seq int=@item;
if @seq=0
begin
   set @seq =(select isnull(MAX(Seq),0)+1 from Acc_JournalDT where EntryId=@id);
end
declare @mode varchar(20)='ADD';
if not exists(select 1 from Acc_JournalDT where EntryId=@id and Seq=@seq)
begin
	insert into Acc_JournalDT
	(EntryId,Seq,AccCode,AccName,AccDesc,Debit,Credit)
	select @id,@seq,@acccode,@accname,@accdesc,@debit,@credit;
end
else
begin
	set @mode='EDIT';

	update Acc_JournalDT
	set AccCode=@acccode,
	AccName=@accname,
	AccDesc=@accdesc,
	Debit=@debit,
	Credit=@credit
	where EntryID=@id and Seq=@seq;
end

--รวมยอด
update h
set h.TotalCredit=d.Cr,h.TotalDebit=d.Dr
from (select EntryID,Sum(Debit) as Dr,sum(Credit) as Cr from Acc_JournalDT group by EntryID) d inner join Acc_JournalHD h
on d.EntryId=h.EntryID 
where h.EntryId=@id;

declare @logdata nvarchar(max)=concat(@id,'|',@seq,'|',@acccode,'|',@accname,'|',@accdesc,'|',@debit,'|',@credit);

--EXEC dbo.SetTWTLog @dbname,@userid,'ACCOUNT','SetJournalDetail',@mode,@logdata,@ip,'','',0;

--select * from vJournal_D where EntryID=@id;
end

GO
/****** Object:  StoredProcedure [dbo].[SetJournalHeader]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[SetJournalHeader]
(
@ip varchar(50),
@dbname varchar(20),
@doctype varchar(20),
@journalno varchar(50),
@entrydate date,
@docdate date,
@userid varchar(50),
@note varchar(max),
@totaldebit float,
@totalcredit float
)
as
begin
--running
if(@journalno='')
begin
   --set @journalno=dbo.GetNewJournal(CONCAT(@doctype,FORMAT(@docdate,'yyMM')),'0000');
   set @journalno=dbo.GetNewRunning(@doctype,'J',@docdate);
end
declare @id int;
declare @logtype varchar(20)='ADD';
--insert or update header
if NOT EXISTS(select 1 from Acc_JournalHD where JournalNo=@journalno)
begin
	set @id=(select isnull(MAX(EntryID),0)+1  from Acc_JournalHD);

	---set identity_insert Acc_JournalHD on

	insert into Acc_JournalHD
	(EntryID,JournalNo,EntryDate,EffectiveDate,EntryBy,Description,TotalDebit,TotalCredit)
	select @id,@journalno,@entrydate,@docdate,@userid,@note,@totaldebit,@totalcredit

	---set identity_insert Acc_JournalHD off
end
else
begin
	set @id=(select isnull(MAX(EntryID),0)  from Acc_JournalHD where JournalNo=@journalno);
	set @logtype='EDIT';
    update Acc_JournalHD set 
	EntryDate=@entrydate,
	EffectiveDate=@docdate,
	Description=@note,
	TotalDebit=@totaldebit,
	TotalCredit=@totalcredit
	where JournalNo=@journalno;
end
--save log
declare @logdata nvarchar(max)=concat(@id,'|',@journalno,'|',@entrydate,'|',@docdate,'|',@userid,'|',@note,'|',@totaldebit,'|',@totalcredit);

EXEC dbo.SetTWTLog @dbname,@userid,'ACCOUNT','SetJournalHeader',@logtype,@logdata,@ip,'','',0;

--select * from vJournal_H where JournalNo=@journalno;
end

GO
/****** Object:  StoredProcedure [dbo].[SetTransactionDetail]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[SetTransactionDetail]
(
@ip varchar(50),
@dbname varchar(50),
@doctype varchar(3),
@accdocno varchar(50),
@itemno int,
@sourceno varchar(50),
@sourceitem int,
@transno int,
@qty decimal(10,4),
@price decimal(10,4),
@unit varchar(50),
@curr varchar(50),
@rate decimal(10,4),
@amt decimal(10,4),
@product varchar(50),
@desc varchar(2000),
@vatrate decimal(10,4),
@whtrate decimal(10,4),
@vattype decimal(10,4),
@userid varchar(50)
)
as
begin
declare @logtype varchar(20)='ADD';
declare @logdata varchar(max)=concat(@accdocno,'|',@itemno,'|',@sourceno,'|',@sourceitem,'|',@transno,'|',@qty,'|',@price,'|',@unit,'|',@curr,'|',@rate,'|',@amt,'|',@product,'|',@desc,'|',@vatrate,'|',@whtrate,'|',@vattype);

if @amt=0
begin
 set @amt=@qty*@price*@rate;
end

if @itemno=0 
begin
  set @itemno=(select isnull(MAX(AccItemNo),0)+1 as t from Acc_TransactionDT where AccDocNo=@accdocno);
  insert into Acc_TransactionDT
  select @accdocno,@itemno,@sourceno,@sourceitem,@transno,@qty,@price,@unit,@curr,@rate,@amt,@product,@desc,@vatrate,@whtrate,@vattype;
end
else
begin
   set @logtype='EDIT';

   update Acc_TransactionDT 
   set 
   AccSourceDocNo =@sourceno,
   AccSourceDocItem=@sourceitem,
   StockTransNo=@transno,
   Qty=@qty,
   Price=@price,
   UnitMea=@unit,
   Currency=@curr,
   ExchangeRate=@rate,
   Amount=@amt,
   SaleProductCode=@product,
   SalesDescription=@desc,
   RateVat=@vatrate,
   RateWht=@whtrate,
   VatType=@vattype
   where AccDocNo=@accdocno and AccItemNo=@itemno;
end

if dbo.GetAccConfig('PROFILE_CONFIG','SAVELOG')='Y'
begin
	EXEC dbo.SetTWTLog @dbname,@userid,'ACCOUNT','SetTransactionDetail',@logtype,@logdata,@ip,'','',0;
end
select * from vTransaction_D where DocNo=@accdocno AND AccItemNo=@itemno;
end

GO
/****** Object:  StoredProcedure [dbo].[SetTransactionHeader]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[SetTransactionHeader]
(
@ip varchar(50),
@dbname varchar(50),
@accdocno varchar(50),
@docdate date,
@effdate date,
@partycode varchar(50),
@partytaxcode varchar(50),
@partyname varchar(2000),
@partyaddr varchar(2000),
@issueby varchar(50),
@doctype varchar(3),
@postdate date,
@fiscalyear date,
@docstatus int,
@docrefno varchar(2000)
)
as
begin

if @accdocno=''
begin
	--declare @header varchar(10);
	--set @header=CONCAT(@doctype,FORMAT(@docdate,'yyMM'));
	
	--set @accdocno=dbo.GetNewTransaction(@header,'0000');
	set @accdocno=dbo.GetNewRunning(@doctype,'T',@docdate);
end
declare @logdata varchar(max)=CONCAT(@accdocno,'|',@docdate,'|',@effdate,'|',@partycode,'|',@partytaxcode,'|',@partyname,'|',@partyaddr,'|',@issueby,'|',@doctype,'|',@postdate,'|',@fiscalyear,'|',@docstatus,'|',@docrefno);
declare @logtype varchar(20)='ADD';
if NOT EXISTS(select 1 from Acc_TransactionHD Where AccDocNo=@accdocno) 
begin   
	insert into Acc_TransactionHD
	select @accdocno,@docdate,@effdate,@partycode,@partytaxcode,@partyname,@partyaddr,@issueby,@doctype,@postdate,@fiscalyear,@docstatus,@docrefno
end
else
begin
	set @logtype='EDIT';

	update Acc_TransactionHD 
	set 
	AccEffectiveDate=@effdate,
	Partycode=@partycode,
	PartyTaxCode=@partytaxcode,
	PartyName=@partyname,
	PartyAddress=@partyaddr,
	IssueBy=@issueby,
	AccPostDate=@postdate,
	FiscalYear=@fiscalyear,
	DocStatus=@docstatus,
	DocRefNo=@docrefno
	where AccDocNo=@accdocno
end
if dbo.GetAccConfig('PROFILE_CONFIG','SAVELOG')='Y'
begin
	EXEC dbo.SetTWTLog @dbname,@issueby,'ACCOUNT','SetTransactionHeader',@logtype,@logdata,@ip,'','',0;
end
select * from vTransaction_H where AccDocNo=@accdocno
end

GO
/****** Object:  StoredProcedure [dbo].[SetTransactionStock]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[SetTransactionStock]
(
@ip varchar(50),
@dbname varchar(50),
@userid varchar(50),
@doctype varchar(20),
@transno varchar(50),
@transtype varchar(20),
@productcode varchar(50),
@qty float,
@price float,
@curr varchar(20),
@rate float,
@acccode varchar(20),
@whcode varchar(20),
@refno varchar(50)
)
as
begin
declare @id int=(select isnull(TransID,0) from Acc_StockTransaction where TransNum=@transno);

if @id is null
begin
 set @id=(select isnull(MAX(TransID),0)+1 from Acc_StockTransaction);
end
declare @mode varchar(20)='ADD';
if not exists(select 1 from Acc_StockTransaction where TransID=@id)
begin
    SET IDENTITY_INSERT Acc_StockTransaction ON
	
	INSERT INTO Acc_StockTransaction
	(TransID,TransNum,TransType,StockProductCode,TransQty,TransPrice,TransCurrency,TransRate,AssetAccCode,WarehouseCode,RefDocNo)
	select @id,@transno,@transtype,@productcode,@qty,@price,@curr,@rate,@acccode,@whcode,@refno;

	SET IDENTITY_INSERT Acc_StockTransaction OFF
end
else	
begin
	set @mode='EDIT';
	update Acc_StockTransaction
	set TransType=@transtype,
	StockProductCode=@productcode,
	TransQty=@qty,
	TransPrice=@price,
	TransCurrency=@curr,
	TransRate=@rate,
	AssetAccCode=@acccode,
	WarehouseCode=@whcode,
	RefDocNo=@refno
	where TransID=@id;
end
declare @logdata nvarchar(max)=concat(@id,'|',@transno,'|',@transtype,'|',@productcode,'|',@qty,'|',@price,'|',@curr,'|',@rate,'|',@acccode,'|',@whcode,'|',@refno);

EXEC dbo.SetTWTLog @dbname,@userid,'ACCOUNT','SetTransactionStock',@mode,@logdata,@ip,'','',0;

--select * from vStock_Card where TransID=@id;
end

GO
/****** Object:  StoredProcedure [dbo].[SetTWTLog]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SetTWTLog]
(
@dbname varchar(50),
@userid varchar(50),
@appid varchar(50),
@modulename varchar(50),
@logaction varchar(50),
@logdata nvarchar(max),
@ip nvarchar(50),
@stacktrace nvarchar(max),
@jsondata nvarchar(max),
@iserror int
)
as
begin
insert into weblicense.dbo.TWTLog
(CustID,AppID,ModuleName,LogAction,Message,LogDateTime,IsError,FromIP,StackTrace,JSonData)
select CONCAT(@dbname,'/',@userid),@appid,@modulename,@logaction,@logdata,GetDate(),@iserror,@ip,@stacktrace,@jsondata
end

GO
/****** Object:  StoredProcedure [dbo].[TestCall]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[TestCall]
as
begin
EXEC dbo.DELETE_ALL_JOURNAL
EXEC dbo.DELETE_ALL_TRANSCTION

--EXEC dbo.Insert_SubAccCodefromCustomer '1201-00',0
--EXEC dbo.Insert_SubAccCodefromCustomer '1401-00',0
--EXEC dbo.Insert_SubAccCodeFromService 'S','4100-00',0
--EXEC dbo.Insert_SubAccCodeFromService 'C','5200-00',0
--EXEC dbo.Insert_SubAccCodeFromService 'E','5300-00',0


EXEC dbo.Insert_AdvanceToJournal_V4 '2026-01-01','2026-07-31',''
EXEC dbo.Insert_ClearExpenseFromAdvance_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearExpenseFromBillPay_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearExpenseFromManualEntry_V3 '2026-01-01','2026-07-31'
EXEC dbo.Insert_BillPayToJournal_V4 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearMoneyFromAdvance_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearMoneyFromNoAdvance '2026-01-01','2026-07-31'
EXEC dbo.Insert_PVFromBillPay_V3 '2026-01-01','2026-07-31'
EXEC dbo.Insert_InvoiceToJournal_V4 '2026-01-01','2026-07-31'
EXEC dbo.Insert_CustAdvanceToJournal '2026-01-01','2026-07-31'
EXEC dbo.Insert_CNDNToJournal_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ReceiptToJournal_V4 '2026-01-01','2026-07-31'
EXEC dbo.Insert_RVFromJob_V3 '2026-01-01','2026-07-31'

select * from vSum_Balance
END

GO
/****** Object:  StoredProcedure [dbo].[TestCall_MNL]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[TestCall_MNL]
as
begin
EXEC dbo.DELETE_JOB_JOURNAL

--EXEC dbo.Insert_SubAccCodefromCustomer '1201-00',0
--EXEC dbo.Insert_SubAccCodefromCustomer '1401-00',0
--EXEC dbo.Insert_SubAccCodeFromService 'S','4100-00',0
--EXEC dbo.Insert_SubAccCodeFromService 'C','5200-00',0
--EXEC dbo.Insert_SubAccCodeFromService 'E','5300-00',0
EXEC dbo.Insert_ProductsCodeFromjob_3x 

EXEC dbo.Insert_AdvanceToJournal_MNL '2026-01-01','2026-07-31',''
EXEC dbo.Insert_ClearExpenseFromAdvance_MNL '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearExpenseFromBillPay_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearExpenseFromManualEntry_V3 '2026-01-01','2026-07-31'
EXEC dbo.Insert_BillPayToJournal_V4 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearMoneyFromAdvance_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ClearMoneyFromNoAdvance '2026-01-01','2026-07-31'
EXEC dbo.Insert_PVFromBillPay_V3 '2026-01-01','2026-07-31'
EXEC dbo.Insert_InvoiceToJournal_MNL '2026-01-01','2026-07-31'
EXEC dbo.Insert_CustAdvanceToJournal '2026-01-01','2026-07-31'
EXEC dbo.Insert_CNDNToJournal_V2 '2026-01-01','2026-07-31'
EXEC dbo.Insert_ReceiptToJournal_V4 '2026-01-01','2026-07-31'
EXEC dbo.Insert_RVFromJob_V3 '2026-01-01','2026-07-31'

select * from vSum_Balance
END


GO
/****** Object:  StoredProcedure [dbo].[TestHR]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TestHR]
as
begin
EXEC dbo.Insert_PayrollByStaff '2026-01-31',1,'ADMIN',1
EXEC dbo.Insert_PayrollByStaff '2026-01-31',1,'ADMIN',2
EXEC dbo.Insert_AddDeductPayroll '2026-01-01','2026-01-31','ADMIN',1
EXEC dbo.Insert_AddDeductPayroll '2026-01-01','2026-01-31','ADMIN',2
EXEC dbo.Insert_PayrollToJournal '2026-01-01','2026-01-31','2026-01-31','ADMIN','เงินเดือน มค.2569'
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePO_STATUS]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdatePO_STATUS]
(
@step int,
@pono varchar(50),
@userid varchar(50),
@statusdate date
)
as
begin
	if @step=1 --APPROVED
	begin
		insert into Acc_AdditionData(DocNo,Seq,Text5,Date1)
		select @pono,0,@userid,@statusdate 
		where not exists(select 1 from Acc_AdditionData where DocNo=@pono and Seq=0)

		update Acc_AdditionData
		set Text1=@userid,Date1=@statusdate 
		where DocNo=@pono and seq=0
	end
	if @step=2 --DELIVERED
	begin
		if exists(select 1 from vTransaction_All where
		AccSourceDocNo=@pono and AccDocType='DI' and DocStatus<>99)
		begin
			update Acc_TransactionHD set DocStatus=2
			where AccdocNo=@pono and DocStatus<>99
		end
	end
	if @step=3 --BILLED
	begin
		if exists(select 1 from vTransaction_All where
		AccSourceDocNo=@pono and AccDocType='PI' and DocStatus<>99)
		begin
			update Acc_TransactionHD set DocStatus=1
			where AccdocNo=@pono and DocStatus<>99
		end
	end
	if @step=4 --CLOSED
	begin
		EXEC dbo.ClosePO @pono,@userid
	end
end


GO
/****** Object:  StoredProcedure [dbo].[UpdatePR_STATUS]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdatePR_STATUS]
(
@step int,
@prno varchar(50),
@userid varchar(50),
@statusdate date
)
as
begin
	if @step=1 --CHECKED
	begin
		insert into Acc_AdditionData(DocNo,Seq,Text1,Date1)
		select @prno,0,@userid,@statusdate 
		where not exists(select 1 from Acc_AdditionData where DocNo=@prno and Seq=0)

		update Acc_AdditionData
		set Text1=@userid,Date1=@statusdate 
		where DocNo=@prno and seq=0
	end
	if @step=2 --APPROVED
	begin
		insert into Acc_AdditionData(DocNo,Seq,Text3,Date3)
		select @prno,0,@userid,@statusdate 
		where not exists(select 1 from Acc_AdditionData where DocNo=@prno and Seq=0)

		update Acc_AdditionData
		set Text3=@userid,Date3=@statusdate 
		where DocNo=@prno and seq=0
	end
	if @step=3 --CLOSED
	begin
		EXEC dbo.ClosePR @prno,@userid
	end
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateTotalDebitCredit]    Script Date: 26/10/2026 12:29:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateTotalDebitCredit]
as
begin
update Acc_JournalDT set Debit=convert(decimal(28,5),Debit) where Debit<>convert(decimal(28,5),Debit)
update Acc_JournalDT set Credit=convert(decimal(28,5),Credit) where Credit<>convert(decimal(28,5),Credit)
update Acc_JournalDT set Debit=0 where Debit is null
update Acc_JournalDT set Credit=0 where Credit is null

update a
set a.TotalDebit=b.sumA,a.TotalCredit=b.sumb
from Acc_JournalHD a inner join 
(select EntryId,convert(decimal(28,5),sum(Debit)) sumA,convert(decimal(28,5),sum(Credit)) sumb from Acc_JournalDT  group by EntryID) b 
on a.EntryID=b.EntryID
where round(isnull(a.TotalDebit,0),2)<>round(b.sumA,2)
or round(isnull(a.TotalCredit,0),2)<>round(b.sumB,2)
end

GO
