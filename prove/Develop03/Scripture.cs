using System;
using System.Collections.Generic;
using System.Linq;
using ScriptureMemorizer.Models;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private string _reference;
        private List<Word> _words;

        public Scripture(string reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public string GetDisplayText()
        {
            string text = _reference + "\n";
            foreach (var word in _words)
            {
                text += word + " ";
            }
            return text;
        }

        public void HideWords(int count = 1)
        {
            Random rand = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = rand.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public void Reset()
        {
            foreach (var word in _words)
            {
                word.Reveal();
            }
        }
    }
}
