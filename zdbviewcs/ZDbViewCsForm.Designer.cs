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
			this.pnlTool = new System.Windows.Forms.Panel();
			this.lblProvider = new System.Windows.Forms.Label();
			this.cboProvider = new System.Windows.Forms.ComboBox();
			this.mnuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuPopupProviderRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.tbcInput = new System.Windows.Forms.TabControl();
			this.tbpConnstr = new System.Windows.Forms.TabPage();
			this.tbpSql = new System.Windows.Forms.TabPage();
			this.txtConnstr = new System.Windows.Forms.TextBox();
			this.txtSql = new System.Windows.Forms.TextBox();
			this.spcList = new System.Windows.Forms.SplitContainer();
			this.tbcList = new System.Windows.Forms.TabControl();
			this.tbpList = new System.Windows.Forms.TabPage();
			this.tbpListLog = new System.Windows.Forms.TabPage();
			this.tbcGrid = new System.Windows.Forms.TabControl();
			this.tbpGrid = new System.Windows.Forms.TabPage();
			this.tbpGridLog = new System.Windows.Forms.TabPage();
			this.txtListLog = new System.Windows.Forms.TextBox();
			this.txtGridLog = new System.Windows.Forms.TextBox();
			this.spcTool.Panel1.SuspendLayout();
			this.spcTool.Panel2.SuspendLayout();
			this.spcTool.SuspendLayout();
			this.pnlTool.SuspendLayout();
			this.mnuPopup.SuspendLayout();
			this.tbcInput.SuspendLayout();
			this.tbpConnstr.SuspendLayout();
			this.tbpSql.SuspendLayout();
			this.spcList.Panel1.SuspendLayout();
			this.spcList.Panel2.SuspendLayout();
			this.spcList.SuspendLayout();
			this.tbcList.SuspendLayout();
			this.tbpListLog.SuspendLayout();
			this.tbcGrid.SuspendLayout();
			this.tbpGridLog.SuspendLayout();
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
			// pnlTool
			// 
			this.pnlTool.Controls.Add(this.cboProvider);
			this.pnlTool.Controls.Add(this.lblProvider);
			this.pnlTool.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTool.Location = new System.Drawing.Point(0, 0);
			this.pnlTool.Name = "pnlTool";
			this.pnlTool.Size = new System.Drawing.Size(584, 40);
			this.pnlTool.TabIndex = 0;
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
			// cboProvider
			// 
			this.cboProvider.FormattingEnabled = true;
			this.cboProvider.Location = new System.Drawing.Point(68, 3);
			this.cboProvider.Name = "cboProvider";
			this.cboProvider.Size = new System.Drawing.Size(240, 20);
			this.cboProvider.TabIndex = 1;
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
			// tbcInput
			// 
			this.tbcInput.Controls.Add(this.tbpConnstr);
			this.tbcInput.Controls.Add(this.tbpSql);
			this.tbcInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcInput.Location = new System.Drawing.Point(0, 40);
			this.tbcInput.Name = "tbcInput";
			this.tbcInput.SelectedIndex = 0;
			this.tbcInput.Size = new System.Drawing.Size(584, 60);
			this.tbcInput.TabIndex = 1;
			// 
			// tbpConnstr
			// 
			this.tbpConnstr.Controls.Add(this.txtConnstr);
			this.tbpConnstr.Location = new System.Drawing.Point(4, 22);
			this.tbpConnstr.Name = "tbpConnstr";
			this.tbpConnstr.Padding = new System.Windows.Forms.Padding(3);
			this.tbpConnstr.Size = new System.Drawing.Size(576, 34);
			this.tbpConnstr.TabIndex = 0;
			this.tbpConnstr.Text = "ConnectionString";
			this.tbpConnstr.UseVisualStyleBackColor = true;
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
			// txtConnstr
			// 
			this.txtConnstr.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtConnstr.Location = new System.Drawing.Point(3, 3);
			this.txtConnstr.Multiline = true;
			this.txtConnstr.Name = "txtConnstr";
			this.txtConnstr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConnstr.Size = new System.Drawing.Size(570, 28);
			this.txtConnstr.TabIndex = 0;
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
			// spcList
			// 
			this.spcList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spcList.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.spcList.Location = new System.Drawing.Point(0, 0);
			this.spcList.Name = "spcList";
			// 
			// spcList.Panel1
			// 
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
			// tbcGrid
			// 
			this.tbcGrid.Controls.Add(this.tbpGrid);
			this.tbcGrid.Controls.Add(this.tbpGridLog);
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
			// txtListLog
			// 
			this.txtListLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtListLog.Location = new System.Drawing.Point(3, 3);
			this.txtListLog.Multiline = true;
			this.txtListLog.Name = "txtListLog";
			this.txtListLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtListLog.Size = new System.Drawing.Size(286, 226);
			this.txtListLog.TabIndex = 1;
			this.txtListLog.WordWrap = false;
			// 
			// txtGridLog
			// 
			this.txtGridLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtGridLog.Location = new System.Drawing.Point(3, 3);
			this.txtGridLog.Multiline = true;
			this.txtGridLog.Name = "txtGridLog";
			this.txtGridLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtGridLog.Size = new System.Drawing.Size(266, 226);
			this.txtGridLog.TabIndex = 2;
			this.txtGridLog.WordWrap = false;
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
			this.spcTool.Panel1.ResumeLayout(false);
			this.spcTool.Panel2.ResumeLayout(false);
			this.spcTool.ResumeLayout(false);
			this.pnlTool.ResumeLayout(false);
			this.pnlTool.PerformLayout();
			this.mnuPopup.ResumeLayout(false);
			this.tbcInput.ResumeLayout(false);
			this.tbpConnstr.ResumeLayout(false);
			this.tbpConnstr.PerformLayout();
			this.tbpSql.ResumeLayout(false);
			this.tbpSql.PerformLayout();
			this.spcList.Panel1.ResumeLayout(false);
			this.spcList.Panel2.ResumeLayout(false);
			this.spcList.ResumeLayout(false);
			this.tbcList.ResumeLayout(false);
			this.tbpListLog.ResumeLayout(false);
			this.tbpListLog.PerformLayout();
			this.tbcGrid.ResumeLayout(false);
			this.tbpGridLog.ResumeLayout(false);
			this.tbpGridLog.PerformLayout();
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
	}
}

