using System;
using System.Collections.Generic;

namespace Library
{
    public class Program
    {
        public static string Bomb(string text)
        {
            string[] listOfWordsInText = text.Split(" ");
            List<string> listOfSymbols = new List<string> { ".", ",", "-", "?", "¿", "¡", "!", "_", ":", ";" };

            foreach (string word in listOfWordsInText)
            {
                string fixedWord = "";

                foreach (char character in word)
                {
                    if (listOfSymbols.IndexOf(character.ToString()) == -1)
                    {
                        fixedWord += character;
                    }
                }

                if (fixedWord.ToLower() == "bomb")
                {
                    return "Duck!!!";
                }
            }

            return "There is no bomb, relax.";
        }
    }
}