using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvhLesson06CF.Models
{
    public class NvhBook
    {
        [Key]
        public int NvhID { get; set; }
        public string NvhBookId { get; set; }
        public string NvhTitle { get; set; }
        public string NvhAuthor { get; set; }
        public int NvhYear { get; set; }
        public string NvhPulisher { get; set; }
        public string NvhPicture { get; set; } 
        public int NvhCategoryId { get; set;  }
        // thuộc tính quan hệ 
        public virtual NvhCategory NvhCategory { get; set;  }
    }
}