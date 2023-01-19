using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Brovarnyk_Lab6
{
    class PasswordGen
    {
        readonly string password;
        readonly int length;
        const int iterations = 1000;
        byte[] salt0 = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        byte[] result;

        public PasswordGen(string textUsage, string lengthUsage)
        {
            password = textUsage;
            length = int.Parse(lengthUsage);
        }

        public byte[] Result
        {
            get
            {
                this.result = Calculations(this.password, this.length);
                return this.result;
            }
            set
            {

            }
        }

        private byte[] Calculations(string pass, int len)
        {
            Rfc2898DeriveBytes k0 = new Rfc2898DeriveBytes(password, salt0);
            byte[] key = k0.GetBytes(len);
            return key;
        }
    }
}
