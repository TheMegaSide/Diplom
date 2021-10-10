using System;
using System.Collections.Generic;
using FInalProject.Models;
using FInalProject.Services;
using FInalProject.Util.DB;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbOrderHandler: IDbExecuteHandler<Order>
    {
        public Order GetDataAfterExecute(OracleDataReader rdr)
        {
            
            return new Order
            {
                OrderDate =  (DateTime)rdr["OrderDate"],
                CompletionDate = (DateTime)rdr["CompletionDate"],
                Completion = rdr["Completion"].ToString(),
                TotalPrice = (decimal)rdr["TotalPrice"],
                ClientId = (decimal)rdr["ClientId"],
                OrderList = rdr["OrderList"].ToString()
               
                
            };
        }
    }
    
    }