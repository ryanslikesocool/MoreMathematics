using System.Runtime.CompilerServices;
using static System.Runtime.CompilerServices.MethodImplOptions;

namespace Unity.Mathematics {
	public static partial class math {
		/// <summary>
		/// Toggles the given boolean variable’s value.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static bool toggle(this ref bool value) {
			value = !value;
			return value;
		}

		/// <summary>
		/// Toggles each lane of the given boolean vector's value.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static bool2 toggle(this ref bool2 value) {
			value = !value;
			return value;
		}

		/// <summary>
		/// Toggles each lane of the given boolean vector's value.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static bool3 toggle(this ref bool3 value) {
			value = !value;
			return value;
		}

		/// <summary>
		/// Toggles each lane of the given boolean vector's value.
		/// </summary>
		[MethodImpl(AggressiveInlining)]
		public static bool4 toggle(this ref bool4 value) {
			value = !value;
			return value;
		}
	}
}