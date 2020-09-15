using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Spell : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Spell(int id, string name, string namePlural, int price, int minimumDamage, int maximumDamage) : base(id, name, namePlural, price)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
