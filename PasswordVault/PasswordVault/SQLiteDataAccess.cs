﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace PasswordVault
{
    public class SQLiteDataAccess
    {
        /// <summary>
        /// Gets all "last" accounts
        /// </summary>
        /// <returns>List of accounts</returns>
        public static List<Account> LoadAccounts()
        {
            // Open an SQLite connection
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Account>("SELECT idAccount AS ID, accTitle AS Title, accLogin AS Login, accPassword AS Password, accComment AS Comment, accLast AS Last, accDate AS Date FROM t_account WHERE accLast = 1", new DynamicParameters());
                List<Account> result = output.ToList();

                // Decrypt data
                foreach (Account account in result)
                {
                    account.Title = CryptClass.DecryptString(account.Title);
                    account.Login = CryptClass.DecryptString(account.Login);
                    account.Password = CryptClass.DecryptString(account.Password);
                    account.Comment = CryptClass.DecryptString(account.Comment);
                }
                return result;
            }
        }

        /// <summary>
        /// Adds an account to the database and creates it's history
        /// </summary>
        /// <param name="account">Account to add in the database</param>
        public static void AddAccount(Account account)
        {
            // Encrypt data
            account.Title = CryptClass.EncryptString(account.Title);
            account.Login = CryptClass.EncryptString(account.Login);
            account.Password = CryptClass.EncryptString(account.Password);
            account.Comment = CryptClass.EncryptString(account.Comment);

            account.Date = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

            // Open an SQLite connection
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO t_account (accTitle, accLogin, accPassword, accComment, accDate) values (@Title, @Login, @Password, @Comment, @Date)", account);
                cnn.Execute("INSERT INTO t_history (fkAccount) values ((SELECT idAccount FROM t_account ORDER BY idAccount DESC LIMIT 1))");
            }
        }

        /// <summary>
        /// Modifies account and updates the history
        /// </summary>
        /// <param name="account">Modified account to update</param>
        public static void ModifyAccount(Account account)
        {
            // Open an SQLite connection
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Get old data from account
                var outputOldAccount = cnn.Query<Account>("SELECT idAccount AS ID, accTitle AS Title, accLogin AS Login, accPassword AS Password, accComment AS Comment, accLast AS Last, accDate AS Date FROM t_account WHERE idAccount = " + account.ID, new DynamicParameters());
                Account oldAccount = outputOldAccount.ToList()[0];

                // INSERT data with old account (last = 0)
                cnn.Execute("INSERT INTO t_account (accTitle, accLogin, accPassword, accComment, accLast, accDate) values (@Title, @Login, @Password, @Comment, 0, @Date)", oldAccount);

                // Encrypt data
                account.Title = CryptClass.EncryptString(account.Title);
                account.Login = CryptClass.EncryptString(account.Login);
                account.Password = CryptClass.EncryptString(account.Password);
                account.Comment = CryptClass.EncryptString(account.Comment);

                // UPDATE data with updated account
                account.Date = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                cnn.Execute("UPDATE t_account SET accTitle = @Title, accLogin = @Login, accPassword = @Password, accComment = @Comment, accDate = @Date WHERE idAccount = @ID", account);

                // Get history from account
                var outputHistory = cnn.Query<History>("SELECT * FROM t_history WHERE fkAccount = " + account.ID, new DynamicParameters());
                History history = outputHistory.ToList()[0];

                // DELETE last history account
                if (history.his10 != null)
                {
                    cnn.Execute("DELETE FROM t_account WHERE idAccount = " + history.his10);
                }

                // Move all ids from history
                cnn.Execute("UPDATE t_history SET his10 = @his9, his9 = @his8, his8 = @his7, his7 = @his6, his6 = @his5, his5 = @his4, his4 = @his3, his3 = @his2, his2 = @his1, his1 = (SELECT idAccount FROM t_account ORDER BY idAccount DESC LIMIT 1) WHERE fkAccount = " + account.ID, history);
            }
        }

        /// <summary>
        /// Deletes account form database and all it's history
        /// </summary>
        /// <param name="account">Account to delete</param>
        public static void DeleteAccount(Account account)
        {
            // Open an SQLite connection
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<History>("SELECT * FROM t_history WHERE fkAccount = " + account.ID, new DynamicParameters());
                cnn.Execute("DELETE FROM t_history WHERE fkAccount = @ID", account);
                cnn.Execute("DELETE FROM t_account WHERE idAccount = " + account.ID);
                History history = output.ToList()[0];
                foreach (int id in history.getIds())
                {
                    cnn.Execute("DELETE FROM t_account WHERE idAccount = " + id);
                }
            }
        }

        /// <summary>
        /// Gets connection string for the SQLite connection
        /// </summary>
        /// <param name="id">ID of the connection string to get (Default id is "Default")</param>
        /// <returns>String connection</returns>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        /// <summary>
        /// Gets all history from an account
        /// </summary>
        /// <param name="account">Up to date account</param>
        /// <returns>List of accounts (history)</returns>
        public static List<Account> GetHistory(Account account)
        {
            // Open an SQLite connection
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // Get history from account
                var outputHistory = cnn.Query<History>("SELECT * FROM t_history WHERE fkAccount = " + account.ID, new DynamicParameters());
                History history = outputHistory.ToList()[0];
                
                // Make the select query
                string selectQuery = "SELECT idAccount AS ID, accTitle AS Title, accLogin AS Login, accPassword AS Password, accComment AS Comment, accLast AS Last, accDate AS Date FROM t_account WHERE idAccount in (" + account.ID;
                foreach (int id in history.getIds())
                {
                    selectQuery += ", " + id;
                }
                selectQuery += ")";

                // Execute the query
                var output = cnn.Query<Account>(selectQuery, new DynamicParameters());
                List<Account> result = output.ToList();

                // Decrypt data
                foreach (Account account1 in result)
                {
                    account1.Title = CryptClass.DecryptString(account1.Title);
                    account1.Login = CryptClass.DecryptString(account1.Login);
                    account1.Password = CryptClass.DecryptString(account1.Password);
                    account1.Comment = CryptClass.DecryptString(account1.Comment);
                }
                return result;
            }
        }
    }
}
