﻿using GR.Data.Models;

namespace Generic_Repository.Models
{
    public class Book:BaseEntity

    {

     
        public int? AuthorId { get; set; }

        public string? Name { get; set; }
        
        public string? ISBN { get; set; }
       
        public string? Publisher { get; set; }
        public virtual Author Author { get; set; } 
    }
}
