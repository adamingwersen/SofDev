using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
    public MainWindow () : base (Gtk.WindowType.Toplevel)
    {
        Build ();
        this.darea.ExposeEvent += this.OnExposeEvent;
    }

    protected void OnDeleteEvent (object sender, DeleteEventArgs a)
    {
        Application.Quit ();
        a.RetVal = true;
    }
    protected void OnExposeEvent (object sender, ExposeEventArgs a)
    {
        this.darea.ModifyBg (StateType.Normal,
            new Gdk.Color (0, 0, 0));
    }
}
