using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            sentence = String.Join(" ", words);
            return sentence;
        }
    }
}
