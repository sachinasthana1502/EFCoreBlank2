using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{

    //Child table class
    public  class Product
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int Productid { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public decimal Unitprice { get; set; }

        [ForeignKey("Category")]
        public int Categoryid { get; set; }

        //navigation property
        public Category Category { get; set; }  

    }
}
