using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(in float2 value)
			=> sum(value) * 0.5f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(in float3 value)
			=> sum(value) * 0.3333333333f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(in float4 value)
			=> sum(value) * 0.25f;

		// MARK: - double

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double average(in double2 value)
			=> sum(value) * 0.5f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double average(in double3 value)
			=> sum(value) * 0.3333333333f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double average(in double4 value)
			=> sum(value) * 0.25f;
	}
}