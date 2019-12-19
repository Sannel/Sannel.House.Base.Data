using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sannel.House.Base.Data.Tests
{
	public class HealthChecksBuilderMock : IHealthChecksBuilder
	{
		private IServiceCollection services = new ServiceCollection();
		public IServiceCollection Services => services;

		public IHealthChecksBuilder Add(HealthCheckRegistration registration)
		{
			return this;
		}
	}
}
