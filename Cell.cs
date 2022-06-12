using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public static class Cell
    {
        //format button name
        public static string GetCellName(int row, int col)
        {
            return $"c{row}-{col}";
        }

        public static bool IsValidCell(int row, int col, int maxRow, int maxCol)
        {
            // Returns true if row number and column number is in range
            return (row >= 0) && (row < maxRow) && (col >= 0) && (col < maxCol);
        }

        //initialize cell
        public static Button GetCell(int top, int left, int row, int col)
        {
            var cell = new Button();
            cell.Top = top;
            cell.Size = new System.Drawing.Size(20, 20);
            cell.Left = left;
            cell.Name = GetCellName(row, col);
            cell.Text = "";
            //
            cell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            cell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //cell.ImageAlign = ContentAlignment.MiddleCenter;
            cell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;

            var tag = new CellTag
            {
                Row = row,
                Column = col,
                IsOpen = false,
                IsMine = false,
                IsFlagged = false
            };

            cell.Tag = tag;

            return cell;
        }

        //set mine to cell
        public static void SetMine(ref Button cell, bool isVisible = false)
        {
            var tag = (CellTag)cell.Tag!;
            tag.IsMine = true;
            cell.Tag = tag;
            if (isVisible)//show mine
            {
                cell.BackgroundImage = Properties.Resources.boom16x16;
            }
        }

        //remove mine from cell
        public static void RemoveMine(ref Button cell)
        {
            var tag = (CellTag)cell.Tag!;
            tag.IsMine = false;
            cell.Tag = tag;
        }

        //check if is mine
        public static bool IsMine(ref Button cell)
        {
            var tag = (CellTag)cell.Tag!;
            return tag.IsMine;
        }

        //open cell and set value of mines around
        public static void OpenSetMinesAround(ref Button cell, int mines)
        {
            var tag = (CellTag)cell.Tag!;
            tag.IsOpen = true;
            tag.IsFlagged = false;
            tag.IsMine = false;
            cell.Tag = tag;
            //cell.Enabled = false;
            cell.BackColor = SystemColors.Control;
            cell.Image = null;
            cell.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            switch (mines)
            {
                case 0:
                    cell.Text = "";
                    break;
                case 1:
                    cell.BackgroundImage = Properties.Resources.num1;
                    break;
                case 2:
                    cell.BackgroundImage = Properties.Resources.num2;
                    break;
                case 3:
                    cell.BackgroundImage = Properties.Resources.num3;
                    break;
                case 4:
                    cell.BackgroundImage = Properties.Resources.num4;
                    break;
                case 5:
                    cell.BackgroundImage = Properties.Resources.num5;
                    break;
                case 6:
                    cell.BackgroundImage = Properties.Resources.num6;
                    break;
                case 7:
                    cell.BackgroundImage = Properties.Resources.num7;
                    break;
                case 8:
                    cell.BackgroundImage = Properties.Resources.num8;
                    break;
            }

        }

        //this.button3.Image = global::Minesweeper.Properties.Resources.flag16x16;

        //set flag on cell
        public static void SetFlag(ref Button cell)
        {
            var tag = (CellTag)cell.Tag!;
            tag.IsFlagged = true;
            cell.Tag = tag;
            cell.BackgroundImage = Properties.Resources.flag16x16;
        }

        //remove flag from cell
        public static void RemoveFlag(ref Button cell)
        {
            var tag = (CellTag)cell.Tag!;
            tag.IsFlagged = false;
            cell.Tag = tag;
            cell.BackgroundImage = null;
        }
    }

    public class CellTag
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsMine { get; set; }
        public bool IsOpen { get; set; }
        public bool IsFlagged { get; set; }

    }







}
