/*
 * Created by SharpDevelop.
 * User: steven england
 * Date: 25.06.2017
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HueFrontendAutomat
{
	/// <summary>
	/// Description of Query.
	/// </summary>
	public class Query
	{
		public int RetryCounter {get;set;}
		public string Sql{get;set;}
		public bool Success{get; set;}
		public string Id {get;set;}
		public bool Initial {get;set;}
		public string BrowserNr{get;set;}
		
		public Query(string sql,  string id)
		{
			Sql = sql;
			RetryCounter = 0;
			Success = false;
			Id = id;
			Initial = true;
			BrowserNr = "-";
		}
	}
}
