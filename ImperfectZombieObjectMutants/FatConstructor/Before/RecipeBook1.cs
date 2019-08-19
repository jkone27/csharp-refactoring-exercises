using System;
using System.Collections.Generic;

namespace MissingAbstraction.FatConstructor
{
    public class RecipeBook1
    {
        public Dictionary<string, string> Recipe { get; }

        public RecipeBook1(Dictionary<string, string> dictionary)
        {
            Recipe = dictionary ?? throw new ArgumentNullException($"{dictionary} is null");
        }
    }
}
