﻿namespace zeus_mud.dialog
{
    partial class frmGameMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameMain));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.lvRooms = new System.Windows.Forms.ListView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt1Email = new System.Windows.Forms.TextBox();
            this.txt1Name = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txt1Level = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtALevel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtAEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(2, 369);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 31);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(231, 370);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(124, 30);
            this.btnFight.TabIndex = 2;
            this.btnFight.Text = "挑战";
            this.btnFight.UseVisualStyleBackColor = true;
            // 
            // lvRooms
            // 
            this.lvRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chCount,
            this.chLevel});
            this.lvRooms.Location = new System.Drawing.Point(2, 142);
            this.lvRooms.Name = "lvRooms";
            this.lvRooms.Size = new System.Drawing.Size(353, 221);
            this.lvRooms.StateImageList = this.imageList1;
            this.lvRooms.TabIndex = 3;
            this.lvRooms.UseCompatibleStateImageBehavior = false;
            this.lvRooms.View = System.Windows.Forms.View.Details;
            this.lvRooms.SelectedIndexChanged += new System.EventHandler(this.lvRooms_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(137, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(143, 14);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a8457564gw1e91gsqeac6j203c03c745.jpg");
            // 
            // chName
            // 
            this.chName.Text = "玩家名称";
            this.chName.Width = 178;
            // 
            // chCount
            // 
            this.chCount.Text = "人数";
            this.chCount.Width = 94;
            // 
            // chLevel
            // 
            this.chLevel.Text = "等级";
            // 
            // txt1Email
            // 
            this.txt1Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1Email.Location = new System.Drawing.Point(74, 7);
            this.txt1Email.Name = "txt1Email";
            this.txt1Email.ReadOnly = true;
            this.txt1Email.Size = new System.Drawing.Size(57, 14);
            this.txt1Email.TabIndex = 6;
            this.txt1Email.Text = "你的帐号:";
            // 
            // txt1Name
            // 
            this.txt1Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1Name.Location = new System.Drawing.Point(74, 26);
            this.txt1Name.Name = "txt1Name";
            this.txt1Name.ReadOnly = true;
            this.txt1Name.Size = new System.Drawing.Size(57, 14);
            this.txt1Name.TabIndex = 7;
            this.txt1Name.Text = "你的名称:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtName.Location = new System.Drawing.Point(137, 26);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(143, 14);
            this.txtName.TabIndex = 8;
            this.txtName.TabStop = false;
            // 
            // txtLevel
            // 
            this.txtLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLevel.Location = new System.Drawing.Point(137, 46);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(143, 14);
            this.txtLevel.TabIndex = 10;
            this.txtLevel.TabStop = false;
            // 
            // txt1Level
            // 
            this.txt1Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1Level.Location = new System.Drawing.Point(74, 44);
            this.txt1Level.Name = "txt1Level";
            this.txt1Level.ReadOnly = true;
            this.txt1Level.Size = new System.Drawing.Size(57, 14);
            this.txt1Level.TabIndex = 9;
            this.txt1Level.Text = "你的等级:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(291, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txtALevel
            // 
            this.txtALevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtALevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtALevel.Location = new System.Drawing.Point(146, 114);
            this.txtALevel.Name = "txtALevel";
            this.txtALevel.ReadOnly = true;
            this.txtALevel.Size = new System.Drawing.Size(143, 14);
            this.txtALevel.TabIndex = 17;
            this.txtALevel.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(76, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(64, 14);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "<房主等级>";
            // 
            // txtAName
            // 
            this.txtAName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAName.Location = new System.Drawing.Point(146, 94);
            this.txtAName.Name = "txtAName";
            this.txtAName.ReadOnly = true;
            this.txtAName.Size = new System.Drawing.Size(143, 14);
            this.txtAName.TabIndex = 15;
            this.txtAName.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(76, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(64, 14);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "<房主名称>";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(76, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(64, 14);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "<房主帐号>";
            // 
            // txtAEmail
            // 
            this.txtAEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtAEmail.Location = new System.Drawing.Point(146, 74);
            this.txtAEmail.Name = "txtAEmail";
            this.txtAEmail.ReadOnly = true;
            this.txtAEmail.Size = new System.Drawing.Size(143, 14);
            this.txtAEmail.TabIndex = 12;
            this.txtAEmail.TabStop = false;
            // 
            // frmGameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 406);
            this.Controls.Add(this.txtALevel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtAEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txt1Level);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txt1Name);
            this.Controls.Add(this.txt1Email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lvRooms);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.btnRefresh);
            this.Name = "frmGameMain";
            this.Text = "frmGameMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.ListView lvRooms;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCount;
        private System.Windows.Forms.ColumnHeader chLevel;
        private System.Windows.Forms.TextBox txt1Email;
        private System.Windows.Forms.TextBox txt1Name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txt1Level;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtALevel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtAEmail;

    }
}