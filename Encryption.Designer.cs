
namespace Nesne2Lab_1
{
    partial class Encryption
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
            this.rbtnCeaser = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rbtnVigenére = new System.Windows.Forms.RadioButton();
            this.rbtnEncryption = new System.Windows.Forms.RadioButton();
            this.txtBox_String = new System.Windows.Forms.TextBox();
            this.lblString = new System.Windows.Forms.Label();
            this.rbtnDecryption = new System.Windows.Forms.RadioButton();
            this.gBox_SelectCrypt = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBox_Cipher = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Result = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBox_Rot = new System.Windows.Forms.TextBox();
            this.txtBox_Key = new System.Windows.Forms.TextBox();
            this.lblRot = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gBox_SelectCrypt.SuspendLayout();
            this.gBox_Cipher.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnCeaser
            // 
            this.rbtnCeaser.AutoSize = true;
            this.rbtnCeaser.Location = new System.Drawing.Point(6, 42);
            this.rbtnCeaser.Name = "rbtnCeaser";
            this.rbtnCeaser.Size = new System.Drawing.Size(98, 19);
            this.rbtnCeaser.TabIndex = 2;
            this.rbtnCeaser.TabStop = true;
            this.rbtnCeaser.Text = "Ceaser Cipher";
            this.rbtnCeaser.UseVisualStyleBackColor = true;
            this.rbtnCeaser.CheckedChanged += new System.EventHandler(this.rbtnCeaser_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(202, 440);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rbtnVigenére
            // 
            this.rbtnVigenére.AutoSize = true;
            this.rbtnVigenére.Location = new System.Drawing.Point(6, 67);
            this.rbtnVigenére.Name = "rbtnVigenére";
            this.rbtnVigenére.Size = new System.Drawing.Size(109, 19);
            this.rbtnVigenére.TabIndex = 4;
            this.rbtnVigenére.TabStop = true;
            this.rbtnVigenére.Text = "Vigenére Cipher";
            this.rbtnVigenére.UseVisualStyleBackColor = true;
            // 
            // rbtnEncryption
            // 
            this.rbtnEncryption.AutoSize = true;
            this.rbtnEncryption.Location = new System.Drawing.Point(12, 41);
            this.rbtnEncryption.Name = "rbtnEncryption";
            this.rbtnEncryption.Size = new System.Drawing.Size(82, 19);
            this.rbtnEncryption.TabIndex = 5;
            this.rbtnEncryption.TabStop = true;
            this.rbtnEncryption.Text = "Encryption";
            this.rbtnEncryption.UseVisualStyleBackColor = true;
            // 
            // txtBox_String
            // 
            this.txtBox_String.Location = new System.Drawing.Point(148, 19);
            this.txtBox_String.Name = "txtBox_String";
            this.txtBox_String.Size = new System.Drawing.Size(206, 23);
            this.txtBox_String.TabIndex = 6;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(29, 22);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(90, 15);
            this.lblString.TabIndex = 7;
            this.lblString.Text = "Enter The String";
            // 
            // rbtnDecryption
            // 
            this.rbtnDecryption.AutoSize = true;
            this.rbtnDecryption.Location = new System.Drawing.Point(12, 66);
            this.rbtnDecryption.Name = "rbtnDecryption";
            this.rbtnDecryption.Size = new System.Drawing.Size(83, 19);
            this.rbtnDecryption.TabIndex = 8;
            this.rbtnDecryption.TabStop = true;
            this.rbtnDecryption.Text = "Decryption";
            this.rbtnDecryption.UseVisualStyleBackColor = true;
            // 
            // gBox_SelectCrypt
            // 
            this.gBox_SelectCrypt.Controls.Add(this.label3);
            this.gBox_SelectCrypt.Controls.Add(this.rbtnEncryption);
            this.gBox_SelectCrypt.Controls.Add(this.rbtnDecryption);
            this.gBox_SelectCrypt.Location = new System.Drawing.Point(36, 310);
            this.gBox_SelectCrypt.Name = "gBox_SelectCrypt";
            this.gBox_SelectCrypt.Size = new System.Drawing.Size(318, 114);
            this.gBox_SelectCrypt.TabIndex = 9;
            this.gBox_SelectCrypt.TabStop = false;
            this.gBox_SelectCrypt.Text = "Select";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "*You Should Select One Of These";
            // 
            // gBox_Cipher
            // 
            this.gBox_Cipher.Controls.Add(this.label2);
            this.gBox_Cipher.Controls.Add(this.rbtnCeaser);
            this.gBox_Cipher.Controls.Add(this.rbtnVigenére);
            this.gBox_Cipher.Location = new System.Drawing.Point(36, 125);
            this.gBox_Cipher.Name = "gBox_Cipher";
            this.gBox_Cipher.Size = new System.Drawing.Size(318, 115);
            this.gBox_Cipher.TabIndex = 10;
            this.gBox_Cipher.TabStop = false;
            this.gBox_Cipher.Text = "Select";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "*You Should Select One Of These";
            // 
            // txtBox_Result
            // 
            this.txtBox_Result.Location = new System.Drawing.Point(148, 250);
            this.txtBox_Result.Name = "txtBox_Result";
            this.txtBox_Result.Size = new System.Drawing.Size(206, 23);
            this.txtBox_Result.TabIndex = 11;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(36, 253);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(77, 15);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Result Ceaser";
            // 
            // txtBox_Rot
            // 
            this.txtBox_Rot.Location = new System.Drawing.Point(148, 51);
            this.txtBox_Rot.Name = "txtBox_Rot";
            this.txtBox_Rot.Size = new System.Drawing.Size(206, 23);
            this.txtBox_Rot.TabIndex = 13;
            // 
            // txtBox_Key
            // 
            this.txtBox_Key.Location = new System.Drawing.Point(148, 95);
            this.txtBox_Key.Name = "txtBox_Key";
            this.txtBox_Key.Size = new System.Drawing.Size(206, 23);
            this.txtBox_Key.TabIndex = 14;
            // 
            // lblRot
            // 
            this.lblRot.AutoSize = true;
            this.lblRot.Location = new System.Drawing.Point(29, 54);
            this.lblRot.Name = "lblRot";
            this.lblRot.Size = new System.Drawing.Size(101, 15);
            this.lblRot.TabIndex = 15;
            this.lblRot.Text = "Ceaser Cipher Rot";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(29, 98);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(113, 15);
            this.lblKey.TabIndex = 16;
            this.lblKey.Text = "Vigenére Cipher Key";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(148, 125);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Result Vigenére";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 23);
            this.textBox1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Reset All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblRot);
            this.Controls.Add(this.txtBox_Key);
            this.Controls.Add(this.txtBox_Rot);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtBox_Result);
            this.Controls.Add(this.gBox_Cipher);
            this.Controls.Add(this.gBox_SelectCrypt);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.txtBox_String);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Encryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Encryption_FormClosed);
            this.gBox_SelectCrypt.ResumeLayout(false);
            this.gBox_SelectCrypt.PerformLayout();
            this.gBox_Cipher.ResumeLayout(false);
            this.gBox_Cipher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnCeaser;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RadioButton rbtnVigenére;
        private System.Windows.Forms.RadioButton rbtnEncryption;
        private System.Windows.Forms.TextBox txtBox_String;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.RadioButton rbtnDecryption;
        private System.Windows.Forms.GroupBox gBox_SelectCrypt;
        private System.Windows.Forms.GroupBox gBox_Cipher;
        private System.Windows.Forms.TextBox txtBox_Result;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBox_Rot;
        private System.Windows.Forms.TextBox txtBox_Key;
        private System.Windows.Forms.Label lblRot;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}