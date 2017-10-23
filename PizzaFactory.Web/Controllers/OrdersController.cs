using Microsoft.AspNetCore.Mvc;
using PizzaFactory.Core.Orders;
using PizzaFactory.Core.Orders.Commands;
using PizzaFactory.Infrastructure;
using PizzaFactory.Web.Models;
using System;
using System.Collections.Generic;

namespace PizzaFactory.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
    {public OrdersController(IRepository repository, ICommandSender commandSender)
        {
            Repository = repository;
            CommandSender = commandSender;
        }

        public IRepository Repository { get; set; }
        public ICommandSender CommandSender { get; set; }

        [HttpGet]
        public JsonResult Get()
        {
            IEnumerable<Order> orders = Repository.All<Order>();

            return Json(orders);
        }

        [HttpPost]
        public void Post([FromBody]PlaceOrderModel model)
        {
            //TODO: Add validation for Size, Dough, Sauce

            var id = Guid.NewGuid();

            PlaceOrder placeOrder = new PlaceOrder(id, model.Size, model.DoughType, model.SauceType, 
                model.Cheeses, model.Meats, model.Vegetables, DateTime.Now, User.Identity.Name);
            CommandSender.Send(placeOrder);
        }
    }
}