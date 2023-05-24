namespace Operátorok 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Operatorok> kifejezesek = new List<Operatorok>();
			StreamReader sr = new StreamReader("kifejezesek.txt");
			sr.ReadLine();
			while (!sr.EndOfStream)
			{
				var mezok = sr.ReadLine().Split(' ');
				kifejezesek beolvas = new kifejezesek(int.Parse(mezok[0]), mezok[1][0], int.Parse(mezok[2]));
				kifejezesek.Add(beolvas);
			}
			sr.Close();
			Console.WriteLine("Hello World!");
		}
	}
}