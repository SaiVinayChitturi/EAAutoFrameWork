using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.Base
{
    public class ParllelConfig
    {
        public RemoteWebDriver Driver { get; set; }

        public BasePage CurrentPage { get; set; }

    }
}
