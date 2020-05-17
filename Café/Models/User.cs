using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Café.Models
{
    public class User
    {
        public int Id { get; set; }

        public int SupplierCode { get; set; }
        [Display(Name = "Nombre")]

        public string UserName { get; set; }
        [Display(Name = "Correo Electrónico")]

        public string Email { get; set; }
        [Display(Name = "Teléfono")]

        public int Phone { get; set; }
        [Display(Name = "Dirección")]

        public string Address { get; set; }
    }
}