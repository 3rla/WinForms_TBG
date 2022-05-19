using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_TBG;

namespace Champs
{
    public class Champions
    {
        // Needed variables

        protected static Random random = new Random();
        int Percentage = random.Next(80, 120);

        public Champions(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int AttackPoints { get; set; }
        public int ArmorPoints { get; set; }
        public void SetStats()
        {
            
        }

        // Helper methods

        protected int RandomizeDamage()
        {
            int percentage = random.Next(Percentage);
            int damage = (AttackPoints * percentage) / 100;
            return damage;
        }
        protected void DeductDamage(Champions champion, int damage)
        {
            champion.HealthPoints -= damage;
        }

        // Attacking methods for standard attack and special ability attack

        public virtual int Attack(Champions champion)
        {
            int randomDamage = RandomizeDamage();
            int defendedDamage = champion.Defend(randomDamage);
            DeductDamage(champion, defendedDamage);
            return defendedDamage;
        }
        protected virtual int Attack(Champions champion, int damage)
        {
            int defendedDamage = champion.Defend(damage);
            DeductDamage(champion, defendedDamage);
            return defendedDamage;
        }

        // Defending damage method

        protected virtual int Defend(int attackedDamage)
        {
            int percentage = random.Next(Percentage);
            int reducedDamage = (ArmorPoints * percentage) / 100;
            int damage = attackedDamage - reducedDamage;
            return damage;
        }
    }

    //Class Assassin

    public class Assassin : Champions
    {
        public Assassin(string name) : base(name)
        {
            this.Name = name;
            this.HealthPoints = 1500;
            this.AttackPoints = 250;
            this.ArmorPoints = 150;
        }

        // Special ability method

        public override int Attack(Champions champion)
        {
            int tripleDamagePercentage = 30;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= tripleDamagePercentage)
            {
                int tripleDamage = RandomizeDamage() * 3;
                base.Attack(champion, tripleDamage);
                return tripleDamage;
            }
            return base.Attack(champion);
        }
    }

    //Class Mage

    public class Mage : Champions
    {
        public Mage(string name) : base(name)
        {
            this.Name = name;
            this.HealthPoints = 1500;
            this.AttackPoints = 250;
            this.ArmorPoints = 150;
        }

        // Special ability methods

        public override int Attack(Champions champion)
        {
            int doubleDamagePercentage = 30;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= doubleDamagePercentage)
            {
                int doubleDamage = RandomizeDamage() * 2;
                base.Attack(champion, doubleDamage);
                return doubleDamage;
            }
            return base.Attack(champion);
        }
        protected override int Defend(int attackedDamage)
        {
            int avoidPercentage = 30;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= avoidPercentage)
            {
                attackedDamage += attackedDamage / 2;
                return attackedDamage;
            }
            return base.Defend(attackedDamage);
        }
    }

    //Class Knight

    public class Knight : Champions
    {
        public Knight(string name) : base(name)
        {
            this.Name = name;
            this.HealthPoints = 1000;
            this.AttackPoints = 250;
            this.ArmorPoints = 150;
        }

        // Special ability methods

        public override int Attack(Champions champion)
        {
            int doubleDamagePercentage = 10;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= doubleDamagePercentage)
            {
                int doubleDamage = RandomizeDamage() * 2;
                base.Attack(champion, doubleDamage);
                return doubleDamage;
            }
            return base.Attack(champion);
        }


        protected override int Defend(int attackedDamage)
        {
            int blockPercentage = 20;
            int randomValue = random.Next(0, 100 + 1);
            if (randomValue <= blockPercentage)
            {
                attackedDamage = 0;
                return attackedDamage;
            }
            return base.Defend(attackedDamage);
        }
    }
}
