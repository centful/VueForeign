using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Server.Controllers
{

    public class ValuesController : ApiController
    {
        private foreignShopEntities _ctx;
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            _ctx = new foreignShopEntities();
            base.Initialize(controllerContext);
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
            base.Dispose(disposing);
        }
        [HttpGet]
        [ActionName("swiper")]
        [AllowAnonymous]
        public HttpResponseMessage swiper()
        {
            var _ctx = new foreignShopEntities();

            var newIndex = new Index
            {
                SwiperProductId = 1,
                SwiperProductName="我超级爱春梅",
                SwiperLinker= "https://huyaimg.msstatic.com/cdnimage/gamebanner/phpCRjeHH1528708655.jpg"
            };
            _ctx.Index.Add(newIndex);
            _ctx.SaveChanges();
            return ResultToJson.toJson(newIndex);
        }

        [ActionName("getImg")]
        [HttpGet]
        [AllowAnonymous]
        public HttpResponseMessage getImg()
        {
            var img = _ctx.Index.Where(x => x.Id == 4);
            var res = ResultToJson.toJson(img);
            res.Headers.Add("Access-Control-Allow-Origin", "*");
            return res;
        }
    }
}
