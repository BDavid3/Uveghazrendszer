using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class NovenyFaj
	{
		string nev;
		int nedvessegTartalom; // 100 ideális
		int egeszsegSzint; // 100 max
		int optimalisSuruseg;

		public NovenyFaj(string nev, int optimalisSuruseg)
		{
			this.nev = nev;
			this.optimalisSuruseg = optimalisSuruseg;
			this.nedvessegTartalom = 100;
			this.egeszsegSzint = 100;
		}

		public string Nev { get => nev; set => nev = value; }
		public int NedvessegTartalom { get => nedvessegTartalom; set => nedvessegTartalom = value; }
		public int EgeszsegSzint { get => egeszsegSzint; set => egeszsegSzint = value; }
		public int OptimalisSuruseg { get => optimalisSuruseg; set => optimalisSuruseg = value; }

		public string Azonosito
		{
			get
			{
				return this.nev.Substring(0, 3);
			}
		}

		public override bool Equals(object obj)
		{
			obj = obj as NovenyFaj;

			if (this.nev == ((NovenyFaj)(obj)).nev)
			{
				return true;
			}
			return false;
		}


		public override string ToString()
		{
			return $"{this.nev} nedvesseg: {this.nedvessegTartalom} egeszseg: {this.egeszsegSzint} idealis egyedszam: {this.optimalisSuruseg}";
		}
	}
}
