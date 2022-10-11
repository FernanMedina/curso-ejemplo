
namespace Practica1
{
    partial class Name
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Name));
            this.controlbtn = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // controlbtn
            // 
            this.controlbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.controlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.controlbtn.Image = ((System.Drawing.Image)(resources.GetObject("controlbtn.Image")));
            this.controlbtn.Location = new System.Drawing.Point(523, 51);
            this.controlbtn.Name = "controlbtn";
            this.controlbtn.Size = new System.Drawing.Size(97, 65);
            this.controlbtn.TabIndex = 0;
            this.controlbtn.Text = "Run";
            this.controlbtn.UseVisualStyleBackColor = false;
            this.controlbtn.Click += new System.EventHandler(this.controlbtn_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(523, 164);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(141, 30);
            this.label.TabIndex = 1;
            this.label.Text = "Control Label";
            this.label.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_MouseMove);
            // 
            // txtApellido
            // 
            this.txtApellido.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(523, 232);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(523, 290);
            this.txtNuevo.Multiline = true;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtNuevo.TabIndex = 3;
            this.txtNuevo.Leave += new System.EventHandler(this.txtNuevo_Leave);
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label);
            this.Controls.Add(this.controlbtn);
            this.Enabled = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Name";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Name_FormClosed);
            this.Load += new System.EventHandler(this.Name_Load);
            this.Click += new System.EventHandler(this.Name_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlbtn;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNuevo;
    }
}

