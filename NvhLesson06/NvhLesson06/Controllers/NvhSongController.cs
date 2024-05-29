using System;
using NvhLesson06.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NvhLesson06.Controllers
{
    public class NvhSongController : Controller
    {
        private static List<NvhSong> NvhSongs = new List<NvhSong>()
        {
            new NvhSong{Id=2210900102,NvhTitle="Nguyễn Văn Hiếu ",NvhAuthor="K22CNTT4",},
            new NvhSong{Id=2210900103,NvhTitle="Nguyễn Văn Hiếu ",NvhAuthor="K22CNTT4",},

        };

        // GET: NvhSong
        /// Hiển thị bài hát
        /// author: Nguyễn Văn Hiếu
        /// </summary>
        /// <returns></returns>
        public ActionResult NvhIndex()
        {
            return View(NvhSongs);
        }
        /// get :Nvhcreate
        /// <summary>
        /// form thêm mới bài hát
        /// author: Nguyễn Văn Hiếu
        ///</summary>
        /// <summary></summary>
        public ActionResult Nvhcreate()
        {
            var NvhSong = new NvhSong();
            return View(NvhSong);

        }
    }
}
