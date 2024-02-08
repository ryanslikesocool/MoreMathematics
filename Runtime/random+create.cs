namespace Unity.Mathematics {
	public partial struct Random {
		/// <summary>
		/// Create a new instance from a seed provided by UnityEngine.Random.Range.
		/// </summary>
		public static Random Create()
			=> new Random((uint)UnityEngine.Random.Range(int.MinValue, int.MaxValue));
	}
}