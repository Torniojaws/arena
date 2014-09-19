using System;
namespace Arena {
	public class Player : Character {
		public Player() {
			getName();
			Console.WriteLine("Prepare yourself, " + name + "!");
			level = 1;
			strength = 10;
			dexterity = 10;
			magic = 10;
			vitality = 10;
		}
				
		private void getName() {
			Console.WriteLine("What is your name?");
			name = Console.ReadLine();
		}
	}
}