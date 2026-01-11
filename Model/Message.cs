

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bla.Model
{
    public class Message
    {
        [Key]
        public int Mid { get; set; }
        public string Sender { get; set; }
        public string MessageString { get; set; }

        public DateTime SendDate { get; set; } = DateTime.Now;

        public bool IsRead { get; set; }


        [ForeignKey(nameof(RecieverId))]
        public string RecieverId { get; set; }
        public User Reciever { get; set; }//nullable för att testa om modelstate inte blir invalid till SendMessage POST
    }
}
