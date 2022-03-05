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
	/// \class Buyer
	///
	/// \brief The buyer represents an employee of OSHT who is tasked with requesting Customer contracts from the Contract Marketplace and generating an initial Order or contract.
	/// -  Initiates contact with the Contract Marketplace to receive contracts from Custome+9rs
	/// -  Buyer may review existing Customers and accept new Customers into the TMS system
	/// -  Buyer may initiate a new Order from the Marketplace requests
	/// -  Buyer may select relevant Cities for the Order
	/// -  Buyer may review completed Orders and process them for Invoice Generation
	///
	/// 
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///

	public partial class Buyer : Form
	{
		private int orderID;
		public Buyer()
		{
			InitializeComponent();
		}

		/**
		* \brief    This function is used to load the settings for initiating contracts.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void Buyer_StartingPage_Load(object sender, EventArgs e)
		{
			HandleDisplayData("p");
			
		}


		/**
		* \brief    This function is used to reveal the settings for Initiating contact with the Contract Marketplace to receive contracts from Customers
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void InitiateContractToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("c");
			DisplayContracts();
		}


		/**
		* \brief    This function handles the data that is to be displayed for the settings selected.
		*
		* \param	   whichMenu	- <b>string</b> 
		* \return      None
		*
		*/
		private void HandleDisplayData(string whichMenu)
		{
			pLabel.Visible = false;
			pLoginButton.Visible = false;
			pPass.Visible = false;

			cRefreshButton.Visible = false;
			cTextBox.Visible = false;

			oLabel1.Visible = false;
			oLabel2.Visible = false;
			oLabel3.Visible = false;
			oLabel4.Visible = false;
			oLabel5.Visible = false;
			oLabel6.Visible = false;
			oName.Visible = false;
			oOrderButton.Visible = false;
			oType.Visible = false;
			oQuantity.Visible = false;
			oType.Visible = false;
			oVanType.Visible = false;
			oDestination.Visible = false;
			oOrigin.Visible = false;

			rComboBox.Visible = false;
			rOrderLabel.Visible = false;
			rDetailsButton.Visible = false;

			rrJob.Visible = false;
			rrName.Visible = false;
			rrNameValue.Visible = false;
			rrOrderDetailsLabel.Visible = false;
			rrJobValue.Visible = false;
			rrQuantity.Visible = false;
			rrQuantityValue.Visible = false;
			rrOrigin.Visible = false;
			rrOriginValue.Visible = false;
			rrDestination.Visible = false;
			rrDestinationValue.Visible = false;
			rrCarriers.Visible = false;
			rrCarriersValue.Visible = false;
			rrGenerateButton.Visible = false;
			rrVan.Visible = false;
			rrVanTypeValue.Visible = false;
			rrEarned.Visible = false;
			rrEarnedValue.Visible = false;
			rrtotal.Visible = false;
			rrCostValue.Visible = false;

			if (whichMenu == "c")
			{
				cRefreshButton.Visible = true;
				cTextBox.Visible = true;

			}
			else if (whichMenu == "o")
			{
				oLabel1.Visible = true;
				oLabel2.Visible = true;
				oLabel3.Visible = true;
				oLabel4.Visible = true;
				oLabel5.Visible = true;
				oLabel6.Visible = true;
				oName.Visible = true;
				oOrderButton.Visible = true;
				oType.Visible = true;
				oQuantity.Visible = true;
				oType.Visible = true;
				oVanType.Visible = true;
				oDestination.Visible = true;
				oOrigin.Visible = true;
			}
			else if (whichMenu == "r")
			{
				rComboBox.Visible = true;
				rOrderLabel.Visible = true;
				rDetailsButton.Visible = true;


			}
			else if (whichMenu == "rr")
			{
				rComboBox.Visible = true;
				rOrderLabel.Visible = true;
				rDetailsButton.Visible = true;
				rrJob.Visible = true;
				rrName.Visible = true;
				rrNameValue.Visible = true;
				rrOrderDetailsLabel.Visible = true;
				rrJobValue.Visible = true;
				rrQuantity.Visible = true;
				rrQuantityValue.Visible = true;
				rrOrigin.Visible = true;
				rrOriginValue.Visible = true;
				rrDestination.Visible = true;
				rrDestinationValue.Visible = true;
				rrCarriers.Visible = true;
				rrCarriersValue.Visible = true;
				rrGenerateButton.Visible = true;
				rrVan.Visible = true;
				rrVanTypeValue.Visible = true;
				rrEarned.Visible = true;
				rrEarnedValue.Visible = true;
				rrtotal.Visible = true;
				rrCostValue.Visible = true;

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
		* \brief    This function is used to reveal the settings for initiating a new Order from the Marketplace requests
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void InitiateOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("o");
		}


		/**
		* \brief    This function is used to reveal the settings for reviewing completed Orders
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void ReviewCompletedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("r");
			try
			{
				string connectionString = GetConnectionString('t');
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				var cmd = sqlConnection.CreateCommand();
				cmd.CommandText = "SELECT client_name FROM orders WHERE order_status=2";
				var reader = cmd.ExecuteReader();
				int count = 0;
				while (reader.Read())
				{
					rComboBox.Items.Insert(count, reader[0].ToString());
				}

			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
			}
		}


		/**
		* \brief    This function is used to reveal infromation such as billing details
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void RDetailsButton_Click(object sender, EventArgs e)
		{
			if (rComboBox.Text == "")
			{
				MessageBox.Show("Please select an order for displaying details");
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
					cmd.CommandText = "SELECT * FROM orders WHERE client_name=@name";
					cmd.Parameters.AddWithValue("@name", rComboBox.Text);
					var reader = cmd.ExecuteReader();
					float dis = 0;
					while (reader.Read())
					{
						orderID = Int32.Parse(reader[0].ToString());
						rrNameValue.Text = reader[1].ToString();
						rrJobValue.Text = reader[2].ToString();
						rrQuantityValue.Text = reader[3].ToString();
						rrOriginValue.Text = reader[4].ToString();
						rrDestinationValue.Text = reader[5].ToString();
						rrVanTypeValue.Text = reader[6].ToString();
						rrCarriersValue.Text = reader[7].ToString();

						dis = float.Parse(reader[12].ToString());

					}
					reader.Close();
					sqlConnection.Close();


					connectionString = GetConnectionString('t');
					sqlConnection = new MySqlConnection(connectionString);
					sqlConnection.Open();
					cmd = sqlConnection.CreateCommand();
			

					if (Int32.Parse(rrJobValue.Text) == 0)
					{
						cmd.CommandText = "select distinct ftlRate from carriers where cName =@ftName";
						
						cmd.Parameters.AddWithValue("@ftName", rrCarriersValue.Text);
						var newreader = cmd.ExecuteReader();
						while (newreader.Read())
						{
							float cost = dis * float.Parse(newreader[0].ToString());
							rrCostValue.Text = "$" + cost.ToString();
							float earned = (cost * 8) / 100;
							rrEarnedValue.Text = "$" + earned.ToString();
						}
					}
					else
					{
						cmd.CommandText = "select distinct ltlRate from carriers where cName =@ltName";
						cmd.Parameters.AddWithValue("@ltName", rrCarriersValue.Text);
						var newreader = cmd.ExecuteReader();
						while (newreader.Read())
						{
							string t = (newreader[0].ToString());
							float cost = dis * float.Parse(newreader[0].ToString());
							rrCostValue.Text = "$" + cost.ToString();
							float earned = (cost * 5) / 100;
							rrEarnedValue.Text = "$" + earned.ToString();
						}
					}

				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
				}
			}
		}



		/**
		* \brief    This function is used to generate an invoice and add it to database.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void RRGenerateButton_Click(object sender, EventArgs e)
		{
			try
			{
				string data = File.ReadAllText("configurationFile.json");
				AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);
				string invoiceData = "Order ID  |  Client Name  |  Job Type  |  Quantity  |  Origin  |  Destination  |  Van Type  |  Carrier  |  Total Cost  |  Money Earned\n";
				invoiceData += orderID.ToString() + "  |  " + rrNameValue.Text + "  |  " + rrJobValue.Text + "  |  " + rrQuantityValue.Text + "  |  " + rrOriginValue.Text + "  |  " + rrDestinationValue.Text + "  |  " + rrVanTypeValue.Text + "  |  " + rrCarriersValue.Text + "  |  " + rrCostValue.Text + "  |  " + rrEarnedValue.Text + "\n";
				string path = appSettings.log_file_directory + orderID.ToString() + rrNameValue.Text + "Invoice.txt"  ;
				File.WriteAllText(path, invoiceData);
				Logger.Log("Buyer generated an invoice.\n");
				MessageBox.Show("Invoice Generated : <" + path + ">\n");
			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);

			}

		}


		/**
		* \brief    This function is used to refresh the Contract marketplace requests.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void CRefreshButton_Click(object sender, EventArgs e)
		{
			DisplayContracts();
		}


		/**
		* \brief    This function is used to create a new order with the provided details.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void OOrderButton_Click(object sender, EventArgs e)
		{
			if (CheckOrderDetails())
			{
				Order newOrder = new Order();
				newOrder.clientName = oName.Text;
				newOrder.vanType = Int32.Parse(oVanType.Text);
				newOrder.origin = oOrigin.Text;
				newOrder.destination = oDestination.Text;
				newOrder.jobType = Int32.Parse(oType.Text);
				newOrder.quantity = Int32.Parse(oQuantity.Text);

				try
				{
					string connectionString = GetConnectionString('t');
					var sqlConnection = new MySqlConnection(connectionString);
					sqlConnection.Open();
					var cmd = sqlConnection.CreateCommand();
					InitiateOrder initiate = new InitiateOrder();
					initiate.origin = newOrder.origin;
					initiate.destination = newOrder.destination;
					initiate.jobType = newOrder.jobType;
					string info = initiate.VerifyUserInput();
					string[] spt = info.Split(',');
					string time = spt[0].Remove(0, 1);
					int t = Int32.Parse(time);
					string km = spt[1].Remove(0, 1);
					

					cmd.CommandText = "INSERT INTO orders (client_name, job_type, quantity, origin, destination, van_type, order_date, order_status, start_time, end_time, distance) VALUES (@name, @job_type, @quantity, @origin, @destination, @van_type, now(), 0, now(), @time, @d)";
					cmd.Parameters.AddWithValue("@name", newOrder.clientName);
					cmd.Parameters.AddWithValue("@job_type", newOrder.jobType);
					cmd.Parameters.AddWithValue("@quantity", newOrder.quantity);
					cmd.Parameters.AddWithValue("@origin", newOrder.origin);
					cmd.Parameters.AddWithValue("@destination", newOrder.destination);
					cmd.Parameters.AddWithValue("@van_type", newOrder.vanType);
					cmd.Parameters.AddWithValue("@time", t);
					cmd.Parameters.AddWithValue("@d", Int32.Parse(km));
					Logger.Log("Buyer initiated a new order for "+ newOrder.clientName +"\n");
					cmd.ExecuteNonQuery();
					MessageBox.Show("Order placed!");

				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
				}




			}
			else
			{
				MessageBox.Show("Cannot initiate the order because of invalid data!");
			}
		}


		




		private void DisplayContracts()
		{
			try
			{
				string connectionString = GetConnectionString('c'); // connection string used to connect to the server
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				cTextBox.Clear();
				cTextBox.Text = "Client_Name  |  Job_Type  |  Quantity  |  Origin  |  Destination  |  Van_Type\n";
				var cmd = sqlConnection.CreateCommand();
				cmd.CommandText = "SELECT * FROM Contract";
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					var ii = reader.FieldCount;
					for (int i = 0; i < ii; i++)
					{
						if (reader[i] is DBNull)
							cTextBox.Text = "Cannot find data\n";
						else
							cTextBox.Text += reader[i].ToString() + "  |  ";
					}
					cTextBox.Text += "\n";
				}
				Logger.Log("Buyer requested new contracts\n");

			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
			}
		}


		private bool CheckOrderDetails()
		{
			bool retValue = true;
			
			
			if (oName.Text == "" || oQuantity.Text == "" || oType.Text == "" || oOrigin.Text == "" ||
				oVanType.Text == "" || oDestination.Text == "" )
			{
				retValue = false;
			}

			if (!Int32.TryParse(oQuantity.Text, out int val))
			{
				retValue = false;
			}

			return retValue;
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

		private void pLoginButton_Click(object sender, EventArgs e)
		{
			if (pPass.Text == "Buyer")
			{
				Logger.Log("Buyer Logged In\n");
				HandleDisplayData("c");
				menuStrip1.Visible = true;
				
			}
			else
			{
				MessageBox.Show("Incorrect Password..Please try again!!");
			}
		}
	}
}
