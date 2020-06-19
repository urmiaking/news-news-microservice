using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsManagementMicroService.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsConfirmed { get; set; }

        public int NewsId { get; set; }

        public News News { get; set; }

        public int UserId { get; set; }

        public DateTime DateTime { get; set; }
    }
}
