using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Insights.Models;
using Insights.Repository.Interface;

namespace Insights.Gateway.Repositories
{
    public class AdInsightsRepository : IAdInsightsRepository
    {
        private readonly List<Ad> _ads;

        public AdInsightsRepository()
        {
            // Dummy data
            _ads = new List<Ad>
            {
                new Ad
                {
                    CampaignId = "campaign1",
                    CampaignName = "Campaign 1",
                    Advertiser = "Advertiser 1",
                    Clicks = 100,
                    Impressions = 1000,
                    ClickToBasket = 10,
                    StartDate = DateTime.Now.AddDays(-30),
                    EndDate = DateTime.Now.AddDays(30)
                },
                new Ad
                {
                    CampaignId = "campaign2",
                    CampaignName = "Campaign 2",
                    Advertiser = "Advertiser 2",
                    Clicks = 200,
                    Impressions = 2000,
                    ClickToBasket = 20,
                    StartDate = DateTime.Now.AddDays(-60),
                    EndDate = DateTime.Now.AddDays(60)
                }
            };
        }

        public Task<int> GetClicksAsync(string campaignID)
        {
            var ad = _ads.FirstOrDefault(a => a.CampaignId == campaignID);
            return Task.FromResult(ad?.Clicks ?? 0);
        }

        public Task<int> GetImpressionsAsync(string campaignID)
        {
            var ad = _ads.FirstOrDefault(a => a.CampaignId == campaignID);
            return Task.FromResult(ad?.Impressions ?? 0);
        }

        public Task<int> GetClickToBasketAsync(string campaignID)
        {
            var ad = _ads.FirstOrDefault(a => a.CampaignId == campaignID);
            return Task.FromResult(ad?.ClickToBasket ?? 0);
        }
    }
}