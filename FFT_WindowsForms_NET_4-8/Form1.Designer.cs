namespace FFT_WindowsForms_NET_4_8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TableBack = new System.Windows.Forms.TableLayoutPanel();
            this.TableUP = new System.Windows.Forms.TableLayoutPanel();
            this.TableDown = new System.Windows.Forms.TableLayoutPanel();
            this.chart_UP_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_UP_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DOWN_1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DOWN_2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_DOWN_3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TableBack.SuspendLayout();
            this.TableUP.SuspendLayout();
            this.TableDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_UP_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_UP_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DOWN_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DOWN_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DOWN_3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TableBack
            // 
            this.TableBack.AutoSize = true;
            this.TableBack.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TableBack.ColumnCount = 1;
            this.TableBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableBack.Controls.Add(this.TableUP, 0, 0);
            this.TableBack.Controls.Add(this.TableDown, 0, 1);
            this.TableBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableBack.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TableBack.Location = new System.Drawing.Point(0, 0);
            this.TableBack.Name = "TableBack";
            this.TableBack.RowCount = 2;
            this.TableBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableBack.Size = new System.Drawing.Size(1009, 388);
            this.TableBack.TabIndex = 0;
            // 
            // TableUP
            // 
            this.TableUP.AutoSize = true;
            this.TableUP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableUP.ColumnCount = 2;
            this.TableUP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUP.Controls.Add(this.chart_UP_2, 1, 0);
            this.TableUP.Controls.Add(this.chart_UP_1, 0, 0);
            this.TableUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableUP.Location = new System.Drawing.Point(3, 3);
            this.TableUP.Name = "TableUP";
            this.TableUP.RowCount = 1;
            this.TableUP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableUP.Size = new System.Drawing.Size(1003, 188);
            this.TableUP.TabIndex = 0;
            // 
            // TableDown
            // 
            this.TableDown.AutoScroll = true;
            this.TableDown.AutoSize = true;
            this.TableDown.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.TableDown.ColumnCount = 3;
            this.TableDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableDown.Controls.Add(this.chart_DOWN_3, 0, 0);
            this.TableDown.Controls.Add(this.chart_DOWN_2, 0, 0);
            this.TableDown.Controls.Add(this.chart_DOWN_1, 0, 0);
            this.TableDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableDown.Location = new System.Drawing.Point(3, 197);
            this.TableDown.Name = "TableDown";
            this.TableDown.RowCount = 1;
            this.TableDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableDown.Size = new System.Drawing.Size(1003, 188);
            this.TableDown.TabIndex = 1;
            // 
            // chart_UP_1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_UP_1.ChartAreas.Add(chartArea2);
            this.chart_UP_1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_UP_1.Legends.Add(legend2);
            this.chart_UP_1.Location = new System.Drawing.Point(5, 5);
            this.chart_UP_1.Name = "chart_UP_1";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_UP_1.Series.Add(series2);
            this.chart_UP_1.Size = new System.Drawing.Size(492, 178);
            this.chart_UP_1.TabIndex = 0;
            this.chart_UP_1.Text = "chart1";
            // 
            // chart_UP_2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_UP_2.ChartAreas.Add(chartArea1);
            this.chart_UP_2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_UP_2.Legends.Add(legend1);
            this.chart_UP_2.Location = new System.Drawing.Point(505, 5);
            this.chart_UP_2.Name = "chart_UP_2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_UP_2.Series.Add(series1);
            this.chart_UP_2.Size = new System.Drawing.Size(493, 178);
            this.chart_UP_2.TabIndex = 1;
            this.chart_UP_2.Text = "chart1";
            // 
            // chart_DOWN_1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_DOWN_1.ChartAreas.Add(chartArea5);
            this.chart_DOWN_1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chart_DOWN_1.Legends.Add(legend5);
            this.chart_DOWN_1.Location = new System.Drawing.Point(5, 5);
            this.chart_DOWN_1.Name = "chart_DOWN_1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_DOWN_1.Series.Add(series5);
            this.chart_DOWN_1.Size = new System.Drawing.Size(325, 178);
            this.chart_DOWN_1.TabIndex = 2;
            this.chart_DOWN_1.Text = "chart1";
            // 
            // chart_DOWN_2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_DOWN_2.ChartAreas.Add(chartArea4);
            this.chart_DOWN_2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart_DOWN_2.Legends.Add(legend4);
            this.chart_DOWN_2.Location = new System.Drawing.Point(338, 5);
            this.chart_DOWN_2.Name = "chart_DOWN_2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart_DOWN_2.Series.Add(series4);
            this.chart_DOWN_2.Size = new System.Drawing.Size(325, 178);
            this.chart_DOWN_2.TabIndex = 3;
            this.chart_DOWN_2.Text = "chart1";
            // 
            // chart_DOWN_3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_DOWN_3.ChartAreas.Add(chartArea3);
            this.chart_DOWN_3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_DOWN_3.Legends.Add(legend3);
            this.chart_DOWN_3.Location = new System.Drawing.Point(671, 5);
            this.chart_DOWN_3.Name = "chart_DOWN_3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_DOWN_3.Series.Add(series3);
            this.chart_DOWN_3.Size = new System.Drawing.Size(327, 178);
            this.chart_DOWN_3.TabIndex = 4;
            this.chart_DOWN_3.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 388);
            this.Controls.Add(this.TableBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableBack.ResumeLayout(false);
            this.TableBack.PerformLayout();
            this.TableUP.ResumeLayout(false);
            this.TableDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_UP_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_UP_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DOWN_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DOWN_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DOWN_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel TableBack;
        private System.Windows.Forms.TableLayoutPanel TableUP;
        private System.Windows.Forms.TableLayoutPanel TableDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_UP_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_UP_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DOWN_3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DOWN_2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DOWN_1;
    }
}

