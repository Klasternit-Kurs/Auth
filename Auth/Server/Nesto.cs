using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth.Server
{
	[Authorize]
	public class Nesto : Hub
	{
		public void Foo() => Console.WriteLine("Ping!");
	}
}
