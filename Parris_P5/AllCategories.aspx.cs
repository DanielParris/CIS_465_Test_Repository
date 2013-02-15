/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This is the home page of the Coleman site, where you choose your category.
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InventoryImages_AllCategories : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DA_CoolerCategories coolerCategoryDAObject =
            new DA_CoolerCategories();


        grdvCoolerCategories.DataSource = coolerCategoryDAObject.GetCoolerCategories();
        grdvCoolerCategories.DataBind();
    }

    
}