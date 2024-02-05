using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		/// <summary>
		/// The angle, in radians, that the given vector is pointing.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float angle(in float2 v)
			=> atan2(v.y, v.x);

		/// <summary>
		/// The angle, in radians, that the given vector is pointing.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double angle(in double2 v)
			=> atan2(v.y, v.x);
	}
}