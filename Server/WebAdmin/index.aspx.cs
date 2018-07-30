using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAdmin
{
    public partial class index : System.Web.UI.Page
    {
        private foreignShopEntities _ctx;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var _ctx = new foreignShopEntities();
            var index = new Index
            {
                SwiperLinker = txtLink.Text.Trim(),
                SwiperProductId = 1,
                SwiperProductName = "中国梦"
            };
            _ctx.Index.Add(index);
            _ctx.SaveChanges();
        }
    }
}