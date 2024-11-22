using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>Perform a rounding operation on the given value, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float round(float x, float nearest)
			=> round(x / nearest) * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float2 round(float2 x, float2 nearest)
			=> round(x / nearest) * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float3 round(float3 x, float3 nearest)
			=> round(x / nearest) * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float4 round(float4 x, float4 nearest)
			=> round(x / nearest) * nearest;

		// MARK: - double

		/// <summary>Perform a rounding operation on the given value, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double round(double x, double nearest)
			=> round(x / nearest) * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double2 round(double2 x, double2 nearest)
			=> round(x / nearest) * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double3 round(double3 x, double3 nearest)
			=> round(x / nearest) * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double4 round(double4 x, double4 nearest)
			=> round(x / nearest) * nearest;

		// MARK: - int

		/// <summary>Perform a rounding operation on the given value, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static int round(int x, int nearest)
			=> x / nearest * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static int2 round(int2 x, int2 nearest)
			=> x / nearest * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static int3 round(int3 x, int3 nearest)
			=> x / nearest * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static int4 round(int4 x, int4 nearest)
			=> x / nearest * nearest;

		// MARK: - uint

		/// <summary>Perform a rounding operation on the given value, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static uint round(uint x, uint nearest)
			=> x / nearest * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static uint2 round(uint2 x, uint2 nearest)
			=> x / nearest * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static uint3 round(uint3 x, uint3 nearest)
			=> x / nearest * nearest;

		/// <summary>Perform a rounding operation on each lane of the given vector, rounding to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round to.</param>
		[MethodImpl(AggressiveInlining)]
		public static uint4 round(uint4 x, uint4 nearest)
			=> x / nearest * nearest;
	}
}