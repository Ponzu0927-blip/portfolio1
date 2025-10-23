using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ポートフォリオ作成
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        private enum ButtonState
        {
            Info1,
            Info2,
            Info3,
            Info4,
            Info5,
            Info6,
            Info7,
            Info8,
            Info9,
            Info10,
            Info11,
            Info12,
            Info13,
            Info14,
            Info15,
            Info16,
            Info17,
            Info18,
            Info19,
            Info20
        }
        private ButtonState buttonState = ButtonState.Info1;
        private Stack<ButtonState> stateHistory = new Stack<ButtonState>();
        private void button1_Click(object sender, EventArgs e)
        {
            stateHistory.Push(buttonState); // 履歴に現在の状態を追加

            switch (buttonState)
            {
                case ButtonState.Info1:
                    // Action1の処理
                    pictureBox1.Image = Image.FromFile(
    　　　　　　　　Path.Combine(Application.StartupPath,  "ポートフォリオ作成", "Git作成.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Visible = true; // label2を表示する
                    buttonState = ButtonState.Info2; // 次の状態に遷移
                    break;
                case ButtonState.Info2:
                    // Action2の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label3.Visible = true;
                    buttonState = ButtonState.Info3; // 次の状態に遷移
                    break;
                case ButtonState.Info3:
                    // Action3の処理
                    label4.Visible = true;
                    buttonState = ButtonState.Info4; // 次の状態に遷移
                    break;
                case ButtonState.Info4:
                    // Action4の処理
                    label5.Visible = true;
                    buttonState = ButtonState.Info5; // 次の状態に遷移
                    break;
                case ButtonState.Info5:
                    // Action5の処理
                    label6.Visible = true;
                    buttonState = ButtonState.Info6; // 次の状態に遷移
                    break;
                case ButtonState.Info6:
                    // Action6の処理
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = true;
                    buttonState = ButtonState.Info7; // 次の状態に遷移
                    break;
                case ButtonState.Info7:
                    // Action7の処理
                    label8.Visible = true;
                    buttonState = ButtonState.Info8; // 次の状態に遷移
                    break;
                case ButtonState.Info8:
                    // Action8の処理
                    label9.Visible = true;
                    buttonState = ButtonState.Info9; // 次の状態に遷移
                    break;
                case ButtonState.Info9:
                    // Action9の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "WebGitホーム.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = true;
                    buttonState = ButtonState.Info10; // 次の状態に遷移
                    break;
                case ButtonState.Info10:
                    // Action10の処理
                    label11.Visible = true;
                    buttonState = ButtonState.Info11; // 次の状態に遷移
                    break;
                case ButtonState.Info11:
                    // Action11の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "ポートフォリオ.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label12.Visible = true;
                    buttonState = ButtonState.Info12; // 次の状態に遷移
                    break;
                case ButtonState.Info12:
                    // Action12の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "GitURL.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label13.Visible = true;
                    buttonState = ButtonState.Info13; // 次の状態に遷移
                    break;
                case ButtonState.Info13:
                    // Action13の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "クローン.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label14.Visible = true;
                    buttonState = ButtonState.Info14; // 次の状態に遷移
                    break;
                case ButtonState.Info14:
                    // Action14の処理
                    label15.Visible = true;
                    buttonState = ButtonState.Info15; // 次の状態に遷移
                    break;
                case ButtonState.Info15:
                    // Action15の処理
                    label10.Visible = false;
                    label11.Visible = false;
                    label12.Visible = false;
                    label13.Visible = false;
                    label14.Visible = false;
                    label15.Visible = false;
                    label16.Visible = true;
                    buttonState = ButtonState.Info16; // 次の状態に遷移
                    break;
                case ButtonState.Info16:
                    // Action16の処理
                    label17.Visible = true;
                    buttonState = ButtonState.Info17; // 次の状態に遷移
                    break;
                case ButtonState.Info17:
                    // Action17の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git変更.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label18.Visible = true;
                    buttonState = ButtonState.Info18; // 次の状態に遷移
                    break;
                case ButtonState.Info18:
                    // Action18の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git変更コメント.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label19.Visible = true;
                    buttonState = ButtonState.Info19; // 次の状態に遷移
                    break;
                case ButtonState.Info19:
                    // Action19の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "プルと同期.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label16.Visible = false;
                    label17.Visible = false;
                    label18.Visible = false;
                    label19.Visible = false;
                    label20.Visible = true;
                    buttonState = ButtonState.Info20; // 次の状態に遷移
                    break;
                case ButtonState.Info20:
                    // Action20の処理
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "追加後.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label21.Visible = true;
                    button1.Enabled = false; // ボタンを無効にする
                    button2.Enabled = true;  // ボタンを有効にする
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false; // ボタンを無効にする
            Download download = new Download();
            download.FormClosed += (s,args) => button2.Enabled = true;
            download.Show();
        }

        private void UpdateView()
        {
            // すべてのラベル・画像を非表示/初期化
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            pictureBox1.Image = null;

            switch (buttonState)
            {
                case ButtonState.Info1:
                    // 初期状態
                    label1.Visible = true;
                    break;
                case ButtonState.Info2:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label2.Visible = true;
                    break;
                case ButtonState.Info3:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label3.Visible = true;
                    break;
                case ButtonState.Info4:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label4.Visible = true;
                    break;
                case ButtonState.Info5:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label5.Visible = true;
                    break;
                case ButtonState.Info6:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label6.Visible = true;
                    break;
                case ButtonState.Info7:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label7.Visible = true;
                    break;
                case ButtonState.Info8:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label8.Visible = true;
                    break;
                case ButtonState.Info9:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git作成パス.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label9.Visible = true;
                    break;
                case ButtonState.Info10:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "WebGitホーム.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label10.Visible = true;
                    break;
                case ButtonState.Info11:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "WebGitホーム.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label11.Visible = true;
                    break;
                case ButtonState.Info12:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "ポートフォリオ.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label12.Visible = true;
                    break;
                case ButtonState.Info13:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "GitURL.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label13.Visible = true;
                    break;
                case ButtonState.Info14:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "クローン.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label14.Visible = true;
                    break;
                case ButtonState.Info15:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "クローン.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label15.Visible = true;
                    break;
                case ButtonState.Info16:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "クローン.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label16.Visible = true;
                    break;
                case ButtonState.Info17:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "クローン.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label17.Visible = true;
                    break;
                case ButtonState.Info18:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git変更.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label18.Visible = true;
                    break;
                case ButtonState.Info19:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "Git変更コメント.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label19.Visible = true;
                    break;
                case ButtonState.Info20:
                    pictureBox1.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "ポートフォリオ作成", "プルと同期.png"));
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    label20.Visible = true;
                    break;
            }
        }

        // 戻るボタン
        private void button3_Click(object sender, EventArgs e)
        {
            if(stateHistory.Count > 0)
            {
                buttonState = stateHistory.Pop();
                UpdateView();
                button1.Enabled = true; 
            }
            
        }
    }
}
