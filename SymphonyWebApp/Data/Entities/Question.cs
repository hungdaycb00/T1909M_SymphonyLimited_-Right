using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
    }
    public class ClassQuestionValidator : AbstractValidator<Question>
    {
        public ClassQuestionValidator()
        {
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.Answer).NotNull();
        }
    }
}