using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuzceUni.Entity.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminAbout { get; set; }
        public string AdminMail { get; set; }
        public string AdminPasswordHash { get; set; }
        public string SecretKey { get; set; } = Guid.NewGuid().ToString().Replace("-", "") + DateTime.Now.ToString().Replace("-", "").Replace(" ", "").Replace(":", "");
        public bool AdminStatus { get; set; }
        [NotMapped]
        public string AdminPassword { get; set; }

    }
}