﻿/*
 * Created by SharpDevelop.
 * User: Sarai & Bambam
 * Date: 2016-07-03
 * Time: 09:46
 */
using System;
using System.Windows.Forms;

namespace Choicy
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
