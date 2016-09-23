using System;

namespace Ej1
{
	public class Animal
	{
		public virtual void HacerRuido()
		{
			Console.WriteLine ("saltando");
		}
		public void Correr()
		{
			Console.WriteLine ("corriendo");
		}
		public Animal ()
		{
		}
	}
}

