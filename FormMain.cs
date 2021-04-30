using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace Arbeidskrav1
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        string RecievedData = "";
        string[] instrumentConfig;
        string pword;
        string write2device;
        string connectLight_Measure1 = ConfigurationManager.ConnectionStrings["Light_Measure1ConnectionString"].ConnectionString;

        List<string> MeasurementAI = new List<string>();
        

        





        private void comboBox_ComPorts_Enter(object sender, EventArgs e)
        {
            comboBox_ComPorts.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBox_ComPorts.Items.Add(ports);

            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBox_ComPorts.SelectedIndex > -1 && comboBox_BitRate.SelectedIndex == 2)
            {
                serialPort1.PortName = comboBox_ComPorts.Items[comboBox_ComPorts.SelectedIndex].ToString();
                

                serialPort1.BaudRate = Convert.ToInt32(comboBox_BitRate.Items[comboBox_BitRate.SelectedIndex]);
                serialPort1.Open();
                
                MessageBox.Show("Connection successful");
                toolStripStatusLabel2.ForeColor = Color.Green;
                toolStripStatusLabel2.Text = "Connected";
            }



            
            else
            {
                MessageBox.Show("No connection established. Change communication port and/or baud rate");
                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.Text = "Not connected";
            }
                


            

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                
                toolStripStatusLabel2.ForeColor = Color.Red;
                toolStripStatusLabel2.Text = "Not connected to a device";
                MessageBox.Show("Disconnected");
            }
            


        }

        private void buttonSaveConfig2File_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string FileName = "";

                if (textBoxReadVals.Text.Length == 0)
                {
                    MessageBox.Show("No data to save");
                }


                if (textBoxReadVals.Text.Length > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileName = saveFileDialog1.FileName;
                    File.WriteAllText(FileName, textBoxReadVals.Text);

                    MessageBox.Show(FileName, "File saved");


                }
            }
           
        }

        private void timerChartadd_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readraw");
                timerSerialRecieve.Enabled = true;
                timerChartadd.Enabled = false;
            }
        }
        private void timerChartScaled_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readscaled");
                timerRecievedScaled.Enabled = true;
                timerChartScaled.Enabled = false;
            }
        }
        private void timerRecievedScaled_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 0)
                {


                    string scaledData = "";

                    if (textBoxUpdateFrequency.TextLength == 0)
                    {
                        timerRecievedScaled.Interval = 1000;
                    }

                    else
                    {
                        timerRecievedScaled.Interval = int.Parse(textBoxUpdateFrequency.Text.ToString())*1000; // konverterer fra sekunder til millisekunder
                    }

                    scaledData = serialPort1.ReadExisting().ToString();

                    string[] scaledReadings = scaledData.Split(';');
                    scaledData = scaledData.Replace(".", ",");
                    var textBoxURVTextFormated = textBoxURV.Text.Replace(".", ",");
                    var textBoxLRVTextFormated = textBoxLRV.Text.Replace(".", ",");
                    SqlConnection connection = new SqlConnection(connectLight_Measure1);

                    string sqlInsertQuery = "INSERT INTO Measurment_AI (Scaled_values,Tagname) VALUES (@Scaled_values, @Tagname)";
                    SqlCommand command = new SqlCommand(sqlInsertQuery, connection);

                    double.TryParse(scaledData, out double scaledVals);
                    double.TryParse(textBoxURVTextFormated, out double URVNumber);
                    double.TryParse(textBoxLRVTextFormated, out double LRVNumber);

                    //var URVNumber = double.Parse(textBoxURV.Text, System.Globalization.CultureInfo.InvariantCulture);
                    //var LRVNumber = double.Parse(textBoxLRV.Text, System.Globalization.CultureInfo.InvariantCulture);
                    //var scaledVals = double.Parse(scaledData, System.Globalization.CultureInfo.InvariantCulture);


                    connection.Open();

                    if (scaledReadings.Length == 1 && textBoxTagName.TextLength > 0 && scaledVals < URVNumber && scaledVals > LRVNumber)
                    {
                        listBoxScaled.Items.Add(scaledData);
                        string tmp = scaledReadings[0];
                        chart2.Series[0].Points.AddXY(Convert.ToDouble(listBoxScaled.Items.Count - 1),
                            Convert.ToDouble(listBoxScaled.Items[listBoxScaled.Items.Count - 1]));

                        command.Parameters.AddWithValue("@Scaled_values", Convert.ToDouble(scaledData));
                        command.Parameters.AddWithValue("@Tagname", textBoxTagName.Text);

                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Data out of range";
                    }

                    
                }
                timerChartScaled.Enabled = true;
                timerRecievedScaled.Enabled = false;
            }
            else
            {
                MessageBox.Show("Device disconnected");
                toolStripStatusLabel2.Text = "Disconnected";
            }
            
        }

        private void timerSerialRecieve_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead > 0)
                {
                    string rawData = "";

                    rawData = serialPort1.ReadExisting().ToString();

                    string[] analogReadings = rawData.Split(';');


                    if (analogReadings.Length == 1)
                    {


                        listBoxRaw.Items.Add(rawData);
                        chart1.Series[0].Points.AddXY(Convert.ToDouble(listBoxRaw.Items.Count - 1),
                            Convert.ToDouble(listBoxRaw.Items[listBoxRaw.Items.Count - 1]));

                    }

                }
                timerChartadd.Enabled = true;
                timerSerialRecieve.Enabled = false;
            }
            
            
        }

        private void buttonStartAuto_Click(object sender, EventArgs e)
        {
            chart2.Series[0].Points.Clear();
            
            chart1.Series[0].Points.Clear();
            

            
            if (serialPort1.IsOpen)
            {
                listBoxScaled.Items.Clear();
                listBoxRaw.Items.Clear();
                if (checkBoxRawVals.Checked == true && checkBoxScaledVals.Checked == true)
                {
                    MessageBox.Show("You cannot chose both raw and scaled values at the same time");
                }

                else if (checkBoxScaledVals.Checked == true)
                {
                    checkBoxRawVals.Enabled = false;
                    if (textBoxTagName.TextLength > 0)
                    {
                        timerChartScaled.Enabled = true;
                        timerRecievedScaled.Enabled = false;
                        chart2.Visible = true;
                        chart1.Visible = false;

                        if (listBoxScaled.Items.Count > 0)
                        {
                            toolStripStatusLabel1.Text = "Reading scaled data and writing to database";
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Read configuration to see instrument Tagname");
                    }

                    

                }

                else if (checkBoxRawVals.Checked == true)
                {
                    chart2.Visible = false;
                    chart1.Visible = true;
                    timerChartadd.Enabled = true;
                    timerSerialRecieve.Enabled = false;
                    checkBoxScaledVals.Enabled = false;
                    toolStripStatusLabel1.Text = "Reading raw data from device";
                }


                


                if (checkBoxScaledVals.Checked == false && checkBoxRawVals.Checked == false)
                {
                    MessageBox.Show("Choose scaled or raw values before starting");
                }

            }
            else
            {
                MessageBox.Show("Connect to a device before starting monitoring");
            }
            
        }

        private void buttonStopAuto_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timerChartadd.Enabled = false;
                timerSerialRecieve.Enabled = false;
                timerChartScaled.Enabled = false;
                timerRecievedScaled.Enabled = false;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                toolStripStatusLabel1.Text = "Monitoring stopped";
                checkBoxRawVals.Checked = false;
                checkBoxScaledVals.Checked = false;
                checkBoxScaledVals.Enabled = true;
                checkBoxRawVals.Enabled = true;



            }

        }

        private void buttonReadData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (serialPort1.BytesToRead == 0)
                {
                    serialPort1.WriteLine("readconf");
                    System.Threading.Thread.Sleep(1500);
                    RecievedData = serialPort1.ReadExisting().ToString();
                    string[] instrumentConfig = RecievedData.Split(';');
                    RecievedData += "\r\n";


                    if (instrumentConfig.Length == 5)
                    {
                        textBoxReadVals.Clear();
                        textBoxReadVals.AppendText(RecievedData);
                        textBoxTagName.Text = instrumentConfig[0];
                        textBoxLRV.Text = instrumentConfig[1];
                        textBoxURV.Text = instrumentConfig[2];
                        textBoxAlarmLow.Text = instrumentConfig[3];
                        textBoxAlarmHigh.Text = instrumentConfig[4];
                    }
                }
                else
                {
                    string tmp = serialPort1.ReadExisting().ToString();

                }
            }

            
            




        }
        private void buttonWrite2Device_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                var textboxWriteValues = new[] { textBoxTagName, textBoxLRV, textBoxURV, textBoxLRV,
                textBoxAlarmLow, textBoxAlarmHigh};

                if (textboxWriteValues.Any(x=> string.IsNullOrWhiteSpace(x.Text)))
                {
                    MessageBox.Show("Fill in all parameters to write");
                }

                else
                {
                    Form1Password pform = new Form1Password();
                    pform.ShowDialog();

                    pword = pform.Password;

                    write2device = "writeconf";
                    string[] ConfigDataNew = new string[5];

                    ConfigDataNew[0] = textBoxTagName.Text;
                    ConfigDataNew[1] = textBoxLRV.Text;
                    ConfigDataNew[2] = textBoxURV.Text;
                    ConfigDataNew[3] = textBoxAlarmLow.Text;
                    ConfigDataNew[4] = textBoxAlarmHigh.Text;

                    string forceString = write2device + ">" + pword + ">" + string.Join(";", ConfigDataNew);
                    serialPort1.Write(forceString);
                }
                
                

                


                timerWrite2Device.Enabled = true;
            }
           
        }



        private void timerWrite2Device_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string pWordCheck = serialPort1.ReadExisting();

                if (pWordCheck.Length > 0)
                {

                    if (pWordCheck == "1")
                    {
                        instrumentConfig[0] = textBoxTagName.Text;
                        instrumentConfig[1] = textBoxLRV.Text;
                        instrumentConfig[2] = textBoxURV.Text;
                        instrumentConfig[3] = textBoxAlarmHigh.Text;
                        instrumentConfig[4] = textBoxAlarmLow.Text;

                        MessageBox.Show("Access confirmed. Press Read Config to see new configuration");

                    }
                    else
                    {
                        MessageBox.Show("Password incorrect",
                                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    timerWrite2Device.Enabled = false;

                }
            }

            



        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                    serialPort1.WriteLine("readstatus");
                    System.Threading.Thread.Sleep(1500);
                    textBoxReadVals.Clear();

                    string ReadStatus = serialPort1.ReadExisting().ToString();
                    int convertStatus = int.Parse(ReadStatus);

                    if (convertStatus == 0)
                    {
                        toolStripStatusLabelStatusRead.Text = "OK";
                    }

                 
                    else if (convertStatus == 2)
                    {
                        toolStripStatusLabelStatusRead.Text = "Alarm low";
                    }
                    else if (convertStatus == 3)
                    {
                        toolStripStatusLabelStatusRead.Text = "Alarm High";
                    }

                
            else
            {
                    
                    toolStripStatusLabelStatusRead.Text = "Fail";
            }

            }

        }

        private void buttonSaveCsv_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                                                   

                    if (listBoxRaw.Items.Count < 1)
                    {
                        MessageBox.Show("No data to save");
                    }

                    else if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
                    {
                        string fileName = "";
                        fileName = saveFileDialogCsv.FileName;
                        StreamWriter outputFile = new StreamWriter(fileName);


                        for (int line = 0; line < listBoxRaw.Items.Count; line++)
                        {

                            outputFile.WriteLine(listBoxRaw.Items[line].ToString());
                        }


                        outputFile.Close();
                    }
                
                    
            }
            

        }
    

        



        private void buttonOpenFile_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                var filename = string.Empty;

                openFileDialog1.InitialDirectory = "c:\\";

                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = "";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    string FromFile = "";
                    var StreamReader = new StreamReader(filename);


                    FromFile = StreamReader.ReadToEnd();

                    textBoxReadVals.Text = FromFile.ToString();
                }
            }

            
            
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            
            this.deviceTableAdapter.Fill(this.lIGHT_MEASURE1DataSet.Device);
           
            this.manufactorTableAdapter.Fill(this.lIGHT_MEASURE1DataSet.Manufactor);
            
            this.areaTableAdapter.Fill(this.lIGHT_MEASURE1DataSet.Area);

            AboutBox1 popUp = new AboutBox1();
            popUp.ShowDialog(this);
            instrumentConfig = new string[5];
            toolStripStatusLabel2.ForeColor = Color.Red;
            toolStripStatusLabel2.Text = "Not connected to a device";
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabelStatusRead.Text = "";
            comboBoxArea.SelectedIndex = -1;
            comboBoxDevice.SelectedIndex = -1;
            comboBoxManufactor.SelectedIndex = -1;

            if (serialPort1.IsOpen)
            {
                checkBoxScaledVals.Enabled = true;
                checkBoxRawVals.Enabled = true;
            }
            else
            {
                toolStripStatusLabel2.Text = "Not connected to a device";
            }

            if (serialPort1.IsOpen == false)
            {
                toolStripStatusLabel2.Text = "Not connected to a device";
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabelStatusRead.Text = "";
            }
        }

        private void buttonSaveChart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (saveFileDialogChart.ShowDialog() == DialogResult.OK)
                {
                    if (chart1.Visible == true)
                    {
                        this.chart1.SaveImage(saveFileDialogChart.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        chart1.Series.Clear();


                        MessageBox.Show("Chart is saved");
                    }

                    else if (chart2.Visible == true)
                    {
                        this.chart2.SaveImage(saveFileDialogChart.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        chart1.Series.Clear();


                        MessageBox.Show("Chart is saved");
                    }
                    
                }
            }
            
            
       

        }

        private void buttonSaveScaled_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                if (listBoxScaled.Items.Count < 1)
                {
                    MessageBox.Show("No data to save");
                }




                else if (saveFileDialogScaled.ShowDialog() == DialogResult.OK)
                {
                    

                    string fileName = "";
                    fileName = saveFileDialogScaled.FileName;
                    StreamWriter outputFile1 = new StreamWriter(fileName);


                    for (int line = 0; line < listBoxScaled.Items.Count; line++)
                    {

                        outputFile1.WriteLine(listBoxScaled.Items[line].ToString());
                    }


                    outputFile1.Close();
                }
            }
               
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 popup = new AboutBox1();
            popup.ShowDialog(this);
        }

        private void buttonSave2DB_Click(object sender, EventArgs e)
        {
            if (textBoxTagName.Text.Length > 0 && textBoxLRV.Text.Length > 0 && textBoxURV.Text.Length > 0 && textBoxAlarmLow.Text.Length > 0 && textBoxAlarmHigh.Text.Length > 0 && textBoxUpdateFrequency.TextLength > 0)
            {
                
                
                SqlConnection connection = new SqlConnection(connectLight_Measure1);
                connection.Open();

                

                //Sjekker om tagname eksisterer
                string get_instrument_config = "SELECT TOP 1 Tagname FROM Instrument_Configuration WHERE Tagname = @Tagname";
                string Insert_new_instrument_config = "INSERT INTO Instrument_Configuration (Tagname, Lower_range_value, Upper_range_value, Alarm_low, Alarm_High, Description, Measurment_unit, Scanning_frequency, Area_number, Manufactor_Id, Device_Id) VALUES (@Tagname, @Lower_range_value, @Upper_range_value, @Alarm_low, @Alarm_High, @Description, @Measurment_unit, @Scanning_frequency, @Area_number, @Manufactor_Id, @Device_Id)";
                string Update_instrument_config = @"UPDATE Instrument_Configuration 
                                                    SET Lower_range_value = @Lower_range_value, 
                                                        Upper_range_value = @Upper_range_value,
                                                        Alarm_low = @Alarm_low,
                                                        Alarm_High = @Alarm_High,
                                                        Description = @Description,
                                                        Measurment_unit = @Measurment_unit,
                                                        Scanning_frequency = @Scanning_frequency,
                                                        Area_number = @Area_number,
                                                        Manufactor_Id = @Manufactor_Id,
                                                       
                                                        Device_Id = @Device_Id 
                                                        WHERE Tagname = @Tagname";



                SqlCommand getTagname = new SqlCommand(get_instrument_config, connection);
                getTagname.Parameters.AddWithValue("@Tagname", textBoxTagName.Text);
                
                var tagname = getTagname.ExecuteScalar();

                SqlCommand command = new SqlCommand("", connection);

                if(tagname == null)
                {
                    command = new SqlCommand(Insert_new_instrument_config, connection);
                } else
                {
                    command = new SqlCommand(Update_instrument_config, connection);
                }
                
                

                command.Parameters.AddWithValue("@Tagname", textBoxTagName.Text);
                command.Parameters.AddWithValue("@Lower_range_value", textBoxLRV.Text);
                command.Parameters.AddWithValue("@Upper_range_value", textBoxURV.Text);
                command.Parameters.AddWithValue("@Alarm_low", textBoxAlarmLow.Text);
                command.Parameters.AddWithValue("@Alarm_High", textBoxAlarmHigh.Text);
                command.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                command.Parameters.AddWithValue("@Measurment_unit", textBoxUnit.Text);
                command.Parameters.AddWithValue("@Scanning_frequency", textBoxUpdateFrequency.Text);
                command.Parameters.AddWithValue("@Area_number", comboBoxArea.SelectedValue);
                command.Parameters.AddWithValue("@Manufactor_Id", comboBoxManufactor.SelectedValue);
                command.Parameters.AddWithValue("@Device_Id", comboBoxDevice.SelectedValue);
                


                command.ExecuteNonQuery();


                connection.Close();


            }
            else
            {
                MessageBox.Show("Fill in all data in configuration");
            }
        }
    }
}



    
