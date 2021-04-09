
namespace ProjektovanjePoSlojevimaStudijeApp
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
            this.buttonPredmetSelect = new System.Windows.Forms.Button();
            this.dataGridViewPredmet = new System.Windows.Forms.DataGridView();
            this.buttonPredmetInsert = new System.Windows.Forms.Button();
            this.buttonPredmetUpdate = new System.Windows.Forms.Button();
            this.buttonPredmetDelete = new System.Windows.Forms.Button();
            this.buttonStudentIspitSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPredmetSelect
            // 
            this.buttonPredmetSelect.Location = new System.Drawing.Point(34, 12);
            this.buttonPredmetSelect.Name = "buttonPredmetSelect";
            this.buttonPredmetSelect.Size = new System.Drawing.Size(129, 23);
            this.buttonPredmetSelect.TabIndex = 0;
            this.buttonPredmetSelect.Text = "Predmet Select";
            this.buttonPredmetSelect.UseVisualStyleBackColor = true;
            this.buttonPredmetSelect.Click += new System.EventHandler(this.buttonPredmetSelect_Click);
            // 
            // dataGridViewPredmet
            // 
            this.dataGridViewPredmet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPredmet.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewPredmet.Name = "dataGridViewPredmet";
            this.dataGridViewPredmet.Size = new System.Drawing.Size(826, 313);
            this.dataGridViewPredmet.TabIndex = 1;
            // 
            // buttonPredmetInsert
            // 
            this.buttonPredmetInsert.Location = new System.Drawing.Point(181, 12);
            this.buttonPredmetInsert.Name = "buttonPredmetInsert";
            this.buttonPredmetInsert.Size = new System.Drawing.Size(129, 23);
            this.buttonPredmetInsert.TabIndex = 2;
            this.buttonPredmetInsert.Text = "Predmet Insert";
            this.buttonPredmetInsert.UseVisualStyleBackColor = true;
            this.buttonPredmetInsert.Click += new System.EventHandler(this.buttonPredmetInsert_Click);
            // 
            // buttonPredmetUpdate
            // 
            this.buttonPredmetUpdate.Location = new System.Drawing.Point(477, 12);
            this.buttonPredmetUpdate.Name = "buttonPredmetUpdate";
            this.buttonPredmetUpdate.Size = new System.Drawing.Size(129, 23);
            this.buttonPredmetUpdate.TabIndex = 3;
            this.buttonPredmetUpdate.Text = "Predmet Update";
            this.buttonPredmetUpdate.UseVisualStyleBackColor = true;
            this.buttonPredmetUpdate.Click += new System.EventHandler(this.buttonPredmetUpdate_Click);
            // 
            // buttonPredmetDelete
            // 
            this.buttonPredmetDelete.Location = new System.Drawing.Point(330, 12);
            this.buttonPredmetDelete.Name = "buttonPredmetDelete";
            this.buttonPredmetDelete.Size = new System.Drawing.Size(129, 23);
            this.buttonPredmetDelete.TabIndex = 4;
            this.buttonPredmetDelete.Text = "Predmet Delete";
            this.buttonPredmetDelete.UseVisualStyleBackColor = true;
            this.buttonPredmetDelete.Click += new System.EventHandler(this.buttonPredmetDelete_Click);
            // 
            // buttonStudentIspitSelect
            // 
            this.buttonStudentIspitSelect.Location = new System.Drawing.Point(709, 12);
            this.buttonStudentIspitSelect.Name = "buttonStudentIspitSelect";
            this.buttonStudentIspitSelect.Size = new System.Drawing.Size(129, 23);
            this.buttonStudentIspitSelect.TabIndex = 5;
            this.buttonStudentIspitSelect.Text = "StudentIspit Select";
            this.buttonStudentIspitSelect.UseVisualStyleBackColor = true;
            this.buttonStudentIspitSelect.Click += new System.EventHandler(this.buttonStudentIspitSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 378);
            this.Controls.Add(this.buttonStudentIspitSelect);
            this.Controls.Add(this.buttonPredmetDelete);
            this.Controls.Add(this.buttonPredmetUpdate);
            this.Controls.Add(this.buttonPredmetInsert);
            this.Controls.Add(this.dataGridViewPredmet);
            this.Controls.Add(this.buttonPredmetSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredmet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPredmetSelect;
        private System.Windows.Forms.DataGridView dataGridViewPredmet;
        private System.Windows.Forms.Button buttonPredmetInsert;
        private System.Windows.Forms.Button buttonPredmetUpdate;
        private System.Windows.Forms.Button buttonPredmetDelete;
        private System.Windows.Forms.Button buttonStudentIspitSelect;
    }
}

