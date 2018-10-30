using System;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Sequencia de Fibonacci: ");
    FuncaoRecursiva(0, 1, 1);
	}

	static int FuncaoRecursiva(int a, int b, int c)
	{
    Console.WriteLine(c);
    a = b;
    b = c;
    c = b + a;

    if (a < 1000)
    {
      return FuncaoRecursiva(a, b, c);
    }
    else
    {
      return 1;
    }
  }
}