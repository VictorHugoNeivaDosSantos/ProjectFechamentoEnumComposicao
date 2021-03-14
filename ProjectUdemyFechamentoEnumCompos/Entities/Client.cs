using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUdemyFechamentoEnumCompos.Entities
{
    class Client
    {

        public string Name { get; set; }
        public string EmailCli { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string emailCli, DateTime birthDate)
        {
            Name = name;
            EmailCli = emailCli;
            BirthDate = birthDate;
        }

        public Client()
        {
        }
    }
}
