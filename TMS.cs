namespace TMS
{
	/// 
	/// \class TMS
	///
	/// \brief This class helps the user to select whether he/she is Planner,Admin or Buyer and direct to selection option
	/// - This Class has Option to choose 
	/// - Admin, Buyer, Planner
	///
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///


	public partial class TMS : Form
	{
		public TMS()
		{
			InitializeComponent();
		}

		private void TMS_StartingPage_Load(object sender, EventArgs e)
		{

		}

		/**
		* \brief    This function is used to ask for user type and direct them to their respective window.
		*
		* \param    sender - <b>object</b> 
		* \param	e	   - <b>EventArgs</b>  
		* \return      None
		*
		*/
		private void Submit_Click(object sender, EventArgs e)
		{
			string user_type = UserType.Text;
			if (user_type == "")
			{
				MessageBox.Show("Please select a user type!");
			}
			else
			{
				if (user_type == "Admin")
				{
					
					Admin adminPage = new Admin();
					adminPage.Show();
				}
				else if (user_type == "Buyer")
				{

					Buyer buyerPage = new Buyer();
					buyerPage.Show();
					
				}
				else if (user_type == "Planner")
				{
					Planner plannerPage = new Planner();
					plannerPage.Show();

				}
				else
				{
					MessageBox.Show("Invalid user type!");
				}
			}
			
		}
	}
}