using System;
using FInalProject.Models;
using FInalProject.Util.DB;
using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DbHandlers
{
    public class DbClientHandler: IDbExecuteHandler<Client>
    {
        public Client GetDataAfterExecute(OracleDataReader rdr)
        {
            return new Client
            {
                ClientName =  rdr["ClientName"].ToString(),
                ClientPhone = rdr["ClientPhone"].ToString(),
                ClientAdress= rdr["ClientAdress"].ToString(),
                ClientType =  rdr["ClientType"].ToString(),
                
                
            };
        }
        
    }
}