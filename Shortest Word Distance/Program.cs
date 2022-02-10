using System;

namespace Shortest_Word_Distance
{
  class Program
  {
    // https://aaronice.gitbook.io/lintcode/hash-table/shortest-word-distance
    // https://www.youtube.com/watch?v=CAIHE6PTpBo
    static void Main(string[] args)
    {
      Program p = new Program();
      string[] words = new string[] { "practice", "makes", "perfect", "coding", "makes" };
      string word1 = "coding";
      string word2 = "practice";
      int distance = p.ShortestWordDistance(words, word1, word2);
      Console.WriteLine(distance);
    }


    int ShortestWordDistance(string[] words, string word1, string word2)
    {
      int distance = int.MaxValue;
      int i = -1, j = -1;
      for (int k = 0; k < words.Length; k++)
      {
        if (words[k].Equals(word1))
          i = k;
        if (words[k].Equals(word2))
          j = k;

        if (i != -1 && j != -1)
        {
          distance = Math.Min(Math.Abs(i - j), distance);
        }
      }

      return distance;
    }
  }
}
