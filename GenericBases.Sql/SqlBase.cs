using System.Data;
using System.Data.SqlClient;
using GenericContracts;

namespace GenericBases.Sql;

public abstract class SqlBase<T,DB>
    where T : class, new()
    where DB : IDatabase<string>, new()
{
    public readonly SqlConnection Conn;

    protected SqlBase()
    {
        var database = new DB();
        Conn = new SqlConnection(database.GetConnectionDetails());
    }

    protected SqlBase(SqlConnection existingConnection)
    {
        Conn = existingConnection;
    }

    protected int ExecuteNonQuery(string querySql, CommandType commandType, List<SqlParameter> parameters)
    {
        using (SqlCommand cmd = new SqlCommand(querySql, Conn))
        {
            foreach (var sqlParameter in parameters)
            {
                cmd.Parameters.Add(sqlParameter);
            }
            cmd.CommandType= commandType;
            if(Conn.State != ConnectionState.Open) Conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
    
    protected int ExecuteNonQuery(string querySql, CommandType commandType)
    {
        return ExecuteNonQuery(querySql, commandType, new List<SqlParameter>());
    }
    
    protected IEnumerable<T> ExecuteQuery(string querySql, CommandType commandType, List<SqlParameter> parameters)
    {
        using (SqlCommand cmd = new SqlCommand(querySql, Conn))
        {
            foreach (var sqlParameter in parameters)
            {
                cmd.Parameters.Add(sqlParameter);
            }
            cmd.CommandType= commandType;
            if(Conn.State != ConnectionState.Open) Conn.Open();
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                yield return ReadToModel(reader);
            }
        }
    }
    
    protected IEnumerable<T> ExecuteQuery(string querySql, CommandType commandType)
    {
        return ExecuteQuery(querySql, commandType, new List<SqlParameter>());
    }

    protected abstract T ReadToModel(IDataReader reader);
}