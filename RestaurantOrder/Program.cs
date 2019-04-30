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
            bool running = true;

            while (running)
            {
                string pilihan;
                int banyak;
                double hargaSatuan;
                

                Console.WriteLine("\n\nSELAMAT DATANG DI CANDRA RESTO");
                Console.WriteLine("\n[1]Pelecing \n[2]Pecel \n[3]Es teh \n[4]Tampilkan Orderan");

                Console.WriteLine("\nPilih Pesanan : ");
                pilihan = Console.ReadLine();



                if (pilihan == "1")
                {
                    Console.WriteLine("Banyak :");
                    banyak = int.Parse(Console.ReadLine());
                    hargaSatuan = 20000;

                    Order.SetPerintah(1);
                    Order.SetMenuItem(new MenuItem("Pelecing", banyak, banyak * hargaSatuan));
                    Order.ExecutePerintah();


                }
                else if (pilihan == "2")
                {
                    Console.WriteLine("Banyak :");
                    banyak = int.Parse(Console.ReadLine());
                    hargaSatuan = 10000;

                    Order.SetPerintah(1);
                    Order.SetMenuItem(new MenuItem("Pecel", banyak, banyak * hargaSatuan));
                    Order.ExecutePerintah();


               }
                else if (pilihan == "3")
                {
                    Console.WriteLine("Banyak :");
                    banyak = int.Parse(Console.ReadLine());
                    hargaSatuan = 2000;

                    Order.SetPerintah(1);
                    Order.SetMenuItem(new MenuItem("Es Teh", banyak, banyak * hargaSatuan));
                    Order.ExecutePerintah();

                
                }
                else if (pilihan == "4")
                {
                    Order.ShowCurrentOrder();
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan Menu Tidak Tersedia");
                }

            }
        }
    }
}
