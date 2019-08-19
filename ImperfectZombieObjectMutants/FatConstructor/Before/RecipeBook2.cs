using System;
using System.Collections.Generic;
using System.Text;

namespace MissingAbstraction.FatConstructor
{

    public class RecipeBook2
    {
        public Dictionary<string, string> Recipe { get; }

        private RecipeBook2(Dictionary<string, string> dictionary)
        {
            Recipe = dictionary; // no logic inside the constructor
        }

        public static RecipeBook2 Get(Dictionary<string, string> dictionary) // static factory method
        {
            return dictionary != null ?
                new RecipeBook2(dictionary)
                : throw new ArgumentNullException($"{dictionary} is null");
        }
    }
}
