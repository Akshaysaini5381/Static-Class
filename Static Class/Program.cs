using System;

namespace Static_Class
{
    static class myclass
    {
        static myclass()
        {
            Console.WriteLine("Static Constructor :");
        }
        public static void show()
        {
            Console.WriteLine("Static method  :");
        }
        
       
    } 
    class Program
    {
        static void Main(string[] args)
        {
           
            myclass.show();
        }
    }
}
