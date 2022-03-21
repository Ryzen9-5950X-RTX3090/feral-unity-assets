using System;
using UnityEngine;

namespace Backtrace.Unity.Types
{
	[Flags]
	public enum ReportFilterType
	{
		[InspectorName("Disable")]
		[Tooltip("Disable report filtering.")]
		None = 0,
		[Tooltip("String message report.")]
		Message = 1,
		[InspectorName("Handled exception")]
		[Tooltip("Handled exception.")]
		Exception = 2,
		[InspectorName("Unhandled exception")]
		[Tooltip("Game unhandled exception.")]
		UnhandledException = 4,
		[Tooltip("Game hang.")]
		Hang = 8
	}
}
