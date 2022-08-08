using System.Collections.Generic;
using System.Text;
using System;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            var separatorForSentences = new char[] { '.', '!', '?', ';', ':', '(', ')' };
            var sentences = text.Split(separatorForSentences, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentence in sentences)
            {
                var wordsList = new List<string>();
                var builder = new StringBuilder();
                foreach (var letter in sentence)
                {
                    if (char.IsLetter(letter) || letter == '\'') builder.Append(letter);
                    else builder.Append(" ");
                }
                var checksentence = builder.ToString().Split();
                foreach (var word in checksentence)
                {
                    if (!string.IsNullOrWhiteSpace(word)) wordsList.Add(word.ToLower());
				}
				if(wordsList.Capacity > 0)
                	sentencesList.Add(wordsList);
            }
            return sentencesList;
        }
    }
}
