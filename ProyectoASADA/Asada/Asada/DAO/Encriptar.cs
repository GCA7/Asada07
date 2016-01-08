using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Asada2015.DAO
{
    public class Encriptar
    {

        public Encriptar()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Método para encriptar un texto plano usando el algoritmo (Rijndael)
        /// </summary>
        /// <returns>Texto encriptado</returns>
        /*public string Cifrar(string pass)
        {
            string passBase = "pass75dc@avz10";
            string saltValue = "s@lAvz";
            string hashAlgorithm = "MD5";
            int passwordIterations = 1;
            string initVector = "@1B2c3D4e5F6g7H8";
            int keySize = 128;
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(pass);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passBase, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);

            RijndaelManaged symmetricKey = new RijndaelManaged()
            {
                Mode = CipherMode.CBC
            };

            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            return cipherText;
        }*/


        /// <summary>
        /// Metodo para desifrar contraseña
        /// </summary>
        /// <param name="clave"> palabra a descifrar </param>
        /// <returns></returns>
        /*public string Descifrar(string clave)
        {
            string key = "ABCDEFG54619525PQRSTUVWXYZabcdef752846opqrstuvwxyz";
            byte[] keyArray;

            //convierte el texto en una secuencia de bytes
            byte[] Array_a_Descifrar = Convert.FromBase64String(clave);

            //se llama a las clases que tienen los algoritmos
            //de encriptación se le aplica hashing
            //algoritmo MD5

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
            tdes.Clear();

            //se regresa en forma de cadena
            return UTF8Encoding.UTF8.GetString(resultArray);

        }*/


        public string Cifrar(string pass) /*{ 
            
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(pass));

            for (int i = 0; i < stream.Length; i++)
            
                sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            
        }*/
        {

            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(pass);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                // Convertimos los valores en hexadecimal
                // cuando tiene una cifra hay que rellenarlo con cero
                // para que siempre ocupen dos dígitos.
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            //Devolvemos la cadena con el hash en mayúsculas para que quede más chuli :)
            return sb.ToString().ToUpper();
        }
    }
}
