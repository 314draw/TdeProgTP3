using System;

namespace Ej4
{
	public class EncriptadorNulo:Encriptador
	{
		/// <summary>
		/// Devuelve la Cadena ingresada.
		/// </summary>
		/// <param name="pCadena">Cadena ingresada.</param>
		public String Encriptar(String pCadena)
		{
			return pCadena;
		}
		/// <summary>
		/// Devulve la cadena ingresada.
		/// </summary>
		/// <returns>Cadena ingresada.</returns>
		/// <param name="pCadena">Cadena ingresada.</param>
		public String DesEncriptar(String pCadena)
		{
			return pCadena;
		}
		/// <summary>
		/// Constructor de la clase <c>EncriptadorNulo</c>
		/// </summary>
		public EncriptadorNulo ()
		{
		}
	}
}

