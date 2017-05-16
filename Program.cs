using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eng_Viet_Dictionary
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            while(true)
            {
                menu();

                Console.WriteLine("Would you like to continue using the dictionary?(Y/N):");
                string s = Console.ReadLine();
                if (s == "N")
                    break;
            }
            Console.WriteLine("BYE BYE!");
        }

        private static void menu()
        {
            Console.WriteLine("1. Create new word");
            Console.WriteLine("2. Edit word");
            Console.WriteLine("3. Search word");
            Console.WriteLine("4. Delete word");
            Console.WriteLine("Which options do you choose?");

            try
            {
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CreateNewWord();
                        break;
                    case 2:
                        EditWord();
                        break;
                    case 3:
                        SearchWord();
                        break;
                    case 4:
                        DeleteWord();
                        break;
                    default:
                        Console.WriteLine("Don't have option {0}", option);
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: "+e.Message);

            }
            
        }

        private static void DeleteWord()
        {
            Console.WriteLine("Please enter english which you want to delete: ");
            string engWord = Console.ReadLine();
            if(dic.ContainsKey(engWord))
            {
                dic.Remove(engWord);
                Console.WriteLine("Deleted successfully english word[{0}]", engWord);
            }
            else
            {
                Console.WriteLine("Did'nt find out english word[{0}]", engWord);
            }
        }

        private static void SearchWord()
        {
            Console.WriteLine("Please enter english word: ");
            string engWord = Console.ReadLine();
            if(dic.ContainsKey(engWord))
            {
                string vietWord = dic[engWord];
                Console.WriteLine("Meaning of [{0}] is: [{1}]", engWord,vietWord);
            }
            else
            {
                Console.WriteLine("English word[{0}] haven't update!", engWord);
            }
        }

        private static void EditWord()
        {
            Console.WriteLine("Please enter english word which you want to edit:");
            string engWord = Console.ReadLine();
            if(dic.ContainsKey(engWord)==false)
            {
                Console.WriteLine("Did'nt find out english word[{0}]", engWord);
            }
            else
            {
                Console.WriteLine("Please enter Vietnamese meaning again:");
                string vietWord = Console.ReadLine();
                dic[engWord] = vietWord;
            }
        }

        private static void CreateNewWord()
        {
            Console.WriteLine("Please enter English word: ");
            string engWord = Console.ReadLine();
            if(dic.ContainsKey(engWord))
            {
                Console.WriteLine("English word[{0}] existed", engWord);
            }
            else
            {
                Console.WriteLine("Please enter Vietnamese meaning:");
                string vietWord = Console.ReadLine();
                dic.Add(engWord, vietWord);
            }
        }
    }
}
