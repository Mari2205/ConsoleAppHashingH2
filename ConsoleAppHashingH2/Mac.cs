using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleAppHashingH2
{
    class Mac
    {
        public static byte[] GetMacSha1(byte[] getHashed)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(getHashed);
            }
        }

        public static byte[] GetMacSha256(byte[] getHashed)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(getHashed);
            }
        }

        public static byte[] GetMacSha512(byte[] getHashed)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(getHashed);
            }
        }

        public static byte[] GetMacMd5(byte[] getHashed)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(getHashed);
            }
        }
    }
}
