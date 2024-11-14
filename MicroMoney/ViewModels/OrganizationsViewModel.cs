using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MicroMoney.ViewModels
{
    public partial class OrganizationsViewModel : LeftTabsViewModel
    {
        [ObservableProperty]
        private ObservableCollection<MmTreeViewNode> selectedNodes;
        [ObservableProperty]
        private ObservableCollection<MmTreeViewNode> nodes;

        public OrganizationsViewModel()
        {
            SelectedNodes = new ObservableCollection<MmTreeViewNode>();
            Nodes = new ObservableCollection<MmTreeViewNode>
            {                
                new ("Animals", new ObservableCollection<MmTreeViewNode>
                {
                    new MmTreeViewNode("Mammals", new ObservableCollection<MmTreeViewNode>
                    {
                        new MmTreeViewNode("Lion"), new MmTreeViewNode("Cat"), new MmTreeViewNode("Zebra")
                    })
                }),
                new MmTreeViewNode("Birds", new ObservableCollection<MmTreeViewNode>
                {
                    new MmTreeViewNode("Robin"), new MmTreeViewNode("Condor"), 
                    new MmTreeViewNode("Parrot"), new MmTreeViewNode("Eagle")
                }),
                new MmTreeViewNode("Insects", new ObservableCollection<MmTreeViewNode>
                {
                    new MmTreeViewNode("Locust"), new MmTreeViewNode("House Fly"), 
                    new MmTreeViewNode("Butterfly"), new MmTreeViewNode("Moth")
                }),
            };
        }
    }
}