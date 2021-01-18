using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class WebBrowser : Form
    {
	    //sets the homepage as duckduckgo.com search engine
	    string homepage = "https://duckduckgo.com";


	    /// <summary>
	    /// initializer function for the form.  Pre-created, some components added
	    /// </summary>
	    public WebBrowser()
         {
	         InitializeComponent();
		    //surppresses javascript errors from appearing.
	         browserDisplay.ScriptErrorsSuppressed = true;

		    //adds event handlers letting user know if they are able to continue using back/forward buttons
	         browserDisplay.CanGoBackChanged += browserDisplay_CanGoBackChanged;
	         browserDisplay.CanGoForwardChanged += browserDisplay_CanGoForwardChanged;

		    //adds key event handler allowing enter key to press button
	         urlBox.KeyDown += goToWeb_KeyDown;
         }

	    /// <summary>
	    /// function to navigate to web address entered once go button is clicked.
	    /// </summary>
	    private void goToWeb_Click(object sender, EventArgs e)
	    {
		    //if nothing entered, do nothing
		    if (string.IsNullOrEmpty(urlBox.Text)) 
			    return;
		    
		    //if address is about:blank, do nothing
		    if (urlBox.Text.Equals("about:blank"))
				return;
		    
		    //if address is missing http or https prefix, add it and then go
		    if (!urlBox.Text.StartsWith("http://") &&
			    !urlBox.Text.StartsWith("https://"))
		    {
				urlBox.Text = "http://" + urlBox.Text;
		    }

		    //attempt to navigate, if it fails catch the exception but do nothing.
		    try
		    { 
			    browserDisplay.Navigate(new Uri(urlBox.Text));
		    }
		    catch (System.UriFormatException)
		    {
				return;
		    }
	    }

	    /// <summary>
	    /// set the url box and navigate to the url.
	    /// </summary>
	    private void homeButton_Click(object sender, EventArgs e)
	    {
			urlBox.Text = homepage;
			browserDisplay.Navigate(homepage);
	    }

	    /// <summary>
	    /// upon form load, automatically go to homepage
	    /// </summary>
	    private void WebBrowser_Load(object sender, EventArgs e)
	    {
			urlBox.Text = homepage;
			browserDisplay.Navigate(homepage);
	    }

	    /// <summary>
	    /// if navigating through by clicking links, update the url text box.
	    /// </summary>
	    private void browserDisplay_Navigated(object sender, WebBrowserNavigatedEventArgs e)
	    { 
		    urlBox.Text = browserDisplay.Url.ToString();
	    }

	    /// <summary>
	    /// if we can go back, enable button; if we cant, disable the button.
	    /// </summary>
	    private void browserDisplay_CanGoBackChanged(object sender,
			EventArgs e)
	    {
		    backButton.Enabled = browserDisplay.CanGoBack;

		    backButton.BackColor = !backButton.Enabled ? System.Drawing.Color.DarkSlateGray : System.Drawing.SystemColors.ActiveCaption;
	    }

	    /// <summary>
	    /// to go back, use the browser display go back feature
	    /// </summary>
	    private void backButton_Click(object sender, EventArgs e)
	    {
			browserDisplay.GoBack();
	    }

	    /// <summary>
	    /// to go forward, use the browser display forward feature
	    /// </summary>
	    private void forwardButton_Click(object sender, EventArgs e)
	    {
			browserDisplay.GoForward();
	    }

	    /// <summary>
	    /// if we can go forward, enable button; if we cant, disable the button.
	    /// </summary>
	    private void browserDisplay_CanGoForwardChanged(object sender,
			EventArgs e)
	    {
		    forwardButton.Enabled = browserDisplay.CanGoForward;

		    forwardButton.BackColor = !forwardButton.Enabled ? System.Drawing.Color.DarkSlateGray : System.Drawing.SystemColors.ActiveCaption;
	    }

	    /// <summary>
	    /// if in the urlBox and enter key is hit, click button
	    /// </summary>
	    private void goToWeb_KeyDown(object sender, KeyEventArgs e)
	    {
			//if enter key was pressed, treat as clicking button
			if (e.KeyCode == Keys.Enter)
			{
				goToWeb.PerformClick();
			}
	    }
    }
}