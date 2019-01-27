namespace MegaDesk
{
    partial class AddQuote
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelNrDrawers = new System.Windows.Forms.Label();
            this.labelSurfaceMaterial = new System.Windows.Forms.Label();
            this.labelOrderDays = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(304, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 50);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textWidth
            // 
            this.textWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWidth.Location = new System.Drawing.Point(304, 62);
            this.textWidth.MaxLength = 2;
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(240, 30);
            this.textWidth.TabIndex = 1;
            this.textWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            this.textWidth.Validated += new System.EventHandler(this.textWidth_Validated);
            // 
            // textCustomerName
            // 
            this.textCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCustomerName.Location = new System.Drawing.Point(304, 15);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(240, 30);
            this.textCustomerName.TabIndex = 2;
            // 
            // textDepth
            // 
            this.textDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDepth.Location = new System.Drawing.Point(304, 108);
            this.textDepth.MaxLength = 2;
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(240, 30);
            this.textDepth.TabIndex = 3;
            this.textDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepth_KeyPress);
            this.textDepth.Validating += new System.ComponentModel.CancelEventHandler(this.textDepth_Validating);
            this.textDepth.Validated += new System.EventHandler(this.textDepth_Validated);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(304, 153);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 30);
            this.numericUpDown1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(304, 200);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(304, 251);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(240, 33);
            this.comboBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(45, 15);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(240, 30);
            this.labelCustomerName.TabIndex = 10;
            this.labelCustomerName.Text = "Customer Name";
            this.labelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWidth
            // 
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(45, 62);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(240, 30);
            this.labelWidth.TabIndex = 11;
            this.labelWidth.Text = "Width";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDepth
            // 
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(46, 108);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(240, 30);
            this.labelDepth.TabIndex = 12;
            this.labelDepth.Text = "Depth";
            this.labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNrDrawers
            // 
            this.labelNrDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrDrawers.Location = new System.Drawing.Point(45, 152);
            this.labelNrDrawers.Name = "labelNrDrawers";
            this.labelNrDrawers.Size = new System.Drawing.Size(240, 30);
            this.labelNrDrawers.TabIndex = 13;
            this.labelNrDrawers.Text = "Number of Drawers";
            this.labelNrDrawers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSurfaceMaterial
            // 
            this.labelSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurfaceMaterial.Location = new System.Drawing.Point(45, 200);
            this.labelSurfaceMaterial.Name = "labelSurfaceMaterial";
            this.labelSurfaceMaterial.Size = new System.Drawing.Size(240, 30);
            this.labelSurfaceMaterial.TabIndex = 14;
            this.labelSurfaceMaterial.Text = "SurfaceMaterial";
            this.labelSurfaceMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOrderDays
            // 
            this.labelOrderDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDays.Location = new System.Drawing.Point(45, 251);
            this.labelOrderDays.Name = "labelOrderDays";
            this.labelOrderDays.Size = new System.Drawing.Size(240, 30);
            this.labelOrderDays.TabIndex = 15;
            this.labelOrderDays.Text = "Order Days";
            this.labelOrderDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.labelOrderDays);
            this.Controls.Add(this.labelSurfaceMaterial);
            this.Controls.Add(this.labelNrDrawers);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textDepth);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.buttonCancel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelNrDrawers;
        private System.Windows.Forms.Label labelSurfaceMaterial;
        private System.Windows.Forms.Label labelOrderDays;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}