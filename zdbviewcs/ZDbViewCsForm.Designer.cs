namespace zdbviewcs {
	partial class ZDbViewCsForm {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.spcTool = new System.Windows.Forms.SplitContainer();
			this.tbcInput = new System.Windows.Forms.TabControl();
			this.tbpConnstr = new System.Windows.Forms.TabPage();
			this.txtConnstr = new System.Windows.Forms.TextBox();
			this.tbpSql = new System.Windows.Forms.TabPage();
			this.txtSql = new System.Windows.Forms.TextBox();
			this.pnlTool = new System.Windows.Forms.Panel();
			this.cboProvider = new System.Windows.Forms.ComboBox();
			this.lblProvider = new System.Windows.Forms.Label();
			this.mnuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuPopupProviderRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.spcList = new System.Windows.Forms.SplitContainer();
			this.tbcList = new System.Windows.Forms.TabControl();
			this.tbpList = new System.Windows.Forms.TabPage();
			this.tbpListLog = new System.Windows.Forms.TabPage();
			this.txtListLog = new System.Windows.Forms.TextBox();
			this.tbcGrid = new System.Windows.Forms.TabControl();
			this.tbpGrid = new System.Windows.Forms.TabPage();
			this.tbpGridLog = new System.Windows.Forms.TabPage();
			this.txtGridLog = new System.Windows.Forms.TextBox();
			this.tbpLog = new System.Windows.Forms.TabPage();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.cboClickCmd = new System.Windows.Forms.ComboBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtLimit = new System.Windows.Forms.TextBox();
			this.btnExec = new System.Windows.Forms.Button();
			this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
			this.spcTool.Panel1.SuspendLayout();
			this.spcTool.Panel2.SuspendLayout();
			this.spcTool.SuspendLayout();
			this.tbcInput.SuspendLayout();
			this.tbpConnstr.SuspendLayout();
			this.tbpSql.SuspendLayout();
			this.pnlTool.SuspendLayout();
			this.mnuPopup.SuspendLayout();
			this.spcList.Panel1.SuspendLayout();
			this.spcList.Panel2.SuspendLayout();
			this.spcList.SuspendLayout();
			this.tbcList.SuspendLayout();
			this.tbpListLog.SuspendLayout();
			this.tbcGrid.SuspendLayout();
			this.tbpGridLog.SuspendLayout();
			this.tbpLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// spcTool
			// 
			this.spcTool.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcTool.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcTool.Location = new System.Drawing.Point(0, 0);
			this.spcTool.Name = "spcTool";
			this.spcTool.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spcTool.Panel1
			// 
			this.spcTool.Panel1.Controls.Add(this.tbcInput);
			this.spcTool.Panel1.Controls.Add(this.pnlTool);
			// 
			// spcTool.Panel2
			// 
			this.spcTool.Panel2.Controls.Add(this.spcList);
			this.spcTool.Size = new System.Drawing.Size(584, 362);
			this.spcTool.SplitterDistance = 100;
			this.spcTool.TabIndex = 0;
			// 
			// tbcInput
			// 
			this.tbcInput.Controls.Add(this.tbpConnstr);
			this.tbcInput.Controls.Add(this.tbpSql);
			this.tbcInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcInput.Location = new System.Drawing.Point(0, 28);
			this.tbcInput.Name = "tbcInput";
			this.tbcInput.SelectedIndex = 0;
			this.tbcInput.Size = new System.Drawing.Size(584, 72);
			this.tbcInput.TabIndex = 1;
			// 
			// tbpConnstr
			// 
			this.tbpConnstr.Controls.Add(this.txtConnstr);
			this.tbpConnstr.Location = new System.Drawing.Point(4, 22);
			this.tbpConnstr.Name = "tbpConnstr";
			this.tbpConnstr.Padding = new System.Windows.Forms.Padding(3);
			this.tbpConnstr.Size = new System.Drawing.Size(576, 46);
			this.tbpConnstr.TabIndex = 0;
			this.tbpConnstr.Text = "ConnectionString";
			this.tbpConnstr.UseVisualStyleBackColor = true;
			// 
			// txtConnstr
			// 
			this.txtConnstr.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtConnstr.Location = new System.Drawing.Point(3, 3);
			this.txtConnstr.Multiline = true;
			this.txtConnstr.Name = "txtConnstr";
			this.txtConnstr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConnstr.Size = new System.Drawing.Size(570, 40);
			this.txtConnstr.TabIndex = 0;
			// 
			// tbpSql
			// 
			this.tbpSql.Controls.Add(this.txtSql);
			this.tbpSql.Location = new System.Drawing.Point(4, 22);
			this.tbpSql.Name = "tbpSql";
			this.tbpSql.Padding = new System.Windows.Forms.Padding(3);
			this.tbpSql.Size = new System.Drawing.Size(576, 34);
			this.tbpSql.TabIndex = 1;
			this.tbpSql.Text = "SQL";
			this.tbpSql.UseVisualStyleBackColor = true;
			// 
			// txtSql
			// 
			this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSql.Location = new System.Drawing.Point(3, 3);
			this.txtSql.Multiline = true;
			this.txtSql.Name = "txtSql";
			this.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtSql.Size = new System.Drawing.Size(570, 28);
			this.txtSql.TabIndex = 1;
			// 
			// pnlTool
			// 
			this.pnlTool.Controls.Add(this.btnExec);
			this.pnlTool.Controls.Add(this.txtLimit);
			this.pnlTool.Controls.Add(this.btnClose);
			this.pnlTool.Controls.Add(this.btnOpen);
			this.pnlTool.Controls.Add(this.cboProvider);
			this.pnlTool.Controls.Add(this.lblProvider);
			this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTool.Location = new System.Drawing.Point(0, 0);
			this.pnlTool.Name = "pnlTool";
			this.pnlTool.Size = new System.Drawing.Size(584, 28);
			this.pnlTool.TabIndex = 0;
			// 
			// cboProvider
			// 
			this.cboProvider.FormattingEnabled = true;
			this.cboProvider.Location = new System.Drawing.Point(68, 3);
			this.cboProvider.Name = "cboProvider";
			this.cboProvider.Size = new System.Drawing.Size(240, 20);
			this.cboProvider.TabIndex = 1;
			// 
			// lblProvider
			// 
			this.lblProvider.AutoSize = true;
			this.lblProvider.ContextMenuStrip = this.mnuPopup;
			this.lblProvider.Location = new System.Drawing.Point(3, 6);
			this.lblProvider.Name = "lblProvider";
			this.lblProvider.Size = new System.Drawing.Size(59, 12);
			this.lblProvider.TabIndex = 0;
			this.lblProvider.Text = "&Provider:";
			// 
			// mnuPopup
			// 
			this.mnuPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPopupProviderRefresh});
			this.mnuPopup.Name = "mnuPopup";
			this.mnuPopup.Size = new System.Drawing.Size(171, 26);
			// 
			// mnuPopupProviderRefresh
			// 
			this.mnuPopupProviderRefresh.Name = "mnuPopupProviderRefresh";
			this.mnuPopupProviderRefresh.Size = new System.Drawing.Size(170, 22);
			this.mnuPopupProviderRefresh.Text = "Provider refresh";
			this.mnuPopupProviderRefresh.Click += new System.EventHandler(this.mnuPopupProviderRefresh_Click);
			// 
			// spcList
			// 
			this.spcList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcList.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcList.Location = new System.Drawing.Point(0, 0);
			this.spcList.Name = "spcList";
			// 
			// spcList.Panel1
			// 
			this.spcList.Panel1.Controls.Add(this.cboClickCmd);
			this.spcList.Panel1.Controls.Add(this.tbcList);
			// 
			// spcList.Panel2
			// 
			this.spcList.Panel2.Controls.Add(this.tbcGrid);
			this.spcList.Size = new System.Drawing.Size(584, 258);
			this.spcList.SplitterDistance = 300;
			this.spcList.TabIndex = 0;
			// 
			// tbcList
			// 
			this.tbcList.Controls.Add(this.tbpList);
			this.tbcList.Controls.Add(this.tbpListLog);
			this.tbcList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcList.Location = new System.Drawing.Point(0, 0);
			this.tbcList.Name = "tbcList";
			this.tbcList.SelectedIndex = 0;
			this.tbcList.Size = new System.Drawing.Size(300, 258);
			this.tbcList.TabIndex = 0;
			// 
			// tbpList
			// 
			this.tbpList.Location = new System.Drawing.Point(4, 22);
			this.tbpList.Name = "tbpList";
			this.tbpList.Padding = new System.Windows.Forms.Padding(3);
			this.tbpList.Size = new System.Drawing.Size(292, 232);
			this.tbpList.TabIndex = 0;
			this.tbpList.Text = "List";
			this.tbpList.UseVisualStyleBackColor = true;
			// 
			// tbpListLog
			// 
			this.tbpListLog.Controls.Add(this.txtListLog);
			this.tbpListLog.Location = new System.Drawing.Point(4, 22);
			this.tbpListLog.Name = "tbpListLog";
			this.tbpListLog.Padding = new System.Windows.Forms.Padding(3);
			this.tbpListLog.Size = new System.Drawing.Size(292, 232);
			this.tbpListLog.TabIndex = 1;
			this.tbpListLog.Text = "ListLog";
			this.tbpListLog.UseVisualStyleBackColor = true;
			// 
			// txtListLog
			// 
			this.txtListLog.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtListLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtListLog.Location = new System.Drawing.Point(3, 3);
			this.txtListLog.Multiline = true;
			this.txtListLog.Name = "txtListLog";
			this.txtListLog.ReadOnly = true;
			this.txtListLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtListLog.Size = new System.Drawing.Size(286, 226);
			this.txtListLog.TabIndex = 1;
			this.txtListLog.WordWrap = false;
			// 
			// tbcGrid
			// 
			this.tbcGrid.Controls.Add(this.tbpGrid);
			this.tbcGrid.Controls.Add(this.tbpGridLog);
			this.tbcGrid.Controls.Add(this.tbpLog);
			this.tbcGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcGrid.Location = new System.Drawing.Point(0, 0);
			this.tbcGrid.Name = "tbcGrid";
			this.tbcGrid.SelectedIndex = 0;
			this.tbcGrid.Size = new System.Drawing.Size(280, 258);
			this.tbcGrid.TabIndex = 0;
			// 
			// tbpGrid
			// 
			this.tbpGrid.Location = new System.Drawing.Point(4, 22);
			this.tbpGrid.Name = "tbpGrid";
			this.tbpGrid.Padding = new System.Windows.Forms.Padding(3);
			this.tbpGrid.Size = new System.Drawing.Size(272, 232);
			this.tbpGrid.TabIndex = 0;
			this.tbpGrid.Text = "Grid";
			this.tbpGrid.UseVisualStyleBackColor = true;
			// 
			// tbpGridLog
			// 
			this.tbpGridLog.Controls.Add(this.txtGridLog);
			this.tbpGridLog.Location = new System.Drawing.Point(4, 22);
			this.tbpGridLog.Name = "tbpGridLog";
			this.tbpGridLog.Padding = new System.Windows.Forms.Padding(3);
			this.tbpGridLog.Size = new System.Drawing.Size(272, 232);
			this.tbpGridLog.TabIndex = 1;
			this.tbpGridLog.Text = "GridLog";
			this.tbpGridLog.UseVisualStyleBackColor = true;
			// 
			// txtGridLog
			// 
			this.txtGridLog.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtGridLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtGridLog.Location = new System.Drawing.Point(3, 3);
			this.txtGridLog.Multiline = true;
			this.txtGridLog.Name = "txtGridLog";
			this.txtGridLog.ReadOnly = true;
			this.txtGridLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGridLog.Size = new System.Drawing.Size(266, 226);
			this.txtGridLog.TabIndex = 2;
			this.txtGridLog.WordWrap = false;
			// 
			// tbpLog
			// 
			this.tbpLog.Controls.Add(this.txtLog);
			this.tbpLog.Location = new System.Drawing.Point(4, 22);
			this.tbpLog.Name = "tbpLog";
			this.tbpLog.Padding = new System.Windows.Forms.Padding(3);
			this.tbpLog.Size = new System.Drawing.Size(272, 232);
			this.tbpLog.TabIndex = 2;
			this.tbpLog.Text = "Log";
			this.tbpLog.UseVisualStyleBackColor = true;
			// 
			// txtLog
			// 
			this.txtLog.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtLog.Location = new System.Drawing.Point(3, 3);
			this.txtLog.Multiline = true;
			this.txtLog.Name = "txtLog";
			this.txtLog.ReadOnly = true;
			this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtLog.Size = new System.Drawing.Size(266, 226);
			this.txtLog.TabIndex = 3;
			this.txtLog.WordWrap = false;
			// 
			// cboClickCmd
			// 
			this.cboClickCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboClickCmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboClickCmd.FormattingEnabled = true;
			this.cboClickCmd.Items.AddRange(new object[] {
            "(None)",
            "select *",
            "select count(*)"});
			this.cboClickCmd.Location = new System.Drawing.Point(184, 0);
			this.cboClickCmd.Name = "cboClickCmd";
			this.cboClickCmd.Size = new System.Drawing.Size(114, 20);
			this.cboClickCmd.TabIndex = 1;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(314, 1);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(64, 23);
			this.btnOpen.TabIndex = 2;
			this.btnOpen.Text = "&Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnClose
			// 
			this.btnClose.Enabled = false;
			this.btnClose.Location = new System.Drawing.Point(384, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 23);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// txtLimit
			// 
			this.txtLimit.Location = new System.Drawing.Point(454, 3);
			this.txtLimit.Name = "txtLimit";
			this.txtLimit.Size = new System.Drawing.Size(48, 21);
			this.txtLimit.TabIndex = 4;
			this.txtLimit.Text = "1000";
			this.ttpMain.SetToolTip(this.txtLimit, "记录数限制. 若为0则表示不限制.");
			// 
			// btnExec
			// 
			this.btnExec.Enabled = false;
			this.btnExec.Location = new System.Drawing.Point(508, 1);
			this.btnExec.Name = "btnExec";
			this.btnExec.Size = new System.Drawing.Size(64, 23);
			this.btnExec.TabIndex = 5;
			this.btnExec.Text = "&Exec";
			this.btnExec.UseVisualStyleBackColor = true;
			this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
			// 
			// ZDbViewCsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 362);
			this.Controls.Add(this.spcTool);
			this.Name = "ZDbViewCsForm";
			this.Text = "zDbViewCs";
			this.Load += new System.EventHandler(this.ZDbViewCsForm_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZDbViewCsForm_FormClosed);
			this.spcTool.Panel1.ResumeLayout(false);
			this.spcTool.Panel2.ResumeLayout(false);
			this.spcTool.ResumeLayout(false);
			this.tbcInput.ResumeLayout(false);
			this.tbpConnstr.ResumeLayout(false);
			this.tbpConnstr.PerformLayout();
			this.tbpSql.ResumeLayout(false);
			this.tbpSql.PerformLayout();
			this.pnlTool.ResumeLayout(false);
			this.pnlTool.PerformLayout();
			this.mnuPopup.ResumeLayout(false);
			this.spcList.Panel1.ResumeLayout(false);
			this.spcList.Panel2.ResumeLayout(false);
			this.spcList.ResumeLayout(false);
			this.tbcList.ResumeLayout(false);
			this.tbpListLog.ResumeLayout(false);
			this.tbpListLog.PerformLayout();
			this.tbcGrid.ResumeLayout(false);
			this.tbpGridLog.ResumeLayout(false);
			this.tbpGridLog.PerformLayout();
			this.tbpLog.ResumeLayout(false);
			this.tbpLog.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer spcTool;
		private System.Windows.Forms.Panel pnlTool;
		private System.Windows.Forms.Label lblProvider;
		private System.Windows.Forms.ComboBox cboProvider;
		private System.Windows.Forms.ContextMenuStrip mnuPopup;
		private System.Windows.Forms.ToolStripMenuItem mnuPopupProviderRefresh;
		private System.Windows.Forms.TabControl tbcInput;
		private System.Windows.Forms.TabPage tbpConnstr;
		private System.Windows.Forms.TabPage tbpSql;
		private System.Windows.Forms.TextBox txtConnstr;
		private System.Windows.Forms.TextBox txtSql;
		private System.Windows.Forms.SplitContainer spcList;
		private System.Windows.Forms.TabControl tbcList;
		private System.Windows.Forms.TabPage tbpList;
		private System.Windows.Forms.TabPage tbpListLog;
		private System.Windows.Forms.TabControl tbcGrid;
		private System.Windows.Forms.TabPage tbpGrid;
		private System.Windows.Forms.TabPage tbpGridLog;
		private System.Windows.Forms.TextBox txtListLog;
		private System.Windows.Forms.TextBox txtGridLog;
		private System.Windows.Forms.TabPage tbpLog;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.ComboBox cboClickCmd;
		private System.Windows.Forms.TextBox txtLimit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnExec;
		private System.Windows.Forms.ToolTip ttpMain;
	}
}

