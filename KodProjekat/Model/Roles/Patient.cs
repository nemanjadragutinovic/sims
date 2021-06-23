/***********************************************************************
 * Module:  Patient.cs
 * Author:  ASsoft
 * Purpose: Definition of the Class Model.Roles.Patient
 ***********************************************************************/

using System;

namespace Model.Roles
{
   public class Patient : User
   {
        public override string ToString()
        {
            return Name + " " + Surname + " " + Jmbg;
        }
    }
}