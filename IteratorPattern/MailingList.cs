using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
	// The MailingList class implements the IEnumerable<T> interface where T is the class Member.
	// The IEnumerable interface requires the implementation of a method called GetEnumerator().
	// An enumerator is an object that implements the iterator pattern on a collection according
	// to the GOF rules (or at least according to Microsoft's understanding of those rules).
	class MailingList : IEnumerable<Member>
	{
		// The requirements for IEnumerable<Member> 
		#region IEnumerable<Member> Members

	  // Returns a MailingListEnum object that knows it is iterating through
		// a collection of Members.  This is expected by the "foreach" statement
		// and is called when foreach executes.  This is the essence of the 
		// iterator pattern in the .NET Framework's implementation of "foreach" and
		// allows our code and collections to have all of the features available to
		// those that come with the .NET Framework.
		public IEnumerator<Member> GetEnumerator()
		{
			return new MailingListEnum(m_MemberList, m_ltl);
		}
		#endregion

		#region IEnumerable Members
		// Returns a System.Collections.IEnumerator that knows it is iterating through
		// a collection of Objects but since it calls GetEnumerator() above it is really
		// returning an enumerator that returns Member objects.
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion

		#region MailingList fields
		// A MailingList is 
		//   - a Member List 
		//   - a list of ListTypes values that determine which members will be 
		//     included in the enumeration (iteration).
		List<Member> m_MemberList;
		List<ListTypes> m_ltl;
		#endregion MailingList fields

		// The MailingList Constructor creates a Mailing List that 
		// can be iterated through based on the lists that were indicated with the boolean
		// arguments.  Every time a different iteration is required, a new MailingList object
		// must be created. Keep in mind that the Member List is a different kind of object
		// than the mailing list.
		public MailingList(List<Member> MemberList, bool OnChristmasList, bool OnPigroastList, bool OnFamilyList)
		{
			m_MemberList = MemberList;
			m_ltl = new List<ListTypes>();
			if (OnChristmasList)
				m_ltl.Add(ListTypes.Christmas);
			if (OnPigroastList)
				m_ltl.Add(ListTypes.PigRoast);
			if (OnFamilyList)
				m_ltl.Add(ListTypes.Family);
		}
	}
}
