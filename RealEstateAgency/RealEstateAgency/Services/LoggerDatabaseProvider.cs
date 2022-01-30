using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RealEstateAgency.Database;
using System;

namespace RealEstateAgency.Services
{
    public class LoggerDatabaseProvider : ILoggerProvider
    {
        public LoggerDatabaseProvider(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public ILogger CreateLogger(string categoryName)
        {
            return new Logger(Configuration);
        }

        public void Dispose()
        {
        }

        public class Logger : ILogger
        {
            public IConfiguration Configuration { get; }

            public Logger(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                if (logLevel == LogLevel.Error)
                    RecordMsg(logLevel, eventId, state, exception, formatter);
            }

            private void RecordMsg<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                var optionsBuilder = new DbContextOptionsBuilder<RealEstateAgencyContext>();
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

                using var dbContext = new RealEstateAgencyContext(optionsBuilder.Options);
                var entity = new ErrorLog
                {
                    StackTrace = exception?.StackTrace,
                    ExceptionMessage = exception?.Message,
                    InnerExceptionMessage = exception?.InnerException?.Message,
                    DateTime = DateTime.Now
                };

                dbContext.Add(entity);
                dbContext.SaveChanges();
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return new NoopDisposable();
            }

            private class NoopDisposable : IDisposable
            {
                public void Dispose()
                {
                }
            }
        }
    }
}