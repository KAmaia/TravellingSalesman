

namespace TravellingSalesMan.Util {

	public class Coordinate {
		public int X { get; private set; }

		public int Y { get; private set; }

		public Coordinate ( int x, int y ) {
			X = x;
			Y = y;
		}

		public override string ToString ( ) {
			return string.Format ( "[Coordinate @ {0}, {1}]", X, Y );
		}

		public bool Equals ( Coordinate c ) {
			return X == c.X && Y == c.Y;
		}
	}
}

