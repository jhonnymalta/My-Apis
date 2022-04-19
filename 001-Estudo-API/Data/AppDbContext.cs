using System.Data.SqlClient;

namespace _001_Estudo_API.Data
{
    static class AppDbContext
    {

        const string connectionString = "Server=localhost,1433;Database=Todo;User Id=sa;Password=xxxxxx";

       static SqlConnection conn = new SqlConnection(connectionString);
    }
}
