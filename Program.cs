using System;

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

    }
  }
}
