using NUnit.Framework;
using System;

namespace Ej4
{
	[TestFixture()]
	public class TestEncriptadorCesar
	{
		[Test()]
		public void TestEncriptar()
		{
			String cadena = "Elefante";
			String ResultadoEsperado = " fanteEle";
			int desplazamiento = 3;
			EncriptadorCesar ECesar= new EncriptadorCesar(desplazamiento);
			Assert.Equals (ECesar.Encriptar (cadena), ResultadoEsperado);
		}
		[Test()]
		public void TestDesEncriptar()
		{
			String cadena = "Elefante";
			String ResultadoEsperado = "fanteEle";
			int desplazamiento = 3;
			EncriptadorCesar ECesar = new EncriptadorCesar (desplazamiento);
			Assert.Equals (ECesar.DesEncriptar (ResultadoEsperado), cadena);
		}
	}
}

