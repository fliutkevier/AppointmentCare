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

        public List<Appointment> GetByIdDoctor(int idDoctor)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                _context.ClearParameters();
                _context.SetQuery("SELECT Id, PatientId, Schedule FROM Appointments WHERE DoctorId = @Doctor");
                _context.SetParameter("Doctor", idDoctor);
                _context.ExecRead();

                while(_context.Reader.Read())
                {
                    Appointment appointment = new Appointment();
                    appointment.Id = (int)_context.Reader["Id"];
                    appointment.DoctorId = idDoctor;
                    appointment.PatientId = (int)_context.Reader["PatientId"];
                    appointment.Schedule = (DateTime)_context.Reader["Schedule"];

                    appointments.Add(appointment);
                }

                return appointments;
            }
            catch (Exception)
            {

                throw;
            }
            finally { _context.Close(); }
        }

        public bool Add(Appointment appointment)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("INSERT INTO Appointments VALUES (@DoctorId, @PatientId, @Schedule)");
                _context.SetParameter("@DoctorId", appointment.DoctorId);
                _context.SetParameter("@PatientId", appointment.PatientId);
                _context.SetParameter("@Schedule", appointment.Schedule);

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

        public bool Modify(Appointment appointment)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("UPDATE Appointments SET DoctorId = @DoctorId, PatientId = @PatientId, Schedule = @Schedule WHERE Id = @Id");
                _context.SetParameter("@DoctorId", appointment.DoctorId);
                _context.SetParameter("@PatientId", appointment.PatientId);
                _context.SetParameter("@Schedule", appointment.Schedule);
                _context.SetParameter("@Id", appointment.Id);
                
                if(_context.ExecAction())
                {
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

        public int GetId(int idDoctor, int idPatient, DateTime schedule)
        {
            int id = -1;
            try
            {
                _context.ClearParameters();
                _context.SetQuery("SELECT Id FROM Appointments WHERE DoctorId = @IdDoctor AND PatientId = @IdPatient AND Schedule = @sche");
                _context.SetParameter("@IdDoctor", idDoctor);
                _context.SetParameter("@IdPatient", idPatient);
                _context.SetParameter("@sche", schedule);
                _context.ExecRead();

                if (_context.Reader.Read())
                {
                    id = (int)_context.Reader["Id"];
                }

                return id;
            }
            catch (Exception)
            {
                throw;
            }
            finally { _context.Close(); }
        }

        public bool Cancel(int idPatient)
        {
            try
            {
                _context.ClearParameters();
                _context.SetQuery("UPDATE Appointments SET PatientId = 0 WHERE PatientId = @IdPat");
                _context.SetParameter("@IdPat", idPatient);

                if (_context.ExecAction())
                {
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
