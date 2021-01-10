using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TodoListDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  event EventHandler clk;

      //  List<UserControl1> list;
        ArrayList list=new ArrayList();

        private void button2_Click(object sender, EventArgs e)
        {



            if (list.Count == 0)
            {
                UserControl1
                Userr = new UserControl1();
                Userr.Location = new System.Drawing.Point(88, 9);
                Userr.Name = "userControl11";
                Userr.Size = new System.Drawing.Size(586, 70);
                Userr.TabIndex = 0;
                list.Add(Userr);
                Delet s = new Delet(Userr);
                s.Show();
                this.panel2.Controls.Add((UserControl1)list[list.Count - 1]);
            }
            else
            {
                UserControl1
               Userr = new UserControl1();
                int y = ((UserControl1)list[list.Count - 1]).Location.Y + 80;
                Userr.Location = new System.Drawing.Point(88,y );
                Userr.Name = "userControl11";
                Userr.Size = new System.Drawing.Size(586, 70);
                Userr.TabIndex = 0;
                list.Add(Userr);
                Delet s = new Delet(Userr);
                s.Show();
                this.panel2.Controls.Add((UserControl1)list[list.Count - 1]);

            }
        }

        public void dlt(object sender)
        {
            int ff = list.IndexOf((UserControl1)sender);
            panel2.Controls.Remove((UserControl1)list[ff]);
            list.RemoveAt(ff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
