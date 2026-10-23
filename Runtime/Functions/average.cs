using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(float2 value)
			=> sum(value) * 0.5f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(float3 value)
			=> sum(value) * 0.3333333333f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(float4 value)
			=> sum(value) * 0.25f;

		// MARK: - double

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double average(double2 value)
			=> sum(value) * 0.5f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double average(double3 value)
			=> sum(value) * 0.3333333333f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double average(double4 value)
			=> sum(value) * 0.25f;

		// MARK: - Unity Vector

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(Vector2 value)
			=> sum(value) * 0.5f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(Vector3 value)
			=> sum(value) * 0.3333333333f;

		/// <summary>
		/// The sum of all lanes in the given vector divided by the number of lanes.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float average(Vector4 value)
			=> sum(value) * 0.25f;
	}
}