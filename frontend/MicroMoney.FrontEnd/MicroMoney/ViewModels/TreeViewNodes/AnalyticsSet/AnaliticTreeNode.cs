using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet
{
    public class AnaliticTreeNode : TreeViewNode
    {
        public string AnalyticName {get;set;}
        public int AnaliticId {get;set;}

        public AnaliticTreeNode(string title, TreeViewNode parent)
         : base(title, parent)
        {
        }

        public AnaliticTreeNode(string title, TreeViewNode parent, ObservableCollection<TreeViewNode> subNodes)
         : base(title, parent, subNodes)
        {
        }
    }
}