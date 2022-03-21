using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Utils;

namespace Rewired
{
	public sealed class InputMapper
	{
		public class Context
		{
			private int cjzdzLwOcjfmOCBkTzQRGkafOqG;

			private ControllerMap RNrniZeIkGmMkeqZsCLNgsdrTfDu;

			private ActionElementMap qBdQEHneVxyZRHnVzEDsbnVpgmaK;

			private AxisRange SxOrufySjIQLzwPpmoMtAANjBBz;

			private bool wKnBnddjnLGpvWTmfpNbnnIJgPbb;

			public int actionId
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public string actionName
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ControllerMap controllerMap
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ActionElementMap actionElementMapToReplace
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public AxisRange actionRange
			{
				get
				{
					return default(AxisRange);
				}
				set
				{
				}
			}

			public Context()
			{
			}

			private Context(Context source)
			{
			}

			public Context Clone()
			{
				return null;
			}

			internal void jYXfovrYDfhplaJjSKFtvcyiTsg()
			{
			}

			private bool gFugBsBBwnwfRrzPDrRopxyxMahP()
			{
				return default(bool);
			}

			public static void Copy(Context source, Context destination)
			{
			}
		}

		public enum ConflictResponse
		{
			Cancel,
			Replace,
			Add,
			Ignore
		}

		public abstract class EventData
		{
			public readonly InputMapper inputMapper;

			internal EventData(InputMapper inputMapper)
			{
			}
		}

		public class InputMappedEventData : EventData
		{
			public readonly ActionElementMap actionElementMap;

			internal InputMappedEventData(InputMapper mapper, ActionElementMap actionElementMap)
			{
			}
		}

		public class CanceledEventData : EventData
		{
			public readonly string message;

			internal CanceledEventData(InputMapper mapper, string message)
			{
			}
		}

		public class ErrorEventData : EventData
		{
			public readonly string message;

			internal ErrorEventData(InputMapper mapper, string message)
			{
			}
		}

		public class TimedOutEventData : EventData
		{
			internal TimedOutEventData(InputMapper mapper)
			{
			}
		}

		public class StartedEventData : EventData
		{
			internal StartedEventData(InputMapper mapper)
			{
			}
		}

		public class StoppedEventData : EventData
		{
			internal StoppedEventData(InputMapper mapper)
			{
			}
		}

		public class ConflictFoundEventData : EventData
		{
			public readonly Action<ConflictResponse> responseCallback;

			public readonly ElementAssignmentInfo assignment;

			public readonly IList<ElementAssignmentConflictInfo> conflicts;

			public readonly bool isProtected;

			internal ConflictFoundEventData(InputMapper mapper, Action<ConflictResponse> responseCallback, ElementAssignmentInfo assignment, IList<ElementAssignmentConflictInfo> conflicts, bool isProtected)
			{
			}
		}

		private enum MlZDdRIGUtZScPcHMvprNBhQCkt
		{
			MmEFZJFHhQmcfXTDlVABkcOvmDn,
			LfFbocAeTPRcdZLjKOHnxAMWEpJ,
			iuOmxwSnbPjkYshIfUaDBvyBuLR,
			XGRLZJxEbyYzsbRmapNzHgvRSFG,
			UorMiexUoWrChVbOGBGhEftqiTOF,
			AlwcgMEgFOTFNGrnSoqhtNYSAqg,
			ZFrqZOtROcJuhlJAujNyNnNLDJtg
		}

		public enum Status
		{
			Idle,
			Listening,
			AwaitingResponse
		}

		private class tFToRgKlKSlWZGnYNcaZgcDXmAB
		{
			private enum QVHCAulbBuKwohfufSTKbINweVi
			{
				nnsHcHBOuBtpDqLdPuYxiGpucPB,
				tRNhuUCDPvFMtZcovsMapbJzmCO
			}

			private enum nuURDKnoeWYysAiGUcCuhZwMnTc
			{
				PoBZZNoYGVGuWkUBxQqhGBhFqWy,
				zJJaNpvrPQFECsQsivwBcHccLmz
			}

			private class AjAhIGttduGHijjBoUQQJwNFSNF
			{
				private Player ynTKxtAzNzOSGMpUVXFSwhkyvv;

				private int cjzdzLwOcjfmOCBkTzQRGkafOqG;

				private Context zIsDmpBbtAbGtEngJIcXXYXltMWp;

