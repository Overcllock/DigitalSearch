namespace DigitalSearch {
    partial class MainWindow {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._Run_ = new System.Windows.Forms.ToolStripButton();
            this._Reset_ = new System.Windows.Forms.ToolStripButton();
            this._MainPanel_ = new System.Windows.Forms.TabControl();
            this._Page_Settings_ = new System.Windows.Forms.TabPage();
            this._Setting_Split_ = new System.Windows.Forms.SplitContainer();
            this.Selected_Algorithms = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Settings_Params_Panel_ = new System.Windows.Forms.TableLayoutPanel();
            this.Increase_Key_Length = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Increase_Keys_Count = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Cycles_Count = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Max_Key_Length = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Keys_Count = new System.Windows.Forms.NumericUpDown();
            this._Page_Table_ = new System.Windows.Forms.TabPage();
            this.Stats = new System.Windows.Forms.DataGridView();
            this._Page_Graph_ = new System.Windows.Forms.TabPage();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            this._MainPanel_.SuspendLayout();
            this._Page_Settings_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Setting_Split_)).BeginInit();
            this._Setting_Split_.Panel1.SuspendLayout();
            this._Setting_Split_.Panel2.SuspendLayout();
            this._Setting_Split_.SuspendLayout();
            this._Settings_Params_Panel_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Increase_Key_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Increase_Keys_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycles_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Key_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keys_Count)).BeginInit();
            this._Page_Table_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stats)).BeginInit();
            this._Page_Graph_.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Run_,
            this._Reset_});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _Run_
            // 
            this._Run_.Image = global::DigitalSearch.Properties.Resources.Start;
            this._Run_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._Run_.Name = "_Run_";
            this._Run_.Size = new System.Drawing.Size(65, 22);
            this._Run_.Text = "Запуск";
            this._Run_.Click += new System.EventHandler(this._Run__Click);
            // 
            // _Reset_
            // 
            this._Reset_.Image = global::DigitalSearch.Properties.Resources.Reset;
            this._Reset_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._Reset_.Name = "_Reset_";
            this._Reset_.Size = new System.Drawing.Size(62, 22);
            this._Reset_.Text = "Сброс";
            this._Reset_.Click += new System.EventHandler(this._Reset__Click);
            // 
            // _MainPanel_
            // 
            this._MainPanel_.Controls.Add(this._Page_Settings_);
            this._MainPanel_.Controls.Add(this._Page_Table_);
            this._MainPanel_.Controls.Add(this._Page_Graph_);
            this._MainPanel_.Dock = System.Windows.Forms.DockStyle.Fill;
            this._MainPanel_.Location = new System.Drawing.Point(0, 25);
            this._MainPanel_.Name = "_MainPanel_";
            this._MainPanel_.SelectedIndex = 0;
            this._MainPanel_.Size = new System.Drawing.Size(784, 536);
            this._MainPanel_.TabIndex = 1;
            // 
            // _Page_Settings_
            // 
            this._Page_Settings_.Controls.Add(this._Setting_Split_);
            this._Page_Settings_.Location = new System.Drawing.Point(4, 22);
            this._Page_Settings_.Name = "_Page_Settings_";
            this._Page_Settings_.Padding = new System.Windows.Forms.Padding(3);
            this._Page_Settings_.Size = new System.Drawing.Size(776, 510);
            this._Page_Settings_.TabIndex = 0;
            this._Page_Settings_.Text = "Настройки";
            this._Page_Settings_.UseVisualStyleBackColor = true;
            // 
            // _Setting_Split_
            // 
            this._Setting_Split_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Setting_Split_.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Setting_Split_.Location = new System.Drawing.Point(3, 3);
            this._Setting_Split_.Name = "_Setting_Split_";
            // 
            // _Setting_Split_.Panel1
            // 
            this._Setting_Split_.Panel1.Controls.Add(this.Selected_Algorithms);
            this._Setting_Split_.Panel1.Controls.Add(this.label1);
            // 
            // _Setting_Split_.Panel2
            // 
            this._Setting_Split_.Panel2.Controls.Add(this._Settings_Params_Panel_);
            this._Setting_Split_.Size = new System.Drawing.Size(770, 504);
            this._Setting_Split_.SplitterDistance = 256;
            this._Setting_Split_.TabIndex = 0;
            // 
            // Selected_Algorithms
            // 
            this.Selected_Algorithms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Selected_Algorithms.CheckOnClick = true;
            this.Selected_Algorithms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Selected_Algorithms.FormattingEnabled = true;
            this.Selected_Algorithms.Items.AddRange(new object[] {
            "Дерево цифрового поиска",
            "Метод цепочек",
            "Упорядоченный массив"});
            this.Selected_Algorithms.Location = new System.Drawing.Point(0, 24);
            this.Selected_Algorithms.Name = "Selected_Algorithms";
            this.Selected_Algorithms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Selected_Algorithms.Size = new System.Drawing.Size(254, 478);
            this.Selected_Algorithms.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сравниваемые алгоритмы:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Settings_Params_Panel_
            // 
            this._Settings_Params_Panel_.ColumnCount = 2;
            this._Settings_Params_Panel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.67716F));
            this._Settings_Params_Panel_.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32283F));
            this._Settings_Params_Panel_.Controls.Add(this.Increase_Key_Length, 1, 4);
            this._Settings_Params_Panel_.Controls.Add(this.label6, 0, 4);
            this._Settings_Params_Panel_.Controls.Add(this.Increase_Keys_Count, 1, 3);
            this._Settings_Params_Panel_.Controls.Add(this.label5, 0, 3);
            this._Settings_Params_Panel_.Controls.Add(this.Cycles_Count, 1, 2);
            this._Settings_Params_Panel_.Controls.Add(this.label4, 0, 2);
            this._Settings_Params_Panel_.Controls.Add(this.Max_Key_Length, 1, 1);
            this._Settings_Params_Panel_.Controls.Add(this.label3, 0, 1);
            this._Settings_Params_Panel_.Controls.Add(this.label2, 0, 0);
            this._Settings_Params_Panel_.Controls.Add(this.Keys_Count, 1, 0);
            this._Settings_Params_Panel_.Dock = System.Windows.Forms.DockStyle.Top;
            this._Settings_Params_Panel_.Location = new System.Drawing.Point(0, 0);
            this._Settings_Params_Panel_.Name = "_Settings_Params_Panel_";
            this._Settings_Params_Panel_.RowCount = 5;
            this._Settings_Params_Panel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._Settings_Params_Panel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._Settings_Params_Panel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._Settings_Params_Panel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._Settings_Params_Panel_.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._Settings_Params_Panel_.Size = new System.Drawing.Size(508, 109);
            this._Settings_Params_Panel_.TabIndex = 0;
            // 
            // Increase_Key_Length
            // 
            this.Increase_Key_Length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Increase_Key_Length.Location = new System.Drawing.Point(423, 87);
            this.Increase_Key_Length.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Increase_Key_Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Increase_Key_Length.Name = "Increase_Key_Length";
            this.Increase_Key_Length.Size = new System.Drawing.Size(82, 20);
            this.Increase_Key_Length.TabIndex = 9;
            this.Increase_Key_Length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Увеличивать число символов на:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Increase_Keys_Count
            // 
            this.Increase_Keys_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Increase_Keys_Count.Location = new System.Drawing.Point(423, 66);
            this.Increase_Keys_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Increase_Keys_Count.Name = "Increase_Keys_Count";
            this.Increase_Keys_Count.Size = new System.Drawing.Size(82, 20);
            this.Increase_Keys_Count.TabIndex = 7;
            this.Increase_Keys_Count.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(414, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Увеличивать количество ключей на:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cycles_Count
            // 
            this.Cycles_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cycles_Count.Location = new System.Drawing.Point(423, 45);
            this.Cycles_Count.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Cycles_Count.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Cycles_Count.Name = "Cycles_Count";
            this.Cycles_Count.Size = new System.Drawing.Size(82, 20);
            this.Cycles_Count.TabIndex = 5;
            this.Cycles_Count.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество выборок:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Max_Key_Length
            // 
            this.Max_Key_Length.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Max_Key_Length.Location = new System.Drawing.Point(423, 24);
            this.Max_Key_Length.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Max_Key_Length.Name = "Max_Key_Length";
            this.Max_Key_Length.Size = new System.Drawing.Size(82, 20);
            this.Max_Key_Length.TabIndex = 3;
            this.Max_Key_Length.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальное число символов ключа:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Количество ключей:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Keys_Count
            // 
            this.Keys_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Keys_Count.Location = new System.Drawing.Point(423, 3);
            this.Keys_Count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Keys_Count.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Keys_Count.Name = "Keys_Count";
            this.Keys_Count.Size = new System.Drawing.Size(82, 20);
            this.Keys_Count.TabIndex = 1;
            this.Keys_Count.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _Page_Table_
            // 
            this._Page_Table_.Controls.Add(this.Stats);
            this._Page_Table_.Location = new System.Drawing.Point(4, 22);
            this._Page_Table_.Name = "_Page_Table_";
            this._Page_Table_.Padding = new System.Windows.Forms.Padding(3);
            this._Page_Table_.Size = new System.Drawing.Size(776, 510);
            this._Page_Table_.TabIndex = 1;
            this._Page_Table_.Text = "Таблица";
            this._Page_Table_.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            this.Stats.AllowUserToOrderColumns = true;
            this.Stats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Stats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Stats.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Stats.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stats.Location = new System.Drawing.Point(3, 3);
            this.Stats.MultiSelect = false;
            this.Stats.Name = "Stats";
            this.Stats.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stats.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Stats.RowHeadersWidth = 500;
            this.Stats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Stats.RowTemplate.ReadOnly = true;
            this.Stats.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Stats.Size = new System.Drawing.Size(770, 504);
            this.Stats.TabIndex = 5;
            // 
            // _Page_Graph_
            // 
            this._Page_Graph_.Controls.Add(this.Graph);
            this._Page_Graph_.Location = new System.Drawing.Point(4, 22);
            this._Page_Graph_.Name = "_Page_Graph_";
            this._Page_Graph_.Size = new System.Drawing.Size(776, 510);
            this._Page_Graph_.TabIndex = 2;
            this._Page_Graph_.Text = "График";
            this._Page_Graph_.UseVisualStyleBackColor = true;
            // 
            // Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea1);
            this.Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Graph.Legends.Add(legend1);
            this.Graph.Location = new System.Drawing.Point(0, 0);
            this.Graph.Name = "Graph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Graph.Series.Add(series1);
            this.Graph.Size = new System.Drawing.Size(776, 510);
            this.Graph.TabIndex = 0;
            this.Graph.Text = "chart1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this._MainPanel_);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Search";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this._MainPanel_.ResumeLayout(false);
            this._Page_Settings_.ResumeLayout(false);
            this._Setting_Split_.Panel1.ResumeLayout(false);
            this._Setting_Split_.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Setting_Split_)).EndInit();
            this._Setting_Split_.ResumeLayout(false);
            this._Settings_Params_Panel_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Increase_Key_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Increase_Keys_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycles_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_Key_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Keys_Count)).EndInit();
            this._Page_Table_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Stats)).EndInit();
            this._Page_Graph_.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _Run_;
        private System.Windows.Forms.ToolStripButton _Reset_;
        private System.Windows.Forms.TabControl _MainPanel_;
        private System.Windows.Forms.TabPage _Page_Settings_;
        private System.Windows.Forms.TabPage _Page_Table_;
        private System.Windows.Forms.TabPage _Page_Graph_;
        private System.Windows.Forms.SplitContainer _Setting_Split_;
        private System.Windows.Forms.CheckedListBox Selected_Algorithms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel _Settings_Params_Panel_;
        private System.Windows.Forms.NumericUpDown Increase_Key_Length;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Increase_Keys_Count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Cycles_Count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Max_Key_Length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Keys_Count;
        private System.Windows.Forms.DataGridView Stats;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
    }
}

