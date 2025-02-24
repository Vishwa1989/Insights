namespace Insights.Models
{
    public class Ad
    {
        public string CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string Advertiser { get; set; }
        public int Clicks { get; set; }
        public int Impressions { get; set; }
        public int ClickToBasket { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}