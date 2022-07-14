using System.Diagnostics;
namespace ProcessUtils
{
    public class ProcessWatcher
    {
        private Process process;
        public ProcessWatcher(string file, DataReceivedEventHandler callback = null, string arguments = null)
        {
            var processStartInfo = new ProcessStartInfo
            {
                FileName = file,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            process = new Process()
            {
                StartInfo = processStartInfo
            };
            process.OutputDataReceived += callback;
            process.Start();
            process.BeginOutputReadLine();
        }
        public void WaitForExit()
        {
            process.WaitForExit();
        }
    }
}