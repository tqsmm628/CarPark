using System;
using System.Threading;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace CarPark.ETL {
    class Program {
        static void Main(string[] args) {
            var job = new Models.JobData.JobSettings.OperatorJob();
            var source = new CarPark.ETL.Jobs.Operator.Source();
            var transform = new CarPark.ETL.Jobs.Operator.Transform();
            var sourceTask = source.Run(job);
            var transformTask = transform.Run(sourceTask.Result);
            var transformResult = transformTask.Result;


            var xx = 1;

            // ISchedulerFactory sf = new StdSchedulerFactory();
            // IScheduler sched = sf.GetScheduler().Result;
            // IJobDetail job = JobBuilder.Create<HelloJob>()
            //     .WithIdentity("job1", "group1")
            //     .Build();
            // ITrigger trigger = TriggerBuilder.Create()
            //     .WithCronSchedule("0 0/1 * * * ?")
            //     .WithIdentity("trigger1", "group1")
            //     .StartNow()
            //     .Build();
            // sched.ScheduleJob(job, trigger);
            // sched.Start();

            // Thread.Sleep(TimeSpan.FromHours(1));
        }
    }

    class HelloJob : IJob {
        public Task Execute(IJobExecutionContext context) {
            Console.WriteLine($"{DateTime.Now:HH:mm:ss}: Hello~");
            return Task.CompletedTask;
        }
    }
}