namespace CarlosMoran_Clients_Project {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btn_edit = new Button();
            lst_output = new ListBox();
            tabcontrol = new TabControl();
            tab_client = new TabPage();
            btn_new = new Button();
            dgv_clients = new DataGridView();
            anumber = new DataGridViewTextBoxColumn();
            lname = new DataGridViewTextBoxColumn();
            fname = new DataGridViewTextBoxColumn();
            uniqueid = new DataGridViewTextBoxColumn();
            tab_document = new TabPage();
            splitContainer2 = new SplitContainer();
            spl_document = new SplitContainer();
            txt_documenttitle = new TextBox();
            txt_documentdescription = new TextBox();
            label14 = new Label();
            dtp_createdate = new DateTimePicker();
            txt_doctype = new TextBox();
            label15 = new Label();
            dtp_duedate = new DateTimePicker();
            label16 = new Label();
            btn_newdocument = new Button();
            btn_editdocument = new Button();
            dgv_documents = new DataGridView();
            btn_deletedocument = new Button();
            splitContainer1 = new SplitContainer();
            txt_reqtitle = new TextBox();
            pictureBox1 = new PictureBox();
            txt_reqdescription = new TextBox();
            label18 = new Label();
            txt_reqtype = new TextBox();
            label17 = new Label();
            label19 = new Label();
            txt_reqdue = new TextBox();
            txt_reqcreatedate = new TextBox();
            dgv_required = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            createdate = new DataGridViewTextBoxColumn();
            duedate = new DataGridViewTextBoxColumn();
            clm_completed = new DataGridViewTextBoxColumn();
            btn_newrequired = new Button();
            btn_completerequired = new Button();
            txt_firstname = new TextBox();
            tblClientBindingSource = new BindingSource(components);
            tblClientBindingSource1 = new BindingSource(components);
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txt_zip = new TextBox();
            txt_state = new TextBox();
            txt_city = new TextBox();
            txt_line2 = new TextBox();
            txt_line1 = new TextBox();
            txt_phone = new TextBox();
            txt_lastname = new TextBox();
            txt_anumber = new TextBox();
            txt_poe = new TextBox();
            label1 = new Label();
            dtp_doe = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            dtp_dob = new DateTimePicker();
            btn_delete = new Button();
            label12 = new Label();
            pnl_client = new GroupBox();
            cbx_clientstatus = new ComboBox();
            label13 = new Label();
            menuStrip1 = new MenuStrip();
            mnu_file = new ToolStripMenuItem();
            mnu_settings = new ToolStripMenuItem();
            mnu_about = new ToolStripMenuItem();
            devToolStripMenuItem = new ToolStripMenuItem();
            mnu_newguid = new ToolStripMenuItem();
            mnu_splitcontainer = new ToolStripMenuItem();
            maintenanceToolStripMenuItem = new ToolStripMenuItem();
            mnu_newuser = new ToolStripMenuItem();
            menuitemnotuysdaasdasd = new ToolStripMenuItem();
            mnu_backuprecords = new ToolStripMenuItem();
            mnu_restorerecords = new ToolStripMenuItem();
            clm_id = new DataGridViewTextBoxColumn();
            clm_title = new DataGridViewTextBoxColumn();
            clm_create = new DataGridViewTextBoxColumn();
            clm_due = new DataGridViewTextBoxColumn();
            clm_filed = new DataGridViewTextBoxColumn();
            tabcontrol.SuspendLayout();
            tab_client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_clients).BeginInit();
            tab_document.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spl_document).BeginInit();
            spl_document.Panel1.SuspendLayout();
            spl_document.Panel2.SuspendLayout();
            spl_document.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_documents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_required).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblClientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblClientBindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            pnl_client.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(6, 6);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(89, 23);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += EditClientClick;
            // 
            // lst_output
            // 
            lst_output.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lst_output.Enabled = false;
            lst_output.FormattingEnabled = true;
            lst_output.ItemHeight = 15;
            lst_output.Location = new Point(295, 632);
            lst_output.Name = "lst_output";
            lst_output.Size = new Size(947, 64);
            lst_output.TabIndex = 2;
            lst_output.TabStop = false;
            // 
            // tabcontrol
            // 
            tabcontrol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabcontrol.Controls.Add(tab_client);
            tabcontrol.Controls.Add(tab_document);
            tabcontrol.Location = new Point(295, 43);
            tabcontrol.Name = "tabcontrol";
            tabcontrol.SelectedIndex = 0;
            tabcontrol.Size = new Size(951, 583);
            tabcontrol.TabIndex = 3;
            tabcontrol.TabStop = false;
            tabcontrol.SelectedIndexChanged += TabSelected;
            tabcontrol.Selecting += tabSelectChange;
            // 
            // tab_client
            // 
            tab_client.Controls.Add(btn_edit);
            tab_client.Controls.Add(btn_new);
            tab_client.Controls.Add(dgv_clients);
            tab_client.Location = new Point(4, 24);
            tab_client.Name = "tab_client";
            tab_client.Padding = new Padding(3);
            tab_client.Size = new Size(943, 555);
            tab_client.TabIndex = 0;
            tab_client.Text = "Clients";
            tab_client.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            btn_new.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_new.Location = new Point(851, 6);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(89, 23);
            btn_new.TabIndex = 13;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // dgv_clients
            // 
            dgv_clients.AllowUserToAddRows = false;
            dgv_clients.AllowUserToDeleteRows = false;
            dgv_clients.AllowUserToOrderColumns = true;
            dgv_clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_clients.BackgroundColor = SystemColors.Info;
            dgv_clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clients.Columns.AddRange(new DataGridViewColumn[] { anumber, lname, fname, uniqueid });
            dgv_clients.Location = new Point(3, 38);
            dgv_clients.Name = "dgv_clients";
            dgv_clients.ReadOnly = true;
            dgv_clients.RowHeadersVisible = false;
            dgv_clients.RowTemplate.Height = 25;
            dgv_clients.ScrollBars = ScrollBars.Vertical;
            dgv_clients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_clients.Size = new Size(937, 514);
            dgv_clients.TabIndex = 0;
            dgv_clients.SelectionChanged += ClientRowSelected;
            // 
            // anumber
            // 
            anumber.DividerWidth = 2;
            anumber.HeaderText = "A#";
            anumber.Name = "anumber";
            anumber.ReadOnly = true;
            anumber.Width = 125;
            // 
            // lname
            // 
            lname.DividerWidth = 2;
            lname.HeaderText = "Last Name";
            lname.Name = "lname";
            lname.ReadOnly = true;
            lname.Width = 200;
            // 
            // fname
            // 
            fname.DividerWidth = 2;
            fname.HeaderText = "First Name";
            fname.Name = "fname";
            fname.ReadOnly = true;
            fname.Width = 200;
            // 
            // uniqueid
            // 
            uniqueid.HeaderText = "GUID";
            uniqueid.Name = "uniqueid";
            uniqueid.ReadOnly = true;
            uniqueid.Visible = false;
            // 
            // tab_document
            // 
            tab_document.Controls.Add(splitContainer2);
            tab_document.Location = new Point(4, 24);
            tab_document.Name = "tab_document";
            tab_document.Size = new Size(943, 555);
            tab_document.TabIndex = 1;
            tab_document.Text = "Documents";
            tab_document.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.Aquamarine;
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(spl_document);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new Size(943, 555);
            splitContainer2.SplitterDistance = 495;
            splitContainer2.SplitterWidth = 7;
            splitContainer2.TabIndex = 35;
            // 
            // spl_document
            // 
            spl_document.BackColor = Color.Aquamarine;
            spl_document.BorderStyle = BorderStyle.Fixed3D;
            spl_document.Dock = DockStyle.Fill;
            spl_document.Location = new Point(0, 0);
            spl_document.Name = "spl_document";
            spl_document.Orientation = Orientation.Horizontal;
            // 
            // spl_document.Panel1
            // 
            spl_document.Panel1.BackColor = SystemColors.Control;
            spl_document.Panel1.Controls.Add(txt_documenttitle);
            spl_document.Panel1.Controls.Add(txt_documentdescription);
            spl_document.Panel1.Controls.Add(label14);
            spl_document.Panel1.Controls.Add(dtp_createdate);
            spl_document.Panel1.Controls.Add(txt_doctype);
            spl_document.Panel1.Controls.Add(label15);
            spl_document.Panel1.Controls.Add(dtp_duedate);
            spl_document.Panel1.Controls.Add(label16);
            // 
            // spl_document.Panel2
            // 
            spl_document.Panel2.BackColor = SystemColors.Control;
            spl_document.Panel2.Controls.Add(btn_newdocument);
            spl_document.Panel2.Controls.Add(btn_editdocument);
            spl_document.Panel2.Controls.Add(dgv_documents);
            spl_document.Panel2.Controls.Add(btn_deletedocument);
            spl_document.Size = new Size(495, 555);
            spl_document.SplitterDistance = 322;
            spl_document.SplitterWidth = 7;
            spl_document.TabIndex = 33;
            // 
            // txt_documenttitle
            // 
            txt_documenttitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_documenttitle.Location = new Point(5, 3);
            txt_documenttitle.Margin = new Padding(5, 3, 5, 3);
            txt_documenttitle.Multiline = true;
            txt_documenttitle.Name = "txt_documenttitle";
            txt_documenttitle.PlaceholderText = "Title";
            txt_documenttitle.Size = new Size(315, 23);
            txt_documenttitle.TabIndex = 26;
            txt_documenttitle.KeyPress += FilterTextEnter;
            // 
            // txt_documentdescription
            // 
            txt_documentdescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_documentdescription.Location = new Point(5, 34);
            txt_documentdescription.Margin = new Padding(5, 3, 5, 3);
            txt_documentdescription.Multiline = true;
            txt_documentdescription.Name = "txt_documentdescription";
            txt_documentdescription.PlaceholderText = "Description";
            txt_documentdescription.ScrollBars = ScrollBars.Vertical;
            txt_documentdescription.Size = new Size(481, 252);
            txt_documentdescription.TabIndex = 14;
            txt_documentdescription.KeyPress += FilterTextEnter;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Location = new Point(5, 292);
            label14.Margin = new Padding(5, 3, 5, 3);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 11;
            label14.Text = "Type";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_createdate
            // 
            dtp_createdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_createdate.Format = DateTimePickerFormat.Short;
            dtp_createdate.Location = new Point(393, 3);
            dtp_createdate.Margin = new Padding(1, 3, 1, 3);
            dtp_createdate.Name = "dtp_createdate";
            dtp_createdate.Size = new Size(93, 23);
            dtp_createdate.TabIndex = 16;
            // 
            // txt_doctype
            // 
            txt_doctype.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_doctype.Location = new Point(107, 292);
            txt_doctype.Margin = new Padding(5, 3, 5, 3);
            txt_doctype.Name = "txt_doctype";
            txt_doctype.PlaceholderText = "Document Type";
            txt_doctype.Size = new Size(174, 23);
            txt_doctype.TabIndex = 25;
            txt_doctype.TextAlign = HorizontalAlignment.Center;
            txt_doctype.KeyPress += FilterTextEnter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Location = new Point(326, 3);
            label15.Margin = new Padding(1, 3, 1, 3);
            label15.Name = "label15";
            label15.Size = new Size(63, 23);
            label15.TabIndex = 17;
            label15.Text = "Created";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_duedate
            // 
            dtp_duedate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dtp_duedate.Format = DateTimePickerFormat.Short;
            dtp_duedate.Location = new Point(386, 292);
            dtp_duedate.Margin = new Padding(1, 3, 1, 3);
            dtp_duedate.Name = "dtp_duedate";
            dtp_duedate.Size = new Size(100, 23);
            dtp_duedate.TabIndex = 18;
            dtp_duedate.ValueChanged += dtp_duedate_ValueChanged;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Location = new Point(287, 292);
            label16.Margin = new Padding(1, 3, 1, 3);
            label16.Name = "label16";
            label16.Size = new Size(97, 23);
            label16.TabIndex = 19;
            label16.Text = "Due";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_newdocument
            // 
            btn_newdocument.Location = new Point(5, 3);
            btn_newdocument.Name = "btn_newdocument";
            btn_newdocument.Size = new Size(83, 23);
            btn_newdocument.TabIndex = 4;
            btn_newdocument.Text = "New";
            btn_newdocument.UseVisualStyleBackColor = true;
            btn_newdocument.Click += btn_newdocument_click;
            // 
            // btn_editdocument
            // 
            btn_editdocument.Location = new Point(94, 3);
            btn_editdocument.Name = "btn_editdocument";
            btn_editdocument.Size = new Size(83, 23);
            btn_editdocument.TabIndex = 3;
            btn_editdocument.Text = "Edit";
            btn_editdocument.UseVisualStyleBackColor = true;
            btn_editdocument.Click += btn_editdocument_click;
            // 
            // dgv_documents
            // 
            dgv_documents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_documents.BackgroundColor = Color.PaleTurquoise;
            dgv_documents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_documents.Columns.AddRange(new DataGridViewColumn[] { clm_id, clm_title, clm_create, clm_due, clm_filed });
            dgv_documents.Location = new Point(5, 32);
            dgv_documents.Name = "dgv_documents";
            dgv_documents.RowHeadersVisible = false;
            dgv_documents.RowTemplate.Height = 25;
            dgv_documents.ScrollBars = ScrollBars.Vertical;
            dgv_documents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_documents.Size = new Size(481, 160);
            dgv_documents.TabIndex = 0;
            dgv_documents.CellContentClick += dgv_documents_CellContentClick;
            dgv_documents.SelectionChanged += DocumentRowSelected;
            // 
            // btn_deletedocument
            // 
            btn_deletedocument.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_deletedocument.Location = new Point(405, 4);
            btn_deletedocument.Name = "btn_deletedocument";
            btn_deletedocument.Size = new Size(81, 23);
            btn_deletedocument.TabIndex = 2;
            btn_deletedocument.Text = "Delete";
            btn_deletedocument.UseVisualStyleBackColor = true;
            btn_deletedocument.Click += btn_deletedocument_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Aquamarine;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Control;
            splitContainer1.Panel1.Controls.Add(txt_reqtitle);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(txt_reqdescription);
            splitContainer1.Panel1.Controls.Add(label18);
            splitContainer1.Panel1.Controls.Add(txt_reqtype);
            splitContainer1.Panel1.Controls.Add(label17);
            splitContainer1.Panel1.Controls.Add(label19);
            splitContainer1.Panel1.Controls.Add(txt_reqdue);
            splitContainer1.Panel1.Controls.Add(txt_reqcreatedate);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(dgv_required);
            splitContainer1.Panel2.Controls.Add(btn_newrequired);
            splitContainer1.Panel2.Controls.Add(btn_completerequired);
            splitContainer1.Size = new Size(441, 555);
            splitContainer1.SplitterDistance = 309;
            splitContainer1.SplitterWidth = 7;
            splitContainer1.TabIndex = 34;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved_1;
            // 
            // txt_reqtitle
            // 
            txt_reqtitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_reqtitle.Location = new Point(4, 87);
            txt_reqtitle.Margin = new Padding(5, 3, 5, 3);
            txt_reqtitle.Multiline = true;
            txt_reqtitle.Name = "txt_reqtitle";
            txt_reqtitle.PlaceholderText = "Required Document Title";
            txt_reqtitle.Size = new Size(238, 23);
            txt_reqtitle.TabIndex = 33;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 79);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // txt_reqdescription
            // 
            txt_reqdescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_reqdescription.Location = new Point(3, 116);
            txt_reqdescription.Margin = new Padding(5, 3, 5, 3);
            txt_reqdescription.Multiline = true;
            txt_reqdescription.Name = "txt_reqdescription";
            txt_reqdescription.PlaceholderText = "Description of Required Document";
            txt_reqdescription.ScrollBars = ScrollBars.Vertical;
            txt_reqdescription.Size = new Size(432, 154);
            txt_reqdescription.TabIndex = 20;
            txt_reqdescription.KeyPress += FilterTextEnter;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Location = new Point(248, 87);
            label18.Margin = new Padding(1, 3, 1, 3);
            label18.Name = "label18";
            label18.Size = new Size(75, 23);
            label18.TabIndex = 27;
            label18.Text = "Created";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_reqtype
            // 
            txt_reqtype.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_reqtype.BorderStyle = BorderStyle.FixedSingle;
            txt_reqtype.Location = new Point(84, 274);
            txt_reqtype.Margin = new Padding(5, 3, 5, 3);
            txt_reqtype.Name = "txt_reqtype";
            txt_reqtype.PlaceholderText = "Required Document Type";
            txt_reqtype.Size = new Size(183, 23);
            txt_reqtype.TabIndex = 32;
            txt_reqtype.TextAlign = HorizontalAlignment.Center;
            txt_reqtype.KeyPress += FilterTextEnter;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Location = new Point(270, 274);
            label17.Margin = new Padding(5, 3, 5, 3);
            label17.Name = "label17";
            label17.Size = new Size(53, 23);
            label17.TabIndex = 22;
            label17.Text = "Due";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Location = new Point(3, 274);
            label19.Margin = new Padding(5, 3, 5, 3);
            label19.Name = "label19";
            label19.Size = new Size(77, 23);
            label19.TabIndex = 31;
            label19.Text = "Type";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_reqdue
            // 
            txt_reqdue.AllowDrop = true;
            txt_reqdue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_reqdue.BorderStyle = BorderStyle.FixedSingle;
            txt_reqdue.Location = new Point(329, 274);
            txt_reqdue.Margin = new Padding(5, 3, 5, 3);
            txt_reqdue.Name = "txt_reqdue";
            txt_reqdue.PlaceholderText = "Due Date";
            txt_reqdue.Size = new Size(106, 23);
            txt_reqdue.TabIndex = 29;
            txt_reqdue.TextAlign = HorizontalAlignment.Center;
            txt_reqdue.KeyPress += FilterTextEnter;
            // 
            // txt_reqcreatedate
            // 
            txt_reqcreatedate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_reqcreatedate.BorderStyle = BorderStyle.FixedSingle;
            txt_reqcreatedate.Location = new Point(329, 87);
            txt_reqcreatedate.Margin = new Padding(5, 3, 5, 3);
            txt_reqcreatedate.Name = "txt_reqcreatedate";
            txt_reqcreatedate.PlaceholderText = "Create Date";
            txt_reqcreatedate.Size = new Size(106, 23);
            txt_reqcreatedate.TabIndex = 28;
            txt_reqcreatedate.TextAlign = HorizontalAlignment.Center;
            txt_reqcreatedate.KeyPress += FilterTextEnter;
            // 
            // dgv_required
            // 
            dgv_required.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_required.BackgroundColor = SystemColors.ActiveCaption;
            dgv_required.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_required.Columns.AddRange(new DataGridViewColumn[] { Id, title, createdate, duedate, clm_completed });
            dgv_required.Location = new Point(4, 31);
            dgv_required.Name = "dgv_required";
            dgv_required.RowHeadersVisible = false;
            dgv_required.RowTemplate.Height = 25;
            dgv_required.ScrollBars = ScrollBars.Vertical;
            dgv_required.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_required.Size = new Size(433, 174);
            dgv_required.TabIndex = 1;
            dgv_required.SelectionChanged += ReqDocumentRowSelected;
            // 
            // Id
            // 
            Id.HeaderText = "Column1";
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 25;
            // 
            // title
            // 
            title.HeaderText = "Title";
            title.Name = "title";
            // 
            // createdate
            // 
            createdate.HeaderText = "Created";
            createdate.Name = "createdate";
            // 
            // duedate
            // 
            duedate.HeaderText = "Due";
            duedate.Name = "duedate";
            // 
            // clm_completed
            // 
            clm_completed.HeaderText = "Completed";
            clm_completed.Name = "clm_completed";
            // 
            // btn_newrequired
            // 
            btn_newrequired.Location = new Point(4, 3);
            btn_newrequired.Name = "btn_newrequired";
            btn_newrequired.Size = new Size(105, 23);
            btn_newrequired.TabIndex = 23;
            btn_newrequired.Text = "Require An Item";
            btn_newrequired.UseVisualStyleBackColor = true;
            btn_newrequired.Click += btn_newrequired_Click;
            // 
            // btn_completerequired
            // 
            btn_completerequired.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_completerequired.Location = new Point(367, 3);
            btn_completerequired.Name = "btn_completerequired";
            btn_completerequired.Size = new Size(68, 23);
            btn_completerequired.TabIndex = 24;
            btn_completerequired.Text = "Complete";
            btn_completerequired.UseVisualStyleBackColor = true;
            btn_completerequired.Click += btn_completerequired_Click;
            // 
            // txt_firstname
            // 
            txt_firstname.BorderStyle = BorderStyle.FixedSingle;
            txt_firstname.Location = new Point(111, 56);
            txt_firstname.Margin = new Padding(5, 3, 5, 3);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.PlaceholderText = "first name";
            txt_firstname.Size = new Size(154, 23);
            txt_firstname.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txt_zip);
            groupBox1.Controls.Add(txt_state);
            groupBox1.Controls.Add(txt_city);
            groupBox1.Controls.Add(txt_line2);
            groupBox1.Controls.Add(txt_line1);
            groupBox1.Location = new Point(12, 309);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(253, 171);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Address";
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(6, 137);
            label7.Margin = new Padding(5, 3, 5, 3);
            label7.Name = "label7";
            label7.Size = new Size(89, 23);
            label7.TabIndex = 19;
            label7.Text = "Postal Code";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(6, 108);
            label8.Margin = new Padding(5, 3, 5, 3);
            label8.Name = "label8";
            label8.Size = new Size(89, 23);
            label8.TabIndex = 18;
            label8.Text = "State ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(6, 79);
            label9.Margin = new Padding(5, 3, 5, 3);
            label9.Name = "label9";
            label9.Size = new Size(89, 23);
            label9.TabIndex = 17;
            label9.Text = "City";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(6, 50);
            label10.Margin = new Padding(5, 3, 5, 3);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 16;
            label10.Text = "Line 2";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(6, 21);
            label11.Margin = new Padding(5, 3, 5, 3);
            label11.Name = "label11";
            label11.Size = new Size(89, 23);
            label11.TabIndex = 15;
            label11.Text = "Line 1";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_zip
            // 
            txt_zip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_zip.BorderStyle = BorderStyle.FixedSingle;
            txt_zip.Location = new Point(105, 137);
            txt_zip.Margin = new Padding(5, 3, 5, 3);
            txt_zip.Name = "txt_zip";
            txt_zip.PlaceholderText = "postal code";
            txt_zip.Size = new Size(136, 23);
            txt_zip.TabIndex = 12;
            // 
            // txt_state
            // 
            txt_state.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_state.BorderStyle = BorderStyle.FixedSingle;
            txt_state.Location = new Point(105, 108);
            txt_state.Margin = new Padding(5, 3, 5, 3);
            txt_state.Name = "txt_state";
            txt_state.PlaceholderText = "state";
            txt_state.Size = new Size(136, 23);
            txt_state.TabIndex = 11;
            // 
            // txt_city
            // 
            txt_city.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_city.BorderStyle = BorderStyle.FixedSingle;
            txt_city.Location = new Point(105, 79);
            txt_city.Margin = new Padding(5, 3, 5, 3);
            txt_city.Name = "txt_city";
            txt_city.PlaceholderText = "city";
            txt_city.Size = new Size(136, 23);
            txt_city.TabIndex = 10;
            // 
            // txt_line2
            // 
            txt_line2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_line2.BorderStyle = BorderStyle.FixedSingle;
            txt_line2.Location = new Point(105, 50);
            txt_line2.Margin = new Padding(5, 3, 5, 3);
            txt_line2.Name = "txt_line2";
            txt_line2.PlaceholderText = "address line 2";
            txt_line2.Size = new Size(136, 23);
            txt_line2.TabIndex = 9;
            // 
            // txt_line1
            // 
            txt_line1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_line1.BorderStyle = BorderStyle.FixedSingle;
            txt_line1.Location = new Point(105, 21);
            txt_line1.Margin = new Padding(5, 3, 5, 3);
            txt_line1.Name = "txt_line1";
            txt_line1.PlaceholderText = "address line 1";
            txt_line1.Size = new Size(136, 23);
            txt_line1.TabIndex = 8;
            // 
            // txt_phone
            // 
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Location = new Point(111, 165);
            txt_phone.Margin = new Padding(5, 3, 5, 3);
            txt_phone.Name = "txt_phone";
            txt_phone.PlaceholderText = "(000) 000-0000";
            txt_phone.Size = new Size(154, 23);
            txt_phone.TabIndex = 4;
            txt_phone.KeyPress += FilterNumeric;
            // 
            // txt_lastname
            // 
            txt_lastname.BorderStyle = BorderStyle.FixedSingle;
            txt_lastname.Location = new Point(111, 85);
            txt_lastname.Margin = new Padding(5, 3, 5, 3);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.PlaceholderText = "last name";
            txt_lastname.Size = new Size(154, 23);
            txt_lastname.TabIndex = 2;
            // 
            // txt_anumber
            // 
            txt_anumber.BorderStyle = BorderStyle.FixedSingle;
            txt_anumber.Location = new Point(46, 21);
            txt_anumber.Margin = new Padding(3, 2, 3, 2);
            txt_anumber.Name = "txt_anumber";
            txt_anumber.PlaceholderText = "A-Number";
            txt_anumber.Size = new Size(120, 23);
            txt_anumber.TabIndex = 0;
            txt_anumber.KeyPress += FilterNumeric;
            // 
            // txt_poe
            // 
            txt_poe.BorderStyle = BorderStyle.FixedSingle;
            txt_poe.Location = new Point(111, 194);
            txt_poe.Margin = new Padding(5, 3, 5, 3);
            txt_poe.Name = "txt_poe";
            txt_poe.PlaceholderText = "point of entry";
            txt_poe.Size = new Size(154, 23);
            txt_poe.TabIndex = 5;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(28, 23);
            label1.TabIndex = 7;
            label1.Text = "A#";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_doe
            // 
            dtp_doe.Format = DateTimePickerFormat.Short;
            dtp_doe.Location = new Point(111, 223);
            dtp_doe.Margin = new Padding(5, 3, 5, 3);
            dtp_doe.Name = "dtp_doe";
            dtp_doe.Size = new Size(154, 23);
            dtp_doe.TabIndex = 6;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 56);
            label2.Margin = new Padding(5, 3, 5, 3);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 10;
            label2.Text = "First Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 85);
            label3.Margin = new Padding(5, 3, 5, 3);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 11;
            label3.Text = "Last Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(12, 165);
            label5.Margin = new Padding(5, 3, 5, 3);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 12;
            label5.Text = "Phone";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(12, 194);
            label4.Margin = new Padding(5, 3, 5, 3);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 13;
            label4.Text = "Point of Entry";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(12, 223);
            label6.Margin = new Padding(5, 3, 5, 3);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 14;
            label6.Text = "Date of Entry";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtp_dob
            // 
            dtp_dob.Format = DateTimePickerFormat.Short;
            dtp_dob.Location = new Point(111, 114);
            dtp_dob.Margin = new Padding(5, 3, 5, 3);
            dtp_dob.Name = "dtp_dob";
            dtp_dob.Size = new Size(154, 23);
            dtp_dob.TabIndex = 3;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.Location = new Point(176, 21);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(89, 23);
            btn_delete.TabIndex = 100;
            btn_delete.TabStop = false;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += DeleteClientClick;
            // 
            // label12
            // 
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Location = new Point(12, 114);
            label12.Margin = new Padding(5, 3, 5, 3);
            label12.Name = "label12";
            label12.Size = new Size(89, 23);
            label12.TabIndex = 16;
            label12.Text = "Date of Birth";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_client
            // 
            pnl_client.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnl_client.Controls.Add(cbx_clientstatus);
            pnl_client.Controls.Add(txt_firstname);
            pnl_client.Controls.Add(label13);
            pnl_client.Controls.Add(label12);
            pnl_client.Controls.Add(btn_delete);
            pnl_client.Controls.Add(dtp_dob);
            pnl_client.Controls.Add(label6);
            pnl_client.Controls.Add(label4);
            pnl_client.Controls.Add(label5);
            pnl_client.Controls.Add(label3);
            pnl_client.Controls.Add(label2);
            pnl_client.Controls.Add(dtp_doe);
            pnl_client.Controls.Add(label1);
            pnl_client.Controls.Add(txt_poe);
            pnl_client.Controls.Add(txt_anumber);
            pnl_client.Controls.Add(txt_lastname);
            pnl_client.Controls.Add(txt_phone);
            pnl_client.Controls.Add(groupBox1);
            pnl_client.Enabled = false;
            pnl_client.Location = new Point(11, 33);
            pnl_client.Name = "pnl_client";
            pnl_client.Size = new Size(277, 663);
            pnl_client.TabIndex = 1;
            pnl_client.TabStop = false;
            pnl_client.Text = "Client";
            // 
            // cbx_clientstatus
            // 
            cbx_clientstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_clientstatus.FormattingEnabled = true;
            cbx_clientstatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cbx_clientstatus.Location = new Point(109, 281);
            cbx_clientstatus.Name = "cbx_clientstatus";
            cbx_clientstatus.Size = new Size(156, 23);
            cbx_clientstatus.TabIndex = 99;
            cbx_clientstatus.TabStop = false;
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Location = new Point(12, 281);
            label13.Margin = new Padding(5, 3, 5, 3);
            label13.Name = "label13";
            label13.Size = new Size(89, 23);
            label13.TabIndex = 17;
            label13.Text = "Client Status";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.InactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnu_file, devToolStripMenuItem, maintenanceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1246, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnu_file
            // 
            mnu_file.DropDownItems.AddRange(new ToolStripItem[] { mnu_settings, mnu_about });
            mnu_file.Name = "mnu_file";
            mnu_file.Size = new Size(37, 20);
            mnu_file.Text = "File";
            // 
            // mnu_settings
            // 
            mnu_settings.Name = "mnu_settings";
            mnu_settings.Size = new Size(116, 22);
            mnu_settings.Text = "Settings";
            mnu_settings.Click += mnu_settings_Click;
            // 
            // mnu_about
            // 
            mnu_about.Name = "mnu_about";
            mnu_about.Size = new Size(116, 22);
            mnu_about.Text = "About";
            mnu_about.Click += mnu_about_Click;
            // 
            // devToolStripMenuItem
            // 
            devToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnu_newguid, mnu_splitcontainer });
            devToolStripMenuItem.Name = "devToolStripMenuItem";
            devToolStripMenuItem.Size = new Size(39, 20);
            devToolStripMenuItem.Text = "Dev";
            // 
            // mnu_newguid
            // 
            mnu_newguid.Name = "mnu_newguid";
            mnu_newguid.Size = new Size(149, 22);
            mnu_newguid.Text = "Helper Box";
            mnu_newguid.Click += putANewGuid;
            // 
            // mnu_splitcontainer
            // 
            mnu_splitcontainer.Name = "mnu_splitcontainer";
            mnu_splitcontainer.Size = new Size(149, 22);
            mnu_splitcontainer.Text = "SplitContainer";
            mnu_splitcontainer.Click += mnu_splitcontainer_Click;
            // 
            // maintenanceToolStripMenuItem
            // 
            maintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnu_newuser, menuitemnotuysdaasdasd });
            maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            maintenanceToolStripMenuItem.Size = new Size(88, 20);
            maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // mnu_newuser
            // 
            mnu_newuser.Name = "mnu_newuser";
            mnu_newuser.Size = new Size(124, 22);
            mnu_newuser.Text = "New User";
            mnu_newuser.Click += mnu_newuser_Click;
            // 
            // menuitemnotuysdaasdasd
            // 
            menuitemnotuysdaasdasd.DropDownItems.AddRange(new ToolStripItem[] { mnu_backuprecords, mnu_restorerecords });
            menuitemnotuysdaasdasd.Name = "menuitemnotuysdaasdasd";
            menuitemnotuysdaasdasd.Size = new Size(124, 22);
            menuitemnotuysdaasdasd.Text = "Database";
            // 
            // mnu_backuprecords
            // 
            mnu_backuprecords.Name = "mnu_backuprecords";
            mnu_backuprecords.Size = new Size(113, 22);
            mnu_backuprecords.Text = "Backup";
            mnu_backuprecords.Click += mnu_backuprecords_Click;
            // 
            // mnu_restorerecords
            // 
            mnu_restorerecords.Name = "mnu_restorerecords";
            mnu_restorerecords.Size = new Size(113, 22);
            mnu_restorerecords.Text = "Restore";
            mnu_restorerecords.Click += mnu_restorerecords_Click;
            // 
            // clm_id
            // 
            clm_id.HeaderText = "id";
            clm_id.Name = "clm_id";
            clm_id.Visible = false;
            // 
            // clm_title
            // 
            clm_title.HeaderText = "Title";
            clm_title.Name = "clm_title";
            // 
            // clm_create
            // 
            clm_create.HeaderText = "Created";
            clm_create.Name = "clm_create";
            // 
            // clm_due
            // 
            clm_due.HeaderText = "Due";
            clm_due.Name = "clm_due";
            // 
            // clm_filed
            // 
            clm_filed.HeaderText = "Filed On";
            clm_filed.Name = "clm_filed";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 706);
            Controls.Add(tabcontrol);
            Controls.Add(lst_output);
            Controls.Add(pnl_client);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Client Records";
            Load += Form1_Load;
            tabcontrol.ResumeLayout(false);
            tab_client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_clients).EndInit();
            tab_document.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            spl_document.Panel1.ResumeLayout(false);
            spl_document.Panel1.PerformLayout();
            spl_document.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spl_document).EndInit();
            spl_document.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_documents).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_required).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblClientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblClientBindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnl_client.ResumeLayout(false);
            pnl_client.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lst_output;
        private TabControl tabcontrol;
        private TabPage tab_client;
        private TextBox txt_documentdescription;
        private TabPage tab_document;
        private BindingSource tblClientBindingSource;
        private BindingSource tblClientBindingSource1;
        private DataGridView dgv_clients;
        private Button btn_edit;
        private Button btn_new;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txt_zip;
        private TextBox txt_state;
        private TextBox txt_city;
        private TextBox txt_line2;
        private TextBox txt_line1;
        private TextBox txt_phone;
        private TextBox txt_lastname;
        private TextBox txt_anumber;
        private TextBox txt_poe;
        private Label label1;
        private DateTimePicker dtp_doe;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private DateTimePicker dtp_dob;
        private Button btn_delete;
        private Label label12;
        private GroupBox pnl_client;
        private Label label13;
        private ComboBox cbx_clientstatus;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_file;
        private ToolStripMenuItem mnu_settings;
        private ToolStripMenuItem mnu_about;
        private DataGridView dgv_documents;
        private Button btn_newdocument;
        private Button btn_editdocument;
        private Button btn_deletedocument;
        private TextBox txt_firstname;
        private Label label14;
        private Label label16;
        private DateTimePicker dtp_duedate;
        private Label label15;
        private DateTimePicker dtp_createdate;
        private Button btn_completerequired;
        private Button btn_newrequired;
        private Label label17;
        private ToolStripMenuItem devToolStripMenuItem;
        private ToolStripMenuItem mnu_newguid;
        private TextBox txt_doctype;
        private TextBox txt_documenttitle;
        private TextBox txt_reqdue;
        private TextBox txt_reqcreatedate;
        private Label label18;
        private TextBox txt_reqtype;
        private Label label19;
        private DataGridView dgv_required;
        private TextBox txt_reqdescription;
        private PictureBox pictureBox1;
        private ToolStripMenuItem mnu_splitcontainer;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem mnu_newuser;
        private SplitContainer spl_document;
        private SplitContainer splitContainer1;
        private TextBox txt_reqtitle;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem menuitemnotuysdaasdasd;
        private ToolStripMenuItem mnu_backuprecords;
        private ToolStripMenuItem mnu_restorerecords;
        private DataGridViewTextBoxColumn anumber;
        private DataGridViewTextBoxColumn lname;
        private DataGridViewTextBoxColumn fname;
        private DataGridViewTextBoxColumn uniqueid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn createdate;
        private DataGridViewTextBoxColumn duedate;
        private DataGridViewTextBoxColumn clm_completed;
        private DataGridViewTextBoxColumn clm_id;
        private DataGridViewTextBoxColumn clm_title;
        private DataGridViewTextBoxColumn clm_create;
        private DataGridViewTextBoxColumn clm_due;
        private DataGridViewTextBoxColumn clm_filed;
    }
}
