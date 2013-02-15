/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This page allows employees to update items in the cooler inventory.
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Employees_UpdateInventoryItem : System.Web.UI.Page
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

            string coolerModelNo = Request.QueryString["qryCoolerID"];
           
            DA_CoolerInventory coolernventoryDAObject =
             new DA_CoolerInventory();
            DataRow dataRowObject = coolernventoryDAObject.GetCoolerProduct(coolerModelNo);

            //Assign the field values of the DataRow object to variables
            //string coolerModelNo = Convert.ToString(dataRowObject["CoolerModelNo"]);
            string coolerName = Convert.ToString(dataRowObject["CoolerName"]);
            string coolerDescription = Convert.ToString(dataRowObject["CoolerDescription"]);
            int coolerCategory = Convert.ToInt32(dataRowObject["CoolerCategory"]);
            decimal coolerPrice = Convert.ToDecimal(dataRowObject["CoolerPrice"]);
            string coolerImageFileName = Convert.ToString(dataRowObject["CoolerImageFileName"]);

            //Display Results
            txtCoolerModelNo.Text = coolerModelNo;
            txtCoolerName.Text = coolerName;
            txtCoolerDescription.Text = coolerDescription;
            txtCoolerCategory.Text = coolerCategory.ToString();
            txtCoolerPrice.Text = coolerPrice.ToString();
            txtImageFileName.Text = coolerImageFileName;

    }
    protected void butUpdate_Click(object sender, EventArgs e)
    {
        //1.Declare Local Variables
        int coolerModelNo = Convert.ToInt32(txtCoolerModelNo.Text);
        string coolerName = txtCoolerName.Text;
        string coolerDescription = txtCoolerDescription.Text;
        int coolerCategory = Convert.ToInt32(txtCoolerCategory.Text);
        decimal coolerPrice = Convert.ToDecimal(txtCoolerPrice.Text);
        string coolerImageFileName = txtImageFileName.Text;

        DA_CoolerInventory coolerInventoryDAObject =
          new DA_CoolerInventory();

        coolerInventoryDAObject.UpdateCoolerItem(coolerModelNo, coolerName, coolerDescription, coolerCategory,
                                                 coolerPrice, coolerImageFileName);

        
            lblCoolerModelNo.Text = Convert.ToString(coolerModelNo);
            lblCoolerName.Text = coolerName;
            lblCoolerDescription.Text = coolerDescription;
            lblCoolerCategory.Text = Convert.ToString(coolerCategory);
            lblCoolerPrice.Text = Convert.ToString(coolerPrice);
            lblCoolerImageFileName.Text = coolerImageFileName;   
    }
}