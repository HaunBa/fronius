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

		public Drone(string direction, int speed, int[] location)
		{
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

	}
}
