namespace Unity.Mathematics {
	public interface ISIMDMatrix<Scalar> : ISIMD<Scalar> where Scalar : struct {
		int Width { get; }
		int Height { get; }
	}
}