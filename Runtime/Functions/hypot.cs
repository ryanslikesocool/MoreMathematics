using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// Returns the hypotenuse of a right-angled triangle with the sides that are adjacent to the right angle that two scalars define.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float hypot(float x, float y)
			=> sqrt(square(x) + square(y));

		/// <summary>
		/// Returns the hypotenuse of a right-angled triangle with the sides that are adjacent to the right angle that a vector defines.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float hypot(in float2 v)
			=> hypot(v.x, v.y);

		// MARK: - double

		/// <summary>
		/// Returns the hypotenuse of a right-angled triangle with the sides that are adjacent to the right angle that two scalars define.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double hypot(double x, double y)
			=> sqrt(square(x) + square(y));

		/// <summary>
		/// Returns the hypotenuse of a right-angled triangle with the sides that are adjacent to the right angle that a vector defines.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double hypot(in double2 v)
			=> hypot(v.x, v.y);
	}
}