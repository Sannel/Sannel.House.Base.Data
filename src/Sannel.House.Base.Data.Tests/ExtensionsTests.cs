using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sannel.House.Base.Data.Tests
{
	public class ExtensionsTests
	{
		[Fact]
		public void AddDbHealthCheckTest()
		{
			var builder = new HealthChecksBuilderMock();
			Assert.Throws<ArgumentNullException>("queryAsync", () => Extensions.AddDbHealthCheck<DbContext>(builder, "Test", null));
		}

		[Fact]
		public void AddDbHealthCheck2Test()
		{
			var builder = new HealthChecksBuilderMock();
			Assert.Throws<ArgumentNullException>("queryAsync", () => Extensions.AddDbHealthCheck<DbContext>(builder, "Test", null, 2));
		}

		[Fact]
		public void AddDbHealthCheck3Test()
		{
			Assert.Throws<ArgumentNullException>("builder", () => Extensions.AddDbHealthCheck<DbContext>(null, "Test", null));
		}

		[Fact]
		public void AddDbHealthCheck4Test()
		{
			Assert.Throws<ArgumentNullException>("builder", () => Extensions.AddDbHealthCheck<DbContext>(null, "Test", null, 2));
		}

	}
}
