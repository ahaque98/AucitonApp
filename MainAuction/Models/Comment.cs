using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainAuction.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string  Content { get; set; }

        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }

        public int? ListId { get; set; }
        [ForeignKey("ListId")]
        public Listing? Listing { get; set; }
    }
}
