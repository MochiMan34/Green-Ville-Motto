using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1
{
    
    class Program
    {
        public static String greenvilleText = "The stars shine in Greenville.";
        public static String BottomBorder = "";
        public static String topBorder = "";
        
        


        static void Main(string[] args)
        {
            greenvilleMotto();
            System.Console.WriteLine(" ");
            greenvilleMotto2(); 
           


            System.Console.ReadKey();
        }

        public static void greenvilleMotto()
        {
            System.Console.WriteLine(greenvilleText);   
            


        }

        public static void greenvilleMotto2()
        {
            generateAsteriskBorder(topBorder);
            System.Console.WriteLine("*" + greenvilleText + "*");
            generateAsteriskBorder(BottomBorder);
        }

        public static void generateAsteriskBorder(String text)
        {
            for(int i = 0; i < greenvilleText.Length+2; i++)
            {
                text += "*"; 
            }
            System.Console.WriteLine(text); 
        }

       

      

      
    }
}
