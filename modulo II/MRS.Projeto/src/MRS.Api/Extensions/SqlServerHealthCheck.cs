﻿using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MRS.Api.Extensions
{
    public class SqlServerHealthCheck : IHealthCheck
    {
        private readonly string _Connection;

        public SqlServerHealthCheck(string connection)
        {
            _Connection = connection;
        }
      
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_Connection))
                {
                    await con.OpenAsync();

                    var command = con.CreateCommand();
                    command.CommandText = "SELECT COUNT(ID) FROM FORNECEDORES";

                    var result = await command.ExecuteScalarAsync();

                    if (Convert.ToInt32(result) > 0)
                    {
                        return HealthCheckResult.Healthy("Tudo OK");
                    }
                    else
                    {
                        return HealthCheckResult.Unhealthy("Nenhum registro");
                    }
                }
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy($"Problema : {ex.Message}"); 
            }
        }
        
    }
}
