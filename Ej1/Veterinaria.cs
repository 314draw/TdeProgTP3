using System;

namespace Ej1
{
	public class Veterinaria
	{
		/// <summary>
		/// Lista los animales y les pide que hagan ruido
		/// </summary>
		/// <param name="pAnimales">listado de animales</param>
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

