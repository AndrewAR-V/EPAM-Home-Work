using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EPAM_Task_3
{
    public class Pages
    {
        const int NumberOfItems = 5;
        public int N { get; set; }
        public int WordLenght { get; set; }

        public List<string> CreateList(List<string> words)
        {
            Random rand = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            words.Clear();

            for (int i = 0; i < N; i++)
            {
                string word = "";
                for (int j = 0; j < WordLenght; j++)
                {
                    int letter_num = rand.Next(0, letters.Length);
                    word += letters[letter_num];
                }
                words.Add(word);
            }
            return words;
        }

        public List<string> TransformerList(List<string> words) // Sort and deleted some words from list
        {
            for (int i = words.Count - 1; i > -1; i--)
            {
                if (words[i].StartsWith("Z"))
                    words.Remove(words[i]);
                else
                {
                    for (int j = i - 1; j > -1; j--)
                        if (words[i] == words[j])
                            words.RemoveAt(j);

                }
            }

            return words;
        }

        public void DisplayPage(int pageNumber, List<string> words) // display 
        {
            try
            {
                int c;

                c = NumberOfItems * pageNumber;
                for (int i = c - NumberOfItems; i < c; i++)
                {
                    Console.Write(words[i] + " ");
                }
            }

            catch (ArgumentOutOfRangeException) { }
        }
    }

}
