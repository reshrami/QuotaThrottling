using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotaTthrotling.Tthrottling
{
    public class TthrottlingConfigurationOptions
    {
        public TthrottlingConfigurationOptions(string tthrottlingCheckUrl) 
        {
            TthrottlingCheckUrl = tthrottlingCheckUrl;
        }

        public string TthrottlingCheckUrl { get; set; }
    }
}
