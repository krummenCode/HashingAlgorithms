using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltHashOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectedOption;
            string input;
            Hash hasher = new Hash();

            Console.WriteLine("This program shows what hashing does to an input(password).");
            Console.WriteLine("What would you like to see hashed?");
            input = Console.ReadLine();
            Console.WriteLine("What method of hashing would you like to try: Additive, Folding, SHA256, SHA256 with salt?");
            selectedOption = Console.ReadLine().ToLower();
            switch (selectedOption)
            {
                case ("additive"):
                    string r = hasher.AdditiveHashing(input);
                    Console.WriteLine(r);
                    break;
                case ("folding"):
                    //string f = hasher.FoldingHashing(input);
                    //Console.WriteLine(f);
                    Console.WriteLine("Fold is under developement! Sorry for the inconvience, SHA256 is stronger...");

                    break;
                case ("sha256"):
                    string sha = hasher.SHA256HashingNoSalt(input);
                    Console.WriteLine(sha);
                    break;
                case ("sha256 with salt"):
                    string salt = hasher.SHA256HashingWithSalt(input);
                    Console.WriteLine(salt);
                    break;
                default:
                    Console.WriteLine("Not an option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
