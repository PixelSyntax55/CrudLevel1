using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Crud_Level_1.NAME.DTOS.OGDTO
{
    public class RequestPersonDTOS
    {

        [Required]
        [StringLength (100 , MinimumLength = 3) ]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(18 , 100)]
        public int Age { get; set; }

        [Required]
        [Range(10000000000, 99999999999)]
        public long PhoneNumber { get; set; }

        [Required]
        [Range(10000000000, 99999999999)]
        public long CNIC { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100 ,MinimumLength = 20)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength (6 , MinimumLength = 4)]
        public   string Gender { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public  string City { get; set; } = string.Empty;

    }
}