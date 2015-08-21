//***********************************************
// Author:      Anthony Nguyen
// Date:        4/26/2015
// Description: This is a paint application
//***********************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace PaintAppWinForm
{
    public partial class formLab3 : Form
    {
        // used to flag if mouse is held down
        bool draw = false;
        // pen used for drawing
        Pen mainPen = new Pen(Color.Black);
        // used for keeping track of positioning
        Point pt1 = new Point();
        Point pt2 = new Point();
        Point pt3 = new Point();
        Point pt4 = new Point();
        Point pt5 = new Point();
        Point pt6 = new Point();
        // used to keep track of clicks for bezier
        Point[] bezierPoints = new Point[4];
        int count = 0;
        // main graphics
        Graphics g;
        // main image
        Image img;

        public formLab3()
        {
            InitializeComponent();
            g = pbDraw.CreateGraphics();
            img = new Bitmap(pbDraw.Width, pbDraw.Height, g);
            g = Graphics.FromImage(img);
        }

        /// <summary>
        /// Click events for top menu items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void topMenu_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            switch (lbl.Text)
            {
                // when View is clicked, change attributes accordingly
                case "View":
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    imageMenu.BorderStyle = BorderStyle.None;
                    pnlViewMenu.Visible = true;
                    pnlImageMenu.Visible = false;
                    g = Graphics.FromImage(img);
                    break;
                // when Image is clicked, change attributes accordingly
                case "Image":
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    viewMenu.BorderStyle = BorderStyle.None;
                    pnlViewMenu.Visible = false;
                    pnlImageMenu.Visible = true;
                    imgSelect.BorderStyle = BorderStyle.None;
                    imgBrush.BorderStyle = BorderStyle.None;
                    imgPencil.BorderStyle = BorderStyle.None;
                    imgText.BorderStyle = BorderStyle.None;
                    imgLines.BorderStyle = BorderStyle.None;
                    break;
                // for entering text
                case "Submit":
                    if (tsStatusBar.Text == "Text")
                    {
                        g.DrawString(tbText.Text, tbText.Font, mainPen.Brush, pt1);
                        pbDraw.Image = img;
                    }
                    break;
                case "Clear":
                    // remove the image
                    if (pbDraw.Image != null)
                    {
                        pbDraw.Image.Dispose();
                        // reset the graphics and image
                        g = pbDraw.CreateGraphics();
                        img = new Bitmap(pbDraw.Width, pbDraw.Height, g);
                        g = Graphics.FromImage(img);
                        // message indicating the mechanics
                        MessageBox.Show("Begin drawing and image will clear");
                    }
                    break;
                // save image to desired location
                case "Save":
                    // create new save file dialog
                    SaveFileDialog s = new SaveFileDialog();

                    // create a new bitmap of the drawing
                    Bitmap bmp = new Bitmap(pbDraw.Width, pbDraw.Height);
                    g = Graphics.FromImage(bmp);

                    // copy the image 
                    Rectangle rect = pbDraw.RectangleToScreen(pbDraw.ClientRectangle);
                    g.CopyFromScreen(rect.Location, Point.Empty, pbDraw.Size);
                    g.Dispose();

                    // adding this saves a few lines, requires a namespace
                    ImageFormat format = ImageFormat.Png;
                    s.Filter = "Images|*.png; *.jpg; *.bmp";

                    // get the file extension
                    string extension = System.IO.Path.GetExtension(s.FileName);

                    // check if save dialog opened
                    if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        switch (extension)
                        {
                            case ".jpg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                        }
                        // save file to specified format
                        bmp.Save(s.FileName, format);
                    }
                    break;
                // when Color is clicked, display color dialog
                case "Color":
                    colorDialog.ShowDialog();
                    break;
            }
        }

        /// <summary>
        /// Applies border to top menu item when mouse down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickMenu_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BorderStyle = BorderStyle.Fixed3D;
        }

        /// <summary>
        /// Removes border from top menu item when mouse up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickMenu_MouseUp(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Not sure if this is necessary, but adds a tooltip when mouse hovers.
        /// It might be in the properties window, but I'll leave this for now
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconMenu_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            PictureBox img = sender as PictureBox;

            switch (img.Name)
            {
                case "imgSelect":
                    tt.SetToolTip(img, "Rectangular Select\nSelect part of the image");
                    break;
                case "imgBrush":
                    tt.SetToolTip(img, "Brush\nDraw with a fat width");
                    break;
                case "imgPencil":
                    tt.SetToolTip(img, "Pencil\nDraw with thin width");
                    break;
                case "imgLines":
                    tt.SetToolTip(img, "Lines\nDraw lines, curves, rectangles, polygons and ellipses");
                    break;
                case "imgText":
                    tt.SetToolTip(img, "Text\nCreate a text box to write");
                    break;
                case "imgEraser":
                    tt.SetToolTip(img, "Eraser\nUse the cursor to erase portions of your image");
                    break;
                case "imgFlipVert":
                    tt.SetToolTip(img, "Flip vertically\nFlip your image according to a horizontal line of symmetry");
                    break;
                case "imgFlipHoriz":
                    tt.SetToolTip(img, "Flip horizontally\nFlip your image according to a vertical line of symmetry");
                    break;
                case "imgRotate90":
                    tt.SetToolTip(img, "Rotate\nRotate your image clockwise in 90° intervals");
                    break;
            }
        }

        /// <summary>
        /// When icons are selected, change border, status bar text, and possibly change cursor;
        /// if selected, other selected icon must be have its border removed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewMenu_Click(object sender, EventArgs e)
        {
            PictureBox img = sender as PictureBox;

            // set status bar text and cursor
            switch (img.Name)
            {
                case "imgSelect":
                    tsStatusBar.Text = "Select";
                    pbDraw.Cursor = Cursors.Cross;
                    MessageBox.Show("Not yet implemented!");
                    break;
                case "imgBrush":
                    tsStatusBar.Text = "Brush";
                    pbDraw.Cursor = Cursors.Default;
                    break;
                case "imgPencil":
                    tsStatusBar.Text = "Pencil";
                    pbDraw.Cursor = Cursors.Default;
                    break;
                case "imgLines":
                    tsStatusBar.Text = "Line/Curve";
                    pnlShapes.Visible = true;
                    break;
                case "imgText":
                    tsStatusBar.Text = "Text";
                    MessageBox.Show("Click for location and Submit");
                    pbDraw.Cursor = Cursors.IBeam;
                    break;
                case "imgEraser":
                    tsStatusBar.Text = "Eraser";
                    pbDraw.Cursor = Cursors.Default;
                    break;
            }
            // set border 
            img.BorderStyle = BorderStyle.FixedSingle;

            // remove border if it isn't selected
            if (img.Name != "imgSelect")
                imgSelect.BorderStyle = BorderStyle.None;
            if (img.Name != "imgBrush")
                imgBrush.BorderStyle = BorderStyle.None;
            if (img.Name != "imgPencil")
                imgPencil.BorderStyle = BorderStyle.None;
            if (img.Name != "imgLines")
                imgLines.BorderStyle = BorderStyle.None;
            if (img.Name != "imgText")
                imgText.BorderStyle = BorderStyle.None;
            if (img.Name != "imgEraser")
                imgEraser.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// When a shape/line is selected change status bar text and change cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbShapes_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            tsStatusBar.Text += ": ";
            switch (pb.Name)
            {
                case "pbLine":
                    tsStatusBar.Text += "Line";
                    break;
                case "pbBezier":
                    tsStatusBar.Text += "Bezier";
                    break;
                case "pbEllipse":
                    tsStatusBar.Text += "Ellipse";
                    break;
                case "pbRectangle":
                    tsStatusBar.Text += "Rectangle";
                    pnlShapes.Visible = true;
                    break;
                case "pbPentagon":
                    tsStatusBar.Text += "Pentagon";
                    break;
                case "pbHexagon":
                    tsStatusBar.Text += "Hexagon";
                    break;
            }
            // set cursor
            pbDraw.Cursor = Cursors.Cross;
            // set visibility of popup menu
            pnlShapes.Visible = false;
        }

        /// <summary>
        /// Set border of icon when mouse down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox img = sender as PictureBox;

            // used to set status bar text
            switch (img.Name)
            {
                case "imgFlipVert":
                    tsStatusBar.Text = "Flip Vertically";
                    break;
                case "imgFlipHoriz":
                    tsStatusBar.Text = "Flip Horizontally";
                    break;
                case "imgRotate90":
                    tsStatusBar.Text = "Rotate";
                    break;
            }
            // set cursor
            pbDraw.Cursor = Cursors.Default;
            // set border
            img.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Removes the border from icon in image menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageMenuPanel_MouseLeave(object sender, EventArgs e)
        {
            PictureBox img = sender as PictureBox;
            img.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Removes the border from icon in image menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageMenuPanel_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox img = sender as PictureBox;
            img.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// Takes care of actions for when the mouse is clicked on the drawing box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            // drawing is allowed
            draw = true;
            // save the location of when mouse is pressed down
            pt1 = e.Location;

            if (imgLines.BorderStyle == BorderStyle.FixedSingle)
            {
                switch (tsStatusBar.Text)
                {
                    case "Line/Curve: Bezier":

                        if (count < 4)
                            bezierPoints[count] = e.Location;
                        count++;

                        if (count == 4)
                        {
                            g.DrawBezier(mainPen, bezierPoints[0], bezierPoints[1], bezierPoints[2], bezierPoints[3]);
                            count = 0;
                            pbDraw.Image = img;
                        }
                        break;
                    case "Text":

                        break;
                }
            }
        }

        /// <summary>
        /// Takes care of actions for when the mouse is unclicked on the drawing box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            // drawing is not allowed
            draw = false;

            if (imgLines.BorderStyle == BorderStyle.FixedSingle)
            {
                switch (tsStatusBar.Text)
                {
                    // Draw line
                    case "Line/Curve: Line":
                        g.DrawLine(mainPen, pt1.X, pt1.Y, e.X, e.Y);
                        pbDraw.Image = img;
                        break;
                    case "Line/Curve: Bezier":
                        break;
                    // Draw Ellipse
                    case "Line/Curve: Ellipse":
                        CheckPoints();
                        g.DrawEllipse(mainPen, pt1.X, pt1.Y, Math.Abs(pt2.X - pt1.X), Math.Abs(pt2.Y - pt1.Y));
                        pbDraw.Image = img;
                        break;
                    // Draw Rectangle
                    case "Line/Curve: Rectangle":
                        CheckPoints();
                        g.DrawRectangle(mainPen, pt1.X, pt1.Y, Math.Abs(pt2.X - pt1.X), Math.Abs(pt2.Y - pt1.Y));
                        pbDraw.Image = img;
                        break;
                    // Draw Pentagon of fixed side lengths
                    case "Line/Curve: Pentagon":
                        pt1 = new Point(e.X, e.Y);
                        pt2 = new Point(e.X - 95, e.Y + 69);
                        pt3 = new Point(e.X - 59, e.Y + 181);
                        pt4 = new Point(e.X + 59, e.Y + 181);
                        pt5 = new Point(e.X + 95, e.Y + 69);
                        // Create points that define pentagon.
                        Point[] pentagonPoints = { pt1, pt2, pt3, pt4, pt5 };
                        // Draw polygon to screen.
                        g.DrawPolygon(mainPen, pentagonPoints);
                        pbDraw.Image = img;
                        break;
                    // Draw Hexagon of fixed side lengths
                    case "Line/Curve: Hexagon":
                        pt1 = new Point(e.X, e.Y);
                        pt2 = new Point(e.X - 100, e.Y);
                        pt3 = new Point(e.X - 150, e.Y + 87);
                        pt4 = new Point(e.X - 100, e.Y + 174);
                        pt5 = new Point(e.X, e.Y + 174);
                        pt6 = new Point(e.X + 50, e.Y + 87);
                        // Create points that define pentagon.
                        Point[] hexagonPoints = { pt1, pt2, pt3, pt4, pt5, pt6 };
                        // Draw polygon to screen.
                        g.DrawPolygon(mainPen, hexagonPoints);
                        pbDraw.Image = img;
                        break;
                }
            }
        }

        /// <summary>
        /// Takes care of actions when mouse button is held down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            // set the color of the main pen
            mainPen.Color = colorDialog.Color;

            // check if drawing is allowed
            if (draw)
            {
                switch (tsStatusBar.Text)
                {
                    // paint brush
                    case "Brush":
                        g.FillEllipse(mainPen.Brush, e.X, e.Y, 10, 10);
                        pbDraw.Image = img;
                        break;
                    // pencil
                    case "Pencil":
                        g.DrawLine(mainPen, pt1, e.Location);
                        pbDraw.Image = img;
                        pt1 = e.Location;
                        break;
                    // eraser
                    case "Eraser":
                        g.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                        pbDraw.Image = img;
                        break;
                    // set end point for shapes/line
                    case "Line/Curve: Line":
                    case "Line/Curve: Ellipse":
                    case "Line/Curve: Rectangle":
                        pt2 = new Point(e.X, e.Y);
                        break;
                }
            }
        }

        /// <summary>
        /// Takes care of actions when specific button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imageMenu_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            switch (pb.Name)
            {
                // flip over the Y-axis
                case "imgFlipVert":
                    img.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pbDraw.Image = img;
                    break;
                // flip over the X-axis
                case "imgFlipHoriz":
                    img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pbDraw.Image = img;
                    break;
                // rotate image by 90 degrees each time
                case "imgRotate90":
                    img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pbDraw.Image = img;
                    break;
            }
            g.Dispose();
        }

        /// <summary>
        /// Checks coordinate points and switches them to draw shapes appropriately
        /// </summary>
        private void CheckPoints()
        {
            if (pt2.X < pt1.X)
            {
                int temp = pt1.X;
                pt1.X = pt2.X;
                pt2.X = temp;
            }

            if (pt2.Y < pt1.Y)
            {
                int temp = pt1.Y;
                pt1.Y = pt2.Y;
                pt2.Y = temp;
            }
        }
    }
}
