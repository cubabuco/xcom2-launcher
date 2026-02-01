using log4net.Core;
using Sentry;

namespace XCOM2Launcher.Log4Net
{
    internal static class LevelMapping
    {
        public static SentryLevel[] ToSentryLevel(this LoggingEvent loggingLevel)
        {
            switch (loggingLevel.Level)
            {
                case var l when l == Level.Fatal
                                || l == Level.Emergency
                                || l == Level.All:
                    return new[] { SentryLevel.Fatal };
                case var l when l == Level.Alert
                                || l == Level.Critical
                                || l == Level.Severe
                                || l == Level.Error:
                    return new[] { SentryLevel.Error };
                case var l when l == Level.Warn:
                    return new[] { SentryLevel.Warning };
                case var l when l == Level.Notice
                                || l == Level.Info:
                    return new[] { SentryLevel.Info };
                case var l when l == Level.Debug
                                || l == Level.Verbose
                                || l == Level.Trace
                                || l == Level.Finer
                                || l == Level.Finest
                                || l == Level.Fine:
                    return new[] { SentryLevel.Debug };
            }

            return new SentryLevel[] { };
        }

        public static BreadcrumbLevel ToBreadcrumbLevel(this LoggingEvent loggingLevel)
        {
            switch (loggingLevel.Level)
            {
                case var l when l == Level.Fatal
                                || l == Level.Emergency
                                || l == Level.All:
                    return BreadcrumbLevel.Critical;
                case var l when l == Level.Alert
                                || l == Level.Critical
                                || l == Level.Severe
                                || l == Level.Error:
                    return BreadcrumbLevel.Error;
                case var l when l == Level.Warn:
                    return BreadcrumbLevel.Warning;
                case var l when l == Level.Notice
                                || l == Level.Info:
                    return BreadcrumbLevel.Info;
                case var l when l == Level.Debug
                                || l == Level.Verbose
                                || l == Level.Trace
                                || l == Level.Finer
                                || l == Level.Finest
                                || l == Level.Fine:
                    return BreadcrumbLevel.Debug;
            }

            return BreadcrumbLevel.Debug;
        }
    }
}
