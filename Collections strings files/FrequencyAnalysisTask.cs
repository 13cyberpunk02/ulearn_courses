using System.Collections.Generic;
namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            return GetNGramms(text);            
		}

        private static Dictionary<(string, string), int> GetBgrams(List<List<string>> text)
        {
            var result = new Dictionary<(string, string), int>();
            foreach (var word in text)
            {
                for (int i = 0; i < word.Count - 1; i++)
                {
                    var key = (word[i], word[i + 1]);
                    if(result.ContainsKey(key))
                        result[key]++;
                    else
                        result.Add(key, 1);
                }
            }   
            return result;    
		}

        private static Dictionary<(string, string), int> GetTgrams(List<List<string>> text)
        {
            var result = new Dictionary<(string, string), int>();
            foreach (var word in text)
            {
                if(word.Count > 2)
                {
                    for (int i = 0; i < word.Count - 2; i++)
                    {
                        var key = (word[i]+ " " + word[i + 1], word[i + 2]);
                        if(result.ContainsKey(key))
                            result[key]++;
                        else
                            result.Add(key, 1);
                    }
                }
            }
            return result;
		}

        private static Dictionary<string, string> GetNGramms(List<List<string>> text)
        {
            var ngrams = new Dictionary<string, string>();
            var result = GetTgrams(text);
            foreach (var grams in GetBgrams(text))
                result.Add(grams.Key, grams.Value);
            foreach (var grams in result)
            {
                if(ngrams.ContainsKey(grams.Key.Item1))
                {                    
                    if(result[(grams.Key)] > result[(grams.Key.Item1, ngrams[grams.Key.Item1])])
                    {
                        ngrams[grams.Key.Item1] = grams.Key.Item2;
                    }
                    if(result[(grams.Key)] == result[(grams.Key.Item1, ngrams[grams.Key.Item1])])
                    {
                        ngrams[grams.Key.Item1] = string.CompareOrdinal(ngrams[grams.Key.Item1], grams.Key.Item2) < 0 ? 
                                                ngrams[grams.Key.Item1] : grams.Key.Item2;
                    }
                }
                else
                {
                    ngrams.Add(grams.Key.Item1, grams.Key.Item2);
                }
            }
            return ngrams;
        }
    }
}
