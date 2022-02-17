using Autofac;
using GamingNomads.Core.Interfaces;
using GamingNomads.Core.Services;

namespace GamingNomads.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
