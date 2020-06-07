using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public static class Encode
    {
        public static string HasPassword(string password)
        {
            string hasPass = "";
            foreach (byte item in new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(password)))
            {
                hasPass += item;
            }
            return hasPass;
        }

        public static byte[] Serialize(string message)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, message);
            return stream.ToArray();
        }

        public static string Deserialize(byte[] tokens)
        {
            MemoryStream stream = new MemoryStream(tokens);
            BinaryFormatter formatter = new BinaryFormatter();
            return (string)formatter.Deserialize(stream);
        }
    }
}
