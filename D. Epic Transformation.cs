

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string s = Console.ReadLine();
                string[] arr = s.Split(' ');
                Array.Sort(arr);
                List<string> list1 = new List<string>(arr);

                int l = 0, k = 1;

                // 1 1 2 2 3 3
                var r = arr.Distinct().ToList();
                ;
                Array.Clear(arr);
                foreach (var k1 in r)
                {
                    arr[l] = k1;
                    l++;


                }
                int l1 = 0;
                int sum = 0, m = 0, max1 = 0;

                for (int i = 0; i < list1.Count();)
                {

                    if (list1[i] == arr[l1])
                    {
                        sum++;
                        i++;
                        m = sum;
                    }

                    else
                    {
                        m = sum;

                        sum = 0;
                        l1++;


                    }
                    if (m > max1)
                    {
                        max1 = m;
                    }




                }
                // Console.WriteLine(max1);
                if (max1 > (list1.Count() - max1))
                {
                    Console.WriteLine(max1 - (list1.Count() - max1));
                }
                else if (n % 2 == 1)
                {
                    Console.WriteLine
                        (1);
                }
                else
                {
                    Console.WriteLine(0);
                }
                list1.Clear();
                Array.Clear(arr);
                l = 0;
                l1--;

                t--;
            }
        }
    }
}