using System;

namespace Exams
{
  class Program
  {
    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] vs = input.Split(' ');
      int A = int.Parse(vs[0]);
      int B = int.Parse(vs[1]);
      int n = int.Parse(vs[2]);
      int X = (A + B) / 2;
      if (X <= B && X >= A)
      {
        Console.WriteLine("NO");
      }
      else
      {
        if (A % X < n)
        {
          Console.WriteLine("NO");
        }
        else
        {
          Console.WriteLine("YES");
        }
      }
    }
  }
}
