using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nguyenvanhieu_BaiThiGiuaKy.Models
{
    public class NvhCustomer
    {
        public string Msv_CustId { get; set; }
        public string Nvh_FullName { get; set; }
        public string Nvh_Address { get; set; }
        public string Nvh_Email { get; set; }
        public string Nvh_Phone { get; set; }
        public int Nvh_Balance { get; set; }
    }
}