using Microsoft.EntityFrameworkCore;

using CrudLevel1.NAME.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CrudLevel1.DataConnection 
{
    
public class DataConnect : DbContext
{

        public DataConnect(DbContextOptions<DataConnect> options) : base(options) { }


        public DbSet <Person> Persons { get; set; }

 }
 }