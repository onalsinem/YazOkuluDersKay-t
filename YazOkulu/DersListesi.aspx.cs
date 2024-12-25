using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;

namespace YazOkulu
{
	public partial class DersListesi : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			List<EntityDers> list = BLLDers.DersListesi();
			Repeater1.DataSource = list;
			Repeater1.DataBind();
		}
	}
}