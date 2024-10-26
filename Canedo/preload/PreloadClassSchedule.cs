using CarlosYulo.backend.entities.class_session;
using CarlosYulo.backend.monolith.schedule;

namespace CarlosYulo.preload;

public class PreloadClassSchedule
{
    public static List<ClassSession> FixedSchedule { get; set; }
    public static List<ClassSession> PersonalSchedule { get; set; }
    public static List<ClassSession> AllSchedule { get; set; }
    private static ScheduleController _scheduleController = ServiceLocator.GetService<ScheduleController>();

    public static void PreLoadSchedule()
    {
        AllSchedule = new List<ClassSession>();

        _scheduleController = ServiceLocator.GetService<ScheduleController>();
        FixedSchedule = _scheduleController.SearchSchedulesAll(ClassSessionType.FIXED);
        PersonalSchedule = _scheduleController.SearchSchedulesAll(ClassSessionType.PERSONAL);

        // schedule
        Bullshit();
    }

    public static void Bullshit()
    {
        AllSchedule.AddRange(FixedSchedule);
        AllSchedule.AddRange(PersonalSchedule);
    }
}