﻿namespace Szafiarka
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent(RetrievingAssemblyData assemblyData)
        {
            this.pMenu = new Classes.PanelMenu();
            this.bTools = new Szafiarka.Classes.ToolsButton();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitializeMenuButtons
            // 
            var menuButton = new Classes.MenuButton();
            menuButton.InitializeMenuButtons(this, this.pMenu);
            //
            // InitializePanels
            //
            var panels = new Classes.Panels();
            panels.initializePanels(this);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 766);
            this.Controls.Add(this.bTools);
            this.Controls.Add(this.pMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = assemblyData.AssemblyTitle;
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Classes.PanelMenu pMenu;
        private Classes.ToolsButton bTools;
    }
}

