using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Machine
    {
        public int State { get; }
        public Head Head { get; }

        //just one check is needed for alphabet
        public bool isChecked = false;

        public List<char> Alphabet { get; }
        public Machine(int state, Head head, IEnumerable<Transition> transitionTable, List<char> alphabet)
        {
            Alphabet = alphabet;
            Alphabet.Add(Head.Blank);

            if (!isChecked && !CheckTapeByAlphabet(head.Tape))
            {
                //too lazy to make own exception, sorry ilya
                throw new ArgumentException($"Entered elements are not contain in alphabet");
            }

            isChecked = true;

            if (head == null) throw new ArgumentNullException(nameof(head));
            if (transitionTable == null) throw new ArgumentNullException(nameof(transitionTable));

            State = state;
            Head = head;
            TransitionTable = transitionTable;
        }

        private bool CheckTapeByAlphabet(IEnumerable<char> tape)
        {
            foreach(var element in tape)
            {
                if (!Alphabet.Contains(element))
                {
                    return false;
                }
            }

            return true;
        }

        public IEnumerable<Transition> TransitionTable { get; }

        public Machine Step()
        {
            if (State < 0) return this;
            var machine = TransitionTable
                    .Where(t => t.InitialState == State && t.Read == Head.Read())
                    .DefaultIfEmpty(new Transition(0, Head.Blank, Head.Read(), HeadDirection.NoMove,
                        TuringMachine.State.Error))
                    .Select(
                        t => new Machine(t.NextState, Head.Write(t.Write).Move(t.HeadDirection), TransitionTable, Alphabet))
                    .First();

            return machine;
                
        }

        public Machine Run()
        {
            var m = this;
            
            while (m.State >= 0)
            {
                m = m.Step();
            }

            return m;
        }
    }
}
