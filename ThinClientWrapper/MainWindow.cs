/* The MIT License (MIT)
 *
 * MainWindow.cs
 * 
 * Copyright Tony Ayre (c) 2014-2015 
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using Gtk;
using System.Diagnostics;

public class MainWindow : Gtk.Window
    {
        public MainWindow() : base(Gtk.WindowType.Toplevel)
        {
            Build();
            Gdk.Window mwin = this.GdkWindow;
            Gdk.Screen mainScreen = this.Screen;
            this.HeightRequest = mainScreen.Height;
            this.WidthRequest = mainScreen.Width;
            this.btnLogon.Clicked += btnLogon_Clicked;
            this.entryPassword.ActivatesDefault = true;
        }

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        void btnLogon_Clicked(object sender, System.EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();

            psi.FileName = ThinClientWrapper.Properties.Settings.Default.executable;
            psi.Arguments = "-u " + this.entryUsername.Text + " -p " + this.entryPassword.Text + " -d " + ThinClientWrapper.Properties.Settings.Default.domain + " -f --plugin rdpsnd " + ThinClientWrapper.Properties.Settings.Default.farm;
            psi.UseShellExecute = false;

            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();
            Application.Quit();
        }

        private global::Gtk.Table table2;

        private global::Gtk.Fixed fixed1;

        private global::Gtk.Image imgLogo;

        private global::Gtk.Label lblUsername;

        private global::Gtk.Label lblPassword;

        private global::Gtk.Entry entryUsername;

        private global::Gtk.Entry entryPassword;

        private global::Gtk.Button btnLogon;

        private global::Gtk.Fixed fixed3;

        private global::Gtk.Fixed fixed4;

        private global::Gtk.Fixed fixed5;

        private global::Gtk.Fixed fixed6;

        protected virtual void Build()
        {
            global::GuiInit.Gui.Initialize(this);
            // Widget MainWindow
            this.Events = ((global::Gdk.EventMask)(4096));
            this.Name = "MainWindow";
            this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
            this.WindowPosition = ((global::Gtk.WindowPosition)(3));
            this.Modal = true;
            this.Resizable = false;
            this.Decorated = false;
            // Container child MainWindow.Gtk.Container+ContainerChild
            this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.fixed1 = new global::Gtk.Fixed();
            this.fixed1.WidthRequest = 390;
            this.fixed1.HeightRequest = 200;
            this.fixed1.HasWindow = false;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.imgLogo = new global::Gtk.Image("Small.png");
            this.imgLogo.Name = "imageLogo";
            this.fixed1.Add(this.imgLogo);
            global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.imgLogo]));
            w1.X = 22;
            w1.Y = 33;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.lblUsername = new global::Gtk.Label();
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.LabelProp = global::Mono.Unix.Catalog.GetString("Username");
            this.fixed1.Add(this.lblUsername);
            global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblUsername]));
            w2.X = 132;
            w2.Y = 25;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.lblPassword = new global::Gtk.Label();
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.LabelProp = global::Mono.Unix.Catalog.GetString("Password");
            this.fixed1.Add(this.lblPassword);
            global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblPassword]));
            w3.X = 132;
            w3.Y = 92;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.entryUsername = new global::Gtk.Entry();
            this.entryUsername.WidthRequest = 230;
            this.entryUsername.CanFocus = true;
            this.entryUsername.Name = "entryUsername";
            this.entryUsername.IsEditable = true;
            this.entryUsername.InvisibleChar = '●';
            this.fixed1.Add(this.entryUsername);
            global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entryUsername]));
            w4.X = 135;
            w4.Y = 51;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.entryPassword = new global::Gtk.Entry();
            this.entryPassword.WidthRequest = 230;
            this.entryPassword.CanFocus = true;
            this.entryPassword.Name = "entryPassword";
            this.entryPassword.IsEditable = true;
            this.entryPassword.Visibility = false;
            this.entryPassword.InvisibleChar = '●';
            this.fixed1.Add(this.entryPassword);
            global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entryPassword]));
            w5.X = 135;
            w5.Y = 116;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.btnLogon = new global::Gtk.Button();
            this.btnLogon.WidthRequest = 109;
            this.btnLogon.CanDefault = true;
            this.btnLogon.CanFocus = true;
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.UseUnderline = true;
            this.btnLogon.Label = global::Mono.Unix.Catalog.GetString("_Log On");
            this.fixed1.Add(this.btnLogon);
            global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnLogon]));
            w6.X = 257;
            w6.Y = 158;
            this.table2.Add(this.fixed1);
            global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.fixed1]));
            w7.TopAttach = ((uint)(1));
            w7.BottomAttach = ((uint)(2));
            w7.LeftAttach = ((uint)(1));
            w7.RightAttach = ((uint)(2));
            w7.XOptions = ((global::Gtk.AttachOptions)(2));
            w7.YOptions = ((global::Gtk.AttachOptions)(2));
            // Container child table2.Gtk.Table+TableChild
            this.fixed3 = new global::Gtk.Fixed();
            this.fixed3.Name = "fixed3";
            this.fixed3.HasWindow = false;
            this.table2.Add(this.fixed3);
            global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.fixed3]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            // Container child table2.Gtk.Table+TableChild
            this.fixed4 = new global::Gtk.Fixed();
            this.fixed4.Name = "fixed4";
            this.fixed4.HasWindow = false;
            this.table2.Add(this.fixed4);
            global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.fixed4]));
            w9.TopAttach = ((uint)(1));
            w9.BottomAttach = ((uint)(2));
            w9.LeftAttach = ((uint)(2));
            w9.RightAttach = ((uint)(3));
            // Container child table2.Gtk.Table+TableChild
            this.fixed5 = new global::Gtk.Fixed();
            this.fixed5.Name = "fixed5";
            this.fixed5.HasWindow = false;
            this.table2.Add(this.fixed5);
            global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2[this.fixed5]));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            // Container child table2.Gtk.Table+TableChild
            this.fixed6 = new global::Gtk.Fixed();
            this.fixed6.Name = "fixed6";
            this.fixed6.HasWindow = false;
            this.table2.Add(this.fixed6);
            global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2[this.fixed6]));
            w11.TopAttach = ((uint)(2));
            w11.BottomAttach = ((uint)(3));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            this.Add(this.table2);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 730;
            this.DefaultHeight = 592;
            this.btnLogon.HasDefault = true;
            this.Show();
            this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
        }

    }