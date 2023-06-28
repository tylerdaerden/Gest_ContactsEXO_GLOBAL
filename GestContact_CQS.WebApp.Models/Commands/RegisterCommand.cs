using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GestContact_CQS.WebApp.Models.Commands
{
    public class RegisterCommand : ICommand
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public string Passwd { get; init; }
        public RegisterCommand(string nom, string prenom, string email, string passwd)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Passwd = passwd;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
