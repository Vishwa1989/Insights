using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Insights.Gateway.Services;

namespace Insights.Gateway.Controllers.V1
{
    /// <summary>
    /// Controller for handling Ad Insights metrics and analytics
    /// </summary>
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AdInsightsController : ControllerBase
    {
        private readonly IAdInsightsService _adInsightsService;

        /// <summary>
        /// Initializes a new instance of the AdInsightsController
        /// </summary>
        /// <param name="adInsightsService">Service for handling ad insights operations</param>
        public AdInsightsController(IAdInsightsService adInsightsService)
        {
            _adInsightsService = adInsightsService;
        }

        /// <summary>
        /// Retrieves the number of clicks for a specific campaign
        /// </summary>
        /// <param name="campaignID">The unique identifier of the campaign</param>
        /// <returns>Click metrics for the specified campaign</returns>
        /// <response code="200">Returns the click data</response>
        /// <response code="404">If the campaign is not found</response>
        [HttpGet("clicks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetClicks(string campaignID)
        {
            var result = await _adInsightsService.GetClicksAsync(campaignID);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves the number of impressions for a specific campaign
        /// </summary>
        /// <param name="campaignID">The unique identifier of the campaign</param>
        /// <returns>Impression metrics for the specified campaign</returns>
        /// <response code="200">Returns the impression data</response>
        /// <response code="404">If the campaign is not found</response>
        [HttpGet("impressions")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetImpressions(string campaignID)
        {
            var result = await _adInsightsService.GetImpressionsAsync(campaignID);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves the click-to-basket conversion rate for a specific campaign
        /// </summary>
        /// <param name="campaignID">The unique identifier of the campaign</param>
        /// <returns>Click-to-basket conversion metrics for the specified campaign</returns>
        /// <response code="200">Returns the click-to-basket conversion data</response>
        /// <response code="404">If the campaign is not found</response>
        [HttpGet("clickToBasket")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetClickToBasket(string campaignID)
        {
            var result = await _adInsightsService.GetClickToBasketAsync(campaignID);
            return Ok(result);
        }
    }
}