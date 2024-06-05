using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NvhLesson06CF.Models
{
    public class NvhBookStore:DbContext
    {
        public NvhBookStore():base("NvhBookStoreConnectionString")
        { 
        }

        // khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<NvhCategory> NvhCategory { get; set; }
        public DbSet<NvhBook> NvhBooks { get; set; }

    }
    
}