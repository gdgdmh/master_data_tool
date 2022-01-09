using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDataTool
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			masterDataTable = null;
			InitializeComponent();
		}

		/// <summary>
		/// フォームのロードイベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			masterDataTable = dataGridView1;
		}

		/// <summary>
		/// 新規データ追加ボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addNewData_Click(object sender, EventArgs e)
		{
			// 追加
			// 将来的にはダイアログかなにかを出して入力させる
			masterDataTable.Columns.Add("columnName", "名称");
		}

		/// <summary>
		/// データ追加ボタン押下イベント
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void addData_Click(object sender, EventArgs e)
		{
			masterDataTable.Rows.Add();
		}

		private DataGridView masterDataTable; // テーブル

	}
}
