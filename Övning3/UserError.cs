using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }
    public class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    //custom concrete classes
    public class SymbolError : UserError 
    {
        public override string UEMessage() 
        {
            return " This is custom error 1 for adding symbols instead of characters!";
        }
    }
    public class InSuffiecientError : UserError
    {
        public override string UEMessage()
        {
            return " This is custom error 2 for having a weak password. It must contain 12 characters!";
        }
    }
    public class InValidError : UserError
    {
        public override string UEMessage()
        {
            return " This is custom error 3 for typing Invalid User Name. Try new name!";
        }
    }


}
