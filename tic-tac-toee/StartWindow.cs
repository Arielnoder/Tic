using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;


namespace tic_tac_toee
{

    class StartWindow : Window
    {


        [UI] private Button _button1 = null;

        [UI] private Button _button2 = null;

        [UI] private Button _button3 = null;

        [UI] private Button _button4 = null;

        [UI] private Button _button5 = null;

        [UI] private Button _button6 = null;

        [UI] private Button _button7 = null;

        [UI] private Button _button8 = null;

        [UI] private Button _button9 = null;


        [UI] private Label _Winer = null;
        string player = "X";






        public StartWindow() : this(new Builder("StartWindow.glade")) { }

        private StartWindow(Builder builder) : base(builder.GetRawOwnedObject("StartWindow"))
        {
            builder.Autoconnect(this);


            game();


            DeleteEvent += Window_DeleteEvent;





        }




        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        public void game()
        {

            _button1.Clicked += button1_click;
            _button2.Clicked += button2_click;
            _button3.Clicked += button3_click;
            _button4.Clicked += button4_click;
            _button5.Clicked += button5_click;
            _button6.Clicked += button6_click;
            _button7.Clicked += button7_click;
            _button8.Clicked += button8_click;
            _button9.Clicked += button9_click;


        }

        public bool turns()
        {
            if (player == "X")
            {
                player = "O";
                return true;
            }
            if (player == "O")
            {
                player = "X";
                return true;
            }
            return false;
        }

        public bool winRow()
        {
            if (_button1.Label == "X" && _button2.Label == "X" && _button3.Label == "X")
            {
                _Winer.Text = "The winner is X";
                return true;
            }
            if (_button1.Label == "O" && _button2.Label == "O" && _button3.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }
            if (_button7.Label == "X" && _button7.Label == "X" && _button9.Label == "X")
            {
                _Winer.Text = "The winner is X ";
                return true;
            }

            if (_button4.Label == "O" && _button5.Label == "O" && _button5.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }
            return false;
        }


        public bool winColumn()
        {
            if (_button1.Label == "O" && _button4.Label == "O" && _button7.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }
            if (_button1.Label == "X" && _button4.Label == "X" && _button7.Label == "X")
            {
                _Winer.Text = "The winner is X";
                return true;
            }

            if (_button3.Label == "X" && _button6.Label == "X" && _button9.Label == "X")
            {
                _Winer.Text = "The winner is X";
                return true;
            }

            if (_button3.Label == "O" && _button6.Label == "O" && _button9.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }

            if (_button2.Label == "X" && _button5.Label == "X" && _button8.Label == "X")
            {
                _Winer.Text = "The winner is X";
                return true;
            }
            if (_button2.Label == "O" && _button5.Label == "O" && _button8.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }
            return false;
        }

        public bool winDiag()
        {
            if (_button1.Label == "X" && _button5.Label == "X" && _button9.Label == "X")
            {
                _Winer.Text = "The winner is X";
                return true;
            }
            if (_button1.Label == "O" && _button5.Label == "O" && _button9.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }
            if (_button3.Label == "X" && _button5.Label == "X" && _button7.Label == "X")
            {
                _Winer.Text = "The winner is X";
                return true;
            }
            if (_button3.Label == "O" && _button5.Label == "O" && _button7.Label == "O")
            {
                _Winer.Text = "The winner is O";
                return true;
            }



            return false;
        }

        public bool winCondition()
        {

            if (_button2.Label == player || _button3.Label == player)
            {

                if (winColumn())
                {

                    return true;
                }
                if (winRow())
                {

                    return true;
                }

            }
            if (_button3.Label == player || _button1.Label == player)
            {
                if (winDiag())
                {
                    return true;
                }
            }
            return false;


        }













        void button1_click(object sender, EventArgs a)
        {
            if (_button1.Label == "O")
            {
                player = "O";
            }
            if (_button1.Label == "X")
            {
                player = "X";
            }


            _button1.Label = player;

            pc();
            player = "X";
            winCondition();







        }

