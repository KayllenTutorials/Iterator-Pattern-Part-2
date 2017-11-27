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
	public partial class Form1 : Form
	{
		MailingList ml;

		public Form1()
		{
			InitializeComponent();
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
			ml = new MailingList(m_cbChristmas.Checked, m_cbPigRoast.Checked, m_cbFamily.Checked);
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
