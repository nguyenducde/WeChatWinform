using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class LollipopCheckBox : CheckBox
{
    #region Variables

    static Point[] CHECKMARK_LINE = { new Point(3, 8), new Point(7, 12), new Point(14, 5) };

    string HexColor = "#508ef5";

    Color EnabledCheckedColor;
    Color EnabledUnCheckedColor = ColorTranslator.FromHtml("#9c9ea1");

    Color DisabledColor = ColorTranslator.FromHtml("#c4c6ca");
    Color EnabledStringColor = ColorTranslator.FromHtml("#999999");
    Color DisabledStringColor = ColorTranslator.FromHtml("#babbbd");

    Timer AnimationTimer = new Timer { Interval = 17 };


    int SizeAnimationNum = 14;
    int PointAnimationNum = 3;
    int Alpha = 0;

    #endregion
    #region  Properties

    [Category("Appearance")]
    public string CheckColor
    {
        get { return HexColor; }
        set
        {
            HexColor = value;
            Invalidate();
        }
    }

    #endregion
    #region Events

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        AnimationTimer.Start();
    }
    protected override void OnResize(EventArgs e)
    {
        Height = 20;
        Width = 20;
    }

    #endregion
    public LollipopCheckBox()
    {
        DoubleBuffered = true;
        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }
    protected override void OnPaint(PaintEventArgs pevent)
    {
        var g = pevent.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Parent.BackColor);

        var checkMarkLine = new Rectangle(1, 1, 16, 16);


        EnabledCheckedColor = ColorTranslator.FromHtml(HexColor);
        SolidBrush BG = new SolidBrush(Enabled ? Checked ? EnabledCheckedColor : EnabledUnCheckedColor : DisabledColor);
        Pen Pen = new Pen(BG.Color);

        g.SmoothingMode = SmoothingMode.None;
        g.FillRectangle(new SolidBrush(Color.White), PointAnimationNum, PointAnimationNum, SizeAnimationNum, SizeAnimationNum);
        g.SmoothingMode = SmoothingMode.AntiAlias;
      
        //CheckMark
        g.DrawImageUnscaledAndClipped(CheckMarkBitmap(), checkMarkLine);
        
        //CheckBox Text

    }

    void AnimationTick(object sender, EventArgs e)
    {
        if (Checked)
        {
            if (Alpha < 250)
            {
                Alpha += 25;
                this.Invalidate();

                if (SizeAnimationNum > 0)
                {
                    SizeAnimationNum -= 2;
                    this.Invalidate();
                }
                
                if (PointAnimationNum < 10)
                {
                    PointAnimationNum += 1;
                    this.Invalidate();
                }
            }
        }
        else if (Alpha > 0)
        {
            Alpha -= 25;
            this.Invalidate();

            if (SizeAnimationNum < 14)
            {
                SizeAnimationNum += 2;
                this.Invalidate();
            }

            
            if (PointAnimationNum > 3)
            {
                PointAnimationNum -= 1;
                this.Invalidate();
            }
        }
    }

    private Bitmap CheckMarkBitmap()
    {
        var checkMark = new Bitmap(16, 16);
        var g = Graphics.FromImage(checkMark);
        g.Clear(Color.Transparent);

        var pen = new Pen(new SolidBrush(Color.FromArgb(Alpha, 255, 255, 255)), 2);
        g.DrawLines(pen, CHECKMARK_LINE);

        return checkMark;
    }
}
