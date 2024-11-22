using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		public static float max(float a, float b, float c, params float[] other) {
			float result = max(max(a, b), c);
			foreach (float element in other) {
				result = max(result, element);
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static double max(double a, double b, double c, params double[] other) {
			double result = max(max(a, b), c);
			foreach (double element in other) {
				result = max(result, element);
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static int max(int a, int b, int c, params int[] other) {
			int result = max(max(a, b), c);
			foreach (int element in other) {
				result = max(result, element);
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static uint max(uint a, uint b, uint c, params uint[] other) {
			uint result = max(max(a, b), c);
			foreach (uint element in other) {
				result = max(result, element);
			}
			return result;
		}
	}
}