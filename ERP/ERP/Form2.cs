using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{
    public partial class Form2 : Form
    {
        My_conn conn = new My_conn();

        string[] st = new string[50];
        int[] qty = new int[50];
        int count = 0;
        int total = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.button11.BackColor = Color.AntiqueWhite;
            button9.Visible = false;
            button10.Visible = false;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;
            this.groupBox6.Visible = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;


            try
            {
                int c = 0;
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(vid) from vendor", conn.oleDbConnection1);

                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                    this.textBox12.Text = c.ToString();
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select vid from vendor", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["vid"].ToString());

                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select vid from vendor", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr["vid"].ToString());

                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select vdept from po", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox3.Items.Add(dr["vdept"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select approve from po", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox26.Text = (dr["approve"].ToString());

                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select poid from po", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox4.Items.Add(dr["poid"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmm = new OleDbCommand("select pid from products", conn.oleDbConnection1);
                OleDbDataReader drr = cmm.ExecuteReader();
                while (drr.Read())
                {
                    comboBox5.Items.Add(drr["pid"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select poid from grn", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox7.Items.Add(dr["poid"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select grnid from grn", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox6.Items.Add(dr["grnid"].ToString());
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                int c = 6;
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(grnid) from grn", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                    textBox52.Text = c.ToString();

                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupBox6.Visible = false;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = true;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;

            this.comboBox3.Text = "";
            this.textBox33.Clear();
            this.textBox32.Clear();
            this.textBox31.Clear();
            this.textBox30.Clear();
            this.textBox29.Clear();
            this.textBox26.Clear();
            this.textBox25.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.comboBox1.Visible = false;
            this.button14.Visible = false;
            this.groupBox1.Text = "Vendor Entry";

            this.textBox11.Visible = true;
            this.textBox12.Visible = true;
            this.button12.Visible = true;
            this.button13.Visible = true;

            this.label14.Visible = true;
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";

            this.textBox11.Text = "";
            this.textBox12.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.White;
            label1.Visible = false;
            button9.Visible = true;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.textBox12.Visible = false;

            this.textBox11.Visible = false;
            this.button12.Visible = false;
            this.button13.Visible = false;
            this.button14.Visible = true;
            this.comboBox1.Visible = true;

            this.label14.Visible = false;
            this.groupBox1.Text = "Vendor Search";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";

            this.textBox11.Text = "";
            this.textBox12.Text = "";
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            this.button11.BackColor = Color.Red;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            this.button11.BackColor = panel2.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Close();
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into vendor(vid,vname,vcode,cpname,vaddress,cpph,vcity,vemail,ph1,ph2,vgroup) values(@vid,@vname,@vcode,@cpname,@vaddress,@cpph,@vcity,@vemail,@ph1,@ph2,@vgroup)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@vid", textBox12.Text);
                cmd.Parameters.AddWithValue("@vanme", textBox1.Text);
                cmd.Parameters.AddWithValue("@vcode", textBox2.Text);
                cmd.Parameters.AddWithValue("@cpname", textBox3.Text);
                cmd.Parameters.AddWithValue("@vaddress", textBox4.Text);
                cmd.Parameters.AddWithValue("@cpph", textBox5.Text);
                cmd.Parameters.AddWithValue("@vcity", textBox6.Text);
                cmd.Parameters.AddWithValue("@vemail", textBox7.Text);
                cmd.Parameters.AddWithValue("@ph1", textBox8.Text);
                cmd.Parameters.AddWithValue("@ph2", textBox9.Text);
                cmd.Parameters.AddWithValue("@vgroup", textBox11.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Request Goes To Admin For Approval");
                conn.oleDbConnection1.Close();
                this.button1.BackColor = panel1.BackColor;
                this.button2.BackColor = Color.White;
                this.groupBox2.Visible = true;
                this.button2.Enabled = true;
                this.groupBox2.Text = "Vendor Approval";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from vendor where VID='" + comboBox1.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["vname"].ToString();
                    textBox2.Text = dr["vcode"].ToString();
                    textBox3.Text = dr["cpname"].ToString();
                    textBox4.Text = dr["vaddress"].ToString();
                    textBox5.Text = dr["cpph"].ToString();
                    textBox6.Text = dr["vcity"].ToString();
                    textBox7.Text = dr["vemail"].ToString();
                    textBox8.Text = dr["ph1"].ToString();
                    textBox9.Text = dr["ph2"].ToString();
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from vendor where VID='" + comboBox2.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox24.Text = dr["vname"].ToString();
                    textBox23.Text = dr["vcode"].ToString();
                    textBox22.Text = dr["cpname"].ToString();
                    textBox21.Text = dr["vaddress"].ToString();
                    textBox20.Text = dr["cpph"].ToString();
                    textBox19.Text = dr["vcity"].ToString();
                    textBox18.Text = dr["vemail"].ToString();
                    textBox17.Text = dr["ph1"].ToString();
                    textBox16.Text = dr["ph2"].ToString();
                    textBox15.Text = dr["vgroup"].ToString();
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                textBox14.Text = "Approve";
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Approve' where vid='" + comboBox2.Text + "'", conn.oleDbConnection1);

                cmd.ExecuteNonQuery();
                this.button3.Enabled = true;
                this.groupBox3.Visible = true;
                this.groupBox3.Text = "Purchase Order Details";
                this.button2.BackColor = panel1.BackColor;
                this.button3.BackColor = Color.White;
                conn.oleDbConnection1.Close();
                pictureBox1.Image = ERP.Properties.Resources._12;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                textBox14.Text = "Disapprove";
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("update vendor set vstatus='Disapprove' where vid='" + comboBox2.Text + "'", conn.oleDbConnection1);
                MessageBox.Show("Sorry Something issue in your Information", "Error" + MessageBoxIcon.Error);
                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
                pictureBox1.Image = ERP.Properties.Resources._1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int c = 0;


                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(poid) from po where vdept='" + comboBox3.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                }

                if (comboBox3.Text == "Consumer")
                {
                    textBox33.Text = "Con-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox3.Text == "Sales")
                {
                    textBox33.Text = "Sal-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }

                if (comboBox3.Text == "HR")
                {
                    textBox33.Text = "HR-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }

                if (comboBox3.Text == "IT")
                {
                    textBox33.Text = "IT-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }
                conn.oleDbConnection1.Close();

                int i = 0;
                conn.oleDbConnection1.Open();
                OleDbCommand cmm = new OleDbCommand("select count(vid) from po where vdept='" + comboBox3.Text + "'", conn.oleDbConnection1);
                OleDbDataReader drr = cmm.ExecuteReader();
                if (drr.Read())
                {
                    i = Convert.ToInt32(drr[0]);
                    i++;
                }

                if (comboBox3.Text == "Consumer")
                {
                    textBox32.Text = "0" + i.ToString();

                }

                if (comboBox3.Text == "Sales")
                {
                    textBox32.Text = "0" + i.ToString();
                }

                if (comboBox3.Text == "HR")
                {
                    textBox32.Text = "0" + i.ToString(); ;
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into po(vdept,poid,vid,vname,vcontectperson,vcpph,ddate,podate,approve,totalamount) values(@vdept,@poid,@vid,@vname,@vcontectperson,@vcpph,@ddate,@podate,@approve,@totalamount)", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@vdept", comboBox3.Text);
                cmd.Parameters.AddWithValue("@poid", textBox33.Text);
                cmd.Parameters.AddWithValue("@vid", textBox32.Text);
                cmd.Parameters.AddWithValue("@vname", textBox31.Text);
                cmd.Parameters.AddWithValue("@vcontectperson", textBox30.Text);
                cmd.Parameters.AddWithValue("@vcpph", textBox29.Text);
                cmd.Parameters.AddWithValue("@ddate", dateTimePicker1);
                cmd.Parameters.AddWithValue("@podate", dateTimePicker2);
                cmd.Parameters.AddWithValue("@approve", textBox26.Text);
                cmd.Parameters.AddWithValue("@totalamount", textBox25.Text);
                cmd.ExecuteNonQuery();
                this.button4.Enabled = true;
                this.groupBox4.Visible = true;
                this.groupBox4.Text = "Purchase Product";
                this.button3.BackColor = panel1.BackColor;
                this.button4.BackColor = Color.White;
                MessageBox.Show(":Your Purchase Order Is Create:");
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int c = 0;
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(poid) from po where poid='" + comboBox4.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                }

                if (comboBox4.Text == "Cons_01_2010")
                {
                    textBox36.Text = "Cons-01-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "Cons_10_2010")
                {
                    textBox36.Text = "Cons-10-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }

                if (comboBox4.Text == "Cons_02_2010")
                {
                    textBox36.Text = "Cons-02-00" + c.ToString() + "-" + System.DateTime.Today.Year;
                }

                if (comboBox4.Text == "Cons_07_2010")
                {
                    textBox36.Text = "Cons-07-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "Cons_08_2010")
                {
                    textBox36.Text = "Cons-08-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "Cons_12_2010")
                {
                    textBox36.Text = "Cons-12-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "HR_04_2010")
                {
                    textBox36.Text = "HR-04-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "HR_05_2010")
                {
                    textBox36.Text = "HR-05-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "HR_11_2010")
                {
                    textBox36.Text = "HR-11-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "Sale_03_2010")
                {
                    textBox36.Text = "Sal-03-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "Sale_06_2010")
                {
                    textBox36.Text = "Sal-06-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox4.Text == "Sale_09_2010")
                {
                    textBox36.Text = "Sal-09-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();

                for (int i = 0; i < count; i++)
                {
                    OleDbCommand cmd = new OleDbCommand("insert into poproducts(pid,pqty,pname,poid) values(@pid,@pqty,@pname,@poid)", conn.oleDbConnection1);

                    cmd.Parameters.AddWithValue("@pid", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@pqty", textBox28.Text);
                    cmd.Parameters.AddWithValue("@pname", textBox34.Text);
                    cmd.Parameters.AddWithValue("@poid", textBox36.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your Purchase Product Is Create");
                    this.button5.Enabled = true;
                    this.groupBox5.Visible = true;
                    //this.groupBox4.Text = "Purchase Product";
                    this.button4.BackColor = panel1.BackColor;
                    this.button5.BackColor = Color.White;
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select * from products where pid='" + comboBox5.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox34.Text = dr["pname"].ToString();
                    textBox27.Text = dr["baseprice"].ToString();
                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox35.Text += comboBox5.Text + Environment.NewLine;
            textBox13.Text += textBox28.Text + Environment.NewLine;
            st[count] = comboBox5.Text;
            qty[count] = Convert.ToInt32(textBox28.Text);
            count++;
            total += Convert.ToInt32(textBox27.Text) * Convert.ToInt32(textBox28.Text);
            textBox10.Text = total.ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int c = 0;


                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("select count(poid) from grn where poid='" + comboBox7.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = Convert.ToInt32(dr[0]);
                    c++;
                }

                if (comboBox7.Text == "Cons_01_2010")
                {
                    textBox43.Text = "Cons-01-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox7.Text == "Cons_02_2010")
                {
                    textBox43.Text = "Cons-02-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox7.Text == "Cons_08_2010")
                {
                    textBox43.Text = "Cons-08-00" + c.ToString() + "-" + System.DateTime.Today.Year;


                }

                if (comboBox7.Text == "Cons_12_2010")
                {
                    textBox43.Text = "Cons-12-00" + c.ToString() + "-" + System.DateTime.Today.Year;

                }

                if (comboBox7.Text == "HR_05_2010")
                {
                    textBox43.Text = "HR-05-00" + c.ToString() + "-" + System.DateTime.Today.Year;


                }

                if (comboBox7.Text == "HR_11_2010")
                {
                    textBox43.Text = "HR-11-00" + c.ToString() + "-" + System.DateTime.Today.Year;


                }

                if (comboBox7.Text == "Sale_03_2010")
                {
                    textBox43.Text = "Sal-03-00" + c.ToString() + "-" + System.DateTime.Today.Year;


                }

                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into grn(grnid,vname,ddate,grdate,poid,sno,status) values(@grnid,@vname,@ddate,@grdate,@poid,@sno,@status) ", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@grnid", textBox43.Text);
                cmd.Parameters.AddWithValue("@vname", textBox44.Text);
                cmd.Parameters.AddWithValue("@ddate", textBox41.Text);
                cmd.Parameters.AddWithValue("@grdate", textBox40.Text);
                cmd.Parameters.AddWithValue("@gpoid", comboBox7.Text);
                cmd.Parameters.AddWithValue("@sno", textBox39.Text);
                cmd.Parameters.AddWithValue("@status", textBox38.Text);
                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
                 this.button6.Enabled = true;
                    this.groupBox6.Visible = true;
                    //this.groupBox4.Text = "Purchase Product";
                    this.button5.BackColor = panel1.BackColor;
                    this.button6.BackColor = Color.White;
                
                MessageBox.Show(":Your GRN Is Create:");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmm = new OleDbCommand("select * from invoice where grnid='" + comboBox6.Text + "'", conn.oleDbConnection1);
                OleDbDataReader drr = cmm.ExecuteReader();
                if (drr.Read())
                {

                    textBox45.Text = drr["contectperson"].ToString();
                    textBox50.Text = drr["vendorid"].ToString();
                    textBox49.Text = drr["vendorname"].ToString();
                    textBox48.Text = drr["cpph"].ToString();
                    textBox47.Text = drr["dcdate"].ToString();
                    textBox46.Text = drr["grndate"].ToString();
                    textBox51.Text = drr["cdate"].ToString();
                    textBox53.Text = drr["amountpayable"].ToString();

                }
                conn.oleDbConnection1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":Your Entry Is Complete:");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.groupBox6.Visible = true;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;

            this.comboBox6.Text = "";
            this.textBox52.Clear();
            this.textBox45.Clear();
            this.textBox50.Clear();
            this.textBox49.Clear();
            this.textBox48.Clear();
            this.textBox46.Clear();
            this.textBox51.Clear();
            this.textBox53.Clear();
            this.textBox47.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.groupBox6.Visible = false;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = true;

            this.comboBox7.Text = "";
            this.textBox43.Clear();
            this.textBox44.Clear();
            this.textBox50.Clear();
            this.textBox41.Clear();
            this.textBox40.Clear();
            this.textBox39.Clear();
            this.textBox38.Clear();
            this.textBox42.Clear();
            this.textBox37.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.groupBox6.Visible = false;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = true;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox5.Visible = false;

            this.comboBox2.Text = "";
            this.textBox24.Clear();
            this.textBox14.Clear();
            this.textBox23.Clear();
            this.textBox22.Clear();
            this.textBox21.Clear();
            this.textBox20.Clear();
            this.textBox19.Clear();
            this.textBox18.Clear();
            this.textBox17.Clear();
            this.textBox16.Clear();
            this.textBox15.Clear();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.groupBox6.Visible = false;
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = true;
            this.groupBox5.Visible = false;

            this.comboBox4.Text = "";
            this.textBox36.Clear();
            this.comboBox5.Text = "";
            this.textBox34.Clear();
            this.textBox28.Clear();
            this.textBox27.Clear();
            this.textBox10.Clear();
            this.textBox35.Clear();
            this.textBox13.Clear();
        }
    }
}