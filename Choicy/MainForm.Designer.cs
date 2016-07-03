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
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.RichTextBox rtbSelectionText;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.RadioButton rbWords;
		private System.Windows.Forms.RadioButton rbLines;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblChoicy;
		
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
			this.tcChoicy = new System.Windows.Forms.TabControl();
			this.tpText = new System.Windows.Forms.TabPage();
			this.rbWords = new System.Windows.Forms.RadioButton();
			this.rbLines = new System.Windows.Forms.RadioButton();
			this.rtbSelectionText = new System.Windows.Forms.RichTextBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.tpAbout = new System.Windows.Forms.TabPage();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblChoicy = new System.Windows.Forms.Label();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tcChoicy.SuspendLayout();
			this.tpText.SuspendLayout();
			this.tpAbout.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcChoicy
			// 
			this.tcChoicy.Controls.Add(this.tpText);
			this.tcChoicy.Controls.Add(this.tpAbout);
			this.tcChoicy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcChoicy.Location = new System.Drawing.Point(0, 0);
			this.tcChoicy.Name = "tcChoicy";
			this.tcChoicy.SelectedIndex = 0;
			this.tcChoicy.Size = new System.Drawing.Size(284, 262);
			this.tcChoicy.TabIndex = 0;
			// 
			// tpText
			// 
			this.tpText.Controls.Add(this.rbWords);
			this.tpText.Controls.Add(this.rbLines);
			this.tpText.Controls.Add(this.rtbSelectionText);
			this.tpText.Controls.Add(this.btnChoose);
			this.tpText.Location = new System.Drawing.Point(4, 22);
			this.tpText.Name = "tpText";
			this.tpText.Padding = new System.Windows.Forms.Padding(3);
			this.tpText.Size = new System.Drawing.Size(276, 236);
			this.tpText.TabIndex = 0;
			this.tpText.Text = "Text";
			this.tpText.UseVisualStyleBackColor = true;
			// 
			// rbWords
			// 
			this.rbWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbWords.Location = new System.Drawing.Point(146, 6);
			this.rbWords.Name = "rbWords";
			this.rbWords.Size = new System.Drawing.Size(60, 24);
			this.rbWords.TabIndex = 3;
			this.rbWords.Text = "Words";
			this.rbWords.UseVisualStyleBackColor = true;
			// 
			// rbLines
			// 
			this.rbLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbLines.Checked = true;
			this.rbLines.Location = new System.Drawing.Point(212, 6);
			this.rbLines.Name = "rbLines";
			this.rbLines.Size = new System.Drawing.Size(56, 24);
			this.rbLines.TabIndex = 2;
			this.rbLines.TabStop = true;
			this.rbLines.Text = "Lines";
			this.rbLines.UseVisualStyleBackColor = true;
			// 
			// rtbSelectionText
			// 
			this.rtbSelectionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSelectionText.Location = new System.Drawing.Point(8, 35);
			this.rtbSelectionText.Name = "rtbSelectionText";
			this.rtbSelectionText.Size = new System.Drawing.Size(260, 180);
			this.rtbSelectionText.TabIndex = 1;
			this.rtbSelectionText.Text = "Right text here and click \"Choose\".\n\nPizza\nBurger\nChicken\nSushi\nPhad Thai\nSalad\nI" +
	"ce cream";
			// 
			// btnChoose
			// 
			this.btnChoose.Location = new System.Drawing.Point(8, 6);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(75, 23);
			this.btnChoose.TabIndex = 0;
			this.btnChoose.Text = "Choose";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.BtnChooseClick);
			// 
			// tpAbout
			// 
			this.tpAbout.Controls.Add(this.lblVersion);
			this.tpAbout.Controls.Add(this.lblChoicy);
			this.tpAbout.Controls.Add(this.lblCopyright);
			this.tpAbout.Location = new System.Drawing.Point(4, 22);
			this.tpAbout.Name = "tpAbout";
			this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
			this.tpAbout.Size = new System.Drawing.Size(276, 236);
			this.tpAbout.TabIndex = 1;
			this.tpAbout.Text = "About";
			this.tpAbout.UseVisualStyleBackColor = true;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.Location = new System.Drawing.Point(8, 57);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(260, 23);
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
			this.lblChoicy.Size = new System.Drawing.Size(260, 23);
			this.lblChoicy.TabIndex = 1;
			this.lblChoicy.Text = "Choicy";
			this.lblChoicy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblChoicy.Click += new System.EventHandler(this.LblChoicyClick);
			// 
			// lblCopyright
			// 
			this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblCopyright.Location = new System.Drawing.Point(8, 104);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(260, 30);
			this.lblCopyright.TabIndex = 0;
			this.lblCopyright.Text = "Copyright 2016 Sistar21";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 240);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(284, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tcChoicy);
			this.Name = "MainForm";
			this.Text = "Choicy";
			this.tcChoicy.ResumeLayout(false);
			this.tpText.ResumeLayout(false);
			this.tpAbout.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
