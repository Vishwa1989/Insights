using System.Threading.Tasks;
using Insights.Repository.Interface;

namespace Insights.Gateway.Services
{
    public class AdInsightsService(IAdInsightsRepository repository) : IAdInsightsService
    {
        public async Task<long> GetClicksAsync(string campaignID)
        {
            return await repository.GetClicksAsync(campaignID);
        }

        public async Task<long> GetImpressionsAsync(string campaignID)
        {
            return await repository.GetImpressionsAsync(campaignID);
        }

        public async Task<int> GetClickToBasketAsync(string campaignID)
        {
            return await repository.GetClickToBasketAsync(campaignID);
        }
    }
}