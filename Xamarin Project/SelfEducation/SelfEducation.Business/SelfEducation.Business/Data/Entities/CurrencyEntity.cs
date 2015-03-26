using System;
using SelfEducation.Business.Data.Contracts;

namespace SelfEducation.Business.Data.Entities
{
    public class CurrencyEntity : Entity
    {
        public int NumCode { get; set; }
        public string CharCode { get; set; }
        public int Scale { get; set; }
        public string Name { get; set; }
        public DateTime OnDate { get; set; }
        public string Rate { get; set; }
    }
}