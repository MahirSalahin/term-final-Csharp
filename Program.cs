using System;
namespace Termfinal
{
     public static class StringExtension{
        public static string Say(this string s)=>s;
     }
    class Program
    {
        enum Days { Sun, Mon = 3, Tue, Wed, Thu, Fri, Sat }
        static void Main(string[] args)
        {
            string s="hello";
            Console.Write(s.Say());
        }
    }
}
