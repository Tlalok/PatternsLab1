using Patterns_Lab_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patterns_Lab_1_UI
{
    public partial class MainForm : Form
    {
        private TimetableService timetableService = new TimetableService();

        private const int busFieldCount = 9;
        private readonly List<string> busFieldsLabels = new List<string>
        {
            "Number", "DepartureDate", "DeparturePoint", "Destination", "DepartureStation", "DeparturePlatform", "ArrivalStation", "TicketCost", "BusBrand", "TravelTime"
        };

        private const int trainFieldCount = 9;
        private readonly List<string> trainFieldsLabels = new List<string>
        {
            "Number", "DepartureDate", "DeparturePoint", "Destination", "DepartureStation", "DeparturePlatform", "ArrivalStation", "TicketType", "TicketCost", "TravelTime"
        };

        private List<int> favouriteBuses = new List<int>();
        private List<int> favouriteTrains = new List<int>();

        public MainForm()
        {
            InitializeComponent();
            tranportComboBox.SelectedIndex = 0;
            timetableService.onChange += timetable => RefreshTable(timetable);
            tranportComboBox.SelectedIndexChanged += (sender, e) =>
                {
                    ConfigurateTable();
                    RefreshTable(timetableService.Timetable);
                };
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            tranportComboBox.SelectedIndex = 0;
            ConfigurateTable();
            favouriteBuses.Clear();
            favouriteTrains.Clear();
            timetableService.SetRepository(new TimetableFileRepository(openFileDialog.FileName));

        }

        private void ConfigurateTable()
        {
            switch (tranportComboBox.SelectedIndex)
            {
                case 0:
                    ConfigurateBusTable();
                    break;
                case 1:
                    ConfigurateTrainTable();
                    break;

            }
        }

        private void ConfigurateBusTable()
        {
            var columns = new DataGridViewColumn[busFieldCount + 1];
            for (int i = 0; i < busFieldCount; i++)
            {
                columns[i] = new DataGridViewTextBoxColumn();
                columns[i].DataPropertyName = busFieldsLabels[i];
                columns[i].HeaderText = busFieldsLabels[i];
            }
            columns[busFieldCount] = new DataGridViewTextBoxColumn();
            columns[busFieldCount].HeaderText = "id";
            columns[busFieldCount].Visible = false;
            table.Columns.Clear();
            table.Columns.AddRange(columns);
        }

        private void ConfigurateTrainTable()
        {
            var columns = new DataGridViewColumn[trainFieldCount + 1];
            for (int i = 0; i < busFieldCount; i++)
            {
                columns[i] = new DataGridViewTextBoxColumn();
                columns[i].DataPropertyName = trainFieldsLabels[i];
                columns[i].HeaderText = trainFieldsLabels[i];
            }
            columns[trainFieldCount] = new DataGridViewTextBoxColumn();
            columns[trainFieldCount].HeaderText = "id";
            columns[trainFieldCount].Visible = false;
            table.Columns.Clear();
            table.Columns.AddRange(columns);
        }

        private void RefreshTable(Timetable timetable)
        {
            switch (tranportComboBox.SelectedIndex)
            {
                case 0:
                    RefreshBusTable(timetable);
                    break;
                case 1:
                    RefreshTrainTable(timetable);
                    break;

            }
        }

        private void RefreshBusTable(Timetable timetable)
        {
            var rows = new DataGridViewRow[timetable.Buses.Count];
            for (var i = 0; i < timetable.Buses.Count; i++)
            {
                rows[i] = GenerateBusRow(timetable.Buses[i]);
            }
            table.Rows.Clear();
            table.Rows.AddRange(rows);
        }

        private void RefreshTrainTable(Timetable timetable)
        {
            var rows = new DataGridViewRow[timetable.Trains.Count];
            for (var i = 0; i < timetable.Trains.Count; i++)
            {
                rows[i] = GenerateTrainRow(timetable.Trains[i]);
            }
            table.Rows.Clear();
            table.Rows.AddRange(rows);
        }

        private DataGridViewRow GenerateBusRow(BusTimetable timetable)
        {
            var row = new DataGridViewRow();

            AddTextCell(row, timetable.Number);
            AddTextCell(row, timetable.DepartureDate);
            AddTextCell(row, timetable.DeparturePoint);
            AddTextCell(row, timetable.Destination);
            AddTextCell(row, timetable.DepartureStation);
            AddTextCell(row, timetable.DeparturePlatform);
            AddTextCell(row, timetable.ArrivalStation);
            AddTextCell(row, timetable.TicketCost);
            AddTextCell(row, timetable.BusBrand);
            AddTextCell(row, timetable.TravelTime);

            AddTextCell(row, timetableService.GetBusId(timetable));

            return row;
        }

        private DataGridViewRow GenerateTrainRow(TrainTimetable timetable)
        {
            var row = new DataGridViewRow();

            AddTextCell(row, timetable.Number);
            AddTextCell(row, timetable.DepartureDate);
            AddTextCell(row, timetable.DeparturePoint);
            AddTextCell(row, timetable.Destination);
            AddTextCell(row, timetable.DepartureStation);
            AddTextCell(row, timetable.DeparturePlatform);
            AddTextCell(row, timetable.ArrivalStation);
            AddTextCell(row, timetable.TicketType);
            AddTextCell(row, timetable.TicketCost);
            AddTextCell(row, timetable.TravelTime);

            AddTextCell(row, timetableService.GetTrainId(timetable));

            return row;
        }

        private void AddTextCell(DataGridViewRow row, object value)
        {
            var cell = new DataGridViewTextBoxCell();
            cell.Value = value;
            row.Cells.Add(cell);
        }

        private void ApplyFiltersButton_Click(object sender, EventArgs e)
        {
            var fromDate = fromDatePicker.Value.Date + fromTimePicker.Value.TimeOfDay;
            var toDate = toDatePicker.Value.Date + toTimePicker.Value.TimeOfDay;
            var weekdays = weekdaysСheckBox.Checked;
            var weekend = weekendCheckBox.Checked;

            var departurePoint = departurePointComboBox.SelectedItem.ToString();
            var destination = destinationComboBox.SelectedItem.ToString();
            
            var nearestDate = customDateRadioButton.Checked ? customDatePicker.Value.Date + customTimePicker.Value.TimeOfDay : DateTime.Now;
            var numberString = NumberComboBox.SelectedItem.ToString();
            var countRecordsToDisplay = String.IsNullOrEmpty(numberString) ? -1 : int.Parse(numberString);

            timetableService.ApplyFilter(fromDate, toDate, weekdays, weekend, departurePoint, destination, nearestDate, countRecordsToDisplay);
        }
    }
}
