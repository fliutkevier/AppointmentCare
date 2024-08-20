using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;

namespace Business
{
    public class PersonService : mainService
    {
        private List<Person> _list;
        public PersonService() : base() { }

        public List<Person> getAllPersons()
        {
            List<Person> people = new List<Person>();
            try
            {
                _context.SetQuery("SELECT Id, Name, Lastname, DNI, Address, Phone, Birthday FROM Persons");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    Person per = new Person();
                    per.IdPerson = (int)_context.Reader["Id"];
                    per.Name = (string)_context.Reader["Name"];
                    per.Lastname = (string)_context.Reader["Lastname"];
                    per.Dni = (string)_context.Reader["DNI"];
                    per.Address = (string)_context.Reader["Address"];
                    per.Phone = (string)_context.Reader["Phone"];
                    DateTime dtHelp = (DateTime)_context.Reader["Birthday"];
                    per.BirthDay = DateOnly.FromDateTime(dtHelp);

                    people.Add(per);
                }

                return people;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _context.Close();
            }
        }

        public int GetIdByDni(string dni)
        {
            _list = getAllPersons();
            return _list.First(person => person.Dni == dni).IdPerson;
        }

        public Person GetById(int id)
        {
            _list = getAllPersons();
            return _list.First(person => person.IdPerson == id);
        }
    }
}
