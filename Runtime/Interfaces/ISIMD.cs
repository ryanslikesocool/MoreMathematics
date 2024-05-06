namespace Unity.Mathematics {
	public interface ISIMD<Scalar> where Scalar : struct {
		/// <summary>
		/// The number of lanes in the vector.
		/// </summary>
		public int Length { get; }

		/// <summary>
		/// Access an element of this vector by index.
		/// </summary>
		Scalar this[int index] { get; set; }
	}
}