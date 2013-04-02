/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This page allows employees to add a cooler to the 
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employees_AddItemToInventory : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            pnlInput.Visible = true;

            pnlDisplay.Visible = false;
        }

        if (Page.IsPostBack == true)
        {
            pnlInput.Visible = false;

            pnlDisplay.Visible = true;
        }          
    }  
    protected void butSubmit_Click(object sender, EventArgs e)
    {
        if (!Page.IsValid)
            return;

        //1.Declare Local Variables
        int coolerModelNo = Convert.ToInt32(txtCoolerModelNo.Text);
        string coolerName = txtCoolerName.Text;
        string coolerDescription = txtCoolerDescription.Text;
        int coolerCategory = Convert.ToInt32(ddlCoolerCategory.SelectedValue);
        decimal coolerPrice = Convert.ToDecimal(txtCoolerPrice.Text);
        string coolerImageFileName = txtImageFileName.Text;

        DA_CoolerInventory coolerInventoryDAObject =
          new DA_CoolerInventory();

        coolerInventoryDAObject.AddCoolerItem(coolerModelNo, coolerName, coolerDescription,
                                              coolerCategory, coolerPrice, coolerImageFileName);


          lblCoolerModelNo.Text = Convert.ToString(coolerModelNo);
          lblCoolerName.Text = coolerName;
          lblCoolerDescription.Text = coolerDescription;
          lblCoolerCategory.Text = Convert.ToString(coolerCategory);
          lblCoolerPrice.Text = Convert.ToString(coolerPrice);
          lblCoolerImageFileName.Text = coolerImageFileName;            
    }       
}