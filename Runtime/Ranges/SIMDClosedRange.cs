using System;

namespace Unity.Mathematics {
	[Serializable]
	public struct SIMDClosedRange<Bound, Scalar>
	where Bound : ISIMD<Scalar>
	where Scalar : struct, IComparable<Scalar> {
		public Bound lowerBound;
		public Bound upperBound;

		public readonly bool IsValid {
			get {
				for (int i = 0; i < lowerBound.Length; i++) {
					if (lowerBound[i].CompareTo(upperBound[i]) > 0) {
						return false;
					}
				}
				return true;
			}
		}

		public readonly bool IsEmpty
			=> lowerBound.Equals(upperBound);

		public SIMDClosedRange(Bound lowerBound, Bound upperBound) {
			this.lowerBound = lowerBound;
			this.upperBound = upperBound;
		}

		public readonly bool Contains(in Bound value) {
			for (int i = 0; i < lowerBound.Length; i++) {
				if (value[i].CompareTo(lowerBound[i]) < 0 || value[i].CompareTo(upperBound[i]) > 0) {
					return false;
				}
			}
			return true;
		}
	}
}