using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "Image")]
        public string UrlImage { get; set; }

        [Display(Name = "Contents")]
        public string content { get; set; }

        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }

        public string? Author { get; set; }
    }

    public class PostValidator : AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.content).NotNull();
        }
    }
}