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
    public partial class frmRoom : Form
    {
        int CurrentRow = -1;

        public frmRoom()
        {
            InitializeComponent();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            DataAccess.LoadDatabaseRoomData();
            DisplayRoomDataOnGrid();
            PopulateCboColumnTitles();
        }

        private void PopulateCboColumnTitles()
        {
            try
            {
                foreach (DataColumn Column in DataAccess.dtRoom.Columns)
                {
                    cboCollumnTitles.Items.Add(Column.ColumnName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to populate search titles selection. " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                SaveData();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void SaveData()
        {
            DataRow r = DataAccess.dtRoom.NewRow();
            Room rm = new Room();
            if (UpdateClassWVerification(rm))
            {
                ImportClassValuesToDataRow(r, rm);

                DataAccess.dtRoom.Rows.Add(r);

                DataAccess.daRoom.Update(DataAccess.ds.Tables["Room"]);
            }
        }

        private bool UpdateClassWVerification(Room rm)
        {
            ErrP.Clear();
            bool ok = true;

            try
            {
                rm.RoomType = txtRoomType.Text;
            }
            catch (Exception ex)
            {
                ErrP.SetError(txtRoomType, ex.Message);
                ok = false;
            }

            try
            {
                rm.Capacity = Convert.ToUInt16(nudCapacity.Value);
            }
            catch (Exception ex)
            {
                ErrP.SetError(nudCapacity, ex.Message);
                ok = false;
            }

            try
            {
                rm.InUse = cbxInUse.Checked;
            }
            catch (Exception ex)
            {
                ErrP.SetError(cbxInUse, ex.Message);
                ok = false;
            }

            return ok;
        }

        private void ImportClassValuesToDataRow(DataRow r, Room rm)
        {
            r["RoomType"] = rm.RoomType;
            r["Capacity"] = rm.Capacity;
            r["InUse"] = rm.InUse;
        }

        private void DisplayRoomDataOnGrid()
        {
            try
            {
                DataAccess.LoadDatabaseRoomData();
                dgvRoom.DataSource = null;
                dgvRoom.DataSource = DataAccess.dtRoom;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvRoom.DataSource = Utilities.DataTableFilter("Room", cboCollumnTitles.Text, txtSearch.Text, "RoomNo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering database: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void cboCollumnTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableSearch();
        }

        private void EnableSearch()
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !string.IsNullOrEmpty(cboCollumnTitles.Text))
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayRoomDataOnGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Room rm = new Room();
                if (UpdateClassWVerification(rm))
                {
                    DataRow r = DataAccess.dtRoom.Rows.Find(CurrentRow);
                    ErrP.Clear();
                    ImportClassValuesToDataRow(r, rm);
                    DataAccess.daRoom.Update(DataAccess.ds.Tables["Room"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update data table.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }

        private void dgvRoom_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CurrentRow = int.Parse(dgvRoom.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (CurrentRow != -1)
                {
                    DisplayGridDataOnForm();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error connecting to database - contact your DB administrator. Was unable to retrieve data from selected datarow.\r\n\r\nAdditional information:\r\n" + ex.Message);
            }
        }

        private void DisplayGridDataOnForm()
        {
            try
            {
                txtRoomType.Text = DataAccess.dtRoom.Rows.Find(CurrentRow)["RoomType"].ToString();
                nudCapacity.Value = (int)DataAccess.dtRoom.Rows.Find(CurrentRow)["Capacity"];
                cbxInUse.Checked = (bool)DataAccess.dtRoom.Rows.Find(CurrentRow)["InUse"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoomType.Clear();
            nudCapacity.Value = 12;
            cbxInUse.Checked = false;
        }
    }
}
