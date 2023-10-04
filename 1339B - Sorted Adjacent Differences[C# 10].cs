using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int t1 = Convert.ToInt32(Console.ReadLine());

        while (t1 > 0)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] s2= s.Split(' ');

            long[] arr = new long[s2.Length];
            long[] arr2 = new long[s2.Length];

            for (int i = 0; i < s2.Length; i++)
            {
               long x= Convert.ToInt64(s2[i]);
                arr[i] = x;
            }
            Array.Sort(arr);
            int l= 0;int r= n-1;
            int t= 0;
            while (r > l) {
                arr2[t] = arr[l];
                t++;
                arr2[t]= arr[r];
                l++;
                r--;
                t++;
            }
            Array.Reverse(arr2);
            if(n%2 == 1) { arr2[0] = arr[n / 2]; }
            for(int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine();
            l = 0;r = n-1;
            Array.Clear(arr);
            Array.Clear(arr2);
            t1--;
           
            
        }
    }
}