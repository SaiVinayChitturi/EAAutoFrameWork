using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.ConfigElement
{
    class EATestConfiguration : ConfigurationSection
    {
        private static EATestConfiguration _testconfig = (EATestConfiguration)ConfigurationManager.GetSection("EATestConfiguration");
        public static EATestConfiguration EASettings { get { return _testconfig;} }

        [ConfigurationProperty("testsettings")]
        public EAFrameworkCollection TestSettings { get { return (EAFrameworkCollection)base["testsettings"]; } }
    }
}
