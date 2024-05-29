using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NvhLesson06.Models
{
    public class NvhSong
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nvh:Hãy nhập tiêu đề")]
        [System.ComponentModel.DisplayName("Tiêu đề")]
        public string NvhTitle { get; set; }
        [Required(ErrorMessage = "Nvh:Hãy nhập tác giả")]
        [DisplayName("tác giả")]
        public string NvhAuthor { get; set; }
        [Required(ErrorMessage = "Nvh:hãy nhập nghệ sĩ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nvh:tên nghệ sĩ có ít nhất 2 kí tự ,tối đa 50 kí tự")]
        [DisplayName("nghệ sĩ")]
        public int NvhArtist { get; set; }
        [Required(ErrorMessage = "Nvh:Hãy nhập Năm xuất bản")]
        [RegularExpression("@[0-9]", ErrorMessage = "Nvh:Nhập xuất bản phải có 2 kí tự số")]
        [Range(1900, 2024, ErrorMessage = "Nvh:Năm xuất bản trong khoảng 1900-2004")]
        [DisplayName("Năm xuất bản")]
        public int NvhYearRelease { get; }
    }
}