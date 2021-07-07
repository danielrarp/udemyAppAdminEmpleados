using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace udemyAppAdminEmpleados.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Nombre { get; set; }
        public int Antiguedad { get; set; }
        public int Edad { get; set; }

        public string Categoria { get; set; }
   
        public class EmpleadoDBContext : ApplicationDbContext
        {
            public DbSet<Empleado> empleados { get; set; }
        }

    }
}