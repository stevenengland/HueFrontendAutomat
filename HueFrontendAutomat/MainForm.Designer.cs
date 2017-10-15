/*
 * Created by SharpDevelop.
 * User: steven england
 * Date: 19.06.2017
 * Time: 07:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HueFrontendAutomat
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.TabPage tabPage10;
		private System.Windows.Forms.Timer statusTimer;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton loadAllPagesBtn;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripLabel toolStripLabel6;
		private System.Windows.Forms.ToolStripLabel toolStripLabel7;
		private System.Windows.Forms.ToolStripLabel toolStripLabel8;
		private System.Windows.Forms.ToolStripLabel toolStripLabel9;
		private System.Windows.Forms.ToolStripLabel toolStripLabel10;
		private System.Windows.Forms.ToolStripLabel toolStripLabel11;
		private System.Windows.Forms.ToolStripTextBox autoQueryTxt;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage sqlQueriesTab;
		private System.Windows.Forms.RichTextBox sqlQueriesTxt;
		private System.Windows.Forms.TabPage statusTab;
		private System.Windows.Forms.ListView queryLst;
		private System.Windows.Forms.ColumnHeader retryCol;
		private System.Windows.Forms.ColumnHeader successCol;
		private System.Windows.Forms.ColumnHeader idCol;
		private System.Windows.Forms.ColumnHeader initialCol;
		private System.Windows.Forms.ColumnHeader sqlCol;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton setSqlBtn;
		private System.Windows.Forms.ToolStripButton removeSuccededBtn;
		private System.Windows.Forms.ColumnHeader browserNrCol;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.sqlQueriesTab = new System.Windows.Forms.TabPage();
			this.sqlQueriesTxt = new System.Windows.Forms.RichTextBox();
			this.statusTab = new System.Windows.Forms.TabPage();
			this.queryLst = new System.Windows.Forms.ListView();
			this.retryCol = new System.Windows.Forms.ColumnHeader();
			this.successCol = new System.Windows.Forms.ColumnHeader();
			this.idCol = new System.Windows.Forms.ColumnHeader();
			this.initialCol = new System.Windows.Forms.ColumnHeader();
			this.browserNrCol = new System.Windows.Forms.ColumnHeader();
			this.sqlCol = new System.Windows.Forms.ColumnHeader();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.statusTimer = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.loadAllPagesBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
			this.autoQueryTxt = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.setSqlBtn = new System.Windows.Forms.ToolStripButton();
			this.removeSuccededBtn = new System.Windows.Forms.ToolStripButton();
			this.tabControl1.SuspendLayout();
			this.tabPage11.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.sqlQueriesTab.SuspendLayout();
			this.statusTab.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage11);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Controls.Add(this.tabPage10);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ItemSize = new System.Drawing.Size(140, 25);
			this.tabControl1.Location = new System.Drawing.Point(38, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1194, 475);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.tabControl2);
			this.tabPage11.Location = new System.Drawing.Point(4, 29);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new System.Drawing.Size(1186, 442);
			this.tabPage11.TabIndex = 10;
			this.tabPage11.Text = "SQL";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.sqlQueriesTab);
			this.tabControl2.Controls.Add(this.statusTab);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1186, 442);
			this.tabControl2.TabIndex = 0;
			// 
			// sqlQueriesTab
			// 
			this.sqlQueriesTab.Controls.Add(this.sqlQueriesTxt);
			this.sqlQueriesTab.Location = new System.Drawing.Point(4, 22);
			this.sqlQueriesTab.Name = "sqlQueriesTab";
			this.sqlQueriesTab.Padding = new System.Windows.Forms.Padding(3);
			this.sqlQueriesTab.Size = new System.Drawing.Size(1178, 416);
			this.sqlQueriesTab.TabIndex = 0;
			this.sqlQueriesTab.Text = "SQL";
			this.sqlQueriesTab.UseVisualStyleBackColor = true;
			// 
			// sqlQueriesTxt
			// 
			this.sqlQueriesTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sqlQueriesTxt.Location = new System.Drawing.Point(3, 3);
			this.sqlQueriesTxt.Name = "sqlQueriesTxt";
			this.sqlQueriesTxt.Size = new System.Drawing.Size(1172, 410);
			this.sqlQueriesTxt.TabIndex = 0;
			this.sqlQueriesTxt.Text = "";
			// 
			// statusTab
			// 
			this.statusTab.Controls.Add(this.queryLst);
			this.statusTab.Location = new System.Drawing.Point(4, 22);
			this.statusTab.Name = "statusTab";
			this.statusTab.Padding = new System.Windows.Forms.Padding(3);
			this.statusTab.Size = new System.Drawing.Size(1178, 416);
			this.statusTab.TabIndex = 1;
			this.statusTab.Text = "Status";
			this.statusTab.UseVisualStyleBackColor = true;
			// 
			// queryLst
			// 
			this.queryLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.retryCol,
			this.successCol,
			this.idCol,
			this.initialCol,
			this.browserNrCol,
			this.sqlCol});
			this.queryLst.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queryLst.GridLines = true;
			this.queryLst.Location = new System.Drawing.Point(3, 3);
			this.queryLst.Name = "queryLst";
			this.queryLst.Size = new System.Drawing.Size(1172, 410);
			this.queryLst.TabIndex = 0;
			this.queryLst.UseCompatibleStateImageBehavior = false;
			this.queryLst.View = System.Windows.Forms.View.Details;
			// 
			// retryCol
			// 
			this.retryCol.Text = "Retry";
			// 
			// successCol
			// 
			this.successCol.Text = "Success";
			// 
			// idCol
			// 
			this.idCol.Text = "Id";
			// 
			// initialCol
			// 
			this.initialCol.Text = "Init";
			// 
			// browserNrCol
			// 
			this.browserNrCol.DisplayIndex = 5;
			this.browserNrCol.Text = "Browser";
			// 
			// sqlCol
			// 
			this.sqlCol.DisplayIndex = 4;
			this.sqlCol.Text = "SQL";
			this.sqlCol.Width = 200;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1186, 442);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.TabPage1Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1186, 442);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1186, 442);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1186, 442);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Location = new System.Drawing.Point(4, 29);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(1186, 442);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "tabPage5";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage6
			// 
			this.tabPage6.Location = new System.Drawing.Point(4, 29);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(1186, 442);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "tabPage6";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Location = new System.Drawing.Point(4, 29);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(1186, 442);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "tabPage7";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// tabPage8
			// 
			this.tabPage8.Location = new System.Drawing.Point(4, 29);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new System.Drawing.Size(1186, 442);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "tabPage8";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// tabPage9
			// 
			this.tabPage9.Location = new System.Drawing.Point(4, 29);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Size = new System.Drawing.Size(1186, 442);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "tabPage9";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// tabPage10
			// 
			this.tabPage10.Location = new System.Drawing.Point(4, 29);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(1186, 442);
			this.tabPage10.TabIndex = 9;
			this.tabPage10.Text = "tabPage10";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// statusTimer
			// 
			this.statusTimer.Enabled = true;
			this.statusTimer.Interval = 60000;
			this.statusTimer.Tick += new System.EventHandler(this.StatusTimerTick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.loadAllPagesBtn,
			this.toolStripLabel1,
			this.toolStripLabel2,
			this.toolStripLabel3,
			this.toolStripLabel4,
			this.toolStripLabel5,
			this.toolStripLabel6,
			this.toolStripLabel7,
			this.toolStripLabel8,
			this.toolStripLabel9,
			this.toolStripLabel10,
			this.toolStripLabel11,
			this.autoQueryTxt,
			this.toolStripSeparator1,
			this.setSqlBtn,
			this.removeSuccededBtn});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(38, 475);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// loadAllPagesBtn
			// 
			this.loadAllPagesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.loadAllPagesBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadAllPagesBtn.Image")));
			this.loadAllPagesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.loadAllPagesBtn.Name = "loadAllPagesBtn";
			this.loadAllPagesBtn.Size = new System.Drawing.Size(35, 20);
			this.loadAllPagesBtn.Text = "toolStripButton1";
			this.loadAllPagesBtn.Click += new System.EventHandler(this.LoadAllPagesBtnClick);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel1.Text = "<1>";
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel2.Text = "<2>";
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel3.Text = "<3>";
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel4.Text = "<4>";
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel5.Text = "<5>";
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel6.Text = "<6>";
			// 
			// toolStripLabel7
			// 
			this.toolStripLabel7.Name = "toolStripLabel7";
			this.toolStripLabel7.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel7.Text = "<7>";
			// 
			// toolStripLabel8
			// 
			this.toolStripLabel8.Name = "toolStripLabel8";
			this.toolStripLabel8.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel8.Text = "<8>";
			// 
			// toolStripLabel9
			// 
			this.toolStripLabel9.Name = "toolStripLabel9";
			this.toolStripLabel9.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel9.Text = "<9>";
			// 
			// toolStripLabel10
			// 
			this.toolStripLabel10.Name = "toolStripLabel10";
			this.toolStripLabel10.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel10.Text = "<10>";
			// 
			// toolStripLabel11
			// 
			this.toolStripLabel11.Name = "toolStripLabel11";
			this.toolStripLabel11.Size = new System.Drawing.Size(35, 12);
			this.toolStripLabel11.Text = "AQ";
			// 
			// autoQueryTxt
			// 
			this.autoQueryTxt.BackColor = System.Drawing.SystemColors.Info;
			this.autoQueryTxt.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autoQueryTxt.MaxLength = 1;
			this.autoQueryTxt.Name = "autoQueryTxt";
			this.autoQueryTxt.Size = new System.Drawing.Size(33, 19);
			this.autoQueryTxt.Text = "0";
			this.autoQueryTxt.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(35, 6);
			// 
			// setSqlBtn
			// 
			this.setSqlBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.setSqlBtn.Image = ((System.Drawing.Image)(resources.GetObject("setSqlBtn.Image")));
			this.setSqlBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.setSqlBtn.Name = "setSqlBtn";
			this.setSqlBtn.Size = new System.Drawing.Size(35, 20);
			this.setSqlBtn.Text = "toolStripButton1";
			this.setSqlBtn.Click += new System.EventHandler(this.SetSqlBtnClick);
			// 
			// removeSuccededBtn
			// 
			this.removeSuccededBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.removeSuccededBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeSuccededBtn.Image")));
			this.removeSuccededBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.removeSuccededBtn.Name = "removeSuccededBtn";
			this.removeSuccededBtn.Size = new System.Drawing.Size(35, 20);
			this.removeSuccededBtn.Text = "toolStripButton1";
			this.removeSuccededBtn.Click += new System.EventHandler(this.RemoveSuccededBtnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 475);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "HueFrontendAutomat";
			this.tabControl1.ResumeLayout(false);
			this.tabPage11.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.sqlQueriesTab.ResumeLayout(false);
			this.statusTab.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
