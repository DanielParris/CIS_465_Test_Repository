/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This page allows employees to choose the category for the item they update.
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Employees_UpdateInventoryItem_Start : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DA_CoolerInventory coolerInventoryDAObject =
            new DA_CoolerInventory();


        grdvCooler.DataSource = coolerInventoryDAObject.GetCoolerInverntory();
        grdvCooler.DataBind();
    }



     
      
}