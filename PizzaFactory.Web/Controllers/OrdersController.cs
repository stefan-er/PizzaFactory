using Microsoft.AspNetCore.Mvc;
using PizzaFactory.Core.Orders.Commands;
using PizzaFactory.Infrastructure;
using PizzaFactory.Web.Models;
using System;

namespace PizzaFactory.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
    {
        public ICommandSender CommandSender { get; set; }

        public OrdersController(ICommandSender commandSender)
        {
            CommandSender = commandSender;
        }

        [HttpPost]
        public void Post([FromBody]PlaceOrderModel model)
        {
            var id = Guid.NewGuid();

            PlaceOrder placeOrder = new PlaceOrder(id, model.Size, model.DoughType, model.SauceType, 
                model.Cheeses, model.Meats, model.Vegetables, DateTime.Now, User.Identity.Name);
            CommandSender.Send(placeOrder);
        }
    }
}