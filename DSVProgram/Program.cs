// Copyright AlexanderAL123, OISP-1-120. ALL RIGHTS RESERVED.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSVProgram
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Auth AuthForm = new Auth();
            Application.Run(AuthForm);

            if (AuthForm.SuccessfullyAuth)
            {
                if (AuthForm.SUCCESS_ADMIN) Application.Run(new Admin());
                else if (AuthForm.SUCCESS_EMPLOYEE) Application.Run(new Employee());
                else if (AuthForm.SUCCESS_WAITER) Application.Run(new Waiter());
            }
        }
    }
}