				private ControllerType jVRvmdSGLvngKifezJIAQbIZrmi;

				private int tiHDqwuWnAypLNJNoTzBctdWRZt;

				private ControllerPollingInfo zYudegFGYpfRFbJPhkwZmJNayQuC;

				private ModifierKeyFlags WyYzmoHdRbnuKAzTWBtVuJIIols;

				public Player yHWXapLnjMXUYBDESFaAUIdnziK
				{
					get
					{
						return null;
					}
				}

				public int OQcyWgBmnPWCLAcqVAqEsHoBwiC
				{
					get
					{
						return default(int);
					}
				}

				public Context QNycFmvnKcoUfGYDAghVcKMXHuQ
				{
					get
					{
						return null;
					}
				}

				public ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH
				{
					get
					{
						return default(ControllerType);
					}
				}

				public int AkkOxeFFauQvLEuBcHkzXcxVDoLa
				{
					get
					{
						return default(int);
					}
				}

				public ControllerPollingInfo PJEAaAfwsJsBxlCAaiKyfPkkDXV
				{
					get
					{
						return default(ControllerPollingInfo);
					}
				}

				public ModifierKeyFlags RgontomKqhXdwuPoWxcvUvVwbRm
				{
					get
					{
						return default(ModifierKeyFlags);
					}
				}

				public AxisRange AxikYLhruiOSODJDsEJYTOGYrus
				{
					get
					{
						return default(AxisRange);
					}
				}

				public string OEBQtXdKPjceipvIJipFBPbMcniS
				{
					get
					{
						return null;
					}
				}

				public void ItdhavHGXcUkAhyjaCFbIXENJheh(Player P_0, Context P_1)
				{
				}

				public void vMfAexzdpfzhXKkyGdAHmJVnQEr()
				{
				}

				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(ControllerPollingInfo P_0)
				{
					return default(ElementAssignment);
				}

				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb(ControllerPollingInfo P_0, ModifierKeyFlags P_1)
				{
					return default(ElementAssignment);
				}

				public ElementAssignment JMPRkrDiidDTjuwUjIXdRGHFjPb()
				{
					return default(ElementAssignment);
				}
			}

			private readonly InputMapper PdhGYsFKOBEfRexHgTcxFTVoRup;

			private readonly Options UkVnIfKaisHxULJaXHVDCMWuCPK;

			private readonly AjAhIGttduGHijjBoUQQJwNFSNF qAWBfCUylfvjpaBoYORwHWHtEur;

			private readonly Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> dRHDBhOgBmQfHvZJblYfKVxrObH;

			private readonly Dictionary<string, SafeDelegate> rcwrnwEzBvUpkFVZeEhnWqpZSss;

			private Status egZseKiVnPHgfhjbzgKjgszxdwnb;

			private nuURDKnoeWYysAiGUcCuhZwMnTc TBbkMvJcaPDFWtbduTqYMGmhYMo;

			private float hiNQNqdOtHYBhVZibpwRUsJJyGU;

			private bool JuOFjzRkYuDstIuGjgxZUqWRewOV;

			private List<Player> NdqRcsJwjlNcXDhcYrMhgdVRrvt;

			private readonly List<ControllerPollingInfo> mAvILkJZgIwXlLPpNPjnIExbUpCH;

			private ElementAssignment DEqzNNYBhMsQUneRKbXtqEOOaaO;

			public Status PCFpBFutvFenwXMFHSFlIQYKAfm
			{
				get
				{
					return default(Status);
				}
			}

			public float OjnboEIXbCOMoOgaEBCLSbywdqms
			{
				get
				{
					return default(float);
				}
			}

			public Context DyxnimTkCxFztDAUeUGvaOsoNvGM
			{
				get
				{
					return null;
				}
			}

			private bool UKzpgnOXNRhJuQfRRZjPKwlWGyz
			{
				get
				{
					return default(bool);
				}
			}

			public tFToRgKlKSlWZGnYNcaZgcDXmAB(InputMapper parent, Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> events)
			{
			}

			~tFToRgKlKSlWZGnYNcaZgcDXmAB()
			{
			}

			public void JHzUZUsFQTvSmWjmIewXSnYsiSq(Context P_0, Options P_1)
			{
			}

			public void BXLwvwEIiTSSpiqsTXeFeyiNydA(string P_0)
			{
			}

