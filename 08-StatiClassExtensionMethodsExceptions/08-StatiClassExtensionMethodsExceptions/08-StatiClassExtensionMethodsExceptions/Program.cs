using _08_StatiClassExtensionMethodsExceptions.Exceptions;
using _08_StatiClassExtensionMethodsExceptions.Servis;

namespace _08_StatiClassExtensionMethodsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LoginSystem loginSystem = new LoginSystem();
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Username daxil edin : ");
                    string username = Console.ReadLine();

                    Console.WriteLine("Password daxil edin :");
                    string password = Console.ReadLine();

                 bool Success=loginSystem.Login(username ,password );
                    if (Success) ;
                    break;


                }
                catch (InvalidUsernameException ex)
                {

                    Console.WriteLine("ERROR: " + ex.Message );
                }
                catch(InvalidPasswordException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message );
                }
                catch(UserNotFoundException ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message );
                    loginSystem.AllUsers();
                }
                catch(IncorrectPasswordException ex)
                {
                    Console.WriteLine("WARNING: " + ex.Message );
                }
                catch(AccountLockedException ex)
                {
                    Console.WriteLine("CRITICAL: " + ex.Message + "contact admin" );
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("UNEXPECTED ERROR: " + ex.Message );
                }

            }
        }
    }
}
