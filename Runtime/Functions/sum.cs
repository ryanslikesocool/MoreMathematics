using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(float2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(float3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(float4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - double

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double sum(double2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double sum(double3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double sum(double4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - int

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(int2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(int3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(int4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - uint

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint sum(uint2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint sum(uint3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint sum(uint4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		// MARK: - Unity Vectors

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(Vector2 vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(Vector3 vector)
			=> vector.x + vector.y + vector.z;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float sum(Vector4 vector)
			=> vector.x + vector.y + vector.z + vector.w;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(Vector2Int vector)
			=> vector.x + vector.y;

		/// <summary>
		/// The result of adding each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int sum(Vector3Int vector)
			=> vector.x + vector.y + vector.z;

		// <summary>
		// The result of adding each lane of the given vector.
		// </summary>
		//[MethodImpl(AggressiveInlining)]
		//public static int sum(Vector4Int vector)
		//	=> vector.x + vector.y + vector.z + vector.w;
	}
}