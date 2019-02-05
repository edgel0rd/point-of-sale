using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public class EFlatButton : Button
    {
        public EFlatButton()
        {
            InitializeComponent();
            flatColor = FlatAppearance.BorderColor;
            BackColor = _idleColor;
            width = Size.Width;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // EFlatButton
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.White;
            this.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Size = new System.Drawing.Size(48, 48);
            this.UseVisualStyleBackColor = false;
            this.SizeChanged += new System.EventHandler(this.EFlatButton_SizeChanged);
            this.Click += new System.EventHandler(this.EFlatButton_Click);
            this.ResumeLayout(false);

        }
        private Color _idleColor;
        private Color flatColor;       
        private Color _colorWorking;
        [Browsable(true)]
        public Color ColorIdle
        {
            get => _idleColor;
            set => _idleColor = value;
        }

        [Browsable(true)]
        public Color ColorWorking
        {
            get => _colorWorking;
            set => _colorWorking = value;
        }

        private int width;
        private string exp_text;
        [Browsable(true)]
        [DefaultValue("")]
        public string Title
        {
            get => exp_text;
            set => exp_text = value;
        }

        private Image _imgIdle;
        [Browsable(true)]
        [DefaultValue(null)]
        public Image ImageIdle
        {
            get => _imgIdle;
            set
            {
                _imgIdle = value;
                Image = value;
            }
        }
        private Image _workingImage;
        [Browsable(true)]
        [DefaultValue(null)]
        public Image ImageWorking
        {
            get => _workingImage;
            set => _workingImage = value;
        }
        
        public bool IsActivated()
        {
            return BackColor.ToArgb() == _idleColor.ToArgb();
        }

        public void Toggle()
        {
            bool b = IsActivated();
            BackColor = b ? _colorWorking : _idleColor;
            Image = b ? _workingImage : _imgIdle;
            ForeColor = b ? _idleColor : _colorWorking;
        }

        private void EFlatButton_Click(object sender, EventArgs e)
        {
        }

        public void PerformLock(bool b)
        {
            
            if (true)
            {
                BackColor = b ? _colorWorking : _idleColor;
                Image = b ? _workingImage : _imgIdle;
                ForeColor = b ? _idleColor : _colorWorking;
                FlatAppearance.MouseDownBackColor = b ? BackColor : flatColor;
                FlatAppearance.MouseOverBackColor = b ? BackColor : flatColor;
                FlatAppearance.BorderColor = b ? BackColor : flatColor;
            }

        }

        private void EFlatButton_SizeChanged(object sender, EventArgs e)
        {
            bool expanded = Size.Width > width;
            Text = expanded ? exp_text : string.Empty;
            ImageAlign = expanded ? ContentAlignment.MiddleLeft : ContentAlignment.MiddleCenter;
            TextAlign = ImageAlign;
            
        }
    }
}
