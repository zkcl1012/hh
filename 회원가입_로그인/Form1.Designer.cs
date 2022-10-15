namespace 회원가입_로그인
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.tall_text = new System.Windows.Forms.TextBox();
            this.weight_text = new System.Windows.Forms.TextBox();
            this.Sign_in_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(179, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(200, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "키";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(158, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "몸무게";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(256, 140);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(127, 21);
            this.name_text.TabIndex = 3;
            // 
            // tall_text
            // 
            this.tall_text.Location = new System.Drawing.Point(256, 200);
            this.tall_text.Name = "tall_text";
            this.tall_text.Size = new System.Drawing.Size(127, 21);
            this.tall_text.TabIndex = 4;
            // 
            // weight_text
            // 
            this.weight_text.Location = new System.Drawing.Point(256, 258);
            this.weight_text.Name = "weight_text";
            this.weight_text.Size = new System.Drawing.Size(127, 21);
            this.weight_text.TabIndex = 5;
            // 
            // Sign_in_button
            // 
            this.Sign_in_button.Location = new System.Drawing.Point(422, 140);
            this.Sign_in_button.Name = "Sign_in_button";
            this.Sign_in_button.Size = new System.Drawing.Size(87, 139);
            this.Sign_in_button.TabIndex = 6;
            this.Sign_in_button.Text = "로그인";
            this.Sign_in_button.UseVisualStyleBackColor = true;
            this.Sign_in_button.Click += new System.EventHandler(this.Sign_in_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sign_in_button);
            this.Controls.Add(this.weight_text);
            this.Controls.Add(this.tall_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Health_Care";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox tall_text;
        private System.Windows.Forms.TextBox weight_text;
        private System.Windows.Forms.Button Sign_in_button;
    }
}

