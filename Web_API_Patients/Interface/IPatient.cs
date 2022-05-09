using Web_API_Patients.Data.Entities;

namespace Web_API_Patients.Interface
{
    public interface IPatient
    {
        List<Patients> patients { get; set; }
        object Patients { get; }

        List<Patients> GetPatients();
        Patients GetPatient();
    }
}
