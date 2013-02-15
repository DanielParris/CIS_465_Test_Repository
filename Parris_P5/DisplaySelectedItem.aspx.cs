/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This page shows the cooler you have selected and gives details about it.
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DisplaySelectedItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
       string coolerModelNo = (Request.QueryString["qrySKU"]);


       DA_CoolerInventory coolernventoryDAObject =
           new DA_CoolerInventory();
       DataRow dataRowObject = coolernventoryDAObject.GetCoolerProduct(coolerModelNo);
   
       
        //Assign the field values of the DataRow object to variables
        string coolerCategory = Convert.ToString(dataRowObject["CoolerCategory"]);
        //string coolerModelNo = Convert.ToString(dataRowObject["CoolerModelNo"]);
        string coolerName = Convert.ToString(dataRowObject["CoolerName"]);
        decimal coolerPrice = Convert.ToDecimal(dataRowObject["CoolerPrice"]);
        string coolerDescription = Convert.ToString(dataRowObject["CoolerDescription"]);
        string coolerImageFileName = Convert.ToString(dataRowObject["CoolerImageFileName"]);
        imgCooler.ImageUrl = "InventoryImages/" + coolerImageFileName;

        //Display Results
        lblCoolerModelNo.Text = coolerModelNo;
        lblCoolerName.Text = coolerName;
        lblCoolerCategory.Text = coolerCategory;
        lblCoolerPrice.Text = coolerPrice.ToString("C");
        lblCoolerDescription.Text = coolerDescription;
        lblCoolerCat.Text = coolerCategory;


         DA_CoolerCategories coolerCategoryDAObject =
            new DA_CoolerCategories();


        grdvCoolerCategories.DataSource = coolerCategoryDAObject.GetCoolerCategories();
        grdvCoolerCategories.DataBind();

        
    }

   
}