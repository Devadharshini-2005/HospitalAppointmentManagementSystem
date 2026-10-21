using System;
using System.Collections.Generic;
using System.Text;
using HospitalAppointmentManagementSystem.Models;

namespace HospitalAppointmentManagementSystem.Services
{
    internal class AppointmentService
    {
        Appointment appointment = new Appointment();

        public List<Patients>? patients = new List<Patients>();
        public List<Doctors>? doctors = new List<Doctors>();

        public AppointmentService(List<Patients> patients)
        {
            this.patients = patients;
        }
    }
}
