using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IteratorPattern
{
	public enum ListTypes { Christmas, PigRoast, Family }

	public partial class Form1 : Form
	{
		private List<Member> m_MemberList = new List<Member>();
		private List<ListTypes> m_ltl = new List<ListTypes>();

		MailingList ml;

		public Form1()
		{
			InitializeComponent();
			PopulateMemberList();

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
		private void m_cbPigRoast_CheckedChanged(object sender, EventArgs e)
		{
			CheckChanged();
		}

		private void m_cbFamily_CheckedChanged(object sender, EventArgs e)
		{
			CheckChanged();
		}

		private void m_cbChristmas_CheckedChanged(object sender, EventArgs e)
		{
			CheckChanged();
		}

		// CheckChanged creates a new MailingList that knows how to iterate through the 
		// lists checked.
		private void CheckChanged()
		{
			ml = new MailingList(m_MemberList, m_cbChristmas.Checked, m_cbPigRoast.Checked, m_cbFamily.Checked);
			PopulateListBox();
		}

		private void PopulateListBox()
		{
			m_lbMembers.Items.Clear();
			foreach (Member m in ml)
			{
				m_lbMembers.Items.Add(m.ToString());
			}
		}


	}
}

//  This Application's code is available at https://github.com/KayllenTutorials/Iterator-Pattern-Part-2.git
//  Copyright (C) 2017 Kayllen Company