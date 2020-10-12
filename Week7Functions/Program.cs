
using System;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            
            Agecalculator();



        }
        public static void Agecalculator()
        {
            int userinput = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"your age is: {2020 - userinput}");
        } 
        
        
        
       
  
    
    
    
    }
}
