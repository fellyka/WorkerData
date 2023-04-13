using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WorkerData.Models.DBEntities
{
    public class Worker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{get;set;}
        
        [Column(TypeName ="varchar(50)")]
        public string FirstName{get;set;}
        public string LastName{get;set;}

        public DateTime DateOfBirth{get;set;}

        public string Email{get;set;}

        public double Salary{get;set;}
    }
}