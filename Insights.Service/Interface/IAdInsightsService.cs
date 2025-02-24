using System.Threading.Tasks;

namespace Insights.Gateway.Services;

public interface IAdInsightsService
{
    Task<int> GetClicksAsync(string campaignID);
    Task<int> GetImpressionsAsync(string campaignID);
    Task<int> GetClickToBasketAsync(string campaignID);
}