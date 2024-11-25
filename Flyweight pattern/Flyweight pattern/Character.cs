using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
    public class Character
    {
        public string Name { get; }
        public string Type { get; }
        public string Image { get; }
        public int Level { get; private set; }
        public int Experience { get; private set; }

        public Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
            Level = 1;
            Experience = 0;
        }
        public void LevelUp()
        {
            Level++;
        }
        public void GainExperience(int exp)
        {
            Experience += exp;
        }
    }
}
