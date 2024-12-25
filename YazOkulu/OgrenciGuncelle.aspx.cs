using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkulu
{
	public partial class OgrenciGuncelle : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int x= Convert.ToInt32(Request.QueryString["id"].ToString());

			ID.Text = x.ToString();
			ID.Enabled = false;

			if(Page.IsPostBack == false)
			{
				List<EntityOgrenci> ogr = BLLOgrenci.IdIleListeBLL(x);
				txtad.Text = ogr[0].Ad.ToString();
				txtsoyad.Text = ogr[0].Soyad.ToString();
				txtfotograf.Text = ogr[0].Fotograf.ToString();
				txtnumara.Text = ogr[0].Numara.ToString();
				txtsifre.Text = ogr[0].Sifre.ToString();
			}	
		
		}


		protected void Button2_Click(object sender, EventArgs e)
		{
			EntityOgrenci ent = new EntityOgrenci
			{
				Id = Convert.ToInt32(ID.Text), 
				Numara = txtnumara.Text,
				Ad = txtad.Text,
				Soyad = txtsoyad.Text,
				Sifre = txtsifre.Text,
				Fotograf = txtfotograf.Text,
			};

			if (BLLOgrenci.OgrenciGuncelleBLL(ent))
			{
				Response.Redirect("OgrenciListe.Aspx");
			}
			else
			{
				Response.Write("Güncelleme işlemi başarısız.");
			}
		}

	}
}