using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Patient_Tracker_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Linq.Expressions;

namespace Patient_Tracker_DAL.Repositories
{
    public class LoginRepository : ILogin
    {
        public IConfiguration _config;
        private readonly string connectionString;
        public LoginRepository(IConfiguration config)
        {
            _config = config;
            connectionString = _config.GetConnectionString("DefaultConnection");
        }

        public string GetUserRole(string user_id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("GetUserRole", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@user_id", user_id);
                        string role = (string)command.ExecuteScalar();
                        return role;
                    }
                }
            }
            catch (Exception)
            {
                // Handle the exception here (e.g., logging, displaying an error message)
                // You can throw the exception further if needed
                throw;
            }
        }

        public bool VerifyUser(string user_id, string user_psw)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();



                    using (SqlCommand command = new SqlCommand("VerifyUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@user_id", user_id);
                        command.Parameters.AddWithValue("@user_psw", user_psw);



                        int count = (int)command.ExecuteScalar();



                        return count > 0;
                    }
                }
            }
            catch (Exception)
            {
             // You can throw the exception further if needed or return false to indicate failure
                throw;
            }
        }


        public string GenerateJwtToken(string userId, string role)
        {
            try
            {

                var claims = new List<Claim>


           { new Claim(ClaimTypes.NameIdentifier, userId),
             new Claim(ClaimTypes.Role, role)
            };
                var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: credentials
                );
                return new JwtSecurityTokenHandler().WriteToken(token);


            }
            catch (Exception)
            {
                throw;
            }



        }
    }


    }

    

