using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvhLesson06CF.Models
{
    public class NvhCategory
    {
        [Key]
        public int NvhID { get; set; }
        public string NvhCategoryName { get; set; }
        // thuộc tính quan hệ
        public virtual ICollection<NvhBook> NvhBook { get; set; }
    }
}