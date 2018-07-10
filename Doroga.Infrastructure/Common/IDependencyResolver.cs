using System;
using System.Collections.Generic;
using System.Text;

namespace Doroga.Infrastructure.Common
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}
