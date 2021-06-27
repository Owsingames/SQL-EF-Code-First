using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SQL_CodeFirst_Demo
{
    class Animal
    {
        [Key] // this will set the property below to the Table Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // sets identity to (1,1) for primary key
        [Required] // property may NOT BE NULL, must have a value for primary key
        public int Id { get; set; }

        [MaxLength(20)] // sets max length of property to 20
        public string Name { get; set; }
        [MaxLength(20)]
        public string EaterType { get; set; }
        [MaxLength(15)]
        public string Species { get; set; }
        [Range(0,100)] // set the max age range
        public int Age { get; set; }
    }
}
