using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet
{
    public class AnaliticTreeNode : TreeViewNode
    {
        public string AnaliticName {get;set;}
        public string AnaliticDescription {get;set;}
        public int AnaliticId {get;set;}
        public Type DataType {get;set;}
 
        public static AnaliticTreeNode Create()
        {
            return new ();
        }

        protected AnaliticTreeNode()
        {

        }

        public AnaliticTreeNode(string title, TreeViewNode parent)
         : base(title, parent)
        {
            AnaliticName = title;
        }

        public AnaliticTreeNode(string title, TreeViewNode parent, ObservableCollection<TreeViewNode> subNodes)
         : base(title, parent, subNodes)
        {
        }
    }
}