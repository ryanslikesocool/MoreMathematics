using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		[MethodImpl(AggressiveInlining)]
		public static float lerpCubic(float a, float b, float c, float d, float t) {
			float ab = lerp(a, b, t);
			float bc = lerp(b, c, t);
			float cd = lerp(c, d, t);
			float abc = lerp(ab, bc, t);
			float bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float2 lerpCubic(float2 a, float2 b, float2 c, float2 d, float t) {
			float2 ab = lerp(a, b, t);
			float2 bc = lerp(b, c, t);
			float2 cd = lerp(c, d, t);
			float2 abc = lerp(ab, bc, t);
			float2 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float2 lerpCubic(float2 a, float2 b, float2 c, float2 d, float2 t) {
			float2 ab = lerp(a, b, t);
			float2 bc = lerp(b, c, t);
			float2 cd = lerp(c, d, t);
			float2 abc = lerp(ab, bc, t);
			float2 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float3 lerpCubic(float3 a, float3 b, float3 c, float3 d, float t) {
			float3 ab = lerp(a, b, t);
			float3 bc = lerp(b, c, t);
			float3 cd = lerp(c, d, t);
			float3 abc = lerp(ab, bc, t);
			float3 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float3 lerpCubic(float3 a, float3 b, float3 c, float3 d, float3 t) {
			float3 ab = lerp(a, b, t);
			float3 bc = lerp(b, c, t);
			float3 cd = lerp(c, d, t);
			float3 abc = lerp(ab, bc, t);
			float3 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float4 lerpCubic(float4 a, float4 b, float4 c, float4 d, float t) {
			float4 ab = lerp(a, b, t);
			float4 bc = lerp(b, c, t);
			float4 cd = lerp(c, d, t);
			float4 abc = lerp(ab, bc, t);
			float4 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float4 lerpCubic(float4 a, float4 b, float4 c, float4 d, float4 t) {
			float4 ab = lerp(a, b, t);
			float4 bc = lerp(b, c, t);
			float4 cd = lerp(c, d, t);
			float4 abc = lerp(ab, bc, t);
			float4 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		// MARK: - double

		[MethodImpl(AggressiveInlining)]
		public static double lerpCubic(double a, double b, double c, double d, double t) {
			double ab = lerp(a, b, t);
			double bc = lerp(b, c, t);
			double cd = lerp(c, d, t);
			double abc = lerp(ab, bc, t);
			double bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double2 lerpCubic(double2 a, double2 b, double2 c, double2 d, double t) {
			double2 ab = lerp(a, b, t);
			double2 bc = lerp(b, c, t);
			double2 cd = lerp(c, d, t);
			double2 abc = lerp(ab, bc, t);
			double2 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double2 lerpCubic(double2 a, double2 b, double2 c, double2 d, double2 t) {
			double2 ab = lerp(a, b, t);
			double2 bc = lerp(b, c, t);
			double2 cd = lerp(c, d, t);
			double2 abc = lerp(ab, bc, t);
			double2 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double3 lerpCubic(double3 a, double3 b, double3 c, double3 d, double t) {
			double3 ab = lerp(a, b, t);
			double3 bc = lerp(b, c, t);
			double3 cd = lerp(c, d, t);
			double3 abc = lerp(ab, bc, t);
			double3 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double3 lerpCubic(double3 a, double3 b, double3 c, double3 d, double3 t) {
			double3 ab = lerp(a, b, t);
			double3 bc = lerp(b, c, t);
			double3 cd = lerp(c, d, t);
			double3 abc = lerp(ab, bc, t);
			double3 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double4 lerpCubic(double4 a, double4 b, double4 c, double4 d, double t) {
			double4 ab = lerp(a, b, t);
			double4 bc = lerp(b, c, t);
			double4 cd = lerp(c, d, t);
			double4 abc = lerp(ab, bc, t);
			double4 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double4 lerpCubic(double4 a, double4 b, double4 c, double4 d, double4 t) {
			double4 ab = lerp(a, b, t);
			double4 bc = lerp(b, c, t);
			double4 cd = lerp(c, d, t);
			double4 abc = lerp(ab, bc, t);
			double4 bcd = lerp(bc, cd, t);
			return lerp(abc, bcd, t);
		}
	}
}
