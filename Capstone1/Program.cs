using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAgain;
            bool cont = true;

            while(cont)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator");
                Console.WriteLine("Enter a line to be translated:");
                string question = Console.ReadLine().ToLower();

                string vowels = "aeiou";
                char vow, word;
                int isConsonant = 0;
                bool exitLoop = false;
                


                for (int v = 0; v < question.Length; v++)
                {

                    word = question[v];

                    for (int i = 0; i < 5; i++) //vowels will never be more than 5
                    {
                        vow = vowels[i];
                        if (vow.Equals(word) == true)
                        {
                            exitLoop = true;
                            break;
                        }

                    }

                    if (exitLoop == true)
                        break;

                    isConsonant = isConsonant + 1;

                }

                if (isConsonant == 0)

                {
                    Console.WriteLine(question + "way");
                }

                else
                {
                    int g = question.Length - isConsonant;

                    string firstLetters = question.Substring(0, isConsonant);


                    Console.WriteLine(question.Substring(isConsonant, g)
                        + firstLetters + "ay");
                }
                 

                bool cont2 = true;
                while(cont2)
                {
                    Console.WriteLine("Continue?(y/n)");
                    doAgain = Console.ReadLine().ToLower();
                    if(doAgain == "y")
                    {
                        cont2 = false;
                    }
                    else if (doAgain == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        cont2 = false;
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again!");
                    }
                }
            }
            Console.ReadLine();
        } 
    }
}

