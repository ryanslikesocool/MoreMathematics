using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(in float2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(in float3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(in float4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - double

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double sum(in double2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double sum(in double3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double sum(in double4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - int

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(in int2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(in int3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(in int4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - uint

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint sum(in uint2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint sum(in uint3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint sum(in uint4 vector)
			=> vector.x + vector.y + vector.z + vector.w;
	}
}