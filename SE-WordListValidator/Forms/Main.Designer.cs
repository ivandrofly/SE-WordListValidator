﻿/*
    Copyright © 2015 Waldi Ravens

    This file is part of SE-WordListValidator.

    SE-WordListValidator is free software: you can redistribute it
    and/or modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation, either version 3 of
    the License, or (at your option) any later version.

    SE-WordListValidator is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with SE-WordListValidator.  If not, see <http://www.gnu.org/licenses/>.
*/
namespace SubtitleEditWordListValidator
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("OCRFixReplace");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("NoBreakAfter");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("NamesEtc");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("User");
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.treeViewWordLists = new System.Windows.Forms.TreeView();
            this.textBoxTerminal = new System.Windows.Forms.TextBox();
            this.contextMenuStripWordLists = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemWordListsValidate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWordListsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWordListsSubmit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWordListsAcceopt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWordListsReject = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.contextMenuStripWordLists.SuspendLayout();
            this.SuspendLayout();
            //
            // splitContainerMain
            //
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            //
            // splitContainerMain.Panel1
            //
            this.splitContainerMain.Panel1.Controls.Add(this.treeViewWordLists);
            this.splitContainerMain.Panel1MinSize = 111;
            //
            // splitContainerMain.Panel2
            //
            this.splitContainerMain.Panel2.Controls.Add(this.textBoxTerminal);
            this.splitContainerMain.Panel2MinSize = 333;
            this.splitContainerMain.Size = new System.Drawing.Size(800, 600);
            this.splitContainerMain.SplitterDistance = 181;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 0;
            //
            // treeViewWordLists
            //
            this.treeViewWordLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewWordLists.ItemHeight = 20;
            this.treeViewWordLists.Location = new System.Drawing.Point(0, 0);
            this.treeViewWordLists.Name = "treeViewWordLists";
            treeNode5.Name = "NodeOCRFix";
            treeNode5.Text = "OCRFixReplace";
            treeNode6.Name = "NodeNoBreak";
            treeNode6.Text = "NoBreakAfter";
            treeNode7.Name = "NodeNames";
            treeNode7.Text = "NamesEtc";
            treeNode8.Name = "NodeUser";
            treeNode8.Text = "User";
            this.treeViewWordLists.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeViewWordLists.Size = new System.Drawing.Size(181, 600);
            this.treeViewWordLists.TabIndex = 0;
            this.treeViewWordLists.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewWordLists_NodeMouseDoubleClick);
            //
            // textBoxTerminal
            //
            this.textBoxTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTerminal.Location = new System.Drawing.Point(0, 0);
            this.textBoxTerminal.Multiline = true;
            this.textBoxTerminal.Name = "textBoxTerminal";
            this.textBoxTerminal.ReadOnly = true;
            this.textBoxTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxTerminal.Size = new System.Drawing.Size(616, 600);
            this.textBoxTerminal.TabIndex = 0;
            this.textBoxTerminal.WordWrap = false;
            this.textBoxTerminal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TextBoxTerminal_MouseDoubleClick);
            //
            // contextMenuStripWordLists
            //
            this.contextMenuStripWordLists.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWordListsValidate,
            this.toolStripMenuItemWordListsEdit,
            this.toolStripMenuItemWordListsSubmit,
            this.toolStripMenuItemWordListsAcceopt,
            this.toolStripMenuItemWordListsReject});
            this.contextMenuStripWordLists.Name = "contextMenuStripWordLists";
            this.contextMenuStripWordLists.ShowImageMargin = false;
            this.contextMenuStripWordLists.Size = new System.Drawing.Size(92, 114);
            //
            // toolStripMenuItemWordListsValidate
            //
            this.toolStripMenuItemWordListsValidate.Name = "toolStripMenuItemWordListsValidate";
            this.toolStripMenuItemWordListsValidate.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItemWordListsValidate.Text = "Validate";
            this.toolStripMenuItemWordListsValidate.Click += new System.EventHandler(this.ToolStripMenuItemWordListsValidate_Click);
            //
            // toolStripMenuItemWordListsEdit
            //
            this.toolStripMenuItemWordListsEdit.Name = "toolStripMenuItemWordListsEdit";
            this.toolStripMenuItemWordListsEdit.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItemWordListsEdit.Text = "Edit";
            this.toolStripMenuItemWordListsEdit.Click += new System.EventHandler(this.ToolStripMenuItemWordListsEdit_Click);
            //
            // toolStripMenuItemWordListsSubmit
            //
            this.toolStripMenuItemWordListsSubmit.Name = "toolStripMenuItemWordListsSubmit";
            this.toolStripMenuItemWordListsSubmit.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItemWordListsSubmit.Text = "Submit";
            this.toolStripMenuItemWordListsSubmit.Click += new System.EventHandler(this.ToolStripMenuItemWordListsSubmit_Click);
            //
            // toolStripMenuItemWordListsAcceopt
            //
            this.toolStripMenuItemWordListsAcceopt.Name = "toolStripMenuItemWordListsAcceopt";
            this.toolStripMenuItemWordListsAcceopt.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItemWordListsAcceopt.Text = "Accept";
            this.toolStripMenuItemWordListsAcceopt.Click += new System.EventHandler(this.ToolStripMenuItemWordListsAcceopt_Click);
            //
            // toolStripMenuItemWordListsReject
            //
            this.toolStripMenuItemWordListsReject.Name = "toolStripMenuItemWordListsReject";
            this.toolStripMenuItemWordListsReject.Size = new System.Drawing.Size(91, 22);
            this.toolStripMenuItemWordListsReject.Text = "Reject";
            this.toolStripMenuItemWordListsReject.Click += new System.EventHandler(this.ToolStripMenuItemWordListsReject_Click);
            //
            // Main
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(416, 338);
            this.Name = "Main";
            this.Text = "Update Subtitle Edit word lists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.contextMenuStripWordLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TreeView treeViewWordLists;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWordLists;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWordListsValidate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWordListsEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWordListsSubmit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWordListsAcceopt;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWordListsReject;
        private System.Windows.Forms.TextBox textBoxTerminal;
    }
}
