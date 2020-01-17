using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("user_registrations")]
    public class UserRegistration
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        
        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("developer_token_id")]
        public string DeveloperTokenId { get; set; }

        [Column("return_url")]
        public string ReturnUrl { get; set; }

        [Column("cancel_url")]
        public string CancelUrl { get; set; }
    }
}