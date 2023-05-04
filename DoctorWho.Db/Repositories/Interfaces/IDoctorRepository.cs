namespace DoctorWho.Db
{
    public interface IDoctorRepository
    {
        Task<Doctor> CreateDoctorAsync(Doctor doctor);
        Task<List<Doctor>> GetAvailableDoctors();
        Task RemoveDoctorAsync(Doctor doctorToRemove);
        Task<Doctor> UpdateDoctor(Doctor updatedDoctor);
    }
}