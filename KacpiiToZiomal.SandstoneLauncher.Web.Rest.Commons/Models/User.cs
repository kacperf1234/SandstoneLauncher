using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("developer_id")]
        public string DeveloperId { get; set; }

        [Column("registration_id")]
        public string RegistrationId { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("email_confirmed")]
        public bool EmailConfirmed { get; set; }
        
        [Column("email_confirmed_at")]
        public DateTime? EmailConfirmedAt { get; set; }

        [Column("phonenumber")]
        public string PhoneNumber { get; set; }

        [Column("phonenumber_confirmed")]
        public bool PhoneNumberConfirmed { get; set; }

        [Column("phonenumber_confirmed_at")]
        public DateTime? PhoneNumberConfirmedAt { get; set; }
    }
}