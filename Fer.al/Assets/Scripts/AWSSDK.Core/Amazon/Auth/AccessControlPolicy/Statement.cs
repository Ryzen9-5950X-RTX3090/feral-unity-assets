using System.Collections.Generic;

namespace Amazon.Auth.AccessControlPolicy
{
	public class Statement
	{
		public enum StatementEffect
		{
			Allow,
			Deny
		}

		private string id;

		private StatementEffect effect;

		private IList<Principal> principals;

		private IList<ActionIdentifier> actions;

		private IList<Resource> resources;

		private IList<Condition> conditions;

		public string Id
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StatementEffect Effect
		{
			get
			{
				return default(StatementEffect);
			}
			set
			{
			}
		}

		public IList<ActionIdentifier> Actions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Resource> Resources
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Condition> Conditions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList<Principal> Principals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Statement(StatementEffect effect)
		{
		}

		public Statement WithId(string id)
		{
			return null;
		}

		public Statement WithActionIdentifiers(ActionIdentifier[] actions)
		{
			return null;
		}

		public Statement WithResources(Resource[] resources)
		{
			return null;
		}

		public Statement WithConditions(Condition[] conditions)
		{
			return null;
		}

		public Statement WithPrincipals(Principal[] principals)
		{
			return null;
		}
	}
}
