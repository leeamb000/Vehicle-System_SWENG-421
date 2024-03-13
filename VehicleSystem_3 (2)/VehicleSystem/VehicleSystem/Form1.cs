using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace VehicleSystem
{
    public partial class Form1 : Form
    {
        UserIF User = new User();
        Session session;
        VehicleIF vehicle;
        Suspension suspension;
        SeatingCapacityForm seatingForm;
        NumOfDoorsForm doorsForm;
        TransmissionForm transmForm;
        SpareTireForm spareTireForm;
        SuspensionForm suspensionForm;
        MaintenanceVisitorIF maintenanceVisitor;  //add maintance visitor pattern to provide service
        List<string> selectedItems = new List<string>(); //stores user's added vehicle items and accesories
        string suspensionType;

        //these parts/accessories have a maximum allowed number:
        decimal numSeats = 0; decimal numDoors = 0; decimal numSpareTires = 0; decimal numVideoScreens = 0;
        

        public Form1()
        {
            InitializeComponent();
            session = new Session();
        }

        public VehicleIF getVehicle()
        {
            return this.vehicle;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}
        private void Form1_Load(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e){ }

        private void btnOK_Click(object sender, EventArgs e) //add vehicle button
        {
            if (textBox1.Text == "") //only lets you create a new vehicle if you have not started another order
            {
                this.vehicle = User.UseFactory(vehicleListBox.GetItemText(vehicleListBox.SelectedItem));
                textBox1.AppendText($"{this.vehicle.GetModelName()}");
                textBox1.AppendText(Environment.NewLine);
            }
            
            button2.Enabled = true;
            addVehicleBtn.Enabled = false;  
            vehicleListBox.Enabled = false;
        }

        private void listBox2_Click(object sender, EventArgs e) //customize parts listbox
        {
            if (textBox1.Text != "") //vehicle must be created first
            {
                addPartsBtn.Enabled = true;

                if (accesoriesListBox.SelectedItem.ToString() == "Seating Capacity")
                {
                    seatingForm = new SeatingCapacityForm();
                    seatingForm.ShowDialog();
                }

                else if (accesoriesListBox.SelectedItem.ToString() == "Transmission")
                {
                    transmForm = new TransmissionForm();
                    transmForm.ShowDialog();
                }

                else if (accesoriesListBox.SelectedItem.ToString() == "Spare Tires")
                {
                    spareTireForm = new SpareTireForm();
                    spareTireForm.ShowDialog();
                }
                else if (accesoriesListBox.SelectedItem.ToString() == "Doors")
                {
                    doorsForm = new NumOfDoorsForm();
                    doorsForm.ShowDialog();
                }
                else if (accesoriesListBox.SelectedItem.ToString() == "Suspension")
                {
                    suspensionForm = new SuspensionForm();
                    suspensionForm.ShowDialog();
                }
            }

        }

     
        private void btnAddCustomizedParts_Click(object sender, EventArgs e) //add parts button, "customize"
        {
                selectedItems.Add(accesoriesListBox.SelectedItem.ToString());

                if (accesoriesListBox.SelectedItem.ToString() == "Seating Capacity")
                {

                    if (numSeats + seatingForm.numericUpDown1.Value <= 9)
                    {
                        for (int i = 0; i < seatingForm.numericUpDown1.Value; i++)
                        {
                            VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new Seat());
                            tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                            tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                            tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                            tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                            tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                            tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                            tempvehicle.setOilChange(this.vehicle.getOilChange());

                        this.vehicle = tempvehicle;
                        }
                        textBox1.AppendText($"{seatingForm.numericUpDown1.Value} seat(s) are added");
                        textBox1.AppendText(Environment.NewLine);
                        numSeats += seatingForm.numericUpDown1.Value;
                    }

                    else
                    {
                        MessageBox.Show("A maximum number of 9 seats is allowed");
                    }
                }
                else if (accesoriesListBox.SelectedItem.ToString() == "Doors")
                {
                    if (numDoors + doorsForm.numericUpDown3.Value <= 6)
                    {
                        for (int i = 0; i < doorsForm.numericUpDown3.Value; i++)
                        {
                            VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new Door());
                            tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                            tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                            tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                        tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                        tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                        tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                        tempvehicle.setOilChange(this.vehicle.getOilChange());
                        this.vehicle = tempvehicle;
                        }
                        textBox1.AppendText($"{doorsForm.numericUpDown3.Value} doors(s) are added");
                        textBox1.AppendText(Environment.NewLine);
                        numDoors += doorsForm.numericUpDown3.Value;
                    }
                    else
                    {
                        MessageBox.Show("A maximum number of 6 doors is allowed");
                    }
                }
                else if (accesoriesListBox.SelectedItem.ToString() == "Spare Tires")
                {
                    if (numSpareTires + spareTireForm.numericUpDown2.Value <= 4)
                    {
                        for (int i = 0; i < spareTireForm.numericUpDown2.Value; i++)
                        {
                            VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new SpareTire());
                            tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                            tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                            tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                            tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                        tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                        tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                        tempvehicle.setOilChange(this.vehicle.getOilChange());
                        this.vehicle = tempvehicle;
                        }
                        textBox1.AppendText($"{spareTireForm.numericUpDown2.Value} spare tire(s) are added");
                        textBox1.AppendText(Environment.NewLine);
                        numSpareTires += spareTireForm.numericUpDown2.Value;
                    }
                    else
                    {
                        MessageBox.Show("A maximum number of 4 spare tires is allowed");
                    }
                }
                else if (accesoriesListBox.SelectedItem.ToString() == "Transmission")
                {
                    this.vehicle.SetTransmission(transmForm.transmissionListBox.SelectedItem.ToString());
                    textBox1.AppendText($"Transmission Type is set to: {transmForm.transmissionListBox.SelectedItem.ToString()}");
                    textBox1.AppendText(Environment.NewLine);
                }
                else if (accesoriesListBox.SelectedItem.ToString() == "Suspension")
                {
                   this.vehicle.SetSuspension(suspensionForm.type);
                    textBox1.AppendText($"Suspension Type is set to: {suspensionForm.type}");
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.AppendText($" {suspensionForm.cb1}");
                    textBox1.AppendText($" {suspensionForm.cb2}");
                    textBox1.AppendText($" {suspensionForm.cb3}");
                    textBox1.AppendText(Environment.NewLine);
                    suspensionType = suspensionForm.type;
                }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e) {}
        private void accesoriesListBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void vehicleListBox_MouseClick(object sender, MouseEventArgs e){}

        private void vehicleListBox_Click(object sender, EventArgs e)
        {         
            addVehicleBtn.Enabled = true;           
        }

        private void fuelListBox_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") //vehicle must be created first
            {
                addFuelBtn.Enabled = true;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e){}
        private void label5_Click(object sender, EventArgs e){}
        private void label4_Click(object sender, EventArgs e){}
        private void numericUpDown2_ValueChanged(object sender, EventArgs e){ }

        private void colorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") //vehicle must be created first
            {
                addColorBtn.Enabled = true;
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "") //vehicle must be created first
            {
                maintanceBtn.Enabled = true;
            }
        }

        private void maintanceBtn_Click(object sender, EventArgs e)
        {
            maintenanceVisitor = new MaintanceVisitor();
            this.vehicle.AcceptMaintenanceVisitor(maintenanceVisitor);
            textBox1.AppendText($"Selected maintance: {listBox1.SelectedItem.ToString()}");
            textBox1.AppendText(Environment.NewLine);

            if (listBox1.SelectedItem.ToString() == "Oil Change")
                this.vehicle.setOilChange(true);
            else if (listBox1.SelectedItem.ToString() == "Wheel Rotation")
                this.vehicle.setRotateTires(true);
            else if (listBox1.SelectedItem.ToString() == "Brakes Check")
                this.vehicle.setCheckBrakes(true);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)  //accessory listbox
        {
            if (textBox1.Text != "") //vehicle must be created first
            {
                addAccessoryBtn.Enabled = true;
            }

            //highlights accessory numericUpDown labels to draw attention:

            if (listBox2.SelectedItem.ToString() == "Floor Mat") 
            {
                label5.BackColor = Color.Yellow;
            }
            if (listBox2.SelectedItem.ToString() != "Floor Mat")
            {
                label5.BackColor = DefaultBackColor;
            }

            if (listBox2.SelectedItem.ToString() == "Passenger Video Screen")
            {
                label10.BackColor = Color.Yellow;
            }
            if (listBox2.SelectedItem.ToString() != "Passenger Video Screen")
            {
                label10.BackColor = DefaultBackColor;
            }

            if (listBox2.SelectedItem.ToString() == "Seat Cover")
            {
                label4.BackColor = Color.Yellow;
            }
            if (listBox2.SelectedItem.ToString() != "Seat Cover")
            {
                label4.BackColor = DefaultBackColor;
            }
        }