			private void MrPMknIMZzaXDjcXZFUzCeTcWDAs(UpdateLoopType P_0)
			{
			}

			private void AGASRXthoscAbPvuERLUlyaRAws()
			{
			}

			private void UoMHNaNPthiGlAUrLPIFatCuFSe()
			{
			}

			private QVHCAulbBuKwohfufSTKbINweVi bCkYPKTEYQDjkrBzXZPrDsSzfAc(out ElementAssignment P_0)
			{
				return default(QVHCAulbBuKwohfufSTKbINweVi);
			}

			private bool lngezBDAJNlfbLzscckekTIvgzL(out IEnumerable<ControllerPollingInfo> P_0, out ModifierKeyFlags P_1)
			{
				return default(bool);
			}

			private IEnumerable<ControllerPollingInfo> mTXQvVovaHOXSeEVaPnffwDSYHR(out ModifierKeyFlags P_0)
			{
				return null;
			}

			private ControllerPollingInfo MlzjzvauDzOhkqLXNkyNGgHNkHt(Options P_0, out ModifierKeyFlags P_1)
			{
				return default(ControllerPollingInfo);
			}

			private static ControllerPollingInfo MlzjzvauDzOhkqLXNkyNGgHNkHt(Options P_0, out bool P_1, out ModifierKeyFlags P_2, out string P_3)
			{
				return default(ControllerPollingInfo);
			}

			private static bool TGkGTNQktnilNAwOqlKPzrkLKZb(ControllerPollingInfo P_0, Options P_1)
			{
				return default(bool);
			}

			private static bool GUraTFbTKHxLGQDLARPJPNBUMJCF(AjAhIGttduGHijjBoUQQJwNFSNF P_0, ControllerPollingInfo P_1, Options P_2)
			{
				return default(bool);
			}

			private void qdAikkZAMUWXkqTDfjmZdqdoZFK()
			{
			}

			private QVHCAulbBuKwohfufSTKbINweVi yJOokDABwVxGMjhSkEEdQJFCCeT(ElementAssignment P_0)
			{
				return default(QVHCAulbBuKwohfufSTKbINweVi);
			}

			private static bool CuUMVeEBqxETUGMohBNXVaBfkfnp(AjAhIGttduGHijjBoUQQJwNFSNF P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return default(bool);
			}

			private static bool oNQVtQiiPOrqxGHJMEOqKQuZjiPo(AjAhIGttduGHijjBoUQQJwNFSNF P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return default(bool);
			}

			private static IList<ElementAssignmentConflictInfo> ZYEfQbSEthQoQFglHyoEjZrtuqp(AjAhIGttduGHijjBoUQQJwNFSNF P_0, ElementAssignment P_1, List<Player> P_2)
			{
				return null;
			}

			private static bool cmTmXsPdDggToIjzpjYTbYHBjAMX(AjAhIGttduGHijjBoUQQJwNFSNF P_0, ElementAssignment P_1, out ElementAssignmentConflictCheck P_2)
			{
				return default(bool);
			}

			private static void WjCYeZhDvSvxKcQpcKOBJaKPtus(AjAhIGttduGHijjBoUQQJwNFSNF P_0, ElementAssignment P_1, List<Player> P_2)
			{
			}

			private void YBGnhLIAfSlHZLSMzgJcpbRSkFl()
			{
			}

			private void inCcrRExDshyOoYwBZiFDCTZGBy()
			{
			}

			private bool JuSaAYLuCkHqOlFCoIySHSjofunY(MlZDdRIGUtZScPcHMvprNBhQCkt P_0)
			{
				return default(bool);
			}

			private void eKfLtIQtyipducYocpkuFFglmiz<T>(MlZDdRIGUtZScPcHMvprNBhQCkt P_0, T P_1)
			{
			}

			private void VRkInhuBwWwrNrPgyGHyDVpyDuxR()
			{
			}

			private void RBtjWbgEfvMJJdmuOZnqKPNoFNS()
			{
			}

			private void YVGcgXCZEeEEezSjyHHOlijcbjR(ActionElementMap P_0)
			{
			}

			private void DBCCivHLhpUwCdvqiZeXKhMdLWh(string P_0)
			{
			}

			private QVHCAulbBuKwohfufSTKbINweVi mJEMSDEOqJelIdAckQxbWWyuDyfN(ElementAssignment P_0)
			{
				return default(QVHCAulbBuKwohfufSTKbINweVi);
			}

