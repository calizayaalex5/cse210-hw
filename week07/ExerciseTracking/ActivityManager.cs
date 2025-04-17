public class ActivityManager
{
    private List<Activity> activities = new List<Activity>();

    public void Start()
    {
        // Create sample activities and add to the list
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 20));

        // Print the summary for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}