
using ProcessUtils;


var p1 = new ProcessWatcher(
    "watch-me.exe",
    (sender, args) => Console.WriteLine("received output: {0}", args.Data)
);
var p2 = new ProcessWatcher(
    "watch-me.exe",
    (sender, args) => Console.WriteLine("received output: {0}", args.Data)
);

p1.WaitForExit();
p2.WaitForExit();