using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public class JsonSerializerSettings
	{
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		internal static readonly StreamingContext DefaultContext;

		internal const Formatting DefaultFormatting = Formatting.None;

		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		internal const TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple;

		internal static readonly CultureInfo DefaultCulture;

		internal const bool DefaultCheckAdditionalContent = false;

		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		internal Formatting? _formatting;

		internal DateFormatHandling? _dateFormatHandling;

		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		internal DateParseHandling? _dateParseHandling;

		internal FloatFormatHandling? _floatFormatHandling;

		internal FloatParseHandling? _floatParseHandling;

		internal StringEscapeHandling? _stringEscapeHandling;

		internal CultureInfo _culture;

		internal bool? _checkAdditionalContent;

		internal int? _maxDepth;

		internal bool _maxDepthSet;

		internal string _dateFormatString;

		internal bool _dateFormatStringSet;

		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		internal DefaultValueHandling? _defaultValueHandling;

		internal PreserveReferencesHandling? _preserveReferencesHandling;

		internal NullValueHandling? _nullValueHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal MissingMemberHandling? _missingMemberHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal StreamingContext? _context;

		internal ConstructorHandling? _constructorHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal MetadataPropertyHandling? _metadataPropertyHandling;

		[CompilerGenerated]
		private IContractResolver <ContractResolver>k__BackingField;

		[CompilerGenerated]
		private IEqualityComparer <EqualityComparer>k__BackingField;

		[CompilerGenerated]
		private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField;

		[CompilerGenerated]
		private ITraceWriter <TraceWriter>k__BackingField;

		[CompilerGenerated]
		private ISerializationBinder <SerializationBinder>k__BackingField;

		[CompilerGenerated]
		private EventHandler<ErrorEventArgs> <Error>k__BackingField;

		public ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return default(ReferenceLoopHandling);
			}
			set
			{
			}
		}

		public MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return default(MissingMemberHandling);
			}
		}

		public ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return default(ObjectCreationHandling);
			}
		}

		public NullValueHandling NullValueHandling
		{
			get
			{
				return default(NullValueHandling);
			}
			set
			{
			}
		}

		public DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return default(DefaultValueHandling);
			}
		}

		public IList<JsonConverter> Converters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return default(PreserveReferencesHandling);
			}
		}

		public TypeNameHandling TypeNameHandling
		{
			get
			{
				return default(TypeNameHandling);
			}
		}

		public MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return default(MetadataPropertyHandling);
			}
		}

		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			get
			{
				return default(TypeNameAssemblyFormatHandling);
			}
		}

		public ConstructorHandling ConstructorHandling
		{
			get
			{
				return default(ConstructorHandling);
			}
		}

		public IContractResolver ContractResolver
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IEqualityComparer EqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ITraceWriter TraceWriter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ISerializationBinder SerializationBinder
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
		}

		public StringEscapeHandling StringEscapeHandling
		{
			set
			{
			}
		}

		static JsonSerializerSettings()
		{
		}

		[DebuggerStepThrough]
		public JsonSerializerSettings()
		{
		}
	}
}
