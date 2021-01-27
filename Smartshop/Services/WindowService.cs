using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Smartshop.Services
{
    public class WindowService<T> : IWindowService<T> where T : Window
    {
        public void Show()
        {
            
        }
    }
}
