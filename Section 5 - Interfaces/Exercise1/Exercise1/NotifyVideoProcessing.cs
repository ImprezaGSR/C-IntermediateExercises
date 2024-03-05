namespace Exercise1
{
    class NotifyVideoProcessing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to the owner of the processing video...");
        }
    }
}

