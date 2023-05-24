using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operátorok
{
	internal class Operatorok
	{
		int elsoSzam;
		string op;
		int masodikSzam;

		public Operatorok(int elsoSzam, string op, int masodikSzam)
		{
			this.elsoSzam = elsoSzam;
			this.op = op;
			this.masodikSzam = masodikSzam;
		}

		public int ElsoSzam { get => elsoSzam;}
		public string Op { get => op;}
		public int MasodikSzam { get => masodikSzam;}
	}
}
