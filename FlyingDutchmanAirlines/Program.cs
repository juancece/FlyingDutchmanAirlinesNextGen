﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace FlyingDutchmanAirlines {
  class Program {
    static void Main(string[] args) {
      InitalizeHost();
    }

    private static void InitalizeHost() =>
      Host.CreateDefaultBuilder()
        .ConfigureWebHostDefaults(builder =>
      {
        builder.UseStartup<Startup>();
        builder.UseUrls("http:/ /0.0.0.0:8080");
      }).Build().Run();
  }
}