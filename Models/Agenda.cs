using System.ComponentModel.DataAnnotations;

namespace AGENDA.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public DateTime DateHeure { get; set; }
        public string Concernee { get; set; }
        public int? Duree { get; set; }
        public string Lieu { get; set; }
        public string Type { get; set; }
    }
}