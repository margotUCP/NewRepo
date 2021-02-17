using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source=;Initial Catalog= ;User ID=;Password=";

            cnn = new SqlConnection(connetionString);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select TutorialID,TutorialName from demotb";

            command = new SqlCommand(sql, cnn);

            dataReader = sqlquery.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>";
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into demotb(TutorialID,TutorialName) value(3, '" + "VB.Net +"')";


            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();


            SqlCommand sqlquery;
            SqlDataReader dataReader;
            String Output = " ";
            sql = "Select TutorialID,TutorialName from demotb";

            sqlquery = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>";
            }


            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Update demotb set TutorialName='"VB.Net Complete"+"' where TutorialID=3";


            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery;

            command.Dispose(): 

            SqlCommand sqlquery;
            SqlDataReader dataReader;
            String Output = " ";
            sql = "Select TutorialID,TutorialName from demotb";

            sqlquery = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>";
            }

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Delete demotb where TutorialID=3";

            command = new SqlCommand(sql, cnn);

            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery;

            SqlCommand sqlquery;
            SqlDataReader dataReader;
            String Output = "";
            sql = "Select TutorialID,TutorialName from demotb";

            sqlquery = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>";
            }/**/

            Response.Write(Output);
            dataReader.Close();
            command.dispose();
            



            Response.Write("Connection MAde");
            conn.Close();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(txtName.Text + "</br>");

            Response.Write(lstLocation.SelectedItem.Text + "</br>");

            lblName.Visible = faux;
            txtName.Visible = false;
            lstLocation.Visible = faux;
            chkC.Visible = faux;
            chkASP.Visible = faux;
            rdFemale.Visible = faux;
            btnSubmit.Visible = faux;
        }
    }
}