namespace Calc
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Text_Display = new System.Windows.Forms.TextBox();
            this.Text_Result = new System.Windows.Forms.TextBox();
            this.Button_Num8 = new System.Windows.Forms.Button();
            this.Button_Num9 = new System.Windows.Forms.Button();
            this.Button_Plus = new System.Windows.Forms.Button();
            this.Button_Num4 = new System.Windows.Forms.Button();
            this.Button_Num5 = new System.Windows.Forms.Button();
            this.Button_Num6 = new System.Windows.Forms.Button();
            this.Button_Minus = new System.Windows.Forms.Button();
            this.Button_Num1 = new System.Windows.Forms.Button();
            this.Button_Num2 = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Num0 = new System.Windows.Forms.Button();
            this.Button_Num3 = new System.Windows.Forms.Button();
            this.Button_Multi = new System.Windows.Forms.Button();
            this.Button_Equal = new System.Windows.Forms.Button();
            this.Button_Div = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Num7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Display
            // 
            this.Text_Display.Font = new System.Drawing.Font("나눔고딕", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Display.Location = new System.Drawing.Point(24, 12);
            this.Text_Display.Name = "Text_Display";
            this.Text_Display.Size = new System.Drawing.Size(330, 62);
            this.Text_Display.TabIndex = 1;
            this.Text_Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Text_Result
            // 
            this.Text_Result.Font = new System.Drawing.Font("나눔고딕", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_Result.Location = new System.Drawing.Point(108, 80);
            this.Text_Result.Name = "Text_Result";
            this.Text_Result.Size = new System.Drawing.Size(246, 62);
            this.Text_Result.TabIndex = 2;
            this.Text_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button_Num8
            // 
            this.Button_Num8.Location = new System.Drawing.Point(108, 148);
            this.Button_Num8.Name = "Button_Num8";
            this.Button_Num8.Size = new System.Drawing.Size(78, 72);
            this.Button_Num8.TabIndex = 3;
            this.Button_Num8.Text = "8";
            this.Button_Num8.UseVisualStyleBackColor = true;
            this.Button_Num8.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Num9
            // 
            this.Button_Num9.Location = new System.Drawing.Point(192, 148);
            this.Button_Num9.Name = "Button_Num9";
            this.Button_Num9.Size = new System.Drawing.Size(78, 72);
            this.Button_Num9.TabIndex = 3;
            this.Button_Num9.Text = "9";
            this.Button_Num9.UseVisualStyleBackColor = true;
            this.Button_Num9.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Plus
            // 
            this.Button_Plus.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Plus.Location = new System.Drawing.Point(276, 148);
            this.Button_Plus.Name = "Button_Plus";
            this.Button_Plus.Size = new System.Drawing.Size(78, 72);
            this.Button_Plus.TabIndex = 3;
            this.Button_Plus.Text = "+";
            this.Button_Plus.UseVisualStyleBackColor = false;
            this.Button_Plus.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // Button_Num4
            // 
            this.Button_Num4.Location = new System.Drawing.Point(24, 226);
            this.Button_Num4.Name = "Button_Num4";
            this.Button_Num4.Size = new System.Drawing.Size(78, 72);
            this.Button_Num4.TabIndex = 0;
            this.Button_Num4.Text = "4";
            this.Button_Num4.UseVisualStyleBackColor = true;
            this.Button_Num4.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Num5
            // 
            this.Button_Num5.Location = new System.Drawing.Point(108, 226);
            this.Button_Num5.Name = "Button_Num5";
            this.Button_Num5.Size = new System.Drawing.Size(78, 72);
            this.Button_Num5.TabIndex = 3;
            this.Button_Num5.Text = "5";
            this.Button_Num5.UseVisualStyleBackColor = true;
            this.Button_Num5.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Num6
            // 
            this.Button_Num6.Location = new System.Drawing.Point(192, 226);
            this.Button_Num6.Name = "Button_Num6";
            this.Button_Num6.Size = new System.Drawing.Size(78, 72);
            this.Button_Num6.TabIndex = 3;
            this.Button_Num6.Text = "6";
            this.Button_Num6.UseVisualStyleBackColor = true;
            this.Button_Num6.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Minus
            // 
            this.Button_Minus.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Minus.Location = new System.Drawing.Point(276, 226);
            this.Button_Minus.Name = "Button_Minus";
            this.Button_Minus.Size = new System.Drawing.Size(78, 72);
            this.Button_Minus.TabIndex = 3;
            this.Button_Minus.Text = "-";
            this.Button_Minus.UseVisualStyleBackColor = false;
            this.Button_Minus.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // Button_Num1
            // 
            this.Button_Num1.Location = new System.Drawing.Point(24, 304);
            this.Button_Num1.Name = "Button_Num1";
            this.Button_Num1.Size = new System.Drawing.Size(78, 72);
            this.Button_Num1.TabIndex = 0;
            this.Button_Num1.Text = "1";
            this.Button_Num1.UseVisualStyleBackColor = true;
            this.Button_Num1.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Num2
            // 
            this.Button_Num2.Location = new System.Drawing.Point(108, 304);
            this.Button_Num2.Name = "Button_Num2";
            this.Button_Num2.Size = new System.Drawing.Size(78, 72);
            this.Button_Num2.TabIndex = 3;
            this.Button_Num2.Text = "2";
            this.Button_Num2.UseVisualStyleBackColor = true;
            this.Button_Num2.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Clear.Location = new System.Drawing.Point(24, 382);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(78, 72);
            this.Button_Clear.TabIndex = 0;
            this.Button_Clear.Text = "C";
            this.Button_Clear.UseVisualStyleBackColor = false;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Num0
            // 
            this.Button_Num0.Location = new System.Drawing.Point(108, 382);
            this.Button_Num0.Name = "Button_Num0";
            this.Button_Num0.Size = new System.Drawing.Size(78, 72);
            this.Button_Num0.TabIndex = 3;
            this.Button_Num0.Text = "0";
            this.Button_Num0.UseVisualStyleBackColor = true;
            this.Button_Num0.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Num3
            // 
            this.Button_Num3.Location = new System.Drawing.Point(192, 304);
            this.Button_Num3.Name = "Button_Num3";
            this.Button_Num3.Size = new System.Drawing.Size(78, 72);
            this.Button_Num3.TabIndex = 3;
            this.Button_Num3.Text = "3";
            this.Button_Num3.UseVisualStyleBackColor = true;
            this.Button_Num3.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Button_Multi
            // 
            this.Button_Multi.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Multi.Location = new System.Drawing.Point(276, 304);
            this.Button_Multi.Name = "Button_Multi";
            this.Button_Multi.Size = new System.Drawing.Size(78, 72);
            this.Button_Multi.TabIndex = 3;
            this.Button_Multi.Text = "x";
            this.Button_Multi.UseVisualStyleBackColor = false;
            this.Button_Multi.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // Button_Equal
            // 
            this.Button_Equal.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Equal.Location = new System.Drawing.Point(192, 382);
            this.Button_Equal.Name = "Button_Equal";
            this.Button_Equal.Size = new System.Drawing.Size(78, 72);
            this.Button_Equal.TabIndex = 3;
            this.Button_Equal.Text = "=";
            this.Button_Equal.UseVisualStyleBackColor = false;
            this.Button_Equal.Click += new System.EventHandler(this.Button_Equal_Click);
            // 
            // Button_Div
            // 
            this.Button_Div.BackColor = System.Drawing.SystemColors.Info;
            this.Button_Div.Location = new System.Drawing.Point(276, 382);
            this.Button_Div.Name = "Button_Div";
            this.Button_Div.Size = new System.Drawing.Size(78, 72);
            this.Button_Div.TabIndex = 3;
            this.Button_Div.Text = "÷";
            this.Button_Div.UseVisualStyleBackColor = false;
            this.Button_Div.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "결과";
            // 
            // Button_Num7
            // 
            this.Button_Num7.Location = new System.Drawing.Point(24, 148);
            this.Button_Num7.Name = "Button_Num7";
            this.Button_Num7.Size = new System.Drawing.Size(78, 72);
            this.Button_Num7.TabIndex = 0;
            this.Button_Num7.Text = "7";
            this.Button_Num7.UseVisualStyleBackColor = true;
            this.Button_Num7.Click += new System.EventHandler(this.Button_Num_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Div);
            this.Controls.Add(this.Button_Equal);
            this.Controls.Add(this.Button_Multi);
            this.Controls.Add(this.Button_Num3);
            this.Controls.Add(this.Button_Minus);
            this.Controls.Add(this.Button_Num0);
            this.Controls.Add(this.Button_Num6);
            this.Controls.Add(this.Button_Num2);
            this.Controls.Add(this.Button_Plus);
            this.Controls.Add(this.Button_Num5);
            this.Controls.Add(this.Button_Num9);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Num8);
            this.Controls.Add(this.Button_Num1);
            this.Controls.Add(this.Text_Result);
            this.Controls.Add(this.Button_Num4);
            this.Controls.Add(this.Text_Display);
            this.Controls.Add(this.Button_Num7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Text_Display;
        private System.Windows.Forms.TextBox Text_Result;
        private System.Windows.Forms.Button Button_Num8;
        private System.Windows.Forms.Button Button_Num9;
        private System.Windows.Forms.Button Button_Plus;
        private System.Windows.Forms.Button Button_Num4;
        private System.Windows.Forms.Button Button_Num5;
        private System.Windows.Forms.Button Button_Num6;
        private System.Windows.Forms.Button Button_Minus;
        private System.Windows.Forms.Button Button_Num1;
        private System.Windows.Forms.Button Button_Num2;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Num0;
        private System.Windows.Forms.Button Button_Num3;
        private System.Windows.Forms.Button Button_Multi;
        private System.Windows.Forms.Button Button_Equal;
        private System.Windows.Forms.Button Button_Div;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Num7;
    }
}

