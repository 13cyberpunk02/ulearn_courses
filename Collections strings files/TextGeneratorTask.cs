using System.Collections.Generic;
namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(
            Dictionary<string, string> nextWords,
            string phraseBeginning,
            int wordsCount)
        {
            if(nextWords.Count < 1 || wordsCount == 0)
                return phraseBeginning;
            for (int i = 0; i < wordsCount; i++)
            {
                int keyLength = phraseBeginning.Split().Length;
                var keys = phraseBeginning.Split();
                if(keyLength > 1)
                {
                    string key = keys[keyLength - 2] + " " + keys[keyLength - 1];
                    if(nextWords.ContainsKey(key))
                        phraseBeginning += " " + nextWords[key];
                    else
                    {
                        key = keys[keyLength - 1];
                        if(nextWords.ContainsKey(key))
                            phraseBeginning += " " + nextWords[key];
                        else
                            return phraseBeginning;
                    }
                }
                else
                {
                    if(nextWords.ContainsKey(phraseBeginning))
                        phraseBeginning += " " + nextWords[phraseBeginning];
                    else
                        return phraseBeginning;
                }   
            }
            return phraseBeginning;
        }
    }
}
