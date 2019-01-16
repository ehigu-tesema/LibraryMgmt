namespace Lib
{
    partial class bookInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookInfo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.srch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.booksNumber = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.date = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(33, 39);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(571, 166);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(226, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(157, 21);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "View Books Info";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(586, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // srch
            // 
            this.srch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.srch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.srch.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.srch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.srch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.srch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.srch.HintForeColor = System.Drawing.Color.Empty;
            this.srch.HintText = "";
            this.srch.isPassword = false;
            this.srch.LineFocusedColor = System.Drawing.Color.Blue;
            this.srch.LineIdleColor = System.Drawing.Color.Gray;
            this.srch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.srch.LineThickness = 3;
            this.srch.Location = new System.Drawing.Point(78, 216);
            this.srch.Margin = new System.Windows.Forms.Padding(4);
            this.srch.MaxLength = 32767;
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(145, 33);
            this.srch.TabIndex = 3;
            this.srch.Text = "type here..";
            this.srch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.srch.Enter += new System.EventHandler(this.Enter);
            this.srch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search);
            this.srch.Leave += new System.EventHandler(this.Leave);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(30, 226);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(41, 13);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "Search";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(381, 226);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Total";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(493, 226);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(52, 16);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Books";
            // 
            // booksNumber
            // 
            this.booksNumber.AutoSize = true;
            this.booksNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.booksNumber.Location = new System.Drawing.Point(435, 226);
            this.booksNumber.Name = "booksNumber";
            this.booksNumber.Size = new System.Drawing.Size(0, 16);
            this.booksNumber.TabIndex = 4;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(67, 279);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(571, 166);
            this.bunifuCustomDataGrid2.TabIndex = 0;
            this.bunifuCustomDataGrid2.Visible = false;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(85, 330);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(72, 13);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Book Name";
            // 
            // name
            // 
            this.name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.name.BackColor = System.Drawing.Color.Gainsboro;
            this.name.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Blue;
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(164, 310);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(145, 33);
            this.name.TabIndex = 6;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(328, 330);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(87, 13);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Book Quantity";
            // 
            // quantity
            // 
            this.quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.quantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.quantity.BackColor = System.Drawing.Color.Gainsboro;
            this.quantity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity.HintForeColor = System.Drawing.Color.Empty;
            this.quantity.HintText = "";
            this.quantity.isPassword = false;
            this.quantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.quantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.quantity.LineThickness = 3;
            this.quantity.Location = new System.Drawing.Point(438, 310);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.MaxLength = 32767;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(145, 33);
            this.quantity.TabIndex = 6;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(85, 371);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(77, 13);
            this.bunifuCustomLabel5.TabIndex = 5;
            this.bunifuCustomLabel5.Text = "Book Author";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(328, 371);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(91, 13);
            this.bunifuCustomLabel7.TabIndex = 5;
            this.bunifuCustomLabel7.Text = "Prchased Date";
            // 
            // author
            // 
            this.author.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.author.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.author.BackColor = System.Drawing.Color.Gainsboro;
            this.author.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.author.HintForeColor = System.Drawing.Color.Empty;
            this.author.HintText = "";
            this.author.isPassword = false;
            this.author.LineFocusedColor = System.Drawing.Color.Blue;
            this.author.LineIdleColor = System.Drawing.Color.Gray;
            this.author.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.author.LineThickness = 3;
            this.author.Location = new System.Drawing.Point(164, 351);
            this.author.Margin = new System.Windows.Forms.Padding(4);
            this.author.MaxLength = 32767;
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(145, 33);
            this.author.TabIndex = 6;
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // update
            // 
            this.update.Active = false;
            this.update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update.BorderRadius = 0;
            this.update.ButtonText = "Update";
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.DisabledColor = System.Drawing.Color.Gray;
            this.update.Iconcolor = System.Drawing.Color.Transparent;
            this.update.Iconimage = ((System.Drawing.Image)(resources.GetObject("update.Iconimage")));
            this.update.Iconimage_right = null;
            this.update.Iconimage_right_Selected = null;
            this.update.Iconimage_Selected = null;
            this.update.IconMarginLeft = 0;
            this.update.IconMarginRight = 0;
            this.update.IconRightVisible = true;
            this.update.IconRightZoom = 0D;
            this.update.IconVisible = true;
            this.update.IconZoom = 90D;
            this.update.IsTab = false;
            this.update.Location = new System.Drawing.Point(267, 401);
            this.update.Name = "update";
            this.update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.update.OnHoverTextColor = System.Drawing.Color.White;
            this.update.selected = false;
            this.update.Size = new System.Drawing.Size(107, 31);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Textcolor = System.Drawing.Color.White;
            this.update.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(264, 290);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(104, 16);
            this.bunifuCustomLabel9.TabIndex = 9;
            this.bunifuCustomLabel9.Text = "Edit Book Info";
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.SeaGreen;
            this.date.BorderRadius = 0;
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.FormatCustom = null;
            this.date.Location = new System.Drawing.Point(438, 371);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 22);
            this.date.TabIndex = 10;
            this.date.Value = new System.DateTime(2019, 1, 14, 13, 52, 23, 952);
            // 
            // bookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 466);
            this.Controls.Add(this.date);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.update);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.booksNumber);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookInfo";
            this.Load += new System.EventHandler(this.bookInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox srch;
        private Bunifu.Framework.UI.BunifuCustomLabel booksNumber;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel label;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox author;
        private Bunifu.Framework.UI.BunifuFlatButton update;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuDatepicker date;
    }
}