using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class FrmCars : Form
    {
        // DataSet to store DB Data in program memory
        //https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset?view=net-5.0
        DataSet carsDataset = new DataSet();

        /*The SqlDataAdapter in C# works as a bridge between a DataSet and a data source (SQL Server Database) to retrieve data. 
        The SqlDataAdapter is a class that represents a set of SQL commands and a database connection. 
        It can be used to fill the DataSet and update the data source.*/
        // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldataadapter?view=dotnet-plat-ext-5.0
        SqlDataAdapter carsDataAdapter;

        //forms data source - links controls to data
        //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource?view=net-5.0
        BindingSource carsBindingSource;

        // Create SQL Commands
        // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommandbuilder?view=dotnet-plat-ext-5.0
        SqlCommandBuilder dbSQLCommands;

        //4  - Connection String (Alex computer is: DESKTOP-6FRHGJC, adjust hostname accordingly)
        string DBConnectionString = @"Data Source=DESKTOP-6FRHGJC\SQLEXPRESS2019;Initial Catalog=Hire;Integrated Security=True;";
        public FrmCars()
        {
            InitializeComponent();
            //3 for top bar in the form
            this.Text = "Task A: Vehicle Details - Date: " + DateTime.Today.ToLongDateString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // BUTTON TESTING TO DB GOES HERE.
        }
    }
}
