using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuringMachine;

namespace AdditingWandMT
{
    public static class TableTrasitionOfWand
    {
        public static IEnumerable<Transition> GetDefaultTable() => new[]
       {
            new Transition(0,        'a', Head.Blank, HeadDirection.Right, 1),
            new Transition(0,        'b',        'b', HeadDirection.NoMove, State.Halt),
            new Transition(0,        '|',        '|', HeadDirection.NoMove, State.Halt),
            new Transition(0, Head.Blank, Head.Blank, HeadDirection.Right , 0),

            new Transition(1,        'a',        'a', HeadDirection.Right, 1),
            new Transition(1,        'b',        'b', HeadDirection.Right, 1),
            new Transition(1,        '|',        '|', HeadDirection.Right, 1),
            new Transition(1, Head.Blank,        '|', HeadDirection.Left, 2),

            new Transition(2,        'a',        'a', HeadDirection.Left, 2),
            new Transition(2,        'b',        'b', HeadDirection.Left, 2),
            new Transition(2,        '|',        '|', HeadDirection.Left, 2),
            new Transition(2, Head.Blank,        'a', HeadDirection.Right, 0),
        };
    }
}