        void button2_click(object sender, EventArgs a)
        {
            if (_button2.Label == "O")
            {
                player = "O";
            }
            if (_button2.Label == "X")
            {
                player = "X";
            }

            _button2.Label = player;

            pc();
            player = "X";
            winCondition();



        }

        void button3_click(object sender, EventArgs a)
        {
            if (_button3.Label == "O")
            {
                player = "O";
            }
            if (_button3.Label == "X")
            {
                player = "X";
            }

            _button3.Label = player;

            pc();
            player = "X";
            winCondition();


        }

        void button4_click(object sender, EventArgs a)
        {
            if (_button4.Label == "O")
            {
                player = "O";
            }
            if (_button4.Label == "X")
            {
                player = "X";
            }

            _button4.Label = player;

            pc();
            player = "X";
            winCondition();



        }

        void button5_click(object sender, EventArgs a)
        {
            if (_button5.Label == "O")
            {
                player = "O";
            }
            if (_button5.Label == "X")
            {
                player = "X";
            }

            _button5.Label = player;

            pc();
            player = "X";
            winCondition();



        }

        void button6_click(object sender, EventArgs a)
        {
            if (_button6.Label == "O")
            {
                player = "O";
            }
            if (_button6.Label == "X")
            {
                player = "X";
            }

            _button6.Label = player;

            pc();
            player = "X";
            winCondition();



        }

        void button7_click(object sender, EventArgs a)
        {
            if (_button7.Label == "O")
            {
                player = "O";
            }
            if (_button7.Label == "X")
            {
                player = "X";
            }

            _button7.Label = player;
           
            pc();
            player = "X";

            winCondition();



        }

        void button8_click(object sender, EventArgs a)
        {
            if (_button8.Label == "O")
            {
                player = "O";
            }
            if (_button8.Label == "X")
            {
                player = "X";
            }

            _button8.Label = "X";

            pc();
            player = "X";
            winCondition();




        }

        void button9_click(object sender, EventArgs a)
        {
            if (_button9.Label == "O")
            {
                player = "O";
            }
            if (_button9.Label == "X")
            {
                player = "X";
            }

            _button9.Label = player;

            pc();
            player = "X";
            winCondition();




        }

        public void pc()
        {
            bool check = true;
            bool check2 = true;
            bool check3 = true;
            bool check4 = true;
            
            bool check6 = false;
            bool check7 = true;
            bool check8 = true;


            if (_button5.Label != "X" && check == true)
            {
                player = "O";
                _button5.Label = player;

                check = false;




            }

            if (_button2.Label == "X" && check2 == true)
            {
                if (check == true)
                {
                    player = "O";
                    _button3.Label = player;
                }
                player = "X";
                check2 = false;


            }


            if (_button1.Label == "X" && _button3.Label == "X" && _button2.Label != "O" && check3 == true && player != "X")
            {
                player = "O";
                _button2.Label = player;
                player = "X";
                check3 = false;


            }

            if (_button1.Label == "X" && _button2.Label == "X" && check7 == true)
            {
                player = "O";
                _button3.Label = player;
                player = "X";
                check7 = false;


            }
            if (_button2.Label == player && _button5.Label == player && check4 == true && _button8.Label != "X")
            {
                player = "O";
                _button8.Label = player;
                player = "X";
                check4 = false;

            }
          if (_button3.Label == player && _button5.Label == player && _button7.Label != "X" && check7 == true)
            {   
                
                player = "O";
                _button7.Label = player;
                player = "X";
                check7 = false;

            }

            if (_button1.Label == "O" && _button5.Label == "O" && _button9.Label != "X" && check6 == false)
            {
                player = "O";
                _button9.Label = player;
                player = "X";
                check6 = true;
            }
            if (_button2.Label == "O" && _button5.Label == "O" && _button8.Label == "X" && check8 == true)
            {
                player = "O";

                _button6.Label = player;
                player = "X";
                check8 = false;

            }



        }



    }
}
