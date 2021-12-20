
namespace MixServersSkinDownloader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NickLabel = new System.Windows.Forms.Label();
            this.NickTB = new System.Windows.Forms.TextBox();
            this.SkinRB = new System.Windows.Forms.RadioButton();
            this.CloakRB = new System.Windows.Forms.RadioButton();
            this.DwnldTypLabel = new System.Windows.Forms.Label();
            this.DwnldBtn = new System.Windows.Forms.Button();
            this.ShowFileCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NickLabel
            // 
            this.NickLabel.AutoSize = true;
            this.NickLabel.Location = new System.Drawing.Point(15, 10);
            this.NickLabel.Margin = new System.Windows.Forms.Padding(0);
            this.NickLabel.Name = "NickLabel";
            this.NickLabel.Size = new System.Drawing.Size(169, 24);
            this.NickLabel.TabIndex = 0;
            this.NickLabel.Text = "Никнейм игрока";
            this.NickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NickTB
            // 
            this.NickTB.Location = new System.Drawing.Point(15, 45);
            this.NickTB.Margin = new System.Windows.Forms.Padding(0);
            this.NickTB.Name = "NickTB";
            this.NickTB.Size = new System.Drawing.Size(257, 28);
            this.NickTB.TabIndex = 0;
            this.NickTB.TextChanged += new System.EventHandler(this.NickTB_TextChanged);
            this.NickTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NickTB_KeyDown);
            // 
            // SkinRB
            // 
            this.SkinRB.AutoSize = true;
            this.SkinRB.Checked = true;
            this.SkinRB.Cursor = System.Windows.Forms.Cursors.Default;
            this.SkinRB.Location = new System.Drawing.Point(290, 45);
            this.SkinRB.Margin = new System.Windows.Forms.Padding(0);
            this.SkinRB.Name = "SkinRB";
            this.SkinRB.Size = new System.Drawing.Size(76, 28);
            this.SkinRB.TabIndex = 1;
            this.SkinRB.TabStop = true;
            this.SkinRB.Text = "Скин";
            this.SkinRB.UseVisualStyleBackColor = true;
            // 
            // CloakRB
            // 
            this.CloakRB.AutoSize = true;
            this.CloakRB.Location = new System.Drawing.Point(290, 85);
            this.CloakRB.Margin = new System.Windows.Forms.Padding(0);
            this.CloakRB.Name = "CloakRB";
            this.CloakRB.Size = new System.Drawing.Size(78, 28);
            this.CloakRB.TabIndex = 2;
            this.CloakRB.TabStop = true;
            this.CloakRB.Text = "Плащ";
            this.CloakRB.UseVisualStyleBackColor = true;
            // 
            // DwnldTypLabel
            // 
            this.DwnldTypLabel.AutoSize = true;
            this.DwnldTypLabel.Location = new System.Drawing.Point(290, 10);
            this.DwnldTypLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DwnldTypLabel.Name = "DwnldTypLabel";
            this.DwnldTypLabel.Size = new System.Drawing.Size(140, 24);
            this.DwnldTypLabel.TabIndex = 0;
            this.DwnldTypLabel.Text = "Тип загрузки";
            this.DwnldTypLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DwnldBtn
            // 
            this.DwnldBtn.Location = new System.Drawing.Point(15, 85);
            this.DwnldBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DwnldBtn.Name = "DwnldBtn";
            this.DwnldBtn.Size = new System.Drawing.Size(257, 28);
            this.DwnldBtn.TabIndex = 3;
            this.DwnldBtn.Text = "Скачать";
            this.DwnldBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DwnldBtn.UseVisualStyleBackColor = true;
            this.DwnldBtn.Click += new System.EventHandler(this.DwnldBtn_Click);
            // 
            // ShowFileCB
            // 
            this.ShowFileCB.AutoSize = true;
            this.ShowFileCB.Location = new System.Drawing.Point(15, 126);
            this.ShowFileCB.Name = "ShowFileCB";
            this.ShowFileCB.Size = new System.Drawing.Size(345, 28);
            this.ShowFileCB.TabIndex = 4;
            this.ShowFileCB.Text = "Показывать файл в проводнике";
            this.ShowFileCB.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(452, 165);
            this.Controls.Add(this.ShowFileCB);
            this.Controls.Add(this.DwnldBtn);
            this.Controls.Add(this.CloakRB);
            this.Controls.Add(this.SkinRB);
            this.Controls.Add(this.NickTB);
            this.Controls.Add(this.DwnldTypLabel);
            this.Controls.Add(this.NickLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mix-Servers Skin Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NickLabel;
        private System.Windows.Forms.TextBox NickTB;
        private System.Windows.Forms.RadioButton SkinRB;
        private System.Windows.Forms.RadioButton CloakRB;
        private System.Windows.Forms.Label DwnldTypLabel;
        private System.Windows.Forms.Button DwnldBtn;
        private System.Windows.Forms.CheckBox ShowFileCB;
    }
}

