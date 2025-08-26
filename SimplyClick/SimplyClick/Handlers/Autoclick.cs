using SimplyClick.Utils;

namespace SimplyClick.Handlers
{
    internal class Autoclick
    {
        #region Data
        internal static class ACData
        {
            internal static bool isThreadEnabled = false;
            internal static string? delayType = "Miliseconds";
            internal static float clickDelay = 2F;

            internal static float pressDownForTime = 0.1F; // How long to hold down the left click
        }
        #endregion

        private static Thread clickingThread;

        internal static void StartClicking(float clickDelay, float minClickDelay, float maxClickDelay, string delayType)
        {
            ACData.isThreadEnabled = true;
            clickingThread = new Thread(() =>
            {
                while (ACData.isThreadEnabled)
                {
                    Mouse.MouseClick();
                    Wait(ACData.clickDelay);
                }
            });

            if (!clickingThread.IsAlive)
                clickingThread.Start();
        }

        internal static void StopClicking()
        {
            ACData.isThreadEnabled = false;
            if (clickingThread != null && clickingThread.IsAlive)
                clickingThread.Join();
        }

        internal static void Wait(float delay = 0F)
        {
            if (string.IsNullOrEmpty(ACData.delayType))
            {
                MessageBox.Show("delayType is somehow null, shutting down");
                StopClicking();
            }

            // If someone has a better way of doing this please make a pull request
            if (delay == 0F)
                delay = ACData.clickDelay;

            switch (ACData.delayType)
            {
                case "Miliseconds":
                    Thread.Sleep(TimeSpan.FromMilliseconds(delay));
                    break;
                case "Seconds":
                    Thread.Sleep(TimeSpan.FromSeconds(delay));
                    break;
                case "Minutes":
                    Thread.Sleep(TimeSpan.FromMinutes(delay));
                    break;
                case "Hours":
                    Thread.Sleep(TimeSpan.FromHours(delay));
                    break;
                default:
                    Thread.Sleep(TimeSpan.FromMilliseconds(delay));
                    break;
            }
        }
    }
}
