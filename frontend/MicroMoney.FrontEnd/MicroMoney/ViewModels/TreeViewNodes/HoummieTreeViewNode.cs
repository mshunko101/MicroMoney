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
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public string SecondName
        {
            get => secondName;
            set
            {
                secondName = value;
                OnPropertyChanged(nameof(Title));
            }
        }
 
        public HoummieTreeViewNode(TreeViewNode parent)
        :base("", parent)
        {
        }
    }
}