
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace TMS
{
	/// 
	/// \class Planner
	///
	/// \brief The Planner employee is responsible for furthering the order by selecting one or more registered Carriers to fulfill the Order, in the form of Trips.
	/// -  Planner receives Orders from the Buyer.
	/// -  Planner selects Carriers from the targeted cities to complete the Order, Which adds a ‘Trip’ to the Order for each Carrier selected
	/// -  The Planner may simulate the passage of time
	/// -  Planner may confirm an order is completed	
	/// -  Planner may see a summary of all active Orders in a status screen
	///
	/// 
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///

	public partial class Planner : Form
	{
		public Planner()
		{
			InitializeComponent();
		}

		/**
		* \brief    This function is used to load the starting page and reveal the settings for reviewing orders
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void Planner_StartingPage_Load(object sender, EventArgs e)
		{
			HandleDisplayData("p");
			
		}


		/**
		* \brief    This function is used to reveal settings for generating the summary report 
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void GenerateReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("g");

		}

		/**
		* \brief    This function is used to reveal settings for received orders. Order route etc.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("r");
			rOrder.Text = "Orders :";
			rSelectCarriersButton.Text = "Select Carrier";
			try
			{
				string connectionString = GetConnectionString('t');
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				rOrdersDropDown.Items.Clear();
				var cmd = sqlConnection.CreateCommand();
				cmd.CommandText = "SELECT client_name FROM orders WHERE order_status=0";
				var reader = cmd.ExecuteReader();
				rOrdersDropDown.Items.Clear();
				int count = 0;
				while (reader.Read())
				{
					rOrdersDropDown.Items.Insert(count, reader[0].ToString());
				}

			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
			}
		}


		/**
		* \brief    This function handles the data that is to be displayed for the settings selected.
		*
		* \param       whichMenu	- <b>string</b>
		* \return      None
		*
		*/
		private void HandleDisplayData(string whichMenu)
		{

			pLabel.Visible = false;
			pLoginButton.Visible = false;
			pPass.Visible = false;


			rOrder.Visible = false;
			rOrdersDropDown.Visible = false;
			rSelectCarriersButton.Visible = false;

			rrAddCarrierButton.Visible = false;
			rrAvailableCarriers.Visible = false;
			rrCarriersDropDown.Visible = false;

			aViewButton.Visible = false;
			aOrigin.Visible = false;
			aOriginValue.Visible = false;
			aDest.Visible = false;
			aDestValue.Visible = false;
			aDate.Visible = false;
			aDateValue.Visible = false;
			aStart.Visible = false;
			aStartValue.Visible = false;
			aEnd.Visible = false;
			aEndValue.Visible = false;
			aCompleteButton.Visible = false;


			gTime.Visible = false;
			gAllTimeRadio.Visible = false;
			g2WeeksRadio.Visible = false;
			gGenerateButton.Visible = false;

			if (whichMenu == "r")
			{
				rOrder.Visible = true;
				rOrdersDropDown.Visible = true;
				rSelectCarriersButton.Visible = true;

			}
			else if (whichMenu == "rr")
			{
				rOrder.Visible = true;
				rOrdersDropDown.Visible = true;
				rSelectCarriersButton.Visible = true;
				rrAddCarrierButton.Visible = true;
				rrAvailableCarriers.Visible = true;
				rrCarriersDropDown.Visible = true;
			}
			else if (whichMenu == "aa")
			{
				rOrder.Visible = true;
				rOrdersDropDown.Visible = true;
				aViewButton.Visible = true;
				aOrigin.Visible = true;
				aOriginValue.Visible = true;
				aDest.Visible = true;
				aDestValue.Visible = true;
				aDate.Visible = true;
				aDateValue.Visible = true;
				aStart.Visible = true;
				aStartValue.Visible = true;
				aEnd.Visible = true;
				aEndValue.Visible = true;
				aCompleteButton.Visible = true;
			}
			else if (whichMenu == "g")
			{
				gTime.Visible = true;
				gAllTimeRadio.Visible = true;
				g2WeeksRadio.Visible = true;
				gGenerateButton.Visible = true;
			}
			else if (whichMenu == "a")
			{

				rOrder.Visible = true;
				rOrdersDropDown.Visible = true;
				aViewButton.Visible = true;
				
			}
			else if (whichMenu == "p")
			{
				pLabel.Visible = true;
				pLoginButton.Visible = true;
				pPass.Visible = true;
				menuStrip1.Visible = false;
			}
		}

		/**
		* \brief    This function is used to reveal settings for selecting Carriers from the targeted cities to complete the Order
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void rSelectCarriersButton_Click(object sender, EventArgs e)
		{
			if (rOrdersDropDown.Text == "")
			{
				MessageBox.Show("Please select an order for selecting carrier!");
			}
			else
			{
				HandleDisplayData("rr");
				try
				{
					string connectionString = GetConnectionString('t');
					var sqlConnection = new MySqlConnection(connectionString);
					sqlConnection.Open();
					var cmd = sqlConnection.CreateCommand();
					rrCarriersDropDown.Items.Clear();
					cmd.CommandText = "SELECT origin FROM orders WHERE client_name=@name";
					cmd.Parameters.AddWithValue("@name", rOrdersDropDown.Text);
					var reader = cmd.ExecuteReader();
					int count = 0;
					string origin = "";
					while (reader.Read())
					{
						origin = reader[0].ToString();
					}
					reader.Close();
					rrCarriersDropDown.Items.Clear();

					cmd.CommandText = "select distinct cName from carriers where dCity=@origin";
					cmd.Parameters.AddWithValue("@origin", origin);
					var newReader = cmd.ExecuteReader();
					while (newReader.Read())
					{
						rrCarriersDropDown.Items.Insert(count, newReader[0].ToString());
					}

				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
				}
			}
		}


		/**
		* \brief    This function is used to see a summary of all active Orders in a status screen
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void ActiveOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("a");
			rOrder.Text = "Active Orders :";
			try
			{
				string connectionString = GetConnectionString('t');
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				rOrdersDropDown.Items.Clear();
				var cmd = sqlConnection.CreateCommand();
				cmd.CommandText = "SELECT client_name FROM orders WHERE order_status=1";
				var reader = cmd.ExecuteReader();
				int count = 0;
				while (reader.Read())
				{
					rOrdersDropDown.Items.Insert(count, reader[0].ToString());
				}

			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
			}
		}


		/**
		* \brief    This function is used to add a carrier for the order.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void rrAddCarrierButton_Click(object sender, EventArgs e)
		{
			if (rrCarriersDropDown.Text == "")
			{
				MessageBox.Show("Please select a carrier before adding!");
			}
			else
			{
				HandleDisplayData("rr");
				try
				{
					string connectionString = GetConnectionString('t');
					var sqlConnection = new MySqlConnection(connectionString);
					sqlConnection.Open();
					var cmd = sqlConnection.CreateCommand();
					
					cmd.CommandText = "SET SQL_SAFE_UPDATES = 0;update orders set carrier =@carrier, order_status=1 where client_name =@name";

					cmd.Parameters.AddWithValue("@name", rOrdersDropDown.Text);
					cmd.Parameters.AddWithValue("@carrier", rrCarriersDropDown.Text);
					cmd.ExecuteNonQuery();
					Logger.Log("Planner added carrier <"+rrCarriersDropDown.Text + " for <"+rOrdersDropDown.Text +">.\n");
					MessageBox.Show("Carrier updated");
				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
				}
			}
		}


		/**
		* \brief    This function is used to generate a report for either all time or past 2 weeks.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void gGenerateButton_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = GetConnectionString('t');
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				var cmd = sqlConnection.CreateCommand();

				string type = "";


				if (gAllTimeRadio.Checked)
				{
					cmd.CommandText = "SELECT * FROM orders";
					type = "allTime";
				}
				else if (g2WeeksRadio.Checked)
				{
					cmd.CommandText = "select * from orders where order_date between date_sub(now(), INTERVAL 1 WEEK) and now();";
					type = "past2Weeks";
				}
				else
				{
					MessageBox.Show("Please select time interval!");
					return;
				}
				var reader = cmd.ExecuteReader();
				float dis = 0;
				string rrJobValue = "";
				string orderID = "";
				string rrNameValue = "";
				string rrQuantityValue = "";
				string rrOriginValue = "";
				string rrDestinationValue = "";
				string rrVanTypeValue = "";
				string rrCarriersValueText = "";
				while (reader.Read())
				{
					orderID = reader[0].ToString();
					rrNameValue = reader[1].ToString();
					rrJobValue = reader[2].ToString();
					rrQuantityValue = reader[3].ToString();
					rrOriginValue = reader[4].ToString();
					rrDestinationValue = reader[5].ToString();
					rrVanTypeValue = reader[6].ToString();
					rrCarriersValueText = reader[7].ToString();
					string distance = reader[12].ToString();
					if (distance != "")
					{
						dis = float.Parse(reader[12].ToString());
					}
				}
				reader.Close();
				sqlConnection.Close();

				connectionString = GetConnectionString('t');
				sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				cmd = sqlConnection.CreateCommand();

				
				string rrCarriersValue = "";
				string rrCostValue = "";
				string rrEarnedValue = "";
				
				if (Int32.Parse(rrJobValue) == 0)
				{
					cmd.CommandText = "select distinct ftlRate from carriers where cName=@fName";

					cmd.Parameters.AddWithValue("@fName", rrCarriersValueText);
					var newreader = cmd.ExecuteReader();
					while (newreader.Read())
					{
						float cost = dis * float.Parse(newreader[0].ToString());
						rrCostValue = "$" + cost.ToString();
						float earned = (cost * 8) / 100;
						rrEarnedValue = "$" + earned.ToString();
					}
				}
				else
				{
					cmd.CommandText = "select distinct ltlRate from carriers where cName =@ltName";
					cmd.Parameters.AddWithValue("@ltName", rrCarriersValueText);
					var newreader = cmd.ExecuteReader();
					while (newreader.Read())
					{
						float cost = dis * float.Parse(newreader[0].ToString());
						rrCostValue = "$" + cost.ToString();
						float earned = (cost * 5) / 100;
						rrEarnedValue= "$" + earned.ToString();
					}
				}
				string data = File.ReadAllText("configurationFile.json");
				AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);
				string invoiceData = "Order ID  |  Client Name  |  Job Type  |  Quantity  |  Origin  |  Destination  |  Van Type  |  Carrier  |  Total Cost  |  Money Earned\n";
				invoiceData += orderID + "  |  " + rrNameValue + "  |  " + rrJobValue+ "  |  " + rrQuantityValue+ "  |  " + rrOriginValue+ "  |  " + rrDestinationValue+ "  |  " + rrVanTypeValue+ "  |  " + rrCarriersValue+ "  |  " + rrCostValue+ "  |  " + rrEarnedValue+ "\n";
				string path = appSettings.log_file_directory + type + "Invoices.txt";
				File.WriteAllText(path, invoiceData);
				Logger.Log("Planner generated invoice.\n");
				MessageBox.Show("Invoice generated");
			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
			}
		}



		private string GetConnectionString(char whichDatabase)
		{
			string connectionString = "f";
			if (whichDatabase == 'c')
			{
				connectionString = "Server=159.89.117.198;Uid=DevOSHT;Pwd=Snodgr4ss!;database=cmp"; // connection string used to connect to the server
			}
			else if (whichDatabase == 't')
			{
				string data = File.ReadAllText("configurationFile.json");
				AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);

				if (appSettings != null)
				{
					string server = "Server=" + appSettings.tms_ip;
					string uid = "Uid=" + appSettings.tms_user;
					string pass = "Pwd=" + appSettings.tms_password;
					string database = "database=tms";

					connectionString = server + ";" + uid + ";" + pass + ";" + database;

				}
			}


			return connectionString;
		}

		private void aViewButton_Click(object sender, EventArgs e)
		{

			if (rOrdersDropDown.Text == "")
			{
				MessageBox.Show("Please select an order!");
			}
			else
			{
				HandleDisplayData("aa");
				try
				{
					string connectionString = GetConnectionString('t');
					var sqlConnection = new MySqlConnection(connectionString);
					sqlConnection.Open();
					var cmd = sqlConnection.CreateCommand();
					cmd.CommandText = "SELECT origin, destination, order_date, start_time, end_time FROM orders WHERE client_name=@name";
					cmd.Parameters.AddWithValue("@name", rOrdersDropDown.Text);
					var reader = cmd.ExecuteReader();
					while (reader.Read())
					{
						aOriginValue.Text = reader[0].ToString();
						aDestValue.Text = reader[1].ToString();
						aDateValue.Text = reader[2].ToString();
						aStartValue.Text = reader[3].ToString();
						aEndValue.Text = reader[4].ToString();
						
					}

				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
				}
			}
		}

		private void aCompleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = GetConnectionString('t');
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				var cmd = sqlConnection.CreateCommand();
				cmd.CommandText = "SET SQL_SAFE_UPDATES = 0;update orders set order_status=2 where client_name =@name";
				cmd.Parameters.AddWithValue("@name", rOrdersDropDown.Text);
				
				cmd.ExecuteNonQuery();
				Logger.Log("Planner marked the order as " + rOrdersDropDown.Text +" completed.\n");
				MessageBox.Show("Order Marked as Completed");
			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
			}
		}

		private void pLoginButton_Click(object sender, EventArgs e)
		{
			if (pPass.Text == "Planner")
			{
				Logger.Log("Planner Logged In.\n");

				HandleDisplayData("r");
				menuStrip1.Visible = true;
				rOrder.Text = "Orders :";
				rSelectCarriersButton.Text = "Select Carrier";

				try
				{
					string connectionString = GetConnectionString('t');
					var sqlConnection = new MySqlConnection(connectionString);
					sqlConnection.Open();
					var cmd = sqlConnection.CreateCommand();
					cmd.CommandText = "SELECT client_name FROM orders WHERE order_status=0";
					var reader = cmd.ExecuteReader();
					int count = 0;
					rOrdersDropDown.Items.Clear();

					while (reader.Read())
					{
						rOrdersDropDown.Items.Insert(count, reader[0].ToString());
					}

				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
				}
			}
			else
			{
				MessageBox.Show("Incorrect Password..Please try again!!");
			}
		}

		private void aEndValue_Click(object sender, EventArgs e)
		{

		}
	}
}
