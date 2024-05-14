using Timer = System.Windows.Forms.Timer;

namespace 倒數計時器
{
    public partial class Form1 : Form
    {
        private int now = 100;
        private Timer timer = new Timer();


        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            
            timer.Interval = 1000; // 計時器1秒
            timer.Tick += Timer1_Tick;
            //當 Timer 物件的間隔時間過去後，就會觸發 Tick 事件
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            now--;
            if (now == 0)
            { 
                timer.Stop();
                MessageBox.Show("TIME'S UP!!");
            }

            count.Text = now.ToString();
        }
        private void start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        
    }
}
