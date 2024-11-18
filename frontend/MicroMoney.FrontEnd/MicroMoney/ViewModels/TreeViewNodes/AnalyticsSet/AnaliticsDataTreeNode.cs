using System.Collections.ObjectModel;

namespace MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet
{
    public class AnaliticsDataTreeNode : TreeViewNode
    {
        public int ItemRelationId {get;set;}
        public string? Description {get;set;}
        public int? ItemIntData {get;set;}
        public string? ItemStringData {get;set;}
        public double? ItemDoubleData {get;set;}

        public AnaliticsDataTreeNode(string title, TreeViewNode parent) 
        : base(title, parent)
        {
        }

        public AnaliticsDataTreeNode(string title, TreeViewNode parent, ObservableCollection<TreeViewNode> subNodes) 
        : base(title, parent, subNodes)
        {
        }
    }
}