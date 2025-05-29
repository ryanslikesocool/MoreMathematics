using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(float2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(float3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(float4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - double

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double product(double2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double product(double3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static double product(double4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - int

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(int2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(int3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(int4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - uint

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint product(uint2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint product(uint3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static uint product(uint4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		// MARK: - Unity Vectors

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(Vector2 vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(Vector3 vector)
			=> vector.x * vector.y * vector.z;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static float product(Vector4 vector)
			=> vector.x * vector.y * vector.z * vector.w;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(Vector2Int vector)
			=> vector.x * vector.y;

		/// <summary>
		/// The result of multiplying each lane of the given vector.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static int product(Vector3Int vector)
			=> vector.x * vector.y * vector.z;

		// <summary>
		// The result of multiplying each lane of the given vector.
		// </summary>
		//[MethodImpl(AggressiveInlining)]
		//public static int product(Vector4Int vector)
		//	=> vector.x * vector.y * vector.z * vector.w;
	}
}