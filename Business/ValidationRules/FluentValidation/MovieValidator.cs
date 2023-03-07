using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete.Models;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.ImdbId).NotEmpty();
            RuleFor(p => p.ImdbId).GreaterThan(0).LessThan(10);
            //RuleFor(p => p.ImdbId).GreaterThanOrEqualTo(8).When(p => p.GenreId == 1).WithMessage("Duz Yaz");
            RuleFor(p => p.Name).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
