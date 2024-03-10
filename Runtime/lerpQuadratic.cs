using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - float

		[MethodImpl(AggressiveInlining)]
		public static float lerpQuadratic(float a, float b, float c, float t) {
			float ab = lerp(a, b, t);
			float bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float2 lerpQuadratic(float2 a, float2 b, float2 c, float t) {
			float2 ab = lerp(a, b, t);
			float2 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float2 lerpQuadratic(float2 a, float2 b, float2 c, float2 t) {
			float2 ab = lerp(a, b, t);
			float2 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float3 lerpQuadratic(float3 a, float3 b, float3 c, float t) {
			float3 ab = lerp(a, b, t);
			float3 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float3 lerpQuadratic(float3 a, float3 b, float3 c, float3 t) {
			float3 ab = lerp(a, b, t);
			float3 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float4 lerpQuadratic(float4 a, float4 b, float4 c, float t) {
			float4 ab = lerp(a, b, t);
			float4 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static float4 lerpQuadratic(float4 a, float4 b, float4 c, float4 t) {
			float4 ab = lerp(a, b, t);
			float4 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		// MARK: - double

		[MethodImpl(AggressiveInlining)]
		public static double lerpQuadratic(double a, double b, double c, double t) {
			double ab = lerp(a, b, t);
			double bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double2 lerpQuadratic(double2 a, double2 b, double2 c, double t) {
			double2 ab = lerp(a, b, t);
			double2 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double2 lerpQuadratic(double2 a, double2 b, double2 c, double2 t) {
			double2 ab = lerp(a, b, t);
			double2 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double3 lerpQuadratic(double3 a, double3 b, double3 c, double t) {
			double3 ab = lerp(a, b, t);
			double3 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double3 lerpQuadratic(double3 a, double3 b, double3 c, double3 t) {
			double3 ab = lerp(a, b, t);
			double3 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double4 lerpQuadratic(double4 a, double4 b, double4 c, double t) {
			double4 ab = lerp(a, b, t);
			double4 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}

		[MethodImpl(AggressiveInlining)]
		public static double4 lerpQuadratic(double4 a, double4 b, double4 c, double4 t) {
			double4 ab = lerp(a, b, t);
			double4 bc = lerp(b, c, t);
			return lerp(ab, bc, t);
		}
	}
}