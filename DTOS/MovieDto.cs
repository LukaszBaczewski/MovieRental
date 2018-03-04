﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.DTOS
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        public int NumberInStock { get; set; }

        public int NumberAvailable { get; set; }
    }
}