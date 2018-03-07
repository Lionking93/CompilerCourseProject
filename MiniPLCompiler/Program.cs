using System;
using System.Collections.Generic;

namespace MiniPLCompiler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Dictionary<AutomatonInput, int> stateTransitions = new Dictionary<AutomatonInput, int>();
            AutomatonInput input1 = new AutomatonInput(1, 'a');
            AutomatonInput input2 = new AutomatonInput(1, 'b');
            AutomatonInput input3 = new AutomatonInput(2, 'a');
            AutomatonInput input4 = new AutomatonInput(2, 'b');
            AutomatonInput input5 = new AutomatonInput(3, 'a');
            AutomatonInput input6 = new AutomatonInput(3, 'b');
            AutomatonInput input7 = new AutomatonInput(4, 'a');
            AutomatonInput input8 = new AutomatonInput(4, 'b');
            stateTransitions.Add(input1, 2);
            stateTransitions.Add(input2, 3);
            stateTransitions.Add(input3, 2);
            stateTransitions.Add(input4, 4);
            stateTransitions.Add(input5, 3);
            stateTransitions.Add(input6, 3);
            stateTransitions.Add(input7, 3);
            stateTransitions.Add(input8, 4);

            int startState = 1;
            HashSet<int> acceptedStates = new HashSet<int>();
            acceptedStates.Add(4);
            states.Add(1);
            states.Add(2);
            states.Add(3);
            states.Add(4);

            Automaton a = new Automaton(startState, acceptedStates, stateTransitions);
            Console.WriteLine(a.GetCurrentState());
            a.ChangeState('a').ChangeState('a').ChangeState('b');
            Console.WriteLine(a.GetCurrentState());
            Console.WriteLine(a.InAcceptedState());
            a.ChangeState('a');
            Console.WriteLine(a.InAcceptedState());
            Console.WriteLine(a.GetCurrentState());

            lexicalScanner.LexicalScanner scanner = new lexicalScanner.LexicalScanner();
        }
    }
}
