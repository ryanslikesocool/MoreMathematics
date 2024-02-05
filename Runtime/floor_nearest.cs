using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>Perform a flooring operation on the given value, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float floor(float x, float nearest)
			=> floor(x / nearest) * nearest;

		/// <summary>Perform a flooring operation on each lane of the given vector, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float2 floor(float2 x, float2 nearest)
			=> floor(x / nearest) * nearest;

		/// <summary>Perform a flooring operation on each lane of the given vector, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float3 floor(float3 x, float3 nearest)
			=> floor(x / nearest) * nearest;

		/// <summary>Perform a flooring operation on each lane of the given vector, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float4 floor(float4 x, float4 nearest)
			=> floor(x / nearest) * nearest;

		// MARK: - double

		/// <summary>Perform a flooring operation on the given value, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double floor(double x, double nearest)
			=> floor(x / nearest) * nearest;

		/// <summary>Perform a flooring operation on each lane of the given vector, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double2 floor(double2 x, double2 nearest)
			=> floor(x / nearest) * nearest;

		/// <summary>Perform a flooring operation on each lane of the given vector, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double3 floor(double3 x, double3 nearest)
			=> floor(x / nearest) * nearest;

		/// <summary>Perform a flooring operation on each lane of the given vector, rounding down to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="">The multiple to round down to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double4 floor(double4 x, double4 nearest)
			=> floor(x / nearest) * nearest;
	}
}