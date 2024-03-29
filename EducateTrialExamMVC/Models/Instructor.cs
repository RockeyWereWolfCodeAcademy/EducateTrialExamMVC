﻿using System.ComponentModel.DataAnnotations;

namespace EducateTrialExamMVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [MaxLength(32)]
        public string Name { get; set; }
        [MaxLength(32)]
        public string Surname { get; set; }
        [MaxLength(32)]
        public string Profession { get; set; }
        public string ImgUrl { get; set; }
    }
}
