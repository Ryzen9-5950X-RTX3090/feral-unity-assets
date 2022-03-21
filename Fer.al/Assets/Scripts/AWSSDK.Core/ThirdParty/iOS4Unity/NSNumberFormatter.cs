using System;

namespace ThirdParty.iOS4Unity
{
	public class NSNumberFormatter : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public NSNumberFormatterBehavior FormatterBehavior
		{
			get
			{
				return default(NSNumberFormatterBehavior);
			}
			set
			{
			}
		}

		public bool AllowsFloats
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string CurrencyCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrencyDecimalSeparator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrencyGroupingSeparator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrencySymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DecimalSeparator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static NSNumberFormatterBehavior DefaultFormatterBehavior
		{
			get
			{
				return default(NSNumberFormatterBehavior);
			}
			set
			{
			}
		}

		public string ExponentSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[CLSCompliant(false)]
		public uint FormatWidth
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public bool GeneratesDecimalNumbers
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string GroupingSeparator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint GroupingSize
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public string InternationalCurrencySymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Lenient
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public NSLocale Locale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaximumFractionDigits
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int MaximumIntegerDigits
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public uint MaximumSignificantDigits
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public int MinimumFractionDigits
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int MinimumIntegerDigits
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public uint MinimumSignificantDigits
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public string MinusSign
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NegativeFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NegativeInfinitySymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NegativePrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NegativeSuffix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NilSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NotANumberSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NSNumberFormatterStyle NumberStyle
		{
			get
			{
				return default(NSNumberFormatterStyle);
			}
			set
			{
			}
		}

		public string PaddingCharacter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NSNumberFormatterPadPosition PaddingPosition
		{
			get
			{
				return default(NSNumberFormatterPadPosition);
			}
			set
			{
			}
		}

		public bool PartialStringValidationEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string PercentSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PerMillSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PlusSign
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PositiveFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PositiveInfinitySymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PositivePrefix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PositiveSuffix
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NSNumberFormatterRoundingMode RoundingMode
		{
			get
			{
				return default(NSNumberFormatterRoundingMode);
			}
			set
			{
			}
		}

		public uint SecondaryGroupingSize
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		public bool UsesGroupingSeparator
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool UsesSignificantDigits
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string ZeroSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static NSNumberFormatter()
		{
		}

		public NSNumberFormatter()
		{
		}

		internal NSNumberFormatter(IntPtr handle)
		{
		}

		public double NumberFromString(string text)
		{
			return default(double);
		}

		public string StringFromNumber(double number)
		{
			return null;
		}

		public static string LocalizedStringFromNumber(double number, NSNumberFormatterStyle style)
		{
			return null;
		}
	}
}
