using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class Words
    {
        private List<string> words;
        private Random randomWord;

        public Words()
        {
            words = new List<string>();
            randomWord = new Random();
        }

        public Words(string keyword) : this()
        {
            SetWord(keyword);
        }

        public Words(List<string> keywords) : this()
        {
            SetWords(keywords);
        }

        public void SetWord(string keyword)
        {
            if (keyword.All(char.IsLetter))
            {
                words.Add(keyword.ToLower());
            }
        }

        public void SetWords(List<string> keywords)
        {
            keywords.RemoveAll(i => !i.All(char.IsLetter));
            keywords = keywords.Select(k => k.ToLower()).ToList();
            words.AddRange(keywords);
        }

        public List<string> GetWords()
        {
            return words;
        }

        public string RandomWord()
        {
            if (words.Count == 0) return string.Empty;

            int chosenWord = randomWord.Next(words.Count);
            return words[chosenWord];
        }

      

        
    }
}
