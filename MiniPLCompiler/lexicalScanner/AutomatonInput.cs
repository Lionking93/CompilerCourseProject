using System;

namespace MiniPLCompiler
{
    public class AutomatonInput
    {
        private readonly int state;
        private readonly char input;

        public AutomatonInput(int pState, char pInput)
        {
            this.state = pState;
            this.input = pInput;
        }

        public override bool Equals(Object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            AutomatonInput comparable = (AutomatonInput)obj;

            return (comparable.state == this.state) && (comparable.input == this.input);
        }

        public override int GetHashCode() {
            return this.state ^ this.input;
        }
    }
}
