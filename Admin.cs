using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.Json;
using MySql.Data.MySqlClient;

namespace TMS
{


	/// 
	/// \class Admin
	///
	/// \brief The Admin user role represents an individual at OSHT who has IT experience and is tasked with configuration, maintenance, and troubleshooting of the TMS application class is a child of the Shape class and will inherit publicly from it
	/// -  Admin may access general configuration options for TMS,
	/// -  Admin may review logfiles without leaving the TMS application
	/// -  Admin may initiate a backup job on the local TMS Database
	/// -  Admin may alter key TMS data
	/// 
	///
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///

	public partial class Admin : Form
	{
		public Admin()
		{
			InitializeComponent();
			
		}


		/**
		* \brief    This function is used to review the log files
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void ReviewLogFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("r");
			string data = File.ReadAllText("configurationFile.json");
			AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);
			
			if (appSettings != null)
			{
				try
				{
					if (File.Exists(appSettings.log_file_directory + "TMS_Log.txt"))
					{
						rLogBox.Text = File.ReadAllText(appSettings.log_file_directory + "TMS_Log.txt");	
					}
					else
					{
						MessageBox.Show("Log file not found!!");
					}
				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
					Logger.Log("[Exception]::<" + m.Message + "\n");

				}
			}
			
		}



		/**
		* \brief    This function reveals the settings for accessing general configuration options like selecting directories for log files, targeting IP address and ports for all DBMS communications
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void GeneralConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("g");
			string data = File.ReadAllText("configurationFile.json");
			AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);

			if (appSettings != null)
			{
				gLogFileDirectory.Text = appSettings.log_file_directory;
				gIPTextBox.Text = appSettings.tms_ip;
				gPortTextBox.Text = appSettings.tms_port;
				gPassword.Text = appSettings.tms_password;
				gUserNameTMS.Text = appSettings.tms_user;
			}
		}



		/**
		* \brief    This function handles the data that is to be displayed for the settings selected.
		*
		* \param       whichMenu - <b>string</b>
		* \return      None
		*
		*/
		private void HandleDisplayData(string whichMenu)
		{
			pLabel.Visible = false;
			pLoginButton.Visible = false;
			pPass.Visible = false;

			gLog.Visible = false;
			gLogFileDirectory.Visible = false;
			gIp.Visible = false;
			gIPTextBox.Visible = false;
			gPortTextBox.Visible = false;
			gPortTMS.Visible = false;
			gSaveButton.Visible = false;
			gUserNameTMS.Visible = false;
			gUserTMS.Visible = false;
			gPass.Visible = false;
			gPassword.Visible = false;

			aRunButton.Visible = false;
			aQueryText.Visible = false;

			rLogBox.Visible = false;
			rLogData.Visible = false;
			rClearButton.Visible = false;

			bBackup.Visible = false;
			bBackupButton.Visible = false;
			bBackupLocation.Visible = false;

			if (whichMenu == "g")
			{
				gLog.Visible = true;
				gLogFileDirectory.Visible = true;
				gIp.Visible = true;
				gIPTextBox.Visible = true;
				gPortTextBox.Visible = true;
				gPortTMS.Visible = true;
				gSaveButton.Visible = true;
				gUserNameTMS.Visible = true;
				gUserTMS.Visible = true;
				gPass.Visible = true;
				gPassword.Visible = true;
			}
			else if (whichMenu == "r")
			{
				rLogData.Visible = true;
				rLogBox.Visible = true;
				rClearButton.Visible = true;
			}
			else if (whichMenu == "a")
			{
				aRunButton.Visible = true;
				aQueryText.Visible = true;
				
			}
			else if (whichMenu == "b")
			{
				bBackup.Visible = true;
				bBackupButton.Visible = true;
				bBackupLocation.Visible = true;

			}
			else if (whichMenu == "p")
			{
				pLabel.Visible = true;
				pLoginButton.Visible = true;
				pPass.Visible = true;
			}


		}


