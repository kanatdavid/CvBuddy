using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Runtime.InteropServices;

namespace bla.Model.CvInfo
{
    public class Cv
    {

        //Tydligen sp ska de saker som inte är nullable markeras som Required,
        //eftersom att Mvc tolkar det som required men det inte riktigt är
        //det viket innebär att Modelstate kan bli ogiltigt invalid

        //Btw ändrade ImageFile till nullable efter detta
        [Key]
        public int Cid { get; set; }

        //Nullable kommentarer för att annars kan inte ett cv skapas utan respektive egenskap, därmed db får falsk data om inte kan lämnas tomt
        public List<Skill> Skills { get; set; } = new(); //Objekt i List borde vara nullable


        public Education Education { get; set; } //Borde vara nullable

        public List<Experience> Experiences { get; set; } = new(); //Objekt i List borde vara nullable

        public List<Certificate> Certificates{ get; set; } = new();//Objekt i List borde vara nullable

        public List<PersonalCharacteristic> PersonalCharacteristics{ get; set; } = new();//Objekt i List borde vara nullable


        //----------------------------------------------------------------------------------------------------------------------------public bool IsPrivate { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;

        public List<Interest> Interests { get; set; } = new();


        public string? ImageFilePath { get; set; } = "pic.png";

        [NotMapped]
        public IFormFile? ImageFile { get; set; } //Borde vara nullable
        public int ReadCount { get; set; }
        public string? UserId { get; set; } //Vart null

        [ForeignKey(nameof(UserId))]
        public User? OneUser { get; set; } //varför nullable, ett cv måste ha en ägare


        [NotMapped]
        public List<Project> UsersProjects { get; set; } = new();
    }
}
