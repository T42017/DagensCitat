using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagensCitat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Glöm ej att skapa en branch "feature-förnamn" INNAN du gör ändringar i koden :)

            String Quote,Dayofweek;

            Quote = "";
            Dayofweek = DateTime.Today.DayOfWeek.ToString(); 

            

            


            if ( Dayofweek=="Monday") {
                Quote = "Oui! Oui! Je adore ton baguette!";

            }


            else if(Dayofweek =="Tuesday")
            {
                Quote ="Look deep into nature, and then you will understand everything better";
              
            }


            else if (Dayofweek == "Wednesday")
            {
                Quote = "Love all, trust a few, do wrong to none";
            }

            else if (Dayofweek =="Thursday" )
            {
                Quote = "The process of delving into the black abyss is to me the keenest form of fascination.";
            }

            else if (Dayofweek == "Friday")
            {
                Quote = "It is a scientific fact that your body will not absorb cholesterol if you take it from another person's plate.";
            }

            else if (Dayofweek == "Saturday")
            {
                Quote = "Your positive action combined with positive thinking results in success.";
            }

            else if (Dayofweek == "Sunday")
            {
                Quote = "Words build bridges into unexplored regions.";
            }


            Console.WriteLine("Today is "+Dayofweek+"\nTodays quote is "+Quote);
            Console.ReadKey(); 

        }
    }
}
