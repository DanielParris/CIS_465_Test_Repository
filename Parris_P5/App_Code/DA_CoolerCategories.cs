/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This class holds code for the Cooler Categories portion of the project.
 * */


using System.Data;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for DA_CoolerCategories
/// </summary>
public class DA_CoolerCategories
{

    HttpContext currentContext = HttpContext.Current;

	public DA_CoolerCategories()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable GetCoolerCategories()
    {
        //1. Build connection object
        string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=|DataDirectory|" + "Project_5.accdb;";
        currentContext.Trace.Warn("connectionString = " + connectionString);

        OleDbConnection connectionObject =
            new OleDbConnection(connectionString);
        connectionObject.Open();

        //2. Construct sql string

        //MAKE SURE TO CHANGE YOUR SQL STRING RIGHT VVVV  THERE.

        string sqlString = "Select * From CoolerCategories " +
                        "Order By CoolerCategoryName";
        currentContext.Trace.Warn("sqlString = " + sqlString);
        //3. Build Command object 
        OleDbCommand commandObject = new OleDbCommand();
        commandObject.Connection = connectionObject;
        commandObject.CommandType = CommandType.Text;
        commandObject.CommandText = sqlString;



        //4. Use the DataAdapter to fill a DataTable object_//Instantiate a DataAdapter object
        OleDbDataAdapter dataAdapterObject =
            new OleDbDataAdapter();
        //Instantiate a DataTable object
        DataTable dataTableObject = new DataTable();

        //Set the SelectCommand property of the DataAdapter object to the filled Command object
        dataAdapterObject.SelectCommand = commandObject;

        //Fill the DataTable object
        dataAdapterObject.Fill(dataTableObject);

        //6. Close the connection. 
        //Always do this!
        connectionObject.Close();
        return dataTableObject;
    }
}