namespace Mitchell_School_of_Music
{
    partial class frmLessonTimetable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlLessonDisplay = new System.Windows.Forms.Panel();
            this.ttDataDisplay = new System.Windows.Forms.ToolTip(this.components);
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // pnlLessonDisplay
            // 
            this.pnlLessonDisplay.AutoScroll = true;
            this.pnlLessonDisplay.Location = new System.Drawing.Point(9, 48);
            this.pnlLessonDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLessonDisplay.Name = "pnlLessonDisplay";
            this.pnlLessonDisplay.Size = new System.Drawing.Size(1168, 485);
            this.pnlLessonDisplay.TabIndex = 0;
            // 
            // dtpSearch
            // 
            this.dtpSearch.Location = new System.Drawing.Point(9, 10);
            this.dtpSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(151, 20);
            this.dtpSearch.TabIndex = 1;
            this.dtpSearch.Value = new System.DateTime(2016, 11, 29, 0, 0, 0, 0);
            this.dtpSearch.ValueChanged += new System.EventHandler(this.dtpSearch_ValueChanged);
            // 
            // frmLessonTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 543);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.pnlLessonDisplay);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLessonTimetable";
            this.Text = "Lesson Timetable";
            this.Load += new System.EventHandler(this.LessonTimetable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLessonDisplay;
        private System.Windows.Forms.ToolTip ttDataDisplay;
        private System.Windows.Forms.DateTimePicker dtpSearch;
    }
}