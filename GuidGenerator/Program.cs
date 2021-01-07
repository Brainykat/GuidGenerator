using System;

namespace GuidGenerator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Chris!");
      for (int i = 0; i < 5; i++)
      {
        Guid guid = Guid.NewGuid();
        Console.WriteLine(guid.ToString().ToUpper());
      }
    }
  }
}
