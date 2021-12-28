using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute ;


namespace tic_tac_toee
{
    class StartWindow : Window
    {
    
        [UI] private Grid _board = null;

        

        public StartWindow() : this(new Builder("StartWindow.glade")) { }

        private StartWindow(Builder builder) : base(builder.GetRawOwnedObject("StartWindow"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

       
    }
}
