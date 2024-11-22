using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	using Geometry;

	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		public static float lengthsq(in LineSegment3D lineSegment)
			=> distancesq(lineSegment.p0, lineSegment.p1);
	}
}