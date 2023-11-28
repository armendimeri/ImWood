using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImWood
{
    class Universal
    {
        public static FormKitchenAccessories projectAccessories;
        public static bool accessoriesShowed;

        public static FormKonstruktDimensions projectKonstruktDimensions;
        public static bool konstruktShowed;

        public static FormFrontDimensions projectFrontDimensions;
        public static bool frontShowed;

        public static FormLesonitDimensions projectLesonitDimensions;
        public static bool lesonitShowed;

        public static FormKonstruktDimensions projectFiokaDimensions;
        public static bool fiokaShowed;

        public static FormKonstruktDimensions projectPolicaDimensions;
        public static bool policaShowed;

        public static void CloseAll()
        {
           
        }


        public static Point Reposition(Form form)
        {
            form.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(form.Location))
                {
                    form.Location = new Point(scrn.Bounds.Right - form.Width, scrn.Bounds.Top);
                    return form.Location;
                }
                
            }
            return form.Location;
        }
    }
}
