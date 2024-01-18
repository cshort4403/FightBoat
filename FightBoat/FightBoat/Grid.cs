using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightBoat
{
	public enum GRIDSTATE
	{
		EMPTY = 0,
		SHIP = 1,
		SHIP_HIT = 2,
		OIL_RIG = 3,
		OIL_RIG_HIT = 4,
		TARGET_HIT = 5,
		TARGET_MISS = 6
	}


	internal class Grid
	{

		public int width = 10, height = 10;

		public Grid() 
		{
		
		}

		public void Load()
		{

		}

		public void Update()
		{

		}
		public void Draw()
		{

		}
	}
}
