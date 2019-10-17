namespace MEStest001
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msgTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTB = new System.Windows.Forms.TextBox();
            this.btn_request = new System.Windows.Forms.Button();
            this.rb_POST = new System.Windows.Forms.RadioButton();
            this.rb_GET = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgTB
            // 
            this.msgTB.Location = new System.Drawing.Point(36, 274);
            this.msgTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgTB.Multiline = true;
            this.msgTB.Name = "msgTB";
            this.msgTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.msgTB.Size = new System.Drawing.Size(882, 408);
            this.msgTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data:";
            // 
            // dataTB
            // 
            this.dataTB.Location = new System.Drawing.Point(93, 84);
            this.dataTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataTB.Multiline = true;
            this.dataTB.Name = "dataTB";
            this.dataTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dataTB.Size = new System.Drawing.Size(825, 129);
            this.dataTB.TabIndex = 6;
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(290, 232);
            this.btn_request.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(132, 34);
            this.btn_request.TabIndex = 7;
            this.btn_request.Text = "Request";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // rb_POST
            // 
            this.rb_POST.AutoSize = true;
            this.rb_POST.Checked = true;
            this.rb_POST.Location = new System.Drawing.Point(37, 237);
            this.rb_POST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_POST.Name = "rb_POST";
            this.rb_POST.Size = new System.Drawing.Size(69, 24);
            this.rb_POST.TabIndex = 8;
            this.rb_POST.TabStop = true;
            this.rb_POST.Text = "POST";
            this.rb_POST.UseVisualStyleBackColor = true;
            // 
            // rb_GET
            // 
            this.rb_GET.AutoSize = true;
            this.rb_GET.Location = new System.Drawing.Point(165, 237);
            this.rb_GET.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_GET.Name = "rb_GET";
            this.rb_GET.Size = new System.Drawing.Size(58, 24);
            this.rb_GET.TabIndex = 9;
            this.rb_GET.Text = "GET";
            this.rb_GET.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(37, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL:";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(94, 17);
            this.tb_url.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(825, 47);
            this.tb_url.TabIndex = 11;
            // 
            // lb_status
            // 
            this.lb_status.BackColor = System.Drawing.Color.Aqua;
            this.lb_status.Location = new System.Drawing.Point(477, 232);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(403, 35);
            this.lb_status.TabIndex = 12;
            this.lb_status.Text = "Ready";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 693);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_GET);
            this.Controls.Add(this.rb_POST);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.dataTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgTB);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "MEStest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox msgTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataTB;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.RadioButton rb_POST;
        private System.Windows.Forms.RadioButton rb_GET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label lb_status;
    }
}

