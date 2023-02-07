using System;

namespace myApp
{
    class Mee
    {
        static void myMethod()
        {
            Console.WriteLine("My punie Mf");
        }
        // parameters act as variables inside a method, then when the 
        //parameter is passed inside a method is called a argument
          static void myMethod2(string fname, int age)
        {
            Console.WriteLine(fname +" "+"is"+" "+ age);
        }
        //someone can also use a default parameter value the = sighn
        static void myMethod3(string country = "Norway")
        {
            Console.WriteLine("All from" +country);
        }
        static void Main(string[] args)
        {
            myMethod();
            myMethod2("Ras", 12);
            myMethod2("Memie", 30);
            myMethod2("Fancy", 23);

            myMethod3("Kenya");
            myMethod3();
            myMethod3("Tz");

        }
    }
}
