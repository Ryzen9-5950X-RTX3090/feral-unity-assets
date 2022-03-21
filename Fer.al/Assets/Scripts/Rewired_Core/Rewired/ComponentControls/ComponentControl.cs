using System;
using System.Collections;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class ComponentControl : MonoBehaviour, IComponentControl
	{
		private IComponentController _controller;

		[NonSerialized]
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf;

		[NonSerialized]
		private bool eWmIQnowqnQnKiVcsFDbGrDwNfz;

		private int _lastUpdateFrame;

		internal abstract bool hasController { get; }

		internal bool initialized
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal ComponentControl()
		{
		}

		public abstract void ClearValue();

		void IComponentControl.Update()
		{
		}

		[CustomObfuscation]
		internal virtual void Awake()
		{
		}

		[CustomObfuscation]
		internal virtual void Start()
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
		internal virtual void OnDestroy()
		{
		}

		[CustomObfuscation]
		internal virtual void OnValidate()
		{
		}

		[CustomObfuscation]
		internal virtual void OnCanvasGroupChanged()
		{
		}

		[CustomObfuscation]
		internal virtual void OnTransformParentChanged()
		{
		}

		[CustomObfuscation]
		internal virtual void OnDidApplyAnimationProperties()
		{
		}

		[CustomObfuscation]
		internal virtual void Reset()
		{
		}

		internal virtual void OnUpdate()
		{
		}

		internal virtual bool OnInitialize()
		{
			return default(bool);
		}

		internal virtual void WFAGIZjSiiMwzmaHWHrBHRQZFpHG()
		{
		}

		internal virtual void OnSubscribeEvents()
		{
		}

		internal virtual void OnUnsubscribeEvents()
		{
		}

		internal virtual void OnSetProperty()
		{
		}

		internal virtual void OnClear()
		{
		}

		internal virtual void FindEventHandlers()
		{
		}

		internal bool pZZsjZGxmnNFXfvvyEpNHpEJHxn()
		{
			return default(bool);
		}

		internal bool qLpKhZHHXXFrTNsbtDCudYkkOPzW()
		{
			return default(bool);
		}

		internal IComponentController LKaeclUBVOWnEmgeJcBnjqBnXI()
		{
			return null;
		}

		[CustomObfuscation]
		internal abstract IComponentController FindController();

		[CustomObfuscation]
		internal abstract Type GetRequiredControllerType();

		private IEnumerator YsYHCkAiAOXNcPmMSVGrvIeeXxW()
		{
			return null;
		}

		private void DeRyKKaIFeIgBBjcstmktRxedrNm()
		{
		}

		private bool GEgOhDhFWzlyUDjyMHeIcciCspI(bool P_0, bool P_1)
		{
			return default(bool);
		}

		private void LZtLIradkTZxeuvnkQoCvQBxNXr()
		{
		}

		private void ZGVHnXXDseHxZFDLQjcaXQZEgJG()
		{
		}
	}
}
