using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makale.Models.ViewModels
{
    public class ProfilePasswordMViewModel
    {
        public ProfileViewModel ProfileViewModel { get; set; } = new ProfileViewModel();
        public ChangePasswordViewModel ChangePasswordViewModel { get; set; } =
                                                                     
                                                                         new ChangePasswordViewModel();
    }
}
