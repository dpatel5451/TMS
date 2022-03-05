using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace TMS
{
	internal class AppSettings
	{
		public string log_file_directory { get; set; }
		public string tms_ip { get; set; }
		public string tms_port {get; set; }
		public string tms_user { get; set; }
		public string tms_password { get; set; }
	}
}
