/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: easylogic
 * 날짜: 2012-03-20
 * 시간: 오후 4:58
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
namespace PLinkCore
{
	partial class PolicyForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.textChange = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbType = new System.Windows.Forms.ComboBox();
			this.textPattern = new System.Windows.Forms.TextBox();
			this.textDesc = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.searchFolder = new System.Windows.Forms.Button();
			this.searchFile = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cbHttpStatus = new System.Windows.Forms.ComboBox();
			this.msgHttp = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.45059F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.54941F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textChange, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.cbType, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textPattern, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textDesc, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 171);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(5, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textChange
			// 
			this.textChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textChange.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textChange.Location = new System.Drawing.Point(67, 71);
			this.textChange.Name = "textChange";
			this.textChange.Size = new System.Drawing.Size(438, 21);
			this.textChange.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(5, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Before";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(5, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "After";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(5, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 35);
			this.label4.TabIndex = 3;
			this.label4.Text = "Desc";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbType
			// 
			this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbType.FormattingEnabled = true;
			this.cbType.Items.AddRange(new object[] {
									"HOST",
									"URL",
									"REAL",
									"PATTERN"});
			this.cbType.Location = new System.Drawing.Point(67, 5);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(121, 20);
			this.cbType.TabIndex = 1;
			// 
			// textPattern
			// 
			this.textPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPattern.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textPattern.Location = new System.Drawing.Point(67, 38);
			this.textPattern.Name = "textPattern";
			this.textPattern.Size = new System.Drawing.Size(438, 21);
			this.textPattern.TabIndex = 2;
			// 
			// textDesc
			// 
			this.textDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textDesc.Location = new System.Drawing.Point(67, 137);
			this.textDesc.Name = "textDesc";
			this.textDesc.Size = new System.Drawing.Size(438, 21);
			this.textDesc.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.searchFolder);
			this.flowLayoutPanel1.Controls.Add(this.searchFile);
			this.flowLayoutPanel1.Controls.Add(this.label5);
			this.flowLayoutPanel1.Controls.Add(this.cbHttpStatus);
			this.flowLayoutPanel1.Controls.Add(this.msgHttp);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 101);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(444, 33);
			this.flowLayoutPanel1.TabIndex = 9;
			// 
			// searchFolder
			// 
			this.searchFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchFolder.Location = new System.Drawing.Point(3, 3);
			this.searchFolder.Name = "searchFolder";
			this.searchFolder.Size = new System.Drawing.Size(85, 24);
			this.searchFolder.TabIndex = 5;
			this.searchFolder.Text = "Directory";
			this.searchFolder.UseVisualStyleBackColor = true;
			this.searchFolder.Click += new System.EventHandler(this.SearchBtnClick);
			// 
			// searchFile
			// 
			this.searchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchFile.Location = new System.Drawing.Point(94, 3);
			this.searchFile.Name = "searchFile";
			this.searchFile.Size = new System.Drawing.Size(75, 23);
			this.searchFile.TabIndex = 6;
			this.searchFile.Text = "File";
			this.searchFile.UseVisualStyleBackColor = true;
			this.searchFile.Click += new System.EventHandler(this.SearchFileClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(175, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 32);
			this.label5.TabIndex = 7;
			this.label5.Text = "HTTP : ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbHttpStatus
			// 
			this.cbHttpStatus.FormattingEnabled = true;
			this.cbHttpStatus.Items.AddRange(new object[] {
									"200",
									"404",
									"403",
									"500"});
			this.cbHttpStatus.Location = new System.Drawing.Point(254, 3);
			this.cbHttpStatus.Name = "cbHttpStatus";
			this.cbHttpStatus.Size = new System.Drawing.Size(66, 20);
			this.cbHttpStatus.TabIndex = 8;
			this.cbHttpStatus.SelectedIndexChanged += new System.EventHandler(this.CbHttpStatusSelectedIndexChanged);
			// 
			// msgHttp
			// 
			this.msgHttp.Location = new System.Drawing.Point(326, 0);
			this.msgHttp.Name = "msgHttp";
			this.msgHttp.Size = new System.Drawing.Size(106, 32);
			this.msgHttp.TabIndex = 9;
			this.msgHttp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
			this.groupBox1.Size = new System.Drawing.Size(530, 205);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(368, 214);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(165, 35);
			this.panel1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 29);
			this.button2.TabIndex = 6;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(84, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 29);
			this.button1.TabIndex = 7;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(536, 252);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// PolicyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 262);
			this.Controls.Add(this.tableLayoutPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PolicyForm";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Change Host";
			this.TopMost = true;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label msgHttp;
		private System.Windows.Forms.ComboBox cbHttpStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button searchFile;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button searchFolder;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textDesc;
		private System.Windows.Forms.TextBox textChange;
		private System.Windows.Forms.TextBox textPattern;
		private System.Windows.Forms.ComboBox cbType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
