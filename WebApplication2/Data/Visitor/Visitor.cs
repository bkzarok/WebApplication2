// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication2DB.Data.Visitor
{
    public partial class Visitor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Phone { get; set; }
        public string Organization { get; set; }
        public string Department { get; set; }
        public string Visiting { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
    }
}