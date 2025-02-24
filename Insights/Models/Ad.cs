namespace Insights.Models
{
    public class Ad
    {
        public Guid CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string Advertiser { get; set; }
        public long Clicks { get; set; }
        public long Impressions { get; set; }
        public int ClickToBasket { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}