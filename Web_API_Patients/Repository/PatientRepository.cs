using Web_API_Patients.Data;
using Web_API_Patients.Data.Entities;
using Web_API_Patients.Interface;

namespace Web_API_Patients.Repository
{
    public class PatientRepository : IPatient
    {
        private readonly MyDatabaseDbContext _context;

        public PatientRepository(MyDatabaseDbContext context)
        {
            _context = context;
        }

        public List<Patients> patients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Patients => throw new NotImplementedException();

        public List<Patients> GetPatients()
        {
            List<Patients> objCatlist = _context.Patients.ToList();
            return objCatlist;
        }
        public List<Patients> GetPatient()
        {
            List<Patients> patients = _context.Patients.ToList();
            return patients;
        }

        Patients IPatient.GetPatient()
        {
            throw new NotImplementedException();
        }
    }
}
