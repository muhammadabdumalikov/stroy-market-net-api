﻿namespace MohirdevNet.Helpers
{
    public class PasswordGenerator
    {
        public string Create(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
         
        public bool Verify(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
