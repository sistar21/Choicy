﻿/*
 * Created by SharpDevelop.
 * User: rlauer
 * Date: 2016-07-03
 * Time: 09:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Choicy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tcChoicy;
		private System.Windows.Forms.TabPage tpText;
		private System.Windows.Forms.TabPage tpAbout;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.RichTextBox rtbSelectionText;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblChoicy;
		private System.Windows.Forms.TabPage tpIntructions;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.SaveFileDialog sfdChoicy;
		private System.Windows.Forms.OpenFileDialog ofdChoicy;
		private System.Windows.Forms.ImageList ilChoicy;
		private System.Windows.Forms.ComboBox cobCheckForUpdates;
		private System.Windows.Forms.Label lblLastChecked;
		private System.Windows.Forms.Button btnCheckVersion;
		private System.Windows.Forms.WebBrowser wbInstructions;
		private System.Windows.Forms.Timer tmrChoicy;
		private System.Windows.Forms.PictureBox pbChoicy;
		private System.Windows.Forms.ToolTip ttChoicy;
		private System.Windows.Forms.PictureBox pbHome;
		private System.Windows.Forms.PictureBox pbDonation;
		private System.Windows.Forms.WebBrowser wbLicense;
		
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
			this.tcChoicy = new System.Windows.Forms.TabControl();
			this.tpText = new System.Windows.Forms.TabPage();
			this.btnOpen = new System.Windows.Forms.Button();
			this.ilChoicy = new System.Windows.Forms.ImageList(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			this.rtbSelectionText = new System.Windows.Forms.RichTextBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.tpIntructions = new System.Windows.Forms.TabPage();
			this.wbInstructions = new System.Windows.Forms.WebBrowser();
			this.tpAbout = new System.Windows.Forms.TabPage();
			this.wbLicense = new System.Windows.Forms.WebBrowser();
			this.pbHome = new System.Windows.Forms.PictureBox();
			this.pbDonation = new System.Windows.Forms.PictureBox();
			this.pbChoicy = new System.Windows.Forms.PictureBox();
			this.btnCheckVersion = new System.Windows.Forms.Button();
			this.lblLastChecked = new System.Windows.Forms.Label();
			this.cobCheckForUpdates = new System.Windows.Forms.ComboBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblChoicy = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.sfdChoicy = new System.Windows.Forms.SaveFileDialog();
			this.ofdChoicy = new System.Windows.Forms.OpenFileDialog();
			this.tmrChoicy = new System.Windows.Forms.Timer(this.components);
			this.ttChoicy = new System.Windows.Forms.ToolTip(this.components);
			this.tcChoicy.SuspendLayout();
			this.tpText.SuspendLayout();
			this.tpIntructions.SuspendLayout();
			this.tpAbout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDonation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbChoicy)).BeginInit();
			this.SuspendLayout();
			// 
			// tcChoicy
			// 
			this.tcChoicy.Controls.Add(this.tpText);
			this.tcChoicy.Controls.Add(this.tpIntructions);
			this.tcChoicy.Controls.Add(this.tpAbout);
			this.tcChoicy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcChoicy.Location = new System.Drawing.Point(0, 0);
			this.tcChoicy.Name = "tcChoicy";
			this.tcChoicy.SelectedIndex = 0;
			this.tcChoicy.Size = new System.Drawing.Size(470, 478);
			this.tcChoicy.TabIndex = 0;
			// 
			// tpText
			// 
			this.tpText.Controls.Add(this.btnOpen);
			this.tpText.Controls.Add(this.btnSave);
			this.tpText.Controls.Add(this.rtbSelectionText);
			this.tpText.Controls.Add(this.btnChoose);
			this.tpText.Location = new System.Drawing.Point(4, 22);
			this.tpText.Name = "tpText";
			this.tpText.Padding = new System.Windows.Forms.Padding(3);
			this.tpText.Size = new System.Drawing.Size(462, 452);
			this.tpText.TabIndex = 0;
			this.tpText.Text = "Text";
			this.tpText.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.ImageKey = "Open";
			this.btnOpen.ImageList = this.ilChoicy;
			this.btnOpen.Location = new System.Drawing.Point(330, 6);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(60, 58);
			this.btnOpen.TabIndex = 3;
			this.btnOpen.Text = "Open";
			this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ttChoicy.SetToolTip(this.btnOpen, "Open a saved list of choices.");
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpenClick);
			// 
			// ilChoicy
			// 
			this.ilChoicy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilChoicy.ImageStream")));
			this.ilChoicy.TransparentColor = System.Drawing.Color.White;
			this.ilChoicy.Images.SetKeyName(0, "Choose");
			this.ilChoicy.Images.SetKeyName(1, "Save");
			this.ilChoicy.Images.SetKeyName(2, "Open");
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.ImageKey = "Save";
			this.btnSave.ImageList = this.ilChoicy;
			this.btnSave.Location = new System.Drawing.Point(396, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(60, 58);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ttChoicy.SetToolTip(this.btnSave, "Save the current list of choices.");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// rtbSelectionText
			// 
			this.rtbSelectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSelectionText.Location = new System.Drawing.Point(8, 70);
			this.rtbSelectionText.Name = "rtbSelectionText";
			this.rtbSelectionText.Size = new System.Drawing.Size(446, 376);
			this.rtbSelectionText.TabIndex = 1;
			this.rtbSelectionText.Text = "Write the title here, your choices below the title and click \"Choose\".\n\nPizza\nBur" +
	"ger\nChicken\nSushi\nPhad Thai\nSalad\nIce cream";
			this.ttChoicy.SetToolTip(this.rtbSelectionText, "Edit the list as you wish to customize it to your choices.");
			this.rtbSelectionText.WordWrap = false;
			this.rtbSelectionText.MouseEnter += new System.EventHandler(this.RtbMouseEnter);
			// 
			// btnChoose
			// 
			this.btnChoose.ImageKey = "Choose";
			this.btnChoose.ImageList = this.ilChoicy;
			this.btnChoose.Location = new System.Drawing.Point(8, 6);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(60, 58);
			this.btnChoose.TabIndex = 0;
			this.btnChoose.Text = "Choose";
			this.btnChoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.ttChoicy.SetToolTip(this.btnChoose, "Make a new choice.");
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.BtnChooseClick);
			// 
			// tpIntructions
			// 
			this.tpIntructions.Controls.Add(this.wbInstructions);
			this.tpIntructions.Location = new System.Drawing.Point(4, 22);
			this.tpIntructions.Name = "tpIntructions";
			this.tpIntructions.Size = new System.Drawing.Size(462, 452);
			this.tpIntructions.TabIndex = 2;
			this.tpIntructions.Text = "Intructions";
			this.tpIntructions.UseVisualStyleBackColor = true;
			// 
			// wbInstructions
			// 
			this.wbInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbInstructions.Location = new System.Drawing.Point(0, 0);
			this.wbInstructions.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbInstructions.Name = "wbInstructions";
			this.wbInstructions.Size = new System.Drawing.Size(462, 452);
			this.wbInstructions.TabIndex = 0;
			this.wbInstructions.Url = new System.Uri("https://sistar21.github.io/Choicy/instructions.html", System.UriKind.Absolute);
			this.wbInstructions.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WbInstructionsDocumentCompleted);
			// 
			// tpAbout
			// 
			this.tpAbout.Controls.Add(this.wbLicense);
			this.tpAbout.Controls.Add(this.pbHome);
			this.tpAbout.Controls.Add(this.pbDonation);
			this.tpAbout.Controls.Add(this.pbChoicy);
			this.tpAbout.Controls.Add(this.btnCheckVersion);
			this.tpAbout.Controls.Add(this.lblLastChecked);
			this.tpAbout.Controls.Add(this.cobCheckForUpdates);
			this.tpAbout.Controls.Add(this.lblVersion);
			this.tpAbout.Controls.Add(this.lblChoicy);
			this.tpAbout.Controls.Add(this.lblCopyright);
			this.tpAbout.Location = new System.Drawing.Point(4, 22);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tpAbout.Size = new System.Drawing.Size(462, 452);
			this.tpAbout.TabIndex = 1;
			this.tpAbout.Text = "About";
			this.tpAbout.UseVisualStyleBackColor = true;
			// 
			// wbLicense
			// 
			this.wbLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.wbLicense.Location = new System.Drawing.Point(0, 254);
			this.wbLicense.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbLicense.Name = "wbLicense";
			this.wbLicense.Size = new System.Drawing.Size(454, 192);
			this.wbLicense.TabIndex = 11;
			this.wbLicense.Url = new System.Uri("https://sistar21.github.io/Choicy/license.html", System.UriKind.Absolute);
			this.wbLicense.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WbLicenseDocumentCompleted);
			// 
			// pbHome
			// 
			this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
			this.pbHome.Location = new System.Drawing.Point(8, 6);
			this.pbHome.Name = "pbHome";
			this.pbHome.Size = new System.Drawing.Size(50, 50);
			this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHome.TabIndex = 10;
			this.pbHome.TabStop = false;
			this.ttChoicy.SetToolTip(this.pbHome, "Go to Choicy Home page");
			this.pbHome.Click += new System.EventHandler(this.PbHomeClick);
			// 
			// pbDonation
			// 
			this.pbDonation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbDonation.Image = ((System.Drawing.Image)(resources.GetObject("pbDonation.Image")));
			this.pbDonation.Location = new System.Drawing.Point(393, 6);
			this.pbDonation.Name = "pbDonation";
			this.pbDonation.Size = new System.Drawing.Size(61, 50);
			this.pbDonation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbDonation.TabIndex = 9;
			this.pbDonation.TabStop = false;
			this.ttChoicy.SetToolTip(this.pbDonation, "Make a small donation");
			this.pbDonation.Click += new System.EventHandler(this.PbDonationClick);
			// 
			// pbChoicy
			// 
			this.pbChoicy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbChoicy.Image = ((System.Drawing.Image)(resources.GetObject("pbChoicy.Image")));
			this.pbChoicy.ImageLocation = "";
			this.pbChoicy.Location = new System.Drawing.Point(8, 66);
			this.pbChoicy.Name = "pbChoicy";
			this.pbChoicy.Size = new System.Drawing.Size(446, 96);
			this.pbChoicy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbChoicy.TabIndex = 6;
			this.pbChoicy.TabStop = false;
			// 
			// btnCheckVersion
			// 
			this.btnCheckVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCheckVersion.Location = new System.Drawing.Point(237, 201);
			this.btnCheckVersion.Name = "btnCheckVersion";
			this.btnCheckVersion.Size = new System.Drawing.Size(158, 23);
			this.btnCheckVersion.TabIndex = 5;
			this.btnCheckVersion.Text = "Check Version Now";
			this.ttChoicy.SetToolTip(this.btnCheckVersion, "Check if your version is up to date.");
			this.btnCheckVersion.UseVisualStyleBackColor = true;
			this.btnCheckVersion.Click += new System.EventHandler(this.BtnCheckVersionClick);
			// 
			// lblLastChecked
			// 
			this.lblLastChecked.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblLastChecked.Location = new System.Drawing.Point(68, 175);
			this.lblLastChecked.Name = "lblLastChecked";
			this.lblLastChecked.Size = new System.Drawing.Size(327, 23);
			this.lblLastChecked.TabIndex = 4;
			this.lblLastChecked.Text = "Last Checked: Never";
			this.lblLastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cobCheckForUpdates
			// 
			this.cobCheckForUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cobCheckForUpdates.FormattingEnabled = true;
			this.cobCheckForUpdates.Items.AddRange(new object[] {
			"Check for updates daily.",
			"Check for updates weekly.",
			"Check for updates monthly."});
			this.cobCheckForUpdates.Location = new System.Drawing.Point(68, 201);
			this.cobCheckForUpdates.Name = "cobCheckForUpdates";
			this.cobCheckForUpdates.Size = new System.Drawing.Size(156, 21);
			this.cobCheckForUpdates.TabIndex = 3;
			this.ttChoicy.SetToolTip(this.cobCheckForUpdates, "Select the frequency of new version checks.");
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.Location = new System.Drawing.Point(8, 40);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(446, 23);
			this.lblVersion.TabIndex = 2;
			this.lblVersion.Text = "0.1";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblChoicy
			// 
			this.lblChoicy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblChoicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChoicy.Location = new System.Drawing.Point(8, 15);
			this.lblChoicy.Name = "lblChoicy";
			this.lblChoicy.Size = new System.Drawing.Size(446, 23);
			this.lblChoicy.TabIndex = 1;
			this.lblChoicy.Text = "Choicy";
			this.lblChoicy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCopyright
			// 
			this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblCopyright.Location = new System.Drawing.Point(68, 221);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(327, 30);
			this.lblCopyright.TabIndex = 0;
			this.lblCopyright.Text = "Copyright 2016 Amanda and Emma Lauer";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sfdChoicy
			// 
			this.sfdChoicy.DefaultExt = "choicy";
			this.sfdChoicy.Filter = "Choicy Lists|*.choicy";
			// 
			// ofdChoicy
			// 
			this.ofdChoicy.DefaultExt = "choicy";
			this.ofdChoicy.Filter = "Choicy Lists|*.choicy";
			// 
			// tmrChoicy
			// 
			this.tmrChoicy.Tick += new System.EventHandler(this.TmrChoicyTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 478);
			this.Controls.Add(this.tcChoicy);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(367, 324);
			this.Name = "MainForm";
			this.Text = "Choicy";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.tcChoicy.ResumeLayout(false);
			this.tpText.ResumeLayout(false);
			this.tpIntructions.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbDonation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbChoicy)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
