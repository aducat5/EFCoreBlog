using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreBlog.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}