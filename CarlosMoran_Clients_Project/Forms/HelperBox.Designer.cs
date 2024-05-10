namespace CarlosMoran_Clients_Project.Forms {
    partial class HelperBox {
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
            btn_newGuid = new Button();
            txt_guidbox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_passwordhash = new Button();
            txt_passwordhashresult = new TextBox();
            txt_passwordhashtarget = new TextBox();
            btn_calchash = new Button();
            txt_hashresult = new TextBox();
            txt_hashtarget = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_newGuid
            // 
            btn_newGuid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_newGuid.Location = new Point(179, 22);
            btn_newGuid.Name = "btn_newGuid";
            btn_newGuid.Size = new Size(106, 23);
            btn_newGuid.TabIndex = 0;
            btn_newGuid.Text = "New Guid";
            btn_newGuid.UseVisualStyleBackColor = true;
            btn_newGuid.Click += btn_newGuid_Click;
            // 
            // txt_guidbox
            // 
            txt_guidbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_guidbox.Location = new Point(6, 22);
            txt_guidbox.Name = "txt_guidbox";
            txt_guidbox.PlaceholderText = "Press Button To Get a GUID";
            txt_guidbox.Size = new Size(168, 23);
            txt_guidbox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_newGuid);
            groupBox1.Controls.Add(txt_guidbox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 57);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guid";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(btn_passwordhash);
            groupBox2.Controls.Add(txt_passwordhashresult);
            groupBox2.Controls.Add(txt_passwordhashtarget);
            groupBox2.Controls.Add(btn_calchash);
            groupBox2.Controls.Add(txt_hashresult);
            groupBox2.Controls.Add(txt_hashtarget);
            groupBox2.Location = new Point(12, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 284);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hashing";
            // 
            // btn_passwordhash
            // 
            btn_passwordhash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_passwordhash.Location = new Point(179, 226);
            btn_passwordhash.Name = "btn_passwordhash";
            btn_passwordhash.Size = new Size(106, 23);
            btn_passwordhash.TabIndex = 6;
            btn_passwordhash.Text = "Password Hash";
            btn_passwordhash.UseVisualStyleBackColor = true;
            btn_passwordhash.Click += btn_passwordhash_Click;
            // 
            // txt_passwordhashresult
            // 
            txt_passwordhashresult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_passwordhashresult.Location = new Point(6, 255);
            txt_passwordhashresult.Name = "txt_passwordhashresult";
            txt_passwordhashresult.PlaceholderText = "Password Hash Result";
            txt_passwordhashresult.Size = new Size(168, 23);
            txt_passwordhashresult.TabIndex = 7;
            // 
            // txt_passwordhashtarget
            // 
            txt_passwordhashtarget.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_passwordhashtarget.Location = new Point(6, 226);
            txt_passwordhashtarget.Name = "txt_passwordhashtarget";
            txt_passwordhashtarget.PlaceholderText = "Input String To Password Hash";
            txt_passwordhashtarget.Size = new Size(168, 23);
            txt_passwordhashtarget.TabIndex = 5;
            // 
            // btn_calchash
            // 
            btn_calchash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_calchash.Location = new Point(179, 22);
            btn_calchash.Name = "btn_calchash";
            btn_calchash.Size = new Size(106, 23);
            btn_calchash.TabIndex = 3;
            btn_calchash.Text = "SHA512";
            btn_calchash.UseVisualStyleBackColor = true;
            btn_calchash.Click += btn_calchash_Click;
            // 
            // txt_hashresult
            // 
            txt_hashresult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_hashresult.Location = new Point(6, 51);
            txt_hashresult.Name = "txt_hashresult";
            txt_hashresult.PlaceholderText = "SHA512 Result";
            txt_hashresult.Size = new Size(168, 23);
            txt_hashresult.TabIndex = 4;
            // 
            // txt_hashtarget
            // 
            txt_hashtarget.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_hashtarget.Location = new Point(6, 22);
            txt_hashtarget.Name = "txt_hashtarget";
            txt_hashtarget.PlaceholderText = "Input String To Hash";
            txt_hashtarget.Size = new Size(168, 23);
            txt_hashtarget.TabIndex = 2;
            // 
            // HelperBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 367);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HelperBox";
            Text = "HelperBox";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_newGuid;
        private TextBox txt_guidbox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_calchash;
        private TextBox txt_hashresult;
        private TextBox txt_hashtarget;
        private Button btn_passwordhash;
        private TextBox txt_passwordhashresult;
        private TextBox txt_passwordhashtarget;
    }
}