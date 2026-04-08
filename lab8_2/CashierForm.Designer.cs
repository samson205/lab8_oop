using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace lab8_2
{
    partial class CashierForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tlpBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.tlpTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tlpLabel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tlpAdmin.SuspendLayout();
            this.tlpBtns.SuspendLayout();
            this.tlpTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tlpLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.flpMenu);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tlpAdmin);
            this.splitContainer.Panel2.Controls.Add(this.tlpBtns);
            this.splitContainer.Panel2.Controls.Add(this.tlpTotal);
            this.splitContainer.Panel2.Controls.Add(this.dgvOrder);
            this.splitContainer.Panel2.Controls.Add(this.tlpLabel);
            this.splitContainer.Size = new System.Drawing.Size(865, 514);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // flpMenu
            // 
            this.flpMenu.AutoScroll = true;
            this.flpMenu.BackColor = System.Drawing.Color.White;
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Padding = new System.Windows.Forms.Padding(10);
            this.flpMenu.Size = new System.Drawing.Size(248, 512);
            this.flpMenu.TabIndex = 0;
            // 
            // tlpAdmin
            // 
            this.tlpAdmin.ColumnCount = 3;
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAdmin.Controls.Add(this.btnAdmin, 1, 0);
            this.tlpAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdmin.Location = new System.Drawing.Point(0, 460);
            this.tlpAdmin.Name = "tlpAdmin";
            this.tlpAdmin.RowCount = 1;
            this.tlpAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAdmin.Size = new System.Drawing.Size(608, 52);
            this.tlpAdmin.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmin.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdmin.Location = new System.Drawing.Point(242, 10);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(124, 32);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "🛠️ Админка";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tlpBtns
            // 
            this.tlpBtns.ColumnCount = 2;
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBtns.Controls.Add(this.btnClear, 0, 0);
            this.tlpBtns.Controls.Add(this.btnPay, 1, 0);
            this.tlpBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBtns.Location = new System.Drawing.Point(0, 399);
            this.tlpBtns.Name = "tlpBtns";
            this.tlpBtns.RowCount = 1;
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBtns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpBtns.Size = new System.Drawing.Size(608, 61);
            this.tlpBtns.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btnClear.Location = new System.Drawing.Point(90, 14);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 32);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "🗑 Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(52)))));
            this.btnPay.Location = new System.Drawing.Point(394, 14);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 32);
            this.btnPay.TabIndex = 1;
            this.btnPay.Text = "💳 Оплатить";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // tlpTotal
            // 
            this.tlpTotal.ColumnCount = 3;
            this.tlpTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTotal.Controls.Add(this.lblTotal, 1, 0);
            this.tlpTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTotal.Location = new System.Drawing.Point(0, 333);
            this.tlpTotal.Name = "tlpTotal";
            this.tlpTotal.RowCount = 1;
            this.tlpTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotal.Size = new System.Drawing.Size(608, 66);
            this.tlpTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(247, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(113, 30);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Итого: 0 ₽";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AllowUserToResizeRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOrder.Location = new System.Drawing.Point(0, 44);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(608, 289);
            this.dgvOrder.TabIndex = 2;
            this.dgvOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellEndEdit);
            // 
            // tlpLabel
            // 
            this.tlpLabel.ColumnCount = 3;
            this.tlpLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpLabel.Controls.Add(this.lblTitle, 1, 0);
            this.tlpLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLabel.Location = new System.Drawing.Point(0, 0);
            this.tlpLabel.Name = "tlpLabel";
            this.tlpLabel.RowCount = 1;
            this.tlpLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLabel.Size = new System.Drawing.Size(608, 44);
            this.tlpLabel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(220, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🛒 Текущий заказ";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(865, 514);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CashierForm";
            this.Text = "Часть 2";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tlpAdmin.ResumeLayout(false);
            this.tlpBtns.ResumeLayout(false);
            this.tlpTotal.ResumeLayout(false);
            this.tlpTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tlpLabel.ResumeLayout(false);
            this.tlpLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private FlowLayoutPanel flpMenu;
        private DataGridView dgvOrder;
        private TableLayoutPanel tlpLabel;
        private Label lblTitle;
        private TableLayoutPanel tlpBtns;
        private Button btnClear;
        private Button btnPay;
        private TableLayoutPanel tlpTotal;
        private Label lblTotal;
        private TableLayoutPanel tlpAdmin;
        private Button btnAdmin;
    }
}
