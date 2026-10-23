using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - Unity Vector

		/// <summary>
		/// Returns the result of a componentwise clamping of the <see cref="Vector2"/> <see paramref="valueToClamp"/> into the interval [<see paramref="lowerBound"/>, <see paramref="upperBound"/>],
		/// where <see paramref="lowerBound"/> and <see paramref="upperBound"/> are <see cref="Vector2"/> vectors.
		/// </summary>
		/// <param name="valueToClamp">Input value to be clamped.</param>
		/// <param name="lowerBound">Lower bound of the interval.</param>
		/// <param name="upperBound">Upper bound of the interval.</param>
		/// <returns>The componentwise clamping of the input <see paramref="valueToClamp"/> into the interval (inclusive) [<see paramref="lowerBound"/>, <see paramref="upperBound"/>].</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2 clamp(Vector2 valueToClamp, Vector2 lowerBound, Vector2 upperBound)
			=> max(lowerBound, min(upperBound, valueToClamp));

		/// <summary>
		/// Returns the result of a componentwise clamping of the <see cref="Vector3"/> <see paramref="valueToClamp"/> into the interval [<see paramref="lowerBound"/>, <see paramref="upperBound"/>],
		/// where <see paramref="lowerBound"/> and <see paramref="upperBound"/> are <see cref="Vector3"/> vectors.
		/// </summary>
		/// <param name="valueToClamp">Input value to be clamped.</param>
		/// <param name="lowerBound">Lower bound of the interval.</param>
		/// <param name="upperBound">Upper bound of the interval.</param>
		/// <returns>The componentwise clamping of the input <see paramref="valueToClamp"/> into the interval (inclusive) [<see paramref="lowerBound"/>, <see paramref="upperBound"/>].</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3 clamp(Vector3 valueToClamp, Vector3 lowerBound, Vector3 upperBound)
			=> max(lowerBound, min(upperBound, valueToClamp));

		/// <summary>
		/// Returns the result of a componentwise clamping of the <see cref="Vector4"/> <see paramref="valueToClamp"/> into the interval [<see paramref="lowerBound"/>, <see paramref="upperBound"/>],
		/// where <see paramref="lowerBound"/> and <see paramref="upperBound"/> are <see cref="Vector4"/> vectors.
		/// </summary>
		/// <param name="valueToClamp">Input value to be clamped.</param>
		/// <param name="lowerBound">Lower bound of the interval.</param>
		/// <param name="upperBound">Upper bound of the interval.</param>
		/// <returns>The componentwise clamping of the input <see paramref="valueToClamp"/> into the interval (inclusive) [<see paramref="lowerBound"/>, <see paramref="upperBound"/>].</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector4 clamp(Vector4 valueToClamp, Vector4 lowerBound, Vector4 upperBound)
			=> max(lowerBound, min(upperBound, valueToClamp));

		/// <summary>
		/// Returns the result of a componentwise clamping of the <see cref="Vector2Int"/> <see paramref="valueToClamp"/> into the interval [<see paramref="lowerBound"/>, <see paramref="upperBound"/>],
		/// where <see paramref="lowerBound"/> and <see paramref="upperBound"/> are <see cref="Vector2Int"/> vectors.
		/// </summary>
		/// <param name="valueToClamp">Input value to be clamped.</param>
		/// <param name="lowerBound">Lower bound of the interval.</param>
		/// <param name="upperBound">Upper bound of the interval.</param>
		/// <returns>The componentwise clamping of the input <see paramref="valueToClamp"/> into the interval (inclusive) [<see paramref="lowerBound"/>, <see paramref="upperBound"/>].</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector2Int clamp(Vector2Int valueToClamp, Vector2Int lowerBound, Vector2Int upperBound)
			=> max(lowerBound, min(upperBound, valueToClamp));

		/// <summary>
		/// Returns the result of a componentwise clamping of the <see cref="Vector3Int"/> <see paramref="valueToClamp"/> into the interval [<see paramref="lowerBound"/>, <see paramref="upperBound"/>],
		/// where <see paramref="lowerBound"/> and <see paramref="upperBound"/> are <see cref="Vector3Int"/> vectors.
		/// </summary>
		/// <param name="valueToClamp">Input value to be clamped.</param>
		/// <param name="lowerBound">Lower bound of the interval.</param>
		/// <param name="upperBound">Upper bound of the interval.</param>
		/// <returns>The componentwise clamping of the input <see paramref="valueToClamp"/> into the interval (inclusive) [<see paramref="lowerBound"/>, <see paramref="upperBound"/>].</returns>
		[MethodImpl(AggressiveInlining)]
		public static Vector3Int clamp(Vector3Int valueToClamp, Vector3Int lowerBound, Vector3Int upperBound)
			=> max(lowerBound, min(upperBound, valueToClamp));

		// <summary>
		// Returns the result of a componentwise clamping of the <see cref="Vector4Int"/> <see paramref="valueToClamp"/> into the interval [<see paramref="lowerBound"/>, <see paramref="upperBound"/>],
		// where <see paramref="lowerBound"/> and <see paramref="upperBound"/> are <see cref="Vector4Int"/> vectors.
		// </summary>
		// <param name="valueToClamp">Input value to be clamped.</param>
		// <param name="lowerBound">Lower bound of the interval.</param>
		// <param name="upperBound">Upper bound of the interval.</param>
		// <returns>The componentwise clamping of the input <see paramref="valueToClamp"/> into the interval (inclusive) [<see paramref="lowerBound"/>, <see paramref="upperBound"/>].</returns>
		//[MethodImpl(AggressiveInlining)]
		//public static Vector4Int clamp(Vector4Int valueToClamp, Vector4Int lowerBound, Vector4Int upperBound)
		//	=> max(lowerBound, min(upperBound, valueToClamp));
	}
}