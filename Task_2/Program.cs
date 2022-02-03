using System;

namespace Task_2
{
  class Program
  {
    static string FindQuantity(ulong n, ulong m) 
    {
      string output;
      ulong count = 0;
      ulong difference = 0;
      ulong maxSpace = n * m;
      if (n > m)
      {
        while (maxSpace >= m * m)
        {
          maxSpace -= m * m;
          count++;
        }
        difference = n * m - count * m * m;
      }
      else if (m > n)
      {
        while (maxSpace >= n * n)
        {
          maxSpace -= n * n;
          count++;
        }
        difference = n * m - count * n * n;
      }
      else
      {
        count = 1;
        difference = 0;
      }
      output = count.ToString() + " " + difference.ToString(); 
      return output;
    }
    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] vs = input.Split(' ');
      ulong N = ulong.Parse(vs[0]);
      ulong M = ulong.Parse(vs[1]);
      input = FindQuantity(N, M);
      vs = input.Split(' ');
      ulong count = ulong.Parse(vs[0]);
      ulong difference = ulong.Parse(vs[1]);
      while (difference > 0)
      {
        if (N > M)
        {
          input = FindQuantity(N % M, M);
          vs = input.Split(' ');
          count += ulong.Parse(vs[0]);
          difference = ulong.Parse(vs[1]);
        }
        else
        {
          input = FindQuantity(N , M % N);
          vs = input.Split(' ');
          count += ulong.Parse(vs[0]);
          difference = ulong.Parse(vs[1]);
        }
      }
      Console.WriteLine(count);
    }
  }
}
