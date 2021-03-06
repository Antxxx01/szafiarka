﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szafiarka.Classes
{
    class Panels : Panel
    {
        public enum PanelsName {
            PSTART, PSEARCH
        };

        private static List<Panels> PanelsList;
        
        public Panels()
        {
            Location = new System.Drawing.Point(110, 70);
            Size = new System.Drawing.Size(1060, 680);
            Visible = false;
        }

        public void initializePanels(Form form)
        {
            PanelsList = new List<Panels> {
                new PanelStart(),
                new PanelSearch(),
            };

            foreach (var panel in PanelsList)
            {
                form.Controls.Add(panel);
            };
        }

        public static void changePanelsVisableToFalse()
        {
            foreach (var item in PanelsList)
                item.Visible = false;
        }

        public static void changePanelVisableToTrue(PanelsName name)
        {
            var panel = PanelsList.Find(X => X.Name.ToUpper() == name.ToString("g"));
            panel.Visible = true;
        }
    }
}
