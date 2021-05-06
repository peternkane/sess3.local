using System;
using System.Globalization;

namespace sess3.local
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menunames = new string[4];
            double[] prices = new double[4];
            Console.WriteLine("Welcome to ACME Restaurant");
            menunames[0] = "Robster Miano";
            prices[0] = 256.4;
            menunames[1] = "Smashed Potato Salad";
            prices[1] = 102.1;
            menunames[2] = "Vegan Sushi";
            prices[2] = 152.8;
            menunames[3] = "Grilled Salmon";
            prices[3] = 93.9;          

            for(int i = 0;  i < menunames.Length; i++ ){  
               
                    foreach(var p in prices){ 

                        Console.WriteLine("Food : " + menunames[i] + " " +"- Price : " + "" + prices[i]+"$" );
                        break;                                              
                    }             
            } 
            
            Console.WriteLine("\nJohn has 150$"); 
            for(int John = 0; John<prices.Length; John++ ) {
                if(prices[John] < 150){
                Console.WriteLine("John can afford Food : " + menunames[John]); }
                else{
                    Console.WriteLine("John can't afford Food : " + menunames[John]);
                }
            }                                         
        }
    }
}
