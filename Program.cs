using System;
using Npgsql;
using System.Data;

namespace bitdotio_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitHost = "db.bit.io";
            var bitApiKey = "v2_3uYmq_RrkrxngWXWutSLYKUqYDyFB"; // from the "Password" field of the "Connect" menu

            var bitUser = "kelvin6118";
            var bitDbName = bitUser + "/CROPS_MANAGEMENT_SYSTEM";

            var cs = $"Host={bitHost};Username={bitUser};Password={bitApiKey};Database={bitDbName}";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM users";

            using var cmd = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable schemaTable = reader.GetSchemaTable();

            // Show schema details
            foreach (DataRow row in schemaTable.Rows)
            {
                foreach (DataColumn column in schemaTable.Columns)
                {
                    Console.WriteLine(String.Format("{0} = {1}",
                    column.ColumnName, row[column]));
                }
            }

            // Show all data
            while (reader.Read()) 
            {
                for (int colNum = 0; colNum < reader.FieldCount; colNum++) 
                {
                    Console.Write(reader.GetName(colNum) + "=" +  reader[colNum] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}