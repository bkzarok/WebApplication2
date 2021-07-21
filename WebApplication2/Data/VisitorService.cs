using Microsoft.EntityFrameworkCore;
using System;
using Tesseract;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2DB.Data.Visitor;

namespace WebApplication2.Data
{
    public class VisitorService
    {
        private static readonly string[] FirstName1 = new[]
         {
           "kuir", "majure", "Joseph", "Bior", "David", "kuir", "majure", "Joseph", "Bior", "David"
        };
        private static readonly string[] LastName1 = new[]
       {
            "Deng", "Agang", "Arok", "Aleu", "kuir", "majure", "Joseph", "Bior", "David"
        };
        private static readonly string[] Description1 = new[]
       {
        "Meeting with the Director General", "Installation of Server Racks", "Software Development"
            ,"Meeting with the Director General", "Installation of Server Racks", "Software Development"
        };

        private readonly VisitorlogdbContext _context;
        public VisitorService(VisitorlogdbContext context)
        {
            _context = context;
        }

        public  async Task<List<Visitor>> GetVisitorInfoAsync()
        {
            return await _context.Visitor.AsNoTracking().ToListAsync();
        }

        public Task<Visitor> CreateVisitorAsync(Visitor visitor)
        {
            _context.Visitor.Add(visitor);
            _context.SaveChanges();
            return Task.FromResult(visitor);
        }

        public Task<List<Visitor>> GetVisitorDateRange(DateTime fromRange, DateTime toRange)
        {
            List<Visitor> range = (from c in _context.Visitor
                                         where c.CheckIn >= fromRange &&
                                          c.CheckIn <= toRange
                                         select c).ToList();
            _context.SaveChanges();
            return Task.FromResult(range);
        }
        public Task<List<Visitor>> GetVisitorByName(string name)
        {
            List<Visitor> visitors = (from c in _context.Visitor
                                      where c.FirstName == name ||
                                      c.LastName == name
                                      select c).ToList();

            _context.SaveChanges();
            return Task.FromResult(visitors);
        }

        public Task<Visitor> UpdateVisitor(Visitor visitor)
        {
            _context.Visitor.Update(visitor);
            _context.SaveChanges();
            return Task.FromResult(visitor);
        }
    }
}
