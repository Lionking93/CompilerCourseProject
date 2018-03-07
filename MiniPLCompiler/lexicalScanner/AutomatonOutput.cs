using System;
namespace MiniPLCompiler
{
    public class AutomatonOutput
    {
        private readonly int state;

        public AutomatonOutput(int pState)
        {
            this.state = pState;
        }

        public int GetState() {
            return this.state;
        }

        public override bool Equals(Object obj) {
            if (obj == null || GetType()!= obj.GetType()) {
                return false;
            }

            AutomatonOutput comparable = (AutomatonOutput)obj;

            return this.state == comparable.state;
        }

        public override int GetHashCode() {
            return this.state;
        }
    }
}
