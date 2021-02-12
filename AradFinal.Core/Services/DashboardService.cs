using AradFinal.Core.Generators;
using AradFinal.Core.Interfaces;
using AradFinal.Core.ViewModels.Dashboard;
using AradFinal.DAL.Entities;
using AradFinal.DataAccessLayer.Contex;
using AradFinal.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AradFinal.Core.Services
{
    public class DashboardService : IDashboard
    {
        private DataBaseContext _context;
        public DashboardService(DataBaseContext context)
        {
            _context = context;
        }
        public void AddSocial(SocialViewModel viewModel)
        {
            Social social = new Social()
            {
                Address = viewModel.Address,
                Color = viewModel.Color,
                Icon = viewModel.Icon,
                Id = CodeGenerators.GetGuid(),
                IsDelete = false,
                Name = viewModel.Name,
                OrderShow = viewModel.OrderShow,
                LastModifyDate=CodeGenerators.GetShamsiDate(),
                LastModifyTime=CodeGenerators.GetCurrentTime()
            };
            _context.socials.Add(social);
            _context.SaveChanges();
        }

        public void DeleteSocial(Guid id)
        {
            Social social = _context.socials.Find(id);
            if (social != null)
            {
                _context.socials.Remove(social);
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
            if (_context!= null)
            {
                _context.Dispose();
            }
        }

        public async Task<Setting> GetSetting()
        {
            return await _context.Settings.FirstOrDefaultAsync();
        }

        public async Task<Social> GetSocial(Guid id)
        {
            return await _context.socials.FindAsync(id);
        }

        public async Task<List<Social>> GetSocials()
        {
            return await _context.socials.OrderBy(s => s.Name).ToListAsync();
        }

        public void GoTrashSocial(Guid id)
        {
            Social social = _context.socials.Find(id);
            if (social!= null)
            {
                social.IsDelete = true;
                social.LastModifyDate = CodeGenerators.GetShamsiDate();
                social.LastModifyTime = CodeGenerators.GetCurrentTime();
                _context.SaveChanges();
            }
          
        }

        public bool UpdateBanner(BannerSettingViewModel viewModel)
        {
            if (viewModel.BannerImg != null)
            {
                if (Path.GetExtension(viewModel.BannerImg.FileName) != ".jpg")
                {
                    return false;
                }

                string filePath = "";
                viewModel.BannerImgName = CodeGenerators.GetFileCode() + ".jpg";
                filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/site/", viewModel.BannerImgName);

                using(var stream = new FileStream(filePath, FileMode.Create))
                {
                    viewModel.BannerImg.CopyTo(stream);
                }

                Setting setting = _context.Settings.FirstOrDefault();
                setting.BannerSubTitle = viewModel.BannerSubTitle;
                setting.BannerTitle = viewModel.BannerTitle;
                setting.Banner = viewModel.BannerImgName;

                _context.SaveChanges();

                return true;
            }

            return false;
        }

        public void UpdateSocial(SocialViewModel viewModel, Guid id)
        {
            Social social = _context.socials.Find(id);
            if (social!= null)
            {
                social.Icon = viewModel.Icon;
                social.Color = viewModel.Color;
                social.Address = viewModel.Address;
                social.Name = viewModel.Name;
                social.IsDelete = false;
                social.OrderShow = viewModel.OrderShow;
                social.LastModifyDate = CodeGenerators.GetShamsiDate();
                social.LastModifyTime = CodeGenerators.GetCurrentTime();

                _context.SaveChanges();

            }
          
        }
    }
}
