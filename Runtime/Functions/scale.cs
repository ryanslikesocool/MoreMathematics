using System;
using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		// MARK: - Float

		[MethodImpl(AggressiveInlining)]
		public static float scaleToFit(
			in float2 initialSize,
			in float2 targetSize
		)
			=> cmin(targetSize / initialSize);

		[MethodImpl(AggressiveInlining)]
		public static float scaleToFill(
			in float2 initialSize,
			in float2 targetSize
		)
			=> cmax(targetSize / initialSize);

		[MethodImpl(AggressiveInlining)]
		public static float2 scale(
			in float2 initialSize,
			in float2 targetSize,
			ScaleMode mode
		) => mode switch {
			ScaleMode.Fit => scaleToFit(initialSize, targetSize),
			ScaleMode.Fill => scaleToFill(initialSize, targetSize),
			ScaleMode.Stretch => targetSize / initialSize,
			_ => throw new ArgumentOutOfRangeException()
		};

		// MARK: - Double

		[MethodImpl(AggressiveInlining)]
		public static double scaleToFit(
			in double2 initialSize,
			in double2 targetSize
		)
			=> cmin(targetSize / initialSize);

		[MethodImpl(AggressiveInlining)]
		public static double scaleToFill(
			in double2 initialSize,
			in double2 targetSize
		)
			=> cmax(targetSize / initialSize);

		[MethodImpl(AggressiveInlining)]
		public static double2 scale(
			in double2 initialSize,
			in double2 targetSize,
			ScaleMode mode
		) => mode switch {
			ScaleMode.Fit => scaleToFit(initialSize, targetSize),
			ScaleMode.Fill => scaleToFill(initialSize, targetSize),
			ScaleMode.Stretch => targetSize / initialSize,
			_ => throw new ArgumentOutOfRangeException()
		};
	}
}