using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		internal static Vector _construct<Scalar, Vector>(Scalar x, Scalar y)
			where Scalar : struct
			where Vector : ISIMD2<Scalar> {
			Vector result = default;
			result[0] = x;
			result[1] = y;
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		internal static Vector _construct<Scalar, Vector>(Scalar x, Scalar y, Scalar z)
			where Scalar : struct
			where Vector : ISIMD3<Scalar> {
			Vector result = default;
			result[0] = x;
			result[1] = y;
			result[2] = z;
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		internal static Vector _construct<Scalar, Vector>(Scalar x, Scalar y, Scalar z, Scalar w)
			where Scalar : struct
			where Vector : ISIMD4<Scalar> {
			Vector result = default;
			result[0] = x;
			result[1] = y;
			result[2] = z;
			result[3] = w;
			return result;
		}
	}
}