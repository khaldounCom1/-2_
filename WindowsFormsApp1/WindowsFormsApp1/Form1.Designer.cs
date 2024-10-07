namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butAdd = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.butSub = new System.Windows.Forms.Button();
            this.butMult = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butCLo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.butAdd.Location = new System.Drawing.Point(230, 109);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 0;
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txt1.Location = new System.Drawing.Point(315, 42);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 20);
            this.txt1.TabIndex = 1;
           // this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txt2.Location = new System.Drawing.Point(167, 42);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(120, 20);
            this.txt2.TabIndex = 2;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txtR
            // 
            this.txtR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtR.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtR.Location = new System.Drawing.Point(61, 42);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(75, 20);
            this.txtR.TabIndex = 3;
            // 
            // butSub
            // 
            this.butSub.Font = new System.Drawing.Font("Tahoma", 8F);
            this.butSub.Location = new System.Drawing.Point(139, 109);
            this.butSub.Name = "butSub";
            this.butSub.Size = new System.Drawing.Size(75, 23);
            this.butSub.TabIndex = 4;
            this.butSub.Text = "-";
            this.butSub.UseVisualStyleBackColor = true;
            this.butSub.Click += new System.EventHandler(this.butSub_Click);
            // 
            // butMult
            // 
            this.butMult.Font = new System.Drawing.Font("Tahoma", 8F);
            this.butMult.Location = new System.Drawing.Point(230, 154);
            this.butMult.Name = "butMult";
            this.butMult.Size = new System.Drawing.Size(75, 23);
            this.butMult.TabIndex = 5;
            this.butMult.Text = "*";
            this.butMult.UseVisualStyleBackColor = true;
            this.butMult.Click += new System.EventHandler(this.butMult_Click);
            // 
            // butDiv
            // 
            this.butDiv.Font = new System.Drawing.Font("Tahoma", 8F);
            this.butDiv.Location = new System.Drawing.Point(139, 154);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(75, 23);
            this.butDiv.TabIndex = 6;
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.butDiv_Click);
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Tahoma", 8F);
            this.butDel.Location = new System.Drawing.Point(315, 214);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 7;
            this.butDel.Text = "حذف";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "العدد الاول ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "العدد الثاني";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "الناتج";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "=";
            // 
            // butCLo
            // 
            this.butCLo.BackColor = System.Drawing.Color.Red;
            this.butCLo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.butCLo.Location = new System.Drawing.Point(61, 214);
            this.butCLo.Name = "butCLo";
            this.butCLo.Size = new System.Drawing.Size(75, 23);
            this.butCLo.TabIndex = 8;
            this.butCLo.Text = "اغلاق";
            this.butCLo.UseVisualStyleBackColor = false;
            this.butCLo.Click += new System.EventHandler(this.butCLo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 6F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 263);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCLo);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butMult);
            this.Controls.Add(this.butSub);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.butAdd);
            this.Font = new System.Drawing.Font("Tahoma", 4F);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button butSub;
        private System.Windows.Forms.Button butMult;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butCLo;
    }
}

