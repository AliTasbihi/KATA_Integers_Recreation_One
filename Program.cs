using System;

namespace KATA_Integers_Recreation_One
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(IntegersRecreationOne.listSquared(6,10));
        }
    }

    public class IntegersRecreationOne
    {
        public static string listSquared(long m, long n)
        {
            if (n-m<0)
            {
                return null;
            }

            if (m<0||n<0)
            {
                return null;
            }
            double sumdivisor = 0;
            string stroutput = "";
            for (long i = m; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sumdivisor += j * j;
                    }
                }
                if (Math.Sqrt(sumdivisor) == Convert.ToInt32(Math.Sqrt(sumdivisor)))
                {
                    stroutput += "[" + i + ", " + sumdivisor + "]";
                    stroutput += ", ";
                }

                sumdivisor = 0;
            }

            if (stroutput=="")
            {
                return null;
            }
            return string.Format("[{0}]", stroutput.Remove(stroutput.Length - 2, 2));
        }
    }
}
