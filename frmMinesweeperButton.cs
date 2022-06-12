using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;

namespace Minesweeper
{

    public partial class frmMinesweeperButton : Form
    {
        public int MaxRows { get; set; } = 0;
        public int MaxCols { get; set; } = 0;


        public frmMinesweeperButton()
        {
            InitializeComponent();
        }

        private void cell_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is not Button cell) return;
            //get tag with properties
            var tag = (CellTag)cell.Tag;
            //check if cell already open
            if (tag.IsOpen) return; //no any action on click if cell open

            switch (e.Button)
            {
                //right click set/remove flag
                case MouseButtons.Right:
                    {
                        //check cell state (flagged or not) and change state
                        if (tag.IsFlagged)
                        {
                            Cell.RemoveFlag(ref cell);
                        }
                        else
                        {
                            Cell.SetFlag(ref cell);
                        }
                        break;
                    }
                //left click 
                case MouseButtons.Left:
                    {
                        if (tag.IsFlagged || tag.IsOpen) return; //cell flagged - no actions on left click
                        CheckMinesAround(tag.Row, tag.Column, true);
                        break;
                    }
            }


        }


        //set initial board
        private void btnSetBoard_Click(object sender, EventArgs e)
        {
            //remove all cells
            panelBoard.Controls.Clear();

            MaxRows = Convert.ToInt32(tbMaxRows.Text);
            MaxCols = Convert.ToInt32(tbMaxCols.Text);
            var maxMines = Convert.ToInt32(tbMaxMines.Text);

            if (MaxRows <= 0 || MaxCols <= 0) return;

            var top = 20;
            var left = 20;
            var step = 20;

            //init cells
            for (var i = 0; i < MaxRows; i++)
            {
                for (var j = 0; j < MaxCols; j++)
                {
                    var cell = Cell.GetCell(top, left, i, j);
                    left += step; //shift to next column
                    panelBoard.Controls.Add(cell);
                    //cell.Click += (cell_Click);
                    cell.MouseUp += (cell_MouseUp);
                }

                left = 20;//return to first column
                top += step;//shift to next row
            }

            //set mines
            var rndRow = new Random();
            var rndCol = new Random();

            for (var i = 0; i <= maxMines; i++)
            {
                var mR = rndRow.Next(0, MaxRows);
                var mC = rndCol.Next(0, MaxCols);
                if (!Cell.IsValidCell(mR, mC, MaxRows, MaxCols)) continue;
                var cell = GetCellByRowColumn(mR, mC);
                if (cell != null) Cell.SetMine(ref cell, chbShowMines.Checked);

            }
        }

        //get button by row and column
        private Button? GetCellByRowColumn(int row, int col)
        {
            var cellName = Cell.GetCellName(row, col);
            var b = panelBoard.Controls.Find(cellName, true).FirstOrDefault();
            if (b?.GetType() == typeof(Button))
            {
                return (Button)b;
            }
            return null;
        }

        public void CheckMinesAround(int row, int col, bool isClickedCell = false)
        {
            var cell = GetCellByRowColumn(row, col);
            if (cell == null) return;
            var tag = (CellTag)cell.Tag;
            if (!tag.IsOpen)
            {
                var mines = CountMinesAroundCell(MaxCols, MaxCols, row, col);
                if (mines > 0)
                {
                    Cell.OpenSetMinesAround(ref cell, mines);
                    return;
                }
                else//cell with no mines around
                {
                    Cell.OpenSetMinesAround(ref cell, mines);

                    //recursion to check all cells around
                    CheckMinesAround(row - 1, col - 1);
                    CheckMinesAround(row - 1, col);
                    CheckMinesAround(row - 1, col + 1);
                    CheckMinesAround(row, col - 1);
                    CheckMinesAround(row, col + 1);
                    CheckMinesAround(row + 1, col - 1);
                    CheckMinesAround(row + 1, col);
                    CheckMinesAround(row + 1, col + 1);
                }
            }
        }
        

        //Count mines around cell
        public int CountMinesAroundCell(int rowMax, int colMax, int row, int col)
        {
            var mines = 0;

            var rowTop = row - 1;
            var rowBtm = row + 1;
            var colRight = col + 1;
            var colLeft = col - 1;

            //left top rowTop-colLeft
            if (Cell.IsValidCell(rowTop, colLeft, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(rowTop, colLeft);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //left row-colLeft
            if (Cell.IsValidCell(row, colLeft, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(row, colLeft);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //left bottom rowBtm-ColLeft 
            if (Cell.IsValidCell(rowBtm, colLeft, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(rowBtm, colLeft);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //mid top rowTop-col
            if (Cell.IsValidCell(rowTop, col, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(rowTop, col);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //mid bottom rowBtm-col
            if (Cell.IsValidCell(rowBtm, col, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(rowBtm, col);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //right top rowTop-colRight
            if (Cell.IsValidCell(rowTop, colRight, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(rowTop, colRight);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //right row-colRight
            if (Cell.IsValidCell(row, colRight, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(row, colRight);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            //right bottom rowBtm-colRight
            if (Cell.IsValidCell(rowBtm, colRight, rowMax, colMax))
            {
                var cell = GetCellByRowColumn(rowBtm, colRight);
                if (cell != null && Cell.IsMine(ref cell)) mines++;
            }

            return mines;
        }

    }
}