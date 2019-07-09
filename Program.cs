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

      var christmasToys = new Dictionary<string, int>() {
        {"Nutcracker", 523},
        {"Christmas Shoes", 278}
      };

      foreach (KeyValuePair<string, int> ctoy in christmasToys)
      {
        toysSold.Add(ctoy.Key, ctoy.Value);
      }

      Console.WriteLine("After adding christmas toys...");
      foreach (KeyValuePair<string, int> toy in toysSold)
      {
        Console.WriteLine($"We sold {toy.Value} units of {toy.Key}.");
      }

    }
  }
}
