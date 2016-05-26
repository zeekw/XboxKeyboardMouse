using System.Windows.Input;

namespace XboxMouse_Keyboard
{
    class Config
    {
        private class Input 
        {
            private class Buttons
            {
                private Key a;
                private Key b;
                private Key x;
                private Key y;
            }
            
            private class Dpad
            {
                private Key up;
                private Key down;
                private Key right;
                private Key left;
            }
            
            private class Bumpers
            {
                private Key right;
                private Key left;
            }
            
            private class Sticks
            {
                private Key right;
                private Key left;
            }
            private Key menu;  //aka Start
            private Key view;  //aka Back or Select or Nav
            private Key home;  //aka Guide 
            
        }
        
        private class App
        {
            private uint ticks_per_frame;
        }
        
        public class LoadConfig()
        {
            
        }
        
      //todo getters and setters
    }
}