/*
 * FILENAME			:	Logger.cs
 * PROJECT			:	PROG2121 - Assignment 06 
 * PROGRAMMER		:	Purv Ketankumar Pandya & Deep Kalpeshkumar Patel
 * FIRST VERSION	:	11/22/2021
 * PURPOSE			:	Log the message to events as well as in a text file whose 
 *						location is same as the exe location.
 */
using System.Text.Json;

namespace TMS
{

	/// 
	/// \class Logger
	///
	/// \brief This class shows the incoming messages in the log file
	///
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///

	public static class Logger
	{

		/**
		* \brief    This function is to log the incoming messages
		*
		* \param    string - <b>message</b> 
		* \return   None
		*
		*/
		public static void Log(string message)
		{
			// Get the exe path
			
			string data = File.ReadAllText("configurationFile.json");
			AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(data);
			string path = appSettings.log_file_directory + "TMS_Log.txt";
			DateTime dateTime = DateTime.Now;
			// log the entry in the text file
			File.AppendAllText(path, dateTime.ToString()+ "\t" + message); 
		}
	}
}
