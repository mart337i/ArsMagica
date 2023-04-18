using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsMagica
{
    public class Player
    {
        public int health;
        public Weapon Weapon;
        public Armor Armor;

        public Player()
        {
            health = 100;
        }

        public void Attack(Player enemy)
        {
            enemy.health -= Weapon.damage; ;
        }

        public void EquipWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }
        
        public void EquipArmor(Armor armor)
        {
            armor = armor;
        }
    }
}
