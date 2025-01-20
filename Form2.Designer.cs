
namespace StudentEnrollmentSystem
{
    partial class RegistrationForm
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
            this.Rlabel1 = new System.Windows.Forms.Label();
            this.StdRegGroup = new System.Windows.Forms.GroupBox();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.labelParentName = new System.Windows.Forms.Label();
            this.ContactDetailsGroup = new System.Windows.Forms.GroupBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.BasicDetailGroup = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.StdRegGroup.SuspendLayout();
            this.groupBoxParentDetails.SuspendLayout();
            this.ContactDetailsGroup.SuspendLayout();
            this.BasicDetailGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rlabel1
            // 
            this.Rlabel1.AutoSize = true;
            this.Rlabel1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rlabel1.ForeColor = System.Drawing.Color.Maroon;
            this.Rlabel1.Location = new System.Drawing.Point(165, 3);
            this.Rlabel1.Name = "Rlabel1";
            this.Rlabel1.Size = new System.Drawing.Size(199, 25);
            this.Rlabel1.TabIndex = 0;
            this.Rlabel1.Text = "Skills International";
            this.Rlabel1.Click += new System.EventHandler(this.Rlabel1_Click);
            // 
            // StdRegGroup
            // 
            this.StdRegGroup.Controls.Add(this.linkExit);
            this.StdRegGroup.Controls.Add(this.btnClear);
            this.StdRegGroup.Controls.Add(this.btnDelete);
            this.StdRegGroup.Controls.Add(this.btnUpdate);
            this.StdRegGroup.Controls.Add(this.btnRegister);
            this.StdRegGroup.Controls.Add(this.groupBoxParentDetails);
            this.StdRegGroup.Controls.Add(this.ContactDetailsGroup);
            this.StdRegGroup.Controls.Add(this.listBox);
            this.StdRegGroup.Controls.Add(this.labelRegNo);
            this.StdRegGroup.Controls.Add(this.BasicDetailGroup);
            this.StdRegGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdRegGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StdRegGroup.Location = new System.Drawing.Point(4, 28);
            this.StdRegGroup.Name = "StdRegGroup";
            this.StdRegGroup.Size = new System.Drawing.Size(538, 573);
            this.StdRegGroup.TabIndex = 1;
            this.StdRegGroup.TabStop = false;
            this.StdRegGroup.Text = "Student Registration";
            this.StdRegGroup.Enter += new System.EventHandler(this.StdRegGroup_Enter);
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkExit.ForeColor = System.Drawing.Color.Red;
            this.linkExit.Location = new System.Drawing.Point(485, 544);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(39, 20);
            this.linkExit.TabIndex = 11;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(326, 500);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(428, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(118, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(16, 500);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 30);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBoxParentDetails
            // 
            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
            this.groupBoxParentDetails.Controls.Add(this.txtParentName);
            this.groupBoxParentDetails.Controls.Add(this.labelContactNo);
            this.groupBoxParentDetails.Controls.Add(this.labelNIC);
            this.groupBoxParentDetails.Controls.Add(this.labelParentName);
            this.groupBoxParentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBoxParentDetails.Location = new System.Drawing.Point(14, 373);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Size = new System.Drawing.Size(516, 109);
            this.groupBoxParentDetails.TabIndex = 6;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";
            this.groupBoxParentDetails.Enter += new System.EventHandler(this.groupBoxParentDetails_Enter);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(148, 75);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(195, 22);
            this.txtContactNo.TabIndex = 3;
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(150, 47);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(193, 22);
            this.txtNIC.TabIndex = 2;
            this.txtNIC.TextChanged += new System.EventHandler(this.txtNIC_TextChanged);
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(150, 19);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(360, 22);
            this.txtParentName.TabIndex = 1;
            this.txtParentName.Text = "\r\n";
            this.txtParentName.TextChanged += new System.EventHandler(this.txtParentName_TextChanged);
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactNo.ForeColor = System.Drawing.Color.Black;
            this.labelContactNo.Location = new System.Drawing.Point(35, 77);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(89, 20);
            this.labelContactNo.TabIndex = 0;
            this.labelContactNo.Text = "Contact No";
            this.labelContactNo.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIC.ForeColor = System.Drawing.Color.Black;
            this.labelNIC.Location = new System.Drawing.Point(35, 49);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(36, 20);
            this.labelNIC.TabIndex = 0;
            this.labelNIC.Text = "NIC";
            this.labelNIC.Click += new System.EventHandler(this.labelNIC_Click);
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParentName.ForeColor = System.Drawing.Color.Black;
            this.labelParentName.Location = new System.Drawing.Point(35, 21);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(102, 20);
            this.labelParentName.TabIndex = 0;
            this.labelParentName.Text = "Parent Name";
            this.labelParentName.Click += new System.EventHandler(this.labelParentName_Click);
            // 
            // ContactDetailsGroup
            // 
            this.ContactDetailsGroup.Controls.Add(this.txtHome);
            this.ContactDetailsGroup.Controls.Add(this.txtMobile);
            this.ContactDetailsGroup.Controls.Add(this.txtEmail);
            this.ContactDetailsGroup.Controls.Add(this.txtAddress);
            this.ContactDetailsGroup.Controls.Add(this.labelHome);
            this.ContactDetailsGroup.Controls.Add(this.labelMobile);
            this.ContactDetailsGroup.Controls.Add(this.labelEmail);
            this.ContactDetailsGroup.Controls.Add(this.labelAddress);
            this.ContactDetailsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ContactDetailsGroup.Location = new System.Drawing.Point(14, 197);
            this.ContactDetailsGroup.Name = "ContactDetailsGroup";
            this.ContactDetailsGroup.Size = new System.Drawing.Size(516, 176);
            this.ContactDetailsGroup.TabIndex = 5;
            this.ContactDetailsGroup.TabStop = false;
            this.ContactDetailsGroup.Text = "Contact Details";
            this.ContactDetailsGroup.Enter += new System.EventHandler(this.ContactDetailsGroup_Enter);
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(303, 147);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(207, 22);
            this.txtHome.TabIndex = 4;
            this.txtHome.TextChanged += new System.EventHandler(this.txtHome_TextChanged);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(50, 147);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(194, 22);
            this.txtMobile.TabIndex = 3;
            this.txtMobile.TextChanged += new System.EventHandler(this.Mobiletxt_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 21);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(360, 66);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "\r\n";
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.Black;
            this.labelHome.Location = new System.Drawing.Point(269, 124);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(76, 20);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home No";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelMobile
            // 
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.ForeColor = System.Drawing.Color.Black;
            this.labelMobile.Location = new System.Drawing.Point(35, 124);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(79, 20);
            this.labelMobile.TabIndex = 0;
            this.labelMobile.Text = "Mobile No";
            this.labelMobile.Click += new System.EventHandler(this.Mobile_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(35, 95);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(35, 23);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Items.AddRange(new object[] {
            "New Member",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.listBox.Location = new System.Drawing.Point(135, 21);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(145, 24);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegNo.ForeColor = System.Drawing.Color.Black;
            this.labelRegNo.Location = new System.Drawing.Point(49, 21);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(69, 20);
            this.labelRegNo.TabIndex = 1;
            this.labelRegNo.Text = "Reg No";
            this.labelRegNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // BasicDetailGroup
            // 
            this.BasicDetailGroup.Controls.Add(this.dtpDOB);
            this.BasicDetailGroup.Controls.Add(this.chkFemale);
            this.BasicDetailGroup.Controls.Add(this.chkMale);
            this.BasicDetailGroup.Controls.Add(this.txtLastName);
            this.BasicDetailGroup.Controls.Add(this.txtFirstName);
            this.BasicDetailGroup.Controls.Add(this.labelGender);
            this.BasicDetailGroup.Controls.Add(this.labelDOB);
            this.BasicDetailGroup.Controls.Add(this.labelLastName);
            this.BasicDetailGroup.Controls.Add(this.labelFirstName);
            this.BasicDetailGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BasicDetailGroup.Location = new System.Drawing.Point(14, 56);
            this.BasicDetailGroup.Name = "BasicDetailGroup";
            this.BasicDetailGroup.Size = new System.Drawing.Size(516, 140);
            this.BasicDetailGroup.TabIndex = 0;
            this.BasicDetailGroup.TabStop = false;
            this.BasicDetailGroup.Text = "Basic Details";
            this.BasicDetailGroup.Enter += new System.EventHandler(this.BasicDetailGroup_Enter);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(152, 79);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(256, 22);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFemale.ForeColor = System.Drawing.Color.Black;
            this.chkFemale.Location = new System.Drawing.Point(303, 107);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(81, 24);
            this.chkFemale.TabIndex = 4;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMale.ForeColor = System.Drawing.Color.Black;
            this.chkMale.Location = new System.Drawing.Point(150, 107);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(62, 24);
            this.chkMale.TabIndex = 3;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.chkMale_CheckedChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(150, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(360, 22);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(150, 23);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(360, 22);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(35, 111);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(63, 20);
            this.labelGender.TabIndex = 0;
            this.labelGender.Text = "Gender";
            this.labelGender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.ForeColor = System.Drawing.Color.Black;
            this.labelDOB.Location = new System.Drawing.Point(35, 81);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(99, 20);
            this.labelDOB.TabIndex = 0;
            this.labelDOB.Text = "Date of Birth";
            this.labelDOB.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.Black;
            this.labelLastName.Location = new System.Drawing.Point(35, 53);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 0;
            this.labelLastName.Text = "Last Name";
            this.labelLastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelFirstName.Location = new System.Drawing.Point(35, 25);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            this.labelFirstName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(553, 601);
            this.Controls.Add(this.StdRegGroup);
            this.Controls.Add(this.Rlabel1);
            this.Name = "RegistrationForm";
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.StdRegGroup.ResumeLayout(false);
            this.StdRegGroup.PerformLayout();
            this.groupBoxParentDetails.ResumeLayout(false);
            this.groupBoxParentDetails.PerformLayout();
            this.ContactDetailsGroup.ResumeLayout(false);
            this.ContactDetailsGroup.PerformLayout();
            this.BasicDetailGroup.ResumeLayout(false);
            this.BasicDetailGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rlabel1;
        private System.Windows.Forms.GroupBox StdRegGroup;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.GroupBox BasicDetailGroup;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox ContactDetailsGroup;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.GroupBox groupBoxParentDetails;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}