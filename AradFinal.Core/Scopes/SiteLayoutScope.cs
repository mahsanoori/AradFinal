using AradFinal.Core.Interfaces;
using AradFinal.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AradFinal.Core.Scopes
{
   public class SiteLayoutScope
    {
        private ITemp _temp;

        public SiteLayoutScope(ITemp temp)
        {
            _temp = temp;
        }

        public async Task<List<Social>> GetSocialsAsync()
        {
            return await _temp.GetSocials();
        }
    }
}
