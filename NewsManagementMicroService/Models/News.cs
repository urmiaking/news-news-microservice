using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsManagementMicroService.Models
{
    public class News
    {

        public News()
        {
            
        }

        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 200)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 300)]
        public string ShortDescription { get; set; }

        [Required]
        [StringLength(maximumLength: 10000, MinimumLength = 300)]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public string ImageName { get; set; }

        public int VisitCount { get; set; }

        public bool ShowInSlider { get; set; }

        public virtual List<Comment> Comments { get; set; }

        public int NewsGroupId { get; set; }

        public NewsGroup NewsGroup { get; set; }

        [Required]
        public string Tags { get; set; }
    }
}
