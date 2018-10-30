using System;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Digite os numeros para fazer a operacao: ");
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());

		FuncaoRecursiva(x, y, 1);
	}

	static int FuncaoRecursiva(int x, int y, int i)
	{
    int number1 = x;
    int number2 = y;

    if (i > number1 || i > number2)
    {
      return 0;
    }
    else if (x % i == 0 && y % i == 0)
    {
      Console.WriteLine("O MDC é: " + i);
      i = i + 1;
      return FuncaoRecursiva(number1, number2, i);
    }
    else
    {
      i = i + 1;
      return FuncaoRecursiva(number1, number2, i);
    }
  }
}