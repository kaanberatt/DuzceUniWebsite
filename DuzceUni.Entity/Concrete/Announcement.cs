using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DuzceUni.Entity.Concrete
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }
        public string  AnnouncementTitle { get; set; }
        public string AnnouncementContent { get; set; }
        public string AnnouncementThumbnail { get; set; }
        public string AnnouncementImage { get; set; }
        public DateTime CreateDate {get; set;}
        public bool BlogStatus { get; set; }
    }
}