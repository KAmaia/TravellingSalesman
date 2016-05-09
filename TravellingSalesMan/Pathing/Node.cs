﻿using System;
using System.Collections.Generic;
using TravellingSalesMan.Util;

namespace TravellingSalesMan.Pathing {
	public class Node {

		public Coordinate Location { get; private set; }

		public Node NearestNode { get; private set; }

		public double DistanceToNearestNode;

		public Node ( Coordinate location ) {
			Location = location;
			NearestNode = null;
		}

		public void FindNearestNode ( List<Node> nodes ) {
			TapeMeasure tm = new TapeMeasure ( );
			foreach ( Node n in nodes ) {
				if ( n.Equals ( this ) ) {
					continue;
				}
				else {
					double distance = tm.Measure ( Location, n.Location );
					if ( NearestNode == null ) {
						DistanceToNearestNode = distance;
						NearestNode = n;
					}
					else if ( distance < DistanceToNearestNode ) {
						DistanceToNearestNode = distance;
						NearestNode = n;
					}
					else if ( distance == DistanceToNearestNode ) {
						//pick one at random;
						NearestNode = Utilities.GetRndFloat ( ) >= Utilities.GetRndFloat ( ) ? NearestNode : n;
					}
					else {
						continue;
					}
				}
			}
		}

		public override bool Equals ( Object obj ) {
			if ( obj == null ) {
				return false;
			}
			Node objAsNode = obj as Node;
			if ( objAsNode == null ) {
				return false;
			}
			else
				return Equals ( objAsNode );
		}

		//check to see if these nodes are at the same location.
		public bool Equals ( Node node1 ) {
			return Location == node1.Location;
		}
	}
}

