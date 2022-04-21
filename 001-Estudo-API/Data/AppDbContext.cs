using System.Data.SqlClient;

namespace _001_Estudo_API.Data
{
    static class AppDbContext
    {

        const string connectionString = "Server=localhost,1433;Database=Todo;User Id=sa;Password=1q2w3e4r@#$";

       static SqlConnection conn = new SqlConnection(connectionString);
    }
}
