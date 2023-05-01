using System;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDB
    {
		private SqlConnection connection;
		private SqlCommand command;
		private SqlDataReader reader;

		// Datos de la Base
		// string serverName = "localhost\\SQLEXPRESS";
		string serverName = "localhost\\SQLLAB";
		string dataBase = "CATALOGO_P3_DB";

		public AccesoDB()
		{
			connection = new SqlConnection($"server={serverName}; database={dataBase}; integrated security=true; TrustServerCertificate=True");
			command = new SqlCommand();
		}

		public SqlDataReader Reader
		{
			get { return reader; }
		}

		public void setQuery(string query)
		{
			command.CommandType = System.Data.CommandType.Text;
			command.CommandText = query;
		}

		public void executeReader()
		{
			command.Connection = connection;
			try
			{
				connection.Open();
				reader = command.ExecuteReader();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool executeNonQuery()
		{
			command.Connection = connection;
			try
			{
				connection.Open();
				if (command.ExecuteNonQuery() > 0)
					return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return false;
		}

		public void closeConnection()
		{
			connection.Close();
		}
	}
}