			private QVHCAulbBuKwohfufSTKbINweVi OIWKurDixFFcRGSNGtidEQekOdKs(ConflictResponse P_0, ElementAssignment P_1)
			{
				return default(QVHCAulbBuKwohfufSTKbINweVi);
			}

			private QVHCAulbBuKwohfufSTKbINweVi OIWKurDixFFcRGSNGtidEQekOdKs(ConflictResponse P_0, ElementAssignment P_1, bool P_2)
			{
				return default(QVHCAulbBuKwohfufSTKbINweVi);
			}

			private void yudbcuSIhPYLFjYWcLVKoiphvTM()
			{
			}

			private void DigEICdNKFcLQcMMQnNuGyVyaubk(string P_0)
			{
			}

			private void ODzuiatjXuCuviZpfFNOOIZGprvE()
			{
			}

			private void RUDfCgekHcgAputZrzNabpnpHzxD()
			{
			}

			private void BqBsVfEMnomqLAGoeIRtkzKfwVn(ElementAssignment P_0)
			{
			}

			private void oKkDKXTQvvZYpRkUeWWEcdWNIOs(ActionElementMap P_0)
			{
			}

			private void apVnrkjNwYgcGKFCtgHQGtkSMDle()
			{
			}

			private void HCJvJuZHNEBfhsXRocWIPFjHzLV(string P_0)
			{
			}

			private void dYxWzvsVguaVfgDIpqCWNUBZcID(string P_0)
			{
			}

			private void rTirlZRigFaTrfkbyjBkmJsCdGAE(ElementAssignmentInfo P_0, IList<ElementAssignmentConflictInfo> P_1, bool P_2)
			{
			}

			private void RXBxalwWJsFQzWPVwCHxQUnmHdT()
			{
			}

			private void QYLfScPgOIyybiJNApxsvnKGOKQ()
			{
			}

			public void vhjXagDioNFESXUfrXwAinEVHrX(ConflictResponse P_0)
			{
			}
		}

		public class Options
		{
			internal const string YNhaUZiTfaIgKxuhFAoHGXsBpJEK = "isElementAllowed";

			private bool dBasdtrcRywCygDiKJdCIpJBheoE;

			private bool pktXvsiXxgjqdTXHyEpNoWoVHwJ;

			private bool vggTxHfUufioTxNKdkOguryKdls;

			private float KsihvWHnqPQVTsmmnFSDGGFjaXnu;

			private bool xyLNXfKogTABXLuIpSdaRxvzakg;

			private bool JOtFskeeZGJUjwWgQxOTvvrFhSXo;

			private bool TqtsDXuSKFVoErDnCsKLgNfZVWt;

			private bool DNlEOnmIIryoZlfFFamkJIPhlCbE;

			private int[] ZxbwCzpHUJgnmrVTitCQOyGqjBh;

			private ConflictResponse zFhvHzyCBpEiEqfQPUgudcerDAhB;

			private bool ekRBSgGDWDcGmufdTAmsrrVIZYne;

			private bool OaNmsCmqtCWUzqKbZKnkbTxbinS;

			private bool AxpxodXqCsfvjeLtTxlBLBYSAHzv;

			private bool ZzJmBsgtNUYwyOXByZhyTVeVMRF;

			private float ulugqHJvrxAbqcJfRGljEPtdSmnJ;

			private readonly Dictionary<string, SafeDelegate> rcwrnwEzBvUpkFVZeEhnWqpZSss;

			[CompilerGenerated]
			private static Action<Exception> USlXdSBXnlfvXVVTMURFbvmMbBc;

			public bool allowAxes
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool allowButtons
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool allowButtonsOnFullAxisAssignment
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public float timeout
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public bool checkForConflicts
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool checkForConflictsWithAllPlayers
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool checkForConflictsWithSelf
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool checkForConflictsWithSystemPlayer
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int[] checkForConflictsWithPlayerIds
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public ConflictResponse defaultActionWhenConflictFound
			{
				get
				{
					return default(ConflictResponse);
				}
				set
				{
				}
			}

