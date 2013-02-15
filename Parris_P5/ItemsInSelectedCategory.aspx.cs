/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This page shows all of the cooler items in the category you have selected.
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemsInSelectedCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //1. Declare Variables
        string category;

        //2. Get Values for Variables
        category = (Request.QueryString["qryCategoryCode"]);

        //4.Display Results
        lblCoolerCategory.Text = category;


        DA_CoolerInventory coolerInventoryDAObject =
            new DA_CoolerInventory();


        grdvCoolerItems.DataSource = coolerInventoryDAObject.GetCoolerProducts(category);
        grdvCoolerItems.DataBind();

        DA_CoolerCategories coolerCategoryDAObject =
            new DA_CoolerCategories();


        grdvCoolerCategories.DataSource = coolerCategoryDAObject.GetCoolerCategories();
        grdvCoolerCategories.DataBind();
    }

    
    
}