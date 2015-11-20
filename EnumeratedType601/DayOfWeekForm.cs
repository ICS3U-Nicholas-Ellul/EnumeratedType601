/*
 * Created by: Nicholas Ellul
 * Created on: 20-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 6-01
 * This program uses an enumerated data type and lets the user pick it from a list box.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumeratedType601
{
    public partial class frmDaysOfTheWeek : Form
    {
        //global delcaration
        enum DAYS
        {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday
        }


        public frmDaysOfTheWeek()
        {
            InitializeComponent();
          
            foreach(DAYS weekday in Enum.GetValues(typeof(DAYS)))
            {
                this.lstList.Items.Add(weekday);
            }
        }


        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when user clickes on day of week
            string selectedItem;

            selectedItem = Convert.ToString(this.lstList.SelectedItem);

            MessageBox.Show(selectedItem,"Your favourite day of the week is...");
        }



        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
