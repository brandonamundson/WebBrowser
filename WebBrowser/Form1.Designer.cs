using System.Windows.Forms;
using WebBrowser.Properties;

namespace WebBrowser
{
    partial class WebBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.browserDisplay = new System.Windows.Forms.WebBrowser();
			this.goToWeb = new System.Windows.Forms.Button();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.homeButton = new System.Windows.Forms.Button();
			this.backButton = new System.Windows.Forms.Button();
			this.forwardButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// browserDisplay
			// 
			this.browserDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.browserDisplay.Location = new System.Drawing.Point(15, 126);
			this.browserDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.browserDisplay.MinimumSize = new System.Drawing.Size(20, 20);
			this.browserDisplay.Name = "browserDisplay";
			this.browserDisplay.Size = new System.Drawing.Size(1215, 633);
			this.browserDisplay.TabIndex = 0;
			this.browserDisplay.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browserDisplay_Navigated);
			// 
			// goToWeb
			// 
			this.goToWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.goToWeb.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.goToWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.goToWeb.Location = new System.Drawing.Point(1160, 34);
			this.goToWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.goToWeb.Name = "goToWeb";
			this.goToWeb.Size = new System.Drawing.Size(69, 63);
			this.goToWeb.TabIndex = 1;
			this.goToWeb.Text = "Go";
			this.goToWeb.UseVisualStyleBackColor = false;
			this.goToWeb.Click += new System.EventHandler(this.goToWeb_Click);
			// 
			// urlBox
			// 
			this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.urlBox.BackColor = System.Drawing.SystemColors.Window;
			this.urlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.urlBox.Location = new System.Drawing.Point(344, 48);
			this.urlBox.Margin = new System.Windows.Forms.Padding(4);
			this.urlBox.Name = "urlBox";
			this.urlBox.Size = new System.Drawing.Size(808, 36);
			this.urlBox.TabIndex = 2;
			// 
			// homeButton
			// 
			this.homeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.homeButton.Location = new System.Drawing.Point(8, 36);
			this.homeButton.Margin = new System.Windows.Forms.Padding(4);
			this.homeButton.Name = "homeButton";
			this.homeButton.Size = new System.Drawing.Size(100, 63);
			this.homeButton.TabIndex = 3;
			this.homeButton.Text = "Home";
			this.homeButton.UseVisualStyleBackColor = false;
			this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
			// 
			// backButton
			// 
			this.backButton.BackColor = System.Drawing.Color.DarkSlateGray;
			this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backButton.Location = new System.Drawing.Point(116, 36);
			this.backButton.Margin = new System.Windows.Forms.Padding(4);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(85, 63);
			this.backButton.TabIndex = 4;
			this.backButton.Text = "Back";
			this.backButton.UseVisualStyleBackColor = false;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// forwardButton
			// 
			this.forwardButton.BackColor = System.Drawing.Color.DarkSlateGray;
			this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forwardButton.Location = new System.Drawing.Point(209, 36);
			this.forwardButton.Margin = new System.Windows.Forms.Padding(4);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(127, 64);
			this.forwardButton.TabIndex = 5;
			this.forwardButton.Text = "Forward";
			this.forwardButton.UseVisualStyleBackColor = false;
			this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
			// 
			// WebBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WebBrowser.Properties.Resources.spider_webs;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1244, 772);
			this.Controls.Add(this.forwardButton);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.homeButton);
			this.Controls.Add(this.urlBox);
			this.Controls.Add(this.goToWeb);
			this.Controls.Add(this.browserDisplay);
			this.Icon = global::WebBrowser.Properties.Resources.web;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "WebBrowser";
			this.Text = "Web Browser";
			this.Load += new System.EventHandler(this.WebBrowser_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.WebBrowser browserDisplay;
		private System.Windows.Forms.Button goToWeb;
		private System.Windows.Forms.TextBox urlBox;
		private System.Windows.Forms.Button homeButton;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button forwardButton;
	}
}

