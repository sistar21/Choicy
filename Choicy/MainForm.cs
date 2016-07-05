/*
 * Created by SharpDevelop.
 * User: Bambam & Sarai
 * Date: 2016-07-03
 * Time: 09:46
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
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ResetSelectionText ( ) 
		{
			// reset the whole rich text box to black default font
			rtbSelectionText.SelectAll();
			rtbSelectionText.SelectionFont = rtbSelectionText.Font;
			rtbSelectionText.SelectionColor = Color.Black;
			
			// make the first line bold
			int iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( 0 );
			string strChoosenLineText = rtbSelectionText.Lines[0];
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Black;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Bold);
			rtbSelectionText.Update();
		}
		
		bool CheckInput()
		{
			if (rtbSelectionText.Lines.Length < 2 ) {
				MessageBox.Show("There are not enought choises in the input.\nNote that the first line is the title.", 
				                "Choisy Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return false;
			}
			int iChoices = 0;
			foreach ( string strLine in rtbSelectionText.Lines ) {
				if (strLine.Length > 0 ) iChoices++;
			}
			if ( iChoices < 3 ) {
				MessageBox.Show("There have to be at least two choices in the list.\nNote that the first line is the title.", 
				                "Choisy Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}
		
		void ChooseNewLine ( )
		{
			ResetSelectionText ( );

			var rndThis = new Random( );
			int iFirstCharIndex = 0;
			string strChoosenLineText = "";
			
			// get a new random line
			while ( strChoosenLineText.Length == 0 ) {
				iRandomLine = rndThis.Next( 1, rtbSelectionText.Lines.Length );
				iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iRandomLine );
				strChoosenLineText = rtbSelectionText.Lines[iRandomLine];
			}

			// make the new random line green
			rtbSelectionText.Select(iFirstCharIndex, strChoosenLineText.Length);
			rtbSelectionText.SelectionColor = Color.Green;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Bold);
		}
		
		void BtnChooseClick(object sender, EventArgs e)
		{
			if ( !CheckInput() ) return;
			ChooseNewLine ( );
		}
		
		void BtnOpenClick(object sender, EventArgs e)
		{
			if ( ofdChoicy.ShowDialog() == DialogResult.OK ) {	
				rtbSelectionText.LoadFile ( ofdChoicy.FileName );
				ResetSelectionText();
				sfdChoicy.FileName = ofdChoicy.FileName;
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