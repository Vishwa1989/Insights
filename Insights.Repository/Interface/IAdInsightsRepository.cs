namespace Insights.Repository.Interface;

public interface IAdInsightsRepository
{
    Task<long> GetClicksAsync(string campaignID);
    Task<long> GetImpressionsAsync(string campaignID);
    Task<int> GetClickToBasketAsync(string campaignID);
}