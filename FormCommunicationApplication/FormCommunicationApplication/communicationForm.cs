using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCommunicationApplication {
    
    public partial class communicationForm : Form {

        public string message;

        public formLayout layout;

        public communicationForm receiverForm;

        //Defalt Constructor of the communication form 
        public communicationForm() {

            InitializeComponent();

            layout = new formLayout(this);

            layout.Dock = DockStyle.Fill;

            this.Controls.Add(layout);

            this.AcceptButton = layout.sendButton; 


        }

        //Constructor of the communication with known receiver form 
        public communicationForm(communicationForm receiverForm) {
            
            InitializeComponent();

            this.receiverForm = receiverForm; 

            layout = new formLayout(this);

            layout.Dock = DockStyle.Fill;

            this.Controls.Add(layout);

            this.AcceptButton = layout.sendButton; 

        }

        public void sendMessage(string message) {

            this.receiverForm.layout.updateTextBox(message);


        }

        private void communicationForm_FormClosed(object sender, FormClosedEventArgs e) {

            Application.Exit();

        }



    }
}
