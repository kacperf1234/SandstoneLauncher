using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models
{
    [Table("developer_tokens")]
    public class DeveloperToken
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

        [Column("unauthorized")]
        public bool Unauthorized { get; set; }

        [Column("updated_times")]
        public int UpdatedTimes { get; set; }
    }
}