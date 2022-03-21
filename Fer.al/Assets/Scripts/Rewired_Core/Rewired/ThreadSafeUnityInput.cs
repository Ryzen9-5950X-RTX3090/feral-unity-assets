using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal static class ThreadSafeUnityInput
	{
		[CustomClassObfuscation]
		[CustomObfuscation]
		public sealed class Keyboard
		{
			private const int dkbQwWEGdYvWqHgwDVFfqiIBuCI = 132;

			public static readonly int keyValueIndex_Escape;

			public static readonly int keyValueIndex_Menu;

			public static readonly int keyValueIndex_F2;

			public static readonly int keyValueIndex_UpArrow;

			public static readonly int keyValueIndex_RightArrow;

			public static readonly int keyValueIndex_DownArrow;

			public static readonly int keyValueIndex_LeftArrow;

			private static readonly int[] AkmBdmXEMLHZyleJSPXZopefEqx;

			private readonly int VSueFCIHzEOqbAAHWqyxhoUpmmSQ;

			private readonly int[] PHZblNhqmDpIZVZMfCuPPXOkgZa;

			private readonly bool[] BtcuDhDnnSEohOGNhSbOXqnStyP;

			private bool RYgMGyqWnNNUOzFUBDIFjvchsBxb;

			private int NTRlznJuCWyalPjsOAcueZOjbbH;

			private readonly bool RJwxragBQeSTQlSaTeqTjfgyWwH;

			public bool enabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool monitoring
			{
				get
				{
					return default(bool);
				}
			}

			public int keyCount
			{
				get
				{
					return default(int);
				}
			}

			static Keyboard()
			{
			}

			public void Initialize()
			{
			}

			public void PostInitialize()
			{
			}

			public void Update()
			{
			}

			public void Monitor(bool state)
			{
			}

			public bool GetKey(KeyCode keyCode)
			{
				return default(bool);
			}

			public void GetKeyValues(bool[] values)
			{
			}

			public void Clear()
			{
			}

			private void pwUnWPfbiGLoijyBXbHmkHOMWJp()
			{
			}

			private void UoMHNaNPthiGlAUrLPIFatCuFSe()
			{
			}

			private void jQAZxqkbnfpgPDirpgJRdSfwkMUj()
			{
			}

			private void VOjUhZVjXhkzyponQzpGGexPwtY()
			{
			}

			private void EQirVzcBFzDMfwJrOzCZJTVFPQq()
			{
			}

			private void kdIyphmIlDvIhUeVLNpAxkpnpCL()
			{
			}
		}

		[CustomObfuscation]
		[CustomClassObfuscation]
		public sealed class Mouse
		{
			private const int yPnzCDCUouValTYijrIjZkOzBoi = 7;

			private const int mcagbMPDbZbuDLVSXAdSGosiwJk = 3;

			private readonly bool[] fjFgJnkphrVLUzcZIWNBokLGbBNJ;

			private readonly float[] GtbxbNliAGztmrCOiIgKeWgIuiM;

			private int NTRlznJuCWyalPjsOAcueZOjbbH;

			private Vector3 FgZjBWgjiNfbEPIznkEcpHOjNnFq;

			private bool IsfJgSAMOpcemHbMURwDTpiUaIT;

			public bool monitoring
			{
				get
				{
					return default(bool);
				}
			}

			public Vector3 mousePosition
			{
				get
				{
					return default(Vector3);
				}
			}

			public bool mousePresent
			{
				get
				{
					return default(bool);
				}
			}

			public void PostInitialize()
			{
			}

			public void Update()
			{
			}

			public void Monitor(bool state)
			{
			}

			public bool GetButton(int index)
			{
				return default(bool);
			}

			public float GetAxisRaw(int index)
			{
				return default(float);
			}

			public void GetButtonValues(bool[] buttons)
			{
			}

			public void GetAxisRawValues(float[] axes)
			{
			}

			private void pwUnWPfbiGLoijyBXbHmkHOMWJp()
			{
			}

			private void UoMHNaNPthiGlAUrLPIFatCuFSe()
			{
			}

			private void jQAZxqkbnfpgPDirpgJRdSfwkMUj()
			{
			}

			private void VOjUhZVjXhkzyponQzpGGexPwtY()
			{
			}

			private void CVEbVTgQOePpPTOLOcYeelaTkqD()
			{
			}

			private void kdIyphmIlDvIhUeVLNpAxkpnpCL()
			{
			}
		}

		private static Mouse KUXWtLbLKAAvBupLaWwXlFqZRDl;

		private static Keyboard dnBiMHFXdLFwnSykRGBRBCnxcnuh;

		public static Mouse mouse
		{
			get
			{
				return null;
			}
		}

		public static Keyboard keyboard
		{
			get
			{
				return null;
			}
		}

		public static void Initialize()
		{
		}

		public static void PostInitialize()
		{
		}

		public static void PostInitialize2()
		{
		}

		public static void Deinitialize()
		{
		}

		public static void Update()
		{
		}
	}
}
