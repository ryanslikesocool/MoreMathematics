using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	using Geometry;

	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		public static float length(in LineSegment3D lineSegment)
			=> distance(lineSegment.p0, lineSegment.p1);
	}
}