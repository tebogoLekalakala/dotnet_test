using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Graphics.Converters;
using devDept.Eyeshot.Design;
using devDept.Serialization;

namespace Building
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           
        }

        public void loadnew()
        {
            viewportLayout1.Clear();

            Mesh shortleg1 = Mesh.CreateBox(500, 500, 800);
            shortleg1.Translate(500, 1000, 200);
            Mesh shortleg2 = Mesh.CreateBox(500, 500, 800);
            shortleg2.Translate(1500, 1000, 200);

            viewportLayout1.Entities.AddRange(new Entity[] { shortleg1, shortleg2 }, 0, System.Drawing.Color.Brown);


            Mesh seatback = Mesh.CreateBox(2500, 3500, 500);
            seatback.Translate(-50, -500, -100);

            viewportLayout1.Entities.Add(seatback, 0, System.Drawing.Color.RosyBrown);



            viewportLayout1.ZoomFit();

            viewportLayout1.Invalidate();

        }
        public void executeprog()
        {


            int bL = Convert.ToInt32(this.textBox1.Text);
            int bW = Convert.ToInt32(this.textBox2.Text);
            int bD = Convert.ToInt32(this.textBox3.Text);
            int cL = Convert.ToInt32(this.textBox4.Text);
            int cW = Convert.ToInt32(this.textBox5.Text);
            int cH = Convert.ToInt32(this.textBox6.Text);
            int cX1 = Convert.ToInt32(this.textBox7.Text);
            int cY1 = Convert.ToInt32(this.textBox8.Text);
            int cX2 = Convert.ToInt32(this.textBox9.Text);
            int cY2 = Convert.ToInt32(this.textBox10.Text);

            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                Mesh seatback = Mesh.CreateBox(bW, bL, bD);
                seatback.Translate(-50, -500, -100);

                viewportLayout1.Entities.Add(seatback, 0, System.Drawing.Color.RosyBrown);

                viewportLayout1.ZoomFit();

                viewportLayout1.Invalidate();


            }
            else
            {

                if (checkBox1.Checked)
                {

                    Mesh shortleg1 = Mesh.CreateBox(cW, cL, cH);
                    shortleg1.Translate(cX1, cY1, 200);
                    viewportLayout1.Entities.AddRange(new Entity[] { shortleg1 }, 0, System.Drawing.Color.Brown);

                    Mesh seatback = Mesh.CreateBox(bW, bL, bD);
                    seatback.Translate(-50, -500, -100);

                    viewportLayout1.Entities.Add(seatback, 0, System.Drawing.Color.RosyBrown);



                    viewportLayout1.ZoomFit();

                    viewportLayout1.Invalidate();
                }
                if (checkBox2.Checked)
                {
                    Mesh shortleg2 = Mesh.CreateBox(cW, cL, cH);
                    shortleg2.Translate(cX2, cY2, 200);

                    //Mesh shortleg1 = Mesh.CreateBox(500, 500, 800);
                    //shortleg1.Translate(500, 1000, 200);
                    //Mesh shortleg2 = Mesh.CreateBox(500, 500, 800);
                    //shortleg2.Translate(1500, 1000, 200);


                    viewportLayout1.Entities.AddRange(new Entity[] { shortleg2 }, 0, System.Drawing.Color.Brown);


                    Mesh seatback1 = Mesh.CreateBox(bW, bL, bD);
                    seatback1.Translate(-50, -500, -100);

                    viewportLayout1.Entities.Add(seatback1, 0, System.Drawing.Color.RosyBrown);



                    viewportLayout1.ZoomFit();

                    viewportLayout1.Invalidate();


                }

            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewportLayout1.Clear();

            textBox1.BackColor = Color.Empty;
            textBox2.BackColor = Color.Empty;
            textBox3.BackColor = Color.Empty;
            textBox4.BackColor = Color.Empty;
            textBox5.BackColor = Color.Empty;
            textBox6.BackColor = Color.Empty;
            textBox7.BackColor = Color.Empty;
            textBox8.BackColor = Color.Empty;
            textBox9.BackColor = Color.Empty;
            textBox10.BackColor = Color.Empty;

            try {


               
                

                int parsedValue;
                if (string.IsNullOrEmpty(textBox1.Text)&& !int.TryParse(textBox1.Text, out parsedValue))
                {

                    textBox1.BackColor = Color.Tomato;
                    MessageBox.Show("Input base Length is empty or they are not numbers,Please input a number there");

                }
            
                if (string.IsNullOrEmpty(textBox2.Text) && !int.TryParse(textBox2.Text, out parsedValue))
                {

                    textBox2.BackColor = Color.Tomato;
                    MessageBox.Show("Input base width is empty or they are not numbers,Please input a number there");

                }
             
                if (string.IsNullOrEmpty(textBox3.Text) && !int.TryParse(textBox3.Text, out parsedValue))
                {

                    textBox3.BackColor = Color.Tomato;
                    MessageBox.Show("Input base depth is empty or they are not numbers,Please input a number there");

                }
              
                if (string.IsNullOrEmpty(textBox4.Text) && !int.TryParse(textBox4.Text, out parsedValue))
                {

                    textBox4.BackColor = Color.Tomato;
                    MessageBox.Show("Input col Length is empty or they are not numbers,Please input a number there");

                }
            
                if (string.IsNullOrEmpty(textBox5.Text) && !int.TryParse(textBox5.Text, out parsedValue))
                {

                    textBox5.BackColor = Color.Tomato;
                    MessageBox.Show("Input col width is empty or they are not numbers,Please input a number there");

                }
             
                if (string.IsNullOrEmpty(textBox6.Text) && !int.TryParse(textBox6.Text, out parsedValue))
                {

                    textBox6.BackColor = Color.Tomato;
                    MessageBox.Show("Input col height is empty or they are not numbers,Please input a number there");

                }
               
                if (string.IsNullOrEmpty(textBox7.Text) && !int.TryParse(textBox7.Text, out parsedValue))
                {

                    textBox7.BackColor = Color.Tomato;
                    MessageBox.Show("Input col 1 X Offset is empty or they are not numbers,Please input a number there");

                }
              
                if (string.IsNullOrEmpty(textBox8.Text) && !int.TryParse(textBox8.Text, out parsedValue))
                {

                    textBox8.BackColor = Color.Tomato;
                    MessageBox.Show("Input col 1 Y Offset is empty or they are not numbers,Please input a number there");

                }
              
                if (string.IsNullOrEmpty(textBox9.Text) && !int.TryParse(textBox9.Text, out parsedValue))
                {

                    textBox9.BackColor = Color.Tomato;
                    MessageBox.Show("Input col 2 X Offset is empty or they are not numbers,Please input a number there");

                }
             
                if (string.IsNullOrEmpty(textBox10.Text) && !int.TryParse(textBox10.Text, out parsedValue))
                {

                    textBox10.BackColor = Color.Tomato;
                    MessageBox.Show("Input col 2 X Offset is empty or they are not numbers,Please input a number there");

                }

                executeprog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Please provide a valid diemention input");


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadnew();
            textBox1.Text = "3500";
            textBox2.Text = "2500";
            textBox3.Text = "500";
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            textBox4.Text = "500";
            textBox5.Text = "500";
            textBox6.Text = "800";
            textBox7.Text = "500";
            textBox8.Text = "1000";
            textBox9.Text = "1500";
            textBox10.Text = "1000";
          

           

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

            loadnew();

        }
    }
}