/// <summary>
/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) //add accessory button
        {
            if (listBox2.SelectedItem.ToString() == "Floor Mat")
            {
                for (int i = 0; i < numericUpDown3.Value; i++)
                {
                    VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new FloorMat());
                    tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                    tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                    tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                    tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                    tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                    tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                    tempvehicle.setOilChange(this.vehicle.getOilChange());
                    this.vehicle = tempvehicle;
                }
                textBox1.AppendText($"{numericUpDown3.Value} floor mat(s) are added");
                textBox1.AppendText(Environment.NewLine);
            }
            else if (listBox2.SelectedItem.ToString() == "Passenger Video Screen")
            {
                if (numVideoScreens + numericUpDown1.Value <= 8)
                {
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new VideoScreen());
                        tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                        tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                        tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                        tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                        tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                        tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                        tempvehicle.setOilChange(this.vehicle.getOilChange());
                        this.vehicle = tempvehicle;
                    }
                    textBox1.AppendText($"{numericUpDown1.Value} passenger video screen(s) are added");
                    textBox1.AppendText(Environment.NewLine);
                    numVideoScreens += numericUpDown1.Value;
                }
                else
                {
                    MessageBox.Show("A maximum number of 8 passenger video screens is allowed");
                }
            }
            else if (listBox2.SelectedItem.ToString() == "Seat Cover")
            {
                for (int i = 0; i < numericUpDown2.Value; i++)
                {
                    VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new SeatCover());
                    tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                    tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                    tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                    tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                    tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                    tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                    tempvehicle.setOilChange(this.vehicle.getOilChange());
                    this.vehicle = tempvehicle;
                }
                textBox1.AppendText($"{numericUpDown2.Value} seat cover(s) are added");
                textBox1.AppendText(Environment.NewLine);
            }
            else if (listBox2.SelectedItem.ToString() == "Auto Starter")
            {
                VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new AutoStarter());
                tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                tempvehicle.setOilChange(this.vehicle.getOilChange());
                this.vehicle = tempvehicle;
                textBox1.AppendText($"Auto starter is added");
                textBox1.AppendText(Environment.NewLine);
            }
            else if (listBox2.SelectedItem.ToString() == "Tire Pressure Monitor")
            {
                VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new TirePressureMonitor());
                tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                tempvehicle.setOilChange(this.vehicle.getOilChange());
                this.vehicle = tempvehicle;
                textBox1.AppendText($"Tire pressure monitor is added");
                textBox1.AppendText(Environment.NewLine);
            }
            else if (listBox2.SelectedItem.ToString() == "Car Alarm")
            {
                VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new CarAlarm());
                tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                tempvehicle.setOilChange(this.vehicle.getOilChange());
                this.vehicle = tempvehicle;
                textBox1.AppendText($"Car alarm is added");
                textBox1.AppendText(Environment.NewLine);
            }
            else if (listBox2.SelectedItem.ToString() == "Phone Mount")
            {
                VehicleDecorator tempvehicle = new VehicleDecorator(this.vehicle, new PhoneMount());
                tempvehicle.SetPaintColor(this.vehicle.GetPaintColor());
                tempvehicle.SetTransmission(this.vehicle.GetTransmission());
                tempvehicle.SetFuelType(this.vehicle.GetFuelType());
                tempvehicle.SetSuspension(this.vehicle.GetSuspension());
                tempvehicle.setCheckBrakes(this.vehicle.getCheckBrakes());
                tempvehicle.setRotateTires(this.vehicle.getRotateTires());
                tempvehicle.setOilChange(this.vehicle.getOilChange());
                this.vehicle = tempvehicle;
                textBox1.AppendText($"Phone mount is added");
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e) //order vehicle
        {
            this.vehicle.BuildVehicle(this.vehicle);
        }

        private void addColorBtn_Click(object sender, EventArgs e) //add color
        {
            this.vehicle.SetPaintColor(colorListBox.SelectedItem.ToString());

            if (!selectedItems.Contains(colorListBox.SelectedItem.ToString())) {
                textBox1.AppendText($"Color is set to: {colorListBox.SelectedItem.ToString()}");
                selectedItems.Add(colorListBox.SelectedItem.ToString());
                textBox1.AppendText(Environment.NewLine);
            }

            
        }

        private void addFuelBtn_Click(object sender, EventArgs e) //add fuel type 
        {
            this.vehicle.SetFuelType(fuelListBox.SelectedItem.ToString()); //set fuel type

             if (!selectedItems.Contains(fuelListBox.SelectedItem.ToString()))
             {
                // AddComponent the selected item to the textbox and the selected items list
                textBox1.AppendText($"Fuel Type is set to: {fuelListBox.SelectedItem.ToString()}");
                selectedItems.Add(fuelListBox.SelectedItem.ToString());
                textBox1.AppendText(Environment.NewLine);
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            session.Interrupt();
        }
    }
}
