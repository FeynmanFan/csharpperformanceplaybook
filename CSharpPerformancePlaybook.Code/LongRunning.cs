namespace CSharpPerformancePlaybook.Code
{
    public class LongRunning
    {
        public int GetThirtySeven()
        {
            Thread.Sleep(5000);

            return 37;
        }

        public async Task<int> LongRunningAsync()
        {
            Thread.Sleep(5000);

            return 37;
        }
    }
}
