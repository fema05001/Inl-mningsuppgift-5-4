using System;
namespace Uppgift_5_4
{
    class program
    {
        static void Main(string[] args)
        {
            string b = (" ");
            string[] a = new string[5];
            a[0] = ("Håkan ");
            a[1] = ("Adam ");
            a[2] = ("David ");
            a[3] = ("patrik ");
            a[4] = ("Amin");
            int j = 1;
            int y = 1;

            for (int i = 0; i < 5; i++)
            {
               
                {
                    y++;
                }
                while (y == 1)
                {
                    if (a[i][0] < a[j][0])
                    {
                        b = a[i];
                    }
                    y--;
                }
                if (b == " ")
                {
                    b = a[i];
                }
               if (a[i][0] < b[0])
                {
                    b = a[i];
                }
               if (b[0] == a[i][0] & a[i][1] != b[1])
                {
                    b = b + a[i];
                }
               
            }
            Console.WriteLine(b );
        }
    }
}