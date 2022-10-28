using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Device_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MobileDevice> top5Mobile = new List<MobileDevice>{ 
                         
                new MobileDevice { Model="Samsung j7 Prim" , Price=8000.00M, UserRating=5.0F}, 
                new MobileDevice { Model="Samsung j2 Prim" , Price=7000.00M, UserRating=4.0F}, 
                new MobileDevice { Model="Samsung j1 Prim" , Price=5000.00M, UserRating=3.5F}, 
                new MobileDevice { Model="Samsung j5 Prim" , Price=3000.00M, UserRating=2.0F}, 
                new MobileDevice { Model="Samsung j2 Prim" , Price=2000.00M, UserRating=1.0F}, 
                  
            };

            top5Mobile.Sort((x, y) => x.Price.CompareTo(y.Price));

            //top5Mobile.Sort((x, y) => x.UserRating.CompareTo(y.UserRating));
            // top5Mobile.Sort((x, y) => x.Model.CompareTo(y.Model));


            top5Mobile.Reverse();

            foreach(var m in top5Mobile)
            {
                Console.WriteLine($"{m.Model} : {m.Price} : {m.UserRating}");
            }

            Console.ReadKey();


        }//Main
    }//Class


    public class MobileDevice
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public float UserRating { get; set; }
    }
}//Namespace

