﻿using Autofac;
using CoreDemoApp.Domain;

namespace CoreDemoApp.Infrastructure
{
  public class ServicesModule : Autofac.Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<DatabaseSeeder>().As<IDatabaseSeeder>();
    }
  }
}