using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zdbviewcs {
	/// <summary>
	/// zyl910's Database viewer (C#) (C#版数据库查看器).
	/// </summary>
	public partial class ZDbViewCsForm : Form {
		public ZDbViewCsForm() {
			InitializeComponent();
		}

		private void mnuPopupProviderRefresh_Click(object sender, EventArgs e) {
			// 刷新提供者列表.
			DataTable dt = DbProviderFactories.GetFactoryClasses();
			//OutLog(ConvertDataTableToXML(dt));
			// cboFactory.
			cboProvider.BeginUpdate();
			cboProvider.Items.Clear();
			try {
				foreach (DataRow dr in dt.Rows) {
					object s = dr["InvariantName"];
					cboProvider.Items.Add(s);
				}
			}
			finally {
				cboProvider.EndUpdate();
			}
		}

		private void ZDbViewCsForm_Load(object sender, EventArgs e) {
			mnuPopupProviderRefresh_Click(mnuPopupProviderRefresh, null);
		}

	}
}