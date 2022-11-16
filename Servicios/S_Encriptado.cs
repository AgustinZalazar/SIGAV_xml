using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Servicios
{
    public class S_Encriptado
    {
        public static string Encriptar(string Password)
        {
            try
            {
                UnicodeEncoding UeCodigo = new UnicodeEncoding();
                byte[] ByteSourceText = UeCodigo.GetBytes(Password);
                MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
                byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
                return Convert.ToBase64String(ByteHash);
            }
            catch (CryptographicException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
