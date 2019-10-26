using System;

namespace Examplemetod
{
    public class Metodo
    {
        public static bool Example1()
        {
            double a = 1.0 / 10.0;
            double s = a + a + a + a + a + a + a + a + a + a;
            if(s == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Example2()
        {
            double a = 1.0 / 10.0;
            double m = a * 10;
            if (m == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
