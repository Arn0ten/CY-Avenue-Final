﻿using System.Data;
using CarlosYulo.database;
using csCY_Avenue.backend.entities;
using csCY_Avenue.backend.interfaces.client;
using csCY_Avenue.backend.interfaces.generic;
using csCY_Avenue.backend.monolith.common;
using MySql.Data.MySqlClient;

namespace csCY_Avenue.backend.monolith.client;

public class ClientSearch : ISearch<Client, string>, IClientSearch
{
    private readonly DatabaseConnector dbConnector;
    private readonly ImageViewer imageViewer;

    public ClientSearch(DatabaseConnector dbConnector)
    {
        this.dbConnector = dbConnector;
        imageViewer = new ImageViewer();
    }

    // SEARCH MEMBERSHIP BY ID
    public Client? SearchById(int membershipId, string? gender, out string message)
    {
        return SearchClient("prcClientSearchByMembershipId", membershipId, null, gender, "Member", out message);
    }

    // SEARCH MEMBERSHIP BY FULL NAME
    public Client? SearchByFullName(string fullName, string? gender, out string message)
    {
        return SearchClient("prcClientSearchByName", null, fullName, gender, "Member", out message);
    }

    // SEARCH WALK-IN MEMBERSHIP BY ID
    public Client? SearchWalkInByMembershipId(int membershipId, out string message)
    {
        return SearchClient("prcClientSearchByMembershipId", membershipId, null, null, "Walk-in", out message);
    }

    // SEARCH WALK-IN BY FULL NAME
    public Client? SearchWalkInByFullName(string fullName, out string message)
    {
        return SearchClient("prcClientSearchByName", null, fullName, null, "Walk-in", out message);
    }


    public List<Client> SearchAll(string type)
    {
        List<Client> clients = new List<Client>();
        string storedProcedure;

        if (type.Equals("Membership", StringComparison.OrdinalIgnoreCase))
        {
            storedProcedure = "prcClientSearchAllByMembership";
        }
        else if (type.Equals("Walk-in", StringComparison.OrdinalIgnoreCase))
        {
            storedProcedure = "prcClientSearchAllByWalkIn";
        }
        else
        {
            storedProcedure = "prcClientSearchAll";
        }

        try
        {
            using (var connection = dbConnector.CreateConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(storedProcedure, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Client client = new Client()
                            {
                                FullName = reader["full_name"] is DBNull ? null : reader["full_name"].ToString(),
                                MembershipId = reader["membership_id"] is DBNull
                                    ? 0
                                    : Convert.ToInt32(reader["membership_id"]),
                                MembershipTypeId = reader["membership_type_id"] is DBNull
                                    ? 0
                                    : Convert.ToInt32(reader["membership_type_id"]),
                                Email = reader["email"] is DBNull ? null : reader["email"].ToString(),
                                PhoneNumber = reader["phone_number"] is DBNull
                                    ? null
                                    : reader["phone_number"].ToString(),

                                Age = reader["age"] is DBNull ? 0 : Convert.ToInt32(reader["age"]),

                                MembershipStart = reader["membership_start"] is DBNull
                                    ? null
                                    : Convert.ToDateTime(reader["membership_start"]),
                                MembershipEnd = reader["membership_end"] is DBNull
                                    ? null
                                    : Convert.ToDateTime(reader["membership_end"]),
                                MembershipStatus = reader["membership_status"] is DBNull
                                    ? null
                                    : reader["membership_status"].ToString(),
                            };

                            if (type.Equals("Walk-in"))
                            {
                                client.BirthDate = null;
                                client.ProfilePictureByte = null;
                                client.Gender = null;
                            }
                            else
                            {
                                client.BirthDate =
                                    reader["birthday"] is DBNull ? null : Convert.ToDateTime(reader["birthday"]);
                                client.ProfilePictureByte = reader["profile_pic"] is DBNull
                                    ? null
                                    : (byte[])reader["profile_pic"];
                                client.Gender = reader["gender"] is DBNull ? null : reader["gender"].ToString();
                                client.SetProfilePicture(imageViewer.ConvertByteArrayToImage(client.ProfilePictureByte));
                            }

                            client.SetMembership(reader["membership"] is DBNull ? null : reader["membership"].ToString());


                            clients.Add(client);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        return clients;
    }

    private Client? SearchClient(string storedProcedure, int? membershipId, string? fullName, string? gender,
        string type, out string message)
    {
        Client? client = null;

        using (var connection = dbConnector.CreateConnection())
        {
            // Open the connection
            connection.Open();

            using (var command = new MySqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add parameters based on search type
                if (membershipId.HasValue)
                {
                    command.Parameters.AddWithValue("p_membership_id", membershipId.Value);
                }
                else if (!string.IsNullOrEmpty(fullName))
                {
                    command.Parameters.AddWithValue("p_client_full_name", fullName);
                }

                // Gender parameter (common to both procedures)
                command.Parameters.AddWithValue("p_gender",
                    string.IsNullOrEmpty(gender) ? DBNull.Value : gender);

                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            client = new Client();
                            client.FullName = reader["full_name"].ToString();
                            client.MembershipId = Convert.ToInt32(reader["membership_id"]);
                            client.MembershipTypeId = Convert.ToInt32(reader["membership_type_id"]);
                            client.Email = reader["email"].ToString();
                            client.PhoneNumber = reader["phone_number"].ToString();


                            client.MembershipStart = Convert.ToDateTime(reader["membership_start"]);
                            client.MembershipEnd = Convert.ToDateTime(reader["membership_end"]);
                            client.MembershipStatus = reader["membership_status"].ToString();

                            if (type.Equals("Member"))
                            {
                                client.Age = Convert.ToInt32(reader["age"]);
                                client.Gender = reader["gender"].ToString();
                                client.ProfilePictureByte = reader["profile_pic"] is DBNull
                                    ? null
                                    : (byte[])reader["profile_pic"];
                                client.SetProfilePicture(imageViewer.ConvertByteArrayToImage(client.ProfilePictureByte));
                            }

                            client.SetMembership(
                                reader["membership"] is DBNull ? null : reader["membership"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error fetching client: {ex.Message}");
                }
            }
        }

        // RETURN FAIL
        if (client == null)
        {
            // If client is null, show an appropriate message based on what's available
            if (!string.IsNullOrWhiteSpace(fullName))
            {
                message = "Client: " + fullName + " not found";
            }
            else if (membershipId.HasValue)
            {
                message = "Client ID: " + membershipId.Value + " cannot be found";
            }
            else
            {
                message = "Client cannot be found";
            }

            return client;
        }

        // RETURN SUCCESS
        message = "Client successfully fetched";
        return client;
    }
}