		/**
		* \brief    This function used for load the starting page and display the general settings.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void Admin_StartingPage_Load(object sender, EventArgs e)
		{
			HandleDisplayData("p");
			menuStrip1.Visible = false;
		}


		/**
		* \brief    This function reveals the settings for altering the key TMS data
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void AlterTMSDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("a");

		}


		/**
		* \brief    This function is used to initiate a backup job on the local TMS Database, specifying the directory for the backup files to be produced
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HandleDisplayData("b");

		}


		/**
		* \brief    This function is used to save the settings mentioned by the admin to appSettings.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void GSaveButton_Click(object sender, EventArgs e)
		{
			string logPath = gLogFileDirectory.Text;
			string ip = gIPTextBox.Text;
			string port = gPortTextBox.Text;
			try
			{
				if (logPath != "" && ip != "" && port != "")
				{
					AppSettings newAppSettings = new AppSettings();

					if (Directory.Exists(logPath))
					{
						newAppSettings.log_file_directory = logPath ;
					}

					IPAddress.Parse(ip);
					newAppSettings.tms_ip = ip;
					newAppSettings.tms_port = port;
					newAppSettings.tms_user = gUserNameTMS.Text;
					newAppSettings.tms_password = gPassword.Text;
					string newSettings = JsonSerializer.Serialize(newAppSettings);

					string data = File.ReadAllText("configurationFile.json");
					AppSettings prevAppSettings = JsonSerializer.Deserialize<AppSettings>(data);

					if (prevAppSettings != null)
					{
						data = File.ReadAllText(prevAppSettings.log_file_directory + "TMS_Log.txt");
						File.Delete(prevAppSettings.log_file_directory + "TMS_Log.txt");
						File.WriteAllText(newAppSettings.log_file_directory + "TMS_Log.txt", data);
						File.WriteAllText("configurationFile.json", newSettings);
						Logger.Log("Admin Saved new settings\n");
						MessageBox.Show("Settings Saved!!");
					}
				}
				else
				{
					MessageBox.Show("Cannot Save the provided settings!");
				}
			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
				Logger.Log("[Exception]::<" + m.Message + "\n");

			}
		}


		/**
		* \brief    This function is used to backup the data to the provided location.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void BBackupButton_Click(object sender, EventArgs e)
		{
			string backupLocation = bBackupLocation.Text;
			if (backupLocation != "" && Directory.Exists(backupLocation))
			{
				string data = File.ReadAllText("configurationFile.json");
				AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);
				if (appSettings != null)
				{
					data = File.ReadAllText(appSettings.log_file_directory + "TMS_Log.txt");
					File.WriteAllText(backupLocation + "TMS_Log.txt", data);
					Logger.Log("Admin Backed Up Logged data to the location : <" + bBackupLocation.Text + ">\n");

					MessageBox.Show("Backed up!!");
				}
			}
		}

		private void aRunButton_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = GetConnectionString('t'); // connection string used to connect to the server
				var sqlConnection = new MySqlConnection(connectionString);
				sqlConnection.Open();
				
				var cmd = sqlConnection.CreateCommand();
				cmd.CommandText = aQueryText.Text;
				var reader = cmd.ExecuteReader();
				aQueryText.Clear();
				while (reader.Read())
				{
					var ii = reader.FieldCount;
					for (int i = 0; i < ii; i++)
					{	
						aQueryText.Text += reader[i].ToString() + "  |  ";
					}
					aQueryText.Text += "\n";
				}
				Logger.Log("Admin run a Query on TMS database: <" + cmd.CommandText + ">\n");
				MessageBox.Show("Query Successful!");
			}
			catch (Exception m)
			{
				MessageBox.Show(m.Message);
				Logger.Log("[Exception]::<" + m.Message + "\n");
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

		private void pLoginButton_Click(object sender, EventArgs e)
		{
			if (pPass.Text == "Admin")
			{
				Logger.Log("Admin Logged In\n");
				HandleDisplayData("g");
				menuStrip1.Visible = true;
				string data = File.ReadAllText("configurationFile.json");
				AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);

				if (appSettings != null)
				{
					gLogFileDirectory.Text = appSettings.log_file_directory;
					gIPTextBox.Text = appSettings.tms_ip;
					gPortTextBox.Text = appSettings.tms_port;
					gPassword.Text = appSettings.tms_password;
					gUserNameTMS.Text = appSettings.tms_user;
				}
				else
				{
					MessageBox.Show("Cannot load settings!");
				}
			}
			else
			{
				MessageBox.Show("Incorrect Password..Please try again!!");
			}
		}

		private void rClearButton_Click(object sender, EventArgs e)
		{
			HandleDisplayData("r");
			string data = File.ReadAllText("configurationFile.json");
			AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);

			if (appSettings != null)
			{
				try
				{
					if (File.Exists(appSettings.log_file_directory + "TMS_Log.txt"))
					{
						File.WriteAllText(appSettings.log_file_directory + "TMS_Log.txt", "");
						rLogBox.Text = File.ReadAllText(appSettings.log_file_directory + "TMS_Log.txt");
					}
					else
					{
						MessageBox.Show("Log file not found!!");
					}
				}
				catch (Exception m)
				{
					MessageBox.Show(m.Message);
					Logger.Log("[Exception]::<" + m.Message + "\n");

				}
			}
		}
	}
}
