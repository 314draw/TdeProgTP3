using System;

namespace Ej4
{
	public class Encriptador:IEncriptador
	{
		private String iNombre;

		public String Nombre
		{
			get{return this.iNombre;}
			set{this.iNombre = value;}
		}

		public String IEncriptador.Encriptar(String pCadena)
		{

		} 
		public String IEncriptador.DesEncriptar(String pCadena)
		{

		}
		public Encriptador (String pNombre)
		{
			this.Nombre = pNombre;
		}
	}
}

