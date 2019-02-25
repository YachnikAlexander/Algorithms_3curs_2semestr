using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuringMachine;

namespace PowerOfTwoMT
{
    public static class TableTransition
    {
        public static IEnumerable<Transition> GetDefaultTable() => new[]
        {
            new Transition(0,        '0', Head.Blank, HeadDirection.Right, 0),
            new Transition(0,        '1', Head.Blank, HeadDirection.Right, 1),
            new Transition(0, Head.Blank,        '0', HeadDirection.NoMove, State.Halt),

            new Transition(1,        '0', Head.Blank, HeadDirection.Right, 1),
            new Transition(1,        '1', Head.Blank, HeadDirection.Right, 2),
            new Transition(1, Head.Blank,        '1', HeadDirection.NoMove, State.Halt),

            new Transition(2,        '0', Head.Blank, HeadDirection.Right, 2),
            new Transition(2,        '1', Head.Blank, HeadDirection.Right, 2),
            new Transition(2, Head.Blank,        '0', HeadDirection.NoMove, State.Halt),
        };
    }
}
