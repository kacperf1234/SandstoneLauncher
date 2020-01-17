using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("developer_credentials")]
    public class DeveloperCredentials : IDbModel
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
        
        public object GetValue() => this;
    }
}