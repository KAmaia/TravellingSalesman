using System;
using System.Collections.Generic;

namespace TravellingSalesMan.Pathing {
	public class Route {
		private List<Node> nodes;
		private List<Node> path;

		public List<Node> Path { get { return path; } }

		public Route ( List<Node> nodes ) {
			this.nodes = nodes;
			path = CreatePath ( );
		}

		private List<Node> CreatePath ( ) {
			List<Node> tmpNodeList = new List<Node> ( );
			//arbitralily pick a starting node.
			Node currentNode = nodes [ Utilities.GetRndInt ( nodes.Count ) ];
			tmpNodeList.Add ( currentNode );
			while ( tmpNodeList.Count != nodes.Count ) {
				currentNode.Equals ( currentNode.FindNearestNode ( nodes ) );
				tmpNodeList.Add ( currentNode );
			}
			return tmpNodeList;
		}
	}
}

