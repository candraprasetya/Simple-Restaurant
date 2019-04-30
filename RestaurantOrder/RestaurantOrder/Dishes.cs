using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder
{
    public class Dishes
    {
        public List<MenuItem> currentItems { get; set; }
        public Dishes()
        {
            currentItems = new List<MenuItem>();
        }

        public void ExecutePerintah(OrderPerintah Perintah, MenuItem item)
        {
            Perintah.Execute(this.currentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach (var item in currentItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }

    }
}
