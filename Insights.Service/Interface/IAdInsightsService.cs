using System.Threading.Tasks;

namespace Insights.Gateway.Services;

public interface IAdInsightsService
{
    Task<long> GetClicksAsync(string campaignID);
    Task<long> GetImpressionsAsync(string campaignID);
    Task<int> GetClickToBasketAsync(string campaignID);
}