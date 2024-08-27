using Microsoft.AspNetCore.Mvc;
using ServicesInteractEachOther.Services;

namespace ServicesInteractEachOther.Controllers
{
    public class OrderController : Controller
    {
        IOrderService _ordererService;
        public OrderController(IOrderService orderService)
        {
            _ordererService = orderService;
        }

        [Route("order/placeorder/{orderId}")]
        public IActionResult PlaceOrder(int orderId)
        {
            _ordererService.PlaceOrder(orderId);
            return Content("Order placed and notification sent");
        }
    }
}
