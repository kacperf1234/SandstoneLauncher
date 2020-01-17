using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("rest_requests")]
    public class RestRequest
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        
        [Column("token_id")]
        public string TokenId { get; set; }
        
        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("return_url")]
        public string ReturnUrl { get; set; }

        [Column("cancel_url")]
        public string CancelUrl { get; set; }

        [Column("generated_at")]
        public DateTime? GeneratedAt { get; set; }

        [Column("invoked")]
        public bool Invoked { get; set; }
    }
}