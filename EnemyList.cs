using System;
using System.Collections;
namespace Arena {
	public class EnemyList {
		private string enemiesDatafile;
		Random rand = new Random();
		ArrayList el = new ArrayList();
		
		public EnemyList() {
			el.Clear();
		}
		
		public string getRandom(int enemyLevel) {
			switch(enemyLevel) {
				case 1:
					enemiesDatafile = "enemies1.txt";
					break;
				case 2:
					enemiesDatafile = "enemies2.txt";
					break;
				case 3:
					enemiesDatafile = "enemies3.txt";
					break;
				default:
					enemiesDatafile = "enemies1.txt";
					break;
			}
			populateEnemyListFromDatafile();
			
			int randomIndex = rand.Next(1, el.Count);
			return (string)el[randomIndex];
		}
		
		private void populateEnemyListFromDatafile() {
			int counter = 0;
			string line;
			System.IO.StreamReader file = new System.IO.StreamReader(enemiesDatafile);
			while((line = file.ReadLine()) != null) {
				el.Add(line);
				++counter;
			}
			file.Close();
		}
	}
}