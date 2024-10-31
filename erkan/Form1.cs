using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Media;
using System.IO;


namespace erkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlaySound()
        {
            // Gömülü kaynak adını belirtin
            var resourceName = "erkan.music.wav";

            using (Stream audioStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (audioStream != null)
                {
                    using (SoundPlayer player = new SoundPlayer(audioStream))
                    {
                        player.Play(); // Müzik çalmaya başla
                    }
                }
                else
                {
                    MessageBox.Show("Ses dosyası bulunamadı.");
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("kapıcanmı", "shikanoko", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.No)
            {
                MessageBox.Show("(nun)\r\nShikanoko nokonoko koshi tantan\r\nShikanoko nokonoko koshi tantan\r\nShikanoko nokonoko koshi tantan\r\nShikanoko nokonoko koshi tantan\r\n(nun!)\r\n\r\nShikanoko tokotoko arawaru nokonoko\r\nTsuno tsuno pyoko pyoko mitame wa onya no ko?\r\nChikagoro uwasa no nakanaka kiwamono\r\nOtenami ikahodo henachoko?\r\n\r\nSugoku mukashi kara japan ni seisoku\r\nShika senbei nara mugen ni kudasai!\r\nTonakai wa nakama kamoshika wa ushika\r\nDemo demo matomete guuteimoku\r\n\r\nNun no suteppu de odorou\r\nYo ga akeru made (wan, tsuu, surii)\r\n\r\nNando datte hansuu shite nu nu nun\r\nYosoku fukanou shika iro deizu\r\nAbangyarudo de oorai kaosu mashi mashi↑↑\r\n\r\nItsu no ma ni kuse ni natte nu nu nun\r\nHacha de mecha na shika iro deizu\r\nHatenkou bacchi Come on!\r\nNandemo ari ruuru nante nashi\r\n\r\nKimi no egao de genki mantan\r\nMoshikashite unmei no ma, ma, My Deer!?\r\nKokoro no dokoka de koshi tantan\r\nKimi to nara itsu made mo\r\n\r\nShikanoko nokonoko koshi tantan\r\nShikanoko nokonoko koshi tantan\r\n\r\n[Full Version Continues]\r\n\r\n[thanks for visiting animesonglyrics.com]\r\n\r\nShikanoko shika katan! odaterya ichikoro?\r\nIya iya igai to tsuwamono kamo yo\r\nYaru koto nasu koto dotabata sawagi de\r\nTsugou ga warukerya terepooto!?\r\n\r\nYoukoso shikabu e atsumare shika tomo\r\nShika ni naritakerya kewashii michi da zo\r\nImadoki JK nara jidai wa shika desho\r\nShika senbei katate ni hai, poozu\r\n\r\nNun no koe ga hibiku yo\r\nChikyuu wo koete doko made mo\r\n\r\nKureejii sore tte hometeru?\r\nTorikkii de ii jan puchohenza\r\n\r\nKami no tsukaitaru shika wo agame yo\r\nShikanoko kami no ko banbanzai!\r\nKami no tsukaitaru shika wo agame yo\r\nShikanoko kami no ko banbanzai!\r\n\r\nSeishun tte yatsu kamo nante\r\nKirari kirari kagayaiteru ne\r\nMabushi sugiru nara gurasan hai (.∀.) つ dozoo\r\n\r\nNando datte hansuu shite nu nu nun\r\nYosoku fukanou shika iro deizu\r\nAbangyarudo de oorai kaosu mashi mashi↑↑\r\n\r\nItsu no ma ni kuse ni natte nu nu nun\r\nHacha de mecha na shika iro deizu\r\nHatenkou bacchi Come on!\r\nNandemo ari ruuru nante nashi\r\n\r\nKimi no egao de genki mantan\r\nMoshikashite unmei no ma, ma, My Deer!?\r\nKokoro no dokoka de koshi tantan\r\nJinrui shikaka keikaku\r\nSonna koto wa sasenai\r\n(demo!)\r\nKimi to nara itsu made mo\r\n\r");
                e.Cancel = true; // Kapatmayı iptal et
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PlaySound();
        }
    }
}
