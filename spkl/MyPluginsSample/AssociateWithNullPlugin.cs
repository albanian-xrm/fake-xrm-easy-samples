﻿
using DataverseEntities;
using Microsoft.Xrm.Sdk;
using System;
using System.ServiceModel;

namespace FakeXrmEasy.Samples.PluginsWithSpkl
{
    [CrmPluginRegistration(
        MessageNameEnum.Associate, 
        null, 
        StageEnum.PreOperation, 
        ExecutionModeEnum.Synchronous,
        "", "PreCreate Contact",
        1, IsolationModeEnum.Sandbox
    )]
    public class AssociateWithNullPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region Boilerplate
            ITracingService tracingService =
                (ITracingService)serviceProvider.GetService(typeof(ITracingService));


            IPluginExecutionContext context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));


            #endregion


            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is EntityReference)
            {


            }
        }
    }
}
