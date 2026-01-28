using IBTbusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IBTwebApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        [HttpPost("update")]
        public async Task<IActionResult> UpdateRates()
        {
            clsExchangeRates manager = new clsExchangeRates();
            await manager.UpdateAllRatesInDB();
            return Ok("Exchange rates updated successfully.");
        }

        //// Optional: Get specific rate
        //[HttpGet("{currencyCode}")]
        //public IActionResult GetRate(string currencyCode)
        //{
        //    double rate = clsExchangeRateDataAccess.GetRate(currencyCode); // You create this in DAL
        //    return Ok(rate);
        //}
    }
}
