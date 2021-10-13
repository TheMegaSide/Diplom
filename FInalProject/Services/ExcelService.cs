using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Util.DB;
using FInalProject.Util.DbHandlers;
using Microsoft.Extensions.Configuration;

namespace FInalProject.Services
{
    public class ExcelService
    {
        public readonly string ConnectionString;

        public ExcelService(IConfiguration configuration)
        {
            ConnectionString = configuration.GetConnectionString("OracleDBConnection");
        }

        public List<Order> GetExcelTable()
        {
            string comText =
                "select *  from Orders";

            return DbExecutor.Execute<Order>(ConnectionString, comText, new DbOrderHandler());
        }
    }
}