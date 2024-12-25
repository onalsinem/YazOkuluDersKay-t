
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-JQVRP07\SQLEXPRESS; Initial Catalog=DbYazOkulu; Integrated Security=True");
    }
}
