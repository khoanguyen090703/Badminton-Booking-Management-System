﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BusinessObjects
{
    [Table("CourtGroup")]
    public class CourtGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public float? Rate { get; set; }

        public string FromDay { get; set; }

        public string ToDay { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public string? ProfileImage { get; set; }

        public string? CoverImage { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ModifiedBy { get; set; }

        public ICollection<Court>? Courts { get; set; }

        public ICollection<CourtSlot>? CourtSlots { get; set; }

        public Company Company { get; set; }    

        public ICollection<ContactPoint>? ContactPoints { get; set; }

        public ICollection<Feedback>? Feedbacks { get; set; }

        public ICollection<Service>? Services { get; set; }
    }
}
