using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroMoney.ViewModels.TreeViewNodes
{
    public class HoummieTreeViewNode : TreeViewNode
    {
        private string firstName;
        private string secondName;
        public override string Title
        {
            get => $"{secondName} {firstName}";
            set => throw new NotImplementedException();
        }
        public HoummieTreeViewNode(string firstName, string secondName, TreeViewNode parent)
        :base("", parent)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }
    }
}