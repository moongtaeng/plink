using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

/*
 * SharpDevelop으로 작성되었습니다.
 * 사용자: easylogic
 * 날짜: 2012-02-16
 * 시간: 오전 11:42
 * 
 * 이 템플리트를 변경하려면 [도구->옵션->코드 작성->표준 헤더 편집]을 이용하십시오.
 */
namespace PLinkCore 
{
	partial class HostTab
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		//private System.ComponentModel.ComponentResourceManager resources = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostTab));
			this.cbLocalPolicy = new System.Windows.Forms.ComboBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.hostModifyItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hostAddItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hostDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.settingGroups = new System.Windows.Forms.GroupBox();
			this.msgAdmin = new System.Windows.Forms.Label();
			this.webPolicyButton = new System.Windows.Forms.Button();
			this.cbWebPolicy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbHeaderEncoding = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.httpsFilter = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.hostGroups = new System.Windows.Forms.GroupBox();
			this.hostTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnPlusPolicy = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnInitHost = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.autoStart = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.bookmarkAdd = new System.Windows.Forms.Button();
			this.bookmarkDel = new System.Windows.Forms.Button();
			this.bookmarkList = new System.Windows.Forms.ListBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.settingGroups.SuspendLayout();
			this.hostGroups.SuspendLayout();
			this.hostTablePanel.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbLocalPolicy
			// 
			this.cbLocalPolicy.DisplayMember = "Key";
			this.cbLocalPolicy.DropDownHeight = 500;
			this.cbLocalPolicy.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.cbLocalPolicy.FormattingEnabled = true;
			this.cbLocalPolicy.IntegralHeight = false;
			this.cbLocalPolicy.Location = new System.Drawing.Point(160, 56);
			this.cbLocalPolicy.MaxDropDownItems = 50;
			this.cbLocalPolicy.Name = "cbLocalPolicy";
			this.cbLocalPolicy.Size = new System.Drawing.Size(240, 21);
			this.cbLocalPolicy.TabIndex = 4;
			this.cbLocalPolicy.ValueMember = "Value";
			this.cbLocalPolicy.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader5,
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.LabelEdit = true;
			this.listView1.Location = new System.Drawing.Point(0, 28);
			this.listView1.Margin = new System.Windows.Forms.Padding(0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(558, 305);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Type";
			this.columnHeader5.Width = 73;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Before";
			this.columnHeader1.Width = 250;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "After";
			this.columnHeader2.Width = 300;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Description";
			this.columnHeader3.Width = 200;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.hostModifyItem,
									this.hostAddItem,
									this.hostDeleteItem});
			this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(115, 70);
			// 
			// hostModifyItem
			// 
			this.hostModifyItem.Name = "hostModifyItem";
			this.hostModifyItem.Size = new System.Drawing.Size(152, 22);
			this.hostModifyItem.Text = "Modify";
			this.hostModifyItem.Click += new System.EventHandler(this.HostModifyItemClick);
			// 
			// hostAddItem
			// 
			this.hostAddItem.Name = "hostAddItem";
			this.hostAddItem.Size = new System.Drawing.Size(152, 22);
			this.hostAddItem.Text = "Add";
			this.hostAddItem.Click += new System.EventHandler(this.HostAddItemClick);
			// 
			// hostDeleteItem
			// 
			this.hostDeleteItem.Name = "hostDeleteItem";
			this.hostDeleteItem.Size = new System.Drawing.Size(152, 22);
			this.hostDeleteItem.Text = "Delete";
			this.hostDeleteItem.Click += new System.EventHandler(this.HostDeleteItemClick);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "row_height.JPG");
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// settingGroups
			// 
			this.settingGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.settingGroups.Controls.Add(this.msgAdmin);
			this.settingGroups.Controls.Add(this.webPolicyButton);
			this.settingGroups.Controls.Add(this.cbWebPolicy);
			this.settingGroups.Controls.Add(this.label1);
			this.settingGroups.Controls.Add(this.checkBox2);
			this.settingGroups.Controls.Add(this.button2);
			this.settingGroups.Controls.Add(this.label2);
			this.settingGroups.Controls.Add(this.cbLocalPolicy);
			this.settingGroups.Location = new System.Drawing.Point(3, 3);
			this.settingGroups.Name = "settingGroups";
			this.settingGroups.Padding = new System.Windows.Forms.Padding(5);
			this.settingGroups.Size = new System.Drawing.Size(473, 136);
			this.settingGroups.TabIndex = 13;
			this.settingGroups.TabStop = false;
			this.settingGroups.Text = "Tools";
			// 
			// msgAdmin
			// 
			this.msgAdmin.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.msgAdmin.ForeColor = System.Drawing.Color.Maroon;
			this.msgAdmin.Location = new System.Drawing.Point(80, 104);
			this.msgAdmin.Name = "msgAdmin";
			this.msgAdmin.Size = new System.Drawing.Size(384, 23);
			this.msgAdmin.TabIndex = 18;
			this.msgAdmin.Text = "You need Administrators access to change hosts file.";
			this.msgAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// webPolicyButton
			// 
			this.webPolicyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.webPolicyButton.Location = new System.Drawing.Point(408, 24);
			this.webPolicyButton.Name = "webPolicyButton";
			this.webPolicyButton.Size = new System.Drawing.Size(48, 24);
			this.webPolicyButton.TabIndex = 17;
			this.webPolicyButton.Text = "Load";
			this.webPolicyButton.UseVisualStyleBackColor = true;
			this.webPolicyButton.Click += new System.EventHandler(this.WebPolicyButtonClick);
			// 
			// cbWebPolicy
			// 
			this.cbWebPolicy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbWebPolicy.FormattingEnabled = true;
			this.cbWebPolicy.Location = new System.Drawing.Point(160, 24);
			this.cbWebPolicy.Name = "cbWebPolicy";
			this.cbWebPolicy.Size = new System.Drawing.Size(240, 20);
			this.cbWebPolicy.TabIndex = 16;
			this.cbWebPolicy.SelectedIndexChanged += new System.EventHandler(this.CbWebPolicySelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(104, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Web";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBox2.BackColor = System.Drawing.Color.Transparent;
			this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.checkBox2.FlatAppearance.BorderSize = 0;
			this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.checkBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.checkBox2.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.checkBox2.ForeColor = System.Drawing.Color.Black;
			this.checkBox2.Location = new System.Drawing.Point(8, 24);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.checkBox2.Size = new System.Drawing.Size(72, 56);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "▶ Start";
			this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox2.UseVisualStyleBackColor = false;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Location = new System.Drawing.Point(408, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 24);
			this.button2.TabIndex = 5;
			this.button2.Text = "Find";
			this.toolTip1.SetToolTip(this.button2, "파일 열기");
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(104, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbHeaderEncoding
			// 
			this.cbHeaderEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHeaderEncoding.FormattingEnabled = true;
			this.cbHeaderEncoding.Items.AddRange(new object[] {
									"UTF-8",
									"EUC-KR"});
			this.cbHeaderEncoding.Location = new System.Drawing.Point(128, 56);
			this.cbHeaderEncoding.Name = "cbHeaderEncoding";
			this.cbHeaderEncoding.Size = new System.Drawing.Size(136, 20);
			this.cbHeaderEncoding.TabIndex = 26;
			this.cbHeaderEncoding.SelectedIndexChanged += new System.EventHandler(this.CbHeaderEncodingSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 24);
			this.label6.TabIndex = 25;
			this.label6.Text = "Header Encoding : ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// httpsFilter
			// 
			this.httpsFilter.Checked = true;
			this.httpsFilter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.httpsFilter.Location = new System.Drawing.Point(128, 80);
			this.httpsFilter.Name = "httpsFilter";
			this.httpsFilter.Size = new System.Drawing.Size(200, 24);
			this.httpsFilter.TabIndex = 24;
			this.httpsFilter.Text = "http://host:443 -> https://host ";
			this.toolTip1.SetToolTip(this.httpsFilter, "피들러 자체 포로토콜 검증으로 인해서  \r\nhttp://host:443  형태로 들어오는 프로토콜에 대해서 인식을 못합니다.\r\n그래서  https" +
						"://host 형태로 정상적인 프로토콜로 변경하도록 필터링을 합니다. ");
			this.httpsFilter.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(41, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 23);
			this.label8.TabIndex = 23;
			this.label8.Text = "Http Filter : ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSave
			// 
			this.btnSave.AutoEllipsis = true;
			this.btnSave.BackColor = System.Drawing.Color.Transparent;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSave.Location = new System.Drawing.Point(3, 3);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(69, 21);
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save!";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.Button4Click);
			// 
			// hostGroups
			// 
			this.hostGroups.Controls.Add(this.hostTablePanel);
			this.hostGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hostGroups.Location = new System.Drawing.Point(0, 0);
			this.hostGroups.Name = "hostGroups";
			this.hostGroups.Padding = new System.Windows.Forms.Padding(10);
			this.hostGroups.Size = new System.Drawing.Size(578, 367);
			this.hostGroups.TabIndex = 14;
			this.hostGroups.TabStop = false;
			this.hostGroups.Text = "Host List";
			// 
			// hostTablePanel
			// 
			this.hostTablePanel.ColumnCount = 1;
			this.hostTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.hostTablePanel.Controls.Add(this.listView1, 0, 1);
			this.hostTablePanel.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.hostTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.hostTablePanel.Location = new System.Drawing.Point(10, 24);
			this.hostTablePanel.Name = "hostTablePanel";
			this.hostTablePanel.RowCount = 2;
			this.hostTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.hostTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.hostTablePanel.Size = new System.Drawing.Size(558, 333);
			this.hostTablePanel.TabIndex = 7;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(558, 28);
			this.tableLayoutPanel4.TabIndex = 7;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.SetColumnSpan(this.flowLayoutPanel1, 2);
			this.flowLayoutPanel1.Controls.Add(this.btnSave);
			this.flowLayoutPanel1.Controls.Add(this.btnModify);
			this.flowLayoutPanel1.Controls.Add(this.btnPlusPolicy);
			this.flowLayoutPanel1.Controls.Add(this.btnDelete);
			this.flowLayoutPanel1.Controls.Add(this.btnInitHost);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(558, 28);
			this.flowLayoutPanel1.TabIndex = 8;
			// 
			// btnModify
			// 
			this.btnModify.BackColor = System.Drawing.Color.Transparent;
			this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModify.FlatAppearance.BorderSize = 0;
			this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnModify.ForeColor = System.Drawing.Color.Black;
			this.btnModify.Location = new System.Drawing.Point(78, 3);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(66, 22);
			this.btnModify.TabIndex = 2;
			this.btnModify.Text = "Modify";
			this.toolTip1.SetToolTip(this.btnModify, "수정");
			this.btnModify.UseVisualStyleBackColor = false;
			this.btnModify.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnPlusPolicy
			// 
			this.btnPlusPolicy.BackColor = System.Drawing.Color.Transparent;
			this.btnPlusPolicy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPlusPolicy.FlatAppearance.BorderSize = 0;
			this.btnPlusPolicy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnPlusPolicy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnPlusPolicy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPlusPolicy.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnPlusPolicy.Location = new System.Drawing.Point(150, 3);
			this.btnPlusPolicy.Name = "btnPlusPolicy";
			this.btnPlusPolicy.Size = new System.Drawing.Size(54, 23);
			this.btnPlusPolicy.TabIndex = 0;
			this.btnPlusPolicy.Text = "Add";
			this.toolTip1.SetToolTip(this.btnPlusPolicy, "추가");
			this.btnPlusPolicy.UseVisualStyleBackColor = false;
			this.btnPlusPolicy.Click += new System.EventHandler(this.BtnPlusPolicyClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnDelete.Location = new System.Drawing.Point(210, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(60, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete";
			this.toolTip1.SetToolTip(this.btnDelete, "삭제");
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnMinusPolicyClick);
			// 
			// btnInitHost
			// 
			this.btnInitHost.Location = new System.Drawing.Point(276, 3);
			this.btnInitHost.Name = "btnInitHost";
			this.btnInitHost.Size = new System.Drawing.Size(75, 23);
			this.btnInitHost.TabIndex = 18;
			this.btnInitHost.Text = "Initialize";
			this.btnInitHost.UseVisualStyleBackColor = true;
			this.btnInitHost.Click += new System.EventHandler(this.BtnInitHostClick);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.settingGroups, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 547);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
			this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.versionLabel, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 518);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(473, 26);
			this.tableLayoutPanel3.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(267, 26);
			this.label5.TabIndex = 0;
			this.label5.Text = "designed by easylogic";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// versionLabel
			// 
			this.versionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.versionLabel.Location = new System.Drawing.Point(276, 0);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(140, 26);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.autoStart);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbHeaderEncoding);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.httpsFilter);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(482, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(369, 136);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// autoStart
			// 
			this.autoStart.Location = new System.Drawing.Point(128, 32);
			this.autoStart.Name = "autoStart";
			this.autoStart.Size = new System.Drawing.Size(200, 24);
			this.autoStart.TabIndex = 28;
			this.autoStart.Text = "save current options";
			this.autoStart.UseVisualStyleBackColor = true;
			this.autoStart.CheckedChanged += new System.EventHandler(this.AutoStartCheckedChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 27;
			this.label4.Text = "State : ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// splitContainer1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 2);
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 145);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.hostGroups);
			this.splitContainer1.Size = new System.Drawing.Size(848, 367);
			this.splitContainer1.SplitterDistance = 266;
			this.splitContainer1.TabIndex = 18;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(266, 367);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Bookmark";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.bookmarkList, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(260, 347);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.bookmarkAdd);
			this.flowLayoutPanel2.Controls.Add(this.bookmarkDel);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(254, 37);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// bookmarkAdd
			// 
			this.bookmarkAdd.Location = new System.Drawing.Point(3, 3);
			this.bookmarkAdd.Name = "bookmarkAdd";
			this.bookmarkAdd.Size = new System.Drawing.Size(61, 29);
			this.bookmarkAdd.TabIndex = 0;
			this.bookmarkAdd.Text = "Add";
			this.bookmarkAdd.UseVisualStyleBackColor = true;
			this.bookmarkAdd.Click += new System.EventHandler(this.BookmarkAddClick);
			// 
			// bookmarkDel
			// 
			this.bookmarkDel.Location = new System.Drawing.Point(70, 3);
			this.bookmarkDel.Name = "bookmarkDel";
			this.bookmarkDel.Size = new System.Drawing.Size(75, 29);
			this.bookmarkDel.TabIndex = 1;
			this.bookmarkDel.Text = "Delete";
			this.bookmarkDel.UseVisualStyleBackColor = true;
			this.bookmarkDel.Click += new System.EventHandler(this.BookmarkDelClick);
			// 
			// bookmarkList
			// 
			this.bookmarkList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.bookmarkList.DisplayMember = "Key";
			this.bookmarkList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bookmarkList.FormattingEnabled = true;
			this.bookmarkList.ItemHeight = 12;
			this.bookmarkList.Location = new System.Drawing.Point(3, 46);
			this.bookmarkList.Name = "bookmarkList";
			this.bookmarkList.Size = new System.Drawing.Size(254, 298);
			this.bookmarkList.TabIndex = 2;
			this.bookmarkList.ValueMember = "Value";
			this.bookmarkList.SelectedIndexChanged += new System.EventHandler(this.BookmarkListSelectedIndexChanged);
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "1331538223_link.png");
			this.imageList2.Images.SetKeyName(1, "1331539460_arrow_left.png");
			// 
			// HostTab
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "HostTab";
			this.Size = new System.Drawing.Size(854, 547);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HostTabDragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HostTabDragEnter);
			this.contextMenuStrip1.ResumeLayout(false);
			this.settingGroups.ResumeLayout(false);
			this.hostGroups.ResumeLayout(false);
			this.hostTablePanel.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox bookmarkList;
		private System.Windows.Forms.Button btnInitHost;
		private System.Windows.Forms.Button bookmarkDel;
		private System.Windows.Forms.Button bookmarkAdd;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox autoStart;
		private System.Windows.Forms.Button webPolicyButton;
		private System.Windows.Forms.Label msgAdmin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbWebPolicy;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbHeaderEncoding;
		private System.Windows.Forms.ToolStripMenuItem hostDeleteItem;
		private System.Windows.Forms.ToolStripMenuItem hostAddItem;
		private System.Windows.Forms.ToolStripMenuItem hostModifyItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TableLayoutPanel hostTablePanel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox httpsFilter;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnPlusPolicy;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		public System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		public System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.GroupBox hostGroups;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.GroupBox settingGroups;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbLocalPolicy;
		private System.Windows.Forms.Button button2;

	}
}
