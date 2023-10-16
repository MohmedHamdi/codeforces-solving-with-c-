// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

int t = Convert.ToInt32(Console.ReadLine());
while (t > 0)
{
    MyClass1 meth = new MyClass1();
    int n = Convert.ToInt32(Console.ReadLine());
    string s = Console.ReadLine();
    string[] s2 = s.Split(' ');
    int[] arr = new int[s2.Length];
    int[] arr2 = new int[n];
    for (int i = 0; i < s2.Length; i++)
    {
        int k = Convert.ToInt32(s2[i]);
        arr[i] = k;


    }
    Array.Sort(arr);
    int x = 0, r = 0, l = 0, count = n - 1;
    //0 0 1
    int c, x1;
    int count1 = n - 1;
    for (int i = 0; i < arr.Length; i++)
    {

        x = meth.Frq(arr, arr.Length, arr[i]);
        x1 = x;
        if (x == ( count1- r))
        {
            Console.Write(arr[i] + " ");
            r++;
        }
        else
        {
            c = n - 1;
            count = 0;
            int d = r;

            for (int j = r; j < n; j++)
            {
                count += (c - r);
                if (count == x)
                {
                    r++;
                    break;


                }
                r++;




            }
            for (int m = d; m < r; m++)
            {
                Console.Write(arr[i] + " ");
            }
            d = r;

        }
        i += x1 - 1;



    }
    Console.WriteLine(arr[arr.Length - 1] );



    t--;
}

public class MyClass1
{

    public int Frq(int[] arr, int n, int l)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (l == arr[i])
            {
                sum++;
            }


        }
        return sum;
    }
    public int print(int result, int n, int x, int r)
    {
        int r1 = r;
        while (x > 0)
        {
            Console.Write(result + " " + x + "\n");
            r1++;
            x -= (n);
        }
        return r1;
    }
}
