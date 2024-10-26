namespace csCY_Avenue.Canedo.backend.entities;

public class ClientAttendance
{
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public DateTime Date { get; set; }
    public DateTime CheckInTime { get; set; }
    public string Status { get; set; }

    public override string ToString()
    {
        return
            $"Client ID: {ClientId}," +
            $"Client Name: {ClientName}," +
            $",Date: {Date:MMMM dd, yyyy}, Check-In Time: {CheckInTime:h:mm tt}, Status: {Status}";
    }
}