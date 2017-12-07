// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NoGracias
{
    [Register ("FirstViewController")]
    partial class MainMenuViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Connect_Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Player_Name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Ready_Button { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Connect_Button != null) {
                Connect_Button.Dispose ();
                Connect_Button = null;
            }

            if (Player_Name != null) {
                Player_Name.Dispose ();
                Player_Name = null;
            }

            if (Ready_Button != null) {
                Ready_Button.Dispose ();
                Ready_Button = null;
            }
        }
    }
}