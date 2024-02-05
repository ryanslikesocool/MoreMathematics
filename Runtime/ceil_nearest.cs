using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>Perform a ceiling operation on the given value, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float ceil(float x, float nearest)
			=> ceil(x / nearest) * nearest;

		/// <summary>Perform a ceiling operation on each lane of the given vector, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float2 ceil(float2 x, float2 nearest)
			=> ceil(x / nearest) * nearest;

		/// <summary>Perform a ceiling operation on each lane of the given vector, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float3 ceil(float3 x, float3 nearest)
			=> ceil(x / nearest) * nearest;

		/// <summary>Perform a ceiling operation on each lane of the given vector, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static float4 ceil(float4 x, float4 nearest)
			=> ceil(x / nearest) * nearest;

		// MARK: - double

		/// <summary>Perform a ceiling operation on the given value, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double ceil(double x, double nearest)
			=> ceil(x / nearest) * nearest;

		/// <summary>Perform a ceiling operation on each lane of the given vector, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double2 ceil(double2 x, double2 nearest)
			=> ceil(x / nearest) * nearest;

		/// <summary>Perform a ceiling operation on each lane of the given vector, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double3 ceil(double3 x, double3 nearest)
			=> ceil(x / nearest) * nearest;

		/// <summary>Perform a ceiling operation on each lane of the given vector, rounding up to the nearest multiple of <paramref name="nearest"/>.</summary>
		/// <param name="x">Input value.</param>
		/// <param name="nearest">The multiple to round up to.</param>
		[MethodImpl(AggressiveInlining)]
		public static double4 ceil(double4 x, double4 nearest)
			=> ceil(x / nearest) * nearest;
	}
}