using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public enum StateEnum
    {
        inProgress = 1,
        Finished = 2
    }
    public class Mission : IMission
    {
        
        private StateEnum state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get;  }
        public string State
        {
            get
            { return this.state.ToString(); }
            set
            {
                StateEnum state;
                if (!Enum.TryParse<StateEnum>(value, out state))
                         throw new ArgumentException("Invalid state");
                this.state = state; 
            }
        }

        public void CompleteMission()
        {
            this.state = StateEnum.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
