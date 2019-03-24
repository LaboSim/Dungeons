namespace Dungeons
{
    partial class Dungeons
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dungeons));
            this.player30 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerHitPoints = new System.Windows.Forms.Label();
            this.batHitPoints = new System.Windows.Forms.Label();
            this.ghostHitPoints = new System.Windows.Forms.Label();
            this.ghoulHitPoints = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.bat30 = new System.Windows.Forms.PictureBox();
            this.sword30 = new System.Windows.Forms.PictureBox();
            this.equipSword = new System.Windows.Forms.PictureBox();
            this.bow30 = new System.Windows.Forms.PictureBox();
            this.equipBow = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.equipWeaponSword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player30)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bat30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipWeaponSword)).BeginInit();
            this.SuspendLayout();
            // 
            // player30
            // 
            this.player30.BackColor = System.Drawing.Color.Transparent;
            this.player30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player30.Image = ((System.Drawing.Image)(resources.GetObject("player30.Image")));
            this.player30.Location = new System.Drawing.Point(12, 12);
            this.player30.Name = "player30";
            this.player30.Size = new System.Drawing.Size(30, 30);
            this.player30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player30.TabIndex = 0;
            this.player30.TabStop = false;
            this.player30.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.09859F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.90141F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.playerHitPoints, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batHitPoints, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostHitPoints, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHitPoints, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(401, 277);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghoul";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHitPoints
            // 
            this.playerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerHitPoints.Location = new System.Drawing.Point(43, 1);
            this.playerHitPoints.Name = "playerHitPoints";
            this.playerHitPoints.Size = new System.Drawing.Size(77, 13);
            this.playerHitPoints.TabIndex = 4;
            this.playerHitPoints.Text = "playerHitPoints";
            this.playerHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batHitPoints
            // 
            this.batHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.batHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.batHitPoints.Location = new System.Drawing.Point(43, 16);
            this.batHitPoints.Name = "batHitPoints";
            this.batHitPoints.Size = new System.Drawing.Size(77, 13);
            this.batHitPoints.TabIndex = 5;
            this.batHitPoints.Text = "batHitPoints";
            this.batHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ghostHitPoints
            // 
            this.ghostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ghostHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghostHitPoints.Location = new System.Drawing.Point(43, 31);
            this.ghostHitPoints.Name = "ghostHitPoints";
            this.ghostHitPoints.Size = new System.Drawing.Size(77, 13);
            this.ghostHitPoints.TabIndex = 6;
            this.ghostHitPoints.Text = "ghostHitPoints";
            this.ghostHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ghoulHitPoints
            // 
            this.ghoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ghoulHitPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ghoulHitPoints.Location = new System.Drawing.Point(43, 47);
            this.ghoulHitPoints.Name = "ghoulHitPoints";
            this.ghoulHitPoints.Size = new System.Drawing.Size(77, 13);
            this.ghoulHitPoints.TabIndex = 7;
            this.ghoulHitPoints.Text = "ghoulHitPoints";
            this.ghoulHitPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(272, 277);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(123, 63);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moveDown);
            this.tabPage1.Controls.Add(this.moveUp);
            this.tabPage1.Controls.Add(this.moveRight);
            this.tabPage1.Controls.Add(this.moveLeft);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(115, 37);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Move";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // moveDown
            // 
            this.moveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveDown.Location = new System.Drawing.Point(85, 6);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(20, 26);
            this.moveDown.TabIndex = 3;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveUp
            // 
            this.moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moveUp.Location = new System.Drawing.Point(59, 6);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(20, 26);
            this.moveUp.TabIndex = 2;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(33, 6);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(20, 26);
            this.moveRight.TabIndex = 1;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(6, 6);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(20, 26);
            this.moveLeft.TabIndex = 0;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.attackDown);
            this.tabPage2.Controls.Add(this.attackUp);
            this.tabPage2.Controls.Add(this.attackRight);
            this.tabPage2.Controls.Add(this.attackLeft);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(115, 37);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attack";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // attackDown
            // 
            this.attackDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackDown.Location = new System.Drawing.Point(85, 6);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(20, 26);
            this.attackDown.TabIndex = 3;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackUp
            // 
            this.attackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackUp.Location = new System.Drawing.Point(59, 6);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(20, 26);
            this.attackUp.TabIndex = 2;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(33, 6);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(20, 26);
            this.attackRight.TabIndex = 1;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(6, 6);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(20, 26);
            this.attackLeft.TabIndex = 0;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // bat30
            // 
            this.bat30.BackColor = System.Drawing.Color.Transparent;
            this.bat30.Image = ((System.Drawing.Image)(resources.GetObject("bat30.Image")));
            this.bat30.Location = new System.Drawing.Point(48, 12);
            this.bat30.Name = "bat30";
            this.bat30.Size = new System.Drawing.Size(30, 30);
            this.bat30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bat30.TabIndex = 3;
            this.bat30.TabStop = false;
            this.bat30.Visible = false;
            // 
            // sword30
            // 
            this.sword30.BackColor = System.Drawing.Color.Transparent;
            this.sword30.Image = ((System.Drawing.Image)(resources.GetObject("sword30.Image")));
            this.sword30.Location = new System.Drawing.Point(84, 12);
            this.sword30.Name = "sword30";
            this.sword30.Size = new System.Drawing.Size(30, 30);
            this.sword30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword30.TabIndex = 4;
            this.sword30.TabStop = false;
            this.sword30.Visible = false;
            // 
            // equipSword
            // 
            this.equipSword.BackColor = System.Drawing.Color.Transparent;
            this.equipSword.Image = ((System.Drawing.Image)(resources.GetObject("equipSword.Image")));
            this.equipSword.Location = new System.Drawing.Point(71, 278);
            this.equipSword.Name = "equipSword";
            this.equipSword.Size = new System.Drawing.Size(30, 30);
            this.equipSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipSword.TabIndex = 5;
            this.equipSword.TabStop = false;
            this.equipSword.Visible = false;
            this.equipSword.Click += new System.EventHandler(this.equipSword_Click);
            // 
            // bow30
            // 
            this.bow30.BackColor = System.Drawing.Color.Transparent;
            this.bow30.Image = ((System.Drawing.Image)(resources.GetObject("bow30.Image")));
            this.bow30.Location = new System.Drawing.Point(120, 12);
            this.bow30.Name = "bow30";
            this.bow30.Size = new System.Drawing.Size(30, 30);
            this.bow30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bow30.TabIndex = 6;
            this.bow30.TabStop = false;
            this.bow30.Visible = false;
            // 
            // equipBow
            // 
            this.equipBow.BackColor = System.Drawing.Color.Transparent;
            this.equipBow.Image = ((System.Drawing.Image)(resources.GetObject("equipBow.Image")));
            this.equipBow.Location = new System.Drawing.Point(107, 278);
            this.equipBow.Name = "equipBow";
            this.equipBow.Size = new System.Drawing.Size(30, 30);
            this.equipBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipBow.TabIndex = 7;
            this.equipBow.TabStop = false;
            this.equipBow.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(173, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Equipped weapon";
            // 
            // equipWeaponSword
            // 
            this.equipWeaponSword.BackColor = System.Drawing.Color.Transparent;
            this.equipWeaponSword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.equipWeaponSword.Image = ((System.Drawing.Image)(resources.GetObject("equipWeaponSword.Image")));
            this.equipWeaponSword.Location = new System.Drawing.Point(216, 293);
            this.equipWeaponSword.Name = "equipWeaponSword";
            this.equipWeaponSword.Size = new System.Drawing.Size(50, 50);
            this.equipWeaponSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipWeaponSword.TabIndex = 9;
            this.equipWeaponSword.TabStop = false;
            this.equipWeaponSword.Visible = false;
            // 
            // Dungeons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.equipWeaponSword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.equipBow);
            this.Controls.Add(this.equipSword);
            this.Controls.Add(this.player30);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bat30);
            this.Controls.Add(this.sword30);
            this.Controls.Add(this.bow30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dungeons";
            this.Text = "Dungeons";
            this.Load += new System.EventHandler(this.Dungeons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player30)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bat30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sword30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bow30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipWeaponSword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player30;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label playerHitPoints;
        private System.Windows.Forms.Label batHitPoints;
        private System.Windows.Forms.Label ghostHitPoints;
        private System.Windows.Forms.Label ghoulHitPoints;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.PictureBox bat30;
        private System.Windows.Forms.PictureBox sword30;
        private System.Windows.Forms.PictureBox equipSword;
        private System.Windows.Forms.PictureBox bow30;
        private System.Windows.Forms.PictureBox equipBow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox equipWeaponSword;
    }
}

