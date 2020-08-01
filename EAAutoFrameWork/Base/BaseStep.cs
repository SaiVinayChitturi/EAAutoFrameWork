using EAAutoFrameWork.Config;
using EAAutoFrameWork.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
   public abstract class BaseStep : Base
    {

        public virtual void NavigateToSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Initialized Framework");
        }
    }
}
