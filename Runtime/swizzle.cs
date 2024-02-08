using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - bool

		[MethodImpl(AggressiveInlining)]
		public static bool2 swizzle(in bool2 input, in int2 mask)
			=> new bool2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static bool3 swizzle(in bool2 input, in int3 mask)
			=> new bool3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static bool4 swizzle(in bool2 input, in int4 mask)
			=> new bool4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static bool2 swizzle(in bool3 input, in int2 mask)
			=> new bool2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static bool3 swizzle(in bool3 input, in int3 mask)
			=> new bool3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static bool4 swizzle(in bool3 input, in int4 mask)
			=> new bool4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static bool2 swizzle(in bool4 input, in int2 mask)
			=> new bool2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static bool3 swizzle(in bool4 input, in int3 mask)
			=> new bool3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static bool4 swizzle(in bool4 input, in int4 mask)
			=> new bool4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		// MARK: - float

		[MethodImpl(AggressiveInlining)]
		public static float2 swizzle(in float2 input, in int2 mask)
			=> new float2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static float3 swizzle(in float2 input, in int3 mask)
			=> new float3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static float4 swizzle(in float2 input, in int4 mask)
			=> new float4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static float2 swizzle(in float3 input, in int2 mask)
			=> new float2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static float3 swizzle(in float3 input, in int3 mask)
			=> new float3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static float4 swizzle(in float3 input, in int4 mask)
			=> new float4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static float2 swizzle(in float4 input, in int2 mask)
			=> new float2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static float3 swizzle(in float4 input, in int3 mask)
			=> new float3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static float4 swizzle(in float4 input, in int4 mask)
			=> new float4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		// MARK: - double

		[MethodImpl(AggressiveInlining)]
		public static double2 swizzle(in double2 input, in int2 mask)
			=> new double2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static double3 swizzle(in double2 input, in int3 mask)
			=> new double3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static double4 swizzle(in double2 input, in int4 mask)
			=> new double4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static double2 swizzle(in double3 input, in int2 mask)
			=> new double2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static double3 swizzle(in double3 input, in int3 mask)
			=> new double3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static double4 swizzle(in double3 input, in int4 mask)
			=> new double4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static double2 swizzle(in double4 input, in int2 mask)
			=> new double2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static double3 swizzle(in double4 input, in int3 mask)
			=> new double3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static double4 swizzle(in double4 input, in int4 mask)
			=> new double4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		// MARK: - int

		[MethodImpl(AggressiveInlining)]
		public static int2 swizzle(in int2 input, in int2 mask)
			=> new int2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static int3 swizzle(in int2 input, in int3 mask)
			=> new int3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static int4 swizzle(in int2 input, in int4 mask)
			=> new int4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static int2 swizzle(in int3 input, in int2 mask)
			=> new int2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static int3 swizzle(in int3 input, in int3 mask)
			=> new int3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static int4 swizzle(in int3 input, in int4 mask)
			=> new int4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static int2 swizzle(in int4 input, in int2 mask)
			=> new int2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static int3 swizzle(in int4 input, in int3 mask)
			=> new int3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static int4 swizzle(in int4 input, in int4 mask)
			=> new int4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		// MARK: - uint

		[MethodImpl(AggressiveInlining)]
		public static uint2 swizzle(in uint2 input, in int2 mask)
			=> new uint2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static uint3 swizzle(in uint2 input, in int3 mask)
			=> new uint3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static uint4 swizzle(in uint2 input, in int4 mask)
			=> new uint4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static uint2 swizzle(in uint3 input, in int2 mask)
			=> new uint2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static uint3 swizzle(in uint3 input, in int3 mask)
			=> new uint3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static uint4 swizzle(in uint3 input, in int4 mask)
			=> new uint4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);

		[MethodImpl(AggressiveInlining)]
		public static uint2 swizzle(in uint4 input, in int2 mask)
			=> new uint2(input[mask.x], input[mask.y]);

		[MethodImpl(AggressiveInlining)]
		public static uint3 swizzle(in uint4 input, in int3 mask)
			=> new uint3(input[mask.x], input[mask.y], input[mask.z]);

		[MethodImpl(AggressiveInlining)]
		public static uint4 swizzle(in uint4 input, in int4 mask)
			=> new uint4(input[mask.x], input[mask.y], input[mask.z], input[mask.w]);
	}
}
