using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("developers")]
    public class Developer
    {
        [Key]
        [Column("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column("credentials_id")]
        public string CredentialsId { get; set; }
    }
}