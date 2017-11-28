using System.Collections.Generic;

namespace IteratorPattern
{
  class Member
  {
  
		// The member's name and a string that describes the lists the member
		// is included on.  This could also include the address and other
    // identifying information. 

    public string m_Name { get; set; }
		public string m_Lists { get; set; }

    // A list of ListTypes indicating the lists on which this
    // member is to be included. 
    public List<ListTypes> ltl = new List<ListTypes>();

		// The only constructor for Members.  Indicates the name as well 
		// the lists on which this member is to be included.
		public Member(string Name, string Lists, bool OnChristmasList, bool OnPigroastList, bool OnFamilyList)
    {
      m_Name = Name;
			m_Lists = Lists;
      if (OnChristmasList)
        ltl.Add(ListTypes.Christmas);
      if (OnPigroastList)
        ltl.Add(ListTypes.PigRoast);
      if (OnFamilyList)
        ltl.Add(ListTypes.Family);
    }

		public override string ToString()
		{
			return m_Name + "  " + m_Lists;
		}
	}
}
