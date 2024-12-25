using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class DALDers
	{
		public static List<EntityDers> DersList()
		{
			List<EntityDers> list = new List<EntityDers>();
			SqlCommand komut1 = new SqlCommand("Select * from TBLDERS", Baglanti.bgl);
			if (komut1.Connection.State != ConnectionState.Open)
			{
				komut1.Connection.Open();
			}

			SqlDataReader Reader = komut1.ExecuteReader();

			while (Reader.Read())
			{
				EntityDers ent = new EntityDers()
				{
					DersAd = Reader["DERSADI"].ToString(),
					Max = Convert.ToInt32(Reader["DERSMAKSKONTENJAN"].ToString()),
					Min= Convert.ToInt32(Reader["DERSMINKONTENJAN"].ToString()),
					Id= Convert.ToInt32(Reader["DERSID"].ToString()),
				};

				list.Add(ent);
			}

			Reader.Close();
			return list;
		}
	}
}
