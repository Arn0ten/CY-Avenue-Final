using csCY_Avenue.backend.entities;

namespace csCY_Avenue.backend.interfaces.client;

public class IClient { }

public interface IClientCreate
{
    bool CreateWalkIn(Client client, out string message);
}

public interface IClientSearch
{
    Client? SearchWalkInByFullName(string fullName, out string message);
    Client? SearchWalkInByMembershipId(int membershipId, out string message);
}


public interface IClientUpdate
{
    bool UpdateClientMembershipType(Client client, MembershipType membership, out string message);
}

public interface IClientGenerate
{
    int GenerateClientMembershipId(Client client);
}

public interface IClientEmail
{
    void SendMembershipExpiryEmail(Client client);
}