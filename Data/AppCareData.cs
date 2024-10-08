﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Data
{
    public class AppCareData
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader = null!;
        public SqlDataReader Reader
        {
            get { return _reader; }
        }
        public AppCareData()
        {
            _connection = new SqlConnection("Server=.\\SQLEXPRESS; Database=AppointmentCare_DB; integrated security=true; TrustServerCertificate=True");
            _command = new SqlCommand();
            _command.CommandType = System.Data.CommandType.Text;
        }

        ~AppCareData()
        {
            if (_reader != null) { _reader.Close(); }
            _connection.Close();
        }

        public void Open()
        {
            _connection.Open();
        }
        
        public void SetQuery(string query)
        {
            _command.CommandText = query;
        }

        public void ExecRead()
        {
            
            _command.Connection = _connection;
            try
            {
                Open();
                _reader = _command.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool ExecAction()
        {
            _command.Connection = _connection;
            try
            {
                Open();
                if(_command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetParameter(string parameter, object value)
        {
            _command.Parameters.AddWithValue(parameter, value);
        }

        public void ClearParameters()
        {
            _command.Parameters.Clear();
        }

        public void Close()
        {
            _connection.Close();
        }
        
    }
}
