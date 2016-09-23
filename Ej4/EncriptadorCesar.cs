using System;

namespace Ej4
{
	public class EncriptadorCesar:Encriptador
	{
		private int iDesplazamiento;

		public int Desplazamiento
		{
			get{return this.iDesplazamiento;}
			set{this.iDesplazamiento = value;}
		}
		override string Encriptar (string pCadena)
		{
			String cadenaFinal,aux = "";
			aux = pCadena;
			for (int i = 0; i <this.Desplazamiento; i++) 
			{
				aux [pCadena.Length + i + 1] = pCadena [i];
			}
			for (int j=3; j<aux.Length; j++) 
			{
				cadenaFinal += aux [j];
			}
			return cadenaFinal;
		}

		public EncriptadorCesar ()
		{
		}
	}
}

