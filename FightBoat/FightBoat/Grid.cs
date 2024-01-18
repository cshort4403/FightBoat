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

		GRIDSTATE[,] gridStates;

		public Grid() 
		{
		
		}

		public void Load()
		{
			gridStates = new GRIDSTATE[width,height];

			for(int i = 0; i < width; i++)
			{
				for (int j = 0; j < height; i++)
				{
					gridStates[i, j] = GRIDSTATE.EMPTY;
				}
			}

		}

		public void Update()
		{

		}
		public void Draw()
		{

		}

		//Returns the previous state
		public GRIDSTATE ChangeSquare(int x, int y, GRIDSTATE newState)
		{
			GRIDSTATE oldState = gridStates[x,y];

			gridStates[x,y] = newState;

			return oldState;
		}


	}
}
