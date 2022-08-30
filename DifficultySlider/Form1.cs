using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySlider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text+= " - Release 1";
        }

        //global vars
        int guitarTierInt = 1;
        int bassTierInt = 1;
        int drumsTierInt = 1;
        int keysTierInt = 1;
        int vocalsTierInt = 1;
        int bandTierInt = 1;

        private void guitar_trackBar_Scroll(object sender, EventArgs e)
        {
            guitar_num_ud.Value = guitar_trackBar.Value;
            updateGuitarDots();   
        }

        private void guitar_num_ud_ValueChanged(object sender, EventArgs e)
        {
            if (guitar_num_ud.Value >= guitar_trackBar.Maximum)
            {
                guitar_trackBar.Maximum = (int)guitar_num_ud.Value;
            }
            guitar_trackBar.Value = (int)guitar_num_ud.Value;
            updateGuitarDots();
        }

        //function to update guitar dots using slider or num up/down
        private void updateGuitarDots()
        {
            guitarTierInt = guitar_trackBar.Value;

            //remove image and bring NO PART label to front
            if (guitarTierInt == 0)
            {
                guitar_tier1.Image = null;
                guitar_tier2.Image = null;
                guitar_tier3.Image = null;
                guitar_tier4.Image = null;
                guitar_tier5.Image = null;
                label_NoPart.Visible = true;
                label_NoPart.BringToFront();
            }
            else
            {
                label_NoPart.Visible = false;
            }

            //store regular guitar tier values to use below
            int tier1 = 139;
            int tier2 = 176;
            int tier3 = 221;
            int tier4 = 267;
            int tier5 = 333;
            int tier6 = 409;

            //use these numbers instead if Pro mode is checked
            if (checkBox_realGuitar.Checked == true)
            {
                tier1 = 150;
                tier2 = 208;
                tier3 = 267;
                tier4 = 325;
                tier5 = 384;
                tier6 = 442;
            }


            //begin checks for difficulty dot conditions
            if (guitarTierInt >= 1 && guitarTierInt <= tier1 - 1)
            {
                guitar_tier1.Image = Properties.Resources.blank_dot;
                guitar_tier2.Image = Properties.Resources.blank_dot;
                guitar_tier3.Image = Properties.Resources.blank_dot;
                guitar_tier4.Image = Properties.Resources.blank_dot;
                guitar_tier5.Image = Properties.Resources.blank_dot;
            }
            if (guitarTierInt >= tier1 && guitarTierInt <= tier2 - 1)
            {
                guitar_tier1.Image = Properties.Resources.normal_dot;
                guitar_tier2.Image = Properties.Resources.blank_dot;
                guitar_tier3.Image = Properties.Resources.blank_dot;
                guitar_tier4.Image = Properties.Resources.blank_dot;
                guitar_tier5.Image = Properties.Resources.blank_dot;
            }
            if (guitarTierInt >= tier2 && guitarTierInt <= tier3 - 1)
            {
                guitar_tier1.Image = Properties.Resources.normal_dot;
                guitar_tier2.Image = Properties.Resources.normal_dot;
                guitar_tier3.Image = Properties.Resources.blank_dot;
                guitar_tier4.Image = Properties.Resources.blank_dot;
                guitar_tier5.Image = Properties.Resources.blank_dot;
            }
            if (guitarTierInt >= tier3 && guitarTierInt <= tier4 - 1)
            {
                guitar_tier1.Image = Properties.Resources.normal_dot;
                guitar_tier2.Image = Properties.Resources.normal_dot;
                guitar_tier3.Image = Properties.Resources.normal_dot;
                guitar_tier4.Image = Properties.Resources.blank_dot;
                guitar_tier5.Image = Properties.Resources.blank_dot;
            }
            if (guitarTierInt >= tier4 && guitarTierInt <= tier5 - 1)
            {
                guitar_tier1.Image = Properties.Resources.normal_dot;
                guitar_tier2.Image = Properties.Resources.normal_dot;
                guitar_tier3.Image = Properties.Resources.normal_dot;
                guitar_tier4.Image = Properties.Resources.normal_dot;
                guitar_tier5.Image = Properties.Resources.blank_dot;
            }
            if (guitarTierInt >= tier5 && guitarTierInt <= tier6 - 1)
            {
                guitar_tier1.Image = Properties.Resources.normal_dot;
                guitar_tier2.Image = Properties.Resources.normal_dot;
                guitar_tier3.Image = Properties.Resources.normal_dot;
                guitar_tier4.Image = Properties.Resources.normal_dot;
                guitar_tier5.Image = Properties.Resources.normal_dot;
            }
            if (guitarTierInt >= tier6 && guitarTierInt <= 600)
            {
                guitar_tier1.Image = Properties.Resources.devil_dot;
                guitar_tier2.Image = Properties.Resources.devil_dot;
                guitar_tier3.Image = Properties.Resources.devil_dot;
                guitar_tier4.Image = Properties.Resources.devil_dot;
                guitar_tier5.Image = Properties.Resources.devil_dot;
            }
        }

        private void updateBassDots()
        {
            bassTierInt = bass_trackBar.Value;

            if (bassTierInt == 0)
            {
                bass_tier1.Image = null;
                bass_tier2.Image = null;
                bass_tier3.Image = null;
                bass_tier4.Image = null;
                bass_tier5.Image = null;
                label_noPart2.Visible = true;
                label_noPart2.BringToFront();
            }
            else
            {
                label_noPart2.Visible = false;
            }

            int tier1 = 135;
            int tier2 = 181;
            int tier3 = 228;
            int tier4 = 293;
            int tier5 = 364;
            int tier6 = 436;

            if (checkBox_realBass.Checked == true)
            {
                tier1 = 150;
                tier2 = 208;
                tier3 = 267;
                tier4 = 325;
                tier5 = 384;
                tier6 = 442;
            }

            if (bassTierInt >= 1 && bassTierInt <= tier1 - 1)
            {
                bass_tier1.Image = Properties.Resources.blank_dot;
                bass_tier2.Image = Properties.Resources.blank_dot;
                bass_tier3.Image = Properties.Resources.blank_dot;
                bass_tier4.Image = Properties.Resources.blank_dot;
                bass_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bassTierInt >= tier1 && bassTierInt <= tier2 - 1)
            {
                bass_tier1.Image = Properties.Resources.normal_dot;
                bass_tier2.Image = Properties.Resources.blank_dot;
                bass_tier3.Image = Properties.Resources.blank_dot;
                bass_tier4.Image = Properties.Resources.blank_dot;
                bass_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bassTierInt >= tier2 && bassTierInt <= tier3 - 1)
            {
                bass_tier1.Image = Properties.Resources.normal_dot;
                bass_tier2.Image = Properties.Resources.normal_dot;
                bass_tier3.Image = Properties.Resources.blank_dot;
                bass_tier4.Image = Properties.Resources.blank_dot;
                bass_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bassTierInt >= tier3 && bassTierInt <= tier4 - 1)
            {
                bass_tier1.Image = Properties.Resources.normal_dot;
                bass_tier2.Image = Properties.Resources.normal_dot;
                bass_tier3.Image = Properties.Resources.normal_dot;
                bass_tier4.Image = Properties.Resources.blank_dot;
                bass_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bassTierInt >= tier4 && bassTierInt <= tier5 - 1)
            {
                bass_tier1.Image = Properties.Resources.normal_dot;
                bass_tier2.Image = Properties.Resources.normal_dot;
                bass_tier3.Image = Properties.Resources.normal_dot;
                bass_tier4.Image = Properties.Resources.normal_dot;
                bass_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bassTierInt >= tier5 && bassTierInt <= tier6 - 1)
            {
                bass_tier1.Image = Properties.Resources.normal_dot;
                bass_tier2.Image = Properties.Resources.normal_dot;
                bass_tier3.Image = Properties.Resources.normal_dot;
                bass_tier4.Image = Properties.Resources.normal_dot;
                bass_tier5.Image = Properties.Resources.normal_dot;
            }
            if (bassTierInt >= tier6 && bassTierInt <= 600)
            {
                bass_tier1.Image = Properties.Resources.devil_dot;
                bass_tier2.Image = Properties.Resources.devil_dot;
                bass_tier3.Image = Properties.Resources.devil_dot;
                bass_tier4.Image = Properties.Resources.devil_dot;
                bass_tier5.Image = Properties.Resources.devil_dot;
            }
        }

        private void updateDrumsDots()
        {
            drumsTierInt = drums_trackBar.Value;

            if (drumsTierInt == 0)
            {
                drums_tier1.Image = null;
                drums_tier2.Image = null;
                drums_tier3.Image = null;
                drums_tier4.Image = null;
                drums_tier5.Image = null;
                label_noPart3.Visible = true;
                label_noPart3.BringToFront();
            }
            else
            {
                label_noPart3.Visible = false;
            }

            if (drumsTierInt >= 1 && drumsTierInt <= 123)
            {
                drums_tier1.Image = Properties.Resources.blank_dot;
                drums_tier2.Image = Properties.Resources.blank_dot;
                drums_tier3.Image = Properties.Resources.blank_dot;
                drums_tier4.Image = Properties.Resources.blank_dot;
                drums_tier5.Image = Properties.Resources.blank_dot;
            }
            if (drumsTierInt >= 124 && drumsTierInt <= 150)
            {
                drums_tier1.Image = Properties.Resources.normal_dot;
                drums_tier2.Image = Properties.Resources.blank_dot;
                drums_tier3.Image = Properties.Resources.blank_dot;
                drums_tier4.Image = Properties.Resources.blank_dot;
                drums_tier5.Image = Properties.Resources.blank_dot;
            }
            if (drumsTierInt >= 151 && drumsTierInt <= 177)
            {
                drums_tier1.Image = Properties.Resources.normal_dot;
                drums_tier2.Image = Properties.Resources.normal_dot;
                drums_tier3.Image = Properties.Resources.blank_dot;
                drums_tier4.Image = Properties.Resources.blank_dot;
                drums_tier5.Image = Properties.Resources.blank_dot;
            }
            if (drumsTierInt >= 178 && drumsTierInt <= 241)
            {
                drums_tier1.Image = Properties.Resources.normal_dot;
                drums_tier2.Image = Properties.Resources.normal_dot;
                drums_tier3.Image = Properties.Resources.normal_dot;
                drums_tier4.Image = Properties.Resources.blank_dot;
                drums_tier5.Image = Properties.Resources.blank_dot;
            }
            if (drumsTierInt >= 242 && drumsTierInt <= 344)
            {
                drums_tier1.Image = Properties.Resources.normal_dot;
                drums_tier2.Image = Properties.Resources.normal_dot;
                drums_tier3.Image = Properties.Resources.normal_dot;
                drums_tier4.Image = Properties.Resources.normal_dot;
                drums_tier5.Image = Properties.Resources.blank_dot;
            }
            if (drumsTierInt >= 345 && drumsTierInt <= 447)
            {
                drums_tier1.Image = Properties.Resources.normal_dot;
                drums_tier2.Image = Properties.Resources.normal_dot;
                drums_tier3.Image = Properties.Resources.normal_dot;
                drums_tier4.Image = Properties.Resources.normal_dot;
                drums_tier5.Image = Properties.Resources.normal_dot;
            }
            if (drumsTierInt >= 448 && drumsTierInt <= 600)
            {
                drums_tier1.Image = Properties.Resources.devil_dot;
                drums_tier2.Image = Properties.Resources.devil_dot;
                drums_tier3.Image = Properties.Resources.devil_dot;
                drums_tier4.Image = Properties.Resources.devil_dot;
                drums_tier5.Image = Properties.Resources.devil_dot;
            }
        }

        private void updateKeysDots()
        {
            keysTierInt = keys_trackBar.Value;

            if (keysTierInt == 0)
            {
                keys_tier1.Image = null;
                keys_tier2.Image = null;
                keys_tier3.Image = null;
                keys_tier4.Image = null;
                keys_tier5.Image = null;
                label_noPart4.Visible = true;
                label_noPart4.BringToFront();
            }
            else
            {
                label_noPart4.Visible = false;
            }

            int tier1 = 153;
            int tier2 = 211;
            int tier3 = 269;
            int tier4 = 327;
            int tier5 = 385;
            int tier6 = 443;

            if (checkBox_realKeys.Checked == true)
            {
                //tier1 = 153;
                //tier2 = 211;
                //tier3 = 269;
                //tier4 = 327;
                //tier5 = 385;
                //tier6 = 443;
            }

            if (keysTierInt >= 1 && keysTierInt <= tier1 - 1)
            {
                keys_tier1.Image = Properties.Resources.blank_dot;
                keys_tier2.Image = Properties.Resources.blank_dot;
                keys_tier3.Image = Properties.Resources.blank_dot;
                keys_tier4.Image = Properties.Resources.blank_dot;
                keys_tier5.Image = Properties.Resources.blank_dot;
            }
            if (keysTierInt >= tier1 && keysTierInt <= tier2 - 1)
            {
                keys_tier1.Image = Properties.Resources.normal_dot;
                keys_tier2.Image = Properties.Resources.blank_dot;
                keys_tier3.Image = Properties.Resources.blank_dot;
                keys_tier4.Image = Properties.Resources.blank_dot;
                keys_tier5.Image = Properties.Resources.blank_dot;
            }
            if (keysTierInt >= tier2 && keysTierInt <= tier3 - 1)
            {
                keys_tier1.Image = Properties.Resources.normal_dot;
                keys_tier2.Image = Properties.Resources.normal_dot;
                keys_tier3.Image = Properties.Resources.blank_dot;
                keys_tier4.Image = Properties.Resources.blank_dot;
                keys_tier5.Image = Properties.Resources.blank_dot;
            }
            if (keysTierInt >= tier3 && keysTierInt <= tier4 - 1)
            {
                keys_tier1.Image = Properties.Resources.normal_dot;
                keys_tier2.Image = Properties.Resources.normal_dot;
                keys_tier3.Image = Properties.Resources.normal_dot;
                keys_tier4.Image = Properties.Resources.blank_dot;
                keys_tier5.Image = Properties.Resources.blank_dot;
            }
            if (keysTierInt >= tier4 && keysTierInt <= tier5 - 1)
            {
                keys_tier1.Image = Properties.Resources.normal_dot;
                keys_tier2.Image = Properties.Resources.normal_dot;
                keys_tier3.Image = Properties.Resources.normal_dot;
                keys_tier4.Image = Properties.Resources.normal_dot;
                keys_tier5.Image = Properties.Resources.blank_dot;
            }
            if (keysTierInt >= tier5 && keysTierInt <= tier6 - 1)
            {
                keys_tier1.Image = Properties.Resources.normal_dot;
                keys_tier2.Image = Properties.Resources.normal_dot;
                keys_tier3.Image = Properties.Resources.normal_dot;
                keys_tier4.Image = Properties.Resources.normal_dot;
                keys_tier5.Image = Properties.Resources.normal_dot;
            }
            if (keysTierInt >= tier6 && keysTierInt <= 600)
            {
                keys_tier1.Image = Properties.Resources.devil_dot;
                keys_tier2.Image = Properties.Resources.devil_dot;
                keys_tier3.Image = Properties.Resources.devil_dot;
                keys_tier4.Image = Properties.Resources.devil_dot;
                keys_tier5.Image = Properties.Resources.devil_dot;
            }
        }

        private void updateVocalsDots()
        {
            vocalsTierInt = vocals_trackBar.Value;

            if (vocalsTierInt == 0)
            {
                vocals_tier1.Image = null;
                vocals_tier2.Image = null;
                vocals_tier3.Image = null;
                vocals_tier4.Image = null;
                vocals_tier5.Image = null;
                label_noPart5.Visible = true;
                label_noPart5.BringToFront();
            }
            else
            {
                label_noPart5.Visible = false;
            }

            if (vocalsTierInt >= 1 && vocalsTierInt <= 131)
            {
                vocals_tier1.Image = Properties.Resources.blank_dot;
                vocals_tier2.Image = Properties.Resources.blank_dot;
                vocals_tier3.Image = Properties.Resources.blank_dot;
                vocals_tier4.Image = Properties.Resources.blank_dot;
                vocals_tier5.Image = Properties.Resources.blank_dot;
            }
            if (vocalsTierInt >= 132 && vocalsTierInt <= 174)
            {
                vocals_tier1.Image = Properties.Resources.normal_dot;
                vocals_tier2.Image = Properties.Resources.blank_dot;
                vocals_tier3.Image = Properties.Resources.blank_dot;
                vocals_tier4.Image = Properties.Resources.blank_dot;
                vocals_tier5.Image = Properties.Resources.blank_dot;
            }
            if (vocalsTierInt >= 175 && vocalsTierInt <= 217)
            {
                vocals_tier1.Image = Properties.Resources.normal_dot;
                vocals_tier2.Image = Properties.Resources.normal_dot;
                vocals_tier3.Image = Properties.Resources.blank_dot;
                vocals_tier4.Image = Properties.Resources.blank_dot;
                vocals_tier5.Image = Properties.Resources.blank_dot;
            }
            if (vocalsTierInt >= 218 && vocalsTierInt <= 278)
            {
                vocals_tier1.Image = Properties.Resources.normal_dot;
                vocals_tier2.Image = Properties.Resources.normal_dot;
                vocals_tier3.Image = Properties.Resources.normal_dot;
                vocals_tier4.Image = Properties.Resources.blank_dot;
                vocals_tier5.Image = Properties.Resources.blank_dot;
            }
            if (vocalsTierInt >= 279 && vocalsTierInt <= 352)
            {
                vocals_tier1.Image = Properties.Resources.normal_dot;
                vocals_tier2.Image = Properties.Resources.normal_dot;
                vocals_tier3.Image = Properties.Resources.normal_dot;
                vocals_tier4.Image = Properties.Resources.normal_dot;
                vocals_tier5.Image = Properties.Resources.blank_dot;
            }
            if (vocalsTierInt >= 353 && vocalsTierInt <= 426)
            {
                vocals_tier1.Image = Properties.Resources.normal_dot;
                vocals_tier2.Image = Properties.Resources.normal_dot;
                vocals_tier3.Image = Properties.Resources.normal_dot;
                vocals_tier4.Image = Properties.Resources.normal_dot;
                vocals_tier5.Image = Properties.Resources.normal_dot;
            }
            if (vocalsTierInt >= 427 && vocalsTierInt <= 600)
            {
                vocals_tier1.Image = Properties.Resources.devil_dot;
                vocals_tier2.Image = Properties.Resources.devil_dot;
                vocals_tier3.Image = Properties.Resources.devil_dot;
                vocals_tier4.Image = Properties.Resources.devil_dot;
                vocals_tier5.Image = Properties.Resources.devil_dot;
            }
        }

        private void updateBandDots()
        {
            bandTierInt = band_trackBar.Value;
            if (bandTierInt >= 1 && bandTierInt <= 164)
            {
                band_tier1.Image = Properties.Resources.blank_dot;
                band_tier2.Image = Properties.Resources.blank_dot;
                band_tier3.Image = Properties.Resources.blank_dot;
                band_tier4.Image = Properties.Resources.blank_dot;
                band_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bandTierInt >= 165 && bandTierInt <= 214)
            {
                band_tier1.Image = Properties.Resources.normal_dot;
                band_tier2.Image = Properties.Resources.blank_dot;
                band_tier3.Image = Properties.Resources.blank_dot;
                band_tier4.Image = Properties.Resources.blank_dot;
                band_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bandTierInt >= 215 && bandTierInt <= 242)
            {
                band_tier1.Image = Properties.Resources.normal_dot;
                band_tier2.Image = Properties.Resources.normal_dot;
                band_tier3.Image = Properties.Resources.blank_dot;
                band_tier4.Image = Properties.Resources.blank_dot;
                band_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bandTierInt >= 243 && bandTierInt <= 266)
            {
                band_tier1.Image = Properties.Resources.normal_dot;
                band_tier2.Image = Properties.Resources.normal_dot;
                band_tier3.Image = Properties.Resources.normal_dot;
                band_tier4.Image = Properties.Resources.blank_dot;
                band_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bandTierInt >= 267 && bandTierInt <= 291)
            {
                band_tier1.Image = Properties.Resources.normal_dot;
                band_tier2.Image = Properties.Resources.normal_dot;
                band_tier3.Image = Properties.Resources.normal_dot;
                band_tier4.Image = Properties.Resources.normal_dot;
                band_tier5.Image = Properties.Resources.blank_dot;
            }
            if (bandTierInt >= 292 && bandTierInt <= 344)
            {
                band_tier1.Image = Properties.Resources.normal_dot;
                band_tier2.Image = Properties.Resources.normal_dot;
                band_tier3.Image = Properties.Resources.normal_dot;
                band_tier4.Image = Properties.Resources.normal_dot;
                band_tier5.Image = Properties.Resources.normal_dot;
            }
            if (bandTierInt >= 345 && bandTierInt <= 600)
            {
                band_tier1.Image = Properties.Resources.devil_dot;
                band_tier2.Image = Properties.Resources.devil_dot;
                band_tier3.Image = Properties.Resources.devil_dot;
                band_tier4.Image = Properties.Resources.devil_dot;
                band_tier5.Image = Properties.Resources.devil_dot;
            }
        }

        private void bass_trackBar_Scroll(object sender, EventArgs e)
        {
            bass_num_ud.Value = bass_trackBar.Value;
            updateBassDots();
        }

        private void bass_num_ud_ValueChanged(object sender, EventArgs e)
        {
            if (bass_num_ud.Value >= bass_trackBar.Maximum)
            {
                bass_trackBar.Maximum = (int)bass_num_ud.Value;
            }
            bass_trackBar.Value = (int)bass_num_ud.Value;
            updateBassDots();
        }

        private void drums_trackBar_Scroll(object sender, EventArgs e)
        {
            drums_num_ud.Value = drums_trackBar.Value;
            updateDrumsDots();
        }

        private void drums_num_ud_ValueChanged(object sender, EventArgs e)
        {
            if (drums_num_ud.Value >= drums_trackBar.Maximum)
            {
                drums_trackBar.Maximum = (int)drums_num_ud.Value;
            }
            drums_trackBar.Value = (int)drums_num_ud.Value;
            updateDrumsDots();
        }

        private void keys_trackBar_Scroll(object sender, EventArgs e)
        {
            keys_num_ud.Value = keys_trackBar.Value;
            updateKeysDots();
        }

        private void keys_num_ud_ValueChanged(object sender, EventArgs e)
        {
            if (keys_num_ud.Value >= keys_trackBar.Maximum)
            {
                keys_trackBar.Maximum = (int)keys_num_ud.Value;
            }
            keys_trackBar.Value = (int)keys_num_ud.Value;
            updateKeysDots();
        }

        private void vocals_trackBar_Scroll(object sender, EventArgs e)
        {
            vocals_num_ud.Value = vocals_trackBar.Value;
            updateVocalsDots();
        }

        private void vocals_num_ud_ValueChanged(object sender, EventArgs e)
        {
            if (vocals_num_ud.Value >= vocals_trackBar.Maximum)
            {
                vocals_trackBar.Maximum = (int)vocals_num_ud.Value;
            }
            vocals_trackBar.Value = (int)vocals_num_ud.Value;
            updateVocalsDots();
        }

        private void band_trackBar_Scroll(object sender, EventArgs e)
        {
            band_num_ud.Value = band_trackBar.Value;
            updateBandDots();
        }

        private void band_num_ud_ValueChanged(object sender, EventArgs e)
        {
            if (band_num_ud.Value >= band_trackBar.Maximum)
            {
                band_trackBar.Maximum = (int)band_num_ud.Value;
            }
            band_trackBar.Value = (int)band_num_ud.Value;
            updateBandDots();
        }

        private void band_button_avg_Click(object sender, EventArgs e)
        {
            band_num_ud.Value = getBandAverage();
        }

        //function to get average based on difficulty tiers entered
        public int getBandAverage()
        {
            int total = 0;
            int count = 0;
            if (guitarTierInt > 0)
            {
                total += guitarTierInt;
                count++;
            }
            if (bassTierInt > 0)
            {
                total += bassTierInt;
                count++;
            }
            if (drumsTierInt > 0)
            {
                total += drumsTierInt;
                count++;
            }
            if (keysTierInt > 0)
            {
                total += keysTierInt;
                count++;
            }
            if (vocalsTierInt > 0)
            {
                total += vocalsTierInt;
                count++;
            }

            int average = total / count;
            return average;
        }

        //dot click functions
        private void guitar_tier1_Click(object sender, EventArgs e)
        {
            guitar_num_ud.Value = 139;
            updateGuitarDots();
        }

        private void guitar_tier2_Click(object sender, EventArgs e)
        {
            guitar_num_ud.Value = 176;
            updateGuitarDots();
        }

        private void guitar_tier3_Click(object sender, EventArgs e)
        {
            guitar_num_ud.Value = 221;
            updateGuitarDots();
        }

        private void guitar_tier4_Click(object sender, EventArgs e)
        {
            guitar_num_ud.Value = 267;
            updateGuitarDots();
        }

        private void guitar_tier5_Click(object sender, EventArgs e)
        {
            guitar_num_ud.Value = 333;
            updateGuitarDots();
        }

        private void bass_tier1_Click(object sender, EventArgs e)
        {
            bass_num_ud.Value = 135;
            updateBassDots();
        }

        private void bass_tier2_Click(object sender, EventArgs e)
        {
            bass_num_ud.Value = 181;
            updateBassDots();
        }

        private void bass_tier3_Click(object sender, EventArgs e)
        {
            bass_num_ud.Value = 228;
            updateBassDots();
        }

        private void bass_tier4_Click(object sender, EventArgs e)
        {
            bass_num_ud.Value = 293;
            updateBassDots();
        }

        private void bass_tier5_Click(object sender, EventArgs e)
        {
            bass_num_ud.Value = 364;
            updateBassDots();
        }

        private void drums_tier1_Click(object sender, EventArgs e)
        {
            drums_num_ud.Value = 124;
            updateBassDots();
        }

        private void drums_tier2_Click(object sender, EventArgs e)
        {
            drums_num_ud.Value = 151;
            updateBassDots();
        }

        private void drums_tier3_Click(object sender, EventArgs e)
        {
            drums_num_ud.Value = 178;
            updateBassDots();
        }

        private void drums_tier4_Click(object sender, EventArgs e)
        {
            drums_num_ud.Value = 242;
            updateBassDots();
        }

        private void drums_tier5_Click(object sender, EventArgs e)
        {
            drums_num_ud.Value = 345;
            updateBassDots();
        }

        private void keys_tier1_Click(object sender, EventArgs e)
        {
            keys_num_ud.Value = 153;
            updateKeysDots();
        }

        private void keys_tier2_Click(object sender, EventArgs e)
        {
            keys_num_ud.Value = 211;
            updateKeysDots();
        }

        private void keys_tier3_Click(object sender, EventArgs e)
        {
            keys_num_ud.Value = 269;
            updateKeysDots();
        }

        private void keys_tier4_Click(object sender, EventArgs e)
        {
            keys_num_ud.Value = 327;
            updateKeysDots();
        }

        private void keys_tier5_Click(object sender, EventArgs e)
        {
            keys_num_ud.Value = 385;
            updateKeysDots();
        }

        private void vocals_tier1_Click(object sender, EventArgs e)
        {
            vocals_num_ud.Value = 132;
            updateVocalsDots();
        }

        private void vocals_tier2_Click(object sender, EventArgs e)
        {
            vocals_num_ud.Value = 175;
            updateVocalsDots();
        }

        private void vocals_tier3_Click(object sender, EventArgs e)
        {
            vocals_num_ud.Value = 218;
            updateVocalsDots();
        }

        private void vocals_tier4_Click(object sender, EventArgs e)
        {
            vocals_num_ud.Value = 279;
            updateVocalsDots();
        }

        private void vocals_tier5_Click(object sender, EventArgs e)
        {
            vocals_num_ud.Value = 353;
            updateVocalsDots();
        }

        private void band_tier1_Click(object sender, EventArgs e)
        {
            band_num_ud.Value = 165;
            updateBandDots();
        }

        private void band_tier2_Click(object sender, EventArgs e)
        {
            band_num_ud.Value = 215;
            updateBandDots();
        }

        private void band_tier3_Click(object sender, EventArgs e)
        {
            band_num_ud.Value = 243;
            updateBandDots();
        }

        private void band_tier4_Click(object sender, EventArgs e)
        {
            band_num_ud.Value = 267;
            updateBandDots();
        }

        private void band_tier5_Click(object sender, EventArgs e)
        {
            band_num_ud.Value = 292;
            updateBandDots();
        }

        private void checkBox_realGuitar_CheckedChanged(object sender, EventArgs e)
        {
            updateGuitarDots();
        }

        private void checkBox_realBass_CheckedChanged(object sender, EventArgs e)
        {
            updateBassDots();
        }

        private void checkBox_realKeys_CheckedChanged(object sender, EventArgs e)
        {
            updateKeysDots();
        }
    }
}
