using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            QuedActions.Items.Clear();
            foreach (var item in Script.GetScript())
            {
                //input position delay repeat keycode
                ListViewItem newItem = new ListViewItem(item.input);
                newItem.SubItems.Add(Convert.ToString(item.position));
                newItem.SubItems.Add(Convert.ToString(item.delay));
                newItem.SubItems.Add(Convert.ToString(item.repeat));
                newItem.SubItems.Add(item.keycode);
            }

        }

        private Task Delay_Tick(object sender, EventArgs e)
        {
            
        }

        private void InputSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(InputSelect.SelectedItem) == "Keyboard")
            {
                RecordBTN.Enabled = true;
                KeycodeTBX.Enabled = true;
                SelectedTBX.Enabled = true;
            }
            else
            {
                SelectedTBX.Clear();
                SelectedTBX.Enabled = false;
            }
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            string input = "";
            bool isValid = false;
            foreach (var item in InputSelect.Items)
            {
                if (InputSelect.SelectedItem == item) isValid = true;
            }
            if (SelectedTBX.Text != null || SelectedTBX.Text != "")
            {
                input = $"Keyboard({SelectedTBX.Text})";
            }
            else if (Convert.ToString(InputSelect.SelectedItem) == "-select input-")
            {
                MessageBox.Show("Please select a input method.", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToString(InputSelect.SelectedItem) == "")
            {
                input = "[Hold]";
            }
            else input = Convert.ToString(InputSelect.SelectedItem);

            ScriptItem newItem = new ScriptItem
            {
                  
            };
        }

        bool _isRecording = false;
        public static string[] _args; // code, value, mod
        private void RecordBTN_Click(object sender, EventArgs e) //this doesn't work
        {
            if (_isRecording == false)
            {
                _isRecording = true;
                RecordBTN.Text = "Stop";
            }
            else
            {
                _isRecording = false;
                RecordBTN.Text = "Record";
            }
        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isRecording)
            {
                KeyDown += InputHandler.Event_KeyDown;
                if (_args != null)
                {
                    SelectedTBX.Text = $"{_args[0]} + {_args[2]}";
                    KeycodeTBX.Text = _args[1];
                }
            }
        }

        private void TestBTN_Click(object sender, EventArgs e)
        {

        }

        private void Run()
        {
            foreach (var item in Script.GetScript())
            {
                if (item.input.ToLower().Contains("keyboard")) { }
                else if (item.input.ToLower().Contains("mouse")) { }
                else if (item.input.ToLower().Contains("hold")) { }
            }
        }
    }
}