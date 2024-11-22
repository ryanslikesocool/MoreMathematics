using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	using Geometry;

	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		public static float3 centroid(in Triangle3D triangle)
			=> (triangle.p0 + triangle.p1 + triangle.p2) / 3;
	}
}