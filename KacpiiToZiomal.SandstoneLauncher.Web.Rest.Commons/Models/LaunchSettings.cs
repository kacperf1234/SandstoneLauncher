using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("launch_settings")]
    public class LaunchSettings
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("user_id")]
        public string UserId { get; set; }

        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column("removed_at")]
        public DateTime? RemovedAt { get; set; }

        /// <summary>
        /// "{xmx:int},{xms:int}" parse it with regex
        /// </summary>
        [Column("memory")]
        public string Memory { get; set; }

        [Column("java_executable")]
        public string JavaExecutable { get; set; }

        [Column("credentials_type")]
        public int CredentialsType { get; set; }

        [Column("credentials_id")]
        public string CredentialsId { get; set; }

        [Column("xx")]
        public string Xx { get; set; }

        /// <summary>
        /// C:\Users\.minecraft
        /// </summary>
        [Column("game_directory")]
        public string GameDirectory { get; set; }

        [Column("version_id")]
        public string VersionId { get; set; }

        [Column("uuid")]
        public string Uuid { get; set; }

        [Column("access_token")]
        public string AccessToken { get; set; }

        [Column("user_type")]
        public string UserType { get; set; }
    }
}