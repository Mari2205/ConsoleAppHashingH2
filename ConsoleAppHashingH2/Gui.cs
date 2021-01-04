using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashingH2
{
    class Gui
    {
        public void SetMenuHeading()
        {
            string acsiiMenu = @"                
 /$$   /$$                     /$$            
| $$  | $$                    | $$            
| $$  | $$  /$$$$$$   /$$$$$$$| $$$$$$$       
| $$$$$$$$ |____  $$ /$$_____/| $$__  $$      
| $$__  $$  /$$$$$$$|  $$$$$$ | $$  \ $$      
| $$  | $$ /$$__  $$ \____  $$| $$  | $$      
| $$  | $$|  $$$$$$$ /$$$$$$$/| $$  | $$      
|__/  |__/ \_______/|_______/ |__/  |__/                                                  
";

            Console.WriteLine(acsiiMenu);
        }
        public void SetMenuBody(string[] listOfChoices)
        {
            int numbering = 1;
            foreach (string choices in listOfChoices)
            {
                Console.WriteLine(numbering + ") " + choices.ToString());
                numbering++;
            }
        }

        public void SetHashMassage(string hashName, byte[] hashMessageNo1, byte[] hashMessageNo2)
        {
            Console.WriteLine($"<" +
                $"\n{hashName} Hashes \n");
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(hashMessageNo1));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(hashMessageNo2));
        }
    }
}
