using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics.Geometry {
	using static math;

	[Serializable]
	public partial struct Triangle3D : IEquatable<Triangle3D> {
		public float3 p0;
		public float3 p1;
		public float3 p2;

		public float3 this[int index] {
			readonly get => index switch {
				0 => p0,
				1 => p1,
				2 => p2,
				_ => throw new IndexOutOfRangeException()
			};
			set {
				switch (index) {
					case 0:
						p0 = value;
						break;
					case 1:
						p1 = value;
						break;
					case 2:
						p2 = value;
						break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		// MARK: - Lifecycle

		public Triangle3D(in float3 p0, in float3 p1, in float3 p2) {
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		// MARK: - Overload

		public readonly override bool Equals(object other) => other switch {
			Triangle3D triangle => this.Equals(triangle),
			_ => false
		};

		public readonly override int GetHashCode()
			=> (p0, p1, p2).GetHashCode();

		public readonly override string ToString()
			=> string.Format(FORMAT_TOSTRING, nameof(Triangle3D), p0, p1, p2);

		// MARK: - Operators

		[MethodImpl(AggressiveInlining)]
		public static bool3 operator ==(in Triangle3D lhs, in Triangle3D rhs)
			=> new bool3(all(lhs.p0 == rhs.p0), all(lhs.p1 == rhs.p1), all(lhs.p2 == rhs.p2));

		[MethodImpl(AggressiveInlining)]
		public static bool3 operator !=(in Triangle3D lhs, in Triangle3D rhs)
			=> new bool3(any(lhs.p0 != rhs.p0), any(lhs.p1 != rhs.p1), any(lhs.p2 != rhs.p2));

		// MARK: - IEquatable

		public readonly bool Equals(Triangle3D other)
			=> this.p0.Equals(other.p0) && this.p1.Equals(other.p1) && this.p2.Equals(other.p2);

		// MARK: -

		/// <summary>
		/// Reverses the triangle in place.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public void Reverse() {
			(p0, p2) = (p2, p0);
		}

		/// <summary>
		/// Returns a reversed copy of the triangle.
		/// </summary>
		/// <returns>A reversed copy of the triangle.</returns>
		[MethodImpl(AggressiveInlining)]
		public readonly Triangle3D Reversed()
			=> new Triangle3D(p2, p1, p0);

		/// <summary>
		/// Translate the triangle in place.
		/// </summary>
		/// <param name="delta">The amount to translate the triangle by.</param>
		[MethodImpl(AggressiveInlining)]
		public void Translate(in float3 delta) {
			p0 += delta;
			p1 += delta;
			p2 += delta;
		}

		/// <summary>
		/// Returns a translated copy of the triangle.
		/// </summary>
		/// <param name="delta">The amount to translate the copied triangle by.</param>
		/// <returns>A translated copy of the triangle.</returns>
		[MethodImpl(AggressiveInlining)]
		public readonly Triangle3D Translated(in float3 delta)
			=> new Triangle3D(p0 + delta, p1 + delta, p2 + delta);

		[MethodImpl(AggressiveInlining)]
		public readonly float3 Normal()
			=> cross(p0 - p2, p1 - p2);

		// MARK: - Constants

		private const string FORMAT_TOSTRING = "{0}({1}, {2}, {3})";

		public static readonly Triangle3D zero
			= new Triangle3D(Mathematics.float3.zero, Mathematics.float3.zero, Mathematics.float3.zero);
	}
}
