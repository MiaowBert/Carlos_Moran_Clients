namespace CarlosMoran_Clients_Project.Forms {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            groupBox1 = new GroupBox();
            asdasdqweqwvrtvrtv = new Label();
            pbx_txtcolor = new PictureBox();
            label1 = new Label();
            pbx_bgcolor = new PictureBox();
            groupBox2 = new GroupBox();
            nmc_phonenumlen = new NumericUpDown();
            label3 = new Label();
            btn_apply = new Button();
            btn_cancel = new Button();
            btn_ok = new Button();
            nmc_zipcodelength = new NumericUpDown();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_txtcolor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_bgcolor).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmc_phonenumlen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmc_zipcodelength).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(asdasdqweqwvrtvrtv);
            groupBox1.Controls.Add(pbx_txtcolor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pbx_bgcolor);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 99);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Style";
            // 
            // asdasdqweqwvrtvrtv
            // 
            asdasdqweqwvrtvrtv.BorderStyle = BorderStyle.Fixed3D;
            asdasdqweqwvrtvrtv.Location = new Point(6, 45);
            asdasdqweqwvrtvrtv.Name = "asdasdqweqwvrtvrtv";
            asdasdqweqwvrtvrtv.Size = new Size(118, 17);
            asdasdqweqwvrtvrtv.TabIndex = 3;
            asdasdqweqwvrtvrtv.Text = "Text Color";
            // 
            // pbx_txtcolor
            // 
            pbx_txtcolor.BackColor = SystemColors.ControlText;
            pbx_txtcolor.Location = new Point(148, 45);
            pbx_txtcolor.Name = "pbx_txtcolor";
            pbx_txtcolor.Size = new Size(16, 16);
            pbx_txtcolor.TabIndex = 2;
            pbx_txtcolor.TabStop = false;
            pbx_txtcolor.Click += pbx_txtcolor_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 1;
            label1.Text = "Background Color";
            // 
            // pbx_bgcolor
            // 
            pbx_bgcolor.BackColor = SystemColors.Control;
            pbx_bgcolor.Location = new Point(148, 19);
            pbx_bgcolor.Name = "pbx_bgcolor";
            pbx_bgcolor.Size = new Size(16, 16);
            pbx_bgcolor.TabIndex = 0;
            pbx_bgcolor.TabStop = false;
            pbx_bgcolor.Click += pbx_bgcolor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nmc_zipcodelength);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(nmc_phonenumlen);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 117);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 78);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // nmc_phonenumlen
            // 
            nmc_phonenumlen.Location = new Point(176, 18);
            nmc_phonenumlen.Name = "nmc_phonenumlen";
            nmc_phonenumlen.Size = new Size(67, 23);
            nmc_phonenumlen.TabIndex = 2;
            nmc_phonenumlen.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(6, 18);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 1;
            label3.Text = "Phone Number Length";
            // 
            // btn_apply
            // 
            btn_apply.Location = new Point(188, 21);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(73, 26);
            btn_apply.TabIndex = 2;
            btn_apply.Text = "Apply";
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(188, 85);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(73, 26);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(188, 53);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(73, 26);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // nmc_zipcodelength
            // 
            nmc_zipcodelength.Location = new Point(176, 41);
            nmc_zipcodelength.Name = "nmc_zipcodelength";
            nmc_zipcodelength.Size = new Size(67, 23);
            nmc_zipcodelength.TabIndex = 4;
            nmc_zipcodelength.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nmc_zipcodelength.ValueChanged += nmc_zipcodelength_ValueChanged;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 3;
            label2.Text = "Zip Code Length";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 316);
            Controls.Add(btn_ok);
            Controls.Add(btn_cancel);
            Controls.Add(btn_apply);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbx_txtcolor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_bgcolor).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmc_phonenumlen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmc_zipcodelength).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pbx_bgcolor;
        private Label label1;
        private Label asdasdqweqwvrtvrtv;
        private PictureBox pbx_txtcolor;
        private GroupBox groupBox2;
        private NumericUpDown nmc_phonenumlen;
        private Label label3;
        private Button btn_apply;
        private Button btn_cancel;
        private Button btn_ok;
        private NumericUpDown nmc_zipcodelength;
        private Label label2;
    }
}