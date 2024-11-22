using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(in float2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(in float3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(in float4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - double

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double product(in double2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double product(in double3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double product(in double4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - int

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(in int2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(in int3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(in int4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - uint

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint product(in uint2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint product(in uint3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint product(in uint4 vector)
			=> vector.x * vector.y * vector.z * vector.w;
	}
}