using System;
using System.Collections.Generic;
using System.Text;
using Smartshop.Data;

namespace Smartshop.Services
{
    public interface IConfigureService
    {
        SmartshopDbContext dbService { get; set; }
    }
}
