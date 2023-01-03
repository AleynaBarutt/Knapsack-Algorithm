
using System.Data;

namespace opt_proje
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
            this.components = new System.ComponentModel.Container();
            this.kapasiteTextBox = new System.Windows.Forms.TextBox();
            this.item_sayiTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelsonuc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.knapSackResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knapSackResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kapasiteTextBox
            // 
            this.kapasiteTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.kapasiteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapasiteTextBox.Location = new System.Drawing.Point(483, 193);
            this.kapasiteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kapasiteTextBox.Name = "kapasiteTextBox";
            this.kapasiteTextBox.Size = new System.Drawing.Size(250, 34);
            this.kapasiteTextBox.TabIndex = 0;
            this.kapasiteTextBox.Tag = "Canta Kapasitesi";
            this.kapasiteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kapasiteTextBox.TextChanged += new System.EventHandler(this.kapasiteTextBox_TextChanged);
            // 
            // item_sayiTextBox
            // 
            this.item_sayiTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.item_sayiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.item_sayiTextBox.Location = new System.Drawing.Point(483, 296);
            this.item_sayiTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.item_sayiTextBox.Name = "item_sayiTextBox";
            this.item_sayiTextBox.Size = new System.Drawing.Size(250, 34);
            this.item_sayiTextBox.TabIndex = 1;
            this.item_sayiTextBox.Tag = "Item sayisi";
            this.item_sayiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item_sayiTextBox.TextChanged += new System.EventHandler(this.item_sayiTextBox_TextChanged);
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.weightTextBox.Location = new System.Drawing.Point(483, 398);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(250, 34);
            this.weightTextBox.TabIndex = 2;
            this.weightTextBox.Tag = "Itemlerin agirligi";
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.valueTextBox.Location = new System.Drawing.Point(483, 500);
            this.valueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(250, 34);
            this.valueTextBox.TabIndex = 3;
            this.valueTextBox.Tag = "Itemlerin degerleri";
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(530, 629);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "Çanta Kapasitesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DodgerBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(191, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 80);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item Ağırlıkları";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DodgerBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(191, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 80);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Değerleri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelsonuc
            // 
            this.labelsonuc.BackColor = System.Drawing.Color.Lavender;
            this.labelsonuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsonuc.Location = new System.Drawing.Point(800, 193);
            this.labelsonuc.Name = "labelsonuc";
            this.labelsonuc.Size = new System.Drawing.Size(271, 137);
            this.labelsonuc.TabIndex = 9;
            this.labelsonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(800, 420);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(271, 137);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(304, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(754, 100);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sırt Çantası Algoritması";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // knapSackResultBindingSource
            // 
            this.knapSackResultBindingSource.DataSource = typeof(opt_proje.KnapSackResult);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1327, 853);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.item_sayiTextBox);
            this.Controls.Add(this.kapasiteTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sırt Çantası Algoritması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knapSackResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kapasiteTextBox;
        private System.Windows.Forms.TextBox item_sayiTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelsonuc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource knapSackResultBindingSource;
        private System.Windows.Forms.Label label5;
    }
}

