using System;

namespace CWTest
{
    class Program
    {
        public static int StringToNumber(string str){
            string _str = str;
            return  Convert.ToInt32(_str);
          
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            StringToNumber("1234");
        }
    }
}
