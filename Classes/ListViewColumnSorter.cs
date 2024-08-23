using System.Collections;
using System.Windows.Forms;

public class ListViewColumnSorter : IComparer
{
    private int columnToSort;
    private SortOrder orderOfSort;
    private readonly CaseInsensitiveComparer objectCompare;

    public ListViewColumnSorter()
    {
        columnToSort = 0;
        orderOfSort = SortOrder.None;
        objectCompare = new CaseInsensitiveComparer();
    }

    public int Compare(object x, object y)
    {
        int compareResult;
        var listViewX = (ListViewItem)x;
        var listViewY = (ListViewItem)y;

        compareResult = objectCompare.Compare(listViewX.SubItems[columnToSort].Text, listViewY.SubItems[columnToSort].Text);

        if (orderOfSort == SortOrder.Ascending)
        {
            return compareResult;
        }
        else if (orderOfSort == SortOrder.Descending)
        {
            return -compareResult;
        }
        else
        {
            return 0;
        }
    }

    public int SortColumn
    {
        get => columnToSort;
        set => columnToSort = value;
    }

    public SortOrder Order
    {
        get => orderOfSort;
        set => orderOfSort = value;
    }
}