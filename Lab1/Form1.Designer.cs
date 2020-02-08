namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultLbl = new System.Windows.Forms.Label();
            this.FindTangentBtn = new System.Windows.Forms.Button();
            this.CircleXUpdn = new System.Windows.Forms.NumericUpDown();
            this.CircleYUpdn = new System.Windows.Forms.NumericUpDown();
            this.PointYUpdn = new System.Windows.Forms.NumericUpDown();
            this.PointXUpdn = new System.Windows.Forms.NumericUpDown();
            this.CircleRadiusUpdn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LineKUpdn = new System.Windows.Forms.NumericUpDown();
            this.LineBUpdn = new System.Windows.Forms.NumericUpDown();
            this.IsTangentBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Circle2RadiusUpdn = new System.Windows.Forms.NumericUpDown();
            this.Circle2YUpdn = new System.Windows.Forms.NumericUpDown();
            this.Circle2XUpdn = new System.Windows.Forms.NumericUpDown();
            this.GetCommonTangentsBtn = new System.Windows.Forms.Button();
            this.TangentsLV = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.CircleXUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleYUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointYUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointXUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleRadiusUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineKUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineBUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2RadiusUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2YUpdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2XUpdn)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Location = new System.Drawing.Point(131, 420);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(46, 17);
            this.ResultLbl.TabIndex = 0;
            this.ResultLbl.Text = "label1";
            // 
            // FindTangentBtn
            // 
            this.FindTangentBtn.Location = new System.Drawing.Point(252, 258);
            this.FindTangentBtn.Name = "FindTangentBtn";
            this.FindTangentBtn.Size = new System.Drawing.Size(162, 36);
            this.FindTangentBtn.TabIndex = 1;
            this.FindTangentBtn.Text = "Find tangent";
            this.FindTangentBtn.UseVisualStyleBackColor = true;
            this.FindTangentBtn.Click += new System.EventHandler(this.FindTangentBtn_Click);
            // 
            // CircleXUpdn
            // 
            this.CircleXUpdn.DecimalPlaces = 3;
            this.CircleXUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.CircleXUpdn.Location = new System.Drawing.Point(57, 48);
            this.CircleXUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CircleXUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.CircleXUpdn.Name = "CircleXUpdn";
            this.CircleXUpdn.Size = new System.Drawing.Size(120, 22);
            this.CircleXUpdn.TabIndex = 2;
            this.CircleXUpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CircleYUpdn
            // 
            this.CircleYUpdn.DecimalPlaces = 3;
            this.CircleYUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.CircleYUpdn.Location = new System.Drawing.Point(57, 134);
            this.CircleYUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CircleYUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.CircleYUpdn.Name = "CircleYUpdn";
            this.CircleYUpdn.Size = new System.Drawing.Size(120, 22);
            this.CircleYUpdn.TabIndex = 7;
            this.CircleYUpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PointYUpdn
            // 
            this.PointYUpdn.DecimalPlaces = 3;
            this.PointYUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.PointYUpdn.Location = new System.Drawing.Point(267, 220);
            this.PointYUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PointYUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.PointYUpdn.Name = "PointYUpdn";
            this.PointYUpdn.Size = new System.Drawing.Size(120, 22);
            this.PointYUpdn.TabIndex = 8;
            this.PointYUpdn.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // PointXUpdn
            // 
            this.PointXUpdn.DecimalPlaces = 3;
            this.PointXUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PointXUpdn.Location = new System.Drawing.Point(57, 220);
            this.PointXUpdn.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.PointXUpdn.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.PointXUpdn.Name = "PointXUpdn";
            this.PointXUpdn.Size = new System.Drawing.Size(120, 22);
            this.PointXUpdn.TabIndex = 9;
            this.PointXUpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CircleRadiusUpdn
            // 
            this.CircleRadiusUpdn.DecimalPlaces = 3;
            this.CircleRadiusUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.CircleRadiusUpdn.Location = new System.Drawing.Point(267, 48);
            this.CircleRadiusUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CircleRadiusUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.CircleRadiusUpdn.Name = "CircleRadiusUpdn";
            this.CircleRadiusUpdn.Size = new System.Drawing.Size(120, 22);
            this.CircleRadiusUpdn.TabIndex = 10;
            this.CircleRadiusUpdn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "circle X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "point X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "circle Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "point Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Result:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "line B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "line K";
            // 
            // LineKUpdn
            // 
            this.LineKUpdn.DecimalPlaces = 3;
            this.LineKUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LineKUpdn.Location = new System.Drawing.Point(57, 327);
            this.LineKUpdn.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LineKUpdn.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.LineKUpdn.Name = "LineKUpdn";
            this.LineKUpdn.Size = new System.Drawing.Size(120, 22);
            this.LineKUpdn.TabIndex = 19;
            this.LineKUpdn.Value = new decimal(new int[] {
            2536,
            0,
            0,
            -2147287040});
            // 
            // LineBUpdn
            // 
            this.LineBUpdn.DecimalPlaces = 3;
            this.LineBUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.LineBUpdn.Location = new System.Drawing.Point(267, 327);
            this.LineBUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.LineBUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.LineBUpdn.Name = "LineBUpdn";
            this.LineBUpdn.Size = new System.Drawing.Size(120, 22);
            this.LineBUpdn.TabIndex = 18;
            this.LineBUpdn.Value = new decimal(new int[] {
            354,
            0,
            0,
            196608});
            // 
            // IsTangentBtn
            // 
            this.IsTangentBtn.Location = new System.Drawing.Point(252, 365);
            this.IsTangentBtn.Name = "IsTangentBtn";
            this.IsTangentBtn.Size = new System.Drawing.Size(162, 29);
            this.IsTangentBtn.TabIndex = 17;
            this.IsTangentBtn.Text = "Is tangent";
            this.IsTangentBtn.UseVisualStyleBackColor = true;
            this.IsTangentBtn.Click += new System.EventHandler(this.IsTangentBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "circle Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "radius";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "circle X";
            // 
            // Circle2RadiusUpdn
            // 
            this.Circle2RadiusUpdn.DecimalPlaces = 3;
            this.Circle2RadiusUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Circle2RadiusUpdn.Location = new System.Drawing.Point(683, 48);
            this.Circle2RadiusUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Circle2RadiusUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.Circle2RadiusUpdn.Name = "Circle2RadiusUpdn";
            this.Circle2RadiusUpdn.Size = new System.Drawing.Size(120, 22);
            this.Circle2RadiusUpdn.TabIndex = 24;
            this.Circle2RadiusUpdn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Circle2YUpdn
            // 
            this.Circle2YUpdn.DecimalPlaces = 3;
            this.Circle2YUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Circle2YUpdn.Location = new System.Drawing.Point(473, 134);
            this.Circle2YUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Circle2YUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.Circle2YUpdn.Name = "Circle2YUpdn";
            this.Circle2YUpdn.Size = new System.Drawing.Size(120, 22);
            this.Circle2YUpdn.TabIndex = 23;
            this.Circle2YUpdn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Circle2XUpdn
            // 
            this.Circle2XUpdn.DecimalPlaces = 3;
            this.Circle2XUpdn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Circle2XUpdn.Location = new System.Drawing.Point(473, 48);
            this.Circle2XUpdn.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Circle2XUpdn.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.Circle2XUpdn.Name = "Circle2XUpdn";
            this.Circle2XUpdn.Size = new System.Drawing.Size(120, 22);
            this.Circle2XUpdn.TabIndex = 22;
            this.Circle2XUpdn.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // GetCommonTangentsBtn
            // 
            this.GetCommonTangentsBtn.Location = new System.Drawing.Point(683, 134);
            this.GetCommonTangentsBtn.Name = "GetCommonTangentsBtn";
            this.GetCommonTangentsBtn.Size = new System.Drawing.Size(164, 43);
            this.GetCommonTangentsBtn.TabIndex = 28;
            this.GetCommonTangentsBtn.Text = "Find common tangents";
            this.GetCommonTangentsBtn.UseVisualStyleBackColor = true;
            this.GetCommonTangentsBtn.Click += new System.EventHandler(this.GetCommonTangentsBtn_Click);
            // 
            // TangentsLV
            // 
            this.TangentsLV.Location = new System.Drawing.Point(473, 202);
            this.TangentsLV.Name = "TangentsLV";
            this.TangentsLV.Size = new System.Drawing.Size(548, 234);
            this.TangentsLV.TabIndex = 29;
            this.TangentsLV.UseCompatibleStateImageBehavior = false;
            this.TangentsLV.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 462);
            this.Controls.Add(this.TangentsLV);
            this.Controls.Add(this.GetCommonTangentsBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Circle2RadiusUpdn);
            this.Controls.Add(this.Circle2YUpdn);
            this.Controls.Add(this.Circle2XUpdn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LineKUpdn);
            this.Controls.Add(this.LineBUpdn);
            this.Controls.Add(this.IsTangentBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CircleRadiusUpdn);
            this.Controls.Add(this.PointXUpdn);
            this.Controls.Add(this.PointYUpdn);
            this.Controls.Add(this.CircleYUpdn);
            this.Controls.Add(this.CircleXUpdn);
            this.Controls.Add(this.FindTangentBtn);
            this.Controls.Add(this.ResultLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CircleXUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleYUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointYUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointXUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleRadiusUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineKUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineBUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2RadiusUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2YUpdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Circle2XUpdn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button FindTangentBtn;
        private System.Windows.Forms.NumericUpDown CircleXUpdn;
        private System.Windows.Forms.NumericUpDown CircleYUpdn;
        private System.Windows.Forms.NumericUpDown PointYUpdn;
        private System.Windows.Forms.NumericUpDown PointXUpdn;
        private System.Windows.Forms.NumericUpDown CircleRadiusUpdn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown LineKUpdn;
        private System.Windows.Forms.NumericUpDown LineBUpdn;
        private System.Windows.Forms.Button IsTangentBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Circle2RadiusUpdn;
        private System.Windows.Forms.NumericUpDown Circle2YUpdn;
        private System.Windows.Forms.NumericUpDown Circle2XUpdn;
        private System.Windows.Forms.Button GetCommonTangentsBtn;
        private System.Windows.Forms.ListView TangentsLV;
    }
}

