using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HMS.Models
{

    public class Reservation
    {
        public int ID { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string room { get; set; }

        [Required]
        public DateTime checkin { get; set; }

        [Required]
        public DateTime checkout { get; set; }

        [Required]
        public int guests { get; set; }

    }
    public class Contact
    {

        public int ID { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string  Message { get; set; }
    }
    public class DatabaseConnection:DbContext
    {
        public DbSet<Reservation> Reserve { get; set; }
        public DbSet<Contact> Contact { get; set; }

    }
}