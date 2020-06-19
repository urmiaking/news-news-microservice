using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsManagementMicroService.Models
{
    public class NewsGroup
    {
        public NewsGroup()
        {

        }

        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string GroupTitle { get; set; }

        public virtual List<News> News { get; set; }
    }
}
