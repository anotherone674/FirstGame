using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountToHeal { get; set; }
        public int DamageAdded { get; set; }
        public bool IsPotion { get; set; }
        public bool IsPoison { get; set; }
        public bool IsFood { get; set; }
        public bool IsDrink { get; set; }

        public HealingPotion(int id, string name, string namePlural, int price, int amountToHeal, int damageAdded, bool isPotion, bool isPoison, bool isFood, bool isDrink) : base(id, name, namePlural, price)
        {
            AmountToHeal = amountToHeal;
            DamageAdded = damageAdded;
            IsPotion = isPotion;
            IsPoison = isPoison;
            IsFood = isFood;
            IsDrink = isDrink;
        }
    }
}
