
using HospitalAppointmentManagementSystem.Models;
using HospitalAppointmentManagementSystem.Services;

public class Program

{
    public static void Main(string[] args)
    {


        int option;

        do
        {
            Console.WriteLine($"-----Hospital Appointment Management System-----\n" +
            $"1.Patient Management\n" +
            $"2.Doctors Management\n" +
            $"3.Appointment Management\n" +
            $"4.Save\n" +
            $"5.Save and Exit");

            Console.WriteLine("Enter the option : ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    {
                        patientManagement();
                        break;
                    }
                case 2:
                    {
                        doctorManagement();
                        break;
                    }
                case 3:
                    {
                        appointmentManagement();
                        break;
                    }
            }
        } while (option!=5);


        
    }
    static public void patientManagement()
    {
        PatientsServices patientService = new PatientsServices();

        int option;

        do
        {
            Console.WriteLine("---Patient Management Operations---\n" +
            "1.Register Patient\n" +
            "2.Display patient\n" +
            "3.Display All Patients\n" +
            "4.Search by Patient Name\n" +
            "5.Update Patient by id\n" +
            "6.Delete Patient Records\n" +
            "7.Exit");
            Console.WriteLine("Enter the option : ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Patient Id : ");
                        int.TryParse(Console.ReadLine(), out int patientId);
                        Console.WriteLine("Enter Patient Name : ");
                        string? patientName = Console.ReadLine();
                        Console.WriteLine("Enter Patient Age : ");
                        int.TryParse(Console.ReadLine(), out int patientAge);
                        Console.WriteLine("Enter Patient Phone Number : ");
                        string? patientPhoneNo = Console.ReadLine();

                        patientService.Register(patientId, patientName!, patientAge, patientPhoneNo!);

                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter the Patient Id : ");
                        int patientId;
                        int.TryParse(Console.ReadLine(), out patientId);

                        patientService.GetById(patientId);
                        break;
                    }

                case 3:
                    {
                        patientService.DispalyAllPatients();
                        break;
                    }

                case 4:
                    {
                        Console.WriteLine("Enter Patient Name : ");
                        string? patientName = Console.ReadLine();
                        patientService.SearchByPatientName(patientName!);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter Patient Id : ");
                        int.TryParse(Console.ReadLine(), out int patientId);
                        Console.WriteLine("Enter Patient Name : ");
                        string? patientName = Console.ReadLine();
                        Console.WriteLine("Enter Patient Age : ");
                        int.TryParse(Console.ReadLine(), out int patientAge);
                        Console.WriteLine("Enter Patient Phone Number : ");
                        string? patientPhoneNo = Console.ReadLine();
                        patientService.UpdatePatientDeatils(patientId, patientName!, patientAge, patientPhoneNo!);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("----------------Exit--------------------");
                        break;
                    }
            }

        } while (option!=7);

        }

    static public void doctorManagement()
    {
        DoctorsService doctorsService = new DoctorsService();

        int option;

        do
        {
            Console.WriteLine("-----Doctor Management-----\n" +
            "1.Register Doctor\n" +
            "2.Display\n" +
            "3.Get by Id\n" +
            "4.Search\n" +
            "5.Update\n" +
            "6.Delete\n" +
            "7.Exit");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the Doctor Id : ");
                        int.TryParse(Console.ReadLine(), out int doctorId);
                        Console.WriteLine("Enter the Name : ");
                        string? fullName = Console.ReadLine();
                        Console.WriteLine("Enter the Specialization : ");
                        string? specialization = Console.ReadLine();
                        Console.WriteLine("Enter the ConsultationFee : ");
                        decimal.TryParse(Console.ReadLine(), out decimal consultationFee);
                        doctorsService.Register(doctorId, fullName!, specialization!, consultationFee);
                        break;
                    }

                case 2:
                    {
                        doctorsService.DisplayAllDoctors();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Enter the Doctor Id : ");
                        int.TryParse(Console.ReadLine(), out int doctorId);
                        doctorsService.GetById(doctorId);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter the Name : ");
                        string? fullName = Console.ReadLine();
                        doctorsService.SearchByName(fullName);
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Enter the Doctor Id : ");
                        int.TryParse(Console.ReadLine(), out int doctorId);
                        Console.WriteLine("Enter the Name : ");
                        string? fullName = Console.ReadLine();
                        Console.WriteLine("Enter the Specialization : ");
                        string? specialization = Console.ReadLine();
                        Console.WriteLine("Enter the ConsultationFee : ");
                        decimal.TryParse(Console.ReadLine(), out decimal consultationFee);
                        doctorsService.UpdateDoctorDetails(doctorId, fullName!, specialization!, consultationFee);
                        break;
                    }

                case 7:
                    {
                        Console.WriteLine("------------------------------Exit-----------------------------");
                        break;
                    }
            }
        } while (option != 7);
    }

    static public void appointmentManagement()
    {
        int option;

        do
        {
            Console.WriteLine("--------Appointment Management---------\n" +
                "1.Book Appointment\n" +
                "2.ViewAllAppoint");

            int.TryParse(Console.ReadLine(),out option);
        } while (option !=7);
    }
}
