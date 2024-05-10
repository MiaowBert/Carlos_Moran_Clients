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
using DbObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarlosMoran_Clients_Project.Helpers;

namespace CarlosMoran_Clients_Project.Forms {
    public partial class NewDocumentForm : Form
    {

        public Document document;

        public NewDocumentForm(Document _target_doc, Guid? _document_id = null)
        {
            InitializeComponent();

            document = _target_doc; //if this is being edited

            if (_document_id != null)
                document.DocumentId = _document_id.Value; // if there is a value, then this is a required document for another document

            GetTypeComboBoxItems();

            PopulateFields();

        }

        /// <summary>
        /// Determine, based on the arguments provided in the Ctor, what 
        /// to display where it currently says... What it do.
        /// </summary>
        public void SetHeaderText(string val)
        {
            lbl_header.Text = val;
        }

        /// <summary>
        /// This should pull all of the relevant 'Types' from the db to
        /// populate the dropdown box containing all the type options
        /// User should optionally be able to enter in new ones
        /// </summary>
        public void GetTypeComboBoxItems()
        {
            using (CarlosMoran_Clients db = new())
            {

                IQueryable<TblDocument>? tblDocuments = db.TblDocuments.Where(

                    d => (d.DocumentId == null) == (document.DocumentId == null)
                );

                //just add the type to the cbx_types
                foreach (TblDocument t in tblDocuments)
                {

                    //compiler complains 't.TyPe MaY bE nUlL hErE'
                    if (t.Type != null)
                    {
                        //make sure there are no spaces hangin' around
                        string type = t.Type.Trim();

                        //make sure no duplicates are enterred for 'type'
                        if (cbx_types.Items.Contains(type) == false)
                        {

                            cbx_types.Items.Add(type);

                        }
                    }

                }//end for each

            }
        }

        /// <summary>
        /// fill the form's fields with data from the document
        /// </summary>
        public void PopulateFields()
        {

            if (document != null)
            {

                txt_title.Text = document.Title;
                txt_description.Text = document.Description;

                dtp_createdate.Text = document.CreateDate.ToShortDateString();
                dtp_duedate.Text = document.DueDate.ToShortDateString();

                //make sure filed date is not zero; 


                if ( document.FiledDate < DateTime.UnixEpoch.AddDays( 7 ) ||    //if fileddate is not set, it will be the default value
                     document.FiledDate > DateTime.Now.AddDays( 1 ) ) {         //Also make sure fileddate has not happened yet.

                    //if here, this is an invalid fileddate. 
                    //uncheck the box so that the date is blank
                    dtp_filedate.Checked = false;
                    Dtp_ValueChanged( (object)dtp_filedate , new EventArgs() );

                }else{

                    try
                    {
                        dtp_filedate.Text = document.FiledDate.ToShortDateString();
          
                    } catch ( Exception exz ) {
                        MessageBox.Show(exz.Message );
                    }

                }

                cbx_types.Text = document.Type;

            }

        }

        /// <summary>
        /// build the document item that will be added/edited to the database with the
        /// form's fields
        /// </summary>
        public void PopulateDocument()
        {
            if (document != null)
            {

                document.Title = txt_title.Text;
                document.Description = txt_description.Text;

                document.CreateDate = dtp_createdate.Value;
                document.DueDate = dtp_duedate.Value;

                //if the user has checked the filedate then save it. otherwise default
                if (dtp_filedate.Checked) document.FiledDate = dtp_filedate.Value;

                if (cbx_types.SelectedIndex != null)
                    document.Type = cbx_types.Text;

            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {

            DialogResult res =
            MessageBox.Show("Save Changes to Document?", "Confirm Changes", MessageBoxButtons.YesNoCancel);

            switch (res)
            {

                case DialogResult.Yes:
                    {
                        //user has chosen to save this document. 
                        PopulateDocument();

                        using (CarlosMoran_Clients db = new())
                        {
                            TblDocument doc = document.ToDbObject();

                            //check for its existence in the db
                            TblDocument? isFind = (db.TblDocuments.Where(
                                d => d.Id == document.Id.ToString())
                                .FirstOrDefault() ?? null);

                            if (isFind != null)
                            {
                                isFind.Copy(doc);

                            }
                            else
                            {
                                db.TblDocuments.Add(doc);

                            }

                            int rows = db.SaveChanges();

                            if (rows == 0) MessageBox.Show("Could not save document ERR05");

                        }

                        this.Close();

                    }
                    break;

                case DialogResult.No:
                    {
                        //discard changes and exit

                        this.Close();

                    }
                    break;

                case DialogResult.Cancel:
                    {
                        //nuthin'

                    }
                    break;

            }
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {

            DialogResult res =
            MessageBox.Show("Discard Changes and Exit?", "Cancel", MessageBoxButtons.YesNo);

            switch (res)
            {

                case DialogResult.Yes:
                    {

                        //close the form
                        this.Close();

                    }
                    break;

                case DialogResult.No:
                    {
                        //nuthin'

                    }
                    break;

            }
        }

        /// <summary>
        /// Sets the datetimepicker to blank if checkbox not checked
        /// </summary>
        /// <remarks>couldn't figure out how to use event handler from different file.</remarks>
        private void Dtp_ValueChanged(object sender, EventArgs e){
            Filter.Dtp_ValueChanged(sender, e);
        }

    }
}
