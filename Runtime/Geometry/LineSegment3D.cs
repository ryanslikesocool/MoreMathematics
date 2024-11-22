using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics.Geometry {
	using static math;

	[Serializable]
	public struct LineSegment3D : IEquatable<LineSegment3D> {
		public float3 p0;
		public float3 p1;

		public float3 this[int index] {
			readonly get => index switch {
				0 => p0,
				1 => p1,
				_ => throw new IndexOutOfRangeException()
			};
			set {
				switch (index) {
					case 0:
						this.p0 = value;
						break;
					case 1:
						this.p1 = value;
						break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		// MARK: - Lifecycle

		[MethodImpl(AggressiveInlining)]
		public LineSegment3D(in float3 p0, in float3 p1) {
			this.p0 = p0;
			this.p1 = p1;
		}

		// MARK: - Overload

		public readonly override bool Equals(object other) => other switch {
			LineSegment3D lineSegment => this.Equals(lineSegment),
			_ => false
		};

		public readonly override int GetHashCode()
			=> (p0, p1).GetHashCode();

		public readonly override string ToString()
			=> string.Format(FORMAT_TOSTRING, nameof(LineSegment3D), p0, p1);

		// MARK: - Operators

		[MethodImpl(AggressiveInlining)]
		public static bool2 operator ==(in LineSegment3D lhs, in LineSegment3D rhs)
			=> new bool2(all(lhs.p0 == rhs.p0), all(lhs.p1 == rhs.p1));

		[MethodImpl(AggressiveInlining)]
		public static bool2 operator !=(in LineSegment3D lhs, in LineSegment3D rhs)
			=> new bool2(any(lhs.p0 != rhs.p0), any(lhs.p1 != rhs.p1));

		// MARK: - IEquatable

		[MethodImpl(AggressiveInlining)]
		public readonly bool Equals(LineSegment3D other)
			=> this.p0.Equals(other.p0) && this.p1.Equals(other.p1);

		// MARK: -

		/// <summary>
		/// Reverse the line segment in place.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public void Reverse() {
			(p0, p1) = (p1, p0);
		}

		/// <summary>
		/// Returns a reversed copy of the line segment.
		/// </summary>
		/// <returns>A reversed copy of the line segment.</returns>
		[MethodImpl(AggressiveInlining)]
		public readonly LineSegment3D Reversed()
			=> new LineSegment3D(p1, p0);

		/// <summary>
		/// Translate the line segment in place.
		/// </summary>
		/// <param name="delta">The amount to translate the line segment by.</param>
		[MethodImpl(AggressiveInlining)]
		public void Translate(in float3 delta) {
			p0 += delta;
			p1 += delta;
		}

		/// <summary>
		/// Returns a translated copy of the line segment.
		/// </summary>
		/// <param name="delta">The amount to translate the copied line segment by.</param>
		/// <returns>A translated copy of the line segment.</returns>
		[MethodImpl(AggressiveInlining)]
		public readonly LineSegment3D Translated(in float3 delta)
			=> new LineSegment3D(p0 + delta, p1 + delta);

		// MARK: - Constants

		public static readonly LineSegment3D zero
			= new LineSegment3D(Mathematics.float3.zero, Mathematics.float3.zero);

		private const string FORMAT_TOSTRING = "{0}({1}, {2})";
	}
}