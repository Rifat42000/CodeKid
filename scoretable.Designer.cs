namespace CodeKid
{
    partial class scoretable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scoretable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeKidDataSet3 = new CodeKid.CodeKidDataSet3();
            this.scoreTableAdapter = new CodeKid.CodeKidDataSet3TableAdapters.ScoreTableAdapter();
            this.judgementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.judgementTableAdapter = new CodeKid.CodeKidDataSet3TableAdapters.JudgementTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeKidDataSet12 = new CodeKid.CodeKidDataSet12();
            this.playerTableAdapter = new CodeKid.CodeKidDataSet12TableAdapters.playerTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeKidDataSet16 = new CodeKid.CodeKidDataSet16();
            this.rankTableAdapter = new CodeKid.CodeKidDataSet16TableAdapters.rankTableAdapter();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playeridDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeKidDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeKidDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeKidDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(54, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 43);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(1204, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 57);
            this.button6.TabIndex = 24;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(1134, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 57);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.codeKidDataSet3;
            // 
            // codeKidDataSet3
            // 
            this.codeKidDataSet3.DataSetName = "CodeKidDataSet3";
            this.codeKidDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // judgementBindingSource
            // 
            this.judgementBindingSource.DataMember = "Judgement";
            this.judgementBindingSource.DataSource = this.codeKidDataSet3;
            // 
            // judgementTableAdapter
            // 
            this.judgementTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.playernameDataGridViewTextBoxColumn,
            this.playerageDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(54, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1176, 184);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "player";
            this.playerBindingSource.DataSource = this.codeKidDataSet12;
            // 
            // codeKidDataSet12
            // 
            this.codeKidDataSet12.DataSetName = "CodeKidDataSet12";
            this.codeKidDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn1,
            this.player_age,
            this.player_name,
            this.rankDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rankBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(54, 444);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1176, 150);
            this.dataGridView2.TabIndex = 26;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_2);
            // 
            // rankBindingSource
            // 
            this.rankBindingSource.DataMember = "rank";
            this.rankBindingSource.DataSource = this.codeKidDataSet16;
            // 
            // codeKidDataSet16
            // 
            this.codeKidDataSet16.DataSetName = "CodeKidDataSet16";
            this.codeKidDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rankTableAdapter
            // 
            this.rankTableAdapter.ClearBeforeFill = true;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "player_id";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.Width = 290;
            // 
            // playernameDataGridViewTextBoxColumn
            // 
            this.playernameDataGridViewTextBoxColumn.DataPropertyName = "player_name";
            this.playernameDataGridViewTextBoxColumn.HeaderText = "player_name";
            this.playernameDataGridViewTextBoxColumn.Name = "playernameDataGridViewTextBoxColumn";
            this.playernameDataGridViewTextBoxColumn.Width = 290;
            // 
            // playerageDataGridViewTextBoxColumn
            // 
            this.playerageDataGridViewTextBoxColumn.DataPropertyName = "player_age";
            this.playerageDataGridViewTextBoxColumn.HeaderText = "player_age";
            this.playerageDataGridViewTextBoxColumn.Name = "playerageDataGridViewTextBoxColumn";
            this.playerageDataGridViewTextBoxColumn.Width = 290;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 290;
            // 
            // playeridDataGridViewTextBoxColumn1
            // 
            this.playeridDataGridViewTextBoxColumn1.DataPropertyName = "player_id";
            this.playeridDataGridViewTextBoxColumn1.HeaderText = "player_id";
            this.playeridDataGridViewTextBoxColumn1.Name = "playeridDataGridViewTextBoxColumn1";
            this.playeridDataGridViewTextBoxColumn1.Width = 250;
            // 
            // player_age
            // 
            this.player_age.DataPropertyName = "player_id";
            this.player_age.HeaderText = "player_age";
            this.player_age.Name = "player_age";
            this.player_age.Width = 250;
            // 
            // player_name
            // 
            this.player_name.DataPropertyName = "player_id";
            this.player_name.HeaderText = "player_name";
            this.player_name.Name = "player_name";
            this.player_name.Width = 250;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.Width = 250;
            // 
            // scoretable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "scoretable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "scoretable";
            this.Load += new System.EventHandler(this.scoretable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeKidDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.judgementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeKidDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeKidDataSet16)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private CodeKidDataSet3 codeKidDataSet3;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private CodeKidDataSet3TableAdapters.ScoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.BindingSource judgementBindingSource;
        private CodeKidDataSet3TableAdapters.JudgementTableAdapter judgementTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CodeKidDataSet12 codeKidDataSet12;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private CodeKidDataSet12TableAdapters.playerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private CodeKidDataSet16 codeKidDataSet16;
        private System.Windows.Forms.BindingSource rankBindingSource;
        private CodeKidDataSet16TableAdapters.rankTableAdapter rankTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
    }
}