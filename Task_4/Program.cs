using System;

namespace Task_4
{
  class Program
  {
    static byte N, M;
    static int sum = 0;

    struct Hourse
    {
      static public int x;
      static public int y;
    }
 
    static void Searching()
    {
      if (Hourse.x == M && Hourse.y == N)
      {
        sum++;
      }

      if (Hourse.x + 2 <= M && Hourse.y - 1 > 0)
      {
        Hourse.x = Hourse.x + 2;
        Hourse.y = Hourse.y - 1;
        Searching();
        Hourse.x = Hourse.x - 2;
        Hourse.y = Hourse.y + 1;
      }

      if (Hourse.x + 2 <= M && Hourse.y + 1 <= N)
      {
        Hourse.x = Hourse.x + 2;
        Hourse.y = Hourse.y + 1;
        Searching();
        Hourse.x = Hourse.x - 2;
        Hourse.y = Hourse.y - 1;
      }

      if (Hourse.x + 1 <= M && Hourse.y + 2 <= N)
      {
        Hourse.x = Hourse.x + 1;
        Hourse.y = Hourse.y + 2;
        Searching();
        Hourse.x = Hourse.x - 1;
        Hourse.y = Hourse.y - 2;
      }

      if (Hourse.x - 1 > 0 && Hourse.y + 2 <= N)
      {
        Hourse.x = Hourse.x - 1;
        Hourse.y = Hourse.y + 2;
        Searching();
        Hourse.x = Hourse.x + 1;
        Hourse.y = Hourse.y - 2;
      }
    }

    static void Main(string[] args)
    {
      string input = Console.ReadLine();
      string[] vs = input.Split(' ');
      N = byte.Parse(vs[0]);
      M = byte.Parse(vs[1]);
      if (N == M && N > 3)
      {
        Hourse.x = 2;
        Hourse.y = 3;
        Searching();
        Console.WriteLine(sum * 2);
      }
      else
      {
        Hourse.x = 1;
        Hourse.y = 1;
        Searching();
        Console.WriteLine(sum);
      }
    }
  }
}
