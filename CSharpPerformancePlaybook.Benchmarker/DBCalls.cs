namespace CSharpPerformancePlaybook.Benchmarker
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Mathematics;
    using BenchmarkDotNet.Order;
    using System.Data;
    using System.Data.SqlClient;

    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class DBCalls
    {
        string connectionString = "Server=.\\SQLExpress;Initial Catalog=AdventureWorks2022b;Trusted_Connection=yes";

        [Benchmark]
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
