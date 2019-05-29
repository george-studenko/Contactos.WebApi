using System;
using Microsoft.EntityFrameworkCore;

namespace Contactos.Models{
    public class ContactosContext: DbContext{
        public ContactosContext(DbContextOptions<ContactosContext> options): base(options){

        }
        public DbSet<Contacto> Contacto {get;set;}
    }
}