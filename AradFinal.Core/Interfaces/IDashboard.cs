using AradFinal.Core.ViewModels.Dashboard;
using AradFinal.DAL.Entities;
using AradFinal.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AradFinal.Core.Interfaces
{
  public interface IDashboard:IDisposable
    {
        #region Social

        Task<List<Social>> GetSocials();
        Task<Social> GetSocial(Guid id);
        void AddSocial(SocialViewModel viewModel);
        void UpdateSocial(SocialViewModel viewModel, Guid id);
        void DeleteSocial(Guid id);
        void GoTrashSocial(Guid id);

        #endregion

        #region Setting

        Task<Setting> GetSetting();
        bool UpdateBanner(BannerSettingViewModel viewModel);

        #endregion
    }
}
