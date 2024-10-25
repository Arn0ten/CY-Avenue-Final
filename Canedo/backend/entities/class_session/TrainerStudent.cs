namespace CarlosYulo.backend.entities.class_session;

public class TrainerStudent
{
    // trainer
    public int? TrainerId { get; set; }
    public string? TrainerName { get; set; }

    // student
    public int? StudentId { get; set; }
    public string? StudentName { get; set; }

    // 
    public DateTime? StartDate { get; set; }
    public string? Status { get; set; }


    // Override ToString method
    public override string ToString()
    {
        return $"Trainer: {TrainerName} (ID: {TrainerId}), " +
               $"Student: {StudentName} (ID: {StudentId}), " +
               $"Start Date: {StartDate?.ToString("yyyy-MM-dd")}, " +
               $"Status: {Status}";
    }
}