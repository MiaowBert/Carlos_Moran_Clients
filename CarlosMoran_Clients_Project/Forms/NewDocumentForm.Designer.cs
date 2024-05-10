namespace CarlosMoran_Clients_Project.Forms {
    partial class NewDocumentForm {
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
        private void InitializeComponent()
        {
            txt_title = new TextBox();
            label16 = new Label();
            dtp_duedate = new DateTimePicker();
            label15 = new Label();
            dtp_createdate = new DateTimePicker();
            txt_description = new TextBox();
            label1 = new Label();
            lbl_header = new Label();
            cbx_types = new ComboBox();
            btn_cancel = new Button();
            btn_confirm = new Button();
            lbl_filedate = new Label();
            dtp_filedate = new DateTimePicker();
            SuspendLayout();
            // 
            // txt_title
            // 
            txt_title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_title.BorderStyle = BorderStyle.FixedSingle;
            txt_title.Location = new Point(9, 45);
            txt_title.Margin = new Padding(5, 3, 5, 3);
            txt_title.Name = "txt_title";
            txt_title.PlaceholderText = "Title";
            txt_title.Size = new Size(458, 23);
            txt_title.TabIndex = 0;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(265, 381);
            label16.Margin = new Padding(1, 3, 1, 3);
            label16.Name = "label16";
            label16.Size = new Size(86, 23);
            label16.TabIndex = 31;
            label16.Text = "Due By";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_duedate
            // 
            dtp_duedate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtp_duedate.Format = DateTimePickerFormat.Short;
            dtp_duedate.Location = new Point(353, 381);
            dtp_duedate.Margin = new Padding(1, 3, 1, 3);
            dtp_duedate.Name = "dtp_duedate";
            dtp_duedate.Size = new Size(114, 23);
            dtp_duedate.TabIndex = 4;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(265, 352);
            label15.Margin = new Padding(1, 3, 1, 3);
            label15.Name = "label15";
            label15.Size = new Size(86, 23);
            label15.TabIndex = 29;
            label15.Text = "Created";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_createdate
            // 
            dtp_createdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtp_createdate.Format = DateTimePickerFormat.Short;
            dtp_createdate.Location = new Point(353, 352);
            dtp_createdate.Margin = new Padding(1, 3, 1, 3);
            dtp_createdate.Name = "dtp_createdate";
            dtp_createdate.Size = new Size(114, 23);
            dtp_createdate.TabIndex = 3;
            // 
            // txt_description
            // 
            txt_description.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_description.Location = new Point(9, 74);
            txt_description.Margin = new Padding(5, 3, 5, 3);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.PlaceholderText = "Description";
            txt_description.Size = new Size(458, 272);
            txt_description.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(8, 352);
            label1.Margin = new Padding(5, 3, 5, 3);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 33;
            label1.Text = "Type";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_header
            // 
            lbl_header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_header.BorderStyle = BorderStyle.Fixed3D;
            lbl_header.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_header.Location = new Point(9, 12);
            lbl_header.Margin = new Padding(5, 3, 5, 3);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(458, 27);
            lbl_header.TabIndex = 36;
            lbl_header.Text = "What it do";
            lbl_header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbx_types
            // 
            cbx_types.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbx_types.FormattingEnabled = true;
            cbx_types.Location = new Point(67, 352);
            cbx_types.Name = "cbx_types";
            cbx_types.Size = new Size(144, 23);
            cbx_types.TabIndex = 2;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_cancel.Location = new Point(356, 410);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(111, 31);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_confirm
            // 
            btn_confirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_confirm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_confirm.Location = new Point(8, 410);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(111, 31);
            btn_confirm.TabIndex = 5;
            btn_confirm.Text = "Ok";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // lbl_filedate
            // 
            lbl_filedate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_filedate.BorderStyle = BorderStyle.Fixed3D;
            lbl_filedate.Location = new Point(8, 381);
            lbl_filedate.Margin = new Padding(1, 3, 1, 3);
            lbl_filedate.Name = "lbl_filedate";
            lbl_filedate.Size = new Size(86, 23);
            lbl_filedate.TabIndex = 38;
            lbl_filedate.Text = "Filed On";
            lbl_filedate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_filedate
            // 
            dtp_filedate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtp_filedate.Format = DateTimePickerFormat.Short;
            dtp_filedate.Location = new Point(96, 381);
            dtp_filedate.Margin = new Padding(1, 3, 1, 3);
            dtp_filedate.Name = "dtp_filedate";
            dtp_filedate.ShowCheckBox = true;
            dtp_filedate.Size = new Size(115, 23);
            dtp_filedate.TabIndex = 39;
            dtp_filedate.ValueChanged += Dtp_ValueChanged;
            // 
            // NewDocumentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 444);
            ControlBox = false;
            Controls.Add(dtp_filedate);
            Controls.Add(lbl_filedate);
            Controls.Add(btn_confirm);
            Controls.Add(btn_cancel);
            Controls.Add(cbx_types);
            Controls.Add(lbl_header);
            Controls.Add(label1);
            Controls.Add(txt_title);
            Controls.Add(label16);
            Controls.Add(dtp_duedate);
            Controls.Add(label15);
            Controls.Add(dtp_createdate);
            Controls.Add(txt_description);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewDocumentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewDocumentForm";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_title;
        private Label label16;
        private DateTimePicker dtp_duedate;
        private Label label15;
        private DateTimePicker dtp_createdate;
        private TextBox txt_description;
        private Label label1;
        private Label lbl_header;
        private ComboBox cbx_types;
        private Button btn_cancel;
        private Button btn_confirm;
        public Label lbl_filedate;
        public DateTimePicker dtp_filedate;
    }
}