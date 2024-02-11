using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		[MethodImpl(AggressiveInlining)]
		public static float min(float a, float b, float c, params float[] other) {
			float result = min(min(a, b), c);
			foreach (float element in other) {
				result = min(result, element);
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static double min(double a, double b, double c, params double[] other) {
			double result = min(min(a, b), c);
			foreach (double element in other) {
				result = min(result, element);
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static int min(int a, int b, int c, params int[] other) {
			int result = min(min(a, b), c);
			foreach (int element in other) {
				result = min(result, element);
			}
			return result;
		}

		[MethodImpl(AggressiveInlining)]
		public static uint min(uint a, uint b, uint c, params uint[] other) {
			uint result = min(min(a, b), c);
			foreach (uint element in other) {
				result = min(result, element);
			}
			return result;
		}
	}
}