/*using System;
using Microsoft.AspNetCore.Mvc;
using HappyFarmer.Models;
using System.Configuration;
using System.Security.Cryptography;
using Microsoft.AspNet.Cryptography.KeyDerivation;
using Npgsql;

namespace HappyFarmer.Controllers
{
   
    public class AccountController : Controller
    {
        private const string SchemaName = "happyschema";
        private const string UserTableName = "user";
        
#region REGISTER
        
        public IActionResult Register()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                string Username = model.Username;
                string Email = model.Email;
                string Password = model.Password;
                
                /* Hash password #1#
                Password = Hash(Password);

                /* Get database connection string #1#
                string connStr = GetConnectionString();
                
                /* Formulate SQL command #1#
                string query = "INSERT INTO " + SchemaName
                                              + "."
                                              + UserTableName
                                              + " (username, email, password)"
                                              + " VALUES "
                                              + "(@Username, "
                                              + "@Email, "
                                              + "@Password)";
                
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = query;
                    
                    cmd.Parameters.AddWithValue("Username", Username);
                    cmd.Parameters.AddWithValue("Email", Email);
                    cmd.Parameters.AddWithValue("Password", Password);
                    
                    InsertDataToDatabase(connStr, cmd);
                }
                
                // Clean up
                ModelState.Clear();
                ViewBag.Message = "Register Succeed!";
            }

            return PartialView();
        }
        
#endregion
        
#region LOGIN
        
        public ActionResult Login()
        {
            return PartialView();
        }  
        
#endregion
        
#region HELPER FUNCTION
        
        /*
         * Get connection string for database connection
         #1#
        public string GetConnectionString()
        {
            ConnectionStringSettings defaultConn = ConfigurationManager.
                ConnectionStrings["DefaultConnection"];
            
            if (defaultConn == null || string.IsNullOrEmpty(defaultConn.ConnectionString))
            {
                throw new Exception("Fatal error: missing connecting string in web.config file");
            }
            
            return defaultConn.ConnectionString;
        }
        
        /*
         * Execute insertion to database
         #1#
        public void InsertDataToDatabase(string connStr, NpgsqlCommand cmd)
        {
            using (var conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }

        /*
         * Basic hashing functionality
         * Reference: https://docs.microsoft.com/en-us/aspnet/core/security/data-protection/
         * consumer-apis/password-hashing?view=aspnetcore-2.1
         #1#
        public string Hash(String sequence)
        {
            // Generate a 128-bit salt using a secure PRNG
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
 
            // Derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: sequence,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
        
#endregion
    }
}*/