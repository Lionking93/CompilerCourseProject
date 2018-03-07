using System;
using System.Collections.Generic;

namespace MiniPLCompiler
{
    public class Automaton
    {
        private int startState;
        private int currentState;
        private HashSet<int> acceptedStates;
        private Dictionary<AutomatonInput, int> stateTransitions;

        public Automaton(int pStartState, HashSet<int> pAcceptedStates, 
                         Dictionary<AutomatonInput, int> pStateTransitions)
        {
            this.startState = pStartState;
            this.currentState = this.startState;
            this.acceptedStates = pAcceptedStates;
            this.stateTransitions = pStateTransitions;
        }

        public int GetCurrentState() {
            return this.currentState;
        }

        public bool InAcceptedState() {
            return this.acceptedStates.Contains(this.currentState);
        }

        public Automaton ChangeState(char pInput) {
            AutomatonInput input = new AutomatonInput(this.currentState, pInput);

            if (!this.stateTransitions.ContainsKey(input)) {
                throw new ArgumentException("Automaton doesn't have a state transition from state " 
                                            + this.currentState + " with input " + pInput);
            }

            this.currentState = this.stateTransitions[input];
            return this;
        }
    }
}
