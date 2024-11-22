using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	using Geometry;

	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		public static float perimiter(in Triangle3D triangle)
			=> distance(triangle.p0, triangle.p1)
			 + distance(triangle.p1, triangle.p2)
			 + distance(triangle.p2, triangle.p0);
	}
}