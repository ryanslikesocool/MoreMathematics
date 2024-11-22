using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	using Geometry;

	public static partial class math {
		/// <summary>
		/// Return the result of transforming a 3D ray by a <see cref="float4x4"/>  matrix.
		/// </summary>
		/// <returns>The transformed ray.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Ray3D transform(in float4x4 matrix, in Ray3D ray) => new Ray3D(
			origin: transform(matrix, ray.origin),
			direction: rotate(matrix, ray.direction)
		);

		/// <summary>
		/// Return the result of transforming a 3D line segment by a <see cref="float4x4"/>  matrix.
		/// </summary>
		/// <returns>The transformed line segment.</returns>
		[MethodImpl(AggressiveInlining)]
		public static LineSegment3D transform(in float4x4 matrix, in LineSegment3D lineSegment) => new LineSegment3D(
			transform(matrix, lineSegment.p0),
			transform(matrix, lineSegment.p1)
		);

		/// <summary>
		/// Return the result of transforming a 3D triangle by a <see cref="float4x4"/> matrix.
		/// </summary>
		/// <returns>The transformed triangle.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Triangle3D transform(in float4x4 matrix, in Triangle3D triangle) => new Triangle3D(
			transform(matrix, triangle.p0),
			transform(matrix, triangle.p1),
			transform(matrix, triangle.p2)
		);
	}
}