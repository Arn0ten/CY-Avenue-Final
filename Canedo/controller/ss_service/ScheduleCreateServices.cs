using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.schedule.ss_trainer;
using CarlosYulo.backend.monolith.session.ss_create;

namespace CarlosYulo.backend.monolith.schedule;

public class ScheduleCreateServices
{
    private readonly ScheduleCreateFixed _fixed;
    private readonly ScheduleCreatePersonalClassMembers _classMembers;
    private readonly ScheduleCreatePersonal _personal;
    private readonly ScheduleCreateTrainerStudent _trainerStudent;
    private readonly ErrorMessageBox _messageBox;

    public ScheduleCreateServices(
        ScheduleCreateFixed scheduleCreateFixed,
        ScheduleCreatePersonalClassMembers classMembers,
        ScheduleCreatePersonal personal,
        ScheduleCreateTrainerStudent trainerStudent)
    {
        _fixed = scheduleCreateFixed;
        _classMembers = classMembers;
        _personal = personal;
        _trainerStudent = trainerStudent;
        _messageBox = new ErrorMessageBox();
    }

    public bool CreateClassFixedSession(ClassSession? classSession)
    {
        string message;
        if (!_fixed.CreateClassFixedSession(classSession, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }

        return true;
    }

    public List<ClassSessionMembers>? CreateSchedulePersonalClassMembers(int? sessionId)
    {
        string message;
        var classStudent = _classMembers.CreateSchedulePersonalClassMembers(sessionId, out message);

        if (classStudent is null)
        {
            _messageBox.ShowErrorMessage(message);
            return null;
        }

        return classStudent;
    }

    public bool CreatePersonalClassSession(ClassSession? classSession)
    {
        string message;
        if (!_personal.CreatePersonalClassSession(classSession, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }

        return true;
    }

    public bool CreateStudent(TrainerStudent? trainerStudent)
    {
        string message;
        if (!_trainerStudent.CreateStudent(trainerStudent, out message))
        {
            _messageBox.ShowErrorMessage(message);
            return false;
        }

        return true;
    }
}