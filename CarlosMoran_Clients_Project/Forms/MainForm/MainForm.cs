/**
   Copyright 2024 Nathan Krone

   Licensed under the Creative Commons Attribution-NonCommercial 4.0 International License (CC BY-NC 4.0).
   You may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       https://creativecommons.org/licenses/by-nc/4.0/

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using CarlosMoran_Clients_Project.Classes;
using CarlosMoran_Clients_Project.Forms;
using CarlosMoran_Clients_Project.Helpers;
using DbObjects;
using System.Diagnostics.CodeAnalysis;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace CarlosMoran_Clients_Project {



    public partial class MainForm : Form {

        const string ClientDgvColumns = "a322ffa8-5083-499c-b4ce-f10324f6df71";
        const string DocumentDgvColumns = "a25d94a4-e79e-421f-80c0-36d751daf374";

        const string BackupFilename = "Backups/CarlosMoran_Clients.db";

        /// <summary>
        /// When applied to the Key Press event of a text box, it 
        /// prevents non numeric characters from being enterred;
        /// </summary>
        /// 
        /// <remarks> Phone numbers, or zip codes</remarks>
        /// <param name="sender">idk</param>
        /// <param name="e">idk</param>
        private void FilterNumeric(object sender, KeyPressEventArgs e) {
            Filter.FilterTextBox_Numeric(sender, e);
        }

        /// <summary>
        /// Event handler for KeyPress event to disable key presses in control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterTextEnter(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        /// <summary>
        /// Get the settings from the database and apply them to this form.
        /// </summary>
        private void RefreshSettings() {
            using (CarlosMoran_Clients db = new()) {
                TblSettings? trySetting = db.TblSettings.First() ?? null;

                if (trySetting != null) {
                    TblSettings settings = trySetting;

                    settings.ApplySettings(this);

                    txt_phone.MaxLength = (int)settings.Phonenumberlength.Value;
                    txt_zip.MaxLength = (int)settings.Zipcodelength.Value;
                }


            }
        }

        /// <summary>
        /// Add a line to the lst_output list box prepended with the time. 
        /// </summary>
        /// <param name="Msg"> The string to add </param>
        public void AddMessage(string Msg) {
            string time = DateTime.Now.ToLongTimeString();

            lst_output.Items.Add($"[{time}] {Msg}");

            lst_output.TopIndex = lst_output.Items.Count - 1;
        }

        public MainForm() {
            InitializeComponent();

            RefreshDgvClients();

            RefreshSettings();

            SetDgvColumnWidths();

            DoToolTips();

            txt_documentdescription.ForeColor = Color.Black;
        }

        private void DoToolTips() {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(btn_newrequired, "Launches a dialog to create a 'Required' document.");

            ToolTip t2 = new ToolTip();
            t2.SetToolTip(btn_completerequired, "Marks the current required document as completed.\nCompleted documents do not show up in the list results.");
        }

        private void SetDgvColumnWidths() {
            dgv_clients.ColumnWidthChanged -= ClientColumnResized;
            dgv_documents.ColumnWidthChanged -= DocumentColumnResized;

            using (CarlosMoran_Clients db = new()) {

                foreach (TblColumnWidths colw in db.TblColumnWidths) {

                    switch (colw.Id) {

                        //case client datagridview
                        case ClientDgvColumns: {

                                List<int> widths = colw.GetRows();

                                for (int i = 0; i < dgv_clients.Columns.Count; i++) {
                                    dgv_clients.Columns[i].Width = widths[i];
                                }

                            }
                            break;

                        //case document datagridview
                        case DocumentDgvColumns: {

                                List<int> widths = colw.GetRows();

                                for (int i = 0; i < dgv_documents.Columns.Count; i++) {
                                    dgv_documents.Columns[i].Width = widths[i];
                                }

                            }
                            break;

                        default: {
                                AddMessage("Unhandled case in Column widths ERR07");
                            }
                            break;

                    }

                }

            }

            dgv_clients.ColumnWidthChanged += ClientColumnResized;
            dgv_documents.ColumnWidthChanged += DocumentColumnResized;
        }

        private void Form1_Load(object sender, EventArgs e) {


        }

        #region [ Tab Control & DataGrids]

        /// <summary>
        /// this is actually in the menu strip control
        /// </summary>
        private void mnu_settings_Click(object sender, EventArgs e) {

            SettingsForm settingsForm = new();
            settingsForm.FormClosed += RefreshSettingsFormClosed;

            settingsForm.ShowDialog(this);

        }

        //event handler for settings form closing
        private void RefreshSettingsFormClosed(object? sender, FormClosedEventArgs e) {
            RefreshSettings();
        }

        private void putANewGuid(object sender, EventArgs e) {
            HelperBox h = new();

            h.Show();
        }

        /// <summary>
        /// Event handler if you resize a column in the dgv_clients
        /// Should persist changes to the database
        /// </summary>
        /// <remarks> Synchronous </remarks>
        private void ClientColumnResized(object sender, DataGridViewColumnEventArgs e) {

            using (CarlosMoran_Clients db = new()) {
                TblColumnWidths? w = db.TblColumnWidths
                    .Where(d => d.Id == ClientDgvColumns)
                    .FirstOrDefault() ?? null;

                //we got a match
                if (w != null) {
                    List<int> newVals = new List<int>();
                    foreach (DataGridViewColumn c in dgv_clients.Columns) {
                        newVals.Add(c.Width);
                    }

                    w.SetRows(newVals);

                    int rows = db.SaveChanges();

                    if (rows == 0) { AddMessage("Column width failed to save ERR09"); }

                } else {
                    AddMessage("ERR10");

                }


            }

        }

        /// <summary>
        /// Event handler if you resize a column in the dgv_clients
        /// Should persist changes to the database
        /// </summary>
        /// <remarks> Synchronous </remarks>
        private void DocumentColumnResized(object sender, DataGridViewColumnEventArgs e) {

            using (CarlosMoran_Clients db = new()) {
                TblColumnWidths? w = db.TblColumnWidths
                    .Where(d => d.Id == DocumentDgvColumns)
                    .FirstOrDefault() ?? null;

                //we got a match
                if (w != null) {
                    List<int> newVals = new List<int>();
                    foreach (DataGridViewColumn c in dgv_documents.Columns) {
                        newVals.Add(c.Width);
                    }

                    w.SetRows(newVals);

                    int rows = db.SaveChanges();

                    if (rows == 0) { AddMessage("Column width failed to save ERR12"); }

                } else {
                    AddMessage("ERR11");

                }


            }

        }

        /// <summary>
        /// Event handler if you resize a column in the dgv_documents
        /// Should persist changes to the database
        /// </summary>
        /// <remarks> Synchronous </remarks>
        private void DocumentColumnResized(object sender, EventArgs e) {

        }

        /// <summary>
        /// Event Handler for when a tab is changed in the tab grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabSelectChange(object sender, TabControlCancelEventArgs e) {
            if (isNewClient || isEditingClient) {
                AddMessage("Tab change disabled while creating or editing a client.");
                e.Cancel = true;
            }

            switch (e.TabPageIndex) {
                case 0: {   //Selected Client Tab

                    }
                    break;
                case 1: {  //Selected Document Tab

                        //make sure a client is selected and 
                        if (currentClient == null) {
                            e.Cancel = true;

                            if (dgv_clients.Rows.Count > 0) {
                                AddMessage("Please Select a Client First");
                            } else {
                                AddMessage("Please Create a Client First");
                            }
                        }

                    }
                    break;

                default: {
                        AddMessage("Default");
                    }
                    break;
            }

        }


        /// <summary>
        /// Event Handler for TabControl SelectedIndexChanged; loads documents....
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabSelected(object sender, EventArgs e) {
            int index = tabcontrol.SelectedIndex;

            switch (index) {
                case 0: {//Clients

                    }
                    break;

                case 1: {//Documents
                        ChangeCurrentDocument(null);
                        LoadDocumentsForClient();

                    }
                    break;

                default: {
                        AddMessage("Switch case not handled for tab select");
                    }
                    break;
            }
        }

        #endregion

        #region [ Client ]

        /// <summary>
        /// User clicked a client in the <see cref="DataGridView">dgv_clients</see>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientRowSelected(object sender, EventArgs e) {

            //commented cause refreshing the dgv_client raises this event. creating erroneous messages
            //if (isEditingClient) {
            //    if (currentClient != null)
            //        this.AddMessage($"Discarding changes made to {currentClient.FirstName} {currentClient.LastName}");
            //}

            if (e != null && dgv_clients.SelectedRows.Count > 0) {

                DataGridViewRow? selectedRow = dgv_clients.SelectedRows[0];

                if (selectedRow != null) {
                    string clientId = selectedRow?.Cells["uniqueid"].Value.ToString() ?? "ERROR";

                    using (CarlosMoran_Clients db = new()) {

                        Client? selected = null;

                        TblClient _selected = db.TblClients.Where(c => c.Id == clientId).FirstOrDefault() ?? null;

                        if (_selected != null) {
                            selected = new Client(_selected);
                        }

                        //update the thing with the new client
                        ChangeCurrentClient(selected);

                    }
                }

            }

        }

        /// <summary>
        /// Determines whether the client panel should be enabled for editing 
        /// or if the button should behave as a 'save' button, disabling the panel. 
        /// 
        /// </summary>
        /// <remarks> When acting as the save button, the client should be updated in the db </remarks>
        protected bool isEditingClient = false;

        /// <summary>
        /// Handles what needs to be changed when switching in and out of edit state
        /// </summary>
        /// <param name="shouldEdit"> True means we are going to edit the client </param>
        protected void ToggleEditClientMode(bool shouldEdit) {
            if (shouldEdit != isEditingClient) {
                isEditingClient = shouldEdit;

                if (shouldEdit) {
                    btn_edit.Text = "Save";
                    pnl_client.Enabled = true;
                    btn_new.Enabled = false;

                } else {
                    btn_edit.Text = "Edit";
                    pnl_client.Enabled = false;
                    btn_new.Enabled = true;

                }

            }

        }

        /// <summary>
        /// Determines if currently creating a new client or not;
        /// </summary>
        protected bool isNewClient = false;

        /// <summary>
        /// Handles what needs to be changed when switching in and out of new client state
        /// </summary>
        /// <param name="startCreating"> True means we are making another client</param>
        protected void ToggleNewMode(bool startCreating) {
            if (startCreating != isNewClient) {
                isNewClient = startCreating;

                if (startCreating) {
                    btn_new.Text = "Save";
                    pnl_client.Enabled = true;
                    btn_edit.Enabled = false;
                    dgv_clients.Enabled = false;
                    btn_delete.Enabled = false;

                } else {
                    btn_new.Text = "New";
                    pnl_client.Enabled = false;
                    btn_edit.Enabled = true;
                    dgv_clients.Enabled = true;
                    btn_delete.Enabled = true;

                }

            }

        }

        /// <summary>
        /// Allows you to enter in new data for a new client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_new_Click(object sender, EventArgs e) {

            //create a new client
            if (!isNewClient) {
                ToggleNewMode(true);

                //clear client
                ChangeCurrentClient(new Client());

            }
            //save the new client
            else {
                string clientName = $"{txt_firstname.Text} {txt_lastname.Text}";

                DialogResult result =
                MessageBox.Show($"Save {clientName} as new client?", "Confirm New Client", MessageBoxButtons.YesNoCancel);

                switch (result) {

                    case DialogResult.Yes: {

                            //persist changes to the database
                            using (CarlosMoran_Clients db = new()) {
                                //write the address to 

                                if (db.TblAddresses != null && db.TblClients != null) {

                                    ApplyCurrentClientChanges();
                                    db.TblAddresses.Add(currentClient.Address.ToDbObject());
                                    db.TblClients.Add(currentClient.ToDbObject());

                                    int row = db.SaveChanges();

                                    if (row > 0) {
                                        AddMessage($"Client added to database");
                                        RefreshDgvClients();
                                    } else AddMessage("Failed to add client...");

                                } else {
                                    AddMessage("Failed to find database");
                                }

                            }

                            ToggleNewMode(false);

                        }
                        break;

                    case DialogResult.No: {
                            ChangeCurrentClient(null);
                            ToggleNewMode(false);

                        }
                        break;

                    case DialogResult.Cancel: {


                        }
                        break;

                }

            }

        }

        protected Classes.Client currentClient;

        /// <summary>
        /// Clears and reloads the DataGridView holding the total clients in
        /// the Clients TabView
        /// </summary>
        protected void RefreshDgvClients() {
            //remove everything
            dgv_clients.Rows.Clear();

            //access the DbContext
            using (CarlosMoran_Clients db = new()) {

                //make sure there are clients in the table and the table isn't null
                if (db.TblClients != null && db.TblClients.Any()) {

                    //
                    List<TblClient> clients =
                        db.TblClients.ToList();

                    foreach (TblClient c in clients) {
                        dgv_clients.Rows.Add(c.Anumber, c.Lastname, c.Firstname, c.Id);

                    }
                }
            }
        }

        /// <summary>
        /// sets the form ui elements to reflect _client data
        /// </summary>
        /// <remarks>Will zero out all the fields if _client is null </remarks>
        /// <param name="_client">The object to populate the ui elements with</param>
        protected void ChangeCurrentClient(Classes.Client? _client = null) {
            currentClient = _client;

            //clear client details.
            txt_anumber.Text = "";
            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_phone.Text = "";

            //clear address details
            txt_line1.Text = "";
            txt_line2.Text = "";
            txt_city.Text = "";
            txt_state.Text = "";
            txt_zip.Text = "";

            cbx_clientstatus.Text = "Select a status";

            txt_poe.Text = "";

            dtp_dob.Value = DateTime.Now;
            dtp_doe.Value = DateTime.Now;
            try {
                if (_client != null) {
                    //clear client details.
                    txt_anumber.Text = _client.A_Number.ToString();
                    txt_firstname.Text = _client.FirstName;
                    txt_lastname.Text = _client.LastName;
                    txt_phone.Text = _client.PhoneNumber.ToString();

                    //clear address details
                    txt_line1.Text = _client.Address.Line1;
                    txt_line2.Text = _client.Address.Line2;
                    txt_city.Text = _client.Address.City;
                    txt_state.Text = _client.Address.State;
                    txt_zip.Text = _client.Address.Zip.ToString();

                    cbx_clientstatus.Text = (_client.IsActive ? "Active" : "Inactive");

                    txt_poe.Text = _client.PointOfEntry;

                    dtp_dob.Value = _client.DateOfBirth;
                    dtp_doe.Value = _client.DateOfEntry;
                }
            } catch (Exception ex) { AddMessage("Could not load client "); }
        }

        /// <summary>
        /// sets the clients members with the data from the text boxes
        /// </summary>
        protected void ApplyCurrentClientChanges() {

            if (currentClient != null) {
                currentClient.A_Number = long.Parse(txt_anumber.Text);
                currentClient.FirstName = txt_firstname.Text;
                currentClient.LastName = txt_lastname.Text;
                currentClient.PhoneNumber = long.Parse(txt_phone.Text);


                currentClient.Address.Line1 = txt_line1.Text;
                currentClient.Address.Line2 = txt_line2.Text;
                currentClient.Address.City = txt_city.Text;
                currentClient.Address.State = txt_state.Text;
                currentClient.Address.Zip = long.Parse(txt_zip.Text);

                currentClient.PointOfEntry = txt_poe.Text;

                currentClient.DateOfBirth = dtp_dob.Value;
                currentClient.DateOfEntry = dtp_doe.Value;

                currentClient.IsActive = cbx_clientstatus.SelectedItem == "Active";
            }

        }

        private void EditClientClick(object sender, EventArgs e) {

            //the edit button has already been pressed and currently displays 'Save'
            if (isEditingClient) {
                string clientName = currentClient.FirstName + " " + currentClient.LastName;

                DialogResult choice = MessageBox.Show($"Save changes made to {clientName}", "Confirm Changes", MessageBoxButtons.YesNoCancel);

                switch (choice) {
                    case DialogResult.Yes: {
                            //do linq to update current client
                            using (CarlosMoran_Clients db = new()) {

                                TblClient? _client = db.TblClients.Where(c => c.Id == currentClient.Id.ToString())
                                                        .FirstOrDefault() ?? null;

                                TblAddress? _address = db.TblAddresses.Where( a => a.Id == currentClient.Address.Id.ToString() )
                                                        .FirstOrDefault() ?? null;

                                //we found the client
                                if (_client != null && _address != null ) {
                                    //make sure client has the latest data input from user.
                                    ApplyCurrentClientChanges();

                                    //update the client with the changes
                                    _client.copy(currentClient.ToDbObject());
                                    _address.copy(currentClient.Address.ToDbObject());

                                    //update the database
                                    int affected = db.SaveChanges();
                                    
                                    //display if operation was success
                                    if( affected > 0) {

                                        this.AddMessage($"Client updated");
                                        //reload the datagrid
                                        RefreshDgvClients();
                                       
                                    }else {
                                        //twas not success
                                        this.AddMessage( "Could not update client ERR20");
                                    }
                                    
                                }
                                //client not found somehow
                                else {
                                    goto default;
                                }

                            }

                            ToggleEditClientMode(false);
                        }
                        break;
                    case DialogResult.No: {
                            //reset the values in the text boxes
                            ChangeCurrentClient(currentClient);
                            //both yes and no should disable everything on exit
                            ToggleEditClientMode(false);

                        }
                        break;
                    case DialogResult.Cancel: break;    //if cancel, user continues to edit
                    default:
                        MessageBox.Show("A Fatal Error Has Occured: Please Call Nathan and Complain... E01 ");
                        goto case DialogResult.No;

                        break;
                }

            }
            //The edit button has not been pressed and panel is disabled 
            //button displays 'Edit'
            else {
                //panel should currently be disabled. 
                ToggleEditClientMode(true);

            }

        }

        private void DeleteClientClick(object sender, EventArgs e) {
            //display a message warning the user

            string clientName = $"{currentClient.FirstName} {currentClient.LastName}";

            DialogResult result =
            MessageBox.Show($"Delete {clientName}? If they have associated documents, deleting could corrupt the database file."
                    , "Confirm Delete"
                    , MessageBoxButtons.YesNo);

            switch (result) {

                case DialogResult.Yes: {

                        using (CarlosMoran_Clients db = new()) {
                            //look for the client to delete;
                            TblClient? _client = db.TblClients.Where(c => c.Id == currentClient.Id.ToString())
                                                              .FirstOrDefault() ?? null;

                            if (_client != null) {
                                db.Remove(_client);

                                int rows = db.SaveChanges();

                                if (rows > 0) {
                                    ChangeCurrentClient(null);
                                    AddMessage($"deleted {clientName}");
                                    dgv_clients.Rows.Remove(dgv_clients.CurrentRow);

                                    ToggleEditClientMode(false);
                                }
                            }
                        }

                    }
                    break;

            }
        }

        #endregion

        #region [ Document ]

        protected Document currentDocument;

        protected void ControlDisabledFontColors(object sender, EventArgs e) {

        }

        /// <summary>
        /// Loads the documents from the database that pertain to the currentClient
        /// </summary>
        private void LoadDocumentsForClient() {

            dgv_documents.Rows.Clear();

            //load dgv_document && cbx_documenttype
            using (CarlosMoran_Clients db = new()) {

                //Getting the users documents
                IQueryable<TblDocument>? docs = db.TblDocuments.Where(
                    d => d.ClientId == currentClient.Id.ToString() &&
                            d.DocumentId == null);

                try {
                    foreach (TblDocument t in docs) {

                        Document d = new(t);

                        string filed = d.FiledDate > Conversion.FromUnixEpoch( 0 ) ? d.FiledDate.ToShortDateString() : "";

                        //id, title, created, due
                        dgv_documents.Rows.Add(d.Id.ToString(), d.Title, d.CreateDate.ToShortDateString(), d.DueDate.ToShortDateString() , filed );


                    }
                } catch (Exception e) { } //ignore 


            }

            //also load the documents that this document requires
            LoadRequiredDocuments();
        }

        /// <summary>
        /// Event handler for when a document is selected in the document tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocumentRowSelected(object sender, EventArgs e) {

            if (dgv_documents.Rows.Count == 0) {

            } else {

                //set a default value of null
                DataGridViewRow? selectedRow = null;

                //avoid index out of bounds error
                if (dgv_documents.SelectedRows.Count > 0) {
                    selectedRow = dgv_documents.SelectedRows[0];
                }

                try {
                    //make sure not accessing null object
                    if (selectedRow != null) {
                        string docid = selectedRow?.Cells["clm_id"].Value.ToString() ?? "ERROR";

                        using (CarlosMoran_Clients db = new()) {

                            Document? selected = null;

                            //if the id of the document is found... _selected will be null
                            TblDocument _selected = db.TblDocuments.Where(d => d.Id == docid).FirstOrDefault() ?? null;


                            if (_selected != null) {
                                selected = new Document(_selected);
                            }

                            //update the thing with the new client
                            ChangeCurrentDocument(selected);

                        }

                    }
                } catch (Exception ex) { }


            }

        }

        /// <summary>
        /// Sets the relevant text boxes with the Document members
        /// </summary>
        /// <param name="selected"></param>
        private void ChangeCurrentDocument(Document? _selected = null) {
            currentDocument = _selected;

            //clear document details.
            txt_doctype.Text = "";
            txt_documentdescription.Text = "";
            dtp_createdate.Value = DateTime.Now;
            dtp_duedate.Value = DateTime.Now;
            txt_documenttitle.Text = "";

            try {
                if (_selected != null) {
                    txt_doctype.Text = currentDocument.Type;
                    txt_documentdescription.Text = currentDocument.Description;
                    dtp_createdate.Value = currentDocument.CreateDate;
                    dtp_duedate.Value = currentDocument.DueDate;
                    txt_documenttitle.Text = currentDocument.Title;

                    LoadRequiredDocuments();
                }
            } catch (Exception ex) { AddMessage("Could not load document "); }
        }



        private void dgv_documents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dtp_duedate_ValueChanged(object sender, EventArgs e) {

        }

        private void newDocumentFormClosed(object? sender, FormClosedEventArgs e) {

            LoadDocumentsForClient();

        }

        private void btn_newdocument_click(object sender, EventArgs e) {
            currentDocument = new(currentClient.Id);

            NewDocumentForm form = new(currentDocument);
            form.FormClosed += newDocumentFormClosed;

            form.SetHeaderText("New Document");

            form.ShowDialog(this);
        }

        /// <summary>
        /// Launches the <see cref="NewDocumentForm"></see> to allow the user to enter a new document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editdocument_click(object sender, EventArgs e) {
            NewDocumentForm form = new(currentDocument);
            form.FormClosed += newDocumentFormClosed;

            form.SetHeaderText("Edit Document");

            form.ShowDialog(this);
        }

        /// <summary>
        /// Launches a dialog box confirming the users choice. Reminds them of marking complete instead
        /// </summary>
        private void btn_deletedocument_Click(object sender, EventArgs e) {

            DialogResult res =
            MessageBox.Show($"Delete {currentDocument.Title}?", "Cancel", MessageBoxButtons.YesNo);

            switch (res) {

                case DialogResult.Yes: {
                        using (CarlosMoran_Clients db = new()) {

                            TblDocument doc = currentDocument.ToDbObject();

                            db.Remove(doc);

                            int rows = db.SaveChanges();

                            if (rows == 0) { AddMessage("Could not remove document from database ERR06"); }

                        }

                        //Clears current document as well?
                        //it does
                        LoadDocumentsForClient();

                    }
                    break;

                case DialogResult.No: {
                        //nuthin'

                    }
                    break;

            }
        }

        #endregion

        #region [ Required Documents ]

        protected Document currentReqDocument;

        /// <summary>
        /// clears the req data grid view and loads the items from the db
        /// using the current document 
        /// </summary>
        private void LoadRequiredDocuments() {

            dgv_required.Rows.Clear();

            if (currentDocument != null) {

                using (CarlosMoran_Clients db = new()) {
                    IQueryable<TblDocument>? reqs = db.TblDocuments
                        .Where(r => r.DocumentId == currentDocument.Id.ToString());
                         //&& r.Completed == 0);

                    if (reqs != null) foreach (TblDocument doc in reqs) {

                            Document d = new(doc);

                            string completed = (d.Completed ? "Yes" : "" );

                            dgv_required.Rows.Add(d.Id.ToString(), d.Title, d.CreateDate, d.DueDate, completed );
                    }
                }

            }


        }


        /// <summary>
        /// Updates the form's UI elements with information from the document
        /// passed to it. Should be the one the user selects from the 
        /// <see cref="DataGridView">dgv_documents</see>
        /// </summary>
        /// <param name="tblDocument"></param>
        private void ChangeCurrentRequiredDocument(TblDocument? tblDocument) {

            currentReqDocument = null;
            
            txt_reqtitle.Text = "";
            txt_reqdescription.Text = "";
            txt_reqtype.Text = "";
            txt_reqcreatedate.Text = DateTime.Now.Date.ToShortDateString();
            txt_reqdue.Text = DateTime.Now.Date.AddDays(7).ToShortDateString();

            if (tblDocument != null) {

                currentReqDocument = new(tblDocument);

                txt_reqtitle.Text = currentReqDocument.Title;
                txt_reqdescription.Text = currentReqDocument.Description;
                txt_reqtype.Text = currentReqDocument.Type;
                txt_reqcreatedate.Text = currentReqDocument.CreateDate.Date.ToShortDateString();
                txt_reqdue.Text = currentReqDocument.DueDate.Date.ToShortDateString();

            }

        }

        /// <summary>
        /// Event handler for selecting a required document from the datagrid.
        /// </summary>
        private void ReqDocumentRowSelected(object sender, EventArgs e) {

            //avoiding index out of range and null reference exceptions
            if (dgv_required.SelectedRows.Count > 0) {
                Guid guid;

                try {

                    string id = dgv_required.SelectedRows[0].Cells["Id"].Value.ToString();
                    guid = new Guid(id);

                } catch (Exception eee) { return; }

                using (CarlosMoran_Clients db = new()) {
                    TblDocument? doc = db.TblDocuments.Where(d => d.Id == guid.ToString()).FirstOrDefault() ?? null;

                    ChangeCurrentRequiredDocument(doc);

                }

            }

        }

        private void NewReqFormClosed(object sender, FormClosedEventArgs e) {
            LoadRequiredDocuments();
        }

        private void btn_newrequired_Click(object sender, EventArgs e) {
            Document req = new(currentClient.Id);

            NewDocumentForm form = new(req, currentDocument.Id);
            form.SetHeaderText("Add New Required Item");
            form.FormClosed += NewReqFormClosed;
            form.dtp_filedate.Visible = false;
            form.lbl_filedate.Visible = false;

            form.ShowDialog(this);
        }

        private void btn_completerequired_Click(object sender, EventArgs e) {

            DialogResult res =
            MessageBox.Show($"Mark {currentReqDocument.Title} Completed? It will be retained for records but it will not show up as a required document."
                                , "Mark Complete"
                                , MessageBoxButtons.YesNoCancel);

            switch (res) {

                case DialogResult.Yes: {
                        using (CarlosMoran_Clients db = new()) {

                            TblDocument? doc = db.TblDocuments.Where(
                                d => d.Id == currentReqDocument.Id.ToString())
                                .FirstOrDefault() ?? null;

                            if (doc != null) {
                                doc.Completed = 1;
                            }

                            int rows = db.SaveChanges();

                            if (rows == 0) { AddMessage("Could not mark complete "); }

                        }

                        //Clears current document as well?
                        //it does
                        LoadRequiredDocuments();

                    }
                    break;

                case DialogResult.No: {
                        //nuthin'

                }
                break;

            }
        }

        #endregion

        private void mnu_about_Click(object sender, EventArgs e) {
            MessageBox.Show("Created by Nathan Krone \n\n\t [ March, 2024 ]", "About");
        }

        private void mnu_splitcontainer_Click(object sender, EventArgs e) {
            //launch a sample form with a split container

            using (SplitContainerForm spt = new()) spt.ShowDialog(this);


        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e) {

        }

        private void mnu_newuser_Click(object sender, EventArgs e) {
            AddMessage("New User Not Yet Implemented.");
        }

        private string GetLastBackup() {
            string res = "Not Found";


            if( File.Exists( BackupFilename )) {
                DateTime lWrite = File.GetLastWriteTime( BackupFilename );

                res = $" {lWrite.ToLongDateString()} at {lWrite.ToLongTimeString()}";
            }

            return res;
        }

        private void mnu_backuprecords_Click(object sender, EventArgs e) {

            //display a message box asking user to confirm their choice and capture the result
            //in 'res'
            DialogResult res = 
            MessageBox.Show($"Create a backup of your current records?\nThis will overwrite your previous backup.\n\nYour last backup was {GetLastBackup()}."
                , "Create Backup", MessageBoxButtons.YesNo);

            //determine what to do based on 'res'
            switch( res) {

                //user pressed yes
                case DialogResult.Yes: {
                    //copy the database to Backups/
                    try {
                        File.Copy( "CarlosMoran_Clients.db" , "Backups/CarlosMoran_Clients.db" , overwrite: true  );

                        //Display message reflecting success
                        AddMessage( "Created Backup of Database");

                    } catch (Exception ex ) {
                        //if exception is raised, print a message 
                        MessageBox.Show( ex.Message );
                    }

                }break;

                //user pressed no
                case DialogResult.No: {
                    //nuthin'
                }break;

            }
        }

        private void mnu_restorerecords_Click( object sender, EventArgs e) {



            DialogResult res = 
            MessageBox.Show( $"\t\t::WARNING::\nRestore most recent backup of client records?\n\nChanges made since {GetLastBackup()} will be lost", "Rollback Changes", MessageBoxButtons.YesNo);

            switch( res) {

                case DialogResult.Yes: {
                    //copy the database to Backups/
                    try {
                        File.Copy( "Backups/CarlosMoran_Clients.db" , "CarlosMoran_Clients.db" , overwrite: true );

                        AddMessage( "Rolled back Database");

                    } catch (Exception ex ) {
                        MessageBox.Show( ex.Message );

                    }

                }break;

                case DialogResult.No: {
                    //nuthin'

                }break;

            }
        }

        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e) {

        }
    }
}
