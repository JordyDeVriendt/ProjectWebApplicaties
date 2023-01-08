using System;
using System.ComponentModel.DataAnnotations;

namespace Project.ViewModels
{
    public class CreateGebruikerViewModel
    {
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
