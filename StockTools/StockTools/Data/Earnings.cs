using System.Collections.Generic;

namespace StockTools.Data
{
    public class AnnualEarning
    {
        public string fiscalDateEnding { get; set; }
        public string reportedEPS { get; set; }
    }

    public class QuarterlyEarning
    {
        public string fiscalDateEnding { get; set; }
        public string reportedDate { get; set; }
        public string reportedEPS { get; set; }
        public string estimatedEPS { get; set; }
        public string surprise { get; set; }
        public string surprisePercentage { get; set; }
    }

    public class EarningsRoot
    {
        public string symbol { get; set; }
        public List<AnnualEarning> annualEarnings { get; set; }
        public List<QuarterlyEarning> quarterlyEarnings { get; set; }
    }
}