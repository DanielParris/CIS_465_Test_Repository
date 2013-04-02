/*
 * Program: Project 5 by Daniel Parris
 * Programmer: Daniel Parris
 * Date: 04/05/11
 * Description: This class holds code for the Cooler Inventory portion of the project.
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
/// Summary description for DA_CoolerInventory
/// </summary>
public class DA_CoolerInventory
{

    HttpContext currentContext = HttpContext.Current;

	public DA_CoolerInventory()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable GetCoolerProducts(string parCooler_CategoryCode)
    {
        //1. Build connection object
        string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=|DataDirectory|" + "Project_5.accdb;";
        

        OleDbConnection connectionObject =
            new OleDbConnection(connectionString);
        connectionObject.Open();

        //2. Construct sql string

        //MAKE SURE TO CHANGE YOUR SQL STRING RIGHT VVVV  THERE.

        string sqlString = "Select * From CoolerInventory " +
                        "Where CoolerCategory=?";
        
        //3. Build Command object 
        OleDbCommand commandObject = new OleDbCommand();
        commandObject.Connection = connectionObject;
        commandObject.CommandType = CommandType.Text;
        commandObject.CommandText = sqlString;
        commandObject.Parameters.AddWithValue("@CoolerModelNo", parCooler_CategoryCode);


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

    public DataRow GetCoolerProduct(string parCoolerModelNo)
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

        string sqlString = "Select * From CoolerInventory " +
                        "Where CoolerModelNo=?";
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
        commandObject.Parameters.AddWithValue("@coolerModelNo", parCoolerModelNo);

        //Fill the DataTable object
        dataAdapterObject.Fill(dataTableObject);

        //Grab the values out of the first (and only) row of
        //the DataTable object and put it in a DataRow object
        DataRow dataRowObject = dataTableObject.Rows[0];

        //6. Close the connection. 
        //Always do this!
        connectionObject.Close();
        return dataRowObject;
    }


    public DataTable GetCoolerInverntory()
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

        string sqlString = "Select * From CoolerInventory " +
                        "Order By CoolerCategory";
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

    public void UpdateCoolerItem(int parCoolerModelNo, string parCoolerName, string parCoolerDescription,
                                    int parCoolerCategory, decimal parCoolerPrice, string parCoolerImageFileName)
    {
        //1. Build connection object
        string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=|DataDirectory|" + "Project_5.accdb;";
        currentContext.Trace.Warn("connectionString = " + connectionString);

        OleDbConnection connectionObject =
            new OleDbConnection(connectionString);
        connectionObject.Open();

        string sqlString = "UPDATE CoolerInventory " +
                        "SET " +
                        "CoolerName=?," +
                        "CoolerDescription=?," +
                        "CoolerCategory=?," +
                        "CoolerPrice=?," +
                        "CoolerImageFileName=? " +
                        " WHERE CoolerModelNo=?";

        //3b. Set the Command object properties  properties
        OleDbCommand commandObject = new OleDbCommand();
        commandObject.Connection = connectionObject;
        commandObject.CommandType = CommandType.Text;
        commandObject.CommandText = sqlString;

        //3c. Add parameters to collection
        commandObject.Parameters.AddWithValue("@CoolerName", parCoolerName);
        commandObject.Parameters.AddWithValue("@CoolerDescription", parCoolerDescription);
        commandObject.Parameters.AddWithValue("@CoolerCategory", parCoolerCategory);
        commandObject.Parameters.AddWithValue("@CoolerPrice", parCoolerPrice);
        commandObject.Parameters.AddWithValue("@CoolerImageFileName", parCoolerImageFileName);
        commandObject.Parameters.AddWithValue("@CoolerModelNo", parCoolerModelNo);

        //4. Execute the INSERT command on the database
        commandObject.ExecuteNonQuery();

        //5.Close Connection Object (and pass variable.)
        connectionObject.Close();


        currentContext.Trace.Warn("CoolerModelNo" + parCoolerModelNo);
        currentContext.Trace.Warn("CoolerName" + parCoolerName);
        currentContext.Trace.Warn("CoolerDescription" + parCoolerDescription);
        currentContext.Trace.Warn("CoolerCategory" + parCoolerCategory);
        currentContext.Trace.Warn("CoolerPrice" + parCoolerPrice);
        currentContext.Trace.Warn("CoolerImageFileName" + parCoolerImageFileName);
    }

    public void AddCoolerItem(int parCoolerModelNo, string parCoolerName, string parCoolerDescription,
                                    int parCoolerCategory, decimal parCoolerPrice, string parCoolerImageFileName)
    {
        //1. Build connection object
        string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=|DataDirectory|" + "Project_5.accdb;";
        currentContext.Trace.Warn("connectionString = " + connectionString);

        OleDbConnection connectionObject =
            new OleDbConnection(connectionString);
        connectionObject.Open();



        //3a. Build the sql string
        string sqlString = "INSERT INTO CoolerInventory " +
                   "(CoolerModelNo, CoolerName, CoolerDescription, " +
                   "CoolerCategory, CoolerPrice, CoolerImageFileName)" +
                   "    VALUES(?, ?, ?, ?, ?, ?)";


        //3. Set the Command object  properties
        OleDbCommand commandObject = new OleDbCommand();
        commandObject.Connection = connectionObject;
        commandObject.CommandType = CommandType.Text;
        commandObject.CommandText = sqlString;

        //3c. Add parameters to collection
        commandObject.Parameters.AddWithValue("@CoolerModelNo", parCoolerModelNo);
        commandObject.Parameters.AddWithValue("@CoolerName", parCoolerName);
        commandObject.Parameters.AddWithValue("@CoolerDescription", parCoolerDescription);
        commandObject.Parameters.AddWithValue("@CoolerCategory", parCoolerCategory);
        commandObject.Parameters.AddWithValue("@CoolerPrice", parCoolerPrice);
        commandObject.Parameters.AddWithValue("@CoolerImageFileName", parCoolerImageFileName);

        currentContext.Trace.Warn("CoolerModelNo = " + parCoolerModelNo);
        currentContext.Trace.Warn("CoolerName = " + parCoolerName);
        currentContext.Trace.Warn("CoolerDescription = " + parCoolerDescription);
        currentContext.Trace.Warn("CoolerCategory = " + parCoolerCategory);
        currentContext.Trace.Warn("CoolerPrice = " + parCoolerPrice);
        currentContext.Trace.Warn("CoolerImageFileName = " + parCoolerImageFileName);

        //4. Execute the INSERT command on the database
        commandObject.ExecuteNonQuery();

        //5.Close Connection Object (and pass variable.)
        connectionObject.Close();
    }

}