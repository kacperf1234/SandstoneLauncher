using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("developer_tokens")]
    public class DeveloperToken : IDbModel
    {
        [Key]
        [Column("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("generated_at")]
        public DateTime? GeneratedAt { get; set; }

        [Column("last_updated_at")]
        public DateTime? LastUpdatedAt { get; set; }

        [Column("expired_at")]
        public DateTime? ExpiredAt { get; set; }

        [Column("archived")]
        public bool Archived { get; set; }

        [Column("authorized")]
        public bool Authorized { get; set; }

        [Column("authorized_at")]
        public DateTime? AuthorizedAt { get; set; }

        [Column("unauthorized")]
        public bool Unauthorized { get; set; }
        
        [Column("unauthorized_at")]
        public DateTime? UnauthorizedAt { get; set; }

        [Column("updated_times")]
        public int UpdatedTimes { get; set; }
        
        public object GetValue() => this;
    }
}