using System;
using System.Text;

namespace Aula_122_Exercicio_Enumeracao_e_composicao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Client() { }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Client: " + Name + " (" + BirthDate.ToString("dd/MM/yyyy")+") - "+Email );
            return sb.ToString();
        }
    }
}
