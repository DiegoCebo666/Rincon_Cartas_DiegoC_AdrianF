using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RinconAPI.Core
{
    public static class ScopePolicy
    {
        public static List<string> ApiUse => new List<string> { "Api.Use" };
        public static List<string> ApiProducts => new List<string> { "Api.Use", "Api.Products" };

    }
}
