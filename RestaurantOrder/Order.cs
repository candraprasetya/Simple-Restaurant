using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder
{
    public class Order
    {
        private OrderPerintah _dishesPerintah;
        private MenuItem _menuItem;
        private Dishes _dishes;

        public Order()
        {
            _dishes = new Dishes();
        }

        public void SetPerintah(int PerintahOption)
        {
            _dishesPerintah = new PerintahFactory().GetPerintah(PerintahOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecutePerintah()
        {
            _dishes.ExecutePerintah(_dishesPerintah, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _dishes.ShowCurrentItems();
        }
    }

    public class MenuItem
    {
        public string NamaPesanan { get; set; }
        public int JumlahPesanan { get; set; }
        public double HargaPesanan { get; set; }

        public MenuItem(string namaPesanan, int jumlahPesanan, double hargaPesanan)
        {
            NamaPesanan = namaPesanan;
            JumlahPesanan = jumlahPesanan;
            HargaPesanan = hargaPesanan;

        }

        public void Display()
        {
            Console.WriteLine("\nNama : " + NamaPesanan);
            Console.WriteLine("Jumlah : " + JumlahPesanan.ToString());
            Console.WriteLine("Harga  : Rp" + HargaPesanan.ToString());
        }
    }

    
}
