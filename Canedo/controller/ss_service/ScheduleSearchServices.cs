using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.common;
using CarlosYulo.backend.monolith.schedule.ss_search;
using CarlosYulo.backend.monolith.schedule.ss_trainer;

namespace CarlosYulo.backend.monolith.schedule;

public class ScheduleSearchServices
{
    private readonly ScheduleSearchAll _searchAll;
    private readonly ScheduleSearchTrainerStudent _searchTrainerStudents;
    private readonly ScheduleSearchAllByTrainerId _searchAllByTrainerById;
    private readonly ErrorMessageBox _messageBox;


    public ScheduleSearchServices(ScheduleSearchAll searchAll, ScheduleSearchTrainerStudent searchTrainerStudents, ScheduleSearchAllByTrainerId searchAllByTrainerById)
    {
        _searchAll = searchAll;
        _searchTrainerStudents = searchTrainerStudents;
        _searchAllByTrainerById = searchAllByTrainerById;
        _messageBox = new ErrorMessageBox();
    }

    public List<ClassSession>? SearchSchedulesAll(ClassSessionType type)
    {
        string message;
        var classSessions = _searchAll.SearchSchedulesAll(type, out message);
        if (classSessions is null)
        {
            _messageBox.ShowErrorMessage(message);
            return classSessions;
        }

        return classSessions;
    }

    public List<TrainerStudent> SearchTrainerStudents(int trainerId)
    {
        string message;

        var trainerStudents = _searchTrainerStudents.GetTrainerStudents(trainerId, out message);
        if (trainerStudents is null)
        {
            _messageBox.ShowErrorMessage(message);
            return new List<TrainerStudent>();
        }

        return trainerStudents;
    }

    public List<ClassSession>? SearchSchedulesAllByTrainerId(int trainerId)
    {
        string message;

        var trainerStudents = _searchAllByTrainerById.SearchSchedulesAllById(trainerId, out message);
        if (trainerStudents is null)
        {
            _messageBox.ShowErrorMessage(message);
            return new List<ClassSession>();
        }

        return trainerStudents;
    }
}