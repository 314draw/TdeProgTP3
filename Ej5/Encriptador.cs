using System;

namespace Ej5
{
	public class Encriptador:IEncriptador
	{
		private String iNombre;

		public String Nombre
		{
			get{return this.iNombre;}
			set{this.iNombre = value;}
		}

		public String Encriptar(String pCadena)
		{
			return "holis";
		} 
		public  String DesEncriptar(String pCadena)
		{
			return "holis";
		}
		public Encriptador ()
		{

		}
	}
}

