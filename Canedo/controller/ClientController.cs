using CarlosYulo.backend.monolith.client.c_create;
using CarlosYulo.backend.monolith.create;
using CarlosYulo.backend.monolith.delete;
using csCY_Avenue.Canedo.backend.entities;
using csCY_Avenue.Canedo.controller.c_service;

namespace CarlosYulo.backend.monolith.client;

public class ClientController
{
    private readonly ClientCreateServices _create;
    private readonly ClientUpdateServices _update;
    private readonly ClientSearchServices _search;
    private readonly ClientDeleteServices _delete;
    private readonly ClientEmailService _email;
    private readonly ClientAttendanceServices _attendance;

    public ClientController(
        ClientCreateServices clientCreate,
        ClientUpdateServices clientUpdate,
        ClientSearchServices clientSearch,
        ClientDeleteServices clientDelete,
        ClientEmailService clientEmail,
        ClientAttendanceServices clientAttendance)
    {
        _create = clientCreate;
        _update = clientUpdate;
        _search = clientSearch;
        _delete = clientDelete;
        _email = clientEmail;
        _attendance = clientAttendance;
    }

    // CREATE CLASSES
    public bool CreateNewMember(Client client)
    {
        return _create.CreateNewMember(client);
    }

    public bool CreateNewWalkIn(Client client)
    {
        return _create.CreateNewWalkIn(client);
    }


    // UPDATE 
    public bool UpdateDetails(Client client)
    {
        return _update.UpdateDetails(client);
    }

    public bool UpdateMembershipType(Client client, MembershipType membershipType)
    {
        return _update.UpdateMembershipType(client, membershipType);
    }

    public bool UpdateProfilePicture(Client client, string imagePath)
    {
        return _update.UpdateProfilePicture(client, imagePath);
    }

    public void UpdateExpireMembersToExpired()
    {
        _update.UpdateAllMembershipsToExpired();
    }


    // SEARCH
    public Client? SearchById(int id)
    {
        return _search.SearchById(id);
    }

    public List<Client>? SearchByFullName(string fullName)
    {
        return _search.SearchByFullName(fullName);
    }
    
    public List<Client> SearchAll(string type)
    {
        return _search.SearchAll(type);
    }
    
    
    // DELETE
    public bool DeleteClient(Client? client)
    {
        return _delete.DeleteClient(client);
    }

    public void DeleteAllExpired(ClientDeleteType type)
    {
        _delete.DeleteAllExpired(type);
    }
    
    
    // EMAIL
    public void SendEmail(Client client, EmailType type)
    {
        _email.SendEmail(client, type);
    }
    
    
    // ATTENDANCE
    public bool CreateAttendance(ClientAttendance clientAttendance)
    {
        return _attendance.CreateAttendance(clientAttendance);
    }

    public List<ClientAttendance> SearchClientAttendanceByDay( DateTime attendanceDate)
    {
        return _attendance.SearchClientAttendanceByDay(attendanceDate);
    }

    public List<ClientAttendance> SearchClientAttendanceAll()
    {
        return _attendance.SearchClientAttendanceAll();
    }
}