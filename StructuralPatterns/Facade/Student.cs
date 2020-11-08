using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade
{
    class Student
    {
        private Book book = new Book();
        private Computer computer = new Computer();
        private Notepad notepad = new Notepad();
        private Workplace workplace = new Workplace();

        public void StartLearning()
        {
            notepad.Open();
            book.Open();
            computer.TurnOn();
        }

        public void EndLearning()
        {
            notepad.Close();
            book.Close();
            computer.TurnOff();
            workplace.Clean();
        }
    
    }
}
