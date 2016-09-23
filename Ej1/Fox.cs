using System;

namespace Ej1
{
	public class Fox:Animal
	{
		public override void HacerRuido ()
		{
			Console.WriteLine("what does the fox says?");
			Console.ReadKey();
			for (Int32 h = 0; h < 50; h++)
			{
				Console.WriteLine(" Ring-ding-ding-ding-dingeringeding!   ");
			}
			Console.ReadKey();
		}
		public Fox ()
		{
		}
	}
}

