using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Notifications.Models
{
    public class Notification
    {
        [Key]
        public Guid? Id { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Notification()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}