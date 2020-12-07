namespace RussianRoulette
{
    partial class Game_form
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
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shootaway = new System.Windows.Forms.Button();
            this.btn_playagain = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.picbox_main = new System.Windows.Forms.PictureBox();
            this.btn_gamerules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_load.Location = new System.Drawing.Point(68, 78);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(98, 57);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click_1);
            // 
            // btn_shoot
            // 
            this.btn_shoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.Location = new System.Drawing.Point(68, 246);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(98, 55);
            this.btn_shoot.TabIndex = 1;
            this.btn_shoot.Text = "Shoot";
            this.btn_shoot.UseVisualStyleBackColor = false;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click_1);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_spin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.Color.Black;
            this.btn_spin.Location = new System.Drawing.Point(624, 78);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(101, 57);
            this.btn_spin.TabIndex = 2;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click_1);
            // 
            // btn_shootaway
            // 
            this.btn_shootaway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_shootaway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootaway.Location = new System.Drawing.Point(624, 246);
            this.btn_shootaway.Name = "btn_shootaway";
            this.btn_shootaway.Size = new System.Drawing.Size(129, 55);
            this.btn_shootaway.TabIndex = 3;
            this.btn_shootaway.Text = "Shoot Away";
            this.btn_shootaway.UseVisualStyleBackColor = false;
            this.btn_shootaway.Click += new System.EventHandler(this.btn_shootaway_Click_1);
            // 
            // btn_playagain
            // 
            this.btn_playagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_playagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playagain.Location = new System.Drawing.Point(650, 372);
            this.btn_playagain.Name = "btn_playagain";
            this.btn_playagain.Size = new System.Drawing.Size(89, 53);
            this.btn_playagain.TabIndex = 4;
            this.btn_playagain.Text = "Play Again";
            this.btn_playagain.UseVisualStyleBackColor = false;
            this.btn_playagain.Click += new System.EventHandler(this.btn_playagain_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(97, 372);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(88, 53);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // picbox_main
            // 
            this.picbox_main.Location = new System.Drawing.Point(222, 78);
            this.picbox_main.Name = "picbox_main";
            this.picbox_main.Size = new System.Drawing.Size(383, 273);
            this.picbox_main.TabIndex = 7;
            this.picbox_main.TabStop = false;
            // 
            // btn_gamerules
            // 
            this.btn_gamerules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_gamerules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gamerules.Location = new System.Drawing.Point(393, 372);
            this.btn_gamerules.Name = "btn_gamerules";
            this.btn_gamerules.Size = new System.Drawing.Size(84, 53);
            this.btn_gamerules.TabIndex = 6;
            this.btn_gamerules.Text = "Rules";
            this.btn_gamerules.UseVisualStyleBackColor = false;
            this.btn_gamerules.Click += new System.EventHandler(this.btn_gamerules_Click);
            // 
            // Game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picbox_main);
            this.Controls.Add(this.btn_gamerules);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_playagain);
            this.Controls.Add(this.btn_shootaway);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_load);
            this.Name = "Game_form";
            this.Text = "Game_form";
            this.Load += new System.EventHandler(this.Game_form_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shootaway;
        private System.Windows.Forms.Button btn_playagain;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox picbox_main;
        private System.Windows.Forms.Button btn_gamerules;
    }
}

