namespace Insights.Repository.Interface;

public interface IAdInsightsRepository
{
    Task<int> GetClicksAsync(string campaignID);
    Task<int> GetImpressionsAsync(string campaignID);
    Task<int> GetClickToBasketAsync(string campaignID);
}