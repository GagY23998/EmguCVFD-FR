using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class VisitsLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime VisitDate { get; set; }
        public string VisitType { get; set; }

    }
}
