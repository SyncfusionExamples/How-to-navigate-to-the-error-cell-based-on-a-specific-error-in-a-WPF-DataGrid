using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rowIndex;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMoveToErrorGridCell(object sender, RoutedEventArgs e)
        {
            var rowGenerator = dataGrid.RowGenerator;
            if(rowGenerator != null)
            {
                var rowItems = dataGrid.RowGenerator.Items;
                if (rowItems != null)
                {
                    for (int i = rowIndex; i < rowItems.Count; i++)
                    {
                        var items = rowItems[i];
                        if (items != null && items.Element != null && items.Element is HeaderRowControl)
                        {
                            rowIndex++;
                            continue;
                        }
                        var rowControl = items.Element as VirtualizingCellsControl;
                        if(rowControl != null && rowControl.Content != null)
                        {
                            var orientedCellsPanel = rowControl.Content as OrientedCellsPanel;
                            if (orientedCellsPanel != null && orientedCellsPanel.Children != null)
                            {
                                foreach (var child in orientedCellsPanel.Children)
                                {
                                    var gridCell = child as GridCell;
                                    if (gridCell != null && gridCell.ErrorMessage != null && gridCell.ErrorMessage.Equals("Invalid shipper id"))
                                    {
                                        var errorGridCell = gridCell;
                                        if (dataGrid.SelectionController != null)
                                            dataGrid.SelectionController.MoveCurrentCell(new RowColumnIndex(gridCell.ColumnBase.RowIndex, gridCell.ColumnBase.ColumnIndex));
                                        rowIndex++;
                                        return;
                                    }
                                }
                                rowIndex++;
                            }
                        }  
                    }
                }
            }      
        }
    }
}


