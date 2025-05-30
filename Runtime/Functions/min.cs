using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		/// <summary>Returns the minimum of two half values.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half min(half x, half y)
			=> isnan(y) || x < y ? x : y;

		/// <summary>Returns the minimum of multiple half values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half min(half a, half b, half c, params half[] other) {
			half result = min(min(a, b), c);
			foreach (half element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the minimum of multiple float values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float min(float a, float b, float c, params float[] other) {
			float result = min(min(a, b), c);
			foreach (float element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the minimum of multiple double values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double min(double a, double b, double c, params double[] other) {
			double result = min(min(a, b), c);
			foreach (double element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the minimum of multiple int values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int min(int a, int b, int c, params int[] other) {
			int result = min(min(a, b), c);
			foreach (int element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the minimum of multiple uint values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint min(uint a, uint b, uint c, params uint[] other) {
			uint result = min(min(a, b), c);
			foreach (uint element in other) {
				result = min(result, element);
			}
			return result;
		}

		// MARK: - Unity Vectors

		/// <summary>Returns the componentwise minimum of two Vector2 vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 min(Vector2 x, Vector2 y)
			=> new(min(x.x, y.x), min(x.y, y.y));

		/// <summary>Returns the componentwise minimum of two Vector3 vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3 min(Vector3 x, Vector3 y)
			=> new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

		/// <summary>Returns the componentwise minimum of two Vector4 vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector4 min(Vector4 x, Vector4 y)
			=> new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

		/// <summary>Returns the componentwise minimum of two Vector2Int vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2Int min(Vector2Int x, Vector2Int y)
			=> new(min(x.x, y.x), min(x.y, y.y));

		/// <summary>Returns the componentwise minimum of two Vector3Int vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3Int min(Vector3Int x, Vector3Int y)
			=> new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

		// <summary>Returns the componentwise minimum of two Vector4Int vectors.</summary>
		// <param name="x">The first input value.</param>
		// <param name="y">The second input value.</param>
		// <returns>The componentwise minimum of the two input values.</returns>
		//[MethodImpl(AggressiveInlining)]
		//public static Vector4Int min(Vector4Int x, Vector4Int y)
		//	=> new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

		/// <summary>Returns the componentwise minimum of multiple Vector2 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 min(Vector2 a, Vector2 b, Vector2 c, params Vector2[] other) {
			Vector2 result = min(min(a, b), c);
			foreach (Vector2 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple Vector3 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3 min(Vector3 a, Vector3 b, Vector3 c, params Vector3[] other) {
			Vector3 result = min(min(a, b), c);
			foreach (Vector3 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple Vector4 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector4 min(Vector4 a, Vector4 b, Vector4 c, params Vector4[] other) {
			Vector4 result = min(min(a, b), c);
			foreach (Vector4 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple Vector2Int vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2Int min(Vector2Int a, Vector2Int b, Vector2Int c, params Vector2Int[] other) {
			Vector2Int result = min(min(a, b), c);
			foreach (Vector2Int element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple Vector3Int vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3Int min(Vector3Int a, Vector3Int b, Vector3Int c, params Vector3Int[] other) {
			Vector3Int result = min(min(a, b), c);
			foreach (Vector3Int element in other) {
				result = min(result, element);
			}
			return result;
		}

		// <summary>Returns the componentwise minimum of multiple Vector4Int vectors.</summary>
		// <param name="a">The first input value.</param>
		// <param name="b">The second input value.</param>
		// <param name="c">The third input value.</param>
		// <param name="other">Additional input values.</param>
		// <returns>The componentwise minimum of the input values.</returns>
		//[MethodImpl(AggressiveInlining)]
		//public static Vector4Int min(Vector4Int a, Vector4Int b, Vector4Int c, params Vector4Int[] other) {
		//	Vector4Int result = min(min(a, b), c);
		//	foreach (Vector4Int element in other) {
		//		result = min(result, element);
		//	}
		//	return result;
		//}

		// MARK: - Vectors

		/// <summary>Returns the componentwise minimum of two half2 vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half2 min(half2 x, half2 y)
			=> new(min(x.x, y.x), min(x.y, y.y));

		/// <summary>Returns the componentwise minimum of two half3 vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half3 min(half3 x, half3 y)
			=> new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z));

		/// <summary>Returns the componentwise minimum of two half4 vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise minimum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half4 min(half4 x, half4 y)
			=> new(min(x.x, y.x), min(x.y, y.y), min(x.z, y.z), min(x.w, y.w));

		/// <summary>Returns the componentwise minimum of multiple half2 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half2 min(half2 a, half2 b, half2 c, params half2[] other) {
			half2 result = min(min(a, b), c);
			foreach (half2 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple half3 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half3 min(half3 a, half3 b, half3 c, params half3[] other) {
			half3 result = min(min(a, b), c);
			foreach (half3 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple half4 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half4 min(half4 a, half4 b, half4 c, params half4[] other) {
			half4 result = min(min(a, b), c);
			foreach (half4 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple float2 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float2 min(float2 a, float2 b, float2 c, params float2[] other) {
			float2 result = min(min(a, b), c);
			foreach (float2 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple float3 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float3 min(float3 a, float3 b, float3 c, params float3[] other) {
			float3 result = min(min(a, b), c);
			foreach (float3 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple float4 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float4 min(float4 a, float4 b, float4 c, params float4[] other) {
			float4 result = min(min(a, b), c);
			foreach (float4 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple double2 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double2 min(double2 a, double2 b, double2 c, params double2[] other) {
			double2 result = min(min(a, b), c);
			foreach (double2 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple double3 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double3 min(double3 a, double3 b, double3 c, params double3[] other) {
			double3 result = min(min(a, b), c);
			foreach (double3 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple double4 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double4 min(double4 a, double4 b, double4 c, params double4[] other) {
			double4 result = min(min(a, b), c);
			foreach (double4 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple int2 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int2 min(int2 a, int2 b, int2 c, params int2[] other) {
			int2 result = min(min(a, b), c);
			foreach (int2 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple int3 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int3 min(int3 a, int3 b, int3 c, params int3[] other) {
			int3 result = min(min(a, b), c);
			foreach (int3 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple int4 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int4 min(int4 a, int4 b, int4 c, params int4[] other) {
			int4 result = min(min(a, b), c);
			foreach (int4 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple uint2 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint2 min(uint2 a, uint2 b, uint2 c, params uint2[] other) {
			uint2 result = min(min(a, b), c);
			foreach (uint2 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple uint3 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint3 min(uint3 a, uint3 b, uint3 c, params uint3[] other) {
			uint3 result = min(min(a, b), c);
			foreach (uint3 element in other) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise minimum of multiple uint4 vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise minimum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint4 min(uint4 a, uint4 b, uint4 c, params uint4[] other) {
			uint4 result = min(min(a, b), c);
			foreach (uint4 element in other) {
				result = min(result, element);
			}
			return result;
		}

		// MARK: - Collections

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float? min(IList<float> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<float>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="float.PositiveInfinity"/>.</returns>
		public static float min(IEnumerable<float> collection) {
			float result = float.PositiveInfinity;
			foreach (float element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double? min(IList<double> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<double>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="double.PositiveInfinity"/>.</returns>
		public static double min(IEnumerable<double> collection) {
			double result = double.PositiveInfinity;
			foreach (double element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int? min(IList<int> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<int>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="int.MaxValue"/>.</returns>
		public static int min(IEnumerable<int> collection) {
			int result = int.MaxValue;
			foreach (int element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint? min(IList<uint> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<uint>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="uint.MaxValue"/>.</returns>
		public static uint min(IEnumerable<uint> collection) {
			uint result = uint.MaxValue;
			foreach (uint element in collection) {
				result = min(result, element);
			}
			return result;
		}

		// MARK: - Vector Collections

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float2? min(IList<float2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<float2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.PositiveInfinity"/>.</returns>
		public static float2 min(IEnumerable<float2> collection) {
			float2 result = float.PositiveInfinity;
			foreach (float2 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float3? min(IList<float3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<float3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.PositiveInfinity"/>.</returns>
		public static float3 min(IEnumerable<float3> collection) {
			float3 result = float.PositiveInfinity;
			foreach (float3 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float4? min(IList<float4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<float4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.PositiveInfinity"/>.</returns>
		public static float4 min(IEnumerable<float4> collection) {
			float4 result = float.PositiveInfinity;
			foreach (float4 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double2? min(IList<double2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<double2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="double.PositiveInfinity"/>.</returns>
		public static double2 min(IEnumerable<double2> collection) {
			double2 result = double.PositiveInfinity;
			foreach (double2 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double3? min(IList<double3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<double3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="double.PositiveInfinity"/>.</returns>
		public static double3 min(IEnumerable<double3> collection) {
			double3 result = double.PositiveInfinity;
			foreach (double3 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double4? min(IList<double4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<double4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="double.PositiveInfinity"/>.</returns>
		public static double4 min(IEnumerable<double4> collection) {
			double4 result = double.PositiveInfinity;
			foreach (double4 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int2? min(IList<int2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<int2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MaxValue"/>.</returns>
		public static int2 min(IEnumerable<int2> collection) {
			int2 result = int.MaxValue;
			foreach (int2 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int3? min(IList<int3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<int3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MaxValue"/>.</returns>
		public static int3 min(IEnumerable<int3> collection) {
			int3 result = int.MaxValue;
			foreach (int3 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int4? min(IList<int4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<int4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MaxValue"/>.</returns>
		public static int4 min(IEnumerable<int4> collection) {
			int4 result = int.MaxValue;
			foreach (int4 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint2? min(IList<uint2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<uint2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="uint.MaxValue"/>.</returns>
		public static uint2 min(IEnumerable<uint2> collection) {
			uint2 result = uint.MaxValue;
			foreach (uint2 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint3? min(IList<uint3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<uint3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="uint.MaxValue"/>.</returns>
		public static uint3 min(IEnumerable<uint3> collection) {
			uint3 result = uint.MaxValue;
			foreach (uint3 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint4? min(IList<uint4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<uint4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="uint.MaxValue"/>.</returns>
		public static uint4 min(IEnumerable<uint4> collection) {
			uint4 result = uint.MaxValue;
			foreach (uint4 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		// MARK: - Unity Vector Collections

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector2? min(IList<Vector2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<Vector2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.PositiveInfinity"/>.</returns>
		public static Vector2 min(IEnumerable<Vector2> collection) {
			Vector2 result = new(float.PositiveInfinity, float.PositiveInfinity);
			foreach (Vector2 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector3? min(IList<Vector3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<Vector3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.PositiveInfinity"/>.</returns>
		public static Vector3 min(IEnumerable<Vector3> collection) {
			Vector3 result = new(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
			foreach (Vector3 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector4? min(IList<Vector4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<Vector4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.PositiveInfinity"/>.</returns>
		public static Vector4 min(IEnumerable<Vector4> collection) {
			Vector4 result = new(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
			foreach (Vector4 element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector2Int? min(IList<Vector2Int> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<Vector2Int>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MaxValue"/>.</returns>
		public static Vector2Int min(IEnumerable<Vector2Int> collection) {
			Vector2Int result = new(int.MaxValue, int.MaxValue);
			foreach (Vector2Int element in collection) {
				result = min(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector3Int? min(IList<Vector3Int> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return min(collection[0], collection[1]);
				default:
					return min(collection as IEnumerable<Vector3Int>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MaxValue"/>.</returns>
		public static Vector3Int min(IEnumerable<Vector3Int> collection) {
			Vector3Int result = new(int.MaxValue, int.MaxValue, int.MaxValue);
			foreach (Vector3Int element in collection) {
				result = min(result, element);
			}
			return result;
		}

		// <summary>
		// 	<para>
		// 	Complexity: O(n)
		// 	</para>
		// </summary>
		// <param name="collection"></param>
		// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		//public static Vector4Int? min(IList<Vector4Int> collection) {
		//	switch (collection.Count) {
		//		case 0:
		//			return null;
		//		case 1:
		//			return collection[0];
		//		//case 2:
		//		//	return min(collection[0], collection[1]);
		//		default:
		//			return min(collection as IEnumerable<Vector4Int>);
		//	}
		//}

		// <summary>
		// 	<para>
		// 	Complexity: O(n)
		// 	</para>
		// </summary>
		// <param name="collection"></param>
		// <returns>The minimum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MaxValue"/>.</returns>
		//public static Vector4Int min(IEnumerable<Vector4Int> collection) {
		//	Vector4Int result = new(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
		//	foreach (Vector4Int element in collection) {
		//		result = min(result, element);
		//	}
		//	return result;
		//}
	}
}