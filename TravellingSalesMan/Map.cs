using System;
using System.Collections.Generic;

using TravellingSalesMan.Pathing;
using TravellingSalesMan.Util;

namespace TravellingSalesMan {
	public class Map {
		private List<Node> nodes;
		private Route route = new Route ( );

		public Map ( ) {
			nodes = new List<Node> ( );
			nodes.Add ( new Node ( new Coordinate ( 1, 2 ) ) );
			nodes.Add ( new Node ( new Coordinate ( 2, 2 ) ) );
			nodes.Add ( new Node ( new Coordinate ( 3, 2 ) ) );
			nodes.Add ( new Node ( new Coordinate ( 3, 3 ) ) );
			nodes.Add ( new Node ( new Coordinate ( 3, 4 ) ) );
		}
	}
}

