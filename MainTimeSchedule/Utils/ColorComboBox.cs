using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;

namespace MainTimeSchedule.Utils
{
    public partial class ColorComboBox : ComboBox
    {
        public Hashtable itemMapIndex = new Hashtable();
        public ColorComboBox()
        {
            FillColors();

            // Change DrawMode for custom drawing
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FillColors()
        {
            this.Items.Clear();

            // Fill Colors using Reflection
            foreach (Color color in typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public).Where(c => c.PropertyType == typeof(Color)).Select(c => (Color)c.GetValue(c, null)))
            {
                if (color == Color.Black || color == Color.White || color == Color.Transparent) continue;
                int index = this.Items.Add(color);
                itemMapIndex.Add(color.Name, index);
            }
            this.SelectedIndex = 0;
        }

        /// <summary>
        /// Override Draw Method
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Color color = (Color)this.Items[e.Index];

                int nextX = 0;

                e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
                DrawColor(e, color, ref nextX);
                DrawText(e, color, nextX);
            }
            else
                base.OnDrawItem(e);
        }

        /// <summary>
        /// Draw the Color rectangle filled with item color
        /// </summary>
        /// <param name="e"></param>
        /// <param name="color"></param>
        /// <param name="nextX"></param>
        private void DrawColor(DrawItemEventArgs e, Color color, ref int nextX)
        {
            int width = e.Bounds.Height * 2 - 8;
            Rectangle rectangle = new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 3, width, e.Bounds.Height - 6);
            e.Graphics.FillRectangle(new SolidBrush(color), rectangle);

            nextX = width + 8;
        }

        /// <summary>
        /// Draw the color name next to the color rectangle
        /// </summary>
        /// <param name="e"></param>
        /// <param name="color"></param>
        /// <param name="nextX"></param>
        private void DrawText(DrawItemEventArgs e, Color color, int nextX)
        {
            e.Graphics.DrawString(color.Name, e.Font, new SolidBrush(e.ForeColor), new PointF(nextX, e.Bounds.Y + (e.Bounds.Height - e.Font.Height) / 2));
        }

        /// <summary>
        /// Gets/sets the selected color of ComboBox
        /// (Default color is Black)
        /// </summary>
        public Color Color
        {
            get
            {
                if (this.SelectedItem != null)
                    return (Color)this.SelectedItem;

                return Color.AliceBlue;
            }
            set
            {
                int ix = this.Items.IndexOf(value);
                if (ix >= 0)
                    this.SelectedIndex = ix;
            }
        }
    }
}
