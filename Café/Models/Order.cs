using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Café.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del pedido")]

        public string CoffeName { get; set; }
        [Display(Name = "Descripción")]

        public string Description { get; set; }
        [Display(Name = "Cantidad")]

        public int Quantity { get; set; }
        [Display(Name = "Forma de Pago")]

        public decimal Price { get; set; }
        [Display(Name = "Estado")]

        public string Status { get; set; }


    }
}