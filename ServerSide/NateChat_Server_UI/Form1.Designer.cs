namespace NateChat_Server_UI
{
    partial class Server_Main
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lbl_State_Index = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Open.Location = new System.Drawing.Point(258, 178);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(115, 48);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "启动服务";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_Stop.Location = new System.Drawing.Point(427, 178);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(115, 48);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "关闭服务";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lbl_State_Index
            // 
            this.lbl_State_Index.AutoSize = true;
            this.lbl_State_Index.Font = new System.Drawing.Font("宋体", 16F);
            this.lbl_State_Index.Location = new System.Drawing.Point(254, 255);
            this.lbl_State_Index.Name = "lbl_State_Index";
            this.lbl_State_Index.Size = new System.Drawing.Size(164, 22);
            this.lbl_State_Index.TabIndex = 2;
            this.lbl_State_Index.Text = "当前服务状态：";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("宋体", 16F);
            this.lbl_State.Location = new System.Drawing.Point(488, 255);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(54, 22);
            this.lbl_State.TabIndex = 2;
            this.lbl_State.Text = "状态";
            // 
            // Server_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.lbl_State_Index);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Open);
            this.Name = "Server_Main";
            this.Text = "服务器端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lbl_State_Index;
        private System.Windows.Forms.Label lbl_State;
    }
}

