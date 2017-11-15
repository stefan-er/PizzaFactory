using PizzaFactory.Core.Common;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PizzaFactory.Core
{
    public abstract class Topping
    {
        public string Name { get; protected set; }
        public ToppingType Type { get; protected set; }

        public static T[] GetToppings<T>(IEnumerable types, ISimpleFactory factory) where T : Topping
        {
            var toppings = new HashSet<T>();
            foreach (var type in types)
            {
                T topping = factory.CreateTopping<T>(type);
                toppings.Add(topping);
            }

            return toppings.ToArray();
        }

        public override bool Equals(object obj)
        {
            Topping other = obj as Topping;
            if (other == null) return false;
            return Type == other.Type;
        }
        public override int GetHashCode()
        {
            return Type.GetHashCode();
        }
    }
}
