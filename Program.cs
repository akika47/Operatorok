namespace Operátorok 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Operatorok> kifejezesek = new List<Operatorok>();
			StreamReader sr = new StreamReader("kifejezesek.txt");
			while (!sr.EndOfStream)
			{
				var mezok = sr.ReadLine().Split(' ');
				Operatorok beolvas = new Operatorok(int.Parse(mezok[0]), mezok[1], int.Parse(mezok[2]));
				kifejezesek.Add(beolvas);
			}
			sr.Close();


			//2.feladat
			Console.WriteLine($"2. feladat: Kifejezések száma: {kifejezesek.Count}");

			//3.feladat
			Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {kifejezesek.Count(x => x.Op == "mod")}");

			//4.feladat
			if (kifejezesek.Any(x => x.ElsoSzam % 10 == 0 && x.MasodikSzam % 10 == 0) == true)
			{
				Console.WriteLine("4. feladat: Van ilyen kifejezés!");
			}
			else { Console.WriteLine("4. feladat: Nincs ilyen kifejezés!"); }



			

		}
	}
}