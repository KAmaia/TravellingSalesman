using System;

using TravellingSalesMan.Util;
using TravellingSalesMan.Pathing;

namespace TravellingSalesMan {
	class MainClass {
		public static void Main ( string[] args ) {
			Coordinate one = new Coordinate ( 1, 2 );
			Coordinate two = new Coordinate ( 1, 2 );
			Coordinate three = new Coordinate ( 2, 5 );

			Node nOne = new Node ( one );
			Node nTwo = new Node ( two );
			Node nThree = new Node ( three );

			Console.WriteLine ( "#### Comparison Tests" );
			Console.WriteLine ( one.Equals ( two ) + " Should be true" );
			Console.WriteLine ( one.Equals ( three ) + " Should be false" );
			Console.WriteLine ( two.Equals ( one ) + " Should be true" );
			Console.WriteLine ( two.Equals ( three ) + " Should be false" );
		
			Console.WriteLine ( "#### Distance Testing" );
			Console.WriteLine ( "Distance Between One and Two: " + new TapeMeasure ( ).Measure ( one, two ) + " Should Be Zero" );
			Console.WriteLine ( "Distance Between Two and Three: " + new TapeMeasure ( ).Measure ( two, three ) + " Should Be 1" );
		
			Console.WriteLine ( "#### Node Comparison" );
			Console.WriteLine ( nOne.Equals ( nTwo ) + " Should be true" );
			Console.WriteLine ( nOne.Equals ( nThree ) + " Should be false" );
			Console.WriteLine ( nTwo.Equals ( nOne ) + " Should be True" );
			Console.WriteLine ( nTwo.Equals ( nThree ) + " Should Be False" );

			Console.WriteLine ( "###Node Distance Testing" );
			Console.WriteLine ( "Distance between Node one and Node two: " + new TapeMeasure ( ).Measure ( nOne.Location, nTwo.Location ) );
			Console.WriteLine ( "Distance between Node two and Node three: " + new TapeMeasure ( ).Measure ( nTwo.Location, nThree.Location ) );

			Console.WriteLine ( "###GetRandomFloat() Testing" );

			Console.WriteLine ( Utilities.GetRndFloat ( ) );
			Console.WriteLine ( Utilities.GetRndFloat ( ) );

			Console.WriteLine ( "Creating New Map" );
			Map m = new Map ( );
			foreach ( Node n in m.route.Path ) {
				Console.WriteLine ( "Node :" + n.Location.ToString ( ) );
			}
		}
	}
}
