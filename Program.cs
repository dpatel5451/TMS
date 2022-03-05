namespace TMS
{

	/// 
	/// \class static class Program

	///
	/// \brief This class contain the main which is used to run the program
	/// -Main Program
	/// 
	/// 
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///

	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new TMS());
		}
	}
}