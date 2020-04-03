using System;
using System.Collections.Generic;
using System.Text;

namespace CCC_Solution1
{
    class Drone
    {
		
		private int speed;
        private string direction;
        private int[] location;
        private int id;

		public Drone(int id, string direction, int speed, int[] location)
		{
            ID = id;
			Speed = speed;
			Direction = direction;
			Location = location;
		}

        public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}		

		public string Direction
		{
			get { return direction; }
			set { direction = value; }
		}		

		public int[] Location
		{
			get { return location; }
			set { location = value; }
		}

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
	}
}
