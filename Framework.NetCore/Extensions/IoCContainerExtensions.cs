using System;
using System.Collections.Generic;
using System.Text;
using Framework.NetCore.IoC;

namespace Framework.NetCore.Extensions
{
    public static class IoCContainerExtensions
    {
        public static void AddAspect(this IoCContainer container)
        {
            if(container==null)
                throw new ArgumentNullException(nameof(container));
        }
    }
}
