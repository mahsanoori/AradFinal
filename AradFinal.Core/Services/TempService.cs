using AradFinal.Core.Interfaces;
using AradFinal.DAL.Entities;
using AradFinal.DataAccessLayer.Contex;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AradFinal.Core.Services
{
    public class TempService : ITemp
    {
        private DataBaseContext _context;

        public TempService(DataBaseContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            if (_context!= null)
            {
                _context.Dispose();
            }
        }

        public async Task<List<Social>> GetSocials()
        {
            return await _context.socials.Where(s => s.IsDelete == false && s.OrderShow != 0).OrderBy(s => s.OrderShow).ToListAsync();
        }
    }
}
