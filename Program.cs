using System;
using System.Collections.Generic;

namespace dictionary_toys
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, int> toysSold = new Dictionary<string, int>() {
                {"Hot Wheels", 344},
                {"Legos", 753},
                {"Gaming Consoles", 243},
                {"Board Games", 273}
            };

      toysSold.Add("Bicycles", 87);


      // Iterate
      foreach (KeyValuePair<string, int> toy in toysSold)
      {
        Console.WriteLine($"We sold {toy.Value} units of {toy.Key}.");
      }
    }
  }
}
