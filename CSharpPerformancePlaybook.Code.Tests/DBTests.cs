namespace CSharpPerformancePlaybook.Code.Tests
{
    using System.Data;
    using System.Data.SqlClient;
    using Xunit;

    public class DBTests
    {
        string connectionString = "Server=.\\SQLExpress;Initial Catalog=AdventureWorks2022b;Trusted_Connection=yes";

        [Fact]
        public void PoorlyPerformingQuery()
        {
            string sql = "SELECT * FROM Person.Person WHERE LastName = 'Jones'";

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var command = new SqlCommand(sql, conn);

                var ds = new DataSet();
                var da = new SqlDataAdapter(command);

                da.Fill(ds);

                var result = ds.Tables[0].Rows[0][1];
            }
        }
    }
}
