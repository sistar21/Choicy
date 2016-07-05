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
			// make the first line bold
			int iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( 0 );
			string strChoosenLineText = rtbSelectionText.Lines[0];
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Black;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Bold);
			
			// make the last choosen line black
			iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iRandomLine );
			strChoosenLineText = rtbSelectionText.Lines[iRandomLine];
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Black;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Regular);

			// get a new random line
			var rndThis = new Random( );
			strChoosenLineText = "";
			while ( strChoosenLineText.Length == 0 ) {
				iRandomLine = rndThis.Next( 1, rtbSelectionText.Lines.Length );
				iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iRandomLine );
				strChoosenLineText = rtbSelectionText.Lines[iRandomLine];
			}

			// make the new random line green
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Green;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Bold);

			rtbSelectionText.Select(0,0);
			rtbSelectionText.SelectionColor = Color.White;
		}
		
		void LblChoicyClick(object sender, EventArgs e)
		{
	
		}
		
		void RtbSelectionTextTextChanged(object sender, EventArgs e)
		{
	
		}
		
		void BtnOpenClick(object sender, EventArgs e)
		{
			if ( ofdChoicy.ShowDialog() == DialogResult.OK ) {	
				rtbSelectionText.LoadFile ( ofdChoicy.FileName );
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			if ( sfdChoicy.ShowDialog() == DialogResult.OK ) {
				rtbSelectionText.SaveFile ( sfdChoicy.FileName );
			}
		}
	}
}
