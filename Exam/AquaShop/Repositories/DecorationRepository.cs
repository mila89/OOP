using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private List<IDecoration> decorationsList;

        public DecorationRepository()
        {
            decorationsList = new List<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models => this.decorationsList.AsReadOnly();

        public void Add(IDecoration model)
        {
            // if it is nececcary to check null
            this.decorationsList.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            return this.decorationsList.FirstOrDefault(x => x.GetType().Name == type);

        }

        public bool Remove(IDecoration model)
        {
            bool res = false;
            if (model != null)
            {
                res = true;
                this.decorationsList.Remove(model);
            }
            return res;
        }

        internal object FirstOrDeafault(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
