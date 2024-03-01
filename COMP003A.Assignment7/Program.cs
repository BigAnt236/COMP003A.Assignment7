/*
 * Author: Anthony Alvarez
 * Course: COMP003A
 * Purpose: Week 7 Assignment
 */
namespace COMP003A.Assignment7
{
    internal class Program
    {
        private static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
        }

        private static int CharacterCounter(char characterInput, string word)
        {
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            int count = 0;

            foreach (char character in word)
            {
                if (character == characterInput)
                {
                    count++;
                }
            }

            return count;
        }

        private static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return word == reversedWord;
        }

        private static void TraverseList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

        private static void Main(string[] args)
        {
            // ... (existing code)

            // Array - CharacterCounter Section
            SectionSeparator("Array - CharacterCounter Section");
            Console.Write("Enter a single letter: ");
            char userCharInput = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line
            Console.Write("Enter a word: ");
            string userWordInput = Console.ReadLine();

            int charCount = CharacterCounter(userCharInput, userWordInput);
            Console.WriteLine($"The character '{userCharInput}' appears {charCount} times in the word '{userWordInput}'\n");

            // Array - IsPalindrome Section
            SectionSeparator("Array - IsPalindrome Section");
            Console.Write("Enter a word: ");
            string userPalindromeInput = Console.ReadLine();

            bool isPalindrome = IsPalindrome(userPalindromeInput);
            Console.WriteLine($"The word '{userPalindromeInput}' {(isPalindrome ? "is" : "is not")} a palindrome.\n");

            // List - Add Section
            SectionSeparator("List - Add Section");
            List<string> names = new List<string>();
            char userInput = default;

            do
            {
                Console.Write("Enter a name: ");
                string enteredName = Console.ReadLine();
                names.Add(enteredName);

                Console.Write("Press any key to add more or (e) to exit: ");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Move to the next line

            } while (userInput != 'e');

            // List - Traversal Section
            SectionSeparator("List - Traversal Section");
            TraverseList(names);

            // List - Reverse Traversal Section
            SectionSeparator("List - Reverse Traversal Section");
            TraverseListReverse(names);
        }
    }
}