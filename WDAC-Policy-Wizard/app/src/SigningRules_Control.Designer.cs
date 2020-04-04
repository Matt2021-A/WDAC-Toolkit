﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// jogeurte 11/19

namespace WDAC_Wizard
{
    partial class SigningRules_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label_AddCustomRules = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.column_Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Exceptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(202, 398);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 28);
            this.label7.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "Policy Signing Rules";
            // 
            // rulesDataGrid
            // 
            this.rulesDataGrid.AllowUserToDeleteRows = false;
            this.rulesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.rulesDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.rulesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Action,
            this.column_Level,
            this.Column_Name,
            this.Column_Files,
            this.Column_Exceptions});
            this.rulesDataGrid.Location = new System.Drawing.Point(195, 194);
            this.rulesDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rulesDataGrid.Name = "rulesDataGrid";
            this.rulesDataGrid.ReadOnly = true;
            this.rulesDataGrid.RowHeadersVisible = false;
            this.rulesDataGrid.RowHeadersWidth = 150;
            this.rulesDataGrid.RowTemplate.Height = 24;
            this.rulesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.rulesDataGrid.Size = new System.Drawing.Size(875, 528);
            this.rulesDataGrid.TabIndex = 92;
            this.rulesDataGrid.VirtualMode = true;
            this.rulesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataClicked);
            this.rulesDataGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.rulesDataGrid_CellValueNeeded);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(196, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 30);
            this.label8.TabIndex = 91;
            this.label8.Text = "Policy Signing Rules List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_AddCustomRules
            // 
            this.label_AddCustomRules.AutoSize = true;
            this.label_AddCustomRules.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddCustomRules.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_AddCustomRules.Location = new System.Drawing.Point(905, 156);
            this.label_AddCustomRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AddCustomRules.Name = "label_AddCustomRules";
            this.label_AddCustomRules.Size = new System.Drawing.Size(165, 30);
            this.label_AddCustomRules.TabIndex = 92;
            this.label_AddCustomRules.Text = "+ Custom Rules";
            this.label_AddCustomRules.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_AddCustomRules.Click += new System.EventHandler(this.label_AddCustomRules_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(191, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(677, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Create allow or deny rules for signed files based on its publisher, path or hash " +
    "value.";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(191, 745);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(98, 25);
            this.label_Error.TabIndex = 96;
            this.label_Error.Text = "Label_Error";
            this.label_Error.Visible = false;
            // 
            // column_Action
            // 
            this.column_Action.HeaderText = "Action";
            this.column_Action.MinimumWidth = 90;
            this.column_Action.Name = "column_Action";
            this.column_Action.ReadOnly = true;
            this.column_Action.Width = 90;
            // 
            // column_Level
            // 
            this.column_Level.HeaderText = "Level";
            this.column_Level.MinimumWidth = 110;
            this.column_Level.Name = "column_Level";
            this.column_Level.ReadOnly = true;
            this.column_Level.Width = 110;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.MinimumWidth = 200;
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.ReadOnly = true;
            this.Column_Name.Width = 200;
            // 
            // Column_Files
            // 
            this.Column_Files.HeaderText = "Associated Files";
            this.Column_Files.MinimumWidth = 200;
            this.Column_Files.Name = "Column_Files";
            this.Column_Files.ReadOnly = true;
            this.Column_Files.Width = 200;
            // 
            // Column_Exceptions
            // 
            this.Column_Exceptions.HeaderText = "Exceptions";
            this.Column_Exceptions.MinimumWidth = 200;
            this.Column_Exceptions.Name = "Column_Exceptions";
            this.Column_Exceptions.ReadOnly = true;
            this.Column_Exceptions.Width = 200;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Image = global::WDAC_Wizard.Properties.Resources.minus;
            this.deleteButton.Location = new System.Drawing.Point(1008, 728);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(62, 50);
            this.deleteButton.TabIndex = 93;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // SigningRules_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label_AddCustomRules);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rulesDataGrid);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SigningRules_Control";
            this.Size = new System.Drawing.Size(1444, 870);
            this.Load += new System.EventHandler(this.SigningRules_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView rulesDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_AddCustomRules;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Exceptions;
    }
}
