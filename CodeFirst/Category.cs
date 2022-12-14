using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{

    // Parent Table class
    public class Category
    {

        public int Categoryid { get; set; }


        [Column(TypeName = "varchar(50)" )]
        public string name { get; set; }


        public string desc { get; set; }


        // optional : navigation property
        //public ICollection <Product> Products { get; set; }


    }

     
} 