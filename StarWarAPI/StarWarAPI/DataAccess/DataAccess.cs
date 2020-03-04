using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Common;
using System.Threading.Tasks;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    public string ConnectionString { get; set; }
    public SqlConnection Connection { get; set; }
    public SqlCommand Command { get; set; }

    public DataAccess(string constr)
    {
        this.ConnectionString = constr;
        this.Connection = new SqlConnection(this.ConnectionString);
        this.Command = new SqlCommand();
        this.Command.Connection = this.Connection;
    }

    public async Task<DataTable> ExecuteSqlQuery(string query)
    {
        try
        {

            this.Command.CommandText = query;
            if (this.Command.Connection.State == ConnectionState.Open)
            {
                this.Command.Connection.Close();
            }
            this.Command.Connection.Open();
            SqlDataAdapter sqlAdopter = new SqlDataAdapter();
            sqlAdopter.SelectCommand = this.Command;
            DataTable table = new DataTable();
            sqlAdopter.Fill(table);
            return table;
        }
        catch (SqlException exc)
        {
            throw exc;
        }
        finally
        {
            if (this.Command.Connection != null && this.Command.Connection.State == ConnectionState.Open)
            {
                this.Command.Connection.Close();
            }
        }
    }
}
