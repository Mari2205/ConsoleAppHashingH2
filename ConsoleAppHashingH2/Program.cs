using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashingH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();

            string[] choicesForTheUser = { "Sha1", "Sha256", "Sha512", "MD5" };

            gui.SetMenuHeading();

            Console.WriteLine("Original Text:");
            string originalText = Console.ReadLine();

            Console.WriteLine("Control Text:");
            string controlText = Console.ReadLine();

            Console.WriteLine("do you want an key {true or false}");
            bool usrkey = Convert.ToBoolean(Console.ReadLine());

            gui.SetMenuBody(choicesForTheUser);
            int usrNo = Convert.ToInt32(Console.ReadLine());
            byte[] key = Hmac.GenerateKey();

            switch (usrNo)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Original text : " + originalText);
                    Console.WriteLine("Control text : " + controlText);
                    if (usrkey == true)
                    {
                        byte[] hmacSha1Message = Hmac.GetHmacsha1(Encoding.UTF8.GetBytes(originalText), key);
                        byte[] hmacSha1Control = Hmac.GetHmacsha1(Encoding.UTF8.GetBytes(controlText), key);

                        gui.SetHashMassage("Sha 1", hmacSha1Message, hmacSha1Control);
                    }
                    else
                    {
                        byte[] sha1HashedMessage = Mac.GetMacSha1(Encoding.UTF8.GetBytes(originalText));
                        byte[] sha1HashedControl = Mac.GetMacSha1(Encoding.UTF8.GetBytes(controlText));

                        gui.SetHashMassage("Sha 1", sha1HashedMessage, sha1HashedControl);
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Original text : " + originalText);
                    Console.WriteLine("Control text : " + controlText);
                    if (usrkey == true)
                    {
                        byte[] hmacSha256Message = Hmac.GetHmacsha256(Encoding.UTF8.GetBytes(originalText), key);
                        byte[] hmacSha256Control = Hmac.GetHmacsha256(Encoding.UTF8.GetBytes(controlText), key);

                        gui.SetHashMassage("Sha 256", hmacSha256Message, hmacSha256Control);
                    }
                    else
                    {
                        byte[] sha256HashedMessage = Mac.GetMacSha256(Encoding.UTF8.GetBytes(originalText));
                        byte[] sha256HashedControl = Mac.GetMacSha256(Encoding.UTF8.GetBytes(controlText));

                        gui.SetHashMassage("Sha 256", sha256HashedMessage, sha256HashedControl);
                    }
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Original text : " + originalText);
                    Console.WriteLine("Control text : " + controlText);
                    if (usrkey == true)
                    {
                        byte[] hmacSha512Message = Hmac.GetHmacsha512(Encoding.UTF8.GetBytes(originalText), key);
                        byte[] hmacSha512Control = Hmac.GetHmacsha512(Encoding.UTF8.GetBytes(controlText), key);

                        gui.SetHashMassage("Sha 512", hmacSha512Message, hmacSha512Control);
                    }
                    else
                    {
                        byte[] sha512HashedMessage = Mac.GetMacSha512(Encoding.UTF8.GetBytes(originalText));
                        byte[] sha512HashedControl = Mac.GetMacSha512(Encoding.UTF8.GetBytes(controlText));

                        gui.SetHashMassage("Sha 512", sha512HashedMessage, sha512HashedControl);
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Original text : " + originalText);
                    Console.WriteLine("Control text : " + controlText);
                    if (usrkey == true)
                    {
                        byte[] hmacMd5Message = Hmac.GetHmacMd5(Encoding.UTF8.GetBytes(originalText), key);
                        byte[] hmacMd5Control = Hmac.GetHmacMd5(Encoding.UTF8.GetBytes(controlText), key);

                        gui.SetHashMassage("MD 5", hmacMd5Message, hmacMd5Control);
                    }
                    else
                    {
                        byte[] md5HashedMessage = Mac.GetMacMd5(Encoding.UTF8.GetBytes(originalText));
                        byte[] md5HashedControl = Mac.GetMacMd5(Encoding.UTF8.GetBytes(controlText));

                        gui.SetHashMassage("MD 5", md5HashedMessage, md5HashedControl);
                    }
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR chose an non exeting option");
                    Console.ResetColor();
                    break;
            }
            Console.ReadKey();
        }
    }
}
