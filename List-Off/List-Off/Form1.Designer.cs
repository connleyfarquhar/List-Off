namespace List_Off
{
    partial class List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.clearList = new System.Windows.Forms.Button();
            this.listName = new System.Windows.Forms.Label();
            this.shoppingList = new System.Windows.Forms.CheckedListBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.listAdd = new System.Windows.Forms.Button();
            this.listoffLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.listoffLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // clearList
            // 
            this.clearList.BackColor = System.Drawing.Color.LightCoral;
            this.clearList.Location = new System.Drawing.Point(214, 352);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(84, 38);
            this.clearList.TabIndex = 0;
            this.clearList.Text = "Clear";
            this.clearList.UseVisualStyleBackColor = false;
            this.clearList.Click += new System.EventHandler(this.Clear_Click);
            // 
            // listName
            // 
            this.listName.AutoSize = true;
            this.listName.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listName.Location = new System.Drawing.Point(141, 110);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(140, 23);
            this.listName.TabIndex = 4;
            this.listName.Text = "Shopping List";
            // 
            // shoppingList
            // 
            this.shoppingList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shoppingList.FormattingEnabled = true;
            this.shoppingList.Items.AddRange(new object[] {
            "Milk",
            "Sugar",
            "Eggs",
            "Bread",
            "Oil",
            "Cheese",
            "Cereal"});
            this.shoppingList.Location = new System.Drawing.Point(124, 147);
            this.shoppingList.Name = "shoppingList";
            this.shoppingList.Size = new System.Drawing.Size(174, 199);
            this.shoppingList.TabIndex = 5;
            // 
            // listAdd
            // 
            this.listAdd.BackColor = System.Drawing.Color.LightGreen;
            this.listAdd.Location = new System.Drawing.Point(124, 352);
            this.listAdd.Name = "listAdd";
            this.listAdd.Size = new System.Drawing.Size(84, 38);
            this.listAdd.TabIndex = 6;
            this.listAdd.Text = "Add";
            this.listAdd.UseVisualStyleBackColor = false;
            this.listAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // listoffLogo
            // 
            this.listoffLogo.Image = global::List_Off.Properties.Resources.logo;
            this.listoffLogo.Location = new System.Drawing.Point(160, 12);
            this.listoffLogo.Name = "listoffLogo";
            this.listoffLogo.Size = new System.Drawing.Size(98, 95);
            this.listoffLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.listoffLogo.TabIndex = 7;
            this.listoffLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 7F);
            this.label1.Location = new System.Drawing.Point(102, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Copyright List-Off © 2024 All Rights Reserved";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(165)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(415, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listoffLogo);
            this.Controls.Add(this.listAdd);
            this.Controls.Add(this.shoppingList);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.clearList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "List";
            this.Text = "List-Off!";
            ((System.ComponentModel.ISupportInitialize)(this.listoffLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearList;
        private System.Windows.Forms.Label listName;
        private System.Windows.Forms.CheckedListBox shoppingList;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.Button listAdd;
        private System.Windows.Forms.PictureBox listoffLogo;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

