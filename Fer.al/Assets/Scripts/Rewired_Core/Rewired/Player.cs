using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils;
using Rewired.Utils.Classes;
using UnityEngine;

namespace Rewired
{
	public sealed class Player
	{
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class ControllerHelper
		{
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class ConflictCheckingHelper : CodeHelper
			{
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK;

				private readonly ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh;

				private readonly int vSShldFHkaZKEuThltrSgFmPfc;

				internal ConflictCheckingHelper(Player player, ControllerHelper parent)
				{
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return default(bool);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(bool);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return null;
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps)
				{
					return default(int);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return default(int);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return default(int);
				}

				private bool DxUxCsinfAWFYpubKnmfntdUduK(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(bool);
				}

				private bool DxUxCsinfAWFYpubKnmfntdUduK(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					return default(bool);
				}

				private bool DxUxCsinfAWFYpubKnmfntdUduK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(bool);
				}

				private bool wXcueicCklSRvlxEnukgGZLyfpI(KeyboardMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(bool);
				}

				private bool wXcueicCklSRvlxEnukgGZLyfpI(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(bool);
				}

				private bool wXcueicCklSRvlxEnukgGZLyfpI(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(bool);
				}

				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(MouseMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(bool);
				}

				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(bool);
				}

				private bool aEPFDkgvlTaxDMvMdXmXlPcSWfzg(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(bool);
				}

				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(bool);
				}

				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					return default(bool);
				}

				private bool RTzJvqyIWdYfpLMnYXwBLikApnt(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(bool);
				}

				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> MRgnTPvPKuFIQVnkoOgsMkvypzz(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(KeyboardMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> tUDCLjaXyYDhvMbyzbdykNyovBi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(MouseMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> GBpaKcaXjHwRPKNwzvYTCbohHIuH(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> nYfulgjqWJpqujfJpXbCGeUTYHC(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return null;
				}

				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(int);
				}

				private int zUesUqgzAjTqcPAFWJspqFdOSAK(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					return default(int);
				}

				private int zUesUqgzAjTqcPAFWJspqFdOSAK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(int);
				}

				private int AAzbhFdYOVScAsWiElenoaQTPBi(KeyboardMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(int);
				}

				private int AAzbhFdYOVScAsWiElenoaQTPBi(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(int);
				}

				private int AAzbhFdYOVScAsWiElenoaQTPBi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(int);
				}

				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(MouseMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(int);
				}

				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(int);
				}

				private int ulBXXqKdVzAGMiziSQvOSsbqBDM(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(int);
				}

				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return default(int);
				}

				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					return default(int);
				}

				private int ogsyqhxhlaCnaGAJLkpKnbhucbi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					return default(int);
				}

				private int NelggbthumjxGTexgIAOZhYwWoK(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false, [Optional] List<ActionElementMap> P_4)
				{
					return default(int);
				}

				private int NelggbthumjxGTexgIAOZhYwWoK(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, [Optional] List<ActionElementMap> P_5)
				{
					return default(int);
				}

				private int NelggbthumjxGTexgIAOZhYwWoK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, [Optional] List<ActionElementMap> P_3)
				{
					return default(int);
				}

				private int SkffTQYiVFTbnzlfYOUqAgXirDr(KeyboardMap P_0, bool P_1 = false, bool P_2 = false, [Optional] List<ActionElementMap> P_3)
				{
					return default(int);
				}

				private int SkffTQYiVFTbnzlfYOUqAgXirDr(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false, [Optional] List<ActionElementMap> P_4)
				{
					return default(int);
				}

				private int SkffTQYiVFTbnzlfYOUqAgXirDr(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, [Optional] List<ActionElementMap> P_3)
				{
					return default(int);
				}

				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(MouseMap P_0, bool P_1 = false, bool P_2 = false, [Optional] List<ActionElementMap> P_3)
				{
					return default(int);
				}

				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false, [Optional] List<ActionElementMap> P_4)
				{
					return default(int);
				}

				private int ptrQHwldfEFdoVXaZbwIaOGNCLAh(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, [Optional] List<ActionElementMap> P_3)
				{
					return default(int);
				}

				private int qzXyzfORVDqhzRVipLqpqtoChSh(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false, [Optional] List<ActionElementMap> P_4)
				{
					return default(int);
				}

				private int qzXyzfORVDqhzRVipLqpqtoChSh(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, [Optional] List<ActionElementMap> P_5)
				{
					return default(int);
				}

				private int qzXyzfORVDqhzRVipLqpqtoChSh(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, [Optional] List<ActionElementMap> P_3)
				{
					return default(int);
				}

				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_5) where T : ControllerMap
				{
					return default(bool);
				}

				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_6) where T : ControllerMap
				{
					return default(bool);
				}

				private bool rCWLbLscSTtJFXWAMHzqUevhLDg<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_3) where T : ControllerMap
				{
					return default(bool);
				}

				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_5) where T : ControllerMap
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_6) where T : ControllerMap
				{
					return null;
				}

				private IEnumerable<ElementAssignmentConflictInfo> XcEtdDcnreaNiJbFAQuTHdzlGEEj<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_3) where T : ControllerMap
				{
					return null;
				}

				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_5) where T : ControllerMap
				{
					return default(int);
				}

				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_6) where T : ControllerMap
				{
					return default(int);
				}

				private int WjCYeZhDvSvxKcQpcKOBJaKPtus<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_3) where T : ControllerMap
				{
					return default(int);
				}

				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_5, [Optional] List<ActionElementMap> P_6) where T : ControllerMap
				{
					return default(int);
				}

				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_6, [Optional] List<ActionElementMap> P_7) where T : ControllerMap
				{
					return default(int);
				}

				private int QuwzUKTytrTXmrjDzPdLAVycjts<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<T> P_3, [Optional] List<ActionElementMap> P_4) where T : ControllerMap
				{
					return default(int);
				}

				private bool SABKxadsuyVakSFClQoKRWbOjqP(InputMapCategory P_0, ControllerMap P_1)
				{
					return default(bool);
				}
			}

			[DefaultMember("Item")]
			internal interface uwILKJrQnvyPKXqkviwAHMwxglt
			{
				zPwANwSjcNWfOppJVpCEtGyMPGw MWiOWGzUiqOkOMPKltvfuPDXdxF { get; }

				ControllerType CGckBVNLLRbsxHptZVYgQLPSxKH { get; }

				int SHujHYUxHggDGFiBfPBtOLtZhMW { get; }

				bool Contains(Controller P_0);

				bool Contains(int P_0);

				void RemoveController(int P_0);

				void RemoveController(Controller P_0);

				void RemoveAt(int P_0);

				Controller GetController(int P_0);

				Controller GetControllerWithTag(string P_0);

				int IndexOf(Controller P_0);

				int IndexOf(int P_0);

				int IndexOfTag(string P_0);

				void Clear();

				zPwANwSjcNWfOppJVpCEtGyMPGw GetEntry(int P_0);

				zPwANwSjcNWfOppJVpCEtGyMPGw GetEntry(Controller P_0);

				void AddEntry(zPwANwSjcNWfOppJVpCEtGyMPGw P_0);
			}

			internal interface zPwANwSjcNWfOppJVpCEtGyMPGw
			{
				sNfUcPzqbmfpkWQZGXbzVNvzIYo rQzQjzZPEBGirpUCdHIDZcYWbNF { get; }

				Controller jbVnEoSGijlOtsPVojcUnqQxqRw { get; }

				float AGsglnLOcnetMiOqoKNEaqYaDAlI { get; }
			}

			[DefaultMember("Item")]
			internal sealed class yuzjpKSgIlOzFrmYoCjvudWJHqg<TController, TMap> : uwILKJrQnvyPKXqkviwAHMwxglt where TController : Controller where TMap : ControllerMap
			{
				public class KvWmrlRvIDMhfmIzEoUOUFQtsIT : zPwANwSjcNWfOppJVpCEtGyMPGw
				{
					public TController jbVnEoSGijlOtsPVojcUnqQxqRw;

					public global::UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> rQzQjzZPEBGirpUCdHIDZcYWbNF;

					public float AGsglnLOcnetMiOqoKNEaqYaDAlI;

					private Controller PjXMZKkDeRhnnHXpRsFQkNWeaUa
					{
						get
						{
							return null;
						}
					}

					private sNfUcPzqbmfpkWQZGXbzVNvzIYo owfBVchPcbnDalFpHCDepzYWmxTA
					{
						get
						{
							return null;
						}
					}

					private float SfWzvrEQzNiPKoZdejQTwsqivJF
					{
						get
						{
							return default(float);
						}
					}

					public KvWmrlRvIDMhfmIzEoUOUFQtsIT(TController controller, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> mapSet)
					{
					}

					public void PiIvWOebYJRTGGXjPLJfusqSYgE()
					{
					}
				}

				private List<KvWmrlRvIDMhfmIzEoUOUFQtsIT> BuwIKNnQECuDvuXrWMqVIxlxRgA;

				private List<TController> utSQKhThHRMCyRAztmqTHAWxVeb;

				private ReadOnlyCollection<TController> ZuVolyAKtLblxeZubjdCVedtILQ;

				private readonly ControllerType jVRvmdSGLvngKifezJIAQbIZrmi;

				public int SHujHYUxHggDGFiBfPBtOLtZhMW
				{
					get
					{
						return default(int);
					}
				}

				public IList<TController> hCYHQatsbxOCyEdosYKFoCnNnkt
				{
					get
					{
						return null;
					}
				}

				public KvWmrlRvIDMhfmIzEoUOUFQtsIT MWiOWGzUiqOkOMPKltvfuPDXdxF
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

				private zPwANwSjcNWfOppJVpCEtGyMPGw RwrcWaBdSKNUOdtlhMnMhslnQpuh
				{
					get
					{
						return null;
					}
				}

				public KvWmrlRvIDMhfmIzEoUOUFQtsIT uDGNCWGQfmuhvDHBSxGtBouWbNb(int P_0)
				{
					return null;
				}

				public KvWmrlRvIDMhfmIzEoUOUFQtsIT uDGNCWGQfmuhvDHBSxGtBouWbNb(TController P_0)
				{
					return null;
				}

				public void oaKHEhKiCbesQaMGhlFggnhHCet(KvWmrlRvIDMhfmIzEoUOUFQtsIT P_0)
				{
				}

				public void RemoveController(int P_0)
				{
				}

				public void XwNcwiEaatgODGzkmSbKgFgCVEWa(TController P_0)
				{
				}

				public void RemoveAt(int P_0)
				{
				}

				public TController vHZICLYpyCcWjWVSNhoczOfMnCG(int P_0)
				{
					return null;
				}

				public bool Contains(int P_0)
				{
					return default(bool);
				}

				public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(TController P_0)
				{
					return default(bool);
				}

				public int IndexOf(int P_0)
				{
					return default(int);
				}

				public int ItDzbHMiIYGseDXjmhIUEkIaQew(TController P_0)
				{
					return default(int);
				}

				public int IndexOfTag(string P_0)
				{
					return default(int);
				}

				public void Clear()
				{
				}

				private zPwANwSjcNWfOppJVpCEtGyMPGw Rewired.Player.ControllerHelper.IControllerSet.GetEntry(int P_0)
				{
					return null;
				}

				private zPwANwSjcNWfOppJVpCEtGyMPGw Rewired.Player.ControllerHelper.IControllerSet.GetEntry(Controller P_0)
				{
					return null;
				}

				private void Rewired.Player.ControllerHelper.IControllerSet.AddEntry(zPwANwSjcNWfOppJVpCEtGyMPGw P_0)
				{
				}

				private void Rewired.Player.ControllerHelper.IControllerSet.RemoveController(Controller P_0)
				{
				}

				private Controller Rewired.Player.ControllerHelper.IControllerSet.GetController(int P_0)
				{
					return null;
				}

				private bool Rewired.Player.ControllerHelper.IControllerSet.Contains(Controller P_0)
				{
					return default(bool);
				}

				private int Rewired.Player.ControllerHelper.IControllerSet.IndexOf(Controller P_0)
				{
					return default(int);
				}

				private Controller Rewired.Player.ControllerHelper.IControllerSet.GetControllerWithTag(string P_0)
				{
					return null;
				}
			}

			internal class egXAAqgVCShQeuJnjIKIGPUQzKT
			{
				public readonly int SHujHYUxHggDGFiBfPBtOLtZhMW;

				private ControllerType[] qXozjOicCkZQWMdOnmdtBiFcfuy;

				private uwILKJrQnvyPKXqkviwAHMwxglt[] DOGjWfNqXhJwrYMCygTRCsZHQkS;

				public uwILKJrQnvyPKXqkviwAHMwxglt VILyHUbxRbFBNVlpaPnEuRjNgLM(int P_0)
				{
					return null;
				}

				public ControllerType tGyhsBkxYMxCvfukQbFmUfQxatN(int P_0)
				{
					return default(ControllerType);
				}

				public egXAAqgVCShQeuJnjIKIGPUQzKT(int length)
				{
				}

				public uwILKJrQnvyPKXqkviwAHMwxglt HidcSjbKbECBzYyBnCtcFeYTQWme(ControllerType P_0)
				{
					return null;
				}

				public void olCMPMvbEidtAtcrerbWKjnDXsq(int P_0, ControllerType P_1, uwILKJrQnvyPKXqkviwAHMwxglt P_2)
				{
				}
			}

			private class jAchFPOUJqmmtMllCTHcROXwbLj
			{
				public class KdfyLBQApCbzGOVOOAmpdQFMdzgU
				{
					public int ApclWZWATFcgBgxbNPQkMDQJKvCT;

					public global::UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> rQzQjzZPEBGirpUCdHIDZcYWbNF;

					public float lFDHcXCTqlOntOoxLiXLgvQIJOsj;

					public KdfyLBQApCbzGOVOOAmpdQFMdzgU(int joystickId, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> mapSet, float lastConnectedTime)
					{
					}
				}

				private readonly List<KdfyLBQApCbzGOVOOAmpdQFMdzgU> hnpXymCoCCHPwqlDSIZkffYsKwxu;

				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK;

				public jAchFPOUJqmmtMllCTHcROXwbLj(Player player)
				{
				}

				public void lmldbkvCGcJRSRLClxvEdfwGeFAF(Joystick P_0, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> P_1)
				{
				}

				public void lmldbkvCGcJRSRLClxvEdfwGeFAF(yuzjpKSgIlOzFrmYoCjvudWJHqg<Joystick, JoystickMap>.KvWmrlRvIDMhfmIzEoUOUFQtsIT P_0)
				{
				}

				public void rIBoFCqulfliDqgYQSDqUUlhTyk()
				{
				}

				public KdfyLBQApCbzGOVOOAmpdQFMdzgU SJSWnEKwuoLTQVEoRbtWctEUXhl(int P_0)
				{
					return null;
				}

				public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(int P_0)
				{
					return default(bool);
				}

				public int ItDzbHMiIYGseDXjmhIUEkIaQew(int P_0)
				{
					return default(int);
				}

				public void vMfAexzdpfzhXKkyGdAHmJVnQEr()
				{
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public sealed class MapHelper : CodeHelper
			{
				private readonly VVLouGbEKulMPcFZiTUTqikUjEp uZAindJKwIucctNndiMpyAASdId;

				private Player yHWXapLnjMXUYBDESFaAUIdnziK;

				private ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh;

				private readonly ControllerMapEnabler mEPluSgrvSHStUTqLfvUfSdRIBD;

				private readonly ControllerMapLayoutManager KKSdtRLTEfvlNthGKcGKiNRvdEEA;

				private readonly int vSShldFHkaZKEuThltrSgFmPfc;

				public ControllerMapLayoutManager layoutManager
				{
					get
					{
						return null;
					}
				}

				public ControllerMapEnabler mapEnabler
				{
					get
					{
						return null;
					}
				}

				public IList<InputBehavior> InputBehaviors
				{
					get
					{
						return null;
					}
				}

				internal MapHelper(Player player, ControllerHelper parent, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings)
				{
				}

				public void LoadMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
				}

				public void LoadMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
				}

				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
				}

				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
				}

				public void LoadMap<T>(int controllerId, int categoryId, int layoutId, bool startEnabled) where T : ControllerMap
				{
				}

				public void LoadMap<T>(int controllerId, string categoryName, string layoutName, bool startEnabled) where T : ControllerMap
				{
				}

				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId, bool startEnabled)
				{
				}

				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName, bool startEnabled)
				{
				}

				private void lzRURLodCXjlaMATvFEbJFSRQAus<T>(int P_0, int P_1, int P_2, BoolOption P_3) where T : ControllerMap
				{
				}

				private void lzRURLodCXjlaMATvFEbJFSRQAus<T>(int P_0, string P_1, string P_2, BoolOption P_3) where T : ControllerMap
				{
				}

				private void lzRURLodCXjlaMATvFEbJFSRQAus(ControllerType P_0, int P_1, int P_2, int P_3, BoolOption P_4)
				{
				}

				private void lzRURLodCXjlaMATvFEbJFSRQAus(ControllerType P_0, int P_1, string P_2, string P_3, BoolOption P_4)
				{
				}

				public IEnumerable<ControllerMap> GetAllMaps()
				{
					return null;
				}

				public int GetAllMaps(List<ControllerMap> results)
				{
					return default(int);
				}

				public IEnumerable<T> GetAllMaps<T>() where T : ControllerMap
				{
					return null;
				}

				public int GetAllMaps<T>(List<T> results) where T : ControllerMap
				{
					return default(int);
				}

				public IEnumerable<ControllerMap> GetAllMaps(ControllerType controllerType)
				{
					return null;
				}

				public int GetAllMaps(ControllerType controllerType, List<ControllerMap> results)
				{
					return default(int);
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName)
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId)
				{
					return null;
				}

				public IEnumerable<T> GetAllMapsInCategory<T>(string categoryName) where T : ControllerMap
				{
					return null;
				}

				public IEnumerable<T> GetAllMapsInCategory<T>(int categoryId) where T : ControllerMap
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName, ControllerType controllerType)
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId, ControllerType controllerType)
				{
					return null;
				}

				public int GetAllMapsInCategory(string categoryName, List<ControllerMap> results)
				{
					return default(int);
				}

				public int GetAllMapsInCategory(int categoryId, List<ControllerMap> results)
				{
					return default(int);
				}

				public int GetAllMapsInCategory<T>(string categoryName, List<T> results) where T : ControllerMap
				{
					return default(int);
				}

				public int GetAllMapsInCategory<T>(int categoryId, List<T> results) where T : ControllerMap
				{
					return default(int);
				}

				public int GetAllMapsInCategory(string categoryName, ControllerType controllerType, List<ControllerMap> results)
				{
					return default(int);
				}

				public int GetAllMapsInCategory(int categoryId, ControllerType controllerType, List<ControllerMap> results)
				{
					return default(int);
				}

				public IList<T> GetMaps<T>(int controllerId) where T : ControllerMap
				{
					return null;
				}

				public IList<ControllerMap> GetMaps(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IList<ControllerMap> GetMaps(Controller controller)
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId)
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName)
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, int categoryId)
				{
					return null;
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, string categoryName)
				{
					return null;
				}

				public int GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId, List<ControllerMap> results)
				{
					return default(int);
				}

				public int GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName, List<ControllerMap> results)
				{
					return default(int);
				}

				public int GetMapsInCategory(Controller controller, int categoryId, List<ControllerMap> results)
				{
					return default(int);
				}

				public int GetMapsInCategory(Controller controller, string categoryName, List<ControllerMap> results)
				{
					return default(int);
				}

				public IEnumerable<T> GetMapsInCategory<T>(int controllerId, int categoryId) where T : ControllerMap
				{
					return null;
				}

				public IEnumerable<T> GetMapsInCategory<T>(int controllerId, string categoryName) where T : ControllerMap
				{
					return null;
				}

				public int GetMapsInCategory<T>(int controllerId, int categoryId, List<T> results) where T : ControllerMap
				{
					return default(int);
				}

				public int GetMapsInCategory<T>(int controllerId, string categoryName, List<T> results) where T : ControllerMap
				{
					return default(int);
				}

				public T GetMap<T>(int controllerId, int mapId) where T : ControllerMap
				{
					return null;
				}

				public T GetMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
					return null;
				}

				public T GetMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
					return null;
				}

				public ControllerMap GetMap(int mapId)
				{
					return null;
				}

				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int mapId)
				{
					return null;
				}

				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
					return null;
				}

				public ControllerMap GetMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
					return null;
				}

				public ControllerMap GetMap(Controller controller, int mapId)
				{
					return null;
				}

				public ControllerMap GetMap(Controller controller, int categoryId, int layoutId)
				{
					return null;
				}

				public ControllerMap GetMap(Controller controller, string categoryName, string layoutName)
				{
					return null;
				}

				public T GetFirstMapInCategory<T>(int controllerId, string categoryName) where T : ControllerMap
				{
					return null;
				}

				public T GetFirstMapInCategory<T>(int controllerId, int categoryId) where T : ControllerMap
				{
					return null;
				}

				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, string categoryName)
				{
					return null;
				}

				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, int categoryId)
				{
					return null;
				}

				public ControllerMap GetFirstMapInCategory(Controller controller, string categoryName)
				{
					return null;
				}

				public ControllerMap GetFirstMapInCategory(Controller controller, int categoryId)
				{
					return null;
				}

				public void AddMap<T>(int controllerId, ControllerMap map) where T : ControllerMap
				{
				}

				public void AddMap(Controller controller, ControllerMap map)
				{
				}

				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map)
				{
				}

				public void AddMap<T>(int controllerId, ControllerMap map, bool startEnabled) where T : ControllerMap
				{
				}

				public void AddMap(Controller controller, ControllerMap map, bool startEnabled)
				{
				}

				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map, bool startEnabled)
				{
				}

				public bool AddMapFromXml<T>(int controllerId, string xmlString) where T : ControllerMap
				{
					return default(bool);
				}

				public bool AddMapFromXml(ControllerType controllerType, int controllerId, string xmlString)
				{
					return default(bool);
				}

				public int AddMapsFromXml<T>(int controllerId, List<string> xmlStrings) where T : ControllerMap
				{
					return default(int);
				}

				public int AddMapsFromXml(ControllerType controllerType, int controllerId, List<string> xmlStrings)
				{
					return default(int);
				}

				public bool AddMapFromJson<T>(int controllerId, string jsonString) where T : ControllerMap
				{
					return default(bool);
				}

				public bool AddMapFromJson(ControllerType controllerType, int controllerId, string jsonString)
				{
					return default(bool);
				}

				public int AddMapsFromJson<T>(int controllerId, List<string> jsonStrings) where T : ControllerMap
				{
					return default(int);
				}

				public int AddMapsFromJson(ControllerType controllerType, int controllerId, List<string> jsonStrings)
				{
					return default(int);
				}

				public void AddEmptyMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
				}

				public void AddEmptyMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
				}

				public void AddEmptyMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
				}

				public void AddEmptyMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
				}

				public void RemoveMap<T>(int controllerId, int mapId) where T : ControllerMap
				{
				}

				public void RemoveMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
				}

				public void RemoveMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
				}

				public void RemoveMap(ControllerType controllerType, int controllerId, int mapId)
				{
				}

				public void RemoveMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
				}

				public void RemoveMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
				}

				public void ClearMaps<T>(bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMaps(ControllerType controllerType, bool userAssignableOnly)
				{
				}

				public void ClearMapsInCategory<T>(int categoryId, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsInCategory<T>(string categoryName, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsInCategory<T>(int categoryId, int layoutId, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsInCategory<T>(string categoryName, string layoutName, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsInCategory(int categoryId, bool userAssignableOnly)
				{
				}

				public void ClearMapsInCategory(string categoryName, bool userAssignableOnly)
				{
				}

				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, bool userAssignableOnly)
				{
				}

				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, bool userAssignableOnly)
				{
				}

				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, int layoutId, bool userAssignableOnly)
				{
				}

				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, string layoutName, bool userAssignableOnly)
				{
				}

				public void ClearMapsInLayout<T>(int layoutId, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsInLayout<T>(string layoutName, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsInLayout(ControllerType controllerType, int layoutId, bool userAssignableOnly)
				{
				}

				public void ClearMapsInLayout(ControllerType controllerType, string layoutName, bool userAssignableOnly)
				{
				}

				public void ClearMapsForController<T>(int controllerId, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsForController<T>(int controllerId, int categoryId, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsForController<T>(int controllerId, string categoryName, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsForController(ControllerType controllerType, int controllerId, bool userAssignableOnly)
				{
				}

				public void ClearMapsForController(ControllerType controllerType, int controllerId, int categoryId, bool userAssignableOnly)
				{
				}

				public void ClearMapsForController(ControllerType controllerType, int controllerId, string categoryName, bool userAssignableOnly)
				{
				}

				public void ClearMapsForControllerInLayout<T>(int controllerId, int layoutId, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsForControllerInLayout<T>(int controllerId, string layoutName, bool userAssignableOnly) where T : ControllerMap
				{
				}

				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, int layoutId, bool userAssignableOnly)
				{
				}

				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, string layoutName, bool userAssignableOnly)
				{
				}

				public void ClearAllMaps(bool userAssignableOnly)
				{
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
				{
					return null;
				}

				public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
				{
					return null;
				}

				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return default(int);
				}

				public T[] GetMapSaveData<T>(int controllerId, bool userAssignableMapsOnly) where T : ControllerMapSaveData
				{
					return null;
				}

				public ControllerMapSaveData[] GetMapSaveData(ControllerType controllerType, int controllerId, bool userAssignableMapsOnly)
				{
					return null;
				}

				public T[] GetAllMapSaveData<T>(bool userAssignableMapsOnly) where T : ControllerMapSaveData
				{
					return null;
				}

				public ControllerMapSaveData[] GetAllMapSaveData(ControllerType controllerType, bool userAssignableMapsOnly)
				{
					return null;
				}

				public ControllerMapSaveData[] GetAllMapSaveData(bool userAssignableMapsOnly)
				{
					return null;
				}

				public int SetAllMapsEnabled(bool state)
				{
					return default(int);
				}

				public int SetAllMapsEnabled(bool state, ControllerType controllerType)
				{
					return default(int);
				}

				public int SetAllMapsEnabled(bool state, Controller controller)
				{
					return default(int);
				}

				public int SetAllMapsEnabled(bool state, ControllerType controllerType, int controllerId)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, int categoryId)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, string categoryName)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, string categoryName, string layoutName)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId, int layoutId)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName, string layoutName)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, Controller controller, int categoryId)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, Controller controller, int categoryId, int layoutId)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, Controller controller, string categoryName)
				{
					return default(int);
				}

				public int SetMapsEnabled(bool state, Controller controller, string categoryName, string layoutName)
				{
					return default(int);
				}

				public void LoadDefaultMaps(ControllerType controllerType)
				{
				}

				public bool ContainsMapInCategory(InputMapCategory category)
				{
					return default(bool);
				}

				public bool ContainsMapInCategory(int categoryId)
				{
					return default(bool);
				}

				public bool ContainsMapInCategory(string categoryName)
				{
					return default(bool);
				}

				public bool ContainsMapInCategory(ControllerType controllerType, int categoryId)
				{
					return default(bool);
				}

				public InputBehavior GetInputBehavior(int behaviorId)
				{
					return null;
				}

				public InputBehavior GetInputBehavior(string behaviorName)
				{
					return null;
				}

				internal void ItdhavHGXcUkAhyjaCFbIXENJheh()
				{
				}

				internal void ljuzyhLOykfHUNqpupeYHHYVVUa(bool P_0)
				{
				}

				internal void NHvEbWUrKnQLGxXIuzllGPcMtQ(bool P_0)
				{
				}

				internal void SlISPtLfLQFUPagROOqtyucSdRl(bool P_0)
				{
				}

				internal void zAYHkHeBUioXAywUbyMjEbgDqMXE(bool P_0)
				{
				}

				private uwILKJrQnvyPKXqkviwAHMwxglt hxOOzhfeazOtLJWADoJhQgiGlzs<T>() where T : ControllerMap
				{
					return null;
				}

				internal global::UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> OjIHCxhPqXjtJWjGkbWIODpinHE(Joystick P_0, bool P_1)
				{
					return null;
				}

				private void kpLbpdIVdpCOPCuotjOTQDWMlps(Joystick P_0, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<JoystickMap> P_1, VazWCJszjSvmMxSvRJnnBczpVoI P_2, bool P_3)
				{
				}

				internal global::UqmUJOucnPAhoXhVuhvbmxKGsOH<CustomControllerMap> VJVfCBZpPxtAMcwrGcyftqeWpph(CustomController P_0, bool P_1)
				{
					return null;
				}

				private void cvcNRPlBVHsHAXnqfBvnJlkrtaA(CustomController P_0, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<CustomControllerMap> P_1, VazWCJszjSvmMxSvRJnnBczpVoI P_2, bool P_3)
				{
				}

				internal void CmxbnCZUDHhLTtrfUROfRgOsrHY(Controller P_0, ControllerMap P_1)
				{
				}

				private IList<T> yWZVEngpJTrWcIAabCcjjehlxsBj<T>(int P_0) where T : ControllerMap
				{
					return null;
				}

				private IList<T> yWZVEngpJTrWcIAabCcjjehlxsBj<T>(Controller P_0) where T : ControllerMap
				{
					return null;
				}

				private IList<ControllerMap> yWZVEngpJTrWcIAabCcjjehlxsBj(ControllerType P_0, int P_1)
				{
					return null;
				}

				private IList<ControllerMap> yWZVEngpJTrWcIAabCcjjehlxsBj(Controller P_0)
				{
					return null;
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType P_0, int P_1, int P_2, int P_3)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(Controller P_0, int P_1, int P_2)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType P_0, int P_1, string P_2, string P_3)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(Controller P_0, string P_1, string P_2)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType P_0, int P_1, int P_2, int P_3, BoolOption P_4)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(Controller P_0, int P_1, int P_2, BoolOption P_3)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(ControllerType P_0, int P_1, string P_2, string P_3, BoolOption P_4)
				{
				}

				private void azHszTgePDPkBJLxcubKkYACbrS(Controller P_0, string P_1, string P_2, BoolOption P_3)
				{
				}

				private void nRpfYcSMpjzNOMaRrgWhxbaFFow(Controller P_0, ControllerMap P_1, BoolOption P_2)
				{
				}

				private void nRpfYcSMpjzNOMaRrgWhxbaFFow(ControllerType P_0, int P_1, ControllerMap P_2, BoolOption P_3)
				{
				}

				private bool gCUvtoINFiRJKWCKAiyXBKgcwCw(ControllerType P_0, int P_1, string P_2)
				{
					return default(bool);
				}

				private int McaTJhbNDEhUXOYSYjSfoXlxXsD(ControllerType P_0, int P_1, List<string> P_2)
				{
					return default(int);
				}

				private bool lmastpkegqvXgzyngLJdWbYQovD(ControllerType P_0, int P_1, string P_2)
				{
					return default(bool);
				}

				private int QeUGCFVLdpkvKuroBITzfcEEQaU(ControllerType P_0, int P_1, List<string> P_2)
				{
					return default(int);
				}

				private void SWSIQZFYSQLALpiqLfqjsjCanYk(ControllerType P_0, int P_1, int P_2, int P_3)
				{
				}

				private void SWSIQZFYSQLALpiqLfqjsjCanYk(Controller P_0, int P_1, int P_2)
				{
				}

				private void SWSIQZFYSQLALpiqLfqjsjCanYk(ControllerType P_0, int P_1, string P_2, string P_3)
				{
				}

				private void SWSIQZFYSQLALpiqLfqjsjCanYk(Controller P_0, string P_1, string P_2)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType P_0, int P_1, int P_2)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller P_0, int P_1)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType P_0, int P_1, ControllerMap P_2)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller P_0, ControllerMap P_1)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType P_0, int P_1, int P_2, int P_3)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller P_0, int P_1, int P_2)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(ControllerType P_0, int P_1, string P_2, string P_3)
				{
				}

				private void wdXBtZaFNKlhBUmtaHeXouumymuU(Controller P_0, string P_1, string P_2)
				{
				}

				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType P_0, int P_1, int P_2)
				{
					return null;
				}

				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller P_0, int P_1)
				{
					return null;
				}

				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType P_0, int P_1, int P_2, int P_3)
				{
					return null;
				}

				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller P_0, int P_1, int P_2)
				{
					return null;
				}

				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(ControllerType P_0, int P_1, string P_2, string P_3)
				{
					return null;
				}

				private ControllerMap vSAkDJuNwpDhFkKyKqtchPrGfgJH(Controller P_0, string P_1, string P_2)
				{
					return null;
				}

				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(ControllerType P_0, int P_1, int P_2)
				{
					return null;
				}

				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(Controller P_0, int P_1)
				{
					return null;
				}

				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(ControllerType P_0, int P_1, string P_2)
				{
					return null;
				}

				private ControllerMap uydcTkSsveNrDWhdfejCzhPijCK(Controller P_0, string P_1)
				{
					return null;
				}

				private ControllerMap[] MsRJVqmqJMIZqczuwuGRjMnFXPNf(ControllerType P_0)
				{
					return null;
				}

				private ControllerMapSaveData[] UxlfCZTeJutCpoKfgKKpmMIRjUX(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private T[] UxlfCZTeJutCpoKfgKKpmMIRjUX<T>(int P_0, bool P_1) where T : ControllerMapSaveData
				{
					return null;
				}

				private ControllerMapSaveData[] WepHTJHYyuxCQWQDKcGkMoxbloqK(ControllerType P_0, bool P_1)
				{
					return null;
				}

				private T[] WepHTJHYyuxCQWQDKcGkMoxbloqK<T>(bool P_0) where T : ControllerMapSaveData
				{
					return null;
				}

				private int tMiAgVhCKUhHOdiwAySOMpxktsU(ControllerType P_0, int P_1, int P_2, List<ControllerMap> P_3)
				{
					return default(int);
				}

				private int tMiAgVhCKUhHOdiwAySOMpxktsU(Controller P_0, int P_1, List<ControllerMap> P_2)
				{
					return default(int);
				}

				private int tMiAgVhCKUhHOdiwAySOMpxktsU(ControllerType P_0, int P_1, string P_2, List<ControllerMap> P_3)
				{
					return default(int);
				}

				private int tMiAgVhCKUhHOdiwAySOMpxktsU(Controller P_0, string P_1, List<ControllerMap> P_2)
				{
					return default(int);
				}

				private IEnumerable<ControllerMap> QLyRBVUAepSHUPCdsjmRgMsOiId(ControllerType P_0, int P_1, int P_2)
				{
					return null;
				}

				private IEnumerable<T> QLyRBVUAepSHUPCdsjmRgMsOiId<T>(int P_0, int P_1) where T : ControllerMap
				{
					return null;
				}

				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType P_0, string P_1, bool P_2)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType P_0, string P_1, bool P_2)
				{
					return null;
				}

				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType P_0, string P_1, bool P_2)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType P_0, string P_1, bool P_2)
				{
					return null;
				}

				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType P_0, string P_1, bool P_2)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType P_0, int P_1, bool P_2)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType P_0, string P_1, bool P_2)
				{
					return null;
				}

				private int iRpRMXtGPzaRzbxQcKhFNYOkpU(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
				{
					return default(int);
				}

				private int aJrBTCaTOYGxSpVpmfRGkxuxFcsp(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
				{
					return default(int);
				}

				private int LUtxNstqrZkFfSUMrtjuNGVLWKp(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
				{
					return default(int);
				}

				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType P_0, int P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					return default(int);
				}

				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType P_0, string P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					return default(int);
				}

				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType P_0, int P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					return default(int);
				}

				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType P_0, string P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					return default(int);
				}

				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType P_0, int P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					return default(int);
				}

				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType P_0, string P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					return default(int);
				}

				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					return null;
				}

				private ActionElementMap zWuVeIfMjbjzeGortobFYQWfBWD(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> VceQlZlQeNWnAVcXwZFwSzxauNl(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					return null;
				}

				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					return null;
				}

				private ActionElementMap zewHWDgjyeGLAqThpksnKtNDbCr(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> QQTvpNWmnOTXXWnIOJysgquOOSN(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					return null;
				}

				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					return null;
				}

				private ActionElementMap zfCiUcEGjnQvFnQdnvuKbtLhWwHb(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> AGYVxhOwMpMgdAOTqqeUwEDCKEZ(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					return null;
				}

				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType P_0, int P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}

				private int PpzEHMktrgrSozWFKEKIrJEwDdl(ControllerType P_0, int P_1, string P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}

				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType P_0, int P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}

				private int orYUSPTLyKzGaPIjbumYvhkmHjZ(ControllerType P_0, int P_1, string P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}

				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType P_0, int P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}

				private int sMrwWquwVtpROYhaaLmsTNgBJiKh(ControllerType P_0, int P_1, string P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}

				private ActionElementMap xGTFTEwJTsxlOSroXbTPCnZFHCo(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3)
				{
					return null;
				}

				private IEnumerable<ActionElementMap> GVIGeapkjeIDqIFeJwntvbxutdYh(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3)
				{
					return null;
				}

				private int fayFUJtQndSNaRgkmUFdjreRzfd(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					return default(int);
				}
			}

			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class PollingHelper : CodeHelper
			{
				private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK;

				private readonly ControllerHelper GsoDNwSmTlqXUxYxRnLUXMOoArhh;

				private readonly int vSShldFHkaZKEuThltrSgFmPfc;

				internal PollingHelper(Player player, ControllerHelper parent)
				{
				}

				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId)
				{
					return default(ControllerPollingInfo);
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId)
				{
					return null;
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType)
				{
					return default(ControllerPollingInfo);
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElements(ControllerType controllerType)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElementsDown(ControllerType controllerType)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtons(ControllerType controllerType)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtonsDown(ControllerType controllerType)
				{
					return null;
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllAxes(ControllerType controllerType)
				{
					return null;
				}

				private ControllerPollingInfo bGKlLbFWmbtGAiOmNKKPUtnwcAZ(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo rqyemvFZhjSSrBYMaOhYnmPCKqem(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo NQtBLmIPQGvDNomIxxmiVjxcQNAA(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo NadfyxFpnsKvEQGCdsAnNZMYaax(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo oKWdenitALAFVrRNgIdhEPKFJvb(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> ZWimbzFMwCSuhYFEcXFEeWFifWR(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> RehcirISqbiBTGUaoHnpFtPenXv(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> zWDCSWjzhmjQvPyFnbCXiBHCOwJJ(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> MtBriKVVFZdgebmAQffCEKEFdXl(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> OSicUzHcokWNlWyDVoxJoXjEYvE(int P_0)
				{
					return null;
				}

				private ControllerPollingInfo dxGBopFwPGpRnntJodvmMTzYCpiY()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo fWKPjGiTOuPWukeRyCkdtHrmENvE()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo ZofbmNrsDVSejYtKcoCeGNYmbpn()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo PUcjNuzteixdxqKUVlKFhYGZmsf()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo UKRVFPSTSpcGXWGJXZBATXbYkwq()
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> AItrmiLLNLETHbDmllsTwttPIQaC()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> jrGRHFKGLMVcvwxfLWDvEVEfMLi()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> BtGYtVGEqwSHtYaXzzQUrewGJtn()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> uMQCThPkzuvLVNhlZAgYnTPKtmq()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> CfecEujJWgnIEBaHKLlKSQqNiSk()
				{
					return null;
				}

				private ControllerPollingInfo DIwYDhteIrUYYQHskNqJZhFugHo()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo ciKfGFbLFusTsJrpdJggIwKAROUA()
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> omzYIcEzjUxwVujJpCnfGdFwAbX()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> MklBDqRYzLrUUBNdRhVSLsUiLKI()
				{
					return null;
				}

				private ControllerPollingInfo nPZxtrrDJyGWOPAciHrsnAGWWPi()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo qBQnfvsldcNuFORfufcManPBmLhk()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo gzutiYORsAguHeeehFjLCLdsDfQh()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo QjcCJttJgHDOZjHbrELXHpwfUGLO()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo sNEfSVWAjRTlpjNlZKETBtDzecp()
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> LhmHRTYQoeUAxXbxFBjrIwBLUWUp()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> ZPuArbyTCfKafkfAWuhezckKgqj()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> gsMyLZGcNmItjsvMlQRZdhKNgYvC()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> OyLGmfjCcioJWJtAePmnOTazcwS()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> KyIBIZHBRRlfClOWAZETcMKeKqb()
				{
					return null;
				}

				private ControllerPollingInfo ukARGcUNoOKRPjiqVKBcGVMeLqZ(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo SsyPctSmRbgMoZvfEsIGiNBNfBS(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo HTLpMztZmHhBNnBWhwmKUZaJjJx(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo EVefEGecgrsLVWECEuaCKzyFaYa(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo meAjTtJCVRtvGxDotlYZDOPybkb(int P_0)
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> wYgrvTepDlcraADeICRgBBKzeBpu(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> BqEGmaeHIeNTnicYHhRMjMtLkMLC(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> YklCVTfTmFGyKDdTjkJgSXyKecKX(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> OevlbRZKmWsizWsTsKtDOUmFvIt(int P_0)
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> TrQFuxrthJtxLaAuKTMNREkLqsA(int P_0)
				{
					return null;
				}

				private ControllerPollingInfo oSFtmtOlVnmtllndgZhgzjXrcPbB()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo BqyFLNGhnxjMKKYomIkiUEqnhvbC()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo pxpCQJFztfslpkhJUtGDeDKsfMI()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo VttanxeBuoolFYVesRmMRlbaZaiL()
				{
					return default(ControllerPollingInfo);
				}

				private ControllerPollingInfo sxpqmzYXwllNCeZVMFVbptxNUkx()
				{
					return default(ControllerPollingInfo);
				}

				private IEnumerable<ControllerPollingInfo> ptBfGdJhSVIOGLSnobCWSRZzxBii()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> XKeRkgCoTdFtbODgFSXZqtgWlrZ()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> MJIamdcXeYbqxTTEaHBvVhjKibf()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> yoOWDMRSkMEUZtHTwrKxqttgCFo()
				{
					return null;
				}

				private IEnumerable<ControllerPollingInfo> maRRnmjmoNDrDjpkFIWHkPqGUslH()
				{
					return null;
				}
			}

			private readonly egXAAqgVCShQeuJnjIKIGPUQzKT kjcfkBjrQkYuXOIuOAVTAohfNFLa;

			private bool DltVeAWOftOsatsUOyyDXbQZoYf;

			private bool yrdehMQHNKfGqUhXmAFthRgGXibc;

			private bool VCsJeXHuvxKMGlHlHqyTsCiKIRlg;

			private float nNotoQyuvMlnNzGudIeGiuunWjb;

			private float rPEuzcfajrNclqqlomTyOntGOXL;

			private SafeAction<ControllerAssignmentChangedEventArgs> hevtkFAAcwsaWUduMzJoSldvEAhG;

			private SafeAction<ControllerAssignmentChangedEventArgs> gQFdpWzunAnCpGgOphLvBJoYWbGb;

			private readonly jAchFPOUJqmmtMllCTHcROXwbLj VoNXLwsbUAMaIxrCOafEXDdBDZn;

			private readonly Player yHWXapLnjMXUYBDESFaAUIdnziK;

			private readonly EOJGUkiUCmDxCVgwuamVbrNKilvC VNXSIBPhgXxupWtsLpgyapRjbDq;

			private readonly int vSShldFHkaZKEuThltrSgFmPfc;

			public readonly MapHelper maps;

			public readonly ConflictCheckingHelper conflictChecking;

			public readonly PollingHelper polling;

			[CompilerGenerated]
			private static Action<Exception> SoptGiBIwpEzOTmBujKpoVBsSer;

			[CompilerGenerated]
			private static Action<Exception> AGoLVphFiYSQJEBguHfxHhzJytur;

			private yuzjpKSgIlOzFrmYoCjvudWJHqg<Joystick, JoystickMap> joystickSet
			{
				get
				{
					return null;
				}
			}

			private global::UqmUJOucnPAhoXhVuhvbmxKGsOH<KeyboardMap> keyboardMapSet
			{
				get
				{
					return null;
				}
			}

			private global::UqmUJOucnPAhoXhVuhvbmxKGsOH<MouseMap> mouseMapSet
			{
				get
				{
					return null;
				}
			}

			private yuzjpKSgIlOzFrmYoCjvudWJHqg<CustomController, CustomControllerMap> customControllerSet
			{
				get
				{
					return null;
				}
			}

			public bool hasMouse
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool hasKeyboard
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public bool excludeFromControllerAutoAssignment
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public Keyboard Keyboard
			{
				get
				{
					return null;
				}
			}

			public Mouse Mouse
			{
				get
				{
					return null;
				}
			}

			public int joystickCount
			{
				get
				{
					return default(int);
				}
			}

			public IList<Joystick> Joysticks
			{
				get
				{
					return null;
				}
			}

			public int customControllerCount
			{
				get
				{
					return default(int);
				}
			}

			public IList<CustomController> CustomControllers
			{
				get
				{
					return null;
				}
			}

			public IEnumerable<Controller> Controllers
			{
				get
				{
					return null;
				}
			}

			public event Action<ControllerAssignmentChangedEventArgs> ControllerAddedEvent
			{
				add
				{
				}
				remove
				{
				}
			}

			public event Action<ControllerAssignmentChangedEventArgs> ControllerRemovedEvent
			{
				add
				{
				}
				remove
				{
				}
			}

			internal ControllerHelper(Player player, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings)
			{
			}

			public T GetController<T>(int controllerId) where T : Controller
			{
				return null;
			}

			public Controller GetController(ControllerType controllerType, int controllerId)
			{
				return null;
			}

			public T GetControllerWithTag<T>(string tag) where T : Controller
			{
				return null;
			}

			public Controller GetControllerWithTag(ControllerType controllerType, string tag)
			{
				return null;
			}

			public void AddController<T>(int controllerId, bool removeFromOtherPlayers) where T : Controller
			{
			}

			public void AddController(Controller controller, bool removeFromOtherPlayers)
			{
			}

			public void AddController(ControllerType controllerType, int controllerId, bool removeFromOtherPlayers)
			{
			}

			public void RemoveController<T>(int controllerId) where T : Controller
			{
			}

			public void RemoveController(ControllerType controllerType, int controllerId)
			{
			}

			public void RemoveController(Controller controller)
			{
			}

			public bool ContainsController<T>(int controllerId) where T : Controller
			{
				return default(bool);
			}

			public bool ContainsController(ControllerType controllerType, int controllerId)
			{
				return default(bool);
			}

			public bool ContainsController(Controller controller)
			{
				return default(bool);
			}

			public void ClearControllersOfType<T>() where T : Controller
			{
			}

			public void ClearControllersOfType(ControllerType controllerType)
			{
			}

			public void ClearAllControllers()
			{
			}

			public Controller GetLastActiveController()
			{
				return null;
			}

			public Controller GetLastActiveController(ControllerType controllerType)
			{
				return null;
			}

			private void EUVYCARsIPrBKbpQiGBVjqXpKpjH(ControllerType P_0, ref Controller P_1, ref float P_2)
			{
			}

			public Controller GetLastActiveController<T>() where T : Controller
			{
				return null;
			}

			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback)
			{
			}

			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
			}

			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback)
			{
			}

			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
			}

			public void ClearLastActiveControllerChangedDelegates()
			{
			}

			public Controller GetFirstControllerWithTemplate(Guid templateTypeGuid)
			{
				return null;
			}

			public Controller GetFirstControllerWithTemplate(Type templateType)
			{
				return null;
			}

			public Controller GetFirstControllerWithTemplate<T>() where T : class
			{
				return null;
			}

			public IList<TInterface> GetControllerTemplates<TInterface>() where TInterface : IControllerTemplate
			{
				return null;
			}

			private Controller jYszhMBrmTjIcZxErgYoWfGYMXC<TDelegateParam>(ControllerType P_0, Func<Controller, TDelegateParam, bool> P_1, TDelegateParam P_2)
			{
				return null;
			}

			internal void ItdhavHGXcUkAhyjaCFbIXENJheh()
			{
			}

			internal float FYIElmJxflCFhgIZyTsOMvYpGHtG(int P_0)
			{
				return default(float);
			}

			internal void XaPQxcyWqNsdQjhKzBKsjimvZyS(Joystick P_0, bool P_1)
			{
			}

			internal void XaPQxcyWqNsdQjhKzBKsjimvZyS(int P_0, bool P_1)
			{
			}

			internal void xzceZeGGWmetBAeiWNsduDUsewIa(int P_0)
			{
			}

			internal void xzceZeGGWmetBAeiWNsduDUsewIa(Joystick P_0)
			{
			}

			internal void JVgdmkDNRxZQzikVOAghyODdmTo()
			{
			}

			internal void XiHbKYIwqhdauDbRGGwGkFljxrFY(CustomController P_0, bool P_1)
			{
			}

			internal void XiHbKYIwqhdauDbRGGwGkFljxrFY(int P_0, bool P_1)
			{
			}

			internal void ThZteeIklpsxGRYsSIfxQcYzcae(int P_0)
			{
			}

			internal void ThZteeIklpsxGRYsSIfxQcYzcae(CustomController P_0)
			{
			}

			internal void uOzYhSCLiLcGIIOdEdqkuYDlGKHv()
			{
			}

			internal CustomController KVVCTKWyFZmIycuszMOZbQGKMvX(int P_0)
			{
				return null;
			}

			internal void tzDaIgFQnfsVMqJsHHtXDlwsoxaI(Action<bool, int, int> P_0)
			{
			}

			internal void AbkUkCWdTMWidEEQvyYkEXJXtVW(Keyboard P_0, djpwPzKBzvznzxIiuRBprQLHfCc P_1, Action<bool, int, int> P_2)
			{
			}

			private static void XpMdjVJIiPLupjAFCctYNYGLQFMI(Keyboard P_0, ControllerMap P_1, ActionElementMap P_2, IqIukLIsmYdsSTXcphOdCKQUWBG P_3, ButtonStateFlags P_4)
			{
			}

			internal void ZUUoXTAWbstgZnbECVAwXArHCqOf(Mouse P_0, Action<bool, int, int> P_1)
			{
			}

			internal void xYYePMSKaQDySNlDrymJaiyuDfTi(Action<bool, int, int> P_0)
			{
			}

			private void oKtDVECOnvicsHXYOjPcsNPoasn<T, TMap>(ControllerType P_0, Action<bool, int, int> P_1) where T : ControllerWithAxes where TMap : ControllerMapWithAxes
			{
			}

			private bool PPjNWtPrrNLfSFeDfxlPEFiPlWi<TMap>(ControllerWithAxes P_0, int P_1, int P_2, ActionElementMap P_3, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> P_4, int P_5, ref float P_6) where TMap : ControllerMapWithAxes
			{
				return default(bool);
			}

			private bool VgZTJYILLhKkehwJvkGIEHsbWZu<TMap>(UnknownControllerHat.HatButtons P_0, int P_1, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> P_2) where TMap : ControllerMapWithAxes
			{
				return default(bool);
			}

			private bool PTrrixCBiTdabCtPetYhlDlQzig<TMap>(UnknownControllerHat.HatButtons P_0, int P_1, global::UqmUJOucnPAhoXhVuhvbmxKGsOH<TMap> P_2) where TMap : ControllerMapWithAxes
			{
				return default(bool);
			}

			[CompilerGenerated]
			private static void pOcCcEPETYfiVgcsLGAPfcnitqGJ(Exception P_0)
			{
			}

			[CompilerGenerated]
			private static void nKBfZOoSRNcWGVmXsGDbjHqfeFdg(Exception P_0)
			{
			}
		}

		private readonly GOCsEdcRqIdaMQpgFWoBujLBrvX AoGmvlgpgvDvEPufAzhECdZfmlf;

		private bool aomFahYawZCtEfvqgieyFRpNBEB;

		private int jotfbgeLQZTIFstijorJbghJlvHQ;

		private string MYcWDFnyndJzsFpKvFFizAMuaiT;

		private string nMArBKqVFJGDMXuQgzGpKHGekZp;

		private bool BehdbTjAadwGBArRmdjvgPqrrwqs;

		private readonly int vSShldFHkaZKEuThltrSgFmPfc;

		public readonly ControllerHelper controllers;

		public int id
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string descriptiveName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool isPlaying
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal Player(bool isSystem, int playerId, string name, string descriptiveName, VVLouGbEKulMPcFZiTUTqikUjEp startingControllerMapInfo, ControllerMapLayoutManager.StartingSettings controllerMapLayoutManagerSettings, ControllerMapEnabler.ZgESyvoCZDaaWJMTaxFmFrlTHlVN controllerMapEnablerSettings)
		{
		}

		public PlayerSaveData GetSaveData(bool userAssignableMapsOnly)
		{
			return default(PlayerSaveData);
		}

		public bool GetButton(string actionName)
		{
			return default(bool);
		}

		public bool GetButton(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonDown(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonDown(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonUp(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonUp(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonPrev(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonPrev(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonSinglePressHold(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonSinglePressHold(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonSinglePressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonSinglePressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonSinglePressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonSinglePressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressHold(string actionName, float speed)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressHold(int actionId, float speed)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressHold(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressHold(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressDown(string actionName, float speed)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressDown(int actionId, float speed)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressUp(string actionName, float speed)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressUp(int actionId, float speed)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonDoublePressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonTimedPress(string actionName, float time)
		{
			return default(bool);
		}

		public bool GetButtonTimedPress(int actionId, float time)
		{
			return default(bool);
		}

		public bool GetButtonTimedPress(string actionName, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetButtonTimedPress(int actionId, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetButtonTimedPressDown(string actionName, float time)
		{
			return default(bool);
		}

		public bool GetButtonTimedPressDown(int actionId, float time)
		{
			return default(bool);
		}

		public bool GetButtonTimedPressUp(string actionName, float time)
		{
			return default(bool);
		}

		public bool GetButtonTimedPressUp(int actionId, float time)
		{
			return default(bool);
		}

		public bool GetButtonTimedPressUp(string actionName, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetButtonTimedPressUp(int actionId, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetButtonShortPress(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonShortPress(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonShortPressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonShortPressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonShortPressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonShortPressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonLongPress(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonLongPress(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonLongPressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonLongPressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonLongPressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonLongPressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetButtonRepeating(string actionName)
		{
			return default(bool);
		}

		public bool GetButtonRepeating(int actionId)
		{
			return default(bool);
		}

		public bool GetAnyButton()
		{
			return default(bool);
		}

		public bool GetAnyButtonDown()
		{
			return default(bool);
		}

		public bool GetAnyButtonUp()
		{
			return default(bool);
		}

		public bool GetAnyButtonPrev()
		{
			return default(bool);
		}

		public float GetButtonTimePressed(string actionName)
		{
			return default(float);
		}

		public float GetButtonTimePressed(int actionId)
		{
			return default(float);
		}

		public float GetButtonTimeUnpressed(string actionName)
		{
			return default(float);
		}

		public float GetButtonTimeUnpressed(int actionId)
		{
			return default(float);
		}

		public bool GetNegativeButton(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButton(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDown(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDown(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonUp(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonUp(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonPrev(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonPrev(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonSinglePressHold(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonSinglePressHold(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonSinglePressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonSinglePressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonSinglePressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonSinglePressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressHold(string actionName, float speed)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressHold(int actionId, float speed)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressHold(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressHold(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressDown(string actionName, float speed)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressDown(int actionId, float speed)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressUp(string actionName, float speed)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressUp(int actionId, float speed)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonDoublePressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPress(string actionName, float time)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPress(int actionId, float time)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPress(string actionName, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPress(int actionId, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPressDown(string actionName, float time)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPressDown(int actionId, float time)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPressUp(string actionName, float time)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPressUp(int actionId, float time)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPressUp(string actionName, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetNegativeButtonTimedPressUp(int actionId, float time, float expireIn)
		{
			return default(bool);
		}

		public bool GetNegativeButtonShortPress(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonShortPress(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonShortPressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonShortPressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonShortPressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonShortPressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonLongPress(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonLongPress(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonLongPressDown(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonLongPressDown(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonLongPressUp(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonLongPressUp(int actionId)
		{
			return default(bool);
		}

		public bool GetNegativeButtonRepeating(string actionName)
		{
			return default(bool);
		}

		public bool GetNegativeButtonRepeating(int actionId)
		{
			return default(bool);
		}

		public bool GetAnyNegativeButton()
		{
			return default(bool);
		}

		public bool GetAnyNegativeButtonDown()
		{
			return default(bool);
		}

		public bool GetAnyNegativeButtonUp()
		{
			return default(bool);
		}

		public bool GetAnyNegativeButtonPrev()
		{
			return default(bool);
		}

		public float GetNegativeButtonTimePressed(string actionName)
		{
			return default(float);
		}

		public float GetNegativeButtonTimePressed(int actionId)
		{
			return default(float);
		}

		public float GetNegativeButtonTimeUnpressed(string actionName)
		{
			return default(float);
		}

		public float GetNegativeButtonTimeUnpressed(int actionId)
		{
			return default(float);
		}

		public float GetAxis(string actionName)
		{
			return default(float);
		}

		public float GetAxis(int actionId)
		{
			return default(float);
		}

		public float GetAxisRaw(string actionName)
		{
			return default(float);
		}

		public float GetAxisRaw(int actionId)
		{
			return default(float);
		}

		public float GetAxisPrev(string actionName)
		{
			return default(float);
		}

		public float GetAxisPrev(int actionId)
		{
			return default(float);
		}

		public float GetAxisRawPrev(string actionName)
		{
			return default(float);
		}

		public float GetAxisRawPrev(int actionId)
		{
			return default(float);
		}

		public float GetAxisDelta(string actionName)
		{
			return default(float);
		}

		public float GetAxisDelta(int actionId)
		{
			return default(float);
		}

		public float GetAxisRawDelta(string actionName)
		{
			return default(float);
		}

		public float GetAxisRawDelta(int actionId)
		{
			return default(float);
		}

		public Vector2 GetAxis2D(string xAxisActionName, string yAxisActionName)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2D(int xAxisActionId, int yAxisActionId)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DPrev(string xAxisActionName, string yAxisActionName)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DPrev(int xAxisActionId, int yAxisActionId)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DRaw(string xAxisActionName, string yAxisActionName)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DRaw(int xAxisActionId, int yAxisActionId)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DRawPrev(string xAxisActionName, string yAxisActionName)
		{
			return default(Vector2);
		}

		public Vector2 GetAxis2DRawPrev(int xAxisActionId, int yAxisActionId)
		{
			return default(Vector2);
		}

		public float GetAxisTimeActive(string actionName)
		{
			return default(float);
		}

		public float GetAxisTimeActive(int actionId)
		{
			return default(float);
		}

		public float GetAxisTimeInactive(string actionName)
		{
			return default(float);
		}

		public float GetAxisTimeInactive(int actionId)
		{
			return default(float);
		}

		public float GetAxisRawTimeActive(string actionName)
		{
			return default(float);
		}

		public float GetAxisRawTimeActive(int actionId)
		{
			return default(float);
		}

		public float GetAxisRawTimeInactive(string actionName)
		{
			return default(float);
		}

		public float GetAxisRawTimeInactive(int actionId)
		{
			return default(float);
		}

		public AxisCoordinateMode GetAxisCoordinateMode(string actionName)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisCoordinateMode(int actionId)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisRawCoordinateMode(string actionName)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisRawCoordinateMode(int actionId)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisCoordinateModePrev(string actionName)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisCoordinateModePrev(int actionId)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisRawCoordinateModePrev(string actionName)
		{
			return default(AxisCoordinateMode);
		}

		public AxisCoordinateMode GetAxisRawCoordinateModePrev(int actionId)
		{
			return default(AxisCoordinateMode);
		}

		public IList<InputActionSourceData> GetCurrentInputSources(string actionName)
		{
			return null;
		}

		public IList<InputActionSourceData> GetCurrentInputSources(int actionId)
		{
			return null;
		}

		public bool IsCurrentInputSource(string actionName, ControllerType controllerType)
		{
			return default(bool);
		}

		public bool IsCurrentInputSource(int actionId, ControllerType controllerType)
		{
			return default(bool);
		}

		public bool IsCurrentInputSource(string actionName, ControllerType controllerType, int controllerId)
		{
			return default(bool);
		}

		public bool IsCurrentInputSource(int actionId, ControllerType controllerType, int controllerId)
		{
			return default(bool);
		}

		public bool IsCurrentInputSource(string actionName, Controller controller)
		{
			return default(bool);
		}

		public bool IsCurrentInputSource(int actionId, Controller controller)
		{
			return default(bool);
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, object[] arguments)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments)
		{
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName, object[] arguments)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, int actionId)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, string actionName)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, int actionId)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, string actionName)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId)
		{
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName)
		{
		}

		public void ClearInputEventDelegates()
		{
		}

		public void SetVibration(int motorIndex, float motorLevel)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
		}

		public float GetVibration(int motorIndex)
		{
			return default(float);
		}

		public void StopVibration()
		{
		}

		internal void SmPrdLxmfnoOLIRlFAKVSpooigo()
		{
		}

		private void ItdhavHGXcUkAhyjaCFbIXENJheh()
		{
		}
	}
}
