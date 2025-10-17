using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ポートフォリオ作成
{
    public partial class Download : Form
    {
        public Download()
        {
            InitializeComponent();
        }
        private enum ButtonState1
        {
            Action1,
            Action2,
            Action3,
            Action4,
            Action5,
            Action6,
            Action7
        }
        private ButtonState1 buttonState1 = ButtonState1.Action1;
        private Stack< ButtonState1 > historyStack1 = new Stack< ButtonState1 >();
        private void button1_Click(object sender, EventArgs e)
        {
            historyStack1.Push(buttonState1); // 現在の状態を履歴スタックに保存
            switch (buttonState1)
            {
                case ButtonState1.Action1:
                    // Action1の処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\ポートフォリオ.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Visible = true; // label2を表示する
                    buttonState1 = ButtonState1.Action2; // 次の状態に遷移
                    break;
                case ButtonState1.Action2:
                    // Action2の処理
                    label3.Visible = true;
                    buttonState1 = ButtonState1.Action3; // 次の状態に遷移
                    break;
                case ButtonState1.Action3:
                    // Action3の処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\URL貼り付け.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label4.Visible = true;
                    buttonState1 = ButtonState1.Action4; // 次の状態に遷移
                    break;
                case ButtonState1.Action4:
                    // Action4の処理
                    label5.Visible = true;
                    buttonState1 = ButtonState1.Action5; // 次の状態に遷移
                    break;
                case ButtonState1.Action5:
                    // Action5の処理
                    label6.Visible = true;
                    buttonState1 = ButtonState1.Action6; // 次の状態に遷移
                    break;
                case ButtonState1.Action6:
                    // Action6の処理
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = true;
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\更新.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    buttonState1 = ButtonState1.Action7; // 次の状態に遷移
                    break;
                case ButtonState1.Action7:
                    // Action7の処理
                    label8.Visible = true;
                    button1.Enabled = false; // ボタンを無効化してこれ以上クリックできないようにする
                    break;
            }
        }
        private void UpdateView()
        {
            // Viewの更新処理をここに記述
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            pictureBox1.Image = null;

            switch(buttonState1)
            {
                 
                case ButtonState1.Action1:
                    // Action1のView更新処理
                    label1.Visible = true; 
                    break;
                case ButtonState1.Action2:
                    // Action2のView更新処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\ポートフォリオ.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Visible = true;
                    label3.Visible = true;
                    break;
                case ButtonState1.Action3:
                    // Action3のView更新処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\URL貼り付け.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label4.Visible = true;
                    break;
                case ButtonState1.Action4:
                    // Action4のView更新処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\URL貼り付け.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label5.Visible = true;
                    break;
                case ButtonState1.Action5:
                    // Action5のView更新処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\URL貼り付け.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label6.Visible = true;
                    break;
                case ButtonState1.Action6:
                    // Action6のView更新処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\URL貼り付け.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label7.Visible = true;
                    break;
                case ButtonState1.Action7:
                    // Action7のView更新処理
                    pictureBox1.Image = Image.FromFile("C:\\Users\\csharp\\Desktop\\ポートフォリオ説明\\ポートフォリオ作成\\URL貼り付け.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label8.Visible = true;
                    button1.Enabled = false; 
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (historyStack1.Count > 0)
            {
                buttonState1 = historyStack1.Pop(); // 履歴スタックから前の状態を取得
                UpdateView(); // Viewを更新
                button1.Enabled = true; // 戻るボタンが押された場合、進むボタンを有効化
            }
        }
    }
}
