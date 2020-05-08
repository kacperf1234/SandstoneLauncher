using System;
using System.ComponentModel.DataAnnotations;
using SandstoneLauncher.App.Enums;

namespace SandstoneLauncher.App.Models
{
    public class OnlineUser : User
    {
        [Key]
        public override Guid Id { get; set; }
        
        
    }
}