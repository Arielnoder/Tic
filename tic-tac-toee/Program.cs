using System;
using Gtk;

namespace tic_tac_toee
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.tic_tac_toee.tic_tac_toee", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new StartWindow();
           

            win.Show();
            Application.Run();
        }
        
    }
}
