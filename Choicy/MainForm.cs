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
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Choicy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int iRandomLine = 1;
		int iChoiceCounter = 0;
        string strXmlSettingsFilePath = "Choicy Settings.xml";
        string strActiveListName = "Choicy.choicy";
		Random rndThis = new Random( );
		
		public MainForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();
			
			LoadSettings( false );
			LoadList ( strActiveListName );
			ResetSelectionText( );
			CheckLatestVersion( "Startup" );
		}

        /// <summary>
        /// Execute the command in the system.
        /// </summary>
        /// <param name="sCommand">The command to execute.</param>
        void ExecuteThis( string sCommand )
        {
            System.Diagnostics.Process.Start( sCommand );
        }


        /// <summary>
        /// Asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The question.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowYesNoQuestion( string strMessage )
        {
            DialogResult drAnswer = MessageBox.Show( strMessage, "Choicy - Question",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            return drAnswer;
		}
        
        /// <summary>
        /// Logs an informal message and asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The informal message.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowInfo( string strMessage )
        {
            return MessageBox.Show( strMessage, "Choicy - Info",
                                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
        }
        
        /// <summary>
        /// Shows an error message and asks the user for a decission.
        /// </summary>
        /// <param name="strMessage">The error message.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowError( string strMessage )
        {
            return MessageBox.Show( strMessage, "Choicy - Error",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Error );
		}
        
        
        /// <summary>
        /// Shows a warning message.
        /// </summary>
        /// <param name="strMessage">The error message.</param>
        /// <returns>The user feedback.</returns>
        DialogResult ShowWarning( string strMessage )
        {
            return MessageBox.Show( strMessage, "Choicy - Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning );
		}
        
#region Version Handling
        
        /// <summary>
        /// Converts a datetime to the standard date format yyyy-mm-dd.
        /// </summary>
        /// <param name="dtToSStandardize">The date time to standardize.</param>
        /// <returns>The standzadized date string.</returns>
        string StandardizeDate( DateTime dtToSStandardize )
        {
            return dtToSStandardize.Year.ToString( "D4" ) + "-" +
                    dtToSStandardize.Month.ToString( "D2" ) + "-" +
                    dtToSStandardize.Day.ToString( "D2" );
        }

        /// <summary>
        /// Check if the latest version of Choicy is installed.
        /// </summary>
        void CheckLatestVersion( string sWhen )
        {
            string sLatestRelease = "";
            string sReleaseNotes = "";
            string sCurrentRelease = Application.ProductVersion.Remove( Application.ProductVersion.Length - 2 );
            lblVersion.Text = sCurrentRelease;
            var dtLastChecked = new DateTime( );
            string sLastCheckedDate = lblLastChecked.Text.Substring( "Last Checked: ".Length );
            if ( sLastCheckedDate == "Never" ) sLastCheckedDate = "1900-01-01";
            dtLastChecked = Convert.ToDateTime( sLastCheckedDate );
            var tsWaitForDays = new TimeSpan( 1, 0, 0, 0 ); // Check for updates daily...

            switch ( cobCheckForUpdates.Text ) {
                case "Check for updates weekly.":
                    tsWaitForDays = new TimeSpan( 7, 0, 0, 0 );
                    break;
                case "Check for updates monthly.":
                    tsWaitForDays = new TimeSpan( 30, 0, 0, 0 );
                    break;
            }

            dtLastChecked += tsWaitForDays;

            if ( dtLastChecked < DateTime.Now || sWhen.Contains( "Now" ) ) {
                var xmlLatestVersion = new XmlDocument( );
                try {
                    xmlLatestVersion.Load( @"https://sistar21.github.io/Choicy/ChoicyVersion.xml" );
                    sLatestRelease = readXmlSetting( xmlLatestVersion, "/ChoicyVersions/LatestRelease", "0.0.0" );
                    sReleaseNotes = readXmlSetting( xmlLatestVersion, "/ChoicyVersions/ReleaseNotes", "Sorry, did not find any release notes..." );
                    if ( sReleaseNotes == "Sorry, did not find any release notes..." ) {
                        if ( ShowYesNoQuestion( "Sorry, did not find any release notes...\n" +
                                                 "Go to the Download page now?" ) == DialogResult.Yes ) {
                            ExecuteThis( "https://sistar21.github.io/Choicy/downloads.html" );
                            Application.Exit( );
                        }
                    }
                    else if ( sCurrentRelease != sLatestRelease ) {
                        if ( ShowYesNoQuestion( "A different version (" + sLatestRelease + ") of Choicy (currently " + sCurrentRelease + ") " +
                                                 "is available.\n" + sReleaseNotes + "\n" +
                                                 "Go to the Download page now?" ) == DialogResult.Yes ) {
                            ExecuteThis( "https://sistar21.github.io/Choicy/downloads.html" );
                            Application.Exit( );
                        }
                    }
                    else if ( sWhen.Contains( "Now" ) ) {
                        ShowInfo( sCurrentRelease + " is the latest version." );
                    }
                    lblLastChecked.Text = "Last Checked: " + StandardizeDate( DateTime.Now );
                }
                catch ( Exception e ) {
                    ShowInfo( "Tried to check for updates but had a problem...\n" + e.Message );
                }
            }
        }
		
#endregion Version Handling

#region Settings

        /// <summary>
        /// Read the setting of one XML element
        /// </summary>
        /// <param name="doc">The XML Document to read from.</param>
        /// <param name="sSettingName">The XML element name.</param>
        /// <param name="sDefault">The default value if the setting is not found.</param>
        /// <returns>The setting as string, if found, otherwise the default value.</returns>
        string readXmlSetting( XmlDocument doc, string sSettingName, string sDefault )
        {
            string sText = "";
            XmlNode node = doc.DocumentElement.SelectSingleNode( sSettingName );
            if ( node == null ) sText = sDefault;
            else {
                sText = node.InnerText;
                if ( sText == null ) sText = sDefault;
            }
            return sText;
        }

        /// <summary>
        /// Loads the XML settings. 
        /// </summary>
        void LoadSettings( bool bReset )
        {
            if ( !File.Exists( strXmlSettingsFilePath ) || bReset ) {
                using ( XmlWriter writer = XmlWriter.Create( strXmlSettingsFilePath ) ) // create a dummy
                {
                    writer.WriteStartDocument( );
                    writer.WriteStartElement( "ChoicySettings" );  // root exlement
                    writer.WriteEndElement( );  // close the root element
                    writer.WriteEndDocument( );
                }
            }

            var xmlSettings = new XmlDocument( );
            xmlSettings.Load( strXmlSettingsFilePath );

            // General settings			
            lblLastChecked.Text = readXmlSetting( xmlSettings, "/ChoicySettings/General/LastChecked", "Last Checked: Never" );
            cobCheckForUpdates.Text = readXmlSetting( xmlSettings, "/ChoicySettings/General/CheckForUpdates", "Check for updates daily." );
            strActiveListName = readXmlSetting( xmlSettings, "/ChoicySettings/General/ActiveListName", "Choicy.choicy" );
        }


        /// <summary>
        /// Save the XML settings.
        /// </summary>
        void SaveSettings( )
        {
            using ( XmlWriter writer = XmlWriter.Create( strXmlSettingsFilePath ) ) {
                writer.WriteStartDocument( );
                writer.WriteStartElement( "ChoicySettings" );  // root exlement

                writer.WriteStartElement( "General" );  // General settings group
                writer.WriteElementString( "LastChecked", lblLastChecked.Text );
                writer.WriteElementString( "CheckForUpdates", cobCheckForUpdates.Text );
                writer.WriteElementString( "ActiveListName", strActiveListName );
                writer.WriteEndElement( );

                writer.WriteEndElement( );  // close the root element
                writer.WriteEndDocument( );
            }
		}

#endregion Settings

		bool CheckInput()
		{
			if (rtbSelectionText.Lines.Length < 2 ) {
				ShowWarning( "There are not enought choises in the input.\n" +
				             "Note that the first line is the title." );
				return false;
			}
			int iChoices = 0;
			foreach ( string strLine in rtbSelectionText.Lines ) {
				if (strLine.Length > 0 ) iChoices++;
			}
			if ( iChoices < 3 ) {
				ShowWarning( "There have to be at least two choices in the list.\n" +
				              "Note that the first line is the title and empty lines are not counted." );
				return false;
			}
			return true;
		}
		
		void SelectLine ( int iLine ) 
		{
			if ( iLine > rtbSelectionText.Lines.Length ) {
				iLine = rtbSelectionText.Lines.Length;
			}
			int iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iLine );
			string strChoosenLineText = rtbSelectionText.Lines[ iLine ];
			rtbSelectionText.Select( iFirstCharIndex, strChoosenLineText.Length );
		}

		void ColorStatistics ( int iLine ) 
		{
			Regex rgxStatistics = new Regex (@"\[\d+\]$");
			
			if ( iLine > rtbSelectionText.Lines.Length ) {
				iLine = rtbSelectionText.Lines.Length;
			}
			
			string strChoosenLineText = rtbSelectionText.Lines[ iLine ];
			if ( rgxStatistics.IsMatch( strChoosenLineText ) ) {
				Match mtch = rgxStatistics.Match( strChoosenLineText );
				int iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iLine ) + mtch.Index;
				rtbSelectionText.Select( iFirstCharIndex, mtch.Length );
				rtbSelectionText.SelectionColor = Color.Gray;
			}
		}
		
		void IncreaseStatistics ( int iLine ) 
		{
			Regex rgxStatistics = new Regex (@"\[\d+\]$");
			
			if ( iLine > rtbSelectionText.Lines.Length ) {
				iLine = rtbSelectionText.Lines.Length;
			}
			
			string strChoosenLineText = rtbSelectionText.Lines[ iLine ];
			if ( rgxStatistics.IsMatch( strChoosenLineText ) ) {
				Match mtch = rgxStatistics.Match( strChoosenLineText );
				int iStatisticsCount = Convert.ToInt32( Regex.Match( mtch.Value, @"\d+" ).Value );
				int iFirstCharIndex = rtbSelectionText.GetFirstCharIndexFromLine( iLine ) + mtch.Index;
				rtbSelectionText.Select( iFirstCharIndex, mtch.Length );
				iStatisticsCount++;
				rtbSelectionText.SelectedText = "[" + iStatisticsCount + "]";
			}
			else {
				SelectLine ( iLine );
				rtbSelectionText.SelectedText = strChoosenLineText + " [1]";
			}
			ColorStatistics ( iLine );
		}
		
		void ResetSelectionText ( ) 
		{
			// reset the whole rich text box to black default font
			for ( int iLineNumber = 0;  iLineNumber < rtbSelectionText.Lines.Length; iLineNumber++ ) {
				ResetLine ( iLineNumber );
			}
			
			// make the first line bold
			SelectLine ( 0 );
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Bold);
			rtbSelectionText.Update();
		}
		
		void ResetLine ( int iLine )
		{
			SelectLine ( iLine );
			rtbSelectionText.SelectionColor = Color.Black;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style );
			ColorStatistics ( iLine );
			rtbSelectionText.Update();
		}
		
		void ChooseNewLine ( )
		{
			int iLastLine = iRandomLine;
			ResetLine ( iLastLine );

			// get a new random line
			iRandomLine = 1;
			do {
				iRandomLine = rndThis.Next( 1, rtbSelectionText.Lines.Length );
			} 
			while ( rtbSelectionText.Lines[ iRandomLine ].Length == 0 && iLastLine != iRandomLine );

			// make the new random line green
			SelectLine ( iRandomLine );
			rtbSelectionText.SelectionColor = Color.Green;
			rtbSelectionText.SelectionFont = new Font(rtbSelectionText.Font, rtbSelectionText.Font.Style | FontStyle.Bold);
			ColorStatistics ( iRandomLine );
		}
		
		void BtnChooseClick(object sender, EventArgs e)
		{
			if ( !CheckInput() ) return;
			iChoiceCounter = 50;
			tmrChoicy.Enabled = true;
		}
		
		void LoadList ( string strListName )
		{
			if ( File.Exists ( strListName ) ) 
			{
				rtbSelectionText.LoadFile ( strListName );
				ResetSelectionText();
				strActiveListName = strListName;
			}
		}
		
		void BtnOpenClick(object sender, EventArgs e)
		{
			if ( ofdChoicy.ShowDialog() == DialogResult.OK ) {	
				LoadList ( ofdChoicy.FileName );
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			sfdChoicy.FileName = strActiveListName;
			if ( sfdChoicy.ShowDialog() == DialogResult.OK ) {
				rtbSelectionText.SaveFile ( sfdChoicy.FileName );
				strActiveListName = sfdChoicy.FileName;
			}
		}
		
		void BtnCheckVersionClick(object sender, EventArgs e)
		{
			CheckLatestVersion ("Now");
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings ();
		}
		
		void TmrChoicyTick(object sender, EventArgs e)
		{
			if ( iChoiceCounter > 0 ) {
				ChooseNewLine ( );
				iChoiceCounter--;
			}
			else {
				tmrChoicy.Enabled = false;
				IncreaseStatistics ( iRandomLine );
				IncreaseStatistics ( 0 );
			}
		}
		void WbInstructionsDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			/*
			dynamic htmldoc = wbInstructions.Document.DomDocument as dynamic;
	        dynamic nodelist = htmldoc.getElementByClassName ("navbar-wrapper") as dynamic;
	        nodelist.removeChild(nodelist);
	        */
		}
	}
}