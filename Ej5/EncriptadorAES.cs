using System;
using System.IO;
using System.Security.Cryptography;

namespace Ej5
{
	public class EncriptadorAES:Encriptador
	{

		public String Encriptar(String pCadena)
		{
			Array aux;
			using (Aes aesAlg = Aes.Create()) 
			{
				ICryptoTransform encryptor = aesAlg.CreateEncryptor ();

				// Create the streams used for encryption.
				using (MemoryStream msEncrypt = new MemoryStream()) 
				{
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) 
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {

							//Write all data to the stream.
							swEncrypt.Write (pCadena);
						}
						aux = msEncrypt.ToArray ();
					}
				}
			}
			return aux.ToString();
		}
		public String DesEncriptar(String pCadena)
		{
			Byte cipherText = Convert.ToByte (pCadena);
			string plaintext = null;

			// Create an Aes object
			// with the specified key and IV.
			using (Aes aesAlg = Aes.Create())
			{
				// Create a decrytor to perform the stream transform.
				ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
				// Create the streams used for decryption.
				using (MemoryStream msDecrypt = new MemoryStream(cipherText))
				{
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))
						{

							// Read the decrypted bytes from the decrypting 
							// and place them in a string.
							plaintext = srDecrypt.ReadToEnd();
						}
					}
				}

			}

			return plaintext;
		}
		public EncriptadorAES ()
		{

		}
	}
}

