using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci O)
        {
            if (O.Soyad != null && O.Numara != null && O.Ad != null && O.Sifre != null && O.Fotograf != null)
            {
                return DALOgrenci.InsertOgrenci(O);
            }
            else
                return -1;
        }

        public static List<EntityOgrenci> OgrenciListeleBLL(){

            return DALOgrenci.ListOgrenci();
        }

		public static List<EntityOgrenci> IdIleListeBLL(int id)
		{
			
				return DALOgrenci.GetByIdOgrencı(id);
			

		}
		public static bool OgrenciGuncelleBLL(EntityOgrenci O)
        {
			if (O.Soyad != null && O.Numara != null && O.Ad != null && O.Sifre != null && O.Fotograf != null)
			{
				return DALOgrenci.UpdateOgrenci(O);
			}
			return false;
		}

		public static bool OgrenciSilBLL(int id)
		{
			if (id !=null)
			{
				return DALOgrenci.DeleteOgrenci(id);
			}
			return false;
			
		}


		//dataaccesslayer katmanında olan ınsertogrenci metodu çağrıldı ve ekleme işlemi yapıldı accesslayerda
		//ise yine entity üzerinden sql kullanarak ekleme yapılmıştı
	}
}
