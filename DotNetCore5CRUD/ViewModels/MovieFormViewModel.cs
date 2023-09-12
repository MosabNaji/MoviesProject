using DotNetCore5CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore5CRUD.ViewModels
{
    public class MovieFormViewModel
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field"), StringLength(250),Display(Name = "Title")]
        public string Title { get; set; }
        [ Display(Name = "Year")]
        public int Year { get; set; }

        [Range(1, 10), Display(Name = "Rate")]
        public double Rate { get; set; }

        [Required(ErrorMessage = "Required field"), StringLength(2500), Display(Name = "Storeline")]
        public string Storeline { get; set; }

        [Display(Name = "Select poster...")]
        public byte[] Poster { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}