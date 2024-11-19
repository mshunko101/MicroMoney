using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using MicroMoney.Utils;

namespace MicroMoney.ViewModels.TreeViewNodes.AnalyticsSet
{
    public class AnaliticDataTreeNode : TreeViewNode
    {
        protected AnaliticTreeNode Set => (AnaliticTreeNode)Parent!;
        protected static TypeConverter typeConverter = new TypeConverter();
        public int ItemRelationId {get;set;}
        public string? Description {get;set;}
        public int? ItemIntData {get;set;}
        public string? ItemStringData {get;set;}
        public double? ItemDoubleData {get;set;}
        public int ItemForeginRelationId {get;set;}
        public int ItemForeginRelationValueId {get;set;}

        public static Type[] GetSupportedTypes()
        {
            return new []{typeof(string), typeof(int), typeof(double)};
        }

        public string Data
        {
            get
            {
                if(Set.DataType == typeof(string))
                {
                    return ItemStringData;
                }
                else if(Set.DataType == typeof(int))
                {
                    return ItemIntData.ToString();
                }
                else if(Set.DataType == typeof(double))
                {
                    return ItemDoubleData.ToString();
                }
                else
                {
                    return "UNKNOWN TYPE";
                }
            }
            set
            {
                if(Set.DataType == typeof(string))
                {
                    ItemStringData = value;
                }
                else if(Set.DataType == typeof(int))
                {
                    ItemIntData = int.Parse(value, CultureInfo.InvariantCulture);
                }
                else if(Set.DataType == typeof(double))
                {
                    ItemDoubleData = double.Parse(value, CultureInfo.InvariantCulture);
                }
                else
                {
                    throw new NotImplementedException("Data");
                }
            }
        }

        protected AnaliticDataTreeNode()
        {

        }
        public static AnaliticDataTreeNode Create()
        {
            return new AnaliticDataTreeNode();
        }

        public AnaliticDataTreeNode(string title, TreeViewNode parent) 
        : base(title, parent)
        {
        }

        public AnaliticDataTreeNode(string title, TreeViewNode parent, ObservableCollection<TreeViewNode> subNodes) 
        : base(title, parent, subNodes)
        {
        }
    }
}