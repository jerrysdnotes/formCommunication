using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCommunicationApplication {
    public partial class formLayout : UserControl {

        //Property to store the parent form ID 
        private communicationForm parentForm;

        public Button sendButton; 

        //Add the Form parameter in the constructor, so this control can get the ID 
        public formLayout(communicationForm parentForm) {
            InitializeComponent();

            this.parentForm = parentForm;

            this.sendButton = sendMessageButton; 
        }

        
        //On-Click Event of the sendMessage Button
        private void sendMessageButton_Click(object sender, EventArgs e) {

            sendMessageAction();

        }


        //Update Converation Text Box with the message
        public void updateTextBox(string message) {

            conversationTextBox.AppendText(message);

        }

        //MessageBox KeyDown Event (When user clicks enter, the message will be sent)
        private void messageTextBox_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {

                sendMessageAction();

            }

        }

        //Send Message Action 
        private void sendMessageAction() {

            string message = String.Format("{0} : {1}\n",
                                            parentForm.Text,
                                            messageTextBox.Text);

            //If messageTextBox is not empty, then send the message
            if (messageTextBox.Text != String.Empty) {

               
                conversationTextBox.AppendText(message);

                messageTextBox.Text = String.Empty;

                //Trigger Parent Form to get Message

                parentForm.sendMessage(message);

                




            } else {

                //If the messageTextBox is empty,then ask user to decide
                DialogResult userSelectedResult = MessageBox.Show("Do you want to send an empty text",
                                                                  "Question",
                                                                   MessageBoxButtons.YesNo,
                                                                   MessageBoxIcon.None);

                switch (userSelectedResult) {

                    case DialogResult.Yes:

                        conversationTextBox.AppendText(message);

                        messageTextBox.Text = String.Empty;

                        //Trigger Parent Form to get Message

                        parentForm.sendMessage(message);

                        break;

                    case DialogResult.No :

                        messageTextBox.Select();


                        break; 






                }





            }

        }


    }
}
