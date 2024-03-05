namespace Exercise1
{
    class WorkflowEngine
    {
        private readonly IList<IActivity> _activities;
        public WorkflowEngine(IList<IActivity> activities)
        {
            _activities = activities;
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}

