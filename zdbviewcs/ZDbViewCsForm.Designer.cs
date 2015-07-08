﻿namespace zdbviewcs {
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
			this.btnExec = new System.Windows.Forms.Button();
			this.txtLimit = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.cboProvider = new System.Windows.Forms.ComboBox();
			this.lblProvider = new System.Windows.Forms.Label();
			this.mnuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuPopupProviderRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.spcList = new System.Windows.Forms.SplitContainer();
			this.cboClickCmd = new System.Windows.Forms.ComboBox();
			this.tbcMain = new System.Windows.Forms.TabControl();
			this.tbpTable = new System.Windows.Forms.TabPage();
			this.tbpTableLog = new System.Windows.Forms.TabPage();
			this.txtTableLog = new System.Windows.Forms.TextBox();
			this.tbcGrid = new System.Windows.Forms.TabControl();
			this.tbpData = new System.Windows.Forms.TabPage();
			this.tbpDataLog = new System.Windows.Forms.TabPage();
			this.txtDataLog = new System.Windows.Forms.TextBox();
			this.tbpLog = new System.Windows.Forms.TabPage();
			this.txtLog = new System.Windows.Forms.TextBox();
			this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
			this.grdTable = new System.Windows.Forms.DataGridView();
			this.grdData = new System.Windows.Forms.DataGridView();
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
			this.tbcMain.SuspendLayout();
			this.tbpTable.SuspendLayout();
			this.tbpTableLog.SuspendLayout();
			this.tbcGrid.SuspendLayout();
			this.tbpData.SuspendLayout();
			this.tbpDataLog.SuspendLayout();
			this.tbpLog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
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
			this.tbcInput.Location = new System.Drawing.Point(0, 24);
			this.tbcInput.Name = "tbcInput";
			this.tbcInput.SelectedIndex = 0;
			this.tbcInput.Size = new System.Drawing.Size(584, 76);
			this.tbcInput.TabIndex = 1;
			// 
			// tbpConnstr
			// 
			this.tbpConnstr.Controls.Add(this.txtConnstr);
			this.tbpConnstr.Location = new System.Drawing.Point(4, 22);
			this.tbpConnstr.Name = "tbpConnstr";
			this.tbpConnstr.Padding = new System.Windows.Forms.Padding(3);
			this.tbpConnstr.Size = new System.Drawing.Size(576, 50);
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
			this.txtConnstr.Size = new System.Drawing.Size(570, 44);
			this.txtConnstr.TabIndex = 0;
			// 
			// tbpSql
			// 
			this.tbpSql.Controls.Add(this.txtSql);
			this.tbpSql.Location = new System.Drawing.Point(4, 22);
			this.tbpSql.Name = "tbpSql";
			this.tbpSql.Padding = new System.Windows.Forms.Padding(3);
			this.tbpSql.Size = new System.Drawing.Size(576, 46);
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
			this.txtSql.Size = new System.Drawing.Size(570, 40);
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
			this.pnlTool.Size = new System.Drawing.Size(584, 24);
			this.pnlTool.TabIndex = 0;
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
			// txtLimit
			// 
			this.txtLimit.Location = new System.Drawing.Point(454, 3);
			this.txtLimit.Name = "txtLimit";
			this.txtLimit.Size = new System.Drawing.Size(48, 21);
			this.txtLimit.TabIndex = 4;
			this.txtLimit.Text = "100";
			this.ttpMain.SetToolTip(this.txtLimit, "记录数限制. 若为0则表示不限制.");
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
			this.spcList.Panel1.Controls.Add(this.tbcMain);
			// 
			// spcList.Panel2
			// 
			this.spcList.Panel2.Controls.Add(this.tbcGrid);
			this.spcList.Size = new System.Drawing.Size(584, 258);
			this.spcList.SplitterDistance = 300;
			this.spcList.TabIndex = 0;
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
			// tbcMain
			// 
			this.tbcMain.Controls.Add(this.tbpTable);
			this.tbcMain.Controls.Add(this.tbpTableLog);
			this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcMain.Location = new System.Drawing.Point(0, 0);
			this.tbcMain.Name = "tbcMain";
			this.tbcMain.SelectedIndex = 0;
			this.tbcMain.Size = new System.Drawing.Size(300, 258);
			this.tbcMain.TabIndex = 0;
			// 
			// tbpTable
			// 
			this.tbpTable.Controls.Add(this.grdTable);
			this.tbpTable.Location = new System.Drawing.Point(4, 22);
			this.tbpTable.Name = "tbpTable";
			this.tbpTable.Padding = new System.Windows.Forms.Padding(3);
			this.tbpTable.Size = new System.Drawing.Size(292, 232);
			this.tbpTable.TabIndex = 0;
			this.tbpTable.Text = "Table";
			this.tbpTable.UseVisualStyleBackColor = true;
			// 
			// tbpTableLog
			// 
			this.tbpTableLog.Controls.Add(this.txtTableLog);
			this.tbpTableLog.Location = new System.Drawing.Point(4, 22);
			this.tbpTableLog.Name = "tbpTableLog";
			this.tbpTableLog.Padding = new System.Windows.Forms.Padding(3);
			this.tbpTableLog.Size = new System.Drawing.Size(292, 232);
			this.tbpTableLog.TabIndex = 1;
			this.tbpTableLog.Text = "TableLog";
			this.tbpTableLog.UseVisualStyleBackColor = true;
			// 
			// txtTableLog
			// 
			this.txtTableLog.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtTableLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTableLog.Location = new System.Drawing.Point(3, 3);
			this.txtTableLog.Multiline = true;
			this.txtTableLog.Name = "txtTableLog";
			this.txtTableLog.ReadOnly = true;
			this.txtTableLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtTableLog.Size = new System.Drawing.Size(286, 226);
			this.txtTableLog.TabIndex = 1;
			this.txtTableLog.WordWrap = false;
			// 
			// tbcGrid
			// 
			this.tbcGrid.Controls.Add(this.tbpData);
			this.tbcGrid.Controls.Add(this.tbpDataLog);
			this.tbcGrid.Controls.Add(this.tbpLog);
			this.tbcGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcGrid.Location = new System.Drawing.Point(0, 0);
			this.tbcGrid.Name = "tbcGrid";
			this.tbcGrid.SelectedIndex = 0;
			this.tbcGrid.Size = new System.Drawing.Size(280, 258);
			this.tbcGrid.TabIndex = 0;
			// 
			// tbpData
			// 
			this.tbpData.Controls.Add(this.grdData);
			this.tbpData.Location = new System.Drawing.Point(4, 22);
			this.tbpData.Name = "tbpData";
			this.tbpData.Padding = new System.Windows.Forms.Padding(3);
			this.tbpData.Size = new System.Drawing.Size(272, 232);
			this.tbpData.TabIndex = 0;
			this.tbpData.Text = "Data";
			this.tbpData.UseVisualStyleBackColor = true;
			// 
			// tbpDataLog
			// 
			this.tbpDataLog.Controls.Add(this.txtDataLog);
			this.tbpDataLog.Location = new System.Drawing.Point(4, 22);
			this.tbpDataLog.Name = "tbpDataLog";
			this.tbpDataLog.Padding = new System.Windows.Forms.Padding(3);
			this.tbpDataLog.Size = new System.Drawing.Size(272, 232);
			this.tbpDataLog.TabIndex = 1;
			this.tbpDataLog.Text = "DataLog";
			this.tbpDataLog.UseVisualStyleBackColor = true;
			// 
			// txtDataLog
			// 
			this.txtDataLog.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.txtDataLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDataLog.Location = new System.Drawing.Point(3, 3);
			this.txtDataLog.Multiline = true;
			this.txtDataLog.Name = "txtDataLog";
			this.txtDataLog.ReadOnly = true;
			this.txtDataLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDataLog.Size = new System.Drawing.Size(266, 226);
			this.txtDataLog.TabIndex = 2;
			this.txtDataLog.WordWrap = false;
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
			// grdTable
			// 
			this.grdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdTable.Location = new System.Drawing.Point(3, 3);
			this.grdTable.Name = "grdTable";
			this.grdTable.RowTemplate.Height = 23;
			this.grdTable.Size = new System.Drawing.Size(286, 226);
			this.grdTable.TabIndex = 0;
			this.grdTable.CurrentCellChanged += new System.EventHandler(this.grdTable_CurrentCellChanged);
			// 
			// grdData
			// 
			this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdData.Location = new System.Drawing.Point(3, 3);
			this.grdData.Name = "grdData";
			this.grdData.RowTemplate.Height = 23;
			this.grdData.Size = new System.Drawing.Size(266, 226);
			this.grdData.TabIndex = 1;
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
			this.tbcMain.ResumeLayout(false);
			this.tbpTable.ResumeLayout(false);
			this.tbpTableLog.ResumeLayout(false);
			this.tbpTableLog.PerformLayout();
			this.tbcGrid.ResumeLayout(false);
			this.tbpData.ResumeLayout(false);
			this.tbpDataLog.ResumeLayout(false);
			this.tbpDataLog.PerformLayout();
			this.tbpLog.ResumeLayout(false);
			this.tbpLog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
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
		private System.Windows.Forms.TabControl tbcMain;
		private System.Windows.Forms.TabPage tbpTable;
		private System.Windows.Forms.TabPage tbpTableLog;
		private System.Windows.Forms.TabControl tbcGrid;
		private System.Windows.Forms.TabPage tbpData;
		private System.Windows.Forms.TabPage tbpDataLog;
		private System.Windows.Forms.TextBox txtTableLog;
		private System.Windows.Forms.TextBox txtDataLog;
		private System.Windows.Forms.TabPage tbpLog;
		private System.Windows.Forms.TextBox txtLog;
		private System.Windows.Forms.ComboBox cboClickCmd;
		private System.Windows.Forms.TextBox txtLimit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnExec;
		private System.Windows.Forms.ToolTip ttpMain;
		private System.Windows.Forms.DataGridView grdTable;
		private System.Windows.Forms.DataGridView grdData;
	}
}

