using CarlosYulo.backend.entities.class_session;

namespace CarlosYulo.backend.monolith.schedule;

public class ScheduleController
{
    private readonly ScheduleCreateServices _create;
    private readonly ScheduleSearchServices _search;
    private readonly ScheduleDeleteServices _delete;

    public ScheduleController(
        ScheduleCreateServices create,
        ScheduleSearchServices search,
        ScheduleDeleteServices delete)
    {
        _create = create;
        _search = search;
        _delete = delete;
    }

    // CREATE
    public bool CreateClassFixedSession(ClassSession? classSession)
    {
        return _create.CreateClassFixedSession(classSession);
    }

    public bool CreatePersonalClassSession(ClassSession? classSession)
    {
        return _create.CreatePersonalClassSession(classSession);
    }

    public List<ClassSessionMembers>? CreateSchedulePersonalClassMembers(int? sessionId)
    {
        return _create.CreateSchedulePersonalClassMembers(sessionId);
    }

    public bool CreateStudent(TrainerStudent? trainerStudent)
    {
        return _create.CreateStudent(trainerStudent);
    }


    // SEARCH
    public List<ClassSession>? SearchSchedulesAll(ClassSessionType type)
    {
        return _search.SearchSchedulesAll(type);
    }

    public List<TrainerStudent> SearchTrainerStudents(int trainerId)
    {
        return _search.SearchTrainerStudents(trainerId);
    }

    public List<ClassSession>? SearchSchedulesFixedAllById(int trainerId)
    {
        return _search.SearchSchedulesFixedAllById(trainerId);
    }
    

    // DELETE
    public bool DeleteAllByDay(ClassSessionType type, DateTime date)
    {
        return _delete.DeleteAllByDay(type, date);
    }

    public bool DeleteAllPrevious(ClassSessionType type)
    {
        return _delete.DeleteAllPrevious(type);
    }

    
    public List<ClassSession>? SearchSchedulesAllByTrainerId(int trainerId)
    {
        return _search.SearchSchedulesAllByTrainerId(trainerId);
    }
    
    // FIXED
    public List<ClassSession>? SearchFixedSchedulesAllByTrainerId(int trainerId)
    {
        return _search.SearchSchedulesAllByTrainerId(trainerId);
    }
}