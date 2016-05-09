using System;

namespace TravellingSalesMan.Util {
	public class TapeMeasure {

		public double Measure ( Coordinate coord1, Coordinate coord2 ) {
			double x = ( coord1.X - coord2.X );
			double y = ( coord1.Y - coord2.Y );
			return( Math.Sqrt ( ( x * x ) + y * y ) );
		}
	}
}
