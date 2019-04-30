using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder
{
    public abstract class OrderPerintah
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }

    public class AddPerintah : OrderPerintah
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            currentItems.Add(newItem);
        }
    }

    public class PerintahFactory
    {
        public OrderPerintah GetPerintah(int PerintahOption)
        {
            return new AddPerintah();
        }
    }
}
