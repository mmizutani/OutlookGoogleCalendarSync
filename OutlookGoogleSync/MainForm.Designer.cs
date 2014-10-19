﻿/*
 * Created by SharpDevelop.
 * User: zsianti
 * Date: 14.08.2012
 * Time: 07:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OutlookGoogleSync
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lNextSyncVal = new System.Windows.Forms.Label();
            this.lLastSyncVal = new System.Windows.Forms.Label();
            this.lNextSync = new System.Windows.Forms.Label();
            this.lLastSync = new System.Windows.Forms.Label();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.bSyncNow = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtEWSServerURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEWSPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEWSUser = new System.Windows.Forms.TextBox();
            this.chkUseEWS = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbConfirmOnDelete = new System.Windows.Forms.CheckBox();
            this.cbMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.cbStartInTray = new System.Windows.Forms.CheckBox();
            this.cbCreateFiles = new System.Windows.Forms.CheckBox();
            this.cbDisableDeletion = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ddMailboxName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAlternateMailbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAddReminders = new System.Windows.Forms.CheckBox();
            this.cbAddAttendees = new System.Windows.Forms.CheckBox();
            this.cbAddDescription = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbShowBubbleTooltips = new System.Windows.Forms.CheckBox();
            this.cbSyncEveryHour = new System.Windows.Forms.CheckBox();
            this.tbMinuteOffsets = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bGetMyCalendars = new System.Windows.Forms.Button();
            this.cbCalendars = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDaysInTheFuture = new System.Windows.Forms.TextBox();
            this.tbDaysInThePast = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lNextSyncVal);
            this.tabPage1.Controls.Add(this.lLastSyncVal);
            this.tabPage1.Controls.Add(this.lNextSync);
            this.tabPage1.Controls.Add(this.lLastSync);
            this.tabPage1.Controls.Add(this.LogBox);
            this.tabPage1.Controls.Add(this.bSyncNow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sync";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lNextSyncVal
            // 
            this.lNextSyncVal.Location = new System.Drawing.Point(271, 28);
            this.lNextSyncVal.Name = "lNextSyncVal";
            this.lNextSyncVal.Size = new System.Drawing.Size(216, 26);
            this.lNextSyncVal.TabIndex = 4;
            this.lNextSyncVal.Text = "Unknown";
            // 
            // lLastSyncVal
            // 
            this.lLastSyncVal.Location = new System.Drawing.Point(22, 28);
            this.lLastSyncVal.Name = "lLastSyncVal";
            this.lLastSyncVal.Size = new System.Drawing.Size(224, 26);
            this.lLastSyncVal.TabIndex = 3;
            this.lLastSyncVal.Text = "N/A";
            // 
            // lNextSync
            // 
            this.lNextSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNextSync.Location = new System.Drawing.Point(252, 14);
            this.lNextSync.Name = "lNextSync";
            this.lNextSync.Size = new System.Drawing.Size(232, 14);
            this.lNextSync.TabIndex = 2;
            this.lNextSync.Text = "Next scheduled:-";
            // 
            // lLastSync
            // 
            this.lLastSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastSync.Location = new System.Drawing.Point(5, 14);
            this.lLastSync.Name = "lLastSync";
            this.lLastSync.Size = new System.Drawing.Size(251, 14);
            this.lLastSync.TabIndex = 2;
            this.lLastSync.Text = "Last successful:-";
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.Location = new System.Drawing.Point(3, 57);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(481, 379);
            this.LogBox.TabIndex = 1;
            // 
            // bSyncNow
            // 
            this.bSyncNow.Location = new System.Drawing.Point(4, 442);
            this.bSyncNow.Name = "bSyncNow";
            this.bSyncNow.Size = new System.Drawing.Size(98, 31);
            this.bSyncNow.TabIndex = 0;
            this.bSyncNow.Text = "Sync now";
            this.bSyncNow.UseVisualStyleBackColor = true;
            this.bSyncNow.Click += new System.EventHandler(this.SyncNow_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.bSave);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.txtEWSServerURL);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtEWSPass);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtEWSUser);
            this.groupBox7.Controls.Add(this.chkUseEWS);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(230, 178);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 109);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "EWS Settings";
            // 
            // txtEWSServerURL
            // 
            this.txtEWSServerURL.Enabled = false;
            this.txtEWSServerURL.Location = new System.Drawing.Point(70, 84);
            this.txtEWSServerURL.Name = "txtEWSServerURL";
            this.txtEWSServerURL.Size = new System.Drawing.Size(166, 20);
            this.txtEWSServerURL.TabIndex = 13;
            this.txtEWSServerURL.TextChanged += new System.EventHandler(this.txtEWSServerURL_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Server:";
            // 
            // txtEWSPass
            // 
            this.txtEWSPass.Enabled = false;
            this.txtEWSPass.Location = new System.Drawing.Point(70, 61);
            this.txtEWSPass.Name = "txtEWSPass";
            this.txtEWSPass.Size = new System.Drawing.Size(166, 20);
            this.txtEWSPass.TabIndex = 11;
            this.txtEWSPass.TextChanged += new System.EventHandler(this.txtEWSPass_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password:";
            // 
            // txtEWSUser
            // 
            this.txtEWSUser.Enabled = false;
            this.txtEWSUser.Location = new System.Drawing.Point(70, 38);
            this.txtEWSUser.Name = "txtEWSUser";
            this.txtEWSUser.Size = new System.Drawing.Size(166, 20);
            this.txtEWSUser.TabIndex = 9;
            this.txtEWSUser.TextChanged += new System.EventHandler(this.txtEWSUser_TextChanged);
            // 
            // chkUseEWS
            // 
            this.chkUseEWS.Location = new System.Drawing.Point(6, 16);
            this.chkUseEWS.Name = "chkUseEWS";
            this.chkUseEWS.Size = new System.Drawing.Size(230, 24);
            this.chkUseEWS.TabIndex = 8;
            this.chkUseEWS.Text = "Use Exchange";
            this.chkUseEWS.UseVisualStyleBackColor = true;
            this.chkUseEWS.CheckedChanged += new System.EventHandler(this.chkUseEWS_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbConfirmOnDelete);
            this.groupBox4.Controls.Add(this.cbMinimizeToTray);
            this.groupBox4.Controls.Add(this.cbStartInTray);
            this.groupBox4.Controls.Add(this.cbCreateFiles);
            this.groupBox4.Controls.Add(this.cbDisableDeletion);
            this.groupBox4.Location = new System.Drawing.Point(6, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 109);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // cbConfirmOnDelete
            // 
            this.cbConfirmOnDelete.Location = new System.Drawing.Point(112, 76);
            this.cbConfirmOnDelete.Name = "cbConfirmOnDelete";
            this.cbConfirmOnDelete.Size = new System.Drawing.Size(121, 24);
            this.cbConfirmOnDelete.TabIndex = 9;
            this.cbConfirmOnDelete.Text = "Confirm on Delete";
            this.cbConfirmOnDelete.UseVisualStyleBackColor = true;
            this.cbConfirmOnDelete.CheckedChanged += new System.EventHandler(this.cbConfirmOnDelete_CheckedChanged);
            // 
            // cbMinimizeToTray
            // 
            this.cbMinimizeToTray.Location = new System.Drawing.Point(12, 38);
            this.cbMinimizeToTray.Name = "cbMinimizeToTray";
            this.cbMinimizeToTray.Size = new System.Drawing.Size(104, 24);
            this.cbMinimizeToTray.TabIndex = 0;
            this.cbMinimizeToTray.Text = "Minimize to Tray";
            this.cbMinimizeToTray.UseVisualStyleBackColor = true;
            this.cbMinimizeToTray.CheckedChanged += new System.EventHandler(this.CbMinimizeToTrayCheckedChanged);
            // 
            // cbStartInTray
            // 
            this.cbStartInTray.Location = new System.Drawing.Point(12, 19);
            this.cbStartInTray.Name = "cbStartInTray";
            this.cbStartInTray.Size = new System.Drawing.Size(104, 24);
            this.cbStartInTray.TabIndex = 1;
            this.cbStartInTray.Text = "Start in Tray";
            this.cbStartInTray.UseVisualStyleBackColor = true;
            this.cbStartInTray.CheckedChanged += new System.EventHandler(this.CbStartInTrayCheckedChanged);
            // 
            // cbCreateFiles
            // 
            this.cbCreateFiles.Location = new System.Drawing.Point(12, 57);
            this.cbCreateFiles.Name = "cbCreateFiles";
            this.cbCreateFiles.Size = new System.Drawing.Size(235, 24);
            this.cbCreateFiles.TabIndex = 7;
            this.cbCreateFiles.Text = "Create text files with found/identified entries";
            this.cbCreateFiles.UseVisualStyleBackColor = true;
            this.cbCreateFiles.CheckedChanged += new System.EventHandler(this.cbCreateFiles_CheckedChanged);
            // 
            // cbDisableDeletion
            // 
            this.cbDisableDeletion.Location = new System.Drawing.Point(12, 76);
            this.cbDisableDeletion.Name = "cbDisableDeletion";
            this.cbDisableDeletion.Size = new System.Drawing.Size(106, 24);
            this.cbDisableDeletion.TabIndex = 8;
            this.cbDisableDeletion.Text = "Disable Delete";
            this.cbDisableDeletion.UseVisualStyleBackColor = true;
            this.cbDisableDeletion.CheckedChanged += new System.EventHandler(this.cbDisableDeletion_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ddMailboxName);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.cbAlternateMailbox);
            this.groupBox6.Location = new System.Drawing.Point(6, 409);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(376, 61);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Outlook Calendar";
            // 
            // ddMailboxName
            // 
            this.ddMailboxName.FormattingEnabled = true;
            this.ddMailboxName.Location = new System.Drawing.Point(168, 36);
            this.ddMailboxName.Name = "ddMailboxName";
            this.ddMailboxName.Size = new System.Drawing.Size(202, 21);
            this.ddMailboxName.TabIndex = 16;
            this.ddMailboxName.SelectedIndexChanged += new System.EventHandler(this.ddMailboxName_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter Name of Mailbox to Sync";
            // 
            // cbAlternateMailbox
            // 
            this.cbAlternateMailbox.AutoSize = true;
            this.cbAlternateMailbox.Location = new System.Drawing.Point(12, 19);
            this.cbAlternateMailbox.Name = "cbAlternateMailbox";
            this.cbAlternateMailbox.Size = new System.Drawing.Size(135, 17);
            this.cbAlternateMailbox.TabIndex = 13;
            this.cbAlternateMailbox.Text = "Use Alternate Mailbox?";
            this.cbAlternateMailbox.UseVisualStyleBackColor = true;
            this.cbAlternateMailbox.CheckedChanged += new System.EventHandler(this.cbAlternateMailbox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAddReminders);
            this.groupBox5.Controls.Add(this.cbAddAttendees);
            this.groupBox5.Controls.Add(this.cbAddDescription);
            this.groupBox5.Location = new System.Drawing.Point(6, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 109);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "When creating Google Calendar Entries...   ";
            // 
            // cbAddReminders
            // 
            this.cbAddReminders.Location = new System.Drawing.Point(12, 71);
            this.cbAddReminders.Name = "cbAddReminders";
            this.cbAddReminders.Size = new System.Drawing.Size(139, 24);
            this.cbAddReminders.TabIndex = 8;
            this.cbAddReminders.Text = "Add Reminders";
            this.cbAddReminders.UseVisualStyleBackColor = true;
            this.cbAddReminders.CheckedChanged += new System.EventHandler(this.CbAddRemindersCheckedChanged);
            // 
            // cbAddAttendees
            // 
            this.cbAddAttendees.Location = new System.Drawing.Point(12, 45);
            this.cbAddAttendees.Name = "cbAddAttendees";
            this.cbAddAttendees.Size = new System.Drawing.Size(235, 24);
            this.cbAddAttendees.TabIndex = 6;
            this.cbAddAttendees.Text = "Add Attendees";
            this.cbAddAttendees.UseVisualStyleBackColor = true;
            this.cbAddAttendees.CheckedChanged += new System.EventHandler(this.cbAddAttendees_CheckedChanged);
            // 
            // cbAddDescription
            // 
            this.cbAddDescription.Location = new System.Drawing.Point(12, 19);
            this.cbAddDescription.Name = "cbAddDescription";
            this.cbAddDescription.Size = new System.Drawing.Size(209, 24);
            this.cbAddDescription.TabIndex = 7;
            this.cbAddDescription.Text = "Add Description";
            this.cbAddDescription.UseVisualStyleBackColor = true;
            this.cbAddDescription.CheckedChanged += new System.EventHandler(this.CbAddDescriptionCheckedChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(400, 433);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 31);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbShowBubbleTooltips);
            this.groupBox3.Controls.Add(this.cbSyncEveryHour);
            this.groupBox3.Controls.Add(this.tbMinuteOffsets);
            this.groupBox3.Location = new System.Drawing.Point(177, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 85);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sync Regularly";
            // 
            // cbShowBubbleTooltips
            // 
            this.cbShowBubbleTooltips.Location = new System.Drawing.Point(6, 49);
            this.cbShowBubbleTooltips.Name = "cbShowBubbleTooltips";
            this.cbShowBubbleTooltips.Size = new System.Drawing.Size(259, 24);
            this.cbShowBubbleTooltips.TabIndex = 7;
            this.cbShowBubbleTooltips.Text = "Show Bubble Tooltip in Taskbar when Syncing";
            this.cbShowBubbleTooltips.UseVisualStyleBackColor = true;
            this.cbShowBubbleTooltips.CheckedChanged += new System.EventHandler(this.CbShowBubbleTooltipsCheckedChanged);
            // 
            // cbSyncEveryHour
            // 
            this.cbSyncEveryHour.Location = new System.Drawing.Point(6, 19);
            this.cbSyncEveryHour.Name = "cbSyncEveryHour";
            this.cbSyncEveryHour.Size = new System.Drawing.Size(180, 24);
            this.cbSyncEveryHour.TabIndex = 6;
            this.cbSyncEveryHour.Text = "Delay between sync (in minutes)";
            this.cbSyncEveryHour.UseVisualStyleBackColor = true;
            this.cbSyncEveryHour.CheckedChanged += new System.EventHandler(this.CbSyncEveryHourCheckedChanged);
            // 
            // tbMinuteOffsets
            // 
            this.tbMinuteOffsets.Location = new System.Drawing.Point(192, 21);
            this.tbMinuteOffsets.Name = "tbMinuteOffsets";
            this.tbMinuteOffsets.Size = new System.Drawing.Size(106, 20);
            this.tbMinuteOffsets.TabIndex = 5;
            this.tbMinuteOffsets.TextChanged += new System.EventHandler(this.TbMinuteOffsetsTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bGetMyCalendars);
            this.groupBox2.Controls.Add(this.cbCalendars);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Google Calendar";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Use Google Calendar:";
            // 
            // bGetMyCalendars
            // 
            this.bGetMyCalendars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGetMyCalendars.Location = new System.Drawing.Point(363, 19);
            this.bGetMyCalendars.Name = "bGetMyCalendars";
            this.bGetMyCalendars.Size = new System.Drawing.Size(106, 40);
            this.bGetMyCalendars.TabIndex = 2;
            this.bGetMyCalendars.Text = "Get My\r\nGoogle Calendars";
            this.bGetMyCalendars.UseVisualStyleBackColor = true;
            this.bGetMyCalendars.Click += new System.EventHandler(this.GetMyGoogleCalendars_Click);
            // 
            // cbCalendars
            // 
            this.cbCalendars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalendars.FormattingEnabled = true;
            this.cbCalendars.Location = new System.Drawing.Point(124, 30);
            this.cbCalendars.Name = "cbCalendars";
            this.cbCalendars.Size = new System.Drawing.Size(225, 21);
            this.cbCalendars.TabIndex = 1;
            this.cbCalendars.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDaysInTheFuture);
            this.groupBox1.Controls.Add(this.tbDaysInThePast);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync Date Range";
            // 
            // tbDaysInTheFuture
            // 
            this.tbDaysInTheFuture.Location = new System.Drawing.Point(112, 51);
            this.tbDaysInTheFuture.Name = "tbDaysInTheFuture";
            this.tbDaysInTheFuture.Size = new System.Drawing.Size(39, 20);
            this.tbDaysInTheFuture.TabIndex = 4;
            this.tbDaysInTheFuture.TextChanged += new System.EventHandler(this.TbDaysInTheFutureTextChanged);
            // 
            // tbDaysInThePast
            // 
            this.tbDaysInThePast.Location = new System.Drawing.Point(112, 21);
            this.tbDaysInThePast.Name = "tbDaysInThePast";
            this.tbDaysInThePast.Size = new System.Drawing.Size(39, 20);
            this.tbDaysInThePast.TabIndex = 3;
            this.tbDaysInThePast.TextChanged += new System.EventHandler(this.TbDaysInThePastTextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Days in the Future";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days in the Past";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(487, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(6, 238);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(475, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://ougocalsync.codeplex.com/";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(481, 193);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "OutlookGoogleSync";
            this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon1Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 529);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OutlookGoogleSync";
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.CheckBox cbAddReminders;
		private System.Windows.Forms.CheckBox cbAddDescription;
		private System.Windows.Forms.CheckBox cbShowBubbleTooltips;
		private System.Windows.Forms.CheckBox cbSyncEveryHour;
		private System.Windows.Forms.CheckBox cbMinimizeToTray;
		private System.Windows.Forms.CheckBox cbStartInTray;
    private System.Windows.Forms.CheckBox cbDisableDeletion;
    private System.Windows.Forms.CheckBox cbConfirmOnDelete;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox tbMinuteOffsets;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbAddAttendees;
		private System.Windows.Forms.CheckBox cbCreateFiles;
		private System.Windows.Forms.TextBox LogBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ComboBox cbCalendars;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbDaysInThePast;
		private System.Windows.Forms.TextBox tbDaysInTheFuture;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bSave;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button bSyncNow;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.CheckBox cbAlternateMailbox;
    private System.Windows.Forms.Button bGetMyCalendars;
    private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtEWSPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEWSUser;
        private System.Windows.Forms.CheckBox chkUseEWS;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label lLastSync;
    private System.Windows.Forms.Label lNextSync;
    private System.Windows.Forms.Label lNextSyncVal;
    private System.Windows.Forms.Label lLastSyncVal;
    private System.Windows.Forms.ComboBox ddMailboxName;
        private System.Windows.Forms.TextBox txtEWSServerURL;
        private System.Windows.Forms.Label label8;
		
	



		

		

	}
}
