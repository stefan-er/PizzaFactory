using PizzaFactory.Core.Orders;
using System;
using System.Collections.Generic;

namespace PizzaFactory.Core.Common
{
    public class InMemoryData
    {
        private static readonly InMemoryData instance = new InMemoryData();

        private InMemoryData()
        {
            Orders = new Dictionary<Guid, Order>();
        }

        public static InMemoryData Instance
        {
            get
            {
                return instance;
            }
        }

        public IDictionary<Guid, Order> Orders { get; set; }
    }
}
