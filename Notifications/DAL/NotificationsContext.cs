using Notifications.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Notifications.DAL
{
    public class NotificationsContext : DbContext
    {
        public DbSet<Notification> Notifications { get; set; }

        public NotificationsContext() : base ("Notifications")
        {
        }
    }
}