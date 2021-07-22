using System;

namespace EVENTSPROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Video { Name = "MyVideo1" };
            var videoEncoderObj = new VideoEncoder();

            videoEncoderObj.myEvent += EmailService.SendEmail;
            videoEncoderObj.Process(obj);
            Console.ReadLine();
        }
    }
    class Video
    {
        public string Name { get; set; }
    }
    class VideoEncoder
    {
        public delegate void PostProcessEventHandler(object source, EventArgs args);
        public event PostProcessEventHandler myEvent;
        public virtual void OnPostProcessingEvent()
        {
            if (myEvent != null)
                myEvent(this, EventArgs.Empty);
        }
        public void Process(Video video)
        {
            Console.WriteLine($"Your video is processing {video.Name}");
            OnPostProcessingEvent();
        }
    }
    class EmailService
    {
        static public void SendEmail(object source, EventArgs args)
        {
            Console.WriteLine($"Sending email.....");
        }
    }
}
