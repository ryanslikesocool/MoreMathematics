using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - Unity Vectors

		/// <summary>Returns the result of rounding each component of a Vector2 vector value to the nearest integral value.</summary>
		/// <param name="x">Input value.</param>
		/// <returns>The componentwise round to nearest integral value of the input.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 round(Vector2 x)
			=> new(round(x.x), round(x.y));

		/// <summary>Returns the result of rounding each component of a Vector3 vector value to the nearest integral value.</summary>
		/// <param name="x">Input value.</param>
		/// <returns>The componentwise round to nearest integral value of the input.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3 round(Vector3 x)
			=> new(round(x.x), round(x.y), round(x.z));

		/// <summary>Returns the result of rounding each component of a Vector4 vector value to the nearest integral value.</summary>
		/// <param name="x">Input value.</param>
		/// <returns>The componentwise round to nearest integral value of the input.</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector4 round(Vector4 x)
			=> new(round(x.x), round(x.y), round(x.z), round(x.w));
	}
}