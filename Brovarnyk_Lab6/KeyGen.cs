using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Brovarnyk_Lab6
{
    static class KeyGen
    {
        static public byte[] GenerateKey(int keyLength, string keyNum = "with 0")
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            byte[] randArr = new byte[keyLength];

            switch(keyNum)
            {
                case "with 0":
                    rng.GetBytes(randArr);
                    break;
                case "without 0":
                    rng.GetNonZeroBytes(randArr);
                    break;
                default:
                    break;
            }

            return randArr;
        }
    }
}
