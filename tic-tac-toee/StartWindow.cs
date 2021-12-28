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

        public bool winRow() {
            if (_button1.Label == player && _button2.Label == player && _button3.Label == player)
            {
                _Winer.Text = "The winner is " + player;   
                return true;
            }
            if (_button7.Label == _button8.Label && _button7.Label == _button9.Label) {
                _Winer.Text = "The winner is " + player;   
            return true;
        }

         if (_button4.Label == _button5.Label && _button4.Label == _button6.Label) {
                _Winer.Text = "The winner is " + player;   
            return true;
        }
        return false; 
        }


        public bool winColumn() {
            if (_button1.Label == player && _button1.Label == player)
            {
                _Winer.Text = "The winner is " + player;   
                return true;
            }
            if (_button2.Label == _button5.Label && _button2.Label == _button8.Label) {
                _Winer.Text = "The winner is " + player;   
            return true;
        }

           if (_button3.Label == _button6.Label && _button3.Label == _button9.Label) {
                _Winer.Text = "The winner is " + player;   
            return true;
        }
        return false; 
        }

         public bool winDiag() {
            if (_button1.Label == _button5.Label && _button1.Label == _button9.Label)
            {
                _Winer.Text = "The winner is " + player;   
                return true;
            }
            if (_button3.Label == _button5.Label && _button3.Label == _button7.Label) {
                _Winer.Text = "The winner is " + player;   
            return true;
        }

           
        return false; 
        }


    public bool winCondition() {
        if (_button1.Label == player || _button2.Label == player || _button3.Label == player) {
            if(winColumn()) {
                return true;
            }

             if(winDiag()) {
                return true;
            }

            if(winRow()) {
                return true;
            }
        }
         if (_button5.Label == player) {
            

             if(winDiag()) {
                return true;
            }

            if(winColumn()) {
                return true;
            }
             if(winRow()) {
                return true;
            }
         }
              if (_button6.Label == player) {
            
            if(winColumn()) {
                return true;
            }
             if(winRow()) {
                return true;
            }

              if (_button6.Label == player) {
            
            if(winColumn()) {
                return true;
            }
             if(winRow()) {
                return true;
            }
            


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
            winCondition();
            turns();






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
           
            winCondition();

            turns();

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
            winCondition();
            turns();

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
            winCondition();
            turns();


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
            winCondition();
            turns();


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
            winCondition();
            turns();


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
            winCondition();
            turns();


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
            _button8.Label = player;
            winCondition();
            turns();



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
            winCondition();
            turns();



        }





    }
}
