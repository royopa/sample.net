using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamSample2.Models.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime releaseDate { get; set; }

        public Band BandId { get; set; }
    }
}