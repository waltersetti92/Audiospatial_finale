using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Audiospatial
{
    public partial class Activity_Stanza : UserControl
    {
        public Main parentForm { get; set; }
        private debugInfo debug = null;
        private static readonly string[] operations_labels = new string[] { "+", "-", "x", "/" };
        private static readonly string[] operations_texts = new string[] { "piu", "meno", "per", "divisione" };

        private readonly List<string> currOperationsLabels = new List<string>(); // displayed labels of the operations
        private readonly List<PictureBox> currOperationsIcons = new List<PictureBox>();
        private readonly List<string> currOperationsTexts = new List<string>();

        private SingleActivity currActivity = null;

        private int iDifficulty;

        private string currStartingNumber = "";
        private string currResult = "";
        public string k;
        public string put_wait_data;
        public string put_started;
        public Activity_Stanza()
        {
            InitializeComponent();
           // SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
          //  this.BackgroundImage = Properties.Resources.Picture1;
           // this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.BackColor = Color.Transparent;
            resetOperations();
            put_started = "/api/uda/put/?i=5&k=7";
            put_wait_data = "/api/uda/put/?i=5&k=14" + "&data=" + "{\"answer\": \"Inserisci il risultato corretto\", \"input_type\":\"\"}";
        }
        private void resetOperations()
        {
            labCenter.Visible = false;
            pbNorth.Visible = false;
            pbEast.Visible = false;
            pbWest.Visible = false;
        }

        // GUI CALLS

        public void applyActivity(SingleActivity act, int type, debugInfo debug)
        {
            this.debug = debug;
            currActivity = act;
            iDifficulty = act.difficulty;


            setStartNumber(currActivity.start_number);

            currOperationsLabels.Clear();
            currOperationsTexts.Clear();
            foreach (int op in currActivity.operations)
            {
                currOperationsLabels.Add(operations_labels[op]);
                currOperationsTexts.Add(operations_texts[op]); 
            }
            resetOperations();
            if (type == ActivityMathSpatialAudio.N_TYPE_SPATIAL) setOperationsIcons(currOperationsTexts.ToArray());
            else resetOperations();

        }

        private string representNumber(int number)
        {
            if (number == -1) return "";

          return number.ToString();
        }
        public void final_number(int i)
        {
            labCenter.Text = Convert.ToString(i);
            this.Update();

            labCenter.Visible = true;
            this.Update();
           
            Thread.Sleep(5000);

        }

        // after new operand is going to be given
        public void nextOperand(int curr_starting_number, int curr_result)
        {
            currStartingNumber = curr_starting_number.ToString();
            currResult = curr_result.ToString();
            Visible = true;
            setStartNumber(curr_starting_number);
            setCountDown(-1);
            Refresh();
        }

        public void setOperationsIcons(string[] ops)
        {
            if (ops is null) return;

            resetOperations();

            pbNorth.WaitOnLoad = true;
            pbNorth.ImageLocation = Main.resourcesPath + "\\" + ops[1] + ".png";
            pbNorth.Visible = true;

            pbEast.WaitOnLoad = true;
            pbEast.ImageLocation = Main.resourcesPath + "\\" + ops[2] + ".png";
            pbEast.Visible = true;

            pbWest.WaitOnLoad = true;
            pbWest.ImageLocation = Main.resourcesPath + "\\" + ops[0] + ".png";
            pbWest.Visible = true;
        }

        public void setStartNumber(int n)
        {
            string strnum = representNumber(n);
            labCenter.Visible = (strnum.Length > 0);

            strnum = fillBlanks(4, strnum);

            labCenter.Text = strnum;
            labCenter.Invalidate();

        }
        public async void setCountDown(int n)
        {
            while (true)
            {
                k = parentForm.Status_Changed(parentForm.activity_form);
                int status = int.Parse(k);
                if (status != 9 && status != 8)
                {
                    if (status == 11 || status == 12)
                    {
                        System.Diagnostics.Process.GetCurrentProcess().Kill();
                    }
                    if (status == 7 || status == 10 )
                    {
                        parentForm.contatore_iniziale = 0;
                        await uda_server_communication.Server_Request(put_started);
                        this.Update();
                        labTimeCounter.Invalidate();
                    }

                    break;
                }
                Thread.Sleep(400);
            }


        }

        private string fillBlanks(int word_length, string str)
        {
            int l = str.Length;

            for (int i = l; i < word_length; i++)
                str = str + " ";

            return str;
        }


        public void setPos(int w, int h)
        {
            int border = 100;
            Location = new Point(0, 0);
            Width = w;
            Height = h;

            labCenter.Location = new Point(w / 2 - border, h / 2);
            pbEast.Location = new Point(w - 3 * border, border);

            //pbNorth.Location = new Point(w / 2 - border / 2, border);
             pbNorth.Location = new Point(2 * border,  border);
            //pbEast.Location = new Point(w - 3 * border, h / 2 + border);
            //pbWest.Location = new Point(2 * border, h / 2 + border);
        }
        private void Activity_Stanza_Load(object sender, EventArgs e)
        {
            labCenter.Visible = true;
        }

        private void labCenter_Click(object sender, EventArgs e)
        {

        }

        private void labTimeCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
