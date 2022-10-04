using System;

namespace CardValidation
{
    public class validation
    {
        public static bool isvalid(long number)
        {
            int x = sumofDoubleEvenPlace(number) + sumofOddPlace(number);
            if (x % 10 == 0)
            return true;
            else 
                return false;
        }
        public static int sumofDoubleEvenPlace(long number)
        {
            int z = 0;
            int count = 0;
            string a = number.ToString();

            for (int i = a.Length - 1; i > -1; i--)
            {
                count++;
                if (count % 2 == 1)
                {
                    continue;
                }
                else
                {
                    int dob = 0;
                    dob = 2 *( (int)(a[i]) - 48 );
                    dob = getdigit(dob);

                    z = z + dob;
                }
               
            }
            return z;
        }
        public static int getdigit(int number)
        {
            int alt = 0;
            string a = number.ToString();
            if (a.Length == 1)
                return number;
            else
                foreach (char c in a)
                {
                    alt = alt + (int)(c) - 48;
                }
            return alt;  
        }
        public static int sumofOddPlace(long number)
        {
            int z = 0;
            int count = 0;
            string a = number.ToString();

            for(int i = a.Length - 1; i > -1 ; i-- )
            {
                count ++;
                if (count%2 == 0)
                {
                    continue;
                }
                else
                {
                    z = z + (int)(a[i]) - 48;
                }

            }

            return z;
        }
        public static bool PrefixMatched(long number, int d)
        {
            string a = number.ToString();

            int first = (int) a[0];

            first = first - 48;


            if (first == d)
            return true;
            else
                return false;
        }
        public static int getSize(long d)
        {
            string a = d.ToString(); 
            return a.Length; ;
        }
        public static long getPrefix(long number, int k)
        {
            string a = number.ToString();

            if (k > a.Length)
            return number;
            else
            {
                string v = (a.Substring(0, k));
                long q = long.Parse(v);
                return q;
            }


        }




    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(validation.isvalid(4388576018410707)); // valid
            Console.WriteLine(validation.isvalid(4388576018402626)); // not valid
          
        }
    }
}
