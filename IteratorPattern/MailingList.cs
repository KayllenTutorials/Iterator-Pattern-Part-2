using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
	public enum ListTypes { Christmas, PigRoast, Family }

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
		private List<Member> m_MemberList = new List<Member>();
		private List<ListTypes> m_ltl = new List<ListTypes>();
		#endregion MailingList fields

		// The MailingList Constructor.  It creates a Mailing List that 
		// can be iterated through based on the lists that were indicated with the boolean
		// arguments.  Every time a different iteration is requested, a new MailingList object
		// is created. Keep in mind that the Member List is a different king of object
		// than the mailing list.
		public MailingList(bool OnChristmasList, bool OnPigroastList, bool OnFamilyList)
		{
			PopulateMemberList();
			if (OnChristmasList)
				m_ltl.Add(ListTypes.Christmas);
			if (OnPigroastList)
				m_ltl.Add(ListTypes.PigRoast);
			if (OnFamilyList)
				m_ltl.Add(ListTypes.Family);
		}

		// Just for this demo -- create the members of the Member List.  Normally, this data 
		// would come from a database or some other external source.
		private void PopulateMemberList()
		{
			// name, lists, christmas list, pigroast list, family list
			m_MemberList.Add(new Member("Dave", "(cPF)", false, true, true));
			m_MemberList.Add(new Member("Deb", "(CPF)", true, true, true));
			m_MemberList.Add(new Member("Terry", "(Cpf)", true, false, false));
			m_MemberList.Add(new Member("Brian", "(CPF)", true, true, true));
			m_MemberList.Add(new Member("Bob", "(CPf)", true, true, false));
			m_MemberList.Add(new Member("Jack", "(cpF)", false, false, true));
			m_MemberList.Add(new Member("Seven", "(cPf)", false, true, false));
		}
	}

	class MailingListEnum : IEnumerator<Member>
	{
		private List<Member> m_MemberList { get; set; }
		private List<ListTypes> m_ltl { get; set; }

		// MailingListEnum constructor -- builds a MailingListEnum object
		// that enumerates through those Members in m_MemberList that are 
		// in any of the Lists whose type is stored in m_ltl.  If the list 
		// changes after the enumerator is created, the enumerator's action
		// are no longer defined.
		public MailingListEnum(List<Member> memberList, List<ListTypes> ltl)
		{
			m_MemberList = memberList;
			m_ltl = ltl;
			Reset();
		}

		#region IEnumerator Members

		// m_CurrIndex -- indicates the current position in the list.  When
		// the list is initialized either through the use of the constructor
		// or via the Reset method, m_CurrIndex is set to -1.  The definition
		// of IEnumerator requires that the initial enumerated structure be 
		// positioned so that a call to MoveNext will make Current return
		// the first item in the list.
		private int m_CurrIndex;

		// Current refers to the current item in m_MemberList
		public Member Current
		{
			get { return m_MemberList[m_CurrIndex]; }
		}

		// System.Collections.IEnumerator.Current returns the value of the current object but 
		// since it is retrieved from Current above as a Member, the object returned from this
		// is also a Member if you want it to be.
		object System.Collections.IEnumerator.Current
		{
			get { return Current; }
		}


		// MoveNext -- moves to the next Member in the m_MemberList structure
		// that is on one of the lists specified in m_ltl
		public bool MoveNext()
		{
			m_CurrIndex++;
			if (m_CurrIndex >= m_MemberList.Count)
				return false;
			else
				while (m_CurrIndex < m_MemberList.Count)
				{
					foreach (ListTypes lt in m_ltl)
					{
						if (m_MemberList[m_CurrIndex].ltl.Contains(lt))
							return true;
					}
					m_CurrIndex++;
				}
			return false;
		}

		// Reset -- sets the current index so a call to MoveNext() will 
		// be on the first item in the requested iteration.
		public void Reset()
		{
			m_CurrIndex = -1;
		}

		#region IDisposable Members

		public void Dispose()
		{
			// This method is required but is not necessary in the iterator pattern
			// so it is left as a stub.  It helps the garbage collector in case
			// the members being iterated are complex.
		}

		#endregion IDisposable Members

		#endregion IEnumerator required methods

	}

}
