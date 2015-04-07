namespace SampleSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        //[Key]
        //[Column(Order = 2)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public int id { get; set; }

        [Key]
        [Column(Order = 0)]
        public string username { get; set; }

        [Column(Order = 1)]
        public string password { get; set; }
    }
}