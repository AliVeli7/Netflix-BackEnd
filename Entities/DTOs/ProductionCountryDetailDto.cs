using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Entities.Concrete.Models;

namespace Entities.DTOs
{
    public class ProductionCountryDetailDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
