using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args) 
        {
            var videoUploadWorkflow = new WorkflowEngine(new List<IActivity> {new VideoUploader(), new RequestEncode(), new NotifyVideoProcessing(), new SetVideoStatus()});
            videoUploadWorkflow.Run();
        }
    }
}

