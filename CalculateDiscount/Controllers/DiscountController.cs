using CalculateDiscount.Models;
using CalculateDiscount.Service.Interfaces;
using CalculateDiscount.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculateDiscount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpPost("")]
        public IActionResult CalculateDiscount([FromBody] DiscountRequest discountRequest)
        {
            CalculateDiscountResponse response = new CalculateDiscountResponse();
            User user = discountRequest.User;
            Bill bill = discountRequest.Bill;

            if (user == null || bill == null) return StatusCode(500, new BaseApiResponse<CalculateDiscountResponse>(false, "error", response));

            decimal discountAmount = _discountService.CalculateDiscount(user, bill);
            response = new CalculateDiscountResponse()
            {
                DiscountAmount = discountAmount,
                InvoiceAmount = discountRequest.Bill.BillItem.Price - discountAmount
            };

            return Ok(new BaseApiResponse<CalculateDiscountResponse>(true, "successful", response));
        }
    }
}
