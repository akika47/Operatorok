using System.Collections.Generic;
using System.Threading.Channels;

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

			//5.feladat
			Console.WriteLine("5. feladat: Statisztika");
			kifejezesek.GroupBy(x => x.Op).Where(x => x.Key == "mod" || x.Key == "/" || x.Key == "div" || x.Key == "-" || x.Key == "*" || x.Key == "+").OrderBy(x => x.Key).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()}"));

            //7.feladat
            Console.WriteLine("7. feladat: Kérek egy kifejezeést (pl.: 1 + 1): ");
			string kifejezes = Console.ReadLine();


            //8.feladat
            using (StreamWriter wr = new StreamWriter("eredmények.txt"))
			{
				foreach (var item in kifejezesek)
				{
					wr.WriteLine($"{item.ElsoSzam} {item.Op} {item.MasodikSzam} = ");
				




			}
			//6.feladat
			string Kiszamol(string kifejezes)
			{
				string eredmeny = "";
				if (kifejezes.Equals("vége"))
				{
					return "vége";
				}

				string[] kif = kifejezes.Split(' ');
				try
				{
					if (kif[1] == "+")
					{
						eredmeny = $"{int.Parse(kif[0]) + int.Parse(kif[1])}";
					}
					else if (kif[1] == "-")
					{
						eredmeny = $"{int.Parse(kif[0]) - int.Parse(kif[1])}";
					}
					else if (kif[1] == "*")
					{
						eredmeny = $"{int.Parse(kif[0]) * int.Parse(kif[1])}";
					}
					else if (kif[1] == "/")
					{
						eredmeny = $"{int.Parse(kif[0]) / int.Parse(kif[1])}";
					}
					else if (kif[1] == "mod")
					{
						eredmeny = $"{int.Parse(kif[0]) % int.Parse(kif[1])}";
					}
					else if (kif[1] == "div")
					{

						eredmeny = $"{Math.Floor(double.Parse( kif[0])) / Math.Floor(double.Parse(kif[1]))}";
					}
					else { Console.WriteLine("Hibás operátor!"); }
				}
				catch (Exception)
				{
					Console.WriteLine("Egyéb Hiba!");
					throw; 
				}
				return eredmeny;
			}
		}
	}
}