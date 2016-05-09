using System;

namespace TravellingSalesMan {
	public class Utilities {
		private static readonly Random rnd = new Random ( );

		public static float GetRndFloat ( ) {
			return (float) rnd.NextDouble ( );
		}

		public static int GetRndInt ( int count ) {
			return rnd.Next ( count );
		}
	}
}

