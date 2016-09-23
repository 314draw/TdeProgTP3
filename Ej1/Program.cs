using System;

namespace Ej1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Veterinaria unaVeterinaria = new Veterinaria();
			Animal[] listado = new Animal[5];
			Perro unPerro= new Perro();
			Gato unGato= new Gato();
			Int32[] op2 = new Int32[5];
			for (Int32 i = 0; i < 5; i++)
			{
				Console.WriteLine("ingresar perro(1) o gato(2) o zorro(3) ");
				Int32 op1 = Convert.ToInt32(Console.ReadLine());

				switch (op1)
				{
					case 1:
					listado[i] = unPerro;
					op2[i] = 1;
					break;
					case 2:
					listado[i] = unGato;
					op2[i] = 2;
					break;
				}
			}
			unaVeterinaria.AceptarAnimales (listado);
			Console.ReadKey();


		}
	}

}
	

