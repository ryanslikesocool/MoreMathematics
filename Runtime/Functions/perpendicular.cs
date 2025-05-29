using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		/// <summary>
		/// Get the vector perpendicular to the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float2 perpendicular(float2 v)
			=> new(-v.y, v.x);

		/// <summary>
		/// Get the vector perpendicular to the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double2 perpendicular(double2 v)
			=> new(-v.y, v.x);

		// MARK: - Unity Vectors

		/// <summary>
		/// Get the vector perpendicular to the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 perpendicular(Vector2 v)
			=> new(-v.y, v.x);

		/// <summary>
		/// Get the vector perpendicular to the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static Vector2Int perpendicular(Vector2Int v)
			=> new(-v.y, v.x);
	}
}