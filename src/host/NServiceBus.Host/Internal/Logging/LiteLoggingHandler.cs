﻿namespace NServiceBus.Host.Internal.Logging
{
    /// <summary>
    /// Handles logging configuration for the lite profile.
    /// </summary>
    public class LiteLoggingHandler : IConfigureLoggingForProfile<Lite>
    {
        void IConfigureLogging.Configure(IConfigureThisEndpoint specifier)
        {
            var layout = new log4net.Layout.PatternLayout("%d [%t] %-5p %c [%x] <%X{auth}> - %m%n");
            var level = log4net.Core.Level.Debug;

            var appender = new log4net.Appender.ConsoleAppender
            {
                Layout = layout,
                Threshold = level
            };
            log4net.Config.BasicConfigurator.Configure(appender);
        }
    }
}