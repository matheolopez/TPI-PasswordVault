using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class SQLiteDataAccess
    {
        public static List<Account> LoadAccounts()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Account>("SELECT idAccount AS ID, accTitle AS Title, accLogin AS Login, accPassword AS Password, accComment AS Comment FROM t_account", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddAccount(Account account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO t_account (accTitle, accLogin, accPassword, accComment) values (@Title, @Login, @Password, @Comment)", account);
                // ToDo: Create History
            }
        }

        public static void ModifyAccount(Account account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE t_account SET accTitle = @Title, accLogin = @Login, accPassword = @Password, accComment = @Comment WHERE idAccount = @ID", account);
                // ToDo: Modify History
            }
        }

        public static void DeleteAccount(Account account)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<int>("SELECT * FROM t_history", new DynamicParameters());
                foreach (var id in output.ToList())
                {
                    cnn.Execute("DELETE FROM t_account WHERE idAccount = @ID", id);
                }
                cnn.Execute("DELETE FROM t_account WHERE idAccount = @ID", account);
                cnn.Execute("DELETE FROM t_history WHERE fkAccount = @ID", account);
                // ToDo: Delete History
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
