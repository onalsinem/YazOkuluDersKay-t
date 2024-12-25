using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int InsertOgrenci(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI( OgrAd,OgrSoyad,OgrFoto,OgrSıfre,OgrNumara ) values (@p1,@p2,@p3,@p4,@p5)",
                Baglanti.bgl);

            if(komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Fotograf);
            komut1.Parameters.AddWithValue("@p4", parametre.Sifre);
            komut1.Parameters.AddWithValue("@p5", parametre.Numara);

            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> ListOgrenci()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();

            SqlCommand komut1 = new SqlCommand("Select * from TBLOGRENCI", Baglanti.bgl);
			if (komut1.Connection.State != ConnectionState.Open)
			{
				komut1.Connection.Open();
			}

            SqlDataReader reader = komut1.ExecuteReader();
            while (reader.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.Id = Convert.ToInt32(reader["OGRID"].ToString());
                ent.Ad =reader["OGRAD"].ToString();
                ent.Soyad =reader["OGRSOYAD"].ToString();
                ent.Numara = reader["OGRNUMARA"].ToString();
				ent.Bakiye = reader["OGRBAKIYE"].ToString();
				ent.Fotograf = reader["OGRFOTO"].ToString();
				ent.Sifre = reader["OGRSIFRE"].ToString();
				degerler.Add(ent);
			}

            reader.Close();
            return degerler;
		}

		public static List<EntityOgrenci> GetByIdOgrencı(int id)
		{
			List<EntityOgrenci> degerler = new List<EntityOgrenci>();
			SqlCommand komut = new SqlCommand("SELECT* FROM TBLOGRENCI WHERE OGRID = @id", Baglanti.bgl);

			komut.Parameters.AddWithValue("@id", id);
			if (komut.Connection.State != ConnectionState.Open)
			{
				komut.Connection.Open();
			}

			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				EntityOgrenci ent = new EntityOgrenci();
				ent.Ad = reader["OGRAD"].ToString();
				ent.Soyad = reader["OGRSOYAD"].ToString();
				ent.Numara = reader["OGRNUMARA"].ToString();
				ent.Bakiye = reader["OGRBAKIYE"].ToString();
				ent.Fotograf = reader["OGRFOTO"].ToString();
				ent.Sifre = reader["OGRSIFRE"].ToString();
				degerler.Add(ent);
			}

			reader.Close();
			return degerler;

		}

		public static bool UpdateOgrenci(EntityOgrenci ogr)
		{
			SqlCommand komut = new SqlCommand(
				"UPDATE TBLOGRENCI SET OGRAD = @ad, OGRSOYAD = @soyad, OGRNUMARA = @numara, " +
				"OGRFOTO=@fotograf WHERE OGRID = @id",
				Baglanti.bgl
			);


			komut.Parameters.AddWithValue("@ad", ogr.Ad);
			komut.Parameters.AddWithValue("@soyad", ogr.Soyad);
			komut.Parameters.AddWithValue("@numara", ogr.Numara);
			//komut.Parameters.AddWithValue("@bakiye", ogr.Bakiye);
			komut.Parameters.AddWithValue("@fotograf", ogr.Fotograf);
			komut.Parameters.AddWithValue("@id", ogr.Id);


			if (komut.Connection.State != ConnectionState.Open)
			{
				komut.Connection.Open();
			}

			return komut.ExecuteNonQuery() >0 ;
		}

		public static bool DeleteOgrenci(int id)
		{
			SqlCommand komut = new SqlCommand("DELETE FROM TBLOGRENCI WHERE OGRID = @id", Baglanti.bgl);

			if (komut.Connection.State != ConnectionState.Open)
			{
				komut.Connection.Open();
			}

			komut.Parameters.AddWithValue("@id", id);

			return komut.ExecuteNonQuery() >0 ;
		}

		

	}
}

