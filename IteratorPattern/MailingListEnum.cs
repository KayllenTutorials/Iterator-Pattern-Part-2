using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
	class MailingListEnum : IEnumerator<Member>
	{
		private List<Member> m_MemberList { get; set; }
		private List<ListTypes> m_ltl { get; set; }

		// MailingListEnum constructor -- builds a MailingListEnum object
		// that enumerates through those Members in m_MemberList that are 
		// in any of the Lists whose type is stored in m_ltl.  If the list 
		// changes after the enumerator is created, the enumerator's action
		// is no longer defined.
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
