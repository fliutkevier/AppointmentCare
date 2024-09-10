using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Business
{
    public class PersonBusiness : mainBusiness
    {
        private List<Person> _list;
        public PersonBusiness() : base() { }

        public List<Person> getAllPersons()
        {
            List<Person> people = new List<Person>();
            try
            {
                _context.SetQuery("SELECT Id, Name, Lastname, DNI, Address, Phone, Birthday, IsActive FROM Persons");
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
                    per.IsActive = (bool)_context.Reader["IsActive"];
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

        public bool SoftDelete(int id)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("UPDATE Persons SET IsActive = 0 WHERE Id = @Id");
                _context.SetParameter("@Id", id);

                if (_context.ExecAction())
                {
                    _context.Close();
                    return true;
                }

                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _context.Close(); }
        }
    }
}
