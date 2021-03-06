using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Animation
	 *  @{
	 */

	/// <summary>Contains a set of animation curves used for moving and rotating the root bone.</summary>
	[ShowInInspector]
	public partial class RootMotion : ScriptObject
	{
		private RootMotion(bool __dummy0) { }
		protected RootMotion() { }

		/// <summary>Animation curve representing the movement of the root bone.</summary>
		[ShowInInspector]
		public Vector3Curve Position
		{
			get { return Internal_getPositionCurves(mCachedPtr); }
		}

		/// <summary>Animation curve representing the rotation of the root bone.</summary>
		[ShowInInspector]
		public QuaternionCurve Rotation
		{
			get { return Internal_getRotationCurves(mCachedPtr); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3Curve Internal_getPositionCurves(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern QuaternionCurve Internal_getRotationCurves(IntPtr thisPtr);
	}

	/** @} */
}
