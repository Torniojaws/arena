using System;
namespace Arena {
	public class ArenaMain {
		static void Main() {
			Console.WriteLine("Welcome to the arena!");
			
			Player pc = new Player();
			Enemy enemy;
			
			while(pc.isAlive()) {
				enemy = new Enemy();
				Console.WriteLine("You face: " + enemy.name + ", which seems to have " + enemy.health + " HP.");
				Console.WriteLine("You have " + pc.health + " HP -- Do you wish to attack? Y/N");
				string willAttack = Console.ReadLine();
				
				if(willAttack == "Y") {
					while(enemy.isAlive()) {
						pc.attack(enemy);
						if(enemy.isAlive()) {
							Console.WriteLine(enemy.name + " retaliates!");
							enemy.attack(pc);
						}
					}
					Console.WriteLine("The enemy has fallen! Another adventure begins...");
					
					//pc.exp += 
				}
			}
			
			Console.WriteLine(pc.name + " is dead! RIP. Game over!");
		}
	}
}