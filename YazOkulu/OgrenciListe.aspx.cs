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
	public partial class OgrenciListe : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			List<EntityOgrenci> entityOgrencis = BLLOgrenci.OgrenciListeleBLL();
			Repeater1.DataSource = entityOgrencis;
			Repeater1.DataBind();
		}

		protected void Sil_Click(object sender, CommandEventArgs e)
		{
			int id = Convert.ToInt32(e.CommandArgument);
			if (BLLOgrenci.OgrenciSilBLL(id))
			{
				// Başarılı silme işlemi sonrası
				Response.Redirect("OgrenciListe.aspx");
			}
			else
			{
				// Hata mesajı gösterebilirsiniz
			}
		}

	}
}