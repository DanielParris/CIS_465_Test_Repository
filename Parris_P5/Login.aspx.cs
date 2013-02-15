/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This is a login page to take you to the password protected employee folder.
 * */


using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ProtectedFolder_LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void butLogin_Click(object sender, EventArgs e)
    {
        string userName;
        string password;

        userName = txtUserName.Text;
        password = txtPassword.Text;

        if (FormsAuthentication.Authenticate(userName, password))
        {
            FormsAuthentication.RedirectFromLoginPage(userName, false);
        }
        else
        {
            lblErrorDisplay.Text = "Invalid Login!";

        }

    }

}//end of class
