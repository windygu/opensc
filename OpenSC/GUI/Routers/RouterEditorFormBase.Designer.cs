﻿namespace OpenSC.GUI.Routers
{
    partial class RouterEditorFormBase
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
            this.baseDataPanel = new System.Windows.Forms.Panel();
            this.baseDataGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idNumericField = new System.Windows.Forms.NumericUpDown();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.baseDataTabPage = new System.Windows.Forms.TabPage();
            this.inputsTabPage = new System.Windows.Forms.TabPage();
            this.inputsTableContainerPanel = new System.Windows.Forms.Panel();
            this.inputsTable = new System.Windows.Forms.DataGridView();
            this.inputsButtonsPanel = new System.Windows.Forms.Panel();
            this.addInputButton = new System.Windows.Forms.Button();
            this.outputsTabPage = new System.Windows.Forms.TabPage();
            this.outputsTableContainerPanel = new System.Windows.Forms.Panel();
            this.outputsTable = new System.Windows.Forms.DataGridView();
            this.outputsButtonsPanel = new System.Windows.Forms.Panel();
            this.addOutputButton = new System.Windows.Forms.Button();
            this.customElementsPanel.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.baseDataPanel.SuspendLayout();
            this.baseDataGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericField)).BeginInit();
            this.tabControl.SuspendLayout();
            this.baseDataTabPage.SuspendLayout();
            this.inputsTabPage.SuspendLayout();
            this.inputsTableContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputsTable)).BeginInit();
            this.inputsButtonsPanel.SuspendLayout();
            this.outputsTabPage.SuspendLayout();
            this.outputsTableContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputsTable)).BeginInit();
            this.outputsButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customElementsPanel
            // 
            this.customElementsPanel.Controls.Add(this.tabControl);
            this.customElementsPanel.Size = new System.Drawing.Size(1082, 428);
            // 
            // mainContainer
            // 
            this.mainContainer.Size = new System.Drawing.Size(1082, 497);
            // 
            // baseDataPanel
            // 
            this.baseDataPanel.AutoSize = true;
            this.baseDataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseDataPanel.Controls.Add(this.baseDataGroupBox);
            this.baseDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseDataPanel.Location = new System.Drawing.Point(3, 3);
            this.baseDataPanel.Name = "baseDataPanel";
            this.baseDataPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.baseDataPanel.Size = new System.Drawing.Size(948, 94);
            this.baseDataPanel.TabIndex = 0;
            // 
            // baseDataGroupBox
            // 
            this.baseDataGroupBox.AutoSize = true;
            this.baseDataGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baseDataGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.baseDataGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.baseDataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.baseDataGroupBox.Name = "baseDataGroupBox";
            this.baseDataGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.baseDataGroupBox.Size = new System.Drawing.Size(948, 87);
            this.baseDataGroupBox.TabIndex = 0;
            this.baseDataGroupBox.TabStop = false;
            this.baseDataGroupBox.Text = "Base data";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.idNumericField, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 56);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Location = new System.Drawing.Point(3, 0);
            this.idLabel.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 28);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.Location = new System.Drawing.Point(3, 28);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 28);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Location = new System.Drawing.Point(70, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(859, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // idNumericField
            // 
            this.idNumericField.Location = new System.Drawing.Point(70, 3);
            this.idNumericField.Name = "idNumericField";
            this.idNumericField.Size = new System.Drawing.Size(120, 22);
            this.idNumericField.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.baseDataTabPage);
            this.tabControl.Controls.Add(this.inputsTabPage);
            this.tabControl.Controls.Add(this.outputsTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1062, 418);
            this.tabControl.TabIndex = 1;
            // 
            // baseDataTabPage
            // 
            this.baseDataTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.baseDataTabPage.Controls.Add(this.baseDataPanel);
            this.baseDataTabPage.Location = new System.Drawing.Point(4, 25);
            this.baseDataTabPage.Name = "baseDataTabPage";
            this.baseDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.baseDataTabPage.Size = new System.Drawing.Size(954, 389);
            this.baseDataTabPage.TabIndex = 0;
            this.baseDataTabPage.Text = "Base data";
            // 
            // inputsTabPage
            // 
            this.inputsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.inputsTabPage.Controls.Add(this.inputsTableContainerPanel);
            this.inputsTabPage.Controls.Add(this.inputsButtonsPanel);
            this.inputsTabPage.Location = new System.Drawing.Point(4, 25);
            this.inputsTabPage.Name = "inputsTabPage";
            this.inputsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inputsTabPage.Size = new System.Drawing.Size(1054, 389);
            this.inputsTabPage.TabIndex = 1;
            this.inputsTabPage.Text = "Inputs";
            // 
            // inputsTableContainerPanel
            // 
            this.inputsTableContainerPanel.Controls.Add(this.inputsTable);
            this.inputsTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsTableContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.inputsTableContainerPanel.Name = "inputsTableContainerPanel";
            this.inputsTableContainerPanel.Size = new System.Drawing.Size(1048, 339);
            this.inputsTableContainerPanel.TabIndex = 2;
            // 
            // inputsTable
            // 
            this.inputsTable.AllowUserToAddRows = false;
            this.inputsTable.AllowUserToDeleteRows = false;
            this.inputsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsTable.Location = new System.Drawing.Point(0, 0);
            this.inputsTable.Name = "inputsTable";
            this.inputsTable.ReadOnly = true;
            this.inputsTable.RowHeadersWidth = 51;
            this.inputsTable.RowTemplate.Height = 24;
            this.inputsTable.Size = new System.Drawing.Size(1048, 339);
            this.inputsTable.TabIndex = 0;
            // 
            // inputsButtonsPanel
            // 
            this.inputsButtonsPanel.Controls.Add(this.addInputButton);
            this.inputsButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputsButtonsPanel.Location = new System.Drawing.Point(3, 342);
            this.inputsButtonsPanel.Name = "inputsButtonsPanel";
            this.inputsButtonsPanel.Size = new System.Drawing.Size(1048, 44);
            this.inputsButtonsPanel.TabIndex = 1;
            // 
            // addInputButton
            // 
            this.addInputButton.Location = new System.Drawing.Point(6, 6);
            this.addInputButton.Margin = new System.Windows.Forms.Padding(6);
            this.addInputButton.Name = "addInputButton";
            this.addInputButton.Size = new System.Drawing.Size(126, 26);
            this.addInputButton.TabIndex = 0;
            this.addInputButton.Text = "Add input";
            this.addInputButton.UseVisualStyleBackColor = true;
            this.addInputButton.Click += new System.EventHandler(this.addInputButton_Click);
            // 
            // outputsTabPage
            // 
            this.outputsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.outputsTabPage.Controls.Add(this.outputsTableContainerPanel);
            this.outputsTabPage.Controls.Add(this.outputsButtonsPanel);
            this.outputsTabPage.Location = new System.Drawing.Point(4, 25);
            this.outputsTabPage.Name = "outputsTabPage";
            this.outputsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outputsTabPage.Size = new System.Drawing.Size(490, 229);
            this.outputsTabPage.TabIndex = 2;
            this.outputsTabPage.Text = "Outputs";
            // 
            // outputsTableContainerPanel
            // 
            this.outputsTableContainerPanel.Controls.Add(this.outputsTable);
            this.outputsTableContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputsTableContainerPanel.Location = new System.Drawing.Point(3, 3);
            this.outputsTableContainerPanel.Name = "outputsTableContainerPanel";
            this.outputsTableContainerPanel.Size = new System.Drawing.Size(484, 179);
            this.outputsTableContainerPanel.TabIndex = 2;
            // 
            // outputsTable
            // 
            this.outputsTable.AllowUserToAddRows = false;
            this.outputsTable.AllowUserToDeleteRows = false;
            this.outputsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputsTable.Location = new System.Drawing.Point(0, 0);
            this.outputsTable.Name = "outputsTable";
            this.outputsTable.ReadOnly = true;
            this.outputsTable.RowHeadersWidth = 51;
            this.outputsTable.RowTemplate.Height = 24;
            this.outputsTable.Size = new System.Drawing.Size(484, 179);
            this.outputsTable.TabIndex = 0;
            // 
            // outputsButtonsPanel
            // 
            this.outputsButtonsPanel.Controls.Add(this.addOutputButton);
            this.outputsButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputsButtonsPanel.Location = new System.Drawing.Point(3, 182);
            this.outputsButtonsPanel.Name = "outputsButtonsPanel";
            this.outputsButtonsPanel.Size = new System.Drawing.Size(484, 44);
            this.outputsButtonsPanel.TabIndex = 1;
            // 
            // addOutputButton
            // 
            this.addOutputButton.Location = new System.Drawing.Point(6, 6);
            this.addOutputButton.Margin = new System.Windows.Forms.Padding(6);
            this.addOutputButton.Name = "addOutputButton";
            this.addOutputButton.Size = new System.Drawing.Size(126, 26);
            this.addOutputButton.TabIndex = 0;
            this.addOutputButton.Text = "Add output";
            this.addOutputButton.UseVisualStyleBackColor = true;
            this.addOutputButton.Click += new System.EventHandler(this.addOutputButton_Click);
            // 
            // RouterEditorFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.DeleteButtonVisible = true;
            this.HeaderText = "Edit router";
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "RouterEditorFormBase";
            this.Text = "Edit router";
            this.customElementsPanel.ResumeLayout(false);
            this.mainContainer.ResumeLayout(false);
            this.baseDataPanel.ResumeLayout(false);
            this.baseDataPanel.PerformLayout();
            this.baseDataGroupBox.ResumeLayout(false);
            this.baseDataGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericField)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.baseDataTabPage.ResumeLayout(false);
            this.baseDataTabPage.PerformLayout();
            this.inputsTabPage.ResumeLayout(false);
            this.inputsTableContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputsTable)).EndInit();
            this.inputsButtonsPanel.ResumeLayout(false);
            this.outputsTabPage.ResumeLayout(false);
            this.outputsTableContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputsTable)).EndInit();
            this.outputsButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel baseDataPanel;
        private System.Windows.Forms.GroupBox baseDataGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown idNumericField;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inputsTabPage;
        private System.Windows.Forms.DataGridView inputsTable;
        private System.Windows.Forms.Button addInputButton;
        private System.Windows.Forms.TabPage outputsTabPage;
        private System.Windows.Forms.DataGridView outputsTable;
        private System.Windows.Forms.Button addOutputButton;
        private System.Windows.Forms.Panel outputsTableContainerPanel;
        private System.Windows.Forms.Panel inputsTableContainerPanel;
        protected System.Windows.Forms.TabPage baseDataTabPage;
        protected System.Windows.Forms.Panel inputsButtonsPanel;
        protected System.Windows.Forms.Panel outputsButtonsPanel;
    }
}