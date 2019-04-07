using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS.Data
{
	public struct Player
	{
		public string Name;
		public float Hp;
		public bool IsVisible;

		public override string ToString() => $"Name {Name} Hp {Hp} IsVisible {IsVisible}";
	}
}
