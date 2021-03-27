﻿using System.Collections.Generic;

namespace StockTools.Data
{
    public class CashFlowStatementAnnualReport
    {
        public string fiscalDateEnding { get; set; }
        public string reportedCurrency { get; set; }
        public string operatingCashflow { get; set; }
        public string paymentsForOperatingActivities { get; set; }
        public string proceedsFromOperatingActivities { get; set; }
        public string changeInOperatingLiabilities { get; set; }
        public string changeInOperatingAssets { get; set; }
        public string depreciationDepletionAndAmortization { get; set; }
        public string capitalExpenditures { get; set; }
        public string changeInReceivables { get; set; }
        public string changeInInventory { get; set; }
        public string profitLoss { get; set; }
        public string cashflowFromInvestment { get; set; }
        public string cashflowFromFinancing { get; set; }
        public string proceedsFromRepaymentsOfShortTermDebt { get; set; }
        public string paymentsForRepurchaseOfCommonStock { get; set; }
        public string paymentsForRepurchaseOfEquity { get; set; }
        public string paymentsForRepurchaseOfPreferredStock { get; set; }
        public string dividendPayout { get; set; }
        public string dividendPayoutCommonStock { get; set; }
        public string dividendPayoutPreferredStock { get; set; }
        public string proceedsFromIssuanceOfCommonStock { get; set; }
        public string proceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; set; }
        public string proceedsFromIssuanceOfPreferredStock { get; set; }
        public string proceedsFromRepurchaseOfEquity { get; set; }
        public string proceedsFromSaleOfTreasuryStock { get; set; }
        public string changeInCashAndCashEquivalents { get; set; }
        public string changeInExchangeRate { get; set; }
        public string netIncome { get; set; }
    }

    public class CashFlowStatementQuarterlyReport
    {
        public string fiscalDateEnding { get; set; }
        public string reportedCurrency { get; set; }
        public string operatingCashflow { get; set; }
        public string paymentsForOperatingActivities { get; set; }
        public string proceedsFromOperatingActivities { get; set; }
        public string changeInOperatingLiabilities { get; set; }
        public string changeInOperatingAssets { get; set; }
        public string depreciationDepletionAndAmortization { get; set; }
        public string capitalExpenditures { get; set; }
        public string changeInReceivables { get; set; }
        public string changeInInventory { get; set; }
        public string profitLoss { get; set; }
        public string cashflowFromInvestment { get; set; }
        public string cashflowFromFinancing { get; set; }
        public string proceedsFromRepaymentsOfShortTermDebt { get; set; }
        public string paymentsForRepurchaseOfCommonStock { get; set; }
        public string paymentsForRepurchaseOfEquity { get; set; }
        public string paymentsForRepurchaseOfPreferredStock { get; set; }
        public string dividendPayout { get; set; }
        public string dividendPayoutCommonStock { get; set; }
        public string dividendPayoutPreferredStock { get; set; }
        public string proceedsFromIssuanceOfCommonStock { get; set; }
        public string proceedsFromIssuanceOfLongTermDebtAndCapitalSecuritiesNet { get; set; }
        public string proceedsFromIssuanceOfPreferredStock { get; set; }
        public string proceedsFromRepurchaseOfEquity { get; set; }
        public string proceedsFromSaleOfTreasuryStock { get; set; }
        public string changeInCashAndCashEquivalents { get; set; }
        public string changeInExchangeRate { get; set; }
        public string netIncome { get; set; }
    }

    public class CashFlowStatementRoot
    {
        public string symbol { get; set; }
        public List<CashFlowStatementAnnualReport> annualReports { get; set; }
        public List<CashFlowStatementQuarterlyReport> quarterlyReports { get; set; }
    }
}
