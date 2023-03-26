using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cor_with_UT
{
    public abstract class Handler_
    {
        protected Handler_ nex_of;
        public void setNext(Handler_ next)
        {
            nex_of = next;
        }
        public abstract string request(string what);
    }

    public class Is_this_question_normal : Handler_
    {
        public Is_this_question_normal() { }

        public override string request(string what)
        {
            if (Char.IsLetter(what[0]))
            {
                if (what[what.Length - 1] != '?')
                {
                    if (nex_of != null)
                    {
                        return nex_of.request(what);
                    }
                    else
                    {
                        return "Whats wrong with u?";
                    }
                }
                else
                {
                    return "Who gave you permission to ask questions?";
                }
            }
            else
            {
                return "Maybe it's better to be checked by an ophthalmologist?";
            }
        }
    }
    public class FromAtoM : Handler_
    {
        public FromAtoM() { }

        public override string request(string what)
        {
            if ((what[0] >= 'a' && what[0] <= 'm') || (what[0] >= 'A' && what[0] <= 'M'))
            {
                return "It's something from a to m";
            }
            else if (nex_of != null)
            {
                return nex_of.request(what);
            }
            return "Whats wrong with u?\nR U blind?";
        }
    }
    public class FromNtoZ : Handler_
    {
        public FromNtoZ() { }

        public override string request(string what)
        {
            if ((what[0] >= 'n' && what[0] <= 'z') || (what[0] >= 'N' && what[0] <= 'Z'))
            {
                return "It's something from n to z";
            }
            else if (nex_of != null)
            {
                return nex_of.request(what);
            }
            return "Whats wrong with u?\nR U blind, or something?";
        }
    }
}
