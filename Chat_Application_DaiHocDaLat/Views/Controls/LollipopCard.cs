﻿using DevExpress.Utils.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class LollipopCard : Control
{

    #region Variables

    Image image;
    Label InfoLabel = new Label();
    FontManager font = new FontManager();
    LollipopFlatButton OKButton = new LollipopFlatButton();

    string info = "Card Content is here";
    string TColor = "#33b679";
    string CColor = "#444444";
    string BColor = "#33b679";

    bool Growing;

    #endregion
    #region Properties

    [Category("Appearance"), Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
    public string ContentText
    {
        get { return info; }
        set
        {
            info = value;

            InfoLabel.Text = info;
            ResizeLabel();

            Invalidate();
        }
    }

    [Category("Appearance")]
    public string TitleColor
    {
        get { return TColor; }
        set
        {
            TColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public string ButtonColor
    {
        get { return BColor; }
        set
        {
            BColor = value;
            OKButton.FontColor = BColor;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public string ContentColor
    {
        get { return CColor; }
        set
        {
            CColor = value;
            Invalidate();
        }
    }

    [Category("Appearance")]
    public Image Image
    {
        get
        {
            return image;
        }
        set
        {
            image = value;
            Invalidate();
        }
    }

    #endregion
    #region Events

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Width = 294;
        this.Height = InfoLabel.Location.Y + InfoLabel.Height + 74;
    }

    #endregion

    public LollipopCard()
    {
        Width = 294; Height = 348; DoubleBuffered = true;

        AddLabel();
        AddButton();
        Controls.Add(InfoLabel);
        Controls.Add(OKButton);
    }

    public void AddLabel()
    {
        InfoLabel.AutoSize = false;
        InfoLabel.Location = new Point(13, 209);
        InfoLabel.ForeColor = ColorTranslator.FromHtml(CColor);

        InfoLabel.Width = 265;
        InfoLabel.Text = info;
        ResizeLabel();
    }
    public void AddButton()
    {
        OKButton.FontColor = BColor;
        OKButton.Location = new Point(210, InfoLabel.Location.Y + InfoLabel.Height + 26);
        OKButton.Size = new Size(69, 33);
        OKButton.Text = "Got it";
    }

    private void ResizeLabel()
    {
        if (Growing) return;
        try
        {
            Growing = true;
            Size sz = new Size(InfoLabel.Width, Int32.MaxValue);
            sz = TextRenderer.MeasureText(InfoLabel.Text, InfoLabel.Font, sz, TextFormatFlags.WordBreak);
            InfoLabel.Height = sz.Height;
        }
        finally
        {
            Growing = false;
        }

        OKButton.Location = new Point(210, InfoLabel.Location.Y + InfoLabel.Height + 26);
        this.Height = InfoLabel.Location.Y + InfoLabel.Height + 74;
        Refresh();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics G = e.Graphics;
        G.SmoothingMode = SmoothingMode.HighQuality;
        G.Clear(Parent.BackColor);

        InfoLabel.ForeColor = ColorTranslator.FromHtml(CColor);

        Color NonColor = ColorTranslator.FromHtml("#e3e5e7");

       
      
        }
    }

