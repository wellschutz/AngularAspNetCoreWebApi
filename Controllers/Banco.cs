using System;
using System.Security.Permissions;
using FirebirdSql.Data.FirebirdClient;

namespace Controllers
{
  public class Banco
  {
    public string Resultado()
    {
      FbConnectionStringBuilder cs = new FbConnectionStringBuilder();

      cs.DataSource = "localhost";
      cs.Database = "C:\\Users\\Wellington\\Documents\\KAMBESS.fdb";
      cs.UserID = "SYSDBA";
      cs.Password = "masterkey";
      cs.Charset = "NONE";
      cs.Pooling = false;

      FbConnection fb =  new FbConnection(cs.ToString());

      string saida = "";

      try
      {
          fb.Open();

          FbCommand leitura = new FbCommand("Select OPE_NOM From OPERACAO WHERE OPE_COD = 40", fb);

          FbDataReader leitor = leitura.ExecuteReader();

          while (leitor.Read())
          {
              saida =   Convert.ToString(leitor[0]);
          }
      }
      catch (Exception e)
      {
          saida = Convert.ToString(e);
      }

    return saida;
    }
  }
}
