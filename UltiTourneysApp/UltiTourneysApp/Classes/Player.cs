using System;
namespace UltiTourneysApp.Classes
{
	public class Player
	{
		public int playerID { get; private set; }
		public string name { get; private set; }

		public Player(string name)
		{
			this.name = name;
		}
	}
}

