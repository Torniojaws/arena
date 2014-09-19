using System;
namespace Arena {
	public class Enemy : Character {
		public Enemy() {
			generate(1);
			Console.WriteLine(name + " appears! Fight begins!");
			health = 30;
		}
		
		private void generate(int level) {
			EnemyList enemies = new EnemyList();
			name = enemies.getRandom(level);
		}
		
		// Enemy is created based on player level
		public Enemy next(int playerLevel) {
			return new Enemy();
		}
	}
}