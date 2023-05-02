namespace Ticket_Reservation_System.CustomControls
{
    partial class CustomDataGridView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            customDataGrid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            birthday = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(customDataGrid);
            panel1.Location = new Point(12, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 450);
            panel1.TabIndex = 0;
            // 
            // customDataGrid
            // 
            customDataGrid.AllowUserToAddRows = false;
            customDataGrid.AllowUserToDeleteRows = false;
            customDataGrid.AllowUserToResizeColumns = false;
            customDataGrid.AllowUserToResizeRows = false;
            customDataGrid.BackgroundColor = Color.White;
            customDataGrid.BorderStyle = BorderStyle.None;
            customDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            customDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(152, 155, 242);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(152, 155, 242);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customDataGrid.ColumnHeadersHeight = 50;
            customDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            customDataGrid.Columns.AddRange(new DataGridViewColumn[] { id, fullName, email, phoneNumber, gender, birthday });
            customDataGrid.Dock = DockStyle.Fill;
            customDataGrid.EnableHeadersVisualStyles = false;
            customDataGrid.GridColor = Color.Silver;
            customDataGrid.Location = new Point(0, 0);
            customDataGrid.Margin = new Padding(0);
            customDataGrid.MultiSelect = false;
            customDataGrid.Name = "customDataGrid";
            customDataGrid.ReadOnly = true;
            customDataGrid.RowHeadersVisible = false;
            customDataGrid.RowHeadersWidth = 40;
            customDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            customDataGrid.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            customDataGrid.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            customDataGrid.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            customDataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
            customDataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            customDataGrid.RowTemplate.Height = 40;
            customDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customDataGrid.Size = new Size(746, 450);
            customDataGrid.TabIndex = 0;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.FillWeight = 50F;
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // fullName
            // 
            fullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullName.FillWeight = 150F;
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.FillWeight = 150F;
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneNumber.FillWeight = 120F;
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            // 
            // gender
            // 
            gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gender.FillWeight = 60F;
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // birthday
            // 
            birthday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            birthday.HeaderText = "Birthday";
            birthday.Name = "birthday";
            birthday.ReadOnly = true;
            // 
            // CustomDataGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 530);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomDataGridView";
            Text = "CustomDataGridView";
            Load += CustomDataGridView_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView customDataGrid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn birthday;
    }
}