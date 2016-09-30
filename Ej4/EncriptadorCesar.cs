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
		/// <summary>
		/// Encripta la cadena ingresada.
		/// </summary>
		/// <returns>Cadena encriptada.</returns>
		/// <param name="pCadena">Cadena que se desea encriptar.</param>
		public String Encriptar (String pCadena)
		{
			String cadenaFinal, aux;
			aux = Convert.ToString(pCadena [0]);
			for (int i = 1; i <this.Desplazamiento; i++) 
			{
				aux+= pCadena [i];
			}
			cadenaFinal = Convert.ToString (pCadena [this.Desplazamiento]);
			for (int j=(this.Desplazamiento+1); j<pCadena.Length; j++) 
			{
				cadenaFinal += pCadena [j];
			}
			cadenaFinal += aux;
			return cadenaFinal;
		}
		/// <summary>
		/// Des encripta la cadena ingresada.
		/// </summary>
		/// <returns>Cadena desencriptada.</returns>
		/// <param name="pCadena">Cadena que se desea desencriptar.</param>
		public String DesEncriptar(String pCadena)
		{
			String cadenaFinal;
			for (int i = (pCadena.Length-this.Desplazamiento); i <pCadena.Length; i++) 
			{
				cadenaFinal+= pCadena [i];
			}

			for (int j=0; j<(pCadena.Length-this.Desplazamiento); j++) 
			{
				cadenaFinal += pCadena [j];
			}
			return cadenaFinal;
		}
		/// <summary>
		/// Inicializa una nueva instancia de la clase tomando un numero 
		/// entero como desplazamiento.
		/// </summary>
		/// <param name="pDesplazamiento">Desplazamiento utilizado en el encriptador.</param>
		public EncriptadorCesar (int pDesplazamiento)
		{
			this.Desplazamiento = pDesplazamiento;
		}
	}
}

