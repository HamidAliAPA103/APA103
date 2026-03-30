using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using _08_StatiClassExtensionMethodsExceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _08_StatiClassExtensionMethodsExceptions.Servis
{
    internal class LoginSystem
    {
        private User[] users;
        public const int MaxAttempts = 3;
        public LoginSystem()
        {
            users = new User[3];
            users[0] = new User("admin", "admin123");
            users[1] = new User("student", "student123");
            users[2] = new User("teacher", "teacher123");
        }

        public void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new InvalidUsernameException("Username bos ola bilmez");
            }
            if (username.Length < 3)
            {
                throw new InvalidUsernameException("Username 3 sinvoldan az olmamalidi");
            }
        }
        public void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidUsernameException("Password bos ola bilmez");
            }
            if (password.Length < 6)
            {
                throw new InvalidUsernameException("Username 6 sinvoldan az olmamalidi");
            }


        }

        private User FindUser(string username)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] != null &&
            users[i].Username != null &&
            username != null &&
            users[i].Username.ToLower() == username.ToLower())
                {
                    return users[i];
                }
            }
            return null;
        }

        public bool Login(string username, string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);
            User user = FindUser(username);

            if (user == null)
            {
                throw new InvalidUsernameException();
            }

            if (user.IsLocked)
            {
                throw new AccountLockedException();
            }

            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successful! Welcome, {username}!");
            }
            else
            {
                user.FailedAttempts++;
                int Attemptsleft = MaxAttempts - user.FailedAttempts;
                if (Attemptsleft < 3)
                {
                    throw new IncorrectPasswordException(Attemptsleft);
                }
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException();
                }
            }
            return true;
        }
        public void AllUsers()
        {
            Console.WriteLine("Movcud istifadeciler:");
            foreach (var user in users)
            {
                Console.WriteLine(user.Username);
            }
        }

    }
}
