using HospitalAppointmentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalAppointmentManagementSystem.Services
{
    internal class PatientsServices
    {
        public List<Patients> patients=new List<Patients>();
        
        public PatientsServices() { }

        AppointmentService appointment = new AppointmentService(patients);

        public void Register(int patientId, string patientName, int patientAge, string patientPhoneNo)
        {
            Patients patient = new Patients(patientId, patientName, patientAge, patientPhoneNo);
           
            if (patients.Any(p => p.PatientId == patientId))
            {
                Console.WriteLine("Patient Already Exist!!");
                return;
            }

            patients.Add(patient);
            Console.WriteLine("Patient is Added Successfully......");
           
        }

        public void GetById(int patientId)
        {
            var patient = patients.Any(p => p.PatientId == patientId);
            if (!patient)
            {
                Console.WriteLine("Patients is Not Found!!");
                return;
            }

            foreach (var i in patients) 
            {
                if (i.PatientId == patientId)
                {
                    Console.WriteLine($"Patient Id : {i.PatientId}\n" +
                        $"Patient Name : {i.PatientName}\n" +
                        $"Patient Age : {i.PatientAge}\n" +
                        $"Patient Phone Number : {i.PatientPhoneNo}");
                }
            }
        }

        public void DispalyAllPatients()
        {
            Console.WriteLine("---------------------Patients List--------------------------");
            foreach (var i in patients)
            {
                Console.WriteLine($"Patient Id : {i.PatientId}\n" +
                        $"Patient Name : {i.PatientName}\n" +
                        $"Patient Age : {i.PatientAge}\n" +
                        $"Patient Phone Number : {i.PatientPhoneNo}");
            }
        }

        public void SearchByPatientName(string patientName)
        {
            var patient = patients.Where(p => p.PatientName.ToLower().Contains(patientName.ToLower())).Select(p => p);

            foreach (var i in patient)
            {
                Console.WriteLine($"Patient Id : {i.PatientId}\n" +
                         $"Patient Name : {i.PatientName}\n" +
                         $"Patient Age : {i.PatientAge}\n" +
                         $"Patient Phone Number : {i.PatientPhoneNo}");
            }

        }

        public void UpdatePatientDeatils(int patientId, string patientName, int patientAge, string patientPhoneNo)
        {

            if (!patients.Any(p => p.PatientId == patientId))
            {
                Console.WriteLine("Patient Record Not Found!!");
                return;
            }

            foreach (Patients i in patients)
            {
                if(i.PatientId == patientId)
                {
                    i.PatientName = patientName;
                    i.PatientAge= patientAge;
                    i.PatientPhoneNo = patientPhoneNo;
                    break;
                }
            }

            Console.WriteLine("Updated Successfully!!");

        }

    }
}
