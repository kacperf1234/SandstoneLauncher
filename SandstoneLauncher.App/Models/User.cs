using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SandstoneLauncher.App.Enums;

namespace SandstoneLauncher.App.Models
{
    public class User
    {
        public virtual Guid Id { get; set; }
        public UserType UserType { get; set; }
    }
}