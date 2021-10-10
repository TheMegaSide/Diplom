using Oracle.ManagedDataAccess.Client;

namespace FInalProject.Util.DB
{
    public interface IDbExecuteHandler<T>
    {
         T GetDataAfterExecute(OracleDataReader rdr);
    }
}