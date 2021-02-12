using AradFinal.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AradFinal.Core.Interfaces
{
   public interface ITemp:IDisposable
    {
        Task<List<Social>> GetSocials();
    }
}
