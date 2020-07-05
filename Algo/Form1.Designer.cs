namespace Algo
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxBefore = new System.Windows.Forms.ListBox();
            this.listBoxAfter = new System.Windows.Forms.ListBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonTri = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxBefore
            // 
            this.listBoxBefore.FormattingEnabled = true;
            this.listBoxBefore.ItemHeight = 16;
            this.listBoxBefore.Location = new System.Drawing.Point(137, 66);
            this.listBoxBefore.Name = "listBoxBefore";
            this.listBoxBefore.Size = new System.Drawing.Size(157, 292);
            this.listBoxBefore.TabIndex = 0;
            // 
            // listBoxAfter
            // 
            this.listBoxAfter.FormattingEnabled = true;
            this.listBoxAfter.ItemHeight = 16;
            this.listBoxAfter.Location = new System.Drawing.Point(491, 66);
            this.listBoxAfter.Name = "listBoxAfter";
            this.listBoxAfter.Size = new System.Drawing.Size(154, 292);
            this.listBoxAfter.TabIndex = 2;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(137, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(157, 46);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Générer";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonTri
            // 
            this.buttonTri.Location = new System.Drawing.Point(310, 173);
            this.buttonTri.Name = "buttonTri";
            this.buttonTri.Size = new System.Drawing.Size(157, 46);
            this.buttonTri.TabIndex = 4;
            this.buttonTri.Text = "Trier";
            this.buttonTri.UseVisualStyleBackColor = true;
            this.buttonTri.Click += new System.EventHandler(this.buttonTri_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(705, 223);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxValue.TabIndex = 5;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(705, 252);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "button1";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(702, 293);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(46, 17);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 438);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonTri);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.listBoxAfter);
            this.Controls.Add(this.listBoxBefore);
            this.Name = "FormMain";
            this.Text = "FormMain Algo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBefore;
        private System.Windows.Forms.ListBox listBoxAfter;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonTri;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelResult;
    }
}

