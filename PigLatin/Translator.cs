using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
    public class Translator
    {
        public static bool IsVowel(char ch)
        {
            // returns true if it’s a vowel, false if it’s a consonant
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool StartsWithVowel(string word)
        {
            bool result = IsVowel(word[0]);
            return result;
    
        }

        public static int NumberofCons(string word)
        {
            int index = 0;
            while (IsVowel(word[index]) == false)
            {
                index++;
            }

            return index;
        }

        // two methods for piglatinizing a word 

        public static string PigLatinVowels(string word)
        {
            return word + "yay";
        }

        public static string PigLatinCons(string word)
        {
            int cons = NumberofCons(word);
            string start = word.Substring(0, cons);
            string newWord = word + start + "ay";
            newWord = newWord.Remove(0, cons);
            return newWord;

        }

        public static string PigLatinize(string word)
        {
            if (StartsWithVowel(word))
            {
                return PigLatinVowels(word);
            }
            else
            {
                return PigLatinCons(word);
            }
        }
    }
}
