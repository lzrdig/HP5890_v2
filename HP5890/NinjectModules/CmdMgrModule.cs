using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;

namespace HP5890
{
    public class HP5890MgrModule : NinjectModule
    {

        public override void Load()
        {
            Bind<IHP5890mgr>().To<HP5890mgr>().InSingletonScope();
            //Bind<HP5890mgr>().ToSelf().InSingletonScope();
        }

    }
}
