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
    
    
    public class mainForm : communicationForm {
        
        private static subForm formB = new subForm() ; 
      
        public mainForm() : base(formB) {

            this.Text = "Form A";

            formB.receiverForm = this;

            formB.Show();

        }



       

        

        

        

        

        
    }
}
