using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		/// <summary>
		/// Get the vector perpendicular to the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float2 perpendicular(in float2 v)
			=> new float2(-v.y, v.x);

		/// <summary>
		/// Get the vector perpendicular to the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double2 perpendicular(in double2 v)
			=> new double2(-v.y, v.x);
	}
}