namespace SistemaDeComandas
{
    partial class FrmCardapio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            foreverGroupBox1 = new ReaLTaiizor.Controls.ForeverGroupBox();
            BtnVoltar = new ReaLTaiizor.Controls.CyberButton();
            BtnEditar = new ReaLTaiizor.Controls.CyberButton();
            BtnExcluir = new ReaLTaiizor.Controls.CyberButton();
            DgvCardapio = new ReaLTaiizor.Controls.PoisonDataGridView();
            BtnAdicionarItem = new ReaLTaiizor.Controls.CyberButton();
            TxtPesquisa = new ReaLTaiizor.Controls.CyberTextBox();
            foreverGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCardapio).BeginInit();
            SuspendLayout();
            // 
            // foreverGroupBox1
            // 
            foreverGroupBox1.ArrowColorF = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.ArrowColorH = Color.FromArgb(60, 70, 73);
            foreverGroupBox1.BackColor = Color.Transparent;
            foreverGroupBox1.BaseColor = Color.Gray;
            foreverGroupBox1.Controls.Add(BtnVoltar);
            foreverGroupBox1.Controls.Add(BtnEditar);
            foreverGroupBox1.Controls.Add(BtnExcluir);
            foreverGroupBox1.Controls.Add(DgvCardapio);
            foreverGroupBox1.Controls.Add(BtnAdicionarItem);
            foreverGroupBox1.Controls.Add(TxtPesquisa);
            foreverGroupBox1.Font = new Font("Segoe UI", 10F);
            foreverGroupBox1.Location = new Point(12, 12);
            foreverGroupBox1.Name = "foreverGroupBox1";
            foreverGroupBox1.ShowArrow = true;
            foreverGroupBox1.ShowText = true;
            foreverGroupBox1.Size = new Size(776, 426);
            foreverGroupBox1.TabIndex = 0;
            foreverGroupBox1.Text = "foreverGroupBox1";
            foreverGroupBox1.TextColor = Color.Green;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Alpha = 20;
            BtnVoltar.BackColor = Color.Transparent;
            BtnVoltar.Background = true;
            BtnVoltar.Background_WidthPen = 4F;
            BtnVoltar.BackgroundPen = true;
            BtnVoltar.ColorBackground = Color.FromArgb(128, 128, 255);
            BtnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            BtnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BtnVoltar.ColorBackground_Pen = Color.FromArgb(64, 64, 64);
            BtnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            BtnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BtnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BtnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnVoltar.Effect_1 = true;
            BtnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BtnVoltar.Effect_1_Transparency = 25;
            BtnVoltar.Effect_2 = true;
            BtnVoltar.Effect_2_ColorBackground = Color.White;
            BtnVoltar.Effect_2_Transparency = 20;
            BtnVoltar.Font = new Font("Arial", 11F);
            BtnVoltar.ForeColor = Color.Black;
            BtnVoltar.Lighting = false;
            BtnVoltar.LinearGradient_Background = false;
            BtnVoltar.LinearGradientPen = false;
            BtnVoltar.Location = new Point(60, 359);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.PenWidth = 15;
            BtnVoltar.Rounding = true;
            BtnVoltar.RoundingInt = 70;
            BtnVoltar.Size = new Size(130, 50);
            BtnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnVoltar.TabIndex = 5;
            BtnVoltar.Tag = "Cyber";
            BtnVoltar.TextButton = "<--  Voltar";
            BtnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnVoltar.Timer_Effect_1 = 5;
            BtnVoltar.Timer_RGB = 300;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Alpha = 20;
            BtnEditar.BackColor = Color.Transparent;
            BtnEditar.Background = true;
            BtnEditar.Background_WidthPen = 4F;
            BtnEditar.BackgroundPen = true;
            BtnEditar.ColorBackground = Color.Blue;
            BtnEditar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            BtnEditar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BtnEditar.ColorBackground_Pen = Color.FromArgb(64, 64, 64);
            BtnEditar.ColorLighting = Color.FromArgb(128, 255, 255);
            BtnEditar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BtnEditar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BtnEditar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnEditar.Effect_1 = true;
            BtnEditar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BtnEditar.Effect_1_Transparency = 25;
            BtnEditar.Effect_2 = true;
            BtnEditar.Effect_2_ColorBackground = Color.White;
            BtnEditar.Effect_2_Transparency = 20;
            BtnEditar.Font = new Font("Arial", 11F);
            BtnEditar.ForeColor = Color.FromArgb(245, 245, 245);
            BtnEditar.Lighting = false;
            BtnEditar.LinearGradient_Background = false;
            BtnEditar.LinearGradientPen = false;
            BtnEditar.Location = new Point(593, 359);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.PenWidth = 15;
            BtnEditar.Rounding = true;
            BtnEditar.RoundingInt = 70;
            BtnEditar.Size = new Size(130, 50);
            BtnEditar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnEditar.TabIndex = 4;
            BtnEditar.Tag = "Cyber";
            BtnEditar.TextButton = "# Editar";
            BtnEditar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnEditar.Timer_Effect_1 = 5;
            BtnEditar.Timer_RGB = 300;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Alpha = 20;
            BtnExcluir.BackColor = Color.Transparent;
            BtnExcluir.Background = true;
            BtnExcluir.Background_WidthPen = 4F;
            BtnExcluir.BackgroundPen = true;
            BtnExcluir.ColorBackground = Color.Red;
            BtnExcluir.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            BtnExcluir.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BtnExcluir.ColorBackground_Pen = Color.FromArgb(64, 64, 64);
            BtnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            BtnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BtnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BtnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnExcluir.Effect_1 = true;
            BtnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BtnExcluir.Effect_1_Transparency = 25;
            BtnExcluir.Effect_2 = true;
            BtnExcluir.Effect_2_ColorBackground = Color.White;
            BtnExcluir.Effect_2_Transparency = 20;
            BtnExcluir.Font = new Font("Arial", 11F);
            BtnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            BtnExcluir.Lighting = false;
            BtnExcluir.LinearGradient_Background = false;
            BtnExcluir.LinearGradientPen = false;
            BtnExcluir.Location = new Point(457, 359);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.PenWidth = 15;
            BtnExcluir.Rounding = true;
            BtnExcluir.RoundingInt = 70;
            BtnExcluir.Size = new Size(130, 50);
            BtnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnExcluir.TabIndex = 3;
            BtnExcluir.Tag = "Cyber";
            BtnExcluir.TextButton = "X Excluir";
            BtnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnExcluir.Timer_Effect_1 = 5;
            BtnExcluir.Timer_RGB = 300;
            // 
            // DgvCardapio
            // 
            DgvCardapio.AllowUserToResizeRows = false;
            DgvCardapio.BackgroundColor = Color.Silver;
            DgvCardapio.BorderStyle = BorderStyle.None;
            DgvCardapio.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DgvCardapio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvCardapio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvCardapio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvCardapio.DefaultCellStyle = dataGridViewCellStyle2;
            DgvCardapio.EnableHeadersVisualStyles = false;
            DgvCardapio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            DgvCardapio.GridColor = Color.FromArgb(255, 255, 255);
            DgvCardapio.Location = new Point(60, 168);
            DgvCardapio.Name = "DgvCardapio";
            DgvCardapio.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvCardapio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvCardapio.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DgvCardapio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCardapio.Size = new Size(663, 185);
            DgvCardapio.TabIndex = 2;
            // 
            // BtnAdicionarItem
            // 
            BtnAdicionarItem.Alpha = 20;
            BtnAdicionarItem.BackColor = Color.Transparent;
            BtnAdicionarItem.Background = true;
            BtnAdicionarItem.Background_WidthPen = 4F;
            BtnAdicionarItem.BackgroundPen = true;
            BtnAdicionarItem.ColorBackground = Color.Lime;
            BtnAdicionarItem.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            BtnAdicionarItem.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            BtnAdicionarItem.ColorBackground_Pen = Color.FromArgb(64, 64, 64);
            BtnAdicionarItem.ColorLighting = Color.FromArgb(29, 200, 238);
            BtnAdicionarItem.ColorPen_1 = Color.FromArgb(37, 52, 68);
            BtnAdicionarItem.ColorPen_2 = Color.FromArgb(41, 63, 86);
            BtnAdicionarItem.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            BtnAdicionarItem.Effect_1 = true;
            BtnAdicionarItem.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            BtnAdicionarItem.Effect_1_Transparency = 25;
            BtnAdicionarItem.Effect_2 = true;
            BtnAdicionarItem.Effect_2_ColorBackground = Color.White;
            BtnAdicionarItem.Effect_2_Transparency = 20;
            BtnAdicionarItem.Font = new Font("Arial", 11F);
            BtnAdicionarItem.ForeColor = Color.Black;
            BtnAdicionarItem.Lighting = false;
            BtnAdicionarItem.LinearGradient_Background = false;
            BtnAdicionarItem.LinearGradientPen = false;
            BtnAdicionarItem.Location = new Point(60, 112);
            BtnAdicionarItem.Name = "BtnAdicionarItem";
            BtnAdicionarItem.PenWidth = 15;
            BtnAdicionarItem.Rounding = true;
            BtnAdicionarItem.RoundingInt = 70;
            BtnAdicionarItem.Size = new Size(130, 50);
            BtnAdicionarItem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            BtnAdicionarItem.TabIndex = 1;
            BtnAdicionarItem.Tag = "Cyber";
            BtnAdicionarItem.TextButton = "+ Item Cardapio";
            BtnAdicionarItem.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnAdicionarItem.Timer_Effect_1 = 5;
            BtnAdicionarItem.Timer_RGB = 300;
            // 
            // TxtPesquisa
            // 
            TxtPesquisa.Alpha = 20;
            TxtPesquisa.BackColor = Color.Transparent;
            TxtPesquisa.Background_WidthPen = 3F;
            TxtPesquisa.BackgroundPen = true;
            TxtPesquisa.ColorBackground = Color.FromArgb(37, 52, 68);
            TxtPesquisa.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            TxtPesquisa.ColorLighting = Color.FromArgb(29, 200, 238);
            TxtPesquisa.ColorPen_1 = Color.FromArgb(29, 200, 238);
            TxtPesquisa.ColorPen_2 = Color.FromArgb(37, 52, 68);
            TxtPesquisa.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            TxtPesquisa.Font = new Font("Arial", 10F);
            TxtPesquisa.ForeColor = Color.FromArgb(245, 245, 245);
            TxtPesquisa.Lighting = false;
            TxtPesquisa.LinearGradientPen = false;
            TxtPesquisa.Location = new Point(60, 55);
            TxtPesquisa.Name = "TxtPesquisa";
            TxtPesquisa.PenWidth = 15;
            TxtPesquisa.RGB = false;
            TxtPesquisa.Rounding = true;
            TxtPesquisa.RoundingInt = 60;
            TxtPesquisa.Size = new Size(663, 40);
            TxtPesquisa.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            TxtPesquisa.TabIndex = 0;
            TxtPesquisa.Tag = "Cyber";
            TxtPesquisa.TextButton = "";
            TxtPesquisa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            TxtPesquisa.Timer_RGB = 300;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foreverGroupBox1);
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            WindowState = FormWindowState.Maximized;
            foreverGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvCardapio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverGroupBox foreverGroupBox1;
        private ReaLTaiizor.Controls.CyberButton BtnEditar;
        private ReaLTaiizor.Controls.CyberButton BtnExcluir;
        private ReaLTaiizor.Controls.PoisonDataGridView DgvCardapio;
        private ReaLTaiizor.Controls.CyberButton BtnAdicionarItem;
        private ReaLTaiizor.Controls.CyberTextBox TxtPesquisa;
        private ReaLTaiizor.Controls.CyberButton BtnVoltar;
    }
}