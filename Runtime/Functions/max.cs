using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		/// <summary>Returns the maximum of two <see cref="Unity.Mathematics.half"/> values.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half max(half x, half y)
			=> isnan(y) || x > y ? x : y;

		/// <summary>Returns the maximum of multiple <see cref="Unity.Mathematics.half"/> values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half max(half a, half b, half c, params half[] other) {
			half result = max(max(a, b), c);
			foreach (half element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the maximum of multiple <see cref="float"/> values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float max(float a, float b, float c, params float[] other) {
			float result = max(max(a, b), c);
			foreach (float element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the maximum of multiple <see cref="double"/> values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double max(double a, double b, double c, params double[] other) {
			double result = max(max(a, b), c);
			foreach (double element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the maximum of multiple <see cref="int"/> values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int max(int a, int b, int c, params int[] other) {
			int result = max(max(a, b), c);
			foreach (int element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the maximum of multiple <see cref="uint"/> values.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint max(uint a, uint b, uint c, params uint[] other) {
			uint result = max(max(a, b), c);
			foreach (uint element in other) {
				result = max(result, element);
			}
			return result;
		}

		// MARK: - Unity Vectors

		/// <summary>Returns the componentwise maximum of two <see cref="Vector2"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 max(Vector2 x, Vector2 y)
			=> new(max(x.x, y.x), max(x.y, y.y));

		/// <summary>Returns the componentwise maximum of two <see cref="Vector3"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3 max(Vector3 x, Vector3 y)
			=> new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));

		/// <summary>Returns the componentwise maximum of two <see cref="Vector4"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector4 max(Vector4 x, Vector4 y)
			=> new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));

		/// <summary>Returns the componentwise maximum of two <see cref="Vector2Int"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2Int max(Vector2Int x, Vector2Int y)
			=> new(max(x.x, y.x), max(x.y, y.y));

		/// <summary>Returns the componentwise maximum of two <see cref="Vector3Int"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3Int max(Vector3Int x, Vector3Int y)
			=> new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));

		// <summary>Returns the componentwise maximum of two <see cref="Vector4Int"/> vectors.</summary>
		// <param name="x">The first input value.</param>
		// <param name="y">The second input value.</param>
		// <returns>The componentwise maximum of the two input values.</returns>
		//[MethodImpl(AggressiveInlining)]
		//public static Vector4Int max(Vector4Int x, Vector4Int y)
		//	=> new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));

		/// <summary>Returns the componentwise maximum of multiple <see cref="Vector2"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 max(Vector2 a, Vector2 b, Vector2 c, params Vector2[] other) {
			Vector2 result = max(max(a, b), c);
			foreach (Vector2 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Vector3"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3 max(Vector3 a, Vector3 b, Vector3 c, params Vector3[] other) {
			Vector3 result = max(max(a, b), c);
			foreach (Vector3 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Vector4"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector4 max(Vector4 a, Vector4 b, Vector4 c, params Vector4[] other) {
			Vector4 result = max(max(a, b), c);
			foreach (Vector4 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Vector2Int"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2Int max(Vector2Int a, Vector2Int b, Vector2Int c, params Vector2Int[] other) {
			Vector2Int result = max(max(a, b), c);
			foreach (Vector2Int element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Vector3Int"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3Int max(Vector3Int a, Vector3Int b, Vector3Int c, params Vector3Int[] other) {
			Vector3Int result = max(max(a, b), c);
			foreach (Vector3Int element in other) {
				result = max(result, element);
			}
			return result;
		}

		// <summary>Returns the componentwise maximum of multiple <see cref="Vector4Int"/> vectors.</summary>
		// <param name="a">The first input value.</param>
		// <param name="b">The second input value.</param>
		// <param name="c">The third input value.</param>
		// <param name="other">Additional input values.</param>
		// <returns>The componentwise maximum of the input values.</returns>
		//[MethodImpl(AggressiveInlining)]
		//public static Vector4Int max(Vector4Int a, Vector4Int b, Vector4Int c, params Vector4Int[] other) {
		//	Vector4Int result = max(max(a, b), c);
		//	foreach (Vector4Int element in other) {
		//		result = max(result, element);
		//	}
		//	return result;
		//}

		// MARK: - Vectors

		/// <summary>Returns the componentwise maximum of two <see cref="Unity.Mathematics.half2"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half2 max(half2 x, half2 y)
			=> new(max(x.x, y.x), max(x.y, y.y));

		/// <summary>Returns the componentwise maximum of two <see cref="Unity.Mathematics.half3"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half3 max(half3 x, half3 y)
			=> new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z));

		/// <summary>Returns the componentwise maximum of two <see cref="Unity.Mathematics.half4"/> vectors.</summary>
		/// <param name="x">The first input value.</param>
		/// <param name="y">The second input value.</param>
		/// <returns>The componentwise maximum of the two input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half4 max(half4 x, half4 y)
			=> new(max(x.x, y.x), max(x.y, y.y), max(x.z, y.z), max(x.w, y.w));

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.half2"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half2 max(half2 a, half2 b, half2 c, params half2[] other) {
			half2 result = max(max(a, b), c);
			foreach (half2 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.half3"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half3 max(half3 a, half3 b, half3 c, params half3[] other) {
			half3 result = max(max(a, b), c);
			foreach (half3 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.half4"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static half4 max(half4 a, half4 b, half4 c, params half4[] other) {
			half4 result = max(max(a, b), c);
			foreach (half4 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.float2"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float2 max(float2 a, float2 b, float2 c, params float2[] other) {
			float2 result = max(max(a, b), c);
			foreach (float2 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.float3"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float3 max(float3 a, float3 b, float3 c, params float3[] other) {
			float3 result = max(max(a, b), c);
			foreach (float3 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.float4"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static float4 max(float4 a, float4 b, float4 c, params float4[] other) {
			float4 result = max(max(a, b), c);
			foreach (float4 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.double2"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double2 max(double2 a, double2 b, double2 c, params double2[] other) {
			double2 result = max(max(a, b), c);
			foreach (double2 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.double3"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double3 max(double3 a, double3 b, double3 c, params double3[] other) {
			double3 result = max(max(a, b), c);
			foreach (double3 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.double4"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static double4 max(double4 a, double4 b, double4 c, params double4[] other) {
			double4 result = max(max(a, b), c);
			foreach (double4 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.int2"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int2 max(int2 a, int2 b, int2 c, params int2[] other) {
			int2 result = max(max(a, b), c);
			foreach (int2 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.int3"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int3 max(int3 a, int3 b, int3 c, params int3[] other) {
			int3 result = max(max(a, b), c);
			foreach (int3 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.int4"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static int4 max(int4 a, int4 b, int4 c, params int4[] other) {
			int4 result = max(max(a, b), c);
			foreach (int4 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.uint2"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint2 max(uint2 a, uint2 b, uint2 c, params uint2[] other) {
			uint2 result = max(max(a, b), c);
			foreach (uint2 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.uint3"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint3 max(uint3 a, uint3 b, uint3 c, params uint3[] other) {
			uint3 result = max(max(a, b), c);
			foreach (uint3 element in other) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>Returns the componentwise maximum of multiple <see cref="Unity.Mathematics.uint4"/> vectors.</summary>
		/// <param name="a">The first input value.</param>
		/// <param name="b">The second input value.</param>
		/// <param name="c">The third input value.</param>
		/// <param name="other">Additional input values.</param>
		/// <returns>The componentwise maximum of the input values.</returns>
		[MethodImpl(AggressiveInlining)]
		public static uint4 max(uint4 a, uint4 b, uint4 c, params uint4[] other) {
			uint4 result = max(max(a, b), c);
			foreach (uint4 element in other) {
				result = max(result, element);
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
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float? max(IList<float> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<float>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="float.NegativeInfinity"/>.</returns>
		public static float max(IEnumerable<float> collection) {
			float result = float.NegativeInfinity;
			foreach (float element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double? max(IList<double> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<double>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="double.NegativeInfinity"/>.</returns>
		public static double max(IEnumerable<double> collection) {
			double result = double.NegativeInfinity;
			foreach (double element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int? max(IList<int> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<int>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="int.MinValue"/>.</returns>
		public static int max(IEnumerable<int> collection) {
			int result = int.MinValue;
			foreach (int element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint? max(IList<uint> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<uint>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see cref="uint.MinValue"/>.</returns>
		public static uint max(IEnumerable<uint> collection) {
			uint result = uint.MinValue;
			foreach (uint element in collection) {
				result = max(result, element);
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
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float2? max(IList<float2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<float2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.NegativeInfinity"/>.</returns>
		public static float2 max(IEnumerable<float2> collection) {
			float2 result = float.NegativeInfinity;
			foreach (float2 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float3? max(IList<float3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<float3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.NegativeInfinity"/>.</returns>
		public static float3 max(IEnumerable<float3> collection) {
			float3 result = float.NegativeInfinity;
			foreach (float3 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static float4? max(IList<float4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<float4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.NegativeInfinity"/>.</returns>
		public static float4 max(IEnumerable<float4> collection) {
			float4 result = float.NegativeInfinity;
			foreach (float4 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double2? max(IList<double2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<double2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="double.NegativeInfinity"/>.</returns>
		public static double2 max(IEnumerable<double2> collection) {
			double2 result = double.NegativeInfinity;
			foreach (double2 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double3? max(IList<double3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<double3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="double.NegativeInfinity"/>.</returns>
		public static double3 max(IEnumerable<double3> collection) {
			double3 result = double.NegativeInfinity;
			foreach (double3 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static double4? max(IList<double4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<double4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="double.NegativeInfinity"/>.</returns>
		public static double4 max(IEnumerable<double4> collection) {
			double4 result = double.NegativeInfinity;
			foreach (double4 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int2? max(IList<int2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<int2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MinValue"/>.</returns>
		public static int2 max(IEnumerable<int2> collection) {
			int2 result = int.MinValue;
			foreach (int2 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int3? max(IList<int3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<int3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MinValue"/>.</returns>
		public static int3 max(IEnumerable<int3> collection) {
			int3 result = int.MinValue;
			foreach (int3 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static int4? max(IList<int4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<int4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MinValue"/>.</returns>
		public static int4 max(IEnumerable<int4> collection) {
			int4 result = int.MinValue;
			foreach (int4 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint2? max(IList<uint2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<uint2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="uint.MinValue"/>.</returns>
		public static uint2 max(IEnumerable<uint2> collection) {
			uint2 result = uint.MinValue;
			foreach (uint2 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint3? max(IList<uint3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<uint3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="uint.MinValue"/>.</returns>
		public static uint3 max(IEnumerable<uint3> collection) {
			uint3 result = uint.MinValue;
			foreach (uint3 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static uint4? max(IList<uint4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<uint4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="uint.MinValue"/>.</returns>
		public static uint4 max(IEnumerable<uint4> collection) {
			uint4 result = uint.MinValue;
			foreach (uint4 element in collection) {
				result = max(result, element);
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
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector2? max(IList<Vector2> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<Vector2>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.NegativeInfinity"/>.</returns>
		public static Vector2 max(IEnumerable<Vector2> collection) {
			Vector2 result = new(float.NegativeInfinity, float.NegativeInfinity);
			foreach (Vector2 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector3? max(IList<Vector3> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<Vector3>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.NegativeInfinity"/>.</returns>
		public static Vector3 max(IEnumerable<Vector3> collection) {
			Vector3 result = new(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
			foreach (Vector3 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector4? max(IList<Vector4> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<Vector4>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="float.NegativeInfinity"/>.</returns>
		public static Vector4 max(IEnumerable<Vector4> collection) {
			Vector4 result = new(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
			foreach (Vector4 element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector2Int? max(IList<Vector2Int> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<Vector2Int>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MinValue"/>.</returns>
		public static Vector2Int max(IEnumerable<Vector2Int> collection) {
			Vector2Int result = new(int.MinValue, int.MinValue);
			foreach (Vector2Int element in collection) {
				result = max(result, element);
			}
			return result;
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		public static Vector3Int? max(IList<Vector3Int> collection) {
			switch (collection.Count) {
				case 0:
					return null;
				case 1:
					return collection[0];
				//case 2:
				//	return max(collection[0], collection[1]);
				default:
					return max(collection as IEnumerable<Vector3Int>);
			}
		}

		/// <summary>
		/// 	<para>
		/// 	Complexity: O(n)
		/// 	</para>
		/// </summary>
		/// <param name="collection"></param>
		/// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MinValue"/>.</returns>
		public static Vector3Int max(IEnumerable<Vector3Int> collection) {
			Vector3Int result = new(int.MinValue, int.MinValue, int.MinValue);
			foreach (Vector3Int element in collection) {
				result = max(result, element);
			}
			return result;
		}

		// <summary>
		// 	<para>
		// 	Complexity: O(n)
		// 	</para>
		// </summary>
		// <param name="collection"></param>
		// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns <see langword="null"/>.</returns>
		//public static Vector4Int? max(IList<Vector4Int> collection) {
		//	switch (collection.Count) {
		//		case 0:
		//			return null;
		//		case 1:
		//			return collection[0];
		//		//case 2:
		//		//	return max(collection[0], collection[1]);
		//		default:
		//			return max(collection as IEnumerable<Vector4Int>);
		//	}
		//}

		// <summary>
		// 	<para>
		// 	Complexity: O(n)
		// 	</para>
		// </summary>
		// <param name="collection"></param>
		// <returns>The maximum of the input values.  If the given <see paramref="collection"/> is empty, returns a vector with each lane set to <see cref="int.MinValue"/>.</returns>
		//public static Vector4Int max(IEnumerable<Vector4Int> collection) {
		//	Vector4Int result = new(int.MinValue, int.MinValue, int.MinValue, int.MinValue);
		//	foreach (Vector4Int element in collection) {
		//		result = max(result, element);
		//	}
		//	return result;
		//}
	}
}