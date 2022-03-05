using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{

	/// 
	/// \class Order
	///
	/// \brief This class will show the details of the order
	/// -  Order has their orderID
	/// -  Order has origin(The location of seller where order has been picked up)
	/// -  Order has destination(The loaction of the client where order should be drop)
	/// -  Order has client name(Client detail's)	
	///
	/// \author <b><i>Purv,Deep,Dev and Gaurav</i></b>
	///

	class Order
	{
		
		public string origin { get; set; }
		public string destination { get; set; }
		public string clientName { get; set; }
		public int jobType { get; set; }
		public int vanType { get; set; }
		public string carrier { get; set; }
		public int quantity { get; set; }
		public string order_date { get; set; }
		public int order_status { get; set; }
	}
}
