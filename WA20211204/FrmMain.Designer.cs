namespace WA20211204
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKereses = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bevetel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szűrés termék alapján:";
            // 
            // tbKereses
            // 
            this.tbKereses.Location = new System.Drawing.Point(219, 25);
            this.tbKereses.Name = "tbKereses";
            this.tbKereses.Size = new System.Drawing.Size(174, 20);
            this.tbKereses.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datum,
            this.termek,
            this.bevetel});
            this.dgv.Location = new System.Drawing.Point(12, 58);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(433, 171);
            this.dgv.TabIndex = 2;
            // 
            // datum
            // 
            this.datum.HeaderText = "dátum";
            this.datum.Name = "datum";
            // 
            // termek
            // 
            this.termek.HeaderText = "termék";
            this.termek.Name = "termek";
            // 
            // bevetel
            // 
            this.bevetel.HeaderText = "bevétel";
            this.bevetel.Name = "bevetel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Új terméktípus rögzítése";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Új eladás rögzítése";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tbKereses);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Zöldség/gyümölcs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKereses;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn termek;
        private System.Windows.Forms.DataGridViewTextBoxColumn bevetel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

