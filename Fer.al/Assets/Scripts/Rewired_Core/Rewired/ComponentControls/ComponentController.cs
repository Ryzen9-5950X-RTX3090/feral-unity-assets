using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class ComponentController : MonoBehaviour, IRegistrar<IComponentControl>, IComponentController
	{
		[NonSerialized]
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf;

		[NonSerialized]
		private bool eWmIQnowqnQnKiVcsFDbGrDwNfz;

		private List<IComponentControl> _controls;

		internal bool initialized
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal ComponentController()
		{
		}

		[CustomObfuscation]
		internal virtual void Awake()
		{
		}

		[CustomObfuscation]
		internal virtual void Update()
		{
		}

		[CustomObfuscation]
		internal virtual void OnEnable()
		{
		}

		[CustomObfuscation]
		internal virtual void OnDisable()
		{
		}

		[CustomObfuscation]
		internal virtual void OnValidate()
		{
		}

		[CustomObfuscation]
		internal virtual void OnDestroy()
		{
		}

		internal virtual bool OnInitialize()
		{
			return default(bool);
		}

		internal virtual void OnSubscribeEvents()
		{
		}

		internal virtual void OnUnsubscribeEvents()
		{
		}

		void IRegistrar<IComponentControl>.Register(IComponentControl P_0)
		{
		}

		void IRegistrar<IComponentControl>.Deregister(IComponentControl P_0)
		{
		}

		public virtual void ClearControlValues()
		{
		}

		private void DeRyKKaIFeIgBBjcstmktRxedrNm()
		{
		}

		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ()
		{
		}

		private IEnumerator GTHIUozEeYqGuSBqusjhCpEyriq()
		{
			return null;
		}
	}
}