			public bool ignoreMouseXAxis
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool ignoreMouseYAxis
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool allowKeyboardKeysWithModifiers
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool allowKeyboardModifierKeyAsPrimary
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public float holdDurationToMapKeyboardModifierKeyAsPrimary
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public Predicate<ControllerPollingInfo> isElementAllowedCallback
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			internal T lRkegFMlGRwRJBayxACmeEBUdsJ<T>(string P_0) where T : SafeDelegate
			{
				return null;
			}

			public Options()
			{
			}

			private Options(Options source)
			{
			}

			public Options Clone()
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}

			internal void vMfAexzdpfzhXKkyGdAHmJVnQEr()
			{
			}

			public static void Copy(Options source, Options destination)
			{
			}

			[CompilerGenerated]
			private static void HIWENDmrdRdtEplYoZrJumOqLPa(Exception P_0)
			{
			}
		}

		private static InputMapper DqYmGHECTlrDVQmfbrCSLOJGmsK;

		private static int opOBHHseJkiuPTdqFxSPSFfBWwf;

		private readonly int FeoFxBhvrqWrLlBecgmLnkpVHMiD;

		private readonly bool LjPoycpcPSUbvwRTdkQajYjpFii;

		private readonly tFToRgKlKSlWZGnYNcaZgcDXmAB FUdqWTUGhUBvKdECFktkLieEvKa;

		private Options UkVnIfKaisHxULJaXHVDCMWuCPK;

		private readonly Dictionary<MlZDdRIGUtZScPcHMvprNBhQCkt, SafeDelegate> dRHDBhOgBmQfHvZJblYfKVxrObH;

		[CompilerGenerated]
		private static Action<Exception> oYBpUPtIotQpZlmyBzHgqIPdpVq;

		[CompilerGenerated]
		private static Action<Exception> GmIYhGBcpMMCirEvOkwMHZBRaFg;

		[CompilerGenerated]
		private static Action<Exception> nYlBBJwwcVkZtIQVFuIuqjeIcsK;

		[CompilerGenerated]
		private static Action<Exception> CWjBcSiUYzmlMwepxVNqomArHSvB;

		[CompilerGenerated]
		private static Action<Exception> gTLlTiQHUPsbMkAVANpjXDMPLlI;

		[CompilerGenerated]
		private static Action<Exception> TjGEBsHFMVCHUCaUrhTtAyNgOuoQ;

		[CompilerGenerated]
		private static Action<Exception> MTpUSWdtwFfJQssYigamHIUInVb;

		public static InputMapper Default
		{
			get
			{
				return null;
			}
		}

		public Options options
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Context mappingContext
		{
			get
			{
				return null;
			}
		}

		public Status status
		{
			get
			{
				return default(Status);
			}
		}

		public float timeRemaining
		{
			get
			{
				return default(float);
			}
		}

		internal int id
		{
			get
			{
				return default(int);
			}
		}

		public event Action<InputMappedEventData> InputMappedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ErrorEventData> ErrorEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<CanceledEventData> CanceledEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<TimedOutEventData> TimedOutEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<StartedEventData> StartedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<StoppedEventData> StoppedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ConflictFoundEventData> ConflictFoundEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private static int whuCWRHtUuaRrnNGmdillFWWQzKa()
		{
			return default(int);
		}

		public InputMapper()
		{
		}

		private InputMapper(bool isDefault)
		{
		}

		public void RemoveEventListeners(object listenerOrParent)
		{
		}

		public void RemoveAllEventListeners()
		{
		}

		internal void xVDRaZExjvXwxInuklypmYiqskE(object P_0)
		{
		}

		internal void RNkBwBdsVZpQPGrdBoekxOOmLqBx()
		{
		}

		public bool Start(Context mappingContext)
		{
			return default(bool);
		}

		public void Stop()
		{
		}

		public void Clear()
		{
		}

		private bool JHzUZUsFQTvSmWjmIewXSnYsiSq(Context P_0, Options P_1)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private static void nKBfZOoSRNcWGVmXsGDbjHqfeFdg(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void QCnBhbrcMfEzZgtusefqogRXgSm(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void duLhsEnrjkGDDwuCgfSCCWjnKgSn(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void WAUAEupZrGtxBDFwxBMrGLgbpheC(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void qFokFxPuLlKEeQtuzioYbpTyKhQ(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void uSEzyJAsfYEgkEIIZypMIYItiji(Exception P_0)
		{
		}

		[CompilerGenerated]
		private static void sHLnowayslNERUCHckPNeNeJjCXd(Exception P_0)
		{
		}
	}
}
