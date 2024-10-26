using CarlosYulo.backend;
using CarlosYulo.backend.monolith.client;
using csCY_Avenue.Canedo.backend.entities;

namespace csCY_Avenue.Canedo.controller.c_service;

public class ClientAttendanceServices
{
    private readonly ClientAttendanceCreate _attendanceCreate;
    private readonly ClientAttendanceSearchAll _attendanceSearchAll;
    private readonly ClientAttendanceSearchByDay _attendanceSearchByDay;

    public ClientAttendanceServices(
        ClientAttendanceCreate attendanceCreate,
        ClientAttendanceSearchAll attendanceSearchAll,
        ClientAttendanceSearchByDay attendanceSearchByDay
    )
    {
        _attendanceCreate = attendanceCreate;
        _attendanceSearchAll = attendanceSearchAll;
        _attendanceSearchByDay = attendanceSearchByDay;
    }

    // create
    public bool CreateAttendance(ClientAttendance clientAttendance)
    {
        string message;
        if (!_attendanceCreate.CreateAttendance(clientAttendance, out message))
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    // search
    public List<ClientAttendance> SearchClientAttendanceByDay(DateTime attendanceDate)
    {
        string message;
        var attendance = _attendanceSearchByDay.SearchClientAttendanceByDay(attendanceDate, out message);
        if (attendance is null)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<ClientAttendance>();
        }

        return attendance;
    }

    public List<ClientAttendance> SearchClientAttendanceAll()
    {
        return _attendanceSearchAll.SearchClientAttendanceAll();
    }
}