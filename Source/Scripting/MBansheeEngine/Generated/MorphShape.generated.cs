using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BansheeEngine
{
	/** @addtogroup Animation
	 *  @{
	 */

	/// <summary>
	/// Name and weight of a single shape in a morph target animation. Each shape internally represents a set of vertices that 
	/// describe the morph shape.
	/// </summary>
	[ShowInInspector]
	public partial class MorphShape : ScriptObject
	{
		private MorphShape(bool __dummy0) { }
		protected MorphShape() { }

		/// <summary>Returns the name of the shape.</summary>
		[ShowInInspector]
		public string Name
		{
			get { return Internal_getName(mCachedPtr); }
		}

		/// <summary>Returns the weight of the shape, determining how are different shapes within a channel blended.</summary>
		[ShowInInspector]
		public float Weight
		{
			get { return Internal_getWeight(mCachedPtr); }
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string Internal_getName(IntPtr thisPtr);
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_getWeight(IntPtr thisPtr);
	}

	/** @} */
}
