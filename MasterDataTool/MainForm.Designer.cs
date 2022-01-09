
namespace MasterDataTool
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addNewData = new System.Windows.Forms.Button();
			this.addData = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
			this.dataGridView1.Location = new System.Drawing.Point(190, 89);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(397, 265);
			this.dataGridView1.TabIndex = 0;
			// 
			// name
			// 
			this.name.HeaderText = "名前";
			this.name.Name = "name";
			// 
			// addNewData
			// 
			this.addNewData.Location = new System.Drawing.Point(190, 51);
			this.addNewData.Name = "addNewData";
			this.addNewData.Size = new System.Drawing.Size(93, 32);
			this.addNewData.TabIndex = 1;
			this.addNewData.Text = "新規データ追加";
			this.addNewData.UseVisualStyleBackColor = true;
			this.addNewData.Click += new System.EventHandler(this.addNewData_Click);
			// 
			// addData
			// 
			this.addData.Location = new System.Drawing.Point(290, 51);
			this.addData.Name = "addData";
			this.addData.Size = new System.Drawing.Size(89, 32);
			this.addData.TabIndex = 2;
			this.addData.Text = "データ追加";
			this.addData.UseVisualStyleBackColor = true;
			this.addData.Click += new System.EventHandler(this.addData_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addData);
			this.Controls.Add(this.addNewData);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.Button addNewData;
		private System.Windows.Forms.Button addData;
	}
}

