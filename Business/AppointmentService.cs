using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AppointmentService : mainService
    {
        public AppointmentService() : base() { }

        public List<Appointment> GetAll()
        {
            List<Appointment> appointmentsList = new List<Appointment>();

            try
            {
                _context.SetQuery("SELECT Id, DoctorId, PatientId, Schedule FROM Appointments");
                _context.ExecRead();

                while (_context.Reader.Read())
                {
                    Appointment appointment = new Appointment();
                    appointment.Id = (int)_context.Reader["Id"];
                    appointment.DoctorId = (int)_context.Reader["DoctorId"];
                    appointment.PatientId = (int)_context.Reader["PatientId"];
                    appointment.Schedule = (DateTime)_context.Reader["Schedule"];

                    appointmentsList.Add(appointment);
                }

                return appointmentsList;
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

        public bool Add(Appointment appointment)
        {
            try
            {
                _context.SetQuery("INSERT INTO Appointments VALUES (@DoctorId, @PatientId, @Schedule)");
                _context.SetParammeter("@DoctorId", appointment.DoctorId);
                _context.SetParammeter("@PatientId", appointment.PatientId);
                _context.SetParammeter("@Schedule", appointment.Schedule);

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
            finally
            {
                _context.Close();
            }
        }
    }
}
