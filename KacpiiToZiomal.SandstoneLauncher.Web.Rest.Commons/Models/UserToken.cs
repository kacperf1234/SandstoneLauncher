﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("users_token")]
    public class UserToken
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("user_id")]
        public string UserId { get; set; }

        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("token")]
        public string Token { get; set; }

        [Column("generated_at")]
        public DateTime? GeneratedAt { get; set; }

        [Column("authorized_at")]
        public DateTime? AuthorizedAt { get; set; }

        [Column("unauthorized_at")]
        public DateTime? UnauthorizedAt { get; set; }

        [Column("authorized")]
        public bool Authorized { get; set; }

        [Column("unauthorized")]
        public bool Unauthorized { get; set; }
    }
}