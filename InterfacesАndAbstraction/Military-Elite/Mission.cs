using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Mission : IMission
    {
        
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; set; }
        public string State
        {
            get
            { return this.state; }
            set
            {
                if (value == "inProgress" || value == "Finished")
                    this.state = value;
                else
                    throw new ArgumentException("Invalid state");
            }
        }

        public void CompleteMission()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
