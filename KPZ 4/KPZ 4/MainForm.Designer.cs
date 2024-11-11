// MainForm.Designer.cs
partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnStartBuilding;
    private System.Windows.Forms.Button btnClone;
    private System.Windows.Forms.RadioButton radioPassenger;
    private System.Windows.Forms.RadioButton radioCargo;
    private System.Windows.Forms.TextBox txtOutput;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.btnStartBuilding = new System.Windows.Forms.Button();
        this.btnClone = new System.Windows.Forms.Button();
        this.radioPassenger = new System.Windows.Forms.RadioButton();
        this.radioCargo = new System.Windows.Forms.RadioButton();
        this.txtOutput = new System.Windows.Forms.TextBox();
        this.SuspendLayout();

        // btnStartBuilding
        this.btnStartBuilding.Location = new System.Drawing.Point(30, 30);
        this.btnStartBuilding.Name = "btnStartBuilding";
        this.btnStartBuilding.Size = new System.Drawing.Size(150, 30);
        this.btnStartBuilding.TabIndex = 0;
        this.btnStartBuilding.Text = "Почати будівництво";
        this.btnStartBuilding.Click += new System.EventHandler(this.btnStartBuilding_Click);

        // btnClone
        this.btnClone.Enabled = false;
        this.btnClone.Location = new System.Drawing.Point(30, 70);
        this.btnClone.Name = "btnClone";
        this.btnClone.Size = new System.Drawing.Size(150, 30);
        this.btnClone.TabIndex = 1;
        this.btnClone.Text = "Копіювати літак";
        this.btnClone.Click += new System.EventHandler(this.btnClone_Click);

        // radioPassenger
        this.radioPassenger.Location = new System.Drawing.Point(200, 30);
        this.radioPassenger.Name = "radioPassenger";
        this.radioPassenger.Size = new System.Drawing.Size(150, 20);
        this.radioPassenger.TabIndex = 2;
        this.radioPassenger.Text = "Пасажирський літак";

        // radioCargo
        this.radioCargo.Location = new System.Drawing.Point(200, 60);
        this.radioCargo.Name = "radioCargo";
        this.radioCargo.Size = new System.Drawing.Size(150, 20);
        this.radioCargo.TabIndex = 3;
        this.radioCargo.Text = "Вантажний літак";

        // txtOutput
        this.txtOutput.Location = new System.Drawing.Point(30, 120);
        this.txtOutput.Multiline = true;
        this.txtOutput.Name = "txtOutput";
        this.txtOutput.ReadOnly = true;
        this.txtOutput.Size = new System.Drawing.Size(300, 200);
        this.txtOutput.TabIndex = 4;

        // MainForm
        this.ClientSize = new System.Drawing.Size(400, 350);
        this.Controls.Add(this.btnStartBuilding);
        this.Controls.Add(this.btnClone);
        this.Controls.Add(this.radioPassenger);
        this.Controls.Add(this.radioCargo);
        this.Controls.Add(this.txtOutput);
        this.Name = "MainForm";
        this.Text = "Airplane Builder and Prototype";
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
