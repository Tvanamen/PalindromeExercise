using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var newWord = word.ToLower();
            char[] charArray = newWord.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);
            foreach(char letter in newWord)
            {
                if (char.IsDigit(letter))
                {
                    return false;
                }
            }
            
            if (reversed == newWord)
            {
                return true;
            }else
            return false;
        }


    }
    
}
