/*
 * Created by SharpDevelop.
 * User: rlauer
 * Date: 2016-07-03
 * Time: 09:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Choicy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int iRandomLine = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnChooseClick(object sender, EventArgs e)
		{
			// make the last choosen line black
			int iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iRandomLine );
			string strChoosenLineText = rtbSelectionText.Lines[iRandomLine];
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Black;

			// get a new random line
			Random rndThis = new Random( );
			iRandomLine = rndThis.Next( 0, rtbSelectionText.Lines.Length );
			
			// make the new random line green
			iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iRandomLine );
			strChoosenLineText = rtbSelectionText.Lines[iRandomLine];
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Green;

			rtbSelectionText.Select(0,0);
			rtbSelectionText.SelectionColor = Color.White;
		}
		void LblChoicyClick(object sender, EventArgs e)
		{
	
		}
	}
}
