/*
 * Created by SharpDevelop.
 * User: steven england
 * Date: 19.06.2017
 * Time: 07:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HueFrontendAutomat.Browser;

namespace HueFrontendAutomat
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private List<WebBrowserEx> webList = new List<WebBrowserEx>();
		
		public List<Query> queryList = new List<Query>();
		
		WebBrowserEx wb1 = new WebBrowserEx();
		WebBrowserEx wb2 = new WebBrowserEx();
		WebBrowserEx wb3 = new WebBrowserEx();
		WebBrowserEx wb4 = new WebBrowserEx();
		WebBrowserEx wb5 = new WebBrowserEx();
		WebBrowserEx wb6 = new WebBrowserEx();
		WebBrowserEx wb7 = new WebBrowserEx();
		WebBrowserEx wb8 = new WebBrowserEx();
		WebBrowserEx wb9 = new WebBrowserEx();
		WebBrowserEx wb10 = new WebBrowserEx();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			wb1.Dock = DockStyle.Fill;
			tabPage1.Controls.Add(wb1);
			wb1.Id = "1";
			
			wb2.Dock = DockStyle.Fill;
			tabPage2.Controls.Add(wb2);
			wb2.Id = "2";
			
			wb3.Dock = DockStyle.Fill;
			tabPage3.Controls.Add(wb3);
			wb3.Id = "3";
			
			wb4.Dock = DockStyle.Fill;
			tabPage4.Controls.Add(wb4);
			wb4.Id = "4";
			
			wb5.Dock = DockStyle.Fill;
			tabPage5.Controls.Add(wb5);
			wb5.Id = "5";
			
			wb6.Dock = DockStyle.Fill;
			tabPage6.Controls.Add(wb6);
			wb6.Id = "6";
			
			wb7.Dock = DockStyle.Fill;
			tabPage7.Controls.Add(wb7);
			wb7.Id = "7";
			
			wb8.Dock = DockStyle.Fill;
			tabPage8.Controls.Add(wb8);
			wb8.Id = "8";
			
			wb9.Dock = DockStyle.Fill;
			tabPage9.Controls.Add(wb9);
			wb9.Id = "9";
			
			wb10.Dock = DockStyle.Fill;
			tabPage10.Controls.Add(wb10);
			wb10.Id = "10";
			
			webList.Add(wb1);
			webList.Add(wb2);
			webList.Add(wb3);
			webList.Add(wb4);
			webList.Add(wb5);
			webList.Add(wb6);
			webList.Add(wb7);
			webList.Add(wb8);
			webList.Add(wb9);
			webList.Add(wb10);
			
			wb1.Navigate("https://somehueinstance.com/impala");
			
		}
		void TabPage1Click(object sender, EventArgs e)
		{
			
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		async void StatusTimerTick(object sender, EventArgs e)
		{
			CheckStatus(wb1, tabPage1);
			CheckStatus(wb2, tabPage2);
			CheckStatus(wb3, tabPage3);
			CheckStatus(wb4, tabPage4);
			CheckStatus(wb5, tabPage5);
			CheckStatus(wb6, tabPage6);
			CheckStatus(wb7, tabPage7);
			CheckStatus(wb8, tabPage8);
			CheckStatus(wb9, tabPage9);
			CheckStatus(wb10, tabPage10);
			
			SetStatus(tabPage1, toolStripLabel1);
			SetStatus(tabPage2, toolStripLabel2);
			SetStatus(tabPage3, toolStripLabel3);
			SetStatus(tabPage4, toolStripLabel4);
			SetStatus(tabPage5, toolStripLabel5);
			SetStatus(tabPage6, toolStripLabel6);
			SetStatus(tabPage7, toolStripLabel7);
			SetStatus(tabPage8, toolStripLabel8);
			SetStatus(tabPage9, toolStripLabel9);
			SetStatus(tabPage10, toolStripLabel10);
			
			ExecuteNext(wb1, toolStripLabel1);
			//await Task.Delay(2000);
			ExecuteNext(wb2, toolStripLabel2);
			ExecuteNext(wb3, toolStripLabel3);
			ExecuteNext(wb4, toolStripLabel4);
			ExecuteNext(wb5, toolStripLabel5);
			ExecuteNext(wb6, toolStripLabel6);
			ExecuteNext(wb7, toolStripLabel7);
			ExecuteNext(wb8, toolStripLabel8);
			ExecuteNext(wb9, toolStripLabel9);
			ExecuteNext(wb10, toolStripLabel10);
			
			RenewQueryListStatus();
		}
		
		private async void ExecuteNext(WebBrowserEx web, ToolStripLabel label)
		{
			if ((label.ForeColor == Color.Green || label.ForeColor == Color.Blue || label.ForeColor == Color.Red) && autoQueryTxt.Text == "1")
			{
				if (web.HueQuery == null || web.HueQuery.Success)
				{
					web.HueQuery = queryList.FirstOrDefault(x => x.Initial == true);
					if (web.HueQuery == null)
						return;
					web.HueQuery.Initial = false;
					web.HueQuery.BrowserNr = web.Id;
				}
				
				if (label.ForeColor == Color.Green && !web.HueQuery.Success && web.HueQuery.RetryCounter > 0)
				{
					web.HueQuery.Success = true;
					web.Document.InvokeScript("eval", new object[] {"codeMirror.setValue('success');"});
					web.HueQuery = null;
					return;
				}
				
				if (web.HueQuery.RetryCounter >= 30)
				{
					web.HueQuery.Success = false;
					web.Document.InvokeScript("eval", new object[] {"codeMirror.setValue('failed');"});
					web.HueQuery = null;
					return;
				}
				
				if (label.ForeColor == Color.Red)
				{
					await Task.Delay(1000);
				}
				string funcFillSql = "codeMirror.setValue('" + web.HueQuery.Sql + "');";
				web.Document.InvokeScript("eval", new object[] {funcFillSql});
				await Task.Delay(1000);
				web.Document.InvokeScript("eval", new object[] {"tryExecuteQuery();"});
				web.HueQuery.RetryCounter++;
			}
		}
		
		private void SetStatus(TabPage page, ToolStripLabel label)
		{
			if (page.Text == "ready")
				label.ForeColor = Color.Blue;
			else if (page.Text.Contains("ready -"))
			{
				label.ForeColor = Color.Red;
				if (page.Text.Contains("results"))
				label.ForeColor = Color.Green;
			}
			else if (page.Text.Contains("busy"))
				label.ForeColor = Color.Yellow;
			else
				label.ForeColor = Color.Gray;
			
			
		}
		
		private void CheckStatus(WebBrowserEx web, TabPage page)
		{
			try
			{
				if (web.Document == null || web.Document.Body == null)
				{
					page.Text = "web_null";
					return;
				}
				
				var element = web.Document.GetElementById("executeQuery");
				if (element == null)
				{
					page.Text = "el_null";
					return;
				}
				
				if (element.Style != null && element.Style.Contains("display: none"))
					page.Text = "busy";
				else
					page.Text = "ready";
				
				// Zusatz
				var result = web.Document.GetElementById("results");
				if (result != null
				    && result.GetAttribute("classname").Contains("active")

				   )
				{
					page.Text += " - results";
					var resultEmptyElement = web.Document.GetElementById("resultEmpty");
					if (resultEmptyElement != null
					    && !resultEmptyElement.GetAttribute("classname").Contains("hide")
					   )
					{
						page.Text += " - no result";
					}
					return;
				}
						
				
				var queryElement = web.Document.GetElementById("log");
				if (queryElement == null)
					page.Text += " - no log el";
				else
				{
					Match match = Regex.Match(queryElement.InnerText, @"Query.*\s{1}(\d{1,3}%)", RegexOptions.IgnoreCase);
					if (match.Success)
					{
						page.Text += " - " + match.Groups[1].Value;
						return;
					}
					match = Regex.Match(queryElement.InnerText, @"map = (\d{1,3}%),  reduce = (\d{1,3}%),", RegexOptions.IgnoreCase | RegexOptions.RightToLeft);
					if (match.Success)
					{
						page.Text += " - m:" + match.Groups[1].Value + " r:" + match.Groups[2].Value;
						return;
					}
				}
			}
			catch (Exception ex)
			{
				page.Text = "cs_err";
				return;
			}
		}
		void LoadAllPagesBtnClick(object sender, EventArgs e)
		{
			wb2.Navigate("https://somehueinstance.com/impala");
			wb3.Navigate("https://somehueinstance.com/impala");
			wb4.Navigate("https://somehueinstance.com/impala");
			wb5.Navigate("https://somehueinstance.com/impala");
			wb6.Navigate("https://somehueinstance.com/impala");
			wb7.Navigate("https://somehueinstance.com/impala");
			wb8.Navigate("https://somehueinstance.com/impala");
			wb9.Navigate("https://somehueinstance.com/impala");
			wb10.Navigate("https://somehueinstance.com/impala");
		}
		
		void SetSqlBtnClick(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(sqlQueriesTxt.Text))
				return;
			queryLst.Items.Clear();
			queryList.Clear();
			string[] lines = sqlQueriesTxt.Text.Split(new[]{';'}
                                          , StringSplitOptions.RemoveEmptyEntries);
			int id = 0;
			foreach (var line in lines)
			{
				var sql = line;
				sql = sql.Replace("'", @"\'");
				sql = sql.Replace("\r\n", "\\n");
				sql = sql.Replace("\n", "\\n");
				var query = new Query(sql + ';', id.ToString());
				queryList.Add(query);
				id++;
			}
			
			RenewQueryListStatus();
		}
		
		private void RenewQueryListStatus()
		{
			queryLst.Items.Clear();
			for (int i = 0; i<queryList.Count; i++)
			{
				queryLst.Items.Add(new ListViewItem(new string[] { 
				                                    	queryList[i].RetryCounter.ToString(),
				                                    	queryList[i].Success.ToString(),
				                                    	queryList[i].Id,
				                                    	queryList[i].Initial.ToString(),
				                                    	queryList[i].BrowserNr,
				                                    	queryList[i].Sql
				                                    }));
			}
		}
		
		void RemoveSuccededBtnClick(object sender, EventArgs e)
		{
			queryList = queryList.FindAll(x => x.Success == false);
		}
	
	}
}
