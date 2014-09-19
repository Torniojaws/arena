using System;
namespace Arena {
	public abstract class Character {
		public int level { get; set; }
		public string name { get; set; }
		public double health { get; set; }
		public double damage { get; set; }
		public double armor { get; set; }
		public int strength { get; set; }
		public int dexterity { get; set; }
		public int magic { get; set; }
		public int vitality { get; set; }
		
		public Character() {
			Console.WriteLine("Creating character...");
			level = 1;
			health = 50;
			armor = 0;
			strength = 10;
			dexterity = 10;
			magic = 10;
			vitality = 10;
			damage = level * strength;
			Console.WriteLine("HP left: " + health);
		}
		
		public void attack(Character target) {
			Console.WriteLine(name + " attacks " + target.name + "!");
			target.receiveDamage(damage);
		}
		
		public void receiveDamage(double recDamage) {
			Console.WriteLine(name + " takes " + recDamage + " DMG!");
			if(armor > 0) {
				recDamage *= 0.5;
				armor -= recDamage;
			}
			health -= recDamage;
		}
		
		public bool isAlive() {
			return health > 0;
		}
	}
}