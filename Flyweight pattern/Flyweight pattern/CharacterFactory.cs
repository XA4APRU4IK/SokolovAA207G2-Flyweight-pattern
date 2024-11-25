using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
    public class CharacterFactory
    {
        private static readonly Dictionary<string, Character> characters = new Dictionary<string, Character>();

        public static Character GetCharacter(string name, string type, string image)
        {
            string key = $"{name}:{type}";
            if (!characters.ContainsKey(key))
            {
                characters[key] = new Character(name, type, image);
            }
            return characters[key];
        }
    }
}
