using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// Compares two scalars and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two scalars for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool approximately(float a, float b, float epsilon = EPSILON)
			=> abs(b - a) < epsilon;

		/// <summary>
		/// Compares each lane of two vectors and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two vectors for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool2 approximately(in float2 a, in float2 b, float epsilon = EPSILON)
			=> abs(b - a) < epsilon;

		/// <summary>
		/// Compares each lane of two vectors and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two vectors for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool3 approximately(in float3 a, in float3 b, float epsilon = EPSILON)
			=> abs(b - a) < epsilon;

		/// <summary>
		/// Compares each lane of two vectors and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two vectors for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool4 approximately(in float4 a, in float4 b, float epsilon = EPSILON)
			=> abs(b - a) < epsilon;

		// MARK: - double

		/// <summary>
		/// Compares two scalars and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two scalars for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool approximately(double a, double b, double epsilon = EPSILON_DBL)
			=> abs(b - a) < epsilon;

		/// <summary>
		/// Compares each lane of two vectors and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two vectors for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool2 approximately(in double2 a, in double2 b, double epsilon = EPSILON_DBL)
			=> abs(b - a) < epsilon;

		/// <summary>
		/// Compares each lane of two vectors and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two vectors for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool3 approximately(in double3 a, in double3 b, double epsilon = EPSILON_DBL)
			=> abs(b - a) < epsilon;

		/// <summary>
		/// Compares each lane of two vectors and returns true if the difference between them is less than the given epsilon.
		/// </summary>
		/// <param name="epsilon">The minimum distance between the two vectors for them to be considered similar.</param>
		[MethodImpl(AggressiveInlining)]
		public static bool4 approximately(in double4 a, in double4 b, double epsilon = EPSILON_DBL)
			=> abs(b - a) < epsilon;
	}
}