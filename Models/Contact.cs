using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace address_book.Models;
public class Contact
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [NotMapped]
    public string FullName { get { return $"{FirstName} {LastName}"; } }

    [Required]
    public string Address { get; set; }

    public string City { get; set; }
    public string Province { get; set; }

    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    public DateTime Created { get; set; }

    [NotMapped]
    [Display(Name = "Image")]
    [DataType(DataType.Upload)]
    public IFormFile ImageFile { get; set; }
    public byte[] ImageData { get; set; }
    public string ImageType { get; set; }
    public int Id { get; set; }

}
