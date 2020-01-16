using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models
{
    [Table("developer_credentials")]
    public class DeveloperCredentials
    {
        [Key]
        [Column("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("client_id")]
        public string ClientId { get; set; }

        [Column("client_secret")]
        public string ClientSecret { get; set; }
    }
}