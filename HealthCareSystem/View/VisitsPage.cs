﻿using HealthCareSystem.DAL;
using HealthCareSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareSystem.View
{
    public partial class VisitsPage : Form
    {
        private Nurse nurse;
        public VisitsPage(Nurse nurse)
        {
            InitializeComponent();

            this.nurse = nurse;
            this.setLoggedNurseInfo();
            this.LoadVisits();
        }

        private void setLoggedNurseInfo()
        {
            nurseNameLabel.Text = $"Nurse Name: {this.nurse.Firstname} {this.nurse.Lastname}";
            nurseIdLabel.Text = $"Nurse ID: {this.nurse.NurseId}";
        }

        private void orderTestButton_Click(object sender, EventArgs e)
        {
            OrderTestPage orderTestPage = new OrderTestPage(this.nurse); 
            orderTestPage.Show();

            this.Close();
        }

        private void LoadVisits()
        {
            VisitDAL visitDAL = new VisitDAL();
            var visits = visitDAL.GetAllVisitsWithDetails();

            visitsDataGrid.Columns.Clear();
            visitsDataGrid.Columns.Add("PatientID", "Patient ID");
            visitsDataGrid.Columns.Add("PatientName", "Patient Name");
            visitsDataGrid.Columns.Add("DoctorID", "Doctor ID");
            visitsDataGrid.Columns.Add("DoctorName", "Doctor Name");
            visitsDataGrid.Columns.Add("AppointmentDateTime", "Appointment Date/Time");
            visitsDataGrid.Columns.Add("SymptomsDescription", "Symptoms Description");

            visitsDataGrid.Rows.Clear();

            foreach (var visit in visits)
            {
                visitsDataGrid.Rows.Add(
                    visit.PatientID,
                    visit.PatientName,
                    visit.DoctorID,
                    visit.DoctorName,
                    visit.AppointmentDateTime,
                    visit.SymptomsDescription
                );
            }
        }

        private void enterTestResultsButton_Click(object sender, EventArgs e)
        {
            TestResultsPage testResultsPage = new TestResultsPage(this.nurse); 
            testResultsPage.Show();

            this.Close();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(this.nurse);
            mainPage.Show();

            this.Close();
        }
    }
}
