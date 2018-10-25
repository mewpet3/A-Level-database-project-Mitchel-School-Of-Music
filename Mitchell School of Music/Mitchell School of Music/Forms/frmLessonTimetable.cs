using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitchell_School_of_Music
{
    public partial class frmLessonTimetable : Form
    {
        public frmLessonTimetable()
        {
            InitializeComponent();
        }

        private void LessonTimetable_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseTimetabledLessonData();
            DataAccess.LoadDatabaseRoomData();
            dtpSearch.Value = DateTime.Now.Date;
        }

        private void PopulateTimetable(byte Periods)
        {
            if (Periods != 0)
            {
                pnlLessonDisplay.AutoScroll = true;
                PictureBox[,] pbxArray = new PictureBox[DataAccess.dtRoom.Rows.Count, Periods];
                Label[] lblArrayx = new Label[DataAccess.dtRoom.Rows.Count];
                Label[] lblArrayy = new Label[Periods];
                short tempx = 0;
                short CellHeight = (short)Math.Round((double)((pnlLessonDisplay.Height - 13) / Periods));
                if (Periods > 9)
                    for (byte tempy = 0; tempy < Periods; tempy++)
                    {
                        lblArrayy[tempy] = new Label();
                        lblArrayy[tempy].Text = (tempy + 1).ToString();
                        lblArrayy[tempy].AutoSize = false;
                        lblArrayy[tempy].Width = 20;
                        lblArrayy[tempy].Top = ((lblArrayy[0].Height + CellHeight * tempy) - (lblArrayy[0].Height / 2)) + CellHeight / 2;
                        lblArrayy[tempy].MouseHover += new EventHandler(Roomlbl_MouseHover);
                        pnlLessonDisplay.Controls.Add(lblArrayy[tempy]);
                    }
                else
                    for (byte tempy = 0; tempy < Periods; tempy++)
                    {
                        lblArrayy[tempy] = new Label();
                        lblArrayy[tempy].Text = (tempy + 1).ToString();
                        lblArrayy[tempy].AutoSize = true;
                        lblArrayy[tempy].Top = ((lblArrayy[0].Height + CellHeight * tempy) - (lblArrayy[0].Height / 2)) + CellHeight / 2;
                        lblArrayy[tempy].MouseHover += new EventHandler(Roomlbl_MouseHover);
                        pnlLessonDisplay.Controls.Add(lblArrayy[tempy]);
                    }
                foreach (DataRow rRoom in DataAccess.dtRoom.Rows)
                {
                    for (int tempy = 0; tempy < Periods; tempy++)
                    {
                        pbxArray[tempx, tempy] = new PictureBox();
                        pbxArray[tempx, tempy].Height = CellHeight;
                        pbxArray[tempx, tempy].Width = CellHeight * 2;
                        pbxArray[tempx, tempy].Top = lblArrayy[0].Height + (tempy * pbxArray[tempx, tempy].Height);
                        pbxArray[tempx, tempy].BorderStyle = BorderStyle.FixedSingle;
                        pbxArray[tempx, tempy].MouseHover += new EventHandler(pbxCell_MouseHover);
                        pbxArray[tempx, tempy].Left = (pbxArray[0, 0].Width * tempx) + lblArrayy[tempy].Width;
                        if ((bool)rRoom[3])
                        {
                            pbxArray[tempx, tempy].BackColor = Color.Red;
                            ttDataDisplay.Show("This room is unavilable.", pbxArray[tempx, tempy]);
                        }
                        else
                        {
                            CellData pbxData = new CellData(tempx + 1, (byte)(tempy + 1));
                            pbxArray[tempx, tempy].Tag = pbxData;
                            if (pbxData.FindAssociatedDataRow(dtpSearch.Value))
                            {
                                pbxArray[tempx, tempy].BackColor = Color.Yellow;
                            }
                            else
                            {
                                pbxArray[tempx, tempy].Click += new EventHandler(pbxCell_Click);
                                pbxArray[tempx, tempy].BackColor = Color.WhiteSmoke;
                            }
                        }
                        pnlLessonDisplay.Controls.Add(pbxArray[tempx, tempy]);
                    }
                    lblArrayx[tempx] = new Label();
                    lblArrayx[tempx].Text = rRoom[0].ToString() + " - " + rRoom[1].ToString();
                    lblArrayx[tempx].Tag = lblArrayx[tempx].Text;
                    lblArrayx[tempx].Left = pbxArray[tempx, 0].Left;
                    lblArrayx[tempx].AutoEllipsis = true;
                    lblArrayx[tempx].Width = pbxArray[tempx, 0].Width;
                    pnlLessonDisplay.Controls.Add(lblArrayx[tempx]);
                    tempx++;
                }
            }
            else
            {////Displaying weekend text
                pnlLessonDisplay.AutoScroll = false;
                Label lblWeekEnd = new Label();
                pnlLessonDisplay.Controls.Add(lblWeekEnd);
                lblWeekEnd.Text = "No lessons are available on weekends.";
                lblWeekEnd.AutoSize = true;
                lblWeekEnd.Font = new Font(FontFamily.GenericSansSerif, 40);
                lblWeekEnd.Left = (pnlLessonDisplay.Width / 2) - (lblWeekEnd.Width / 2);
                lblWeekEnd.Top = (pnlLessonDisplay.Height / 2) - (lblWeekEnd.Height / 2);
            }
        }

        private void UnpopulateTimetable()
        {
            pnlLessonDisplay.Controls.Clear();
        }

        private void pbxCell_Click(object sender, EventArgs e)
        {
            pbxCell_MouseHover(sender, e);
            PictureBox pbxSelected = sender as PictureBox;
            DialogResult deleteRecord = MessageBox.Show("Would you like to create a new lesson for this time starting from this date?", "Create new record", MessageBoxButtons.YesNo);
            if (deleteRecord == DialogResult.Yes)
            {
                frmTimetabledLesson newform = new frmTimetabledLesson(dtpSearch.Value, ((CellData)pbxSelected.Tag).RoomNo, ((CellData)pbxSelected.Tag).PeriodNo);
                newform.Show();
                this.Close();
            }
        }

        private void pbxCell_MouseHover(object sender, EventArgs e)
        {
            try
            {
                PictureBox pbxSelected = sender as PictureBox;
                if (pbxSelected.Tag != null)
                    ttDataDisplay.Show(((CellData)pbxSelected.Tag).ToString(), pbxSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not display data: " + ex.Message);
            }
        }

        private void Roomlbl_MouseHover(object sender, EventArgs e)
        {
            try
            {
                Label lblSelected = sender as Label;
                ttDataDisplay.Show(lblSelected.Tag.ToString(), lblSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No room data was stored within label: " + ex.Message);
            }
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            UnpopulateTimetable();
            byte Periods;
            if (dtpSearch.Value.DayOfWeek == DayOfWeek.Friday)
            {
                Periods = 8;
            }
            else if (dtpSearch.Value.DayOfWeek == DayOfWeek.Saturday || dtpSearch.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                Periods = 0;
            }
            else
            {
                Periods = 16;
            }
            PopulateTimetable(Periods);
        }
    }

    class CellData
    {
        private int roomNo;
        private byte periodNo;
        private DataRow associatedDataRow;

        public CellData(int RoomNo, byte PeriodNo)
        {
            roomNo = RoomNo;
            periodNo = PeriodNo;
        }

        public int RoomNo
        {
            get { return roomNo; }
        }
        public byte PeriodNo
        {
            get { return periodNo; }
        }
        public DataRow AssociatedDataRow
        {
            get { return associatedDataRow; }
        }

        public bool FindAssociatedDataRow(DateTime Date)
        {
            DataRow[] FoundDataRows = DataAccess.dtTimetabledLesson.Select("RoomNo = " + roomNo + " AND TimeLesson = " + periodNo + " AND DateLesson = '" + Date.Date.ToString() + "'");
            if (FoundDataRows.Count() == 1)
            {
                associatedDataRow = FoundDataRows[0];
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override string ToString()
        {
            if (associatedDataRow == null)
            {
                return "RoomNo: " + roomNo + ",\r\nPeriodNo: " + periodNo + ",\r\nThis session is not booked, click here to book a session for this day and time.";
            }
            else if (((DateTime)associatedDataRow["DateLesson"]).Date == DateTime.Now.Date)
            {
                string ReturnString = string.Empty;
                for (int CollumnNo = 0; CollumnNo < associatedDataRow.ItemArray.Count(); CollumnNo++)
                {
                    ReturnString += associatedDataRow.Table.Columns[CollumnNo].ColumnName + ": " + associatedDataRow[CollumnNo].ToString() + "\r\n";
                }
                return ReturnString;
            }
            else
            {
                string ReturnString = string.Empty;
                for (int CollumnNo = 0; CollumnNo < associatedDataRow.ItemArray.Count()-3; CollumnNo++)
                {
                    ReturnString += associatedDataRow.Table.Columns[CollumnNo].ColumnName + ": " + associatedDataRow[CollumnNo].ToString() + "\r\n";
                }
                return ReturnString;
            }
        }
    }
}