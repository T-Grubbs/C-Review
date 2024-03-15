using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // TODO: Declare an array of values
            int[] vals = new int[5];
            string[] strs = { "one", "two", "three" }; //when you know what the values will be you can add them in curlys

            // TODO: Print the values using a Formatting String
            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, c, b, str, f, d, x, z);

            // TODO: "null" means "no value"
            object obj = null;
            Console.WriteLine(obj);//will not print because it has no value

            // TODO: Implicit conversion between types
            long bignum;
            bignum = i; //i is originally assigned an int (see above) since it is int- type it can convert from int to long


            // TODO: Explicit conversions (casting?)
            float i_to_f = (float)i; //to exlicitly convert i to a float, you must have (float)
            Console.WriteLine("{0}", i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine("{0}", f_to_i);

        }
    }
}
