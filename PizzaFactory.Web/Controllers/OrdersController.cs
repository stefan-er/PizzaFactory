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
            PlaceOrder placeOrder = new PlaceOrder(Guid.Parse("4bdf2d6b-029f-48e5-a7a9-cdb85a8ef636"));
            CommandSender.Send(placeOrder);
        }
    }
}