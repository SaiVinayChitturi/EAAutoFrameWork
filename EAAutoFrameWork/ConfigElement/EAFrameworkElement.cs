using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFrameWork.ConfigElement
{
    public class EAFrameworkElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired =true)]
        public string Name { get { return (string)base["name"]; } }

        [ConfigurationProperty("aut", IsRequired = true)]
        public string AUT { get { return (string)base["aut"]; } }

        [ConfigurationProperty("browser", IsRequired = true)]
        public string Browser { get { return (string)base["browser"]; } }

        [ConfigurationProperty("testtype", IsRequired = true)]
        public string TestType { get { return (string)base["testtype"]; } }

        [ConfigurationProperty("isLog", IsRequired = true)]
        public string IsLog { get { return (string)base["IsLog"]; } }

        [ConfigurationProperty("logPath", IsRequired = true)]
        public string LogPath { get { return (string)base["LogPath"]; } }

    }
}
