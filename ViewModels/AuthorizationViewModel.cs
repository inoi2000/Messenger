using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TopMessenger.Infrastructure.Services;
using TopMessenger.ModelShells;
using TopMessenger.ViewModels.Commands;

namespace TopMessenger.ViewModels
{
    public class AuthorizationViewModel : BaseViewModel
    {

        #region Properties
        
        #endregion

        #region Commands
        public ActionCommand WindowMinimizeCommand => new ActionCommand(x => WindowMinimize());
        public ActionCommand WindowMaximizeCommand => new ActionCommand(x => WindowMaximize());
        public ActionCommand CloseWindowCommand => new ActionCommand(x => Application.Current.Windows[Application.Current.Windows.Count - 1].Close());
        #endregion


        private void WindowMaximize()
        {
            if (Application.Current.Windows[Application.Current.Windows.Count - 1].WindowState == WindowState.Normal)
            {
                Application.Current.Windows[Application.Current.Windows.Count - 1].WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.Windows[Application.Current.Windows.Count - 1].WindowState = WindowState.Normal;
            }
        }

        private void WindowMinimize()
        {
            Application.Current.Windows[Application.Current.Windows.Count - 1].WindowState = WindowState.Minimized;
        }
    }
}
