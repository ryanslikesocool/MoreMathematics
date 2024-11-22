using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics.Geometry {
	using static math;

	[Serializable]
	public partial struct Ray3D : IEquatable<Ray3D> {
		/// <summary>
		/// The starting point of the ray.
		/// </summary>
		[Tooltip("The starting point of the ray.")]
		public float3 origin;

		/// <summary>
		/// The direction the ray is pointing in.
		/// </summary>
		[Tooltip("The direction the ray is pointing in.")]
		public float3 direction;

		// MARK: - Lifecycle

		/// <summary>
		/// Create a new ray.
		/// </summary>
		/// <param name="origin">The starting point of the ray.</param>
		/// <param name="direction">The direction the ray is pointing in.</param>
		[MethodImpl(AggressiveInlining)]
		public Ray3D(in float3 origin, in float3 direction) {
			this.origin = origin;
			this.direction = direction;
		}

		// MARK: - Overload

		public readonly override bool Equals(object other) => other switch {
			Ray3D ray => this.Equals(ray),
			_ => false
		};

		public readonly override int GetHashCode()
			=> (origin, direction).GetHashCode();

		public readonly override string ToString()
			=> string.Format(FORMAT_TOSTRING, nameof(Ray3D), origin, direction);

		// MARK: - Operators

		[MethodImpl(AggressiveInlining)]
		public static bool operator ==(in Ray3D lhs, in Ray3D rhs)
			=> lhs.Equals(rhs);

		[MethodImpl(AggressiveInlining)]
		public static bool operator !=(in Ray3D lhs, in Ray3D rhs)
			=> !lhs.Equals(rhs);

		[MethodImpl(AggressiveInlining)]
		public static implicit operator UnityEngine.Ray(in Ray3D ray)
			=> new UnityEngine.Ray(ray.origin, ray.direction);

		[MethodImpl(AggressiveInlining)]
		public static implicit operator Ray3D(in UnityEngine.Ray ray)
			=> new Ray3D(ray.origin, ray.direction);

		// MARK: - IEquatable

		public readonly bool Equals(Ray3D other)
			=> this.origin.Equals(other.origin) && this.direction.Equals(other.direction);

		// MARK: -

		/// <summary>
		/// Returns a Boolean value indicating if the ray is normalized or not.
		/// </summary>
		/// <returns><see langword="true"/> if the ray is normalized; <see langword="false"/> otherwise.</returns>
		[MethodImpl(AggressiveInlining)]
		public readonly bool IsNormalized(float epsilon = EPSILON)
			=> approximately(lengthsq(direction), 1.0f, epsilon: epsilon);

		/// <summary>
		/// Normalize the ray in place.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public void Normalize() {
			direction = normalize(direction);
		}

		[MethodImpl(AggressiveInlining)]
		public readonly float3 Evaluate(float distance)
			=> origin + direction * distance;

		/// <remarks>
		/// This method assumed that <see cref="origin"/> and <see paramref="point"/> are not equal.
		/// </remarks>
		public readonly bool ContainsPoint(in float3 point, float epsilon = EPSILON) {
			float3 newNorm = normalize(point - origin);
			if (all(point == origin)) {
				return true;
			}
			float d = dot(newNorm, direction);
			return approximately(1.0f - d, 0.0f, epsilon: epsilon);
		}

		public readonly float DistanceToPoint(in float3 point) {
			float3 s = point - origin;
			float t = dot(s, direction);
			return lengthsq(s) - t * t * rcp(lengthsq(direction));
		}

		/// <summary>
		/// Translate the ray in place.
		/// </summary>
		/// <param name="delta">The amount to translate the ray by.</param>
		[MethodImpl(AggressiveInlining)]
		public void Translate(in float3 delta) {
			origin += delta;
		}

		/// <summary>
		/// Returns a translated copy of the ray.
		/// </summary>
		/// <param name="delta">The amount to translate the copied ray by.</param>
		/// <returns>A translated copy of the ray.</returns>
		[MethodImpl(AggressiveInlining)]
		public readonly Ray3D Translated(in float3 delta)
			=> new Ray3D(origin + delta, direction);

		// MARK: - Constants

		private const string FORMAT_TOSTRING = "{0}(origin: {1}, direction: {2})";

		private const float EPSILON = 0.000001f;

		public static readonly Ray3D zero
			= new Ray3D(Mathematics.float3.zero, Mathematics.float3.zero);
	}
}