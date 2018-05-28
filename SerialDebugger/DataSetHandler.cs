using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialDebugger
{
    class DataSetHandler
    {
        public struct dataSet
        {
            private GroupBox groupBox;
            public GroupBox retGroupBox;
            private TextBox textBox;
            private Label unitLabel;
            public string messageID;

            public dataSet(string variableName, string ID, string Unit)
            {
                /* message id string, in incoming serial lines */
                messageID = ID;

                /* specified groupbox control to represent datas */
                groupBox = new GroupBox() { Text = variableName };
                groupBox.Size = new Size(100, 45);

                /* Fill groupbox with controls */
                /* Set Textbox */
                textBox = new TextBox();
                groupBox.Controls.Add(textBox);
                textBox.Size = new Size(75, 10);
                textBox.Location = new Point(5, 15);

                /* Set Unit label */
                unitLabel = new Label() { Text = Unit };
                groupBox.Controls.Add(unitLabel);
                unitLabel.Location = new Point(80, 17);

                retGroupBox = groupBox;
            }

            public GroupBox GetMyGroupBox
            {
                get
                {
                    return retGroupBox;
                }
            }

            public string SetVariableValue
            {
                get
                {
                    return textBox.Text;
                }

                set
                {
                    textBox.Text = value;
                }
            }
        }

        public void AddNewSet(string Name, string ID, string Unit)
        {
            
        }

        public void DeleteSet()
        {

        }

        public void ModifySet()
        {

        }
    }
}
