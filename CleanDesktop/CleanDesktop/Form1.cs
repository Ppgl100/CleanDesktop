using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanDesktop
{
    public partial class Form1 : Form
    {
        string path = "shortcuts.txt";
        List<string> myPaths = new List<string>();
        Boolean firstUse = true;
        Color defaultColor = Color.DarkSlateBlue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readColor();

            //creates the txt File for the shortcuts
            createPathFile();

            //creates Dynamic Panles for all the shortcuts in the txt file
            createPanels();

            this.textBox1.KeyDown += new KeyEventHandler(tb_KeyDown);

            //Click event for the default panel and its controls
            this.defaultPanel.MouseClick += panelCLick;
            this.defaultBackground.MouseClick += panelCLick;
            this.defaultIcon.MouseClick += panelCLick;
            this.defaultLabel.MouseClick += panelCLick;
            this.defaultIcon.MouseEnter += mouseEnter;
            this.defaultIcon.MouseLeave += mouseLeave;
            this.defaultLabel.MouseEnter += mouseEnter;
            this.defaultLabel.MouseLeave += mouseLeave;
            this.defaultBackground.MouseEnter += mouseEnter;
            this.defaultBackground.MouseLeave += mouseLeave;


            //Right Click memu
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Remove");
            cm.MenuItems[0].Click += menuItem1_Click;
            this.defaultPanel.ContextMenu = cm;
            this.defaultBackground.ContextMenu = cm;
            this.defaultIcon.ContextMenu = cm;
            this.defaultLabel.ContextMenu = cm;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            Panel p = (Panel)c.Parent;
            foreach(Control cnt in p.Controls)
            {
                if(cnt.BackColor != Color.White && cnt.BackColor != Color.Black)
                {
                    cnt.BackColor = Color.White;
                }
            }
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            Panel p = (Panel)c.Parent;
            foreach (Control cnt in p.Controls)
            {
                if (cnt.BackColor != Color.LightGray && cnt.BackColor != Color.Black)
                {
                    cnt.BackColor = Color.LightGray;
                }
            }
        }

        private void readColor()
        {
            var lines = File.ReadLines("color.txt");
            foreach (var line in lines)
            {
                defaultColor = Color.FromArgb(Convert.ToInt32(line.ToString()));
            }

            mainPanel.BackColor = defaultColor;
            this.BackColor = defaultColor;
            myLayout.BackColor = defaultColor;
            this.defaultPanel.BackColor = defaultColor;
            this.textBox1.BackColor = defaultColor;
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {

            MenuItem m = new MenuItem();
            m = (MenuItem)sender;

            ContextMenu cm = new ContextMenu();
            cm = (ContextMenu)m.Parent;

            Control myParent = new Control();
            myParent = (Control)cm.SourceControl;

            bool isTemp = false;
            foreach(Control c in myParent.Parent.Controls)
            {
                if(c is Label && c.Text == "+")
                {
                        isTemp = true;
                }
            }

            if(myLayout.Controls.Count == 1 || isTemp)
            {
                return;
            }

            string toDelete = "";

            foreach (Control c in myParent.Parent.Controls)
            {
                if(c is Label)
                {
                    toDelete = "" + c.Tag;
                    break;
                }
            }

            foreach(Control c in this.myLayout.Controls)
            {
                if(c == myParent.Parent)
                {
                    myLayout.Controls.Remove(c);
                }
            }

            string line = null;
            string line_to_delete = toDelete;

            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter("tmp"+path))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, line_to_delete) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                }
            }
            File.Delete(path);
            System.IO.File.Move("tmp"+path, path);

            refreshList();
        }

        private void refreshList()
        {
            createPathFile();
        }

        //create dynamic Panel
        private void createDynamicPanel(string path)
        {
            //Template for the danamiy panel creation
            Panel templatePanel = new Panel();
            templatePanel.BackColor = mainPanel.BackColor;
            templatePanel.Anchor = AnchorStyles.Top;
            templatePanel.Size = new Size(344, 144);

            PictureBox templatePic = new PictureBox();
            templatePic.BackColor = Color.White;
            templatePic.Name = "foreground";
            templatePic.Size = new Size(325, 125);
            templatePic.Location = new Point(3,3);
            templatePic.Anchor = AnchorStyles.Top;

            PictureBox templatePicBack = new PictureBox();
            templatePicBack.BackColor = Color.Black;
            templatePicBack.Size = new Size(325, 125);
            templatePicBack.Location = new Point(13, 13);
            templatePicBack.Anchor = AnchorStyles.Top;

            PictureBox tempImage = new PictureBox();
            tempImage.BackColor = Color.Lavender;
            tempImage.Size = new Size(80, 80);
            tempImage.Location = new Point(26, 26);
            tempImage.Anchor = AnchorStyles.Top;
            tempImage.Name = "dynamicIcon";

            Label tempLabel = new Label();
            tempLabel.Size = new Size(201,80);
            tempLabel.TextAlign = ContentAlignment.MiddleCenter;
            tempLabel.AutoSize = false;
            tempLabel.Location = new Point(116, 26);
            tempLabel.Text = "+";
            tempLabel.BackColor = Color.White;
            tempLabel.Anchor = AnchorStyles.Top;
            tempLabel.Font = new Font(defaultLabel.Font.Name,defaultLabel.Font.Size);
            if (path != "")
            {
                tempLabel.Tag = path;
                string fileName = path.Substring(path.LastIndexOf("\\") + 1, path.Length - (path.LastIndexOf("\\") + 1));
                tempLabel.Text = fileName;

                tempImage.BackColor = Color.White;
                Icon myIcon = Icon.ExtractAssociatedIcon(path);
                tempImage.BackgroundImageLayout = ImageLayout.Center;
                tempImage.BackgroundImage = myIcon.ToBitmap();

            }

            //Click event for the dynamic panel and its controls
            templatePic.MouseClick += panelCLick;
            templatePicBack.MouseClick += panelCLick;
            tempImage.MouseClick += panelCLick;
            tempLabel.MouseClick += panelCLick;

            templatePic.MouseEnter += mouseEnter;
            templatePic.MouseLeave += mouseLeave;
            tempImage.MouseEnter += mouseEnter;
            tempImage.MouseLeave += mouseLeave;
            tempLabel.MouseEnter += mouseEnter;
            tempLabel.MouseLeave += mouseLeave;

            //Right Click memu
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Remove");
            cm.MenuItems[0].Click += menuItem1_Click;
            templatePic.ContextMenu = cm;
            templatePicBack.ContextMenu = cm;
            tempImage.ContextMenu = cm;
            tempLabel.ContextMenu = cm;

            templatePanel.Controls.Add(templatePic);
            templatePanel.Controls.Add(templatePicBack);
            templatePanel.Controls.Add(tempImage);
            templatePanel.Controls.Add(tempLabel);
            tempImage.BringToFront();
            tempLabel.BringToFront();
            myLayout.Controls.Add(templatePanel);

            if (!firstUse)
            {
                refreshList();
            }
        }

        //creates Dynamic Panles for all the shortcuts in the txt file
        private void createPanels()
        {
            if(myPaths.Count!=0)
            {
                int tmpCounter = 0;
                foreach(string s in myPaths)
                {
                    if (tmpCounter == 0)
                    {
                        tmpCounter++;
                        addShortcut(myPaths[0], defaultPanel);
                    }
                    else
                    {
                        createDynamicPanel(myPaths[tmpCounter]);
                        tmpCounter++;

                    }
                }
                createDynamicPanel("");
                firstUse = false;
            }
        }

        //Creates the txt file for the shortcuts on start of the application
        private void createPathFile()
        {
            myPaths.Clear();
            if (File.Exists(path))
            {
                var lines = File.ReadLines(path);
                foreach (var line in lines)
                {
                    myPaths.Add(line);
                }
            }
            else
            {
                using (StreamWriter writetext = new StreamWriter(path))
                {
                }
            }
        }

        //Called on click event from panel or its controls
        private void panelCLick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                bool wasAdded = false;
                Control myControl = new Control();
                myControl = (Control)sender;
                string myTag = "";

                //Checks to see if Shortcut was added or not by checking label Text
                foreach (Control c in myControl.Parent.Controls)
                {
                    if (c is Label && c.Text != "+")
                    {
                        myTag = "" + c.Tag;
                        wasAdded = true;
                        break;
                    }
                }

                //If no shortcut was chosen, it opens a FileDialog to choose a shortcut to be added
                if (!wasAdded)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Title = "Choose shortcut";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.DereferenceLinks = false;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            if ((openFileDialog.OpenFile()) != null)
                            {
                                //Adds path to the shortcut txt file
                                string chosenPath = openFileDialog.InitialDirectory + "" + openFileDialog.FileName;
                                if (!myPaths.Contains(chosenPath))
                                {
                                    File.AppendAllText(path, chosenPath + Environment.NewLine);
                                }
                                else
                                {
                                    MessageBox.Show("This shortcut was already added.");
                                    return;
                                }

                                addShortcut(chosenPath, myControl.Parent);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not read Path. Original error: " + ex.Message);
                        }
                    }
                }
                else
                {
                    System.Diagnostics.Process.Start(myTag);
                }
            }
        }

        //Adds the chosen shortcut path to the panel
        private void addShortcut(string shortcutPath, Object sender)
        {
            Control myControl = new Control();
            myControl = (Control)sender;
            Icon myIcon = Icon.ExtractAssociatedIcon(shortcutPath);

            foreach (Control c in myControl.Controls)
            {
                if (c is PictureBox && c.Name.Equals("defaultIcon") || c is PictureBox && c.Name.Equals("dynamicIcon"))
                {
                    PictureBox pb = new PictureBox();
                    pb = (PictureBox)c;
                    pb.BackgroundImageLayout = ImageLayout.Center;
                    pb.BackColor = Color.White;
                    pb.BackgroundImage = myIcon.ToBitmap();
                }
                else if (c is Label)
                {
                    Label l = new Label();
                    l = (Label)c;
                    l.Tag = shortcutPath;

                    string fileName = shortcutPath.Substring(shortcutPath.LastIndexOf("\\")+1, shortcutPath.Length - (shortcutPath.LastIndexOf("\\")+1));
                    l.Text = fileName;
                }
            }

            if (firstUse && myPaths.Count ==0)
            {
                createDynamicPanel("");
                firstUse = false;
            }
            else if(!firstUse)
            {
                createDynamicPanel("");
            }

        }

        private void myLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colorSettings_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                mainPanel.BackColor = colorDlg.Color;
                this.BackColor = colorDlg.Color;
                myLayout.BackColor = colorDlg.Color;
                this.textBox1.BackColor = colorDlg.Color;
                foreach (Control c in myLayout.Controls)
                {
                    if(c is Panel)
                    {
                        c.BackColor = colorDlg.Color;                      
                    }
                }
            }
            System.IO.File.WriteAllText(@"color.txt", colorDlg.Color.ToArgb().ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            foreach(Control c in myLayout.Controls)
            {
                foreach (Control c2 in c.Controls)
                {
                    if (c2 is Label && c2.Text.ToUpper().Contains(this.textBox1.Text.ToUpper()))
                    {
                        c2.BackColor = mainPanel.BackColor;
                        this.myLayout.ScrollControlIntoView(c2);
                    }
                }
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchBtn_Click(null, null);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
