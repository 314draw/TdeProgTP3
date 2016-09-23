using System;

namespace Ej1
{
	public class Veterinaria
	{
		/// <summary>
		/// A
		/// </summary>
		/// <param name="pAnimales">P animales.</param>
		public void AceptarAnimales(Animal[] pAnimales)
		{
			for (Int16 i=0; i<pAnimales.Length; i++) 
			{
				pAnimales [i].HacerRuido ();
			}
		}
		public Veterinaria ()
		{
		}
	}
}

