//using Java.Util;
//using Java.Util.Concurrent;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestXFApp
{
   // Declare a delegate type for processing a updating:
        public delegate void performCallback(object state);
    //Action class
    class performClass 
     {
         //test the database of updating with using  count.
       static int count = 0;
        public performClass() { }
         //The task to run should be specified in the implementation of the run() method.
         //It is an abstaract method.
       public static void updating(object state)
         {
             ++count;
               System.Diagnostics.Debug.WriteLine("Test about databases uppdatering  ....! ");
             if(count==5)
             {
               System.Diagnostics.Debug.WriteLine("Test!. tell the user about the existence new notification ..! ");
                 count = 0;
             }
         }
      
     }
    //Timer in Portable Class Library
    public class ScheduleTest : CancellationTokenSource, IDisposable
    {
        //test the database of updating with using  count.
        protected static int count = 0;
        protected static int period; //milliseconds
        protected static int DueTime;//milliseconds
       

        public ScheduleTest(int _DueTime,int _period) {
            period = _period;
            DueTime = _DueTime;
        }
        // 

        public void ScheduledThread(performCallback callback,object state)
        {
            //// Create a schedule to run  the instance of performClass that  includes a
            //task that waits one millisecond, then invokes every x millisecond.
             Task.Delay(DueTime, Token).ContinueWith(async(t, s) =>
             {
                 //The method Tuple  has represents 2 elements - delagates method and its argument- type object
                 //Tuple`2 object as the method argument,
                 //suppling the performCallback’s startup routine with one item of data.
                 var tuple = (Tuple<performCallback, object>)s;
                 while (!IsCancellationRequested)
                 {
                     //PassedInUpdating();
                    await Task.Run(()=>  tuple.Item1(tuple.Item1));
                    await Task.Delay(period, Token).ConfigureAwait(false);
                 } 
             }, Tuple.Create(callback, state), CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously |
                                                      TaskContinuationOptions.OnlyOnRanToCompletion, TaskScheduler.Default);
        }
    
        // Call a passed-in delegate on updating to process it: 
       private void PassedInUpdating() {

        
            ++count;
            System.Diagnostics.Debug.WriteLine("Test about databases uppdatering  ....! ");
            if (count == 5)
            {
                System.Diagnostics.Debug.WriteLine("Test!. tell the user about the existence new notification ..! ");
                count = 0;
            }       

    }
        //Releases all resources used by the current instance of thread.
        //Interrupt scheduled thread.

        public new void Dispose()
        {
            Cancel();

        }
    }
}

//Test about the updating database by using the timer 
//  public class ActivateOfUpdatingData:Timer
//{
//public Timer timer;


//public ActivateOfUpdatingData(string name) : base(name) { }
//public override void ScheduleAtFixedRate(TimerTask task, long delay, long period)
//{                      
//    base.Schedule(task, delay, period);
//}

//public override void Cancel()
//{        
//    base.Cancel();
//    Debug.WriteLine("disposing of Timer...");
//}




