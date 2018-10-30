using System;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Digite os numeros para fazer a operacao: ");
		int x = Convert.ToInt32(Console.ReadLine());
		int y = Convert.ToInt32(Console.ReadLine());

		FuncaoRecursiva(x, y);
	}

	static int FuncaoRecursiva(int x, int y, int z = 0)
	{
		if (x == 0)
		{
			return 1;
		}
		else
		{
			z = z + y;
			x = x - 1;
			Console.WriteLine(z);
			return FuncaoRecursiva(x, y, z);
		}
	}
}