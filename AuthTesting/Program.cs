using System;

namespace AuthTesting
{
   public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Something()
        {
            return "Holaa Mundo";
        }

        public static bool Login(string user, string password) =>
            user == "hdeleon" && password == "132456" ? true : false;

    }


    public class Calcs
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    
}
