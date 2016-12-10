using System;
namespace UnionFind
{
	public static class MainClass
	{
		public static void Main()
		{
			Console.WriteLine("Entre com o número");
			var number = int.Parse(Console.ReadLine());

			IUF uf = new QuickUnion(number);


			do
			{
				Console.WriteLine("Entre com o primeiro número");
				var p = int.Parse(Console.ReadLine());

				Console.WriteLine("Entre com o segundo número");
				var q = int.Parse(Console.ReadLine());

				if (!uf.Connected(p, q))
				{
					uf.Union(p, q);
					Console.WriteLine($"Union Ok: {p} {q}");
				}
				else
				{
					Console.WriteLine($"Já estavam conectados: {p} {q}");
				}

				Console.WriteLine("Continuar? Sim(S) Não(N)");
			} while (Console.ReadLine() == "S");

			Console.WriteLine("FIM");
		}
	}
}
