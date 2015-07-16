using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace MvcMovie.Models
{
    public class MyTestClass
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class NiggaDbContext : DbContext
    {
        public DbSet<MyTestClass> MyTestClasses { get; set; }
    }
}