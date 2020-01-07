using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Label
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int LabelNumber { get; set; }
    }
}
