using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - bool

		[MethodImpl(AggressiveInlining)]
		public static bool2 unswizzle(in bool2 input, in int2 mask) {
			bool2 result = default;
			for (int i = 0; i < 2; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static bool3 unswizzle(in bool3 input, in int3 mask) {
			bool3 result = default;
			for (int i = 0; i < 3; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static bool4 unswizzle(in bool4 input, in int3 mask) {
			bool4 result = default;
			for (int i = 0; i < 4; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		// MARK: - float

		[MethodImpl(AggressiveInlining)]
		public static float2 unswizzle(in float2 input, in int2 mask) {
			float2 result = default;
			for (int i = 0; i < 2; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static float3 unswizzle(in float3 input, in int3 mask) {
			float3 result = default;
			for (int i = 0; i < 3; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static float4 unswizzle(in float4 input, in int3 mask) {
			float4 result = default;
			for (int i = 0; i < 4; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		// MARK: - double

		[MethodImpl(AggressiveInlining)]
		public static double2 unswizzle(in double2 input, in int2 mask) {
			double2 result = default;
			for (int i = 0; i < 2; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static double3 unswizzle(in double3 input, in int3 mask) {
			double3 result = default;
			for (int i = 0; i < 3; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static double4 unswizzle(in double4 input, in int3 mask) {
			double4 result = default;
			for (int i = 0; i < 4; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		// MARK: - int

		[MethodImpl(AggressiveInlining)]
		public static int2 unswizzle(in int2 input, in int2 mask) {
			int2 result = default;
			for (int i = 0; i < 2; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static int3 unswizzle(in int3 input, in int3 mask) {
			int3 result = default;
			for (int i = 0; i < 3; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static int4 unswizzle(in int4 input, in int3 mask) {
			int4 result = default;
			for (int i = 0; i < 4; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}


		// MARK: - uint

		[MethodImpl(AggressiveInlining)]
		public static uint2 unswizzle(in uint2 input, in int2 mask) {
			uint2 result = default;
			for (int i = 0; i < 2; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static uint3 unswizzle(in uint3 input, in int3 mask) {
			uint3 result = default;
			for (int i = 0; i < 3; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static uint4 unswizzle(in uint4 input, in int3 mask) {
			uint4 result = default;
			for (int i = 0; i < 4; i++) {
				result[mask[i]] = input[i];
			}
			return result;
		}
	}
}