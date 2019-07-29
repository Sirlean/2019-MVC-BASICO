using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using teste2._1.Web.Models;

namespace teste2._1.Web.Service
{
    public class Contexto: DbContext
    {
        public DbSet<ServicosViewModel> servico { get; set; }


       
    }
}