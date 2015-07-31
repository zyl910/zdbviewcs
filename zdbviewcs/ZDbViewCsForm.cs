using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace zdbviewcs {
	/// <summary>
	/// zyl910's Database viewer (C#) (C#版数据库查看器).
	/// </summary>
	public partial class ZDbViewCsForm : Form {
		/// <summary>
		/// 当前数据库提供者.
		/// </summary>
		private DbProviderFactory m_provider = null;

		/// <summary>
		/// 当前数据库连接.
		/// </summary>
		private DbConnection m_conn = null;

		/// <summary>
		/// 当前表名.
		/// </summary>
		private string m_CurTableName = null;

		/// <summary>
		/// 当前弹出菜单所关联的网格控件.
		/// </summary>
		private DataGridView m_CurPopupGrid = null;

		/// <summary>
		/// 将数据表转为xml.
		/// </summary>
		/// <param name="xmlDS"></param>
		/// <returns></returns>
		private string ConvertDataTableToXML(DataTable xmlDS) {
			MemoryStream stream = null;
			XmlTextWriter writer = null;
			try {
				stream = new MemoryStream();
				writer = new XmlTextWriter(stream, Encoding.UTF8);
				writer.Formatting = Formatting.Indented;
				xmlDS.WriteXml(writer);
				int count = (int)stream.Length;
				byte[] arr = new byte[count];
				stream.Seek(0, SeekOrigin.Begin);
				stream.Read(arr, 0, count);
				UTF8Encoding utf = new UTF8Encoding();
				return utf.GetString(arr).Trim();
			}
			catch {
				return String.Empty;
			}
			finally {
				if (writer != null) writer.Close();
			}
		}

		/// <summary>
		/// 输出日志.
		/// </summary>
		/// <param name="s">日志文本.</param>
		public void OutLog(string s) {
			if (txtLog.Lines.Length > 3000) txtLog.Clear();
			txtLog.Select(txtLog.Text.Length, 0);
			txtLog.SelectedText = s + Environment.NewLine;
			txtLog.Select(txtLog.Text.Length, 0);
		}

		/// <summary>
		/// 显示数据表信息.
		/// </summary>
		/// <param name="tablename">表名</param>
		/// <returns></returns>
		private bool DoShowTableInfo(string tablename) {
			bool rt = false;
			if (null==tablename) return rt;
			try {
				this.Cursor = Cursors.WaitCursor;
				// 数据.
				int iwork = cboClickCmd.SelectedIndex;
				string ssql = null;
				if (1 == iwork) {
					ssql = string.Format("select * from {0}", tablename);
				}
				else if (2 == iwork) {
					ssql = string.Format("select count(*) as cnt from {0}", tablename);
				}
				if (!string.IsNullOrEmpty(ssql)) {
					txtSql.Text = ssql;
					btnExec_Click(btnExec, null);
				}
			}
			finally {
				this.Cursor = Cursors.Default;
				//Application.UseWaitCursor = false;
			}
			// done.
			rt = true;
			return rt;
		}

		public ZDbViewCsForm() {
			InitializeComponent();
		}

		private void mnuPopupProviderRefresh_Click(object sender, EventArgs e) {
			// 刷新提供者列表.
			DataTable dt = DbProviderFactories.GetFactoryClasses();
			OutLog(ConvertDataTableToXML(dt));
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
			cboClickCmd.SelectedIndex = 1;
			mnuPopupProviderRefresh_Click(mnuPopupProviderRefresh, null);
		}

		private void btnOpen_Click(object sender, EventArgs e) {
			btnClose_Click(sender, null);
			// main.
			string sFactory = cboProvider.Text.Trim();
			try {
				m_provider = DbProviderFactories.GetFactory(sFactory);
			}
			catch (Exception ex) {
				OutLog(ex.Message);
				MessageBox.Show(this, ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (null == m_provider) return;
			try {
				// DbConnection.
				try {
					OutLog("Create DbConnection:");
					m_conn = m_provider.CreateConnection();
					OutLog(string.Format("\t{0}", m_conn.GetType().ToString()));
				}
				catch (Exception ex) {
					OutLog(ex.Message);
					MessageBox.Show(this, ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					try {
						m_conn.Dispose();
					}
					catch (Exception ex2) {
						OutLog(ex2.ToString());
					}
					m_conn = null;
					return;
				}
				if (null == m_conn) return;
				// open.
				try {
					m_conn.ConnectionString = txtConnstr.Text.Trim();
					m_conn.Open();
				}
				catch (Exception ex) {
					OutLog(ex.Message);
					MessageBox.Show(this, ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
					try {
						m_conn.Dispose();
					}
					catch (Exception ex2) {
						OutLog(ex2.ToString());
					}
					m_conn = null;
					return;
				}
			}
			finally {
				if (null == m_conn) {
					m_provider = null;
				}
			}
			// done.
			bool isconn = true;
			btnOpen.Enabled = !isconn;
			btnClose.Enabled = isconn;
			btnExec.Enabled = isconn;
			cboProvider.Enabled = !isconn;
			txtConnstr.ReadOnly = isconn;
			OutLog("Db opened.");
			// show tables.
			DataTable dt = m_conn.GetSchema("Tables");
			grdTable.DataSource = dt;
			m_CurTableName = null;
			tbcInput.SelectedIndex = 1;
		}

		private void btnClose_Click(object sender, EventArgs e) {
			m_provider = null;
			if (null == m_conn) return;
			try {
				m_conn.Close();
				m_conn.Dispose();
			}
			catch (Exception ex) {
				OutLog(ex.ToString());
			}
			m_conn = null;
			// done.
			bool isconn = false;
			btnOpen.Enabled = !isconn;
			btnClose.Enabled = isconn;
			btnExec.Enabled = isconn;
			cboProvider.Enabled = !isconn;
			txtConnstr.ReadOnly = isconn;
			OutLog("Db closed.");
			grdTable.DataSource = null;
			grdGetSchema.DataSource = null;
			grdData.DataSource = null;
			grdDataSchema.DataSource = null;
			m_CurTableName = null;
		}

		private void btnExec_Click(object sender, EventArgs e) {
			if (null == m_conn) return;
			string ssql = txtSql.Text;
			if (string.IsNullOrEmpty(ssql)) return;
			int nlimit;
			if (!int.TryParse(txtLimit.Text, out nlimit)) nlimit = 0;
			OutLog(ssql);
			try {
				grdData.DataSource = null;
				using (DbCommand cmd = m_conn.CreateCommand()) {
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = ssql;
					using(DbDataAdapter dta = m_provider.CreateDataAdapter()) {
						dta.SelectCommand = cmd;
						DataSet dts = new DataSet();
						if (nlimit > 0) {
							dta.Fill(dts, 0, nlimit, "Table");
						}
						else {
							dta.Fill(dts);
						}
						grdData.DataSource = dts.Tables[0];
						//DataSet dts2 = new DataSet();
						//dta.FillSchema(dts2, SchemaType.Mapped);
						//grdDataSchema.DataSource = dts2.Tables[0];
						//DataTable dtt = new DataTable();
						//dta.FillSchema(dtt, SchemaType.Source);
						//grdDataSchema.DataSource = dtt;
					}
					using (DbDataReader dr = cmd.ExecuteReader()) {
						DataTable dtt = dr.GetSchemaTable();
						grdDataSchema.DataSource = dtt;
					}
				}
			}
			catch (Exception ex) {
				OutLog(ex.ToString());
			}
		}

		private void ZDbViewCsForm_FormClosed(object sender, FormClosedEventArgs e) {
			if (null != m_conn) {
				try {
					m_conn.Close();
				}
				catch (Exception ex) {
					Trace.TraceError(ex.ToString());
				}
				m_conn = null;
			}
			m_provider = null;
		}

		private void grdTable_CurrentCellChanged(object sender, EventArgs e) {
			string stable = null;
			try {
				if (null == grdTable.CurrentRow) return;
				stable = grdTable.CurrentRow.Cells["TABLE_NAME"].Value.ToString();
			}
			catch (Exception ex) {
				OutLog(ex.Message);
				return;
			}
			if (string.IsNullOrEmpty(stable)) return;
			if (stable.Equals(m_CurTableName)) return;
			m_CurTableName = stable;
			Trace.TraceInformation("Current table: {0}", m_CurTableName);
			DoShowTableInfo(m_CurTableName);
		}

		private void grdData_DataError(object sender, DataGridViewDataErrorEventArgs e) {
			e.Cancel = true;
			Trace.TraceWarning("{0}, {1}: {2}", e.RowIndex, e.ColumnIndex, e.Exception.ToString());
			OutLog(string.Format("{0}, {1}: {2}", e.RowIndex, e.ColumnIndex, e.Exception.Message));
		}

		private void mnuGridCopyValue_Click(object sender, EventArgs e) {
			DataGridView grd = mnuGrid.SourceControl as DataGridView;
			if (null == grd) return;
			if (grd.RowCount <= 0) return;
			//DataTable dtt = grd.DataSource as DataTable;
			//if (null == dtt) return;
			// make.
			StringBuilder sb = new StringBuilder();
			//DataGridViewSelectedColumnCollection dgvscs = grd.SelectedColumns;	// 只有整列选择时，才会在 SelectedColumns属性中.
			//foreach (DataGridViewRow dgvr in grd.SelectedRows) {
			//    if (sb.Length > 0) sb.AppendLine();
			//    for (int i = 0; i < dgvscs.Count - 1; ++i) {
			//        string s = string.Empty;
			//        DataGridViewColumn dgvc = dgvscs[i];
			//        DataGridViewCell dgve = dgvr.Cells[dgvc.Index];
			//        if (dgve.Selected) {
			//            if (null != dgve.Value) s = dgve.Value.ToString();
			//        }
			//        //
			//        if (i>0) sb.Append('\t');
			//        sb.Append(s);
			//    }
			//}
			foreach (DataGridViewCell dgve in grd.SelectedCells) {
				if (sb.Length > 0) sb.AppendLine();
				if (null == dgve) continue;
				sb.Append(dgve.Value.ToString());
			}
			// Clipboard.
			Clipboard.Clear();
			if (sb.Length>0)
				Clipboard.SetText(sb.ToString());
		}

		private void mnuGridCopyRow_Click(object sender, EventArgs e) {
			DataGridView grd = mnuGrid.SourceControl as DataGridView;
			if (null == grd) return;
			if (grd.RowCount <= 0) return;
			// make.
			StringBuilder sb = new StringBuilder();
			try {
				// columns.
				int i = 0;
				foreach (DataGridViewColumn dgvc in grd.Columns) {
					if (i > 0) sb.Append('\t');
					sb.Append(dgvc.HeaderText);
					// next.
					++i;
				}
				sb.AppendLine();
				if (grd.SelectedRows.Count > 0) {
					// 当行选时，使用行选信息.
					foreach (DataGridViewRow dgvr in grd.SelectedRows) {
						i = 0;
						foreach (DataGridViewCell dgve in dgvr.Cells) {
							if (i > 0) sb.Append('\t');
							if (null != dgve.Value)
								sb.Append(dgve.Value.ToString());
							// next.
							++i;
						}
						sb.AppendLine();
					}
				}
				else {
					// 否则使用单元格选择信息.
					// 计算已选的行.
					SortedList<int, string> rowindexs = new SortedList<int, string>();
					foreach (DataGridViewCell dgve in grd.SelectedCells) {
						int row = dgve.RowIndex;
						rowindexs.Add(row, null);
					}
					// data.
					foreach (int row in rowindexs.Keys) {
						DataGridViewRow dgvr = grd.Rows[row];
						i = 0;
						foreach (DataGridViewCell dgve in dgvr.Cells) {
							if (i > 0) sb.Append('\t');
							if (null != dgve.Value)
								sb.Append(dgve.Value.ToString());
							// next.
							++i;
						}
						sb.AppendLine();
					}
				}
			}
			catch (Exception ex) {
				Trace.TraceError(ex.ToString());
				OutLog(ex.Message);
			}
			// Clipboard.
			Clipboard.Clear();
			if (sb.Length > 0)
				Clipboard.SetText(sb.ToString());
		}

		private void mnuGridCopyTable_Click(object sender, EventArgs e) {
			//
		}

		private void mnuGridCopyTableXml_Click(object sender, EventArgs e) {
			DataGridView grd = mnuGrid.SourceControl as DataGridView;
			if (null == grd) return;
			if (grd.RowCount <= 0) return;
			DataTable dtt = grd.DataSource as DataTable;
			if (null == dtt) return;
			// make.
			string sb = ConvertDataTableToXML(dtt);
			// Clipboard.
			Clipboard.Clear();
			if (!string.IsNullOrEmpty(sb))
				Clipboard.SetText(sb);
		}

		private void mnuGridExportTable_Click(object sender, EventArgs e) {
			DataGridView grd = mnuGrid.SourceControl as DataGridView;
			if (null == grd) return;
			if (grd.RowCount <= 0) return;
			DataTable dtt = grd.DataSource as DataTable;
			if (null == dtt) return;
			// file.
			if (dlgSave.ShowDialog(this)!= DialogResult.OK) return;
			using(FileStream stm = new FileStream(dlgSave.FileName, FileMode.Create)) {
				XmlTextWriter writer = new XmlTextWriter(stm, Encoding.UTF8);
				writer.Formatting = Formatting.Indented;
				writer.WriteStartDocument();
				dtt.WriteXml(writer);
				writer.WriteEndDocument();
			}
		}

		private void mnuGrid_Opening(object sender, CancelEventArgs e) {
			DataGridView grd = mnuGrid.SourceControl as DataGridView;
			if (null == grd) return;
			//e.Cancel = (null==grd.DataSource);
		}

		private void btnGetSchema_Click(object sender, EventArgs e) {
			if (null == m_conn) return;
			DataGridView grd = grdGetSchema;
			String s = cboGetSchema.Text.Trim();
			DataTable dt = null;
			if (!String.IsNullOrEmpty(s)) {
				try {
					dt = m_conn.GetSchema(s);
				} catch (Exception ex) {
					MessageBox.Show(this, ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			grd.DataSource = dt;
		}

	}
}