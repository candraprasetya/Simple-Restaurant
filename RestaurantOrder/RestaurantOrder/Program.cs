using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Order Order = new Order();
            
            string pilihan;
            int banyak;
            double hargaSatuan;

            Console.WriteLine("SELAMAT DATANG DI WARUNG PADANG");
            Console.WriteLine("\n[1]Rendang \n[2]Dendeng \n[3]Es teh");

            pilihan = Console.ReadLine();

            if(pilihan == "1")
            {
                Console.WriteLine("Banyak :");
                banyak = int.Parse(Console.ReadLine());
                hargaSatuan = 20000;

                Order.SetPerintah(1);
                Order.SetMenuItem(new MenuItem("Rendang", banyak, banyak * hargaSatuan));
                Order.ExecutePerintah();

                //Menampilkan Orderan
                Order.ShowCurrentOrder();
            }

            Console.ReadKey();

        }
    }
}
