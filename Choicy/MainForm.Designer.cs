/*
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
			this.tpAbout = new System.Windows.Forms.TabPage();
			this.btnCheckVersion = new System.Windows.Forms.Button();
			this.lblLastChecked = new System.Windows.Forms.Label();
			this.cobCheckForUpdates = new System.Windows.Forms.ComboBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblChoicy = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.sfdChoicy = new System.Windows.Forms.SaveFileDialog();
			this.ofdChoicy = new System.Windows.Forms.OpenFileDialog();
			this.wbInstructions = new System.Windows.Forms.WebBrowser();
			this.tcChoicy.SuspendLayout();
			this.tpText.SuspendLayout();
			this.tpIntructions.SuspendLayout();
			this.tpAbout.SuspendLayout();
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
			this.tcChoicy.Size = new System.Drawing.Size(351, 258);
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
			this.tpText.Size = new System.Drawing.Size(343, 232);
			this.tpText.TabIndex = 0;
			this.tpText.Text = "Text";
			this.tpText.UseVisualStyleBackColor = true;
			// 
			// btnOpen
			// 
			this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpen.ImageKey = "Open";
			this.btnOpen.ImageList = this.ilChoicy;
			this.btnOpen.Location = new System.Drawing.Point(211, 6);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(60, 58);
			this.btnOpen.TabIndex = 3;
			this.btnOpen.Text = "Open";
			this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
			this.btnSave.Location = new System.Drawing.Point(277, 6);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(60, 58);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
			this.rtbSelectionText.Size = new System.Drawing.Size(327, 156);
			this.rtbSelectionText.TabIndex = 1;
			this.rtbSelectionText.Text = "Write the title here, your choices below the title and click \"Choose\".\n\nPizza\nBur" +
	"ger\nChicken\nSushi\nPhad Thai\nSalad\nIce cream";
			this.rtbSelectionText.WordWrap = false;
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
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.BtnChooseClick);
			// 
			// tpIntructions
			// 
			this.tpIntructions.Controls.Add(this.wbInstructions);
			this.tpIntructions.Location = new System.Drawing.Point(4, 22);
			this.tpIntructions.Name = "tpIntructions";
			this.tpIntructions.Size = new System.Drawing.Size(343, 232);
			this.tpIntructions.TabIndex = 2;
			this.tpIntructions.Text = "Intructions";
			this.tpIntructions.UseVisualStyleBackColor = true;
			// 
			// tpAbout
			// 
			this.tpAbout.Controls.Add(this.btnCheckVersion);
			this.tpAbout.Controls.Add(this.lblLastChecked);
			this.tpAbout.Controls.Add(this.cobCheckForUpdates);
			this.tpAbout.Controls.Add(this.lblVersion);
			this.tpAbout.Controls.Add(this.lblChoicy);
			this.tpAbout.Controls.Add(this.lblCopyright);
			this.tpAbout.Location = new System.Drawing.Point(4, 22);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tpAbout.Size = new System.Drawing.Size(343, 232);
			this.tpAbout.TabIndex = 1;
			this.tpAbout.Text = "About";
			this.tpAbout.UseVisualStyleBackColor = true;
			// 
			// btnCheckVersion
			// 
			this.btnCheckVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCheckVersion.Location = new System.Drawing.Point(198, 112);
			this.btnCheckVersion.Name = "btnCheckVersion";
			this.btnCheckVersion.Size = new System.Drawing.Size(137, 23);
			this.btnCheckVersion.TabIndex = 5;
			this.btnCheckVersion.Text = "Check Version Now";
			this.btnCheckVersion.UseVisualStyleBackColor = true;
			this.btnCheckVersion.Click += new System.EventHandler(this.BtnCheckVersionClick);
			// 
			// lblLastChecked
			// 
			this.lblLastChecked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblLastChecked.Location = new System.Drawing.Point(8, 80);
			this.lblLastChecked.Name = "lblLastChecked";
			this.lblLastChecked.Size = new System.Drawing.Size(327, 23);
			this.lblLastChecked.TabIndex = 4;
			this.lblLastChecked.Text = "Last Checked: Never";
			this.lblLastChecked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cobCheckForUpdates
			// 
			this.cobCheckForUpdates.FormattingEnabled = true;
			this.cobCheckForUpdates.Items.AddRange(new object[] {
			"Check for updates daily.",
			"Check for updates weekly.",
			"Check for updates monthly."});
			this.cobCheckForUpdates.Location = new System.Drawing.Point(8, 112);
			this.cobCheckForUpdates.Name = "cobCheckForUpdates";
			this.cobCheckForUpdates.Size = new System.Drawing.Size(153, 21);
			this.cobCheckForUpdates.TabIndex = 3;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.Location = new System.Drawing.Point(8, 57);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(327, 23);
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
			this.lblChoicy.Size = new System.Drawing.Size(327, 23);
			this.lblChoicy.TabIndex = 1;
			this.lblChoicy.Text = "Choicy";
			this.lblChoicy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCopyright
			// 
			this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCopyright.Location = new System.Drawing.Point(8, 197);
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
			// wbInstructions
			// 
			this.wbInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbInstructions.Location = new System.Drawing.Point(0, 0);
			this.wbInstructions.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbInstructions.Name = "wbInstructions";
			this.wbInstructions.Size = new System.Drawing.Size(343, 232);
			this.wbInstructions.TabIndex = 0;
			this.wbInstructions.Url = new System.Uri("https://sistar21.github.io/Choicy/instructions.html", System.UriKind.Absolute);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 258);
			this.Controls.Add(this.tcChoicy);
			this.MinimumSize = new System.Drawing.Size(250, 296);
			this.Name = "MainForm";
			this.Text = "Choicy";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.tcChoicy.ResumeLayout(false);
			this.tpText.ResumeLayout(false);
			this.tpIntructions.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
