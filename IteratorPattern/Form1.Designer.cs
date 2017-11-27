namespace IteratorPattern
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.m_lbMembers = new System.Windows.Forms.ListBox();
			this.m_ToolTips = new System.Windows.Forms.ToolTip(this.components);
			this.m_cbChristmas = new System.Windows.Forms.CheckBox();
			this.m_cbPigRoast = new System.Windows.Forms.CheckBox();
			this.m_cbFamily = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Members";
			// 
			// m_lbMembers
			// 
			this.m_lbMembers.FormattingEnabled = true;
			this.m_lbMembers.Location = new System.Drawing.Point(13, 30);
			this.m_lbMembers.Name = "m_lbMembers";
			this.m_lbMembers.Size = new System.Drawing.Size(242, 381);
			this.m_lbMembers.TabIndex = 1;
			this.m_ToolTips.SetToolTip(this.m_lbMembers, "Those who are members of any selected list.");
			// 
			// m_cbChristmas
			// 
			this.m_cbChristmas.AutoSize = true;
			this.m_cbChristmas.Location = new System.Drawing.Point(282, 68);
			this.m_cbChristmas.Name = "m_cbChristmas";
			this.m_cbChristmas.Size = new System.Drawing.Size(71, 17);
			this.m_cbChristmas.TabIndex = 2;
			this.m_cbChristmas.Text = "Christmas";
			this.m_cbChristmas.UseVisualStyleBackColor = true;
			this.m_cbChristmas.CheckedChanged += new System.EventHandler(this.m_cbChristmas_CheckedChanged);
			// 
			// m_cbPigRoast
			// 
			this.m_cbPigRoast.AutoSize = true;
			this.m_cbPigRoast.Location = new System.Drawing.Point(282, 91);
			this.m_cbPigRoast.Name = "m_cbPigRoast";
			this.m_cbPigRoast.Size = new System.Drawing.Size(72, 17);
			this.m_cbPigRoast.TabIndex = 2;
			this.m_cbPigRoast.Text = "Pig Roast";
			this.m_cbPigRoast.UseVisualStyleBackColor = true;
			this.m_cbPigRoast.CheckedChanged += new System.EventHandler(this.m_cbPigRoast_CheckedChanged);
			// 
			// m_cbFamily
			// 
			this.m_cbFamily.AutoSize = true;
			this.m_cbFamily.Location = new System.Drawing.Point(282, 114);
			this.m_cbFamily.Name = "m_cbFamily";
			this.m_cbFamily.Size = new System.Drawing.Size(55, 17);
			this.m_cbFamily.TabIndex = 2;
			this.m_cbFamily.Text = "Family";
			this.m_cbFamily.UseVisualStyleBackColor = true;
			this.m_cbFamily.CheckedChanged += new System.EventHandler(this.m_cbFamily_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 446);
			this.Controls.Add(this.m_cbFamily);
			this.Controls.Add(this.m_cbPigRoast);
			this.Controls.Add(this.m_cbChristmas);
			this.Controls.Add(this.m_lbMembers);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mailing Lists";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox m_lbMembers;
    private System.Windows.Forms.ToolTip m_ToolTips;
    private System.Windows.Forms.CheckBox m_cbChristmas;
    private System.Windows.Forms.CheckBox m_cbPigRoast;
    private System.Windows.Forms.CheckBox m_cbFamily;
  }
}

