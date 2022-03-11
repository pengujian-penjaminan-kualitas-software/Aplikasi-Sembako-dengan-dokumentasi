using System;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SEMBAKO_JAYA
{
	/// <summary>
	/// Sumber data untuk menautkan server yang nantinya akan dihubungkan ke database
	/// </summary>
	public class Koneksi
	{
		///coding ini untuk memanggil koneksi dan membuka koneksinya
		public SqlConnection GetConn()
		{
			///yang ini untuk mengeskekusi querynya
			SqlConnection Conn = new SqlConnection();
			///Coding dibawah untuk Query SQL 
			Conn.ConnectionString = "Data Source=E3-SENTRY;initial catalog=DataUser; integrated security=true";
			return Conn;
		}
	}
}
