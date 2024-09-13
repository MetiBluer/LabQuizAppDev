
namespace _046_TolentinoBulalayao_FranceszDave_L3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.saveText = new System.Windows.Forms.SaveFileDialog();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.lbldep = new System.Windows.Forms.Label();
            this.cboLoad = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveRec = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.openText = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelFIleToolStripMenuItem,
            this.textFileToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // excelFIleToolStripMenuItem
            // 
            this.excelFIleToolStripMenuItem.Name = "excelFIleToolStripMenuItem";
            this.excelFIleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excelFIleToolStripMenuItem.Text = "Excel FIle";
            this.excelFIleToolStripMenuItem.Click += new System.EventHandler(this.excelFIleToolStripMenuItem_Click);
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textFileToolStripMenuItem.Text = "Text File";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(13, 52);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(16, 68);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(140, 20);
            this.txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(16, 122);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(140, 20);
            this.txtLname.TabIndex = 4;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(13, 106);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 3;
            this.lblLname.Text = "Last Name";
            // 
            // lbldep
            // 
            this.lbldep.AutoSize = true;
            this.lbldep.Location = new System.Drawing.Point(13, 159);
            this.lbldep.Name = "lbldep";
            this.lbldep.Size = new System.Drawing.Size(62, 13);
            this.lbldep.TabIndex = 5;
            this.lbldep.Text = "Department";
            // 
            // cboLoad
            // 
            this.cboLoad.FormattingEnabled = true;
            this.cboLoad.Location = new System.Drawing.Point(16, 187);
            this.cboLoad.Name = "cboLoad";
            this.cboLoad.Size = new System.Drawing.Size(167, 21);
            this.cboLoad.TabIndex = 6;
            this.cboLoad.SelectedIndexChanged += new System.EventHandler(this.cboLoad_SelectedIndexChanged);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(204, 27);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(443, 280);
            this.dgvData.TabIndex = 7;
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(16, 248);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 23);
            this.btnAddList.TabIndex = 8;
            this.btnAddList.Text = "Add to List";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveRec
            // 
            this.btnSaveRec.Location = new System.Drawing.Point(424, 331);
            this.btnSaveRec.Name = "btnSaveRec";
            this.btnSaveRec.Size = new System.Drawing.Size(99, 23);
            this.btnSaveRec.TabIndex = 11;
            this.btnSaveRec.Text = "Save Records";
            this.btnSaveRec.UseVisualStyleBackColor = true;
            this.btnSaveRec.Click += new System.EventHandler(this.btnSaveRec_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(548, 331);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // openText
            // 
            this.openText.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 391);
            this.Controls.Add(this.btnSaveRec);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.cboLoad);
            this.Controls.Add(this.lbldep);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog saveText;
        private System.Windows.Forms.ToolStripMenuItem excelFIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lbldep;
        private System.Windows.Forms.ComboBox cboLoad;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveRec;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.OpenFileDialog openText;
    }
}

