using System;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Description of Koneksi.
	/// </summary>
	public class Koneksi
	{
		public SqlConnection GetConn()
		{
			SqlConnection Conn = new SqlConnection();
			Conn.ConnectionString = "Data Source=E3-SENTRY;initial catalog=DataUser; integrated security=true";
			return Conn;
		}
	}
}
