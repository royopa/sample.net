using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamSample2.Models.Entities
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Country CountryId { get; set; }
    }
}