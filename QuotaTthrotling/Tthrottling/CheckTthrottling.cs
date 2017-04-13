using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotaTthrotling.Tthrottling
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class CheckTthrottling
    {

        AppFunc _next;
        private TthrottlingConfigurationOptions _configOptions;
        public CheckTthrottling(AppFunc next, TthrottlingConfigurationOptions configOptions)
        {
            _next = next;
            _configOptions = configOptions;
        }
        public async Task Invoke(IDictionary<string, object> environment)
        {
            IOwinContext context = new OwinContext(environment);
            
            //await context.Response.WriteAsync("<h1>Hello from My First Middleware</h1>");
            await _next.Invoke(environment);
        }

    }
}
