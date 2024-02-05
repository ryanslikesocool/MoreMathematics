using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float negate(this ref float x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float2 negate(this ref float2 x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float3 negate(this ref float3 x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float4 negate(this ref float4 x) {
			x = -x;
			return x;
		}

		// MARK: - double

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double negate(this ref double x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double2 negate(this ref double2 x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double3 negate(this ref double3 x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double4 negate(this ref double4 x) {
			x = -x;
			return x;
		}

		// MARK: - int

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int negate(this ref int x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int2 negate(this ref int2 x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int3 negate(this ref int3 x) {
			x = -x;
			return x;
		}

		/// <summary>
		/// Replaces the given value with its additive inverse.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int4 negate(this ref int4 x) {
			x = -x;
			return x;
		}
	}
}