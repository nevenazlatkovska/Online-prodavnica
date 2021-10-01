using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services.Interface
{
    public interface IBackgroundEmailSender
    {
        Task DoWork();
    }
}
